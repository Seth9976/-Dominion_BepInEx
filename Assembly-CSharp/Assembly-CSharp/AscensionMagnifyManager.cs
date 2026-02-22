using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using TMPro;
using UnityEngine;

// Token: 0x02000024 RID: 36
public class AscensionMagnifyManager : MagnifyManager
{
	// Token: 0x06000801 RID: 2049 RVA: 0x000316B0 File Offset: 0x0002F8B0
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionMagnifyManager()
	{
		Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionMagnifyManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr);
		AscensionMagnifyManager.NativeFieldInfoPtr_m_AscensionGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_AscensionGame");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyChampionLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifyChampionLocator");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_TutorialMagnifyCardLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_TutorialMagnifyCardLocator");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_EndGameMagnifyCardLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_EndGameMagnifyCardLocator");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardButtonLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifiedCardButtonLeft");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardButtonRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifiedCardButtonRight");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardActionButtonPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifiedCardActionButtonPanel");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardActionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifiedCardActionButtons");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardTransformButtonPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifiedCardTransformButtonPanel");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardTransformButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifiedCardTransformButtonText");
		AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultMovementRateXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "k_DefaultMovementRateXY");
		AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultMovementRateZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "k_DefaultMovementRateZ");
		AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultRotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "k_DefaultRotationRate");
		AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultScaleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "k_DefaultScaleRate");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyMovementRateXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifyMovementRateXY");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyMovementRateZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifyMovementRateZ");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyRotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifyRotationRate");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyScaleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifyScaleRate");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardNeighborLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifiedCardNeighborLeft");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardNeighborRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifiedCardNeighborRight");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_MagnifiedCardTransform");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_bEnableNeighborButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_bEnableNeighborButtons");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_bEnableMagnifyActionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_bEnableMagnifyActionButtons");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_bMagnifiedKingdomCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_bMagnifiedKingdomCard");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_dataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_dataBuffer");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_hDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_hDataBuffer");
		AscensionMagnifyManager.NativeFieldInfoPtr_m_bufPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "m_bufPtr");
		AscensionMagnifyManager.NativeFieldInfoPtr_k_maxDataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, "k_maxDataSize");
		AscensionMagnifyManager.NativeMethodInfoPtr_SetMagnifyRates_Private_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663819);
		AscensionMagnifyManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663820);
		AscensionMagnifyManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663821);
		AscensionMagnifyManager.NativeMethodInfoPtr_GetMagnifyCardLocator_Public_Virtual_AnimationLocator_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663822);
		AscensionMagnifyManager.NativeMethodInfoPtr_SetEnableNeighborButtons_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663823);
		AscensionMagnifyManager.NativeMethodInfoPtr_SetEnableMagnifyActionButtons_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663824);
		AscensionMagnifyManager.NativeMethodInfoPtr_StartMagnifyCard_Public_Virtual_Boolean_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663825);
		AscensionMagnifyManager.NativeMethodInfoPtr_RemoveMagnifiedCard_Public_Virtual_Boolean_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663826);
		AscensionMagnifyManager.NativeMethodInfoPtr_OnPressShowTransform_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663827);
		AscensionMagnifyManager.NativeMethodInfoPtr_OnReleaseShowTransform_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663828);
		AscensionMagnifyManager.NativeMethodInfoPtr_OnMagnifiedCardButtonLeftPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663829);
		AscensionMagnifyManager.NativeMethodInfoPtr_OnMagnifiedCardButtonRightPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663830);
		AscensionMagnifyManager.NativeMethodInfoPtr_OnMagnifiedCardActionButtonPressed_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663831);
		AscensionMagnifyManager.NativeMethodInfoPtr_OnUnmagnifyButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663832);
		AscensionMagnifyManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr, 100663833);
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00031A3C File Offset: 0x0002FC3C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233909, RefRangeEnd = 233910, XrefRangeStart = 233902, XrefRangeEnd = 233909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMagnifyRates(CardObject magnifyCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_SetMagnifyRates_Private_Void_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00031A80 File Offset: 0x0002FC80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233910, XrefRangeEnd = 233936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00031AB4 File Offset: 0x0002FCB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233936, XrefRangeEnd = 233958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x00031AE8 File Offset: 0x0002FCE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233958, XrefRangeEnd = 233967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override AnimationLocator GetMagnifyCardLocator(CardObject magnifyCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionMagnifyManager.NativeMethodInfoPtr_GetMagnifyCardLocator_Public_Virtual_AnimationLocator_CardObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr3) : null;
		}
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x00031B44 File Offset: 0x0002FD44
	[CallerCount(0)]
	public unsafe void SetEnableNeighborButtons(bool bEnable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_SetEnableNeighborButtons_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x00031B84 File Offset: 0x0002FD84
	[CallerCount(0)]
	public unsafe void SetEnableMagnifyActionButtons(bool bEnable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bEnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_SetEnableMagnifyActionButtons_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x00031BC4 File Offset: 0x0002FDC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233967, XrefRangeEnd = 234521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool StartMagnifyCard(CardObject magnifyCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionMagnifyManager.NativeMethodInfoPtr_StartMagnifyCard_Public_Virtual_Boolean_CardObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x00031C1C File Offset: 0x0002FE1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234521, XrefRangeEnd = 234547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool RemoveMagnifiedCard(CardObject magnifyCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionMagnifyManager.NativeMethodInfoPtr_RemoveMagnifiedCard_Public_Virtual_Boolean_CardObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00031C74 File Offset: 0x0002FE74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234547, XrefRangeEnd = 234555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPressShowTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_OnPressShowTransform_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00031CA8 File Offset: 0x0002FEA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234555, XrefRangeEnd = 234561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnReleaseShowTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_OnReleaseShowTransform_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00031CDC File Offset: 0x0002FEDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234561, XrefRangeEnd = 234581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMagnifiedCardButtonLeftPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_OnMagnifiedCardButtonLeftPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00031D10 File Offset: 0x0002FF10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234581, XrefRangeEnd = 234601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMagnifiedCardButtonRightPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_OnMagnifiedCardButtonRightPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x00031D44 File Offset: 0x0002FF44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234601, XrefRangeEnd = 234668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMagnifiedCardActionButtonPressed(GameObject button_pressed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button_pressed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_OnMagnifiedCardActionButtonPressed_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00031D88 File Offset: 0x0002FF88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234679, RefRangeEnd = 234680, XrefRangeStart = 234668, XrefRangeEnd = 234679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUnmagnifyButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr_OnUnmagnifyButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x00031DBC File Offset: 0x0002FFBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234680, XrefRangeEnd = 234681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionMagnifyManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionMagnifyManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionMagnifyManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00007086 File Offset: 0x00005286
	public AscensionMagnifyManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x06000812 RID: 2066 RVA: 0x00031DF8 File Offset: 0x0002FFF8
	// (set) Token: 0x06000813 RID: 2067 RVA: 0x0000708F File Offset: 0x0000528F
	public unsafe AscensionGame m_AscensionGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_AscensionGame);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionGame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_AscensionGame), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x06000814 RID: 2068 RVA: 0x00031E28 File Offset: 0x00030028
	// (set) Token: 0x06000815 RID: 2069 RVA: 0x000070AE File Offset: 0x000052AE
	public unsafe AnimationLocator m_MagnifyChampionLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyChampionLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyChampionLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002E5 RID: 741
	// (get) Token: 0x06000816 RID: 2070 RVA: 0x00031E58 File Offset: 0x00030058
	// (set) Token: 0x06000817 RID: 2071 RVA: 0x000070CD File Offset: 0x000052CD
	public unsafe AnimationLocator m_TutorialMagnifyCardLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_TutorialMagnifyCardLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_TutorialMagnifyCardLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002E6 RID: 742
	// (get) Token: 0x06000818 RID: 2072 RVA: 0x00031E88 File Offset: 0x00030088
	// (set) Token: 0x06000819 RID: 2073 RVA: 0x000070EC File Offset: 0x000052EC
	public unsafe AnimationLocator m_EndGameMagnifyCardLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_EndGameMagnifyCardLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_EndGameMagnifyCardLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x0600081A RID: 2074 RVA: 0x00031EB8 File Offset: 0x000300B8
	// (set) Token: 0x0600081B RID: 2075 RVA: 0x0000710B File Offset: 0x0000530B
	public unsafe GameObject m_MagnifiedCardButtonLeft
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardButtonLeft);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardButtonLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x0600081C RID: 2076 RVA: 0x00031EE8 File Offset: 0x000300E8
	// (set) Token: 0x0600081D RID: 2077 RVA: 0x0000712A File Offset: 0x0000532A
	public unsafe GameObject m_MagnifiedCardButtonRight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardButtonRight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardButtonRight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002E9 RID: 745
	// (get) Token: 0x0600081E RID: 2078 RVA: 0x00031F18 File Offset: 0x00030118
	// (set) Token: 0x0600081F RID: 2079 RVA: 0x00007149 File Offset: 0x00005349
	public unsafe GameObject m_MagnifiedCardActionButtonPanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardActionButtonPanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardActionButtonPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002EA RID: 746
	// (get) Token: 0x06000820 RID: 2080 RVA: 0x00031F48 File Offset: 0x00030148
	// (set) Token: 0x06000821 RID: 2081 RVA: 0x00007168 File Offset: 0x00005368
	public unsafe Il2CppReferenceArray<GameObject> m_MagnifiedCardActionButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardActionButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardActionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002EB RID: 747
	// (get) Token: 0x06000822 RID: 2082 RVA: 0x00031F78 File Offset: 0x00030178
	// (set) Token: 0x06000823 RID: 2083 RVA: 0x00007187 File Offset: 0x00005387
	public unsafe GameObject m_MagnifiedCardTransformButtonPanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardTransformButtonPanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardTransformButtonPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002EC RID: 748
	// (get) Token: 0x06000824 RID: 2084 RVA: 0x00031FA8 File Offset: 0x000301A8
	// (set) Token: 0x06000825 RID: 2085 RVA: 0x000071A6 File Offset: 0x000053A6
	public unsafe TextMeshProUGUI m_MagnifiedCardTransformButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardTransformButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardTransformButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002ED RID: 749
	// (get) Token: 0x06000826 RID: 2086 RVA: 0x00031FD8 File Offset: 0x000301D8
	// (set) Token: 0x06000827 RID: 2087 RVA: 0x000071C5 File Offset: 0x000053C5
	public unsafe static float k_DefaultMovementRateXY
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultMovementRateXY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultMovementRateXY, (void*)(&value));
		}
	}

	// Token: 0x170002EE RID: 750
	// (get) Token: 0x06000828 RID: 2088 RVA: 0x00031FF4 File Offset: 0x000301F4
	// (set) Token: 0x06000829 RID: 2089 RVA: 0x000071D3 File Offset: 0x000053D3
	public unsafe static float k_DefaultMovementRateZ
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultMovementRateZ, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultMovementRateZ, (void*)(&value));
		}
	}

	// Token: 0x170002EF RID: 751
	// (get) Token: 0x0600082A RID: 2090 RVA: 0x00032010 File Offset: 0x00030210
	// (set) Token: 0x0600082B RID: 2091 RVA: 0x000071E1 File Offset: 0x000053E1
	public unsafe static float k_DefaultRotationRate
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultRotationRate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultRotationRate, (void*)(&value));
		}
	}

	// Token: 0x170002F0 RID: 752
	// (get) Token: 0x0600082C RID: 2092 RVA: 0x0003202C File Offset: 0x0003022C
	// (set) Token: 0x0600082D RID: 2093 RVA: 0x000071EF File Offset: 0x000053EF
	public unsafe static float k_DefaultScaleRate
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultScaleRate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionMagnifyManager.NativeFieldInfoPtr_k_DefaultScaleRate, (void*)(&value));
		}
	}

	// Token: 0x170002F1 RID: 753
	// (get) Token: 0x0600082E RID: 2094 RVA: 0x00032048 File Offset: 0x00030248
	// (set) Token: 0x0600082F RID: 2095 RVA: 0x000071FD File Offset: 0x000053FD
	public unsafe float m_MagnifyMovementRateXY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyMovementRateXY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyMovementRateXY)) = value;
		}
	}

	// Token: 0x170002F2 RID: 754
	// (get) Token: 0x06000830 RID: 2096 RVA: 0x00032070 File Offset: 0x00030270
	// (set) Token: 0x06000831 RID: 2097 RVA: 0x00007218 File Offset: 0x00005418
	public unsafe float m_MagnifyMovementRateZ
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyMovementRateZ);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyMovementRateZ)) = value;
		}
	}

	// Token: 0x170002F3 RID: 755
	// (get) Token: 0x06000832 RID: 2098 RVA: 0x00032098 File Offset: 0x00030298
	// (set) Token: 0x06000833 RID: 2099 RVA: 0x00007233 File Offset: 0x00005433
	public unsafe float m_MagnifyRotationRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyRotationRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyRotationRate)) = value;
		}
	}

	// Token: 0x170002F4 RID: 756
	// (get) Token: 0x06000834 RID: 2100 RVA: 0x000320C0 File Offset: 0x000302C0
	// (set) Token: 0x06000835 RID: 2101 RVA: 0x0000724E File Offset: 0x0000544E
	public unsafe float m_MagnifyScaleRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyScaleRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifyScaleRate)) = value;
		}
	}

	// Token: 0x170002F5 RID: 757
	// (get) Token: 0x06000836 RID: 2102 RVA: 0x000320E8 File Offset: 0x000302E8
	// (set) Token: 0x06000837 RID: 2103 RVA: 0x00007269 File Offset: 0x00005469
	public unsafe AscensionCard m_MagnifiedCardNeighborLeft
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardNeighborLeft);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardNeighborLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002F6 RID: 758
	// (get) Token: 0x06000838 RID: 2104 RVA: 0x00032118 File Offset: 0x00030318
	// (set) Token: 0x06000839 RID: 2105 RVA: 0x00007288 File Offset: 0x00005488
	public unsafe AscensionCard m_MagnifiedCardNeighborRight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardNeighborRight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardNeighborRight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002F7 RID: 759
	// (get) Token: 0x0600083A RID: 2106 RVA: 0x00032148 File Offset: 0x00030348
	// (set) Token: 0x0600083B RID: 2107 RVA: 0x000072A7 File Offset: 0x000054A7
	public unsafe AscensionCard m_MagnifiedCardTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_MagnifiedCardTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002F8 RID: 760
	// (get) Token: 0x0600083C RID: 2108 RVA: 0x00032178 File Offset: 0x00030378
	// (set) Token: 0x0600083D RID: 2109 RVA: 0x000072C6 File Offset: 0x000054C6
	public unsafe bool m_bEnableNeighborButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_bEnableNeighborButtons);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_bEnableNeighborButtons)) = value;
		}
	}

	// Token: 0x170002F9 RID: 761
	// (get) Token: 0x0600083E RID: 2110 RVA: 0x000321A0 File Offset: 0x000303A0
	// (set) Token: 0x0600083F RID: 2111 RVA: 0x000072E1 File Offset: 0x000054E1
	public unsafe bool m_bEnableMagnifyActionButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_bEnableMagnifyActionButtons);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_bEnableMagnifyActionButtons)) = value;
		}
	}

	// Token: 0x170002FA RID: 762
	// (get) Token: 0x06000840 RID: 2112 RVA: 0x000321C8 File Offset: 0x000303C8
	// (set) Token: 0x06000841 RID: 2113 RVA: 0x000072FC File Offset: 0x000054FC
	public unsafe bool m_bMagnifiedKingdomCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_bMagnifiedKingdomCard);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_bMagnifiedKingdomCard)) = value;
		}
	}

	// Token: 0x170002FB RID: 763
	// (get) Token: 0x06000842 RID: 2114 RVA: 0x000321F0 File Offset: 0x000303F0
	// (set) Token: 0x06000843 RID: 2115 RVA: 0x00007317 File Offset: 0x00005517
	public unsafe Il2CppStructArray<byte> m_dataBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_dataBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_dataBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002FC RID: 764
	// (get) Token: 0x06000844 RID: 2116 RVA: 0x00032220 File Offset: 0x00030420
	// (set) Token: 0x06000845 RID: 2117 RVA: 0x00007336 File Offset: 0x00005536
	public unsafe GCHandle m_hDataBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_hDataBuffer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_hDataBuffer)) = value;
		}
	}

	// Token: 0x170002FD RID: 765
	// (get) Token: 0x06000846 RID: 2118 RVA: 0x00032248 File Offset: 0x00030448
	// (set) Token: 0x06000847 RID: 2119 RVA: 0x00007351 File Offset: 0x00005551
	public unsafe IntPtr m_bufPtr
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_bufPtr);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionMagnifyManager.NativeFieldInfoPtr_m_bufPtr)) = value;
		}
	}

	// Token: 0x170002FE RID: 766
	// (get) Token: 0x06000848 RID: 2120 RVA: 0x00032270 File Offset: 0x00030470
	// (set) Token: 0x06000849 RID: 2121 RVA: 0x0000736C File Offset: 0x0000556C
	public unsafe static int k_maxDataSize
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionMagnifyManager.NativeFieldInfoPtr_k_maxDataSize, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionMagnifyManager.NativeFieldInfoPtr_k_maxDataSize, (void*)(&value));
		}
	}

	// Token: 0x040004F9 RID: 1273
	private static readonly IntPtr NativeFieldInfoPtr_m_AscensionGame;

	// Token: 0x040004FA RID: 1274
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyChampionLocator;

	// Token: 0x040004FB RID: 1275
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialMagnifyCardLocator;

	// Token: 0x040004FC RID: 1276
	private static readonly IntPtr NativeFieldInfoPtr_m_EndGameMagnifyCardLocator;

	// Token: 0x040004FD RID: 1277
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifiedCardButtonLeft;

	// Token: 0x040004FE RID: 1278
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifiedCardButtonRight;

	// Token: 0x040004FF RID: 1279
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifiedCardActionButtonPanel;

	// Token: 0x04000500 RID: 1280
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifiedCardActionButtons;

	// Token: 0x04000501 RID: 1281
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifiedCardTransformButtonPanel;

	// Token: 0x04000502 RID: 1282
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifiedCardTransformButtonText;

	// Token: 0x04000503 RID: 1283
	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultMovementRateXY;

	// Token: 0x04000504 RID: 1284
	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultMovementRateZ;

	// Token: 0x04000505 RID: 1285
	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultRotationRate;

	// Token: 0x04000506 RID: 1286
	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultScaleRate;

	// Token: 0x04000507 RID: 1287
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyMovementRateXY;

	// Token: 0x04000508 RID: 1288
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyMovementRateZ;

	// Token: 0x04000509 RID: 1289
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyRotationRate;

	// Token: 0x0400050A RID: 1290
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyScaleRate;

	// Token: 0x0400050B RID: 1291
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifiedCardNeighborLeft;

	// Token: 0x0400050C RID: 1292
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifiedCardNeighborRight;

	// Token: 0x0400050D RID: 1293
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifiedCardTransform;

	// Token: 0x0400050E RID: 1294
	private static readonly IntPtr NativeFieldInfoPtr_m_bEnableNeighborButtons;

	// Token: 0x0400050F RID: 1295
	private static readonly IntPtr NativeFieldInfoPtr_m_bEnableMagnifyActionButtons;

	// Token: 0x04000510 RID: 1296
	private static readonly IntPtr NativeFieldInfoPtr_m_bMagnifiedKingdomCard;

	// Token: 0x04000511 RID: 1297
	private static readonly IntPtr NativeFieldInfoPtr_m_dataBuffer;

	// Token: 0x04000512 RID: 1298
	private static readonly IntPtr NativeFieldInfoPtr_m_hDataBuffer;

	// Token: 0x04000513 RID: 1299
	private static readonly IntPtr NativeFieldInfoPtr_m_bufPtr;

	// Token: 0x04000514 RID: 1300
	private static readonly IntPtr NativeFieldInfoPtr_k_maxDataSize;

	// Token: 0x04000515 RID: 1301
	private static readonly IntPtr NativeMethodInfoPtr_SetMagnifyRates_Private_Void_CardObject_0;

	// Token: 0x04000516 RID: 1302
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000517 RID: 1303
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000518 RID: 1304
	private static readonly IntPtr NativeMethodInfoPtr_GetMagnifyCardLocator_Public_Virtual_AnimationLocator_CardObject_0;

	// Token: 0x04000519 RID: 1305
	private static readonly IntPtr NativeMethodInfoPtr_SetEnableNeighborButtons_Public_Void_Boolean_0;

	// Token: 0x0400051A RID: 1306
	private static readonly IntPtr NativeMethodInfoPtr_SetEnableMagnifyActionButtons_Public_Void_Boolean_0;

	// Token: 0x0400051B RID: 1307
	private static readonly IntPtr NativeMethodInfoPtr_StartMagnifyCard_Public_Virtual_Boolean_CardObject_0;

	// Token: 0x0400051C RID: 1308
	private static readonly IntPtr NativeMethodInfoPtr_RemoveMagnifiedCard_Public_Virtual_Boolean_CardObject_0;

	// Token: 0x0400051D RID: 1309
	private static readonly IntPtr NativeMethodInfoPtr_OnPressShowTransform_Public_Void_0;

	// Token: 0x0400051E RID: 1310
	private static readonly IntPtr NativeMethodInfoPtr_OnReleaseShowTransform_Public_Void_0;

	// Token: 0x0400051F RID: 1311
	private static readonly IntPtr NativeMethodInfoPtr_OnMagnifiedCardButtonLeftPressed_Public_Void_0;

	// Token: 0x04000520 RID: 1312
	private static readonly IntPtr NativeMethodInfoPtr_OnMagnifiedCardButtonRightPressed_Public_Void_0;

	// Token: 0x04000521 RID: 1313
	private static readonly IntPtr NativeMethodInfoPtr_OnMagnifiedCardActionButtonPressed_Public_Void_GameObject_0;

	// Token: 0x04000522 RID: 1314
	private static readonly IntPtr NativeMethodInfoPtr_OnUnmagnifyButtonPressed_Public_Void_0;

	// Token: 0x04000523 RID: 1315
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
