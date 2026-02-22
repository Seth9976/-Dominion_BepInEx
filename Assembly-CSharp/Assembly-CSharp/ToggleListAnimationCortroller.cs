using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000AF RID: 175
public class ToggleListAnimationCortroller : MonoBehaviour
{
	// Token: 0x06001473 RID: 5235 RVA: 0x000580CC File Offset: 0x000562CC
	// Note: this type is marked as 'beforefieldinit'.
	static ToggleListAnimationCortroller()
	{
		Il2CppClassPointerStore<ToggleListAnimationCortroller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ToggleListAnimationCortroller");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleListAnimationCortroller>.NativeClassPtr);
		ToggleListAnimationCortroller.NativeFieldInfoPtr_m_toggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleListAnimationCortroller>.NativeClassPtr, "m_toggles");
		ToggleListAnimationCortroller.NativeFieldInfoPtr_m_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleListAnimationCortroller>.NativeClassPtr, "m_animator");
		ToggleListAnimationCortroller.NativeFieldInfoPtr_m_animatorIntName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleListAnimationCortroller>.NativeClassPtr, "m_animatorIntName");
		ToggleListAnimationCortroller.NativeFieldInfoPtr_m_currentButtonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleListAnimationCortroller>.NativeClassPtr, "m_currentButtonIndex");
		ToggleListAnimationCortroller.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleListAnimationCortroller>.NativeClassPtr, 100664939);
		ToggleListAnimationCortroller.NativeMethodInfoPtr_HandleToggleChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleListAnimationCortroller>.NativeClassPtr, 100664940);
		ToggleListAnimationCortroller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleListAnimationCortroller>.NativeClassPtr, 100664941);
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x00058188 File Offset: 0x00056388
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 245894, RefRangeEnd = 245895, XrefRangeStart = 245892, XrefRangeEnd = 245894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleListAnimationCortroller.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x000581BC File Offset: 0x000563BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245895, XrefRangeEnd = 245897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleToggleChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleListAnimationCortroller.NativeMethodInfoPtr_HandleToggleChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x000581F0 File Offset: 0x000563F0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ToggleListAnimationCortroller()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleListAnimationCortroller>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleListAnimationCortroller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x0000D49D File Offset: 0x0000B69D
	public ToggleListAnimationCortroller(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000678 RID: 1656
	// (get) Token: 0x06001478 RID: 5240 RVA: 0x0005822C File Offset: 0x0005642C
	// (set) Token: 0x06001479 RID: 5241 RVA: 0x0000D4A6 File Offset: 0x0000B6A6
	public unsafe Il2CppReferenceArray<Toggle> m_toggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleListAnimationCortroller.NativeFieldInfoPtr_m_toggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleListAnimationCortroller.NativeFieldInfoPtr_m_toggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000679 RID: 1657
	// (get) Token: 0x0600147A RID: 5242 RVA: 0x0005825C File Offset: 0x0005645C
	// (set) Token: 0x0600147B RID: 5243 RVA: 0x0000D4C5 File Offset: 0x0000B6C5
	public unsafe Animator m_animator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleListAnimationCortroller.NativeFieldInfoPtr_m_animator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleListAnimationCortroller.NativeFieldInfoPtr_m_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700067A RID: 1658
	// (get) Token: 0x0600147C RID: 5244 RVA: 0x0005828C File Offset: 0x0005648C
	// (set) Token: 0x0600147D RID: 5245 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
	public unsafe string m_animatorIntName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleListAnimationCortroller.NativeFieldInfoPtr_m_animatorIntName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleListAnimationCortroller.NativeFieldInfoPtr_m_animatorIntName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700067B RID: 1659
	// (get) Token: 0x0600147E RID: 5246 RVA: 0x000582B4 File Offset: 0x000564B4
	// (set) Token: 0x0600147F RID: 5247 RVA: 0x0000D503 File Offset: 0x0000B703
	public unsafe int m_currentButtonIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleListAnimationCortroller.NativeFieldInfoPtr_m_currentButtonIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleListAnimationCortroller.NativeFieldInfoPtr_m_currentButtonIndex)) = value;
		}
	}

	// Token: 0x04000E3D RID: 3645
	private static readonly IntPtr NativeFieldInfoPtr_m_toggles;

	// Token: 0x04000E3E RID: 3646
	private static readonly IntPtr NativeFieldInfoPtr_m_animator;

	// Token: 0x04000E3F RID: 3647
	private static readonly IntPtr NativeFieldInfoPtr_m_animatorIntName;

	// Token: 0x04000E40 RID: 3648
	private static readonly IntPtr NativeFieldInfoPtr_m_currentButtonIndex;

	// Token: 0x04000E41 RID: 3649
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	// Token: 0x04000E42 RID: 3650
	private static readonly IntPtr NativeMethodInfoPtr_HandleToggleChange_Public_Void_0;

	// Token: 0x04000E43 RID: 3651
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
