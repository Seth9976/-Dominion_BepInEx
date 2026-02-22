using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000112 RID: 274
public class InGameBillingTab : FeatureTab
{
	// Token: 0x060012D6 RID: 4822 RVA: 0x000583F0 File Offset: 0x000565F0
	// Note: this type is marked as 'beforefieldinit'.
	static InGameBillingTab()
	{
		Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "InGameBillingTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr);
		InGameBillingTab.NativeFieldInfoPtr_objectToEnbaleOnInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr, "objectToEnbaleOnInit");
		InGameBillingTab.NativeFieldInfoPtr_initBoundButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr, "initBoundButtons");
		InGameBillingTab.NativeFieldInfoPtr_coinsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr, "coinsLabel");
		InGameBillingTab.NativeFieldInfoPtr_boostLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr, "boostLabel");
		InGameBillingTab.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr, 100665573);
		InGameBillingTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr, 100665574);
		InGameBillingTab.NativeMethodInfoPtr_AddCoins_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr, 100665575);
		InGameBillingTab.NativeMethodInfoPtr_Boost_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr, 100665576);
		InGameBillingTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr, 100665577);
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x000584D4 File Offset: 0x000566D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183638, XrefRangeEnd = 183642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameBillingTab.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x00058508 File Offset: 0x00056708
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183642, XrefRangeEnd = 183667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameBillingTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x0005853C File Offset: 0x0005673C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183667, XrefRangeEnd = 183673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCoins()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameBillingTab.NativeMethodInfoPtr_AddCoins_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x00058570 File Offset: 0x00056770
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183673, XrefRangeEnd = 183679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Boost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameBillingTab.NativeMethodInfoPtr_Boost_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x000585A4 File Offset: 0x000567A4
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InGameBillingTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InGameBillingTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameBillingTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x000094F6 File Offset: 0x000076F6
	public InGameBillingTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700058C RID: 1420
	// (get) Token: 0x060012DD RID: 4829 RVA: 0x000585E0 File Offset: 0x000567E0
	// (set) Token: 0x060012DE RID: 4830 RVA: 0x000094FF File Offset: 0x000076FF
	public unsafe Il2CppReferenceArray<GameObject> objectToEnbaleOnInit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameBillingTab.NativeFieldInfoPtr_objectToEnbaleOnInit);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameBillingTab.NativeFieldInfoPtr_objectToEnbaleOnInit), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700058D RID: 1421
	// (get) Token: 0x060012DF RID: 4831 RVA: 0x00058610 File Offset: 0x00056810
	// (set) Token: 0x060012E0 RID: 4832 RVA: 0x0000951E File Offset: 0x0000771E
	public unsafe Il2CppReferenceArray<Button> initBoundButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameBillingTab.NativeFieldInfoPtr_initBoundButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameBillingTab.NativeFieldInfoPtr_initBoundButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700058E RID: 1422
	// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00058640 File Offset: 0x00056840
	// (set) Token: 0x060012E2 RID: 4834 RVA: 0x0000953D File Offset: 0x0000773D
	public unsafe Text coinsLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameBillingTab.NativeFieldInfoPtr_coinsLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameBillingTab.NativeFieldInfoPtr_coinsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700058F RID: 1423
	// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00058670 File Offset: 0x00056870
	// (set) Token: 0x060012E4 RID: 4836 RVA: 0x0000955C File Offset: 0x0000775C
	public unsafe Text boostLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameBillingTab.NativeFieldInfoPtr_boostLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InGameBillingTab.NativeFieldInfoPtr_boostLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000E74 RID: 3700
	private static readonly IntPtr NativeFieldInfoPtr_objectToEnbaleOnInit;

	// Token: 0x04000E75 RID: 3701
	private static readonly IntPtr NativeFieldInfoPtr_initBoundButtons;

	// Token: 0x04000E76 RID: 3702
	private static readonly IntPtr NativeFieldInfoPtr_coinsLabel;

	// Token: 0x04000E77 RID: 3703
	private static readonly IntPtr NativeFieldInfoPtr_boostLabel;

	// Token: 0x04000E78 RID: 3704
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000E79 RID: 3705
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000E7A RID: 3706
	private static readonly IntPtr NativeMethodInfoPtr_AddCoins_Public_Void_0;

	// Token: 0x04000E7B RID: 3707
	private static readonly IntPtr NativeMethodInfoPtr_Boost_Public_Void_0;

	// Token: 0x04000E7C RID: 3708
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
