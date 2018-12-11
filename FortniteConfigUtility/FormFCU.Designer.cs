namespace fcu
{
    partial class FormFCU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFCU));
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFPS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolution.Location = new System.Drawing.Point(5, 5);
            this.labelResolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(73, 16);
            this.labelResolution.TabIndex = 0;
            this.labelResolution.Text = "Resolution:";
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFPS.Location = new System.Drawing.Point(5, 33);
            this.labelFPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(65, 16);
            this.labelFPS.TabIndex = 1;
            this.labelFPS.Text = "FPS Cap:";
            // 
            // numericUpDownResY
            // 
            this.numericUpDownResY.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownResY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownResY.Location = new System.Drawing.Point(179, 3);
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
            this.numericUpDownResY.Size = new System.Drawing.Size(70, 22);
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
            this.numericUpDownResX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownResX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownResX.Location = new System.Drawing.Point(83, 3);
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
            this.numericUpDownResX.Size = new System.Drawing.Size(70, 22);
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
            this.numericUpDownFPS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFPS.Location = new System.Drawing.Point(78, 31);
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
            this.numericUpDownFPS.Size = new System.Drawing.Size(54, 22);
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
            this.labelCopyright.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.Location = new System.Drawing.Point(110, 90);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(134, 13);
            this.labelCopyright.TabIndex = 5;
            this.labelCopyright.Text = "Copyright 2018, Takoid";
            this.toolTipFooter.SetToolTip(this.labelCopyright, "Licensed under GPLv3");
            // 
            // checkBoxFullscreen
            // 
            this.checkBoxFullscreen.AutoSize = true;
            this.checkBoxFullscreen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFullscreen.Location = new System.Drawing.Point(263, 4);
            this.checkBoxFullscreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFullscreen.Name = "checkBoxFullscreen";
            this.checkBoxFullscreen.Size = new System.Drawing.Size(87, 20);
            this.checkBoxFullscreen.TabIndex = 3;
            this.checkBoxFullscreen.Text = "Fullscreen";
            this.toolTipRes.SetToolTip(this.checkBoxFullscreen, "Fullscreen mode\r\nMust be checked for custom resolutions");
            this.checkBoxFullscreen.UseVisualStyleBackColor = true;
            this.checkBoxFullscreen.CheckedChanged += new System.EventHandler(this.checkBoxFullscreen_CheckedChanged);
            // 
            // checkBoxNoFPSLimit
            // 
            this.checkBoxNoFPSLimit.AutoSize = true;
            this.checkBoxNoFPSLimit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNoFPSLimit.Location = new System.Drawing.Point(143, 32);
            this.checkBoxNoFPSLimit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxNoFPSLimit.Name = "checkBoxNoFPSLimit";
            this.checkBoxNoFPSLimit.Size = new System.Drawing.Size(85, 20);
            this.checkBoxNoFPSLimit.TabIndex = 5;
            this.checkBoxNoFPSLimit.Text = "Uncapped";
            this.toolTipFPS.SetToolTip(this.checkBoxNoFPSLimit, "Remove FPS cap\r\nMust be disabled to enter custom FPS limit");
            this.checkBoxNoFPSLimit.UseVisualStyleBackColor = true;
            this.checkBoxNoFPSLimit.CheckedChanged += new System.EventHandler(this.checkBoxNoFPSLimit_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(117, 57);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 30);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save Config";
            this.toolTipButtons.SetToolTip(this.buttonSave, "Save changes to config");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonConfigDir
            // 
            this.buttonConfigDir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigDir.Location = new System.Drawing.Point(5, 57);
            this.buttonConfigDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConfigDir.Name = "buttonConfigDir";
            this.buttonConfigDir.Size = new System.Drawing.Size(108, 30);
            this.buttonConfigDir.TabIndex = 7;
            this.buttonConfigDir.Text = "Config Directory";
            this.toolTipButtons.SetToolTip(this.buttonConfigDir, "Open the config directory");
            this.buttonConfigDir.UseVisualStyleBackColor = true;
            this.buttonConfigDir.Click += new System.EventHandler(this.buttonConfigDir_Click);
            // 
            // buttonNVCP
            // 
            this.buttonNVCP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNVCP.Location = new System.Drawing.Point(295, 57);
            this.buttonNVCP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNVCP.Name = "buttonNVCP";
            this.buttonNVCP.Size = new System.Drawing.Size(54, 30);
            this.buttonNVCP.TabIndex = 10;
            this.buttonNVCP.Text = "NVCP";
            this.toolTipButtons.SetToolTip(this.buttonNVCP, "Open NVIDIA Control Panel");
            this.buttonNVCP.UseVisualStyleBackColor = true;
            this.buttonNVCP.Click += new System.EventHandler(this.buttonNVCP_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(159, 5);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(15, 16);
            this.labelX.TabIndex = 13;
            this.labelX.Text = "x";
            // 
            // checkBoxBackup
            // 
            this.checkBoxBackup.AutoSize = true;
            this.checkBoxBackup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBackup.Location = new System.Drawing.Point(234, 32);
            this.checkBoxBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxBackup.Name = "checkBoxBackup";
            this.checkBoxBackup.Size = new System.Drawing.Size(113, 20);
            this.checkBoxBackup.TabIndex = 6;
            this.checkBoxBackup.Text = "Create Backup";
            this.toolTipBackup.SetToolTip(this.checkBoxBackup, "Create GameUserSettings.old backup in config directory");
            this.checkBoxBackup.UseVisualStyleBackColor = true;
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGitHub.Location = new System.Drawing.Point(231, 57);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(60, 30);
            this.buttonGitHub.TabIndex = 9;
            this.buttonGitHub.Text = "GitHub";
            this.toolTipButtons.SetToolTip(this.buttonGitHub, "FCU GitHub Repo");
            this.buttonGitHub.UseVisualStyleBackColor = true;
            this.buttonGitHub.Click += new System.EventHandler(this.buttonGitHub_Click);
            // 
            // FormFCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(354, 106);
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
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormFCU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortnite Config Utility";
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
    }
}

