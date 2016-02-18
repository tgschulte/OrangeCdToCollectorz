using System;
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

          // write output to a file
          richTextBox1.Text += "Writing output." + Environment.NewLine;
          System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(CollectorzMusic.Musicinfo));

          string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Collectorz.xml");
          FileStream fileStream = File.Create(path);

          writer.Serialize(fileStream, collectorzMusic);
          fileStream.Close();
          richTextBox1.Text += "Output written to." + path;

        }
        catch (IOException ioException)
        {
          Console.WriteLine(ioException.Message); // <-- For debugging use.
        }
      }
      Console.WriteLine(result); // <-- For debugging use.
    }
  }
}
