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
	internal class frmNotice : System.Windows.Forms.Form
	{
		
		#region Default Instance
		
		private static frmNotice defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmNotice Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmNotice();
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
		public frmNotice()
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
		public System.Windows.Forms.Button cmdOK;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label _Line1_1;
		public System.Windows.Forms.Label lblDescription;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label _Line1_0;
		public System.Windows.Forms.Label lblDisclaimer;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotice));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdOK = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this._Line1_1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this._Line1_0 = new System.Windows.Forms.Label();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this.cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdOK.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdOK.Location = new System.Drawing.Point(181, 299);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOK.Size = new System.Drawing.Size(78, 23);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(101, 269);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(233, 16);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "** ALL RIGHTS RESERVED **";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(69, 117);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(169, 14);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "To register, visit our website:";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 12F);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(69, 147);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(268, 33);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "https://www.ubgames.com";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(45, 64);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(337, 53);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "This registration fee is $9.95 U.S.  Upon registration, a notice-free update will" +
    " be sent to you.  Thank you for your interest.";
            // 
            // _Line1_1
            // 
            this._Line1_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._Line1_1.Location = new System.Drawing.Point(42, 189);
            this._Line1_1.Name = "_Line1_1";
            this._Line1_1.Size = new System.Drawing.Size(350, 1);
            this._Line1_1.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(35, 32);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(380, 33);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "This software is not free. The evaluation period for this software is 30 days.";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(141, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(137, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "** NOTICE **";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _Line1_0
            // 
            this._Line1_0.BackColor = System.Drawing.Color.White;
            this._Line1_0.Location = new System.Drawing.Point(42, 189);
            this._Line1_0.Name = "_Line1_0";
            this._Line1_0.Size = new System.Drawing.Size(350, 1);
            this._Line1_0.TabIndex = 12;
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.BackColor = System.Drawing.Color.Transparent;
            this.lblDisclaimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDisclaimer.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.ForeColor = System.Drawing.Color.Black;
            this.lblDisclaimer.Location = new System.Drawing.Point(45, 200);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDisclaimer.Size = new System.Drawing.Size(352, 62);
            this.lblDisclaimer.TabIndex = 2;
            this.lblDisclaimer.Text = resources.GetString("lblDisclaimer.Text");
            // 
            // frmNotice
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cmdOK;
            this.ClientSize = new System.Drawing.Size(459, 361);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._Line1_1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this._Line1_0);
            this.Controls.Add(this.lblDisclaimer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(149, 112);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNotice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Please Support Shareware!";
            this.Load += new System.EventHandler(this.frmNotice_Load);
            this.ResumeLayout(false);

		}
		#endregion
		
		private void cmdOK_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			this.Close();
		}
		
		private void frmNotice_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
			// Center the Form on the screen
			this.SetBounds((System.Windows.Forms.Screen.GetBounds(this).Width / 2) - (this.Width / 2), (System.Windows.Forms.Screen.GetBounds(this).Height / 2) - (this.Height / 2), this.Width, this.Height, System.Windows.Forms.BoundsSpecified.Location);
			
		}
	}
}
