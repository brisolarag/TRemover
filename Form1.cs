using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRemover
{
    public partial class Form1 : Form
    {
        string pcUser = Environment.UserName;


        public List<string> Paths = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/brisolarag");
            AdicionaTempP();            // adiciona %temp%
            AdicionaTemp();             // adiciona temp
            AdicionaPrefetch();         // adiciona Prefetch
            AdicionaWinAttTempFiles();  // adiciona Software Distribution Download

            AtualizarListBox();
        }



        #region Buttons
        private void buttonDelete_Click(object sender, EventArgs e) // Botao principal
        {
            int totalArquivosExcluidos = 0; // Variável para rastrear o total de arquivos excluídos

            foreach (string f in Paths.ToList()) // Usamos ToList para criar uma cópia da lista Paths
            {
                try
                {
                    int excluidos = WindowsControl.FileDelete(f);
                    totalArquivosExcluidos += excluidos;
                    Paths.Remove(f);
                }
                catch (UnauthorizedAccessException ex)
                {
                    // Lidar com a exceção de acesso não autorizado, por exemplo, registrar ou exibir uma mensagem
                    Console.WriteLine($"Não foi possível excluir '{f}' devido a permissões insuficientes: {ex.Message}");
                }
            }

            MessageBox.Show($"Total de arquivos excluídos: {totalArquivosExcluidos}");
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string pathSent = textBoxPath.Text;
            Paths.Add(pathSent);
            AtualizarListBox();
            textBoxPath.Text = null;
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxPaths.SelectedIndex != -1)
            {
                string selectedValue = listBoxPaths.GetItemText(listBoxPaths.SelectedItem);

                Paths.Remove(selectedValue);
                AtualizarListBox();
            }
        }

        #endregion

        #region CheckBoxes
        private void checkBoxTempP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTempP.Checked)
            {
                AdicionaTempP(); // adiciona %temp%
                AtualizarListBox();
            } else
            {
                if (Paths.Contains(WindowsControl.FullPathTempP(pcUser)))
                {
                    RemoveTempP();// remove %temp%
                    AtualizarListBox();
                } else { return; }
            }
            
        }


        private void checkBoxTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTemp.Checked)
            {
                AdicionaTemp(); // adiciona temp
                AtualizarListBox();
            }
            else
            {
                if (Paths.Contains(@"C:\Windows\Temp"))
                {
                    RemoveTemp();// remove temp
                    AtualizarListBox();
                }
                else { return; }
            }
        }

        private void checkBoxPrefetch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrefetch.Checked)
            {
                AdicionaPrefetch(); // adiciona Prefetch
                AtualizarListBox();
            }
            else
            {
                if (Paths.Contains(@"C:\Windows\Prefetch"))
                {
                    RemovePrefetch();// remove Prefetch
                    AtualizarListBox();
                }
                else { return; }
            }
        }
        private void checkBoxSoftwareDistributionDownload_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSoftwareDistributionDownload.Checked)
            {
                AdicionaWinAttTempFiles(); // adiciona Software.Download
                AtualizarListBox();
            }
            else
            {
                if (Paths.Contains(@"C:\Windows\SoftwareDistribution\Download"))
                {
                    RemoveWinAttTempFiles();// remove Software.Download
                    AtualizarListBox();
                }
                else { return; }
            }
        }
        #endregion

        #region AtualizarListBox()
        private void AtualizarListBox()
        {
            // Limpa a ListBox
            listBoxPaths.Items.Clear();

            // Adiciona os itens selecionados à ListBox
            foreach (string item in Paths)
            {
                listBoxPaths.Items.Add(item);
            }
        }
        #endregion
        #region AdicionaTempP() e RemoveTempP()
        public void AdicionaTempP()
        {
            Paths.Add(WindowsControl.FullPathTempP(pcUser));
        }
        public void RemoveTempP()
        {
            Paths.Remove(WindowsControl.FullPathTempP(pcUser));
        }
        #endregion
        #region AdicionaTemp() e RemoveTemp()
        public void AdicionaTemp()
        {
            Paths.Add(@"C:\Windows\Temp");
        }
        public void RemoveTemp()
        {
            Paths.Remove(@"C:\Windows\Temp");
        }
        #endregion 
        #region AdicionaPrefetch() e RemovePrefetch()
        public void AdicionaPrefetch()
        {
            Paths.Add(@"C:\Windows\Prefetch");
        }
        public void RemovePrefetch()
        {
            Paths.Remove(@"C:\Windows\Prefetch");
        }
        #endregion
        #region AdicinaWinAttTempFiles() e RemoveWinAttTempFiles()
        public void AdicionaWinAttTempFiles()
        {
            Paths.Add(@"C:\Windows\SoftwareDistribution\Download");
        }
        public void RemoveWinAttTempFiles()
        {
            Paths.Remove(@"C:\Windows\SoftwareDistribution\Download");
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
