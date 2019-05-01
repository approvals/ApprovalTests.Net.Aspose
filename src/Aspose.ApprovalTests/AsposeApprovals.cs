using System.IO;
using ApprovalTests;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

public static class AsposeApprovals
{
    public static void VerifyPdf(string path)
    {
        using (var document = new Document(path))
        using (var pdfConverter = new PdfConverter(document))
        using (var outputStream = new MemoryStream())
        {
            pdfConverter.SaveAsTIFF(outputStream);
            outputStream.Position = 0;
            Approvals.VerifyBinaryFile(outputStream.ToArray(), ".tiff");
        }
    }
}