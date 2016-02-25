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
            string comment = string.Empty;
            string labelnumber = string.Empty;
            string location = string.Empty;
            string upc = string.Empty;
            string title = string.Empty;
            string label = string.Empty;
            string releaseDateStr = string.Empty;
            int releaseYear = 0; ;
            CollectionAlbumsAlbumArtists collectionAlbumsAlbumArtists = new CollectionAlbumsAlbumArtists();
            CollectorzMusic.Genres genres = new CollectorzMusic.Genres();

            for (int i = 0; i < album.Items.Length; i++)
            {
              switch (album.ItemsElementName[i])
              {
                case ItemsChoiceType2.Volumes:
                // skipping 
                case ItemsChoiceType2.Year:
                  if (releaseYear == 0)
                  {
                    // format is ushort 
                    releaseYear = (ushort)album.Items[i];
                  }
                  break;
                case ItemsChoiceType2.UPC:
                  upc = album.Items[i].ToString();
                  break;
                case ItemsChoiceType2.Title:
                  title = album.Items[i].ToString();
                  break;
                case ItemsChoiceType2.Status:
                  // skipping 
                  break;
                case ItemsChoiceType2.ReleaseDate:
                  CollectionAlbumsAlbumReleaseDate collectionAlbumsAlbumReleaseDate = (CollectionAlbumsAlbumReleaseDate)album.Items[i];
                  releaseDateStr = collectionAlbumsAlbumReleaseDate.Value;

                  if (int.TryParse(collectionAlbumsAlbumReleaseDate.Value, out releaseYear) == false)
                  {
                    DateTime releaseDate;
                    if (DateTime.TryParse(collectionAlbumsAlbumReleaseDate.Value, out releaseDate))
                    {
                      releaseYear = releaseDate.Year;
                    }
                  }
                  break;
                case ItemsChoiceType2.ReissueDate:
                  // skipping 
                  break;
                case ItemsChoiceType2.RefNo:
                  // skipping 
                  break;
                case ItemsChoiceType2.Production:
                  // skipping 
                  break;
                case ItemsChoiceType2.Path:
                  // skipping 
                  break;
                case ItemsChoiceType2.Musicians:
                  // skipping 
                  break;
                case ItemsChoiceType2.ReissueLabel:
                  // skipping 
                  break;
                case ItemsChoiceType2.Location:
                  location = album.Items[i].ToString();
                  break;
                case ItemsChoiceType2.Label:
                  label = album.Items[i].ToString();
                  break;
                case ItemsChoiceType2.Genres:
                  //     [System.Xml.Serialization.XmlElementAttribute("Genres", typeof(CollectionAlbumsAlbumGenres))]
                  CollectionAlbumsAlbumGenres ocdGenres = (CollectionAlbumsAlbumGenres)album.Items[i];

                  if (ocdGenres.Genre != null)
                  {
                    if (genres.Genre == null)
                    {
                      genres.Genre = new CollectorzMusic.Genre();
                    }

                    genres.Genre.Displayname = ocdGenres.Genre[0];
                  }

                  break;
                case ItemsChoiceType2.FreeDBComment:
                  comment += album.Items[i].ToString();
                  break;
                case ItemsChoiceType2.Credits:
                  // skipping 
                  break;
                case ItemsChoiceType2.Country:
                  // skipping 
                  break;
                case ItemsChoiceType2.Composers:
                  // skipping 
                  break;
                case ItemsChoiceType2.Company:
                  // skipping 
                  break;
                case ItemsChoiceType2.Comment:
                  comment += album.Items[i].ToString();
                  break;
                case ItemsChoiceType2.Category:

                  if (genres.Genre == null)
                  {
                    genres.Genre = new CollectorzMusic.Genre();
                  }

                  genres.Genre.Displayname = album.Items[i].ToString();
                  break;
                case ItemsChoiceType2.Format:
                  format = album.Items[i].ToString();
                  break;
                case ItemsChoiceType2.CatalogNo:
                  labelnumber = album.Items[i].ToString();
                  break;
                case ItemsChoiceType2.ASIN:
                  // skipping ASIN
                  break;
                case ItemsChoiceType2.Artists:
                  // read artists
                  collectionAlbumsAlbumArtists = (CollectionAlbumsAlbumArtists)album.Items[i];
                  break;
                default:
                  richTextBox1.Text += "Error extracting property '" + album.ItemsElementName[i] + "' from OrangeCd.Collection album " + album.ID + Environment.NewLine;
                  break;
              }
            }

            if ((format == "CD") || (format == "CDR") || (format == "LP"))
            {
              richTextBox1.Text += "Extracting from OrangeCd.Collection " + format + Environment.NewLine; // + " " + album.Title + Environment.NewLine;
              CollectorzMusic.Music music = new CollectorzMusic.Music();

              // Title 
              music.Title = title;

              // release date
              if (string.IsNullOrEmpty(releaseDateStr) == false)
              {
                music.Releasedate = new CollectorzMusic.Releasedate();
                music.Releasedate.Date = releaseDateStr;

                if (releaseYear > 0)
                {
                  music.Releasedate.Year = new CollectorzMusic.Year();
                  music.Releasedate.Year.Displayname = releaseYear.ToString();
                }
              }

              music.Upc = upc;

              // Location 
              if (location != string.Empty)
              {
                music.Location = new CollectorzMusic.Location();
                music.Location.Displayname = location;
                music.Location.Sortname = location;
              }

              // label
              if (label != string.Empty)
              {
                music.Label = new CollectorzMusic.Label();
                music.Label.Displayname = label;
                music.Label.Sortname = label;
              }

              // Notes
              music.Notes = comment;

              // genre
              music.Genres = genres;

              // cat. no.
              music.Labelnumber = labelnumber;

              // format
              CollectorzMusic.Format collectorzMusicFormat = new CollectorzMusic.Format();
              collectorzMusicFormat.Displayname = format;
              music.Format = collectorzMusicFormat;

              // artists
              music.Artists = new CollectorzMusic.Artists();
              if (collectionAlbumsAlbumArtists.Various == 1)
              {
                CollectorzMusic.Artist cArtist = new CollectorzMusic.Artist();
                cArtist.Displayname = "Various Artists";
                cArtist.Sortname = "Various Artists";
                music.Artistfirstletter = new CollectorzMusic.Artistfirstletter();
                music.Artistfirstletter.Displayname = "Various Artists";
                music.Artistfirstletter.Sortname = "Various Artists";
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
                  if (collectionArtists.SortName != null)
                  {
                    sortname = collectionArtists.SortName;
                  }
                }

                music.Artists.Artist.Sortname = sortname;

                music.Artistfirstletter = new CollectorzMusic.Artistfirstletter();
                music.Artistfirstletter.Displayname = music.Artists.Artist.Displayname;
                music.Artistfirstletter.Sortname = music.Artists.Artist.Sortname;
              }

              musiclist.Music.Add(music);
            }
            else
            {
              richTextBox1.Text += "Skipping extracting album from OrangeCd.Collection with format " + format + Environment.NewLine; // + " " + album.Title + Environment.NewLine;
            }
          }

          collectorzMusic.Musiclist = musiclist;

          // write output to a file
          richTextBox1.Text += "Writing output." + Environment.NewLine;
          XmlSerializer writer = new XmlSerializer(typeof(CollectorzMusic.Musicinfo));

          string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Collectorz.xml");
          FileStream fileStream = File.Create(path);

          writer.Serialize(fileStream, collectorzMusic);
          fileStream.Close();
          richTextBox1.Text += "Output for importing written to." + path;

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
