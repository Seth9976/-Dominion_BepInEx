using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000BC RID: 188
public class AN_GMSGiftsProxy : MonoBehaviour
{
	// Token: 0x06000DB1 RID: 3505 RVA: 0x0004755C File Offset: 0x0004575C
	// Note: this type is marked as 'beforefieldinit'.
	static AN_GMSGiftsProxy()
	{
		Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_GMSGiftsProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr);
		AN_GMSGiftsProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr, "CLASS_NAME");
		AN_GMSGiftsProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr, 100664985);
		AN_GMSGiftsProxy.NativeMethodInfoPtr_sendGiftRequest_Public_Static_Void_Int32_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr, 100664986);
		AN_GMSGiftsProxy.NativeMethodInfoPtr_showRequestAccepDialog_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr, 100664987);
		AN_GMSGiftsProxy.NativeMethodInfoPtr_acceptRequests_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr, 100664988);
		AN_GMSGiftsProxy.NativeMethodInfoPtr_dismissRequest_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr, 100664989);
		AN_GMSGiftsProxy.NativeMethodInfoPtr_leaveRoom_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr, 100664990);
		AN_GMSGiftsProxy.NativeMethodInfoPtr_showInvitationBox_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr, 100664991);
		AN_GMSGiftsProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr, 100664992);
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x00047640 File Offset: 0x00045840
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177671, XrefRangeEnd = 177672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGiftsProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x00047698 File Offset: 0x00045898
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177684, RefRangeEnd = 177685, XrefRangeStart = 177672, XrefRangeEnd = 177684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void sendGiftRequest(int type, string playload, int requestLifetimeDays, string icon, string description)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref type;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playload);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestLifetimeDays;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(icon);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGiftsProxy.NativeMethodInfoPtr_sendGiftRequest_Public_Static_Void_Int32_String_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x00047710 File Offset: 0x00045910
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177690, RefRangeEnd = 177691, XrefRangeStart = 177685, XrefRangeEnd = 177690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showRequestAccepDialog()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGiftsProxy.NativeMethodInfoPtr_showRequestAccepDialog_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x00047738 File Offset: 0x00045938
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177697, RefRangeEnd = 177698, XrefRangeStart = 177691, XrefRangeEnd = 177697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void acceptRequests(string ids)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGiftsProxy.NativeMethodInfoPtr_acceptRequests_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x00047770 File Offset: 0x00045970
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177704, RefRangeEnd = 177705, XrefRangeStart = 177698, XrefRangeEnd = 177704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void dismissRequest(string ids)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGiftsProxy.NativeMethodInfoPtr_dismissRequest_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x000477A8 File Offset: 0x000459A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177710, RefRangeEnd = 177711, XrefRangeStart = 177705, XrefRangeEnd = 177710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void leaveRoom()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGiftsProxy.NativeMethodInfoPtr_leaveRoom_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x000477D0 File Offset: 0x000459D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177716, RefRangeEnd = 177717, XrefRangeStart = 177711, XrefRangeEnd = 177716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showInvitationBox()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGiftsProxy.NativeMethodInfoPtr_showInvitationBox_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x000477F8 File Offset: 0x000459F8
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_GMSGiftsProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_GMSGiftsProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGiftsProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x0000758A File Offset: 0x0000578A
	public static void CallActivityFunction(string methodName, params global::Il2CppSystem.Object[] args)
	{
		AN_GMSGiftsProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x00007598 File Offset: 0x00005798
	public AN_GMSGiftsProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000432 RID: 1074
	// (get) Token: 0x06000DBC RID: 3516 RVA: 0x00047834 File Offset: 0x00045A34
	// (set) Token: 0x06000DBD RID: 3517 RVA: 0x000075A1 File Offset: 0x000057A1
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_GMSGiftsProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_GMSGiftsProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000AA9 RID: 2729
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000AAA RID: 2730
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000AAB RID: 2731
	private static readonly IntPtr NativeMethodInfoPtr_sendGiftRequest_Public_Static_Void_Int32_String_Int32_String_String_0;

	// Token: 0x04000AAC RID: 2732
	private static readonly IntPtr NativeMethodInfoPtr_showRequestAccepDialog_Public_Static_Void_0;

	// Token: 0x04000AAD RID: 2733
	private static readonly IntPtr NativeMethodInfoPtr_acceptRequests_Public_Static_Void_String_0;

	// Token: 0x04000AAE RID: 2734
	private static readonly IntPtr NativeMethodInfoPtr_dismissRequest_Public_Static_Void_String_0;

	// Token: 0x04000AAF RID: 2735
	private static readonly IntPtr NativeMethodInfoPtr_leaveRoom_Public_Static_Void_0;

	// Token: 0x04000AB0 RID: 2736
	private static readonly IntPtr NativeMethodInfoPtr_showInvitationBox_Public_Static_Void_0;

	// Token: 0x04000AB1 RID: 2737
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
