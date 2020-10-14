using System;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000014 RID: 20
internal class Class8
{
	// Token: 0x0600009A RID: 154 RVA: 0x00009E28 File Offset: 0x00008028
	static Class8()
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Filter = "Lua Script Txt (*.txt)|*.txt|All files (*.*)|*.*",
			FilterIndex = 1,
			RestoreDirectory = true,
			Title = "ShadowSploit Lua Open Script"
		};
		Class8.openFileDialog_0 = openFileDialog;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00009E70 File Offset: 0x00008070
	public static void smethod_0()
	{
		if (Class10.smethod_2(Class10.string_0))
		{
			MessageBox.Show("Already injected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else if (!Class10.smethod_2(Class10.string_0))
		{
			switch (Class5.Class6.Class6_0.method_1("RobloxPlayerBeta", AppDomain.CurrentDomain.BaseDirectory + Class8.string_0))
			{
			case Class5.Enum0.DllNotFound:
				MessageBox.Show("couldn't find" + Class8.string_0, "Dll was not found!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				break;
			case Class5.Enum0.GameProcessNotFound:
				MessageBox.Show("Couldn't find RobloxPlayerBeta.exe!", "Target process was not found!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				break;
			case Class5.Enum0.InjectionFailed:
				MessageBox.Show("Injection Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				break;
			default:
				Thread.Sleep(3000);
				if (Class10.smethod_2(Class10.string_0))
				{
				}
				break;
			}
		}
	}

	// Token: 0x040000A9 RID: 169
	public static string string_0 = "SkisploitAPIModule.dll";

	// Token: 0x040000AA RID: 170
	public static OpenFileDialog openFileDialog_0;

	// Token: 0x040000AB RID: 171
	internal static object object_0;
}
