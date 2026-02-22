using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000169 RID: 361
	public static class SteamScreenshots : Object
	{
		// Token: 0x06001C30 RID: 7216 RVA: 0x00081938 File Offset: 0x0007FB38
		// Note: this type is marked as 'beforefieldinit'.
		static SteamScreenshots()
		{
			Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamScreenshots");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr);
			SteamScreenshots.NativeMethodInfoPtr_WriteScreenshot_Public_Static_ScreenshotHandle_Il2CppStructArray_1_Byte_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100667194);
			SteamScreenshots.NativeMethodInfoPtr_AddScreenshotToLibrary_Public_Static_ScreenshotHandle_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100667195);
			SteamScreenshots.NativeMethodInfoPtr_TriggerScreenshot_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100667196);
			SteamScreenshots.NativeMethodInfoPtr_HookScreenshots_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100667197);
			SteamScreenshots.NativeMethodInfoPtr_SetLocation_Public_Static_Boolean_ScreenshotHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100667198);
			SteamScreenshots.NativeMethodInfoPtr_TagUser_Public_Static_Boolean_ScreenshotHandle_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100667199);
			SteamScreenshots.NativeMethodInfoPtr_TagPublishedFile_Public_Static_Boolean_ScreenshotHandle_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100667200);
			SteamScreenshots.NativeMethodInfoPtr_IsScreenshotsHooked_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100667201);
			SteamScreenshots.NativeMethodInfoPtr_AddVRScreenshotToLibrary_Public_Static_ScreenshotHandle_EVRScreenshotType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100667202);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00081A1C File Offset: 0x0007FC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201688, XrefRangeEnd = 201696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenshotHandle WriteScreenshot(Il2CppStructArray<byte> pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pubRGB);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubRGB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_WriteScreenshot_Public_Static_ScreenshotHandle_Il2CppStructArray_1_Byte_UInt32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00081A88 File Offset: 0x0007FC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201696, XrefRangeEnd = 201719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFilename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchThumbnailFilename);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_AddScreenshotToLibrary_Public_Static_ScreenshotHandle_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00081AF8 File Offset: 0x0007FCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201719, XrefRangeEnd = 201723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerScreenshot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_TriggerScreenshot_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00081B20 File Offset: 0x0007FD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201723, XrefRangeEnd = 201727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HookScreenshots(bool bHook)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bHook;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_HookScreenshots_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00081B54 File Offset: 0x0007FD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201727, XrefRangeEnd = 201739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hScreenshot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_SetLocation_Public_Static_Boolean_ScreenshotHandle_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00081BA4 File Offset: 0x0007FDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201739, XrefRangeEnd = 201743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hScreenshot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_TagUser_Public_Static_Boolean_ScreenshotHandle_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00081BF0 File Offset: 0x0007FDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201743, XrefRangeEnd = 201747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hScreenshot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPublishedFileID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_TagPublishedFile_Public_Static_Boolean_ScreenshotHandle_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00081C3C File Offset: 0x0007FE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201747, XrefRangeEnd = 201751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsScreenshotsHooked()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_IsScreenshotsHooked_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00081C6C File Offset: 0x0007FE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201751, XrefRangeEnd = 201774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFilename);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVRFilename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_AddVRScreenshotToLibrary_Public_Static_ScreenshotHandle_EVRScreenshotType_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0000BB11 File Offset: 0x00009D11
		public SteamScreenshots(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeMethodInfoPtr_WriteScreenshot_Public_Static_ScreenshotHandle_Il2CppStructArray_1_Byte_UInt32_Int32_Int32_0;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeMethodInfoPtr_AddScreenshotToLibrary_Public_Static_ScreenshotHandle_String_String_Int32_Int32_0;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeMethodInfoPtr_TriggerScreenshot_Public_Static_Void_0;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeMethodInfoPtr_HookScreenshots_Public_Static_Void_Boolean_0;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeMethodInfoPtr_SetLocation_Public_Static_Boolean_ScreenshotHandle_String_0;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_TagUser_Public_Static_Boolean_ScreenshotHandle_CSteamID_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_TagPublishedFile_Public_Static_Boolean_ScreenshotHandle_PublishedFileId_t_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr_IsScreenshotsHooked_Public_Static_Boolean_0;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeMethodInfoPtr_AddVRScreenshotToLibrary_Public_Static_ScreenshotHandle_EVRScreenshotType_String_String_0;
	}
}
