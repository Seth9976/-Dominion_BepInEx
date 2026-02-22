using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200002F RID: 47
public class GameOptionButton : MonoBehaviour
{
	// Token: 0x06000914 RID: 2324 RVA: 0x00034980 File Offset: 0x00032B80
	// Note: this type is marked as 'beforefieldinit'.
	static GameOptionButton()
	{
		Il2CppClassPointerStore<GameOptionButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameOptionButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOptionButton>.NativeClassPtr);
		GameOptionButton.NativeFieldInfoPtr_m_ActivateHintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionButton>.NativeClassPtr, "m_ActivateHintType");
		GameOptionButton.NativeFieldInfoPtr_m_ActivateOptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionButton>.NativeClassPtr, "m_ActivateOptionText");
		GameOptionButton.NativeMethodInfoPtr_SetAvailable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionButton>.NativeClassPtr, 100663904);
		GameOptionButton.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionButton>.NativeClassPtr, 100663905);
		GameOptionButton.NativeMethodInfoPtr_OnGameOptionButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionButton>.NativeClassPtr, 100663906);
		GameOptionButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionButton>.NativeClassPtr, 100663907);
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00034A28 File Offset: 0x00032C28
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 235352, RefRangeEnd = 235360, XrefRangeStart = 235349, XrefRangeEnd = 235352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAvailable(bool bAvailable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bAvailable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionButton.NativeMethodInfoPtr_SetAvailable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00034A68 File Offset: 0x00032C68
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235376, RefRangeEnd = 235377, XrefRangeStart = 235360, XrefRangeEnd = 235376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSelectionState(bool bHighlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionButton.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00034AA8 File Offset: 0x00032CA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235377, XrefRangeEnd = 235379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameOptionButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionButton.NativeMethodInfoPtr_OnGameOptionButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x00034ADC File Offset: 0x00032CDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235379, XrefRangeEnd = 235380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameOptionButton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameOptionButton>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x00007A54 File Offset: 0x00005C54
	public GameOptionButton(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000337 RID: 823
	// (get) Token: 0x0600091A RID: 2330 RVA: 0x00034B18 File Offset: 0x00032D18
	// (set) Token: 0x0600091B RID: 2331 RVA: 0x00007A5D File Offset: 0x00005C5D
	public unsafe GameOptionButton.GameOptionButtonHintType m_ActivateHintType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionButton.NativeFieldInfoPtr_m_ActivateHintType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionButton.NativeFieldInfoPtr_m_ActivateHintType)) = value;
		}
	}

	// Token: 0x17000338 RID: 824
	// (get) Token: 0x0600091C RID: 2332 RVA: 0x00034B40 File Offset: 0x00032D40
	// (set) Token: 0x0600091D RID: 2333 RVA: 0x00007A78 File Offset: 0x00005C78
	public unsafe string m_ActivateOptionText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionButton.NativeFieldInfoPtr_m_ActivateOptionText);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionButton.NativeFieldInfoPtr_m_ActivateOptionText), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040005A2 RID: 1442
	private static readonly IntPtr NativeFieldInfoPtr_m_ActivateHintType;

	// Token: 0x040005A3 RID: 1443
	private static readonly IntPtr NativeFieldInfoPtr_m_ActivateOptionText;

	// Token: 0x040005A4 RID: 1444
	private static readonly IntPtr NativeMethodInfoPtr_SetAvailable_Public_Void_Boolean_0;

	// Token: 0x040005A5 RID: 1445
	private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0;

	// Token: 0x040005A6 RID: 1446
	private static readonly IntPtr NativeMethodInfoPtr_OnGameOptionButtonPressed_Public_Void_0;

	// Token: 0x040005A7 RID: 1447
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000179 RID: 377
	public enum GameOptionButtonHintType
	{
		// Token: 0x04001896 RID: 6294
		CHOOSE_EFFECT = 41088,
		// Token: 0x04001897 RID: 6295
		YES = 41200,
		// Token: 0x04001898 RID: 6296
		NO,
		// Token: 0x04001899 RID: 6297
		CHOOSE_FACTION_ENLIGHTENED = 41104,
		// Token: 0x0400189A RID: 6298
		CHOOSE_FACTION_LIFEBOUND,
		// Token: 0x0400189B RID: 6299
		CHOOSE_FACTION_MECHANA,
		// Token: 0x0400189C RID: 6300
		CHOOSE_FACTION_VOID,
		// Token: 0x0400189D RID: 6301
		ADD_CARD_TO_DREAMSCAPE = 41169
	}
}
