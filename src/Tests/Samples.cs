using System;
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
    public void VerifyPowerPoint()
    {
        #region VerifyPowerPoint

        AsposeApprovals.VerifyPowerPoint("sample.pptx");

        #endregion
    }

    [Fact]
    public void VerifyExcel()
    {
        #region VerifyExcel

       // AsposeApprovals.VerifyExcel("sample.xlsx");

        #endregion
    }

    [Fact]
    public void VerifyWord()
    {
        #region VerifyWord

        AsposeApprovals.VerifyWord("sample.docx");

        #endregion
    }

    [Fact]
    public void VerifyMarkdown()
    {
        #region VerifyMarkdown
        try
        {

            AsposeApprovals.VerifyMarkdown("sample.md");
        }
        catch
        {
        }

        #endregion
    }

    [Fact]
    public void VerifyMarkdownText()
    {
        #region VerifyMarkdownText
        //AsposeApprovals.VerifyMarkdownText("## Header");

        #endregion
    }

    public Samples(ITestOutputHelper output) :
        base(output)
    {
    }
}