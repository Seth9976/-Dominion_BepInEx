using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000C0 RID: 192
public class UI_FrontEndAndInGameScene : MonoBehaviour
{
	// Token: 0x0600174C RID: 5964 RVA: 0x00060600 File Offset: 0x0005E800
	// Note: this type is marked as 'beforefieldinit'.
	static UI_FrontEndAndInGameScene()
	{
		Il2CppClassPointerStore<UI_FrontEndAndInGameScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_FrontEndAndInGameScene");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_FrontEndAndInGameScene>.NativeClassPtr);
		UI_FrontEndAndInGameScene.NativeFieldInfoPtr_m_frontEndObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FrontEndAndInGameScene>.NativeClassPtr, "m_frontEndObjects");
		UI_FrontEndAndInGameScene.NativeFieldInfoPtr_m_inGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FrontEndAndInGameScene>.NativeClassPtr, "m_inGameObjects");
		UI_FrontEndAndInGameScene.NativeFieldInfoPtr_bSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FrontEndAndInGameScene>.NativeClassPtr, "bSet");
		UI_FrontEndAndInGameScene.NativeMethodInfoPtr_SetIsInGame_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FrontEndAndInGameScene>.NativeClassPtr, 100665153);
		UI_FrontEndAndInGameScene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FrontEndAndInGameScene>.NativeClassPtr, 100665154);
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x00060694 File Offset: 0x0005E894
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 248208, RefRangeEnd = 248213, XrefRangeStart = 248204, XrefRangeEnd = 248208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsInGame(bool bInGame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bInGame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FrontEndAndInGameScene.NativeMethodInfoPtr_SetIsInGame_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x000606D4 File Offset: 0x0005E8D4
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_FrontEndAndInGameScene()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_FrontEndAndInGameScene>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FrontEndAndInGameScene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x0000F0E1 File Offset: 0x0000D2E1
	public UI_FrontEndAndInGameScene(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700076C RID: 1900
	// (get) Token: 0x06001750 RID: 5968 RVA: 0x00060710 File Offset: 0x0005E910
	// (set) Token: 0x06001751 RID: 5969 RVA: 0x0000F0EA File Offset: 0x0000D2EA
	public unsafe Il2CppReferenceArray<GameObject> m_frontEndObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FrontEndAndInGameScene.NativeFieldInfoPtr_m_frontEndObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FrontEndAndInGameScene.NativeFieldInfoPtr_m_frontEndObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700076D RID: 1901
	// (get) Token: 0x06001752 RID: 5970 RVA: 0x00060740 File Offset: 0x0005E940
	// (set) Token: 0x06001753 RID: 5971 RVA: 0x0000F109 File Offset: 0x0000D309
	public unsafe Il2CppReferenceArray<GameObject> m_inGameObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FrontEndAndInGameScene.NativeFieldInfoPtr_m_inGameObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FrontEndAndInGameScene.NativeFieldInfoPtr_m_inGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700076E RID: 1902
	// (get) Token: 0x06001754 RID: 5972 RVA: 0x00060770 File Offset: 0x0005E970
	// (set) Token: 0x06001755 RID: 5973 RVA: 0x0000F128 File Offset: 0x0000D328
	public unsafe bool bSet
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FrontEndAndInGameScene.NativeFieldInfoPtr_bSet);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FrontEndAndInGameScene.NativeFieldInfoPtr_bSet)) = value;
		}
	}

	// Token: 0x04001002 RID: 4098
	private static readonly IntPtr NativeFieldInfoPtr_m_frontEndObjects;

	// Token: 0x04001003 RID: 4099
	private static readonly IntPtr NativeFieldInfoPtr_m_inGameObjects;

	// Token: 0x04001004 RID: 4100
	private static readonly IntPtr NativeFieldInfoPtr_bSet;

	// Token: 0x04001005 RID: 4101
	private static readonly IntPtr NativeMethodInfoPtr_SetIsInGame_Public_Void_Boolean_0;

	// Token: 0x04001006 RID: 4102
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
