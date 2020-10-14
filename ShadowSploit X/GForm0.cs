using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using MetroSuite;
using ShadowSploit_X.Properties;

// Token: 0x02000010 RID: 16
public class GForm0 : MetroForm
{
	// Token: 0x06000041 RID: 65 RVA: 0x00003F10 File Offset: 0x00002110
	public GForm0()
	{
		this.method_0();
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00003F30 File Offset: 0x00002130
	private void GForm0_Load(object sender, EventArgs e)
	{
		base.TopMost = true;
		this.textBox_0.UseSystemPasswordChar = true;
		this.textBox_0.Text = Settings.Default.Key;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00003F68 File Offset: 0x00002168
	private void button_0_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002C10 File Offset: 0x00000E10
	private void label_0_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00003F7C File Offset: 0x0000217C
	private void button_1_Click(object sender, EventArgs e)
	{
		Process.Start("https://direct-link.net/32327/ShadowSploitXKey");
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00003F94 File Offset: 0x00002194
	public static string smethod_0(string string_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		return Convert.ToBase64String(bytes);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00003FB8 File Offset: 0x000021B8
	public static string smethod_1(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00003FDC File Offset: 0x000021DC
	private void button_2_Click(object sender, EventArgs e)
	{
		WebClient webClient = new WebClient();
		if (string.IsNullOrEmpty(this.textBox_0.Text))
		{
			MessageBox.Show("Please enter a Key!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		string str = webClient.DownloadString("https://icanhazip.com");
		string string_ = webClient.DownloadString("http://emperex.xyz/key/Checka.php?key=" + this.textBox_0.Text + "&eyepee=" + str);
		if (GForm0.smethod_1(string_) == "Dumbass Dexy fixed this")
		{
			MessageBox.Show("Login successful", "Works!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			webClient.Dispose();
			MessageBox.Show("Welcome to ShadowSploit");
			Process.Start("https://discord.gg/gQYBH5D");
			base.Hide();
			new GForm1().ShowDialog();
			base.Close();
		}
		else
		{
			MessageBox.Show("Login failed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			webClient.Dispose();
		}
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000040B8 File Offset: 0x000022B8
	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		if (this.checkBox_0.Checked)
		{
			this.textBox_0.UseSystemPasswordChar = false;
		}
		if (!this.checkBox_0.Checked)
		{
			this.textBox_0.UseSystemPasswordChar = true;
		}
	}

	// Token: 0x0600004A RID: 74 RVA: 0x000040FC File Offset: 0x000022FC
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000412C File Offset: 0x0000232C
	private void method_0()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		this.button_0 = new Button();
		this.label_0 = new Label();
		this.label_1 = new Label();
		this.textBox_0 = new TextBox();
		this.checkBox_0 = new CheckBox();
		this.button_1 = new Button();
		this.button_2 = new Button();
		base.SuspendLayout();
		this.button_0.BackColor = Color.FromArgb(40, 40, 40);
		this.button_0.FlatStyle = FlatStyle.Flat;
		this.button_0.ForeColor = Color.DarkViolet;
		this.button_0.Location = new Point(448, 4);
		this.button_0.Margin = new Padding(3, 4, 3, 4);
		this.button_0.Name = "button1";
		this.button_0.Size = new Size(26, 31);
		this.button_0.TabIndex = 6;
		this.button_0.Text = "X";
		this.button_0.UseVisualStyleBackColor = false;
		this.button_0.Click += this.button_0_Click;
		this.label_0.AutoSize = true;
		this.label_0.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label_0.Location = new Point(102, 67);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(303, 25);
		this.label_0.TabIndex = 7;
		this.label_0.Text = "Click Get Key button to get the Key";
		this.label_0.Click += this.label_0_Click;
		this.label_1.AutoSize = true;
		this.label_1.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label_1.Location = new Point(14, 116);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(46, 25);
		this.label_1.TabIndex = 8;
		this.label_1.Text = "Key:";
		this.textBox_0.BackColor = SystemColors.WindowFrame;
		this.textBox_0.BorderStyle = BorderStyle.None;
		this.textBox_0.ForeColor = Color.FromArgb(104, 33, 122);
		this.textBox_0.Location = new Point(62, 121);
		this.textBox_0.Margin = new Padding(3, 4, 3, 4);
		this.textBox_0.Name = "textBox1";
		this.textBox_0.Size = new Size(402, 20);
		this.textBox_0.TabIndex = 9;
		this.checkBox_0.AutoSize = true;
		this.checkBox_0.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.checkBox_0.Location = new Point(62, 151);
		this.checkBox_0.Margin = new Padding(3, 4, 3, 4);
		this.checkBox_0.Name = "checkBox1";
		this.checkBox_0.Size = new Size(147, 27);
		this.checkBox_0.TabIndex = 10;
		this.checkBox_0.Text = "Show/Hide Key";
		this.checkBox_0.UseVisualStyleBackColor = true;
		this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.FlatAppearance.BorderSize = 0;
		this.button_1.FlatStyle = FlatStyle.Flat;
		this.button_1.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.button_1.Location = new Point(51, 195);
		this.button_1.Margin = new Padding(3, 4, 3, 4);
		this.button_1.Name = "button7";
		this.button_1.Size = new Size(175, 51);
		this.button_1.TabIndex = 11;
		this.button_1.Text = "Get Key";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_2.FlatAppearance.BorderSize = 0;
		this.button_2.FlatStyle = FlatStyle.Flat;
		this.button_2.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.button_2.Location = new Point(251, 195);
		this.button_2.Margin = new Padding(3, 4, 3, 4);
		this.button_2.Name = "button2";
		this.button_2.Size = new Size(175, 51);
		this.button_2.TabIndex = 12;
		this.button_2.Text = "Login";
		this.button_2.UseVisualStyleBackColor = true;
		this.button_2.Click += this.button_2_Click;
		base.AccentColor = Color.FromArgb(104, 33, 122);
		base.AutoScaleDimensions = new SizeF(8f, 20f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(478, 261);
		base.Controls.Add(this.button_2);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.checkBox_0);
		base.Controls.Add(this.textBox_0);
		base.Controls.Add(this.label_1);
		base.Controls.Add(this.label_0);
		base.Controls.Add(this.button_0);
		this.ForeColor = SystemColors.ControlDark;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "Login";
		base.StartPosition = FormStartPosition.CenterScreen;
		base.State = 1;
		base.Style = 1;
		this.Text = "Login";
		base.TopMost = true;
		base.Load += this.GForm0_Load;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000035 RID: 53
	private IContainer icontainer_0 = null;

	// Token: 0x04000036 RID: 54
	private Button button_0;

	// Token: 0x04000037 RID: 55
	private Label label_0;

	// Token: 0x04000038 RID: 56
	private Label label_1;

	// Token: 0x04000039 RID: 57
	private TextBox textBox_0;

	// Token: 0x0400003A RID: 58
	private CheckBox checkBox_0;

	// Token: 0x0400003B RID: 59
	private Button button_1;

	// Token: 0x0400003C RID: 60
	private Button button_2;
}
