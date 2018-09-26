# RTFToTextConverter

**[Nuget](https://www.nuget.org/packages/Avinch.RTFToText.dll/)**

Forked from https://github.com/Akturan/RTFToTextConverter to reduce the targeted .NET version from v4.5 to v4 to get round some pains in the ****. 

*Heads up: this package is unlikely to recieve any updates*

### RTF string to plain text

```
string str = RTFToText.converting().rtfFromString("RAW RTF HERE");
```

### RTF file to plain text

```
string str = RTFToText.converting().rtfFromFile(@"C:\Custom Library\test.rtf");
Console.WriteLine(str);
Console.ReadLine();
```
