using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200000C RID: 12
public class AnnouncementLocator : MonoBehaviour
{
	// Token: 0x06000122 RID: 290 RVA: 0x0001E190 File Offset: 0x0001C390
	// Note: this type is marked as 'beforefieldinit'.
	static AnnouncementLocator()
	{
		Il2CppClassPointerStore<AnnouncementLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnnouncementLocator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnnouncementLocator>.NativeClassPtr);
		AnnouncementLocator.NativeFieldInfoPtr_k_EdgeMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementLocator>.NativeClassPtr, "k_EdgeMargin");
		AnnouncementLocator.NativeFieldInfoPtr_m_objectCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnnouncementLocator>.NativeClassPtr, "m_objectCorners");
		AnnouncementLocator.NativeMethodInfoPtr_UpdateAnnouncementPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnnouncementLocator>.NativeClassPtr, 100663390);
		AnnouncementLocator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnnouncementLocator>.NativeClassPtr, 100663391);
	}

	// Token: 0x06000123 RID: 291 RVA: 0x0001E210 File Offset: 0x0001C410
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224791, RefRangeEnd = 224792, XrefRangeStart = 224752, XrefRangeEnd = 224791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAnnouncementPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnnouncementLocator.NativeMethodInfoPtr_UpdateAnnouncementPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000124 RID: 292 RVA: 0x0001E244 File Offset: 0x0001C444
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224792, XrefRangeEnd = 224796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnnouncementLocator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnnouncementLocator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnnouncementLocator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002AA7 File Offset: 0x00000CA7
	public AnnouncementLocator(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000126 RID: 294 RVA: 0x0001E280 File Offset: 0x0001C480
	// (set) Token: 0x06000127 RID: 295 RVA: 0x00002AB0 File Offset: 0x00000CB0
	public unsafe static int k_EdgeMargin
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AnnouncementLocator.NativeFieldInfoPtr_k_EdgeMargin, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnnouncementLocator.NativeFieldInfoPtr_k_EdgeMargin, (void*)(&value));
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000128 RID: 296 RVA: 0x0001E29C File Offset: 0x0001C49C
	// (set) Token: 0x06000129 RID: 297 RVA: 0x00002ABE File Offset: 0x00000CBE
	public unsafe Il2CppStructArray<Vector3> m_objectCorners
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnnouncementLocator.NativeFieldInfoPtr_m_objectCorners);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnnouncementLocator.NativeFieldInfoPtr_m_objectCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000B5 RID: 181
	private static readonly IntPtr NativeFieldInfoPtr_k_EdgeMargin;

	// Token: 0x040000B6 RID: 182
	private static readonly IntPtr NativeFieldInfoPtr_m_objectCorners;

	// Token: 0x040000B7 RID: 183
	private static readonly IntPtr NativeMethodInfoPtr_UpdateAnnouncementPosition_Public_Void_0;

	// Token: 0x040000B8 RID: 184
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
