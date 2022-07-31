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
    string CreateMarkdownPreview(string Image, int width)
    {
        return $"<img src=\"{Image}\" width=\"{width}\">"; ;
    }
    public string CreateImageBlock(string Image)
    {

        return $"{CreateMarkdownPreview(Image,250)}\n \n ```{CreateMarkdownLink(Image)}```";
    }
}

