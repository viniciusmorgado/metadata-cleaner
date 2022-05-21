using GroupDocs.Metadata;
using GroupDocs.Metadata.Common;
using GroupDocs.Metadata.Tagging;

public static class MetadataHelper
{
    public static void RemoveAllMetadata(string filePath, string savePath)
    {
        using (Metadata metadata = new Metadata(filePath))
        {
            metadata.Sanitize();
            metadata.Save(savePath);
        }
    }

    public static void RemoveSpecificMetadata(string filePath, string savePath)
    {
        using (Metadata metadata = new Metadata(filePath))
        {
            // Remove all the properties that:
            // contains the name of the document author OR
            // it refers to the last editor OR 
            // the property value is a string AND equal to the given string "GroupDocs"
            var affected = metadata.RemoveProperties(
                p => p.Tags.Contains(Tags.Person.Creator) ||
                     p.Tags.Contains(Tags.Person.Editor) ||
                     p.Tags.Contains(Tags.Origin.Source) ||
                     p.Value.Type == MetadataPropertyType.String && p.Value.ToString().Contains("GroupDocs"));
            Console.WriteLine("Properties removed: {0}", affected);

            metadata.Save(savePath);
        }
    }
}