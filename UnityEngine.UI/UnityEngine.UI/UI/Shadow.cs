using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000044 RID: 68
	public class Shadow : BaseMeshEffect
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x00026618 File Offset: 0x00024818
		// Note: this type is marked as 'beforefieldinit'.
		static Shadow()
		{
			Il2CppClassPointerStore<Shadow>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Shadow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shadow>.NativeClassPtr);
			Shadow.NativeFieldInfoPtr_m_EffectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadow>.NativeClassPtr, "m_EffectColor");
			Shadow.NativeFieldInfoPtr_m_EffectDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadow>.NativeClassPtr, "m_EffectDistance");
			Shadow.NativeFieldInfoPtr_m_UseGraphicAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadow>.NativeClassPtr, "m_UseGraphicAlpha");
			Shadow.NativeFieldInfoPtr_kMaxEffectDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shadow>.NativeClassPtr, "kMaxEffectDistance");
			Shadow.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664484);
			Shadow.NativeMethodInfoPtr_get_effectColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664485);
			Shadow.NativeMethodInfoPtr_set_effectColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664486);
			Shadow.NativeMethodInfoPtr_get_effectDistance_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664487);
			Shadow.NativeMethodInfoPtr_set_effectDistance_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664488);
			Shadow.NativeMethodInfoPtr_get_useGraphicAlpha_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664489);
			Shadow.NativeMethodInfoPtr_set_useGraphicAlpha_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664490);
			Shadow.NativeMethodInfoPtr_ApplyShadowZeroAlloc_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664491);
			Shadow.NativeMethodInfoPtr_ApplyShadow_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664492);
			Shadow.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shadow>.NativeClassPtr, 100664493);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00026760 File Offset: 0x00024960
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120236, RefRangeEnd = 120238, XrefRangeStart = 120234, XrefRangeEnd = 120236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shadow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shadow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x0002679C File Offset: 0x0002499C
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x000267D8 File Offset: 0x000249D8
		public unsafe Color effectColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_get_effectColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120238, XrefRangeEnd = 120244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_set_effectColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00026818 File Offset: 0x00024A18
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00026854 File Offset: 0x00024A54
		public unsafe Vector2 effectDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_get_effectDistance_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120244, XrefRangeEnd = 120252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_set_effectDistance_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00026894 File Offset: 0x00024A94
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x000268D0 File Offset: 0x00024AD0
		public unsafe bool useGraphicAlpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_get_useGraphicAlpha_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120252, XrefRangeEnd = 120258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_set_useGraphicAlpha_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00026910 File Offset: 0x00024B10
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 120275, RefRangeEnd = 120283, XrefRangeStart = 120258, XrefRangeEnd = 120275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_ApplyShadowZeroAlloc_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00026998 File Offset: 0x00024B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120283, XrefRangeEnd = 120300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shadow.NativeMethodInfoPtr_ApplyShadow_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00026A20 File Offset: 0x00024C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120300, XrefRangeEnd = 120333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shadow.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00004CE5 File Offset: 0x00002EE5
		public Shadow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00026A70 File Offset: 0x00024C70
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00004CEE File Offset: 0x00002EEE
		public unsafe Color m_EffectColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_EffectColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_EffectColor)) = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00026A98 File Offset: 0x00024C98
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00004D09 File Offset: 0x00002F09
		public unsafe Vector2 m_EffectDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_EffectDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_EffectDistance)) = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00026AC0 File Offset: 0x00024CC0
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00004D24 File Offset: 0x00002F24
		public unsafe bool m_UseGraphicAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_UseGraphicAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shadow.NativeFieldInfoPtr_m_UseGraphicAlpha)) = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00026AE8 File Offset: 0x00024CE8
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00004D3F File Offset: 0x00002F3F
		public unsafe static float kMaxEffectDistance
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Shadow.NativeFieldInfoPtr_kMaxEffectDistance, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shadow.NativeFieldInfoPtr_kMaxEffectDistance, (void*)(&value));
			}
		}

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectColor;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectDistance;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr_m_UseGraphicAlpha;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeFieldInfoPtr_kMaxEffectDistance;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_get_effectColor_Public_get_Color_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_set_effectColor_Public_set_Void_Color_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_get_effectDistance_Public_get_Vector2_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_set_effectDistance_Public_set_Void_Vector2_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_get_useGraphicAlpha_Public_get_Boolean_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_set_useGraphicAlpha_Public_set_Void_Boolean_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShadowZeroAlloc_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShadow_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;
	}
}
