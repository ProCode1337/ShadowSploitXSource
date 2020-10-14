using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200000D RID: 13
internal class Class5
{
	// Token: 0x0200000E RID: 14
	public enum Enum0
	{
		// Token: 0x0400002F RID: 47
		DllNotFound,
		// Token: 0x04000030 RID: 48
		GameProcessNotFound,
		// Token: 0x04000031 RID: 49
		InjectionFailed,
		// Token: 0x04000032 RID: 50
		Success
	}

	// Token: 0x0200000F RID: 15
	public sealed class Class6
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003D84 File Offset: 0x00001F84
		public static Class5.Class6 Class6_0
		{
			get
			{
				if (Class5.Class6.class6_0 == null)
				{
					Class5.Class6.class6_0 = new Class5.Class6();
				}
				return Class5.Class6.class6_0;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003038 File Offset: 0x00001238
		private Class6()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003DC4 File Offset: 0x00001FC4
		private bool method_0(uint uint_0, string string_0)
		{
			IntPtr intPtr = Class5.Class6.OpenProcess(1082u, 1, uint_0);
			bool result;
			if (intPtr != Class5.Class6.intptr_0)
			{
				IntPtr procAddress = Class5.Class6.GetProcAddress(Class5.Class6.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
				if (procAddress != Class5.Class6.intptr_0)
				{
					IntPtr intPtr2 = Class5.Class6.VirtualAllocEx(intPtr, (IntPtr)0, (IntPtr)string_0.Length, 12288u, 64u);
					if (!(intPtr2 != Class5.Class6.intptr_0))
					{
						result = false;
					}
					else
					{
						byte[] bytes = Encoding.ASCII.GetBytes(string_0);
						if (Class5.Class6.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, 0) != 0 && Class5.Class6.CreateRemoteThread(intPtr, (IntPtr)0, Class5.Class6.intptr_0, procAddress, intPtr2, 0u, (IntPtr)0) != Class5.Class6.intptr_0)
						{
							Class5.Class6.CloseHandle(intPtr);
							result = true;
						}
						else
						{
							result = false;
						}
					}
				}
				else
				{
					result = false;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000039 RID: 57
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int CloseHandle(IntPtr intptr_1);

		// Token: 0x0600003A RID: 58
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateRemoteThread(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, IntPtr intptr_5, uint uint_0, IntPtr intptr_6);

		// Token: 0x0600003B RID: 59
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string string_0);

		// Token: 0x0600003C RID: 60
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_0);

		// Token: 0x0600003D RID: 61 RVA: 0x00003EA0 File Offset: 0x000020A0
		public Class5.Enum0 method_1(string string_0, string string_1)
		{
			if (File.Exists(string_1))
			{
				uint num = 0u;
				Process[] processes = Process.GetProcesses();
				int i = 0;
				while (i < processes.Length)
				{
					if (processes[i].ProcessName != string_0)
					{
						i++;
					}
					else
					{
						num = (uint)processes[i].Id;
						IL_41:
						if (num > 0u)
						{
							return (!this.method_0(num, string_1)) ? Class5.Enum0.InjectionFailed : Class5.Enum0.Success;
						}
						return Class5.Enum0.GameProcessNotFound;
					}
				}
				goto IL_41;
			}
			return Class5.Enum0.DllNotFound;
		}

		// Token: 0x0600003E RID: 62
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr OpenProcess(uint uint_0, int int_0, uint uint_1);

		// Token: 0x0600003F RID: 63
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, uint uint_0, uint uint_1);

		// Token: 0x06000040 RID: 64
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int WriteProcessMemory(IntPtr intptr_1, IntPtr intptr_2, byte[] byte_0, uint uint_0, int int_0);

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr intptr_0 = (IntPtr)0;

		// Token: 0x04000034 RID: 52
		private static Class5.Class6 class6_0;
	}
}
