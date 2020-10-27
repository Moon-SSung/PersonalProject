﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace MS_Project
{
    class DBConnect
    {
        //Section Name in .ini file
        public const string IniSectionName = "DBConnect";

        //ini파일 내 파라미터
        public const string Param_DB_IP = "DatabaseIP";
        public const string Param_DB_Name = "DatabaseName";
        public const string Param_Security = "Security";
        public const string Param_DB_ID = "DatabaseID";
        public const string Param_DB_PW = "DatabasePW";

        public static string GetConString()
        {
            IniFile iniFile = new IniFile();
            iniFile.Load(IniData.SettingIniFile);
            IniSection dbSection = iniFile[IniSectionName];
            //ini파일을 활용한 DB연결
            return $"Data Source = {dbSection[Param_DB_IP]};" +
                   $"Initial Catalog = {dbSection[Param_DB_Name]};" +
                   $"Persist Security Info = {dbSection[Param_Security]};" +
                   $"User ID = {dbSection[Param_DB_ID]};" +
                   $"Password = {dbSection[Param_DB_PW]};";
        }
    }
}
