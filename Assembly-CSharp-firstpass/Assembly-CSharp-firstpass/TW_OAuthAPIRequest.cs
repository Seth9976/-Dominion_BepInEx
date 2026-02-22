using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x020000B1 RID: 177
public class TW_OAuthAPIRequest : MonoBehaviour
{
	// Token: 0x06000CD6 RID: 3286 RVA: 0x00043C64 File Offset: 0x00041E64
	// Note: this type is marked as 'beforefieldinit'.
	static TW_OAuthAPIRequest()
	{
		Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TW_OAuthAPIRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr);
		TW_OAuthAPIRequest.NativeFieldInfoPtr_OnResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, "OnResult");
		TW_OAuthAPIRequest.NativeFieldInfoPtr_IsFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, "IsFirst");
		TW_OAuthAPIRequest.NativeFieldInfoPtr_GetParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, "GetParams");
		TW_OAuthAPIRequest.NativeFieldInfoPtr_requestUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, "requestUrl");
		TW_OAuthAPIRequest.NativeFieldInfoPtr_Headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, "Headers");
		TW_OAuthAPIRequest.NativeFieldInfoPtr_requestParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, "requestParams");
		TW_OAuthAPIRequest.NativeMethodInfoPtr_add_OnResult_Public_add_Void_Action_1_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, 100664832);
		TW_OAuthAPIRequest.NativeMethodInfoPtr_remove_OnResult_Public_rem_Void_Action_1_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, 100664833);
		TW_OAuthAPIRequest.NativeMethodInfoPtr_Create_Public_Static_TW_OAuthAPIRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, 100664834);
		TW_OAuthAPIRequest.NativeMethodInfoPtr_Send_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, 100664835);
		TW_OAuthAPIRequest.NativeMethodInfoPtr_AddParam_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, 100664836);
		TW_OAuthAPIRequest.NativeMethodInfoPtr_AddParam_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, 100664837);
		TW_OAuthAPIRequest.NativeMethodInfoPtr_SetUrl_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, 100664838);
		TW_OAuthAPIRequest.NativeMethodInfoPtr_Request_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, 100664839);
		TW_OAuthAPIRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, 100664840);
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x00043DC0 File Offset: 0x00041FC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176203, RefRangeEnd = 176204, XrefRangeStart = 176199, XrefRangeEnd = 176203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnResult(Action<TW_APIRequstResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.NativeMethodInfoPtr_add_OnResult_Public_add_Void_Action_1_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x00043E04 File Offset: 0x00042004
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176204, XrefRangeEnd = 176208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnResult(Action<TW_APIRequstResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.NativeMethodInfoPtr_remove_OnResult_Public_rem_Void_Action_1_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x00043E48 File Offset: 0x00042048
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176218, RefRangeEnd = 176219, XrefRangeStart = 176208, XrefRangeEnd = 176218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TW_OAuthAPIRequest Create()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.NativeMethodInfoPtr_Create_Public_Static_TW_OAuthAPIRequest_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TW_OAuthAPIRequest>(intPtr3) : null;
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x00043E7C File Offset: 0x0004207C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176225, RefRangeEnd = 176226, XrefRangeStart = 176219, XrefRangeEnd = 176225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Send(string url)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.NativeMethodInfoPtr_Send_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x00043EC0 File Offset: 0x000420C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176226, XrefRangeEnd = 176238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddParam(string name, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.NativeMethodInfoPtr_AddParam_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x00043F10 File Offset: 0x00042110
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176238, XrefRangeEnd = 176250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddParam(string name, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.NativeMethodInfoPtr_AddParam_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x00043F64 File Offset: 0x00042164
	[CallerCount(0)]
	public unsafe void SetUrl(string url)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.NativeMethodInfoPtr_SetUrl_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x00043FA8 File Offset: 0x000421A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176250, XrefRangeEnd = 176254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Request()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.NativeMethodInfoPtr_Request_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x00043FE8 File Offset: 0x000421E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176254, XrefRangeEnd = 176285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TW_OAuthAPIRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x0000731F File Offset: 0x0000551F
	public TW_OAuthAPIRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00044024 File Offset: 0x00042224
	// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x00007328 File Offset: 0x00005528
	public unsafe Action<TW_APIRequstResult> OnResult
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_OnResult);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TW_APIRequstResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_OnResult), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000421 RID: 1057
	// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00044054 File Offset: 0x00042254
	// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00007347 File Offset: 0x00005547
	public unsafe bool IsFirst
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_IsFirst);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_IsFirst)) = value;
		}
	}

	// Token: 0x17000422 RID: 1058
	// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0004407C File Offset: 0x0004227C
	// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00007362 File Offset: 0x00005562
	public unsafe string GetParams
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_GetParams);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_GetParams), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000423 RID: 1059
	// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x000440A4 File Offset: 0x000422A4
	// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00007381 File Offset: 0x00005581
	public unsafe string requestUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_requestUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_requestUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000424 RID: 1060
	// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x000440CC File Offset: 0x000422CC
	// (set) Token: 0x06000CEA RID: 3306 RVA: 0x000073A0 File Offset: 0x000055A0
	public unsafe Dictionary<string, string> Headers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_Headers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_Headers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000440FC File Offset: 0x000422FC
	// (set) Token: 0x06000CEC RID: 3308 RVA: 0x000073BF File Offset: 0x000055BF
	public unsafe SortedDictionary<string, string> requestParams
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_requestParams);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest.NativeFieldInfoPtr_requestParams), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040009FE RID: 2558
	private static readonly IntPtr NativeFieldInfoPtr_OnResult;

	// Token: 0x040009FF RID: 2559
	private static readonly IntPtr NativeFieldInfoPtr_IsFirst;

	// Token: 0x04000A00 RID: 2560
	private static readonly IntPtr NativeFieldInfoPtr_GetParams;

	// Token: 0x04000A01 RID: 2561
	private static readonly IntPtr NativeFieldInfoPtr_requestUrl;

	// Token: 0x04000A02 RID: 2562
	private static readonly IntPtr NativeFieldInfoPtr_Headers;

	// Token: 0x04000A03 RID: 2563
	private static readonly IntPtr NativeFieldInfoPtr_requestParams;

	// Token: 0x04000A04 RID: 2564
	private static readonly IntPtr NativeMethodInfoPtr_add_OnResult_Public_add_Void_Action_1_TW_APIRequstResult_0;

	// Token: 0x04000A05 RID: 2565
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnResult_Public_rem_Void_Action_1_TW_APIRequstResult_0;

	// Token: 0x04000A06 RID: 2566
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TW_OAuthAPIRequest_0;

	// Token: 0x04000A07 RID: 2567
	private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Void_String_0;

	// Token: 0x04000A08 RID: 2568
	private static readonly IntPtr NativeMethodInfoPtr_AddParam_Public_Void_String_Int32_0;

	// Token: 0x04000A09 RID: 2569
	private static readonly IntPtr NativeMethodInfoPtr_AddParam_Public_Void_String_String_0;

	// Token: 0x04000A0A RID: 2570
	private static readonly IntPtr NativeMethodInfoPtr_SetUrl_Protected_Void_String_0;

	// Token: 0x04000A0B RID: 2571
	private static readonly IntPtr NativeMethodInfoPtr_Request_Private_IEnumerator_0;

	// Token: 0x04000A0C RID: 2572
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000389 RID: 905
	[ObfuscatedName("TW_OAuthAPIRequest+<Request>d__13")]
	public sealed class _Request_d__13 : global::Il2CppSystem.Object
	{
		// Token: 0x060035EA RID: 13802 RVA: 0x000DDCD0 File Offset: 0x000DBED0
		// Note: this type is marked as 'beforefieldinit'.
		static _Request_d__13()
		{
			Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, "<Request>d__13");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr);
			TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr, "<>1__state");
			TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr, "<>2__current");
			TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr, "<>4__this");
			TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr__www_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr, "<www>5__2");
			TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr, 100670166);
			TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr, 100670167);
			TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr, 100670168);
			TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr, 100670169);
			TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr, 100670170);
			TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr, 100670171);
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x000DDDC4 File Offset: 0x000DBFC4
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Request_d__13(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_OAuthAPIRequest._Request_d__13>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x000DDE0C File Offset: 0x000DC00C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x000DDE40 File Offset: 0x000DC040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175993, XrefRangeEnd = 176194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060035EE RID: 13806 RVA: 0x000DDE7C File Offset: 0x000DC07C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x000DDEBC File Offset: 0x000DC0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176194, XrefRangeEnd = 176199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060035F0 RID: 13808 RVA: 0x000DDEF0 File Offset: 0x000DC0F0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest._Request_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x00014E3E File Offset: 0x0001303E
		public _Request_d__13(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x000DDF30 File Offset: 0x000DC130
		// (set) Token: 0x060035F3 RID: 13811 RVA: 0x00014E47 File Offset: 0x00013047
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x000DDF58 File Offset: 0x000DC158
		// (set) Token: 0x060035F5 RID: 13813 RVA: 0x00014E62 File Offset: 0x00013062
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x000DDF88 File Offset: 0x000DC188
		// (set) Token: 0x060035F7 RID: 13815 RVA: 0x00014E81 File Offset: 0x00013081
		public unsafe TW_OAuthAPIRequest __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TW_OAuthAPIRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x000DDFB8 File Offset: 0x000DC1B8
		// (set) Token: 0x060035F9 RID: 13817 RVA: 0x00014EA0 File Offset: 0x000130A0
		public unsafe WWW _www_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr__www_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_OAuthAPIRequest._Request_d__13.NativeFieldInfoPtr__www_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400317C RID: 12668
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400317D RID: 12669
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400317E RID: 12670
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400317F RID: 12671
		private static readonly IntPtr NativeFieldInfoPtr__www_5__2;

		// Token: 0x04003180 RID: 12672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003181 RID: 12673
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003182 RID: 12674
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04003183 RID: 12675
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003184 RID: 12676
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003185 RID: 12677
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200038A RID: 906
	[ObfuscatedName("TW_OAuthAPIRequest+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060035FA RID: 13818 RVA: 0x000DDFE8 File Offset: 0x000DC1E8
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<TW_OAuthAPIRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TW_OAuthAPIRequest>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_OAuthAPIRequest.__c>.NativeClassPtr);
			TW_OAuthAPIRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest.__c>.NativeClassPtr, "<>9");
			TW_OAuthAPIRequest.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_OAuthAPIRequest.__c>.NativeClassPtr, "<>9__14_0");
			TW_OAuthAPIRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest.__c>.NativeClassPtr, 100670173);
			TW_OAuthAPIRequest.__c.NativeMethodInfoPtr___ctor_b__14_0_Internal_Void_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_OAuthAPIRequest.__c>.NativeClassPtr, 100670174);
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x000DE064 File Offset: 0x000DC264
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_OAuthAPIRequest.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x000DE0A0 File Offset: 0x000DC2A0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_0(TW_APIRequstResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_OAuthAPIRequest.__c.NativeMethodInfoPtr___ctor_b__14_0_Internal_Void_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x00014EBF File Offset: 0x000130BF
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x000DE0E4 File Offset: 0x000DC2E4
		// (set) Token: 0x060035FF RID: 13823 RVA: 0x00014EC8 File Offset: 0x000130C8
		public unsafe static TW_OAuthAPIRequest.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TW_OAuthAPIRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TW_OAuthAPIRequest.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TW_OAuthAPIRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06003600 RID: 13824 RVA: 0x000DE10C File Offset: 0x000DC30C
		// (set) Token: 0x06003601 RID: 13825 RVA: 0x00014EDA File Offset: 0x000130DA
		public unsafe static Action<TW_APIRequstResult> __9__14_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TW_OAuthAPIRequest.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TW_APIRequstResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TW_OAuthAPIRequest.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003186 RID: 12678
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003187 RID: 12679
		private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

		// Token: 0x04003188 RID: 12680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003189 RID: 12681
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Internal_Void_TW_APIRequstResult_0;
	}
}
