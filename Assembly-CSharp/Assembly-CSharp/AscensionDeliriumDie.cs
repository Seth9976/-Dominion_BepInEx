using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200001E RID: 30
public class AscensionDeliriumDie : DragObject
{
	// Token: 0x06000584 RID: 1412 RVA: 0x0002A7CC File Offset: 0x000289CC
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionDeliriumDie()
	{
		Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionDeliriumDie");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr);
		AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDieImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_DeliriumDieImage");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDieFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_DeliriumDieFaces");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_AnimateFaceTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_AnimateFaceTime");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDie3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_DeliriumDie3D");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDie3DFinishPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_DeliriumDie3DFinishPositions");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_MaxRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_MaxRotateSpeed");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_AccelerationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_AccelerationTime");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_FinishTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_FinishTime");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_bAnimateDisplayedFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_bAnimateDisplayedFace");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDieInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_DeliriumDieInstanceID");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_DisplayedFaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_DisplayedFaceIndex");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_DisplayedFaceTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_DisplayedFaceTime");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_bIs3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_bIs3D");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_FinishPositionsQuat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_FinishPositionsQuat");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_CurrentRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_CurrentRotateSpeed");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_RandomRotateVec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_RandomRotateVec");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_Random");
		AscensionDeliriumDie.NativeFieldInfoPtr_m_DisableDeliriumDieButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "m_DisableDeliriumDieButton");
		AscensionDeliriumDie.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663669);
		AscensionDeliriumDie.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663670);
		AscensionDeliriumDie.NativeMethodInfoPtr_SetDelirumDieButton_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663671);
		AscensionDeliriumDie.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663672);
		AscensionDeliriumDie.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663673);
		AscensionDeliriumDie.NativeMethodInfoPtr_GetDeliriumDieInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663674);
		AscensionDeliriumDie.NativeMethodInfoPtr_SetDeliriumDieInstanceID_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663675);
		AscensionDeliriumDie.NativeMethodInfoPtr_SetDisplayedFace_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663676);
		AscensionDeliriumDie.NativeMethodInfoPtr_SetRandomDisplayedFace_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663677);
		AscensionDeliriumDie.NativeMethodInfoPtr_BeginAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663678);
		AscensionDeliriumDie.NativeMethodInfoPtr_EndAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663679);
		AscensionDeliriumDie.NativeMethodInfoPtr_AccelerateRotation_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663680);
		AscensionDeliriumDie.NativeMethodInfoPtr_RotateToFace_Private_IEnumerator_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663681);
		AscensionDeliriumDie.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, 100663682);
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x0002AA7C File Offset: 0x00028C7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229493, XrefRangeEnd = 229516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x0002AAB0 File Offset: 0x00028CB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229516, XrefRangeEnd = 229518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x0002AAE4 File Offset: 0x00028CE4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229525, RefRangeEnd = 229526, XrefRangeStart = 229518, XrefRangeEnd = 229525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDelirumDieButton(GameObject button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_SetDelirumDieButton_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x0002AB28 File Offset: 0x00028D28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229526, XrefRangeEnd = 229531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x0002AB5C File Offset: 0x00028D5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229531, XrefRangeEnd = 229536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x0002AB90 File Offset: 0x00028D90
	[CallerCount(0)]
	public unsafe int GetDeliriumDieInstanceID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_GetDeliriumDieInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x0002ABCC File Offset: 0x00028DCC
	[CallerCount(0)]
	public unsafe void SetDeliriumDieInstanceID(int instanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_SetDeliriumDieInstanceID_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x0002AC0C File Offset: 0x00028E0C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 229556, RefRangeEnd = 229559, XrefRangeStart = 229536, XrefRangeEnd = 229556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDisplayedFace(int faceIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref faceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_SetDisplayedFace_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x0002AC4C File Offset: 0x00028E4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229559, XrefRangeEnd = 229560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRandomDisplayedFace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_SetRandomDisplayedFace_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x0002AC80 File Offset: 0x00028E80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229560, XrefRangeEnd = 229574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginAnimationCallback(AnimateObject animateObject, AnimationLocator sourceLocator, AnimationLocator destinationLocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceLocator);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationLocator);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_BeginAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x0002ACE8 File Offset: 0x00028EE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229574, XrefRangeEnd = 229584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndAnimationCallback(AnimateObject animateObject, AnimationLocator sourceLocator, AnimationLocator destinationLocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceLocator);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationLocator);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_EndAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x0002AD50 File Offset: 0x00028F50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229584, XrefRangeEnd = 229588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator AccelerateRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_AccelerateRotation_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x0002AD90 File Offset: 0x00028F90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229588, XrefRangeEnd = 229592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator RotateToFace(Quaternion final)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref final;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr_RotateToFace_Private_IEnumerator_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x0002ADDC File Offset: 0x00028FDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229592, XrefRangeEnd = 229598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionDeliriumDie()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0000549C File Offset: 0x0000369C
	public AscensionDeliriumDie(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06000594 RID: 1428 RVA: 0x0002AE18 File Offset: 0x00029018
	// (set) Token: 0x06000595 RID: 1429 RVA: 0x000054A5 File Offset: 0x000036A5
	public unsafe Image m_DeliriumDieImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDieImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDieImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06000596 RID: 1430 RVA: 0x0002AE48 File Offset: 0x00029048
	// (set) Token: 0x06000597 RID: 1431 RVA: 0x000054C4 File Offset: 0x000036C4
	public unsafe Il2CppReferenceArray<Sprite> m_DeliriumDieFaces
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDieFaces);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDieFaces), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x06000598 RID: 1432 RVA: 0x0002AE78 File Offset: 0x00029078
	// (set) Token: 0x06000599 RID: 1433 RVA: 0x000054E3 File Offset: 0x000036E3
	public unsafe float m_AnimateFaceTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_AnimateFaceTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_AnimateFaceTime)) = value;
		}
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x0600059A RID: 1434 RVA: 0x0002AEA0 File Offset: 0x000290A0
	// (set) Token: 0x0600059B RID: 1435 RVA: 0x000054FE File Offset: 0x000036FE
	public unsafe Transform m_DeliriumDie3D
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDie3D);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDie3D), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x0600059C RID: 1436 RVA: 0x0002AED0 File Offset: 0x000290D0
	// (set) Token: 0x0600059D RID: 1437 RVA: 0x0000551D File Offset: 0x0000371D
	public unsafe Il2CppStructArray<Vector3> m_DeliriumDie3DFinishPositions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDie3DFinishPositions);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDie3DFinishPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x0600059E RID: 1438 RVA: 0x0002AF00 File Offset: 0x00029100
	// (set) Token: 0x0600059F RID: 1439 RVA: 0x0000553C File Offset: 0x0000373C
	public unsafe float m_MaxRotateSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_MaxRotateSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_MaxRotateSpeed)) = value;
		}
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0002AF28 File Offset: 0x00029128
	// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00005557 File Offset: 0x00003757
	public unsafe float m_AccelerationTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_AccelerationTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_AccelerationTime)) = value;
		}
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0002AF50 File Offset: 0x00029150
	// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00005572 File Offset: 0x00003772
	public unsafe float m_FinishTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_FinishTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_FinishTime)) = value;
		}
	}

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0002AF78 File Offset: 0x00029178
	// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0000558D File Offset: 0x0000378D
	public unsafe bool m_bAnimateDisplayedFace
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_bAnimateDisplayedFace);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_bAnimateDisplayedFace)) = value;
		}
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0002AFA0 File Offset: 0x000291A0
	// (set) Token: 0x060005A7 RID: 1447 RVA: 0x000055A8 File Offset: 0x000037A8
	public unsafe int m_DeliriumDieInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDieInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DeliriumDieInstanceID)) = value;
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0002AFC8 File Offset: 0x000291C8
	// (set) Token: 0x060005A9 RID: 1449 RVA: 0x000055C3 File Offset: 0x000037C3
	public unsafe int m_DisplayedFaceIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DisplayedFaceIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DisplayedFaceIndex)) = value;
		}
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x060005AA RID: 1450 RVA: 0x0002AFF0 File Offset: 0x000291F0
	// (set) Token: 0x060005AB RID: 1451 RVA: 0x000055DE File Offset: 0x000037DE
	public unsafe float m_DisplayedFaceTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DisplayedFaceTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DisplayedFaceTime)) = value;
		}
	}

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x060005AC RID: 1452 RVA: 0x0002B018 File Offset: 0x00029218
	// (set) Token: 0x060005AD RID: 1453 RVA: 0x000055F9 File Offset: 0x000037F9
	public unsafe bool m_bIs3D
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_bIs3D);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_bIs3D)) = value;
		}
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x060005AE RID: 1454 RVA: 0x0002B040 File Offset: 0x00029240
	// (set) Token: 0x060005AF RID: 1455 RVA: 0x00005614 File Offset: 0x00003814
	public unsafe Il2CppStructArray<Quaternion> m_FinishPositionsQuat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_FinishPositionsQuat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Quaternion>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_FinishPositionsQuat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0002B070 File Offset: 0x00029270
	// (set) Token: 0x060005B1 RID: 1457 RVA: 0x00005633 File Offset: 0x00003833
	public unsafe float m_CurrentRotateSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_CurrentRotateSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_CurrentRotateSpeed)) = value;
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0002B098 File Offset: 0x00029298
	// (set) Token: 0x060005B3 RID: 1459 RVA: 0x0000564E File Offset: 0x0000384E
	public unsafe Vector3 m_RandomRotateVec
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_RandomRotateVec);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_RandomRotateVec)) = value;
		}
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0002B0C0 File Offset: 0x000292C0
	// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00005669 File Offset: 0x00003869
	public unsafe global::Il2CppSystem.Random m_Random
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_Random);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Random>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_Random), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0002B0F0 File Offset: 0x000292F0
	// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00005688 File Offset: 0x00003888
	public unsafe GameObject m_DisableDeliriumDieButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DisableDeliriumDieButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie.NativeFieldInfoPtr_m_DisableDeliriumDieButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400036F RID: 879
	private static readonly IntPtr NativeFieldInfoPtr_m_DeliriumDieImage;

	// Token: 0x04000370 RID: 880
	private static readonly IntPtr NativeFieldInfoPtr_m_DeliriumDieFaces;

	// Token: 0x04000371 RID: 881
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateFaceTime;

	// Token: 0x04000372 RID: 882
	private static readonly IntPtr NativeFieldInfoPtr_m_DeliriumDie3D;

	// Token: 0x04000373 RID: 883
	private static readonly IntPtr NativeFieldInfoPtr_m_DeliriumDie3DFinishPositions;

	// Token: 0x04000374 RID: 884
	private static readonly IntPtr NativeFieldInfoPtr_m_MaxRotateSpeed;

	// Token: 0x04000375 RID: 885
	private static readonly IntPtr NativeFieldInfoPtr_m_AccelerationTime;

	// Token: 0x04000376 RID: 886
	private static readonly IntPtr NativeFieldInfoPtr_m_FinishTime;

	// Token: 0x04000377 RID: 887
	private static readonly IntPtr NativeFieldInfoPtr_m_bAnimateDisplayedFace;

	// Token: 0x04000378 RID: 888
	private static readonly IntPtr NativeFieldInfoPtr_m_DeliriumDieInstanceID;

	// Token: 0x04000379 RID: 889
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedFaceIndex;

	// Token: 0x0400037A RID: 890
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedFaceTime;

	// Token: 0x0400037B RID: 891
	private static readonly IntPtr NativeFieldInfoPtr_m_bIs3D;

	// Token: 0x0400037C RID: 892
	private static readonly IntPtr NativeFieldInfoPtr_m_FinishPositionsQuat;

	// Token: 0x0400037D RID: 893
	private static readonly IntPtr NativeFieldInfoPtr_m_CurrentRotateSpeed;

	// Token: 0x0400037E RID: 894
	private static readonly IntPtr NativeFieldInfoPtr_m_RandomRotateVec;

	// Token: 0x0400037F RID: 895
	private static readonly IntPtr NativeFieldInfoPtr_m_Random;

	// Token: 0x04000380 RID: 896
	private static readonly IntPtr NativeFieldInfoPtr_m_DisableDeliriumDieButton;

	// Token: 0x04000381 RID: 897
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000382 RID: 898
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000383 RID: 899
	private static readonly IntPtr NativeMethodInfoPtr_SetDelirumDieButton_Public_Void_GameObject_0;

	// Token: 0x04000384 RID: 900
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04000385 RID: 901
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04000386 RID: 902
	private static readonly IntPtr NativeMethodInfoPtr_GetDeliriumDieInstanceID_Public_Int32_0;

	// Token: 0x04000387 RID: 903
	private static readonly IntPtr NativeMethodInfoPtr_SetDeliriumDieInstanceID_Public_Void_Int32_0;

	// Token: 0x04000388 RID: 904
	private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedFace_Public_Void_Int32_0;

	// Token: 0x04000389 RID: 905
	private static readonly IntPtr NativeMethodInfoPtr_SetRandomDisplayedFace_Public_Void_0;

	// Token: 0x0400038A RID: 906
	private static readonly IntPtr NativeMethodInfoPtr_BeginAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0;

	// Token: 0x0400038B RID: 907
	private static readonly IntPtr NativeMethodInfoPtr_EndAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0;

	// Token: 0x0400038C RID: 908
	private static readonly IntPtr NativeMethodInfoPtr_AccelerateRotation_Private_IEnumerator_0;

	// Token: 0x0400038D RID: 909
	private static readonly IntPtr NativeMethodInfoPtr_RotateToFace_Private_IEnumerator_Quaternion_0;

	// Token: 0x0400038E RID: 910
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200016B RID: 363
	[ObfuscatedName("AscensionDeliriumDie+<AccelerateRotation>d__29")]
	public sealed class _AccelerateRotation_d__29 : global::Il2CppSystem.Object
	{
		// Token: 0x060022C0 RID: 8896 RVA: 0x000825F8 File Offset: 0x000807F8
		// Note: this type is marked as 'beforefieldinit'.
		static _AccelerateRotation_d__29()
		{
			Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "<AccelerateRotation>d__29");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr);
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, "<>1__state");
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, "<>2__current");
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, "<>4__this");
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr__previousTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, "<previousTime>5__2");
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr__currentAnimTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, "<currentAnimTime>5__3");
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, 100666034);
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, 100666035);
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, 100666036);
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, 100666037);
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, 100666038);
			AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr, 100666039);
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00082700 File Offset: 0x00080900
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _AccelerateRotation_d__29(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionDeliriumDie._AccelerateRotation_d__29>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00082748 File Offset: 0x00080948
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0008277C File Offset: 0x0008097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229451, XrefRangeEnd = 229464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x000827B8 File Offset: 0x000809B8
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000827F8 File Offset: 0x000809F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229464, XrefRangeEnd = 229469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0008282C File Offset: 0x00080A2C
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._AccelerateRotation_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00015DC4 File Offset: 0x00013FC4
		public _AccelerateRotation_d__29(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x0008286C File Offset: 0x00080A6C
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x00015DCD File Offset: 0x00013FCD
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x00082894 File Offset: 0x00080A94
		// (set) Token: 0x060022CB RID: 8907 RVA: 0x00015DE8 File Offset: 0x00013FE8
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x000828C4 File Offset: 0x00080AC4
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x00015E07 File Offset: 0x00014007
		public unsafe AscensionDeliriumDie __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionDeliriumDie>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x000828F4 File Offset: 0x00080AF4
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x00015E26 File Offset: 0x00014026
		public unsafe float _previousTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr__previousTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr__previousTime_5__2)) = value;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x0008291C File Offset: 0x00080B1C
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x00015E41 File Offset: 0x00014041
		public unsafe float _currentAnimTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr__currentAnimTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._AccelerateRotation_d__29.NativeFieldInfoPtr__currentAnimTime_5__3)) = value;
			}
		}

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__2;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeFieldInfoPtr__currentAnimTime_5__3;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200016C RID: 364
	[ObfuscatedName("AscensionDeliriumDie+<RotateToFace>d__30")]
	public sealed class _RotateToFace_d__30 : global::Il2CppSystem.Object
	{
		// Token: 0x060022D2 RID: 8914 RVA: 0x00082944 File Offset: 0x00080B44
		// Note: this type is marked as 'beforefieldinit'.
		static _RotateToFace_d__30()
		{
			Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionDeliriumDie>.NativeClassPtr, "<RotateToFace>d__30");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr);
			AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, "<>1__state");
			AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, "<>2__current");
			AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, "<>4__this");
			AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr_final = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, "final");
			AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, "<start>5__2");
			AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, "<previousTime>5__3");
			AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr__currentAnimTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, "<currentAnimTime>5__4");
			AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, 100666040);
			AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, 100666041);
			AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, 100666042);
			AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, 100666043);
			AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, 100666044);
			AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr, 100666045);
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00082A74 File Offset: 0x00080C74
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _RotateToFace_d__30(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionDeliriumDie._RotateToFace_d__30>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00082ABC File Offset: 0x00080CBC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00082AF0 File Offset: 0x00080CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229469, XrefRangeEnd = 229488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x00082B2C File Offset: 0x00080D2C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00082B6C File Offset: 0x00080D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229488, XrefRangeEnd = 229493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x00082BA0 File Offset: 0x00080DA0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDeliriumDie._RotateToFace_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00015E5C File Offset: 0x0001405C
		public _RotateToFace_d__30(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x00082BE0 File Offset: 0x00080DE0
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x00015E65 File Offset: 0x00014065
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x00082C08 File Offset: 0x00080E08
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x00015E80 File Offset: 0x00014080
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x00082C38 File Offset: 0x00080E38
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x00015E9F File Offset: 0x0001409F
		public unsafe AscensionDeliriumDie __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionDeliriumDie>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x00082C68 File Offset: 0x00080E68
		// (set) Token: 0x060022E1 RID: 8929 RVA: 0x00015EBE File Offset: 0x000140BE
		public unsafe Quaternion final
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr_final);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr_final)) = value;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x00082C90 File Offset: 0x00080E90
		// (set) Token: 0x060022E3 RID: 8931 RVA: 0x00015ED9 File Offset: 0x000140D9
		public unsafe Quaternion _start_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr__start_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr__start_5__2)) = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x00082CB8 File Offset: 0x00080EB8
		// (set) Token: 0x060022E5 RID: 8933 RVA: 0x00015EF4 File Offset: 0x000140F4
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x00082CE0 File Offset: 0x00080EE0
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x00015F0F File Offset: 0x0001410F
		public unsafe float _currentAnimTime_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr__currentAnimTime_5__4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDeliriumDie._RotateToFace_d__30.NativeFieldInfoPtr__currentAnimTime_5__4)) = value;
			}
		}

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeFieldInfoPtr_final;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeFieldInfoPtr__start_5__2;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeFieldInfoPtr__currentAnimTime_5__4;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
