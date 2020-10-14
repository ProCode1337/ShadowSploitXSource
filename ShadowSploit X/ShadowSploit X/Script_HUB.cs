using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeAreDevs_API;

// Token: 0x02000011 RID: 17
public partial class Script_HUB : Form
{
	// Token: 0x0600004C RID: 76 RVA: 0x000047A8 File Offset: 0x000029A8
	public Script_HUB()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600004D RID: 77 RVA: 0x000047D4 File Offset: 0x000029D4
	private void button1_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000047E8 File Offset: 0x000029E8
	private void button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x000047FC File Offset: 0x000029FC
	private void button11_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox26.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox26.Text);
		}
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002C10 File Offset: 0x00000E10
	private void Script_HUB_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00004840 File Offset: 0x00002A40
	private void button3_Click(object sender, EventArgs e)
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			MessageBox.Show("Password of this GUI is Cracked");
			Class10.smethod_0(this.richTextBox27.Text);
		}
		else
		{
			MessageBox.Show("Password of this GUI is Cracked");
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox27.Text);
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00004898 File Offset: 0x00002A98
	private void button4_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			MessageBox.Show("Infinity Yield FE might be not stable");
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox28.Text);
		}
		else
		{
			MessageBox.Show("Infinity Yield FE might be not stable");
			Class10.smethod_0(this.richTextBox28.Text);
		}
	}

	// Token: 0x06000053 RID: 83 RVA: 0x000048F0 File Offset: 0x00002AF0
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0400003D RID: 61
	private ExploitAPI exploitAPI_0 = new ExploitAPI();

	// Token: 0x0400003E RID: 62
	private IContainer icontainer_0 = null;
}
