/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/11/2021
 * Time: 9:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollGUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CalculatebuttonClick(object sender, EventArgs e)
		{
			double HourlyPayRate = Convert.ToDouble(HourlyPayRatetextBox.Text);
			double NumbersOfHoursWorked = Convert.ToDouble(NumberOfHoursWorkedtextBox.Text);
			
			double GrossPay = HourlyPayRate * NumbersOfHoursWorked;
			double FederalTax = GrossPay * 0.15;
			double StateTax = GrossPay * 0.05;
			double NetPay = GrossPay - (FederalTax + StateTax);
			
			GrossPaytextBox.Text=GrossPay.ToString("c");
			FederalTaxtextBox.Text=FederalTax.ToString("c");
			StateTaxtextBox.Text=StateTax.ToString("c");
			NetPaytextBox.Text=NetPay.ToString("c");
		}
		void ClearbuttonClick(object sender, EventArgs e)
		{
			NametextBox.Clear();
			SocialSecurityNumbertextBox.Clear();
			HourlyPayRatetextBox.Clear();
			NumberOfHoursWorkedtextBox.Clear();
			GrossPaytextBox.Clear();
			FederalTaxtextBox.Clear();
			StateTaxtextBox.Clear();
			NetPaytextBox.Clear();
		}
		void ExitbuttonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
