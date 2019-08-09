<!--
GENERATED FILE - DO NOT EDIT
This file was generated by [MarkdownSnippets](https://github.com/SimonCropp/MarkdownSnippets).
Source File: /readme.source.md
To change this file edit the source file and then run MarkdownSnippets.
-->

# <img src="/src/icon.png" height="40px"> Aspose.ApprovalTests

Extends [ApprovalTests](https://github.com/approvals/ApprovalTests.Net) to allow approval of document via [Aspose](https://www.aspose.com/).

Converts documents (pdf, docx, xslx, pptx, md) to png for verification.

An [Aspose License](https://purchase.aspose.com/policies/license-types) is required to use this tool.

<!-- toc -->
## Contents

  * [NuGet package](#nuget-package)
  * [Usage](#usage)
    * [Markdown](#markdown)
    * [PDF](#pdf)
    * [Excel](#excel)
    * [Word](#word)
    * [PowerPoint](#powerpoint)
  * [File Samples](#file-samples)
  * [Icon](#icon)
<!-- endtoc -->



## NuGet package

https://nuget.org/packages/Aspose.ApprovalTests/ [![NuGet Status](http://img.shields.io/nuget/v/Aspose.ApprovalTests.svg)](https://www.nuget.org/packages/Aspose.ApprovalTests/)


## Usage


### Markdown

<!-- snippet: VerifyMarkdown -->
```cs
AsposeApprovals.VerifyMarkdown("sample.md");
```
<sup>[snippet source](/src/Tests/Samples.cs#L50-L54)</sup>
<!-- endsnippet -->

Two Files will be produced:

  * '.md' with the markdown contents
  * '.png' with the resultant html rendered as a png

Result:

[Samples.VerifyMarkdown.approved.md](/src/Tests/Samples.VerifyMarkdown.approved.md):

[Samples.VerifyMarkdown.approved.png](/src/Tests/Samples.VerifyMarkdown.approved.png):

<img src="/src/Tests/Samples.VerifyMarkdown.approved.png" width="200px">


### PDF

<!-- snippet: VerifyPdf -->
```cs
AsposeApprovals.VerifyPdf("sample.pdf");
```
<sup>[snippet source](/src/Tests/Samples.cs#L10-L14)</sup>
<!-- endsnippet -->

Result: [Samples.VerifyPdf.01.approved.png](/src/Tests/Samples.VerifyPdf.01.approved.png):

<img src="/src/Tests/Samples.VerifyPdf.01.approved.png" width="200px">


### Excel

<!-- snippet: VerifyExcel -->
```cs
AsposeApprovals.VerifyExcel("sample.xlsx");
```
<sup>[snippet source](/src/Tests/Samples.cs#L30-L34)</sup>
<!-- endsnippet -->

Result: [Samples.VerifyExcel.01.01.approved.png](/src/Tests/Samples.VerifyExcel.01.01.approved.png):

<img src="/src/Tests/Samples.VerifyExcel.01.01.approved.png" width="200px">


### Word

<!-- snippet: VerifyWord -->
```cs
AsposeApprovals.VerifyWord("sample.docx");
```
<sup>[snippet source](/src/Tests/Samples.cs#L40-L44)</sup>
<!-- endsnippet -->

Result: [Samples.VerifyWord.01.approved.png](/src/Tests/Samples.VerifyWord.01.approved.png):

<img src="/src/Tests/Samples.VerifyWord.01.approved.png" width="200px">


### PowerPoint

<!-- snippet: VerifyPowerPoint -->
```cs
AsposeApprovals.VerifyPowerPoint("sample.pptx");
```
<sup>[snippet source](/src/Tests/Samples.cs#L20-L24)</sup>
<!-- endsnippet -->

Result: [Samples.VerifyPowerPoint.01.approved.svg](/src/Tests/Samples.VerifyPowerPoint.01.approved.svg):


## File Samples

http://file-examples.com/


## Icon

[Swirl](https://thenounproject.com/term/swirl/1568686/) designed by [creativepriyanka](https://thenounproject.com/creativepriyanka) from [The Noun Project](https://thenounproject.com/creativepriyanka).
