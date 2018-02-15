using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace People.UWP
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            string path = global::Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            return System.IO.Path.Combine(path, filename);
        }
    }
}