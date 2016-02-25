using System.Collections.Generic;
using System.Xml.Serialization;

/*  Thanks to Xml2CSharp.com for helping generate this class
 Licensed under the Apache License, Version 2.0
    
 http://www.apache.org/licenses/LICENSE-2.0
 */
namespace OrangeCdToCollectorz
{
  public class CollectorzMusic
  {
    [XmlRoot(ElementName = "field")]
    public class Field
    {
      [XmlAttribute(AttributeName = "id")]
      public string Id { get; set; }
      [XmlAttribute(AttributeName = "label")]
      public string Label { get; set; }
      [XmlAttribute(AttributeName = "name")]
      public string Name { get; set; }
    }

    [XmlRoot(ElementName = "localizedtemplatetexts")]
    public class Localizedtemplatetexts
    {
      [XmlElement(ElementName = "field")]
      public List<Field> Field { get; set; }
    }

    [XmlRoot(ElementName = "musicmetadata")]
    public class Musicmetadata
    {
      [XmlElement(ElementName = "field")]
      public List<Field> Field { get; set; }
    }

    [XmlRoot(ElementName = "year")]
    public class Year
    {
      [XmlElement(ElementName = "displayname")]
      public string Displayname { get; set; }
    }

    [XmlRoot(ElementName = "releasedate")]
    public class Releasedate
    {
      [XmlElement(ElementName = "year")]
      public Year Year { get; set; }
      [XmlElement(ElementName = "date")]
      public string Date { get; set; }
    }

    [XmlRoot(ElementName = "artist")]
    public class Artist
    {
      [XmlElement(ElementName = "displayname")]
      public string Displayname { get; set; }
      [XmlElement(ElementName = "sortname")]
      public string Sortname { get; set; }
    }

    [XmlRoot(ElementName = "artists")]
    public class Artists
    {
      [XmlElement(ElementName = "artist")]
      public Artist Artist { get; set; }
    }

    [XmlRoot(ElementName = "artistfirstletter")]
    public class Artistfirstletter
    {
      [XmlElement(ElementName = "displayname")]
      public string Displayname { get; set; }
      [XmlElement(ElementName = "sortname")]
      public string Sortname { get; set; }
    }

    [XmlRoot(ElementName = "genre")]
    public class Genre
    {
      [XmlElement(ElementName = "displayname")]
      public string Displayname { get; set; }
    }

    [XmlRoot(ElementName = "genres")]
    public class Genres
    {
      [XmlElement(ElementName = "genre")]
      public Genre Genre { get; set; }
    }

    [XmlRoot(ElementName = "label")]
    public class Label
    {
      [XmlElement(ElementName = "displayname")]
      public string Displayname { get; set; }
      [XmlElement(ElementName = "sortname")]
      public string Sortname { get; set; }
    }

    [XmlRoot(ElementName = "format")]
    public class Format
    {
      [XmlElement(ElementName = "displayname")]
      public string Displayname { get; set; }
    }

    [XmlRoot(ElementName = "rating")]
    public class Rating
    {
      [XmlElement(ElementName = "displayname")]
      public string Displayname { get; set; }
      [XmlElement(ElementName = "sortname")]
      public string Sortname { get; set; }
    }

    [XmlRoot(ElementName = "spars")]
    public class Spars
    {
      [XmlElement(ElementName = "displayname")]
      public string Displayname { get; set; }
    }

    [XmlRoot(ElementName = "sound")]
    public class Sound
    {
      [XmlElement(ElementName = "displayname")]
      public string Displayname { get; set; }
    }

    [XmlRoot(ElementName = "sounds")]
    public class Sounds
    {
      [XmlElement(ElementName = "sound")]
      public Sound Sound { get; set; }
    }

    [XmlRoot(ElementName = "packaging")]
    public class Packaging
    {
      [XmlElement(ElementName = "displayname")]
      public string Displayname { get; set; }
    }

    [XmlRoot(ElementName = "rare")]
    public class Rare
    {
      [XmlAttribute(AttributeName = "boolvalue")]
      public string Boolvalue { get; set; }
      [XmlText]
      public string Text { get; set; }
    }

    [XmlRoot(ElementName = "collectionstatus")]
    public class Collectionstatus
    {
      [XmlAttribute(AttributeName = "listid")]
      public string Listid { get; set; }
      [XmlText]
      public string Text { get; set; }
    }

    [XmlRoot(ElementName = "lastmodified")]
    public class Lastmodified
    {
      [XmlElement(ElementName = "date")]
      public string Date { get; set; }
    }

    [XmlRoot(ElementName = "dateadded")]
    public class Dateadded
    {
      [XmlElement(ElementName = "date")]
      public string Date { get; set; }
    }

    [XmlRoot(ElementName = "detail")]
    public class Detail
    {
      [XmlElement(ElementName = "id")]
      public string Id { get; set; }
      [XmlElement(ElementName = "index")]
      public string Index { get; set; }
      [XmlElement(ElementName = "title")]
      public string Title { get; set; }
      [XmlElement(ElementName = "releasedate")]
      public Releasedate Releasedate { get; set; }
      [XmlElement(ElementName = "recordingdate")]
      public string Recordingdate { get; set; }
      [XmlElement(ElementName = "artists")]
      public Artists Artists { get; set; }
      [XmlElement(ElementName = "artistfirstletter")]
      public Artistfirstletter Artistfirstletter { get; set; }
      [XmlElement(ElementName = "composers")]
      public string Composers { get; set; }
      [XmlElement(ElementName = "genres")]
      public Genres Genres { get; set; }
      [XmlElement(ElementName = "label")]
      public Label Label { get; set; }
      [XmlElement(ElementName = "labelnumber")]
      public string Labelnumber { get; set; }
      [XmlElement(ElementName = "length")]
      public string Length { get; set; }
      [XmlElement(ElementName = "lengthsecs")]
      public string Lengthsecs { get; set; }
      [XmlElement(ElementName = "nrtracks")]
      public string Nrtracks { get; set; }
      [XmlElement(ElementName = "cddbgenreid1")]
      public string Cddbgenreid1 { get; set; }
      [XmlElement(ElementName = "compositions")]
      public string Compositions { get; set; }
      [XmlElement(ElementName = "submissiondate")]
      public string Submissiondate { get; set; }
      [XmlElement(ElementName = "cddbgenreid2")]
      public string Cddbgenreid2 { get; set; }
      [XmlElement(ElementName = "rating")]
      public Rating Rating { get; set; }
      [XmlElement(ElementName = "studios")]
      public string Studios { get; set; }
      [XmlElement(ElementName = "conductors")]
      public string Conductors { get; set; }
      [XmlElement(ElementName = "orchestras")]
      public string Orchestras { get; set; }
      [XmlElement(ElementName = "choruses")]
      public string Choruses { get; set; }
      [XmlElement(ElementName = "musicians")]
      public string Musicians { get; set; }
      [XmlElement(ElementName = "credits")]
      public string Credits { get; set; }
      [XmlElement(ElementName = "bitrate")]
      public string Bitrate { get; set; }
      [XmlElement(ElementName = "filesize")]
      public string Filesize { get; set; }
      [XmlElement(ElementName = "offset")]
      public string Offset { get; set; }
      [XmlElement(ElementName = "position")]
      public string Position { get; set; }
      [XmlAttribute(AttributeName = "type")]
      public string Type { get; set; }
      [XmlElement(ElementName = "details")]
      public Details Details { get; set; }
      [XmlElement(ElementName = "cddbid")]
      public string Cddbid { get; set; }
      [XmlElement(ElementName = "leadoutoffset")]
      public string Leadoutoffset { get; set; }
      [XmlElement(ElementName = "cddbrevision")]
      public string Cddbrevision { get; set; }
      [XmlElement(ElementName = "bpdiscid")]
      public string Bpdiscid { get; set; }
      [XmlElement(ElementName = "storagedevice")]
      public string Storagedevice { get; set; }
    }

    [XmlRoot(ElementName = "details")]
    public class Details
    {
      [XmlElement(ElementName = "detail")]
      public List<Detail> Detail { get; set; }
    }

    [XmlRoot(ElementName = "rpm")]
    public class Rpm
    {
      [XmlAttribute(AttributeName = "listid")]
      public string Listid { get; set; }
      [XmlText]
      public string Text { get; set; }
    }

    [XmlRoot(ElementName = "music")]
    public class Music
    {
      [XmlElement(ElementName = "id")]
      public string Id { get; set; }
      [XmlElement(ElementName = "index")]
      public string Index { get; set; }
      [XmlElement(ElementName = "title")]
      public string Title { get; set; }
      [XmlElement(ElementName = "releasedate")]
      public Releasedate Releasedate { get; set; }
      [XmlElement(ElementName = "recordingdate")]
      public string Recordingdate { get; set; }
      [XmlElement(ElementName = "artists")]
      public Artists Artists { get; set; }
      [XmlElement(ElementName = "artistfirstletter")]
      public Artistfirstletter Artistfirstletter { get; set; }
      [XmlElement(ElementName = "composers")]
      public string Composers { get; set; }
      [XmlElement(ElementName = "genres")]
      public Genres Genres { get; set; }
      [XmlElement(ElementName = "label")]
      public Label Label { get; set; }
      [XmlElement(ElementName = "labelnumber")]
      public string Labelnumber { get; set; }
      [XmlElement(ElementName = "length")]
      public string Length { get; set; }
      [XmlElement(ElementName = "lengthsecs")]
      public string Lengthsecs { get; set; }
      [XmlElement(ElementName = "notes")]
      public string Notes { get; set; }
      [XmlElement(ElementName = "nrtracks")]
      public string Nrtracks { get; set; }
      [XmlElement(ElementName = "cddbgenreid1")]
      public string Cddbgenreid1 { get; set; }
      [XmlElement(ElementName = "compositions")]
      public string Compositions { get; set; }
      [XmlElement(ElementName = "submissiondate")]
      public string Submissiondate { get; set; }
      [XmlElement(ElementName = "format")]
      public Format Format { get; set; }
      [XmlElement(ElementName = "cddbgenreid2")]
      public string Cddbgenreid2 { get; set; }
      [XmlElement(ElementName = "rating")]
      public Rating Rating { get; set; }
      [XmlElement(ElementName = "studios")]
      public string Studios { get; set; }
      [XmlElement(ElementName = "conductors")]
      public string Conductors { get; set; }
      [XmlElement(ElementName = "orchestras")]
      public string Orchestras { get; set; }
      [XmlElement(ElementName = "choruses")]
      public string Choruses { get; set; }
      [XmlElement(ElementName = "musicians")]
      public string Musicians { get; set; }
      [XmlElement(ElementName = "credits")]
      public string Credits { get; set; }
      [XmlElement(ElementName = "hash")]
      public string Hash { get; set; }
      [XmlElement(ElementName = "purchasedate")]
      public string Purchasedate { get; set; }
      [XmlElement(ElementName = "origreleasedate")]
      public string Origreleasedate { get; set; }
      [XmlElement(ElementName = "spars")]
      public Spars Spars { get; set; }
      [XmlElement(ElementName = "sounds")]
      public Sounds Sounds { get; set; }
      [XmlElement(ElementName = "extras")]
      public string Extras { get; set; }
      [XmlElement(ElementName = "packaging")]
      public Packaging Packaging { get; set; }
      [XmlElement(ElementName = "rare")]
      public Rare Rare { get; set; }
      [XmlElement(ElementName = "collectionstatus")]
      public Collectionstatus Collectionstatus { get; set; }
      [XmlElement(ElementName = "nrdiscs")]
      public string Nrdiscs { get; set; }
      [XmlElement(ElementName = "upc")]
      public string Upc { get; set; }
      [XmlElement(ElementName = "bpalbumid")]
      public string Bpalbumid { get; set; }
      [XmlElement(ElementName = "links")]
      public string Links { get; set; }
      [XmlElement(ElementName = "condition")]
      public string Condition { get; set; }
      [XmlElement(ElementName = "mediacondition")]
      public string Mediacondition { get; set; }
      [XmlElement(ElementName = "quantity")]
      public string Quantity { get; set; }
      [XmlElement(ElementName = "lastmodified")]
      public Lastmodified Lastmodified { get; set; }
      [XmlElement(ElementName = "dateadded")]
      public Dateadded Dateadded { get; set; }
      [XmlElement(ElementName = "details")]
      public Details Details { get; set; }
      [XmlElement(ElementName = "tags")]
      public string Tags { get; set; }
      [XmlElement(ElementName = "storagedevice")]
      public string Storagedevice { get; set; }
      [XmlElement(ElementName = "boxset")]
      public string Boxset { get; set; }
      [XmlElement(ElementName = "rpm")]
      public Rpm Rpm { get; set; }
      [XmlElement(ElementName = "vinylcolor")]
      public string Vinylcolor { get; set; }
      [XmlElement(ElementName = "vinylweight")]
      public string Vinylweight { get; set; }
    }

    [XmlRoot(ElementName = "musiclist")]
    public class Musiclist
    {
      [XmlElement(ElementName = "music")]
      public List<Music> Music { get; set; }
    }

    [XmlRoot(ElementName = "musicinfo")]
    public class Musicinfo
    {
      [XmlElement(ElementName = "localizedtemplatetexts")]
      public Localizedtemplatetexts Localizedtemplatetexts { get; set; }
      [XmlElement(ElementName = "musicmetadata")]
      public Musicmetadata Musicmetadata { get; set; }
      [XmlElement(ElementName = "musiclist")]
      public Musiclist Musiclist { get; set; }
      [XmlAttribute(AttributeName = "creationdate")]
      public string Creationdate { get; set; }
    }

  }

}
