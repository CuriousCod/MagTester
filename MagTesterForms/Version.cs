using System.Reflection;

namespace MagTesterForms;

public static class Version
{
    public static string GetBuildDate()
    {
        var baseDirectory = AppContext.BaseDirectory;
        var fileInfo = new FileInfo(Path.Combine(baseDirectory, AppDomain.CurrentDomain.FriendlyName + ".exe"));
        return fileInfo.LastWriteTimeUtc.ToString("yyyy-MM-dd HH:mm:ss");
    }
}