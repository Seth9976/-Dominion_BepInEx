using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class AdjustCardScaleForAspectRatio : MonoBehaviour
{
	// Token: 0x0600010E RID: 270 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
	// Note: this type is marked as 'beforefieldinit'.
	static AdjustCardScaleForAspectRatio()
	{
		Il2CppClassPointerStore<AdjustCardScaleForAspectRatio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AdjustCardScaleForAspectRatio");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdjustCardScaleForAspectRatio>.NativeClassPtr);
		AdjustCardScaleForAspectRatio.NativeFieldInfoPtr_m_AdjustScaleFullSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustCardScaleForAspectRatio>.NativeClassPtr, "m_AdjustScaleFullSize");
		AdjustCardScaleForAspectRatio.NativeFieldInfoPtr_m_AdjustScaleHalfHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustCardScaleForAspectRatio>.NativeClassPtr, "m_AdjustScaleHalfHeight");
		AdjustCardScaleForAspectRatio.NativeFieldInfoPtr_m_AdjustScaleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdjustCardScaleForAspectRatio>.NativeClassPtr, "m_AdjustScaleManager");
		AdjustCardScaleForAspectRatio.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleForAspectRatio>.NativeClassPtr, 100663382);
		AdjustCardScaleForAspectRatio.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleForAspectRatio>.NativeClassPtr, 100663383);
		AdjustCardScaleForAspectRatio.NativeMethodInfoPtr_AdjustScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleForAspectRatio>.NativeClassPtr, 100663384);
		AdjustCardScaleForAspectRatio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdjustCardScaleForAspectRatio>.NativeClassPtr, 100663385);
	}

	// Token: 0x0600010F RID: 271 RVA: 0x0001DE6C File Offset: 0x0001C06C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224684, XrefRangeEnd = 224700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleForAspectRatio.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0001DEA0 File Offset: 0x0001C0A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224700, XrefRangeEnd = 224713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleForAspectRatio.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0001DED4 File Offset: 0x0001C0D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224731, RefRangeEnd = 224732, XrefRangeStart = 224713, XrefRangeEnd = 224731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleForAspectRatio.NativeMethodInfoPtr_AdjustScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0001DF08 File Offset: 0x0001C108
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdjustCardScaleForAspectRatio()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdjustCardScaleForAspectRatio>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdjustCardScaleForAspectRatio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00002A19 File Offset: 0x00000C19
	public AdjustCardScaleForAspectRatio(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000114 RID: 276 RVA: 0x0001DF44 File Offset: 0x0001C144
	// (set) Token: 0x06000115 RID: 277 RVA: 0x00002A22 File Offset: 0x00000C22
	public unsafe Il2CppStructArray<float> m_AdjustScaleFullSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdjustCardScaleForAspectRatio.NativeFieldInfoPtr_m_AdjustScaleFullSize);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdjustCardScaleForAspectRatio.NativeFieldInfoPtr_m_AdjustScaleFullSize), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000116 RID: 278 RVA: 0x0001DF74 File Offset: 0x0001C174
	// (set) Token: 0x06000117 RID: 279 RVA: 0x00002A41 File Offset: 0x00000C41
	public unsafe Il2CppStructArray<float> m_AdjustScaleHalfHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdjustCardScaleForAspectRatio.NativeFieldInfoPtr_m_AdjustScaleHalfHeight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdjustCardScaleForAspectRatio.NativeFieldInfoPtr_m_AdjustScaleHalfHeight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000118 RID: 280 RVA: 0x0001DFA4 File Offset: 0x0001C1A4
	// (set) Token: 0x06000119 RID: 281 RVA: 0x00002A60 File Offset: 0x00000C60
	public unsafe AdjustCardScaleManager m_AdjustScaleManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdjustCardScaleForAspectRatio.NativeFieldInfoPtr_m_AdjustScaleManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdjustCardScaleManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdjustCardScaleForAspectRatio.NativeFieldInfoPtr_m_AdjustScaleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000A9 RID: 169
	private static readonly IntPtr NativeFieldInfoPtr_m_AdjustScaleFullSize;

	// Token: 0x040000AA RID: 170
	private static readonly IntPtr NativeFieldInfoPtr_m_AdjustScaleHalfHeight;

	// Token: 0x040000AB RID: 171
	private static readonly IntPtr NativeFieldInfoPtr_m_AdjustScaleManager;

	// Token: 0x040000AC RID: 172
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040000AD RID: 173
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040000AE RID: 174
	private static readonly IntPtr NativeMethodInfoPtr_AdjustScale_Private_Void_0;

	// Token: 0x040000AF RID: 175
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
