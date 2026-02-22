using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000AA RID: 170
public class RegisterPopup : MonoBehaviour
{
	// Token: 0x060013D8 RID: 5080 RVA: 0x00056138 File Offset: 0x00054338
	// Note: this type is marked as 'beforefieldinit'.
	static RegisterPopup()
	{
		Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RegisterPopup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr);
		RegisterPopup.NativeFieldInfoPtr_popupParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr, "popupParent");
		RegisterPopup.NativeFieldInfoPtr_popupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr, "popupName");
		RegisterPopup.NativeFieldInfoPtr_m_notify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr, "m_notify");
		RegisterPopup.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr, 100664879);
		RegisterPopup.NativeMethodInfoPtr_OpenPopup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr, 100664880);
		RegisterPopup.NativeMethodInfoPtr_PopupData_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr, 100664881);
		RegisterPopup.NativeMethodInfoPtr_ClosePopupConfirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr, 100664882);
		RegisterPopup.NativeMethodInfoPtr_ClosePopupCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr, 100664883);
		RegisterPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr, 100664884);
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x0005621C File Offset: 0x0005441C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244958, XrefRangeEnd = 244969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterPopup.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x00056250 File Offset: 0x00054450
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 244974, RefRangeEnd = 244975, XrefRangeStart = 244969, XrefRangeEnd = 244974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterPopup.NativeMethodInfoPtr_OpenPopup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x00056284 File Offset: 0x00054484
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244975, XrefRangeEnd = 244978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopupData(GameObject data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterPopup.NativeMethodInfoPtr_PopupData_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x000562C8 File Offset: 0x000544C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244978, XrefRangeEnd = 244983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClosePopupConfirm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterPopup.NativeMethodInfoPtr_ClosePopupConfirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x000562FC File Offset: 0x000544FC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 244988, RefRangeEnd = 244991, XrefRangeStart = 244983, XrefRangeEnd = 244988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClosePopupCancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterPopup.NativeMethodInfoPtr_ClosePopupCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x00056330 File Offset: 0x00054530
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegisterPopup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterPopup>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x0000CF97 File Offset: 0x0000B197
	public RegisterPopup(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700064C RID: 1612
	// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0005636C File Offset: 0x0005456C
	// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0000CFA0 File Offset: 0x0000B1A0
	public unsafe GameObject popupParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterPopup.NativeFieldInfoPtr_popupParent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterPopup.NativeFieldInfoPtr_popupParent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700064D RID: 1613
	// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0005639C File Offset: 0x0005459C
	// (set) Token: 0x060013E3 RID: 5091 RVA: 0x0000CFBF File Offset: 0x0000B1BF
	public unsafe string popupName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterPopup.NativeFieldInfoPtr_popupName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterPopup.NativeFieldInfoPtr_popupName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700064E RID: 1614
	// (get) Token: 0x060013E4 RID: 5092 RVA: 0x000563C4 File Offset: 0x000545C4
	// (set) Token: 0x060013E5 RID: 5093 RVA: 0x0000CFDE File Offset: 0x0000B1DE
	public unsafe INotifyParentMenu m_notify
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterPopup.NativeFieldInfoPtr_m_notify);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<INotifyParentMenu>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterPopup.NativeFieldInfoPtr_m_notify), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000DD7 RID: 3543
	private static readonly IntPtr NativeFieldInfoPtr_popupParent;

	// Token: 0x04000DD8 RID: 3544
	private static readonly IntPtr NativeFieldInfoPtr_popupName;

	// Token: 0x04000DD9 RID: 3545
	private static readonly IntPtr NativeFieldInfoPtr_m_notify;

	// Token: 0x04000DDA RID: 3546
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000DDB RID: 3547
	private static readonly IntPtr NativeMethodInfoPtr_OpenPopup_Public_Void_0;

	// Token: 0x04000DDC RID: 3548
	private static readonly IntPtr NativeMethodInfoPtr_PopupData_Public_Void_GameObject_0;

	// Token: 0x04000DDD RID: 3549
	private static readonly IntPtr NativeMethodInfoPtr_ClosePopupConfirm_Public_Void_0;

	// Token: 0x04000DDE RID: 3550
	private static readonly IntPtr NativeMethodInfoPtr_ClosePopupCancel_Public_Void_0;

	// Token: 0x04000DDF RID: 3551
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
