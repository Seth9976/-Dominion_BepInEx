using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000148 RID: 328
	public static class SteamAppList : Object
	{
		// Token: 0x06001823 RID: 6179 RVA: 0x0006A0AC File Offset: 0x000682AC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAppList()
		{
			Il2CppClassPointerStore<SteamAppList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAppList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr);
			SteamAppList.NativeMethodInfoPtr_GetNumInstalledApps_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr, 100666223);
			SteamAppList.NativeMethodInfoPtr_GetInstalledApps_Public_Static_UInt32_Il2CppStructArray_1_AppId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr, 100666224);
			SteamAppList.NativeMethodInfoPtr_GetAppName_Public_Static_Int32_AppId_t_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr, 100666225);
			SteamAppList.NativeMethodInfoPtr_GetAppInstallDir_Public_Static_Int32_AppId_t_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr, 100666226);
			SteamAppList.NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr, 100666227);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0006A140 File Offset: 0x00068340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194897, XrefRangeEnd = 194901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetNumInstalledApps()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAppList.NativeMethodInfoPtr_GetNumInstalledApps_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0006A170 File Offset: 0x00068370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194901, XrefRangeEnd = 194905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetInstalledApps(Il2CppStructArray<AppId_t> pvecAppID, uint unMaxAppIDs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pvecAppID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unMaxAppIDs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAppList.NativeMethodInfoPtr_GetInstalledApps_Public_Static_UInt32_Il2CppStructArray_1_AppId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0006A1C0 File Offset: 0x000683C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194905, XrefRangeEnd = 194917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchNameMax;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamAppList.NativeMethodInfoPtr_GetAppName_Public_Static_Int32_AppId_t_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0006A228 File Offset: 0x00068428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194917, XrefRangeEnd = 194929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchNameMax;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamAppList.NativeMethodInfoPtr_GetAppInstallDir_Public_Static_Int32_AppId_t_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchDirectory = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0006A290 File Offset: 0x00068490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194929, XrefRangeEnd = 194933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAppBuildId(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAppList.NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		public SteamAppList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_GetNumInstalledApps_Public_Static_UInt32_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_GetInstalledApps_Public_Static_UInt32_Il2CppStructArray_1_AppId_t_UInt32_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_GetAppName_Public_Static_Int32_AppId_t_byref_String_Int32_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_GetAppInstallDir_Public_Static_Int32_AppId_t_byref_String_Int32_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_AppId_t_0;
	}
}
