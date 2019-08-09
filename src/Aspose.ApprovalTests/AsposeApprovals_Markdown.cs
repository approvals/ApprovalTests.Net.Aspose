using System.Drawing;
using System.IO;
using System.Runtime.ExceptionServices;
using ApprovalTests.Core.Exceptions;
using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;

public static partial class AsposeApprovals
{
    public static void VerifyMarkdownText(string markdown)
    {
        Guard.AgainstNullOrEmpty(markdown, nameof(markdown));
        var tempFileName = Path.GetTempFileName();
        try
        {
            File.WriteAllText(tempFileName, markdown);
            VerifyMarkdown(tempFileName);
        }
        finally
        {
            File.Delete(tempFileName);
        }
    }

    public static void VerifyMarkdown(string path)
    {
        Guard.AgainstNullOrEmpty(path, nameof(path));
        path = Path.GetFullPath(path);
        var htmlDocument = Converter.ConvertMarkdown(path);
        var imageSaveOptions = new ImageSaveOptions(ImageFormat.Png){BackgroundColor = Color.White};

        ApprovalException pngException = null;
        using (var memoryStream = new MemoryStream())
        {
            Converter.ConvertHTML(htmlDocument, imageSaveOptions, new MemoryCreateStream(memoryStream));
            VerifyBinary(memoryStream, ref pngException);
        }

        ApprovalException mdException = null;
        VerifyMarkdownFile(path, ref mdException);
        if (mdException != null)
        {
            ExceptionDispatchInfo.Capture(mdException).Throw();
        }
        if (pngException != null)
        {
            ExceptionDispatchInfo.Capture(pngException).Throw();
        }
    }
}