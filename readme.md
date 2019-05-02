<!--
This file was generate by MarkdownSnippets.
Source File: /readme.source.md
To change this file edit the source file and then re-run the generation using either the dotnet global tool (https://github.com/SimonCropp/MarkdownSnippets#markdownsnippetstool) or using the api (https://github.com/SimonCropp/MarkdownSnippets#running-as-a-unit-test).
-->
# <img src="https://raw.githubusercontent.com/SimonCropp/Aspose.ApprovalTests/master/icon.png" height="40px"> Aspose.ApprovalTests

Extends [ApprovalTests](https://github.com/approvals/ApprovalTests.Net) to allow approval of document via [Aspose](https://www.aspose.com/).

Converts documents (pdf, docx, xslx, pptx) to png for verification.

An [Aspose License](https://purchase.aspose.com/policies/license-types) is required to use this tool.


## The NuGet package [![NuGet Status](http://img.shields.io/nuget/v/Aspose.ApprovalTests.svg?style=flat)](https://www.nuget.org/packages/Aspose.ApprovalTests/)

https://nuget.org/packages/Aspose.ApprovalTests/

    PM> Install-Package Aspose.ApprovalTests


## Usage


### PDF

<!-- snippet: VerifyPdf -->
```cs
AsposeApprovals.VerifyPdf("sample.pdf");
```
<sup>[snippet source](/src/Tests/Samples.cs#L11-L15)</sup>
<!-- endsnippet -->

Result: [Samples.VerifyPdf.01.approved.png](https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyPdf.01.approved.png):

<img src="https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyPdf.01.approved.png" width="200px">


### Excel

<!-- snippet: VerifyExcel -->
```cs
AsposeApprovals.VerifyExcel("sample.xlsx");
```
<sup>[snippet source](/src/Tests/Samples.cs#L31-L35)</sup>
<!-- endsnippet -->

Result: [Samples.VerifyExcel.01.01.approved.png](https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyExcel.01.01.approved.png):

<img src="https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyExcel.01.01.approved.png" width="200px">


### Word

<!-- snippet: VerifyWord -->
```cs
AsposeApprovals.VerifyWord("sample.docx");
```
<sup>[snippet source](/src/Tests/Samples.cs#L41-L45)</sup>
<!-- endsnippet -->

Result: [Samples.VerifyWord.01.approved.png](https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyWord.01.approved.png):

<img src="https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyWord.01.approved.png" width="200px">


### PowerPoint

<!-- snippet: VerifyPowerPoint -->
```cs
AsposeApprovals.VerifyPowerPoint("sample.pptx");
```
<sup>[snippet source](/src/Tests/Samples.cs#L21-L25)</sup>
<!-- endsnippet -->

Result: [Samples.VerifyPowerPoint.01.approved.svg](https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyPowerPoint.01.approved.svg):



## File Samples

http://file-examples.com/


## Icon

<a href="http://thenounproject.com/term/swirl/1568686/" target="_blank">Swirl</a> designed by <a href="http://thenounproject.com/creativepriyanka" target="_blank">creativepriyanka</a> from The Noun Project
