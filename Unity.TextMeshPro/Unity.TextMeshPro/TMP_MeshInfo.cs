using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000046 RID: 70
	public sealed class TMP_MeshInfo : ValueType
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00024780 File Offset: 0x00022980
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_MeshInfo()
		{
			Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_MeshInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr);
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultColor");
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultNormal");
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultTangent");
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultBounds");
			TMP_MeshInfo.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "mesh");
			TMP_MeshInfo.NativeFieldInfoPtr_vertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "vertexCount");
			TMP_MeshInfo.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "vertices");
			TMP_MeshInfo.NativeFieldInfoPtr_normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "normals");
			TMP_MeshInfo.NativeFieldInfoPtr_tangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "tangents");
			TMP_MeshInfo.NativeFieldInfoPtr_uvs0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "uvs0");
			TMP_MeshInfo.NativeFieldInfoPtr_uvs2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "uvs2");
			TMP_MeshInfo.NativeFieldInfoPtr_colors32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "colors32");
			TMP_MeshInfo.NativeFieldInfoPtr_triangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "triangles");
			TMP_MeshInfo.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "material");
			TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664131);
			TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664132);
			TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664133);
			TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664134);
			TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664135);
			TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664136);
			TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664137);
			TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664138);
			TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664139);
			TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664140);
			TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664141);
			TMP_MeshInfo.NativeMethodInfoPtr_SwapVertexData_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664142);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000249B8 File Offset: 0x00022BB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 143622, RefRangeEnd = 143626, XrefRangeStart = 143575, XrefRangeEnd = 143622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_MeshInfo(Mesh mesh, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00024A18 File Offset: 0x00022C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143626, XrefRangeEnd = 143673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolumetric;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00024A84 File Offset: 0x00022C84
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 143708, RefRangeEnd = 143715, XrefRangeStart = 143673, XrefRangeEnd = 143708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeMeshInfo(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00024AC8 File Offset: 0x00022CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143761, RefRangeEnd = 143762, XrefRangeStart = 143715, XrefRangeEnd = 143761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeMeshInfo(int size, bool isVolumetric)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolumetric;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00024B1C File Offset: 0x00022D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143762, XrefRangeEnd = 143768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00024B54 File Offset: 0x00022D54
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 143782, RefRangeEnd = 143787, XrefRangeStart = 143768, XrefRangeEnd = 143782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool uploadChanges)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uploadChanges;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00024B98 File Offset: 0x00022D98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 143788, RefRangeEnd = 143792, XrefRangeStart = 143787, XrefRangeEnd = 143788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00024BD0 File Offset: 0x00022DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143793, RefRangeEnd = 143794, XrefRangeStart = 143792, XrefRangeEnd = 143793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00024C14 File Offset: 0x00022E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143800, RefRangeEnd = 143801, XrefRangeStart = 143794, XrefRangeEnd = 143800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices(int startIndex, bool updateMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00024C68 File Offset: 0x00022E68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 143802, RefRangeEnd = 143806, XrefRangeStart = 143801, XrefRangeEnd = 143802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGeometry(VertexSortingOrder order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_VertexSortingOrder_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00024CAC File Offset: 0x00022EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143815, RefRangeEnd = 143816, XrefRangeStart = 143806, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGeometry(IList<int> sortingOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortingOrder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_IList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00024CF4 File Offset: 0x00022EF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143818, XrefRangeStart = 143816, XrefRangeEnd = 143816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapVertexData(int src, int dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_SwapVertexData_Public_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00005A3E File Offset: 0x00003C3E
		public TMP_MeshInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00005A47 File Offset: 0x00003C47
		public TMP_MeshInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00024D48 File Offset: 0x00022F48
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00005A59 File Offset: 0x00003C59
		public unsafe static Color32 s_DefaultColor
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00024D64 File Offset: 0x00022F64
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00005A67 File Offset: 0x00003C67
		public unsafe static Vector3 s_DefaultNormal
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00024D80 File Offset: 0x00022F80
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00005A75 File Offset: 0x00003C75
		public unsafe static Vector4 s_DefaultTangent
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00024D9C File Offset: 0x00022F9C
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00005A83 File Offset: 0x00003C83
		public unsafe static Bounds s_DefaultBounds
		{
			get
			{
				Bounds bounds;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultBounds, (void*)(&bounds));
				return bounds;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultBounds, (void*)(&value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00024DB8 File Offset: 0x00022FB8
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00005A91 File Offset: 0x00003C91
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00024DE8 File Offset: 0x00022FE8
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00005AB0 File Offset: 0x00003CB0
		public unsafe int vertexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertexCount)) = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00024E10 File Offset: 0x00023010
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00005ACB File Offset: 0x00003CCB
		public unsafe Il2CppStructArray<Vector3> vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00024E40 File Offset: 0x00023040
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00005AEA File Offset: 0x00003CEA
		public unsafe Il2CppStructArray<Vector3> normals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_normals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_normals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00024E70 File Offset: 0x00023070
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00005B09 File Offset: 0x00003D09
		public unsafe Il2CppStructArray<Vector4> tangents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_tangents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_tangents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00024EA0 File Offset: 0x000230A0
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00005B28 File Offset: 0x00003D28
		public unsafe Il2CppStructArray<Vector2> uvs0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00024ED0 File Offset: 0x000230D0
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00005B47 File Offset: 0x00003D47
		public unsafe Il2CppStructArray<Vector2> uvs2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00024F00 File Offset: 0x00023100
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00005B66 File Offset: 0x00003D66
		public unsafe Il2CppStructArray<Color32> colors32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_colors32);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_colors32), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00024F30 File Offset: 0x00023130
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00005B85 File Offset: 0x00003D85
		public unsafe Il2CppStructArray<int> triangles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_triangles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_triangles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00024F60 File Offset: 0x00023160
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00005BA4 File Offset: 0x00003DA4
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultColor;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultNormal;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTangent;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultBounds;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_vertexCount;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr_normals;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_tangents;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_uvs0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeFieldInfoPtr_uvs2;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeFieldInfoPtr_colors32;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeFieldInfoPtr_triangles;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_Boolean_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_Boolean_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_Boolean_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_Boolean_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_SortGeometry_Public_Void_VertexSortingOrder_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_SortGeometry_Public_Void_IList_1_Int32_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_SwapVertexData_Public_Void_Int32_Int32_0;
	}
}
