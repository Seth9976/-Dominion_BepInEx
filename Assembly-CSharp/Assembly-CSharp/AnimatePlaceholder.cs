using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200007D RID: 125
public class AnimatePlaceholder : MonoBehaviour
{
	// Token: 0x06000FEC RID: 4076 RVA: 0x00048B8C File Offset: 0x00046D8C
	// Note: this type is marked as 'beforefieldinit'.
	static AnimatePlaceholder()
	{
		Il2CppClassPointerStore<AnimatePlaceholder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimatePlaceholder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatePlaceholder>.NativeClassPtr);
		AnimatePlaceholder.NativeFieldInfoPtr_m_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatePlaceholder>.NativeClassPtr, "m_Owner");
		AnimatePlaceholder.NativeMethodInfoPtr_SetOwner_Public_Void_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatePlaceholder>.NativeClassPtr, 100664453);
		AnimatePlaceholder.NativeMethodInfoPtr_GetOwner_Public_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatePlaceholder>.NativeClassPtr, 100664454);
		AnimatePlaceholder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatePlaceholder>.NativeClassPtr, 100664455);
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x00048C0C File Offset: 0x00046E0C
	[CallerCount(0)]
	public unsafe void SetOwner(AnimateObject owner)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatePlaceholder.NativeMethodInfoPtr_SetOwner_Public_Void_AnimateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00048C50 File Offset: 0x00046E50
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimateObject GetOwner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatePlaceholder.NativeMethodInfoPtr_GetOwner_Public_AnimateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimateObject>(intPtr3) : null;
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00048C90 File Offset: 0x00046E90
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimatePlaceholder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatePlaceholder>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatePlaceholder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x0000B233 File Offset: 0x00009433
	public AnimatePlaceholder(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700054E RID: 1358
	// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00048CCC File Offset: 0x00046ECC
	// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x0000B23C File Offset: 0x0000943C
	public unsafe AnimateObject m_Owner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatePlaceholder.NativeFieldInfoPtr_m_Owner);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatePlaceholder.NativeFieldInfoPtr_m_Owner), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000B2B RID: 2859
	private static readonly IntPtr NativeFieldInfoPtr_m_Owner;

	// Token: 0x04000B2C RID: 2860
	private static readonly IntPtr NativeMethodInfoPtr_SetOwner_Public_Void_AnimateObject_0;

	// Token: 0x04000B2D RID: 2861
	private static readonly IntPtr NativeMethodInfoPtr_GetOwner_Public_AnimateObject_0;

	// Token: 0x04000B2E RID: 2862
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
