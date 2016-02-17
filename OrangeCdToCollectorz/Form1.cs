using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace OrangeCdToCollectorz
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      const string testData = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<Collection Version=""1.0"">
	<Albums>
		<All>
			<Album ID=""CACDFB69814A4B2D"" Modified=""5192EB05"" Created=""5192EB06"" IsCompilation=""1"" Icon=""6"" Frames=""318975"" Time=""1:10:53"">
				<Artists Various=""1""/>
				<Title>Hava Narghile Vol. 1</Title>
				<Year>2001</Year>
				<Genres>
					<Genre>Folk, World, &amp; Country</Genre>
					<Genre>Rock</Genre>
				</Genres>
				<Category>rock</Category>
				<Format>CDR</Format>
				<Comment></Comment>
				<RefNo>V-00300</RefNo>
				<ReleaseDate Encoded=""65000000"">2001</ReleaseDate>
				<Label>Bacchus Archives</Label>
				<CatalogNo>BA1162</CatalogNo>
				<Country>US</Country>
				<Location>Avant-Garde: Violin</Location>
				<Musicians>
					<Credit>
						<Name>Suzy Splab</Name>
						<Role>Artwork</Role>
					</Credit>
					<Credit>
						<Name>Gökhan Aya</Name>
						<Role>Compilation Producer</Role>
					</Credit>
					<Credit>
						<Name>Jay Dobis</Name>
						<Role>Compilation Producer</Role>
					</Credit>
				</Musicians>
				<Volumes>
					<Volume ID=""EFA30400"" Frames=""318975"" Time=""1:10:53"">
						<Tracks>
							<Track Number=""01"" Frames=""10125"" Time=""2:15"">
								<Artist>Silûetler</Artist>
								<Title>Lorke Lorke</Title>
							</Track>
							<Track Number=""02"" Frames=""12150"" Time=""2:42"">
								<Artist>Kaygisizlar</Artist>
								<Title>Sasirdim (Short Circuit)</Title>
							</Track>
							<Track Number=""03"" Frames=""11250"" Time=""2:30"">
								<Artist>Mavi Isiklar</Artist>
								<Title>Iyi Düsün Tasin (For Your Information)</Title>
							</Track>
							<Track Number=""04"" Frames=""10800"" Time=""2:24"">
								<Artist>Haramiler</Artist>
								<Title>Çamlica Yolunda</Title>
							</Track>
							<Track Number=""05"" Frames=""18000"" Time=""4:00"">
								<Artist>Yabancilar</Artist>
								<Title>Agit</Title>
							</Track>
							<Track Number=""06"" Frames=""15375"" Time=""3:25"">
								<Artist>Apaslar</Artist>
								<Title>Gilgamis</Title>
							</Track>
							<Track Number=""07"" Frames=""11175"" Time=""2:29"">
								<Artist>Les Mogol</Artist>
								<Title>Hard Work</Title>
							</Track>
							<Track Number=""08"" Frames=""18300"" Time=""4:04"">
								<Artist>Erkin Koray</Artist>
								<Title>Anma Arkadas</Title>
							</Track>
							<Track Number=""09"" Frames=""12600"" Time=""2:48"">
								<Artist>Baris Manço &amp; Kaygisizlar</Artist>
								<Title>Flower Of Love</Title>
							</Track>
							<Track Number=""10"" Frames=""14850"" Time=""3:18"">
								<Artist>Erkut Taçkin &amp; Okan Dincer &amp; Kontrastlar</Artist>
								<Title>Mühür Gözlüm</Title>
							</Track>
							<Track Number=""11"" Frames=""22950"" Time=""5:06"">
								<Artist>Çagrisim</Artist>
								<Title>Divane Gönlüm</Title>
							</Track>
							<Track Number=""12"" Frames=""13875"" Time=""3:05"">
								<Artist>Baris Manço &amp; Kaygisizlar</Artist>
								<Title>Trip (Fairground)</Title>
							</Track>
							<Track Number=""13"" Frames=""16800"" Time=""3:44"">
								<Artist>Les Mogol</Artist>
								<Title>Berkay Oyun Havasi</Title>
							</Track>
							<Track Number=""14"" Frames=""13800"" Time=""3:04"">
								<Artist>Bunalim</Artist>
								<Title>Basak Saçlim</Title>
							</Track>
							<Track Number=""15"" Frames=""16500"" Time=""3:40"">
								<Artist>Üç Hürel</Artist>
								<Title>...Ve Olüm</Title>
							</Track>
							<Track Number=""16"" Frames=""17550"" Time=""3:54"">
								<Artist>Erkin Koray &amp; Ter</Artist>
								<Title>Hor Görme Garibi</Title>
							</Track>
							<Track Number=""17"" Frames=""15900"" Time=""3:32"">
								<Artist>Baris Manço</Artist>
								<Title>Ben Bilirim</Title>
							</Track>
							<Track Number=""18"" Frames=""12375"" Time=""2:45"">
								<Artist>Koray Oktay</Artist>
								<Title>Vefasiz Dost</Title>
							</Track>
							<Track Number=""19"" Frames=""13350"" Time=""2:58"">
								<Artist>Ersen</Artist>
								<Title>Sor Kendine</Title>
							</Track>
							<Track Number=""20"" Frames=""10425"" Time=""2:19"">
								<Artist>Melih Faruk Serdar Saygun</Artist>
								<Title>Gurbet Acisi</Title>
							</Track>
							<Track Number=""21"" Frames=""19800"" Time=""4:24"">
								<Artist>Erkin Koray</Artist>
								<Title>Saskin</Title>
							</Track>
							<Track Number=""22"" Frames=""11025"" Time=""2:27"">
								<Artist>Gökçen Kaynatan</Artist>
								<Title>Pencerenin Perdesini</Title>
							</Track>
						</Tracks>
					</Volume>
				</Volumes>
			</Album>
			<Album ID=""504B700C9EEAF33B"" Modified=""4B80B794"" Created=""4B80B794"" Icon=""1"" Frames=""128775"" Time=""28:37"">
				<Artists>
					<Artist>The Minds</Artist>
				</Artists>
				<Title>Plastic Girls</Title>
				<Year>2003</Year>
				<Genres></Genres>
				<Category>rock</Category>
				<Format>CD</Format>
				<RefNo>T-0340</RefNo>
				<ReleaseDate Encoded=""67000000"">2003</ReleaseDate>
				<Location>Avant-Garde: Violin</Location>
				<Volumes>
					<Volume ID=""75BB4B00"" Frames=""128775"" Time=""28:37"">
						<Tracks>
							<Track Number=""01"" Frames=""12610"" Time=""2:48"">
								<Title>Hot</Title>
							</Track>
							<Track Number=""02"" Frames=""12087"" Time=""2:41"">
								<Title>Lost In A Crowd</Title>
							</Track>
							<Track Number=""03"" Frames=""13833"" Time=""3:04"">
								<Title>Night Drive</Title>
							</Track>
							<Track Number=""04"" Frames=""7997"" Time=""1:46"">
								<Title>Forbidden Friend</Title>
							</Track>
							<Track Number=""05"" Frames=""10633"" Time=""2:21"">
								<Title>Don't Touch</Title>
							</Track>
							<Track Number=""06"" Frames=""9605"" Time=""2:08"">
								<Title>Plastic Girls</Title>
							</Track>
							<Track Number=""07"" Frames=""12040"" Time=""2:40"">
								<Title>Smash Smash Smash!</Title>
							</Track>
							<Track Number=""08"" Frames=""9937"" Time=""2:12"">
								<Title>Nerves</Title>
							</Track>
							<Track Number=""09"" Frames=""7120"" Time=""1:34"">
								<Title>Sensation</Title>
							</Track>
							<Track Number=""10"" Frames=""10733"" Time=""2:23"">
								<Title>Open The Door</Title>
							</Track>
							<Track Number=""11"" Frames=""12072"" Time=""2:40"">
								<Title>My Place (Adverts)</Title>
							</Track>
							<Track Number=""12"" Frames=""10108"" Time=""2:14"">
								<Title>Sex Vamp</Title>
							</Track>
						</Tracks>
					</Volume>
				</Volumes>
			</Album>
		</All>
	</Albums>
	<Artists Modified=""5185B3B0"">
		<Artist>
			<Name>Béla Bartók</Name>
			<SortName>Bela Bartok</SortName>
		</Artist>
		<Artist>
			<Name>Béla Fleck &amp; The Flecktones</Name>
			<SortName>Bela Fleck &amp; The Flecktones</SortName>
		</Artist>
		<Artist>
			<Name>Ceoltórí</Name>
			<SortName>Ceoltori</SortName>
		</Artist>
		<Artist>
			<Name>Die Doofen</Name>
			<SortName>Doofen, Die</SortName>
		</Artist>
		<Artist>
			<Name>Les Amis Creole</Name>
			<SortName>Amis Creole, Les</SortName>
		</Artist>
		<Artist>
			<Name>Los Activos</Name>
			<SortName>Activos, Los</SortName>
		</Artist>
		<Artist>
			<Name>Los Dug Dug's</Name>
			<SortName>Dug Dug's, Los</SortName>
		</Artist>
		<Artist>
			<Name>Los Peyotes</Name>
			<SortName>Peyotes, Los</SortName>
		</Artist>
		<Artist>
			<Name>Méav</Name>
			<SortName>Meav</SortName>
		</Artist>
		<Artist>
			<Name>The Minds</Name>
			<SortName>Minds, The</SortName>
		</Artist>
	</Artists>
	<Formats Modified=""4B4BF36D"">
		<Format>CD</Format>
		<Format>CDR</Format>
		<Format>2CD</Format>
		<Format>CD+DVD</Format>
		<Format>3&quot; CD</Format>
		<Format>5&quot; CD</Format>
		<Format>CD box set</Format>
		<Format>DVD</Format>
		<Format>MP3</Format>
		<Format>FLAC</Format>
	</Formats>
	<Categories Modified=""00000000"">
		<Category>blues</Category>
		<Category>classical</Category>
		<Category>country</Category>
		<Category>data</Category>
		<Category>folk</Category>
		<Category>jazz</Category>
		<Category>misc</Category>
		<Category>newage</Category>
		<Category>reggae</Category>
		<Category>rock</Category>
		<Category>soundtrack</Category>
	</Categories>
	<Genres Modified=""4B513A8A"">
		<Genre>A Cappella</Genre>
		<Genre>Acid</Genre>
		<Genre>Acid Jazz</Genre>
		<Genre>Vocal</Genre>
		<Genre>Xmas</Genre>
	</Genres>
	<Statuses Modified=""00000000"">
		<Status>Borrowed</Status>
		<Status>Heard</Status>
		<Status>Loaned</Status>
		<Status>Lost</Status>
		<Status>Ordered</Status>
		<Status>Owned</Status>
		<Status>Sold</Status>
		<Status>Want</Status>
	</Statuses>
	<Locations Modified=""556FB027"">
		<Location>Jazz: Experimental</Location>
		<Location>Avant-Garde: Violin</Location>
		<Location>Bluegrass/Old Timey: Instrumental</Location>
		<Location>Zappa &amp; Related</Location>
	</Locations>
	<Sources Modified=""00000000"">
		<Source>AM Radio</Source>
		<Source>Audience</Source>
		<Source>Bootleg</Source>
		<Source>FM Radio</Source>
		<Source>Internet Radio</Source>
		<Source>Official</Source>
		<Source>Soundtrack</Source>
		<Source>TV</Source>
	</Sources>
	<Generations Modified=""00000000"">
		<Generation>1st Gen</Generation>
		<Generation>2nd Gen</Generation>
		<Generation>3rd Gen</Generation>
		<Generation>4th Gen</Generation>
		<Generation>&gt;4th Gen</Generation>
		<Generation>Unknown</Generation>
	</Generations>
	<Qualities Modified=""00000000"">
		<Quality>Excellent</Quality>
		<Quality>Good</Quality>
		<Quality>Listenable</Quality>
	</Qualities>
	<Conditions Modified=""00000000"">
		<Condition>Acceptable</Condition>
		<Condition>Good</Condition>
		<Condition>Excellent</Condition>
		<Condition>Mint</Condition>
		<Condition>Sealed</Condition>
	</Conditions>
	<Packagings Modified=""00000000"">
		<Packaging>CD case</Packaging>
		<Packaging>Slim CD case</Packaging>
		<Packaging>Super CD case</Packaging>
		<Packaging>Double CD case</Packaging>
		<Packaging>DVD case</Packaging>
		<Packaging>Digipak</Packaging>
		<Packaging>Sleeve</Packaging>
	</Packagings>
</Collection>";

      XmlSerializer serializer = new XmlSerializer(typeof(OrangeCd.Collection));
      using (TextReader reader = new StringReader(testData))
      {
        OrangeCd.Collection orangeCd = (OrangeCd.Collection)serializer.Deserialize(reader);
      }

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
            XmlDocument _Doc = new XmlDocument();
            _Doc.Load(file);

            XmlSerializer deserializer = new XmlSerializer(typeof(OrangeCd.Collection));
            using (TextReader textReader = new StringReader(_Doc.OuterXml))
            {
              OrangeCd.Collection XmlData = (OrangeCd.Collection)deserializer.Deserialize(textReader);
            }

            ser = new XmlSerializer(typeof(OrangeCd.Collection));
            wrapper = (OrangeCd.Collection)ser.Deserialize(new StringReader(_Doc.OuterXml));


            //ser = new XmlSerializer(typeof(OrangeCd.Collection));
            //wrapper = (OrangeCd.Collection)ser.Deserialize(new StringReader(_Doc.OuterXml));

            //_Doc = new XmlDocument();
            //_Doc.Load(file);
            //ser = new XmlSerializer(typeof(OrangeCd.Collection));
            //wrapper = (OrangeCd.Collection)ser.Deserialize(new XmlNodeReader(_Doc.DocumentElement));
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
