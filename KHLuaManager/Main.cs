using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using KHLuaManager.Properties;

namespace KHLuaManager
{
    public partial class Main : Form
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\KINGDOM HEARTS HD 1.5+2.5 ReMIX\";
        public Main()
        {
            InitializeComponent();
            gameList.SelectedIndex = Settings.Default.lastgame;
            Directory.CreateDirectory(path + @"scripts\kh1\disabled");
            Directory.CreateDirectory(path + @"scripts\recom\disabled");
            Directory.CreateDirectory(path + @"scripts\kh2\disabled");
            Directory.CreateDirectory(path + @"scripts\bbs\disabled");
        }

        private void LoadKH1()
        {
            scriptBox.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(path + @"\scripts\kh1");
            try
            {
                FileInfo[] Files = d.GetFiles("*.lua");
                foreach (FileInfo file in Files)
                    scriptBox.Items.Add(file.Name);

                dscriptBox.Items.Clear();
                DirectoryInfo dd = new DirectoryInfo(path + @"\scripts\kh1\disabled");
                FileInfo[] Filesd = dd.GetFiles("*.lua");
                foreach (FileInfo file in Filesd)
                    dscriptBox.Items.Add(file.Name);
            }
            catch
            {

            }
        }

        private void LoadKH2()
        {
            scriptBox.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(path + @"\scripts\kh2");
            try
            {
                FileInfo[] Files = d.GetFiles("*.lua");
                foreach (FileInfo file in Files)
                    scriptBox.Items.Add(file.Name);

                dscriptBox.Items.Clear();
                DirectoryInfo dd = new DirectoryInfo(path + @"\scripts\kh2\disabled");
                FileInfo[] Filesd = dd.GetFiles("*.lua");
                foreach (FileInfo file in Filesd)
                    dscriptBox.Items.Add(file.Name);
            }
            catch
            {

            }
        }

        private void LoadKHCOM()
        {
            scriptBox.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(path + @"\scripts\recom");
            try
            {
                FileInfo[] Files = d.GetFiles("*.lua");
                foreach (FileInfo file in Files)
                    scriptBox.Items.Add(file.Name);

                dscriptBox.Items.Clear();
                DirectoryInfo dd = new DirectoryInfo(path + @"\scripts\recom\disabled");
                FileInfo[] Filesd = dd.GetFiles("*.lua");
                foreach (FileInfo file in Filesd)
                    dscriptBox.Items.Add(file.Name);
            }
            catch
            {

            }
        }

        private void LoadKHBBS()
        {
            scriptBox.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(path + @"\scripts\bbs");
            try
            {
                FileInfo[] Files = d.GetFiles("*.lua");
                foreach (FileInfo file in Files)
                    scriptBox.Items.Add(file.Name);

                dscriptBox.Items.Clear();
                DirectoryInfo dd = new DirectoryInfo(path + @"\scripts\bbs\disabled");
                FileInfo[] Filesd = dd.GetFiles("*.lua");
                foreach (FileInfo file in Filesd)
                    dscriptBox.Items.Add(file.Name);
            }
            catch
            {

            }
        }

        private void gameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            if (gameList.SelectedIndex == 0)
                LoadKH1();
            else if (gameList.SelectedIndex == 1)
                LoadKH2();
            else if (gameList.SelectedIndex == 2)
                LoadKHCOM();
            else if (gameList.SelectedIndex == 3)
                LoadKHBBS();
            else
                MessageBox.Show("Invalid game");
        }

        private void addscript_Click(object sender, EventArgs e)
        {
            string item = dscriptBox.GetItemText(dscriptBox.SelectedItem);
            if (item.Length < 1)
                return;
            if (gameList.SelectedIndex == 0)
                File.Move(path + $@"\scripts\kh1\disabled\{item}", path + $@"\scripts\kh1\{item}");
            else if (gameList.SelectedIndex == 1)
                File.Move(path + $@"\scripts\kh2\disabled\{item}", path + $@"\scripts\kh2\{item}");
            else if (gameList.SelectedIndex == 2)
                File.Move(path + $@"\scripts\recom\disabled\{item}", path + $@"\scripts\recom\{item}");
            else if (gameList.SelectedIndex == 3)
                File.Move(path + $@"\scripts\bbs\disabled\{item}", path + $@"\scripts\bbs\{item}");
            else
                MessageBox.Show("Invalid game");
            Reload();
        }

        private void removescript_Click(object sender, EventArgs e)
        {
            string item = scriptBox.GetItemText(scriptBox.SelectedItem);
            if (item.Length < 1)
                return;
            if (gameList.SelectedIndex == 0)
                File.Move(path + $@"\scripts\kh1\{item}", path + $@"\scripts\kh1\disabled\{item}");
            else if (gameList.SelectedIndex == 1)
                File.Move(path + $@"\scripts\kh2\{item}", path + $@"\scripts\kh2\disabled\{item}");
            else if (gameList.SelectedIndex == 2)
                File.Move(path + $@"\scripts\recom\{item}", path + $@"\scripts\recom\disabled\{item}");
            else if (gameList.SelectedIndex == 3)
                File.Move(path + $@"\scripts\bbs\{item}", path + $@"\scripts\bbs\disabled\{item}");
            Reload();
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo() { FileName = path + @"\scripts", UseShellExecute = true };
            Process.Start(psi);
        }

        private void reloadScripts_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void scriptBox_DoubleClick(object sender, EventArgs e)
        {
            if (scriptBox.SelectedItem != null)
            {
                if (gameList.SelectedIndex == 0)
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo(path + $@"\scripts\kh1\" + scriptBox.SelectedItem.ToString())
                        {
                            UseShellExecute = true
                        }
                    }.Start();
                }
                else if (gameList.SelectedIndex == 1)
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo(path + $@"\scripts\kh2\" + scriptBox.SelectedItem.ToString())
                        {
                            UseShellExecute = true
                        }
                    }.Start();
                }
                else if (gameList.SelectedIndex == 2)
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo(path + $@"\scripts\recom\" + scriptBox.SelectedItem.ToString())
                        {
                            UseShellExecute = true
                        }
                    }.Start();
                }
                else if (gameList.SelectedIndex == 3)
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo(path + $@"\scripts\bbs\" + scriptBox.SelectedItem.ToString())
                        {
                            UseShellExecute = true
                        }
                    }.Start();
                }
            }
        }

        private void dscriptBox_DoubleClick(object sender, EventArgs e)
        {
            if (dscriptBox.SelectedItem != null)
            {
                if (dscriptBox.SelectedIndex == 0)
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo(path + $@"\scripts\kh1\disabled\" + dscriptBox.SelectedItem.ToString())
                        {
                            UseShellExecute = true
                        }
                    }.Start();
                }
                else if (gameList.SelectedIndex == 1)
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo(path + $@"\scripts\kh2\disabled\" + dscriptBox.SelectedItem.ToString())
                        {
                            UseShellExecute = true
                        }
                    }.Start();
                }
                else if (gameList.SelectedIndex == 2)
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo(path + $@"\scripts\recom\disabled\" + dscriptBox.SelectedItem.ToString())
                        {
                            UseShellExecute = true
                        }
                    }.Start();
                }
                else if (gameList.SelectedIndex == 3)
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo(path + $@"\scripts\bbs\disabled\" + dscriptBox.SelectedItem.ToString())
                        {
                            UseShellExecute = true
                        }
                    }.Start();
                }
            }
        }

        private void downloadLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            new Process
            {
                StartInfo = new ProcessStartInfo("https://github.com/Sirius902/LuaBackend/releases")
                {
                    UseShellExecute = true
                }
            }.Start();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.lastgame = gameList.SelectedIndex;
            Settings.Default.Save();
        }

        private void run_kh1_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo( $@"{Settings.Default.gamepath}\KINGDOM HEARTS FINAL MIX.exe")
                {
                    UseShellExecute = false
                }
            }.Start();
        }

        private void run_kh2_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo($@"{Settings.Default.gamepath}\KINGDOM HEARTS II FINAL MIX.exe")
                {
                    UseShellExecute = false
                }
            }.Start();
        }

        private void run_com_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo($@"{Settings.Default.gamepath}\KINGDOM HEARTS Re_Chain of Memories.exe")
                {
                    UseShellExecute = false
                }
            }.Start();
        }

        private void run_bbs_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo($@"{Settings.Default.gamepath}\KINGDOM HEARTS Birth by Sleep FINAL MIX.exe")
                {
                    UseShellExecute = false
                }
            }.Start();
        }

        private void run_khlauncher_Click(object sender, EventArgs e)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo($@"{Settings.Default.gamepath}\KINGDOM HEARTS HD 1.5+2.5 ReMIX.exe")
                {
                    UseShellExecute = false
                }
            }.Start();
        }

        private void set_khpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please select the KH1.5+2.5 folder.";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.gamepath = fbd.SelectedPath;
                Settings.Default.Save();
                MessageBox.Show("Path has been set.");
            }
        }

        private void scriptBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;

        }

        private void scriptBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string filename = Path.GetFileName(file);
                if (!filename.EndsWith(".lua"))
                {
                    MessageBox.Show("Invalid file type.\nPlease only use .lua files.");
                    return;
                }
                if (gameList.SelectedIndex == 0)
                    File.Move(file, path + $@"\scripts\kh1\{filename}");
                else if (gameList.SelectedIndex == 1)
                    File.Move(file, path + $@"\scripts\kh2\{filename}");
                else if (gameList.SelectedIndex == 2)
                    File.Move(file, path + $@"\scripts\recom\{filename}");
                else if (gameList.SelectedIndex == 3)
                    File.Move(file, path + $@"\scripts\bbs\{filename}");
                Reload();
            }
        }

        private void dscriptBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void dscriptBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string filename = Path.GetFileName(file);
                if (!filename.EndsWith(".lua"))
                {
                    MessageBox.Show("Invalid file type.\nPlease only use .lua files.");
                    return;
                }
                if (gameList.SelectedIndex == 0)
                    File.Move(file, path + $@"\scripts\kh1\disabled\{filename}");
                else if (gameList.SelectedIndex == 1)
                    File.Move(file, path + $@"\scripts\kh2\disabled\{filename}");
                else if (gameList.SelectedIndex == 2)
                    File.Move(file, path + $@"\scripts\recom\disabled\{filename}");
                else if (gameList.SelectedIndex == 3)
                    File.Move(file, path + $@"\scripts\bbs\disabled\{filename}");
                Reload();
            }
        }

        private void scriptDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gameList.SelectedIndex == 0)
                    File.Delete(path + $@"\scripts\kh1\{scriptBox.GetItemText(scriptBox.SelectedItem)}");
                else if (gameList.SelectedIndex == 1)
                    File.Delete(path + $@"\scripts\kh2\{scriptBox.GetItemText(scriptBox.SelectedItem)}");
                else if (gameList.SelectedIndex == 2)
                    File.Delete(path + $@"\scripts\recom\{scriptBox.GetItemText(scriptBox.SelectedItem)}");
                else if (gameList.SelectedIndex == 3)
                    File.Delete(path + $@"\scripts\bbs\{scriptBox.GetItemText(scriptBox.SelectedItem)}");
                Reload();
            }
            catch
            {
                MessageBox.Show("You didn't select a file.");
            }
        }

        private void dscriptDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gameList.SelectedIndex == 0)
                    File.Delete(path + $@"\scripts\kh1\disabled\{dscriptBox.GetItemText(dscriptBox.SelectedItem)}");
                else if (gameList.SelectedIndex == 1)
                    File.Delete(path + $@"\scripts\kh2\disabled\{dscriptBox.GetItemText(dscriptBox.SelectedItem)}");
                else if (gameList.SelectedIndex == 2)
                    File.Delete(path + $@"\scripts\recom\disabled\{dscriptBox.GetItemText(dscriptBox.SelectedItem)}");
                else if (gameList.SelectedIndex == 3)
                    File.Delete(path + $@"\scripts\bbs\disabled\{dscriptBox.GetItemText(dscriptBox.SelectedItem)}");
                Reload();
            }
            catch
            {
                MessageBox.Show("You didn't select a file.");
            }
        }
    }
}