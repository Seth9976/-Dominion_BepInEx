using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000FD RID: 253
public class SASendMessageOnClick : SAOnClickAction
{
	// Token: 0x0600118B RID: 4491 RVA: 0x000543C0 File Offset: 0x000525C0
	// Note: this type is marked as 'beforefieldinit'.
	static SASendMessageOnClick()
	{
		Il2CppClassPointerStore<SASendMessageOnClick>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SASendMessageOnClick");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SASendMessageOnClick>.NativeClassPtr);
		SASendMessageOnClick.NativeFieldInfoPtr_Reciver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SASendMessageOnClick>.NativeClassPtr, "Reciver");
		SASendMessageOnClick.NativeFieldInfoPtr_MethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SASendMessageOnClick>.NativeClassPtr, "MethodName");
		SASendMessageOnClick.NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SASendMessageOnClick>.NativeClassPtr, 100665431);
		SASendMessageOnClick.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SASendMessageOnClick>.NativeClassPtr, 100665432);
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x00054440 File Offset: 0x00052640
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181765, XrefRangeEnd = 181767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SASendMessageOnClick.NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x0005447C File Offset: 0x0005267C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SASendMessageOnClick()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SASendMessageOnClick>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SASendMessageOnClick.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x00008BFB File Offset: 0x00006DFB
	public SASendMessageOnClick(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000533 RID: 1331
	// (get) Token: 0x0600118F RID: 4495 RVA: 0x000544B8 File Offset: 0x000526B8
	// (set) Token: 0x06001190 RID: 4496 RVA: 0x00008C04 File Offset: 0x00006E04
	public unsafe GameObject Reciver
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SASendMessageOnClick.NativeFieldInfoPtr_Reciver);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SASendMessageOnClick.NativeFieldInfoPtr_Reciver), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x06001191 RID: 4497 RVA: 0x000544E8 File Offset: 0x000526E8
	// (set) Token: 0x06001192 RID: 4498 RVA: 0x00008C23 File Offset: 0x00006E23
	public unsafe string MethodName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SASendMessageOnClick.NativeFieldInfoPtr_MethodName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SASendMessageOnClick.NativeFieldInfoPtr_MethodName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D94 RID: 3476
	private static readonly IntPtr NativeFieldInfoPtr_Reciver;

	// Token: 0x04000D95 RID: 3477
	private static readonly IntPtr NativeFieldInfoPtr_MethodName;

	// Token: 0x04000D96 RID: 3478
	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0;

	// Token: 0x04000D97 RID: 3479
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
