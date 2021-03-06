<Query Kind="Program" />

void Main()
{
	long bytes = 1073278976;
	
	var result = bytes / 1024.0 / 1024.0 / 1024.0;
	
	Math.Round(result,0).Dump("Manual");
	FormatBytes(bytes).Dump("FormatBytes");
}

private static string FormatBytes(long bytes)
{
    string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
    int i;
    double dblSByte = bytes;
    for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
        dblSByte = bytes / 1024.0;
    return String.Format("{0:0.##}{1}", dblSByte, Suffix[i]);
}

// Define other methods and classes here
