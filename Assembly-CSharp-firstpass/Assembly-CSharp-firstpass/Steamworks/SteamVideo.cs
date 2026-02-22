using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200016E RID: 366
	public static class SteamVideo : Object
	{
		// Token: 0x06001D00 RID: 7424 RVA: 0x0008658C File Offset: 0x0008478C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamVideo()
		{
			Il2CppClassPointerStore<SteamVideo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamVideo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr);
			SteamVideo.NativeMethodInfoPtr_GetVideoURL_Public_Static_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100667392);
			SteamVideo.NativeMethodInfoPtr_IsBroadcasting_Public_Static_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100667393);
			SteamVideo.NativeMethodInfoPtr_GetOPFSettings_Public_Static_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100667394);
			SteamVideo.NativeMethodInfoPtr_GetOPFStringForApp_Public_Static_Boolean_AppId_t_byref_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamVideo>.NativeClassPtr, 100667395);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0008660C File Offset: 0x0008480C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203272, XrefRangeEnd = 203276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetVideoURL(AppId_t unVideoAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unVideoAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_GetVideoURL_Public_Static_Void_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00086640 File Offset: 0x00084840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203276, XrefRangeEnd = 203280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBroadcasting(out int pnNumViewers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pnNumViewers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_IsBroadcasting_Public_Static_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00086680 File Offset: 0x00084880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203280, XrefRangeEnd = 203284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetOPFSettings(AppId_t unVideoAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unVideoAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_GetOPFSettings_Public_Static_Void_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000866B4 File Offset: 0x000848B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203284, XrefRangeEnd = 203296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetOPFStringForApp(AppId_t unVideoAppID, out string pchBuffer, ref int pnBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unVideoAppID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnBufferSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamVideo.NativeMethodInfoPtr_GetOPFStringForApp_Public_Static_Boolean_AppId_t_byref_String_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0000BB3E File Offset: 0x00009D3E
		public SteamVideo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_GetVideoURL_Public_Static_Void_AppId_t_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_IsBroadcasting_Public_Static_Boolean_byref_Int32_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_GetOPFSettings_Public_Static_Void_AppId_t_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_GetOPFStringForApp_Public_Static_Boolean_AppId_t_byref_String_byref_Int32_0;
	}
}
