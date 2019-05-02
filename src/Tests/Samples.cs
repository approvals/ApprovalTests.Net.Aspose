using AsposeApprovalTests;
using Xunit;
using Xunit.Abstractions;

public class Samples :
    XunitLoggingBase
{
    [Fact]
    public void VerifyPdf()
    {
        #region VerifyPdf

        AsposeApprovals.VerifyPdf("sample.pdf");

        #endregion
    }

    [Fact]
    public void VerifyWord()
    {
        #region VerifyWord

        AsposeApprovals.VerifyWord("sample.docx");

        #endregion
    }

    public Samples(ITestOutputHelper output) :
        base(output)
    {
    }
}