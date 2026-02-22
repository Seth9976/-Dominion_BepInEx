using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200002B RID: 43
public class CardOverlay_Akam : CardOverlay
{
	// Token: 0x060008DB RID: 2267 RVA: 0x00034070 File Offset: 0x00032270
	// Note: this type is marked as 'beforefieldinit'.
	static CardOverlay_Akam()
	{
		Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardOverlay_Akam");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr);
		CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr, "m_WishNode1");
		CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode1_Glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr, "m_WishNode1_Glow");
		CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr, "m_WishNode2");
		CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode2_Glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr, "m_WishNode2_Glow");
		CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr, "m_WishNode3");
		CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode3_Glow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr, "m_WishNode3_Glow");
		CardOverlay_Akam.NativeMethodInfoPtr_SetData_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr, 100663893);
		CardOverlay_Akam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr, 100663894);
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x00034140 File Offset: 0x00032340
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235308, XrefRangeEnd = 235315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetData(int data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardOverlay_Akam.NativeMethodInfoPtr_SetData_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x0003418C File Offset: 0x0003238C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardOverlay_Akam()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardOverlay_Akam>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardOverlay_Akam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x00007803 File Offset: 0x00005A03
	public CardOverlay_Akam(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x060008DF RID: 2271 RVA: 0x000341C8 File Offset: 0x000323C8
	// (set) Token: 0x060008E0 RID: 2272 RVA: 0x0000780C File Offset: 0x00005A0C
	public unsafe GameObject m_WishNode1
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode1);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode1), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x060008E1 RID: 2273 RVA: 0x000341F8 File Offset: 0x000323F8
	// (set) Token: 0x060008E2 RID: 2274 RVA: 0x0000782B File Offset: 0x00005A2B
	public unsafe GameObject m_WishNode1_Glow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode1_Glow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode1_Glow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00034228 File Offset: 0x00032428
	// (set) Token: 0x060008E4 RID: 2276 RVA: 0x0000784A File Offset: 0x00005A4A
	public unsafe GameObject m_WishNode2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode2);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode2), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00034258 File Offset: 0x00032458
	// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00007869 File Offset: 0x00005A69
	public unsafe GameObject m_WishNode2_Glow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode2_Glow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode2_Glow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00034288 File Offset: 0x00032488
	// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00007888 File Offset: 0x00005A88
	public unsafe GameObject m_WishNode3
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode3);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode3), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x060008E9 RID: 2281 RVA: 0x000342B8 File Offset: 0x000324B8
	// (set) Token: 0x060008EA RID: 2282 RVA: 0x000078A7 File Offset: 0x00005AA7
	public unsafe GameObject m_WishNode3_Glow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode3_Glow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Akam.NativeFieldInfoPtr_m_WishNode3_Glow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000584 RID: 1412
	private static readonly IntPtr NativeFieldInfoPtr_m_WishNode1;

	// Token: 0x04000585 RID: 1413
	private static readonly IntPtr NativeFieldInfoPtr_m_WishNode1_Glow;

	// Token: 0x04000586 RID: 1414
	private static readonly IntPtr NativeFieldInfoPtr_m_WishNode2;

	// Token: 0x04000587 RID: 1415
	private static readonly IntPtr NativeFieldInfoPtr_m_WishNode2_Glow;

	// Token: 0x04000588 RID: 1416
	private static readonly IntPtr NativeFieldInfoPtr_m_WishNode3;

	// Token: 0x04000589 RID: 1417
	private static readonly IntPtr NativeFieldInfoPtr_m_WishNode3_Glow;

	// Token: 0x0400058A RID: 1418
	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Virtual_Void_Int32_0;

	// Token: 0x0400058B RID: 1419
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
