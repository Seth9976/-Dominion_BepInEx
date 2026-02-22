using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

// Token: 0x0200010E RID: 270
public class BillingTab : FeatureTab
{
	// Token: 0x06001296 RID: 4758 RVA: 0x00057730 File Offset: 0x00055930
	// Note: this type is marked as 'beforefieldinit'.
	static BillingTab()
	{
		Il2CppClassPointerStore<BillingTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "BillingTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillingTab>.NativeClassPtr);
		BillingTab.NativeFieldInfoPtr_initButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingTab>.NativeClassPtr, "initButton");
		BillingTab.NativeFieldInfoPtr_initBoundButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingTab>.NativeClassPtr, "initBoundButtons");
		BillingTab.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingTab>.NativeClassPtr, 100665537);
		BillingTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingTab>.NativeClassPtr, 100665538);
		BillingTab.NativeMethodInfoPtr_SuccsesPurchase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingTab>.NativeClassPtr, 100665539);
		BillingTab.NativeMethodInfoPtr_FailPurchase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingTab>.NativeClassPtr, 100665540);
		BillingTab.NativeMethodInfoPtr_ConsumeProduct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingTab>.NativeClassPtr, 100665541);
		BillingTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingTab>.NativeClassPtr, 100665542);
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x00057800 File Offset: 0x00055A00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182968, XrefRangeEnd = 182972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingTab.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00057834 File Offset: 0x00055A34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182972, XrefRangeEnd = 182986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00057868 File Offset: 0x00055A68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182986, XrefRangeEnd = 183009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SuccsesPurchase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingTab.NativeMethodInfoPtr_SuccsesPurchase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x0005789C File Offset: 0x00055A9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183009, XrefRangeEnd = 183032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FailPurchase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingTab.NativeMethodInfoPtr_FailPurchase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x000578D0 File Offset: 0x00055AD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183032, XrefRangeEnd = 183073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConsumeProduct()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingTab.NativeMethodInfoPtr_ConsumeProduct_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x00057904 File Offset: 0x00055B04
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BillingTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillingTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x000093FE File Offset: 0x000075FE
	public BillingTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700057D RID: 1405
	// (get) Token: 0x0600129E RID: 4766 RVA: 0x00057940 File Offset: 0x00055B40
	// (set) Token: 0x0600129F RID: 4767 RVA: 0x00009407 File Offset: 0x00007607
	public unsafe Button initButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingTab.NativeFieldInfoPtr_initButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingTab.NativeFieldInfoPtr_initButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700057E RID: 1406
	// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00057970 File Offset: 0x00055B70
	// (set) Token: 0x060012A1 RID: 4769 RVA: 0x00009426 File Offset: 0x00007626
	public unsafe Il2CppReferenceArray<Button> initBoundButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingTab.NativeFieldInfoPtr_initBoundButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingTab.NativeFieldInfoPtr_initBoundButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000E47 RID: 3655
	private static readonly IntPtr NativeFieldInfoPtr_initButton;

	// Token: 0x04000E48 RID: 3656
	private static readonly IntPtr NativeFieldInfoPtr_initBoundButtons;

	// Token: 0x04000E49 RID: 3657
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x04000E4A RID: 3658
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000E4B RID: 3659
	private static readonly IntPtr NativeMethodInfoPtr_SuccsesPurchase_Public_Void_0;

	// Token: 0x04000E4C RID: 3660
	private static readonly IntPtr NativeMethodInfoPtr_FailPurchase_Public_Void_0;

	// Token: 0x04000E4D RID: 3661
	private static readonly IntPtr NativeMethodInfoPtr_ConsumeProduct_Public_Void_0;

	// Token: 0x04000E4E RID: 3662
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
