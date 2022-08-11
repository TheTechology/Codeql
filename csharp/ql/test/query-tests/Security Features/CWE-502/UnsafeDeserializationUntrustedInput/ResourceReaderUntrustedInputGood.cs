using System.Web.UI.WebControls;
using System.Resources;
using System.IO;
using System.Text;
using System;

class GoodResourceReader
{
    public static void Deserialize(TextBox data)
    {
        // GOOD
        var ds = new ResourceReader(new MemoryStream(Encoding.UTF8.GetBytes("hardcoded")));
        var dict = ds.GetEnumerator();
        while (dict.MoveNext())
            Console.WriteLine("   {0}: '{1}' (Type {2})", 
                            dict.Key, dict.Value, dict.Value.GetType().Name);
        ds.Close();
    }
}
