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
    along with Fortnite Config Utility.  If not, see https://www.gnu.org/licenses/. */

using System;
using System.IO;
using System.Text;

namespace fcu
{
    class Config
    {
        //variables

        //triggers
        private readonly string triggerX = "ResolutionSizeX=";
        private readonly string triggerY = "ResolutionSizeY=";
        private readonly string triggerConfirmedX = "LastUserConfirmedResolutionSizeX=";
        private readonly string triggerConfirmedY = "LastUserConfirmedResolutionSizeY=";
        private readonly string triggerFPS = "FrameRateLimit=";
        private readonly string triggerConfirmedFullscreen = "LastConfirmedFullscreenMode=";
        private readonly string triggerPreferredFullscreen = "PreferredFullscreenMode=";
        private readonly string triggerFullscreen = "FullscreenMode=";

        //directories
        private FileInfo backupDir = new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.old");
        private FileInfo configDir = new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.ini");

        //get/set methods
        private int lineNumX;
        private int lineNumY;
        private int lineNumConfirmedX;
        private int lineNumConfirmedY;
        private int lineNumFPS;
        private int lineNumConfirmedFullscreen;
        private int lineNumPreferredFullscreen;
        private int lineNumFullscreen;
        private string[] currentConfig;
        private string currentResX;
        private string currentResY;
        private string currentFPS;
        private string currentFullscreen;
        private string newX;
        private string newY;
        private string newFPS;
        private string newFullscreen;
        private bool isFullscreen;
        private bool isFPSUnlimittted;
        private bool wasReadOnly;

        //get/set methods
        public int LineNumX { get => lineNumX; set => lineNumX = value; }
        public int LineNumY { get => lineNumY; set => lineNumY = value; }
        public int LineNumConfirmedX { get => lineNumConfirmedX; set => lineNumConfirmedX = value; }
        public int LineNumConfirmedY { get => lineNumConfirmedY; set => lineNumConfirmedY = value; }
        public int LineNumFPS { get => lineNumFPS; set => lineNumFPS = value; }
        public int LineNumConfirmedFullscreen { get => lineNumConfirmedFullscreen; set => lineNumConfirmedFullscreen = value; }
        public int LineNumPreferredFullscreen { get => lineNumPreferredFullscreen; set => lineNumPreferredFullscreen = value; }
        public int LineNumFullscreen { get => lineNumFullscreen; set => lineNumFullscreen = value; }
        public string[] CurrentConfig { get => currentConfig; set => currentConfig = value; }
        public string CurrentResX { get => currentResX; set => currentResX = value; }
        public string CurrentResY { get => currentResY; set => currentResY = value; }
        public string CurrentFPS { get => currentFPS; set => currentFPS = value; }
        public string CurrentFullscreen { get => currentFullscreen; set => currentFullscreen = value; }
        public string NewX { get => newX; set => newX = value; }
        public string NewY { get => newY; set => newY = value; }
        public string NewFPS { get => newFPS; set => newFPS = value; }
        public string NewFullscreen { get => newFullscreen; set => newFullscreen = value; }
        public bool IsFullscreen { get => isFullscreen; set => isFullscreen = value; }
        public bool IsFPSUnlimittted { get => isFPSUnlimittted; set => isFPSUnlimittted = value; }
        public bool WasReadOnly { get => wasReadOnly; set => wasReadOnly = value; }

        //constructor
        public Config()
        {
            //read the config when a new config is constructed
            ReadConfig();
        }

        //get and set methods        

        //read the config
        public void ReadConfig()
        {

            //store each line in string array currentconfig
            CurrentConfig = System.IO.File.ReadAllLines(configDir.ToString());

            //create new linecounter set to 0
            int lineCounter = 0;

            //loop through each line
            foreach (string currentLine in CurrentConfig)
            {
                //if the line starts with a trigger
                if (currentLine.StartsWith(triggerX))
                {
                    //set currentresx to the line minus trigger
                    CurrentResX = currentLine.Replace(triggerX, "");
                    //store line index value
                    LineNumX = lineCounter;
                }
                if (currentLine.StartsWith(triggerY))
                {
                    CurrentResY = currentLine.Replace(triggerY, "");
                    LineNumY = lineCounter;
                }
                if (currentLine.StartsWith(triggerConfirmedX))
                {
                    LineNumConfirmedX = lineCounter;
                }
                if (currentLine.StartsWith(triggerConfirmedY))
                {
                    LineNumConfirmedY = lineCounter;
                }
                if (currentLine.StartsWith(triggerFPS))
                {
                    CurrentFPS = currentLine.Replace(triggerFPS, "");
                    LineNumFPS = lineCounter;

                    //set fps bool
                    if (CurrentFPS.StartsWith("0"))
                    {
                        IsFPSUnlimittted = true;
                    }
                    else
                    {
                        IsFPSUnlimittted = false;
                    }
                }
                if (currentLine.StartsWith(triggerPreferredFullscreen))
                {
                    //using the preferred trigger since it should hold the most up to date preference
                    CurrentFullscreen = currentLine.Replace(triggerPreferredFullscreen, "");
                    LineNumPreferredFullscreen = lineCounter;

                    //set fullscreen bool
                    if (CurrentFullscreen.StartsWith("0"))
                    {
                        IsFullscreen = true;
                    }
                    else
                    {
                        IsFullscreen = false;
                    }
                }
                if (currentLine.StartsWith(triggerConfirmedFullscreen))
                {
                    LineNumConfirmedFullscreen = lineCounter;
                }
                if (currentLine.StartsWith(triggerFullscreen))
                {
                    LineNumFullscreen = lineCounter;
                }
                //increment line counter after each loop
                lineCounter++;
            }
        }

        //convert array of strings to config's format
        private string FormatConfig(string[] unformattedConfig)
        {
            StringBuilder formattedConfigSB = new StringBuilder();
            foreach (string currentLine in unformattedConfig)
            {
                formattedConfigSB.Append(currentLine + Environment.NewLine);
            }
            string formattedConfig = formattedConfigSB.ToString();
            return formattedConfig;
        }

        //write config
        public void WriteConfig()
        {
            ReplaceLines();
            //write new config
            if (configDir.IsReadOnly)
            {
                wasReadOnly = true;
                configDir.IsReadOnly = false;
            }
            File.WriteAllText(configDir.ToString(), FormatConfig(CurrentConfig));
            if (wasReadOnly)
            {
                configDir.IsReadOnly = true;
            }
        }

        private void ReplaceLines()
        {
            //replace lines at linenum index with their updated values
            CurrentConfig[LineNumX] = triggerX + NewX;
            CurrentConfig[LineNumY] = triggerY + NewY;
            CurrentConfig[LineNumConfirmedX] = triggerConfirmedX + NewX;
            CurrentConfig[LineNumConfirmedY] = triggerConfirmedY + NewY;

            if (IsFPSUnlimittted)
            {
                CurrentConfig[LineNumFPS] = triggerFPS + "0.000000";
            }
            else
            {
                CurrentConfig[LineNumFPS] = triggerFPS + NewFPS + ".000000";
            }

            if (IsFullscreen)
            {
                CurrentConfig[LineNumPreferredFullscreen] = triggerPreferredFullscreen + "0";
                CurrentConfig[LineNumConfirmedFullscreen] = triggerConfirmedFullscreen + "0";
                CurrentConfig[LineNumFullscreen] = triggerFullscreen + "0";
            }
            else
            {
                CurrentConfig[LineNumPreferredFullscreen] = triggerPreferredFullscreen + "1";
                CurrentConfig[LineNumConfirmedFullscreen] = triggerConfirmedFullscreen + "1";
                CurrentConfig[LineNumFullscreen] = triggerFullscreen + "1";
            }

        }

        public void CreateBackup()
        {
            //write that backup
            File.WriteAllText(backupDir.ToString(), FormatConfig(CurrentConfig));
        }
    }
}
