using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200008C RID: 140
public static class SPFacebookAnalytics : Object
{
	// Token: 0x06000A43 RID: 2627 RVA: 0x0003ADB4 File Offset: 0x00038FB4
	// Note: this type is marked as 'beforefieldinit'.
	static SPFacebookAnalytics()
	{
		Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SPFacebookAnalytics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr);
		SPFacebookAnalytics.NativeMethodInfoPtr_ActivateApp_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664551);
		SPFacebookAnalytics.NativeMethodInfoPtr_AchievedLevel_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664552);
		SPFacebookAnalytics.NativeMethodInfoPtr_AddedPaymentInfo_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664553);
		SPFacebookAnalytics.NativeMethodInfoPtr_AddedToCart_Public_Static_Void_Single_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664554);
		SPFacebookAnalytics.NativeMethodInfoPtr_AddedToWishlist_Public_Static_Void_Single_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664555);
		SPFacebookAnalytics.NativeMethodInfoPtr_CompletedRegistration_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664556);
		SPFacebookAnalytics.NativeMethodInfoPtr_CompletedTutorial_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664557);
		SPFacebookAnalytics.NativeMethodInfoPtr_InitiatedCheckout_Public_Static_Void_Single_Int32_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664558);
		SPFacebookAnalytics.NativeMethodInfoPtr_Purchased_Public_Static_Void_Single_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664559);
		SPFacebookAnalytics.NativeMethodInfoPtr_Rated_Public_Static_Void_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664560);
		SPFacebookAnalytics.NativeMethodInfoPtr_Searched_Public_Static_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664561);
		SPFacebookAnalytics.NativeMethodInfoPtr_SpentCredits_Public_Static_Void_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664562);
		SPFacebookAnalytics.NativeMethodInfoPtr_UnlockedAchievement_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664563);
		SPFacebookAnalytics.NativeMethodInfoPtr_LogEvent_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664564);
		SPFacebookAnalytics.NativeMethodInfoPtr_ViewedContent_Public_Static_Void_Single_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebookAnalytics>.NativeClassPtr, 100664565);
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x0003AF10 File Offset: 0x00039110
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ActivateApp()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_ActivateApp_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x0003AF38 File Offset: 0x00039138
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AchievedLevel(int level)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_AchievedLevel_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x0003AF6C File Offset: 0x0003916C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddedPaymentInfo(bool IsPaymentInfoAvailable)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref IsPaymentInfoAvailable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_AddedPaymentInfo_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x0003AFA0 File Offset: 0x000391A0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddedToCart(float price, string id, string type, string currency = "USD")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref price;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currency);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_AddedToCart_Public_Static_Void_Single_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x0003B008 File Offset: 0x00039208
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddedToWishlist(float price, string id, string type, string currency = "USD")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref price;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currency);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_AddedToWishlist_Public_Static_Void_Single_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x0003B070 File Offset: 0x00039270
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CompletedRegistration(string RegistrationMethod)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(RegistrationMethod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_CompletedRegistration_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x0003B0A8 File Offset: 0x000392A8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CompletedTutorial(bool IsIsSuccsessed, string ContentId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref IsIsSuccsessed;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_CompletedTutorial_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x0003B0EC File Offset: 0x000392EC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitiatedCheckout(float price, int itemsCount, string ContentType, string ContentId, bool IsPaymentInfoAvailable, string Currency = "USD")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref price;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemsCount;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentType);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentId);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsPaymentInfoAvailable;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Currency);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_InitiatedCheckout_Public_Static_Void_Single_Int32_String_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x0003B174 File Offset: 0x00039374
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Purchased(float price, int itemsCount, string ContentType, string ContentId, string Currency = "USD")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref price;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemsCount;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentType);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentId);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Currency);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_Purchased_Public_Static_Void_Single_Int32_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x0003B1EC File Offset: 0x000393EC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Rated(int Rating, string ContentType, string ContentId, int MaxRating)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref Rating;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentType);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentId);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref MaxRating;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_Rated_Public_Static_Void_Int32_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x0003B250 File Offset: 0x00039450
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Searched(string ContentType, string SearchString, bool IsIsSuccsessed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ContentType);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(SearchString);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsIsSuccsessed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_Searched_Public_Static_Void_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x0003B2A8 File Offset: 0x000394A8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SpentCredits(float credit, string ContentType, string ContentId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref credit;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentType);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_SpentCredits_Public_Static_Void_Single_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x0003B300 File Offset: 0x00039500
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnlockedAchievement(string Describtion)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(Describtion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_UnlockedAchievement_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x0003B338 File Offset: 0x00039538
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogEvent()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_LogEvent_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x0003B360 File Offset: 0x00039560
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ViewedContent(float price, string ContentType, string ContentId, string Currency = "USD")
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref price;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentType);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ContentId);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Currency);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebookAnalytics.NativeMethodInfoPtr_ViewedContent_Public_Static_Void_Single_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x0000604A File Offset: 0x0000424A
	public SPFacebookAnalytics(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000842 RID: 2114
	private static readonly IntPtr NativeMethodInfoPtr_ActivateApp_Public_Static_Void_0;

	// Token: 0x04000843 RID: 2115
	private static readonly IntPtr NativeMethodInfoPtr_AchievedLevel_Public_Static_Void_Int32_0;

	// Token: 0x04000844 RID: 2116
	private static readonly IntPtr NativeMethodInfoPtr_AddedPaymentInfo_Public_Static_Void_Boolean_0;

	// Token: 0x04000845 RID: 2117
	private static readonly IntPtr NativeMethodInfoPtr_AddedToCart_Public_Static_Void_Single_String_String_String_0;

	// Token: 0x04000846 RID: 2118
	private static readonly IntPtr NativeMethodInfoPtr_AddedToWishlist_Public_Static_Void_Single_String_String_String_0;

	// Token: 0x04000847 RID: 2119
	private static readonly IntPtr NativeMethodInfoPtr_CompletedRegistration_Public_Static_Void_String_0;

	// Token: 0x04000848 RID: 2120
	private static readonly IntPtr NativeMethodInfoPtr_CompletedTutorial_Public_Static_Void_Boolean_String_0;

	// Token: 0x04000849 RID: 2121
	private static readonly IntPtr NativeMethodInfoPtr_InitiatedCheckout_Public_Static_Void_Single_Int32_String_String_Boolean_String_0;

	// Token: 0x0400084A RID: 2122
	private static readonly IntPtr NativeMethodInfoPtr_Purchased_Public_Static_Void_Single_Int32_String_String_String_0;

	// Token: 0x0400084B RID: 2123
	private static readonly IntPtr NativeMethodInfoPtr_Rated_Public_Static_Void_Int32_String_String_Int32_0;

	// Token: 0x0400084C RID: 2124
	private static readonly IntPtr NativeMethodInfoPtr_Searched_Public_Static_Void_String_String_Boolean_0;

	// Token: 0x0400084D RID: 2125
	private static readonly IntPtr NativeMethodInfoPtr_SpentCredits_Public_Static_Void_Single_String_String_0;

	// Token: 0x0400084E RID: 2126
	private static readonly IntPtr NativeMethodInfoPtr_UnlockedAchievement_Public_Static_Void_String_0;

	// Token: 0x0400084F RID: 2127
	private static readonly IntPtr NativeMethodInfoPtr_LogEvent_Public_Static_Void_0;

	// Token: 0x04000850 RID: 2128
	private static readonly IntPtr NativeMethodInfoPtr_ViewedContent_Public_Static_Void_Single_String_String_String_0;
}
