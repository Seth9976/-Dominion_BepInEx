using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020001F1 RID: 497
	public sealed class LensFlare : Behaviour
	{
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x00011418 File Offset: 0x0000F618
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0001142A File Offset: 0x0000F62A
		public float brightness
		{
			get
			{
				return LensFlare.get_brightnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LensFlare.set_brightnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0001143D File Offset: 0x0000F63D
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0001144F File Offset: 0x0000F64F
		public float fadeSpeed
		{
			get
			{
				return LensFlare.get_fadeSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LensFlare.set_fadeSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x00064690 File Offset: 0x00062890
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x00011462 File Offset: 0x0000F662
		public Color color
		{
			get
			{
				Color color;
				this.get_color_Injected(out color);
				return color;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x000646A8 File Offset: 0x000628A8
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0001146C File Offset: 0x0000F66C
		public Flare flare
		{
			get
			{
				IntPtr intPtr = LensFlare.get_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flare>(intPtr2) : null;
			}
			set
			{
				LensFlare.set_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00011484 File Offset: 0x0000F684
		public void get_color_Injected(out Color ret)
		{
			LensFlare.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00011497 File Offset: 0x0000F697
		public void set_color_Injected(ref Color value)
		{
			LensFlare.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04001784 RID: 6020
		private static readonly LensFlare.get_brightnessDelegate get_brightnessDelegateField = IL2CPP.ResolveICall<LensFlare.get_brightnessDelegate>("UnityEngine.LensFlare::get_brightness");

		// Token: 0x04001785 RID: 6021
		private static readonly LensFlare.set_brightnessDelegate set_brightnessDelegateField = IL2CPP.ResolveICall<LensFlare.set_brightnessDelegate>("UnityEngine.LensFlare::set_brightness");

		// Token: 0x04001786 RID: 6022
		private static readonly LensFlare.get_fadeSpeedDelegate get_fadeSpeedDelegateField = IL2CPP.ResolveICall<LensFlare.get_fadeSpeedDelegate>("UnityEngine.LensFlare::get_fadeSpeed");

		// Token: 0x04001787 RID: 6023
		private static readonly LensFlare.set_fadeSpeedDelegate set_fadeSpeedDelegateField = IL2CPP.ResolveICall<LensFlare.set_fadeSpeedDelegate>("UnityEngine.LensFlare::set_fadeSpeed");

		// Token: 0x04001788 RID: 6024
		private static readonly LensFlare.get_flareDelegate get_flareDelegateField = IL2CPP.ResolveICall<LensFlare.get_flareDelegate>("UnityEngine.LensFlare::get_flare");

		// Token: 0x04001789 RID: 6025
		private static readonly LensFlare.set_flareDelegate set_flareDelegateField = IL2CPP.ResolveICall<LensFlare.set_flareDelegate>("UnityEngine.LensFlare::set_flare");

		// Token: 0x0400178A RID: 6026
		private static readonly LensFlare.get_color_InjectedDelegate get_color_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.get_color_InjectedDelegate>("UnityEngine.LensFlare::get_color_Injected");

		// Token: 0x0400178B RID: 6027
		private static readonly LensFlare.set_color_InjectedDelegate set_color_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.set_color_InjectedDelegate>("UnityEngine.LensFlare::set_color_Injected");

		// Token: 0x02000B9F RID: 2975
		// (Invoke) Token: 0x0600353C RID: 13628
		private delegate float get_brightnessDelegate(IntPtr @this);

		// Token: 0x02000BA0 RID: 2976
		// (Invoke) Token: 0x0600353E RID: 13630
		private delegate void set_brightnessDelegate(IntPtr @this, float value);

		// Token: 0x02000BA1 RID: 2977
		// (Invoke) Token: 0x06003540 RID: 13632
		private delegate float get_fadeSpeedDelegate(IntPtr @this);

		// Token: 0x02000BA2 RID: 2978
		// (Invoke) Token: 0x06003542 RID: 13634
		private delegate void set_fadeSpeedDelegate(IntPtr @this, float value);

		// Token: 0x02000BA3 RID: 2979
		// (Invoke) Token: 0x06003544 RID: 13636
		private delegate IntPtr get_flareDelegate(IntPtr @this);

		// Token: 0x02000BA4 RID: 2980
		// (Invoke) Token: 0x06003546 RID: 13638
		private delegate void set_flareDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000BA5 RID: 2981
		// (Invoke) Token: 0x06003548 RID: 13640
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000BA6 RID: 2982
		// (Invoke) Token: 0x0600354A RID: 13642
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
