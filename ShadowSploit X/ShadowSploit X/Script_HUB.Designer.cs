// Token: 0x02000011 RID: 17
public partial class Script_HUB : global::System.Windows.Forms.Form
{
	// Token: 0x06000054 RID: 84 RVA: 0x00004920 File Offset: 0x00002B20
	private void InitializeComponent()
	{
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Script_HUB));
		this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.button2 = new global::System.Windows.Forms.Button();
		this.button1 = new global::System.Windows.Forms.Button();
		this.button11 = new global::System.Windows.Forms.Button();
		this.richTextBox26 = new global::System.Windows.Forms.RichTextBox();
		this.button3 = new global::System.Windows.Forms.Button();
		this.richTextBox27 = new global::System.Windows.Forms.RichTextBox();
		this.button4 = new global::System.Windows.Forms.Button();
		this.richTextBox28 = new global::System.Windows.Forms.RichTextBox();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.panel1.BackColor = global::System.Drawing.Color.Indigo;
		this.panel1.Controls.Add(this.button2);
		this.panel1.Controls.Add(this.button1);
		this.panel1.ForeColor = global::System.Drawing.Color.Purple;
		this.panel1.Location = new global::System.Drawing.Point(-8, -6);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(957, 49);
		this.panel1.TabIndex = 0;
		this.button2.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
		this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = global::System.Drawing.Color.Fuchsia;
		this.button2.Location = new global::System.Drawing.Point(826, 14);
		this.button2.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.button2.Name = "button2";
		this.button2.Size = new global::System.Drawing.Size(34, 31);
		this.button2.TabIndex = 8;
		this.button2.Text = "-";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new global::System.EventHandler(this.button2_Click);
		this.button1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.button1.ForeColor = global::System.Drawing.Color.Fuchsia;
		this.button1.Location = new global::System.Drawing.Point(876, 14);
		this.button1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(34, 31);
		this.button1.TabIndex = 7;
		this.button1.Text = "X";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.button11.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
		this.button11.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.button11.ForeColor = global::System.Drawing.Color.DarkViolet;
		this.button11.Location = new global::System.Drawing.Point(12, 50);
		this.button11.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.button11.Name = "button11";
		this.button11.Size = new global::System.Drawing.Size(191, 61);
		this.button11.TabIndex = 7;
		this.button11.Text = "Fencing GUI";
		this.button11.UseVisualStyleBackColor = false;
		this.button11.Click += new global::System.EventHandler(this.button11_Click);
		this.richTextBox26.Location = new global::System.Drawing.Point(81, 69);
		this.richTextBox26.Name = "richTextBox26";
		this.richTextBox26.Size = new global::System.Drawing.Size(59, 29);
		this.richTextBox26.TabIndex = 73;
		this.richTextBox26.Text = componentResourceManager.GetString("richTextBox26.Text");
		this.button3.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
		this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.button3.ForeColor = global::System.Drawing.Color.DarkViolet;
		this.button3.Location = new global::System.Drawing.Point(228, 50);
		this.button3.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.button3.Name = "button3";
		this.button3.Size = new global::System.Drawing.Size(191, 61);
		this.button3.TabIndex = 74;
		this.button3.Text = "Dungeon Quest GUI";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new global::System.EventHandler(this.button3_Click);
		this.richTextBox27.Location = new global::System.Drawing.Point(296, 69);
		this.richTextBox27.Name = "richTextBox27";
		this.richTextBox27.Size = new global::System.Drawing.Size(59, 29);
		this.richTextBox27.TabIndex = 75;
		this.richTextBox27.Text = componentResourceManager.GetString("richTextBox27.Text");
		this.button4.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
		this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.button4.ForeColor = global::System.Drawing.Color.DarkViolet;
		this.button4.Location = new global::System.Drawing.Point(443, 50);
		this.button4.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.button4.Name = "button4";
		this.button4.Size = new global::System.Drawing.Size(191, 61);
		this.button4.TabIndex = 76;
		this.button4.Text = "Infinity Yield FE";
		this.button4.UseVisualStyleBackColor = false;
		this.button4.Click += new global::System.EventHandler(this.button4_Click);
		this.richTextBox28.Location = new global::System.Drawing.Point(502, 69);
		this.richTextBox28.Name = "richTextBox28";
		this.richTextBox28.Size = new global::System.Drawing.Size(59, 29);
		this.richTextBox28.TabIndex = 77;
		this.richTextBox28.Text = componentResourceManager.GetString("richTextBox28.Text");
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(914, 518);
		base.ControlBox = false;
		base.Controls.Add(this.button4);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button11);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.richTextBox26);
		base.Controls.Add(this.richTextBox27);
		base.Controls.Add(this.richTextBox28);
		this.Cursor = global::System.Windows.Forms.Cursors.Default;
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Script_HUB";
		this.Text = "More Commands";
		base.TopMost = true;
		base.Load += new global::System.EventHandler(this.Script_HUB_Load);
		this.panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x0400003F RID: 63
	private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

	// Token: 0x04000040 RID: 64
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x04000041 RID: 65
	private global::System.Windows.Forms.Button button2;

	// Token: 0x04000042 RID: 66
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000043 RID: 67
	private global::System.Windows.Forms.Button button11;

	// Token: 0x04000044 RID: 68
	private global::System.Windows.Forms.RichTextBox richTextBox26;

	// Token: 0x04000045 RID: 69
	private global::System.Windows.Forms.Button button3;

	// Token: 0x04000046 RID: 70
	private global::System.Windows.Forms.RichTextBox richTextBox27;

	// Token: 0x04000047 RID: 71
	private global::System.Windows.Forms.Button button4;

	// Token: 0x04000048 RID: 72
	private global::System.Windows.Forms.RichTextBox richTextBox28;
}
