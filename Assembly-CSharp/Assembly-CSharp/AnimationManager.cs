using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000082 RID: 130
public class AnimationManager : MonoBehaviour
{
	// Token: 0x0600103D RID: 4157 RVA: 0x00049AA8 File Offset: 0x00047CA8
	// Note: this type is marked as 'beforefieldinit'.
	static AnimationManager()
	{
		Il2CppClassPointerStore<AnimationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr);
		AnimationManager.NativeFieldInfoPtr_k_AnimationFlagForceToStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "k_AnimationFlagForceToStart");
		AnimationManager.NativeFieldInfoPtr_m_DefaultAnimationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_DefaultAnimationLayer");
		AnimationManager.NativeFieldInfoPtr_m_LocatorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_LocatorMap");
		AnimationManager.NativeFieldInfoPtr_m_AnimationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_AnimationList");
		AnimationManager.NativeFieldInfoPtr_m_QueuedAnimationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_QueuedAnimationList");
		AnimationManager.NativeFieldInfoPtr_m_AnimationDestinationFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_AnimationDestinationFlags");
		AnimationManager.NativeFieldInfoPtr_m_WaitForDestinationFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_WaitForDestinationFlags");
		AnimationManager.NativeFieldInfoPtr_m_WaitForAllAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_WaitForAllAnimation");
		AnimationManager.NativeFieldInfoPtr_m_OnBeginAnimationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_OnBeginAnimationCallback");
		AnimationManager.NativeFieldInfoPtr_m_OnEndAnimationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_OnEndAnimationCallback");
		AnimationManager.NativeFieldInfoPtr_m_UpdateAnimateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_UpdateAnimateList");
		AnimationManager.NativeFieldInfoPtr_m_AnimationSpeedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_AnimationSpeedScale");
		AnimationManager.NativeFieldInfoPtr_m_MaxAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "m_MaxAnimationSpeed");
		AnimationManager.NativeMethodInfoPtr_SetAnimationSpeedScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664476);
		AnimationManager.NativeMethodInfoPtr_AddOnBeginAnimationCallback_Public_Void_AnimationManagerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664477);
		AnimationManager.NativeMethodInfoPtr_RemoveOnBeginAnimationCallback_Public_Void_AnimationManagerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664478);
		AnimationManager.NativeMethodInfoPtr_AddOnEndAnimationCallback_Public_Void_AnimationManagerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664479);
		AnimationManager.NativeMethodInfoPtr_RemoveOnEndAnimationCallback_Public_Void_AnimationManagerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664480);
		AnimationManager.NativeMethodInfoPtr_GetDefaultAnimationLayer_Public_AnimationLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664481);
		AnimationManager.NativeMethodInfoPtr_GetAnimationLocator_Public_AnimationLocator_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664482);
		AnimationManager.NativeMethodInfoPtr_SetAnimationLocator_Public_Boolean_Int32_Int32_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664483);
		AnimationManager.NativeMethodInfoPtr_RemoveAnimationLocator_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664484);
		AnimationManager.NativeMethodInfoPtr_RemoveAllAnimationLocators_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664485);
		AnimationManager.NativeMethodInfoPtr_GetCurrentAnimationEntry_Public_AnimationEntry_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664486);
		AnimationManager.NativeMethodInfoPtr_CountCurrentAnimationEntriesToDestination_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664487);
		AnimationManager.NativeMethodInfoPtr_GetCurrentAnimationEntriesToDestination_Public_List_1_AnimationEntry_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664488);
		AnimationManager.NativeMethodInfoPtr_GetCurrentAnimationToDestinationFlags_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664489);
		AnimationManager.NativeMethodInfoPtr_AddToAnimationList_Public_Void_AnimateObject_Int32_Int32_Int32_Int32_UInt32_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664490);
		AnimationManager.NativeMethodInfoPtr_RemoveFromAnimationList_Public_Boolean_AnimateObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664491);
		AnimationManager.NativeMethodInfoPtr_StartAnimation_Public_Boolean_AnimateObject_Int32_Int32_Int32_Int32_UInt32_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664492);
		AnimationManager.NativeMethodInfoPtr_QueueAnimation_Public_Boolean_AnimateObject_Int32_Int32_Int32_Int32_UInt32_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664493);
		AnimationManager.NativeMethodInfoPtr_CheckForQueuedAnimation_Public_Boolean_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664494);
		AnimationManager.NativeMethodInfoPtr_StartAnimationToLocator_Public_Boolean_AnimateObject_AnimationLocator_Int32_AnimationLocator_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664495);
		AnimationManager.NativeMethodInfoPtr_StartAnimationToPlaceholder_Public_Boolean_AnimateObject_GameObject_Int32_Int32_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664496);
		AnimationManager.NativeMethodInfoPtr_SetAnimationRatesReturnDragObject_Public_Virtual_New_Void_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664497);
		AnimationManager.NativeMethodInfoPtr_IsAnimationToDestination_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664498);
		AnimationManager.NativeMethodInfoPtr_PauseForAnimationManager_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664499);
		AnimationManager.NativeMethodInfoPtr_AddWaitForAllAnimation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664500);
		AnimationManager.NativeMethodInfoPtr_AddWaitForDestination_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664501);
		AnimationManager.NativeMethodInfoPtr_AddWaitForDestinationFlags_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664502);
		AnimationManager.NativeMethodInfoPtr_AddUpdateAnimateList_Public_Void_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664503);
		AnimationManager.NativeMethodInfoPtr_RemoveUpdateAnimateList_Public_Void_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664504);
		AnimationManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664505);
		AnimationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, 100664506);
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x00049E48 File Offset: 0x00048048
	[CallerCount(0)]
	public unsafe void SetAnimationSpeedScale(float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_SetAnimationSpeedScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x00049E88 File Offset: 0x00048088
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241176, RefRangeEnd = 241178, XrefRangeStart = 241173, XrefRangeEnd = 241176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnBeginAnimationCallback(AnimationManager.AnimationManagerCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_AddOnBeginAnimationCallback_Public_Void_AnimationManagerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x00049ECC File Offset: 0x000480CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241181, RefRangeEnd = 241182, XrefRangeStart = 241178, XrefRangeEnd = 241181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnBeginAnimationCallback(AnimationManager.AnimationManagerCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_RemoveOnBeginAnimationCallback_Public_Void_AnimationManagerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00049F10 File Offset: 0x00048110
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241185, RefRangeEnd = 241187, XrefRangeStart = 241182, XrefRangeEnd = 241185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnEndAnimationCallback(AnimationManager.AnimationManagerCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_AddOnEndAnimationCallback_Public_Void_AnimationManagerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x00049F54 File Offset: 0x00048154
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241190, RefRangeEnd = 241191, XrefRangeStart = 241187, XrefRangeEnd = 241190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnEndAnimationCallback(AnimationManager.AnimationManagerCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_RemoveOnEndAnimationCallback_Public_Void_AnimationManagerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00049F98 File Offset: 0x00048198
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationLayer GetDefaultAnimationLayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_GetDefaultAnimationLayer_Public_AnimationLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationLayer>(intPtr3) : null;
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x00049FD8 File Offset: 0x000481D8
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 241208, RefRangeEnd = 241213, XrefRangeStart = 241191, XrefRangeEnd = 241208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationLocator GetAnimationLocator(int locatorIndex, int locatorID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref locatorIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locatorID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_GetAnimationLocator_Public_AnimationLocator_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr3) : null;
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x0004A034 File Offset: 0x00048234
	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 241252, RefRangeEnd = 241291, XrefRangeStart = 241213, XrefRangeEnd = 241252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetAnimationLocator(int locatorIndex, int locatorID, AnimationLocator locator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref locatorIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locatorID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locator);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_SetAnimationLocator_Public_Boolean_Int32_Int32_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001046 RID: 4166 RVA: 0x0004A0A0 File Offset: 0x000482A0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 241311, RefRangeEnd = 241315, XrefRangeStart = 241291, XrefRangeEnd = 241311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RemoveAnimationLocator(int locatorIndex, int locatorID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref locatorIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locatorID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_RemoveAnimationLocator_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x0004A0F8 File Offset: 0x000482F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241331, RefRangeEnd = 241332, XrefRangeStart = 241315, XrefRangeEnd = 241331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllAnimationLocators()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_RemoveAllAnimationLocators_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x0004A12C File Offset: 0x0004832C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241342, RefRangeEnd = 241344, XrefRangeStart = 241332, XrefRangeEnd = 241342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationEntry GetCurrentAnimationEntry(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_GetCurrentAnimationEntry_Public_AnimationEntry_AnimateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationEntry>(intPtr3) : null;
		}
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x0004A17C File Offset: 0x0004837C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241344, XrefRangeEnd = 241354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CountCurrentAnimationEntriesToDestination(int destinationLocatorIndex, int destinationLocatorInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref destinationLocatorIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorInstanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_CountCurrentAnimationEntriesToDestination_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x0004A1D4 File Offset: 0x000483D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241354, XrefRangeEnd = 241371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<AnimationEntry> GetCurrentAnimationEntriesToDestination(int destinationLocatorIndex, int destinationLocatorInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref destinationLocatorIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorInstanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_GetCurrentAnimationEntriesToDestination_Public_List_1_AnimationEntry_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AnimationEntry>>(intPtr3) : null;
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x0004A230 File Offset: 0x00048430
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241371, XrefRangeEnd = 241381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetCurrentAnimationToDestinationFlags(int destinationLocatorIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref destinationLocatorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_GetCurrentAnimationToDestinationFlags_Public_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x0004A27C File Offset: 0x0004847C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 241394, RefRangeEnd = 241397, XrefRangeStart = 241381, XrefRangeEnd = 241394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToAnimationList(AnimateObject animate_object, int sourceLocatorIndex, int sourceLocatorInstanceID, int destinationLocatorIndex, int destinationLocatorInstanceID, uint animationFlags, Vector3 additionalRotation, float delayAtStart, float pauseAtDestination, bool bCancelQueuedAnimation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorIndex;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorInstanceID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorIndex;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorInstanceID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationFlags;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalRotation;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayAtStart;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pauseAtDestination;
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCancelQueuedAnimation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_AddToAnimationList_Public_Void_AnimateObject_Int32_Int32_Int32_Int32_UInt32_Vector3_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x0004A340 File Offset: 0x00048540
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241423, RefRangeEnd = 241425, XrefRangeStart = 241397, XrefRangeEnd = 241423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RemoveFromAnimationList(AnimateObject animate_object, bool bCancelQueuedAnimation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCancelQueuedAnimation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_RemoveFromAnimationList_Public_Boolean_AnimateObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x0004A39C File Offset: 0x0004859C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 241451, RefRangeEnd = 241455, XrefRangeStart = 241425, XrefRangeEnd = 241451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool StartAnimation(AnimateObject animate_object, int sourceLocatorIndex, int sourceLocatorInstanceID, int destinationLocatorIndex, int destinationLocatorInstanceID, uint animationFlags, Vector3 additionalRotation, float delayAtStart = 0f, float pauseAtDestination = 0f, bool bCancelQueuedAnimation = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorIndex;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorInstanceID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorIndex;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorInstanceID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationFlags;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalRotation;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayAtStart;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pauseAtDestination;
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCancelQueuedAnimation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_StartAnimation_Public_Boolean_AnimateObject_Int32_Int32_Int32_Int32_UInt32_Vector3_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x0004A46C File Offset: 0x0004866C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241470, RefRangeEnd = 241471, XrefRangeStart = 241455, XrefRangeEnd = 241470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool QueueAnimation(AnimateObject animate_object, int sourceLocatorIndex, int sourceLocatorInstanceID, int destinationLocatorIndex, int destinationLocatorInstanceID, uint animationFlags, Vector3 additionalRotation, float delayAtStart = 0f, float pauseAtDestination = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorIndex;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorInstanceID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorIndex;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorInstanceID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationFlags;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalRotation;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayAtStart;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pauseAtDestination;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_QueueAnimation_Public_Boolean_AnimateObject_Int32_Int32_Int32_Int32_UInt32_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x0004A52C File Offset: 0x0004872C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241471, XrefRangeEnd = 241483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckForQueuedAnimation(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_CheckForQueuedAnimation_Public_Boolean_AnimateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001051 RID: 4177 RVA: 0x0004A57C File Offset: 0x0004877C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241497, RefRangeEnd = 241498, XrefRangeStart = 241483, XrefRangeEnd = 241497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool StartAnimationToLocator(AnimateObject animate_object, AnimationLocator destinationLocator, int destinationLocatorIndex = 0, AnimationLocator sourceLocator = null, float delayAtStart = 0f, float pauseAtDestination = 0f, bool bCancelQueuedAnimation = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationLocator);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorIndex;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceLocator);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayAtStart;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pauseAtDestination;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCancelQueuedAnimation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_StartAnimationToLocator_Public_Boolean_AnimateObject_AnimationLocator_Int32_AnimationLocator_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x0004A628 File Offset: 0x00048828
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241509, RefRangeEnd = 241511, XrefRangeStart = 241498, XrefRangeEnd = 241509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool StartAnimationToPlaceholder(AnimateObject animate_object, GameObject target_placeholder, int destinationLocatorIndex = 0, int destinationLocatorInstanceID = 0, float delayAtStart = 0f, float pauseAtDestination = 0f, bool bCancelQueuedAnimation = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target_placeholder);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorIndex;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorInstanceID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayAtStart;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pauseAtDestination;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCancelQueuedAnimation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_StartAnimationToPlaceholder_Public_Boolean_AnimateObject_GameObject_Int32_Int32_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x0004A6D0 File Offset: 0x000488D0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetAnimationRatesReturnDragObject(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationManager.NativeMethodInfoPtr_SetAnimationRatesReturnDragObject_Public_Virtual_New_Void_AnimateObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x0004A720 File Offset: 0x00048920
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241511, RefRangeEnd = 241512, XrefRangeStart = 241511, XrefRangeEnd = 241511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAnimationToDestination(int destinationLocatorIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref destinationLocatorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_IsAnimationToDestination_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x0004A76C File Offset: 0x0004896C
	[CallerCount(0)]
	public unsafe virtual bool PauseForAnimationManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationManager.NativeMethodInfoPtr_PauseForAnimationManager_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x0004A7B4 File Offset: 0x000489B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241512, XrefRangeEnd = 241513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddWaitForAllAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_AddWaitForAllAnimation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x0004A7F0 File Offset: 0x000489F0
	[CallerCount(0)]
	public unsafe bool AddWaitForDestination(int destinationLocatorIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref destinationLocatorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_AddWaitForDestination_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x0004A83C File Offset: 0x00048A3C
	[CallerCount(0)]
	public unsafe void AddWaitForDestinationFlags(long destinationFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref destinationFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_AddWaitForDestinationFlags_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x0004A87C File Offset: 0x00048A7C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 241519, RefRangeEnd = 241523, XrefRangeStart = 241513, XrefRangeEnd = 241519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdateAnimateList(AnimateObject card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_AddUpdateAnimateList_Public_Void_AnimateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x0004A8C0 File Offset: 0x00048AC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241523, XrefRangeEnd = 241526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveUpdateAnimateList(AnimateObject card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr_RemoveUpdateAnimateList_Public_Void_AnimateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x0004A904 File Offset: 0x00048B04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241526, XrefRangeEnd = 241537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x0004A940 File Offset: 0x00048B40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241537, XrefRangeEnd = 241554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x0000B508 File Offset: 0x00009708
	public AnimationManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x0600105E RID: 4190 RVA: 0x0004A97C File Offset: 0x00048B7C
	// (set) Token: 0x0600105F RID: 4191 RVA: 0x0000B511 File Offset: 0x00009711
	public unsafe static uint k_AnimationFlagForceToStart
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AnimationManager.NativeFieldInfoPtr_k_AnimationFlagForceToStart, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnimationManager.NativeFieldInfoPtr_k_AnimationFlagForceToStart, (void*)(&value));
		}
	}

	// Token: 0x17000567 RID: 1383
	// (get) Token: 0x06001060 RID: 4192 RVA: 0x0004A998 File Offset: 0x00048B98
	// (set) Token: 0x06001061 RID: 4193 RVA: 0x0000B51F File Offset: 0x0000971F
	public unsafe AnimationLayer m_DefaultAnimationLayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_DefaultAnimationLayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLayer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_DefaultAnimationLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000568 RID: 1384
	// (get) Token: 0x06001062 RID: 4194 RVA: 0x0004A9C8 File Offset: 0x00048BC8
	// (set) Token: 0x06001063 RID: 4195 RVA: 0x0000B53E File Offset: 0x0000973E
	public unsafe Il2CppReferenceArray<List<AnimationLocatorEntry>> m_LocatorMap
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_LocatorMap);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<AnimationLocatorEntry>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_LocatorMap), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x06001064 RID: 4196 RVA: 0x0004A9F8 File Offset: 0x00048BF8
	// (set) Token: 0x06001065 RID: 4197 RVA: 0x0000B55D File Offset: 0x0000975D
	public unsafe List<AnimationEntry> m_AnimationList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_AnimationList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AnimationEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_AnimationList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700056A RID: 1386
	// (get) Token: 0x06001066 RID: 4198 RVA: 0x0004AA28 File Offset: 0x00048C28
	// (set) Token: 0x06001067 RID: 4199 RVA: 0x0000B57C File Offset: 0x0000977C
	public unsafe List<AnimationEntry> m_QueuedAnimationList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_QueuedAnimationList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AnimationEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_QueuedAnimationList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700056B RID: 1387
	// (get) Token: 0x06001068 RID: 4200 RVA: 0x0004AA58 File Offset: 0x00048C58
	// (set) Token: 0x06001069 RID: 4201 RVA: 0x0000B59B File Offset: 0x0000979B
	public unsafe long m_AnimationDestinationFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_AnimationDestinationFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_AnimationDestinationFlags)) = value;
		}
	}

	// Token: 0x1700056C RID: 1388
	// (get) Token: 0x0600106A RID: 4202 RVA: 0x0004AA80 File Offset: 0x00048C80
	// (set) Token: 0x0600106B RID: 4203 RVA: 0x0000B5B6 File Offset: 0x000097B6
	public unsafe long m_WaitForDestinationFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_WaitForDestinationFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_WaitForDestinationFlags)) = value;
		}
	}

	// Token: 0x1700056D RID: 1389
	// (get) Token: 0x0600106C RID: 4204 RVA: 0x0004AAA8 File Offset: 0x00048CA8
	// (set) Token: 0x0600106D RID: 4205 RVA: 0x0000B5D1 File Offset: 0x000097D1
	public unsafe bool m_WaitForAllAnimation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_WaitForAllAnimation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_WaitForAllAnimation)) = value;
		}
	}

	// Token: 0x1700056E RID: 1390
	// (get) Token: 0x0600106E RID: 4206 RVA: 0x0004AAD0 File Offset: 0x00048CD0
	// (set) Token: 0x0600106F RID: 4207 RVA: 0x0000B5EC File Offset: 0x000097EC
	public unsafe AnimationManager.AnimationManagerCallback m_OnBeginAnimationCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_OnBeginAnimationCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationManager.AnimationManagerCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_OnBeginAnimationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700056F RID: 1391
	// (get) Token: 0x06001070 RID: 4208 RVA: 0x0004AB00 File Offset: 0x00048D00
	// (set) Token: 0x06001071 RID: 4209 RVA: 0x0000B60B File Offset: 0x0000980B
	public unsafe AnimationManager.AnimationManagerCallback m_OnEndAnimationCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_OnEndAnimationCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationManager.AnimationManagerCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_OnEndAnimationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000570 RID: 1392
	// (get) Token: 0x06001072 RID: 4210 RVA: 0x0004AB30 File Offset: 0x00048D30
	// (set) Token: 0x06001073 RID: 4211 RVA: 0x0000B62A File Offset: 0x0000982A
	public unsafe List<AnimateObject> m_UpdateAnimateList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_UpdateAnimateList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AnimateObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_UpdateAnimateList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000571 RID: 1393
	// (get) Token: 0x06001074 RID: 4212 RVA: 0x0004AB60 File Offset: 0x00048D60
	// (set) Token: 0x06001075 RID: 4213 RVA: 0x0000B649 File Offset: 0x00009849
	public unsafe float m_AnimationSpeedScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_AnimationSpeedScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_AnimationSpeedScale)) = value;
		}
	}

	// Token: 0x17000572 RID: 1394
	// (get) Token: 0x06001076 RID: 4214 RVA: 0x0004AB88 File Offset: 0x00048D88
	// (set) Token: 0x06001077 RID: 4215 RVA: 0x0000B664 File Offset: 0x00009864
	public unsafe float m_MaxAnimationSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_MaxAnimationSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationManager.NativeFieldInfoPtr_m_MaxAnimationSpeed)) = value;
		}
	}

	// Token: 0x04000B5A RID: 2906
	private static readonly IntPtr NativeFieldInfoPtr_k_AnimationFlagForceToStart;

	// Token: 0x04000B5B RID: 2907
	private static readonly IntPtr NativeFieldInfoPtr_m_DefaultAnimationLayer;

	// Token: 0x04000B5C RID: 2908
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorMap;

	// Token: 0x04000B5D RID: 2909
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationList;

	// Token: 0x04000B5E RID: 2910
	private static readonly IntPtr NativeFieldInfoPtr_m_QueuedAnimationList;

	// Token: 0x04000B5F RID: 2911
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationDestinationFlags;

	// Token: 0x04000B60 RID: 2912
	private static readonly IntPtr NativeFieldInfoPtr_m_WaitForDestinationFlags;

	// Token: 0x04000B61 RID: 2913
	private static readonly IntPtr NativeFieldInfoPtr_m_WaitForAllAnimation;

	// Token: 0x04000B62 RID: 2914
	private static readonly IntPtr NativeFieldInfoPtr_m_OnBeginAnimationCallback;

	// Token: 0x04000B63 RID: 2915
	private static readonly IntPtr NativeFieldInfoPtr_m_OnEndAnimationCallback;

	// Token: 0x04000B64 RID: 2916
	private static readonly IntPtr NativeFieldInfoPtr_m_UpdateAnimateList;

	// Token: 0x04000B65 RID: 2917
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationSpeedScale;

	// Token: 0x04000B66 RID: 2918
	private static readonly IntPtr NativeFieldInfoPtr_m_MaxAnimationSpeed;

	// Token: 0x04000B67 RID: 2919
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationSpeedScale_Public_Void_Single_0;

	// Token: 0x04000B68 RID: 2920
	private static readonly IntPtr NativeMethodInfoPtr_AddOnBeginAnimationCallback_Public_Void_AnimationManagerCallback_0;

	// Token: 0x04000B69 RID: 2921
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnBeginAnimationCallback_Public_Void_AnimationManagerCallback_0;

	// Token: 0x04000B6A RID: 2922
	private static readonly IntPtr NativeMethodInfoPtr_AddOnEndAnimationCallback_Public_Void_AnimationManagerCallback_0;

	// Token: 0x04000B6B RID: 2923
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnEndAnimationCallback_Public_Void_AnimationManagerCallback_0;

	// Token: 0x04000B6C RID: 2924
	private static readonly IntPtr NativeMethodInfoPtr_GetDefaultAnimationLayer_Public_AnimationLayer_0;

	// Token: 0x04000B6D RID: 2925
	private static readonly IntPtr NativeMethodInfoPtr_GetAnimationLocator_Public_AnimationLocator_Int32_Int32_0;

	// Token: 0x04000B6E RID: 2926
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationLocator_Public_Boolean_Int32_Int32_AnimationLocator_0;

	// Token: 0x04000B6F RID: 2927
	private static readonly IntPtr NativeMethodInfoPtr_RemoveAnimationLocator_Public_Boolean_Int32_Int32_0;

	// Token: 0x04000B70 RID: 2928
	private static readonly IntPtr NativeMethodInfoPtr_RemoveAllAnimationLocators_Public_Void_0;

	// Token: 0x04000B71 RID: 2929
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentAnimationEntry_Public_AnimationEntry_AnimateObject_0;

	// Token: 0x04000B72 RID: 2930
	private static readonly IntPtr NativeMethodInfoPtr_CountCurrentAnimationEntriesToDestination_Public_Int32_Int32_Int32_0;

	// Token: 0x04000B73 RID: 2931
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentAnimationEntriesToDestination_Public_List_1_AnimationEntry_Int32_Int32_0;

	// Token: 0x04000B74 RID: 2932
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentAnimationToDestinationFlags_Public_UInt32_Int32_0;

	// Token: 0x04000B75 RID: 2933
	private static readonly IntPtr NativeMethodInfoPtr_AddToAnimationList_Public_Void_AnimateObject_Int32_Int32_Int32_Int32_UInt32_Vector3_Single_Single_Boolean_0;

	// Token: 0x04000B76 RID: 2934
	private static readonly IntPtr NativeMethodInfoPtr_RemoveFromAnimationList_Public_Boolean_AnimateObject_Boolean_0;

	// Token: 0x04000B77 RID: 2935
	private static readonly IntPtr NativeMethodInfoPtr_StartAnimation_Public_Boolean_AnimateObject_Int32_Int32_Int32_Int32_UInt32_Vector3_Single_Single_Boolean_0;

	// Token: 0x04000B78 RID: 2936
	private static readonly IntPtr NativeMethodInfoPtr_QueueAnimation_Public_Boolean_AnimateObject_Int32_Int32_Int32_Int32_UInt32_Vector3_Single_Single_0;

	// Token: 0x04000B79 RID: 2937
	private static readonly IntPtr NativeMethodInfoPtr_CheckForQueuedAnimation_Public_Boolean_AnimateObject_0;

	// Token: 0x04000B7A RID: 2938
	private static readonly IntPtr NativeMethodInfoPtr_StartAnimationToLocator_Public_Boolean_AnimateObject_AnimationLocator_Int32_AnimationLocator_Single_Single_Boolean_0;

	// Token: 0x04000B7B RID: 2939
	private static readonly IntPtr NativeMethodInfoPtr_StartAnimationToPlaceholder_Public_Boolean_AnimateObject_GameObject_Int32_Int32_Single_Single_Boolean_0;

	// Token: 0x04000B7C RID: 2940
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationRatesReturnDragObject_Public_Virtual_New_Void_AnimateObject_0;

	// Token: 0x04000B7D RID: 2941
	private static readonly IntPtr NativeMethodInfoPtr_IsAnimationToDestination_Public_Boolean_Int32_0;

	// Token: 0x04000B7E RID: 2942
	private static readonly IntPtr NativeMethodInfoPtr_PauseForAnimationManager_Public_Virtual_New_Boolean_0;

	// Token: 0x04000B7F RID: 2943
	private static readonly IntPtr NativeMethodInfoPtr_AddWaitForAllAnimation_Public_Boolean_0;

	// Token: 0x04000B80 RID: 2944
	private static readonly IntPtr NativeMethodInfoPtr_AddWaitForDestination_Public_Boolean_Int32_0;

	// Token: 0x04000B81 RID: 2945
	private static readonly IntPtr NativeMethodInfoPtr_AddWaitForDestinationFlags_Public_Void_Int64_0;

	// Token: 0x04000B82 RID: 2946
	private static readonly IntPtr NativeMethodInfoPtr_AddUpdateAnimateList_Public_Void_AnimateObject_0;

	// Token: 0x04000B83 RID: 2947
	private static readonly IntPtr NativeMethodInfoPtr_RemoveUpdateAnimateList_Public_Void_AnimateObject_0;

	// Token: 0x04000B84 RID: 2948
	private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

	// Token: 0x04000B85 RID: 2949
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000191 RID: 401
	public sealed class AnimationManagerCallback : MulticastDelegate
	{
		// Token: 0x06002464 RID: 9316 RVA: 0x00087710 File Offset: 0x00085910
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationManagerCallback()
		{
			Il2CppClassPointerStore<AnimationManager.AnimationManagerCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationManager>.NativeClassPtr, "AnimationManagerCallback");
			AnimationManager.AnimationManagerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager.AnimationManagerCallback>.NativeClassPtr, 100666192);
			AnimationManager.AnimationManagerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager.AnimationManagerCallback>.NativeClassPtr, 100666193);
			AnimationManager.AnimationManagerCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AnimateObject_UInt32_Int32_Int32_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager.AnimationManagerCallback>.NativeClassPtr, 100666194);
			AnimationManager.AnimationManagerCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationManager.AnimationManagerCallback>.NativeClassPtr, 100666195);
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x00087784 File Offset: 0x00085984
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationManagerCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationManager.AnimationManagerCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.AnimationManagerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x000877E0 File Offset: 0x000859E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241158, RefRangeEnd = 241160, XrefRangeStart = 241140, XrefRangeEnd = 241158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(AnimateObject animateObject, uint animationFlags, int sourceLocatorIndex, int sourceLocatorInstanceID, int destinationLocatorIndex, int destinationLocatorInstanceID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorInstanceID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.AnimationManagerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00087868 File Offset: 0x00085A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241160, XrefRangeEnd = 241173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AnimateObject animateObject, uint animationFlags, int sourceLocatorIndex, int sourceLocatorInstanceID, int destinationLocatorIndex, int destinationLocatorInstanceID, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorInstanceID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorInstanceID;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.AnimationManagerCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AnimateObject_UInt32_Int32_Int32_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00087924 File Offset: 0x00085B24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationManager.AnimationManagerCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00016A23 File Offset: 0x00014C23
		public AnimationManagerCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x00016A2C File Offset: 0x00014C2C
		public static implicit operator AnimationManager.AnimationManagerCallback(Action<AnimateObject, uint, int, int, int, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<AnimationManager.AnimationManagerCallback>(A_0);
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x00016A34 File Offset: 0x00014C34
		public static AnimationManager.AnimationManagerCallback operator +(AnimationManager.AnimationManagerCallback A_0, AnimationManager.AnimationManagerCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AnimationManager.AnimationManagerCallback>();
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00016A42 File Offset: 0x00014C42
		public static AnimationManager.AnimationManagerCallback operator -(AnimationManager.AnimationManagerCallback A_0, AnimationManager.AnimationManagerCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AnimationManager.AnimationManagerCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AnimateObject_UInt32_Int32_Int32_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
