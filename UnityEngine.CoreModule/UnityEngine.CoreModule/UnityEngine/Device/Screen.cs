using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Device
{
	// Token: 0x020002CB RID: 715
	public static class Screen
	{
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x000144AE File Offset: 0x000126AE
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x000144B5 File Offset: 0x000126B5
		public static float brightness
		{
			get
			{
				return Screen.brightness;
			}
			set
			{
				Screen.brightness = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x000144BE File Offset: 0x000126BE
		// (set) Token: 0x06002279 RID: 8825 RVA: 0x000144C5 File Offset: 0x000126C5
		public static bool autorotateToLandscapeLeft
		{
			get
			{
				return Screen.autorotateToLandscapeLeft;
			}
			set
			{
				Screen.autorotateToLandscapeLeft = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x000144CE File Offset: 0x000126CE
		// (set) Token: 0x0600227B RID: 8827 RVA: 0x000144D5 File Offset: 0x000126D5
		public static bool autorotateToLandscapeRight
		{
			get
			{
				return Screen.autorotateToLandscapeRight;
			}
			set
			{
				Screen.autorotateToLandscapeRight = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x000144DE File Offset: 0x000126DE
		// (set) Token: 0x0600227D RID: 8829 RVA: 0x000144E5 File Offset: 0x000126E5
		public static bool autorotateToPortrait
		{
			get
			{
				return Screen.autorotateToPortrait;
			}
			set
			{
				Screen.autorotateToPortrait = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x000144EE File Offset: 0x000126EE
		// (set) Token: 0x0600227F RID: 8831 RVA: 0x000144F5 File Offset: 0x000126F5
		public static bool autorotateToPortraitUpsideDown
		{
			get
			{
				return Screen.autorotateToPortraitUpsideDown;
			}
			set
			{
				Screen.autorotateToPortraitUpsideDown = value;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x000144FE File Offset: 0x000126FE
		public static Resolution currentResolution
		{
			get
			{
				return Screen.currentResolution;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x00014505 File Offset: 0x00012705
		public static Il2CppStructArray<Rect> cutouts
		{
			get
			{
				return Screen.cutouts;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x0001450C File Offset: 0x0001270C
		public static float dpi
		{
			get
			{
				return Screen.dpi;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x00014513 File Offset: 0x00012713
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x0001451A File Offset: 0x0001271A
		public static bool fullScreen
		{
			get
			{
				return Screen.fullScreen;
			}
			set
			{
				Screen.fullScreen = value;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x00014523 File Offset: 0x00012723
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x0001452A File Offset: 0x0001272A
		public static FullScreenMode fullScreenMode
		{
			get
			{
				return Screen.fullScreenMode;
			}
			set
			{
				Screen.fullScreenMode = value;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x00014533 File Offset: 0x00012733
		public static int height
		{
			get
			{
				return Screen.height;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x0001453A File Offset: 0x0001273A
		public static int width
		{
			get
			{
				return Screen.width;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x00014541 File Offset: 0x00012741
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x00014548 File Offset: 0x00012748
		public static ScreenOrientation orientation
		{
			get
			{
				return Screen.orientation;
			}
			set
			{
				Screen.orientation = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x00014551 File Offset: 0x00012751
		public static Il2CppStructArray<Resolution> resolutions
		{
			get
			{
				return Screen.resolutions;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x00014558 File Offset: 0x00012758
		public static Rect safeArea
		{
			get
			{
				return Screen.safeArea;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x0001455F File Offset: 0x0001275F
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x00014566 File Offset: 0x00012766
		public static int sleepTimeout
		{
			get
			{
				return Screen.sleepTimeout;
			}
			set
			{
				Screen.sleepTimeout = value;
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0001456F File Offset: 0x0001276F
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate)
		{
			Screen.SetResolution(width, height, fullscreenMode, preferredRefreshRate);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0001457C File Offset: 0x0001277C
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
			Screen.SetResolution(width, height, fullscreenMode, 0);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00014589 File Offset: 0x00012789
		public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
		{
			Screen.SetResolution(width, height, fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed, preferredRefreshRate);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x0001459C File Offset: 0x0001279C
		public static void SetResolution(int width, int height, bool fullscreen)
		{
			Screen.SetResolution(width, height, fullscreen, 0);
		}
	}
}
