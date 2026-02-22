using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x020000D3 RID: 211
public class UI_Menu : MonoBehaviour
{
	// Token: 0x0600198B RID: 6539 RVA: 0x00066BB4 File Offset: 0x00064DB4
	// Note: this type is marked as 'beforefieldinit'.
	static UI_Menu()
	{
		Il2CppClassPointerStore<UI_Menu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_Menu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Menu>.NativeClassPtr);
		UI_Menu.NativeMethodInfoPtr_OnFaqPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Menu>.NativeClassPtr, 100665312);
		UI_Menu.NativeMethodInfoPtr_OnMoreGamesEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Menu>.NativeClassPtr, 100665313);
		UI_Menu.NativeMethodInfoPtr_OnMoreGamesExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Menu>.NativeClassPtr, 100665314);
		UI_Menu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Menu>.NativeClassPtr, 100665315);
	}

	// Token: 0x0600198C RID: 6540 RVA: 0x00066C34 File Offset: 0x00064E34
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFaqPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Menu.NativeMethodInfoPtr_OnFaqPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x00066C68 File Offset: 0x00064E68
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMoreGamesEnter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Menu.NativeMethodInfoPtr_OnMoreGamesEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600198E RID: 6542 RVA: 0x00066C9C File Offset: 0x00064E9C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMoreGamesExit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Menu.NativeMethodInfoPtr_OnMoreGamesExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600198F RID: 6543 RVA: 0x00066CD0 File Offset: 0x00064ED0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_Menu()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Menu>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Menu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x00010751 File Offset: 0x0000E951
	public UI_Menu(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400115D RID: 4445
	private static readonly IntPtr NativeMethodInfoPtr_OnFaqPressed_Public_Void_0;

	// Token: 0x0400115E RID: 4446
	private static readonly IntPtr NativeMethodInfoPtr_OnMoreGamesEnter_Public_Void_0;

	// Token: 0x0400115F RID: 4447
	private static readonly IntPtr NativeMethodInfoPtr_OnMoreGamesExit_Public_Void_0;

	// Token: 0x04001160 RID: 4448
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
