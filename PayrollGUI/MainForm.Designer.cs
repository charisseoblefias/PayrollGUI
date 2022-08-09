/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/11/2021
 * Time: 9:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PayrollGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox NametextBox;
		private System.Windows.Forms.TextBox SocialSecurityNumbertextBox;
		private System.Windows.Forms.TextBox HourlyPayRatetextBox;
		private System.Windows.Forms.TextBox NumberOfHoursWorkedtextBox;
		private System.Windows.Forms.Button Calculatebutton;
		private System.Windows.Forms.Button Clearbutton;
		private System.Windows.Forms.Button Exitbutton;
		private System.Windows.Forms.TextBox GrossPaytextBox;
		private System.Windows.Forms.TextBox FederalTaxtextBox;
		private System.Windows.Forms.TextBox StateTaxtextBox;
		private System.Windows.Forms.TextBox NetPaytextBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.NametextBox = new System.Windows.Forms.TextBox();
			this.SocialSecurityNumbertextBox = new System.Windows.Forms.TextBox();
			this.HourlyPayRatetextBox = new System.Windows.Forms.TextBox();
			this.NumberOfHoursWorkedtextBox = new System.Windows.Forms.TextBox();
			this.Calculatebutton = new System.Windows.Forms.Button();
			this.Clearbutton = new System.Windows.Forms.Button();
			this.Exitbutton = new System.Windows.Forms.Button();
			this.GrossPaytextBox = new System.Windows.Forms.TextBox();
			this.FederalTaxtextBox = new System.Windows.Forms.TextBox();
			this.StateTaxtextBox = new System.Windows.Forms.TextBox();
			this.NetPaytextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(138, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Payroll";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(24, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name :";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(24, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Social Security Number :";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(24, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hourly Pay Rate :";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(24, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(183, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Number of Hours Worked :";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(24, 233);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Gross Pay :";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(24, 267);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(183, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Federal Withholding Tax :";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(24, 300);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(170, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "State Withholding Tax :";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label9.Location = new System.Drawing.Point(24, 332);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 8;
			this.label9.Text = "Net Pay :";
			// 
			// NametextBox
			// 
			this.NametextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.NametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NametextBox.Location = new System.Drawing.Point(203, 76);
			this.NametextBox.Name = "NametextBox";
			this.NametextBox.Size = new System.Drawing.Size(205, 24);
			this.NametextBox.TabIndex = 9;
			// 
			// SocialSecurityNumbertextBox
			// 
			this.SocialSecurityNumbertextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.SocialSecurityNumbertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SocialSecurityNumbertextBox.Location = new System.Drawing.Point(203, 104);
			this.SocialSecurityNumbertextBox.Name = "SocialSecurityNumbertextBox";
			this.SocialSecurityNumbertextBox.Size = new System.Drawing.Size(205, 24);
			this.SocialSecurityNumbertextBox.TabIndex = 10;
			// 
			// HourlyPayRatetextBox
			// 
			this.HourlyPayRatetextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.HourlyPayRatetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HourlyPayRatetextBox.Location = new System.Drawing.Point(203, 133);
			this.HourlyPayRatetextBox.Name = "HourlyPayRatetextBox";
			this.HourlyPayRatetextBox.Size = new System.Drawing.Size(100, 24);
			this.HourlyPayRatetextBox.TabIndex = 11;
			// 
			// NumberOfHoursWorkedtextBox
			// 
			this.NumberOfHoursWorkedtextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.NumberOfHoursWorkedtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumberOfHoursWorkedtextBox.Location = new System.Drawing.Point(203, 162);
			this.NumberOfHoursWorkedtextBox.Name = "NumberOfHoursWorkedtextBox";
			this.NumberOfHoursWorkedtextBox.Size = new System.Drawing.Size(100, 24);
			this.NumberOfHoursWorkedtextBox.TabIndex = 12;
			// 
			// Calculatebutton
			// 
			this.Calculatebutton.BackColor = System.Drawing.SystemColors.GrayText;
			this.Calculatebutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Calculatebutton.Location = new System.Drawing.Point(39, 396);
			this.Calculatebutton.Name = "Calculatebutton";
			this.Calculatebutton.Size = new System.Drawing.Size(102, 42);
			this.Calculatebutton.TabIndex = 13;
			this.Calculatebutton.Text = "Calculate";
			this.Calculatebutton.UseVisualStyleBackColor = false;
			this.Calculatebutton.Click += new System.EventHandler(this.CalculatebuttonClick);
			// 
			// Clearbutton
			// 
			this.Clearbutton.BackColor = System.Drawing.SystemColors.GrayText;
			this.Clearbutton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Clearbutton.Location = new System.Drawing.Point(203, 396);
			this.Clearbutton.Name = "Clearbutton";
			this.Clearbutton.Size = new System.Drawing.Size(91, 42);
			this.Clearbutton.TabIndex = 14;
			this.Clearbutton.Text = "Clear";
			this.Clearbutton.UseVisualStyleBackColor = false;
			this.Clearbutton.Click += new System.EventHandler(this.ClearbuttonClick);
			// 
			// Exitbutton
			// 
			this.Exitbutton.BackColor = System.Drawing.SystemColors.GrayText;
			this.Exitbutton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Exitbutton.Location = new System.Drawing.Point(344, 396);
			this.Exitbutton.Name = "Exitbutton";
			this.Exitbutton.Size = new System.Drawing.Size(82, 42);
			this.Exitbutton.TabIndex = 15;
			this.Exitbutton.Text = "Exit";
			this.Exitbutton.UseVisualStyleBackColor = false;
			this.Exitbutton.Click += new System.EventHandler(this.ExitbuttonClick);
			// 
			// GrossPaytextBox
			// 
			this.GrossPaytextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.GrossPaytextBox.Enabled = false;
			this.GrossPaytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GrossPaytextBox.Location = new System.Drawing.Point(203, 233);
			this.GrossPaytextBox.Name = "GrossPaytextBox";
			this.GrossPaytextBox.Size = new System.Drawing.Size(100, 24);
			this.GrossPaytextBox.TabIndex = 16;
			// 
			// FederalTaxtextBox
			// 
			this.FederalTaxtextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.FederalTaxtextBox.Enabled = false;
			this.FederalTaxtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FederalTaxtextBox.Location = new System.Drawing.Point(203, 267);
			this.FederalTaxtextBox.Name = "FederalTaxtextBox";
			this.FederalTaxtextBox.Size = new System.Drawing.Size(100, 24);
			this.FederalTaxtextBox.TabIndex = 17;
			// 
			// StateTaxtextBox
			// 
			this.StateTaxtextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.StateTaxtextBox.Enabled = false;
			this.StateTaxtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StateTaxtextBox.Location = new System.Drawing.Point(203, 300);
			this.StateTaxtextBox.Name = "StateTaxtextBox";
			this.StateTaxtextBox.Size = new System.Drawing.Size(100, 24);
			this.StateTaxtextBox.TabIndex = 18;
			// 
			// NetPaytextBox
			// 
			this.NetPaytextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.NetPaytextBox.Enabled = false;
			this.NetPaytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NetPaytextBox.Location = new System.Drawing.Point(203, 332);
			this.NetPaytextBox.Name = "NetPaytextBox";
			this.NetPaytextBox.Size = new System.Drawing.Size(100, 24);
			this.NetPaytextBox.TabIndex = 19;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(470, 493);
			this.Controls.Add(this.NetPaytextBox);
			this.Controls.Add(this.StateTaxtextBox);
			this.Controls.Add(this.FederalTaxtextBox);
			this.Controls.Add(this.GrossPaytextBox);
			this.Controls.Add(this.Exitbutton);
			this.Controls.Add(this.Clearbutton);
			this.Controls.Add(this.Calculatebutton);
			this.Controls.Add(this.NumberOfHoursWorkedtextBox);
			this.Controls.Add(this.HourlyPayRatetextBox);
			this.Controls.Add(this.SocialSecurityNumbertextBox);
			this.Controls.Add(this.NametextBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "PayrollGUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
