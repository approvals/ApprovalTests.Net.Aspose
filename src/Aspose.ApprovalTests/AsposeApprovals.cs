using System.IO;
using ApprovalTests;
using ApprovalTests.Core.Exceptions;

namespace AsposeApprovalTests
{
    public static partial class AsposeApprovals
    {
        static void VerifyBinary(MemoryStream outputStream, int pageIndex, int count)
        {
            try
            {
                outputStream.Position = 0;
                Approvals.VerifyBinaryFile(outputStream.ToArray(), ".png");
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