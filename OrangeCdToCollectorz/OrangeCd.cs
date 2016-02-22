using System;
using System.Xml.Serialization;
using System.Collections.Generic;

/*  Thanks to Xml2CSharp.com for helping generate this class
 Licensed under the Apache License, Version 2.0
    
 http://www.apache.org/licenses/LICENSE-2.0
 */
namespace OrangeCdToCollectorz
{
  [Serializable, XmlRoot(ElementName = "Collection")]
  [XmlType("Collection")]
  public sealed class OrangeCd
  {
    [XmlRoot(ElementName = "Artists")]
    public class Artists
    {
      [XmlAttribute(AttributeName = "Various")]
      public string Various { get; set; }
      [XmlElement(ElementName = "Artist")]
      public string Artist { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "Genres")]
    public class Genres
    {
      [XmlElement(ElementName = "Genre")]
      public List<string> Genre { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "ReleaseDate")]
    public class ReleaseDate
    {
      [XmlAttribute(AttributeName = "Encoded")]
      public string Encoded { get; set; }
      [XmlText]
      public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Credit")]
    public class Credit
    {
      [XmlElement(ElementName = "Name")]
      public string Name { get; set; }
      [XmlElement(ElementName = "Role")]
      public string Role { get; set; }
    }

    [XmlRoot(ElementName = "Musicians")]
    public class Musicians
    {
      [XmlElement(ElementName = "Credit")]
      public List<Credit> Credit { get; set; }
    }

    [XmlRoot(ElementName = "Track")]
    public class Track
    {
      [XmlElement(ElementName = "Artist")]
      public string Artist { get; set; }
      [XmlElement(ElementName = "Title")]
      public string Title { get; set; }
      [XmlAttribute(AttributeName = "Number")]
      public string Number { get; set; }
      [XmlAttribute(AttributeName = "Frames")]
      public string Frames { get; set; }
      [XmlAttribute(AttributeName = "Time")]
      public string Time { get; set; }
      [XmlElement(ElementName = "Comment")]
      public string Comment { get; set; }
      [XmlElement(ElementName = "File")]
      public File File { get; set; }
      [XmlAttribute(AttributeName = "Bitrate")]
      public string Bitrate { get; set; }
    }

    [XmlRoot(ElementName = "Tracks")]
    public class Tracks
    {
      [XmlElement(ElementName = "Track")]
      public List<Track> Track { get; set; }
    }

    [XmlRoot(ElementName = "Volume")]
    public class Volume
    {
      [XmlElement(ElementName = "Tracks")]
      public Tracks Tracks { get; set; }
      [XmlAttribute(AttributeName = "ID")]
      public string ID { get; set; }
      [XmlAttribute(AttributeName = "Frames")]
      public string Frames { get; set; }
      [XmlAttribute(AttributeName = "Time")]
      public string Time { get; set; }
    }

    [XmlRoot(ElementName = "Volumes")]
    public class Volumes
    {
      [XmlElement(ElementName = "Volume")]
      public Volume Volume { get; set; }
    }

    [XmlRoot(ElementName = "Album")]
    public class Album
    {
      [XmlElement(ElementName = "Artists")]
      public Artists Artists { get; set; }
      [XmlElement(ElementName = "Title")]
      public string Title { get; set; }
      [XmlElement(ElementName = "Year")]
      public string Year { get; set; }
      [XmlElement(ElementName = "Genres")]
      public Genres Genres { get; set; }
      [XmlElement(ElementName = "Category")]
      public string Category { get; set; }
      [XmlElement(ElementName = "Format")]
      public string Format { get; set; }
      [XmlElement(ElementName = "Comment")]
      public string Comment { get; set; }
      [XmlElement(ElementName = "RefNo")]
      public string RefNo { get; set; }
      [XmlElement(ElementName = "ReleaseDate")]
      public ReleaseDate ReleaseDate { get; set; }
      [XmlElement(ElementName = "Label")]
      public string Label { get; set; }
      [XmlElement(ElementName = "CatalogNo")]
      public string CatalogNo { get; set; }
      [XmlElement(ElementName = "Country")]
      public string Country { get; set; }
      [XmlElement(ElementName = "Location")]
      public string Location { get; set; }
      [XmlElement(ElementName = "Musicians")]
      public Musicians Musicians { get; set; }
      [XmlElement(ElementName = "Volumes")]
      public Volumes Volumes { get; set; }
      [XmlAttribute(AttributeName = "ID")]
      public string ID { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
      [XmlAttribute(AttributeName = "Created")]
      public string Created { get; set; }
      [XmlAttribute(AttributeName = "IsCompilation")]
      public string IsCompilation { get; set; }
      [XmlAttribute(AttributeName = "Icon")]
      public string Icon { get; set; }
      [XmlAttribute(AttributeName = "Frames")]
      public string Frames { get; set; }
      [XmlAttribute(AttributeName = "Time")]
      public string Time { get; set; }
      [XmlElement(ElementName = "Path")]
      public string Path { get; set; }
    }

    [XmlRoot(ElementName = "File")]
    public class File
    {
      [XmlAttribute(AttributeName = "Size")]
      public string Size { get; set; }
      [XmlText]
      public string Text { get; set; }
    }

    [XmlRoot(ElementName = "All")]
    public class All
    {
      [XmlElement(ElementName = "Album")]
      public List<Album> Album { get; set; }
    }

    [XmlRoot(ElementName = "Albums")]
    public class Albums
    {
      [XmlElement(ElementName = "All")]
      public All All { get; set; }
    }

    [XmlRoot(ElementName = "Artist")]
    public class Artist
    {
      [XmlElement(ElementName = "Name")]
      public string Name { get; set; }
      [XmlElement(ElementName = "SortName")]
      public string SortName { get; set; }
    }

    [XmlRoot(ElementName = "Formats")]
    public class Formats
    {
      [XmlElement(ElementName = "Format")]
      public List<string> Format { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "Categories")]
    public class Categories
    {
      [XmlElement(ElementName = "Category")]
      public List<string> Category { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "Statuses")]
    public class Statuses
    {
      [XmlElement(ElementName = "Status")]
      public List<string> Status { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "Locations")]
    public class Locations
    {
      [XmlElement(ElementName = "Location")]
      public List<string> Location { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "Sources")]
    public class Sources
    {
      [XmlElement(ElementName = "Source")]
      public List<string> Source { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "Generations")]
    public class Generations
    {
      [XmlElement(ElementName = "Generation")]
      public List<string> Generation { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "Qualities")]
    public class Qualities
    {
      [XmlElement(ElementName = "Quality")]
      public List<string> Quality { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "Conditions")]
    public class Conditions
    {
      [XmlElement(ElementName = "Condition")]
      public List<string> Condition { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "Packagings")]
    public class Packagings
    {
      [XmlElement(ElementName = "Packaging")]
      public List<string> Packaging { get; set; }
      [XmlAttribute(AttributeName = "Modified")]
      public string Modified { get; set; }
    }

    [XmlRoot(ElementName = "Collection")]
    public class Collection2
    {
      [XmlElement(ElementName = "Albums")]
      public Albums Albums { get; set; }
      [XmlElement(ElementName = "Artists")]
      public Artists Artists { get; set; }
      [XmlElement(ElementName = "Formats")]
      public Formats Formats { get; set; }
      [XmlElement(ElementName = "Categories")]
      public Categories Categories { get; set; }
      [XmlElement(ElementName = "Genres")]
      public Genres Genres { get; set; }
      [XmlElement(ElementName = "Statuses")]
      public Statuses Statuses { get; set; }
      [XmlElement(ElementName = "Locations")]
      public Locations Locations { get; set; }
      [XmlElement(ElementName = "Sources")]
      public Sources Sources { get; set; }
      [XmlElement(ElementName = "Generations")]
      public Generations Generations { get; set; }
      [XmlElement(ElementName = "Qualities")]
      public Qualities Qualities { get; set; }
      [XmlElement(ElementName = "Conditions")]
      public Conditions Conditions { get; set; }
      [XmlElement(ElementName = "Packagings")]
      public Packagings Packagings { get; set; }
      [XmlAttribute(AttributeName = "Version")]
      public string Version { get; set; }
    }
  }
}
