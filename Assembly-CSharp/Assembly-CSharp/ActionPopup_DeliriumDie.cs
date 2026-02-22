using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class ActionPopup_DeliriumDie : PopupBase
{
	// Token: 0x06000076 RID: 118 RVA: 0x0001C44C File Offset: 0x0001A64C
	// Note: this type is marked as 'beforefieldinit'.
	static ActionPopup_DeliriumDie()
	{
		Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ActionPopup_DeliriumDie");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr);
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_audioHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_audioHandler");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_deliriumDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_deliriumDie");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_slowRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_slowRotateSpeed");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_fastRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_fastRotateSpeed");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_accelerationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_accelerationTime");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_holdTimeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_holdTimeMin");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_holdTimeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_holdTimeMax");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_slowDownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_slowDownTime");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_titleText");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_infoText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_infoText");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_buttonCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_buttonCancel");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_buttonConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_buttonConfirm");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_buttonClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_buttonClose");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_finishPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_finishPositions");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_resultsStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_resultsStrings");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_dieMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_dieMode");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_storedResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_storedResults");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_currentRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_currentRotateSpeed");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_randomRotateVec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_randomRotateVec");
		ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_bBlockUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "m_bBlockUpdates");
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_DismissPopup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663347);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663348);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663349);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_SetNonBlockingMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663350);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_DisplayDecision_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663351);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_DisplayResults_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663352);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_ForceResultsEnd_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663353);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_OnConfirmButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663354);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_OnCancelButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663355);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_OnCloseButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663356);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663357);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_RotateRotator_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663358);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_StartResults_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663359);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr_RotateToTarget_Private_IEnumerator_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663360);
		ActionPopup_DeliriumDie.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, 100663361);
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0001C738 File Offset: 0x0001A938
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224431, XrefRangeEnd = 224435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DismissPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionPopup_DeliriumDie.NativeMethodInfoPtr_DismissPopup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0001C774 File Offset: 0x0001A974
	[CallerCount(0)]
	public unsafe override bool BlockGameUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionPopup_DeliriumDie.NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x0001C7BC File Offset: 0x0001A9BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224435, XrefRangeEnd = 224437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0001C7F0 File Offset: 0x0001A9F0
	[CallerCount(0)]
	public unsafe void SetNonBlockingMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_SetNonBlockingMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x0001C824 File Offset: 0x0001AA24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224437, XrefRangeEnd = 224458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayDecision()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_DisplayDecision_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0001C858 File Offset: 0x0001AA58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224458, XrefRangeEnd = 224487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayResults(int resultIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resultIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_DisplayResults_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0001C898 File Offset: 0x0001AA98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224487, XrefRangeEnd = 224508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceResultsEnd(int resultIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resultIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_ForceResultsEnd_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConfirmButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_OnConfirmButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0001C90C File Offset: 0x0001AB0C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCancelButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_OnCancelButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x0001C940 File Offset: 0x0001AB40
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCloseButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_OnCloseButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0001C974 File Offset: 0x0001AB74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224508, XrefRangeEnd = 224517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0001C9A8 File Offset: 0x0001ABA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224517, XrefRangeEnd = 224521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator RotateRotator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_RotateRotator_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224521, XrefRangeEnd = 224525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator StartResults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_StartResults_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x0001CA28 File Offset: 0x0001AC28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224525, XrefRangeEnd = 224529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator RotateToTarget(Vector3 targetRotate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref targetRotate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr_RotateToTarget_Private_IEnumerator_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0001CA74 File Offset: 0x0001AC74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224529, XrefRangeEnd = 224531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActionPopup_DeliriumDie()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000023A2 File Offset: 0x000005A2
	public ActionPopup_DeliriumDie(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000087 RID: 135 RVA: 0x0001CAB0 File Offset: 0x0001ACB0
	// (set) Token: 0x06000088 RID: 136 RVA: 0x000023AB File Offset: 0x000005AB
	public unsafe AscensionAudioHandlerIngame m_audioHandler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_audioHandler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAudioHandlerIngame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_audioHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000089 RID: 137 RVA: 0x0001CAE0 File Offset: 0x0001ACE0
	// (set) Token: 0x0600008A RID: 138 RVA: 0x000023CA File Offset: 0x000005CA
	public unsafe Transform m_deliriumDie
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_deliriumDie);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_deliriumDie), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x0600008B RID: 139 RVA: 0x0001CB10 File Offset: 0x0001AD10
	// (set) Token: 0x0600008C RID: 140 RVA: 0x000023E9 File Offset: 0x000005E9
	public unsafe float m_slowRotateSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_slowRotateSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_slowRotateSpeed)) = value;
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600008D RID: 141 RVA: 0x0001CB38 File Offset: 0x0001AD38
	// (set) Token: 0x0600008E RID: 142 RVA: 0x00002404 File Offset: 0x00000604
	public unsafe float m_fastRotateSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_fastRotateSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_fastRotateSpeed)) = value;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600008F RID: 143 RVA: 0x0001CB60 File Offset: 0x0001AD60
	// (set) Token: 0x06000090 RID: 144 RVA: 0x0000241F File Offset: 0x0000061F
	public unsafe float m_accelerationTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_accelerationTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_accelerationTime)) = value;
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000091 RID: 145 RVA: 0x0001CB88 File Offset: 0x0001AD88
	// (set) Token: 0x06000092 RID: 146 RVA: 0x0000243A File Offset: 0x0000063A
	public unsafe float m_holdTimeMin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_holdTimeMin);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_holdTimeMin)) = value;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000093 RID: 147 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
	// (set) Token: 0x06000094 RID: 148 RVA: 0x00002455 File Offset: 0x00000655
	public unsafe float m_holdTimeMax
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_holdTimeMax);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_holdTimeMax)) = value;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000095 RID: 149 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
	// (set) Token: 0x06000096 RID: 150 RVA: 0x00002470 File Offset: 0x00000670
	public unsafe float m_slowDownTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_slowDownTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_slowDownTime)) = value;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000097 RID: 151 RVA: 0x0001CC00 File Offset: 0x0001AE00
	// (set) Token: 0x06000098 RID: 152 RVA: 0x0000248B File Offset: 0x0000068B
	public unsafe TextMeshProUGUI m_titleText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_titleText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_titleText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000099 RID: 153 RVA: 0x0001CC30 File Offset: 0x0001AE30
	// (set) Token: 0x0600009A RID: 154 RVA: 0x000024AA File Offset: 0x000006AA
	public unsafe TextMeshProUGUI m_infoText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_infoText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_infoText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x0600009B RID: 155 RVA: 0x0001CC60 File Offset: 0x0001AE60
	// (set) Token: 0x0600009C RID: 156 RVA: 0x000024C9 File Offset: 0x000006C9
	public unsafe GameObject m_buttonCancel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_buttonCancel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_buttonCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600009D RID: 157 RVA: 0x0001CC90 File Offset: 0x0001AE90
	// (set) Token: 0x0600009E RID: 158 RVA: 0x000024E8 File Offset: 0x000006E8
	public unsafe GameObject m_buttonConfirm
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_buttonConfirm);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_buttonConfirm), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600009F RID: 159 RVA: 0x0001CCC0 File Offset: 0x0001AEC0
	// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002507 File Offset: 0x00000707
	public unsafe GameObject m_buttonClose
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_buttonClose);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_buttonClose), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000A1 RID: 161 RVA: 0x0001CCF0 File Offset: 0x0001AEF0
	// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002526 File Offset: 0x00000726
	public unsafe Il2CppStructArray<Vector3> m_finishPositions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_finishPositions);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_finishPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000A3 RID: 163 RVA: 0x0001CD20 File Offset: 0x0001AF20
	// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002545 File Offset: 0x00000745
	public unsafe Il2CppStringArray m_resultsStrings
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_resultsStrings);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_resultsStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000A5 RID: 165 RVA: 0x0001CD50 File Offset: 0x0001AF50
	// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002564 File Offset: 0x00000764
	public unsafe int m_dieMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_dieMode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_dieMode)) = value;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000A7 RID: 167 RVA: 0x0001CD78 File Offset: 0x0001AF78
	// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000257F File Offset: 0x0000077F
	public unsafe int m_storedResults
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_storedResults);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_storedResults)) = value;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000A9 RID: 169 RVA: 0x0001CDA0 File Offset: 0x0001AFA0
	// (set) Token: 0x060000AA RID: 170 RVA: 0x0000259A File Offset: 0x0000079A
	public unsafe float m_currentRotateSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_currentRotateSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_currentRotateSpeed)) = value;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000AB RID: 171 RVA: 0x0001CDC8 File Offset: 0x0001AFC8
	// (set) Token: 0x060000AC RID: 172 RVA: 0x000025B5 File Offset: 0x000007B5
	public unsafe Vector3 m_randomRotateVec
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_randomRotateVec);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_randomRotateVec)) = value;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000AD RID: 173 RVA: 0x0001CDF0 File Offset: 0x0001AFF0
	// (set) Token: 0x060000AE RID: 174 RVA: 0x000025D0 File Offset: 0x000007D0
	public unsafe bool m_bBlockUpdates
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_bBlockUpdates);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie.NativeFieldInfoPtr_m_bBlockUpdates)) = value;
		}
	}

	// Token: 0x0400004E RID: 78
	private static readonly IntPtr NativeFieldInfoPtr_m_audioHandler;

	// Token: 0x0400004F RID: 79
	private static readonly IntPtr NativeFieldInfoPtr_m_deliriumDie;

	// Token: 0x04000050 RID: 80
	private static readonly IntPtr NativeFieldInfoPtr_m_slowRotateSpeed;

	// Token: 0x04000051 RID: 81
	private static readonly IntPtr NativeFieldInfoPtr_m_fastRotateSpeed;

	// Token: 0x04000052 RID: 82
	private static readonly IntPtr NativeFieldInfoPtr_m_accelerationTime;

	// Token: 0x04000053 RID: 83
	private static readonly IntPtr NativeFieldInfoPtr_m_holdTimeMin;

	// Token: 0x04000054 RID: 84
	private static readonly IntPtr NativeFieldInfoPtr_m_holdTimeMax;

	// Token: 0x04000055 RID: 85
	private static readonly IntPtr NativeFieldInfoPtr_m_slowDownTime;

	// Token: 0x04000056 RID: 86
	private static readonly IntPtr NativeFieldInfoPtr_m_titleText;

	// Token: 0x04000057 RID: 87
	private static readonly IntPtr NativeFieldInfoPtr_m_infoText;

	// Token: 0x04000058 RID: 88
	private static readonly IntPtr NativeFieldInfoPtr_m_buttonCancel;

	// Token: 0x04000059 RID: 89
	private static readonly IntPtr NativeFieldInfoPtr_m_buttonConfirm;

	// Token: 0x0400005A RID: 90
	private static readonly IntPtr NativeFieldInfoPtr_m_buttonClose;

	// Token: 0x0400005B RID: 91
	private static readonly IntPtr NativeFieldInfoPtr_m_finishPositions;

	// Token: 0x0400005C RID: 92
	private static readonly IntPtr NativeFieldInfoPtr_m_resultsStrings;

	// Token: 0x0400005D RID: 93
	private static readonly IntPtr NativeFieldInfoPtr_m_dieMode;

	// Token: 0x0400005E RID: 94
	private static readonly IntPtr NativeFieldInfoPtr_m_storedResults;

	// Token: 0x0400005F RID: 95
	private static readonly IntPtr NativeFieldInfoPtr_m_currentRotateSpeed;

	// Token: 0x04000060 RID: 96
	private static readonly IntPtr NativeFieldInfoPtr_m_randomRotateVec;

	// Token: 0x04000061 RID: 97
	private static readonly IntPtr NativeFieldInfoPtr_m_bBlockUpdates;

	// Token: 0x04000062 RID: 98
	private static readonly IntPtr NativeMethodInfoPtr_DismissPopup_Public_Virtual_Void_0;

	// Token: 0x04000063 RID: 99
	private static readonly IntPtr NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_Boolean_0;

	// Token: 0x04000064 RID: 100
	private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

	// Token: 0x04000065 RID: 101
	private static readonly IntPtr NativeMethodInfoPtr_SetNonBlockingMode_Public_Void_0;

	// Token: 0x04000066 RID: 102
	private static readonly IntPtr NativeMethodInfoPtr_DisplayDecision_Public_Void_0;

	// Token: 0x04000067 RID: 103
	private static readonly IntPtr NativeMethodInfoPtr_DisplayResults_Public_Void_Int32_0;

	// Token: 0x04000068 RID: 104
	private static readonly IntPtr NativeMethodInfoPtr_ForceResultsEnd_Public_Void_Int32_0;

	// Token: 0x04000069 RID: 105
	private static readonly IntPtr NativeMethodInfoPtr_OnConfirmButtonPress_Public_Void_0;

	// Token: 0x0400006A RID: 106
	private static readonly IntPtr NativeMethodInfoPtr_OnCancelButtonPress_Public_Void_0;

	// Token: 0x0400006B RID: 107
	private static readonly IntPtr NativeMethodInfoPtr_OnCloseButtonPress_Public_Void_0;

	// Token: 0x0400006C RID: 108
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400006D RID: 109
	private static readonly IntPtr NativeMethodInfoPtr_RotateRotator_Private_IEnumerator_0;

	// Token: 0x0400006E RID: 110
	private static readonly IntPtr NativeMethodInfoPtr_StartResults_Private_IEnumerator_0;

	// Token: 0x0400006F RID: 111
	private static readonly IntPtr NativeMethodInfoPtr_RotateToTarget_Private_IEnumerator_Vector3_0;

	// Token: 0x04000070 RID: 112
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000162 RID: 354
	[ObfuscatedName("ActionPopup_DeliriumDie+<RotateRotator>d__31")]
	public sealed class _RotateRotator_d__31 : global::Il2CppSystem.Object
	{
		// Token: 0x06002258 RID: 8792 RVA: 0x00081364 File Offset: 0x0007F564
		// Note: this type is marked as 'beforefieldinit'.
		static _RotateRotator_d__31()
		{
			Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "<RotateRotator>d__31");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr);
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, "<>1__state");
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, "<>2__current");
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, "<>4__this");
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__holdTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, "<holdTime>5__2");
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__randVec_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, "<randVec>5__3");
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__previousTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, "<previousTime>5__4");
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__currentAnimTime_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, "<currentAnimTime>5__5");
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__startVec_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, "<startVec>5__6");
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, 100666003);
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, 100666004);
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, 100666005);
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, 100666006);
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, 100666007);
			ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr, 100666008);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x000814A8 File Offset: 0x0007F6A8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _RotateRotator_d__31(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateRotator_d__31>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x000814F0 File Offset: 0x0007F6F0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00081524 File Offset: 0x0007F724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224360, XrefRangeEnd = 224374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x00081560 File Offset: 0x0007F760
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x000815A0 File Offset: 0x0007F7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224374, XrefRangeEnd = 224379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x000815D4 File Offset: 0x0007F7D4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00015A63 File Offset: 0x00013C63
		public _RotateRotator_d__31(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x00081614 File Offset: 0x0007F814
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x00015A6C File Offset: 0x00013C6C
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x0008163C File Offset: 0x0007F83C
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x00015A87 File Offset: 0x00013C87
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x0008166C File Offset: 0x0007F86C
		// (set) Token: 0x06002265 RID: 8805 RVA: 0x00015AA6 File Offset: 0x00013CA6
		public unsafe ActionPopup_DeliriumDie __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionPopup_DeliriumDie>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x0008169C File Offset: 0x0007F89C
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x00015AC5 File Offset: 0x00013CC5
		public unsafe float _holdTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__holdTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__holdTime_5__2)) = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x000816C4 File Offset: 0x0007F8C4
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x00015AE0 File Offset: 0x00013CE0
		public unsafe Vector3 _randVec_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__randVec_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__randVec_5__3)) = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x000816EC File Offset: 0x0007F8EC
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x00015AFB File Offset: 0x00013CFB
		public unsafe float _previousTime_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__previousTime_5__4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__previousTime_5__4)) = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x00081714 File Offset: 0x0007F914
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x00015B16 File Offset: 0x00013D16
		public unsafe float _currentAnimTime_5__5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__currentAnimTime_5__5);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__currentAnimTime_5__5)) = value;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x0008173C File Offset: 0x0007F93C
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x00015B31 File Offset: 0x00013D31
		public unsafe Vector3 _startVec_5__6
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__startVec_5__6);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateRotator_d__31.NativeFieldInfoPtr__startVec_5__6)) = value;
			}
		}

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeFieldInfoPtr__holdTime_5__2;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeFieldInfoPtr__randVec_5__3;

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__4;

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeFieldInfoPtr__currentAnimTime_5__5;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeFieldInfoPtr__startVec_5__6;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000163 RID: 355
	[ObfuscatedName("ActionPopup_DeliriumDie+<StartResults>d__32")]
	public sealed class _StartResults_d__32 : global::Il2CppSystem.Object
	{
		// Token: 0x06002270 RID: 8816 RVA: 0x00081764 File Offset: 0x0007F964
		// Note: this type is marked as 'beforefieldinit'.
		static _StartResults_d__32()
		{
			Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "<StartResults>d__32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr);
			ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, "<>1__state");
			ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, "<>2__current");
			ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, "<>4__this");
			ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr__previousTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, "<previousTime>5__2");
			ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr__currentAnimTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, "<currentAnimTime>5__3");
			ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, 100666009);
			ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, 100666010);
			ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, 100666011);
			ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, 100666012);
			ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, 100666013);
			ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr, 100666014);
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x0008186C File Offset: 0x0007FA6C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _StartResults_d__32(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionPopup_DeliriumDie._StartResults_d__32>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x000818B4 File Offset: 0x0007FAB4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x000818E8 File Offset: 0x0007FAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224379, XrefRangeEnd = 224390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x00081924 File Offset: 0x0007FB24
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00081964 File Offset: 0x0007FB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224390, XrefRangeEnd = 224395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x00081998 File Offset: 0x0007FB98
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._StartResults_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x00015B4C File Offset: 0x00013D4C
		public _StartResults_d__32(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x000819D8 File Offset: 0x0007FBD8
		// (set) Token: 0x06002279 RID: 8825 RVA: 0x00015B55 File Offset: 0x00013D55
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x00081A00 File Offset: 0x0007FC00
		// (set) Token: 0x0600227B RID: 8827 RVA: 0x00015B70 File Offset: 0x00013D70
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x00081A30 File Offset: 0x0007FC30
		// (set) Token: 0x0600227D RID: 8829 RVA: 0x00015B8F File Offset: 0x00013D8F
		public unsafe ActionPopup_DeliriumDie __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionPopup_DeliriumDie>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x00081A60 File Offset: 0x0007FC60
		// (set) Token: 0x0600227F RID: 8831 RVA: 0x00015BAE File Offset: 0x00013DAE
		public unsafe float _previousTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr__previousTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr__previousTime_5__2)) = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x00081A88 File Offset: 0x0007FC88
		// (set) Token: 0x06002281 RID: 8833 RVA: 0x00015BC9 File Offset: 0x00013DC9
		public unsafe float _currentAnimTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr__currentAnimTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._StartResults_d__32.NativeFieldInfoPtr__currentAnimTime_5__3)) = value;
			}
		}

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__2;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeFieldInfoPtr__currentAnimTime_5__3;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000164 RID: 356
	[ObfuscatedName("ActionPopup_DeliriumDie+<RotateToTarget>d__33")]
	public sealed class _RotateToTarget_d__33 : global::Il2CppSystem.Object
	{
		// Token: 0x06002282 RID: 8834 RVA: 0x00081AB0 File Offset: 0x0007FCB0
		// Note: this type is marked as 'beforefieldinit'.
		static _RotateToTarget_d__33()
		{
			Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionPopup_DeliriumDie>.NativeClassPtr, "<RotateToTarget>d__33");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr);
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, "<>1__state");
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, "<>2__current");
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, "<>4__this");
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr_targetRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, "targetRotate");
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__final_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, "<final>5__2");
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__startVec_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, "<startVec>5__3");
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__previousTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, "<previousTime>5__4");
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__currentAnimTime_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, "<currentAnimTime>5__5");
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, 100666015);
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, 100666016);
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, 100666017);
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, 100666018);
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, 100666019);
			ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr, 100666020);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00081BF4 File Offset: 0x0007FDF4
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _RotateToTarget_d__33(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionPopup_DeliriumDie._RotateToTarget_d__33>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x00081C3C File Offset: 0x0007FE3C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00081C70 File Offset: 0x0007FE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224395, XrefRangeEnd = 224426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x00081CAC File Offset: 0x0007FEAC
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x00081CEC File Offset: 0x0007FEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224426, XrefRangeEnd = 224431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x00081D20 File Offset: 0x0007FF20
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00015BE4 File Offset: 0x00013DE4
		public _RotateToTarget_d__33(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x00081D60 File Offset: 0x0007FF60
		// (set) Token: 0x0600228B RID: 8843 RVA: 0x00015BED File Offset: 0x00013DED
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x00081D88 File Offset: 0x0007FF88
		// (set) Token: 0x0600228D RID: 8845 RVA: 0x00015C08 File Offset: 0x00013E08
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x00081DB8 File Offset: 0x0007FFB8
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x00015C27 File Offset: 0x00013E27
		public unsafe ActionPopup_DeliriumDie __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionPopup_DeliriumDie>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x00081DE8 File Offset: 0x0007FFE8
		// (set) Token: 0x06002291 RID: 8849 RVA: 0x00015C46 File Offset: 0x00013E46
		public unsafe Vector3 targetRotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr_targetRotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr_targetRotate)) = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x00081E10 File Offset: 0x00080010
		// (set) Token: 0x06002293 RID: 8851 RVA: 0x00015C61 File Offset: 0x00013E61
		public unsafe Quaternion _final_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__final_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__final_5__2)) = value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x00081E38 File Offset: 0x00080038
		// (set) Token: 0x06002295 RID: 8853 RVA: 0x00015C7C File Offset: 0x00013E7C
		public unsafe Vector3 _startVec_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__startVec_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__startVec_5__3)) = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x00081E60 File Offset: 0x00080060
		// (set) Token: 0x06002297 RID: 8855 RVA: 0x00015C97 File Offset: 0x00013E97
		public unsafe float _previousTime_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__previousTime_5__4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__previousTime_5__4)) = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x00081E88 File Offset: 0x00080088
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x00015CB2 File Offset: 0x00013EB2
		public unsafe float _currentAnimTime_5__5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__currentAnimTime_5__5);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_DeliriumDie._RotateToTarget_d__33.NativeFieldInfoPtr__currentAnimTime_5__5)) = value;
			}
		}

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeFieldInfoPtr_targetRotate;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeFieldInfoPtr__final_5__2;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeFieldInfoPtr__startVec_5__3;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__4;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeFieldInfoPtr__currentAnimTime_5__5;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
