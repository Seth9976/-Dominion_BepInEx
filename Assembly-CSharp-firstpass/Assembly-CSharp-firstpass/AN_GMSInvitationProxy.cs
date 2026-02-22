using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000BD RID: 189
public class AN_GMSInvitationProxy : MonoBehaviour
{
	// Token: 0x06000DBE RID: 3518 RVA: 0x00047854 File Offset: 0x00045A54
	// Note: this type is marked as 'beforefieldinit'.
	static AN_GMSInvitationProxy()
	{
		Il2CppClassPointerStore<AN_GMSInvitationProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_GMSInvitationProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_GMSInvitationProxy>.NativeClassPtr);
		AN_GMSInvitationProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_GMSInvitationProxy>.NativeClassPtr, "CLASS_NAME");
		AN_GMSInvitationProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSInvitationProxy>.NativeClassPtr, 100664993);
		AN_GMSInvitationProxy.NativeMethodInfoPtr_registerInvitationListener_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSInvitationProxy>.NativeClassPtr, 100664994);
		AN_GMSInvitationProxy.NativeMethodInfoPtr_unregisterInvitationListener_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSInvitationProxy>.NativeClassPtr, 100664995);
		AN_GMSInvitationProxy.NativeMethodInfoPtr_LoadInvitations_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSInvitationProxy>.NativeClassPtr, 100664996);
		AN_GMSInvitationProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSInvitationProxy>.NativeClassPtr, 100664997);
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x000478FC File Offset: 0x00045AFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177717, XrefRangeEnd = 177718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSInvitationProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x00047954 File Offset: 0x00045B54
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177723, RefRangeEnd = 177724, XrefRangeStart = 177718, XrefRangeEnd = 177723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void registerInvitationListener()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSInvitationProxy.NativeMethodInfoPtr_registerInvitationListener_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x0004797C File Offset: 0x00045B7C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177729, RefRangeEnd = 177730, XrefRangeStart = 177724, XrefRangeEnd = 177729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void unregisterInvitationListener()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSInvitationProxy.NativeMethodInfoPtr_unregisterInvitationListener_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x000479A4 File Offset: 0x00045BA4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177735, RefRangeEnd = 177736, XrefRangeStart = 177730, XrefRangeEnd = 177735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadInvitations()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSInvitationProxy.NativeMethodInfoPtr_LoadInvitations_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x000479CC File Offset: 0x00045BCC
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_GMSInvitationProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_GMSInvitationProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSInvitationProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x000075B3 File Offset: 0x000057B3
	public static void CallActivityFunction(string methodName, params global::Il2CppSystem.Object[] args)
	{
		AN_GMSInvitationProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x000075C1 File Offset: 0x000057C1
	public AN_GMSInvitationProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000433 RID: 1075
	// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00047A08 File Offset: 0x00045C08
	// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x000075CA File Offset: 0x000057CA
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_GMSInvitationProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_GMSInvitationProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000AB2 RID: 2738
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000AB3 RID: 2739
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000AB4 RID: 2740
	private static readonly IntPtr NativeMethodInfoPtr_registerInvitationListener_Public_Static_Void_0;

	// Token: 0x04000AB5 RID: 2741
	private static readonly IntPtr NativeMethodInfoPtr_unregisterInvitationListener_Public_Static_Void_0;

	// Token: 0x04000AB6 RID: 2742
	private static readonly IntPtr NativeMethodInfoPtr_LoadInvitations_Public_Static_Void_0;

	// Token: 0x04000AB7 RID: 2743
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
