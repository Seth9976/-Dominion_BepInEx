using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200011E RID: 286
	public class NicerOutline : BaseMeshEffect
	{
		// Token: 0x06002087 RID: 8327 RVA: 0x0007CEB4 File Offset: 0x0007B0B4
		// Note: this type is marked as 'beforefieldinit'.
		static NicerOutline()
		{
			Il2CppClassPointerStore<NicerOutline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "NicerOutline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr);
			NicerOutline.NativeFieldInfoPtr_m_EffectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, "m_EffectColor");
			NicerOutline.NativeFieldInfoPtr_m_EffectDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, "m_EffectDistance");
			NicerOutline.NativeFieldInfoPtr_m_UseGraphicAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, "m_UseGraphicAlpha");
			NicerOutline.NativeMethodInfoPtr_get_effectColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, 100665944);
			NicerOutline.NativeMethodInfoPtr_set_effectColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, 100665945);
			NicerOutline.NativeMethodInfoPtr_get_effectDistance_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, 100665946);
			NicerOutline.NativeMethodInfoPtr_set_effectDistance_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, 100665947);
			NicerOutline.NativeMethodInfoPtr_get_useGraphicAlpha_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, 100665948);
			NicerOutline.NativeMethodInfoPtr_set_useGraphicAlpha_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, 100665949);
			NicerOutline.NativeMethodInfoPtr_ApplyShadowZeroAlloc_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, 100665950);
			NicerOutline.NativeMethodInfoPtr_ApplyShadow_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, 100665951);
			NicerOutline.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, 100665952);
			NicerOutline.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr, 100665953);
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x0007CFE8 File Offset: 0x0007B1E8
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x0007D024 File Offset: 0x0007B224
		public unsafe Color effectColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NicerOutline.NativeMethodInfoPtr_get_effectColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257598, XrefRangeEnd = 257604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NicerOutline.NativeMethodInfoPtr_set_effectColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0007D064 File Offset: 0x0007B264
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x0007D0A0 File Offset: 0x0007B2A0
		public unsafe Vector2 effectDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NicerOutline.NativeMethodInfoPtr_get_effectDistance_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257604, XrefRangeEnd = 257612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NicerOutline.NativeMethodInfoPtr_set_effectDistance_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x0007D0E0 File Offset: 0x0007B2E0
		// (set) Token: 0x0600208D RID: 8333 RVA: 0x0007D11C File Offset: 0x0007B31C
		public unsafe bool useGraphicAlpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NicerOutline.NativeMethodInfoPtr_get_useGraphicAlpha_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257612, XrefRangeEnd = 257618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NicerOutline.NativeMethodInfoPtr_set_useGraphicAlpha_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x0007D15C File Offset: 0x0007B35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257618, XrefRangeEnd = 257635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NicerOutline.NativeMethodInfoPtr_ApplyShadowZeroAlloc_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x0007D1E4 File Offset: 0x0007B3E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 257659, RefRangeEnd = 257667, XrefRangeStart = 257635, XrefRangeEnd = 257659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NicerOutline.NativeMethodInfoPtr_ApplyShadow_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x0007D26C File Offset: 0x0007B46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257667, XrefRangeEnd = 257704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NicerOutline.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x0007D2BC File Offset: 0x0007B4BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120236, RefRangeEnd = 120238, XrefRangeStart = 120236, XrefRangeEnd = 120238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NicerOutline()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NicerOutline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NicerOutline.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x0001435F File Offset: 0x0001255F
		public NicerOutline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x0007D2F8 File Offset: 0x0007B4F8
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x00014368 File Offset: 0x00012568
		public unsafe Color m_EffectColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NicerOutline.NativeFieldInfoPtr_m_EffectColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NicerOutline.NativeFieldInfoPtr_m_EffectColor)) = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x0007D320 File Offset: 0x0007B520
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x00014383 File Offset: 0x00012583
		public unsafe Vector2 m_EffectDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NicerOutline.NativeFieldInfoPtr_m_EffectDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NicerOutline.NativeFieldInfoPtr_m_EffectDistance)) = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x0007D348 File Offset: 0x0007B548
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x0001439E File Offset: 0x0001259E
		public unsafe bool m_UseGraphicAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NicerOutline.NativeFieldInfoPtr_m_UseGraphicAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NicerOutline.NativeFieldInfoPtr_m_UseGraphicAlpha)) = value;
			}
		}

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectColor;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectDistance;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeFieldInfoPtr_m_UseGraphicAlpha;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_get_effectColor_Public_get_Color_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_set_effectColor_Public_set_Void_Color_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_get_effectDistance_Public_get_Vector2_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_set_effectDistance_Public_set_Void_Vector2_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_get_useGraphicAlpha_Public_get_Boolean_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_set_useGraphicAlpha_Public_set_Void_Boolean_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShadowZeroAlloc_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShadow_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
