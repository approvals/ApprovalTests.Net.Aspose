﻿using System.IO;
using ApprovalTests;
using ApprovalTests.Core.Exceptions;
using ApprovalTests.Namers;
using Aspose.Cells;
using Aspose.Cells.Drawing;
using Aspose.Cells.Rendering;

namespace AsposeApprovalTests
{
    public static partial class AsposeApprovals
    {
        public static void VerifyExcel(string path)
        {
            var document = new Workbook(path);
            {
                VerifyWord(document);
            }
        }

        public static void VerifyExcel(Stream stream)
        {
            using (var document = new Workbook(stream))
            {
                VerifyWord(document);
            }
        }

        static ImageOrPrintOptions options = new ImageOrPrintOptions
                {
                    ImageType = ImageType.Png
                };
        static void VerifyWord(Workbook document)
        {
            ApprovalException approvalException = null;
            for (var sheetIndex = 0; sheetIndex < document.Worksheets.Count; sheetIndex++)
            {
                var worksheet = document.Worksheets[sheetIndex];
                var sheetRender = new SheetRender(worksheet, options);
                for (var pageIndex = 0; pageIndex < sheetRender.PageCount; pageIndex++)
                {
                    var name = $"{sheetIndex + 1}.{pageIndex + 1}";
                    using (NamerFactory.AsEnvironmentSpecificTest(() => name))
                    using (var outputStream = new MemoryStream())
                    {
                        sheetRender.ToImage(pageIndex, outputStream);
                        outputStream.Position = 0;
                        var array = outputStream.ToArray();
                        try
                        {
                            Approvals.VerifyBinaryFile(array, ".png");
                        }
                        catch (ApprovalException exception)
                        {
                            approvalException = exception;
                        }
                    }
                }
            }

            if (approvalException != null)
            {
                throw approvalException;
            }
        }
    }
}