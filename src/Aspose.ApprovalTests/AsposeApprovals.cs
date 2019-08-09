using System.IO;
using ApprovalTests;
using ApprovalTests.Core.Exceptions;
using ApprovalTests.Writers;

public static partial class AsposeApprovals
{
    static void VerifyBinary(MemoryStream outputStream, ref ApprovalException exception, string extension = ".png")
    {
        outputStream.Position = 0;
        var array = outputStream.ToArray();
        try
        {
            Approvals.VerifyBinaryFile(array, extension);
        }
        catch (ApprovalException approvalException)
        {
            exception = approvalException;
        }
    }

    static void VerifyMarkdownFile(string path, ref ApprovalException exception)
    {
        try
        {
            Approvals.Verify(WriterFactory.CreateTextWriter(File.ReadAllText(path), "md"));
        }
        catch (ApprovalException approvalException)
        {
            exception = approvalException;
        }
    }
}