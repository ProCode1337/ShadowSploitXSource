using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using MetroSuite;
using Microsoft.Win32;
using VisualStudioTabControl;
using WeAreDevs_API;

// Token: 0x02000012 RID: 18
public class GForm1 : MetroForm
{
	// Token: 0x06000055 RID: 85 RVA: 0x00005078 File Offset: 0x00003278
	public GForm1()
	{
		this.method_11();
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000050BC File Offset: 0x000032BC
	private async void GForm1_Load(object sender, EventArgs e)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\SkisploitAuth", true);
		if (registryKey == null)
		{
			registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\SkisploitAuth");
			registryKey.SetValue("Auth", "");
		}
		registryKey.SetValue("Auth", "382fe18b3029c5d86349cd91d0b57410158afac49ba9d3935687d84edd0f97b7");
		this.checkBox_0.Checked = true;
		await Task.Delay(500);
		this.webBrowser_0 = this.webBrowser_1;
		try
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
			string name = AppDomain.CurrentDomain.FriendlyName;
			if (registryKey2.GetValue(name) == null)
			{
				registryKey2.SetValue(name, 11001, RegistryValueKind.DWord);
			}
			registryKey2 = null;
			name = null;
		}
		catch (Exception ex)
		{
		}
		this.webBrowser_0.Url = new Uri(string.Format("file:///{0}/bin/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
		this.webBrowser_1.Document.InvokeScript("SetTheme", new object[]
		{
			"Dark"
		});
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00005108 File Offset: 0x00003308
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			this.label_0.Text = "(Injected)";
		}
		else
		{
			this.label_0.Text = "(Not Injected)";
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_0(object sender, EventArgs e)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000047E8 File Offset: 0x000029E8
	private void button_1_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00003F68 File Offset: 0x00002168
	private void button_0_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00005144 File Offset: 0x00003344
	private void button_2_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Filter = "Text files (.txt)|*.txt"
		};
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string text = File.ReadAllText(openFileDialog.FileName);
			HtmlDocument document = this.webBrowser_1.Document;
			string scriptName = "SetText";
			object[] args = new string[]
			{
				text
			};
			document.InvokeScript(scriptName, args);
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0000519C File Offset: 0x0000339C
	private void button_5_Click(object sender, EventArgs e)
	{
		Class8.smethod_0();
		this.timer_0.Start();
		if (Class10.smethod_2(Class10.string_0))
		{
			Class10.smethod_0(this.richTextBox_0.Text);
			MessageBox.Show("ShadowSploit Injected!");
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_1(object sender, EventArgs e)
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000051E0 File Offset: 0x000033E0
	private void button_4_Click(object sender, EventArgs e)
	{
		HtmlDocument document = this.webBrowser_1.Document;
		string scriptName = "GetText";
		object[] args = new string[0];
		object arg = document.InvokeScript(scriptName, args);
		if (!Class10.smethod_2(Class10.string_0))
		{
			MessageBox.Show("Inject " + Class8.string_0 + " before using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			Class10.smethod_0("spawn (function()\r\n" + arg + "\r\nend)");
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_2(object sender, EventArgs e)
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00005254 File Offset: 0x00003454
	private void button_3_Click(object sender, EventArgs e)
	{
		HtmlDocument document = this.webBrowser_1.Document;
		string scriptName = "SetText";
		object[] args = new string[]
		{
			""
		};
		document.InvokeScript(scriptName, args);
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00005288 File Offset: 0x00003488
	private void button_6_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_1.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_1.Text);
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000052CC File Offset: 0x000034CC
	private void button_8_Click(object sender, EventArgs e)
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			Class10.smethod_0(this.richTextBox_2.Text);
		}
		else
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_2.Text);
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00005310 File Offset: 0x00003510
	private void button_9_Click(object sender, EventArgs e)
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			Class10.smethod_0(this.richTextBox_3.Text);
		}
		else
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_3.Text);
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00005354 File Offset: 0x00003554
	private void button_10_Click(object sender, EventArgs e)
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			Class10.smethod_0(this.richTextBox_4.Text);
		}
		else
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_4.Text);
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00005398 File Offset: 0x00003598
	private void button_11_Click(object sender, EventArgs e)
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			Class10.smethod_0(this.richTextBox_5.Text);
		}
		else
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_5.Text);
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x000053DC File Offset: 0x000035DC
	private void button_12_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_6.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_6.Text);
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00005420 File Offset: 0x00003620
	private void button_13_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_7.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_7.Text);
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00005464 File Offset: 0x00003664
	private void button_14_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_8.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_8.Text);
		}
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000054A8 File Offset: 0x000036A8
	private void button_15_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_9.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_9.Text);
		}
	}

	// Token: 0x0600006A RID: 106 RVA: 0x000054EC File Offset: 0x000036EC
	private void button_16_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_10.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_10.Text);
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00005530 File Offset: 0x00003730
	private void button_17_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_11.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_11.Text);
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00005574 File Offset: 0x00003774
	private void button_18_Click(object sender, EventArgs e)
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			Class10.smethod_0(this.richTextBox_12.Text);
		}
		else
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_12.Text);
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x000055B8 File Offset: 0x000037B8
	private void button_19_Click(object sender, EventArgs e)
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			Class10.smethod_0(this.richTextBox_13.Text);
		}
		else
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_13.Text);
		}
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000055FC File Offset: 0x000037FC
	private void button_20_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_14.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_14.Text);
		}
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00005640 File Offset: 0x00003840
	private void button_21_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_15.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_15.Text);
		}
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00005684 File Offset: 0x00003884
	private void button_22_Click(object sender, EventArgs e)
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			Class10.smethod_0(this.richTextBox_16.Text);
		}
		else
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_16.Text);
		}
	}

	// Token: 0x06000071 RID: 113 RVA: 0x000056C8 File Offset: 0x000038C8
	private void button_23_Click(object sender, EventArgs e)
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			Class10.smethod_0(this.richTextBox_17.Text);
		}
		else
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_17.Text);
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x0000570C File Offset: 0x0000390C
	private void button_24_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_18.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_18.Text);
		}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00005750 File Offset: 0x00003950
	private void button_25_Click(object sender, EventArgs e)
	{
		if (!Class10.smethod_2(Class10.string_0))
		{
			this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_19.Text);
		}
		else
		{
			Class10.smethod_0(this.richTextBox_19.Text);
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00005794 File Offset: 0x00003994
	private void button_26_Click(object sender, EventArgs e)
	{
		Script_HUB script_HUB = new Script_HUB();
		script_HUB.Show();
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000057B0 File Offset: 0x000039B0
	private void button_32_Click(object sender, EventArgs e)
	{
		this.exploitAPI_0.LaunchExploit();
		this.label_0.Text = "(Injected)";
		this.timer_1.Start();
		Thread.Sleep(3000);
		this.exploitAPI_0.SendLimitedLuaScript(this.richTextBox_20.Text);
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00005804 File Offset: 0x00003A04
	private void button_31_Click(object sender, EventArgs e)
	{
		this.exploitAPI_0.IsUpdated();
		MessageBox.Show("API Updated!");
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00005828 File Offset: 0x00003A28
	private void button_30_Click(object sender, EventArgs e)
	{
		this.exploitAPI_0.SendLimitedLuaScript(this.fastColoredTextBox_0.Text);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0000584C File Offset: 0x00003A4C
	private void button_28_Click(object sender, EventArgs e)
	{
		if (Class8.openFileDialog_0.ShowDialog() == DialogResult.OK)
		{
			try
			{
				this.fastColoredTextBox_0.Text = File.ReadAllText(Class8.openFileDialog_0.FileName);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
			}
		}
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000058B0 File Offset: 0x00003AB0
	private void button_29_Click(object sender, EventArgs e)
	{
		this.fastColoredTextBox_0.Clear();
	}

	// Token: 0x0600007A RID: 122 RVA: 0x000058C8 File Offset: 0x00003AC8
	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.youtube.com/channel/UCxXusD80tho_kxmKY6NHreA");
	}

	// Token: 0x0600007B RID: 123 RVA: 0x000058E0 File Offset: 0x00003AE0
	private void pictureBox_3_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Discord him ILoveBirds#4566");
	}

	// Token: 0x0600007C RID: 124 RVA: 0x000058F8 File Offset: 0x00003AF8
	private void pictureBox_2_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.youtube.com/channel/UCpzcAeI3Foan4wGJ5Ljkk2A");
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00005910 File Offset: 0x00003B10
	private void pictureBox_1_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Discord Him Mexual#5038");
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00005928 File Offset: 0x00003B28
	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		if (this.checkBox_0.Checked)
		{
			base.TopMost = true;
		}
		if (!this.checkBox_0.Checked)
		{
			base.TopMost = false;
		}
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00005960 File Offset: 0x00003B60
	private void button_7_Click(object sender, EventArgs e)
	{
		foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
		{
			process.Kill();
		}
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00005990 File Offset: 0x00003B90
	private void button_33_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Credits go to Shadow 1160, Immortal Donkey, ILoveBirds#4566, ThunderMods and TNE");
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_3(object sender, EventArgs e)
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_4(object sender, EventArgs e)
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_5(object sender, EventArgs e)
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_6(object sender, EventArgs e)
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_7(object sender, EventArgs e)
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_8(object sender, EventArgs e)
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_9(object sender, EventArgs e)
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002C10 File Offset: 0x00000E10
	private void method_10(object sender, EventArgs e)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000059A8 File Offset: 0x00003BA8
	private void button_34_Click(object sender, EventArgs e)
	{
		Process.Start("https://aka.ms/vs/15/release/vc_redist.x86.exe");
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000059C0 File Offset: 0x00003BC0
	private void button_35_Click(object sender, EventArgs e)
	{
		Process.Start("https://aka.ms/vs/15/release/vc_redist.x64.exe");
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000059D8 File Offset: 0x00003BD8
	private void button_36_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Follow all the instruction to fix the problem!");
		Process.Start("https://shadowsploit1160.weebly.com/fix-exploit-crash-problem.html");
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002C10 File Offset: 0x00000E10
	private void tabPage_2_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000059FC File Offset: 0x00003BFC
	private void button_37_Click(object sender, EventArgs e)
	{
		Process.Start("https://clk.ink/Shadow1160ScriptPack100Plus");
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002C10 File Offset: 0x00000E10
	private void webBrowser_1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002C10 File Offset: 0x00000E10
	private void label_0_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00005A14 File Offset: 0x00003C14
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.method_12("RobloxPlayerBeta");
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00005A2C File Offset: 0x00003C2C
	private void metroButton_0_Click(object sender, EventArgs e)
	{
		Process.Start("ShadowC++.exe");
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00005A44 File Offset: 0x00003C44
	private void metroButton_1_Click(object sender, EventArgs e)
	{
		MessageBox.Show("idk why, its not work so just close the CS:GO hack manually");
		foreach (Process process in Process.GetProcessesByName("ShadowC++.exe"))
		{
			process.Kill();
		}
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00005A80 File Offset: 0x00003C80
	private void GForm1_FormClosing(object sender, FormClosingEventArgs e)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\SkisploitAuth", true);
		if (registryKey == null)
		{
			registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\SkisploitAuth");
			registryKey.SetValue("Auth", "");
		}
		registryKey.SetValue("Auth", "false");
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00005AD4 File Offset: 0x00003CD4
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00005B04 File Offset: 0x00003D04
	private void method_11()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm1));
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.visualStudioTabControl_0 = new VisualStudioTabControl();
		this.tabPage_0 = new TabPage();
		this.button_2 = new Button();
		this.button_3 = new Button();
		this.button_4 = new Button();
		this.button_5 = new Button();
		this.webBrowser_1 = new WebBrowser();
		this.richTextBox_0 = new RichTextBox();
		this.tabPage_3 = new TabPage();
		this.button_31 = new Button();
		this.button_32 = new Button();
		this.button_28 = new Button();
		this.button_29 = new Button();
		this.button_30 = new Button();
		this.fastColoredTextBox_0 = new FastColoredTextBox();
		this.richTextBox_20 = new RichTextBox();
		this.tabPage_1 = new TabPage();
		this.button_26 = new Button();
		this.button_25 = new Button();
		this.button_24 = new Button();
		this.button_23 = new Button();
		this.button_22 = new Button();
		this.button_21 = new Button();
		this.button_20 = new Button();
		this.button_19 = new Button();
		this.button_18 = new Button();
		this.button_17 = new Button();
		this.button_16 = new Button();
		this.button_15 = new Button();
		this.button_14 = new Button();
		this.button_13 = new Button();
		this.button_12 = new Button();
		this.button_11 = new Button();
		this.button_10 = new Button();
		this.button_9 = new Button();
		this.button_8 = new Button();
		this.button_6 = new Button();
		this.richTextBox_1 = new RichTextBox();
		this.richTextBox_2 = new RichTextBox();
		this.richTextBox_3 = new RichTextBox();
		this.richTextBox_4 = new RichTextBox();
		this.richTextBox_5 = new RichTextBox();
		this.richTextBox_6 = new RichTextBox();
		this.richTextBox_7 = new RichTextBox();
		this.richTextBox_8 = new RichTextBox();
		this.richTextBox_9 = new RichTextBox();
		this.richTextBox_10 = new RichTextBox();
		this.richTextBox_11 = new RichTextBox();
		this.richTextBox_12 = new RichTextBox();
		this.richTextBox_13 = new RichTextBox();
		this.richTextBox_14 = new RichTextBox();
		this.richTextBox_15 = new RichTextBox();
		this.richTextBox_16 = new RichTextBox();
		this.richTextBox_17 = new RichTextBox();
		this.richTextBox_18 = new RichTextBox();
		this.richTextBox_19 = new RichTextBox();
		this.tabPage_4 = new TabPage();
		this.fastColoredTextBox_1 = new FastColoredTextBox();
		this.metroButton_1 = new MetroButton();
		this.metroButton_0 = new MetroButton();
		this.tabPage_2 = new TabPage();
		this.label_3 = new Label();
		this.button_37 = new Button();
		this.button_36 = new Button();
		this.label_2 = new Label();
		this.button_35 = new Button();
		this.label_1 = new Label();
		this.button_34 = new Button();
		this.button_33 = new Button();
		this.checkBox_0 = new CheckBox();
		this.pictureBox_0 = new PictureBox();
		this.pictureBox_1 = new PictureBox();
		this.pictureBox_2 = new PictureBox();
		this.pictureBox_3 = new PictureBox();
		this.button_7 = new Button();
		this.label_0 = new Label();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.button_27 = new Button();
		this.timer_1 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.visualStudioTabControl_0.SuspendLayout();
		this.tabPage_0.SuspendLayout();
		this.tabPage_3.SuspendLayout();
		this.fastColoredTextBox_0.BeginInit();
		this.tabPage_1.SuspendLayout();
		this.tabPage_4.SuspendLayout();
		this.fastColoredTextBox_1.BeginInit();
		this.tabPage_2.SuspendLayout();
		((ISupportInitialize)this.pictureBox_0).BeginInit();
		((ISupportInitialize)this.pictureBox_1).BeginInit();
		((ISupportInitialize)this.pictureBox_2).BeginInit();
		((ISupportInitialize)this.pictureBox_3).BeginInit();
		base.SuspendLayout();
		this.button_0.BackColor = Color.FromArgb(40, 40, 40);
		this.button_0.FlatStyle = FlatStyle.Flat;
		this.button_0.ForeColor = Color.DarkViolet;
		this.button_0.Location = new Point(941, 4);
		this.button_0.Margin = new Padding(3, 4, 3, 4);
		this.button_0.Name = "button1";
		this.button_0.Size = new Size(26, 31);
		this.button_0.TabIndex = 5;
		this.button_0.Text = "X";
		this.button_0.UseVisualStyleBackColor = false;
		this.button_0.Click += this.button_0_Click;
		this.button_1.BackColor = Color.FromArgb(40, 40, 40);
		this.button_1.FlatStyle = FlatStyle.Flat;
		this.button_1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.button_1.ForeColor = Color.DarkViolet;
		this.button_1.Location = new Point(907, 4);
		this.button_1.Margin = new Padding(3, 4, 3, 4);
		this.button_1.Name = "button2";
		this.button_1.Size = new Size(26, 31);
		this.button_1.TabIndex = 6;
		this.button_1.Text = "-";
		this.button_1.UseVisualStyleBackColor = false;
		this.button_1.Click += this.button_1_Click;
		this.visualStudioTabControl_0.ActiveColor = Color.FromArgb(104, 33, 122);
		this.visualStudioTabControl_0.AllowDrop = true;
		this.visualStudioTabControl_0.BackTabColor = Color.FromArgb(28, 28, 28);
		this.visualStudioTabControl_0.BorderColor = Color.FromArgb(30, 30, 30);
		this.visualStudioTabControl_0.ClosingButtonColor = Color.WhiteSmoke;
		this.visualStudioTabControl_0.ClosingMessage = null;
		this.visualStudioTabControl_0.Controls.Add(this.tabPage_0);
		this.visualStudioTabControl_0.Controls.Add(this.tabPage_3);
		this.visualStudioTabControl_0.Controls.Add(this.tabPage_1);
		this.visualStudioTabControl_0.Controls.Add(this.tabPage_4);
		this.visualStudioTabControl_0.Controls.Add(this.tabPage_2);
		this.visualStudioTabControl_0.HeaderColor = Color.FromArgb(45, 45, 48);
		this.visualStudioTabControl_0.HorizontalLineColor = Color.FromArgb(104, 33, 122);
		this.visualStudioTabControl_0.ImeMode = ImeMode.NoControl;
		this.visualStudioTabControl_0.ItemSize = new Size(240, 16);
		this.visualStudioTabControl_0.Location = new Point(14, 55);
		this.visualStudioTabControl_0.Margin = new Padding(3, 4, 3, 4);
		this.visualStudioTabControl_0.Name = "visualStudioTabControl1";
		this.visualStudioTabControl_0.SelectedIndex = 0;
		this.visualStudioTabControl_0.SelectedTextColor = Color.FromArgb(255, 255, 255);
		this.visualStudioTabControl_0.ShowClosingButton = false;
		this.visualStudioTabControl_0.ShowClosingMessage = false;
		this.visualStudioTabControl_0.Size = new Size(943, 568);
		this.visualStudioTabControl_0.TabIndex = 7;
		this.visualStudioTabControl_0.TextColor = Color.FromArgb(255, 255, 255);
		this.tabPage_0.BackColor = Color.FromArgb(28, 28, 28);
		this.tabPage_0.Controls.Add(this.button_2);
		this.tabPage_0.Controls.Add(this.button_3);
		this.tabPage_0.Controls.Add(this.button_4);
		this.tabPage_0.Controls.Add(this.button_5);
		this.tabPage_0.Controls.Add(this.webBrowser_1);
		this.tabPage_0.Controls.Add(this.richTextBox_0);
		this.tabPage_0.Location = new Point(4, 20);
		this.tabPage_0.Margin = new Padding(3, 4, 3, 4);
		this.tabPage_0.Name = "tabPage1";
		this.tabPage_0.Padding = new Padding(3, 4, 3, 4);
		this.tabPage_0.Size = new Size(935, 544);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Full Lua Executor";
		this.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_2.FlatAppearance.BorderSize = 0;
		this.button_2.FlatStyle = FlatStyle.Flat;
		this.button_2.Location = new Point(712, 485);
		this.button_2.Margin = new Padding(3, 4, 3, 4);
		this.button_2.Name = "button8";
		this.button_2.Size = new Size(215, 51);
		this.button_2.TabIndex = 13;
		this.button_2.Text = "Load File";
		this.button_2.UseVisualStyleBackColor = true;
		this.button_2.Click += this.button_2_Click;
		this.button_3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_3.FlatAppearance.BorderSize = 0;
		this.button_3.FlatStyle = FlatStyle.Flat;
		this.button_3.Location = new Point(478, 485);
		this.button_3.Margin = new Padding(3, 4, 3, 4);
		this.button_3.Name = "button6";
		this.button_3.Size = new Size(228, 51);
		this.button_3.TabIndex = 12;
		this.button_3.Text = "Clear";
		this.button_3.UseVisualStyleBackColor = true;
		this.button_3.Click += this.button_3_Click;
		this.button_4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_4.FlatAppearance.BorderSize = 0;
		this.button_4.FlatStyle = FlatStyle.Flat;
		this.button_4.Location = new Point(250, 485);
		this.button_4.Margin = new Padding(3, 4, 3, 4);
		this.button_4.Name = "button5";
		this.button_4.Size = new Size(222, 51);
		this.button_4.TabIndex = 11;
		this.button_4.Text = "Execute";
		this.button_4.UseVisualStyleBackColor = true;
		this.button_4.Click += this.button_4_Click;
		this.button_5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_5.FlatAppearance.BorderSize = 0;
		this.button_5.FlatStyle = FlatStyle.Flat;
		this.button_5.Location = new Point(7, 485);
		this.button_5.Margin = new Padding(3, 4, 3, 4);
		this.button_5.Name = "button7";
		this.button_5.Size = new Size(237, 51);
		this.button_5.TabIndex = 9;
		this.button_5.Text = "Inject Skisploit API";
		this.button_5.UseVisualStyleBackColor = true;
		this.button_5.Click += this.button_5_Click;
		this.webBrowser_1.Location = new Point(7, 8);
		this.webBrowser_1.Margin = new Padding(3, 4, 3, 4);
		this.webBrowser_1.MinimumSize = new Size(23, 27);
		this.webBrowser_1.Name = "webBrowser1";
		this.webBrowser_1.Size = new Size(920, 461);
		this.webBrowser_1.TabIndex = 0;
		this.webBrowser_1.DocumentCompleted += this.webBrowser_1_DocumentCompleted;
		this.richTextBox_0.Location = new Point(60, 489);
		this.richTextBox_0.Name = "richTextBox1";
		this.richTextBox_0.Size = new Size(41, 32);
		this.richTextBox_0.TabIndex = 9;
		this.richTextBox_0.Text = componentResourceManager.GetString("richTextBox1.Text");
		this.tabPage_3.BackColor = Color.FromArgb(28, 28, 28);
		this.tabPage_3.Controls.Add(this.button_31);
		this.tabPage_3.Controls.Add(this.button_32);
		this.tabPage_3.Controls.Add(this.button_28);
		this.tabPage_3.Controls.Add(this.button_29);
		this.tabPage_3.Controls.Add(this.button_30);
		this.tabPage_3.Controls.Add(this.fastColoredTextBox_0);
		this.tabPage_3.Controls.Add(this.richTextBox_20);
		this.tabPage_3.Location = new Point(4, 20);
		this.tabPage_3.Name = "tabPage4";
		this.tabPage_3.Size = new Size(935, 544);
		this.tabPage_3.TabIndex = 3;
		this.tabPage_3.Text = "Alternate Executor";
		this.button_31.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_31.FlatAppearance.BorderSize = 0;
		this.button_31.FlatStyle = FlatStyle.Flat;
		this.button_31.Location = new Point(190, 488);
		this.button_31.Margin = new Padding(3, 4, 3, 4);
		this.button_31.Name = "button9";
		this.button_31.Size = new Size(176, 53);
		this.button_31.TabIndex = 18;
		this.button_31.Text = "Update API";
		this.button_31.UseVisualStyleBackColor = true;
		this.button_31.Click += this.button_31_Click;
		this.button_32.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_32.FlatAppearance.BorderSize = 0;
		this.button_32.FlatStyle = FlatStyle.Flat;
		this.button_32.Location = new Point(14, 488);
		this.button_32.Margin = new Padding(3, 4, 3, 4);
		this.button_32.Name = "button4";
		this.button_32.Size = new Size(170, 51);
		this.button_32.TabIndex = 17;
		this.button_32.Text = "Inject WeAreDevs API";
		this.button_32.UseVisualStyleBackColor = true;
		this.button_32.Click += this.button_32_Click;
		this.button_28.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_28.FlatAppearance.BorderSize = 0;
		this.button_28.FlatStyle = FlatStyle.Flat;
		this.button_28.Location = new Point(743, 488);
		this.button_28.Margin = new Padding(3, 4, 3, 4);
		this.button_28.Name = "button31";
		this.button_28.Size = new Size(172, 52);
		this.button_28.TabIndex = 16;
		this.button_28.Text = "Load File";
		this.button_28.UseVisualStyleBackColor = true;
		this.button_28.Click += this.button_28_Click;
		this.button_29.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_29.FlatAppearance.BorderSize = 0;
		this.button_29.FlatStyle = FlatStyle.Flat;
		this.button_29.Location = new Point(559, 489);
		this.button_29.Margin = new Padding(3, 4, 3, 4);
		this.button_29.Name = "button32";
		this.button_29.Size = new Size(178, 52);
		this.button_29.TabIndex = 15;
		this.button_29.Text = "Clear";
		this.button_29.UseVisualStyleBackColor = true;
		this.button_29.Click += this.button_29_Click;
		this.button_30.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_30.FlatAppearance.BorderSize = 0;
		this.button_30.FlatStyle = FlatStyle.Flat;
		this.button_30.Location = new Point(372, 489);
		this.button_30.Margin = new Padding(3, 4, 3, 4);
		this.button_30.Name = "button33";
		this.button_30.Size = new Size(181, 52);
		this.button_30.TabIndex = 14;
		this.button_30.Text = "Execute";
		this.button_30.UseVisualStyleBackColor = true;
		this.button_30.Click += this.button_30_Click;
		FastColoredTextBox fastColoredTextBox = this.fastColoredTextBox_0;
		char[] autoCompleteBracketsList = 1162115032;
		.<<EMPTY_NAME>><char[]>();
		fastColoredTextBox.AutoCompleteBracketsList = autoCompleteBracketsList;
		this.fastColoredTextBox_0.AutoScrollMinSize = new Size(981, 504);
		this.fastColoredTextBox_0.BackBrush = null;
		this.fastColoredTextBox_0.BackColor = Color.Black;
		this.fastColoredTextBox_0.BookmarkColor = Color.FromArgb(192, 0, 192);
		this.fastColoredTextBox_0.CharHeight = 18;
		this.fastColoredTextBox_0.CharWidth = 10;
		this.fastColoredTextBox_0.Cursor = Cursors.IBeam;
		this.fastColoredTextBox_0.DisabledColor = Color.FromArgb(100, 180, 180, 180);
		this.fastColoredTextBox_0.ForeColor = Color.DarkViolet;
		this.fastColoredTextBox_0.IndentBackColor = Color.Black;
		this.fastColoredTextBox_0.IsReplaceMode = false;
		this.fastColoredTextBox_0.LineNumberColor = Color.Fuchsia;
		this.fastColoredTextBox_0.Location = new Point(0, 3);
		this.fastColoredTextBox_0.Name = "fastColoredTextBox1";
		this.fastColoredTextBox_0.PaddingBackColor = Color.Black;
		this.fastColoredTextBox_0.Paddings = new Padding(0);
		this.fastColoredTextBox_0.SelectionColor = Color.FromArgb(60, 0, 0, 255);
		this.fastColoredTextBox_0.ServiceColors = (ServiceColors)componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors");
		this.fastColoredTextBox_0.ServiceLinesColor = Color.Black;
		this.fastColoredTextBox_0.Size = new Size(932, 464);
		this.fastColoredTextBox_0.TabIndex = 0;
		this.fastColoredTextBox_0.Text = componentResourceManager.GetString("fastColoredTextBox1.Text");
		this.fastColoredTextBox_0.Zoom = 100;
		this.richTextBox_20.Location = new Point(61, 502);
		this.richTextBox_20.Name = "richTextBox2";
		this.richTextBox_20.Size = new Size(38, 31);
		this.richTextBox_20.TabIndex = 19;
		this.richTextBox_20.Text = componentResourceManager.GetString("richTextBox2.Text");
		this.tabPage_1.BackColor = Color.FromArgb(28, 28, 28);
		this.tabPage_1.Controls.Add(this.button_26);
		this.tabPage_1.Controls.Add(this.button_25);
		this.tabPage_1.Controls.Add(this.button_24);
		this.tabPage_1.Controls.Add(this.button_23);
		this.tabPage_1.Controls.Add(this.button_22);
		this.tabPage_1.Controls.Add(this.button_21);
		this.tabPage_1.Controls.Add(this.button_20);
		this.tabPage_1.Controls.Add(this.button_19);
		this.tabPage_1.Controls.Add(this.button_18);
		this.tabPage_1.Controls.Add(this.button_17);
		this.tabPage_1.Controls.Add(this.button_16);
		this.tabPage_1.Controls.Add(this.button_15);
		this.tabPage_1.Controls.Add(this.button_14);
		this.tabPage_1.Controls.Add(this.button_13);
		this.tabPage_1.Controls.Add(this.button_12);
		this.tabPage_1.Controls.Add(this.button_11);
		this.tabPage_1.Controls.Add(this.button_10);
		this.tabPage_1.Controls.Add(this.button_9);
		this.tabPage_1.Controls.Add(this.button_8);
		this.tabPage_1.Controls.Add(this.button_6);
		this.tabPage_1.Controls.Add(this.richTextBox_1);
		this.tabPage_1.Controls.Add(this.richTextBox_2);
		this.tabPage_1.Controls.Add(this.richTextBox_3);
		this.tabPage_1.Controls.Add(this.richTextBox_4);
		this.tabPage_1.Controls.Add(this.richTextBox_5);
		this.tabPage_1.Controls.Add(this.richTextBox_6);
		this.tabPage_1.Controls.Add(this.richTextBox_7);
		this.tabPage_1.Controls.Add(this.richTextBox_8);
		this.tabPage_1.Controls.Add(this.richTextBox_9);
		this.tabPage_1.Controls.Add(this.richTextBox_10);
		this.tabPage_1.Controls.Add(this.richTextBox_11);
		this.tabPage_1.Controls.Add(this.richTextBox_12);
		this.tabPage_1.Controls.Add(this.richTextBox_13);
		this.tabPage_1.Controls.Add(this.richTextBox_14);
		this.tabPage_1.Controls.Add(this.richTextBox_15);
		this.tabPage_1.Controls.Add(this.richTextBox_16);
		this.tabPage_1.Controls.Add(this.richTextBox_17);
		this.tabPage_1.Controls.Add(this.richTextBox_18);
		this.tabPage_1.Controls.Add(this.richTextBox_19);
		this.tabPage_1.Location = new Point(4, 20);
		this.tabPage_1.Margin = new Padding(3, 4, 3, 4);
		this.tabPage_1.Name = "tabPage2";
		this.tabPage_1.Padding = new Padding(3, 4, 3, 4);
		this.tabPage_1.Size = new Size(935, 544);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "More Commands";
		this.button_26.BackColor = Color.FromArgb(40, 40, 40);
		this.button_26.FlatStyle = FlatStyle.Flat;
		this.button_26.ForeColor = Color.DarkViolet;
		this.button_26.Location = new Point(695, 392);
		this.button_26.Margin = new Padding(3, 4, 3, 4);
		this.button_26.Name = "button29";
		this.button_26.Size = new Size(191, 61);
		this.button_26.TabIndex = 79;
		this.button_26.Text = "More Commands click here!";
		this.button_26.UseVisualStyleBackColor = false;
		this.button_26.Click += this.button_26_Click;
		this.button_25.BackColor = Color.FromArgb(40, 40, 40);
		this.button_25.FlatStyle = FlatStyle.Flat;
		this.button_25.ForeColor = Color.DarkViolet;
		this.button_25.Location = new Point(470, 392);
		this.button_25.Margin = new Padding(3, 4, 3, 4);
		this.button_25.Name = "button28";
		this.button_25.Size = new Size(191, 61);
		this.button_25.TabIndex = 77;
		this.button_25.Text = "FE Chat Bypass";
		this.button_25.UseVisualStyleBackColor = false;
		this.button_25.Click += this.button_25_Click;
		this.button_24.BackColor = Color.FromArgb(40, 40, 40);
		this.button_24.FlatStyle = FlatStyle.Flat;
		this.button_24.ForeColor = Color.DarkViolet;
		this.button_24.Location = new Point(248, 392);
		this.button_24.Margin = new Padding(3, 4, 3, 4);
		this.button_24.Name = "button27";
		this.button_24.Size = new Size(191, 61);
		this.button_24.TabIndex = 75;
		this.button_24.Text = "Click TP Tool";
		this.button_24.UseVisualStyleBackColor = false;
		this.button_24.Click += this.button_24_Click;
		this.button_23.BackColor = Color.FromArgb(40, 40, 40);
		this.button_23.FlatStyle = FlatStyle.Flat;
		this.button_23.ForeColor = Color.DarkViolet;
		this.button_23.Location = new Point(31, 392);
		this.button_23.Margin = new Padding(3, 4, 3, 4);
		this.button_23.Name = "button26";
		this.button_23.Size = new Size(191, 61);
		this.button_23.TabIndex = 73;
		this.button_23.Text = "FE Fly";
		this.button_23.UseVisualStyleBackColor = false;
		this.button_23.Click += this.button_23_Click;
		this.button_22.BackColor = Color.FromArgb(40, 40, 40);
		this.button_22.FlatStyle = FlatStyle.Flat;
		this.button_22.ForeColor = Color.DarkViolet;
		this.button_22.Location = new Point(695, 294);
		this.button_22.Margin = new Padding(3, 4, 3, 4);
		this.button_22.Name = "button25";
		this.button_22.Size = new Size(191, 61);
		this.button_22.TabIndex = 71;
		this.button_22.Text = "Kill FE GUI";
		this.button_22.UseVisualStyleBackColor = false;
		this.button_22.Click += this.button_22_Click;
		this.button_21.BackColor = Color.FromArgb(40, 40, 40);
		this.button_21.FlatStyle = FlatStyle.Flat;
		this.button_21.ForeColor = Color.DarkViolet;
		this.button_21.Location = new Point(470, 294);
		this.button_21.Margin = new Padding(3, 4, 3, 4);
		this.button_21.Name = "button24";
		this.button_21.Size = new Size(191, 61);
		this.button_21.TabIndex = 69;
		this.button_21.Text = "DEX v4";
		this.button_21.UseVisualStyleBackColor = false;
		this.button_21.Click += this.button_21_Click;
		this.button_20.BackColor = Color.FromArgb(40, 40, 40);
		this.button_20.FlatStyle = FlatStyle.Flat;
		this.button_20.ForeColor = Color.DarkViolet;
		this.button_20.Location = new Point(248, 294);
		this.button_20.Margin = new Padding(3, 4, 3, 4);
		this.button_20.Name = "button23";
		this.button_20.Size = new Size(191, 61);
		this.button_20.TabIndex = 67;
		this.button_20.Text = "Mad City GUI";
		this.button_20.UseVisualStyleBackColor = false;
		this.button_20.Click += this.button_20_Click;
		this.button_19.BackColor = Color.FromArgb(40, 40, 40);
		this.button_19.FlatStyle = FlatStyle.Flat;
		this.button_19.ForeColor = Color.DarkViolet;
		this.button_19.Location = new Point(31, 294);
		this.button_19.Margin = new Padding(3, 4, 3, 4);
		this.button_19.Name = "button22";
		this.button_19.Size = new Size(191, 61);
		this.button_19.TabIndex = 65;
		this.button_19.Text = "Mad City Money Farm";
		this.button_19.UseVisualStyleBackColor = false;
		this.button_19.Click += this.button_19_Click;
		this.button_18.BackColor = Color.FromArgb(40, 40, 40);
		this.button_18.FlatStyle = FlatStyle.Flat;
		this.button_18.ForeColor = Color.DarkViolet;
		this.button_18.Location = new Point(695, 196);
		this.button_18.Margin = new Padding(3, 4, 3, 4);
		this.button_18.Name = "button21";
		this.button_18.Size = new Size(191, 61);
		this.button_18.TabIndex = 63;
		this.button_18.Text = "Rocitizens GUI";
		this.button_18.UseVisualStyleBackColor = false;
		this.button_18.Click += this.button_18_Click;
		this.button_17.BackColor = Color.FromArgb(40, 40, 40);
		this.button_17.FlatStyle = FlatStyle.Flat;
		this.button_17.ForeColor = Color.DarkViolet;
		this.button_17.Location = new Point(470, 196);
		this.button_17.Margin = new Padding(3, 4, 3, 4);
		this.button_17.Name = "button20";
		this.button_17.Size = new Size(191, 61);
		this.button_17.TabIndex = 61;
		this.button_17.Text = "Flee The Facility GUI";
		this.button_17.UseVisualStyleBackColor = false;
		this.button_17.Click += this.button_17_Click;
		this.button_16.BackColor = Color.FromArgb(40, 40, 40);
		this.button_16.FlatStyle = FlatStyle.Flat;
		this.button_16.ForeColor = Color.DarkViolet;
		this.button_16.Location = new Point(248, 196);
		this.button_16.Margin = new Padding(3, 4, 3, 4);
		this.button_16.Name = "button19";
		this.button_16.Size = new Size(191, 61);
		this.button_16.TabIndex = 58;
		this.button_16.Text = "Counter-Blox GUI";
		this.button_16.UseVisualStyleBackColor = false;
		this.button_16.Click += this.button_16_Click;
		this.button_15.BackColor = Color.FromArgb(40, 40, 40);
		this.button_15.FlatStyle = FlatStyle.Flat;
		this.button_15.ForeColor = Color.DarkViolet;
		this.button_15.Location = new Point(31, 196);
		this.button_15.Margin = new Padding(3, 4, 3, 4);
		this.button_15.Name = "button18";
		this.button_15.Size = new Size(191, 61);
		this.button_15.TabIndex = 56;
		this.button_15.Text = "Mad City Exp Farm";
		this.button_15.UseVisualStyleBackColor = false;
		this.button_15.Click += this.button_15_Click;
		this.button_14.BackColor = Color.FromArgb(40, 40, 40);
		this.button_14.FlatStyle = FlatStyle.Flat;
		this.button_14.ForeColor = Color.DarkViolet;
		this.button_14.Location = new Point(695, 104);
		this.button_14.Margin = new Padding(3, 4, 3, 4);
		this.button_14.Name = "button17";
		this.button_14.Size = new Size(191, 61);
		this.button_14.TabIndex = 48;
		this.button_14.Text = "Strucid GUI";
		this.button_14.UseVisualStyleBackColor = false;
		this.button_14.Click += this.button_14_Click;
		this.button_13.BackColor = Color.FromArgb(40, 40, 40);
		this.button_13.FlatStyle = FlatStyle.Flat;
		this.button_13.ForeColor = Color.DarkViolet;
		this.button_13.Location = new Point(470, 104);
		this.button_13.Margin = new Padding(3, 4, 3, 4);
		this.button_13.Name = "button16";
		this.button_13.Size = new Size(191, 61);
		this.button_13.TabIndex = 44;
		this.button_13.Text = "Fencing Reach";
		this.button_13.UseVisualStyleBackColor = false;
		this.button_13.Click += this.button_13_Click;
		this.button_12.BackColor = Color.FromArgb(40, 40, 40);
		this.button_12.FlatStyle = FlatStyle.Flat;
		this.button_12.ForeColor = Color.DarkViolet;
		this.button_12.Location = new Point(248, 104);
		this.button_12.Margin = new Padding(3, 4, 3, 4);
		this.button_12.Name = "button15";
		this.button_12.Size = new Size(191, 61);
		this.button_12.TabIndex = 42;
		this.button_12.Text = "Jailbreak OP GUI";
		this.button_12.UseVisualStyleBackColor = false;
		this.button_12.Click += this.button_12_Click;
		this.button_11.BackColor = Color.FromArgb(40, 40, 40);
		this.button_11.FlatStyle = FlatStyle.Flat;
		this.button_11.ForeColor = Color.DarkViolet;
		this.button_11.Location = new Point(31, 104);
		this.button_11.Margin = new Padding(3, 4, 3, 4);
		this.button_11.Name = "button14";
		this.button_11.Size = new Size(191, 61);
		this.button_11.TabIndex = 40;
		this.button_11.Text = "Ro-Exploit";
		this.button_11.UseVisualStyleBackColor = false;
		this.button_11.Click += this.button_11_Click;
		this.button_10.BackColor = Color.FromArgb(40, 40, 40);
		this.button_10.FlatStyle = FlatStyle.Flat;
		this.button_10.ForeColor = Color.DarkViolet;
		this.button_10.Location = new Point(695, 17);
		this.button_10.Margin = new Padding(3, 4, 3, 4);
		this.button_10.Name = "button13";
		this.button_10.Size = new Size(191, 61);
		this.button_10.TabIndex = 38;
		this.button_10.Text = "FE Blocks";
		this.button_10.UseVisualStyleBackColor = false;
		this.button_10.Click += this.button_10_Click;
		this.button_9.BackColor = Color.FromArgb(40, 40, 40);
		this.button_9.FlatStyle = FlatStyle.Flat;
		this.button_9.ForeColor = Color.DarkViolet;
		this.button_9.Location = new Point(470, 17);
		this.button_9.Margin = new Padding(3, 4, 3, 4);
		this.button_9.Name = "button10";
		this.button_9.Size = new Size(191, 61);
		this.button_9.TabIndex = 35;
		this.button_9.Text = "RevizAdmin";
		this.button_9.UseVisualStyleBackColor = false;
		this.button_9.Click += this.button_9_Click;
		this.button_8.BackColor = Color.FromArgb(40, 40, 40);
		this.button_8.FlatStyle = FlatStyle.Flat;
		this.button_8.ForeColor = Color.DarkViolet;
		this.button_8.Location = new Point(248, 17);
		this.button_8.Margin = new Padding(3, 4, 3, 4);
		this.button_8.Name = "button3";
		this.button_8.Size = new Size(191, 61);
		this.button_8.TabIndex = 32;
		this.button_8.Text = "MeepCity gamepass";
		this.button_8.UseVisualStyleBackColor = false;
		this.button_8.Click += this.button_8_Click;
		this.button_6.BackColor = Color.FromArgb(40, 40, 40);
		this.button_6.FlatStyle = FlatStyle.Flat;
		this.button_6.ForeColor = Color.DarkViolet;
		this.button_6.Location = new Point(31, 17);
		this.button_6.Margin = new Padding(3, 4, 3, 4);
		this.button_6.Name = "button11";
		this.button_6.Size = new Size(191, 61);
		this.button_6.TabIndex = 6;
		this.button_6.Text = "Topk3k";
		this.button_6.UseVisualStyleBackColor = false;
		this.button_6.Click += this.button_6_Click;
		this.richTextBox_1.Location = new Point(82, 33);
		this.richTextBox_1.Name = "richTextBox3";
		this.richTextBox_1.Size = new Size(84, 30);
		this.richTextBox_1.TabIndex = 31;
		this.richTextBox_1.Text = componentResourceManager.GetString("richTextBox3.Text");
		this.richTextBox_2.Location = new Point(327, 24);
		this.richTextBox_2.Name = "richTextBox4";
		this.richTextBox_2.Size = new Size(52, 39);
		this.richTextBox_2.TabIndex = 34;
		this.richTextBox_2.Text = componentResourceManager.GetString("richTextBox4.Text");
		this.richTextBox_3.Location = new Point(544, 30);
		this.richTextBox_3.Name = "richTextBox7";
		this.richTextBox_3.Size = new Size(43, 33);
		this.richTextBox_3.TabIndex = 37;
		this.richTextBox_3.Text = componentResourceManager.GetString("richTextBox7.Text");
		this.richTextBox_4.Location = new Point(774, 25);
		this.richTextBox_4.Name = "richTextBox5";
		this.richTextBox_4.Size = new Size(46, 38);
		this.richTextBox_4.TabIndex = 39;
		this.richTextBox_4.Text = componentResourceManager.GetString("richTextBox5.Text");
		this.richTextBox_5.Location = new Point(82, 121);
		this.richTextBox_5.Name = "richTextBox8";
		this.richTextBox_5.Size = new Size(72, 25);
		this.richTextBox_5.TabIndex = 41;
		this.richTextBox_5.Text = "loadstring(game:GetObjects(\"rbxassetid://364364477\")[1].Source)()";
		this.richTextBox_6.Location = new Point(302, 138);
		this.richTextBox_6.Name = "richTextBox9";
		this.richTextBox_6.Size = new Size(63, 23);
		this.richTextBox_6.TabIndex = 43;
		this.richTextBox_6.Text = componentResourceManager.GetString("richTextBox9.Text");
		this.richTextBox_7.Location = new Point(528, 136);
		this.richTextBox_7.Name = "richTextBox13";
		this.richTextBox_7.Size = new Size(59, 29);
		this.richTextBox_7.TabIndex = 47;
		this.richTextBox_7.Text = componentResourceManager.GetString("richTextBox13.Text");
		this.richTextBox_8.Location = new Point(761, 136);
		this.richTextBox_8.Name = "richTextBox17";
		this.richTextBox_8.Size = new Size(59, 29);
		this.richTextBox_8.TabIndex = 55;
		this.richTextBox_8.Text = componentResourceManager.GetString("richTextBox17.Text");
		this.richTextBox_9.Location = new Point(95, 213);
		this.richTextBox_9.Name = "richTextBox14";
		this.richTextBox_9.Size = new Size(59, 29);
		this.richTextBox_9.TabIndex = 57;
		this.richTextBox_9.Text = componentResourceManager.GetString("richTextBox14.Text");
		this.richTextBox_10.Location = new Point(320, 213);
		this.richTextBox_10.Name = "richTextBox19";
		this.richTextBox_10.Size = new Size(59, 29);
		this.richTextBox_10.TabIndex = 60;
		this.richTextBox_10.Text = componentResourceManager.GetString("richTextBox19.Text");
		this.richTextBox_11.Location = new Point(544, 213);
		this.richTextBox_11.Name = "richTextBox11";
		this.richTextBox_11.Size = new Size(59, 29);
		this.richTextBox_11.TabIndex = 62;
		this.richTextBox_11.Text = componentResourceManager.GetString("richTextBox11.Text");
		this.richTextBox_12.Location = new Point(761, 213);
		this.richTextBox_12.Name = "richTextBox12";
		this.richTextBox_12.Size = new Size(59, 29);
		this.richTextBox_12.TabIndex = 64;
		this.richTextBox_12.Text = componentResourceManager.GetString("richTextBox12.Text");
		this.richTextBox_13.Location = new Point(95, 311);
		this.richTextBox_13.Name = "richTextBox15";
		this.richTextBox_13.Size = new Size(59, 29);
		this.richTextBox_13.TabIndex = 66;
		this.richTextBox_13.Text = componentResourceManager.GetString("richTextBox15.Text");
		this.richTextBox_14.Location = new Point(320, 311);
		this.richTextBox_14.Name = "richTextBox16";
		this.richTextBox_14.Size = new Size(59, 29);
		this.richTextBox_14.TabIndex = 68;
		this.richTextBox_14.Text = componentResourceManager.GetString("richTextBox16.Text");
		this.richTextBox_15.Location = new Point(544, 311);
		this.richTextBox_15.Name = "richTextBox21";
		this.richTextBox_15.Size = new Size(59, 29);
		this.richTextBox_15.TabIndex = 70;
		this.richTextBox_15.Text = "loadstring(game:GetObjects('rbxassetid://2180084478')[1].Source)()";
		this.richTextBox_16.Location = new Point(761, 311);
		this.richTextBox_16.Name = "richTextBox22";
		this.richTextBox_16.Size = new Size(59, 29);
		this.richTextBox_16.TabIndex = 72;
		this.richTextBox_16.Text = componentResourceManager.GetString("richTextBox22.Text");
		this.richTextBox_17.Location = new Point(95, 409);
		this.richTextBox_17.Name = "richTextBox23";
		this.richTextBox_17.Size = new Size(59, 29);
		this.richTextBox_17.TabIndex = 74;
		this.richTextBox_17.Text = componentResourceManager.GetString("richTextBox23.Text");
		this.richTextBox_18.Location = new Point(320, 409);
		this.richTextBox_18.Name = "richTextBox24";
		this.richTextBox_18.Size = new Size(59, 29);
		this.richTextBox_18.TabIndex = 76;
		this.richTextBox_18.Text = componentResourceManager.GetString("richTextBox24.Text");
		this.richTextBox_19.Location = new Point(544, 409);
		this.richTextBox_19.Name = "richTextBox25";
		this.richTextBox_19.Size = new Size(59, 29);
		this.richTextBox_19.TabIndex = 78;
		this.richTextBox_19.Text = componentResourceManager.GetString("richTextBox25.Text");
		this.tabPage_4.BackColor = Color.FromArgb(28, 28, 28);
		this.tabPage_4.Controls.Add(this.fastColoredTextBox_1);
		this.tabPage_4.Controls.Add(this.metroButton_1);
		this.tabPage_4.Controls.Add(this.metroButton_0);
		this.tabPage_4.Location = new Point(4, 20);
		this.tabPage_4.Name = "tabPage5";
		this.tabPage_4.Size = new Size(935, 544);
		this.tabPage_4.TabIndex = 4;
		this.tabPage_4.Text = "CS:GO Hack";
		FastColoredTextBox fastColoredTextBox2 = this.fastColoredTextBox_1;
		char[] autoCompleteBracketsList2 = -51983379;
		.<<EMPTY_NAME>><char[]>();
		fastColoredTextBox2.AutoCompleteBracketsList = autoCompleteBracketsList2;
		this.fastColoredTextBox_1.AutoScrollMinSize = new Size(818, 462);
		this.fastColoredTextBox_1.BackBrush = null;
		this.fastColoredTextBox_1.BackColor = Color.Black;
		this.fastColoredTextBox_1.BookmarkColor = Color.Fuchsia;
		this.fastColoredTextBox_1.ChangedLineColor = Color.Black;
		this.fastColoredTextBox_1.CharHeight = 22;
		this.fastColoredTextBox_1.CharWidth = 12;
		this.fastColoredTextBox_1.CurrentLineColor = Color.Black;
		this.fastColoredTextBox_1.Cursor = Cursors.IBeam;
		this.fastColoredTextBox_1.DisabledColor = Color.Black;
		this.fastColoredTextBox_1.FoldingIndicatorColor = Color.Fuchsia;
		this.fastColoredTextBox_1.Font = new Font("Courier New", 12f, FontStyle.Bold);
		this.fastColoredTextBox_1.ForeColor = Color.Fuchsia;
		this.fastColoredTextBox_1.IsReplaceMode = false;
		this.fastColoredTextBox_1.Location = new Point(63, 49);
		this.fastColoredTextBox_1.Name = "fastColoredTextBox2";
		this.fastColoredTextBox_1.Paddings = new Padding(0);
		this.fastColoredTextBox_1.SelectionColor = Color.FromArgb(60, 255, 0, 255);
		this.fastColoredTextBox_1.ServiceColors = (ServiceColors)componentResourceManager.GetObject("fastColoredTextBox2.ServiceColors");
		this.fastColoredTextBox_1.ServiceLinesColor = Color.Fuchsia;
		this.fastColoredTextBox_1.Size = new Size(794, 342);
		this.fastColoredTextBox_1.TabIndex = 2;
		this.fastColoredTextBox_1.Text = componentResourceManager.GetString("fastColoredTextBox2.Text");
		this.fastColoredTextBox_1.Zoom = 100;
		this.metroButton_1.BackColor = Color.Black;
		this.metroButton_1.BackgroundImageLayout = ImageLayout.None;
		this.metroButton_1.BorderColor = Color.FromArgb(98, 98, 98);
		this.metroButton_1.DefaultColor = Color.FromArgb(40, 40, 40);
		this.metroButton_1.DisabledColor = Color.FromArgb(35, 35, 35);
		this.metroButton_1.Font = new Font("Segoe UI", 9f);
		this.metroButton_1.ForeColor = Color.FromArgb(153, 153, 153);
		this.metroButton_1.HoverColor = Color.FromArgb(63, 63, 63);
		this.metroButton_1.Location = new Point(639, 419);
		this.metroButton_1.Name = "metroButton2";
		this.metroButton_1.PressedColor = Color.FromArgb(0, 122, 204);
		this.metroButton_1.RoundingArc = 74;
		this.metroButton_1.Size = new Size(218, 74);
		this.metroButton_1.Style = 1;
		this.metroButton_1.TabIndex = 1;
		this.metroButton_1.Text = "Exit CS:GO Hack";
		this.metroButton_1.Click += this.metroButton_1_Click;
		this.metroButton_0.BackColor = Color.Black;
		this.metroButton_0.BackgroundImageLayout = ImageLayout.None;
		this.metroButton_0.BorderColor = Color.FromArgb(98, 98, 98);
		this.metroButton_0.DefaultColor = Color.FromArgb(40, 40, 40);
		this.metroButton_0.DisabledColor = Color.FromArgb(35, 35, 35);
		this.metroButton_0.Font = new Font("Segoe UI", 9f);
		this.metroButton_0.ForeColor = Color.FromArgb(153, 153, 153);
		this.metroButton_0.HoverColor = Color.FromArgb(63, 63, 63);
		this.metroButton_0.Location = new Point(63, 419);
		this.metroButton_0.Name = "metroButton1";
		this.metroButton_0.PressedColor = Color.FromArgb(0, 122, 204);
		this.metroButton_0.RoundingArc = 74;
		this.metroButton_0.Size = new Size(218, 74);
		this.metroButton_0.Style = 1;
		this.metroButton_0.TabIndex = 0;
		this.metroButton_0.Text = "Launch CS:GO Hack";
		this.metroButton_0.Click += this.metroButton_0_Click;
		this.tabPage_2.BackColor = Color.FromArgb(28, 28, 28);
		this.tabPage_2.Controls.Add(this.label_3);
		this.tabPage_2.Controls.Add(this.button_37);
		this.tabPage_2.Controls.Add(this.button_36);
		this.tabPage_2.Controls.Add(this.label_2);
		this.tabPage_2.Controls.Add(this.button_35);
		this.tabPage_2.Controls.Add(this.label_1);
		this.tabPage_2.Controls.Add(this.button_34);
		this.tabPage_2.Controls.Add(this.button_33);
		this.tabPage_2.Controls.Add(this.checkBox_0);
		this.tabPage_2.Controls.Add(this.pictureBox_0);
		this.tabPage_2.Controls.Add(this.pictureBox_1);
		this.tabPage_2.Controls.Add(this.pictureBox_2);
		this.tabPage_2.Controls.Add(this.pictureBox_3);
		this.tabPage_2.Controls.Add(this.button_7);
		this.tabPage_2.Location = new Point(4, 20);
		this.tabPage_2.Margin = new Padding(3, 4, 3, 4);
		this.tabPage_2.Name = "tabPage3";
		this.tabPage_2.Padding = new Padding(3, 4, 3, 4);
		this.tabPage_2.Size = new Size(935, 544);
		this.tabPage_2.TabIndex = 2;
		this.tabPage_2.Text = "Settings";
		this.tabPage_2.Click += this.tabPage_2_Click;
		this.label_3.AutoSize = true;
		this.label_3.Font = new Font("Segoe UI", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label_3.ForeColor = Color.DarkOrchid;
		this.label_3.Location = new Point(537, 100);
		this.label_3.Name = "label4";
		this.label_3.Size = new Size(378, 75);
		this.label_3.TabIndex = 41;
		this.label_3.Text = "Don't have any script to use?\r\nDon't worry, click this button and download\r\nShadow 1160 Script pack.";
		this.button_37.BackColor = Color.FromArgb(40, 40, 40);
		this.button_37.FlatStyle = FlatStyle.Flat;
		this.button_37.ForeColor = Color.DarkViolet;
		this.button_37.Location = new Point(542, 189);
		this.button_37.Margin = new Padding(3, 4, 3, 4);
		this.button_37.Name = "button38";
		this.button_37.Size = new Size(373, 58);
		this.button_37.TabIndex = 40;
		this.button_37.Text = "Download Shadow 1160 Script Pack";
		this.button_37.UseVisualStyleBackColor = false;
		this.button_37.Click += this.button_37_Click;
		this.button_36.BackColor = Color.FromArgb(40, 40, 40);
		this.button_36.FlatStyle = FlatStyle.Flat;
		this.button_36.ForeColor = Color.DarkViolet;
		this.button_36.Location = new Point(15, 458);
		this.button_36.Margin = new Padding(3, 4, 3, 4);
		this.button_36.Name = "button37";
		this.button_36.Size = new Size(152, 58);
		this.button_36.TabIndex = 39;
		this.button_36.Text = "Advanced Fix";
		this.button_36.UseVisualStyleBackColor = false;
		this.button_36.Click += this.button_36_Click;
		this.label_2.AutoSize = true;
		this.label_2.Font = new Font("Segoe UI", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label_2.ForeColor = Color.DarkOrchid;
		this.label_2.Location = new Point(11, 392);
		this.label_2.Name = "label3";
		this.label_2.Size = new Size(459, 50);
		this.label_2.TabIndex = 38;
		this.label_2.Text = "The exploit still not inject or other injection problem?\r\nClick this button and follow the Instruction.\r\n";
		this.button_35.BackColor = Color.FromArgb(40, 40, 40);
		this.button_35.FlatStyle = FlatStyle.Flat;
		this.button_35.ForeColor = Color.DarkViolet;
		this.button_35.Location = new Point(196, 314);
		this.button_35.Margin = new Padding(3, 4, 3, 4);
		this.button_35.Name = "button36";
		this.button_35.Size = new Size(152, 58);
		this.button_35.TabIndex = 37;
		this.button_35.Text = "vcruntime 64 bit 2017";
		this.button_35.UseVisualStyleBackColor = false;
		this.button_35.Click += this.button_35_Click;
		this.label_1.AutoSize = true;
		this.label_1.Font = new Font("Segoe UI", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label_1.ForeColor = Color.DarkOrchid;
		this.label_1.Location = new Point(10, 251);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(296, 50);
		this.label_1.TabIndex = 36;
		this.label_1.Text = "Exploit not Inject or DLL Missing? \r\nDownload and install both of this.\r\n";
		this.button_34.BackColor = Color.FromArgb(40, 40, 40);
		this.button_34.FlatStyle = FlatStyle.Flat;
		this.button_34.ForeColor = Color.DarkViolet;
		this.button_34.Location = new Point(15, 314);
		this.button_34.Margin = new Padding(3, 4, 3, 4);
		this.button_34.Name = "button35";
		this.button_34.Size = new Size(152, 58);
		this.button_34.TabIndex = 35;
		this.button_34.Text = "vcruntime 32 bit 2017";
		this.button_34.UseVisualStyleBackColor = false;
		this.button_34.Click += this.button_34_Click;
		this.button_33.BackColor = Color.FromArgb(40, 40, 40);
		this.button_33.FlatStyle = FlatStyle.Flat;
		this.button_33.ForeColor = Color.DarkViolet;
		this.button_33.Location = new Point(16, 162);
		this.button_33.Margin = new Padding(3, 4, 3, 4);
		this.button_33.Name = "button34";
		this.button_33.Size = new Size(180, 67);
		this.button_33.TabIndex = 34;
		this.button_33.Text = "Credits";
		this.button_33.UseVisualStyleBackColor = false;
		this.button_33.Click += this.button_33_Click;
		this.checkBox_0.AutoSize = true;
		this.checkBox_0.BackColor = Color.Black;
		this.checkBox_0.FlatStyle = FlatStyle.Flat;
		this.checkBox_0.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.checkBox_0.ForeColor = Color.DarkOrchid;
		this.checkBox_0.Location = new Point(16, 21);
		this.checkBox_0.Name = "checkBox1";
		this.checkBox_0.Size = new Size(180, 22);
		this.checkBox_0.TabIndex = 33;
		this.checkBox_0.Text = "TopMost Application";
		this.checkBox_0.UseVisualStyleBackColor = false;
		this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
		this.pictureBox_0.BackgroundImageLayout = ImageLayout.Stretch;
		this.pictureBox_0.Location = new Point(586, 11);
		this.pictureBox_0.Name = "pictureBox2";
		this.pictureBox_0.Size = new Size(73, 70);
		this.pictureBox_0.TabIndex = 32;
		this.pictureBox_0.TabStop = false;
		this.pictureBox_0.Click += this.pictureBox_0_Click;
		this.pictureBox_1.BackgroundImageLayout = ImageLayout.Stretch;
		this.pictureBox_1.Location = new Point(850, 11);
		this.pictureBox_1.Name = "pictureBox3";
		this.pictureBox_1.Size = new Size(73, 70);
		this.pictureBox_1.TabIndex = 31;
		this.pictureBox_1.TabStop = false;
		this.pictureBox_1.Click += this.pictureBox_1_Click;
		this.pictureBox_2.BackgroundImageLayout = ImageLayout.Stretch;
		this.pictureBox_2.Location = new Point(760, 11);
		this.pictureBox_2.Name = "pictureBox4";
		this.pictureBox_2.Size = new Size(73, 70);
		this.pictureBox_2.TabIndex = 30;
		this.pictureBox_2.TabStop = false;
		this.pictureBox_2.Click += this.pictureBox_2_Click;
		this.pictureBox_3.BackgroundImageLayout = ImageLayout.Stretch;
		this.pictureBox_3.Location = new Point(674, 11);
		this.pictureBox_3.Name = "pictureBox1";
		this.pictureBox_3.Size = new Size(73, 70);
		this.pictureBox_3.TabIndex = 29;
		this.pictureBox_3.TabStop = false;
		this.pictureBox_3.Click += this.pictureBox_3_Click;
		this.button_7.BackColor = Color.FromArgb(40, 40, 40);
		this.button_7.FlatStyle = FlatStyle.Flat;
		this.button_7.ForeColor = Color.DarkViolet;
		this.button_7.Location = new Point(16, 69);
		this.button_7.Margin = new Padding(3, 4, 3, 4);
		this.button_7.Name = "button12";
		this.button_7.Size = new Size(180, 67);
		this.button_7.TabIndex = 7;
		this.button_7.Text = "Kill Roblox Process";
		this.button_7.UseVisualStyleBackColor = false;
		this.button_7.Click += this.button_7_Click;
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(149, 9);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(101, 20);
		this.label_0.TabIndex = 8;
		this.label_0.Text = "(Not Injected)";
		this.label_0.Click += this.label_0_Click;
		this.timer_0.Tick += this.timer_0_Tick;
		this.button_27.Location = new Point(-19, -19);
		this.button_27.Name = "button30";
		this.button_27.Size = new Size(75, 23);
		this.button_27.TabIndex = 9;
		this.button_27.Text = "button30";
		this.button_27.UseVisualStyleBackColor = true;
		this.timer_1.Tick += this.timer_1_Tick;
		base.AccentColor = Color.FromArgb(104, 33, 122);
		base.AutoScaleDimensions = new SizeF(8f, 20f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(970, 639);
		base.Controls.Add(this.button_27);
		base.Controls.Add(this.label_0);
		base.Controls.Add(this.visualStudioTabControl_0);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		this.ForeColor = SystemColors.ControlDark;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Margin = new Padding(3, 4, 3, 4);
		this.MaximumSize = new Size(970, 639);
		this.MinimumSize = new Size(970, 639);
		base.Name = "ShadowSploitX";
		base.StartPosition = FormStartPosition.CenterScreen;
		base.State = 1;
		base.Style = 1;
		this.Text = "ShadowSploit X";
		base.FormClosing += this.GForm1_FormClosing;
		base.Load += this.GForm1_Load;
		this.visualStudioTabControl_0.ResumeLayout(false);
		this.tabPage_0.ResumeLayout(false);
		this.tabPage_3.ResumeLayout(false);
		this.fastColoredTextBox_0.EndInit();
		this.tabPage_1.ResumeLayout(false);
		this.tabPage_4.ResumeLayout(false);
		this.fastColoredTextBox_1.EndInit();
		this.tabPage_2.ResumeLayout(false);
		this.tabPage_2.PerformLayout();
		((ISupportInitialize)this.pictureBox_0).EndInit();
		((ISupportInitialize)this.pictureBox_1).EndInit();
		((ISupportInitialize)this.pictureBox_2).EndInit();
		((ISupportInitialize)this.pictureBox_3).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00009BD4 File Offset: 0x00007DD4
	[CompilerGenerated]
	private void method_12(string string_2)
	{
		Process[] processesByName = Process.GetProcessesByName(string_2);
		if (processesByName.Length == 0)
		{
			this.label_0.Text = "(Not Injected)";
		}
	}

	// Token: 0x04000049 RID: 73
	private ExploitAPI exploitAPI_0 = new ExploitAPI();

	// Token: 0x0400004A RID: 74
	internal string string_0 = "WeAreDevsPublicAPI_Lua";

	// Token: 0x0400004B RID: 75
	internal string string_1 = "\\\\.\\pipe\\{0}";

	// Token: 0x0400004C RID: 76
	private WebBrowser webBrowser_0;

	// Token: 0x0400004D RID: 77
	private IContainer icontainer_0 = null;

	// Token: 0x0400004E RID: 78
	private Button button_0;

	// Token: 0x0400004F RID: 79
	private Button button_1;

	// Token: 0x04000050 RID: 80
	private VisualStudioTabControl visualStudioTabControl_0;

	// Token: 0x04000051 RID: 81
	private TabPage tabPage_0;

	// Token: 0x04000052 RID: 82
	private WebBrowser webBrowser_1;

	// Token: 0x04000053 RID: 83
	private TabPage tabPage_1;

	// Token: 0x04000054 RID: 84
	private Button button_2;

	// Token: 0x04000055 RID: 85
	private Button button_3;

	// Token: 0x04000056 RID: 86
	private Button button_4;

	// Token: 0x04000057 RID: 87
	private Button button_5;

	// Token: 0x04000058 RID: 88
	private Label label_0;

	// Token: 0x04000059 RID: 89
	private System.Windows.Forms.Timer timer_0;

	// Token: 0x0400005A RID: 90
	private Button button_6;

	// Token: 0x0400005B RID: 91
	private TabPage tabPage_2;

	// Token: 0x0400005C RID: 92
	private Button button_7;

	// Token: 0x0400005D RID: 93
	private RichTextBox richTextBox_0;

	// Token: 0x0400005E RID: 94
	private RichTextBox richTextBox_1;

	// Token: 0x0400005F RID: 95
	private Button button_8;

	// Token: 0x04000060 RID: 96
	private RichTextBox richTextBox_2;

	// Token: 0x04000061 RID: 97
	private Button button_9;

	// Token: 0x04000062 RID: 98
	private RichTextBox richTextBox_3;

	// Token: 0x04000063 RID: 99
	private Button button_10;

	// Token: 0x04000064 RID: 100
	private RichTextBox richTextBox_4;

	// Token: 0x04000065 RID: 101
	private Button button_11;

	// Token: 0x04000066 RID: 102
	private RichTextBox richTextBox_5;

	// Token: 0x04000067 RID: 103
	private Button button_12;

	// Token: 0x04000068 RID: 104
	private Button button_13;

	// Token: 0x04000069 RID: 105
	private RichTextBox richTextBox_6;

	// Token: 0x0400006A RID: 106
	private RichTextBox richTextBox_7;

	// Token: 0x0400006B RID: 107
	private Button button_14;

	// Token: 0x0400006C RID: 108
	private Button button_15;

	// Token: 0x0400006D RID: 109
	private RichTextBox richTextBox_8;

	// Token: 0x0400006E RID: 110
	private RichTextBox richTextBox_9;

	// Token: 0x0400006F RID: 111
	private Button button_16;

	// Token: 0x04000070 RID: 112
	private RichTextBox richTextBox_10;

	// Token: 0x04000071 RID: 113
	private Button button_17;

	// Token: 0x04000072 RID: 114
	private Button button_18;

	// Token: 0x04000073 RID: 115
	private RichTextBox richTextBox_11;

	// Token: 0x04000074 RID: 116
	private RichTextBox richTextBox_12;

	// Token: 0x04000075 RID: 117
	private Button button_19;

	// Token: 0x04000076 RID: 118
	private RichTextBox richTextBox_13;

	// Token: 0x04000077 RID: 119
	private Button button_20;

	// Token: 0x04000078 RID: 120
	private RichTextBox richTextBox_14;

	// Token: 0x04000079 RID: 121
	private Button button_21;

	// Token: 0x0400007A RID: 122
	private RichTextBox richTextBox_15;

	// Token: 0x0400007B RID: 123
	private Button button_22;

	// Token: 0x0400007C RID: 124
	private RichTextBox richTextBox_16;

	// Token: 0x0400007D RID: 125
	private Button button_23;

	// Token: 0x0400007E RID: 126
	private RichTextBox richTextBox_17;

	// Token: 0x0400007F RID: 127
	private Button button_24;

	// Token: 0x04000080 RID: 128
	private RichTextBox richTextBox_18;

	// Token: 0x04000081 RID: 129
	private Button button_25;

	// Token: 0x04000082 RID: 130
	private RichTextBox richTextBox_19;

	// Token: 0x04000083 RID: 131
	private Button button_26;

	// Token: 0x04000084 RID: 132
	private TabPage tabPage_3;

	// Token: 0x04000085 RID: 133
	private FastColoredTextBox fastColoredTextBox_0;

	// Token: 0x04000086 RID: 134
	private Button button_27;

	// Token: 0x04000087 RID: 135
	private Button button_28;

	// Token: 0x04000088 RID: 136
	private Button button_29;

	// Token: 0x04000089 RID: 137
	private Button button_30;

	// Token: 0x0400008A RID: 138
	private Button button_31;

	// Token: 0x0400008B RID: 139
	private Button button_32;

	// Token: 0x0400008C RID: 140
	private RichTextBox richTextBox_20;

	// Token: 0x0400008D RID: 141
	private PictureBox pictureBox_0;

	// Token: 0x0400008E RID: 142
	private PictureBox pictureBox_1;

	// Token: 0x0400008F RID: 143
	private PictureBox pictureBox_2;

	// Token: 0x04000090 RID: 144
	private PictureBox pictureBox_3;

	// Token: 0x04000091 RID: 145
	private CheckBox checkBox_0;

	// Token: 0x04000092 RID: 146
	private Button button_33;

	// Token: 0x04000093 RID: 147
	private Label label_1;

	// Token: 0x04000094 RID: 148
	private Button button_34;

	// Token: 0x04000095 RID: 149
	private Button button_35;

	// Token: 0x04000096 RID: 150
	private Button button_36;

	// Token: 0x04000097 RID: 151
	private Label label_2;

	// Token: 0x04000098 RID: 152
	private Label label_3;

	// Token: 0x04000099 RID: 153
	private Button button_37;

	// Token: 0x0400009A RID: 154
	private System.Windows.Forms.Timer timer_1;

	// Token: 0x0400009B RID: 155
	private TabPage tabPage_4;

	// Token: 0x0400009C RID: 156
	private MetroButton metroButton_0;

	// Token: 0x0400009D RID: 157
	private MetroButton metroButton_1;

	// Token: 0x0400009E RID: 158
	private FastColoredTextBox fastColoredTextBox_1;
}
