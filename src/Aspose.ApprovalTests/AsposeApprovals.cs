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

        static void VerifyBinary(MemoryStream outputStream, int pageIndex, int count)
        {
            outputStream.Position = 0;
            var array = outputStream.ToArray();
            try
            {
                Approvals.VerifyBinaryFile(array, ".png");
            }
            catch (ApprovalException)
            {
                if (pageIndex == count)
                {
                    throw;
                }
            }
        }
    }
}