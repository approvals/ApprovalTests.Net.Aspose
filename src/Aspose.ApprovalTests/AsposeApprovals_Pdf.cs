using System.IO;
using ApprovalTests;
using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace AsposeApprovalTests
{
    public static partial class AsposeApprovals
    {
        public static void VerifyPdf(string path)
        {
            using (var document = new Document(path))
            {
                VerifyPdf(document);
            }
        }

        public static void VerifyPdf(Stream stream)
        {
            using (var document = new Document(stream))
            {
                VerifyPdf(document);
            }
        }

        static void VerifyPdf(Document document)
        {
            using (var pdfConverter = new PdfConverter(document))
            using (var outputStream = new MemoryStream())
            {
                pdfConverter.SaveAsTIFF(outputStream);
                outputStream.Position = 0;
                Approvals.VerifyBinaryFile(outputStream.ToArray(), ".tiff");
            }
        }
    }
}