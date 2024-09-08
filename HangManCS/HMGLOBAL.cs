//*********************************************************
//Developed by UbGames, visit us at https://www.ubgames.com
//*********************************************************
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Data;
using System.IO;
using System.Media;
using System.Threading;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace HangMan
{
	sealed class HMGLOBAL
	{
		[DllImport("kernel32",EntryPoint="GetWindowsDirectoryA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int GetWindowsDirectory(string lpBuffer, int nSize);
		
		public const int HWND_BROADCAST = 0xFFFF;
		public const short WM_FONTCHANGE = 0x1D;
		
		//number of characters in alphabet
		public const short MAXCHARS = 26;
		//Global Const MAXWORDS = 3500
		public const short MAXARRAY = 14; //0 to 14
		
		//MAXHOLD is the maximum chars in word
		public const short MAXHOLD = 15;
		
		//an empty letter slot in the word
		public const short NOLETTER = - 1;
		
		//Delay
		public const double NEWDELAY = 2;
		
		//word structure - word to guess from list
		public struct WORDINFO
		{
			public string Letter;
			public short Used; //true if letter has been guessed
		}
		
		//word information, what letter is in what slot
		public static WORDINFO[] WInfo = new WORDINFO[MAXHOLD + 1];
		public static WORDINFO[] LInfo = new WORDINFO[MAXHOLD + 1];

		//man structure - which part to show in list
		//1=Head 2=Body 3=Larm 4=Rarm 5=Lleg 6=Rleg
		//following items added for beginner level
		//7=Lhand 8=Rhand 9=Lfoot 10=Rfoot
		public struct MANINFO
		{
			public short flag;
		}

        public static long index = 10;
		//man information, which part to show in list 0 thru 9, 10 items in array
		public static MANINFO[] MInfo = new MANINFO[index];
		
		//card structure, info where card is on form and what value card has
		public struct CARDINFO
		{
			public short FormIndex;         //hold location on form index
			public short CardIndex;         //hold location of card
			public short CardVal;           //hold card value
			public short CardFlag;          //true id matched
		}
		
		public static short Wnum;           //holds start of empty space in array
		public static short gNum;           //index to word in data file
		public static string gWord;         //hold new word to guess
		public static short gSound;         //flag, true when sound is on
		public static short gExpired;       //flag, true when over 30 days
		public static int gDaysLeft;        //number of days in demo
		public static int gDaysUsed;        // number of days used

		public static bool gExpireFlag = false;                 //set to false to turn off demo
        public static bool gUseEncryption = false;              //set to true to use encryption for date
        public static string gDateInstall;                      //date app first used

        public static bool gShowNagScreenFlag = false;          //set to false to turn off nag screen frmNotice
        public static bool ShowAllHangMan = false;              //set to true to display hangman, used for centering hangman

        public static bool gbtnShowWord = false;                 //set to true to show button to display word

        //used for testing dates
        public static bool gHideEncryDecryptTextBoxes = true;    //set to true to hide encrypt and decrypt textboxes

		public static short gFont;          //flag, true when font is found
		public static short gLevel;         //mode of player, true for advanced, beginner shows hands and feet
		public static short gFileok;        //flag for file found
		public static short MaxNum;         //number of body parts - 6
		public static short MaxGames;       //number of games in play
		public static short MaxWins;        //number of wins in play
		public static short Beginner;
		public static short Intermediate;
		public static short Advanced;
		public static short MustReDeal;     //when to redeal cards
		public static short InPlay;         //when games is started
		public static short FCard;          //first card selected for user
		public static short NFile;          //number of file to use for category
		public static string MyPath;        //Object 'current path c:\windows
		public static object NewCards;      //true to refresh new backs
		public static int MAXWORDS;         //number of words in file
        public static int MAXLENGTH;        //length of longest word in file
		
		public static string Style;
		public static string Title;
		public static string Help;
		public static string Msg;
		public static string Ans;
		
		//messageBox
		public const string HM_MSG = "Hang Man!";   // used in title of msgbox
		public const short MB_OK = 0;
		public const short MB_OKCANCEL = 1;         // define buttons
		public const short MB_YESNOCANCEL = 3;
		public const short MB_YESNO = 4;
		public const short MB_ICONSTOP = 16;
		public const short MB_ICONQUESTION = 32;    // define icons
		public const short MB_ICONEXCLAMATION = 48;
		public const short MB_ICONINFORMATION = 64;
		public const short MB_DEFBUTTON2 = 256;
		public const short IDYES = 6;
		public const short IDNO = 7;
		public const short IDCANCEL = 2;
		public const short IDOK = 1;                // define other
		public const short MB_DEFBUTTON1 = 0;
		public const short MB_DEFBUTTON3 = 512;
		// Message box beep constants
		public const short MB_DEFBEEP = - 1;
		public const short MB_ICONASTERISK = 64;
		public const short MB_ICONHAND = 16;
		// WinsndPlaySound constants
		public const short SND_SYNC = 0;
		public const short SND_ASYNC = 1;
		public const short SND_NODEFAULT = 2;
		public const short SND_LOOP = 8;
		public const short SND_NOSTOP = 16;
		
		// MCI Buttons
		public const short MIDIOPEN = 0;
		public const short MIDIPLAY = 1;
		public const short MIDISTOP = 2;
		public const short MIDICLOSE = 3;
		
		// Windows API Sound functions
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern void MessageBeep(short BeepType);
		[DllImport("winmm.dll",EntryPoint="sndPlaySoundA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int WinsndPlaySound(string lpszSoundName, int uFlags);
		[DllImport("winmm.dll",EntryPoint="mciSendStringA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
		
		public static void GetAlphaLetter(short Index, ref string AlphaLetter)
		{
			//convert index to letter of alphabet and assign the char to AlphaLetter
			switch (Index)
			{
				case 0:
					AlphaLetter = "A";
					break;
				case 1:
					AlphaLetter = "B";
					break;
				case 2:
					AlphaLetter = "C";
					break;
				case 3:
					AlphaLetter = "D";
					break;
				case 4:
					AlphaLetter = "E";
					break;
				case 5:
					AlphaLetter = "F";
					break;
				case 6:
					AlphaLetter = "G";
					break;
				case 7:
					AlphaLetter = "H";
					break;
				case 8:
					AlphaLetter = "I";
					break;
				case 9:
					AlphaLetter = "J";
					break;
				case 10:
					AlphaLetter = "K";
					break;
				case 11:
					AlphaLetter = "L";
					break;
				case 12:
					AlphaLetter = "M";
					break;
				case 13:
					AlphaLetter = "N";
					break;
				case 14:
					AlphaLetter = "O";
					break;
				case 15:
					AlphaLetter = "P";
					break;
				case 16:
					AlphaLetter = "Q";
					break;
				case 17:
					AlphaLetter = "R";
					break;
				case 18:
					AlphaLetter = "S";
					break;
				case 19:
					AlphaLetter = "T";
					break;
				case 20:
					AlphaLetter = "U";
					break;
				case 21:
					AlphaLetter = "V";
					break;
				case 22:
					AlphaLetter = "W";
					break;
				case 23:
					AlphaLetter = "X";
					break;
				case 24:
					AlphaLetter = "Y";
					break;
				case 25:
					AlphaLetter = "Z";
					break;
			}
		}

        public static void DataFileExist(string tfile, ref short gFileok, ref int newfieldsNum)
        {
            //check for file in directory
            string filefound;
            string TmpNum;

            string tmpdir;
            string TmpStr;

            //Declare Char constant that contains comma
            const Char DELIMIETER = ',';
            
            tmpdir = Application.StartupPath + "\\AppData\\";

            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(tmpdir);
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles(tfile);

            //MessageBox.Show("tfile= " + tfile, "tfile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //if (filefound == "")
            if (filesInDir.Length == 0)
            {
                gFileok = 0;
            }
            else
            {
                //Instantiate filestream object
                FileStream inFile = new FileStream(tmpdir + tfile, FileMode.Open, FileAccess.Read);

                //Instantiate stream reader objecat
                StreamReader reader = new StreamReader(inFile);

                //Declare a string variable to hold each record contained in the text file
                string allRecords = "";

                //Declare a string array to hold each field contained in the record that is read
                string[] fields;

                //Read the record form the file and store it in the appropriate variable
                allRecords = reader.ReadLine();

                int i = 1;

                //string tmpString = "";
                int tmpNumber = 0;

                //while loop to process text file until there is no more content
                while (allRecords != null)
                {
                    //Split the record into fields and populate array
                    fields = allRecords.Split(DELIMIETER);

                    //MyRecord.TmpNum = System.Convert.ToInt16(fields[0]);
                    tmpNumber = System.Convert.ToInt16(fields[0]);

                    //tmpString = fields[1];
                    //MyRecord.TmpStr = tmpString;
                    //fields[1];

                    //TmpNum = System.Convert.ToString(MyRecord.TmpNum);
                    TmpNum = System.Convert.ToString(tmpNumber);

                    if (double.Parse(TmpNum) <= 0)
                    {
                        gFileok = 0;
                    }
                    else
                    {
                        gFileok = 1;
                    }
                    break;
                    
                    //Read the next record in the ext file
                    allRecords = reader.ReadLine();
                    i++;

                }
                newfieldsNum = i - 1;

                //Close fileStream and streamReader objects
                reader.Close();
                inFile.Close();
            }

        }

        public static void FileExists(string tmpdir, string filename, ref bool tFlag)
        {

            //tmpdir folder where file is located, filename name of file, tFlag if file was found

            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(tmpdir);
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles(filename);

            //if (file not found in directory)
            if (filesInDir.Length == 0)
            {
                //add error message here, no file exists
                //MessageBox.Show("File is missing or corrupted! " + filename, "Cancel Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //System.Environment.Exit(0);
                tFlag = false;
            }
            else
            {
                //file exists
                tFlag = true;
            }
        }

        public static void GetWordFromFile(short gNum, ref string gWord, string tfile)
        {
            //find maximum words in data file, assign the amount to MAXWORDS

            //check for file in directory
            string filefound;
            string filetosearch;
            string TmpNum;
            string TmpStr;

            string tmpdir;

            int tc;

            short I;
            string ch;
            string newch;
            int tNum;


            //Declare Char constant that contains comma
            const Char DELIMIETER = ',';

            tmpdir = Application.StartupPath + "\\AppData\\";

            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(tmpdir);
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles(tfile);

            //MessageBox.Show("tmpdir= " + tmpdir, "tmpdir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //MessageBox.Show("hdDirectoryInWhichToSearch= " + hdDirectoryInWhichToSearch, "hdDirectoryInWhichToSearch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (filesInDir.Length == 0)
            {
                MAXWORDS = 0;
                //MessageBox.Show("tmpdir= " + tmpdir, "tmpdir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("File is missing or corrupted! " + tfile, "Cancel Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FileStream inFile = new FileStream(tmpdir + tfile, FileMode.Open, FileAccess.Read);

                //Instantiate stream reader objecat
                StreamReader reader = new StreamReader(inFile);

                //Declare a string variable to hold each record contained in the text file
                string allRecords = "";

                //Declare a string array to hold each field contained in the record that is read
                string[] fields;

                //Read the record form the file and store it in the appropriate variable
                allRecords = reader.ReadLine();

                tc = 0;

                string tmpString = "";
                int tmpNumber = 0;

                //while loop to process text file until there is no more content
                while (allRecords != null)
                {
                    //Split the record into fields and populate array
                    fields = allRecords.Split(DELIMIETER);

                    //MyRecord.TmpNum = System.Convert.ToInt16(fields[0]);
                    tmpNumber = System.Convert.ToInt16(fields[0]);

                    //MyRecord.TmpStr = fields[1];
                    tmpString = fields[1];

                    //TmpNum = System.Convert.ToString(MyRecord.TmpNum);
                    TmpNum = System.Convert.ToString(tmpNumber);

                    if (double.Parse(TmpNum) <= 0 || double.Parse(TmpNum) > gNum)
                    {
                        //error in data file
                        MessageBox.Show("File is missing or corrupted! " + tfile, "Cancel Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gWord = "";
                        return;

                    }
                    if (double.Parse(TmpNum) == gNum)
                    {

                        //TmpStr = Convert.ToString(MyRecord.TmpStr);
                        TmpStr = Convert.ToString(tmpString);

                        tNum = Convert.ToInt16(TmpStr.Length);

                        //MessageBox.Show("TmpNum=" + TmpNum + " gNum= " + gNum, "TmpNum gNum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show("tNum=" + tNum, "tNum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;

                        newch = null;
                        for (I = 1; I <= tNum; I++)
                        {
                            ch = TmpStr.Substring(I - 1, 1);

                            int AsciiCodeO = (int)System.Convert.ToChar(ch);

                            //used for testing
                            //if (I <= 3)
                            //{
                            //    MessageBox.Show("AsciiCodeO=" + AsciiCodeO, "AsciiCodeO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //    MessageBox.Show("ch=" + Strings.Asc(ch), "ch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //    MessageBox.Show("ch=" + ch, "ch", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //}

                            if (AsciiCodeO < 32)
                            {
                                break;
                            }
                            else
                            {
                                newch = newch + ch;
                            }
                        }
                        gWord = newch;
                        //MessageBox.Show("gWord=" + gWord, "gWord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    //Read the next record in the ext file
                    allRecords = reader.ReadLine();
                    tc++;

                }

                //Close fileStream and streamReader objects
                reader.Close();
                inFile.Close();
            }
        }
		
		public static void FindMaxWords(ref int MAXWORDS, string tfile)
		{
			//find maximum words in data file, assign the amount to MAXWORDS

            //check for file in directory
            string filefound;
            string filetosearch;
            string TmpNum;

            string tmpdir;
            string TmpStr;

            int tc;

            //Find Len Of Word
            int tLength = 0;
            int tHold = 0;

            //Declare Char constant that contains comma
            const Char DELIMIETER = ',';

            tmpdir = Application.StartupPath + "\\AppData\\";

            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(tmpdir);
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles(tfile);

            //MessageBox.Show("tmpdir= " + tmpdir, "tmpdir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //MessageBox.Show("hdDirectoryInWhichToSearch= " + hdDirectoryInWhichToSearch, "hdDirectoryInWhichToSearch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (filesInDir.Length == 0)
            {
                MAXWORDS = 0;
                //MessageBox.Show("tmpdir= " + tmpdir, "tmpdir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                FileStream inFile = new FileStream(tmpdir + tfile, FileMode.Open, FileAccess.Read);

                //Instantiate stream reader objecat
                StreamReader reader = new StreamReader(inFile);

                //Declare a string variable to hold each record contained in the text file
                string allRecords = "";

                //Declare a string array to hold each field contained in the record that is read
                string[] fields;

                //Read the record form the file and store it in the appropriate variable
                allRecords = reader.ReadLine();

                tc = 0;
                //string tmpString = "";
                int tmpNumber = 0;

                //while loop to process text file until there is no more content
                while (allRecords != null)
                {
                    //Split the record into fields and populate array
                    fields = allRecords.Split(DELIMIETER);

                    //MyRecord.TmpNum = System.Convert.ToInt16(fields[0]);
                    tmpNumber = System.Convert.ToInt16(fields[0]);

                    //MyRecord.TmpStr = fields[1];
                    //tmpString = fields[1];

                    //TmpNum = System.Convert.ToString(MyRecord.TmpNum);
                    TmpNum = System.Convert.ToString(tmpNumber);

                    //only use if you need to find word length in file

                    //tLength = Convert.ToInt32(tmpString.Length);
                    //if (tLength > tHold)
                    //{
                    //    tHold = tLength;
                    //}

                    //Read the next record in the ext file
                    allRecords = reader.ReadLine();
                    tc++;

                }
                MAXWORDS = tc;
                HMGLOBAL.MAXLENGTH = tHold;

                //MessageBox.Show("MAXLENGTH= " + tHold, "MAXLENGTH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Close fileStream and streamReader objects
                reader.Close();
                inFile.Close();

            }
		}
		
		public static void FindCategoryFile(short NFile, ref string tfile)
		{
			//use tfile as global value for filename, use NFile as Global value for file number of category
			//determine which category of words to use by using the tfile value from ini file only need to change category if user made a change in category, there are 9 categories
			//animals, food, holidays, home, leisure, seasons sports, weather and misc.

			switch (NFile)
			{
				case 1:
                    tfile = "animals.txt";
					break;
				case 2:
                    tfile = "food.txt";
					break;
				case 3:
                    tfile = "holidays.txt";
					break;
				case 4:
                    tfile = "home.txt";
					break;
				case 5:
                    tfile = "leisure.txt";
					break;
				case 6:
                    tfile = "seasons.txt";
					break;
				case 7:
                    tfile = "sports.txt";
					break;
				case 8:
                    tfile = "weather.txt";
					break;
				case 9:
                    tfile = "misc.txt";
					break;
				default:
					MessageBox.Show("Value not found");
					break;
			}
		}
		
		public static void PlayLostSound()
		{
            //play sound when palyer lost
            PlaySoundFiles("Nwin2_WAV");
		}
		
		public static void PlayWinSound()
		{
			//play sound when user wins
			
			short tnum;
            string tStr;
            
            Random sortRandom = new Random();
            tnum = (short)(HMGLOBAL.GetRandom(2));

            switch (tnum)
            {
                case 1:
                    tStr = "Ywin1_WAV";
                    break;
                case 2:
                     tStr = "Ywin2_WAV";
                        break;
                default:
                    tStr = "Ywin1_WAV";
                    //play no sound
                    //MessageBox.Show("Number greater than 2 " + tnum);
                    break;
            }

            PlaySoundFiles(tStr);
		}
		
		public static void PlayEndSound()
		{
            //play sound at end of turn
            PlaySoundFiles("End_WAV");
        }

        private static void PlaySoundFiles(string tString)
        {
            //play sound files
            if (HMGLOBAL.gSound == 1)
            {
                //sound files in resources used for testing
                //SoundPlayer player = new SoundPlayer(My.Resources.Resources.Nwin2);
                //player.Play();
                //player.Dispose();

                switch (tString)
                {
                    case "Nwin2_WAV":
                        SoundPlayer player1 = new SoundPlayer(My.Resources.Resources.Nwin2);
                        player1.Play();
                        player1.Dispose();
                        break;
                    case "Ywin1_WAV":
                        SoundPlayer player2 = new SoundPlayer(My.Resources.Resources.Ywin1);
                        player2.Play();
                        player2.Dispose();
                        break;
                    case "Ywin2_WAV":
                        SoundPlayer player3 = new SoundPlayer(My.Resources.Resources.Ywin2);
                        player3.Play();
                        player3.Dispose();
                        break;
                    case "End_WAV":
                        SoundPlayer player4 = new SoundPlayer(My.Resources.Resources.End);
                        player4.Play();
                        player4.Dispose();
                        break;
                    default:
                        SoundPlayer player = new SoundPlayer(My.Resources.Resources.Nwin2);
                        player.Play();
                        player.Dispose();
                        break;
                }   //end switch
            }   //end if NSound
        }   //end PlaySoundFiles
						
        //code to use random function
        public static Random rnum = new Random();

		static public short GetRandom(int range)
		{
			//this function returns a random number between 0 and range-1, inclusive.
			//the generic formula is: Int((upperbound-lowerbound+1)*Rnd+lowerbound)
			
            int randomnum = 0;
			//generating a random number between 0 and range, example between 0 and 51, not 52
            randomnum = rnum.Next(0, range);
            return Convert.ToInt16(randomnum);
		}
	}
}
