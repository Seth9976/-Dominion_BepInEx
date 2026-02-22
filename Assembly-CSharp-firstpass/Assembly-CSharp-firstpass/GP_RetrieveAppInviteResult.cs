using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x0200002F RID: 47
public class GP_RetrieveAppInviteResult : GooglePlayResult
{
	// Token: 0x06000481 RID: 1153 RVA: 0x00025DAC File Offset: 0x00023FAC
	// Note: this type is marked as 'beforefieldinit'.
	static GP_RetrieveAppInviteResult()
	{
		Il2CppClassPointerStore<GP_RetrieveAppInviteResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_RetrieveAppInviteResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_RetrieveAppInviteResult>.NativeClassPtr);
		GP_RetrieveAppInviteResult.NativeFieldInfoPtr__AppInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_RetrieveAppInviteResult>.NativeClassPtr, "_AppInvite");
		GP_RetrieveAppInviteResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RetrieveAppInviteResult>.NativeClassPtr, 100663812);
		GP_RetrieveAppInviteResult.NativeMethodInfoPtr__ctor_Public_Void_GP_AppInvite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RetrieveAppInviteResult>.NativeClassPtr, 100663813);
		GP_RetrieveAppInviteResult.NativeMethodInfoPtr_get_AppInvite_Public_get_GP_AppInvite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_RetrieveAppInviteResult>.NativeClassPtr, 100663814);
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00025E2C File Offset: 0x0002402C
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163764, XrefRangeEnd = 163765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_RetrieveAppInviteResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_RetrieveAppInviteResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RetrieveAppInviteResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00025E78 File Offset: 0x00024078
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163780, XrefRangeEnd = 163781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_RetrieveAppInviteResult(GP_AppInvite invite)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_RetrieveAppInviteResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(invite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RetrieveAppInviteResult.NativeMethodInfoPtr__ctor_Public_Void_GP_AppInvite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000484 RID: 1156 RVA: 0x00025EC4 File Offset: 0x000240C4
	public unsafe GP_AppInvite AppInvite
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_RetrieveAppInviteResult.NativeMethodInfoPtr_get_AppInvite_Public_get_GP_AppInvite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_AppInvite>(intPtr3) : null;
		}
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00003EF8 File Offset: 0x000020F8
	public GP_RetrieveAppInviteResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000486 RID: 1158 RVA: 0x00025F04 File Offset: 0x00024104
	// (set) Token: 0x06000487 RID: 1159 RVA: 0x00003F01 File Offset: 0x00002101
	public unsafe GP_AppInvite _AppInvite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RetrieveAppInviteResult.NativeFieldInfoPtr__AppInvite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_AppInvite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_RetrieveAppInviteResult.NativeFieldInfoPtr__AppInvite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400035D RID: 861
	private static readonly IntPtr NativeFieldInfoPtr__AppInvite;

	// Token: 0x0400035E RID: 862
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x0400035F RID: 863
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GP_AppInvite_0;

	// Token: 0x04000360 RID: 864
	private static readonly IntPtr NativeMethodInfoPtr_get_AppInvite_Public_get_GP_AppInvite_0;
}
