﻿using System;
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
            Process.Start("https://github.com/Sirius902/LuaBackend/releases");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.lastgame = gameList.SelectedIndex;
            Settings.Default.Save();
        }
    }
}