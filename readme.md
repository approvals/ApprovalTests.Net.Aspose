<!--
This file was generate by MarkdownSnippets.
Source File: /readme.source.md
To change this file edit the source file and then re-run the generation using either the dotnet global tool (https://github.com/SimonCropp/MarkdownSnippets#markdownsnippetstool) or using the api (https://github.com/SimonCropp/MarkdownSnippets#running-as-a-unit-test).
-->
# <img src="https://raw.githubusercontent.com/SimonCropp/Aspose.ApprovalTests/master/icon.png" height="40px"> ObjectApproval

Extends [ApprovalTests](https://github.com/approvals/ApprovalTests.Net) to allow approval of document via [Aspose](https://www.aspose.com/).

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

Result: [Samples.VerifyPdf.approved.tiff](https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyPdf.approved.tiff):

<img src="https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyPdf.approved.tiff" height="200px">


### Word

<!-- snippet: VerifyWord -->
```cs
AsposeApprovals.VerifyWord("sample.docx");
```
<sup>[snippet source](/src/Tests/Samples.cs#L21-L25)</sup>
<!-- endsnippet -->

Result: [Samples.v.approved.tiff](https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyWord.approved.tiff):

<img src="https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyWord.approved.tiff" height="200px">


## File Samples

http://file-examples.com/

## Icon

<a href="http://thenounproject.com/term/swirl/1568686/" target="_blank">Swirl</a> designed by <a href="http://thenounproject.com/creativepriyanka" target="_blank">creativepriyanka</a> from The Noun Project
