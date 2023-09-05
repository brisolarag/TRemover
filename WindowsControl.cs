using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRemover
{
    public class WindowsControl
    {
        #region FileDelete Method
        public static int FileDelete (string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            int i = 0; 

            foreach (FileInfo file in directory.EnumerateFiles())
            {
                try
                {
                    file.Delete();
                    i++;
                }
                catch (IOException ex)
                {
                    // Lidar com exceção de arquivo em uso, por exemplo, registrar ou exibir uma mensagem
                    Console.WriteLine($"Não foi possível excluir o arquivo '{file.FullName}' devido a um erro: {ex.Message}");
                }
            }

            foreach (DirectoryInfo dir in directory.EnumerateDirectories())
            {
                try
                {
                    dir.Delete(true);
                    i++;
                }
                catch (IOException ex)
                {
                    // Lidar com exceção de diretório em uso, por exemplo, registrar ou exibir uma mensagem
                    Console.WriteLine($"Não foi possível excluir o diretório '{dir.FullName}' devido a um erro: {ex.Message}");
                }
            }
            return i;
        }
        #endregion

        #region FullPath %Temp%
        public static string FullPathTempP(string uUser)
        {
            return Path.Combine(@"C:\Users", uUser, "AppData", "Local", "Temp");
        }
        #endregion
    }
}

