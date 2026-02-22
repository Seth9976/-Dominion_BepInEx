using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000028 RID: 40
public class AscensionTransformEffect_End : StateMachineBehaviour
{
	// Token: 0x060008CB RID: 2251 RVA: 0x00033CE8 File Offset: 0x00031EE8
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionTransformEffect_End()
	{
		Il2CppClassPointerStore<AscensionTransformEffect_End>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionTransformEffect_End");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionTransformEffect_End>.NativeClassPtr);
		AscensionTransformEffect_End.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionTransformEffect_End>.NativeClassPtr, 100663885);
		AscensionTransformEffect_End.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionTransformEffect_End>.NativeClassPtr, 100663886);
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00033D40 File Offset: 0x00031F40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235299, XrefRangeEnd = 235307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateInfo;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionTransformEffect_End.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00033DAC File Offset: 0x00031FAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235307, XrefRangeEnd = 235308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionTransformEffect_End()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionTransformEffect_End>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionTransformEffect_End.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x000077C9 File Offset: 0x000059C9
	public AscensionTransformEffect_End(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400057B RID: 1403
	private static readonly IntPtr NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;

	// Token: 0x0400057C RID: 1404
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
