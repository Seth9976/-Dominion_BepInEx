using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

// Token: 0x0200002C RID: 44
public class CardOverlay_Generic : CardOverlay
{
	// Token: 0x060008EB RID: 2283 RVA: 0x000342E8 File Offset: 0x000324E8
	// Note: this type is marked as 'beforefieldinit'.
	static CardOverlay_Generic()
	{
		Il2CppClassPointerStore<CardOverlay_Generic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardOverlay_Generic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardOverlay_Generic>.NativeClassPtr);
		CardOverlay_Generic.NativeFieldInfoPtr_m_countText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardOverlay_Generic>.NativeClassPtr, "m_countText");
		CardOverlay_Generic.NativeMethodInfoPtr_SetData_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardOverlay_Generic>.NativeClassPtr, 100663895);
		CardOverlay_Generic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardOverlay_Generic>.NativeClassPtr, 100663896);
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00034354 File Offset: 0x00032554
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235315, XrefRangeEnd = 235316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetData(int data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardOverlay_Generic.NativeMethodInfoPtr_SetData_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x000343A0 File Offset: 0x000325A0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardOverlay_Generic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardOverlay_Generic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardOverlay_Generic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x000078C6 File Offset: 0x00005AC6
	public CardOverlay_Generic(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x060008EF RID: 2287 RVA: 0x000343DC File Offset: 0x000325DC
	// (set) Token: 0x060008F0 RID: 2288 RVA: 0x000078CF File Offset: 0x00005ACF
	public unsafe TextMeshProUGUI m_countText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Generic.NativeFieldInfoPtr_m_countText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardOverlay_Generic.NativeFieldInfoPtr_m_countText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400058C RID: 1420
	private static readonly IntPtr NativeFieldInfoPtr_m_countText;

	// Token: 0x0400058D RID: 1421
	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Virtual_Void_Int32_0;

	// Token: 0x0400058E RID: 1422
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
