using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Pattern;

// Token: 0x020000B5 RID: 181
public class AndroidGoogleAnalytics : Singleton<AndroidGoogleAnalytics>
{
	// Token: 0x06000CFF RID: 3327 RVA: 0x00044588 File Offset: 0x00042788
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidGoogleAnalytics()
	{
		Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidGoogleAnalytics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr);
		AndroidGoogleAnalytics.NativeFieldInfoPtr_IsStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, "IsStarted");
		AndroidGoogleAnalytics.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664853);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_StartTracking_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664854);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SetTrackerID_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664855);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SendView_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664856);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SendView_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664857);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664858);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664859);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664860);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_Int64_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664861);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SendTiming_Public_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664862);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SendTiming_Public_Void_String_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664863);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SendTiming_Public_Void_String_Int64_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664864);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_CreateTransaction_Public_Void_String_String_Single_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664865);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_CreateItem_Public_Void_String_String_String_String_Single_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664866);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SetKey_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664867);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_ClearKey_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664868);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SetLogLevel_Public_Void_GPLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664869);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_SetDryRun_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664870);
		AndroidGoogleAnalytics.NativeMethodInfoPtr_EnableAdvertisingIdCollection_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664871);
		AndroidGoogleAnalytics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr, 100664872);
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x0004475C File Offset: 0x0004295C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176618, XrefRangeEnd = 176623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x00044790 File Offset: 0x00042990
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176624, RefRangeEnd = 176625, XrefRangeStart = 176623, XrefRangeEnd = 176624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartTracking()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_StartTracking_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x000447C4 File Offset: 0x000429C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176625, XrefRangeEnd = 176626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTrackerID(string trackingID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SetTrackerID_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x00044808 File Offset: 0x00042A08
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176627, RefRangeEnd = 176628, XrefRangeStart = 176626, XrefRangeEnd = 176627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendView(string appScreen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appScreen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SendView_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x0004484C File Offset: 0x00042A4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176628, XrefRangeEnd = 176629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SendView_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x00044880 File Offset: 0x00042A80
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176632, RefRangeEnd = 176633, XrefRangeStart = 176629, XrefRangeEnd = 176632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendEvent(string category, string action, string label)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(action);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x000448E8 File Offset: 0x00042AE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176633, XrefRangeEnd = 176635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendEvent(string category, string action, string label, long value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(action);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x0004495C File Offset: 0x00042B5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176635, XrefRangeEnd = 176638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendEvent(string category, string action, string label, string key, string val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(action);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x000449E8 File Offset: 0x00042BE8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176640, RefRangeEnd = 176641, XrefRangeStart = 176638, XrefRangeEnd = 176640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendEvent(string category, string action, string label, long value, string key, string val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(action);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_Int64_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00044A84 File Offset: 0x00042C84
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176645, RefRangeEnd = 176646, XrefRangeStart = 176641, XrefRangeEnd = 176645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendTiming(string category, long intervalInMilliseconds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intervalInMilliseconds;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SendTiming_Public_Void_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x00044AD4 File Offset: 0x00042CD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176646, XrefRangeEnd = 176650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendTiming(string category, long intervalInMilliseconds, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intervalInMilliseconds;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SendTiming_Public_Void_String_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x00044B38 File Offset: 0x00042D38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176650, XrefRangeEnd = 176652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendTiming(string category, long intervalInMilliseconds, string name, string label)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intervalInMilliseconds;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SendTiming_Public_Void_String_Int64_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x00044BB0 File Offset: 0x00042DB0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 176656, RefRangeEnd = 176658, XrefRangeStart = 176652, XrefRangeEnd = 176656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateTransaction(string transactionId, string affiliation, float revenue, float tax, float shipping, string currencyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(affiliation);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref revenue;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tax;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shipping;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currencyCode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_CreateTransaction_Public_Void_String_String_Single_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00044C44 File Offset: 0x00042E44
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 176661, RefRangeEnd = 176663, XrefRangeStart = 176658, XrefRangeEnd = 176661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateItem(string transactionId, string name, string sku, string category, float price, int quantity, string currencyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sku);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currencyCode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_CreateItem_Public_Void_String_String_String_String_Single_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x00044CEC File Offset: 0x00042EEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176664, RefRangeEnd = 176665, XrefRangeStart = 176663, XrefRangeEnd = 176664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetKey(string key, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SetKey_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x00044D40 File Offset: 0x00042F40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176665, XrefRangeEnd = 176666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearKey(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_ClearKey_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x00044D84 File Offset: 0x00042F84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176666, XrefRangeEnd = 176667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLogLevel(GPLogLevel logLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref logLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SetLogLevel_Public_Void_GPLogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x00044DC4 File Offset: 0x00042FC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176667, XrefRangeEnd = 176672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDryRun(bool mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_SetDryRun_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x00044E04 File Offset: 0x00043004
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176677, RefRangeEnd = 176678, XrefRangeStart = 176672, XrefRangeEnd = 176677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableAdvertisingIdCollection(bool mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr_EnableAdvertisingIdCollection_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x00044E44 File Offset: 0x00043044
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176678, XrefRangeEnd = 176684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidGoogleAnalytics()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidGoogleAnalytics>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGoogleAnalytics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x000073F9 File Offset: 0x000055F9
	public AndroidGoogleAnalytics(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00044E80 File Offset: 0x00043080
	// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00007402 File Offset: 0x00005602
	public unsafe bool IsStarted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidGoogleAnalytics.NativeFieldInfoPtr_IsStarted);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidGoogleAnalytics.NativeFieldInfoPtr_IsStarted)) = value;
		}
	}

	// Token: 0x04000A19 RID: 2585
	private static readonly IntPtr NativeFieldInfoPtr_IsStarted;

	// Token: 0x04000A1A RID: 2586
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000A1B RID: 2587
	private static readonly IntPtr NativeMethodInfoPtr_StartTracking_Public_Void_0;

	// Token: 0x04000A1C RID: 2588
	private static readonly IntPtr NativeMethodInfoPtr_SetTrackerID_Public_Void_String_0;

	// Token: 0x04000A1D RID: 2589
	private static readonly IntPtr NativeMethodInfoPtr_SendView_Public_Void_String_0;

	// Token: 0x04000A1E RID: 2590
	private static readonly IntPtr NativeMethodInfoPtr_SendView_Public_Void_0;

	// Token: 0x04000A1F RID: 2591
	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_0;

	// Token: 0x04000A20 RID: 2592
	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_Int64_0;

	// Token: 0x04000A21 RID: 2593
	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_String_String_0;

	// Token: 0x04000A22 RID: 2594
	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Void_String_String_String_Int64_String_String_0;

	// Token: 0x04000A23 RID: 2595
	private static readonly IntPtr NativeMethodInfoPtr_SendTiming_Public_Void_String_Int64_0;

	// Token: 0x04000A24 RID: 2596
	private static readonly IntPtr NativeMethodInfoPtr_SendTiming_Public_Void_String_Int64_String_0;

	// Token: 0x04000A25 RID: 2597
	private static readonly IntPtr NativeMethodInfoPtr_SendTiming_Public_Void_String_Int64_String_String_0;

	// Token: 0x04000A26 RID: 2598
	private static readonly IntPtr NativeMethodInfoPtr_CreateTransaction_Public_Void_String_String_Single_Single_Single_String_0;

	// Token: 0x04000A27 RID: 2599
	private static readonly IntPtr NativeMethodInfoPtr_CreateItem_Public_Void_String_String_String_String_Single_Int32_String_0;

	// Token: 0x04000A28 RID: 2600
	private static readonly IntPtr NativeMethodInfoPtr_SetKey_Public_Void_String_String_0;

	// Token: 0x04000A29 RID: 2601
	private static readonly IntPtr NativeMethodInfoPtr_ClearKey_Public_Void_String_0;

	// Token: 0x04000A2A RID: 2602
	private static readonly IntPtr NativeMethodInfoPtr_SetLogLevel_Public_Void_GPLogLevel_0;

	// Token: 0x04000A2B RID: 2603
	private static readonly IntPtr NativeMethodInfoPtr_SetDryRun_Public_Void_Boolean_0;

	// Token: 0x04000A2C RID: 2604
	private static readonly IntPtr NativeMethodInfoPtr_EnableAdvertisingIdCollection_Public_Void_Boolean_0;

	// Token: 0x04000A2D RID: 2605
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
