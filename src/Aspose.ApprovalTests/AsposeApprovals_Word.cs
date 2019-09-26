using System.IO;
using System.Runtime.ExceptionServices;
using ApprovalTests.Core.Exceptions;
using ApprovalTests.Namers;
using Aspose.Words;
using Aspose.Words.Saving;

public static partial class AsposeApprovals
{
    public static void VerifyWord(string path)
    {
        Guard.AgainstNullOrEmpty(path, nameof(path));
        var document = new Document(path);
        {
            VerifyWord(document);
        }
    }

    public static void VerifyWord(Stream stream)
    {
        Guard.AgainstNull(stream, nameof(stream));
        var document = new Document(stream);
        VerifyWord(document);
    }

    static void VerifyWord(Document document)
    {
        ApprovalException? exception = null;
        for (var pageIndex = 0; pageIndex < document.PageCount; pageIndex++)
        {
            var options = new ImageSaveOptions(SaveFormat.Png)
            {
                PageIndex = pageIndex
            };
            var name = $"{pageIndex + 1:D2}";
            using (NamerFactory.AsEnvironmentSpecificTest(() => name))
            using (var outputStream = new MemoryStream())
            {
                document.Save(outputStream, options);
                VerifyBinary(outputStream, ref exception);
            }
        }

        if (exception != null)
        {
            ExceptionDispatchInfo.Capture(exception).Throw();
        }
    }
}