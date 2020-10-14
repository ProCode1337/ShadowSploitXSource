using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ShadowSploit_X.Properties
{
	// Token: 0x0200001B RID: 27
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.1.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000A96C File Offset: 0x00008B6C
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000A980 File Offset: 0x00008B80
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Key
		{
			get
			{
				return (string)this["Key"];
			}
			set
			{
				this["Key"] = value;
			}
		}

		// Token: 0x040000BC RID: 188
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
