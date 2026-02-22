using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x020000AE RID: 174
public class TW_APIRequest : MonoBehaviour
{
	// Token: 0x06000CB3 RID: 3251 RVA: 0x0004344C File Offset: 0x0004164C
	// Note: this type is marked as 'beforefieldinit'.
	static TW_APIRequest()
	{
		Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TW_APIRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr);
		TW_APIRequest.NativeFieldInfoPtr_ActionComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, "ActionComplete");
		TW_APIRequest.NativeFieldInfoPtr_IsFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, "IsFirst");
		TW_APIRequest.NativeFieldInfoPtr_GetParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, "GetParams");
		TW_APIRequest.NativeFieldInfoPtr_requestUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, "requestUrl");
		TW_APIRequest.NativeFieldInfoPtr_Headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, "Headers");
		TW_APIRequest.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_1_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664813);
		TW_APIRequest.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_1_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664814);
		TW_APIRequest.NativeMethodInfoPtr_Send_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664815);
		TW_APIRequest.NativeMethodInfoPtr_AddParam_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664816);
		TW_APIRequest.NativeMethodInfoPtr_AddParam_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664817);
		TW_APIRequest.NativeMethodInfoPtr_SendCompleteResult_Protected_Void_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664818);
		TW_APIRequest.NativeMethodInfoPtr_SetUrl_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664819);
		TW_APIRequest.NativeMethodInfoPtr_Request_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664820);
		TW_APIRequest.NativeMethodInfoPtr_OnResult_Protected_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664821);
		TW_APIRequest.NativeMethodInfoPtr_OnTokenLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664822);
		TW_APIRequest.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, 100664823);
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x000435BC File Offset: 0x000417BC
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 175755, RefRangeEnd = 175760, XrefRangeStart = 175751, XrefRangeEnd = 175755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionComplete(Action<TW_APIRequstResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_1_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x00043600 File Offset: 0x00041800
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175760, XrefRangeEnd = 175764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionComplete(Action<TW_APIRequstResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_1_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x00043644 File Offset: 0x00041844
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 175791, RefRangeEnd = 175796, XrefRangeStart = 175764, XrefRangeEnd = 175791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Send()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.NativeMethodInfoPtr_Send_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00043678 File Offset: 0x00041878
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175796, XrefRangeEnd = 175805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.NativeMethodInfoPtr_AddParam_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x000436C8 File Offset: 0x000418C8
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 175813, RefRangeEnd = 175820, XrefRangeStart = 175805, XrefRangeEnd = 175813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.NativeMethodInfoPtr_AddParam_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x0004371C File Offset: 0x0004191C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 175824, RefRangeEnd = 175825, XrefRangeStart = 175820, XrefRangeEnd = 175824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendCompleteResult(TW_APIRequstResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.NativeMethodInfoPtr_SendCompleteResult_Protected_Void_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x00043760 File Offset: 0x00041960
	[CallerCount(0)]
	public unsafe void SetUrl(string url)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.NativeMethodInfoPtr_SetUrl_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x000437A4 File Offset: 0x000419A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175825, XrefRangeEnd = 175829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Request()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.NativeMethodInfoPtr_Request_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x000437E4 File Offset: 0x000419E4
	[CallerCount(0)]
	public unsafe virtual void OnResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TW_APIRequest.NativeMethodInfoPtr_OnResult_Protected_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00043834 File Offset: 0x00041A34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175829, XrefRangeEnd = 175860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTokenLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.NativeMethodInfoPtr_OnTokenLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00043868 File Offset: 0x00041A68
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 175885, RefRangeEnd = 175890, XrefRangeStart = 175860, XrefRangeEnd = 175885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TW_APIRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x0000726D File Offset: 0x0000546D
	public TW_APIRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700041B RID: 1051
	// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x000438A4 File Offset: 0x00041AA4
	// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00007276 File Offset: 0x00005476
	public unsafe Action<TW_APIRequstResult> ActionComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest.NativeFieldInfoPtr_ActionComplete);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TW_APIRequstResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest.NativeFieldInfoPtr_ActionComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x000438D4 File Offset: 0x00041AD4
	// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00007295 File Offset: 0x00005495
	public unsafe bool IsFirst
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest.NativeFieldInfoPtr_IsFirst);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest.NativeFieldInfoPtr_IsFirst)) = value;
		}
	}

	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x000438FC File Offset: 0x00041AFC
	// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x000072B0 File Offset: 0x000054B0
	public unsafe string GetParams
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest.NativeFieldInfoPtr_GetParams);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest.NativeFieldInfoPtr_GetParams), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700041E RID: 1054
	// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00043924 File Offset: 0x00041B24
	// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x000072CF File Offset: 0x000054CF
	public unsafe string requestUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest.NativeFieldInfoPtr_requestUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest.NativeFieldInfoPtr_requestUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700041F RID: 1055
	// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0004394C File Offset: 0x00041B4C
	// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x000072EE File Offset: 0x000054EE
	public unsafe Dictionary<string, string> Headers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest.NativeFieldInfoPtr_Headers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest.NativeFieldInfoPtr_Headers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040009E6 RID: 2534
	private static readonly IntPtr NativeFieldInfoPtr_ActionComplete;

	// Token: 0x040009E7 RID: 2535
	private static readonly IntPtr NativeFieldInfoPtr_IsFirst;

	// Token: 0x040009E8 RID: 2536
	private static readonly IntPtr NativeFieldInfoPtr_GetParams;

	// Token: 0x040009E9 RID: 2537
	private static readonly IntPtr NativeFieldInfoPtr_requestUrl;

	// Token: 0x040009EA RID: 2538
	private static readonly IntPtr NativeFieldInfoPtr_Headers;

	// Token: 0x040009EB RID: 2539
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_1_TW_APIRequstResult_0;

	// Token: 0x040009EC RID: 2540
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_1_TW_APIRequstResult_0;

	// Token: 0x040009ED RID: 2541
	private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Void_0;

	// Token: 0x040009EE RID: 2542
	private static readonly IntPtr NativeMethodInfoPtr_AddParam_Public_Void_String_Int32_0;

	// Token: 0x040009EF RID: 2543
	private static readonly IntPtr NativeMethodInfoPtr_AddParam_Public_Void_String_String_0;

	// Token: 0x040009F0 RID: 2544
	private static readonly IntPtr NativeMethodInfoPtr_SendCompleteResult_Protected_Void_TW_APIRequstResult_0;

	// Token: 0x040009F1 RID: 2545
	private static readonly IntPtr NativeMethodInfoPtr_SetUrl_Protected_Void_String_0;

	// Token: 0x040009F2 RID: 2546
	private static readonly IntPtr NativeMethodInfoPtr_Request_Private_IEnumerator_0;

	// Token: 0x040009F3 RID: 2547
	private static readonly IntPtr NativeMethodInfoPtr_OnResult_Protected_Abstract_Virtual_New_Void_String_0;

	// Token: 0x040009F4 RID: 2548
	private static readonly IntPtr NativeMethodInfoPtr_OnTokenLoaded_Private_Void_0;

	// Token: 0x040009F5 RID: 2549
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	// Token: 0x02000387 RID: 903
	[ObfuscatedName("TW_APIRequest+<Request>d__12")]
	public sealed class _Request_d__12 : global::Il2CppSystem.Object
	{
		// Token: 0x060035D2 RID: 13778 RVA: 0x000DD86C File Offset: 0x000DBA6C
		// Note: this type is marked as 'beforefieldinit'.
		static _Request_d__12()
		{
			Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, "<Request>d__12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr);
			TW_APIRequest._Request_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr, "<>1__state");
			TW_APIRequest._Request_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr, "<>2__current");
			TW_APIRequest._Request_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr, "<>4__this");
			TW_APIRequest._Request_d__12.NativeFieldInfoPtr__www_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr, "<www>5__2");
			TW_APIRequest._Request_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr, 100670157);
			TW_APIRequest._Request_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr, 100670158);
			TW_APIRequest._Request_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr, 100670159);
			TW_APIRequest._Request_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr, 100670160);
			TW_APIRequest._Request_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr, 100670161);
			TW_APIRequest._Request_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr, 100670162);
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x000DD960 File Offset: 0x000DBB60
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Request_d__12(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_APIRequest._Request_d__12>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest._Request_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x000DD9A8 File Offset: 0x000DBBA8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest._Request_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x000DD9DC File Offset: 0x000DBBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175699, XrefRangeEnd = 175746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest._Request_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060035D6 RID: 13782 RVA: 0x000DDA18 File Offset: 0x000DBC18
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest._Request_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x000DDA58 File Offset: 0x000DBC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175746, XrefRangeEnd = 175751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest._Request_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060035D8 RID: 13784 RVA: 0x000DDA8C File Offset: 0x000DBC8C
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest._Request_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00014D90 File Offset: 0x00012F90
		public _Request_d__12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x000DDACC File Offset: 0x000DBCCC
		// (set) Token: 0x060035DB RID: 13787 RVA: 0x00014D99 File Offset: 0x00012F99
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest._Request_d__12.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest._Request_d__12.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060035DC RID: 13788 RVA: 0x000DDAF4 File Offset: 0x000DBCF4
		// (set) Token: 0x060035DD RID: 13789 RVA: 0x00014DB4 File Offset: 0x00012FB4
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest._Request_d__12.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest._Request_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060035DE RID: 13790 RVA: 0x000DDB24 File Offset: 0x000DBD24
		// (set) Token: 0x060035DF RID: 13791 RVA: 0x00014DD3 File Offset: 0x00012FD3
		public unsafe TW_APIRequest __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest._Request_d__12.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TW_APIRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest._Request_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060035E0 RID: 13792 RVA: 0x000DDB54 File Offset: 0x000DBD54
		// (set) Token: 0x060035E1 RID: 13793 RVA: 0x00014DF2 File Offset: 0x00012FF2
		public unsafe WWW _www_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest._Request_d__12.NativeFieldInfoPtr__www_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequest._Request_d__12.NativeFieldInfoPtr__www_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400316E RID: 12654
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400316F RID: 12655
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04003170 RID: 12656
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04003171 RID: 12657
		private static readonly IntPtr NativeFieldInfoPtr__www_5__2;

		// Token: 0x04003172 RID: 12658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003173 RID: 12659
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003174 RID: 12660
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04003175 RID: 12661
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003176 RID: 12662
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003177 RID: 12663
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000388 RID: 904
	[ObfuscatedName("TW_APIRequest+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060035E2 RID: 13794 RVA: 0x000DDB84 File Offset: 0x000DBD84
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<TW_APIRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TW_APIRequest>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_APIRequest.__c>.NativeClassPtr);
			TW_APIRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest.__c>.NativeClassPtr, "<>9");
			TW_APIRequest.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequest.__c>.NativeClassPtr, "<>9__15_0");
			TW_APIRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest.__c>.NativeClassPtr, 100670164);
			TW_APIRequest.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequest.__c>.NativeClassPtr, 100670165);
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x000DDC00 File Offset: 0x000DBE00
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_APIRequest.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x000DDC3C File Offset: 0x000DBE3C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_0(TW_APIRequstResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequest.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00014E11 File Offset: 0x00013011
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060035E6 RID: 13798 RVA: 0x000DDC80 File Offset: 0x000DBE80
		// (set) Token: 0x060035E7 RID: 13799 RVA: 0x00014E1A File Offset: 0x0001301A
		public unsafe static TW_APIRequest.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TW_APIRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TW_APIRequest.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TW_APIRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060035E8 RID: 13800 RVA: 0x000DDCA8 File Offset: 0x000DBEA8
		// (set) Token: 0x060035E9 RID: 13801 RVA: 0x00014E2C File Offset: 0x0001302C
		public unsafe static Action<TW_APIRequstResult> __9__15_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TW_APIRequest.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TW_APIRequstResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TW_APIRequest.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003178 RID: 12664
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003179 RID: 12665
		private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

		// Token: 0x0400317A RID: 12666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400317B RID: 12667
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_TW_APIRequstResult_0;
	}
}
