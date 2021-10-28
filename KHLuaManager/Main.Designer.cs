﻿
namespace KHLuaManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gameList = new System.Windows.Forms.ComboBox();
            this.scriptBox = new System.Windows.Forms.ListBox();
            this.dscriptBox = new System.Windows.Forms.ListBox();
            this.removescript = new System.Windows.Forms.Button();
            this.addscript = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFolder = new System.Windows.Forms.Button();
            this.reloadScripts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadLink = new System.Windows.Forms.LinkLabel();
            this.kh_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.run_kh1 = new System.Windows.Forms.Button();
            this.run_kh2 = new System.Windows.Forms.Button();
            this.run_com = new System.Windows.Forms.Button();
            this.run_bbs = new System.Windows.Forms.Button();
            this.run_khlauncher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameList
            // 
            this.gameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameList.FormattingEnabled = true;
            this.gameList.Items.AddRange(new object[] {
            "Kingdom Hearts",
            "Kingdom Hearts II",
            "Kingdom Hearts Re:Chain of Memories",
            "Kingdom Hearts: Birth by Sleep"});
            this.gameList.Location = new System.Drawing.Point(15, 12);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(489, 21);
            this.gameList.TabIndex = 0;
            this.gameList.SelectedIndexChanged += new System.EventHandler(this.gameList_SelectedIndexChanged);
            // 
            // scriptBox
            // 
            this.scriptBox.BackColor = System.Drawing.SystemColors.Control;
            this.scriptBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scriptBox.FormattingEnabled = true;
            this.scriptBox.Location = new System.Drawing.Point(15, 58);
            this.scriptBox.Name = "scriptBox";
            this.scriptBox.Size = new System.Drawing.Size(221, 355);
            this.scriptBox.TabIndex = 1;
            this.scriptBox.DoubleClick += new System.EventHandler(this.scriptBox_DoubleClick);
            // 
            // dscriptBox
            // 
            this.dscriptBox.BackColor = System.Drawing.SystemColors.Control;
            this.dscriptBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dscriptBox.FormattingEnabled = true;
            this.dscriptBox.Location = new System.Drawing.Point(283, 58);
            this.dscriptBox.Name = "dscriptBox";
            this.dscriptBox.Size = new System.Drawing.Size(221, 355);
            this.dscriptBox.TabIndex = 2;
            this.dscriptBox.DoubleClick += new System.EventHandler(this.dscriptBox_DoubleClick);
            // 
            // removescript
            // 
            this.removescript.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removescript.Location = new System.Drawing.Point(242, 58);
            this.removescript.Name = "removescript";
            this.removescript.Size = new System.Drawing.Size(35, 106);
            this.removescript.TabIndex = 3;
            this.removescript.Text = ">";
            this.removescript.UseVisualStyleBackColor = true;
            this.removescript.Click += new System.EventHandler(this.removescript_Click);
            // 
            // addscript
            // 
            this.addscript.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addscript.Location = new System.Drawing.Point(242, 307);
            this.addscript.Name = "addscript";
            this.addscript.Size = new System.Drawing.Size(35, 106);
            this.addscript.TabIndex = 4;
            this.addscript.Text = "<";
            this.addscript.UseVisualStyleBackColor = true;
            this.addscript.Click += new System.EventHandler(this.addscript_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enabled Scripts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(280, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Disabled Scripts";
            // 
            // openFolder
            // 
            this.openFolder.Location = new System.Drawing.Point(15, 419);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(489, 23);
            this.openFolder.TabIndex = 7;
            this.openFolder.Text = "Open Script Folder";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // reloadScripts
            // 
            this.reloadScripts.Location = new System.Drawing.Point(15, 448);
            this.reloadScripts.Name = "reloadScripts";
            this.reloadScripts.Size = new System.Drawing.Size(489, 23);
            this.reloadScripts.TabIndex = 8;
            this.reloadScripts.Text = "Reload Scripts";
            this.reloadScripts.UseVisualStyleBackColor = true;
            this.reloadScripts.Click += new System.EventHandler(this.reloadScripts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "This program is supposed to accommodate with Sirius902\'s LuaBackend fork.";
            // 
            // downloadLink
            // 
            this.downloadLink.AutoSize = true;
            this.downloadLink.Location = new System.Drawing.Point(453, 474);
            this.downloadLink.Name = "downloadLink";
            this.downloadLink.Size = new System.Drawing.Size(55, 13);
            this.downloadLink.TabIndex = 10;
            this.downloadLink.TabStop = true;
            this.downloadLink.Text = "Download";
            this.downloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.downloadLink_LinkClicked);
            // 
            // kh_path
            // 
            this.kh_path.Location = new System.Drawing.Point(15, 513);
            this.kh_path.Name = "kh_path";
            this.kh_path.Size = new System.Drawing.Size(221, 20);
            this.kh_path.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "KH Path (Where all .exe\'s are stored)";
            // 
            // run_kh1
            // 
            this.run_kh1.Location = new System.Drawing.Point(242, 511);
            this.run_kh1.Name = "run_kh1";
            this.run_kh1.Size = new System.Drawing.Size(62, 23);
            this.run_kh1.TabIndex = 13;
            this.run_kh1.Text = "Run KH1";
            this.run_kh1.UseVisualStyleBackColor = true;
            this.run_kh1.Click += new System.EventHandler(this.run_kh1_Click);
            // 
            // run_kh2
            // 
            this.run_kh2.Location = new System.Drawing.Point(310, 511);
            this.run_kh2.Name = "run_kh2";
            this.run_kh2.Size = new System.Drawing.Size(62, 23);
            this.run_kh2.TabIndex = 14;
            this.run_kh2.Text = "Run KH2";
            this.run_kh2.UseVisualStyleBackColor = true;
            this.run_kh2.Click += new System.EventHandler(this.run_kh2_Click);
            // 
            // run_com
            // 
            this.run_com.Location = new System.Drawing.Point(378, 511);
            this.run_com.Name = "run_com";
            this.run_com.Size = new System.Drawing.Size(62, 23);
            this.run_com.TabIndex = 15;
            this.run_com.Text = "Run CoM";
            this.run_com.UseVisualStyleBackColor = true;
            this.run_com.Click += new System.EventHandler(this.run_com_Click);
            // 
            // run_bbs
            // 
            this.run_bbs.Location = new System.Drawing.Point(446, 511);
            this.run_bbs.Name = "run_bbs";
            this.run_bbs.Size = new System.Drawing.Size(62, 23);
            this.run_bbs.TabIndex = 16;
            this.run_bbs.Text = "Run BBS";
            this.run_bbs.UseVisualStyleBackColor = true;
            this.run_bbs.Click += new System.EventHandler(this.run_bbs_Click);
            // 
            // run_khlauncher
            // 
            this.run_khlauncher.Location = new System.Drawing.Point(242, 540);
            this.run_khlauncher.Name = "run_khlauncher";
            this.run_khlauncher.Size = new System.Drawing.Size(266, 31);
            this.run_khlauncher.TabIndex = 17;
            this.run_khlauncher.Text = "Run KINGDOM HEARTS HD 1.5+2.5 Launcher";
            this.run_khlauncher.UseVisualStyleBackColor = true;
            this.run_khlauncher.Click += new System.EventHandler(this.run_khlauncher_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 49);
            this.label5.TabIndex = 18;
            this.label5.Text = "Running a game without the launcher only works for the pirated version of the gam" +
    "e.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 583);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.run_khlauncher);
            this.Controls.Add(this.run_bbs);
            this.Controls.Add(this.run_com);
            this.Controls.Add(this.run_kh2);
            this.Controls.Add(this.run_kh1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kh_path);
            this.Controls.Add(this.downloadLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reloadScripts);
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addscript);
            this.Controls.Add(this.removescript);
            this.Controls.Add(this.dscriptBox);
            this.Controls.Add(this.scriptBox);
            this.Controls.Add(this.gameList);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Kingdom Hearts LUA Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gameList;
        private System.Windows.Forms.ListBox scriptBox;
        private System.Windows.Forms.ListBox dscriptBox;
        private System.Windows.Forms.Button removescript;
        private System.Windows.Forms.Button addscript;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.Button reloadScripts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel downloadLink;
        private System.Windows.Forms.TextBox kh_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button run_kh1;
        private System.Windows.Forms.Button run_kh2;
        private System.Windows.Forms.Button run_com;
        private System.Windows.Forms.Button run_bbs;
        private System.Windows.Forms.Button run_khlauncher;
        private System.Windows.Forms.Label label5;
    }
}

