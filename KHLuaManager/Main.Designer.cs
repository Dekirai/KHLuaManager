
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gameList = new System.Windows.Forms.ComboBox();
            this.scriptBox = new System.Windows.Forms.ListBox();
            this.scriptContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.scriptDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dscriptBox = new System.Windows.Forms.ListBox();
            this.dscriptContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dscriptDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.removescript = new System.Windows.Forms.Button();
            this.addscript = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFolder = new System.Windows.Forms.Button();
            this.reloadScripts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadLink = new System.Windows.Forms.LinkLabel();
            this.run_kh1 = new System.Windows.Forms.Button();
            this.run_kh2 = new System.Windows.Forms.Button();
            this.run_com = new System.Windows.Forms.Button();
            this.run_bbs = new System.Windows.Forms.Button();
            this.run_khlauncher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.set_khpath = new System.Windows.Forms.Button();
            this.scriptContext.SuspendLayout();
            this.dscriptContext.SuspendLayout();
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
            this.scriptBox.AllowDrop = true;
            this.scriptBox.BackColor = System.Drawing.SystemColors.Control;
            this.scriptBox.ContextMenuStrip = this.scriptContext;
            this.scriptBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scriptBox.FormattingEnabled = true;
            this.scriptBox.Location = new System.Drawing.Point(15, 58);
            this.scriptBox.Name = "scriptBox";
            this.scriptBox.Size = new System.Drawing.Size(221, 355);
            this.scriptBox.TabIndex = 1;
            this.scriptBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.scriptBox_DragDrop);
            this.scriptBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.scriptBox_DragEnter);
            this.scriptBox.DoubleClick += new System.EventHandler(this.scriptBox_DoubleClick);
            // 
            // scriptContext
            // 
            this.scriptContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptDelete});
            this.scriptContext.Name = "scriptContext";
            this.scriptContext.Size = new System.Drawing.Size(140, 26);
            // 
            // scriptDelete
            // 
            this.scriptDelete.Name = "scriptDelete";
            this.scriptDelete.Size = new System.Drawing.Size(139, 22);
            this.scriptDelete.Text = "Delete script";
            this.scriptDelete.Click += new System.EventHandler(this.scriptDelete_Click);
            // 
            // dscriptBox
            // 
            this.dscriptBox.AllowDrop = true;
            this.dscriptBox.BackColor = System.Drawing.SystemColors.Control;
            this.dscriptBox.ContextMenuStrip = this.dscriptContext;
            this.dscriptBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dscriptBox.FormattingEnabled = true;
            this.dscriptBox.Location = new System.Drawing.Point(283, 58);
            this.dscriptBox.Name = "dscriptBox";
            this.dscriptBox.Size = new System.Drawing.Size(221, 355);
            this.dscriptBox.TabIndex = 2;
            this.dscriptBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.dscriptBox_DragDrop);
            this.dscriptBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.dscriptBox_DragEnter);
            this.dscriptBox.DoubleClick += new System.EventHandler(this.dscriptBox_DoubleClick);
            // 
            // dscriptContext
            // 
            this.dscriptContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dscriptDelete});
            this.dscriptContext.Name = "dscriptContext";
            this.dscriptContext.Size = new System.Drawing.Size(140, 26);
            // 
            // dscriptDelete
            // 
            this.dscriptDelete.Name = "dscriptDelete";
            this.dscriptDelete.Size = new System.Drawing.Size(139, 22);
            this.dscriptDelete.Text = "Delete script";
            this.dscriptDelete.Click += new System.EventHandler(this.dscriptDelete_Click);
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
            this.reloadScripts.Text = "Reload files";
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
            // run_kh1
            // 
            this.run_kh1.Location = new System.Drawing.Point(242, 490);
            this.run_kh1.Name = "run_kh1";
            this.run_kh1.Size = new System.Drawing.Size(62, 23);
            this.run_kh1.TabIndex = 13;
            this.run_kh1.Text = "Run KH1";
            this.run_kh1.UseVisualStyleBackColor = true;
            this.run_kh1.Click += new System.EventHandler(this.run_kh1_Click);
            // 
            // run_kh2
            // 
            this.run_kh2.Location = new System.Drawing.Point(310, 490);
            this.run_kh2.Name = "run_kh2";
            this.run_kh2.Size = new System.Drawing.Size(62, 23);
            this.run_kh2.TabIndex = 14;
            this.run_kh2.Text = "Run KH2";
            this.run_kh2.UseVisualStyleBackColor = true;
            this.run_kh2.Click += new System.EventHandler(this.run_kh2_Click);
            // 
            // run_com
            // 
            this.run_com.Location = new System.Drawing.Point(378, 490);
            this.run_com.Name = "run_com";
            this.run_com.Size = new System.Drawing.Size(62, 23);
            this.run_com.TabIndex = 15;
            this.run_com.Text = "Run CoM";
            this.run_com.UseVisualStyleBackColor = true;
            this.run_com.Click += new System.EventHandler(this.run_com_Click);
            // 
            // run_bbs
            // 
            this.run_bbs.Location = new System.Drawing.Point(446, 490);
            this.run_bbs.Name = "run_bbs";
            this.run_bbs.Size = new System.Drawing.Size(62, 23);
            this.run_bbs.TabIndex = 16;
            this.run_bbs.Text = "Run BBS";
            this.run_bbs.UseVisualStyleBackColor = true;
            this.run_bbs.Click += new System.EventHandler(this.run_bbs_Click);
            // 
            // run_khlauncher
            // 
            this.run_khlauncher.Location = new System.Drawing.Point(242, 519);
            this.run_khlauncher.Name = "run_khlauncher";
            this.run_khlauncher.Size = new System.Drawing.Size(266, 31);
            this.run_khlauncher.TabIndex = 17;
            this.run_khlauncher.Text = "Run KINGDOM HEARTS HD 1.5+2.5 Launcher";
            this.run_khlauncher.UseVisualStyleBackColor = true;
            this.run_khlauncher.Click += new System.EventHandler(this.run_khlauncher_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 49);
            this.label5.TabIndex = 18;
            this.label5.Text = "Running a game without the launcher only works for the pirated version of the gam" +
    "e.";
            // 
            // set_khpath
            // 
            this.set_khpath.Location = new System.Drawing.Point(15, 490);
            this.set_khpath.Name = "set_khpath";
            this.set_khpath.Size = new System.Drawing.Size(221, 23);
            this.set_khpath.TabIndex = 19;
            this.set_khpath.Text = "Set game Path";
            this.set_khpath.UseVisualStyleBackColor = true;
            this.set_khpath.Click += new System.EventHandler(this.set_khpath_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 561);
            this.Controls.Add(this.set_khpath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.run_khlauncher);
            this.Controls.Add(this.run_bbs);
            this.Controls.Add(this.run_com);
            this.Controls.Add(this.run_kh2);
            this.Controls.Add(this.run_kh1);
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
            this.scriptContext.ResumeLayout(false);
            this.dscriptContext.ResumeLayout(false);
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
        private System.Windows.Forms.Button run_kh1;
        private System.Windows.Forms.Button run_kh2;
        private System.Windows.Forms.Button run_com;
        private System.Windows.Forms.Button run_bbs;
        private System.Windows.Forms.Button run_khlauncher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button set_khpath;
        private System.Windows.Forms.ContextMenuStrip scriptContext;
        private System.Windows.Forms.ToolStripMenuItem scriptDelete;
        private System.Windows.Forms.ContextMenuStrip dscriptContext;
        private System.Windows.Forms.ToolStripMenuItem dscriptDelete;
    }
}

