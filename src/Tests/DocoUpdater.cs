using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using MarkdownSnippets;
using Xunit;
using Xunit.Abstractions;

public class DocoUpdater :
    XunitLoggingBase
{
    [Fact]
    public void Run()
    {
        //var directory = GetProjectDirectory();
        //foreach (var file in Directory.EnumerateFiles(directory,"*.tiff"))
        //{
        //    var tiff = Image.FromFile(file);
        //    var png = Path.ChangeExtension(file, ".png");
        //    tiff.Save(png, ImageFormat.Png);
        //}
        DirectoryMarkdownProcessor.RunForFilePath();
    }

    string GetProjectDirectory([CallerFilePath] string sourceFilePath = "")
    {
        return Path.GetDirectoryName(sourceFilePath);
    }

    public DocoUpdater(ITestOutputHelper output) :
        base(output)
    {
    }
}