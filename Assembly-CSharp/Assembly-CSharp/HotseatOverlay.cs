using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;

// Token: 0x02000034 RID: 52
public class HotseatOverlay : MonoBehaviour
{
	// Token: 0x0600097D RID: 2429 RVA: 0x00035F24 File Offset: 0x00034124
	// Note: this type is marked as 'beforefieldinit'.
	static HotseatOverlay()
	{
		Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HotseatOverlay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr);
		HotseatOverlay.NativeFieldInfoPtr_m_HotseatBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, "m_HotseatBase");
		HotseatOverlay.NativeFieldInfoPtr_m_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, "m_Animator");
		HotseatOverlay.NativeFieldInfoPtr_m_waitTimeToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, "m_waitTimeToDisable");
		HotseatOverlay.NativeFieldInfoPtr_m_HotseatName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, "m_HotseatName");
		HotseatOverlay.NativeFieldInfoPtr_m_HotseatAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, "m_HotseatAvatar");
		HotseatOverlay.NativeFieldInfoPtr_m_HotseatColorizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, "m_HotseatColorizer");
		HotseatOverlay.NativeFieldInfoPtr_m_bIsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, "m_bIsHidden");
		HotseatOverlay.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, 100663948);
		HotseatOverlay.NativeMethodInfoPtr_IsVisible_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, 100663949);
		HotseatOverlay.NativeMethodInfoPtr_SetIsVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, 100663950);
		HotseatOverlay.NativeMethodInfoPtr_TurnOn_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, 100663951);
		HotseatOverlay.NativeMethodInfoPtr_TurnOff_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, 100663952);
		HotseatOverlay.NativeMethodInfoPtr_SetData_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, 100663953);
		HotseatOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, 100663954);
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x0003606C File Offset: 0x0003426C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x000360A0 File Offset: 0x000342A0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235778, RefRangeEnd = 235780, XrefRangeStart = 235776, XrefRangeEnd = 235778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsVisible()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay.NativeMethodInfoPtr_IsVisible_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x000360DC File Offset: 0x000342DC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235783, RefRangeEnd = 235786, XrefRangeStart = 235780, XrefRangeEnd = 235783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsVisible(bool bVisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay.NativeMethodInfoPtr_SetIsVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x0003611C File Offset: 0x0003431C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235786, XrefRangeEnd = 235790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator TurnOn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay.NativeMethodInfoPtr_TurnOn_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x0003615C File Offset: 0x0003435C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235790, XrefRangeEnd = 235794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator TurnOff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay.NativeMethodInfoPtr_TurnOff_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x0003619C File Offset: 0x0003439C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235797, RefRangeEnd = 235799, XrefRangeStart = 235794, XrefRangeEnd = 235797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(string name, int avatarIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref avatarIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay.NativeMethodInfoPtr_SetData_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x000361EC File Offset: 0x000343EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235799, XrefRangeEnd = 235800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HotseatOverlay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00007D3F File Offset: 0x00005F3F
	public HotseatOverlay(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x06000986 RID: 2438 RVA: 0x00036228 File Offset: 0x00034428
	// (set) Token: 0x06000987 RID: 2439 RVA: 0x00007D48 File Offset: 0x00005F48
	public unsafe GameObject m_HotseatBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_HotseatBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_HotseatBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000351 RID: 849
	// (get) Token: 0x06000988 RID: 2440 RVA: 0x00036258 File Offset: 0x00034458
	// (set) Token: 0x06000989 RID: 2441 RVA: 0x00007D67 File Offset: 0x00005F67
	public unsafe Animator m_Animator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_Animator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x0600098A RID: 2442 RVA: 0x00036288 File Offset: 0x00034488
	// (set) Token: 0x0600098B RID: 2443 RVA: 0x00007D86 File Offset: 0x00005F86
	public unsafe float m_waitTimeToDisable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_waitTimeToDisable);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_waitTimeToDisable)) = value;
		}
	}

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x0600098C RID: 2444 RVA: 0x000362B0 File Offset: 0x000344B0
	// (set) Token: 0x0600098D RID: 2445 RVA: 0x00007DA1 File Offset: 0x00005FA1
	public unsafe TextMeshProUGUI m_HotseatName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_HotseatName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_HotseatName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000354 RID: 852
	// (get) Token: 0x0600098E RID: 2446 RVA: 0x000362E0 File Offset: 0x000344E0
	// (set) Token: 0x0600098F RID: 2447 RVA: 0x00007DC0 File Offset: 0x00005FC0
	public unsafe Avatar_UI m_HotseatAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_HotseatAvatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_HotseatAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000355 RID: 853
	// (get) Token: 0x06000990 RID: 2448 RVA: 0x00036310 File Offset: 0x00034510
	// (set) Token: 0x06000991 RID: 2449 RVA: 0x00007DDF File Offset: 0x00005FDF
	public unsafe ColorByFaction m_HotseatColorizer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_HotseatColorizer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorByFaction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_HotseatColorizer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x06000992 RID: 2450 RVA: 0x00036340 File Offset: 0x00034540
	// (set) Token: 0x06000993 RID: 2451 RVA: 0x00007DFE File Offset: 0x00005FFE
	public unsafe bool m_bIsHidden
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_bIsHidden);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay.NativeFieldInfoPtr_m_bIsHidden)) = value;
		}
	}

	// Token: 0x040005E7 RID: 1511
	private static readonly IntPtr NativeFieldInfoPtr_m_HotseatBase;

	// Token: 0x040005E8 RID: 1512
	private static readonly IntPtr NativeFieldInfoPtr_m_Animator;

	// Token: 0x040005E9 RID: 1513
	private static readonly IntPtr NativeFieldInfoPtr_m_waitTimeToDisable;

	// Token: 0x040005EA RID: 1514
	private static readonly IntPtr NativeFieldInfoPtr_m_HotseatName;

	// Token: 0x040005EB RID: 1515
	private static readonly IntPtr NativeFieldInfoPtr_m_HotseatAvatar;

	// Token: 0x040005EC RID: 1516
	private static readonly IntPtr NativeFieldInfoPtr_m_HotseatColorizer;

	// Token: 0x040005ED RID: 1517
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsHidden;

	// Token: 0x040005EE RID: 1518
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040005EF RID: 1519
	private static readonly IntPtr NativeMethodInfoPtr_IsVisible_Public_Boolean_0;

	// Token: 0x040005F0 RID: 1520
	private static readonly IntPtr NativeMethodInfoPtr_SetIsVisible_Public_Void_Boolean_0;

	// Token: 0x040005F1 RID: 1521
	private static readonly IntPtr NativeMethodInfoPtr_TurnOn_Private_IEnumerator_0;

	// Token: 0x040005F2 RID: 1522
	private static readonly IntPtr NativeMethodInfoPtr_TurnOff_Private_IEnumerator_0;

	// Token: 0x040005F3 RID: 1523
	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_String_Int32_0;

	// Token: 0x040005F4 RID: 1524
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200017B RID: 379
	[ObfuscatedName("HotseatOverlay+<TurnOn>d__10")]
	public sealed class _TurnOn_d__10 : global::Il2CppSystem.Object
	{
		// Token: 0x0600238A RID: 9098 RVA: 0x00084DD8 File Offset: 0x00082FD8
		// Note: this type is marked as 'beforefieldinit'.
		static _TurnOn_d__10()
		{
			Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, "<TurnOn>d__10");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr);
			HotseatOverlay._TurnOn_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr, "<>1__state");
			HotseatOverlay._TurnOn_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr, "<>2__current");
			HotseatOverlay._TurnOn_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr, "<>4__this");
			HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr, 100666116);
			HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr, 100666117);
			HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr, 100666118);
			HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr, 100666119);
			HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr, 100666120);
			HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr, 100666121);
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00084EB8 File Offset: 0x000830B8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _TurnOn_d__10(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotseatOverlay._TurnOn_d__10>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00084F00 File Offset: 0x00083100
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00084F34 File Offset: 0x00083134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235757, XrefRangeEnd = 235762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x00084F70 File Offset: 0x00083170
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00084FB0 File Offset: 0x000831B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235762, XrefRangeEnd = 235767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x00084FE4 File Offset: 0x000831E4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0001635C File Offset: 0x0001455C
		public _TurnOn_d__10(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x00085024 File Offset: 0x00083224
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x00016365 File Offset: 0x00014565
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOn_d__10.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOn_d__10.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x0008504C File Offset: 0x0008324C
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x00016380 File Offset: 0x00014580
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOn_d__10.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOn_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0008507C File Offset: 0x0008327C
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x0001639F File Offset: 0x0001459F
		public unsafe HotseatOverlay __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOn_d__10.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotseatOverlay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOn_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200017C RID: 380
	[ObfuscatedName("HotseatOverlay+<TurnOff>d__11")]
	public sealed class _TurnOff_d__11 : global::Il2CppSystem.Object
	{
		// Token: 0x06002398 RID: 9112 RVA: 0x000850AC File Offset: 0x000832AC
		// Note: this type is marked as 'beforefieldinit'.
		static _TurnOff_d__11()
		{
			Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HotseatOverlay>.NativeClassPtr, "<TurnOff>d__11");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr);
			HotseatOverlay._TurnOff_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr, "<>1__state");
			HotseatOverlay._TurnOff_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr, "<>2__current");
			HotseatOverlay._TurnOff_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr, "<>4__this");
			HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr, 100666122);
			HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr, 100666123);
			HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr, 100666124);
			HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr, 100666125);
			HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr, 100666126);
			HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr, 100666127);
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x0008518C File Offset: 0x0008338C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _TurnOff_d__11(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotseatOverlay._TurnOff_d__11>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x000851D4 File Offset: 0x000833D4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00085208 File Offset: 0x00083408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235767, XrefRangeEnd = 235771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x00085244 File Offset: 0x00083444
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00085284 File Offset: 0x00083484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235771, XrefRangeEnd = 235776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x000852B8 File Offset: 0x000834B8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotseatOverlay._TurnOff_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000163BE File Offset: 0x000145BE
		public _TurnOff_d__11(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x000852F8 File Offset: 0x000834F8
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x000163C7 File Offset: 0x000145C7
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOff_d__11.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOff_d__11.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x00085320 File Offset: 0x00083520
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x000163E2 File Offset: 0x000145E2
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOff_d__11.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOff_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x00085350 File Offset: 0x00083550
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x00016401 File Offset: 0x00014601
		public unsafe HotseatOverlay __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOff_d__11.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotseatOverlay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotseatOverlay._TurnOff_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
