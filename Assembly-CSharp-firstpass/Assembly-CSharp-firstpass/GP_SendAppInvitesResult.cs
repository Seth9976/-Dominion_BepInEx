using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000030 RID: 48
public class GP_SendAppInvitesResult : GooglePlayResult
{
	// Token: 0x06000488 RID: 1160 RVA: 0x00025F34 File Offset: 0x00024134
	// Note: this type is marked as 'beforefieldinit'.
	static GP_SendAppInvitesResult()
	{
		Il2CppClassPointerStore<GP_SendAppInvitesResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_SendAppInvitesResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_SendAppInvitesResult>.NativeClassPtr);
		GP_SendAppInvitesResult.NativeFieldInfoPtr__InvitationIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_SendAppInvitesResult>.NativeClassPtr, "_InvitationIds");
		GP_SendAppInvitesResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SendAppInvitesResult>.NativeClassPtr, 100663815);
		GP_SendAppInvitesResult.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SendAppInvitesResult>.NativeClassPtr, 100663816);
		GP_SendAppInvitesResult.NativeMethodInfoPtr_get_InvitationIds_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SendAppInvitesResult>.NativeClassPtr, 100663817);
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00025FB4 File Offset: 0x000241B4
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_SendAppInvitesResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_SendAppInvitesResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SendAppInvitesResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00026000 File Offset: 0x00024200
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_SendAppInvitesResult(Il2CppStringArray invites)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_SendAppInvitesResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(invites);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SendAppInvitesResult.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x0600048B RID: 1163 RVA: 0x0002604C File Offset: 0x0002424C
	public unsafe Il2CppStringArray InvitationIds
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SendAppInvitesResult.NativeMethodInfoPtr_get_InvitationIds_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00003F20 File Offset: 0x00002120
	public GP_SendAppInvitesResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x0600048D RID: 1165 RVA: 0x0002608C File Offset: 0x0002428C
	// (set) Token: 0x0600048E RID: 1166 RVA: 0x00003F29 File Offset: 0x00002129
	public unsafe Il2CppStringArray _InvitationIds
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SendAppInvitesResult.NativeFieldInfoPtr__InvitationIds);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SendAppInvitesResult.NativeFieldInfoPtr__InvitationIds), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000361 RID: 865
	private static readonly IntPtr NativeFieldInfoPtr__InvitationIds;

	// Token: 0x04000362 RID: 866
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000363 RID: 867
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;

	// Token: 0x04000364 RID: 868
	private static readonly IntPtr NativeMethodInfoPtr_get_InvitationIds_Public_get_Il2CppStringArray_0;
}
