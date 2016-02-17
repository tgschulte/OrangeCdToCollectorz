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
        try
        {
          var ser = new XmlSerializer(typeof(OrangeCd.Collection));
          using (var reader = XmlReader.Create(file))
          {
            var wrapper = (OrangeCd.Collection)ser.Deserialize(reader);
          }
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
