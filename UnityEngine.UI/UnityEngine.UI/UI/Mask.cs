using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000029 RID: 41
	public class Mask : UIBehaviour
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x00019B94 File Offset: 0x00017D94
		// Note: this type is marked as 'beforefieldinit'.
		static Mask()
		{
			Il2CppClassPointerStore<Mask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Mask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mask>.NativeClassPtr);
			Mask.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mask>.NativeClassPtr, "m_RectTransform");
			Mask.NativeFieldInfoPtr_m_ShowMaskGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mask>.NativeClassPtr, "m_ShowMaskGraphic");
			Mask.NativeFieldInfoPtr_m_Graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mask>.NativeClassPtr, "m_Graphic");
			Mask.NativeFieldInfoPtr_m_MaskMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mask>.NativeClassPtr, "m_MaskMaterial");
			Mask.NativeFieldInfoPtr_m_UnmaskMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mask>.NativeClassPtr, "m_UnmaskMaterial");
			Mask.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664013);
			Mask.NativeMethodInfoPtr_get_showMaskGraphic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664014);
			Mask.NativeMethodInfoPtr_set_showMaskGraphic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664015);
			Mask.NativeMethodInfoPtr_get_graphic_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664016);
			Mask.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664017);
			Mask.NativeMethodInfoPtr_MaskEnabled_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664018);
			Mask.NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664019);
			Mask.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664020);
			Mask.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664021);
			Mask.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664022);
			Mask.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664023);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00019D04 File Offset: 0x00017F04
		public unsafe RectTransform rectTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115838, XrefRangeEnd = 115841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mask.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00019D44 File Offset: 0x00017F44
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00019D80 File Offset: 0x00017F80
		public unsafe bool showMaskGraphic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mask.NativeMethodInfoPtr_get_showMaskGraphic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 115851, RefRangeEnd = 115854, XrefRangeStart = 115841, XrefRangeEnd = 115851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mask.NativeMethodInfoPtr_set_showMaskGraphic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00019DC0 File Offset: 0x00017FC0
		public unsafe Graphic graphic
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 115857, RefRangeEnd = 115859, XrefRangeStart = 115854, XrefRangeEnd = 115857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mask.NativeMethodInfoPtr_get_graphic_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00019E00 File Offset: 0x00018000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115859, XrefRangeEnd = 115860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mask()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mask>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mask.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00019E3C File Offset: 0x0001803C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115860, XrefRangeEnd = 115861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MaskEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_MaskEnabled_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00019E84 File Offset: 0x00018084
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSiblingGraphicEnabledDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00019EC0 File Offset: 0x000180C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115861, XrefRangeEnd = 115890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00019EFC File Offset: 0x000180FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115890, XrefRangeEnd = 115929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00019F38 File Offset: 0x00018138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115929, XrefRangeEnd = 115937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00019FA0 File Offset: 0x000181A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115937, XrefRangeEnd = 115970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00003A14 File Offset: 0x00001C14
		public Mask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00019FFC File Offset: 0x000181FC
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00003A1D File Offset: 0x00001C1D
		public unsafe RectTransform m_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0001A02C File Offset: 0x0001822C
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00003A3C File Offset: 0x00001C3C
		public unsafe bool m_ShowMaskGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_ShowMaskGraphic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_ShowMaskGraphic)) = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0001A054 File Offset: 0x00018254
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00003A57 File Offset: 0x00001C57
		public unsafe Graphic m_Graphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_Graphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_Graphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0001A084 File Offset: 0x00018284
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00003A76 File Offset: 0x00001C76
		public unsafe Material m_MaskMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_MaskMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_MaskMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x0001A0B4 File Offset: 0x000182B4
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00003A95 File Offset: 0x00001C95
		public unsafe Material m_UnmaskMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_UnmaskMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_UnmaskMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_m_ShowMaskGraphic;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_m_Graphic;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskMaterial;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_m_UnmaskMaterial;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_get_showMaskGraphic_Public_get_Boolean_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_set_showMaskGraphic_Public_set_Void_Boolean_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_get_graphic_Public_get_Graphic_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_MaskEnabled_Public_Virtual_New_Boolean_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Virtual_New_Void_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0;
	}
}
