using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200003E RID: 62
public class ResolveImageDisableWhenEmpty : MonoBehaviour
{
	// Token: 0x06000B2A RID: 2858 RVA: 0x0003AEB4 File Offset: 0x000390B4
	// Note: this type is marked as 'beforefieldinit'.
	static ResolveImageDisableWhenEmpty()
	{
		Il2CppClassPointerStore<ResolveImageDisableWhenEmpty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResolveImageDisableWhenEmpty");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveImageDisableWhenEmpty>.NativeClassPtr);
		ResolveImageDisableWhenEmpty.NativeFieldInfoPtr_m_raycastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveImageDisableWhenEmpty>.NativeClassPtr, "m_raycastTarget");
		ResolveImageDisableWhenEmpty.NativeFieldInfoPtr_m_resolveContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveImageDisableWhenEmpty>.NativeClassPtr, "m_resolveContainer");
		ResolveImageDisableWhenEmpty.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveImageDisableWhenEmpty>.NativeClassPtr, 100664080);
		ResolveImageDisableWhenEmpty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveImageDisableWhenEmpty>.NativeClassPtr, 100664081);
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x0003AF34 File Offset: 0x00039134
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237490, XrefRangeEnd = 237499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveImageDisableWhenEmpty.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x0003AF68 File Offset: 0x00039168
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResolveImageDisableWhenEmpty()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveImageDisableWhenEmpty>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveImageDisableWhenEmpty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x00008D6F File Offset: 0x00006F6F
	public ResolveImageDisableWhenEmpty(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0003AFA4 File Offset: 0x000391A4
	// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00008D78 File Offset: 0x00006F78
	public unsafe Image m_raycastTarget
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveImageDisableWhenEmpty.NativeFieldInfoPtr_m_raycastTarget);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveImageDisableWhenEmpty.NativeFieldInfoPtr_m_raycastTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003DC RID: 988
	// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0003AFD4 File Offset: 0x000391D4
	// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00008D97 File Offset: 0x00006F97
	public unsafe GameObject m_resolveContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveImageDisableWhenEmpty.NativeFieldInfoPtr_m_resolveContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveImageDisableWhenEmpty.NativeFieldInfoPtr_m_resolveContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040006F5 RID: 1781
	private static readonly IntPtr NativeFieldInfoPtr_m_raycastTarget;

	// Token: 0x040006F6 RID: 1782
	private static readonly IntPtr NativeFieldInfoPtr_m_resolveContainer;

	// Token: 0x040006F7 RID: 1783
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040006F8 RID: 1784
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
