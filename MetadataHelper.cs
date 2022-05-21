using GroupDocs.Metadata;

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
}