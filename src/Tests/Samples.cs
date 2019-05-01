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

    public Samples(ITestOutputHelper output) :
        base(output)
    {
    }
}