using System.IO;
using System.Runtime.ExceptionServices;
using ApprovalTests.Core.Exceptions;
using ApprovalTests.Namers;
using Aspose.Cells;
using Aspose.Cells.Drawing;
using Aspose.Cells.Rendering;

public static partial class AsposeApprovals
{
    public static void VerifyExcel(string path)
    {
        Guard.AgainstNullOrEmpty(path, nameof(path));
        var document = new Workbook(path);
        {
            VerifyWord(document);
        }
    }

    public static void VerifyExcel(Stream stream)
    {
        Guard.AgainstNull(stream, nameof(stream));
        using (var document = new Workbook(stream))
        {
            VerifyWord(document);
        }
    }

    static ImageOrPrintOptions excelOptions = new ImageOrPrintOptions
    {
        ImageType = ImageType.Png
    };

    static void VerifyWord(Workbook document)
    {
        ApprovalException exception = null;
        for (var sheetIndex = 0; sheetIndex < document.Worksheets.Count; sheetIndex++)
        {
            var worksheet = document.Worksheets[sheetIndex];
            var sheetRender = new SheetRender(worksheet, excelOptions);
            for (var pageIndex = 0; pageIndex < sheetRender.PageCount; pageIndex++)
            {
                var pageNumber = pageIndex + 1;
                var sheetNumber = sheetIndex + 1;
                var name = $"{sheetNumber:D2}.{pageNumber:D2}";

                using (NamerFactory.AsEnvironmentSpecificTest(() => name))
                using (var outputStream = new MemoryStream())
                {
                    sheetRender.ToImage(pageIndex, outputStream);
                    VerifyBinary(outputStream, ref exception);
                }
            }
        }

        if (exception != null)
        {
            ExceptionDispatchInfo.Capture(exception).Throw();
        }
    }
}