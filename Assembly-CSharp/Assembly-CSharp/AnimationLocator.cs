using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200007F RID: 127
public class AnimationLocator : MonoBehaviour
{
	// Token: 0x06001000 RID: 4096 RVA: 0x00048F48 File Offset: 0x00047148
	// Note: this type is marked as 'beforefieldinit'.
	static AnimationLocator()
	{
		Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimationLocator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr);
		AnimationLocator.NativeFieldInfoPtr_m_OverrideAnimationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, "m_OverrideAnimationLayer");
		AnimationLocator.NativeFieldInfoPtr_m_OverridePlaceLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, "m_OverridePlaceLocator");
		AnimationLocator.NativeFieldInfoPtr_m_AnimationHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, "m_AnimationHeight");
		AnimationLocator.NativeFieldInfoPtr_m_AdditionalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, "m_AdditionalRotation");
		AnimationLocator.NativeFieldInfoPtr_m_AdjustPlaceholderLayoutWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, "m_AdjustPlaceholderLayoutWidth");
		AnimationLocator.NativeFieldInfoPtr_m_AdjustPlaceholderLayoutHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, "m_AdjustPlaceholderLayoutHeight");
		AnimationLocator.NativeFieldInfoPtr_m_AnimationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, "m_AnimationManager");
		AnimationLocator.NativeMethodInfoPtr_SetAnimationManager_Public_Void_AnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664459);
		AnimationLocator.NativeMethodInfoPtr_GetOverrideAnimationLayer_Public_AnimationLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664460);
		AnimationLocator.NativeMethodInfoPtr_SetOverrideAnimationLayer_Public_Void_AnimationLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664461);
		AnimationLocator.NativeMethodInfoPtr_GetOverridePlaceLocator_Public_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664462);
		AnimationLocator.NativeMethodInfoPtr_SetOverridePlaceLocator_Public_Void_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664463);
		AnimationLocator.NativeMethodInfoPtr_GetOverrideDestinationLocator_Public_Virtual_New_AnimationLocator_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664464);
		AnimationLocator.NativeMethodInfoPtr_GetAnimationHeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664465);
		AnimationLocator.NativeMethodInfoPtr_GetAdditionalRotation_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664466);
		AnimationLocator.NativeMethodInfoPtr_GetAdjustPlaceholderLayoutWidth_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664467);
		AnimationLocator.NativeMethodInfoPtr_GetAdjustPlaceholderLayoutHeight_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664468);
		AnimationLocator.NativeMethodInfoPtr_AnimateFromLocator_Public_Virtual_New_Void_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664469);
		AnimationLocator.NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664470);
		AnimationLocator.NativeMethodInfoPtr_AnimateToLocator_Public_Boolean_AnimateObject_AnimationLocator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664471);
		AnimationLocator.NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_New_Void_AnimateObject_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664472);
		AnimationLocator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr, 100664473);
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00049130 File Offset: 0x00047330
	[CallerCount(0)]
	public unsafe void SetAnimationManager(AnimationManager manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr_SetAnimationManager_Public_Void_AnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x00049174 File Offset: 0x00047374
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationLayer GetOverrideAnimationLayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr_GetOverrideAnimationLayer_Public_AnimationLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationLayer>(intPtr3) : null;
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x000491B4 File Offset: 0x000473B4
	[CallerCount(0)]
	public unsafe void SetOverrideAnimationLayer(AnimationLayer animation_layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animation_layer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr_SetOverrideAnimationLayer_Public_Void_AnimationLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x000491F8 File Offset: 0x000473F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationLocator GetOverridePlaceLocator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr_GetOverridePlaceLocator_Public_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr3) : null;
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00049238 File Offset: 0x00047438
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOverridePlaceLocator(AnimationLocator locator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(locator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr_SetOverridePlaceLocator_Public_Void_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x0004927C File Offset: 0x0004747C
	[CallerCount(734)]
	[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual AnimationLocator GetOverrideDestinationLocator(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationLocator.NativeMethodInfoPtr_GetOverrideDestinationLocator_Public_Virtual_New_AnimationLocator_AnimateObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr3) : null;
		}
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x000492D8 File Offset: 0x000474D8
	[CallerCount(0)]
	public unsafe float GetAnimationHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr_GetAnimationHeight_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00049314 File Offset: 0x00047514
	[CallerCount(0)]
	public unsafe Vector3 GetAdditionalRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr_GetAdditionalRotation_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00049350 File Offset: 0x00047550
	[CallerCount(0)]
	public unsafe bool GetAdjustPlaceholderLayoutWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr_GetAdjustPlaceholderLayoutWidth_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x0004938C File Offset: 0x0004758C
	[CallerCount(0)]
	public unsafe bool GetAdjustPlaceholderLayoutHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr_GetAdjustPlaceholderLayoutHeight_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x000493C8 File Offset: 0x000475C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241076, XrefRangeEnd = 241091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AnimateFromLocator(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationLocator.NativeMethodInfoPtr_AnimateFromLocator_Public_Virtual_New_Void_AnimateObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x00049418 File Offset: 0x00047618
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241091, XrefRangeEnd = 241102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetPlaceholderParent(GameObject placeholder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(placeholder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationLocator.NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x00049468 File Offset: 0x00047668
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241132, RefRangeEnd = 241134, XrefRangeStart = 241102, XrefRangeEnd = 241132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AnimateToLocator(AnimateObject animate_object, AnimationLocator sourceLocator, float delayAtStart = 0f, float pauseAtDestination = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceLocator);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayAtStart;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pauseAtDestination;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr_AnimateToLocator_Public_Boolean_AnimateObject_AnimationLocator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x000494E4 File Offset: 0x000476E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241134, XrefRangeEnd = 241138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PlaceAnimateObject(AnimateObject animate_object, bool bSetPosition = false, bool bSetRotation = false, bool bIgnoreOverride = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSetPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSetRotation;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIgnoreOverride;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationLocator.NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_New_Void_AnimateObject_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x0004955C File Offset: 0x0004775C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241138, XrefRangeEnd = 241140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationLocator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationLocator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationLocator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x0000B2D8 File Offset: 0x000094D8
	public AnimationLocator(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000553 RID: 1363
	// (get) Token: 0x06001011 RID: 4113 RVA: 0x00049598 File Offset: 0x00047798
	// (set) Token: 0x06001012 RID: 4114 RVA: 0x0000B2E1 File Offset: 0x000094E1
	public unsafe AnimationLayer m_OverrideAnimationLayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_OverrideAnimationLayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLayer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_OverrideAnimationLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x06001013 RID: 4115 RVA: 0x000495C8 File Offset: 0x000477C8
	// (set) Token: 0x06001014 RID: 4116 RVA: 0x0000B300 File Offset: 0x00009500
	public unsafe AnimationLocator m_OverridePlaceLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_OverridePlaceLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_OverridePlaceLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000555 RID: 1365
	// (get) Token: 0x06001015 RID: 4117 RVA: 0x000495F8 File Offset: 0x000477F8
	// (set) Token: 0x06001016 RID: 4118 RVA: 0x0000B31F File Offset: 0x0000951F
	public unsafe float m_AnimationHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_AnimationHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_AnimationHeight)) = value;
		}
	}

	// Token: 0x17000556 RID: 1366
	// (get) Token: 0x06001017 RID: 4119 RVA: 0x00049620 File Offset: 0x00047820
	// (set) Token: 0x06001018 RID: 4120 RVA: 0x0000B33A File Offset: 0x0000953A
	public unsafe Vector3 m_AdditionalRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_AdditionalRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_AdditionalRotation)) = value;
		}
	}

	// Token: 0x17000557 RID: 1367
	// (get) Token: 0x06001019 RID: 4121 RVA: 0x00049648 File Offset: 0x00047848
	// (set) Token: 0x0600101A RID: 4122 RVA: 0x0000B355 File Offset: 0x00009555
	public unsafe bool m_AdjustPlaceholderLayoutWidth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_AdjustPlaceholderLayoutWidth);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_AdjustPlaceholderLayoutWidth)) = value;
		}
	}

	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x0600101B RID: 4123 RVA: 0x00049670 File Offset: 0x00047870
	// (set) Token: 0x0600101C RID: 4124 RVA: 0x0000B370 File Offset: 0x00009570
	public unsafe bool m_AdjustPlaceholderLayoutHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_AdjustPlaceholderLayoutHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_AdjustPlaceholderLayoutHeight)) = value;
		}
	}

	// Token: 0x17000559 RID: 1369
	// (get) Token: 0x0600101D RID: 4125 RVA: 0x00049698 File Offset: 0x00047898
	// (set) Token: 0x0600101E RID: 4126 RVA: 0x0000B38B File Offset: 0x0000958B
	public unsafe AnimationManager m_AnimationManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_AnimationManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationLocator.NativeFieldInfoPtr_m_AnimationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000B36 RID: 2870
	private static readonly IntPtr NativeFieldInfoPtr_m_OverrideAnimationLayer;

	// Token: 0x04000B37 RID: 2871
	private static readonly IntPtr NativeFieldInfoPtr_m_OverridePlaceLocator;

	// Token: 0x04000B38 RID: 2872
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationHeight;

	// Token: 0x04000B39 RID: 2873
	private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalRotation;

	// Token: 0x04000B3A RID: 2874
	private static readonly IntPtr NativeFieldInfoPtr_m_AdjustPlaceholderLayoutWidth;

	// Token: 0x04000B3B RID: 2875
	private static readonly IntPtr NativeFieldInfoPtr_m_AdjustPlaceholderLayoutHeight;

	// Token: 0x04000B3C RID: 2876
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationManager;

	// Token: 0x04000B3D RID: 2877
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationManager_Public_Void_AnimationManager_0;

	// Token: 0x04000B3E RID: 2878
	private static readonly IntPtr NativeMethodInfoPtr_GetOverrideAnimationLayer_Public_AnimationLayer_0;

	// Token: 0x04000B3F RID: 2879
	private static readonly IntPtr NativeMethodInfoPtr_SetOverrideAnimationLayer_Public_Void_AnimationLayer_0;

	// Token: 0x04000B40 RID: 2880
	private static readonly IntPtr NativeMethodInfoPtr_GetOverridePlaceLocator_Public_AnimationLocator_0;

	// Token: 0x04000B41 RID: 2881
	private static readonly IntPtr NativeMethodInfoPtr_SetOverridePlaceLocator_Public_Void_AnimationLocator_0;

	// Token: 0x04000B42 RID: 2882
	private static readonly IntPtr NativeMethodInfoPtr_GetOverrideDestinationLocator_Public_Virtual_New_AnimationLocator_AnimateObject_0;

	// Token: 0x04000B43 RID: 2883
	private static readonly IntPtr NativeMethodInfoPtr_GetAnimationHeight_Public_Single_0;

	// Token: 0x04000B44 RID: 2884
	private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalRotation_Public_Vector3_0;

	// Token: 0x04000B45 RID: 2885
	private static readonly IntPtr NativeMethodInfoPtr_GetAdjustPlaceholderLayoutWidth_Public_Boolean_0;

	// Token: 0x04000B46 RID: 2886
	private static readonly IntPtr NativeMethodInfoPtr_GetAdjustPlaceholderLayoutHeight_Public_Boolean_0;

	// Token: 0x04000B47 RID: 2887
	private static readonly IntPtr NativeMethodInfoPtr_AnimateFromLocator_Public_Virtual_New_Void_AnimateObject_0;

	// Token: 0x04000B48 RID: 2888
	private static readonly IntPtr NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_New_Void_GameObject_0;

	// Token: 0x04000B49 RID: 2889
	private static readonly IntPtr NativeMethodInfoPtr_AnimateToLocator_Public_Boolean_AnimateObject_AnimationLocator_Single_Single_0;

	// Token: 0x04000B4A RID: 2890
	private static readonly IntPtr NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_New_Void_AnimateObject_Boolean_Boolean_Boolean_0;

	// Token: 0x04000B4B RID: 2891
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
