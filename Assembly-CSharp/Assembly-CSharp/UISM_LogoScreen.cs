using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000DE RID: 222
public class UISM_LogoScreen : StateMachineBehaviour
{
	// Token: 0x06001BE1 RID: 7137 RVA: 0x0006D744 File Offset: 0x0006B944
	// Note: this type is marked as 'beforefieldinit'.
	static UISM_LogoScreen()
	{
		Il2CppClassPointerStore<UISM_LogoScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UISM_LogoScreen");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISM_LogoScreen>.NativeClassPtr);
		UISM_LogoScreen.NativeFieldInfoPtr_m_logoScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISM_LogoScreen>.NativeClassPtr, "m_logoScript");
		UISM_LogoScreen.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISM_LogoScreen>.NativeClassPtr, 100665482);
		UISM_LogoScreen.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISM_LogoScreen>.NativeClassPtr, 100665483);
		UISM_LogoScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISM_LogoScreen>.NativeClassPtr, 100665484);
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x0006D7C4 File Offset: 0x0006B9C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253259, XrefRangeEnd = 253275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISM_LogoScreen.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x0006D830 File Offset: 0x0006BA30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253275, XrefRangeEnd = 253291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISM_LogoScreen.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x0006D89C File Offset: 0x0006BA9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UISM_LogoScreen()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISM_LogoScreen>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISM_LogoScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x00011F4F File Offset: 0x0001014F
	public UISM_LogoScreen(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170008F6 RID: 2294
	// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x0006D8D8 File Offset: 0x0006BAD8
	// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x00011F58 File Offset: 0x00010158
	public unsafe LogoSplashScreen m_logoScript
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISM_LogoScreen.NativeFieldInfoPtr_m_logoScript);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogoSplashScreen>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISM_LogoScreen.NativeFieldInfoPtr_m_logoScript), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040012D2 RID: 4818
	private static readonly IntPtr NativeFieldInfoPtr_m_logoScript;

	// Token: 0x040012D3 RID: 4819
	private static readonly IntPtr NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;

	// Token: 0x040012D4 RID: 4820
	private static readonly IntPtr NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;

	// Token: 0x040012D5 RID: 4821
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
