/*  This file is part of Fortnite Config Tool.

    Fortnite Config Tool is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Fortnite Config Tool is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along witH Fortnite Config Tooly. If not, see https://www.gnu.org/licenses/. */

using System;
using System.IO;
using System.Text;

namespace fct
{
    class Config
    {
        
        //"trigger" strings when reading config
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

        //variables
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
        private StringBuilder successMessage;
        private string[] newConfig;

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
        public string[] NewConfig { get => newConfig; set => newConfig = value; }
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
        public StringBuilder SuccessMessage { get => successMessage; set => successMessage = value; }

        //constructor
        public Config()
        {
            //read config upon construction
            ReadConfig();
        }     

        //read the config
        public void ReadConfig()
        {

            //store each line in string array 'CurrentConfig'
            CurrentConfig = System.IO.File.ReadAllLines(configDir.ToString());

            //create new linecounter set to 0
            int lineCounter = 0;

            //loop through each line
            foreach (string currentLine in CurrentConfig)
            {
                //if the line starts with a trigger
                if (currentLine.StartsWith(triggerX))
                {
                    //set CurrentResX to the line minus trigger
                    CurrentResX = currentLine.Replace(triggerX, "");
                    //store this line number
                    LineNumX = lineCounter;
                }
                if (currentLine.StartsWith(triggerY))
                {
                    CurrentResY = currentLine.Replace(triggerY, "");
                    LineNumY = lineCounter;
                }
                //only the line number is needed for these lines since data is repeated
                if (currentLine.StartsWith(triggerConfirmedX))
                {
                    LineNumConfirmedX = lineCounter;
                }
                if (currentLine.StartsWith(triggerConfirmedY))
                {
                    LineNumConfirmedY = lineCounter;
                }
                if (currentLine.StartsWith(triggerConfirmedFullscreen))
                {
                    LineNumConfirmedFullscreen = lineCounter;
                }
                if (currentLine.StartsWith(triggerFullscreen))
                {
                    LineNumFullscreen = lineCounter;
                }
                //FPS and Fullscreen lines both set booleans
                if (currentLine.StartsWith(triggerFPS))
                {
                    CurrentFPS = currentLine.Replace(triggerFPS, "");
                    LineNumFPS = lineCounter;

                    //set IsFPSUnlimittted bool
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
                //increment line counter after each loop
                lineCounter++;
            }
            //end loop
        }

        //convert array of strings to config's format
        private string FormatConfig(string[] unformattedConfig)
        {
            //create StringBuilder to store each line in unformattedConfig
            StringBuilder formattedConfigSB = new StringBuilder();
            //loop through each line in the unformattedConfig
            foreach (string currentLine in unformattedConfig)
            {
                //add the line to formattedConfigSB
                formattedConfigSB.Append(currentLine + Environment.NewLine);
            }
            string formattedConfig = formattedConfigSB.ToString();
            return formattedConfig;
        }

        //write config
        public void WriteConfig()
        {
            //check if config is 'read-only'
            if (configDir.IsReadOnly)
            {
                //remember it was
                wasReadOnly = true;
                //remove 'read-only'
                configDir.IsReadOnly = false;
            }

            //write config to file
            File.WriteAllText(configDir.ToString(), FormatConfig(NewConfig));

            //return 'read-only' status if needed
            if (wasReadOnly)
            {
                configDir.IsReadOnly = true;
            }
        }

        public void ReplaceLines()
        {
            SuccessMessage = new StringBuilder();
            //create string to store CurrentConfig
            NewConfig = new string[CurrentConfig.Length];
            //copy CurrentConfig to NewConfig
            CurrentConfig.CopyTo(NewConfig, 0);

            //replace lines at LineNum index with their new values
            NewConfig[LineNumX] = triggerX + NewX;
            NewConfig[LineNumY] = triggerY + NewY;
            NewConfig[LineNumConfirmedX] = triggerConfirmedX + NewX;
            NewConfig[LineNumConfirmedY] = triggerConfirmedY + NewY;

            //append new line info to SuccessMessage
            SuccessMessage.Append("Resolution: " + NewX + "x" + NewY);            

            if (IsFPSUnlimittted)
            {
                NewConfig[LineNumFPS] = triggerFPS + "0.000000";
                SuccessMessage.Append(Environment.NewLine + "FPS Uncapped");
            }
            else
            {
                NewConfig[LineNumFPS] = triggerFPS + NewFPS;
                SuccessMessage.Append(Environment.NewLine + "FPS: " + NewFPS);
            }

            if (IsFullscreen)
            {
                NewConfig[LineNumPreferredFullscreen] = triggerPreferredFullscreen + "0";
                NewConfig[LineNumConfirmedFullscreen] = triggerConfirmedFullscreen + "0";
                NewConfig[LineNumFullscreen] = triggerFullscreen + "0";
                SuccessMessage.Append(Environment.NewLine + "Fullscreen On");
            }
            else
            {
                NewConfig[LineNumPreferredFullscreen] = triggerPreferredFullscreen + "1";
                NewConfig[LineNumConfirmedFullscreen] = triggerConfirmedFullscreen + "1";
                NewConfig[LineNumFullscreen] = triggerFullscreen + "1";
                SuccessMessage.Append(Environment.NewLine + "Fullscreen Off");
            }

        }

        //backup CurrentConfig
        public void CreateBackup()
        {
            File.WriteAllText(backupDir.ToString(), FormatConfig(CurrentConfig));
        }
    }
}
