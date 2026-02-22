using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200003D RID: 61
	public class VertexHelper : Object
	{
		// Token: 0x060007CA RID: 1994 RVA: 0x000254FC File Offset: 0x000236FC
		// Note: this type is marked as 'beforefieldinit'.
		static VertexHelper()
		{
			Il2CppClassPointerStore<VertexHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "VertexHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr);
			VertexHelper.NativeFieldInfoPtr_m_Positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Positions");
			VertexHelper.NativeFieldInfoPtr_m_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Colors");
			VertexHelper.NativeFieldInfoPtr_m_Uv0S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv0S");
			VertexHelper.NativeFieldInfoPtr_m_Uv1S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv1S");
			VertexHelper.NativeFieldInfoPtr_m_Uv2S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv2S");
			VertexHelper.NativeFieldInfoPtr_m_Uv3S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv3S");
			VertexHelper.NativeFieldInfoPtr_m_Normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Normals");
			VertexHelper.NativeFieldInfoPtr_m_Tangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Tangents");
			VertexHelper.NativeFieldInfoPtr_m_Indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Indices");
			VertexHelper.NativeFieldInfoPtr_s_DefaultTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "s_DefaultTangent");
			VertexHelper.NativeFieldInfoPtr_s_DefaultNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "s_DefaultNormal");
			VertexHelper.NativeFieldInfoPtr_m_ListsInitalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_ListsInitalized");
			VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664448);
			VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664449);
			VertexHelper.NativeMethodInfoPtr_InitializeListIfRequired_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664450);
			VertexHelper.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664451);
			VertexHelper.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664452);
			VertexHelper.NativeMethodInfoPtr_get_currentVertCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664453);
			VertexHelper.NativeMethodInfoPtr_get_currentIndexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664454);
			VertexHelper.NativeMethodInfoPtr_PopulateUIVertex_Public_Void_byref_UIVertex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664455);
			VertexHelper.NativeMethodInfoPtr_SetUIVertex_Public_Void_UIVertex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664456);
			VertexHelper.NativeMethodInfoPtr_FillMesh_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664457);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector4_Vector4_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664458);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664459);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664460);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664461);
			VertexHelper.NativeMethodInfoPtr_AddTriangle_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664462);
			VertexHelper.NativeMethodInfoPtr_AddUIVertexQuad_Public_Void_Il2CppStructArray_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664463);
			VertexHelper.NativeMethodInfoPtr_AddUIVertexStream_Public_Void_List_1_UIVertex_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664464);
			VertexHelper.NativeMethodInfoPtr_AddUIVertexTriangleStream_Public_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664465);
			VertexHelper.NativeMethodInfoPtr_GetUIVertexStream_Public_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664466);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00025798 File Offset: 0x00023998
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000257D4 File Offset: 0x000239D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119757, RefRangeEnd = 119759, XrefRangeStart = 119717, XrefRangeEnd = 119757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexHelper(Mesh m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00025820 File Offset: 0x00023A20
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 119793, RefRangeEnd = 119809, XrefRangeStart = 119759, XrefRangeEnd = 119793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeListIfRequired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_InitializeListIfRequired_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00025854 File Offset: 0x00023A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119809, XrefRangeEnd = 119843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00025888 File Offset: 0x00023A88
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 119865, RefRangeEnd = 119879, XrefRangeStart = 119843, XrefRangeEnd = 119865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x000258BC File Offset: 0x00023ABC
		public unsafe int currentVertCount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 119880, RefRangeEnd = 119887, XrefRangeStart = 119879, XrefRangeEnd = 119880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_get_currentVertCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x000258F8 File Offset: 0x00023AF8
		public unsafe int currentIndexCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119887, XrefRangeEnd = 119888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_get_currentIndexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00025934 File Offset: 0x00023B34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119900, RefRangeEnd = 119903, XrefRangeStart = 119888, XrefRangeEnd = 119900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateUIVertex(ref UIVertex vertex, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vertex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_PopulateUIVertex_Public_Void_byref_UIVertex_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00025980 File Offset: 0x00023B80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119923, RefRangeEnd = 119926, XrefRangeStart = 119903, XrefRangeEnd = 119923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUIVertex(UIVertex vertex, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_SetUIVertex_Public_Void_UIVertex_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000259CC File Offset: 0x00023BCC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 119946, RefRangeEnd = 119954, XrefRangeStart = 119926, XrefRangeEnd = 119946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_FillMesh_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00025A10 File Offset: 0x00023C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119954, XrefRangeEnd = 119974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv3;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tangent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector4_Vector4_Vector3_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00025AB0 File Offset: 0x00023CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119996, RefRangeEnd = 119997, XrefRangeStart = 119974, XrefRangeEnd = 119996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tangent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector3_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00025B34 File Offset: 0x00023D34
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 120003, RefRangeEnd = 120021, XrefRangeStart = 119997, XrefRangeEnd = 120003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(Vector3 position, Color32 color, Vector4 uv0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv0;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00025B90 File Offset: 0x00023D90
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 120041, RefRangeEnd = 120049, XrefRangeStart = 120021, XrefRangeEnd = 120041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(UIVertex v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00025BD0 File Offset: 0x00023DD0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 120058, RefRangeEnd = 120073, XrefRangeStart = 120049, XrefRangeEnd = 120058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTriangle(int idx0, int idx1, int idx2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddTriangle_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00025C2C File Offset: 0x00023E2C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 120116, RefRangeEnd = 120121, XrefRangeStart = 120073, XrefRangeEnd = 120116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUIVertexQuad(Il2CppStructArray<UIVertex> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddUIVertexQuad_Public_Void_Il2CppStructArray_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00025C70 File Offset: 0x00023E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120121, XrefRangeEnd = 120126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUIVertexStream(List<UIVertex> verts, List<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddUIVertexStream_Public_Void_List_1_UIVertex_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00025CC4 File Offset: 0x00023EC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 120128, RefRangeEnd = 120132, XrefRangeStart = 120126, XrefRangeEnd = 120128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddUIVertexTriangleStream_Public_Void_List_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00025D08 File Offset: 0x00023F08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 120134, RefRangeEnd = 120139, XrefRangeStart = 120132, XrefRangeEnd = 120134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUIVertexStream(List<UIVertex> stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_GetUIVertexStream_Public_Void_List_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00004B0A File Offset: 0x00002D0A
		public VertexHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00025D4C File Offset: 0x00023F4C
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00004B13 File Offset: 0x00002D13
		public unsafe List<Vector3> m_Positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00025D7C File Offset: 0x00023F7C
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00004B32 File Offset: 0x00002D32
		public unsafe List<Color32> m_Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color32>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00025DAC File Offset: 0x00023FAC
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00004B51 File Offset: 0x00002D51
		public unsafe List<Vector4> m_Uv0S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv0S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv0S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00025DDC File Offset: 0x00023FDC
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00004B70 File Offset: 0x00002D70
		public unsafe List<Vector4> m_Uv1S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv1S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv1S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00025E0C File Offset: 0x0002400C
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00004B8F File Offset: 0x00002D8F
		public unsafe List<Vector4> m_Uv2S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv2S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv2S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00025E3C File Offset: 0x0002403C
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00004BAE File Offset: 0x00002DAE
		public unsafe List<Vector4> m_Uv3S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv3S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv3S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00025E6C File Offset: 0x0002406C
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x00004BCD File Offset: 0x00002DCD
		public unsafe List<Vector3> m_Normals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Normals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Normals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00025E9C File Offset: 0x0002409C
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00004BEC File Offset: 0x00002DEC
		public unsafe List<Vector4> m_Tangents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Tangents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Tangents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00025ECC File Offset: 0x000240CC
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00004C0B File Offset: 0x00002E0B
		public unsafe List<int> m_Indices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Indices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Indices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00025EFC File Offset: 0x000240FC
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00004C2A File Offset: 0x00002E2A
		public unsafe static Vector4 s_DefaultTangent
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(VertexHelper.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VertexHelper.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00025F18 File Offset: 0x00024118
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00004C38 File Offset: 0x00002E38
		public unsafe static Vector3 s_DefaultNormal
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(VertexHelper.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VertexHelper.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00025F34 File Offset: 0x00024134
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00004C46 File Offset: 0x00002E46
		public unsafe bool m_ListsInitalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_ListsInitalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_ListsInitalized)) = value;
			}
		}

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_m_Positions;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_m_Colors;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv0S;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv1S;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv2S;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv3S;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr_m_Normals;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_m_Tangents;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_m_Indices;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTangent;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultNormal;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeFieldInfoPtr_m_ListsInitalized;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_InitializeListIfRequired_Private_Void_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_get_currentVertCount_Public_get_Int32_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_get_currentIndexCount_Public_get_Int32_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_PopulateUIVertex_Public_Void_byref_UIVertex_Int32_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_SetUIVertex_Public_Void_UIVertex_Int32_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_FillMesh_Public_Void_Mesh_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector4_Vector4_Vector3_Vector4_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector3_Vector4_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_UIVertex_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_AddTriangle_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_AddUIVertexQuad_Public_Void_Il2CppStructArray_1_UIVertex_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_AddUIVertexStream_Public_Void_List_1_UIVertex_List_1_Int32_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_AddUIVertexTriangleStream_Public_Void_List_1_UIVertex_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_GetUIVertexStream_Public_Void_List_1_UIVertex_0;
	}
}
