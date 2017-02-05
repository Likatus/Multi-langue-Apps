using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Module.Parameter
{
  public class ParameterManager
  {
    private static List<XElement> _langues;
    private static string _lang = "Fr";


    public ParameterManager()
    {
      var xDoc = XDocument.Load("Data\\Lang.xml");
      _langues = xDoc.Document?.Root?.Elements().ToList();
    }

    public string GetLanguage(string key)
    {
      _lang = _lang.Contains("Ang") ? "Fr" : "Ang";

      try
      {
        return _langues?.Where(l => l.Attribute("key")?.Value == key)
          .Select(l => l.Attribute(_lang)?.Value).First();
      }
      catch (Exception e)
      {
        throw new Exception(e.Message);
      }
    }
  }
}
