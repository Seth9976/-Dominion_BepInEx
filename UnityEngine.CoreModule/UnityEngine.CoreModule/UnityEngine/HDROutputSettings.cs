using System;
using Il2CppInterop.Runtime;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x020001E2 RID: 482
	public class HDROutputSettings
	{
		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x0001015B File Offset: 0x0000E35B
		public static HDROutputSettings main
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x00010168 File Offset: 0x0000E368
		public bool active
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00010175 File Offset: 0x0000E375
		public bool available
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x00010182 File Offset: 0x0000E382
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x0001018F File Offset: 0x0000E38F
		public bool automaticHDRTonemapping
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0001019C File Offset: 0x0000E39C
		public ColorGamut displayColorGamut
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x000101A9 File Offset: 0x0000E3A9
		public RenderTextureFormat format
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x000101B6 File Offset: 0x0000E3B6
		public UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x000101C3 File Offset: 0x0000E3C3
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x000101D0 File Offset: 0x0000E3D0
		public float paperWhiteNits
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x000101DD File Offset: 0x0000E3DD
		public int maxFullFrameToneMapLuminance
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x000101EA File Offset: 0x0000E3EA
		public int maxToneMapLuminance
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x000101F7 File Offset: 0x0000E3F7
		public int minToneMapLuminance
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00010204 File Offset: 0x0000E404
		public bool HDRModeChangeRequested
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00010211 File Offset: 0x0000E411
		public void RequestHDRModeChange(bool enabled)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00062DD8 File Offset: 0x00060FD8
		public static void SetPaperWhiteInNits(float paperWhite)
		{
			int num = 0;
			bool available = HDROutputSettings.GetAvailable(num);
			if (available)
			{
				HDROutputSettings.SetPaperWhiteNits(num, paperWhite);
			}
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0001021E File Offset: 0x0000E41E
		public static bool GetActive(int displayIndex)
		{
			return HDROutputSettings.GetActiveDelegateField(displayIndex);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0001022B File Offset: 0x0000E42B
		public static bool GetAvailable(int displayIndex)
		{
			return HDROutputSettings.GetAvailableDelegateField(displayIndex);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00010238 File Offset: 0x0000E438
		public static bool GetAutomaticHDRTonemapping(int displayIndex)
		{
			return HDROutputSettings.GetAutomaticHDRTonemappingDelegateField(displayIndex);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00010245 File Offset: 0x0000E445
		public static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted)
		{
			HDROutputSettings.SetAutomaticHDRTonemappingDelegateField(displayIndex, scripted);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00010253 File Offset: 0x0000E453
		public static ColorGamut GetDisplayColorGamut(int displayIndex)
		{
			return HDROutputSettings.GetDisplayColorGamutDelegateField(displayIndex);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00010260 File Offset: 0x0000E460
		public static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(int displayIndex)
		{
			return HDROutputSettings.GetGraphicsFormatDelegateField(displayIndex);
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0001026D File Offset: 0x0000E46D
		public static float GetPaperWhiteNits(int displayIndex)
		{
			return HDROutputSettings.GetPaperWhiteNitsDelegateField(displayIndex);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0001027A File Offset: 0x0000E47A
		public static void SetPaperWhiteNits(int displayIndex, float paperWhite)
		{
			HDROutputSettings.SetPaperWhiteNitsDelegateField(displayIndex, paperWhite);
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00010288 File Offset: 0x0000E488
		public static int GetMaxFullFrameToneMapLuminance(int displayIndex)
		{
			return HDROutputSettings.GetMaxFullFrameToneMapLuminanceDelegateField(displayIndex);
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00010295 File Offset: 0x0000E495
		public static int GetMaxToneMapLuminance(int displayIndex)
		{
			return HDROutputSettings.GetMaxToneMapLuminanceDelegateField(displayIndex);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x000102A2 File Offset: 0x0000E4A2
		public static int GetMinToneMapLuminance(int displayIndex)
		{
			return HDROutputSettings.GetMinToneMapLuminanceDelegateField(displayIndex);
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x000102AF File Offset: 0x0000E4AF
		public static bool GetHDRModeChangeRequested(int displayIndex)
		{
			return HDROutputSettings.GetHDRModeChangeRequestedDelegateField(displayIndex);
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x000102BC File Offset: 0x0000E4BC
		public static void RequestHDRModeChangeInternal(int displayIndex, bool enabled)
		{
			HDROutputSettings.RequestHDRModeChangeInternalDelegateField(displayIndex, enabled);
		}

		// Token: 0x040016DD RID: 5853
		private static readonly HDROutputSettings.GetActiveDelegate GetActiveDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetActiveDelegate>("UnityEngine.HDROutputSettings::GetActive");

		// Token: 0x040016DE RID: 5854
		private static readonly HDROutputSettings.GetAvailableDelegate GetAvailableDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetAvailableDelegate>("UnityEngine.HDROutputSettings::GetAvailable");

		// Token: 0x040016DF RID: 5855
		private static readonly HDROutputSettings.GetAutomaticHDRTonemappingDelegate GetAutomaticHDRTonemappingDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetAutomaticHDRTonemappingDelegate>("UnityEngine.HDROutputSettings::GetAutomaticHDRTonemapping");

		// Token: 0x040016E0 RID: 5856
		private static readonly HDROutputSettings.SetAutomaticHDRTonemappingDelegate SetAutomaticHDRTonemappingDelegateField = IL2CPP.ResolveICall<HDROutputSettings.SetAutomaticHDRTonemappingDelegate>("UnityEngine.HDROutputSettings::SetAutomaticHDRTonemapping");

		// Token: 0x040016E1 RID: 5857
		private static readonly HDROutputSettings.GetDisplayColorGamutDelegate GetDisplayColorGamutDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetDisplayColorGamutDelegate>("UnityEngine.HDROutputSettings::GetDisplayColorGamut");

		// Token: 0x040016E2 RID: 5858
		private static readonly HDROutputSettings.GetGraphicsFormatDelegate GetGraphicsFormatDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetGraphicsFormatDelegate>("UnityEngine.HDROutputSettings::GetGraphicsFormat");

		// Token: 0x040016E3 RID: 5859
		private static readonly HDROutputSettings.GetPaperWhiteNitsDelegate GetPaperWhiteNitsDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetPaperWhiteNitsDelegate>("UnityEngine.HDROutputSettings::GetPaperWhiteNits");

		// Token: 0x040016E4 RID: 5860
		private static readonly HDROutputSettings.SetPaperWhiteNitsDelegate SetPaperWhiteNitsDelegateField = IL2CPP.ResolveICall<HDROutputSettings.SetPaperWhiteNitsDelegate>("UnityEngine.HDROutputSettings::SetPaperWhiteNits");

		// Token: 0x040016E5 RID: 5861
		private static readonly HDROutputSettings.GetMaxFullFrameToneMapLuminanceDelegate GetMaxFullFrameToneMapLuminanceDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetMaxFullFrameToneMapLuminanceDelegate>("UnityEngine.HDROutputSettings::GetMaxFullFrameToneMapLuminance");

		// Token: 0x040016E6 RID: 5862
		private static readonly HDROutputSettings.GetMaxToneMapLuminanceDelegate GetMaxToneMapLuminanceDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetMaxToneMapLuminanceDelegate>("UnityEngine.HDROutputSettings::GetMaxToneMapLuminance");

		// Token: 0x040016E7 RID: 5863
		private static readonly HDROutputSettings.GetMinToneMapLuminanceDelegate GetMinToneMapLuminanceDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetMinToneMapLuminanceDelegate>("UnityEngine.HDROutputSettings::GetMinToneMapLuminance");

		// Token: 0x040016E8 RID: 5864
		private static readonly HDROutputSettings.GetHDRModeChangeRequestedDelegate GetHDRModeChangeRequestedDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetHDRModeChangeRequestedDelegate>("UnityEngine.HDROutputSettings::GetHDRModeChangeRequested");

		// Token: 0x040016E9 RID: 5865
		private static readonly HDROutputSettings.RequestHDRModeChangeInternalDelegate RequestHDRModeChangeInternalDelegateField = IL2CPP.ResolveICall<HDROutputSettings.RequestHDRModeChangeInternalDelegate>("UnityEngine.HDROutputSettings::RequestHDRModeChangeInternal");

		// Token: 0x02000AFB RID: 2811
		// (Invoke) Token: 0x060033F6 RID: 13302
		private delegate bool GetActiveDelegate(int displayIndex);

		// Token: 0x02000AFC RID: 2812
		// (Invoke) Token: 0x060033F8 RID: 13304
		private delegate bool GetAvailableDelegate(int displayIndex);

		// Token: 0x02000AFD RID: 2813
		// (Invoke) Token: 0x060033FA RID: 13306
		private delegate bool GetAutomaticHDRTonemappingDelegate(int displayIndex);

		// Token: 0x02000AFE RID: 2814
		// (Invoke) Token: 0x060033FC RID: 13308
		private delegate void SetAutomaticHDRTonemappingDelegate(int displayIndex, bool scripted);

		// Token: 0x02000AFF RID: 2815
		// (Invoke) Token: 0x060033FE RID: 13310
		private delegate ColorGamut GetDisplayColorGamutDelegate(int displayIndex);

		// Token: 0x02000B00 RID: 2816
		// (Invoke) Token: 0x06003400 RID: 13312
		private delegate UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormatDelegate(int displayIndex);

		// Token: 0x02000B01 RID: 2817
		// (Invoke) Token: 0x06003402 RID: 13314
		private delegate float GetPaperWhiteNitsDelegate(int displayIndex);

		// Token: 0x02000B02 RID: 2818
		// (Invoke) Token: 0x06003404 RID: 13316
		private delegate void SetPaperWhiteNitsDelegate(int displayIndex, float paperWhite);

		// Token: 0x02000B03 RID: 2819
		// (Invoke) Token: 0x06003406 RID: 13318
		private delegate int GetMaxFullFrameToneMapLuminanceDelegate(int displayIndex);

		// Token: 0x02000B04 RID: 2820
		// (Invoke) Token: 0x06003408 RID: 13320
		private delegate int GetMaxToneMapLuminanceDelegate(int displayIndex);

		// Token: 0x02000B05 RID: 2821
		// (Invoke) Token: 0x0600340A RID: 13322
		private delegate int GetMinToneMapLuminanceDelegate(int displayIndex);

		// Token: 0x02000B06 RID: 2822
		// (Invoke) Token: 0x0600340C RID: 13324
		private delegate bool GetHDRModeChangeRequestedDelegate(int displayIndex);

		// Token: 0x02000B07 RID: 2823
		// (Invoke) Token: 0x0600340E RID: 13326
		private delegate void RequestHDRModeChangeInternalDelegate(int displayIndex, bool enabled);
	}
}
