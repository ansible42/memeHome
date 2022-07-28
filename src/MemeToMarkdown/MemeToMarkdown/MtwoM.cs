// This class is intented to be a helper for prgroramatic generation of markdown files.  
public class MtwoM
{
    private string _relpath { get; set; }
    public MtwoM(string relpath = "main")
    {
       this._relpath = relpath;
    }

    string CreateMarkdownLink(string Image)
    {
        return $"![{Image}]({this._relpath}/{Image})"; ;
    }
    public string CreateImageBlock(string Image)
    {
        string ImageLink = CreateMarkdownLink(Image);
        return $"{ImageLink}\n \n ```{ImageLink}```";
    }
}

