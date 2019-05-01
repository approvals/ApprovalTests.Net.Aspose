<!--
This file was generate by MarkdownSnippets.
Source File: /readme.source.md
To change this file edit the source file and then re-run the generation using either the dotnet global tool (https://github.com/SimonCropp/MarkdownSnippets#markdownsnippetstool) or using the api (https://github.com/SimonCropp/MarkdownSnippets#running-as-a-unit-test).
-->
# <img src="https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/icon.png" height="40px"> ObjectApproval

Extends [ApprovalTests](https://github.com/approvals/ApprovalTests.Net) to allow approval of document via [Aspose](https://www.aspose.com/).


## The NuGet package [![NuGet Status](http://img.shields.io/nuget/v/Aspose.ApprovalTests.svg?style=flat)](https://www.nuget.org/packages/Aspose.ApprovalTests/)

https://nuget.org/packages/Aspose.ApprovalTests/

    PM> Install-Package Aspose.ApprovalTests


## Usage

### PDF

Assuming you have previously verified and approved using this.

<!-- snippet: VerifyPdf -->
```cs
AsposeApprovals.VerifyPdf("sample.pdf");
```
<sup>[snippet source](/src/Tests/Samples.cs#L10-L14)</sup>
<!-- endsnippet -->

Then you attempt to verify this the result is [Samples.VerifyPdf.approved.tiff](https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyPdf.approved.tiff):

<img src="https://raw.github.com/SimonCropp/Aspose.ApprovalTests/master/src/Tests/Samples.VerifyPdf.approved.tiff" height="200px">


## Icon

<a href="http://thenounproject.com/term/helmet/9554/" target="_blank">Helmet</a> designed by <a href="http://thenounproject.com/alterego" target="_blank">Leonidas Ikonomou</a> from The Noun Project
