using System.IO;
using ApprovalTests.Core.Exceptions;
using ApprovalTests.Namers;
using Aspose.Slides;

namespace AsposeApprovalTests
{
    public static partial class AsposeApprovals
    {
        public static void VerifyPowerPoint(string path)
        {
            var document = new Presentation(path);
            {
                VerifyPowerPoint(document);
            }
        }

        public static void VerifyPowerPoint(Stream stream)
        {
            using (var document = new Presentation(stream))
            {
                VerifyPowerPoint(document);
            }
        }

        static void VerifyPowerPoint(Presentation document)
        {
            ApprovalException exception = null;
            for (var pageIndex = 0; pageIndex < document.Slides.Count; pageIndex++)
            {
                var slide = document.Slides[pageIndex];
                var name = $"{pageIndex + 1:D2}";
                using (NamerFactory.AsEnvironmentSpecificTest(() => name))
                using (var outputStream = new MemoryStream())
                {
                    slide.WriteAsSvg(outputStream);
                    VerifyBinary(outputStream, ref exception, ".svg");
                }
            }
            if (exception != null)
            {
                throw exception;
            }
        }
    }
}