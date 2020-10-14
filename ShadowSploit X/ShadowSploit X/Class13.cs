using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200001A RID: 26
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal class Class13
{
	// Token: 0x060000AE RID: 174 RVA: 0x00003038 File Offset: 0x00001238
	internal Class13()
	{
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x060000AF RID: 175 RVA: 0x0000A7FC File Offset: 0x000089FC
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class13.resourceManager_0 == null)
			{
				ResourceManager resourceManager = new ResourceManager("DDiD\"x9\\&$Nw2-plEDohbpvQA!", typeof(Class13).Assembly);
				Class13.resourceManager_0 = resourceManager;
			}
			return Class13.resourceManager_0;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000A83C File Offset: 0x00008A3C
	// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000A850 File Offset: 0x00008A50
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class13.cultureInfo_0;
		}
		set
		{
			Class13.cultureInfo_0 = value;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000A864 File Offset: 0x00008A64
	internal static Bitmap Bitmap_0
	{
		get
		{
			object @object = Class13.ResourceManager_0.GetObject("brofist", Class13.cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000A890 File Offset: 0x00008A90
	internal static Bitmap Bitmap_1
	{
		get
		{
			object @object = Class13.ResourceManager_0.GetObject("immortal-donkey-channel-pfp", Class13.cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000A8BC File Offset: 0x00008ABC
	internal static Bitmap Bitmap_2
	{
		get
		{
			object @object = Class13.ResourceManager_0.GetObject("Pfp 2", Class13.cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000A8E8 File Offset: 0x00008AE8
	internal static Bitmap Bitmap_3
	{
		get
		{
			object @object = Class13.ResourceManager_0.GetObject("Shadow1160EditedPicture", Class13.cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000A914 File Offset: 0x00008B14
	internal static Bitmap Bitmap_4
	{
		get
		{
			object @object = Class13.ResourceManager_0.GetObject("ShadowSlime", Class13.cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000A940 File Offset: 0x00008B40
	internal static Bitmap Bitmap_5
	{
		get
		{
			object @object = Class13.ResourceManager_0.GetObject("TNE's Picture", Class13.cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	// Token: 0x040000BA RID: 186
	private static ResourceManager resourceManager_0;

	// Token: 0x040000BB RID: 187
	private static CultureInfo cultureInfo_0;
}
