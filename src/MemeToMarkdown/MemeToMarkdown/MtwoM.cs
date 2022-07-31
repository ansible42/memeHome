// This class is intented to be a helper for prgroramatic generation of markdown files.  
public class MtwoM
{
    private string _relpath { get; set; }
    public MtwoM(string relpath = "main")
    {
       this._relpath = relpath;
    }

    string CreateMarkdownLink(string relPath)
    {
        return $"![{FullImagePath(relPath)}}]({FullImagePath(relPath)})"; ;
    }
    string FullImagePath(string relPath)
    {
        return $"{this._relpath}/{relPath}";
    }
    string CreateImagePreview(string relPath, int width)
    {
        return $"<img src=\"{FullImagePath(relPath)}\" width=\"{width}\">"; ;
    }
    public string CreateImageBlock(string Image)
    {

        return $"{CreateImagePreview(Image,250)}\n \n ```{CreateMarkdownLink(Image)}```";
    }
}

