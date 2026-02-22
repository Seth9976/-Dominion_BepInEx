using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003F RID: 63
	public class BaseMeshEffect : UIBehaviour
	{
		// Token: 0x060007FB RID: 2043 RVA: 0x00026040 File Offset: 0x00024240
		// Note: this type is marked as 'beforefieldinit'.
		static BaseMeshEffect()
		{
			Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "BaseMeshEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr);
			BaseMeshEffect.NativeFieldInfoPtr_m_Graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, "m_Graphic");
			BaseMeshEffect.NativeMethodInfoPtr_get_graphic_Protected_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664470);
			BaseMeshEffect.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664471);
			BaseMeshEffect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664472);
			BaseMeshEffect.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664473);
			BaseMeshEffect.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_New_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664474);
			BaseMeshEffect.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664475);
			BaseMeshEffect.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr, 100664476);
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00026110 File Offset: 0x00024310
		public unsafe Graphic graphic
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 120146, RefRangeEnd = 120166, XrefRangeStart = 120139, XrefRangeEnd = 120146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMeshEffect.NativeMethodInfoPtr_get_graphic_Protected_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00026150 File Offset: 0x00024350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120166, XrefRangeEnd = 120173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMeshEffect.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0002618C File Offset: 0x0002438C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120173, XrefRangeEnd = 120181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMeshEffect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000261C8 File Offset: 0x000243C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120181, XrefRangeEnd = 120189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMeshEffect.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00026204 File Offset: 0x00024404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120189, XrefRangeEnd = 120198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMeshEffect.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_New_Void_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00026254 File Offset: 0x00024454
		[CallerCount(0)]
		public unsafe virtual void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMeshEffect.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000262A4 File Offset: 0x000244A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseMeshEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseMeshEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMeshEffect.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00004C6A File Offset: 0x00002E6A
		public BaseMeshEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x000262E0 File Offset: 0x000244E0
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00004C73 File Offset: 0x00002E73
		public unsafe Graphic m_Graphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMeshEffect.NativeFieldInfoPtr_m_Graphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMeshEffect.NativeFieldInfoPtr_m_Graphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr_m_Graphic;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_get_graphic_Protected_get_Graphic_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_New_Void_Mesh_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
