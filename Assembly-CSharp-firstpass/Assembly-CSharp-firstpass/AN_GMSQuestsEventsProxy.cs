using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000BE RID: 190
public class AN_GMSQuestsEventsProxy : MonoBehaviour
{
	// Token: 0x06000DC8 RID: 3528 RVA: 0x00047A28 File Offset: 0x00045C28
	// Note: this type is marked as 'beforefieldinit'.
	static AN_GMSQuestsEventsProxy()
	{
		Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_GMSQuestsEventsProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr);
		AN_GMSQuestsEventsProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr, "CLASS_NAME");
		AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr, 100664998);
		AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_sumbitEvent_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr, 100664999);
		AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_loadEvents_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr, 100665000);
		AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_showSelectedQuests_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr, 100665001);
		AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_acceptQuest_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr, 100665002);
		AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_loadQuests_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr, 100665003);
		AN_GMSQuestsEventsProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr, 100665004);
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00047AF8 File Offset: 0x00045CF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177736, XrefRangeEnd = 177737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x00047B50 File Offset: 0x00045D50
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177745, RefRangeEnd = 177747, XrefRangeStart = 177737, XrefRangeEnd = 177745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void sumbitEvent(string eventId, int count)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(eventId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_sumbitEvent_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00047B94 File Offset: 0x00045D94
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177752, RefRangeEnd = 177753, XrefRangeStart = 177747, XrefRangeEnd = 177752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadEvents()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_loadEvents_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x00047BBC File Offset: 0x00045DBC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177759, RefRangeEnd = 177761, XrefRangeStart = 177753, XrefRangeEnd = 177759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showSelectedQuests(string questSelectors)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(questSelectors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_showSelectedQuests_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00047BF4 File Offset: 0x00045DF4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177767, RefRangeEnd = 177768, XrefRangeStart = 177761, XrefRangeEnd = 177767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void acceptQuest(string questId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(questId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_acceptQuest_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x00047C2C File Offset: 0x00045E2C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177776, RefRangeEnd = 177778, XrefRangeStart = 177768, XrefRangeEnd = 177776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadQuests(string questSelectors, int sortOrder)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(questSelectors);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortOrder;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSQuestsEventsProxy.NativeMethodInfoPtr_loadQuests_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x00047C70 File Offset: 0x00045E70
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_GMSQuestsEventsProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_GMSQuestsEventsProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSQuestsEventsProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x000075DC File Offset: 0x000057DC
	public static void CallActivityFunction(string methodName, params global::Il2CppSystem.Object[] args)
	{
		AN_GMSQuestsEventsProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x000075EA File Offset: 0x000057EA
	public AN_GMSQuestsEventsProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00047CAC File Offset: 0x00045EAC
	// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x000075F3 File Offset: 0x000057F3
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_GMSQuestsEventsProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_GMSQuestsEventsProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000AB8 RID: 2744
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000AB9 RID: 2745
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000ABA RID: 2746
	private static readonly IntPtr NativeMethodInfoPtr_sumbitEvent_Public_Static_Void_String_Int32_0;

	// Token: 0x04000ABB RID: 2747
	private static readonly IntPtr NativeMethodInfoPtr_loadEvents_Public_Static_Void_0;

	// Token: 0x04000ABC RID: 2748
	private static readonly IntPtr NativeMethodInfoPtr_showSelectedQuests_Public_Static_Void_String_0;

	// Token: 0x04000ABD RID: 2749
	private static readonly IntPtr NativeMethodInfoPtr_acceptQuest_Public_Static_Void_String_0;

	// Token: 0x04000ABE RID: 2750
	private static readonly IntPtr NativeMethodInfoPtr_loadQuests_Public_Static_Void_String_Int32_0;

	// Token: 0x04000ABF RID: 2751
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
