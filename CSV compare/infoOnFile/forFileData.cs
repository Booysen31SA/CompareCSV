using System;

namespace CSV_compare.infoOnFile
{
    internal class forFileData
    {
        public String Extension(String extension)
        {
            String createdTime = Convert.ToString(extension);
            return createdTime;
        }

        public String FileLastCreated(DateTime created)
        {
            String createdTime = Convert.ToString(created);
            return createdTime;
        }

        public String LastModified(DateTime modified)
        {
            String createdTime = Convert.ToString(modified);
            return createdTime;
        }

        public String FileSize(long size)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = size;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }
    }
}