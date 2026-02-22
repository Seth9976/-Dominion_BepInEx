using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000050 RID: 80
public class AN_InvitationInboxCloseResult : MonoBehaviour
{
	// Token: 0x06000690 RID: 1680 RVA: 0x0002D6C4 File Offset: 0x0002B8C4
	// Note: this type is marked as 'beforefieldinit'.
	static AN_InvitationInboxCloseResult()
	{
		Il2CppClassPointerStore<AN_InvitationInboxCloseResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_InvitationInboxCloseResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_InvitationInboxCloseResult>.NativeClassPtr);
		AN_InvitationInboxCloseResult.NativeFieldInfoPtr__resultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_InvitationInboxCloseResult>.NativeClassPtr, "_resultCode");
		AN_InvitationInboxCloseResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InvitationInboxCloseResult>.NativeClassPtr, 100664090);
		AN_InvitationInboxCloseResult.NativeMethodInfoPtr_get_ResultCode_Public_get_AdroidActivityResultCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_InvitationInboxCloseResult>.NativeClassPtr, 100664091);
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x0002D730 File Offset: 0x0002B930
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166636, RefRangeEnd = 166637, XrefRangeStart = 166631, XrefRangeEnd = 166636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_InvitationInboxCloseResult(string result)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_InvitationInboxCloseResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InvitationInboxCloseResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700023B RID: 571
	// (get) Token: 0x06000692 RID: 1682 RVA: 0x0002D77C File Offset: 0x0002B97C
	public unsafe AdroidActivityResultCodes ResultCode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_InvitationInboxCloseResult.NativeMethodInfoPtr_get_ResultCode_Public_get_AdroidActivityResultCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00004AF1 File Offset: 0x00002CF1
	public AN_InvitationInboxCloseResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700023A RID: 570
	// (get) Token: 0x06000694 RID: 1684 RVA: 0x0002D7B8 File Offset: 0x0002B9B8
	// (set) Token: 0x06000695 RID: 1685 RVA: 0x00004AFA File Offset: 0x00002CFA
	public unsafe AdroidActivityResultCodes _resultCode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InvitationInboxCloseResult.NativeFieldInfoPtr__resultCode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_InvitationInboxCloseResult.NativeFieldInfoPtr__resultCode)) = value;
		}
	}

	// Token: 0x04000558 RID: 1368
	private static readonly IntPtr NativeFieldInfoPtr__resultCode;

	// Token: 0x04000559 RID: 1369
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x0400055A RID: 1370
	private static readonly IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_AdroidActivityResultCodes_0;
}
