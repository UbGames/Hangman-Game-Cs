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
using System.Diagnostics;

namespace HangMan
{
	internal class frmMain : System.Windows.Forms.Form
	{
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.Run(new frmMain());
		}
		
		#region Windows Form Designer generated code
		public frmMain()
		{
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			Form_Initialize_Game();
		}
		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool Disposing)
		{
			if (Disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}

        private System.ComponentModel.IContainer components;
        //Required by the Windows Form Designer
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Button cmdExit;
		public System.Windows.Forms.Button cmdNewGame;
		public System.Windows.Forms.Label Rfoot;
		public System.Windows.Forms.Label Lfoot;
		public System.Windows.Forms.Label Rhand;
		public System.Windows.Forms.Label Lhand;
		public System.Windows.Forms.Label lblmaxwords;
		public System.Windows.Forms.Label lblfilename;
        
        //public AxComctlLib.AxToolbar tbToolBar;
        //public AxComctlLib.AxStatusBar sbStatusBar;
        //public AxComctlLib.AxImageList imglist;

        private ToolStrip ToolStrip1;
        private StatusStrip sbStatusStrip;
        private ImageList imageList1;
        
		public System.Windows.Forms.Label lblWordIs;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Line4;
		public System.Windows.Forms.Label Line3;
		public System.Windows.Forms.Label Line2;
		public System.Windows.Forms.Label Line1;
		public System.Windows.Forms.Label lblStatus;
		public System.Windows.Forms.MenuItem mnuNewGame;
		public System.Windows.Forms.MenuItem mnuFileBar1;
		public System.Windows.Forms.MenuItem mnuFileExit;
		public System.Windows.Forms.MenuItem mnuFile;
		public System.Windows.Forms.MenuItem mnuAnimals;
		public System.Windows.Forms.MenuItem mnuFood;
		public System.Windows.Forms.MenuItem mnuHolidays;
		public System.Windows.Forms.MenuItem mnuHome;
		public System.Windows.Forms.MenuItem mnuLeisure;
		public System.Windows.Forms.MenuItem mnuSeasons;
		public System.Windows.Forms.MenuItem mnuSports;
		public System.Windows.Forms.MenuItem mnuWeather;
		public System.Windows.Forms.MenuItem mnuMisc;
		public System.Windows.Forms.MenuItem mnuSelectGame;
		public System.Windows.Forms.MenuItem mnuEditBar1;
		public System.Windows.Forms.MenuItem mnuBeginner;
		public System.Windows.Forms.MenuItem mnuAdvanced;
		public System.Windows.Forms.MenuItem mnuLevel;
		public System.Windows.Forms.MenuItem mnuEditBar2;
		public System.Windows.Forms.MenuItem mnuSoundOn;
		public System.Windows.Forms.MenuItem mnuSoundOff;
		public System.Windows.Forms.MenuItem mnuSound;
		public System.Windows.Forms.MenuItem mnuOptions;
		public System.Windows.Forms.MenuItem mnuHelpRules;
		public System.Windows.Forms.MenuItem mnuHelpBar1;
		public System.Windows.Forms.MenuItem mnuHelpPrint;
		public System.Windows.Forms.MenuItem mnuHelpBar2;
		public System.Windows.Forms.MenuItem mnuHelpAbout;
		public System.Windows.Forms.MenuItem mnuHelp;
		internal System.Windows.Forms.Label lblLetter0;
		internal System.Windows.Forms.Label lblLetter1;
		internal System.Windows.Forms.Label lblLetter2;
		internal System.Windows.Forms.Label lblLetter3;
		internal System.Windows.Forms.Label lblLetter4;
		internal System.Windows.Forms.Label lblLetter5;
		internal System.Windows.Forms.Label lblLetter6;
		internal System.Windows.Forms.Label lblLetter7;
		internal System.Windows.Forms.Label lblLetter8;
		internal System.Windows.Forms.Label lblLetter9;
		internal System.Windows.Forms.Label lblLetter10;
		internal System.Windows.Forms.Label lblLetter11;
		internal System.Windows.Forms.Label lblLetter12;
		internal System.Windows.Forms.Label lblLetter13;
		internal System.Windows.Forms.Label lblLetter14;
		internal System.Windows.Forms.Label lblWLine0;
		internal System.Windows.Forms.Label lblWLine1;
		internal System.Windows.Forms.Label lblWLine2;
		internal System.Windows.Forms.Label lblWLine3;
		internal System.Windows.Forms.Label lblWLine4;
		internal System.Windows.Forms.Label lblWLine5;
		internal System.Windows.Forms.Label lblWLine6;
		internal System.Windows.Forms.Label lblWLine7;
		internal System.Windows.Forms.Label lblWLine8;
		internal System.Windows.Forms.Label lblWLine9;
		internal System.Windows.Forms.Label lblWLine10;
		internal System.Windows.Forms.Label lblWLine11;
		internal System.Windows.Forms.Label lblWLine12;
		internal System.Windows.Forms.Label lblWLine13;
		internal System.Windows.Forms.Label lblWLine14;
		internal System.Windows.Forms.Label lblAlpha0;
		internal System.Windows.Forms.Label lblAlpha1;
		internal System.Windows.Forms.Label lblAlpha2;
		internal System.Windows.Forms.Label lblAlpha3;
		internal System.Windows.Forms.Label lblAlpha4;
		internal System.Windows.Forms.Label lblAlpha5;
		internal System.Windows.Forms.Label lblAlpha6;
		internal System.Windows.Forms.Label lblAlpha7;
		internal System.Windows.Forms.Label lblAlpha8;
		internal System.Windows.Forms.Label lblAlpha9;
		internal System.Windows.Forms.Label lblAlpha10;
		internal System.Windows.Forms.Label lblAlpha11;
		internal System.Windows.Forms.Label lblAlpha12;
		internal System.Windows.Forms.Label lblAlpha13;
		internal System.Windows.Forms.Label lblAlpha14;
		public System.Windows.Forms.Button cmdLetter0;
		public System.Windows.Forms.Button cmdLetter1;
		public System.Windows.Forms.Button cmdLetter2;
		public System.Windows.Forms.Button cmdLetter3;
		public System.Windows.Forms.Button cmdLetter4;
		public System.Windows.Forms.Button cmdLetter5;
		public System.Windows.Forms.Button cmdLetter6;
		public System.Windows.Forms.Button cmdLetter12;
		public System.Windows.Forms.Button cmdLetter11;
		public System.Windows.Forms.Button cmdLetter10;
		public System.Windows.Forms.Button cmdLetter9;
		public System.Windows.Forms.Button cmdLetter8;
		public System.Windows.Forms.Button cmdLetter7;
		public System.Windows.Forms.Button cmdLetter25;
		public System.Windows.Forms.Button cmdLetter24;
		public System.Windows.Forms.Button cmdLetter23;
		public System.Windows.Forms.Button cmdLetter22;
		public System.Windows.Forms.Button cmdLetter21;
		public System.Windows.Forms.Button cmdLetter20;
		public System.Windows.Forms.Button cmdLetter19;
		public System.Windows.Forms.Button cmdLetter18;
		public System.Windows.Forms.Button cmdLetter17;
		public System.Windows.Forms.Button cmdLetter16;
		public System.Windows.Forms.Button cmdLetter15;
		public System.Windows.Forms.Button cmdLetter14;
		public System.Windows.Forms.Button cmdLetter13;
		public System.Windows.Forms.Label lblShowWord;
		public System.Windows.Forms.Label lblMaxChars;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel toolStripStatusLabel7;
        private ToolStripStatusLabel toolStripStatusLabel8;
        private ToolStripStatusLabel toolStripStatusLabel9;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private TextBox lblEncryptedValue;
        private TextBox lblDecryptedValue;
        private TextBox txtNormalValue;
        private Label lblEncrypt;
        private Label lblDecrypt;
        private Button Encrypt;
        private Label lblNormal;
        private Button Decrypt;
        private Label lblEncrypted;
        private TextBox txtEncryptedValue;
        private Button btnShowWord;
        private Button btnHideWord;

		public System.Windows.Forms.MainMenu MainMenu1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdNewGame = new System.Windows.Forms.Button();
            this.Rfoot = new System.Windows.Forms.Label();
            this.Lfoot = new System.Windows.Forms.Label();
            this.Rhand = new System.Windows.Forms.Label();
            this.Lhand = new System.Windows.Forms.Label();
            this.lblmaxwords = new System.Windows.Forms.Label();
            this.lblfilename = new System.Windows.Forms.Label();
            this.lblWordIs = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Line4 = new System.Windows.Forms.Label();
            this.Line3 = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.Line1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuNewGame = new System.Windows.Forms.MenuItem();
            this.mnuFileBar1 = new System.Windows.Forms.MenuItem();
            this.mnuFileExit = new System.Windows.Forms.MenuItem();
            this.mnuOptions = new System.Windows.Forms.MenuItem();
            this.mnuSelectGame = new System.Windows.Forms.MenuItem();
            this.mnuAnimals = new System.Windows.Forms.MenuItem();
            this.mnuFood = new System.Windows.Forms.MenuItem();
            this.mnuHolidays = new System.Windows.Forms.MenuItem();
            this.mnuHome = new System.Windows.Forms.MenuItem();
            this.mnuLeisure = new System.Windows.Forms.MenuItem();
            this.mnuSeasons = new System.Windows.Forms.MenuItem();
            this.mnuSports = new System.Windows.Forms.MenuItem();
            this.mnuWeather = new System.Windows.Forms.MenuItem();
            this.mnuMisc = new System.Windows.Forms.MenuItem();
            this.mnuEditBar1 = new System.Windows.Forms.MenuItem();
            this.mnuLevel = new System.Windows.Forms.MenuItem();
            this.mnuBeginner = new System.Windows.Forms.MenuItem();
            this.mnuAdvanced = new System.Windows.Forms.MenuItem();
            this.mnuEditBar2 = new System.Windows.Forms.MenuItem();
            this.mnuSound = new System.Windows.Forms.MenuItem();
            this.mnuSoundOn = new System.Windows.Forms.MenuItem();
            this.mnuSoundOff = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuHelpRules = new System.Windows.Forms.MenuItem();
            this.mnuHelpBar1 = new System.Windows.Forms.MenuItem();
            this.mnuHelpPrint = new System.Windows.Forms.MenuItem();
            this.mnuHelpBar2 = new System.Windows.Forms.MenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.MenuItem();
            this.lblLetter0 = new System.Windows.Forms.Label();
            this.lblLetter1 = new System.Windows.Forms.Label();
            this.lblLetter2 = new System.Windows.Forms.Label();
            this.lblLetter3 = new System.Windows.Forms.Label();
            this.lblLetter4 = new System.Windows.Forms.Label();
            this.lblLetter5 = new System.Windows.Forms.Label();
            this.lblLetter6 = new System.Windows.Forms.Label();
            this.lblLetter7 = new System.Windows.Forms.Label();
            this.lblLetter8 = new System.Windows.Forms.Label();
            this.lblLetter9 = new System.Windows.Forms.Label();
            this.lblLetter10 = new System.Windows.Forms.Label();
            this.lblLetter11 = new System.Windows.Forms.Label();
            this.lblLetter12 = new System.Windows.Forms.Label();
            this.lblLetter13 = new System.Windows.Forms.Label();
            this.lblLetter14 = new System.Windows.Forms.Label();
            this.lblWLine0 = new System.Windows.Forms.Label();
            this.lblWLine1 = new System.Windows.Forms.Label();
            this.lblWLine2 = new System.Windows.Forms.Label();
            this.lblWLine3 = new System.Windows.Forms.Label();
            this.lblWLine4 = new System.Windows.Forms.Label();
            this.lblWLine5 = new System.Windows.Forms.Label();
            this.lblWLine6 = new System.Windows.Forms.Label();
            this.lblWLine7 = new System.Windows.Forms.Label();
            this.lblWLine8 = new System.Windows.Forms.Label();
            this.lblWLine9 = new System.Windows.Forms.Label();
            this.lblWLine10 = new System.Windows.Forms.Label();
            this.lblWLine11 = new System.Windows.Forms.Label();
            this.lblWLine12 = new System.Windows.Forms.Label();
            this.lblWLine13 = new System.Windows.Forms.Label();
            this.lblWLine14 = new System.Windows.Forms.Label();
            this.lblAlpha0 = new System.Windows.Forms.Label();
            this.lblAlpha1 = new System.Windows.Forms.Label();
            this.lblAlpha2 = new System.Windows.Forms.Label();
            this.lblAlpha3 = new System.Windows.Forms.Label();
            this.lblAlpha4 = new System.Windows.Forms.Label();
            this.lblAlpha5 = new System.Windows.Forms.Label();
            this.lblAlpha6 = new System.Windows.Forms.Label();
            this.lblAlpha7 = new System.Windows.Forms.Label();
            this.lblAlpha8 = new System.Windows.Forms.Label();
            this.lblAlpha9 = new System.Windows.Forms.Label();
            this.lblAlpha10 = new System.Windows.Forms.Label();
            this.lblAlpha11 = new System.Windows.Forms.Label();
            this.lblAlpha12 = new System.Windows.Forms.Label();
            this.lblAlpha13 = new System.Windows.Forms.Label();
            this.lblAlpha14 = new System.Windows.Forms.Label();
            this.cmdLetter0 = new System.Windows.Forms.Button();
            this.cmdLetter1 = new System.Windows.Forms.Button();
            this.cmdLetter2 = new System.Windows.Forms.Button();
            this.cmdLetter3 = new System.Windows.Forms.Button();
            this.cmdLetter4 = new System.Windows.Forms.Button();
            this.cmdLetter5 = new System.Windows.Forms.Button();
            this.cmdLetter6 = new System.Windows.Forms.Button();
            this.cmdLetter12 = new System.Windows.Forms.Button();
            this.cmdLetter11 = new System.Windows.Forms.Button();
            this.cmdLetter10 = new System.Windows.Forms.Button();
            this.cmdLetter9 = new System.Windows.Forms.Button();
            this.cmdLetter8 = new System.Windows.Forms.Button();
            this.cmdLetter7 = new System.Windows.Forms.Button();
            this.cmdLetter25 = new System.Windows.Forms.Button();
            this.cmdLetter24 = new System.Windows.Forms.Button();
            this.cmdLetter23 = new System.Windows.Forms.Button();
            this.cmdLetter22 = new System.Windows.Forms.Button();
            this.cmdLetter21 = new System.Windows.Forms.Button();
            this.cmdLetter20 = new System.Windows.Forms.Button();
            this.cmdLetter19 = new System.Windows.Forms.Button();
            this.cmdLetter18 = new System.Windows.Forms.Button();
            this.cmdLetter17 = new System.Windows.Forms.Button();
            this.cmdLetter16 = new System.Windows.Forms.Button();
            this.cmdLetter15 = new System.Windows.Forms.Button();
            this.cmdLetter14 = new System.Windows.Forms.Button();
            this.cmdLetter13 = new System.Windows.Forms.Button();
            this.lblShowWord = new System.Windows.Forms.Label();
            this.lblMaxChars = new System.Windows.Forms.Label();
            this.sbStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblEncryptedValue = new System.Windows.Forms.TextBox();
            this.lblDecryptedValue = new System.Windows.Forms.TextBox();
            this.txtNormalValue = new System.Windows.Forms.TextBox();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.Button();
            this.lblNormal = new System.Windows.Forms.Label();
            this.Decrypt = new System.Windows.Forms.Button();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.txtEncryptedValue = new System.Windows.Forms.TextBox();
            this.btnShowWord = new System.Windows.Forms.Button();
            this.btnHideWord = new System.Windows.Forms.Button();
            this.sbStatusStrip.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.Control;
            this.cmdExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdExit.Image = ((System.Drawing.Image)(resources.GetObject("cmdExit.Image")));
            this.cmdExit.Location = new System.Drawing.Point(575, 263);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdExit.Size = new System.Drawing.Size(65, 33);
            this.cmdExit.TabIndex = 63;
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdExit, "Exit Game");
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdNewGame
            // 
            this.cmdNewGame.BackColor = System.Drawing.SystemColors.Control;
            this.cmdNewGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdNewGame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNewGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdNewGame.Image = ((System.Drawing.Image)(resources.GetObject("cmdNewGame.Image")));
            this.cmdNewGame.Location = new System.Drawing.Point(503, 263);
            this.cmdNewGame.Name = "cmdNewGame";
            this.cmdNewGame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdNewGame.Size = new System.Drawing.Size(65, 33);
            this.cmdNewGame.TabIndex = 62;
            this.cmdNewGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToolTip1.SetToolTip(this.cmdNewGame, "Start New game");
            this.cmdNewGame.UseVisualStyleBackColor = false;
            this.cmdNewGame.Click += new System.EventHandler(this.cmdNewGame_Click);
            // 
            // Rfoot
            // 
            this.Rfoot.BackColor = System.Drawing.SystemColors.WindowText;
            this.Rfoot.Location = new System.Drawing.Point(196, 280);
            this.Rfoot.Name = "Rfoot";
            this.Rfoot.Size = new System.Drawing.Size(10, 1);
            this.Rfoot.TabIndex = 64;
            // 
            // Lfoot
            // 
            this.Lfoot.BackColor = System.Drawing.SystemColors.WindowText;
            this.Lfoot.Location = new System.Drawing.Point(116, 280);
            this.Lfoot.Name = "Lfoot";
            this.Lfoot.Size = new System.Drawing.Size(10, 1);
            this.Lfoot.TabIndex = 65;
            // 
            // Rhand
            // 
            this.Rhand.BackColor = System.Drawing.SystemColors.WindowText;
            this.Rhand.Location = new System.Drawing.Point(196, 185);
            this.Rhand.Name = "Rhand";
            this.Rhand.Size = new System.Drawing.Size(10, 1);
            this.Rhand.TabIndex = 66;
            // 
            // Lhand
            // 
            this.Lhand.BackColor = System.Drawing.SystemColors.WindowText;
            this.Lhand.Location = new System.Drawing.Point(116, 185);
            this.Lhand.Name = "Lhand";
            this.Lhand.Size = new System.Drawing.Size(10, 1);
            this.Lhand.TabIndex = 67;
            // 
            // lblmaxwords
            // 
            this.lblmaxwords.BackColor = System.Drawing.Color.Transparent;
            this.lblmaxwords.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblmaxwords.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxwords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblmaxwords.Location = new System.Drawing.Point(575, 473);
            this.lblmaxwords.Name = "lblmaxwords";
            this.lblmaxwords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblmaxwords.Size = new System.Drawing.Size(99, 17);
            this.lblmaxwords.TabIndex = 65;
            this.lblmaxwords.Text = "Maxwords";
            this.lblmaxwords.Visible = false;
            // 
            // lblfilename
            // 
            this.lblfilename.BackColor = System.Drawing.Color.Transparent;
            this.lblfilename.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblfilename.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblfilename.Location = new System.Drawing.Point(575, 497);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblfilename.Size = new System.Drawing.Size(99, 17);
            this.lblfilename.TabIndex = 64;
            this.lblfilename.Text = "filename";
            this.lblfilename.Visible = false;
            // 
            // lblWordIs
            // 
            this.lblWordIs.BackColor = System.Drawing.Color.Transparent;
            this.lblWordIs.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWordIs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordIs.ForeColor = System.Drawing.Color.Black;
            this.lblWordIs.Location = new System.Drawing.Point(122, 491);
            this.lblWordIs.Name = "lblWordIs";
            this.lblWordIs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWordIs.Size = new System.Drawing.Size(107, 17);
            this.lblWordIs.TabIndex = 61;
            this.lblWordIs.Text = "The word is:";
            this.lblWordIs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(328, 172);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(117, 19);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Select a letter:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(375, 83);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(258, 55);
            this.Label2.TabIndex = 29;
            this.Label2.Text = "Hang Man!";
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.SystemColors.WindowText;
            this.Line4.Location = new System.Drawing.Point(161, 137);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(1, 12);
            this.Line4.TabIndex = 79;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Line3.Location = new System.Drawing.Point(56, 318);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(50, 10);
            this.Line3.TabIndex = 80;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Line2.Location = new System.Drawing.Point(77, 127);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(125, 10);
            this.Line2.TabIndex = 81;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Line1.Location = new System.Drawing.Point(77, 128);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(10, 195);
            this.Line1.TabIndex = 82;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblStatus.Location = new System.Drawing.Point(180, 358);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(121, 25);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuOptions,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNewGame,
            this.mnuFileBar1,
            this.mnuFileExit});
            this.mnuFile.Text = "&File";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Index = 0;
            this.mnuNewGame.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.mnuNewGame.Text = "&New Game";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            this.mnuNewGame.Popup += new System.EventHandler(this.mnuNewGame_Popup);
            // 
            // mnuFileBar1
            // 
            this.mnuFileBar1.Index = 1;
            this.mnuFileBar1.Text = "-";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Index = 2;
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            this.mnuFileExit.Popup += new System.EventHandler(this.mnuFileExit_Popup);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Index = 1;
            this.mnuOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSelectGame,
            this.mnuEditBar1,
            this.mnuLevel,
            this.mnuEditBar2,
            this.mnuSound});
            this.mnuOptions.Text = "&Options";
            // 
            // mnuSelectGame
            // 
            this.mnuSelectGame.Index = 0;
            this.mnuSelectGame.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAnimals,
            this.mnuFood,
            this.mnuHolidays,
            this.mnuHome,
            this.mnuLeisure,
            this.mnuSeasons,
            this.mnuSports,
            this.mnuWeather,
            this.mnuMisc});
            this.mnuSelectGame.Text = "&Select Game";
            // 
            // mnuAnimals
            // 
            this.mnuAnimals.Index = 0;
            this.mnuAnimals.Text = "&Animals";
            this.mnuAnimals.Click += new System.EventHandler(this.mnuAnimals_Click);
            this.mnuAnimals.Popup += new System.EventHandler(this.mnuAnimals_Popup);
            // 
            // mnuFood
            // 
            this.mnuFood.Index = 1;
            this.mnuFood.Text = "&Food";
            this.mnuFood.Click += new System.EventHandler(this.mnuFood_Click);
            this.mnuFood.Popup += new System.EventHandler(this.mnuFood_Popup);
            // 
            // mnuHolidays
            // 
            this.mnuHolidays.Index = 2;
            this.mnuHolidays.Text = "&Holidays";
            this.mnuHolidays.Click += new System.EventHandler(this.mnuHolidays_Click);
            this.mnuHolidays.Popup += new System.EventHandler(this.mnuHolidays_Popup);
            // 
            // mnuHome
            // 
            this.mnuHome.Index = 3;
            this.mnuHome.Text = "H&ome";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            this.mnuHome.Popup += new System.EventHandler(this.mnuHome_Popup);
            // 
            // mnuLeisure
            // 
            this.mnuLeisure.Index = 4;
            this.mnuLeisure.Text = "&Liesure";
            this.mnuLeisure.Click += new System.EventHandler(this.mnuLeisure_Click);
            this.mnuLeisure.Popup += new System.EventHandler(this.mnuLeisure_Popup);
            // 
            // mnuSeasons
            // 
            this.mnuSeasons.Index = 5;
            this.mnuSeasons.Text = "S&easons";
            this.mnuSeasons.Click += new System.EventHandler(this.mnuSeasons_Click);
            this.mnuSeasons.Popup += new System.EventHandler(this.mnuSeasons_Popup);
            // 
            // mnuSports
            // 
            this.mnuSports.Index = 6;
            this.mnuSports.Text = "&Sports";
            this.mnuSports.Click += new System.EventHandler(this.mnuSports_Click);
            this.mnuSports.Popup += new System.EventHandler(this.mnuSports_Popup);
            // 
            // mnuWeather
            // 
            this.mnuWeather.Index = 7;
            this.mnuWeather.Text = "&Weather";
            this.mnuWeather.Click += new System.EventHandler(this.mnuWeather_Click);
            this.mnuWeather.Popup += new System.EventHandler(this.mnuWeather_Popup);
            // 
            // mnuMisc
            // 
            this.mnuMisc.Index = 8;
            this.mnuMisc.Text = "&Misc";
            this.mnuMisc.Click += new System.EventHandler(this.mnuMisc_Click);
            this.mnuMisc.Popup += new System.EventHandler(this.mnuMisc_Popup);
            // 
            // mnuEditBar1
            // 
            this.mnuEditBar1.Index = 1;
            this.mnuEditBar1.Text = "-";
            // 
            // mnuLevel
            // 
            this.mnuLevel.Index = 2;
            this.mnuLevel.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuBeginner,
            this.mnuAdvanced});
            this.mnuLevel.Text = "&Level";
            // 
            // mnuBeginner
            // 
            this.mnuBeginner.Index = 0;
            this.mnuBeginner.Text = "&Beginner";
            this.mnuBeginner.Click += new System.EventHandler(this.mnuBeginner_Click);
            this.mnuBeginner.Popup += new System.EventHandler(this.mnuBeginner_Popup);
            // 
            // mnuAdvanced
            // 
            this.mnuAdvanced.Checked = true;
            this.mnuAdvanced.Index = 1;
            this.mnuAdvanced.Text = "&Advanced";
            this.mnuAdvanced.Click += new System.EventHandler(this.mnuAdvanced_Click);
            this.mnuAdvanced.Popup += new System.EventHandler(this.mnuAdvanced_Popup);
            // 
            // mnuEditBar2
            // 
            this.mnuEditBar2.Index = 3;
            this.mnuEditBar2.Text = "-";
            // 
            // mnuSound
            // 
            this.mnuSound.Index = 4;
            this.mnuSound.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSoundOn,
            this.mnuSoundOff});
            this.mnuSound.Text = "Sound";
            // 
            // mnuSoundOn
            // 
            this.mnuSoundOn.Checked = true;
            this.mnuSoundOn.Index = 0;
            this.mnuSoundOn.Text = "On";
            this.mnuSoundOn.Click += new System.EventHandler(this.mnuSoundOn_Click);
            this.mnuSoundOn.Popup += new System.EventHandler(this.mnuSoundOn_Popup);
            // 
            // mnuSoundOff
            // 
            this.mnuSoundOff.Index = 1;
            this.mnuSoundOff.Text = "Off";
            this.mnuSoundOff.Click += new System.EventHandler(this.mnuSoundOff_Click);
            this.mnuSoundOff.Popup += new System.EventHandler(this.mnuSoundOff_Popup);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 2;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuHelpRules,
            this.mnuHelpBar1,
            this.mnuHelpPrint,
            this.mnuHelpBar2,
            this.mnuHelpAbout});
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpRules
            // 
            this.mnuHelpRules.Index = 0;
            this.mnuHelpRules.Text = "&How To Play";
            this.mnuHelpRules.Click += new System.EventHandler(this.mnuHelpRules_Click);
            this.mnuHelpRules.Popup += new System.EventHandler(this.mnuHelpRules_Popup);
            // 
            // mnuHelpBar1
            // 
            this.mnuHelpBar1.Index = 1;
            this.mnuHelpBar1.Text = "-";
            // 
            // mnuHelpPrint
            // 
            this.mnuHelpPrint.Index = 2;
            this.mnuHelpPrint.Text = "&Print Order Form";
            this.mnuHelpPrint.Click += new System.EventHandler(this.mnuHelpPrint_Click);
            this.mnuHelpPrint.Popup += new System.EventHandler(this.mnuHelpPrint_Popup);
            // 
            // mnuHelpBar2
            // 
            this.mnuHelpBar2.Index = 3;
            this.mnuHelpBar2.Text = "-";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Index = 4;
            this.mnuHelpAbout.Text = "&About Hangman...";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            this.mnuHelpAbout.Popup += new System.EventHandler(this.mnuHelpAbout_Popup);
            // 
            // lblLetter0
            // 
            this.lblLetter0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter0.Location = new System.Drawing.Point(142, 410);
            this.lblLetter0.Name = "lblLetter0";
            this.lblLetter0.Size = new System.Drawing.Size(20, 25);
            this.lblLetter0.TabIndex = 95;
            this.lblLetter0.Text = "x";
            this.lblLetter0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter1
            // 
            this.lblLetter1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter1.Location = new System.Drawing.Point(167, 410);
            this.lblLetter1.Name = "lblLetter1";
            this.lblLetter1.Size = new System.Drawing.Size(20, 25);
            this.lblLetter1.TabIndex = 96;
            this.lblLetter1.Text = "x";
            this.lblLetter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter2
            // 
            this.lblLetter2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter2.Location = new System.Drawing.Point(192, 410);
            this.lblLetter2.Name = "lblLetter2";
            this.lblLetter2.Size = new System.Drawing.Size(20, 25);
            this.lblLetter2.TabIndex = 97;
            this.lblLetter2.Text = "x";
            this.lblLetter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter3
            // 
            this.lblLetter3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter3.Location = new System.Drawing.Point(217, 410);
            this.lblLetter3.Name = "lblLetter3";
            this.lblLetter3.Size = new System.Drawing.Size(20, 25);
            this.lblLetter3.TabIndex = 98;
            this.lblLetter3.Text = "x";
            this.lblLetter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter4
            // 
            this.lblLetter4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter4.Location = new System.Drawing.Point(242, 410);
            this.lblLetter4.Name = "lblLetter4";
            this.lblLetter4.Size = new System.Drawing.Size(20, 25);
            this.lblLetter4.TabIndex = 99;
            this.lblLetter4.Text = "x";
            this.lblLetter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter5
            // 
            this.lblLetter5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter5.Location = new System.Drawing.Point(267, 410);
            this.lblLetter5.Name = "lblLetter5";
            this.lblLetter5.Size = new System.Drawing.Size(20, 25);
            this.lblLetter5.TabIndex = 100;
            this.lblLetter5.Text = "x";
            this.lblLetter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter6
            // 
            this.lblLetter6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter6.Location = new System.Drawing.Point(292, 410);
            this.lblLetter6.Name = "lblLetter6";
            this.lblLetter6.Size = new System.Drawing.Size(20, 25);
            this.lblLetter6.TabIndex = 101;
            this.lblLetter6.Text = "x";
            this.lblLetter6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter7
            // 
            this.lblLetter7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter7.Location = new System.Drawing.Point(317, 410);
            this.lblLetter7.Name = "lblLetter7";
            this.lblLetter7.Size = new System.Drawing.Size(20, 25);
            this.lblLetter7.TabIndex = 102;
            this.lblLetter7.Text = "x";
            this.lblLetter7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter8
            // 
            this.lblLetter8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter8.Location = new System.Drawing.Point(342, 410);
            this.lblLetter8.Name = "lblLetter8";
            this.lblLetter8.Size = new System.Drawing.Size(20, 25);
            this.lblLetter8.TabIndex = 103;
            this.lblLetter8.Text = "x";
            this.lblLetter8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter9
            // 
            this.lblLetter9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter9.Location = new System.Drawing.Point(367, 410);
            this.lblLetter9.Name = "lblLetter9";
            this.lblLetter9.Size = new System.Drawing.Size(20, 25);
            this.lblLetter9.TabIndex = 104;
            this.lblLetter9.Text = "x";
            this.lblLetter9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter10
            // 
            this.lblLetter10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter10.Location = new System.Drawing.Point(392, 410);
            this.lblLetter10.Name = "lblLetter10";
            this.lblLetter10.Size = new System.Drawing.Size(20, 25);
            this.lblLetter10.TabIndex = 105;
            this.lblLetter10.Text = "x";
            this.lblLetter10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter11
            // 
            this.lblLetter11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter11.Location = new System.Drawing.Point(417, 410);
            this.lblLetter11.Name = "lblLetter11";
            this.lblLetter11.Size = new System.Drawing.Size(20, 25);
            this.lblLetter11.TabIndex = 106;
            this.lblLetter11.Text = "x";
            this.lblLetter11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter12
            // 
            this.lblLetter12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter12.Location = new System.Drawing.Point(442, 410);
            this.lblLetter12.Name = "lblLetter12";
            this.lblLetter12.Size = new System.Drawing.Size(20, 25);
            this.lblLetter12.TabIndex = 107;
            this.lblLetter12.Text = "x";
            this.lblLetter12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter13
            // 
            this.lblLetter13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter13.Location = new System.Drawing.Point(467, 410);
            this.lblLetter13.Name = "lblLetter13";
            this.lblLetter13.Size = new System.Drawing.Size(20, 25);
            this.lblLetter13.TabIndex = 108;
            this.lblLetter13.Text = "x";
            this.lblLetter13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetter14
            // 
            this.lblLetter14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter14.Location = new System.Drawing.Point(492, 410);
            this.lblLetter14.Name = "lblLetter14";
            this.lblLetter14.Size = new System.Drawing.Size(20, 25);
            this.lblLetter14.TabIndex = 109;
            this.lblLetter14.Text = "x";
            this.lblLetter14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWLine0
            // 
            this.lblWLine0.BackColor = System.Drawing.Color.Black;
            this.lblWLine0.Location = new System.Drawing.Point(142, 440);
            this.lblWLine0.Name = "lblWLine0";
            this.lblWLine0.Size = new System.Drawing.Size(20, 1);
            this.lblWLine0.TabIndex = 110;
            // 
            // lblWLine1
            // 
            this.lblWLine1.BackColor = System.Drawing.Color.Black;
            this.lblWLine1.Location = new System.Drawing.Point(167, 440);
            this.lblWLine1.Name = "lblWLine1";
            this.lblWLine1.Size = new System.Drawing.Size(20, 1);
            this.lblWLine1.TabIndex = 111;
            // 
            // lblWLine2
            // 
            this.lblWLine2.BackColor = System.Drawing.Color.Black;
            this.lblWLine2.Location = new System.Drawing.Point(192, 440);
            this.lblWLine2.Name = "lblWLine2";
            this.lblWLine2.Size = new System.Drawing.Size(20, 1);
            this.lblWLine2.TabIndex = 112;
            // 
            // lblWLine3
            // 
            this.lblWLine3.BackColor = System.Drawing.Color.Black;
            this.lblWLine3.Location = new System.Drawing.Point(217, 440);
            this.lblWLine3.Name = "lblWLine3";
            this.lblWLine3.Size = new System.Drawing.Size(20, 1);
            this.lblWLine3.TabIndex = 113;
            // 
            // lblWLine4
            // 
            this.lblWLine4.BackColor = System.Drawing.Color.Black;
            this.lblWLine4.Location = new System.Drawing.Point(242, 440);
            this.lblWLine4.Name = "lblWLine4";
            this.lblWLine4.Size = new System.Drawing.Size(20, 1);
            this.lblWLine4.TabIndex = 114;
            // 
            // lblWLine5
            // 
            this.lblWLine5.BackColor = System.Drawing.Color.Black;
            this.lblWLine5.Location = new System.Drawing.Point(267, 440);
            this.lblWLine5.Name = "lblWLine5";
            this.lblWLine5.Size = new System.Drawing.Size(20, 1);
            this.lblWLine5.TabIndex = 115;
            // 
            // lblWLine6
            // 
            this.lblWLine6.BackColor = System.Drawing.Color.Black;
            this.lblWLine6.Location = new System.Drawing.Point(292, 440);
            this.lblWLine6.Name = "lblWLine6";
            this.lblWLine6.Size = new System.Drawing.Size(20, 1);
            this.lblWLine6.TabIndex = 116;
            // 
            // lblWLine7
            // 
            this.lblWLine7.BackColor = System.Drawing.Color.Black;
            this.lblWLine7.Location = new System.Drawing.Point(317, 440);
            this.lblWLine7.Name = "lblWLine7";
            this.lblWLine7.Size = new System.Drawing.Size(20, 1);
            this.lblWLine7.TabIndex = 117;
            // 
            // lblWLine8
            // 
            this.lblWLine8.BackColor = System.Drawing.Color.Black;
            this.lblWLine8.Location = new System.Drawing.Point(342, 440);
            this.lblWLine8.Name = "lblWLine8";
            this.lblWLine8.Size = new System.Drawing.Size(20, 1);
            this.lblWLine8.TabIndex = 118;
            // 
            // lblWLine9
            // 
            this.lblWLine9.BackColor = System.Drawing.Color.Black;
            this.lblWLine9.Location = new System.Drawing.Point(367, 440);
            this.lblWLine9.Name = "lblWLine9";
            this.lblWLine9.Size = new System.Drawing.Size(20, 1);
            this.lblWLine9.TabIndex = 119;
            // 
            // lblWLine10
            // 
            this.lblWLine10.BackColor = System.Drawing.Color.Black;
            this.lblWLine10.Location = new System.Drawing.Point(392, 440);
            this.lblWLine10.Name = "lblWLine10";
            this.lblWLine10.Size = new System.Drawing.Size(20, 1);
            this.lblWLine10.TabIndex = 120;
            // 
            // lblWLine11
            // 
            this.lblWLine11.BackColor = System.Drawing.Color.Black;
            this.lblWLine11.Location = new System.Drawing.Point(417, 440);
            this.lblWLine11.Name = "lblWLine11";
            this.lblWLine11.Size = new System.Drawing.Size(20, 1);
            this.lblWLine11.TabIndex = 121;
            // 
            // lblWLine12
            // 
            this.lblWLine12.BackColor = System.Drawing.Color.Black;
            this.lblWLine12.Location = new System.Drawing.Point(442, 440);
            this.lblWLine12.Name = "lblWLine12";
            this.lblWLine12.Size = new System.Drawing.Size(20, 1);
            this.lblWLine12.TabIndex = 122;
            // 
            // lblWLine13
            // 
            this.lblWLine13.BackColor = System.Drawing.Color.Black;
            this.lblWLine13.Location = new System.Drawing.Point(467, 440);
            this.lblWLine13.Name = "lblWLine13";
            this.lblWLine13.Size = new System.Drawing.Size(20, 1);
            this.lblWLine13.TabIndex = 123;
            // 
            // lblWLine14
            // 
            this.lblWLine14.BackColor = System.Drawing.Color.Black;
            this.lblWLine14.Location = new System.Drawing.Point(492, 440);
            this.lblWLine14.Name = "lblWLine14";
            this.lblWLine14.Size = new System.Drawing.Size(20, 1);
            this.lblWLine14.TabIndex = 124;
            // 
            // lblAlpha0
            // 
            this.lblAlpha0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha0.Location = new System.Drawing.Point(244, 491);
            this.lblAlpha0.Name = "lblAlpha0";
            this.lblAlpha0.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha0.TabIndex = 125;
            this.lblAlpha0.Text = "x";
            this.lblAlpha0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha1
            // 
            this.lblAlpha1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha1.Location = new System.Drawing.Point(260, 491);
            this.lblAlpha1.Name = "lblAlpha1";
            this.lblAlpha1.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha1.TabIndex = 126;
            this.lblAlpha1.Text = "x";
            this.lblAlpha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha2
            // 
            this.lblAlpha2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha2.Location = new System.Drawing.Point(276, 491);
            this.lblAlpha2.Name = "lblAlpha2";
            this.lblAlpha2.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha2.TabIndex = 127;
            this.lblAlpha2.Text = "x";
            this.lblAlpha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha3
            // 
            this.lblAlpha3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha3.Location = new System.Drawing.Point(292, 491);
            this.lblAlpha3.Name = "lblAlpha3";
            this.lblAlpha3.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha3.TabIndex = 128;
            this.lblAlpha3.Text = "x";
            this.lblAlpha3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha4
            // 
            this.lblAlpha4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha4.Location = new System.Drawing.Point(308, 491);
            this.lblAlpha4.Name = "lblAlpha4";
            this.lblAlpha4.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha4.TabIndex = 129;
            this.lblAlpha4.Text = "x";
            this.lblAlpha4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha5
            // 
            this.lblAlpha5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha5.Location = new System.Drawing.Point(324, 491);
            this.lblAlpha5.Name = "lblAlpha5";
            this.lblAlpha5.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha5.TabIndex = 130;
            this.lblAlpha5.Text = "x";
            this.lblAlpha5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha6
            // 
            this.lblAlpha6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha6.Location = new System.Drawing.Point(340, 491);
            this.lblAlpha6.Name = "lblAlpha6";
            this.lblAlpha6.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha6.TabIndex = 131;
            this.lblAlpha6.Text = "x";
            this.lblAlpha6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha7
            // 
            this.lblAlpha7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha7.Location = new System.Drawing.Point(356, 491);
            this.lblAlpha7.Name = "lblAlpha7";
            this.lblAlpha7.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha7.TabIndex = 132;
            this.lblAlpha7.Text = "x";
            this.lblAlpha7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha8
            // 
            this.lblAlpha8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha8.Location = new System.Drawing.Point(372, 491);
            this.lblAlpha8.Name = "lblAlpha8";
            this.lblAlpha8.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha8.TabIndex = 133;
            this.lblAlpha8.Text = "x";
            this.lblAlpha8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha9
            // 
            this.lblAlpha9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha9.Location = new System.Drawing.Point(388, 491);
            this.lblAlpha9.Name = "lblAlpha9";
            this.lblAlpha9.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha9.TabIndex = 134;
            this.lblAlpha9.Text = "x";
            this.lblAlpha9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha10
            // 
            this.lblAlpha10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha10.Location = new System.Drawing.Point(404, 491);
            this.lblAlpha10.Name = "lblAlpha10";
            this.lblAlpha10.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha10.TabIndex = 135;
            this.lblAlpha10.Text = "x";
            this.lblAlpha10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha11
            // 
            this.lblAlpha11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha11.Location = new System.Drawing.Point(420, 491);
            this.lblAlpha11.Name = "lblAlpha11";
            this.lblAlpha11.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha11.TabIndex = 136;
            this.lblAlpha11.Text = "x";
            this.lblAlpha11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha12
            // 
            this.lblAlpha12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha12.Location = new System.Drawing.Point(436, 491);
            this.lblAlpha12.Name = "lblAlpha12";
            this.lblAlpha12.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha12.TabIndex = 137;
            this.lblAlpha12.Text = "x";
            this.lblAlpha12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha13
            // 
            this.lblAlpha13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha13.Location = new System.Drawing.Point(452, 491);
            this.lblAlpha13.Name = "lblAlpha13";
            this.lblAlpha13.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha13.TabIndex = 138;
            this.lblAlpha13.Text = "x";
            this.lblAlpha13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlpha14
            // 
            this.lblAlpha14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlpha14.Location = new System.Drawing.Point(468, 491);
            this.lblAlpha14.Name = "lblAlpha14";
            this.lblAlpha14.Size = new System.Drawing.Size(17, 17);
            this.lblAlpha14.TabIndex = 139;
            this.lblAlpha14.Text = "x";
            this.lblAlpha14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdLetter0
            // 
            this.cmdLetter0.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter0.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter0.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter0.Location = new System.Drawing.Point(329, 197);
            this.cmdLetter0.Name = "cmdLetter0";
            this.cmdLetter0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter0.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter0.TabIndex = 140;
            this.cmdLetter0.TabStop = false;
            this.cmdLetter0.Tag = "0";
            this.cmdLetter0.Text = "A";
            this.cmdLetter0.UseVisualStyleBackColor = false;
            this.cmdLetter0.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter1
            // 
            this.cmdLetter1.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter1.Location = new System.Drawing.Point(355, 197);
            this.cmdLetter1.Name = "cmdLetter1";
            this.cmdLetter1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter1.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter1.TabIndex = 141;
            this.cmdLetter1.TabStop = false;
            this.cmdLetter1.Tag = "1";
            this.cmdLetter1.Text = "B";
            this.cmdLetter1.UseVisualStyleBackColor = false;
            this.cmdLetter1.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter2
            // 
            this.cmdLetter2.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter2.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter2.Location = new System.Drawing.Point(382, 197);
            this.cmdLetter2.Name = "cmdLetter2";
            this.cmdLetter2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter2.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter2.TabIndex = 142;
            this.cmdLetter2.TabStop = false;
            this.cmdLetter2.Tag = "2";
            this.cmdLetter2.Text = "C";
            this.cmdLetter2.UseVisualStyleBackColor = false;
            this.cmdLetter2.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter3
            // 
            this.cmdLetter3.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter3.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter3.Location = new System.Drawing.Point(409, 197);
            this.cmdLetter3.Name = "cmdLetter3";
            this.cmdLetter3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter3.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter3.TabIndex = 143;
            this.cmdLetter3.TabStop = false;
            this.cmdLetter3.Tag = "3";
            this.cmdLetter3.Text = "D";
            this.cmdLetter3.UseVisualStyleBackColor = false;
            this.cmdLetter3.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter4
            // 
            this.cmdLetter4.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter4.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter4.Location = new System.Drawing.Point(436, 197);
            this.cmdLetter4.Name = "cmdLetter4";
            this.cmdLetter4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter4.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter4.TabIndex = 144;
            this.cmdLetter4.TabStop = false;
            this.cmdLetter4.Tag = "4";
            this.cmdLetter4.Text = "E";
            this.cmdLetter4.UseVisualStyleBackColor = false;
            this.cmdLetter4.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter5
            // 
            this.cmdLetter5.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter5.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter5.Location = new System.Drawing.Point(463, 197);
            this.cmdLetter5.Name = "cmdLetter5";
            this.cmdLetter5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter5.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter5.TabIndex = 145;
            this.cmdLetter5.TabStop = false;
            this.cmdLetter5.Tag = "5";
            this.cmdLetter5.Text = "F";
            this.cmdLetter5.UseVisualStyleBackColor = false;
            this.cmdLetter5.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter6
            // 
            this.cmdLetter6.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter6.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter6.Location = new System.Drawing.Point(490, 197);
            this.cmdLetter6.Name = "cmdLetter6";
            this.cmdLetter6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter6.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter6.TabIndex = 146;
            this.cmdLetter6.TabStop = false;
            this.cmdLetter6.Tag = "6";
            this.cmdLetter6.Text = "G";
            this.cmdLetter6.UseVisualStyleBackColor = false;
            this.cmdLetter6.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter12
            // 
            this.cmdLetter12.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter12.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter12.Location = new System.Drawing.Point(652, 197);
            this.cmdLetter12.Name = "cmdLetter12";
            this.cmdLetter12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter12.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter12.TabIndex = 152;
            this.cmdLetter12.TabStop = false;
            this.cmdLetter12.Tag = "12";
            this.cmdLetter12.Text = "M";
            this.cmdLetter12.UseVisualStyleBackColor = false;
            this.cmdLetter12.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter11
            // 
            this.cmdLetter11.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter11.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter11.Location = new System.Drawing.Point(625, 197);
            this.cmdLetter11.Name = "cmdLetter11";
            this.cmdLetter11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter11.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter11.TabIndex = 151;
            this.cmdLetter11.TabStop = false;
            this.cmdLetter11.Tag = "11";
            this.cmdLetter11.Text = "L";
            this.cmdLetter11.UseVisualStyleBackColor = false;
            this.cmdLetter11.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter10
            // 
            this.cmdLetter10.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter10.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter10.Location = new System.Drawing.Point(598, 197);
            this.cmdLetter10.Name = "cmdLetter10";
            this.cmdLetter10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter10.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter10.TabIndex = 150;
            this.cmdLetter10.TabStop = false;
            this.cmdLetter10.Tag = "10";
            this.cmdLetter10.Text = "K";
            this.cmdLetter10.UseVisualStyleBackColor = false;
            this.cmdLetter10.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter9
            // 
            this.cmdLetter9.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter9.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter9.Location = new System.Drawing.Point(571, 197);
            this.cmdLetter9.Name = "cmdLetter9";
            this.cmdLetter9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter9.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter9.TabIndex = 149;
            this.cmdLetter9.TabStop = false;
            this.cmdLetter9.Tag = "9";
            this.cmdLetter9.Text = "J";
            this.cmdLetter9.UseVisualStyleBackColor = false;
            this.cmdLetter9.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter8
            // 
            this.cmdLetter8.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter8.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter8.Location = new System.Drawing.Point(544, 197);
            this.cmdLetter8.Name = "cmdLetter8";
            this.cmdLetter8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter8.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter8.TabIndex = 148;
            this.cmdLetter8.TabStop = false;
            this.cmdLetter8.Tag = "8";
            this.cmdLetter8.Text = "I";
            this.cmdLetter8.UseVisualStyleBackColor = false;
            this.cmdLetter8.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter7
            // 
            this.cmdLetter7.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter7.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter7.Location = new System.Drawing.Point(517, 197);
            this.cmdLetter7.Name = "cmdLetter7";
            this.cmdLetter7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter7.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter7.TabIndex = 147;
            this.cmdLetter7.TabStop = false;
            this.cmdLetter7.Tag = "7";
            this.cmdLetter7.Text = "H";
            this.cmdLetter7.UseVisualStyleBackColor = false;
            this.cmdLetter7.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter25
            // 
            this.cmdLetter25.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter25.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter25.Location = new System.Drawing.Point(651, 227);
            this.cmdLetter25.Name = "cmdLetter25";
            this.cmdLetter25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter25.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter25.TabIndex = 165;
            this.cmdLetter25.TabStop = false;
            this.cmdLetter25.Tag = "25";
            this.cmdLetter25.Text = "Z";
            this.cmdLetter25.UseVisualStyleBackColor = false;
            this.cmdLetter25.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter24
            // 
            this.cmdLetter24.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter24.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter24.Location = new System.Drawing.Point(624, 227);
            this.cmdLetter24.Name = "cmdLetter24";
            this.cmdLetter24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter24.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter24.TabIndex = 164;
            this.cmdLetter24.TabStop = false;
            this.cmdLetter24.Tag = "24";
            this.cmdLetter24.Text = "Y";
            this.cmdLetter24.UseVisualStyleBackColor = false;
            this.cmdLetter24.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter23
            // 
            this.cmdLetter23.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter23.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter23.Location = new System.Drawing.Point(597, 227);
            this.cmdLetter23.Name = "cmdLetter23";
            this.cmdLetter23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter23.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter23.TabIndex = 163;
            this.cmdLetter23.TabStop = false;
            this.cmdLetter23.Tag = "23";
            this.cmdLetter23.Text = "X";
            this.cmdLetter23.UseVisualStyleBackColor = false;
            this.cmdLetter23.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter22
            // 
            this.cmdLetter22.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter22.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter22.Location = new System.Drawing.Point(570, 227);
            this.cmdLetter22.Name = "cmdLetter22";
            this.cmdLetter22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter22.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter22.TabIndex = 162;
            this.cmdLetter22.TabStop = false;
            this.cmdLetter22.Tag = "22";
            this.cmdLetter22.Text = "W";
            this.cmdLetter22.UseVisualStyleBackColor = false;
            this.cmdLetter22.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter21
            // 
            this.cmdLetter21.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter21.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter21.Location = new System.Drawing.Point(544, 227);
            this.cmdLetter21.Name = "cmdLetter21";
            this.cmdLetter21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter21.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter21.TabIndex = 161;
            this.cmdLetter21.TabStop = false;
            this.cmdLetter21.Tag = "21";
            this.cmdLetter21.Text = "V";
            this.cmdLetter21.UseVisualStyleBackColor = false;
            this.cmdLetter21.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter20
            // 
            this.cmdLetter20.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter20.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter20.Location = new System.Drawing.Point(517, 227);
            this.cmdLetter20.Name = "cmdLetter20";
            this.cmdLetter20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter20.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter20.TabIndex = 160;
            this.cmdLetter20.TabStop = false;
            this.cmdLetter20.Tag = "20";
            this.cmdLetter20.Text = "U";
            this.cmdLetter20.UseVisualStyleBackColor = false;
            this.cmdLetter20.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter19
            // 
            this.cmdLetter19.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter19.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter19.Location = new System.Drawing.Point(490, 227);
            this.cmdLetter19.Name = "cmdLetter19";
            this.cmdLetter19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter19.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter19.TabIndex = 159;
            this.cmdLetter19.TabStop = false;
            this.cmdLetter19.Tag = "19";
            this.cmdLetter19.Text = "T";
            this.cmdLetter19.UseVisualStyleBackColor = false;
            this.cmdLetter19.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter18
            // 
            this.cmdLetter18.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter18.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter18.Location = new System.Drawing.Point(463, 227);
            this.cmdLetter18.Name = "cmdLetter18";
            this.cmdLetter18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter18.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter18.TabIndex = 158;
            this.cmdLetter18.TabStop = false;
            this.cmdLetter18.Tag = "18";
            this.cmdLetter18.Text = "S";
            this.cmdLetter18.UseVisualStyleBackColor = false;
            this.cmdLetter18.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter17
            // 
            this.cmdLetter17.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter17.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter17.Location = new System.Drawing.Point(436, 227);
            this.cmdLetter17.Name = "cmdLetter17";
            this.cmdLetter17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter17.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter17.TabIndex = 157;
            this.cmdLetter17.TabStop = false;
            this.cmdLetter17.Tag = "17";
            this.cmdLetter17.Text = "R";
            this.cmdLetter17.UseVisualStyleBackColor = false;
            this.cmdLetter17.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter16
            // 
            this.cmdLetter16.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter16.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter16.Location = new System.Drawing.Point(409, 227);
            this.cmdLetter16.Name = "cmdLetter16";
            this.cmdLetter16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter16.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter16.TabIndex = 156;
            this.cmdLetter16.TabStop = false;
            this.cmdLetter16.Tag = "16";
            this.cmdLetter16.Text = "Q";
            this.cmdLetter16.UseVisualStyleBackColor = false;
            this.cmdLetter16.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter15
            // 
            this.cmdLetter15.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter15.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter15.Location = new System.Drawing.Point(382, 227);
            this.cmdLetter15.Name = "cmdLetter15";
            this.cmdLetter15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter15.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter15.TabIndex = 155;
            this.cmdLetter15.TabStop = false;
            this.cmdLetter15.Tag = "15";
            this.cmdLetter15.Text = "P";
            this.cmdLetter15.UseVisualStyleBackColor = false;
            this.cmdLetter15.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter14
            // 
            this.cmdLetter14.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter14.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter14.Location = new System.Drawing.Point(355, 227);
            this.cmdLetter14.Name = "cmdLetter14";
            this.cmdLetter14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter14.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter14.TabIndex = 154;
            this.cmdLetter14.TabStop = false;
            this.cmdLetter14.Tag = "14";
            this.cmdLetter14.Text = "O";
            this.cmdLetter14.UseVisualStyleBackColor = false;
            this.cmdLetter14.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // cmdLetter13
            // 
            this.cmdLetter13.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLetter13.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLetter13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLetter13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLetter13.Location = new System.Drawing.Point(329, 227);
            this.cmdLetter13.Name = "cmdLetter13";
            this.cmdLetter13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLetter13.Size = new System.Drawing.Size(25, 25);
            this.cmdLetter13.TabIndex = 153;
            this.cmdLetter13.TabStop = false;
            this.cmdLetter13.Tag = "13";
            this.cmdLetter13.Text = "N";
            this.cmdLetter13.UseVisualStyleBackColor = false;
            this.cmdLetter13.Click += new System.EventHandler(this.cmdletter_Click);
            // 
            // lblShowWord
            // 
            this.lblShowWord.BackColor = System.Drawing.Color.Transparent;
            this.lblShowWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowWord.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblShowWord.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowWord.ForeColor = System.Drawing.Color.Yellow;
            this.lblShowWord.Location = new System.Drawing.Point(572, 418);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblShowWord.Size = new System.Drawing.Size(173, 17);
            this.lblShowWord.TabIndex = 166;
            this.lblShowWord.Visible = false;
            // 
            // lblMaxChars
            // 
            this.lblMaxChars.AutoSize = true;
            this.lblMaxChars.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxChars.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMaxChars.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxChars.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaxChars.Location = new System.Drawing.Point(139, 455);
            this.lblMaxChars.Name = "lblMaxChars";
            this.lblMaxChars.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMaxChars.Size = new System.Drawing.Size(66, 16);
            this.lblMaxChars.TabIndex = 168;
            this.lblMaxChars.Text = "MaxChars";
            this.lblMaxChars.Visible = false;
            // 
            // sbStatusStrip
            // 
            this.sbStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sbStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel9});
            this.sbStatusStrip.Location = new System.Drawing.Point(0, 549);
            this.sbStatusStrip.Name = "sbStatusStrip";
            this.sbStatusStrip.Size = new System.Drawing.Size(925, 22);
            this.sbStatusStrip.TabIndex = 169;
            this.sbStatusStrip.Text = "sbStatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel1.Text = "Label0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(175, 17);
            this.toolStripStatusLabel2.Text = "Label1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel3.Text = "Label2";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel4.Text = "Label3";
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel5.Text = "Label4";
            this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel6.Text = "Label5";
            this.toolStripStatusLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.AutoSize = false;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabel7.Text = "Label6";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.AutoSize = false;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel8.Text = "Label7";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.AutoSize = false;
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel9.Text = "Label8";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Silver;
            this.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(925, 45);
            this.ToolStrip1.Stretch = true;
            this.ToolStrip1.TabIndex = 170;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::My.Resources.Resources.ANIMALS;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 42);
            this.toolStripButton1.Text = "Animals";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::My.Resources.Resources.FOOD;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 42);
            this.toolStripButton2.Text = "Food";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::My.Resources.Resources.HOLIDAYS;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(59, 42);
            this.toolStripButton3.Text = "Holidays";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::My.Resources.Resources.HOME;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(59, 42);
            this.toolStripButton4.Text = "Home";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::My.Resources.Resources.LEISURE;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(59, 42);
            this.toolStripButton5.Text = "Leisure";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::My.Resources.Resources.SEASONS;
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(59, 42);
            this.toolStripButton6.Text = "Seasons";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::My.Resources.Resources.SPORTS;
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(59, 42);
            this.toolStripButton7.Text = "Sports";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::My.Resources.Resources.WEATHER;
            this.toolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(59, 42);
            this.toolStripButton8.Text = "Weather";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = global::My.Resources.Resources.MISC;
            this.toolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(59, 42);
            this.toolStripButton9.Text = "Misc";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblEncryptedValue
            // 
            this.lblEncryptedValue.Location = new System.Drawing.Point(721, 266);
            this.lblEncryptedValue.Name = "lblEncryptedValue";
            this.lblEncryptedValue.Size = new System.Drawing.Size(100, 20);
            this.lblEncryptedValue.TabIndex = 171;
            // 
            // lblDecryptedValue
            // 
            this.lblDecryptedValue.Location = new System.Drawing.Point(721, 364);
            this.lblDecryptedValue.Name = "lblDecryptedValue";
            this.lblDecryptedValue.Size = new System.Drawing.Size(100, 20);
            this.lblDecryptedValue.TabIndex = 172;
            // 
            // txtNormalValue
            // 
            this.txtNormalValue.Location = new System.Drawing.Point(721, 218);
            this.txtNormalValue.Name = "txtNormalValue";
            this.txtNormalValue.Size = new System.Drawing.Size(159, 20);
            this.txtNormalValue.TabIndex = 173;
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Location = new System.Drawing.Point(721, 247);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(47, 14);
            this.lblEncrypt.TabIndex = 174;
            this.lblEncrypt.Text = "Encrypt:";
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.Location = new System.Drawing.Point(721, 347);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(48, 14);
            this.lblDecrypt.TabIndex = 175;
            this.lblDecrypt.Text = "Decrypt:";
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(827, 266);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(53, 23);
            this.Encrypt.TabIndex = 176;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Location = new System.Drawing.Point(721, 199);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(73, 14);
            this.lblNormal.TabIndex = 177;
            this.lblNormal.Text = "Normal Value:";
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(825, 360);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(55, 23);
            this.Decrypt.TabIndex = 178;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Location = new System.Drawing.Point(721, 301);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(89, 14);
            this.lblEncrypted.TabIndex = 179;
            this.lblEncrypted.Text = "Encrypted Value:";
            // 
            // txtEncryptedValue
            // 
            this.txtEncryptedValue.Location = new System.Drawing.Point(721, 318);
            this.txtEncryptedValue.Name = "txtEncryptedValue";
            this.txtEncryptedValue.Size = new System.Drawing.Size(156, 20);
            this.txtEncryptedValue.TabIndex = 180;
            // 
            // btnShowWord
            // 
            this.btnShowWord.Location = new System.Drawing.Point(751, 415);
            this.btnShowWord.Name = "btnShowWord";
            this.btnShowWord.Size = new System.Drawing.Size(75, 23);
            this.btnShowWord.TabIndex = 181;
            this.btnShowWord.Text = "Show Word";
            this.btnShowWord.UseVisualStyleBackColor = true;
            this.btnShowWord.Click += new System.EventHandler(this.btnShowWord_Click);
            // 
            // btnHideWord
            // 
            this.btnHideWord.Location = new System.Drawing.Point(751, 440);
            this.btnHideWord.Name = "btnHideWord";
            this.btnHideWord.Size = new System.Drawing.Size(75, 23);
            this.btnHideWord.TabIndex = 182;
            this.btnHideWord.Text = "Hide Word";
            this.btnHideWord.UseVisualStyleBackColor = true;
            this.btnHideWord.Click += new System.EventHandler(this.btnHideWord_Click);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(925, 571);
            this.Controls.Add(this.btnHideWord);
            this.Controls.Add(this.btnShowWord);
            this.Controls.Add(this.txtEncryptedValue);
            this.Controls.Add(this.lblEncrypted);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.lblNormal);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.lblDecrypt);
            this.Controls.Add(this.lblEncrypt);
            this.Controls.Add(this.txtNormalValue);
            this.Controls.Add(this.lblDecryptedValue);
            this.Controls.Add(this.lblEncryptedValue);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.sbStatusStrip);
            this.Controls.Add(this.lblMaxChars);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.cmdLetter25);
            this.Controls.Add(this.cmdLetter24);
            this.Controls.Add(this.cmdLetter23);
            this.Controls.Add(this.cmdLetter22);
            this.Controls.Add(this.cmdLetter21);
            this.Controls.Add(this.cmdLetter20);
            this.Controls.Add(this.cmdLetter19);
            this.Controls.Add(this.cmdLetter18);
            this.Controls.Add(this.cmdLetter17);
            this.Controls.Add(this.cmdLetter16);
            this.Controls.Add(this.cmdLetter15);
            this.Controls.Add(this.cmdLetter14);
            this.Controls.Add(this.cmdLetter13);
            this.Controls.Add(this.cmdLetter12);
            this.Controls.Add(this.cmdLetter11);
            this.Controls.Add(this.cmdLetter10);
            this.Controls.Add(this.cmdLetter9);
            this.Controls.Add(this.cmdLetter8);
            this.Controls.Add(this.cmdLetter7);
            this.Controls.Add(this.cmdLetter6);
            this.Controls.Add(this.cmdLetter5);
            this.Controls.Add(this.cmdLetter4);
            this.Controls.Add(this.cmdLetter3);
            this.Controls.Add(this.cmdLetter2);
            this.Controls.Add(this.cmdLetter1);
            this.Controls.Add(this.cmdLetter0);
            this.Controls.Add(this.lblAlpha14);
            this.Controls.Add(this.lblAlpha13);
            this.Controls.Add(this.lblAlpha12);
            this.Controls.Add(this.lblAlpha11);
            this.Controls.Add(this.lblAlpha10);
            this.Controls.Add(this.lblAlpha9);
            this.Controls.Add(this.lblAlpha8);
            this.Controls.Add(this.lblAlpha7);
            this.Controls.Add(this.lblAlpha6);
            this.Controls.Add(this.lblAlpha5);
            this.Controls.Add(this.lblAlpha4);
            this.Controls.Add(this.lblAlpha3);
            this.Controls.Add(this.lblAlpha2);
            this.Controls.Add(this.lblAlpha1);
            this.Controls.Add(this.lblAlpha0);
            this.Controls.Add(this.lblWLine14);
            this.Controls.Add(this.lblWLine13);
            this.Controls.Add(this.lblWLine12);
            this.Controls.Add(this.lblWLine11);
            this.Controls.Add(this.lblWLine10);
            this.Controls.Add(this.lblWLine9);
            this.Controls.Add(this.lblWLine8);
            this.Controls.Add(this.lblWLine7);
            this.Controls.Add(this.lblWLine6);
            this.Controls.Add(this.lblWLine5);
            this.Controls.Add(this.lblWLine4);
            this.Controls.Add(this.lblWLine3);
            this.Controls.Add(this.lblWLine2);
            this.Controls.Add(this.lblWLine1);
            this.Controls.Add(this.lblWLine0);
            this.Controls.Add(this.lblLetter14);
            this.Controls.Add(this.lblLetter13);
            this.Controls.Add(this.lblLetter12);
            this.Controls.Add(this.lblLetter11);
            this.Controls.Add(this.lblLetter10);
            this.Controls.Add(this.lblLetter9);
            this.Controls.Add(this.lblLetter8);
            this.Controls.Add(this.lblLetter7);
            this.Controls.Add(this.lblLetter6);
            this.Controls.Add(this.lblLetter5);
            this.Controls.Add(this.lblLetter4);
            this.Controls.Add(this.lblLetter3);
            this.Controls.Add(this.lblLetter2);
            this.Controls.Add(this.lblLetter1);
            this.Controls.Add(this.lblLetter0);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdNewGame);
            this.Controls.Add(this.Rfoot);
            this.Controls.Add(this.Lfoot);
            this.Controls.Add(this.Rhand);
            this.Controls.Add(this.Lhand);
            this.Controls.Add(this.lblmaxwords);
            this.Controls.Add(this.lblfilename);
            this.Controls.Add(this.lblWordIs);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Line4);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.lblStatus);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(169, 105);
            this.Menu = this.MainMenu1;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hangman";
            this.Closed += new System.EventHandler(this.frmMain_Closed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sbStatusStrip.ResumeLayout(false);
            this.sbStatusStrip.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		
		//Visual Studio 2013
		short mflag;
		string tfile;
		short maxflag;      //max word is 15 chars
        short MaxNum;       //mode of player, true for advanced, beginner shows hands and feet
		short mtmp;         //hold file number to reset NFile if user does not play new game
		short moldtmp;      //hold old category
		bool CatFlag2;
		bool CatFlag1;
		bool CatFlag3;
		bool CatFlag4;
		bool CatFlag7;
		bool CatFlag5;
		bool CatFlag6;
		bool CatFlag8;
		bool CatFlag9;
		bool gameover;
		
		System.Drawing.Graphics gfxobj;
		int x1;
		int y1;
		int x2;
		int y2;
		int w1;         //width
		int h1;         //height
		Pen pen;

        string[] newfields;
        int newfieldsNum;
                
		private void cmdletter_Click(System.Object eventSender, System.EventArgs eventArgs)
		{

            Button NewButton = (Button)eventSender;
            //MessageBox.Show("Got Here!", "Got Here!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			
            short Index = Convert.ToInt16(NewButton.Tag);

            //MessageBox.Show("Got Here!", "Got Here!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //return;

            //index will start at zero for letter "A" to 25 for letter "Z"
			//MsgBox(Index)
			
			string AlphaLetter;
			short flag = 0;
			short done;
			short tmpflag;

            //MessageBox.Show("Got Here!", "Got Here!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //return;


			if (! gameover)
			{
				mflag = 0;
				AlphaLetter = "";
				HMGLOBAL.GetAlphaLetter(Index, ref AlphaLetter);

                //MessageBox.Show("Index= " + Index + "AlphaLetter= " + AlphaLetter, "AlphaLetter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //return;

				//MsgBox(Index & " " & AlphaLetter)
				
				CheckWordForValidLetter(AlphaLetter, ref flag);
                //MessageBox.Show("flag= " + flag + "AlphaLetter= " + AlphaLetter, "flag", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                DisableCmdLetter(Index);
                //MessageBox.Show("Index= " + Index, "Index", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //return;

				//check if word is guessed
                tmpflag = 1;
                //System.Convert.ToInt16(true);
				WasWordGuessed(ref tmpflag);

                //MessageBox.Show("tmpflag" + tmpflag, "tmpflag", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //return;
                
                //tmpflag is true if word was guessed
				//if (System.Convert.ToBoolean(tmpflag))
                if (tmpflag == 1)
                {
					lblStatus.Text = "You Win!";
					gameover = true;
					//start new game
                    mflag = 1;
                    
					HMGLOBAL.MaxGames++;
					HMGLOBAL.MaxWins++;
					UpDateStatusBar(HMGLOBAL.MaxGames, HMGLOBAL.MaxWins);
					//play sound if gSound equals 1
					if (HMGLOBAL.gSound == 1)
					{
						HMGLOBAL.PlayWinSound();
						SetSoundMenuItems(HMGLOBAL.gSound);
					}
				}
				else
				{
					//if (System.Convert.ToBoolean(~ flag))
                    if (flag == 0)
                    {
						//start to hang the man
                        done = 0;
                        
						HangMan(ref done);
                        //MessageBox.Show("done=" + done, "done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //return;

						//if (System.Convert.ToBoolean(done))
                        if (done == 1)
                        {
							lblWordIs.Visible = true;
							lblStatus.Text = "You Lost!";
							gameover = true;
							ShowWord();
							//start new game
							mflag = 1;
							HMGLOBAL.MaxGames++;
							UpDateStatusBar(HMGLOBAL.MaxGames, HMGLOBAL.MaxWins);
							if (HMGLOBAL.gSound == 1)
							{
								HMGLOBAL.PlayEndSound();
								SetSoundMenuItems(HMGLOBAL.gSound);
							}
						}
						else
						{
							if (HMGLOBAL.gSound == 1)
							{
								//play sound
								HMGLOBAL.PlayLostSound();
								SetSoundMenuItems(HMGLOBAL.gSound);
							}
						}
					}
				}
				
			}
			else
			{
				cmdNewGame.Focus();
			}
		}
		
		private void Form_Initialize_Game()
		{
			//get ini file name
			ini.GetIntPathSettings();
			ini.GetIniExpired(ref HMGLOBAL.gExpired);
			
			//if program is in demo mode and was used over 30 days then gExpired will be 1
			//and must quit game otherwise gExpired will be 0 and play game
			if (HMGLOBAL.gExpired == 0)
			{
				//check for new install, if so then output
				//system date of today and add value.dat to directory
				ini.CheckForNewInstall();
				//get initial settings for the file to use
				//NFile is the category
				ini.GetIniFileSettings(ref HMGLOBAL.NFile, ref HMGLOBAL.gSound);
				mtmp = HMGLOBAL.NFile;
			}
			else
			{
				//show expired screen and exit program
                ini.CheckForNewInstall();
                frmExpired.Default.ShowDialog();
                //this.Close();
                System.Environment.Exit(0);
			}
			
		}
		
		private void frmMain_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
            //width, height, default 900, 700, changed to 1024x768
            this.Width = 900;
			this.Height = 700;
			
			// Center the Form on the screen
			this.SetBounds((System.Windows.Forms.Screen.GetBounds(this).Width / 2) - (this.Width / 2), (System.Windows.Forms.Screen.GetBounds(this).Height / 2) - (this.Height / 2), this.Width, this.Height, System.Windows.Forms.BoundsSpecified.Location);
			
			//create the graphics object
			gfxobj = CreateGraphics();

            //Hide Encrypt Decrypt TextBoxes
			HideEncryptDecryptTextBox(HMGLOBAL.gHideEncryDecryptTextBoxes);

            if (HMGLOBAL.gbtnShowWord == true)
            {
                btnShowWord.Visible = true;
                btnHideWord.Visible = true;
            }
            else
            {
                btnShowWord.Visible = false;
                btnHideWord.Visible = false;
            }

            //variables used to update status bar
			HMGLOBAL.MaxGames = 0;
			HMGLOBAL.MaxWins = 0;
			mflag = 1;
			//set mode of play, true for advanced level
			HMGLOBAL.gLevel = 1;
			//update status bar text for level
            sbStatusStrip.Items[0].Text = "Level: Advanced";
            sbStatusStrip.Items[1].Text = " ";
            sbStatusStrip.Items[2].Text = "Games:";
            sbStatusStrip.Items[3].Text = " ";
            sbStatusStrip.Items[4].Text = "Wins:";
            sbStatusStrip.Items[5].Text = " ";
            sbStatusStrip.Items[6].Text = " ";
            sbStatusStrip.Items[7].Text = DateTime.Now.ToString("MM/dd/yyyy");
            sbStatusStrip.Items[8].Text = " ";

			SetCategoryMenuItems(HMGLOBAL.NFile);
			SetSoundMenuItems(HMGLOBAL.gSound);
			SetCategoryFlagsFalse();
			lblStatus.BorderStyle = BorderStyle.None;
			
            //used for testing read fdrom file
			//assume all files are in directory
            HMGLOBAL.FindCategoryFile(HMGLOBAL.NFile, ref tfile);

			HMGLOBAL.gFileok = 1;
            HMGLOBAL.DataFileExist(tfile, ref HMGLOBAL.gFileok, ref newfieldsNum);

            //MessageBox.Show("HMGLOBAL.gFileok= " + HMGLOBAL.gFileok, "HMGLOBAL.gFileok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //MessageBox.Show("newfieldsNum= " + newfieldsNum, "newfieldsNum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            HMGLOBAL.gDaysLeft = 0;

            if (HMGLOBAL.gExpireFlag == true)
            {
                HMGLOBAL.gDaysLeft = 30 - HMGLOBAL.gDaysUsed;

                sbStatusStrip.Items[6].ForeColor = Color.Red;
                if (HMGLOBAL.gDaysLeft <= 5)
                {
                    sbStatusStrip.Items[6].Text = HMGLOBAL.gDateInstall + " Demo Expires in " + HMGLOBAL.gDaysLeft + " days.";

                }
                else
                {
                    sbStatusStrip.Items[6].Text = "Demo Expires in " + HMGLOBAL.gDaysLeft + " days.";
                }
                //MessageBox.Show("Expires in " + HMGLOBAL.gDaysLeft + " days", "Expires", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sbStatusStrip.Items[6].Text = "Developed by UbGames.com";

            }

			if (System.Convert.ToBoolean(HMGLOBAL.gFileok))
			{
				cmdNewGame_Click(cmdNewGame, new System.EventArgs());
			}
			else
			{
				SetCategoryFlagTrue(HMGLOBAL.NFile);
				ClearAllItems();
			}
			
		}
		
		private void frmMain_Closed(System.Object eventSender, System.EventArgs eventArgs)
		{
			//close all sub forms
		}
		
		private void cmdNewGame_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//start new game
			if (System.Convert.ToBoolean(HMGLOBAL.gFileok))
			{
				if (System.Convert.ToBoolean(mflag))
				{
					HMGLOBAL.NFile = mtmp;
					InitNewGame();
				}
				else
				{
                    //Start New Game?
                    var dialogResult = MessageBox.Show("Start New Game?", "Caption", MessageBoxButtons.YesNoCancel);
                    
                    //ans will return as IDYES = 6 or IDNO = 7
                    if (dialogResult == DialogResult.Yes)
					{
						HMGLOBAL.NFile = mtmp;
						SetCategoryMenuItems(mtmp);
						InitNewGame();

                    }
					else
					{
						mtmp = HMGLOBAL.NFile;
						SetCategoryMenuItems(mtmp);
					}
				}
			}
			else
			{
				MessageBox.Show("Please select new category!");
			}
			
		}
        private void HideEncryptDecryptTextBox(bool flag)
        {
            if (flag == true)
            {
                Encrypt.Visible = false;
                Decrypt.Visible = false;

                txtNormalValue.Visible = false;
                lblEncryptedValue.Visible = false;
                txtEncryptedValue.Visible = false;
                lblDecryptedValue.Visible = false;

                lblNormal.Visible = false;
                lblEncrypt.Visible = false;
                lblEncrypted.Visible = false;
                lblDecrypt.Visible = false;

            }
            else
            {
                Encrypt.Visible = true;
                Decrypt.Visible = true;

                txtNormalValue.Visible = true;
                lblEncryptedValue.Visible = true;
                txtEncryptedValue.Visible = true;
                lblDecryptedValue.Visible = true;

                lblNormal.Visible = true;
                lblEncrypt.Visible = true;
                lblEncrypted.Visible = true;
                lblDecrypt.Visible = true;

            }

        }		
		private void DrawShape(int xShape, bool flag)
		{
			//draw the line
			//start at location (x,y) as (162,134)
			int NumX1;
			int NumY1;
			NumX1 = 162;
			NumY1 = 134;
			
			switch (xShape)
			{
				case 0:
					//head
					//draws an ellipse located at (x,y) for the width and height
					x1 = 137; //162-25=137         '110
					y1 = 149; //134+12=146         '120
					w1 = 50;
					h1 = 50;
					if (flag)
					{
						gfxobj.DrawEllipse(Pens.Black, x1, y1, w1, h1);
					}
					else
					{
						gfxobj.DrawEllipse(Pens.Green, x1, y1, w1, h1);
					}
					break;
				case 1:
					//body
					//draws a line form (x1,y1) to (x2,y2)
					x1 = 162; //137+25=162     '135
					y1 = 199; //149+50=199     '170
					x2 = 162; //137+25=162    '135
					y2 = 240; //240+50=290    '240
					if (flag)
					{
						gfxobj.DrawLine(Pens.Black, x1, y1, x2, y2);
					}
					else
					{
						gfxobj.DrawLine(Pens.Green, x1, y1, x2, y2);
					}
					break;
				case 2:
					//left arm
					//draws a line form (x1,y1) to (x2,y2)
					x1 = 125; //100
					y1 = 185;
					x2 = 162; //135
					y2 = 220;
					if (flag)
					{
						gfxobj.DrawLine(Pens.Black, x1, y1, x2, y2);
					}
					else
					{
						gfxobj.DrawLine(Pens.Green, x1, y1, x2, y2);
					}
					break;
				case 3:
					//right arm
					//draws a line form (x1,y1) to (x2,y2)
					x1 = 195; //170
					y1 = 185;
					x2 = 162; //135
					y2 = 220;
					if (flag)
					{
						gfxobj.DrawLine(Pens.Black, x1, y1, x2, y2);
					}
					else
					{
						gfxobj.DrawLine(Pens.Green, x1, y1, x2, y2);
					}
					break;
				case 4:
					//left leg
					//draws a line form (x1,y1) to (x2,y2)
					x1 = 162; //160
					y1 = 240;
					x2 = 125; //100
					y2 = 280;
					if (flag)
					{
						gfxobj.DrawLine(Pens.Black, x1, y1, x2, y2);
					}
					else
					{
						gfxobj.DrawLine(Pens.Green, x1, y1, x2, y2);
					}
					break;
				case 5:
					//right leg
					//draws a line form (x1,y1) to (x2,y2)
					x1 = 162; //160
					y1 = 240;
					x2 = 195; //170
					y2 = 280;
					if (flag)
					{
						gfxobj.DrawLine(Pens.Black, x1, y1, x2, y2);
					}
					else
					{
						gfxobj.DrawLine(Pens.Green, x1, y1, x2, y2);
					}
					break;
			}
			
		}
		
		public void InitNewGame()
		{
			//initialize new game, get new word from data file
			
			gameover = false;
			ClearlblArray();
			ClearHangMan();
        			
			HMGLOBAL.FindCategoryFile(HMGLOBAL.NFile, ref tfile);
            //MessageBox.Show("HMGLOBAL.gFileok= " + HMGLOBAL.gFileok, "HMGLOBAL.gFileok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            DisplayCategoryFile();
			mflag = 0;
			EnableCmdLetters();
			lblStatus.Text = "";
			lblWordIs.Visible = false;
			//find maximum words in file

			HMGLOBAL.FindMaxWords(ref HMGLOBAL.MAXWORDS, tfile);
            //MessageBox.Show("MAXWORDS= " + HMGLOBAL.MAXWORDS, "MAXWORDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Random sortRandom = new Random();
            HMGLOBAL.gNum = (short) (HMGLOBAL.GetRandom(HMGLOBAL.MAXWORDS));

            //MessageBox.Show("Random Number gNum= " + HMGLOBAL.gNum, "gNum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            HMGLOBAL.GetWordFromFile(HMGLOBAL.gNum, ref HMGLOBAL.gWord, tfile);
            lblShowWord.Text = HMGLOBAL.gWord;

            //MessageBox.Show("Get Word gWord= " + HMGLOBAL.gWord, "gWord", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			LoadWord(HMGLOBAL.gWord);
            
            //load array of used letters
			LoadlblLetter();
			lblMaxChars.Visible = true;
			lblMaxChars.Text = "Guess the " + HMGLOBAL.gWord.Length + " letter word.";

            //MessageBox.Show("Get Word gWord= " + HMGLOBAL.gWord, "gWord", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			//used for testing, to display the filename
            //lblfilename.Visible = true;
            //lblfilename.Text = tfile;
            //lblmaxwords.Visible = true;
            //lblmaxwords.Text = Convert.ToString(HMGLOBAL.MAXWORDS);
		}
		
		public void LoadlblLetter()
		{
			short I;
			string NewChar;
			
			for (I = 0; I <= HMGLOBAL.MAXARRAY; I++)
			{
				NewChar = HMGLOBAL.WInfo[I].Letter;
				LoadlblLetter(I, NewChar);
				LoadlblAlpha(I, NewChar);
				HidelblAlpha();
			}
			
		}
		
		public void LoadlblLetter(short Index, string AlphaLetter)
		{
			//load lblletter labels with letter
			switch (Index)
			{
				case 0:
					lblLetter0.Text = AlphaLetter;
					
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter0.Visible = true;
						lblWLine0.Visible = false;
					}
					else
					{
						lblLetter0.Visible = false;
						lblWLine0.Visible = true;
					}
					break;
				case 1:
					lblLetter1.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter1.Visible = true;
						lblWLine1.Visible = false;
					}
					else
					{
						lblLetter1.Visible = false;
						lblWLine1.Visible = true;
					}
					break;
				case 2:
					lblLetter2.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter2.Visible = true;
						lblWLine2.Visible = false;
					}
					else
					{
						lblLetter2.Visible = false;
						lblWLine2.Visible = true;
					}
					break;
				case 3:
					lblLetter3.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter3.Visible = true;
						lblWLine3.Visible = false;
					}
					else
					{
						lblLetter3.Visible = false;
						lblWLine3.Visible = true;
					}
					break;
				case 4:
					lblLetter4.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter4.Visible = true;
						lblWLine4.Visible = false;
					}
					else
					{
						lblLetter4.Visible = false;
						lblWLine4.Visible = true;
					}
					break;
				case 5:
					lblLetter5.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter5.Visible = true;
						lblWLine5.Visible = false;
					}
					else
					{
						lblLetter5.Visible = false;
						lblWLine5.Visible = true;
					}
					break;
				case 6:
					lblLetter6.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter6.Visible = true;
						lblWLine6.Visible = false;
					}
					else
					{
						lblLetter6.Visible = false;
						lblWLine6.Visible = true;
					}
					break;
				case 7:
					lblLetter7.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter7.Visible = true;
						lblWLine7.Visible = false;
					}
					else
					{
						lblLetter7.Visible = false;
						lblWLine7.Visible = true;
					}
					break;
				case 8:
					lblLetter8.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter8.Visible = true;
						lblWLine8.Visible = false;
					}
					else
					{
						lblLetter8.Visible = false;
						lblWLine8.Visible = true;
					}
					break;
				case 9:
					lblLetter9.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter9.Visible = true;
						lblWLine9.Visible = false;
					}
					else
					{
						lblLetter9.Visible = false;
						lblWLine9.Visible = true;
					}
					break;
				case 10:
					lblLetter10.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter10.Visible = true;
						lblWLine10.Visible = false;
					}
					else
					{
						lblLetter10.Visible = false;
						lblWLine10.Visible = true;
					}
					break;
				case 11:
					lblLetter11.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter11.Visible = true;
						lblWLine11.Visible = false;
					}
					else
					{
						lblLetter11.Visible = false;
						lblWLine11.Visible = true;
					}
					break;
				case 12:
					lblLetter12.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter12.Visible = true;
						lblWLine12.Visible = false;
					}
					else
					{
						lblLetter12.Visible = false;
						lblWLine12.Visible = true;
					}
					break;
				case 13:
					lblLetter13.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter13.Visible = true;
						lblWLine13.Visible = false;
					}
					else
					{
						lblLetter13.Visible = false;
						lblWLine13.Visible = true;
					}
					break;
				case 14:
					lblLetter14.Text = AlphaLetter;
					if ((String.Compare(AlphaLetter, "A") < 0) || (String.Compare(AlphaLetter, "Z") > 0) )
					{
						lblLetter14.Visible = true;
						lblWLine14.Visible = false;
					}
					else
					{
						lblLetter14.Visible = false;
						lblWLine14.Visible = true;
					}
					break;
			}
		}
		
		public void LoadlblAlpha(short Index, string AlphaLetter)
		{
			//load lblAlpha labels with letter
			switch (Index)
			{
				case 0:
					lblAlpha0.Text = AlphaLetter;
					break;
				case 1:
					lblAlpha1.Text = AlphaLetter;
					break;
				case 2:
					lblAlpha2.Text = AlphaLetter;
					break;
				case 3:
					lblAlpha3.Text = AlphaLetter;
					break;
				case 4:
					lblAlpha4.Text = AlphaLetter;
					break;
				case 5:
					lblAlpha5.Text = AlphaLetter;
					break;
				case 6:
					lblAlpha6.Text = AlphaLetter;
					break;
				case 7:
					lblAlpha7.Text = AlphaLetter;
					break;
				case 8:
					lblAlpha8.Text = AlphaLetter;
					break;
				case 9:
					lblAlpha9.Text = AlphaLetter;
					break;
				case 10:
					lblAlpha10.Text = AlphaLetter;
					break;
				case 11:
					lblAlpha11.Text = AlphaLetter;
					break;
				case 12:
					lblAlpha12.Text = AlphaLetter;
					break;
				case 13:
					lblAlpha13.Text = AlphaLetter;
					break;
				case 14:
					lblAlpha14.Text = AlphaLetter;
					break;
			}
		}
		
		public void LoadWord(string gWord)
		{
			
			short I;
			string chr_X;
			short TmpNum;
			
			//need to clear array
			for (I = 1; I <= HMGLOBAL.MAXHOLD; I++)
			{
				HMGLOBAL.WInfo[I].Letter = "";
				HMGLOBAL.WInfo[I].Used = 0;
				HMGLOBAL.LInfo[I].Letter = "";
				HMGLOBAL.LInfo[I].Used = 0;
			}
            TmpNum = Convert.ToInt16(gWord.Length);

            //MessageBox.Show("TmpNum= " + TmpNum + "gWord= " + gWord, "TmpNum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            for (I = 1; I <= TmpNum; I++)
			{
				chr_X = gWord.Substring(I - 1, 1);
                //MessageBox.Show("chr_X= " + chr_X.ToUpper() + "gWord= " + gWord, "chr_X", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

				HMGLOBAL.WInfo[I - 1].Letter = chr_X.ToUpper();
				HMGLOBAL.WInfo[I - 1].Used = 0;
				HMGLOBAL.LInfo[I - 1].Letter = chr_X.ToUpper();
				HMGLOBAL.LInfo[I - 1].Used = 0;
			}
			
			//used for testing
			MaxNum = 0;
			//clear hangman array
			for (I = 0; I <= 9; I++)
			{
                HMGLOBAL.MInfo[I].flag = 0;
                
			}
			
            HMGLOBAL.Wnum = Convert.ToInt16(TmpNum - 1);

            //used for testing, show how hangman is displayed
            //if ShowAllHangMan is true display hangman when new games is clicked
            if (HMGLOBAL.ShowAllHangMan == true)
            {
                ShowHangMan();
            }
            else
            {
                ClearHangMan();
            }

		}
		
		public void CheckWordForValidLetter(string AlphaLetter, ref short flag)
		{
			//check new word to see if AlphaLetter exists
			short I;
			
			flag = 0;
			for (I = 0; I <= HMGLOBAL.Wnum; I++)
			{
				
				switch (I)
				{
					case 0:
						if (lblLetter0.Text == AlphaLetter)
						{
							lblLetter0.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 1:
						if (lblLetter1.Text == AlphaLetter)
						{
							lblLetter1.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 2:
						if (lblLetter2.Text == AlphaLetter)
						{
							lblLetter2.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 3:
						if (lblLetter3.Text == AlphaLetter)
						{
							lblLetter3.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 4:
						if (lblLetter4.Text == AlphaLetter)
						{
							lblLetter4.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 5:
						if (lblLetter5.Text == AlphaLetter)
						{
							lblLetter5.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 6:
						if (lblLetter6.Text == AlphaLetter)
						{
							lblLetter6.Visible = true;
							flag = 1;
						}
						break;
					case 7:
						if (lblLetter7.Text == AlphaLetter)
						{
							lblLetter7.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 8:
						if (lblLetter8.Text == AlphaLetter)
						{
							lblLetter8.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 9:
						if (lblLetter9.Text == AlphaLetter)
						{
							lblLetter9.Visible = true;
							flag = 1;
                            
						}
						break;
					case 10:
						if (lblLetter10.Text == AlphaLetter)
						{
							lblLetter10.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 11:
						if (lblLetter11.Text == AlphaLetter)
						{
							lblLetter11.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 12:
						if (lblLetter12.Text == AlphaLetter)
						{
							lblLetter12.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 13:
						if (lblLetter13.Text == AlphaLetter)
						{
							lblLetter13.Visible = true;
                            flag = 1;
                            
						}
						break;
					case 14:
						if (lblLetter14.Text == AlphaLetter)
						{
							lblLetter14.Visible = true;
                            flag = 1;
                            
						}
						break;
				}
				
			}
			
		}
		
		public void HangMan(ref short done)
		{
			//check to see what part of man to show man structure - which part to show in list MInfo of MANINFO.flag
			//1=Head 2=Body 3=Larm 4=Rarm 5=Lleg 6=Rleg
			//following items added for beginner level
			//7=Lhand 8=Rhand 9=Lfoot 10=Rfoot
			short I;
			bool found;
			
            found = false; 
            I = 0;

            while ((I <= 9) && !found)
			{
				if (HMGLOBAL.MInfo[I].flag == 0)
				{
					//show this part of man and set to true
					HMGLOBAL.MInfo[I].flag = 1;
                    found = true;
                    done = 0;

                    MaxNum++;
					switch (I)
					{
						case 0:
							DrawShape(0, true);
							break;
						case 1:
							DrawShape(1, true);
							break;
						case 2:
							DrawShape(2, true);
							break;
						case 3:
							DrawShape(3, true);
							break;
						case 4:
							DrawShape(4, true);
							break;
						case 5:
							DrawShape(5, true);
							break;
						case 6:
							this.Lhand.Visible = true;
							break;
						case 7:
							this.Rhand.Visible = true;
							break;
						case 8:
							this.Lfoot.Visible = true;
							break;
						case 9:
							this.Rfoot.Visible = true;
							break;
					}
					break;
				}
				I++;
			}
			if (HMGLOBAL.gLevel == 0)
			{
				//beginner mode, 0 thru 9, array of 10
                //mode of player, true for advanced, beginner shows hands and feet
				if (MaxNum >= 10)
				{
					done = 1;
				}
			}
			else
			{
				//advanced mode, 0 thru 5, array of 6
                //mode of player, true for advanced, advance will not show hands and feet
				if (MaxNum >= 6)
				{
					done = 1;
				}
			}
			
		}
		
		public void WasWordGuessed(ref short tmpflag)
		{
			//search word array to see if word was guessed
			short I;
			
			I = 0;
			while (I <= HMGLOBAL.Wnum)
			{
				
				switch (I)
				{
					case 0:
						if (lblLetter0.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 1:
						if (lblLetter1.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 2:
						if (lblLetter2.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 3:
						if (lblLetter3.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 4:
						if (lblLetter4.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 5:
						if (lblLetter5.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 6:
						if (lblLetter6.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 7:
						if (lblLetter7.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 8:
						if (lblLetter8.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 9:
						if (lblLetter9.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 10:
						if (lblLetter10.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 11:
						if (lblLetter11.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 12:
						if (lblLetter12.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 13:
						if (lblLetter13.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
					case 14:
						if (lblLetter14.Visible == false)
						{
							tmpflag = 0;
						}
                        break;
				}
				
				I++;
			}			
		}
		
		public void ShowWord()
		{
			//display word to user
			ShowlblAlpha();
		}
		
		public void ShowlblAlpha()
		{
			//clear lblAlpha labels
			lblAlpha0.Visible = true;
			lblAlpha1.Visible = true;
			lblAlpha2.Visible = true;
			lblAlpha3.Visible = true;
			lblAlpha4.Visible = true;
			lblAlpha5.Visible = true;
			lblAlpha6.Visible = true;
			lblAlpha7.Visible = true;
			lblAlpha8.Visible = true;
			lblAlpha9.Visible = true;
			lblAlpha10.Visible = true;
			lblAlpha11.Visible = true;
			lblAlpha12.Visible = true;
			lblAlpha13.Visible = true;
			lblAlpha14.Visible = true;
		}
		
		public void HidelblAlpha()
		{
			//clear lblAlpha labels
			lblAlpha0.Visible = false;
			lblAlpha1.Visible = false;
			lblAlpha2.Visible = false;
			lblAlpha3.Visible = false;
			lblAlpha4.Visible = false;
			lblAlpha5.Visible = false;
			lblAlpha6.Visible = false;
			lblAlpha7.Visible = false;
			lblAlpha8.Visible = false;
			lblAlpha9.Visible = false;
			lblAlpha10.Visible = false;
			lblAlpha11.Visible = false;
			lblAlpha12.Visible = false;
			lblAlpha13.Visible = false;
			lblAlpha14.Visible = false;
		}
		
		public void DisableCmdLetter(short Index)
		{
			//disable button that was selected
			switch (Index)
			{
				case 0:
					this.cmdLetter0.Enabled = false;
					break;
				case 1:
					this.cmdLetter1.Enabled = false;
					break;
				case 2:
					this.cmdLetter2.Enabled = false;
					break;
				case 3:
					this.cmdLetter3.Enabled = false;
					break;
				case 4:
					this.cmdLetter4.Enabled = false;
					break;
				case 5:
					this.cmdLetter5.Enabled = false;
					break;
				case 6:
					this.cmdLetter6.Enabled = false;
					break;
				case 7:
					this.cmdLetter7.Enabled = false;
					break;
				case 8:
					this.cmdLetter8.Enabled = false;
					break;
				case 9:
					this.cmdLetter9.Enabled = false;
					break;
				case 10:
					this.cmdLetter10.Enabled = false;
					break;
				case 11:
					this.cmdLetter11.Enabled = false;
					break;
				case 12:
					this.cmdLetter12.Enabled = false;
					break;
				case 13:
					this.cmdLetter13.Enabled = false;
					break;
				case 14:
					this.cmdLetter14.Enabled = false;
					break;
				case 15:
					this.cmdLetter15.Enabled = false;
					break;
				case 16:
					this.cmdLetter16.Enabled = false;
					break;
				case 17:
					this.cmdLetter17.Enabled = false;
					break;
				case 18:
					this.cmdLetter18.Enabled = false;
					break;
				case 19:
					this.cmdLetter19.Enabled = false;
					break;
				case 20:
					this.cmdLetter20.Enabled = false;
					break;
				case 21:
					this.cmdLetter21.Enabled = false;
					break;
				case 22:
					this.cmdLetter22.Enabled = false;
					break;
				case 23:
					this.cmdLetter23.Enabled = false;
					break;
				case 24:
					this.cmdLetter24.Enabled = false;
					break;
				case 25:
					this.cmdLetter25.Enabled = false;
					break;
			}
		}
		
		public void EnableCmdLetters()
		{
			
			this.cmdLetter0.Enabled = true;
			this.cmdLetter1.Enabled = true;
			this.cmdLetter2.Enabled = true;
			this.cmdLetter3.Enabled = true;
			this.cmdLetter4.Enabled = true;
			this.cmdLetter5.Enabled = true;
			this.cmdLetter6.Enabled = true;
			this.cmdLetter7.Enabled = true;
			this.cmdLetter8.Enabled = true;
			this.cmdLetter9.Enabled = true;
			this.cmdLetter10.Enabled = true;
			this.cmdLetter11.Enabled = true;
			this.cmdLetter12.Enabled = true;
			this.cmdLetter13.Enabled = true;
			this.cmdLetter14.Enabled = true;
			this.cmdLetter15.Enabled = true;
			this.cmdLetter16.Enabled = true;
			this.cmdLetter17.Enabled = true;
			this.cmdLetter18.Enabled = true;
			this.cmdLetter19.Enabled = true;
			this.cmdLetter20.Enabled = true;
			this.cmdLetter21.Enabled = true;
			this.cmdLetter22.Enabled = true;
			this.cmdLetter23.Enabled = true;
			this.cmdLetter24.Enabled = true;
			this.cmdLetter25.Enabled = true;
			
		}
		
		public void ClearlblArray()
		{
			short I;
			
			//need to turn off underlines Line(X)
			for (I = 0; I <= HMGLOBAL.MAXARRAY; I++)
			{
				
				switch (I)
				{
					case 0:
						lblLetter0.Text = "";
						lblLetter0.Visible = false;
						lblWLine0.Visible = false;
						lblAlpha0.Text = "";
						lblAlpha0.Visible = false;
						break;
					case 1:
						lblLetter1.Text = "";
						lblLetter1.Visible = false;
						lblWLine1.Visible = false;
						lblAlpha1.Text = "";
						lblAlpha1.Visible = false;
						break;
					case 2:
						lblLetter2.Text = "";
						lblLetter2.Visible = false;
						lblWLine2.Visible = false;
						lblAlpha2.Text = "";
						lblAlpha2.Visible = false;
						break;
					case 3:
						lblLetter3.Text = "";
						lblLetter3.Visible = false;
						lblWLine3.Visible = false;
						lblAlpha3.Text = "";
						lblAlpha3.Visible = false;
						break;
					case 4:
						lblLetter4.Text = "";
						lblLetter4.Visible = false;
						lblWLine4.Visible = false;
						lblAlpha4.Text = "";
						lblAlpha4.Visible = false;
						break;
					case 5:
						lblLetter5.Text = "";
						lblLetter5.Visible = false;
						lblWLine5.Visible = false;
						lblAlpha5.Text = "";
						lblAlpha5.Visible = false;
						break;
					case 6:
						lblLetter6.Text = "";
						lblLetter6.Visible = false;
						lblWLine6.Visible = false;
						lblAlpha6.Text = "";
						lblAlpha6.Visible = false;
						break;
					case 7:
						lblLetter7.Text = "";
						lblLetter7.Visible = false;
						lblWLine7.Visible = false;
						lblAlpha7.Text = "";
						lblAlpha7.Visible = false;
						break;
					case 8:
						lblLetter8.Text = "";
						lblLetter8.Visible = false;
						lblWLine8.Visible = false;
						lblAlpha8.Text = "";
						lblAlpha8.Visible = false;
						break;
					case 9:
						lblLetter9.Text = "";
						lblLetter9.Visible = false;
						lblWLine9.Visible = false;
						lblAlpha9.Text = "";
						lblAlpha9.Visible = false;
						break;
					case 10:
						lblLetter10.Text = "";
						lblLetter10.Visible = false;
						lblWLine10.Visible = false;
						lblAlpha10.Text = "";
						lblAlpha10.Visible = false;
						break;
					case 11:
						lblLetter11.Text = "";
						lblLetter11.Visible = false;
						lblWLine11.Visible = false;
						lblAlpha11.Text = "";
						lblAlpha11.Visible = false;
						break;
					case 12:
						lblLetter12.Text = "";
						lblLetter12.Visible = false;
						lblWLine12.Visible = false;
						lblAlpha12.Text = "";
						lblAlpha12.Visible = false;
						break;
					case 13:
						lblLetter13.Text = "";
						lblLetter13.Visible = false;
						lblWLine13.Visible = false;
						lblAlpha13.Text = "";
						lblAlpha13.Visible = false;
						break;
					case 14:
						lblLetter14.Text = "";
						lblLetter14.Visible = false;
						lblWLine14.Visible = false;
						lblAlpha14.Text = "";
						lblAlpha14.Visible = false;
						break;
				}
				
			}
			
		}
		
		public void ClearHangMan()
		{
			//clear hangman
			
			DrawShape(0, false);
			DrawShape(1, false);
			DrawShape(2, false);
			DrawShape(3, false);
			DrawShape(4, false);
			DrawShape(5, false);
			this.Lhand.Visible = false;
			this.Rhand.Visible = false;
			this.Lfoot.Visible = false;
			this.Rfoot.Visible = false;
			
		}

        public void ShowHangMan()
        {
            //clear hangman

            DrawShape(0, true);
            DrawShape(1, true);
            DrawShape(2, true);
            DrawShape(3, true);
            DrawShape(4, true);
            DrawShape(5, true);
            this.Lhand.Visible = true;
            this.Rhand.Visible = true;
            this.Lfoot.Visible = true;
            this.Rfoot.Visible = true;

        }

		public void DisableCmdLetters()
		{
			//disable cmdletters
			
			this.cmdLetter0.Enabled = false;
			this.cmdLetter1.Enabled = false;
			this.cmdLetter2.Enabled = false;
			this.cmdLetter3.Enabled = false;
			this.cmdLetter4.Enabled = false;
			this.cmdLetter5.Enabled = false;
			this.cmdLetter6.Enabled = false;
			this.cmdLetter7.Enabled = false;
			this.cmdLetter8.Enabled = false;
			this.cmdLetter9.Enabled = false;
			this.cmdLetter10.Enabled = false;
			this.cmdLetter11.Enabled = false;
			this.cmdLetter12.Enabled = false;
			this.cmdLetter13.Enabled = false;
			this.cmdLetter14.Enabled = false;
			this.cmdLetter15.Enabled = false;
			this.cmdLetter16.Enabled = false;
			this.cmdLetter17.Enabled = false;
			this.cmdLetter18.Enabled = false;
			this.cmdLetter19.Enabled = false;
			this.cmdLetter20.Enabled = false;
			this.cmdLetter21.Enabled = false;
			this.cmdLetter22.Enabled = false;
			this.cmdLetter23.Enabled = false;
			this.cmdLetter24.Enabled = false;
			this.cmdLetter25.Enabled = false;
			
		}
		
		public void DisplayCategoryFile()
		{
			//display category name
			switch (HMGLOBAL.NFile)
			{
				case 1:
                    sbStatusStrip.Items[1].Text = "Category is Animals";
					break;
				case 2:
                    sbStatusStrip.Items[1].Text = "Category is Food";
					break;
				case 3:
                    sbStatusStrip.Items[1].Text = "Category is Holidays";
					break;
				case 4:
                    sbStatusStrip.Items[1].Text = "Category is Home";
					break;
				case 5:
                    sbStatusStrip.Items[1].Text = "Category is Leisure";
					break;
				case 6:
                    sbStatusStrip.Items[1].Text = "Category is Seasons";
					break;
				case 7:
                    sbStatusStrip.Items[1].Text = "Category is Sports";
					break;
				case 8:
                    sbStatusStrip.Items[1].Text = "Category is Weather";
					break;
				case 9:
                    sbStatusStrip.Items[1].Text = "Category is Misc";
					break;
				default:
					MessageBox.Show("Value not found");
					break;
			}
		}
		
		public void SetCategoryMenuItems(short NFile)
		{
			//check menu items
			
			mnuAnimals.Checked = false;
			mnuFood.Checked = false;
			mnuHolidays.Checked = false;
			mnuHome.Checked = false;
			mnuLeisure.Checked = false;
			mnuSeasons.Checked = false;
			mnuSports.Checked = false;
			mnuWeather.Checked = false;
			mnuMisc.Checked = false;
			
			switch (NFile)
			{
				case 1:
					mnuAnimals.Checked = true;
					break;
				case 2:
					mnuFood.Checked = true;
					break;
				case 3:
					mnuHolidays.Checked = true;
					break;
				case 4:
					mnuHome.Checked = true;
					break;
				case 5:
					mnuLeisure.Checked = true;
					break;
				case 6:
					mnuSeasons.Checked = true;
					break;
				case 7:
					mnuSports.Checked = true;
					break;
				case 8:
					mnuWeather.Checked = true;
					break;
				case 9:
					mnuMisc.Checked = true;
					break;
				default:
					MessageBox.Show("Value not found");
					break;
			}
		}
		
		public void SetSoundMenuItems(short gSound)
		{
			//set sound menu item to on or off
			
			mnuSoundOn.Checked = false;
			mnuSoundOff.Checked = false;
			if (gSound == 1)
			{
				mnuSoundOn.Checked = true;
			}
			else
			{
				mnuSoundOff.Checked = true;
			}
			
		}
		
		public void ClearAllItems()
		{
			//error found, clear all items
			mflag = 1;
			lblWordIs.Visible = false;
			ClearlblArray();
			ClearHangMan();
            
            lblStatus.Text = "";
			lblWordIs.Visible = false;
			DisableCmdLetters();
			//MsgBox "Error in file!"
            sbStatusStrip.Items[1].Text = "File not found!";

		}
		
		public void SelectNewCategory(ref short mtmp)
		{
			//select new category for words
			
			HMGLOBAL.FindCategoryFile(mtmp, ref tfile);
			HMGLOBAL.gFileok = 1;
            HMGLOBAL.DataFileExist(tfile, ref HMGLOBAL.gFileok, ref newfieldsNum);
            
			if (System.Convert.ToBoolean(HMGLOBAL.gFileok))
			{
				if (HMGLOBAL.NFile != mtmp)
				{
					//NFile = mtmp
					cmdNewGame_Click(cmdNewGame, new System.EventArgs());
				}
			}
			else
			{
				HMGLOBAL.gFileok = 1;
				//set category flag to true
				SetCategoryFlagTrue(mtmp);
				mtmp = moldtmp;
                MessageBox.Show("File is missing or corrupted!", "Select New Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		
		public void SetCategoryFlagTrue(short mtmp)
		{
			//set flag to true if category file not found
			switch (mtmp)
			{
				case 1:
					CatFlag1 = true;
					break;
				case 2:
					CatFlag2 = true;
					break;
				case 3:
					CatFlag3 = true;
					break;
				case 4:
					CatFlag4 = true;
					break;
				case 5:
					CatFlag5 = true;
					break;
				case 6:
					CatFlag6 = true;
					break;
				case 7:
					CatFlag7 = true;
					break;
				case 8:
					CatFlag8 = true;
					break;
				case 9:
					CatFlag9 = true;
					break;
				default:
					MessageBox.Show("Value not found");
					break;
			}
		}
		
		public void SetCategoryFlagsFalse()
		{
			//initialize category flags to false
			CatFlag1 = false;
			CatFlag2 = false;
			CatFlag3 = false;
			CatFlag4 = false;
			CatFlag5 = false;
			CatFlag6 = false;
			CatFlag7 = false;
			CatFlag8 = false;
			CatFlag9 = false;
		}
		
		public void mnuAdvanced_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuAdvanced_Click(eventSender, eventArgs);
		}
		
		public void mnuAdvanced_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select advanced mode
			if (HMGLOBAL.gLevel == 0)
			{
				//player wants to change level, need to start new game
				if (System.Convert.ToBoolean(mflag))
				{
					//end of game reached, start new game
					//update status bar text for level
                    sbStatusStrip.Items[0].Text = "Level: Advanced";
					//gLevel is true for advanced player
					HMGLOBAL.gLevel = 1;
					mnuBeginner.Checked = false;
					mnuAdvanced.Checked = true;
					InitNewGame();
				}
				else
				{
                    //Start New Game?
                    var dialogResult = MessageBox.Show("Start New Game?", "Caption", MessageBoxButtons.YesNoCancel);

					//ans will return as IDYES = 6 or IDNO = 7
                    if (dialogResult == DialogResult.Yes)
                    {
						//update status bar text for level
                        sbStatusStrip.Items[0].Text = "Level: Advanced";
						//gLevel is true for advanced player
						HMGLOBAL.gLevel = 1;
						mnuBeginner.Checked = false;
						mnuAdvanced.Checked = true;
						InitNewGame();
					}
				}
			}
		}
		
		public void mnuBeginner_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuBeginner_Click(eventSender, eventArgs);
		}
		
		public void mnuBeginner_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select beginner mode
			if (HMGLOBAL.gLevel == 1)
			{
				//player wants to change level, need to start new game
				if (System.Convert.ToBoolean(mflag))
				{
					//end of game reached, start new game
					//update status bar text for level
                    sbStatusStrip.Items[0].Text = "Level: Beginner";
					//gLevel is true for advanced player
					HMGLOBAL.gLevel = 0;
					mnuBeginner.Checked = true;
					mnuAdvanced.Checked = false;
					InitNewGame();
				}
				else
				{
                    //Start New Game?
                    var dialogResult = MessageBox.Show("Start New Game?", "Caption", MessageBoxButtons.YesNoCancel);

					//ans will return as IDYES = 6 or IDNO = 7
                    if (dialogResult == DialogResult.Yes)
                    {
						//update status bar text for level
                        sbStatusStrip.Items[0].Text = "Level: Beginner";
                        //gLevel is true for advanced player
						HMGLOBAL.gLevel = 0;
						mnuBeginner.Checked = true;
						mnuAdvanced.Checked = false;
						InitNewGame();
					}
				}
			}
		}
		
		public void mnuHelpAbout_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuHelpAbout_Click(eventSender, eventArgs);
		}
		
		public void mnuHelpAbout_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			frmAbout.Default.ShowDialog();
		}
		
		public void mnuHelpPrint_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuHelpPrint_Click(eventSender, eventArgs);
		}
		
		public void mnuHelpPrint_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//open the windows notepad application to print order form
            bool tFlag = false;
            string tmpdir;

            //Declare string constant to hold file name
            const string filename = "order.txt";

            tmpdir = Application.StartupPath;
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(tmpdir);
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles(filename);

            //tmpdir folder where file is located, filename name of file, tFlag if file was found
            HMGLOBAL.FileExists(tmpdir, filename, ref tFlag);

            if (tFlag == false)
            {
                MessageBox.Show("File is missing or corrupted!", "Order.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
            else
            {
                //this process works to open notepad.exe and order.txt
                Process process = new Process();
                // Configure the process using the StartInfo properties.
                process.StartInfo.FileName = "notepad.exe";
                //process.StartInfo.Arguments = folder and file name to open
                process.StartInfo.Arguments = tmpdir + "\\" + filename;
                //process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process.Start();
                process.WaitForExit();// Waits here for the process to exit.
            }
            return;
		}
		
		public void mnuHelpRules_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuHelpRules_Click(eventSender, eventArgs);
		}
		
		public void mnuHelpRules_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//show rules to play
			frmRules.Default.ShowDialog();
		}
		
		private void mnuHint_Click()
		{
			//give the player a hint
			MessageBox.Show("Sorry no Hint!");
		}
		
		public void mnuNewGame_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuNewGame_Click(eventSender, eventArgs);
		}
		
		public void mnuNewGame_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//start new game
			cmdNewGame_Click(cmdNewGame, new System.EventArgs());
		}
		
		public void mnuSoundOff_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuSoundOff_Click(eventSender, eventArgs);
		}
		
		public void mnuSoundOff_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//turn off sound
			HMGLOBAL.gSound = 0;
			SetSoundMenuItems(HMGLOBAL.gSound);
		}
		
		public void mnuSoundOn_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuSoundOn_Click(eventSender, eventArgs);
		}
		
		public void mnuSoundOn_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//turn on sound
			HMGLOBAL.gSound = 1;
			SetSoundMenuItems(HMGLOBAL.gSound);
		}
		
		public void mnuFileExit_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuFileExit_Click(eventSender, eventArgs);
		}
		
		public void mnuFileExit_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			cmdExit_Click(cmdExit, new System.EventArgs());
		}
		
		private void mnuFileNew_Click()
		{
			cmdNewGame_Click(cmdNewGame, new System.EventArgs());
		}
		
		public void mnuFood_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuFood_Click(eventSender, eventArgs);
		}
		
		public void mnuFood_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select words from food.txt
			moldtmp = HMGLOBAL.NFile;
			//only search for file if flag is set to true
			if (! CatFlag2)
			{
				mtmp = 2;
				SelectNewCategory(ref mtmp);
			}
			else
			{
                MessageBox.Show("File is missing or corrupted!", "food", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void mnuHolidays_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuHolidays_Click(eventSender, eventArgs);
		}
		
		public void mnuHolidays_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select words from holidays.txt
			moldtmp = HMGLOBAL.NFile;
			//only search for file if flag is set to true
			if (! CatFlag3)
			{
				mtmp = 3;
				SelectNewCategory(ref mtmp);
			}
			else
			{
                MessageBox.Show("File is missing or corrupted!", "holidays", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		
		public void mnuHome_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuHome_Click(eventSender, eventArgs);
		}
		
		public void mnuHome_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select words from home.txt
			moldtmp = HMGLOBAL.NFile;
			//only search for file if flag is set to true
			if (! CatFlag4)
			{
				mtmp = 4;
				SelectNewCategory(ref mtmp);
			}
			else
			{
                MessageBox.Show("File is missing or corrupted!", "home", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void mnuLeisure_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuLeisure_Click(eventSender, eventArgs);
		}
		
		public void mnuLeisure_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select words from leisure.txt
			moldtmp = HMGLOBAL.NFile;
			//only search for file if flag is set to true
			if (! CatFlag5)
			{
				mtmp = 5;
				SelectNewCategory(ref mtmp);
			}
			else
			{
                MessageBox.Show("File is missing or corrupted!", "leisure", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void mnuSeasons_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuSeasons_Click(eventSender, eventArgs);
		}
		
		public void mnuSeasons_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select words from seasons.txt
			moldtmp = HMGLOBAL.NFile;
			//only search for file if flag is set to true
			if (! CatFlag6)
			{
				mtmp = 6;
				SelectNewCategory(ref mtmp);
			}
			else
			{
                MessageBox.Show("File is missing or corrupted!", "seasons", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void mnuSports_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuSports_Click(eventSender, eventArgs);
		}
		
		public void mnuSports_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select words from sports.txt
			moldtmp = HMGLOBAL.NFile;
			//only search for file if flag is set to true
			if (! CatFlag7)
			{
				mtmp = 7;
				SelectNewCategory(ref mtmp);
			}
			else
			{
                MessageBox.Show("File is missing or corrupted!", "sports", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void mnuWeather_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuWeather_Click(eventSender, eventArgs);
		}
		
		public void mnuWeather_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select words from weather.txt
			moldtmp = HMGLOBAL.NFile;
			//only search for file if flag is set to true
			if (! CatFlag8)
			{
				mtmp = 8;
				SelectNewCategory(ref mtmp);
			}
			else
			{
                MessageBox.Show("File is missing or corrupted!", "weather", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		
		public void mnuMisc_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuMisc_Click(eventSender, eventArgs);
		}
		
		public void mnuMisc_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select words from misc.txt
			moldtmp = HMGLOBAL.NFile;
			//only search for file if flag is set to true
			if (! CatFlag9)
			{
				mtmp = 9;
				SelectNewCategory(ref mtmp);
			}
			else
			{
                MessageBox.Show("File is missing or corrupted!", "misc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		
		public void mnuAnimals_Popup(System.Object eventSender, System.EventArgs eventArgs)
		{
			mnuAnimals_Click(eventSender, eventArgs);
		}
		
		public void mnuAnimals_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//select words from animals.txt
			moldtmp = HMGLOBAL.NFile;
			//only search for file if flag is set to true
			if (! CatFlag1)
			{
				mtmp = 1;
				SelectNewCategory(ref mtmp);
			}
			else
			{
                MessageBox.Show("File is missing or corrupted!", "animals", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void UpDateStatusBar(short Games, short Hangs)
		{
			//update status bar text for MaxGames and MaxHangs
            sbStatusStrip.Items[3].Text = Convert.ToString(Games);
            sbStatusStrip.Items[5].Text = Convert.ToString(Hangs);
		}
		
		private void cmdExit_Click(System.Object eventSender, System.EventArgs eventArgs)
		{

            var dialogResult = MessageBox.Show("Exit Game?", "Caption", MessageBoxButtons.YesNoCancel);

			//ans will return as IDYES = 6 or IDNO = 7
            if (dialogResult == DialogResult.Yes)
            {
				//unload the form
                if (HMGLOBAL.gShowNagScreenFlag == true)
                {
                    ini.ShowNagScreen();
                }

				ini.PutIniFileSettings(HMGLOBAL.NFile, HMGLOBAL.gSound);
				//this.Close();
                System.Environment.Exit(0);
			}
			
		}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mnuAnimals_Click(mnuAnimals, new System.EventArgs());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            mnuFood_Click(mnuFood, new System.EventArgs());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            mnuHolidays_Click(mnuHolidays, new System.EventArgs());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            mnuHome_Click(mnuHome, new System.EventArgs());
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            mnuLeisure_Click(mnuLeisure, new System.EventArgs());
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            mnuSeasons_Click(mnuSeasons, new System.EventArgs());
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            mnuSports_Click(mnuSports, new System.EventArgs());
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            mnuWeather_Click(mnuWeather, new System.EventArgs());
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            mnuMisc_Click(mnuMisc, new System.EventArgs());
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            //added for testing encryption of dates
            lblEncryptedValue.Text = ini.EncryptString(txtNormalValue.Text, ini.EKey);
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            //added for testing decryption of dates
            lblDecryptedValue.Text = ini.DecryptString(txtEncryptedValue.Text, ini.EKey);
        }

        private void btnShowWord_Click(object sender, EventArgs e)
        {
            //used for testing to display word
            lblShowWord.Visible = true;
        }

        private void btnHideWord_Click(object sender, EventArgs e)
        {
            //used for testing to hide word
            lblShowWord.Visible = false;
        }
		
	}//end of from
}//end of namespace
