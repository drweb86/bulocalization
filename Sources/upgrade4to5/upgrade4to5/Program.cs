// See https://aka.ms/new-console-template for more information


using System.Globalization;
using System.Text;
using System.Transactions;
using System.Xml;
using upgrade4to5.Languages;



Console.WriteLine("Conversion utility to upgrade from v.4 to v.5 version of BULocalization\n\n");

var translationsV3Folder=   @"D:\sources\butil\sources\LocalizationProject";
var translationFiles = Directory.GetFiles(translationsV3Folder, "*.Language");
Console.WriteLine("Found translations");
foreach (var translationFile in translationFiles)
{
    Console.WriteLine(translationFile);
}

foreach (var translationFile in translationFiles)
{
    Console.WriteLine("Converting {0}", translationFile);

    var document = new XmlDocument();
    document.Load(translationFile);

    Console.WriteLine("Populate data");

    var itemNodes = document.SelectNodes("/XML/Language/Items/Item");
    var ts = new List<T>();
    foreach (XmlNode namespaceNode in itemNodes)
    {
        var id = namespaceNode.SelectSingleNode("ID").InnerText;
        var source = namespaceNode.SelectSingleNode("Source").InnerText;
        var translation = namespaceNode.SelectSingleNode("Translation").InnerText;
        var nid = namespaceNode.SelectSingleNode("N_ID").InnerText;

        ts.Add(new T { Nid = nid, Id = id, Name = string.IsNullOrEmpty(translation) ? source : translation, Source = source });
    }

    itemNodes = document.SelectNodes("/XML/Language/Namespaces/Namespace");
    var nss = new List<NS>();
    foreach (XmlNode namespaceNode in itemNodes)
    {
        var name = namespaceNode.SelectSingleNode("Name").InnerText;
        var nid = namespaceNode.SelectSingleNode("N_ID").InnerText;

        nss.Add(new NS { Id = nid, Name = name });
    }

    // Add translation meta

    ts.Add(new T { Source = "Translation Author", Id = "TranslationAuthor", Nid = "4" /*Hard code - ns where t a i is showed */, Name = document.SelectSingleNode("/XML/Language/Author").InnerText });

    var repDic = new Dictionary<string, string>();
    foreach (var ns in nss)
    {
        var outputDir = Path.Combine(translationsV3Folder, ns.Name);
        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);

        // *.cs Translation.Current[488] => Resources.<ID>
        var resourceFileName = "Resources.resx";
        if (translationFile.EndsWith("default.Language"))
        {
            
        }
        else if (translationFile.EndsWith("Russian.Language"))
        {
            resourceFileName = "Resources.ru.resx";
        }
        else if (translationFile.EndsWith("Belorussian.Language"))
        {
            resourceFileName = "Resources.be.resx";
        }

        var outputResx = Path.Combine(outputDir, resourceFileName);
        var outputResxContent = File.ReadAllText(@"D:\sources\bulocalization\Sources\upgrade4to5\upgrade4to5\Languages\Prefix.txt");


        foreach (var translation in ts.Where(tr=> tr.Nid == ns.Id).ToArray())
        {
            var newId = A.RemoveSpecialCharacters(CultureInfo.InvariantCulture.TextInfo.ToTitleCase(translation.Source.ToLower()));
            if (newId[0] >= '0' && newId[0] <= '9') newId = '_' + newId;
            repDic.Add($"Translation.Current[{translation.Id}]", $"Resources.{newId}");
            var escapedText = new System.Xml.Linq.XText(translation.Name).ToString();
            outputResxContent += String.Format(@"  <data name=""{0}"" xml:space=""preserve"">
    <value>{1}</value>
  </data>
", newId, escapedText);
        }
        outputResxContent += File.ReadAllText(@"D:\sources\bulocalization\Sources\upgrade4to5\upgrade4to5\Languages\Postfix.txt");

        if (File.Exists(outputResx))
            File.Delete(outputResx);
        File.WriteAllText(outputResx, outputResxContent);
    }

    if (translationFile.EndsWith("default.Language"))
        {

        var allCsFiles = Directory.GetFiles("D:\\sources\\butil\\sources", "*.cs", SearchOption.AllDirectories);

        foreach (var file in allCsFiles)
        {
            var content = File.ReadAllText(file);
            if (content.Contains("Translation.Current") || content.Contains("translation["))
            {
                foreach (var r in repDic)
                    content = content
                        .Replace(r.Key, r.Value)
                        .Replace(r.Key.Replace("Translation.Current", "translation"), r.Value);
                File.Delete(file);
                File.WriteAllText(file, content);
            }
        }

        }
}



static class A
{
    public static string RemoveSpecialCharacters(this string str)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in str)
        {
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '_')
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}

class NS
{
    public string Name { get; set; }
    public string Id { get; set; }
}

class T
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string Nid { get; set; }
    public string Source { get; set; }
}