using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.XR
{
	// Token: 0x02000005 RID: 5
	public static class XRSettings
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002101 File Offset: 0x00000301
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000210D File Offset: 0x0000030D
		public static bool enabled
		{
			get
			{
				return XRSettings.get_enabledDelegateField();
			}
			set
			{
				XRSettings.set_enabledDelegateField(value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000211A File Offset: 0x0000031A
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002126 File Offset: 0x00000326
		public static GameViewRenderMode gameViewRenderMode
		{
			get
			{
				return XRSettings.get_gameViewRenderModeDelegateField();
			}
			set
			{
				XRSettings.set_gameViewRenderModeDelegateField(value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002133 File Offset: 0x00000333
		public static bool isDeviceActive
		{
			get
			{
				return XRSettings.get_isDeviceActiveDelegateField();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000213F File Offset: 0x0000033F
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000214B File Offset: 0x0000034B
		public static bool showDeviceView
		{
			get
			{
				return XRSettings.get_showDeviceViewDelegateField();
			}
			set
			{
				XRSettings.set_showDeviceViewDelegateField(value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002158 File Offset: 0x00000358
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002164 File Offset: 0x00000364
		public static float eyeTextureResolutionScale
		{
			get
			{
				return XRSettings.get_eyeTextureResolutionScaleDelegateField();
			}
			set
			{
				XRSettings.set_eyeTextureResolutionScaleDelegateField(value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002171 File Offset: 0x00000371
		public static int eyeTextureWidth
		{
			get
			{
				return XRSettings.get_eyeTextureWidthDelegateField();
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000217D File Offset: 0x0000037D
		public static int eyeTextureHeight
		{
			get
			{
				return XRSettings.get_eyeTextureHeightDelegateField();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002508 File Offset: 0x00000708
		public static RenderTextureDescriptor eyeTextureDesc
		{
			get
			{
				RenderTextureDescriptor renderTextureDescriptor;
				XRSettings.get_eyeTextureDesc_Injected(out renderTextureDescriptor);
				return renderTextureDescriptor;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002189 File Offset: 0x00000389
		public static TextureDimension deviceEyeTextureDimension
		{
			get
			{
				return XRSettings.get_deviceEyeTextureDimensionDelegateField();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002520 File Offset: 0x00000720
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002538 File Offset: 0x00000738
		public static float renderViewportScale
		{
			get
			{
				return XRSettings.renderViewportScaleInternal;
			}
			set
			{
				bool flag = value < 0f || value > 1f;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("value", "Render viewport scale should be between 0 and 1.");
				}
				XRSettings.renderViewportScaleInternal = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002195 File Offset: 0x00000395
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000021A1 File Offset: 0x000003A1
		public static float renderViewportScaleInternal
		{
			get
			{
				return XRSettings.get_renderViewportScaleInternalDelegateField();
			}
			set
			{
				XRSettings.set_renderViewportScaleInternalDelegateField(value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000021AE File Offset: 0x000003AE
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000021BA File Offset: 0x000003BA
		public static float occlusionMaskScale
		{
			get
			{
				return XRSettings.get_occlusionMaskScaleDelegateField();
			}
			set
			{
				XRSettings.set_occlusionMaskScaleDelegateField(value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000021C7 File Offset: 0x000003C7
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000021D3 File Offset: 0x000003D3
		public static bool useOcclusionMesh
		{
			get
			{
				return XRSettings.get_useOcclusionMeshDelegateField();
			}
			set
			{
				XRSettings.set_useOcclusionMeshDelegateField(value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002574 File Offset: 0x00000774
		public static string loadedDeviceName
		{
			get
			{
				IntPtr intPtr = XRSettings.get_loadedDeviceNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000021E0 File Offset: 0x000003E0
		public static void LoadDeviceByName(string deviceName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000021ED File Offset: 0x000003ED
		public static void LoadDeviceByName(Il2CppStringArray prioritizedDeviceNameList)
		{
			XRSettings.LoadDeviceByNameDelegateField(IL2CPP.Il2CppObjectBaseToPtr(prioritizedDeviceNameList));
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002594 File Offset: 0x00000794
		public static Il2CppStringArray supportedDevices
		{
			get
			{
				IntPtr intPtr = XRSettings.get_supportedDevicesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000021FF File Offset: 0x000003FF
		public static XRSettings.StereoRenderingMode stereoRenderingMode
		{
			get
			{
				return XRSettings.get_stereoRenderingModeDelegateField();
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000220B File Offset: 0x0000040B
		public static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret)
		{
			XRSettings.get_eyeTextureDesc_InjectedDelegateField(out ret);
		}

		// Token: 0x04000011 RID: 17
		private static readonly XRSettings.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<XRSettings.get_enabledDelegate>("UnityEngine.XR.XRSettings::get_enabled");

		// Token: 0x04000012 RID: 18
		private static readonly XRSettings.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<XRSettings.set_enabledDelegate>("UnityEngine.XR.XRSettings::set_enabled");

		// Token: 0x04000013 RID: 19
		private static readonly XRSettings.get_gameViewRenderModeDelegate get_gameViewRenderModeDelegateField = IL2CPP.ResolveICall<XRSettings.get_gameViewRenderModeDelegate>("UnityEngine.XR.XRSettings::get_gameViewRenderMode");

		// Token: 0x04000014 RID: 20
		private static readonly XRSettings.set_gameViewRenderModeDelegate set_gameViewRenderModeDelegateField = IL2CPP.ResolveICall<XRSettings.set_gameViewRenderModeDelegate>("UnityEngine.XR.XRSettings::set_gameViewRenderMode");

		// Token: 0x04000015 RID: 21
		private static readonly XRSettings.get_isDeviceActiveDelegate get_isDeviceActiveDelegateField = IL2CPP.ResolveICall<XRSettings.get_isDeviceActiveDelegate>("UnityEngine.XR.XRSettings::get_isDeviceActive");

		// Token: 0x04000016 RID: 22
		private static readonly XRSettings.get_showDeviceViewDelegate get_showDeviceViewDelegateField = IL2CPP.ResolveICall<XRSettings.get_showDeviceViewDelegate>("UnityEngine.XR.XRSettings::get_showDeviceView");

		// Token: 0x04000017 RID: 23
		private static readonly XRSettings.set_showDeviceViewDelegate set_showDeviceViewDelegateField = IL2CPP.ResolveICall<XRSettings.set_showDeviceViewDelegate>("UnityEngine.XR.XRSettings::set_showDeviceView");

		// Token: 0x04000018 RID: 24
		private static readonly XRSettings.get_eyeTextureResolutionScaleDelegate get_eyeTextureResolutionScaleDelegateField = IL2CPP.ResolveICall<XRSettings.get_eyeTextureResolutionScaleDelegate>("UnityEngine.XR.XRSettings::get_eyeTextureResolutionScale");

		// Token: 0x04000019 RID: 25
		private static readonly XRSettings.set_eyeTextureResolutionScaleDelegate set_eyeTextureResolutionScaleDelegateField = IL2CPP.ResolveICall<XRSettings.set_eyeTextureResolutionScaleDelegate>("UnityEngine.XR.XRSettings::set_eyeTextureResolutionScale");

		// Token: 0x0400001A RID: 26
		private static readonly XRSettings.get_eyeTextureWidthDelegate get_eyeTextureWidthDelegateField = IL2CPP.ResolveICall<XRSettings.get_eyeTextureWidthDelegate>("UnityEngine.XR.XRSettings::get_eyeTextureWidth");

		// Token: 0x0400001B RID: 27
		private static readonly XRSettings.get_eyeTextureHeightDelegate get_eyeTextureHeightDelegateField = IL2CPP.ResolveICall<XRSettings.get_eyeTextureHeightDelegate>("UnityEngine.XR.XRSettings::get_eyeTextureHeight");

		// Token: 0x0400001C RID: 28
		private static readonly XRSettings.get_deviceEyeTextureDimensionDelegate get_deviceEyeTextureDimensionDelegateField = IL2CPP.ResolveICall<XRSettings.get_deviceEyeTextureDimensionDelegate>("UnityEngine.XR.XRSettings::get_deviceEyeTextureDimension");

		// Token: 0x0400001D RID: 29
		private static readonly XRSettings.get_renderViewportScaleInternalDelegate get_renderViewportScaleInternalDelegateField = IL2CPP.ResolveICall<XRSettings.get_renderViewportScaleInternalDelegate>("UnityEngine.XR.XRSettings::get_renderViewportScaleInternal");

		// Token: 0x0400001E RID: 30
		private static readonly XRSettings.set_renderViewportScaleInternalDelegate set_renderViewportScaleInternalDelegateField = IL2CPP.ResolveICall<XRSettings.set_renderViewportScaleInternalDelegate>("UnityEngine.XR.XRSettings::set_renderViewportScaleInternal");

		// Token: 0x0400001F RID: 31
		private static readonly XRSettings.get_occlusionMaskScaleDelegate get_occlusionMaskScaleDelegateField = IL2CPP.ResolveICall<XRSettings.get_occlusionMaskScaleDelegate>("UnityEngine.XR.XRSettings::get_occlusionMaskScale");

		// Token: 0x04000020 RID: 32
		private static readonly XRSettings.set_occlusionMaskScaleDelegate set_occlusionMaskScaleDelegateField = IL2CPP.ResolveICall<XRSettings.set_occlusionMaskScaleDelegate>("UnityEngine.XR.XRSettings::set_occlusionMaskScale");

		// Token: 0x04000021 RID: 33
		private static readonly XRSettings.get_useOcclusionMeshDelegate get_useOcclusionMeshDelegateField = IL2CPP.ResolveICall<XRSettings.get_useOcclusionMeshDelegate>("UnityEngine.XR.XRSettings::get_useOcclusionMesh");

		// Token: 0x04000022 RID: 34
		private static readonly XRSettings.set_useOcclusionMeshDelegate set_useOcclusionMeshDelegateField = IL2CPP.ResolveICall<XRSettings.set_useOcclusionMeshDelegate>("UnityEngine.XR.XRSettings::set_useOcclusionMesh");

		// Token: 0x04000023 RID: 35
		private static readonly XRSettings.get_loadedDeviceNameDelegate get_loadedDeviceNameDelegateField = IL2CPP.ResolveICall<XRSettings.get_loadedDeviceNameDelegate>("UnityEngine.XR.XRSettings::get_loadedDeviceName");

		// Token: 0x04000024 RID: 36
		private static readonly XRSettings.LoadDeviceByNameDelegate LoadDeviceByNameDelegateField = IL2CPP.ResolveICall<XRSettings.LoadDeviceByNameDelegate>("UnityEngine.XR.XRSettings::LoadDeviceByName");

		// Token: 0x04000025 RID: 37
		private static readonly XRSettings.get_supportedDevicesDelegate get_supportedDevicesDelegateField = IL2CPP.ResolveICall<XRSettings.get_supportedDevicesDelegate>("UnityEngine.XR.XRSettings::get_supportedDevices");

		// Token: 0x04000026 RID: 38
		private static readonly XRSettings.get_stereoRenderingModeDelegate get_stereoRenderingModeDelegateField = IL2CPP.ResolveICall<XRSettings.get_stereoRenderingModeDelegate>("UnityEngine.XR.XRSettings::get_stereoRenderingMode");

		// Token: 0x04000027 RID: 39
		private static readonly XRSettings.get_eyeTextureDesc_InjectedDelegate get_eyeTextureDesc_InjectedDelegateField = IL2CPP.ResolveICall<XRSettings.get_eyeTextureDesc_InjectedDelegate>("UnityEngine.XR.XRSettings::get_eyeTextureDesc_Injected");

		// Token: 0x02000013 RID: 19
		public enum StereoRenderingMode
		{
			// Token: 0x04000036 RID: 54
			MultiPass,
			// Token: 0x04000037 RID: 55
			SinglePass,
			// Token: 0x04000038 RID: 56
			SinglePassInstanced,
			// Token: 0x04000039 RID: 57
			SinglePassMultiview
		}

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000044 RID: 68
		private delegate bool get_enabledDelegate();

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000046 RID: 70
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000048 RID: 72
		private delegate GameViewRenderMode get_gameViewRenderModeDelegate();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600004A RID: 74
		private delegate void set_gameViewRenderModeDelegate(GameViewRenderMode value);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600004C RID: 76
		private delegate bool get_isDeviceActiveDelegate();

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600004E RID: 78
		private delegate bool get_showDeviceViewDelegate();

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000050 RID: 80
		private delegate void set_showDeviceViewDelegate(bool value);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000052 RID: 82
		private delegate float get_eyeTextureResolutionScaleDelegate();

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000054 RID: 84
		private delegate void set_eyeTextureResolutionScaleDelegate(float value);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000056 RID: 86
		private delegate int get_eyeTextureWidthDelegate();

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000058 RID: 88
		private delegate int get_eyeTextureHeightDelegate();

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x0600005A RID: 90
		private delegate TextureDimension get_deviceEyeTextureDimensionDelegate();

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600005C RID: 92
		private delegate float get_renderViewportScaleInternalDelegate();

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600005E RID: 94
		private delegate void set_renderViewportScaleInternalDelegate(float value);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000060 RID: 96
		private delegate float get_occlusionMaskScaleDelegate();

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000062 RID: 98
		private delegate void set_occlusionMaskScaleDelegate(float value);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000064 RID: 100
		private delegate bool get_useOcclusionMeshDelegate();

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000066 RID: 102
		private delegate void set_useOcclusionMeshDelegate(bool value);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000068 RID: 104
		private delegate IntPtr get_loadedDeviceNameDelegate();

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600006A RID: 106
		private delegate void LoadDeviceByNameDelegate(IntPtr prioritizedDeviceNameList);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x0600006C RID: 108
		private delegate IntPtr get_supportedDevicesDelegate();

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600006E RID: 110
		private delegate XRSettings.StereoRenderingMode get_stereoRenderingModeDelegate();

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000070 RID: 112
		private delegate void get_eyeTextureDesc_InjectedDelegate([Out] IntPtr ret);
	}
}
