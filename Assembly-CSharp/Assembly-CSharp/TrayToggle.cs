using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000098 RID: 152
public class TrayToggle : MonoBehaviour
{
	// Token: 0x06001238 RID: 4664 RVA: 0x00050E18 File Offset: 0x0004F018
	// Note: this type is marked as 'beforefieldinit'.
	static TrayToggle()
	{
		Il2CppClassPointerStore<TrayToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TrayToggle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr);
		TrayToggle.NativeFieldInfoPtr_tray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, "tray");
		TrayToggle.NativeFieldInfoPtr_m_CloseOtherTrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, "m_CloseOtherTrays");
		TrayToggle.NativeFieldInfoPtr_m_ownerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, "m_ownerIndex");
		TrayToggle.NativeFieldInfoPtr_m_trayStartHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, "m_trayStartHidden");
		TrayToggle.NativeFieldInfoPtr_m_resetPositionOnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, "m_resetPositionOnOpen");
		TrayToggle.NativeFieldInfoPtr_m_scrollRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, "m_scrollRects");
		TrayToggle.NativeFieldInfoPtr_m_audioManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, "m_audioManager");
		TrayToggle.NativeFieldInfoPtr_m_bTrayOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, "m_bTrayOpen");
		TrayToggle.NativeMethodInfoPtr_GetOwnerIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, 100664714);
		TrayToggle.NativeMethodInfoPtr_IsTrayOpen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, 100664715);
		TrayToggle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, 100664716);
		TrayToggle.NativeMethodInfoPtr_TrayState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, 100664717);
		TrayToggle.NativeMethodInfoPtr_SetTrayState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, 100664718);
		TrayToggle.NativeMethodInfoPtr_UpdateTrayState_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, 100664719);
		TrayToggle.NativeMethodInfoPtr_CheckCloseTrays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, 100664720);
		TrayToggle.NativeMethodInfoPtr_CloseOtherTrays_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, 100664721);
		TrayToggle.NativeMethodInfoPtr_ResetScrollPosition_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, 100664722);
		TrayToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, 100664723);
	}

	// Token: 0x06001239 RID: 4665 RVA: 0x00050FB0 File Offset: 0x0004F1B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetOwnerIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle.NativeMethodInfoPtr_GetOwnerIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600123A RID: 4666 RVA: 0x00050FEC File Offset: 0x0004F1EC
	[CallerCount(0)]
	public unsafe bool IsTrayOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle.NativeMethodInfoPtr_IsTrayOpen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x00051028 File Offset: 0x0004F228
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243336, XrefRangeEnd = 243346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x0005105C File Offset: 0x0004F25C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 243346, RefRangeEnd = 243350, XrefRangeStart = 243346, XrefRangeEnd = 243346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TrayState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle.NativeMethodInfoPtr_TrayState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x00051090 File Offset: 0x0004F290
	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 243350, RefRangeEnd = 243373, XrefRangeStart = 243350, XrefRangeEnd = 243350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTrayState(bool bOpen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle.NativeMethodInfoPtr_SetTrayState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x000510D0 File Offset: 0x0004F2D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243392, RefRangeEnd = 243393, XrefRangeStart = 243373, XrefRangeEnd = 243392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UpdateTrayState(bool bPlayAudio = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bPlayAudio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrayToggle.NativeMethodInfoPtr_UpdateTrayState_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x0005111C File Offset: 0x0004F31C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243393, XrefRangeEnd = 243394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckCloseTrays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle.NativeMethodInfoPtr_CheckCloseTrays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00051150 File Offset: 0x0004F350
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 243395, RefRangeEnd = 243398, XrefRangeStart = 243394, XrefRangeEnd = 243395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseOtherTrays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle.NativeMethodInfoPtr_CloseOtherTrays_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00051184 File Offset: 0x0004F384
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243398, XrefRangeEnd = 243402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ResetScrollPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle.NativeMethodInfoPtr_ResetScrollPosition_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x000511C4 File Offset: 0x0004F3C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243402, XrefRangeEnd = 243403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TrayToggle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x0000C2A7 File Offset: 0x0000A4A7
	public TrayToggle(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005DC RID: 1500
	// (get) Token: 0x06001244 RID: 4676 RVA: 0x00051200 File Offset: 0x0004F400
	// (set) Token: 0x06001245 RID: 4677 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
	public unsafe Animator tray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_tray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_tray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005DD RID: 1501
	// (get) Token: 0x06001246 RID: 4678 RVA: 0x00051230 File Offset: 0x0004F430
	// (set) Token: 0x06001247 RID: 4679 RVA: 0x0000C2CF File Offset: 0x0000A4CF
	public unsafe Il2CppReferenceArray<TrayToggle> m_CloseOtherTrays
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_CloseOtherTrays);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrayToggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_CloseOtherTrays), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005DE RID: 1502
	// (get) Token: 0x06001248 RID: 4680 RVA: 0x00051260 File Offset: 0x0004F460
	// (set) Token: 0x06001249 RID: 4681 RVA: 0x0000C2EE File Offset: 0x0000A4EE
	public unsafe int m_ownerIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_ownerIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_ownerIndex)) = value;
		}
	}

	// Token: 0x170005DF RID: 1503
	// (get) Token: 0x0600124A RID: 4682 RVA: 0x00051288 File Offset: 0x0004F488
	// (set) Token: 0x0600124B RID: 4683 RVA: 0x0000C309 File Offset: 0x0000A509
	public unsafe bool m_trayStartHidden
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_trayStartHidden);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_trayStartHidden)) = value;
		}
	}

	// Token: 0x170005E0 RID: 1504
	// (get) Token: 0x0600124C RID: 4684 RVA: 0x000512B0 File Offset: 0x0004F4B0
	// (set) Token: 0x0600124D RID: 4685 RVA: 0x0000C324 File Offset: 0x0000A524
	public unsafe TrayToggle.ResetScrollPositionEnum m_resetPositionOnOpen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_resetPositionOnOpen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_resetPositionOnOpen)) = value;
		}
	}

	// Token: 0x170005E1 RID: 1505
	// (get) Token: 0x0600124E RID: 4686 RVA: 0x000512D8 File Offset: 0x0004F4D8
	// (set) Token: 0x0600124F RID: 4687 RVA: 0x0000C33F File Offset: 0x0000A53F
	public unsafe Il2CppReferenceArray<ScrollRect> m_scrollRects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_scrollRects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScrollRect>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_scrollRects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E2 RID: 1506
	// (get) Token: 0x06001250 RID: 4688 RVA: 0x00051308 File Offset: 0x0004F508
	// (set) Token: 0x06001251 RID: 4689 RVA: 0x0000C35E File Offset: 0x0000A55E
	public unsafe AscensionAudioHandlerIngame m_audioManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_audioManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAudioHandlerIngame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_audioManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005E3 RID: 1507
	// (get) Token: 0x06001252 RID: 4690 RVA: 0x00051338 File Offset: 0x0004F538
	// (set) Token: 0x06001253 RID: 4691 RVA: 0x0000C37D File Offset: 0x0000A57D
	public unsafe bool m_bTrayOpen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_bTrayOpen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle.NativeFieldInfoPtr_m_bTrayOpen)) = value;
		}
	}

	// Token: 0x04000CC2 RID: 3266
	private static readonly IntPtr NativeFieldInfoPtr_tray;

	// Token: 0x04000CC3 RID: 3267
	private static readonly IntPtr NativeFieldInfoPtr_m_CloseOtherTrays;

	// Token: 0x04000CC4 RID: 3268
	private static readonly IntPtr NativeFieldInfoPtr_m_ownerIndex;

	// Token: 0x04000CC5 RID: 3269
	private static readonly IntPtr NativeFieldInfoPtr_m_trayStartHidden;

	// Token: 0x04000CC6 RID: 3270
	private static readonly IntPtr NativeFieldInfoPtr_m_resetPositionOnOpen;

	// Token: 0x04000CC7 RID: 3271
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollRects;

	// Token: 0x04000CC8 RID: 3272
	private static readonly IntPtr NativeFieldInfoPtr_m_audioManager;

	// Token: 0x04000CC9 RID: 3273
	private static readonly IntPtr NativeFieldInfoPtr_m_bTrayOpen;

	// Token: 0x04000CCA RID: 3274
	private static readonly IntPtr NativeMethodInfoPtr_GetOwnerIndex_Public_Int32_0;

	// Token: 0x04000CCB RID: 3275
	private static readonly IntPtr NativeMethodInfoPtr_IsTrayOpen_Public_Boolean_0;

	// Token: 0x04000CCC RID: 3276
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000CCD RID: 3277
	private static readonly IntPtr NativeMethodInfoPtr_TrayState_Public_Void_0;

	// Token: 0x04000CCE RID: 3278
	private static readonly IntPtr NativeMethodInfoPtr_SetTrayState_Public_Void_Boolean_0;

	// Token: 0x04000CCF RID: 3279
	private static readonly IntPtr NativeMethodInfoPtr_UpdateTrayState_Protected_Virtual_New_Void_Boolean_0;

	// Token: 0x04000CD0 RID: 3280
	private static readonly IntPtr NativeMethodInfoPtr_CheckCloseTrays_Private_Void_0;

	// Token: 0x04000CD1 RID: 3281
	private static readonly IntPtr NativeMethodInfoPtr_CloseOtherTrays_Public_Void_0;

	// Token: 0x04000CD2 RID: 3282
	private static readonly IntPtr NativeMethodInfoPtr_ResetScrollPosition_Private_IEnumerator_0;

	// Token: 0x04000CD3 RID: 3283
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200019F RID: 415
	public enum ResetScrollPositionEnum
	{
		// Token: 0x0400197D RID: 6525
		None,
		// Token: 0x0400197E RID: 6526
		Left,
		// Token: 0x0400197F RID: 6527
		Right
	}

	// Token: 0x020001A0 RID: 416
	[ObfuscatedName("TrayToggle+<ResetScrollPosition>d__17")]
	public sealed class _ResetScrollPosition_d__17 : global::Il2CppSystem.Object
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x00088AF0 File Offset: 0x00086CF0
		// Note: this type is marked as 'beforefieldinit'.
		static _ResetScrollPosition_d__17()
		{
			Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrayToggle>.NativeClassPtr, "<ResetScrollPosition>d__17");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr);
			TrayToggle._ResetScrollPosition_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr, "<>1__state");
			TrayToggle._ResetScrollPosition_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr, "<>2__current");
			TrayToggle._ResetScrollPosition_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr, "<>4__this");
			TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr, 100666226);
			TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr, 100666227);
			TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr, 100666228);
			TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr, 100666229);
			TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr, 100666230);
			TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr, 100666231);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00088BD0 File Offset: 0x00086DD0
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ResetScrollPosition_d__17(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrayToggle._ResetScrollPosition_d__17>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00088C18 File Offset: 0x00086E18
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00088C4C File Offset: 0x00086E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243326, XrefRangeEnd = 243331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x00088C88 File Offset: 0x00086E88
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00088CC8 File Offset: 0x00086EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243331, XrefRangeEnd = 243336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x00088CFC File Offset: 0x00086EFC
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle._ResetScrollPosition_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00016D2D File Offset: 0x00014F2D
		public _ResetScrollPosition_d__17(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x00088D3C File Offset: 0x00086F3C
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x00016D36 File Offset: 0x00014F36
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle._ResetScrollPosition_d__17.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle._ResetScrollPosition_d__17.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x00088D64 File Offset: 0x00086F64
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x00016D51 File Offset: 0x00014F51
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle._ResetScrollPosition_d__17.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle._ResetScrollPosition_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x00088D94 File Offset: 0x00086F94
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x00016D70 File Offset: 0x00014F70
		public unsafe TrayToggle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle._ResetScrollPosition_d__17.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle._ResetScrollPosition_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
