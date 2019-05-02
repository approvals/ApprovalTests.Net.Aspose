using System.IO;
using ApprovalTests;
using ApprovalTests.Core.Exceptions;

namespace AsposeApprovalTests
{
    public static partial class AsposeApprovals
    {
        static void VerifyBinary(MemoryStream outputStream)
        {
            outputStream.Position = 0;
            var array = outputStream.ToArray();
            Approvals.VerifyBinaryFile(array, ".png");
        }

        static void VerifyBinary(MemoryStream outputStream, int pageIndex, int count, string extension = ".png")
        {
            outputStream.Position = 0;
            var array = outputStream.ToArray();
            try
            {
                Approvals.VerifyBinaryFile(array, extension);
            }
            catch (ApprovalException)
            {
                if (pageIndex+1 == count)
                {
                    throw;
                }
            }
        }
    }
}