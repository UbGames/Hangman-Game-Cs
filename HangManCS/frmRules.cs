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
	internal class frmRules : System.Windows.Forms.Form
	{
		
		#region Default Instance
		
		private static frmRules defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmRules Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmRules();
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
		public frmRules()
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
		internal System.Windows.Forms.RichTextBox RichTextBox1;
        public Button cmdOK;
		public System.Windows.Forms.ToolTip ToolTip1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRules));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox1.Location = new System.Drawing.Point(34, 26);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.Size = new System.Drawing.Size(399, 284);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "";
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this.cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdOK.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdOK.Location = new System.Drawing.Point(195, 338);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(78, 23);
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // frmRules
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(475, 389);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.RichTextBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(116, 117);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRules";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Playing the game";
            this.Load += new System.EventHandler(this.frmRules_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmRules_Paint);
            this.ResumeLayout(false);

		}
		#endregion
		
		private void frmRules_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
			
			// Center the Form on the screen
			this.SetBounds((System.Windows.Forms.Screen.GetBounds(this).Width / 2) - (this.Width / 2), (System.Windows.Forms.Screen.GetBounds(this).Height / 2) - (this.Height / 2), this.Width, this.Height, System.Windows.Forms.BoundsSpecified.Location);
			
		}
		
		private void frmRules_Paint(System.Object eventSender, System.Windows.Forms.PaintEventArgs eventArgs)
		{
			
			//position rule text
			int CurrentX;
			CurrentX = 0;
			int CurrentY;
			CurrentY = 0;
			
			//display text on form
			RichTextBox1.Text = "Hang Man is easy to play, but can you become an expert? You can select either Beginner or Advanced level of play." + Environment.NewLine + Environment.NewLine + "There are nine word categories:" + Environment.NewLine + Environment.NewLine + "Animals, Food, Holidays, Home, Leisure, Seasons, Sports, Weather, and Misc." + Environment.NewLine + Environment.NewLine + "The object of the game is to guess the word before you get hung." + Environment.NewLine + Environment.NewLine + "At the beginning of play you select the letter you want to guess. If your right the letter is displayed, but if you are wrong?" + Environment.NewLine + Environment.NewLine + "See if you can guess the word before your hung!" + Environment.NewLine + Environment.NewLine + "This is a game that interests people of all ages.";
			
		}

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}
