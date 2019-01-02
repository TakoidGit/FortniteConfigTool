namespace fct
{
    partial class FormFCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFCT));
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelFPS = new System.Windows.Forms.Label();
            this.numericUpDownResY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownResX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFPS = new System.Windows.Forms.NumericUpDown();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.checkBoxFullscreen = new System.Windows.Forms.CheckBox();
            this.checkBoxNoFPSLimit = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonConfigDir = new System.Windows.Forms.Button();
            this.buttonNVCP = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.toolTipRes = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFPS = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBackup = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxBackup = new System.Windows.Forms.CheckBox();
            this.toolTipButtons = new System.Windows.Forms.ToolTip(this.components);
            this.buttonGitHub = new System.Windows.Forms.Button();
            this.toolTipFooter = new System.Windows.Forms.ToolTip(this.components);
            this.labelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFPS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolution.Location = new System.Drawing.Point(1, 5);
            this.labelResolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(78, 18);
            this.labelResolution.TabIndex = 0;
            this.labelResolution.Text = "Resolution:";
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFPS.Location = new System.Drawing.Point(1, 34);
            this.labelFPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(60, 18);
            this.labelFPS.TabIndex = 0;
            this.labelFPS.Text = "FPS Cap:";
            // 
            // numericUpDownResY
            // 
            this.numericUpDownResY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDownResY.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownResY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownResY.Location = new System.Drawing.Point(169, 5);
            this.numericUpDownResY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownResY.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDownResY.Minimum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericUpDownResY.Name = "numericUpDownResY";
            this.numericUpDownResY.Size = new System.Drawing.Size(70, 23);
            this.numericUpDownResY.TabIndex = 2;
            this.toolTipRes.SetToolTip(this.numericUpDownResY, "720 - 1440");
            this.numericUpDownResY.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // numericUpDownResX
            // 
            this.numericUpDownResX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDownResX.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownResX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownResX.Location = new System.Drawing.Point(81, 5);
            this.numericUpDownResX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownResX.Maximum = new decimal(new int[] {
            2560,
            0,
            0,
            0});
            this.numericUpDownResX.Minimum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericUpDownResX.Name = "numericUpDownResX";
            this.numericUpDownResX.Size = new System.Drawing.Size(70, 23);
            this.numericUpDownResX.TabIndex = 1;
            this.toolTipRes.SetToolTip(this.numericUpDownResX, "720 - 2560");
            this.numericUpDownResX.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // numericUpDownFPS
            // 
            this.numericUpDownFPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericUpDownFPS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFPS.Location = new System.Drawing.Point(63, 34);
            this.numericUpDownFPS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownFPS.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownFPS.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownFPS.Name = "numericUpDownFPS";
            this.numericUpDownFPS.Size = new System.Drawing.Size(59, 23);
            this.numericUpDownFPS.TabIndex = 4;
            this.toolTipRes.SetToolTip(this.numericUpDownFPS, "30 - 999");
            this.numericUpDownFPS.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Gray;
            this.labelCopyright.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.Location = new System.Drawing.Point(247, 99);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(103, 14);
            this.labelCopyright.TabIndex = 0;
            this.labelCopyright.Text = "Created by Takoid";
            this.toolTipFooter.SetToolTip(this.labelCopyright, "Licensed under GPLv3");
            // 
            // checkBoxFullscreen
            // 
            this.checkBoxFullscreen.AutoSize = true;
            this.checkBoxFullscreen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFullscreen.Location = new System.Drawing.Point(251, 6);
            this.checkBoxFullscreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFullscreen.Name = "checkBoxFullscreen";
            this.checkBoxFullscreen.Size = new System.Drawing.Size(91, 22);
            this.checkBoxFullscreen.TabIndex = 3;
            this.checkBoxFullscreen.Text = "Fullscreen";
            this.toolTipRes.SetToolTip(this.checkBoxFullscreen, "Fullscreen mode\r\nMust be checked for custom resolutions");
            this.checkBoxFullscreen.UseVisualStyleBackColor = true;
            this.checkBoxFullscreen.CheckedChanged += new System.EventHandler(this.checkBoxFullscreen_CheckedChanged);
            // 
            // checkBoxNoFPSLimit
            // 
            this.checkBoxNoFPSLimit.AutoSize = true;
            this.checkBoxNoFPSLimit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNoFPSLimit.Location = new System.Drawing.Point(130, 35);
            this.checkBoxNoFPSLimit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxNoFPSLimit.Name = "checkBoxNoFPSLimit";
            this.checkBoxNoFPSLimit.Size = new System.Drawing.Size(89, 22);
            this.checkBoxNoFPSLimit.TabIndex = 5;
            this.checkBoxNoFPSLimit.Text = "Uncapped";
            this.toolTipFPS.SetToolTip(this.checkBoxNoFPSLimit, "Remove FPS cap\r\nMust be disabled to enter custom FPS limit");
            this.checkBoxNoFPSLimit.UseVisualStyleBackColor = true;
            this.checkBoxNoFPSLimit.CheckedChanged += new System.EventHandler(this.checkBoxNoFPSLimit_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(4, 63);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 28);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save Config";
            this.toolTipButtons.SetToolTip(this.buttonSave, "Save changes to config");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonConfigDir
            // 
            this.buttonConfigDir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigDir.Location = new System.Drawing.Point(101, 63);
            this.buttonConfigDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConfigDir.Name = "buttonConfigDir";
            this.buttonConfigDir.Size = new System.Drawing.Size(121, 28);
            this.buttonConfigDir.TabIndex = 8;
            this.buttonConfigDir.Text = "Config Directory";
            this.toolTipButtons.SetToolTip(this.buttonConfigDir, "Open the config directory");
            this.buttonConfigDir.UseVisualStyleBackColor = true;
            this.buttonConfigDir.Click += new System.EventHandler(this.buttonConfigDir_Click);
            // 
            // buttonNVCP
            // 
            this.buttonNVCP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNVCP.Location = new System.Drawing.Point(288, 63);
            this.buttonNVCP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNVCP.Name = "buttonNVCP";
            this.buttonNVCP.Size = new System.Drawing.Size(57, 28);
            this.buttonNVCP.TabIndex = 10;
            this.buttonNVCP.Text = "NVCP";
            this.toolTipButtons.SetToolTip(this.buttonNVCP, "Open NVIDIA Control Panel");
            this.buttonNVCP.UseVisualStyleBackColor = true;
            this.buttonNVCP.Click += new System.EventHandler(this.buttonNVCP_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(153, 7);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(15, 18);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "x";
            // 
            // checkBoxBackup
            // 
            this.checkBoxBackup.AutoSize = true;
            this.checkBoxBackup.Checked = true;
            this.checkBoxBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBackup.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBackup.Location = new System.Drawing.Point(227, 35);
            this.checkBoxBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxBackup.Name = "checkBoxBackup";
            this.checkBoxBackup.Size = new System.Drawing.Size(115, 22);
            this.checkBoxBackup.TabIndex = 6;
            this.checkBoxBackup.Text = "Create Backup";
            this.toolTipBackup.SetToolTip(this.checkBoxBackup, "Create GameUserSettings.old backup in config directory");
            this.checkBoxBackup.UseVisualStyleBackColor = true;
            this.checkBoxBackup.CheckedChanged += new System.EventHandler(this.checkBoxBackup_CheckedChanged);
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGitHub.Location = new System.Drawing.Point(224, 63);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(62, 28);
            this.buttonGitHub.TabIndex = 9;
            this.buttonGitHub.Text = "GitHub";
            this.toolTipButtons.SetToolTip(this.buttonGitHub, "FCT GitHub Repo");
            this.buttonGitHub.UseVisualStyleBackColor = true;
            this.buttonGitHub.Click += new System.EventHandler(this.buttonGitHub_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Gray;
            this.labelVersion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(0, 98);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(40, 15);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "v1.0.4";
            this.toolTipFooter.SetToolTip(this.labelVersion, "Check GitHub for updates");
            // 
            // FormFCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(349, 113);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonGitHub);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.buttonNVCP);
            this.Controls.Add(this.buttonConfigDir);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxBackup);
            this.Controls.Add(this.checkBoxNoFPSLimit);
            this.Controls.Add(this.checkBoxFullscreen);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.numericUpDownFPS);
            this.Controls.Add(this.numericUpDownResX);
            this.Controls.Add(this.numericUpDownResY);
            this.Controls.Add(this.labelFPS);
            this.Controls.Add(this.labelResolution);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormFCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortnite Config Tool";
            this.Load += new System.EventHandler(this.FCU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.NumericUpDown numericUpDownResY;
        private System.Windows.Forms.NumericUpDown numericUpDownResX;
        private System.Windows.Forms.NumericUpDown numericUpDownFPS;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.CheckBox checkBoxFullscreen;
        private System.Windows.Forms.CheckBox checkBoxNoFPSLimit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonConfigDir;
        private System.Windows.Forms.Button buttonNVCP;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.ToolTip toolTipRes;
        private System.Windows.Forms.ToolTip toolTipFPS;
        private System.Windows.Forms.ToolTip toolTipBackup;
        private System.Windows.Forms.ToolTip toolTipButtons;
        private System.Windows.Forms.ToolTip toolTipFooter;
        private System.Windows.Forms.Button buttonGitHub;
        private System.Windows.Forms.CheckBox checkBoxBackup;
        private System.Windows.Forms.Label labelVersion;
    }
}

