using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using System.Xml.Serialization;

namespace OrangeCdToCollectorz
{
  internal partial class Form1 : Form
  {
    string _lastPoprerty = string.Empty;
    string _file = string.Empty;
    CollectorzMusic.Musicinfo collectorzMusic = new CollectorzMusic.Musicinfo();


    // This delegate enables asynchronous calls for setting  
    // the text property on a TextBox control.  
    delegate void SetTextCallback(RichTextBox label, string text);

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      DialogResult result = openFileDialog1.ShowDialog();
      if (result == DialogResult.OK) // Test result.
      {
        this._file = openFileDialog1.FileName;
        richTextBox1.Text = "Loading file " + this._file + Environment.NewLine;
        progressBar1.Maximum = 100;
        progressBar1.Step = 1;
        progressBar1.Value = 0;
        backgroundWorker1.WorkerReportsProgress = true;
        backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
        backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
    backgroundWorker1.RunWorkerAsync();
      }
      else
      {
        richTextBox1.Text = result.ToString(); // <-- For debugging use.
      }
    }

    private void Form1_Load(object sender, System.EventArgs e)
    {
      // Start the BackgroundWorker.
      backgroundWorker1.RunWorkerAsync();
    }

    private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.progressBar1.Value = e.ProgressPercentage;
      this.progressBar1.Update();
    }

    private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      // write output to a file
      richTextBox1.Text += "Writing output." + Environment.NewLine;
      XmlSerializer writer = new XmlSerializer(typeof(CollectorzMusic.Musicinfo));

      string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Collectorz.xml");
      FileStream fileStream = File.Create(path);

      writer.Serialize(fileStream, collectorzMusic);
      fileStream.Close();
      this.SetText(this.richTextBox1, "Output for importing written to." + path);

      //richTextBox1.Text += "Output for importing written to." + path;
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      var backgroundWorker = sender as BackgroundWorker;      // Show the dialog and get result.

      try
      {
        var ser = new XmlSerializer(typeof(Collection));
        Collection orangeCdCollection;
        using (StreamReader reader = new StreamReader(this._file, Encoding.UTF8, true))
        {
          orangeCdCollection = (OrangeCdToCollectorz.Collection)ser.Deserialize(reader);
        }

        int albumCnt = orangeCdCollection.Albums.All.Length;
        this.SetText(this.richTextBox1, "OrangeCd.Collection has " + albumCnt.ToString() + " albums." + Environment.NewLine);

        //richTextBox1.Text += "OrangeCd.Collection has " + albumCnt.ToString() + " albums." + Environment.NewLine;
        int cnt = 0;

        collectorzMusic.Creationdate = DateTime.Now.ToString("M/dd/yyyy hh:mm:ss tt");

        CollectorzMusic.Musiclist musiclist = new CollectorzMusic.Musiclist();
        musiclist.Music = new List<CollectorzMusic.Music>();

        foreach (CollectionAlbumsAlbum album in orangeCdCollection.Albums.All)
        {
          cnt++;
          //int progress = 100 * (int)((double)cnt / albumCnt);
          double progress = cnt *100.0 / albumCnt;
          backgroundWorker.ReportProgress((int)progress);
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
                this._lastPoprerty = "Year";
                if (releaseYear == 0)
                {
                  // format is ushort 
                  int.TryParse(album.Items[i].ToString(), out releaseYear);
                }
                break;
              case ItemsChoiceType2.UPC:
                this._lastPoprerty = "UPC";
                upc = album.Items[i].ToString();
                break;
              case ItemsChoiceType2.Title:
                this._lastPoprerty = "Title";
                title = album.Items[i].ToString();
                break;
              case ItemsChoiceType2.Status:
                // skipping 
                break;
              case ItemsChoiceType2.ReleaseDate:
                this._lastPoprerty = "ReleaseDate";
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
                this._lastPoprerty = "Location";
                location = album.Items[i].ToString();
                break;
              case ItemsChoiceType2.Label:
                this._lastPoprerty = "Label";
                label = album.Items[i].ToString();
                break;
              case ItemsChoiceType2.Genres:
                this._lastPoprerty = "Genres";
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
                this._lastPoprerty = "FreeDBComment";
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
                this._lastPoprerty = "Comment";
                comment += album.Items[i].ToString();
                break;
              case ItemsChoiceType2.Category:
                this._lastPoprerty = "Category";

                if (genres.Genre == null)
                {
                  genres.Genre = new CollectorzMusic.Genre();
                }

                genres.Genre.Displayname = album.Items[i].ToString();
                break;
              case ItemsChoiceType2.Format:
                this._lastPoprerty = "Format";
                format = album.Items[i].ToString();
                break;
              case ItemsChoiceType2.CatalogNo:
                this._lastPoprerty = "CatalogNo";
                labelnumber = album.Items[i].ToString();
                break;
              case ItemsChoiceType2.ASIN:
                // skipping ASIN
                break;
              case ItemsChoiceType2.Artists:
                this._lastPoprerty = "Artists";
                collectionAlbumsAlbumArtists = (CollectionAlbumsAlbumArtists)album.Items[i];
                break;
              default:
                this.SetText(this.richTextBox1, "Error extracting property '" + album.ItemsElementName[i] + "' from OrangeCd.Collection album " + album.ID + Environment.NewLine);

                //richTextBox1.Text += "Error extracting property '" + album.ItemsElementName[i] + "' from OrangeCd.Collection album " + album.ID + Environment.NewLine;
                break;
            }
          }

          if ((format == "CD") || (format == "CDR") || (format == "LP"))
          {
            this.SetText(this.richTextBox1, cnt.ToString() + " Extracting album'" + title + "' from OrangeCd.Collection " + format + Environment.NewLine);

            //richTextBox1.Text += cnt.ToString() + " Extracting album'" + title + "' from OrangeCd.Collection " + format + Environment.NewLine; // + " " + album.Title + Environment.NewLine;
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
            this.SetText(this.richTextBox1, cnt.ToString() + " Skipping extracting album '" + title + "' from OrangeCd.Collection with format " + format + Environment.NewLine);

            //richTextBox1.Text += cnt.ToString() + " Skipping extracting album '" + title + "' from OrangeCd.Collection with format " + format + Environment.NewLine; // + " " + album.Title + Environment.NewLine;
          }
        }


        collectorzMusic.Musiclist = musiclist;

      }
      catch (XmlException xmlException)
      {
        // example: ' ', hexadecimal value 0x02, is an invalid character. Line 1282, position 23.
        // http://stackoverflow.com/questions/3102604/ignore-exceptions-that-cross-appdomains-when-debugging-in-visual-studio-2010
        // if this exception is not caught correctly, "There's an option in Visual Studio 2010 called "Break when exceptions cross AppDomain or managed/native boundaries (Managed only)" (under Debugging > General) that, when unchecked, sometimes helps. When it doesn't I need to quit Visual Studio 2010, delete all temporary files, and then try again. Not a very elegant solution, so if anyone have any better ideas, please provide them."
        // richTextBox1.Text += xmlException.Message + Environment.NewLine;
        this.SetText(this.richTextBox1, "This is invalid XML. According to the XML specification, all character references must be to characters which are valid. Valid characters are:" + Environment.NewLine);

        //richTextBox1.Text += "This is invalid XML. According to the XML specification, all character references must be to characters which are valid. Valid characters are:" + Environment.NewLine;
        //richTextBox1.Text += "#x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]" + Environment.NewLine;
        //richTextBox1.Text += "Remove the offending characters and try again";
        ; // <-- For debugging use.
      }
      catch (IOException ioException)
      {
        this.SetText(this.richTextBox1, ioException.Message + Environment.NewLine);

        //richTextBox1.Text += ioException.Message + Environment.NewLine;
        ; // <-- For debugging use.
      }
      catch (Exception exception)
      {
        this.SetText(this.richTextBox1, exception.Message + " lastPoprerty: " + this._lastPoprerty + Environment.NewLine);

        //richTextBox1.Text += exception.Message + " lastPoprerty: " + this._lastPoprerty + Environment.NewLine;
        ; // <-- For debugging use.
      }
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
      richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
      richTextBox1.ScrollToCaret(); //Now scroll it automatically
    }

    // This method demonstrates a pattern for making thread-safe
    // calls on a Windows Forms control. 
    //
    // If the calling thread is different from the thread that
    // created the TextBox control, this method creates a
    // SetTextCallback and calls itself asynchronously using the
    // Invoke method.
    //
    // If the calling thread is the same as the thread that created
    // the TextBox control, the Text property is set directly. 
    private void SetText(RichTextBox label, string text)
    {
      // InvokeRequired required compares the thread ID of the
      // calling thread to the thread ID of the creating thread.
      // If these threads are different, it returns true.
      if (label.InvokeRequired)
      {
        SetTextCallback d = new SetTextCallback(SetText);
        this.Invoke(d, new object[] { label, text });
      }
      else
      {
        label.Text += text;
      }
    }
  }
}
