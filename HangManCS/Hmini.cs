//*********************************************************
//Developed by UbGames, visit us at https://www.ubgames.com
//*********************************************************
using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

using System.Security.Cryptography;

namespace HangMan
{
	sealed class ini
	{
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

		public const string SerialNum = "59-43-C99";
		public const string INIFILENAME = "hm.ini";
		public const string EKey = "94022"; //Chr$(57) & Chr$(52) & Chr$(48) & Chr$(50) & Chr$(50)  'encrypt key - "94022"
		public static string file;
		public static string appname;
		public static string keyname;
		public static string Kvalue;
		
		public static void WriteIni(string MyValue)
		{
			
			string m;
			string lpKeyName;
			string lpAppName;
			string lpFileName;
			string lpString;
            long U = 0;
            //int U;
			
			lpAppName = appname;
			lpKeyName = keyname;
			lpString = MyValue;
			lpFileName = file;
			U = WritePrivateProfileString(lpAppName, lpKeyName, lpString, lpFileName);

            try
            {
                U = WritePrivateProfileString(lpAppName, lpKeyName, lpString, lpFileName);
                if (U == 0)
                {
                    //file is missing
                   MessageBox.Show("File is missing or corrupted!", "Error - WriteIni", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                //file is missing
               MessageBox.Show("File is missing or corrupted!", "Error - WriteIni", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Environment.Exit(0);
            }
		}
		
		public static void ReadIni(ref string result)
		{
            string m = null;
			int X = 0;
            string lpAppName = null;
            string lpKeyName = null;
            string lpDefault = null;
            string lpFileName = null;
            string lpReturnedString = null;
			int nSize = 0;
			
			lpAppName = appname;
			lpKeyName = keyname;
            lpDefault = Convert.ToString(0);
            //lpDefault = 0.ToString();
			lpFileName = file;

            StringBuilder Temp = new StringBuilder(255);

			
			lpReturnedString = new string('\0', 50); //fill with nulls
			nSize = 0;

            try
            {
                X = GetPrivateProfileString(lpAppName, lpKeyName, "", Temp, 255, lpFileName);
                lpReturnedString = Temp.ToString();
                if (X == 0)
                {
                    //file is missing
                   MessageBox.Show("File is missing or corrupted!", "Error - ReadIni", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Environment.Exit(0);
                }
                else
                {
                    result = lpReturnedString.ToString();
                }

            }
            catch (Exception ex)
            {
                //file is missing
               MessageBox.Show("File is missing or corrupted!", "Error - ReadIni", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Environment.Exit(0); 
            }
		}
		
		public static void ShowNagScreen()
		{
			//display nag screen shareware message
			frmNotice.Default.ShowDialog();
		}
		
		public static void GetIniFileSettings(ref short NFile, ref short gSound)
		{
			//open the hm.ini file in the application directory and get initial settings for category of words
			string TmpNum;
			
			appname = "Category";
			keyname = "File";
			TmpNum = "";
			
			ReadIni(ref TmpNum);
			
            NFile = Convert.ToInt16(TmpNum);

            //MessageBox.Show("TmpNum= " + TmpNum + "NFile= " + NFile, "NFile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		
			appname = "Settings";
			keyname = "PlaySound";
			
			ReadIni(ref TmpNum);
            gSound = Convert.ToInt16(TmpNum);

            //MessageBox.Show("TmpNum= " + TmpNum + "gSound= " + gSound, "gSound", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

		}
		
		public static void PutIniFileSettings(short Num, short gSound)
		{
			//open the hm.ini file in the application directory and output initial settings for category of words
			string TmpNum;
			
			appname = "Category";
			keyname = "File";
			
            TmpNum = Convert.ToString(Num);

			WriteIni(TmpNum);
			
			appname = "Settings";
			keyname = "PlaySound";
			
            TmpNum = Convert.ToString(gSound);

			WriteIni(TmpNum);
			
		}
		
		public static void GetIntPathSettings()
		{

            //set initial path settings to application directory
            try
            {
                //set mypath to the application directory
                HMGLOBAL.MyPath = Application.StartupPath;
                file = Application.StartupPath + "\\" + INIFILENAME;
                return;
            }
            catch (Exception ex)
            {
                //may need to create directory if not exist
                MessageBox.Show("A path is missing or corrupted!", "Error - Path Settings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Environment.Exit(0);
            }
		}
		
		public static void CheckForNewInstall()
		{
			//check hm.ini file for new install, compare key for serial number,
			//if key = 59-43-C99 then new else it should be valid date
			
			string NKey;
			string MyDate;
            string MyDay;
            string MyMonth;
            string MyYear;

            string MyDate2;
            string MyDay2;
            string MyMonth2;
            string MyYear2;
            
            string TmpStr;
			string lpString;
			string lpFileName;
			string lpAppName;
			string lpKeyName;
			string lpDefault;
			short f;
			DateTime CurDate;
			short DaysUsed;
			string m;

            int X = 0;
            long U = 0;

            //added for .net
			DateTime Now = DateTime.Now;
			
			lpFileName = file;
			lpAppName = "Serial";
			lpKeyName = "Key";
			lpDefault = "0";

			//NKey = Strings.Space(31);
            // 32 spaces
            //string str = new string(' ', 32);
            NKey = new string(' ', 32);

            StringBuilder Temp = new StringBuilder(31);

            //X will return the length of chars in NKey
            X = GetPrivateProfileString(lpAppName, lpKeyName, lpDefault, Temp, 255, lpFileName);
            //NKey must be 9 chars in length

			if (X <= 8)
			{
                //NKey is less than 9 chars in length
                MessageBox.Show("HM.ini file is missing or corrupted!", "Error - CheckForNewInstall", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Environment.Exit(0);
			}
			else
			{
                NKey = Temp.ToString();
                NKey = NKey.TrimEnd(' ').TrimStart(' ');

                if (NKey == SerialNum)
                {

                    MyDate = Now.ToString("MM/dd/yyyy");
                    //strip MyDate to Month, Day, and Year
                    //start at postion 1 and select the next 2 chars
                    MyMonth = MyDate.Substring(0, 2); //Month(MyDate)
                    //start at postion 4 and select the next 2 chars
                    MyDay = MyDate.Substring(3, 2); //Day(MyDate)
                    //start at postion 7 and select the next 2 chars
                    MyYear = MyDate.Substring(6, 4); //Year(MyDate)
                    TmpStr = MyMonth + "-" + MyDay + "-" + "C" + MyYear;
                    //output installed date to file cs.ini in win.dir
                    lpString = TmpStr;

                    U = WritePrivateProfileString(lpAppName, lpKeyName, lpString, lpFileName);

                    //output installed date to file hm.ini in application directory
                    TmpStr = MyMonth + "/" + MyDay + "/" + MyYear;

                    HMGLOBAL.gDateInstall = TmpStr;

                    if (HMGLOBAL.gUseEncryption == true)
                    {
                        TmpStr = EncryptString(TmpStr, EKey);
                    }

                    //MessageBox.Show("Encrypt TmpStr= " + TmpStr, "TmpStr", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    lpString = TmpStr;

                    lpFileName = file;
                    lpAppName = "Previous Serial";
                    lpKeyName = "Key";
                    lpDefault = "0";

                    U = WritePrivateProfileString(lpAppName, lpKeyName, lpString, lpFileName);

                    if (X == 0)
                    {
                        //file is missing
                        MessageBox.Show("HM.ini file is missing or corrupted!", "Error - CheckForNewInstall", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        System.Environment.Exit(0);
                    }
                } //end NKey = SerialNum
                else
                {
                    lpFileName = file;
                    lpAppName = "Previous Serial";
                    lpKeyName = "Key";
                    lpDefault = "0";
                    X = GetPrivateProfileString(lpAppName, lpKeyName, lpDefault, Temp, 255, lpFileName);

                    NKey = Temp.ToString();
                    NKey = NKey.TrimEnd(' ').TrimStart(' ');

                    //MessageBox.Show("NKey= " + NKey, "NKey", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (HMGLOBAL.gUseEncryption == true)
                    {
                        NKey = DecryptString(NKey, EKey);
                    }

                    //MessageBox.Show("Decrypt NKey= " + NKey, "NKey", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    HMGLOBAL.gDateInstall = NKey;
                    //use date from ini file and calculate days used
                    MyDate2 = NKey;
                    //strip MyDate to Month, Day, and Year
                    //start at postion 1 and select the next 2 chars
                    MyMonth2 = MyDate2.Substring(0, 2); //Month(MyDate)
                    //start at postion 4 and select the next 2 chars
                    MyDay2 = MyDate2.Substring(3, 2); //Day(MyDate)
                    //start at postion 7 and select the next 2 chars
                    MyYear2 = MyDate2.Substring(6, 4); //Year(MyDate)

                    //MessageBox.Show("Key MyDate2= " + MyDate2 + " MM DD YY= " + MyMonth2 + " " + MyDay2 + " " + MyYear2, "MyDate2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //use todays date and calculate days used
                    MyDate = Now.ToString("MM/dd/yyyy");
                    //strip MyDate to Month, Day, and Year
                    //start at postion 1 and select the next 2 chars
                    MyMonth = MyDate.Substring(0, 2); //Month(MyDate)
                    //start at postion 4 and select the next 2 chars
                    MyDay = MyDate.Substring(3, 2); //Day(MyDate)
                    //start at postion 7 and select the next 2 chars
                    MyYear = MyDate.Substring(6, 4); //Year(MyDate)

                    //MessageBox.Show("Now MyDate= " + MyDate + " MM DD YY= " + MyMonth + " " + MyDay + " " + MyYear, "MyDate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //used for testing date
                    //DateTime enteredDate = DateTime.Parse(MyDate2);
                    //MessageBox.Show("enteredDate= " + enteredDate, "enteredDate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    DateTime d1 = DateTime.Now;
                    DateTime d2 = DateTime.Parse(MyDate2);
                    TimeSpan t = d1 - d2;
                    double NrOfDays = t.TotalDays;

                    //MessageBox.Show("NrOfDays= " + NrOfDays + " d1= " + d1 + " d2= " + d2, "NrOfDays", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    DaysUsed = Convert.ToInt16(NrOfDays - 1);
                    //MessageBox.Show("DaysUsed= " + DaysUsed, "DaysUsed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    HMGLOBAL.gDaysUsed = DaysUsed;

                    //cannot use program more than 30 days
                    if (DaysUsed >= 30 || DaysUsed < 0)
                    {
                        //output a 1 when program is used over 30 days
                        HMGLOBAL.gExpired = 1;

                        //set gExpireFlag in HMGLOBAL.cs file to true for demo mode
                        if (HMGLOBAL.gExpireFlag == true)
                        {
                            PutIniExpired(HMGLOBAL.gExpired);

                            //not used in app
                            //show expired screen and exit program
                            //frmExpired.Default.ShowDialog();
                            //System.Environment.Exit(0);
                        }
                    }

                }

            } //end X <= 8
		} //CheckForNewInstall

        public static string EncryptString(string Message, string Passphrase)
        {
            //Encrypt using const EKey = "94022"

            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToEncrypt = UTF8.GetBytes(Message);
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return Convert.ToBase64String(Results);
        }

        public static string DecryptString(string Message, string Passphrase)
        {
            //Decrypt using const EKey = "94022"

            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToDecrypt = Convert.FromBase64String(Message);
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return UTF8.GetString(Results);
        }

		public static void GetIniExpired(ref short gExpired)
		{
			//check if program was used over 30 days
			//open the hm.ini file in the application directory
			//and check if program was used over 30 days
			//by checking initial settings for category of words
			
			string TmpNum;
			
			appname = "Settings";
			keyname = "GFile";
			TmpNum = "";
			ReadIni(ref TmpNum);

            TmpNum = TmpNum.Trim();

            //if no expiration date gExpired is 0, gExpired = 0;
            //set gExpireFlag to false to turn off demo

            gExpired = Convert.ToInt16(TmpNum);

            //MessageBox.Show("gExpired= " + gExpired, "gExpired", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		
		public static void PutIniExpired(short gExpired)
		{
            //no use in app at this time, see frmMain cmdExit_Click to enable, but need to check days

			//output a 1 when program is used over 30 days
			//open the hm.ini file in the application directory
			//and output a 1 when program is used over 30 days
			
			string TmpNum;

            appname = "Settings";
			keyname = "GFile";
            TmpNum = Convert.ToString(gExpired);

            //if no expiration date TmpNum is 0, TmpNum = "0"
            //set gExpireFlag to false to turn off demo

            //MessageBox.Show("TmpNum= " + TmpNum, "gExpired", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			WriteIni(TmpNum);
		}
		
	}
}
