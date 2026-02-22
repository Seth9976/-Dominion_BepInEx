using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000C1 RID: 193
public class UI_GameWaitingIcon : MonoBehaviour
{
	// Token: 0x06001756 RID: 5974 RVA: 0x00060798 File Offset: 0x0005E998
	// Note: this type is marked as 'beforefieldinit'.
	static UI_GameWaitingIcon()
	{
		Il2CppClassPointerStore<UI_GameWaitingIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_GameWaitingIcon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_GameWaitingIcon>.NativeClassPtr);
		UI_GameWaitingIcon.NativeFieldInfoPtr_m_gameWaitingIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_GameWaitingIcon>.NativeClassPtr, "m_gameWaitingIcon");
		UI_GameWaitingIcon.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_GameWaitingIcon>.NativeClassPtr, 100665155);
		UI_GameWaitingIcon.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_GameWaitingIcon>.NativeClassPtr, 100665156);
		UI_GameWaitingIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_GameWaitingIcon>.NativeClassPtr, 100665157);
	}

	// Token: 0x06001757 RID: 5975 RVA: 0x00060818 File Offset: 0x0005EA18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248213, XrefRangeEnd = 248215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_GameWaitingIcon.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001758 RID: 5976 RVA: 0x0006084C File Offset: 0x0005EA4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248215, XrefRangeEnd = 248224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_GameWaitingIcon.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001759 RID: 5977 RVA: 0x00060880 File Offset: 0x0005EA80
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_GameWaitingIcon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_GameWaitingIcon>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_GameWaitingIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x0000F143 File Offset: 0x0000D343
	public UI_GameWaitingIcon(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700076F RID: 1903
	// (get) Token: 0x0600175B RID: 5979 RVA: 0x000608BC File Offset: 0x0005EABC
	// (set) Token: 0x0600175C RID: 5980 RVA: 0x0000F14C File Offset: 0x0000D34C
	public unsafe GameObject m_gameWaitingIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_GameWaitingIcon.NativeFieldInfoPtr_m_gameWaitingIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_GameWaitingIcon.NativeFieldInfoPtr_m_gameWaitingIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001007 RID: 4103
	private static readonly IntPtr NativeFieldInfoPtr_m_gameWaitingIcon;

	// Token: 0x04001008 RID: 4104
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04001009 RID: 4105
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400100A RID: 4106
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
