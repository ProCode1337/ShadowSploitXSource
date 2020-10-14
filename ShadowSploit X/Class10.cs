using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000017 RID: 23
internal class Class10
{
	// Token: 0x060000A7 RID: 167 RVA: 0x0000A634 File Offset: 0x00008834
	public static void smethod_0(string string_1)
	{
		Class10.Class11 @class = new Class10.Class11();
		@class.string_0 = string_1;
		if (Class10.smethod_2(Class10.string_0))
		{
			new Thread(new ThreadStart(@class.method_0)).Start();
		}
		else
		{
			MessageBox.Show("Inject " + Class8.string_0 + " before Using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x0000A698 File Offset: 0x00008898
	internal static void smethod_1(string string_1, string string_2, string string_3)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0000A6AC File Offset: 0x000088AC
	public static bool smethod_2(string string_1)
	{
		bool result;
		try
		{
			if (!Class10.WaitNamedPipe(Path.GetFullPath(string.Format("\\\\\\\\.\\\\pipe\\\\{0}", string_1)), 0))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error == 0)
				{
					return false;
				}
				if (lastWin32Error == 2)
				{
					return false;
				}
			}
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060000AA RID: 170
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool WaitNamedPipe(string string_1, int int_0);

	// Token: 0x040000B8 RID: 184
	public static string string_0 = "9w49yJgL5Vg8VHwHvxZNtBAb";

	// Token: 0x02000018 RID: 24
	[CompilerGenerated]
	private sealed class Class11
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000A710 File Offset: 0x00008910
		internal void method_0()
		{
			try
			{
				using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", Class10.string_0, PipeDirection.Out))
				{
					namedPipeClientStream.Connect();
					using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream, Encoding.Default, 999999))
					{
						streamWriter.Write(this.string_0);
						streamWriter.Dispose();
					}
					namedPipeClientStream.Dispose();
				}
			}
			catch (IOException)
			{
				MessageBox.Show("Error occured connecting to the pipe.", "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}

		// Token: 0x040000B9 RID: 185
		public string string_0;
	}
}
