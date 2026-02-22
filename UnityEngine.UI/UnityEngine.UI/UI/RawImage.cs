using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000030 RID: 48
	public class RawImage : MaskableGraphic
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x0001B66C File Offset: 0x0001986C
		// Note: this type is marked as 'beforefieldinit'.
		static RawImage()
		{
			Il2CppClassPointerStore<RawImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "RawImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RawImage>.NativeClassPtr);
			RawImage.NativeFieldInfoPtr_m_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawImage>.NativeClassPtr, "m_Texture");
			RawImage.NativeFieldInfoPtr_m_UVRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawImage>.NativeClassPtr, "m_UVRect");
			RawImage.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawImage>.NativeClassPtr, 100664073);
			RawImage.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawImage>.NativeClassPtr, 100664074);
			RawImage.NativeMethodInfoPtr_get_texture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawImage>.NativeClassPtr, 100664075);
			RawImage.NativeMethodInfoPtr_set_texture_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawImage>.NativeClassPtr, 100664076);
			RawImage.NativeMethodInfoPtr_get_uvRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawImage>.NativeClassPtr, 100664077);
			RawImage.NativeMethodInfoPtr_set_uvRect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawImage>.NativeClassPtr, 100664078);
			RawImage.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawImage>.NativeClassPtr, 100664079);
			RawImage.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawImage>.NativeClassPtr, 100664080);
			RawImage.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawImage>.NativeClassPtr, 100664081);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0001B778 File Offset: 0x00019978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116468, XrefRangeEnd = 116480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RawImage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RawImage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RawImage.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0001B7B4 File Offset: 0x000199B4
		public unsafe override Texture mainTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116480, XrefRangeEnd = 116485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RawImage.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001B800 File Offset: 0x00019A00
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0001B840 File Offset: 0x00019A40
		public unsafe Texture texture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12693, RefRangeEnd = 12694, XrefRangeStart = 12693, XrefRangeEnd = 12694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RawImage.NativeMethodInfoPtr_get_texture_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116485, XrefRangeEnd = 116489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RawImage.NativeMethodInfoPtr_set_texture_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0001B884 File Offset: 0x00019A84
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0001B8C0 File Offset: 0x00019AC0
		public unsafe Rect uvRect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RawImage.NativeMethodInfoPtr_get_uvRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116489, XrefRangeEnd = 116490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RawImage.NativeMethodInfoPtr_set_uvRect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0001B900 File Offset: 0x00019B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116490, XrefRangeEnd = 116504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetNativeSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RawImage.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0001B93C File Offset: 0x00019B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116504, XrefRangeEnd = 116541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPopulateMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RawImage.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0001B98C File Offset: 0x00019B8C
		[CallerCount(0)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RawImage.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00003CFB File Offset: 0x00001EFB
		public RawImage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0001B9C8 File Offset: 0x00019BC8
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00003D04 File Offset: 0x00001F04
		public unsafe Texture m_Texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RawImage.NativeFieldInfoPtr_m_Texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RawImage.NativeFieldInfoPtr_m_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00003D23 File Offset: 0x00001F23
		public unsafe Rect m_UVRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RawImage.NativeFieldInfoPtr_m_UVRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RawImage.NativeFieldInfoPtr_m_UVRect)) = value;
			}
		}

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_m_Texture;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_m_UVRect;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_set_texture_Public_set_Void_Texture_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_get_uvRect_Public_get_Rect_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_set_uvRect_Public_set_Void_Rect_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeSize_Public_Virtual_Void_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;
	}
}
