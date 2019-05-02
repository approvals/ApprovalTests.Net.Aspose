using System.IO;
using ApprovalTests.Namers;
using Aspose.Words;
using Aspose.Words.Saving;

namespace AsposeApprovalTests
{
    public static partial class AsposeApprovals
    {
        public static void VerifyWord(string path)
        {
            var document = new Document(path);
            {
                VerifyWord(document);
            }
        }

        public static void VerifyWord(Stream stream)
        {
            var document = new Document(stream);
            VerifyWord(document);
        }

        static void VerifyWord(Document document)
        {
            for (var pageIndex = 0; pageIndex < document.PageCount; pageIndex++)
            {
                var options = new ImageSaveOptions(SaveFormat.Png)
                {
                    PageIndex = pageIndex
                };
                var name = $"{pageIndex + 1}";
                using (NamerFactory.AsEnvironmentSpecificTest(() => name))
                using (var outputStream = new MemoryStream())
                {
                    document.Save(outputStream, options);
                    VerifyBinary(outputStream, pageIndex, document.PageCount);
                }
            }
        }
    }
}