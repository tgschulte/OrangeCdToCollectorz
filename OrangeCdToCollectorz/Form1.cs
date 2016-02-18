using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace OrangeCdToCollectorz
{
  internal partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Show the dialog and get result.
      DialogResult result = openFileDialog1.ShowDialog();
      if (result == DialogResult.OK) // Test result.
      {
        string file = openFileDialog1.FileName;
        richTextBox1.Text = "Loading file " + file + Environment.NewLine;

        OrangeCd.Collection orangeCdCollection;
        try
        {
          var ser = new XmlSerializer(typeof(OrangeCd.Collection));
          using (var reader = XmlReader.Create(file))
          {
            orangeCdCollection = (OrangeCd.Collection)ser.Deserialize(reader);
          }

          richTextBox1.Text += "OrangeCd.Collection has " + orangeCdCollection.Albums.All.Album.Count.ToString() + " albums." + Environment.NewLine;

          CollectorzMusic.Musicinfo collectorzMusic = new CollectorzMusic.Musicinfo();
          collectorzMusic.Creationdate = DateTime.Now.ToString("M/dd/yyyy hh:mm:ss tt");

          CollectorzMusic.Musiclist musiclist = new CollectorzMusic.Musiclist();
          musiclist.Music = new List<CollectorzMusic.Music>();

          foreach (OrangeCd.Album album in orangeCdCollection.Albums.All.Album)
          {
            if ((album.Format == "CD") || (album.Format == "CDR") || (album.Format == "LP"))
            {
              richTextBox1.Text += "Importing from OrangeCd.Collection " + album.Format + " " + album.Title + Environment.NewLine;

              CollectorzMusic.Artists cArtists = new CollectorzMusic.Artists();
              int index = 0;

              if (album.Artists.Various == "1")
              {
                CollectorzMusic.Music music = new CollectorzMusic.Music();
                CollectorzMusic.Artist collectorzArtist = new CollectorzMusic.Artist();
                collectorzArtist.Displayname = "Various Artists";
                collectorzArtist.Sortname = "Various Artists";

                cArtists.Artist = collectorzArtist;
                music.Artists = cArtists;
                musiclist.Music.Add(music);
              }
              else
              {
                CollectorzMusic.Music music = new CollectorzMusic.Music();

                foreach (OrangeCd.Artist orangeCdAlbumArtist in album.Artists.Artist)
                {
                  // todo: We are not finding the artist in the deserialized object, for instance: Album ID="504B700C9EEAF33B" 
                  music.Artistfirstletter.Displayname = orangeCdAlbumArtist.Name.Substring(0, 1);
                  
                  // default this property, in case we don't find something better in the OrangeCD Artists collection
                  music.Artistfirstletter.Sortname = orangeCdAlbumArtist.Name.Substring(0, 1);

                  if (album.Artists.Artist.Contains(orangeCdAlbumArtist))
                  {
                    OrangeCd.Artist orangeCdAlbumFoundArtist = album.Artists.Artist.Find(t => t.Name == orangeCdAlbumArtist.Name);

                    if (orangeCdAlbumFoundArtist.SortName != null)
                    {
                      music.Artistfirstletter.Sortname = orangeCdAlbumFoundArtist.SortName.Substring(0, 1);
                    }
                  }

                }

                musiclist.Music.Add(music);
              }

            }
            else
            {
              richTextBox1.Text += "Skipping Importing from OrangeCd.Collection " + album.Format + " " + album.Title + Environment.NewLine;
            }
          }

          // write output to a file
          richTextBox1.Text += "Writing output." + Environment.NewLine;
          XmlSerializer writer = new XmlSerializer(typeof(CollectorzMusic.Musicinfo));

          string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Collectorz.xml");
          FileStream fileStream = File.Create(path);

          writer.Serialize(fileStream, collectorzMusic);
          fileStream.Close();
          richTextBox1.Text += "Output written to." + path;

        }
        catch (IOException ioException)
        {
          richTextBox1.Text += ioException.Message + Environment.NewLine; ; // <-- For debugging use.
        }
        catch (Exception exception)
        {
          richTextBox1.Text += exception.Message + Environment.NewLine; ; // <-- For debugging use.
        }
      }
      // richTextBox1.Text = result.ToString(); // <-- For debugging use.
    }
  }
}
