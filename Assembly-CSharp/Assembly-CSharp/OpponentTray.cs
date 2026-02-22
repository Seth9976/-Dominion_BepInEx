using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000039 RID: 57
public class OpponentTray : MonoBehaviour
{
	// Token: 0x060009DB RID: 2523 RVA: 0x000371E0 File Offset: 0x000353E0
	// Note: this type is marked as 'beforefieldinit'.
	static OpponentTray()
	{
		Il2CppClassPointerStore<OpponentTray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OpponentTray");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr);
		OpponentTray.NativeFieldInfoPtr_k_maxDataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, "k_maxDataSize");
		OpponentTray.NativeFieldInfoPtr_m_AscensionGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, "m_AscensionGame");
		OpponentTray.NativeFieldInfoPtr_m_AscensionLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, "m_AscensionLog");
		OpponentTray.NativeFieldInfoPtr_m_OppTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, "m_OppTray");
		OpponentTray.NativeFieldInfoPtr_m_OpponentDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, "m_OpponentDisplays");
		OpponentTray.NativeMethodInfoPtr_GetPlayerDisplayByOpponentOrder_Public_PlayerDisplay_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, 100663983);
		OpponentTray.NativeMethodInfoPtr_GetPlayerDisplayByInstanceID_Public_PlayerDisplay_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, 100663984);
		OpponentTray.NativeMethodInfoPtr_UpdateOppCardTrayButtonGlows_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, 100663985);
		OpponentTray.NativeMethodInfoPtr_BuildPlayerDisplays_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, 100663986);
		OpponentTray.NativeMethodInfoPtr_CloseOpponentTrays_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, 100663987);
		OpponentTray.NativeMethodInfoPtr_UpdatePlayerDisplays_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, 100663988);
		OpponentTray.NativeMethodInfoPtr_RebuildInterface_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, 100663989);
		OpponentTray.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, 100663990);
		OpponentTray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr, 100663991);
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00037328 File Offset: 0x00035528
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236080, RefRangeEnd = 236081, XrefRangeStart = 236080, XrefRangeEnd = 236080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerDisplay GetPlayerDisplayByOpponentOrder(int order_index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref order_index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentTray.NativeMethodInfoPtr_GetPlayerDisplayByOpponentOrder_Public_PlayerDisplay_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerDisplay>(intPtr3) : null;
		}
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00037374 File Offset: 0x00035574
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 236086, RefRangeEnd = 236088, XrefRangeStart = 236081, XrefRangeEnd = 236086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerDisplay GetPlayerDisplayByInstanceID(int playerInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentTray.NativeMethodInfoPtr_GetPlayerDisplayByInstanceID_Public_PlayerDisplay_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerDisplay>(intPtr3) : null;
		}
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x000373C0 File Offset: 0x000355C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236088, XrefRangeEnd = 236095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateOppCardTrayButtonGlows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentTray.NativeMethodInfoPtr_UpdateOppCardTrayButtonGlows_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x000373F4 File Offset: 0x000355F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236146, RefRangeEnd = 236147, XrefRangeStart = 236095, XrefRangeEnd = 236146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildPlayerDisplays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentTray.NativeMethodInfoPtr_BuildPlayerDisplays_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00037428 File Offset: 0x00035628
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236159, RefRangeEnd = 236160, XrefRangeStart = 236147, XrefRangeEnd = 236159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseOpponentTrays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentTray.NativeMethodInfoPtr_CloseOpponentTrays_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x0003745C File Offset: 0x0003565C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236168, RefRangeEnd = 236169, XrefRangeStart = 236160, XrefRangeEnd = 236168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlayerDisplays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentTray.NativeMethodInfoPtr_UpdatePlayerDisplays_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00037490 File Offset: 0x00035690
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236177, RefRangeEnd = 236178, XrefRangeStart = 236169, XrefRangeEnd = 236177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildInterface()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentTray.NativeMethodInfoPtr_RebuildInterface_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x000374C4 File Offset: 0x000356C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236186, RefRangeEnd = 236187, XrefRangeStart = 236178, XrefRangeEnd = 236186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildAnimationManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentTray.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x000374F8 File Offset: 0x000356F8
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OpponentTray()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpponentTray>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentTray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00008031 File Offset: 0x00006231
	public OpponentTray(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000369 RID: 873
	// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00037534 File Offset: 0x00035734
	// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0000803A File Offset: 0x0000623A
	public unsafe static int k_maxDataSize
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(OpponentTray.NativeFieldInfoPtr_k_maxDataSize, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(OpponentTray.NativeFieldInfoPtr_k_maxDataSize, (void*)(&value));
		}
	}

	// Token: 0x1700036A RID: 874
	// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00037550 File Offset: 0x00035750
	// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00008048 File Offset: 0x00006248
	public unsafe AscensionGame m_AscensionGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentTray.NativeFieldInfoPtr_m_AscensionGame);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionGame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentTray.NativeFieldInfoPtr_m_AscensionGame), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700036B RID: 875
	// (get) Token: 0x060009EA RID: 2538 RVA: 0x00037580 File Offset: 0x00035780
	// (set) Token: 0x060009EB RID: 2539 RVA: 0x00008067 File Offset: 0x00006267
	public unsafe AscensionLog m_AscensionLog
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentTray.NativeFieldInfoPtr_m_AscensionLog);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionLog>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentTray.NativeFieldInfoPtr_m_AscensionLog), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700036C RID: 876
	// (get) Token: 0x060009EC RID: 2540 RVA: 0x000375B0 File Offset: 0x000357B0
	// (set) Token: 0x060009ED RID: 2541 RVA: 0x00008086 File Offset: 0x00006286
	public unsafe TrayToggleMultipleOwners m_OppTray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentTray.NativeFieldInfoPtr_m_OppTray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggleMultipleOwners>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentTray.NativeFieldInfoPtr_m_OppTray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700036D RID: 877
	// (get) Token: 0x060009EE RID: 2542 RVA: 0x000375E0 File Offset: 0x000357E0
	// (set) Token: 0x060009EF RID: 2543 RVA: 0x000080A5 File Offset: 0x000062A5
	public unsafe Il2CppReferenceArray<PlayerDisplay> m_OpponentDisplays
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentTray.NativeFieldInfoPtr_m_OpponentDisplays);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerDisplay>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentTray.NativeFieldInfoPtr_m_OpponentDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000622 RID: 1570
	private static readonly IntPtr NativeFieldInfoPtr_k_maxDataSize;

	// Token: 0x04000623 RID: 1571
	private static readonly IntPtr NativeFieldInfoPtr_m_AscensionGame;

	// Token: 0x04000624 RID: 1572
	private static readonly IntPtr NativeFieldInfoPtr_m_AscensionLog;

	// Token: 0x04000625 RID: 1573
	private static readonly IntPtr NativeFieldInfoPtr_m_OppTray;

	// Token: 0x04000626 RID: 1574
	private static readonly IntPtr NativeFieldInfoPtr_m_OpponentDisplays;

	// Token: 0x04000627 RID: 1575
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerDisplayByOpponentOrder_Public_PlayerDisplay_Int32_0;

	// Token: 0x04000628 RID: 1576
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerDisplayByInstanceID_Public_PlayerDisplay_Int32_0;

	// Token: 0x04000629 RID: 1577
	private static readonly IntPtr NativeMethodInfoPtr_UpdateOppCardTrayButtonGlows_Public_Void_0;

	// Token: 0x0400062A RID: 1578
	private static readonly IntPtr NativeMethodInfoPtr_BuildPlayerDisplays_Public_Void_0;

	// Token: 0x0400062B RID: 1579
	private static readonly IntPtr NativeMethodInfoPtr_CloseOpponentTrays_Public_Void_0;

	// Token: 0x0400062C RID: 1580
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerDisplays_Public_Void_0;

	// Token: 0x0400062D RID: 1581
	private static readonly IntPtr NativeMethodInfoPtr_RebuildInterface_Public_Void_0;

	// Token: 0x0400062E RID: 1582
	private static readonly IntPtr NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_0;

	// Token: 0x0400062F RID: 1583
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
