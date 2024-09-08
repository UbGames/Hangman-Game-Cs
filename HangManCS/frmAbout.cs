//*********************************************************
//Developed by UbGames, visit us at https://www.ubgames.com
//*********************************************************
using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Data;

namespace HangMan
{
	internal class frmAbout : System.Windows.Forms.Form
	{
		
		#region Default Instance
		
		private static frmAbout defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmAbout Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmAbout();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
		#endregion
		
		#region Windows Form Designer generated code
		public frmAbout()
		{
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
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
		public System.Windows.Forms.PictureBox Picture1;
		public System.Windows.Forms.Button cmdOK;
		public System.Windows.Forms.Label _Line1_5;
		public System.Windows.Forms.Label _Line1_4;
		public System.Windows.Forms.Label _Line1_3;
		public System.Windows.Forms.Label _Line1_2;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label _Line1_1;
		public System.Windows.Forms.Label lblDescription;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label _Line1_0;
		public System.Windows.Forms.Label lblVersion;
		internal System.Windows.Forms.Label lblExpires;
		public System.Windows.Forms.Label lblDisclaimer;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this._Line1_5 = new System.Windows.Forms.Label();
            this._Line1_4 = new System.Windows.Forms.Label();
            this._Line1_3 = new System.Windows.Forms.Label();
            this._Line1_2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this._Line1_1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this._Line1_0 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.lblExpires = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture1
            // 
            this.Picture1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Picture1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Picture1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Picture1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Picture1.Image = ((System.Drawing.Image)(resources.GetObject("Picture1.Image")));
            this.Picture1.Location = new System.Drawing.Point(72, 13);
            this.Picture1.Name = "Picture1";
            this.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Picture1.Size = new System.Drawing.Size(32, 32);
            this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Picture1.TabIndex = 10;
            this.Picture1.TabStop = false;
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this.cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdOK.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdOK.Location = new System.Drawing.Point(192, 295);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(78, 23);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // _Line1_5
            // 
            this._Line1_5.BackColor = System.Drawing.Color.White;
            this._Line1_5.Location = new System.Drawing.Point(65, 55);
            this._Line1_5.Name = "_Line1_5";
            this._Line1_5.Size = new System.Drawing.Size(325, 1);
            this._Line1_5.TabIndex = 11;
            // 
            // _Line1_4
            // 
            this._Line1_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._Line1_4.Location = new System.Drawing.Point(65, 54);
            this._Line1_4.Name = "_Line1_4";
            this._Line1_4.Size = new System.Drawing.Size(325, 1);
            this._Line1_4.TabIndex = 12;
            // 
            // _Line1_3
            // 
            this._Line1_3.BackColor = System.Drawing.Color.White;
            this._Line1_3.Location = new System.Drawing.Point(65, 213);
            this._Line1_3.Name = "_Line1_3";
            this._Line1_3.Size = new System.Drawing.Size(325, 1);
            this._Line1_3.TabIndex = 13;
            // 
            // _Line1_2
            // 
            this._Line1_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._Line1_2.Location = new System.Drawing.Point(65, 212);
            this._Line1_2.Name = "_Line1_2";
            this._Line1_2.Size = new System.Drawing.Size(325, 1);
            this._Line1_2.TabIndex = 14;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(64, 99);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(326, 21);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Vist our website at https://www.ubgames.com";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 12F);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(64, 67);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(79, 18);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "UbGames";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(64, 171);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(344, 30);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "This registration fee is $9.95 U.S. Upon registration, a notice-free update will " +
    "be sent to you.";
            // 
            // _Line1_1
            // 
            this._Line1_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._Line1_1.Location = new System.Drawing.Point(65, 121);
            this._Line1_1.Name = "_Line1_1";
            this._Line1_1.Size = new System.Drawing.Size(325, 1);
            this._Line1_1.TabIndex = 15;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(64, 133);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(313, 35);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Please Note: This software is not free. The evaluation period for this software i" +
    "s 30 days.";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 22.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(104, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(166, 40);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Hang Man!";
            // 
            // _Line1_0
            // 
            this._Line1_0.BackColor = System.Drawing.Color.White;
            this._Line1_0.Location = new System.Drawing.Point(65, 121);
            this._Line1_0.Name = "_Line1_0";
            this._Line1_0.Size = new System.Drawing.Size(325, 1);
            this._Line1_0.TabIndex = 16;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVersion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblVersion.Location = new System.Drawing.Point(272, 57);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVersion.Size = new System.Drawing.Size(73, 16);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Version";
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.BackColor = System.Drawing.Color.Transparent;
            this.lblDisclaimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDisclaimer.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.ForeColor = System.Drawing.Color.Black;
            this.lblDisclaimer.Location = new System.Drawing.Point(64, 224);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDisclaimer.Size = new System.Drawing.Size(344, 64);
            this.lblDisclaimer.TabIndex = 2;
            this.lblDisclaimer.Text = resources.GetString("lblDisclaimer.Text");
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.Location = new System.Drawing.Point(65, 328);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(39, 14);
            this.lblExpires.TabIndex = 17;
            this.lblExpires.Text = "Label6";
            this.lblExpires.Visible = false;
            // 
            // frmAbout
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cmdOK;
            this.ClientSize = new System.Drawing.Size(459, 411);
            this.Controls.Add(this.lblExpires);
            this.Controls.Add(this.Picture1);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this._Line1_5);
            this.Controls.Add(this._Line1_4);
            this.Controls.Add(this._Line1_3);
            this.Controls.Add(this._Line1_2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._Line1_1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this._Line1_0);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDisclaimer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(117, 123);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		
		private void cmdOK_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			this.Close();
		}
		
		private void frmAbout_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
			// Center the Form on the screen
			this.SetBounds((System.Windows.Forms.Screen.GetBounds(this).Width / 2) - (this.Width / 2), (System.Windows.Forms.Screen.GetBounds(this).Height / 2) - (this.Height / 2), this.Width, this.Height, System.Windows.Forms.BoundsSpecified.Location);
			
			//Me.Caption = "About " & App.Title
			lblVersion.Text = "Version " + System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileMajorPart + "." + System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileMinorPart + ".";
			//& App.Revision
			lblTitle.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
			
            if (HMGLOBAL.gExpireFlag == true)
			{
				lblExpires.Visible = true;
				lblExpires.Text = "Date installed: " + HMGLOBAL.gDateInstall + " expires in " + HMGLOBAL.gDaysLeft + " days.";
				//MsgBox("Expires in " & gDaysLeft & " days.")
			}
			
		}
	}
}
