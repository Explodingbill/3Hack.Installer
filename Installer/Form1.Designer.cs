
namespace Installer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.startupMainText = new System.Windows.Forms.TextBox();
            this.installInfo = new System.Windows.Forms.TextBox();
            this.Animated = new System.Windows.Forms.Timer(this.components);
            this.uninstallButton = new System.Windows.Forms.Button();
            this.CloseButtor = new System.Windows.Forms.Button();
            this.TypeTitle = new System.Windows.Forms.TextBox();
            this.pathSelectBox = new System.Windows.Forms.TextBox();
            this.pathSelectButton = new System.Windows.Forms.Button();
            this.nextType = new System.Windows.Forms.Button();
            this.new3dashType = new System.Windows.Forms.Button();
            this.new3dashplusType = new System.Windows.Forms.Button();
            this.existingType = new System.Windows.Forms.Button();
            this.pathTitle = new System.Windows.Forms.TextBox();
            this.pathInstallButton = new System.Windows.Forms.Button();
            this.installationStatus = new System.Windows.Forms.TextBox();
            this.uninstallPath = new System.Windows.Forms.TextBox();
            this.uninstallTitle = new System.Windows.Forms.TextBox();
            this.uninstallBrowse = new System.Windows.Forms.Button();
            this.uninstallButtonPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // installButton
            // 
            this.installButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.installButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.installButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.installButton.FlatAppearance.BorderSize = 0;
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Location = new System.Drawing.Point(347, 196);
            this.installButton.Name = "installButton";
            this.installButton.Padding = new System.Windows.Forms.Padding(3);
            this.installButton.Size = new System.Drawing.Size(142, 38);
            this.installButton.TabIndex = 6;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.InstallClicked);
            // 
            // startupMainText
            // 
            this.startupMainText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.startupMainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startupMainText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.startupMainText.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.startupMainText.ForeColor = System.Drawing.Color.White;
            this.startupMainText.Location = new System.Drawing.Point(12, 12);
            this.startupMainText.Name = "startupMainText";
            this.startupMainText.ReadOnly = true;
            this.startupMainText.Size = new System.Drawing.Size(232, 24);
            this.startupMainText.TabIndex = 7;
            this.startupMainText.Text = "3Hack by Explodingbill";
            this.startupMainText.Enter += new System.EventHandler(this.Unselect);
            // 
            // installInfo
            // 
            this.installInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.installInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.installInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.installInfo.Font = new System.Drawing.Font("Arial", 9.8F);
            this.installInfo.ForeColor = System.Drawing.Color.White;
            this.installInfo.Location = new System.Drawing.Point(32730, 147);
            this.installInfo.Name = "installInfo";
            this.installInfo.ReadOnly = true;
            this.installInfo.Size = new System.Drawing.Size(10, 19);
            this.installInfo.TabIndex = 8;
            this.installInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Animated
            // 
            this.Animated.Enabled = true;
            this.Animated.Interval = 1;
            this.Animated.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uninstallButton
            // 
            this.uninstallButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uninstallButton.BackColor = System.Drawing.Color.Red;
            this.uninstallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstallButton.FlatAppearance.BorderSize = 0;
            this.uninstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallButton.Location = new System.Drawing.Point(347, 253);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Padding = new System.Windows.Forms.Padding(3);
            this.uninstallButton.Size = new System.Drawing.Size(142, 38);
            this.uninstallButton.TabIndex = 9;
            this.uninstallButton.Text = "UnInstall";
            this.uninstallButton.UseVisualStyleBackColor = false;
            this.uninstallButton.Click += new System.EventHandler(this.Uninstall);
            // 
            // CloseButtor
            // 
            this.CloseButtor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButtor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CloseButtor.FlatAppearance.BorderSize = 0;
            this.CloseButtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtor.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButtor.ForeColor = System.Drawing.Color.White;
            this.CloseButtor.Location = new System.Drawing.Point(490, -1);
            this.CloseButtor.Name = "CloseButtor";
            this.CloseButtor.Padding = new System.Windows.Forms.Padding(3);
            this.CloseButtor.Size = new System.Drawing.Size(31, 34);
            this.CloseButtor.TabIndex = 9999;
            this.CloseButtor.Text = "X";
            this.CloseButtor.UseVisualStyleBackColor = false;
            this.CloseButtor.Click += new System.EventHandler(this.Close);
            // 
            // TypeTitle
            // 
            this.TypeTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TypeTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TypeTitle.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.TypeTitle.ForeColor = System.Drawing.Color.White;
            this.TypeTitle.Location = new System.Drawing.Point(12, 42);
            this.TypeTitle.Name = "TypeTitle";
            this.TypeTitle.ReadOnly = true;
            this.TypeTitle.Size = new System.Drawing.Size(290, 24);
            this.TypeTitle.TabIndex = 11;
            this.TypeTitle.Text = "Installation Type";
            this.TypeTitle.Enter += new System.EventHandler(this.Unselect);
            // 
            // pathSelectBox
            // 
            this.pathSelectBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pathSelectBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pathSelectBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathSelectBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathSelectBox.Font = new System.Drawing.Font("Arial", 9.2F, System.Drawing.FontStyle.Bold);
            this.pathSelectBox.ForeColor = System.Drawing.Color.White;
            this.pathSelectBox.Location = new System.Drawing.Point(28, 127);
            this.pathSelectBox.Margin = new System.Windows.Forms.Padding(7);
            this.pathSelectBox.Name = "pathSelectBox";
            this.pathSelectBox.Size = new System.Drawing.Size(360, 18);
            this.pathSelectBox.TabIndex = 12;
            // 
            // pathSelectButton
            // 
            this.pathSelectButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pathSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pathSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pathSelectButton.FlatAppearance.BorderSize = 0;
            this.pathSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathSelectButton.Font = new System.Drawing.Font("Arial Black", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathSelectButton.ForeColor = System.Drawing.Color.White;
            this.pathSelectButton.Location = new System.Drawing.Point(398, 122);
            this.pathSelectButton.Name = "pathSelectButton";
            this.pathSelectButton.Size = new System.Drawing.Size(91, 28);
            this.pathSelectButton.TabIndex = 13;
            this.pathSelectButton.Text = "Browse";
            this.pathSelectButton.UseVisualStyleBackColor = false;
            this.pathSelectButton.Click += new System.EventHandler(this.SelectPath);
            // 
            // nextType
            // 
            this.nextType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextType.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.nextType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextType.FlatAppearance.BorderSize = 0;
            this.nextType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextType.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextType.Location = new System.Drawing.Point(148, 253);
            this.nextType.Name = "nextType";
            this.nextType.Padding = new System.Windows.Forms.Padding(3);
            this.nextType.Size = new System.Drawing.Size(142, 38);
            this.nextType.TabIndex = 10000;
            this.nextType.Text = "Next";
            this.nextType.UseVisualStyleBackColor = false;
            this.nextType.Click += new System.EventHandler(this.TypeNext);
            // 
            // new3dashType
            // 
            this.new3dashType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.new3dashType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.new3dashType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new3dashType.FlatAppearance.BorderSize = 0;
            this.new3dashType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new3dashType.Font = new System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold);
            this.new3dashType.ForeColor = System.Drawing.Color.White;
            this.new3dashType.Location = new System.Drawing.Point(28, 107);
            this.new3dashType.Name = "new3dashType";
            this.new3dashType.Size = new System.Drawing.Size(372, 25);
            this.new3dashType.TabIndex = 10001;
            this.new3dashType.Text = "New 3Dash Installation";
            this.new3dashType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new3dashType.UseVisualStyleBackColor = false;
            this.new3dashType.Click += new System.EventHandler(this.new3dashType_Click);
            // 
            // new3dashplusType
            // 
            this.new3dashplusType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.new3dashplusType.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.new3dashplusType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new3dashplusType.FlatAppearance.BorderSize = 0;
            this.new3dashplusType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new3dashplusType.Font = new System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold);
            this.new3dashplusType.Location = new System.Drawing.Point(28, 144);
            this.new3dashplusType.Name = "new3dashplusType";
            this.new3dashplusType.Size = new System.Drawing.Size(372, 25);
            this.new3dashplusType.TabIndex = 10002;
            this.new3dashplusType.Text = "New 3Dash Plus Installation (Recommended)";
            this.new3dashplusType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new3dashplusType.UseVisualStyleBackColor = false;
            this.new3dashplusType.Click += new System.EventHandler(this.new3dashplusType_Click);
            // 
            // existingType
            // 
            this.existingType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.existingType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.existingType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.existingType.FlatAppearance.BorderSize = 0;
            this.existingType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.existingType.Font = new System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold);
            this.existingType.ForeColor = System.Drawing.Color.White;
            this.existingType.Location = new System.Drawing.Point(28, 181);
            this.existingType.Name = "existingType";
            this.existingType.Size = new System.Drawing.Size(372, 25);
            this.existingType.TabIndex = 10003;
            this.existingType.Text = "Existing 3Dash Installation";
            this.existingType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.existingType.UseVisualStyleBackColor = false;
            this.existingType.Click += new System.EventHandler(this.existingType_Click);
            // 
            // pathTitle
            // 
            this.pathTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pathTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pathTitle.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.pathTitle.ForeColor = System.Drawing.Color.White;
            this.pathTitle.Location = new System.Drawing.Point(12, 72);
            this.pathTitle.Name = "pathTitle";
            this.pathTitle.ReadOnly = true;
            this.pathTitle.Size = new System.Drawing.Size(136, 24);
            this.pathTitle.TabIndex = 10004;
            this.pathTitle.Text = "3Dash Path";
            // 
            // pathInstallButton
            // 
            this.pathInstallButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pathInstallButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pathInstallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pathInstallButton.FlatAppearance.BorderSize = 0;
            this.pathInstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathInstallButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathInstallButton.Location = new System.Drawing.Point(6, 253);
            this.pathInstallButton.Name = "pathInstallButton";
            this.pathInstallButton.Padding = new System.Windows.Forms.Padding(3);
            this.pathInstallButton.Size = new System.Drawing.Size(142, 38);
            this.pathInstallButton.TabIndex = 10005;
            this.pathInstallButton.Text = "Install";
            this.pathInstallButton.UseVisualStyleBackColor = false;
            this.pathInstallButton.Click += new System.EventHandler(this.BeginInstall);
            // 
            // installationStatus
            // 
            this.installationStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.installationStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.installationStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.installationStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.installationStatus.Font = new System.Drawing.Font("Arial", 9.2F, System.Drawing.FontStyle.Bold);
            this.installationStatus.ForeColor = System.Drawing.Color.White;
            this.installationStatus.Location = new System.Drawing.Point(1, 301);
            this.installationStatus.Name = "installationStatus";
            this.installationStatus.ReadOnly = true;
            this.installationStatus.Size = new System.Drawing.Size(520, 18);
            this.installationStatus.TabIndex = 10006;
            this.installationStatus.Text = "Loading Installer";
            this.installationStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.installationStatus.Enter += new System.EventHandler(this.Unselect);
            // 
            // uninstallPath
            // 
            this.uninstallPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uninstallPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.uninstallPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uninstallPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uninstallPath.Font = new System.Drawing.Font("Arial", 9.2F, System.Drawing.FontStyle.Bold);
            this.uninstallPath.ForeColor = System.Drawing.Color.White;
            this.uninstallPath.Location = new System.Drawing.Point(28, 225);
            this.uninstallPath.Margin = new System.Windows.Forms.Padding(7);
            this.uninstallPath.Name = "uninstallPath";
            this.uninstallPath.Size = new System.Drawing.Size(360, 18);
            this.uninstallPath.TabIndex = 10007;
            // 
            // uninstallTitle
            // 
            this.uninstallTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.uninstallTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uninstallTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uninstallTitle.Font = new System.Drawing.Font("Arial", 12.2F, System.Drawing.FontStyle.Bold);
            this.uninstallTitle.ForeColor = System.Drawing.Color.White;
            this.uninstallTitle.Location = new System.Drawing.Point(12, 105);
            this.uninstallTitle.Name = "uninstallTitle";
            this.uninstallTitle.ReadOnly = true;
            this.uninstallTitle.Size = new System.Drawing.Size(136, 24);
            this.uninstallTitle.TabIndex = 10008;
            this.uninstallTitle.Text = "3Dash Path";
            // 
            // uninstallBrowse
            // 
            this.uninstallBrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uninstallBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.uninstallBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstallBrowse.FlatAppearance.BorderSize = 0;
            this.uninstallBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallBrowse.Font = new System.Drawing.Font("Arial Black", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallBrowse.ForeColor = System.Drawing.Color.White;
            this.uninstallBrowse.Location = new System.Drawing.Point(398, 162);
            this.uninstallBrowse.Name = "uninstallBrowse";
            this.uninstallBrowse.Size = new System.Drawing.Size(91, 28);
            this.uninstallBrowse.TabIndex = 10009;
            this.uninstallBrowse.Text = "Browse";
            this.uninstallBrowse.UseVisualStyleBackColor = false;
            this.uninstallBrowse.Click += new System.EventHandler(this.SelectPath);
            // 
            // uninstallButtonPage
            // 
            this.uninstallButtonPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uninstallButtonPage.BackColor = System.Drawing.Color.Red;
            this.uninstallButtonPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstallButtonPage.FlatAppearance.BorderSize = 0;
            this.uninstallButtonPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallButtonPage.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallButtonPage.Location = new System.Drawing.Point(347, 37);
            this.uninstallButtonPage.Name = "uninstallButtonPage";
            this.uninstallButtonPage.Padding = new System.Windows.Forms.Padding(3);
            this.uninstallButtonPage.Size = new System.Drawing.Size(142, 38);
            this.uninstallButtonPage.TabIndex = 10010;
            this.uninstallButtonPage.Text = "UnInstall";
            this.uninstallButtonPage.UseVisualStyleBackColor = false;
            this.uninstallButtonPage.Click += new System.EventHandler(this.Uninstall);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(520, 320);
            this.Controls.Add(this.uninstallButtonPage);
            this.Controls.Add(this.uninstallBrowse);
            this.Controls.Add(this.uninstallTitle);
            this.Controls.Add(this.uninstallPath);
            this.Controls.Add(this.installationStatus);
            this.Controls.Add(this.pathInstallButton);
            this.Controls.Add(this.pathTitle);
            this.Controls.Add(this.existingType);
            this.Controls.Add(this.new3dashplusType);
            this.Controls.Add(this.new3dashType);
            this.Controls.Add(this.nextType);
            this.Controls.Add(this.pathSelectButton);
            this.Controls.Add(this.pathSelectBox);
            this.Controls.Add(this.TypeTitle);
            this.Controls.Add(this.CloseButtor);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.installInfo);
            this.Controls.Add(this.startupMainText);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3Hack.Installer";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.TextBox startupMainText;
        private System.Windows.Forms.TextBox installInfo;
        private System.Windows.Forms.Timer Animated;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Button CloseButtor;
        private System.Windows.Forms.TextBox TypeTitle;
        private System.Windows.Forms.TextBox pathSelectBox;
        private System.Windows.Forms.Button pathSelectButton;
        private System.Windows.Forms.Button nextType;
        private System.Windows.Forms.Button new3dashType;
        private System.Windows.Forms.Button new3dashplusType;
        private System.Windows.Forms.Button existingType;
        private System.Windows.Forms.TextBox pathTitle;
        private System.Windows.Forms.Button pathInstallButton;
        private System.Windows.Forms.TextBox installationStatus;
        private System.Windows.Forms.TextBox uninstallPath;
        private System.Windows.Forms.TextBox uninstallTitle;
        private System.Windows.Forms.Button uninstallBrowse;
        private System.Windows.Forms.Button uninstallButtonPage;
    }
}

