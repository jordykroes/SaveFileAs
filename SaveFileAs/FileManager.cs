using System.IO;
using System.Windows.Forms;

namespace SaveFileAs
{
    internal class FileManager
    {
        public static bool SaveFileAs(string sourcePath, string outputName, string directoryPath)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                FileName = outputName,
                InitialDirectory = directoryPath,
                Filter = "pdf (*.pdf)|",
                AddExtension = true,
                DefaultExt = ".pdf"
            };

            using (saveFileDialog)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveFile(sourcePath, saveFileDialog.FileName);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private static void SaveFile(string sourcePath, string destinationPath)
        {
            if (File.Exists(destinationPath))
            {
                File.Delete(destinationPath);
            }

            File.Copy(sourcePath, destinationPath);
        }
    }
}