using System.IO;
using System.Runtime.ExceptionServices;
using ApprovalTests.Core.Exceptions;
using ApprovalTests.Namers;
using Aspose.Pdf;
using Aspose.Pdf.Devices;

public static partial class AsposeApprovals
{
    public static void VerifyPdf(string path)
    {
        Guard.AgainstNullOrEmpty(path, nameof(path));
        using var document = new Document(path);
        VerifyPdf(document);
    }

    public static void VerifyPdf(Stream stream)
    {
        Guard.AgainstNull(stream, nameof(stream));
        using var document = new Document(stream);
        VerifyPdf(document);
    }

    static PngDevice pngDevice = new PngDevice();

    static void VerifyPdf(Document document)
    {
        ApprovalException? exception = null;
        foreach (var page in document.Pages)
        {
            var name = $"{page.Number:D2}";
            using (NamerFactory.AsEnvironmentSpecificTest(name))
            {
                using var outputStream = new MemoryStream();
                pngDevice.Process(page, outputStream);
                VerifyBinary(outputStream, ref exception);
            }
        }

        if (exception != null)
        {
            ExceptionDispatchInfo.Capture(exception).Throw();
        }
    }
}