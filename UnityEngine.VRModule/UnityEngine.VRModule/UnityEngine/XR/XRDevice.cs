using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000002 RID: 2
	public static class XRDevice : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002270 File Offset: 0x00000470
		// Note: this type is marked as 'beforefieldinit'.
		static XRDevice()
		{
			Il2CppClassPointerStore<XRDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VRModule.dll", "UnityEngine.XR", "XRDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDevice>.NativeClassPtr);
			XRDevice.NativeFieldInfoPtr_deviceLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDevice>.NativeClassPtr, "deviceLoaded");
			XRDevice.NativeMethodInfoPtr_InvokeDeviceLoaded_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDevice>.NativeClassPtr, 100663297);
			XRDevice.get_refreshRateDelegateField = IL2CPP.ResolveICall<XRDevice.get_refreshRateDelegate>("UnityEngine.XR.XRDevice::get_refreshRate");
			XRDevice.GetNativePtrDelegateField = IL2CPP.ResolveICall<XRDevice.GetNativePtrDelegate>("UnityEngine.XR.XRDevice::GetNativePtr");
			XRDevice.GetTrackingSpaceTypeDelegateField = IL2CPP.ResolveICall<XRDevice.GetTrackingSpaceTypeDelegate>("UnityEngine.XR.XRDevice::GetTrackingSpaceType");
			XRDevice.SetTrackingSpaceTypeDelegateField = IL2CPP.ResolveICall<XRDevice.SetTrackingSpaceTypeDelegate>("UnityEngine.XR.XRDevice::SetTrackingSpaceType");
			XRDevice.DisableAutoXRCameraTrackingDelegateField = IL2CPP.ResolveICall<XRDevice.DisableAutoXRCameraTrackingDelegate>("UnityEngine.XR.XRDevice::DisableAutoXRCameraTracking");
			XRDevice.UpdateEyeTextureMSAASettingDelegateField = IL2CPP.ResolveICall<XRDevice.UpdateEyeTextureMSAASettingDelegate>("UnityEngine.XR.XRDevice::UpdateEyeTextureMSAASetting");
			XRDevice.get_fovZoomFactorDelegateField = IL2CPP.ResolveICall<XRDevice.get_fovZoomFactorDelegate>("UnityEngine.XR.XRDevice::get_fovZoomFactor");
			XRDevice.set_fovZoomFactorDelegateField = IL2CPP.ResolveICall<XRDevice.set_fovZoomFactorDelegate>("UnityEngine.XR.XRDevice::set_fovZoomFactor");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002340 File Offset: 0x00000540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158223, XrefRangeEnd = 158232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeDeviceLoaded(string loadedDeviceName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(loadedDeviceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDevice.NativeMethodInfoPtr_InvokeDeviceLoaded_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public XRDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002378 File Offset: 0x00000578
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static Action<string> deviceLoaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRDevice.NativeFieldInfoPtr_deviceLoaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRDevice.NativeFieldInfoPtr_deviceLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000206B File Offset: 0x0000026B
		public static bool isPresent
		{
			get
			{
				throw new NotSupportedException("XRDevice is Obsolete. Instead, find the active XRDisplaySubsystem and check to see if it is running.");
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002078 File Offset: 0x00000278
		public static float refreshRate
		{
			get
			{
				return XRDevice.get_refreshRateDelegateField();
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002084 File Offset: 0x00000284
		public static IntPtr GetNativePtr()
		{
			return XRDevice.GetNativePtrDelegateField();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002090 File Offset: 0x00000290
		public static TrackingSpaceType GetTrackingSpaceType()
		{
			return XRDevice.GetTrackingSpaceTypeDelegateField();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000209C File Offset: 0x0000029C
		public static bool SetTrackingSpaceType(TrackingSpaceType trackingSpaceType)
		{
			return XRDevice.SetTrackingSpaceTypeDelegateField(trackingSpaceType);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020A9 File Offset: 0x000002A9
		public static void DisableAutoXRCameraTracking(Camera camera, bool disabled)
		{
			XRDevice.DisableAutoXRCameraTrackingDelegateField(IL2CPP.Il2CppObjectBaseToPtr(camera), disabled);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020BC File Offset: 0x000002BC
		public static void UpdateEyeTextureMSAASetting()
		{
			XRDevice.UpdateEyeTextureMSAASettingDelegateField();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020C8 File Offset: 0x000002C8
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020D4 File Offset: 0x000002D4
		public static float fovZoomFactor
		{
			get
			{
				return XRDevice.get_fovZoomFactorDelegateField();
			}
			set
			{
				XRDevice.set_fovZoomFactorDelegateField(value);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020E1 File Offset: 0x000002E1
		public static void add_deviceLoaded(Action<string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020EE File Offset: 0x000002EE
		public static void remove_deviceLoaded(Action<string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_deviceLoaded;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDeviceLoaded_Private_Static_Void_String_0;

		// Token: 0x04000003 RID: 3
		private static readonly XRDevice.get_refreshRateDelegate get_refreshRateDelegateField;

		// Token: 0x04000004 RID: 4
		private static readonly XRDevice.GetNativePtrDelegate GetNativePtrDelegateField;

		// Token: 0x04000005 RID: 5
		private static readonly XRDevice.GetTrackingSpaceTypeDelegate GetTrackingSpaceTypeDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly XRDevice.SetTrackingSpaceTypeDelegate SetTrackingSpaceTypeDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly XRDevice.DisableAutoXRCameraTrackingDelegate DisableAutoXRCameraTrackingDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly XRDevice.UpdateEyeTextureMSAASettingDelegate UpdateEyeTextureMSAASettingDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly XRDevice.get_fovZoomFactorDelegate get_fovZoomFactorDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly XRDevice.set_fovZoomFactorDelegate set_fovZoomFactorDelegateField;

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000034 RID: 52
		private delegate float get_refreshRateDelegate();

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000036 RID: 54
		private delegate IntPtr GetNativePtrDelegate();

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000038 RID: 56
		private delegate TrackingSpaceType GetTrackingSpaceTypeDelegate();

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600003A RID: 58
		private delegate bool SetTrackingSpaceTypeDelegate(TrackingSpaceType trackingSpaceType);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600003C RID: 60
		private delegate void DisableAutoXRCameraTrackingDelegate(IntPtr camera, bool disabled);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600003E RID: 62
		private delegate void UpdateEyeTextureMSAASettingDelegate();

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000040 RID: 64
		private delegate float get_fovZoomFactorDelegate();

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000042 RID: 66
		private delegate void set_fovZoomFactorDelegate(float value);
	}
}
