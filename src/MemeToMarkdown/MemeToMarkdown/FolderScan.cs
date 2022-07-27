
public class FolderScan
{
	private string _folder { get; set; }
	public FolderScan(string folder)
	{
		_folder = folder;

	}
	public List<string> ScanFolder (List<string> filePattern)
	{
        DirectoryInfo di = new DirectoryInfo(this._folder);
        List<string> result = new List<string>();
		foreach(string extension in filePattern)
		{
			foreach(var file in di.EnumerateFiles(extension))
			{
				result.Add(file.Name);
			}
		}

		return result;
	}
}
