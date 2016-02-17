using System.Xml.Serialization;
using System;

namespace OrangeCdToCollectorz
{
  [Serializable, XmlRoot(ElementName = "Collection")]
  [XmlType("Collection")]
  public class OrangeCdCollection
  {
    private string m_Albums = "";

    public string Albums
    {
      get { return m_Albums; }
      set { m_Albums = value; }
    }

    private string m_Artists = "";

    public string Artists
    {
      get { return m_Artists; }
      set { m_Artists = value; }
    }

    private string m_Artists_Modified = "";

    public string Artists_Modified
    {
      get { return m_Artists_Modified; }
      set { m_Artists_Modified = value; }
    }

    private string m_Formats = "";

    public string Formats
    {
      get { return m_Formats; }
      set { m_Formats = value; }
    }

    private string m_Formats_Modified = "";

    public string Formats_Modified
    {
      get { return m_Formats_Modified; }
      set { m_Formats_Modified = value; }
    }

    private string m_Categories = "";

    public string Categories
    {
      get { return m_Categories; }
      set { m_Categories = value; }
    }

    private string m_Categories_Modified = "";

    public string Categories_Modified
    {
      get { return m_Categories_Modified; }
      set { m_Categories_Modified = value; }
    }

    private string m_Genres = "";

    public string Genres
    {
      get { return m_Genres; }
      set { m_Genres = value; }
    }

    private string m_Genres_Modified = "";

    public string Genres_Modified
    {
      get { return m_Genres_Modified; }
      set { m_Genres_Modified = value; }
    }

    private string m_Statuses = "";

    public string Statuses
    {
      get { return m_Statuses; }
      set { m_Statuses = value; }
    }

    private string m_Statuses_Modified = "";

    public string Statuses_Modified
    {
      get { return m_Statuses_Modified; }
      set { m_Statuses_Modified = value; }
    }

    private string m_Locations = "";

    public string Locations
    {
      get { return m_Locations; }
      set { m_Locations = value; }
    }

    private string m_Locations_Modified = "";

    public string Locations_Modified
    {
      get { return m_Locations_Modified; }
      set { m_Locations_Modified = value; }
    }

    private string m_Sources = "";

    public string Sources
    {
      get { return m_Sources; }
      set { m_Sources = value; }
    }

    private string m_Sources_Modified = "";

    public string Sources_Modified
    {
      get { return m_Sources_Modified; }
      set { m_Sources_Modified = value; }
    }

    private string m_Generations = "";

    public string Generations
    {
      get { return m_Generations; }
      set { m_Generations = value; }
    }

    private string m_Generations_Modified = "";

    public string Generations_Modified
    {
      get { return m_Generations_Modified; }
      set { m_Generations_Modified = value; }
    }

    private string m_Qualities = "";

    public string Qualities
    {
      get { return m_Qualities; }
      set { m_Qualities = value; }
    }

    private string m_Qualities_Modified = "";

    public string Qualities_Modified
    {
      get { return m_Qualities_Modified; }
      set { m_Qualities_Modified = value; }
    }

    private string m_Conditions = "";

    public string Conditions
    {
      get { return m_Conditions; }
      set { m_Conditions = value; }
    }

    private string m_Conditions_Modified = "";

    public string Conditions_Modified
    {
      get { return m_Conditions_Modified; }
      set { m_Conditions_Modified = value; }
    }

    private string m_Packagings = "";

    public string Packagings
    {
      get { return m_Packagings; }
      set { m_Packagings = value; }
    }

    private string m_Packagings_Modified = "";

    public string Packagings_Modified
    {
      get { return m_Packagings_Modified; }
      set { m_Packagings_Modified = value; }
    }
  }
}
