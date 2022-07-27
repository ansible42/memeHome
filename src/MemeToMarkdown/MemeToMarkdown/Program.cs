// See https://aka.ms/new-console-template for more information
using System.IO;


Console.WriteLine("makeing meme markdown");

string folder = "..\\..\\content";

FolderScan fs = new FolderScan(folder);
List<string> extensions = new List<string> { "*.png","*.jpg","*.gif"};

var lit = fs.ScanFolder(extensions);

foreach (var item in lit)
{
    Console.WriteLine($"{item}");
}

MtwoM md = new MtwoM("main/content");
string markdownFile = "# Fun Memes for code reviews \n \n";
foreach( var item in lit)
{
    markdownFile = $"{markdownFile} \n \n {md.CreateImageBlock(item)} ";
}

File.WriteAllText("test.md", markdownFile);