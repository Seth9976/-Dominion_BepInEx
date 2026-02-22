using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200002A RID: 42
public class CardOverlay : MonoBehaviour
{
	// Token: 0x060008D5 RID: 2261 RVA: 0x00033F00 File Offset: 0x00032100
	// Note: this type is marked as 'beforefieldinit'.
	static CardOverlay()
	{
		Il2CppClassPointerStore<CardOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardOverlay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardOverlay>.NativeClassPtr);
		CardOverlay.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardOverlay>.NativeClassPtr, 100663889);
		CardOverlay.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardOverlay>.NativeClassPtr, 100663890);
		CardOverlay.NativeMethodInfoPtr_SetData_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardOverlay>.NativeClassPtr, 100663891);
		CardOverlay.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardOverlay>.NativeClassPtr, 100663892);
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00033F80 File Offset: 0x00032180
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 183702, RefRangeEnd = 183706, XrefRangeStart = 183702, XrefRangeEnd = 183706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardOverlay.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x00033FB4 File Offset: 0x000321B4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 183709, RefRangeEnd = 183710, XrefRangeStart = 183709, XrefRangeEnd = 183710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardOverlay.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00033FE8 File Offset: 0x000321E8
	[CallerCount(0)]
	public unsafe virtual void SetData(int data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardOverlay.NativeMethodInfoPtr_SetData_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00034034 File Offset: 0x00032234
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardOverlay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardOverlay>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardOverlay.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x000077FA File Offset: 0x000059FA
	public CardOverlay(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000580 RID: 1408
	private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

	// Token: 0x04000581 RID: 1409
	private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

	// Token: 0x04000582 RID: 1410
	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Abstract_Virtual_New_Void_Int32_0;

	// Token: 0x04000583 RID: 1411
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}
