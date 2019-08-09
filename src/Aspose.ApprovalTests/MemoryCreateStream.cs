using System.IO;
using Aspose.Html.IO;

class MemoryCreateStream : ICreateStreamProvider
{
    MemoryStream memoryStream;

    public MemoryCreateStream(MemoryStream memoryStream)
    {
        this.memoryStream = memoryStream;
    }

    public void Dispose()
    {
    }

    public Stream GetStream(string name, string extension)
    {
        return memoryStream;
    }

    public Stream GetStream(string name, string extension, int page)
    {
        return memoryStream;
    }

    public void ReleaseStream(Stream stream)
    {
    }
}