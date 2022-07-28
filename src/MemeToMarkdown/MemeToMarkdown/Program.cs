// See https://aka.ms/new-console-template for more informa
using System.CommandLine;
using System.CommandLine.DragonFruit;
using System;

internal class Program
{
    /// <summary>
    /// Link Location maker 
    /// </summary>
    /// <param name="scanFolder">Folder to scan</param>
    /// <param name="repoLocation">the folder location of the repo </param>
    /// <param name="outputFile">Output file to write to</param>
    static void Main(string ?scanFolder = "../../content",
                    string ?repoLocation = "https://github.com/ansible42/memeHome",
                    string ?outputFile="test.md")
    {
        MakeMarkdown(scanFolder, repoLocation, outputFile); 
    }

    static void MakeMarkdown(string folderToScan, string repoURL, string outputFilepath)
    {
        FolderScan fs = new FolderScan(folderToScan);
        List<string> extensions = new List<string> { "*.png", "*.jpg", "*.gif" };

        var lit = fs.ScanFolder(extensions);

        MtwoM md = new MtwoM(repoURL);
        string markdownFile = "# Fun Memes for code reviews \n \n";
        Console.WriteLine("Files found to write");
        foreach (var item in lit)
        {
            Console.WriteLine($"{item}");
            markdownFile = $"{markdownFile} \n \n {md.CreateImageBlock(item)} ";
        }
        Console.WriteLine($"md written to {outputFilepath}");
        File.WriteAllText(outputFilepath, markdownFile);
    }
}

