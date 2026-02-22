using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000CD RID: 205
public class UI_Credits : MonoBehaviour
{
	// Token: 0x060018A8 RID: 6312 RVA: 0x000643B8 File Offset: 0x000625B8
	// Note: this type is marked as 'beforefieldinit'.
	static UI_Credits()
	{
		Il2CppClassPointerStore<UI_Credits>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_Credits");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Credits>.NativeClassPtr);
		UI_Credits.NativeFieldInfoPtr_m_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Credits>.NativeClassPtr, "m_scrollRect");
		UI_Credits.NativeFieldInfoPtr_m_bCheckUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Credits>.NativeClassPtr, "m_bCheckUpdate");
		UI_Credits.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Credits>.NativeClassPtr, 100665251);
		UI_Credits.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Credits>.NativeClassPtr, 100665252);
		UI_Credits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Credits>.NativeClassPtr, 100665253);
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x0006444C File Offset: 0x0006264C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249641, XrefRangeEnd = 249642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Credits.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x00064480 File Offset: 0x00062680
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Credits.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060018AB RID: 6315 RVA: 0x000644C0 File Offset: 0x000626C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_Credits()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Credits>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Credits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018AC RID: 6316 RVA: 0x0000FE26 File Offset: 0x0000E026
	public UI_Credits(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170007DE RID: 2014
	// (get) Token: 0x060018AD RID: 6317 RVA: 0x000644FC File Offset: 0x000626FC
	// (set) Token: 0x060018AE RID: 6318 RVA: 0x0000FE2F File Offset: 0x0000E02F
	public unsafe ScrollRect_AutoScroll m_scrollRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Credits.NativeFieldInfoPtr_m_scrollRect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect_AutoScroll>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Credits.NativeFieldInfoPtr_m_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007DF RID: 2015
	// (get) Token: 0x060018AF RID: 6319 RVA: 0x0006452C File Offset: 0x0006272C
	// (set) Token: 0x060018B0 RID: 6320 RVA: 0x0000FE4E File Offset: 0x0000E04E
	public unsafe bool m_bCheckUpdate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Credits.NativeFieldInfoPtr_m_bCheckUpdate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Credits.NativeFieldInfoPtr_m_bCheckUpdate)) = value;
		}
	}

	// Token: 0x040010D3 RID: 4307
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollRect;

	// Token: 0x040010D4 RID: 4308
	private static readonly IntPtr NativeFieldInfoPtr_m_bCheckUpdate;

	// Token: 0x040010D5 RID: 4309
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x040010D6 RID: 4310
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x040010D7 RID: 4311
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
