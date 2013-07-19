using System;
using System.Collections.Generic;
using System.Text;

namespace BitrateFilter
{
    class BitrateInfo
    {
        private static Shell32.Shell shell = new Shell32.Shell();

        // From vista to 8 at least
        private static int bitrateAttribute = 28;

        public static int GetBitrate(string name, string path)
        {
            return getBitrate(name, path);
        }

        private static int getBitrate(string name, string path)
        {
            var folder = getFolderHandle(path);
            var file = getFileHandle(name, folder);

            if (file != null)
            {
                var bitrate = folder.GetDetailsOf(file, bitrateAttribute);
                if (bitrate != string.Empty)
                {
                    bitrate = bitrate.Substring(1, 3);
                    return int.Parse(bitrate);
                }
            }

            return -1;
        }

        private static Shell32.Folder getFolderHandle(string path)
        {
            return shell.NameSpace(path);
        }

        private static Shell32.FolderItem getFileHandle(string name, Shell32.Folder shellFolder)
        {
            return shellFolder.ParseName(name);
        }
    }
}
