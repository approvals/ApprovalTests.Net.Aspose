using System.IO;
using ApprovalTests;
using Aspose.Words;
using Aspose.Words.Saving;

namespace AsposeApprovalTests
{
    public static partial class AsposeApprovals
    {
        public static void VerifyWord(string path, ImageSaveOptions options = default)
        {
            var document = new Document(path);
            {
                VerifyWord(document, options);
            }
        }

        public static void VerifyWord(Stream stream, ImageSaveOptions options = default)
        {
            var document = new Document(stream);
            VerifyWord(document, options);
        }

        static void VerifyWord(Document document, ImageSaveOptions options = default)
        {
            if (options == null)
            {
                options = new ImageSaveOptions(SaveFormat.Tiff);
            }

            using (var outputStream = new MemoryStream())
            {
                document.Save(outputStream, options);
                outputStream.Position = 0;
                Approvals.VerifyBinaryFile(outputStream.ToArray(), ".tiff");
            }
        }
    }
}