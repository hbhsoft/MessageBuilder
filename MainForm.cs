/*
 * Created by SharpDevelop.
 * User: tphuy
 * Date: 4/8/2021
 * Time: 11:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DemoMessageBuilder
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
				textBox2.Text = HBHSOFT.MyMessageBuilderAPI.Encrypt(textBox1.Text);
			else
				textBox2.Text = HBHSOFT.MyMessageBuilderAPI.Decrypt(textBox1.Text);
		}
		void Button2Click(object sender, EventArgs e)
		{
			Clipboard.Clear();Clipboard.SetText(textBox2.Text);
		}
	}
}
