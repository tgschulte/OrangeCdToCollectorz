namespace OrangeCdToCollectorz
{

  /// <remarks/>
  /// Made natively in Visual Studio 2012 by Paste Special with XML: http://www.c-sharpcorner.com/blogs/paste-xml-as-c-sharp-classes-in-vs-2012
  /// Can't be internal: "OrangeCdToCollectorz.Collection is inaccessible due to its protection level. Only public types can be processed."
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
  // ReSharper disable once MemberCanBeInternal
  public sealed class Collection
  {

    private CollectionAlbums albumsField;

    private CollectionArtists artistsField;

    private CollectionFormats formatsField;

    private CollectionCategories categoriesField;

    private CollectionGenres genresField;

    private CollectionStatuses statusesField;

    private CollectionLocations locationsField;

    private CollectionSources sourcesField;

    private CollectionGenerations generationsField;

    private CollectionQualities qualitiesField;

    private CollectionConditions conditionsField;

    private CollectionPackagings packagingsField;

    private decimal versionField;

    /// <remarks/>
    public CollectionAlbums Albums
    {
      get
      {
        return this.albumsField;
      }
      set
      {
        this.albumsField = value;
      }
    }

    /// <remarks/>
    public CollectionArtists Artists
    {
      get
      {
        return this.artistsField;
      }
      set
      {
        this.artistsField = value;
      }
    }

    /// <remarks/>
    public CollectionFormats Formats
    {
      get
      {
        return this.formatsField;
      }
      set
      {
        this.formatsField = value;
      }
    }

    /// <remarks/>
    public CollectionCategories Categories
    {
      get
      {
        return this.categoriesField;
      }
      set
      {
        this.categoriesField = value;
      }
    }

    /// <remarks/>
    public CollectionGenres Genres
    {
      get
      {
        return this.genresField;
      }
      set
      {
        this.genresField = value;
      }
    }

    /// <remarks/>
    public CollectionStatuses Statuses
    {
      get
      {
        return this.statusesField;
      }
      set
      {
        this.statusesField = value;
      }
    }

    /// <remarks/>
    public CollectionLocations Locations
    {
      get
      {
        return this.locationsField;
      }
      set
      {
        this.locationsField = value;
      }
    }

    /// <remarks/>
    public CollectionSources Sources
    {
      get
      {
        return this.sourcesField;
      }
      set
      {
        this.sourcesField = value;
      }
    }

    /// <remarks/>
    public CollectionGenerations Generations
    {
      get
      {
        return this.generationsField;
      }
      set
      {
        this.generationsField = value;
      }
    }

    /// <remarks/>
    public CollectionQualities Qualities
    {
      get
      {
        return this.qualitiesField;
      }
      set
      {
        this.qualitiesField = value;
      }
    }

    /// <remarks/>
    public CollectionConditions Conditions
    {
      get
      {
        return this.conditionsField;
      }
      set
      {
        this.conditionsField = value;
      }
    }

    /// <remarks/>
    public CollectionPackagings Packagings
    {
      get
      {
        return this.packagingsField;
      }
      set
      {
        this.packagingsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Version
    {
      get
      {
        return this.versionField;
      }
      set
      {
        this.versionField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbums
  {

    private CollectionAlbumsAlbum[] allField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Album", IsNullable = false)]
    public CollectionAlbumsAlbum[] All
    {
      get
      {
        return this.allField;
      }
      set
      {
        this.allField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbum
  {

    private object[] itemsField;

    private ItemsChoiceType2[] itemsElementNameField;

    private string idField;

    private string modifiedField;

    private string createdField;

    private uint framesField;

    private bool framesFieldSpecified;

    private string timeField;

    private byte isCompilationField;

    private bool isCompilationFieldSpecified;

    private byte iconField;

    private bool iconFieldSpecified;

    private byte isClassicalField;

    private bool isClassicalFieldSpecified;

    private string cDDBIDField;

    private string mCIIDField;

    private byte isPromoField;

    private bool isPromoFieldSpecified;

    private byte isBootlegField;

    private bool isBootlegFieldSpecified;

    private byte isSingleField;

    private bool isSingleFieldSpecified;

    private byte isSoundtrackField;

    private bool isSoundtrackFieldSpecified;

    private byte isRareField;

    private bool isRareFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ASIN", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Artists", typeof(CollectionAlbumsAlbumArtists))]
    [System.Xml.Serialization.XmlElementAttribute("CatalogNo", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Category", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Comment", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Company", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Composers", typeof(CollectionAlbumsAlbumComposers))]
    [System.Xml.Serialization.XmlElementAttribute("Country", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Credits", typeof(CollectionAlbumsAlbumCredits))]
    [System.Xml.Serialization.XmlElementAttribute("Format", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("FreeDBComment", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Genres", typeof(CollectionAlbumsAlbumGenres))]
    [System.Xml.Serialization.XmlElementAttribute("Label", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Location", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Musicians", typeof(CollectionAlbumsAlbumMusicians))]
    [System.Xml.Serialization.XmlElementAttribute("Path", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Production", typeof(CollectionAlbumsAlbumProduction))]
    [System.Xml.Serialization.XmlElementAttribute("RefNo", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("ReissueDate", typeof(CollectionAlbumsAlbumReissueDate))]
    [System.Xml.Serialization.XmlElementAttribute("ReissueLabel", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("ReleaseDate", typeof(CollectionAlbumsAlbumReleaseDate))]
    [System.Xml.Serialization.XmlElementAttribute("Status", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Title", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("UPC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Volumes", typeof(CollectionAlbumsAlbumVolumes))]
    [System.Xml.Serialization.XmlElementAttribute("Year", typeof(ushort))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType2[] ItemsElementName
    {
      get
      {
        return this.itemsElementNameField;
      }
      set
      {
        this.itemsElementNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Created
    {
      get
      {
        return this.createdField;
      }
      set
      {
        this.createdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint Frames
    {
      get
      {
        return this.framesField;
      }
      set
      {
        this.framesField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FramesSpecified
    {
      get
      {
        return this.framesFieldSpecified;
      }
      set
      {
        this.framesFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Time
    {
      get
      {
        return this.timeField;
      }
      set
      {
        this.timeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte IsCompilation
    {
      get
      {
        return this.isCompilationField;
      }
      set
      {
        this.isCompilationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsCompilationSpecified
    {
      get
      {
        return this.isCompilationFieldSpecified;
      }
      set
      {
        this.isCompilationFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Icon
    {
      get
      {
        return this.iconField;
      }
      set
      {
        this.iconField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IconSpecified
    {
      get
      {
        return this.iconFieldSpecified;
      }
      set
      {
        this.iconFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte IsClassical
    {
      get
      {
        return this.isClassicalField;
      }
      set
      {
        this.isClassicalField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsClassicalSpecified
    {
      get
      {
        return this.isClassicalFieldSpecified;
      }
      set
      {
        this.isClassicalFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CDDBID
    {
      get
      {
        return this.cDDBIDField;
      }
      set
      {
        this.cDDBIDField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MCIID
    {
      get
      {
        return this.mCIIDField;
      }
      set
      {
        this.mCIIDField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte IsPromo
    {
      get
      {
        return this.isPromoField;
      }
      set
      {
        this.isPromoField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsPromoSpecified
    {
      get
      {
        return this.isPromoFieldSpecified;
      }
      set
      {
        this.isPromoFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte IsBootleg
    {
      get
      {
        return this.isBootlegField;
      }
      set
      {
        this.isBootlegField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsBootlegSpecified
    {
      get
      {
        return this.isBootlegFieldSpecified;
      }
      set
      {
        this.isBootlegFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte IsSingle
    {
      get
      {
        return this.isSingleField;
      }
      set
      {
        this.isSingleField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsSingleSpecified
    {
      get
      {
        return this.isSingleFieldSpecified;
      }
      set
      {
        this.isSingleFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte IsSoundtrack
    {
      get
      {
        return this.isSoundtrackField;
      }
      set
      {
        this.isSoundtrackField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsSoundtrackSpecified
    {
      get
      {
        return this.isSoundtrackFieldSpecified;
      }
      set
      {
        this.isSoundtrackFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte IsRare
    {
      get
      {
        return this.isRareField;
      }
      set
      {
        this.isRareField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IsRareSpecified
    {
      get
      {
        return this.isRareFieldSpecified;
      }
      set
      {
        this.isRareFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumArtists
  {

    private string artistField;

    private byte variousField;

    private bool variousFieldSpecified;

    /// <remarks/>
    public string Artist
    {
      get
      {
        return this.artistField;
      }
      set
      {
        this.artistField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Various
    {
      get
      {
        return this.variousField;
      }
      set
      {
        this.variousField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VariousSpecified
    {
      get
      {
        return this.variousFieldSpecified;
      }
      set
      {
        this.variousFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumComposers
  {

    private string composerField;

    private byte variousField;

    private bool variousFieldSpecified;

    /// <remarks/>
    public string Composer
    {
      get
      {
        return this.composerField;
      }
      set
      {
        this.composerField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Various
    {
      get
      {
        return this.variousField;
      }
      set
      {
        this.variousField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool VariousSpecified
    {
      get
      {
        return this.variousFieldSpecified;
      }
      set
      {
        this.variousFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumCredits
  {

    private CollectionAlbumsAlbumCreditsCredit[] creditField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Credit")]
    public CollectionAlbumsAlbumCreditsCredit[] Credit
    {
      get
      {
        return this.creditField;
      }
      set
      {
        this.creditField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumCreditsCredit
  {

    private string nameField;

    private string roleField;

    /// <remarks/>
    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public string Role
    {
      get
      {
        return this.roleField;
      }
      set
      {
        this.roleField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumGenres
  {

    private string[] genreField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Genre")]
    public string[] Genre
    {
      get
      {
        return this.genreField;
      }
      set
      {
        this.genreField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumMusicians
  {

    private CollectionAlbumsAlbumMusiciansCredit[] creditField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Credit")]
    public CollectionAlbumsAlbumMusiciansCredit[] Credit
    {
      get
      {
        return this.creditField;
      }
      set
      {
        this.creditField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumMusiciansCredit
  {

    private string nameField;

    private string roleField;

    /// <remarks/>
    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public string Role
    {
      get
      {
        return this.roleField;
      }
      set
      {
        this.roleField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumProduction
  {

    private CollectionAlbumsAlbumProductionCredit[] creditField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Credit")]
    public CollectionAlbumsAlbumProductionCredit[] Credit
    {
      get
      {
        return this.creditField;
      }
      set
      {
        this.creditField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumProductionCredit
  {

    private string nameField;

    private string roleField;

    /// <remarks/>
    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public string Role
    {
      get
      {
        return this.roleField;
      }
      set
      {
        this.roleField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumReissueDate
  {

    private string encodedField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Encoded
    {
      get
      {
        return this.encodedField;
      }
      set
      {
        this.encodedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumReleaseDate
  {

    private string encodedField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Encoded
    {
      get
      {
        return this.encodedField;
      }
      set
      {
        this.encodedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumVolumes
  {

    private CollectionAlbumsAlbumVolumesVolume[] volumeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Volume")]
    public CollectionAlbumsAlbumVolumesVolume[] Volume
    {
      get
      {
        return this.volumeField;
      }
      set
      {
        this.volumeField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumVolumesVolume
  {

    private CollectionAlbumsAlbumVolumesVolumeTracks tracksField;

    private string idField;

    private uint framesField;

    private bool framesFieldSpecified;

    private string timeField;

    private string titleField;

    /// <remarks/>
    public CollectionAlbumsAlbumVolumesVolumeTracks Tracks
    {
      get
      {
        return this.tracksField;
      }
      set
      {
        this.tracksField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint Frames
    {
      get
      {
        return this.framesField;
      }
      set
      {
        this.framesField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FramesSpecified
    {
      get
      {
        return this.framesFieldSpecified;
      }
      set
      {
        this.framesFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Time
    {
      get
      {
        return this.timeField;
      }
      set
      {
        this.timeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Title
    {
      get
      {
        return this.titleField;
      }
      set
      {
        this.titleField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumVolumesVolumeTracks
  {

    private CollectionAlbumsAlbumVolumesVolumeTracksCommon commonField;

    private CollectionAlbumsAlbumVolumesVolumeTracksTrack[] trackField;

    /// <remarks/>
    public CollectionAlbumsAlbumVolumesVolumeTracksCommon Common
    {
      get
      {
        return this.commonField;
      }
      set
      {
        this.commonField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Track")]
    public CollectionAlbumsAlbumVolumesVolumeTracksTrack[] Track
    {
      get
      {
        return this.trackField;
      }
      set
      {
        this.trackField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumVolumesVolumeTracksCommon
  {

    private object[] itemsField;

    private ItemsChoiceType[] itemsElementNameField;

    private short bitrateField;

    private bool bitrateFieldSpecified;

    private byte monoField;

    private bool monoFieldSpecified;

    private byte liveField;

    private bool liveFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Artist", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Comment", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("FreeDBComment", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("RecCity", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("RecCountry", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("RecDate", typeof(CollectionAlbumsAlbumVolumesVolumeTracksCommonRecDate))]
    [System.Xml.Serialization.XmlElementAttribute("RecVenue", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName
    {
      get
      {
        return this.itemsElementNameField;
      }
      set
      {
        this.itemsElementNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public short Bitrate
    {
      get
      {
        return this.bitrateField;
      }
      set
      {
        this.bitrateField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BitrateSpecified
    {
      get
      {
        return this.bitrateFieldSpecified;
      }
      set
      {
        this.bitrateFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Mono
    {
      get
      {
        return this.monoField;
      }
      set
      {
        this.monoField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MonoSpecified
    {
      get
      {
        return this.monoFieldSpecified;
      }
      set
      {
        this.monoFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Live
    {
      get
      {
        return this.liveField;
      }
      set
      {
        this.liveField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LiveSpecified
    {
      get
      {
        return this.liveFieldSpecified;
      }
      set
      {
        this.liveFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumVolumesVolumeTracksCommonRecDate
  {

    private string encodedField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Encoded
    {
      get
      {
        return this.encodedField;
      }
      set
      {
        this.encodedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
  public enum ItemsChoiceType
  {

    /// <remarks/>
    Artist,

    /// <remarks/>
    Comment,

    /// <remarks/>
    FreeDBComment,

    /// <remarks/>
    RecCity,

    /// <remarks/>
    RecCountry,

    /// <remarks/>
    RecDate,

    /// <remarks/>
    RecVenue,
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumVolumesVolumeTracksTrack
  {

    private object[] itemsField;

    private ItemsChoiceType1[] itemsElementNameField;

    private ushort numberField;

    private uint framesField;

    private bool framesFieldSpecified;

    private string timeField;

    private short bitrateField;

    private bool bitrateFieldSpecified;

    private byte bPMField;

    private bool bPMFieldSpecified;

    private byte bool1Field;

    private bool bool1FieldSpecified;

    private byte liveField;

    private bool liveFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Artist", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Comment", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Composer", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("File", typeof(CollectionAlbumsAlbumVolumesVolumeTracksTrackFile))]
    [System.Xml.Serialization.XmlElementAttribute("FreeDBComment", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Lyrics", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("RecDate", typeof(CollectionAlbumsAlbumVolumesVolumeTracksTrackRecDate))]
    [System.Xml.Serialization.XmlElementAttribute("RecVenue", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Title", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType1[] ItemsElementName
    {
      get
      {
        return this.itemsElementNameField;
      }
      set
      {
        this.itemsElementNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort Number
    {
      get
      {
        return this.numberField;
      }
      set
      {
        this.numberField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint Frames
    {
      get
      {
        return this.framesField;
      }
      set
      {
        this.framesField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FramesSpecified
    {
      get
      {
        return this.framesFieldSpecified;
      }
      set
      {
        this.framesFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Time
    {
      get
      {
        return this.timeField;
      }
      set
      {
        this.timeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public short Bitrate
    {
      get
      {
        return this.bitrateField;
      }
      set
      {
        this.bitrateField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BitrateSpecified
    {
      get
      {
        return this.bitrateFieldSpecified;
      }
      set
      {
        this.bitrateFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte BPM
    {
      get
      {
        return this.bPMField;
      }
      set
      {
        this.bPMField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BPMSpecified
    {
      get
      {
        return this.bPMFieldSpecified;
      }
      set
      {
        this.bPMFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Bool1
    {
      get
      {
        return this.bool1Field;
      }
      set
      {
        this.bool1Field = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Bool1Specified
    {
      get
      {
        return this.bool1FieldSpecified;
      }
      set
      {
        this.bool1FieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Live
    {
      get
      {
        return this.liveField;
      }
      set
      {
        this.liveField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LiveSpecified
    {
      get
      {
        return this.liveFieldSpecified;
      }
      set
      {
        this.liveFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumVolumesVolumeTracksTrackFile
  {

    private uint sizeField;

    private bool sizeFieldSpecified;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint Size
    {
      get
      {
        return this.sizeField;
      }
      set
      {
        this.sizeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SizeSpecified
    {
      get
      {
        return this.sizeFieldSpecified;
      }
      set
      {
        this.sizeFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionAlbumsAlbumVolumesVolumeTracksTrackRecDate
  {

    private uint encodedField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint Encoded
    {
      get
      {
        return this.encodedField;
      }
      set
      {
        this.encodedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
  public enum ItemsChoiceType1
  {

    /// <remarks/>
    Artist,

    /// <remarks/>
    Comment,

    /// <remarks/>
    Composer,

    /// <remarks/>
    File,

    /// <remarks/>
    FreeDBComment,

    /// <remarks/>
    Lyrics,

    /// <remarks/>
    RecDate,

    /// <remarks/>
    RecVenue,

    /// <remarks/>
    Title,
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
  public enum ItemsChoiceType2
  {

    /// <remarks/>
    ASIN,

    /// <remarks/>
    Artists,

    /// <remarks/>
    CatalogNo,

    /// <remarks/>
    Category,

    /// <remarks/>
    Comment,

    /// <remarks/>
    Company,

    /// <remarks/>
    Composers,

    /// <remarks/>
    Country,

    /// <remarks/>
    Credits,

    /// <remarks/>
    Format,

    /// <remarks/>
    FreeDBComment,

    /// <remarks/>
    Genres,

    /// <remarks/>
    Label,

    /// <remarks/>
    Location,

    /// <remarks/>
    Musicians,

    /// <remarks/>
    Path,

    /// <remarks/>
    Production,

    /// <remarks/>
    RefNo,

    /// <remarks/>
    ReissueDate,

    /// <remarks/>
    ReissueLabel,

    /// <remarks/>
    ReleaseDate,

    /// <remarks/>
    Status,

    /// <remarks/>
    Title,

    /// <remarks/>
    UPC,

    /// <remarks/>
    Volumes,

    /// <remarks/>
    Year,
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionArtists
  {

    private CollectionArtistsArtist[] artistField;

    private string modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Artist")]
    public CollectionArtistsArtist[] Artist
    {
      get
      {
        return this.artistField;
      }
      set
      {
        this.artistField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionArtistsArtist
  {

    private string nameField;

    private string sortNameField;

    /// <remarks/>
    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public string SortName
    {
      get
      {
        return this.sortNameField;
      }
      set
      {
        this.sortNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionFormats
  {

    private string[] formatField;

    private string modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Format")]
    public string[] Format
    {
      get
      {
        return this.formatField;
      }
      set
      {
        this.formatField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionCategories
  {

    private string[] categoryField;

    private byte modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Category")]
    public string[] Category
    {
      get
      {
        return this.categoryField;
      }
      set
      {
        this.categoryField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionGenres
  {

    private string[] genreField;

    private string modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Genre")]
    public string[] Genre
    {
      get
      {
        return this.genreField;
      }
      set
      {
        this.genreField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionStatuses
  {

    private string[] statusField;

    private byte modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Status")]
    public string[] Status
    {
      get
      {
        return this.statusField;
      }
      set
      {
        this.statusField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionLocations
  {

    private string[] locationField;

    private string modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Location")]
    public string[] Location
    {
      get
      {
        return this.locationField;
      }
      set
      {
        this.locationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionSources
  {

    private string[] sourceField;

    private byte modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Source")]
    public string[] Source
    {
      get
      {
        return this.sourceField;
      }
      set
      {
        this.sourceField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionGenerations
  {

    private string[] generationField;

    private byte modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Generation")]
    public string[] Generation
    {
      get
      {
        return this.generationField;
      }
      set
      {
        this.generationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionQualities
  {

    private string[] qualityField;

    private byte modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Quality")]
    public string[] Quality
    {
      get
      {
        return this.qualityField;
      }
      set
      {
        this.qualityField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionConditions
  {

    private string[] conditionField;

    private byte modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Condition")]
    public string[] Condition
    {
      get
      {
        return this.conditionField;
      }
      set
      {
        this.conditionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class CollectionPackagings
  {

    private string[] packagingField;

    private byte modifiedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Packaging")]
    public string[] Packaging
    {
      get
      {
        return this.packagingField;
      }
      set
      {
        this.packagingField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
      }
    }
  }



}
