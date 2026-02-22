using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000099 RID: 153
public class TrayToggleMultipleOwners : TrayToggle
{
	// Token: 0x06001254 RID: 4692 RVA: 0x00051360 File Offset: 0x0004F560
	// Note: this type is marked as 'beforefieldinit'.
	static TrayToggleMultipleOwners()
	{
		Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TrayToggleMultipleOwners");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr);
		TrayToggleMultipleOwners.NativeFieldInfoPtr_m_currentOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, "m_currentOwner");
		TrayToggleMultipleOwners.NativeFieldInfoPtr_m_bRespondToDelayedOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, "m_bRespondToDelayedOpen");
		TrayToggleMultipleOwners.NativeFieldInfoPtr_m_bClearOwnerOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, "m_bClearOwnerOnClose");
		TrayToggleMultipleOwners.NativeFieldInfoPtr_m_DelayedOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, "m_DelayedOwner");
		TrayToggleMultipleOwners.NativeFieldInfoPtr_m_delayedOpenTrayToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, "m_delayedOpenTrayToggle");
		TrayToggleMultipleOwners.NativeMethodInfoPtr_GetActiveOwner_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, 100664724);
		TrayToggleMultipleOwners.NativeMethodInfoPtr_GetActiveOwner_CheckClosing_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, 100664725);
		TrayToggleMultipleOwners.NativeMethodInfoPtr_GetDelayedOwner_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, 100664726);
		TrayToggleMultipleOwners.NativeMethodInfoPtr_TrayStateWithOwner_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, 100664727);
		TrayToggleMultipleOwners.NativeMethodInfoPtr_SetTrayStateOnWithOwner_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, 100664728);
		TrayToggleMultipleOwners.NativeMethodInfoPtr_AskToToggle_Public_Void_TrayToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, 100664729);
		TrayToggleMultipleOwners.NativeMethodInfoPtr_AskToOpen_Public_Void_TrayToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, 100664730);
		TrayToggleMultipleOwners.NativeMethodInfoPtr_HandleDelayedOpen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, 100664731);
		TrayToggleMultipleOwners.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr, 100664732);
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x000514A8 File Offset: 0x0004F6A8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11932, RefRangeEnd = 11934, XrefRangeStart = 11932, XrefRangeEnd = 11934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetActiveOwner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggleMultipleOwners.NativeMethodInfoPtr_GetActiveOwner_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x000514E4 File Offset: 0x0004F6E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243403, RefRangeEnd = 243404, XrefRangeStart = 243403, XrefRangeEnd = 243403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetActiveOwner_CheckClosing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggleMultipleOwners.NativeMethodInfoPtr_GetActiveOwner_CheckClosing_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001257 RID: 4695 RVA: 0x00051520 File Offset: 0x0004F720
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 24292, RefRangeEnd = 24293, XrefRangeStart = 24292, XrefRangeEnd = 24293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetDelayedOwner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggleMultipleOwners.NativeMethodInfoPtr_GetDelayedOwner_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001258 RID: 4696 RVA: 0x0005155C File Offset: 0x0004F75C
	[CallerCount(0)]
	public unsafe void TrayStateWithOwner(int ownerIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref ownerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggleMultipleOwners.NativeMethodInfoPtr_TrayStateWithOwner_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x0005159C File Offset: 0x0004F79C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243404, XrefRangeEnd = 243406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTrayStateOnWithOwner(int ownerIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref ownerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggleMultipleOwners.NativeMethodInfoPtr_SetTrayStateOnWithOwner_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x000515DC File Offset: 0x0004F7DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243406, XrefRangeEnd = 243411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AskToToggle(TrayToggle trayToToggle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trayToToggle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggleMultipleOwners.NativeMethodInfoPtr_AskToToggle_Public_Void_TrayToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x00051620 File Offset: 0x0004F820
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243411, XrefRangeEnd = 243415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AskToOpen(TrayToggle trayToToggle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trayToToggle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggleMultipleOwners.NativeMethodInfoPtr_AskToOpen_Public_Void_TrayToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x00051664 File Offset: 0x0004F864
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243415, XrefRangeEnd = 243420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleDelayedOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggleMultipleOwners.NativeMethodInfoPtr_HandleDelayedOpen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x00051698 File Offset: 0x0004F898
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243420, XrefRangeEnd = 243421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TrayToggleMultipleOwners()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrayToggleMultipleOwners>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggleMultipleOwners.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x0000C398 File Offset: 0x0000A598
	public TrayToggleMultipleOwners(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005E4 RID: 1508
	// (get) Token: 0x0600125F RID: 4703 RVA: 0x000516D4 File Offset: 0x0004F8D4
	// (set) Token: 0x06001260 RID: 4704 RVA: 0x0000C3A1 File Offset: 0x0000A5A1
	public unsafe int m_currentOwner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggleMultipleOwners.NativeFieldInfoPtr_m_currentOwner);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggleMultipleOwners.NativeFieldInfoPtr_m_currentOwner)) = value;
		}
	}

	// Token: 0x170005E5 RID: 1509
	// (get) Token: 0x06001261 RID: 4705 RVA: 0x000516FC File Offset: 0x0004F8FC
	// (set) Token: 0x06001262 RID: 4706 RVA: 0x0000C3BC File Offset: 0x0000A5BC
	public unsafe bool m_bRespondToDelayedOpen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggleMultipleOwners.NativeFieldInfoPtr_m_bRespondToDelayedOpen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggleMultipleOwners.NativeFieldInfoPtr_m_bRespondToDelayedOpen)) = value;
		}
	}

	// Token: 0x170005E6 RID: 1510
	// (get) Token: 0x06001263 RID: 4707 RVA: 0x00051724 File Offset: 0x0004F924
	// (set) Token: 0x06001264 RID: 4708 RVA: 0x0000C3D7 File Offset: 0x0000A5D7
	public unsafe bool m_bClearOwnerOnClose
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggleMultipleOwners.NativeFieldInfoPtr_m_bClearOwnerOnClose);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggleMultipleOwners.NativeFieldInfoPtr_m_bClearOwnerOnClose)) = value;
		}
	}

	// Token: 0x170005E7 RID: 1511
	// (get) Token: 0x06001265 RID: 4709 RVA: 0x0005174C File Offset: 0x0004F94C
	// (set) Token: 0x06001266 RID: 4710 RVA: 0x0000C3F2 File Offset: 0x0000A5F2
	public unsafe int m_DelayedOwner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggleMultipleOwners.NativeFieldInfoPtr_m_DelayedOwner);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggleMultipleOwners.NativeFieldInfoPtr_m_DelayedOwner)) = value;
		}
	}

	// Token: 0x170005E8 RID: 1512
	// (get) Token: 0x06001267 RID: 4711 RVA: 0x00051774 File Offset: 0x0004F974
	// (set) Token: 0x06001268 RID: 4712 RVA: 0x0000C40D File Offset: 0x0000A60D
	public unsafe TrayToggle m_delayedOpenTrayToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggleMultipleOwners.NativeFieldInfoPtr_m_delayedOpenTrayToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggleMultipleOwners.NativeFieldInfoPtr_m_delayedOpenTrayToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000CD4 RID: 3284
	private static readonly IntPtr NativeFieldInfoPtr_m_currentOwner;

	// Token: 0x04000CD5 RID: 3285
	private static readonly IntPtr NativeFieldInfoPtr_m_bRespondToDelayedOpen;

	// Token: 0x04000CD6 RID: 3286
	private static readonly IntPtr NativeFieldInfoPtr_m_bClearOwnerOnClose;

	// Token: 0x04000CD7 RID: 3287
	private static readonly IntPtr NativeFieldInfoPtr_m_DelayedOwner;

	// Token: 0x04000CD8 RID: 3288
	private static readonly IntPtr NativeFieldInfoPtr_m_delayedOpenTrayToggle;

	// Token: 0x04000CD9 RID: 3289
	private static readonly IntPtr NativeMethodInfoPtr_GetActiveOwner_Public_Int32_0;

	// Token: 0x04000CDA RID: 3290
	private static readonly IntPtr NativeMethodInfoPtr_GetActiveOwner_CheckClosing_Public_Int32_0;

	// Token: 0x04000CDB RID: 3291
	private static readonly IntPtr NativeMethodInfoPtr_GetDelayedOwner_Public_Int32_0;

	// Token: 0x04000CDC RID: 3292
	private static readonly IntPtr NativeMethodInfoPtr_TrayStateWithOwner_Public_Void_Int32_0;

	// Token: 0x04000CDD RID: 3293
	private static readonly IntPtr NativeMethodInfoPtr_SetTrayStateOnWithOwner_Public_Void_Int32_0;

	// Token: 0x04000CDE RID: 3294
	private static readonly IntPtr NativeMethodInfoPtr_AskToToggle_Public_Void_TrayToggle_0;

	// Token: 0x04000CDF RID: 3295
	private static readonly IntPtr NativeMethodInfoPtr_AskToOpen_Public_Void_TrayToggle_0;

	// Token: 0x04000CE0 RID: 3296
	private static readonly IntPtr NativeMethodInfoPtr_HandleDelayedOpen_Public_Void_0;

	// Token: 0x04000CE1 RID: 3297
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
