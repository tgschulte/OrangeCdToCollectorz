using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
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

        try
        {
          //using (StreamReader reader = StreamReader("my.xml", Encoding.UTF8, true))
          //{
          //  XmlSerializer serializer = new XmlSerializer(typeof(OrangeCd.Collection));

          //  object result = serializer.Deserialize(reader);
          //}
          //OrangeCdToCollectorz.Collection col = new Collection();

          var ser = new XmlSerializer(typeof(OrangeCdToCollectorz.Collection));

          OrangeCdToCollectorz.Collection orangeCdCollection;
          using (StreamReader reader = new StreamReader(file, Encoding.UTF8, true))
          //using (var reader = XmlReader.Create(file))
          {
            orangeCdCollection = (OrangeCdToCollectorz.Collection)ser.Deserialize(reader);
          }

          //richTextBox1.Text += "OrangeCd.Collection has " + orangeCdCollection.Albums.All.Album.Count.ToString() + " albums." + Environment.NewLine;
          richTextBox1.Text += "OrangeCd.Collection has " + orangeCdCollection.Albums.All.Length.ToString() + " albums." + Environment.NewLine;

          CollectorzMusic.Musicinfo collectorzMusic = new CollectorzMusic.Musicinfo();
          collectorzMusic.Creationdate = DateTime.Now.ToString("M/dd/yyyy hh:mm:ss tt");

          CollectorzMusic.Musiclist musiclist = new CollectorzMusic.Musiclist();
          musiclist.Music = new List<CollectorzMusic.Music>();

          foreach (CollectionAlbumsAlbum album in orangeCdCollection.Albums.All)
          //foreach (OrangeCd.Album album in orangeCdCollection.Albums.All.Album)
          {
            string format = string.Empty;
            CollectionAlbumsAlbumArtists collectionAlbumsAlbumArtists = new CollectionAlbumsAlbumArtists();

            for (int i = 0; i < album.Items.Length; i++)
            {
              switch (album.ItemsElementName[i])
              {
                case ItemsChoiceType2.Format:
                  format = album.Items[i].ToString();
                  break;
                case ItemsChoiceType2.ASIN:
                  // skipping ASIN
                  break;
                case ItemsChoiceType2.Artists:
                  // read artists
                  collectionAlbumsAlbumArtists = (CollectionAlbumsAlbumArtists)album.Items[i];
                  break;
                default:
                  richTextBox1.Text += "Error Importing from OrangeCd.Collection album " + album.ID + Environment.NewLine;
                  break;
              }
            }

            if ((format == "CD") || (format == "CDR") || (format == "LP"))
              {
                richTextBox1.Text += "Importing from OrangeCd.Collection " + format + Environment.NewLine; // + " " + album.Title + Environment.NewLine;
                CollectorzMusic.Music music = new CollectorzMusic.Music();

                // format
                CollectorzMusic.Format collectorzMusicFormat = new CollectorzMusic.Format();
                collectorzMusicFormat.Displayname = format;
                music.Format = collectorzMusicFormat;

                // artists
                music.Artists = new CollectorzMusic.Artists();
                if (collectionAlbumsAlbumArtists.Various == 1)
                {
                  CollectorzMusic.Artist  cArtist = new CollectorzMusic.Artist();
                  cArtist.Displayname = "Various Artists";
                  cArtist.Sortname = "Various Artists";
                  music.Artists.Artist = cArtist;
                }
                else
                {
                  // look up sort name, display name
                  music.Artists.Artist = new CollectorzMusic.Artist();
                  string sortname = collectionAlbumsAlbumArtists.Artist;
                  music.Artists.Artist.Displayname = sortname;

                  CollectionArtistsArtist collectionArtists = orangeCdCollection.Artists.Artist.FirstOrDefault(a => a.Name == sortname);

                  if (collectionArtists != null)
                  {
                    if (collectionArtists.SortName!=null)
                    {
                      sortname = collectionArtists.SortName;
                    }
                  }

                  music.Artists.Artist.Sortname = sortname;

                }

                musiclist.Music.Add(music);
              }
              else
              {
                richTextBox1.Text += "Skipping Importing from OrangeCd.Collection " + format + Environment.NewLine; // + " " + album.Title + Environment.NewLine;
              }

              //if (myChoices.ChoiceArray[i] == MoreChoices.Item)
              //  Console.WriteLine("Item: " + (string)myChoices.ManyChoices[i]);
              //else if (myChoices.ChoiceArray[i] == MoreChoices.Amount)
              //  Console.WriteLine("Amount: " + myChoices.ManyChoices[i].ToString());
              //if (myChoices.ChoiceArray[i] == MoreChoices.Temp)
              //  Console.WriteLine("Temp: " + (string)myChoices.ManyChoices[i].ToString());
            //}


            //album.Items[]
            //if ((album.Format == "CD") || (album.Format == "CDR") || (album.Format == "LP"))
            //{
            //  richTextBox1.Text += "Importing from OrangeCd.Collection " + album.Format + " " + album.Title + Environment.NewLine;

            //  CollectorzMusic.Artists cArtists = new CollectorzMusic.Artists();
            //  int index = 0;
            //  .
            //  if (album.Artists.Various == "1")
            //  {
            //    CollectorzMusic.Music music = new CollectorzMusic.Music();
            //    CollectorzMusic.Artist collectorzArtist = new CollectorzMusic.Artist();
            //    collectorzArtist.Displayname = "Various Artists";
            //    collectorzArtist.Sortname = "Various Artists";

            //    cArtists.Artist = collectorzArtist;
            //    music.Artists = cArtists;
            //    musiclist.Music.Add(music);
            //  }
            //  else
            //  {
            //    CollectorzMusic.Music music = new CollectorzMusic.Music();

            //    foreach (string orangeCdAlbumArtist in album.Artists)
            //    {
            //      string artist = orangeCdAlbumArtist.ToString();
            //      // todo: We are not finding the artist in the deserialized object, for instance: Album ID="504B700C9EEAF33B" 
            //      // music.Artistfirstletter.Displayname = orangeCdAlbumArtist.Name.Substring(0, 1);

            //      // default this property, in case we don't find something better in the OrangeCD Artists collection
            //      // music.Artistfirstletter.Sortname = orangeCdAlbumArtist.Name.Substring(0, 1);

            //      //if (album.Artists.Artist.Contains(orangeCdAlbumArtist))
            //      //{
            //      //  OrangeCd.Artist orangeCdAlbumFoundArtist = album.Artists.Artist.Find(t => t.Name == orangeCdAlbumArtist.Name);

            //      //  if (orangeCdAlbumFoundArtist.SortName != null)
            //      //  {
            //      //    music.Artistfirstletter.Sortname = orangeCdAlbumFoundArtist.SortName.Substring(0, 1);
            //      //  }
            //      //}
            //    }

            //    musiclist.Music.Add(music);
            //  }

            //}
            //else
            //{
            //  richTextBox1.Text += "Skipping Importing from OrangeCd.Collection " + album.Format + " " + album.Title + Environment.NewLine;
            //}
          }

          collectorzMusic.Musiclist = musiclist;

          // write output to a file
          richTextBox1.Text += "Writing output." + Environment.NewLine;
          XmlSerializer writer = new XmlSerializer(typeof(CollectorzMusic.Musicinfo));

          string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Collectorz.xml");
          FileStream fileStream = File.Create(path);

          writer.Serialize(fileStream, collectorzMusic);
          fileStream.Close();
          richTextBox1.Text += "Output written to." + path;

        }
        catch (XmlException xmlException)
        {
          // example: ' ', hexadecimal value 0x02, is an invalid character. Line 1282, position 23.
          // http://stackoverflow.com/questions/3102604/ignore-exceptions-that-cross-appdomains-when-debugging-in-visual-studio-2010
          // if this exception is not caught correctly, "There's an option in Visual Studio 2010 called "Break when exceptions cross AppDomain or managed/native boundaries (Managed only)" (under Debugging > General) that, when unchecked, sometimes helps. When it doesn't I need to quit Visual Studio 2010, delete all temporary files, and then try again. Not a very elegant solution, so if anyone have any better ideas, please provide them."
          richTextBox1.Text += xmlException.Message + Environment.NewLine;
          richTextBox1.Text += "This is invalid XML. According to the XML specification, all character references must be to characters which are valid. Valid characters are:" + Environment.NewLine;
          richTextBox1.Text += "#x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]" + Environment.NewLine;
          richTextBox1.Text += "Remove the offending characters and try again";
          ; // <-- For debugging use.
        }
        catch (IOException ioException)
        {
          richTextBox1.Text += ioException.Message + Environment.NewLine;
          ; // <-- For debugging use.
        }
        catch (Exception exception)
        {
          richTextBox1.Text += exception.Message + Environment.NewLine;
          ; // <-- For debugging use.
        }
      }
      // richTextBox1.Text = result.ToString(); // <-- For debugging use.
    }
  }
}
