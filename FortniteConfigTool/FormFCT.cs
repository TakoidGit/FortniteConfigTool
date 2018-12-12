/*  This file is part of Fortnite Config Utility.

    Fortnite Config Utility is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Fortnite Config Utility is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Fortnite Config Utility.  If not, see https://www.gnu.org/licenses/> */

using System;
using System.IO;
using System.Windows.Forms;

namespace fct
{
    public partial class FormFCT : Form
    {
        private Config config;

        public FormFCT()
        {
            InitializeComponent();
        }

        private void InitForm()
        {
            try
            {
                config = new Config();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //tell user something is broken
                MessageBox.Show("Could not read config file" + Environment.NewLine + "Try loading Fortnite first", "Error", MessageBoxButtons.OK);
                //exit
                Application.Exit();
            }

            //try settings current values
            try
            {
                numericUpDownResX.Value = Decimal.Parse(config.CurrentResX);
                numericUpDownResY.Value = Decimal.Parse(config.CurrentResY);

                if (config.IsFullscreen)
                {
                    checkBoxFullscreen.Checked = true;
                }
                else
                {
                    numericUpDownResX.Enabled = false;
                    numericUpDownResY.Enabled = false;
                }

                if (config.IsFPSUnlimittted)
                {
                    checkBoxNoFPSLimit.Checked = true;        
                    numericUpDownFPS.Enabled = false;                
                }
                else
                {
                    numericUpDownFPS.Value = Decimal.Parse(config.CurrentFPS);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //try nvidia
            try
            {
                //look for nvcp .exe and see if FNRC can access it
                FileInfo nvidiaDir = new FileInfo(@"C:\Program Files\NVIDIA Corporation\Control Panel Client\nvcplui.exe");
                buttonNVCP.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //if not disable button and change tooltip
                buttonNVCP.Enabled = false;
                toolTipButtons.SetToolTip(buttonNVCP, "NVIDIA Control Panel Unavailable");
            }
        }

        private void FCU_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void buttonConfigDir_Click(object sender, EventArgs e)
        {
            //open config directory
            System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FortniteGame\Saved\Config\WindowsClient");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {            
            if (checkBoxBackup.Checked)
            {
                config.CreateBackup();
            }

            config.NewX = numericUpDownResX.Value.ToString();
            config.NewY = numericUpDownResY.Value.ToString();

            if (!config.IsFPSUnlimittted)
            {
                config.NewFPS = numericUpDownFPS.Value.ToString();
            }

            config.ReplaceLines();

            DialogResult result = MessageBox.Show(config.SuccessMessage.ToString(), "New Config", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                config.WriteConfig();
            }
                    
        }

        private void checkBoxFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFullscreen.Checked)
            {
                numericUpDownResX.Enabled = true;
                numericUpDownResY.Enabled = true;
                config.IsFullscreen = true;
            }
            else
            {
                numericUpDownResX.Enabled = false;
                numericUpDownResY.Enabled = false;
                config.IsFullscreen = false;
            }
        }

        private void checkBoxNoFPSLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoFPSLimit.Checked)
            {
                numericUpDownFPS.Enabled = false;
                config.IsFPSUnlimittted = true;
            }
            else
            {
                numericUpDownFPS.Enabled = true;
                config.IsFPSUnlimittted = false;
            }
        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TakoidGit/FortniteConfigTool/");
        }

        private void buttonNVCP_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\Program Files\NVIDIA Corporation\Control Panel Client\nvcplui.exe");
            } catch (Exception ex)
            {
                buttonNVCP.Enabled = false;
                toolTipButtons.SetToolTip(buttonNVCP, "NVIDIA Control Panel Unavailable");
                Console.WriteLine(ex);
            }
        }

        private void checkBoxBackup_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
