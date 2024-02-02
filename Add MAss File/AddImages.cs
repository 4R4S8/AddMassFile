using System;
using System.IO;

namespace Add_MAss_File
{
    public class AddImages
    {
        public static void Add(string _pathFrom, string _pathTo)
        {
            string[] FromDirectories = Directory.GetFiles(_pathFrom, ".", SearchOption.AllDirectories);
            string[] ToDirectories = Directory.GetFiles(_pathTo, ".", SearchOption.AllDirectories);


            foreach (string file in FromDirectories)
            {
                // Check if the file is an image by its extension
                if (file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                {
                    // Get the relative path of the file from the first path
                    string relativePath = file.Substring(_pathFrom.Length + 1);

                    // Get the full path of the file in the second path
                    string newPath = Path.Combine(_pathTo, relativePath);

                    // Check if the file exists in the second path
                    if (!System.IO.File.Exists(newPath))
                    {
                        // Create the directory if it does not exist
                        Directory.CreateDirectory(Path.GetDirectoryName(newPath));

                        // Copy the file from the first path to the second path
                        System.IO.File.Copy(file, newPath);

                    }

                }
            }
        }
    }
}
