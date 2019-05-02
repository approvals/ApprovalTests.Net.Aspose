using System.IO;
using Aspose.Tasks;
using Aspose.Tasks.Saving;

namespace AsposeApprovalTests
{
    public static partial class AsposeApprovals
    {
        public static void VerifyProject(string path)
        {
            var document = new Project(path);
            {
                VerifyProject(document);
            }
        }

        public static void VerifyProject(Stream stream)
        {
            var document = new Project(stream);
            VerifyProject(document);
        }

        static ImageSaveOptions saveOptions = new ImageSaveOptions(SaveFileFormat.PNG)
        {
            SaveToSeparateFiles = false,
            FitContent = true,
        };

        static void VerifyProject(Project document)
        {
            using (var outputStream = new MemoryStream())
            {
                document.Save(outputStream, saveOptions);
                VerifyBinary(outputStream);
            }
        }
    }
}