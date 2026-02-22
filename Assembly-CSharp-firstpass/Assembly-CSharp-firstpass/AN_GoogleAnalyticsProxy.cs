using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000C1 RID: 193
public class AN_GoogleAnalyticsProxy : MonoBehaviour
{
	// Token: 0x06000E1C RID: 3612 RVA: 0x00049178 File Offset: 0x00047378
	// Note: this type is marked as 'beforefieldinit'.
	static AN_GoogleAnalyticsProxy()
	{
		Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_GoogleAnalyticsProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr);
		AN_GoogleAnalyticsProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, "CLASS_NAME");
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665067);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_StartAnalyticsTracking_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665068);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SetTrackerID_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665069);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SendView_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665070);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SendView_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665071);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665072);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665073);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SendTiming_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665074);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_CreateTransaction_Public_Static_Void_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665075);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_CreateItem_Public_Static_Void_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665076);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SetKey_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665077);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_ClearKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665078);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SetLogLevel_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665079);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SetDryRun_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665080);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_EnableAdvertisingIdCollection_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665081);
		AN_GoogleAnalyticsProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr, 100665082);
	}

	// Token: 0x06000E1D RID: 3613 RVA: 0x000492FC File Offset: 0x000474FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178265, XrefRangeEnd = 178266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallActivityFunction(string methodName, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E1E RID: 3614 RVA: 0x00049354 File Offset: 0x00047554
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178271, RefRangeEnd = 178272, XrefRangeStart = 178266, XrefRangeEnd = 178271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartAnalyticsTracking()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_StartAnalyticsTracking_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x0004937C File Offset: 0x0004757C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178278, RefRangeEnd = 178279, XrefRangeStart = 178272, XrefRangeEnd = 178278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTrackerID(string trackingID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SetTrackerID_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x000493B4 File Offset: 0x000475B4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178284, RefRangeEnd = 178285, XrefRangeStart = 178279, XrefRangeEnd = 178284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendView()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SendView_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x000493DC File Offset: 0x000475DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178291, RefRangeEnd = 178292, XrefRangeStart = 178285, XrefRangeEnd = 178291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendView(string appScreen)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appScreen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SendView_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x00049414 File Offset: 0x00047614
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178301, RefRangeEnd = 178303, XrefRangeStart = 178292, XrefRangeEnd = 178301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendEvent(string category, string action, string label, string value)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(action);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E23 RID: 3619 RVA: 0x00049480 File Offset: 0x00047680
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178314, RefRangeEnd = 178316, XrefRangeStart = 178303, XrefRangeEnd = 178314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendEvent(string category, string action, string label, string value, string key, string val)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(action);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x00049514 File Offset: 0x00047714
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 178325, RefRangeEnd = 178328, XrefRangeStart = 178316, XrefRangeEnd = 178325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendTiming(string category, string intervalInMilliseconds, string name, string label)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(intervalInMilliseconds);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SendTiming_Public_Static_Void_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x00049580 File Offset: 0x00047780
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178339, RefRangeEnd = 178340, XrefRangeStart = 178328, XrefRangeEnd = 178339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateTransaction(string transactionId, string affiliation, string revenue, string tax, string shipping, string currencyCode)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(affiliation);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(revenue);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tax);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(shipping);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currencyCode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_CreateTransaction_Public_Static_Void_String_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00049614 File Offset: 0x00047814
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178352, RefRangeEnd = 178353, XrefRangeStart = 178340, XrefRangeEnd = 178352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateItem(string transactionId, string name, string sku, string category, string price, string quantity, string currencyCode)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sku);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(price);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quantity);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currencyCode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_CreateItem_Public_Static_Void_String_String_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x000496BC File Offset: 0x000478BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178360, RefRangeEnd = 178361, XrefRangeStart = 178353, XrefRangeEnd = 178360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetKey(string key, string value)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SetKey_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x00049704 File Offset: 0x00047904
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178367, RefRangeEnd = 178368, XrefRangeStart = 178361, XrefRangeEnd = 178367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearKey(string key)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_ClearKey_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x0004973C File Offset: 0x0004793C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178375, RefRangeEnd = 178376, XrefRangeStart = 178368, XrefRangeEnd = 178375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLogLevel(int lvl)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref lvl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SetLogLevel_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00049770 File Offset: 0x00047970
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178382, RefRangeEnd = 178383, XrefRangeStart = 178376, XrefRangeEnd = 178382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDryRun(string mode)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_SetDryRun_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x000497A8 File Offset: 0x000479A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178389, RefRangeEnd = 178390, XrefRangeStart = 178383, XrefRangeEnd = 178389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableAdvertisingIdCollection(string mode)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr_EnableAdvertisingIdCollection_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x000497E0 File Offset: 0x000479E0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_GoogleAnalyticsProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_GoogleAnalyticsProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAnalyticsProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x00007657 File Offset: 0x00005857
	public static void CallActivityFunction(string methodName, params global::Il2CppSystem.Object[] args)
	{
		AN_GoogleAnalyticsProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x00007665 File Offset: 0x00005865
	public AN_GoogleAnalyticsProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x06000E2F RID: 3631 RVA: 0x0004981C File Offset: 0x00047A1C
	// (set) Token: 0x06000E30 RID: 3632 RVA: 0x0000766E File Offset: 0x0000586E
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_GoogleAnalyticsProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_GoogleAnalyticsProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000B00 RID: 2816
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000B01 RID: 2817
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000B02 RID: 2818
	private static readonly IntPtr NativeMethodInfoPtr_StartAnalyticsTracking_Public_Static_Void_0;

	// Token: 0x04000B03 RID: 2819
	private static readonly IntPtr NativeMethodInfoPtr_SetTrackerID_Public_Static_Void_String_0;

	// Token: 0x04000B04 RID: 2820
	private static readonly IntPtr NativeMethodInfoPtr_SendView_Public_Static_Void_0;

	// Token: 0x04000B05 RID: 2821
	private static readonly IntPtr NativeMethodInfoPtr_SendView_Public_Static_Void_String_0;

	// Token: 0x04000B06 RID: 2822
	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_String_String_String_0;

	// Token: 0x04000B07 RID: 2823
	private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Static_Void_String_String_String_String_String_String_0;

	// Token: 0x04000B08 RID: 2824
	private static readonly IntPtr NativeMethodInfoPtr_SendTiming_Public_Static_Void_String_String_String_String_0;

	// Token: 0x04000B09 RID: 2825
	private static readonly IntPtr NativeMethodInfoPtr_CreateTransaction_Public_Static_Void_String_String_String_String_String_String_0;

	// Token: 0x04000B0A RID: 2826
	private static readonly IntPtr NativeMethodInfoPtr_CreateItem_Public_Static_Void_String_String_String_String_String_String_String_0;

	// Token: 0x04000B0B RID: 2827
	private static readonly IntPtr NativeMethodInfoPtr_SetKey_Public_Static_Void_String_String_0;

	// Token: 0x04000B0C RID: 2828
	private static readonly IntPtr NativeMethodInfoPtr_ClearKey_Public_Static_Void_String_0;

	// Token: 0x04000B0D RID: 2829
	private static readonly IntPtr NativeMethodInfoPtr_SetLogLevel_Public_Static_Void_Int32_0;

	// Token: 0x04000B0E RID: 2830
	private static readonly IntPtr NativeMethodInfoPtr_SetDryRun_Public_Static_Void_String_0;

	// Token: 0x04000B0F RID: 2831
	private static readonly IntPtr NativeMethodInfoPtr_EnableAdvertisingIdCollection_Public_Static_Void_String_0;

	// Token: 0x04000B10 RID: 2832
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
