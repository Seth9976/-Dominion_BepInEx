using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000158 RID: 344
	public static class SteamHTMLSurface : Object
	{
		// Token: 0x06001A6F RID: 6767 RVA: 0x00077668 File Offset: 0x00075868
		// Note: this type is marked as 'beforefieldinit'.
		static SteamHTMLSurface()
		{
			Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamHTMLSurface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr);
			SteamHTMLSurface.NativeMethodInfoPtr_Init_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666779);
			SteamHTMLSurface.NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666780);
			SteamHTMLSurface.NativeMethodInfoPtr_CreateBrowser_Public_Static_SteamAPICall_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666781);
			SteamHTMLSurface.NativeMethodInfoPtr_RemoveBrowser_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666782);
			SteamHTMLSurface.NativeMethodInfoPtr_LoadURL_Public_Static_Void_HHTMLBrowser_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666783);
			SteamHTMLSurface.NativeMethodInfoPtr_SetSize_Public_Static_Void_HHTMLBrowser_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666784);
			SteamHTMLSurface.NativeMethodInfoPtr_StopLoad_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666785);
			SteamHTMLSurface.NativeMethodInfoPtr_Reload_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666786);
			SteamHTMLSurface.NativeMethodInfoPtr_GoBack_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666787);
			SteamHTMLSurface.NativeMethodInfoPtr_GoForward_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666788);
			SteamHTMLSurface.NativeMethodInfoPtr_AddHeader_Public_Static_Void_HHTMLBrowser_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666789);
			SteamHTMLSurface.NativeMethodInfoPtr_ExecuteJavascript_Public_Static_Void_HHTMLBrowser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666790);
			SteamHTMLSurface.NativeMethodInfoPtr_MouseUp_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666791);
			SteamHTMLSurface.NativeMethodInfoPtr_MouseDown_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666792);
			SteamHTMLSurface.NativeMethodInfoPtr_MouseDoubleClick_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666793);
			SteamHTMLSurface.NativeMethodInfoPtr_MouseMove_Public_Static_Void_HHTMLBrowser_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666794);
			SteamHTMLSurface.NativeMethodInfoPtr_MouseWheel_Public_Static_Void_HHTMLBrowser_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666795);
			SteamHTMLSurface.NativeMethodInfoPtr_KeyDown_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666796);
			SteamHTMLSurface.NativeMethodInfoPtr_KeyUp_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666797);
			SteamHTMLSurface.NativeMethodInfoPtr_KeyChar_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666798);
			SteamHTMLSurface.NativeMethodInfoPtr_SetHorizontalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666799);
			SteamHTMLSurface.NativeMethodInfoPtr_SetVerticalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666800);
			SteamHTMLSurface.NativeMethodInfoPtr_SetKeyFocus_Public_Static_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666801);
			SteamHTMLSurface.NativeMethodInfoPtr_ViewSource_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666802);
			SteamHTMLSurface.NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666803);
			SteamHTMLSurface.NativeMethodInfoPtr_PasteFromClipboard_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666804);
			SteamHTMLSurface.NativeMethodInfoPtr_Find_Public_Static_Void_HHTMLBrowser_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666805);
			SteamHTMLSurface.NativeMethodInfoPtr_StopFind_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666806);
			SteamHTMLSurface.NativeMethodInfoPtr_GetLinkAtPosition_Public_Static_Void_HHTMLBrowser_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666807);
			SteamHTMLSurface.NativeMethodInfoPtr_SetCookie_Public_Static_Void_String_String_String_String_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666808);
			SteamHTMLSurface.NativeMethodInfoPtr_SetPageScaleFactor_Public_Static_Void_HHTMLBrowser_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666809);
			SteamHTMLSurface.NativeMethodInfoPtr_SetBackgroundMode_Public_Static_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666810);
			SteamHTMLSurface.NativeMethodInfoPtr_SetDPIScalingFactor_Public_Static_Void_HHTMLBrowser_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666811);
			SteamHTMLSurface.NativeMethodInfoPtr_OpenDeveloperTools_Public_Static_Void_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666812);
			SteamHTMLSurface.NativeMethodInfoPtr_AllowStartRequest_Public_Static_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666813);
			SteamHTMLSurface.NativeMethodInfoPtr_JSDialogResponse_Public_Static_Void_HHTMLBrowser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666814);
			SteamHTMLSurface.NativeMethodInfoPtr_FileLoadDialogResponse_Public_Static_Void_HHTMLBrowser_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTMLSurface>.NativeClassPtr, 100666815);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0007797C File Offset: 0x00075B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198871, XrefRangeEnd = 198875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_Init_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x000779AC File Offset: 0x00075BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198875, XrefRangeEnd = 198879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x000779DC File Offset: 0x00075BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198879, XrefRangeEnd = 198902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchUserAgent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUserCSS);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_CreateBrowser_Public_Static_SteamAPICall_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00077A30 File Offset: 0x00075C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198902, XrefRangeEnd = 198906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_RemoveBrowser_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00077A64 File Offset: 0x00075C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198906, XrefRangeEnd = 198925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchURL);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPostData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_LoadURL_Public_Static_Void_HHTMLBrowser_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00077ABC File Offset: 0x00075CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198925, XrefRangeEnd = 198929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetSize_Public_Static_Void_HHTMLBrowser_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00077B0C File Offset: 0x00075D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198929, XrefRangeEnd = 198933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopLoad(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_StopLoad_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00077B40 File Offset: 0x00075D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198933, XrefRangeEnd = 198937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reload(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_Reload_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00077B74 File Offset: 0x00075D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198937, XrefRangeEnd = 198941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GoBack(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_GoBack_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00077BA8 File Offset: 0x00075DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198941, XrefRangeEnd = 198945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GoForward(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_GoForward_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00077BDC File Offset: 0x00075DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198945, XrefRangeEnd = 198964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_AddHeader_Public_Static_Void_HHTMLBrowser_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00077C34 File Offset: 0x00075E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198964, XrefRangeEnd = 198976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchScript);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_ExecuteJavascript_Public_Static_Void_HHTMLBrowser_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00077C78 File Offset: 0x00075E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198976, XrefRangeEnd = 198980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_MouseUp_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00077CB8 File Offset: 0x00075EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198980, XrefRangeEnd = 198984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_MouseDown_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00077CF8 File Offset: 0x00075EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198984, XrefRangeEnd = 198988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMouseButton;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_MouseDoubleClick_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00077D38 File Offset: 0x00075F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198988, XrefRangeEnd = 198992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_MouseMove_Public_Static_Void_HHTMLBrowser_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00077D88 File Offset: 0x00075F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198992, XrefRangeEnd = 198996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_MouseWheel_Public_Static_Void_HHTMLBrowser_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00077DC8 File Offset: 0x00075FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198996, XrefRangeEnd = 199000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNativeKeyCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsSystemKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_KeyDown_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00077E24 File Offset: 0x00076024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199000, XrefRangeEnd = 199004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nNativeKeyCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_KeyUp_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00077E74 File Offset: 0x00076074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199004, XrefRangeEnd = 199008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cUnicodeChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eHTMLKeyModifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_KeyChar_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x00077EC4 File Offset: 0x000760C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199008, XrefRangeEnd = 199012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAbsolutePixelScroll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetHorizontalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00077F04 File Offset: 0x00076104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199012, XrefRangeEnd = 199016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAbsolutePixelScroll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetVerticalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00077F44 File Offset: 0x00076144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199016, XrefRangeEnd = 199020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHasKeyFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetKeyFocus_Public_Static_Void_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00077F84 File Offset: 0x00076184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199020, XrefRangeEnd = 199024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ViewSource(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_ViewSource_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00077FB8 File Offset: 0x000761B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199024, XrefRangeEnd = 199028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00077FEC File Offset: 0x000761EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199028, XrefRangeEnd = 199032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_PasteFromClipboard_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00078020 File Offset: 0x00076220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199032, XrefRangeEnd = 199044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchSearchStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCurrentlyInFind;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReverse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_Find_Public_Static_Void_HHTMLBrowser_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00078080 File Offset: 0x00076280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199044, XrefRangeEnd = 199048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopFind(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_StopFind_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x000780B4 File Offset: 0x000762B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199048, XrefRangeEnd = 199052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_GetLinkAtPosition_Public_Static_Void_HHTMLBrowser_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00078104 File Offset: 0x00076304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199052, XrefRangeEnd = 199085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0U, bool bSecure = false, bool bHTTPOnly = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchHostname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPath);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nExpires;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSecure;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHTTPOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetCookie_Public_Static_Void_String_String_String_String_UInt32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0007819C File Offset: 0x0007639C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199085, XrefRangeEnd = 199089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flZoom;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPointX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPointY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetPageScaleFactor_Public_Static_Void_HHTMLBrowser_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000781F8 File Offset: 0x000763F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199089, XrefRangeEnd = 199093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bBackgroundMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetBackgroundMode_Public_Static_Void_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00078238 File Offset: 0x00076438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199093, XrefRangeEnd = 199097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flDPIScaling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_SetDPIScalingFactor_Public_Static_Void_HHTMLBrowser_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00078278 File Offset: 0x00076478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199097, XrefRangeEnd = 199101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenDeveloperTools(HHTMLBrowser unBrowserHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_OpenDeveloperTools_Public_Static_Void_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000782AC File Offset: 0x000764AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199101, XrefRangeEnd = 199105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_AllowStartRequest_Public_Static_Void_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000782EC File Offset: 0x000764EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199105, XrefRangeEnd = 199109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_JSDialogResponse_Public_Static_Void_HHTMLBrowser_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0007832C File Offset: 0x0007652C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199109, XrefRangeEnd = 199113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unBrowserHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchSelectedFiles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTMLSurface.NativeMethodInfoPtr_FileLoadDialogResponse_Public_Static_Void_HHTMLBrowser_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0000BA78 File Offset: 0x00009C78
		public SteamHTMLSurface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Boolean_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_CreateBrowser_Public_Static_SteamAPICall_t_String_String_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBrowser_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_LoadURL_Public_Static_Void_HHTMLBrowser_String_String_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Static_Void_HHTMLBrowser_UInt32_UInt32_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_StopLoad_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr_GoBack_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr_GoForward_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_AddHeader_Public_Static_Void_HHTMLBrowser_String_String_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteJavascript_Public_Static_Void_HHTMLBrowser_String_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr_MouseUp_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr_MouseDown_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr_MouseDoubleClick_Public_Static_Void_HHTMLBrowser_EHTMLMouseButton_0;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr_MouseMove_Public_Static_Void_HHTMLBrowser_Int32_Int32_0;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeMethodInfoPtr_MouseWheel_Public_Static_Void_HHTMLBrowser_Int32_0;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeMethodInfoPtr_KeyDown_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_Boolean_0;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeMethodInfoPtr_KeyUp_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeMethodInfoPtr_KeyChar_Public_Static_Void_HHTMLBrowser_UInt32_EHTMLKeyModifiers_0;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticalScroll_Public_Static_Void_HHTMLBrowser_UInt32_0;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyFocus_Public_Static_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr_ViewSource_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_PasteFromClipboard_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_Void_HHTMLBrowser_String_Boolean_Boolean_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_StopFind_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_GetLinkAtPosition_Public_Static_Void_HHTMLBrowser_Int32_Int32_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_SetCookie_Public_Static_Void_String_String_String_String_UInt32_Boolean_Boolean_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_SetPageScaleFactor_Public_Static_Void_HHTMLBrowser_Single_Int32_Int32_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_SetBackgroundMode_Public_Static_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_SetDPIScalingFactor_Public_Static_Void_HHTMLBrowser_Single_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_OpenDeveloperTools_Public_Static_Void_HHTMLBrowser_0;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeMethodInfoPtr_AllowStartRequest_Public_Static_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_JSDialogResponse_Public_Static_Void_HHTMLBrowser_Boolean_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_FileLoadDialogResponse_Public_Static_Void_HHTMLBrowser_IntPtr_0;
	}
}
