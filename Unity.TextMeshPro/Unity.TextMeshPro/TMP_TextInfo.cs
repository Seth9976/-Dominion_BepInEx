using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200006A RID: 106
	[Serializable]
	public class TMP_TextInfo : global::Il2CppSystem.Object
	{
		// Token: 0x06000DA1 RID: 3489 RVA: 0x000376BC File Offset: 0x000358BC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextInfo()
		{
			Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr);
			TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorPositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "k_InfinityVectorPositive");
			TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "k_InfinityVectorNegative");
			TMP_TextInfo.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "textComponent");
			TMP_TextInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "characterCount");
			TMP_TextInfo.NativeFieldInfoPtr_spriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "spriteCount");
			TMP_TextInfo.NativeFieldInfoPtr_spaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "spaceCount");
			TMP_TextInfo.NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "wordCount");
			TMP_TextInfo.NativeFieldInfoPtr_linkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "linkCount");
			TMP_TextInfo.NativeFieldInfoPtr_lineCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "lineCount");
			TMP_TextInfo.NativeFieldInfoPtr_pageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "pageCount");
			TMP_TextInfo.NativeFieldInfoPtr_materialCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "materialCount");
			TMP_TextInfo.NativeFieldInfoPtr_characterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "characterInfo");
			TMP_TextInfo.NativeFieldInfoPtr_wordInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "wordInfo");
			TMP_TextInfo.NativeFieldInfoPtr_linkInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "linkInfo");
			TMP_TextInfo.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "lineInfo");
			TMP_TextInfo.NativeFieldInfoPtr_pageInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "pageInfo");
			TMP_TextInfo.NativeFieldInfoPtr_meshInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "meshInfo");
			TMP_TextInfo.NativeFieldInfoPtr_m_CachedMeshInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, "m_CachedMeshInfo");
			TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664682);
			TMP_TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664683);
			TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664684);
			TMP_TextInfo.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664685);
			TMP_TextInfo.NativeMethodInfoPtr_ClearAllData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664686);
			TMP_TextInfo.NativeMethodInfoPtr_ClearMeshInfo_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664687);
			TMP_TextInfo.NativeMethodInfoPtr_ClearAllMeshInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664688);
			TMP_TextInfo.NativeMethodInfoPtr_ResetVertexLayout_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664689);
			TMP_TextInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Il2CppReferenceArray_1_MaterialReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664690);
			TMP_TextInfo.NativeMethodInfoPtr_ClearLineInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664691);
			TMP_TextInfo.NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664692);
			TMP_TextInfo.NativeMethodInfoPtr_CopyMeshInfoVertexData_Public_Il2CppReferenceArray_1_TMP_MeshInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664693);
			TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664694);
			TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr, 100664695);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0003796C File Offset: 0x00035B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148753, XrefRangeEnd = 148772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000379A8 File Offset: 0x00035BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148791, RefRangeEnd = 148792, XrefRangeStart = 148772, XrefRangeEnd = 148791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextInfo(int characterCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref characterCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000379F0 File Offset: 0x00035BF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148811, RefRangeEnd = 148812, XrefRangeStart = 148792, XrefRangeEnd = 148811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextInfo(TMP_Text textComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00037A3C File Offset: 0x00035C3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148813, RefRangeEnd = 148815, XrefRangeStart = 148812, XrefRangeEnd = 148813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00037A70 File Offset: 0x00035C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148815, XrefRangeEnd = 148833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAllData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearAllData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00037AA4 File Offset: 0x00035CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148833, XrefRangeEnd = 148835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearMeshInfo(bool updateMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMesh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearMeshInfo_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00037AE4 File Offset: 0x00035CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148835, XrefRangeEnd = 148837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAllMeshInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearAllMeshInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00037B18 File Offset: 0x00035D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148839, RefRangeEnd = 148840, XrefRangeStart = 148837, XrefRangeEnd = 148839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVertexLayout(bool isVolumetric)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVolumetric;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ResetVertexLayout_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00037B58 File Offset: 0x00035D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148840, XrefRangeEnd = 148842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices(Il2CppReferenceArray<MaterialReference> materials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Il2CppReferenceArray_1_MaterialReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00037B9C File Offset: 0x00035D9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148852, RefRangeEnd = 148854, XrefRangeStart = 148842, XrefRangeEnd = 148852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearLineInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00037BD0 File Offset: 0x00035DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148857, RefRangeEnd = 148858, XrefRangeStart = 148854, XrefRangeEnd = 148857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPageInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00037C04 File Offset: 0x00035E04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 148886, RefRangeEnd = 148891, XrefRangeStart = 148858, XrefRangeEnd = 148886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TMP_MeshInfo> CopyMeshInfoVertexData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.NativeMethodInfoPtr_CopyMeshInfoVertexData_Public_Il2CppReferenceArray_1_TMP_MeshInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr3) : null;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00037C44 File Offset: 0x00035E44
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 148893, RefRangeEnd = 148899, XrefRangeStart = 148891, XrefRangeEnd = 148893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resize<T>(ref Il2CppArrayBase<T> array, int size)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00037CA0 File Offset: 0x00035EA0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 148901, RefRangeEnd = 148915, XrefRangeStart = 148899, XrefRangeEnd = 148901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resize<T>(ref Il2CppArrayBase<T> array, int size, bool isBlockAllocated)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBlockAllocated;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_TextInfo.MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00008782 File Offset: 0x00006982
		public TMP_TextInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00037D08 File Offset: 0x00035F08
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x0000878B File Offset: 0x0000698B
		public unsafe static Vector2 k_InfinityVectorPositive
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorPositive, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorPositive, (void*)(&value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00037D24 File Offset: 0x00035F24
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x00008799 File Offset: 0x00006999
		public unsafe static Vector2 k_InfinityVectorNegative
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorNegative, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextInfo.NativeFieldInfoPtr_k_InfinityVectorNegative, (void*)(&value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00037D40 File Offset: 0x00035F40
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x000087A7 File Offset: 0x000069A7
		public unsafe TMP_Text textComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_textComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00037D70 File Offset: 0x00035F70
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x000087C6 File Offset: 0x000069C6
		public unsafe int characterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterCount)) = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00037D98 File Offset: 0x00035F98
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x000087E1 File Offset: 0x000069E1
		public unsafe int spriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spriteCount)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x00037DC0 File Offset: 0x00035FC0
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x000087FC File Offset: 0x000069FC
		public unsafe int spaceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spaceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_spaceCount)) = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x00037DE8 File Offset: 0x00035FE8
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x00008817 File Offset: 0x00006A17
		public unsafe int wordCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordCount)) = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00037E10 File Offset: 0x00036010
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x00008832 File Offset: 0x00006A32
		public unsafe int linkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkCount)) = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00037E38 File Offset: 0x00036038
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x0000884D File Offset: 0x00006A4D
		public unsafe int lineCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineCount)) = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00037E60 File Offset: 0x00036060
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x00008868 File Offset: 0x00006A68
		public unsafe int pageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageCount)) = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00037E88 File Offset: 0x00036088
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00008883 File Offset: 0x00006A83
		public unsafe int materialCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_materialCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_materialCount)) = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00037EB0 File Offset: 0x000360B0
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x0000889E File Offset: 0x00006A9E
		public unsafe Il2CppReferenceArray<TMP_CharacterInfo> characterInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_CharacterInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_characterInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00037EE0 File Offset: 0x000360E0
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x000088BD File Offset: 0x00006ABD
		public unsafe Il2CppReferenceArray<TMP_WordInfo> wordInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_WordInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_wordInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00037F10 File Offset: 0x00036110
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x000088DC File Offset: 0x00006ADC
		public unsafe Il2CppReferenceArray<TMP_LinkInfo> linkInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_LinkInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_linkInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00037F40 File Offset: 0x00036140
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x000088FB File Offset: 0x00006AFB
		public unsafe Il2CppStructArray<TMP_LineInfo> lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TMP_LineInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_lineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00037F70 File Offset: 0x00036170
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x0000891A File Offset: 0x00006B1A
		public unsafe Il2CppStructArray<TMP_PageInfo> pageInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TMP_PageInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_pageInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00037FA0 File Offset: 0x000361A0
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00008939 File Offset: 0x00006B39
		public unsafe Il2CppReferenceArray<TMP_MeshInfo> meshInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_meshInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_meshInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00037FD0 File Offset: 0x000361D0
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x00008958 File Offset: 0x00006B58
		public unsafe Il2CppReferenceArray<TMP_MeshInfo> m_CachedMeshInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_m_CachedMeshInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextInfo.NativeFieldInfoPtr_m_CachedMeshInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr_k_InfinityVectorPositive;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr_k_InfinityVectorNegative;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_textComponent;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_spriteCount;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_spaceCount;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_wordCount;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr_linkCount;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_lineCount;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeFieldInfoPtr_pageCount;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr_materialCount;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_characterInfo;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_wordInfo;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_linkInfo;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr_pageInfo;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_meshInfo;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedMeshInfo;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllData_Internal_Void_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_ClearMeshInfo_Public_Void_Boolean_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllMeshInfo_Public_Void_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_ResetVertexLayout_Public_Void_Boolean_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Il2CppReferenceArray_1_MaterialReference_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_ClearLineInfo_Public_Void_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_ClearPageInfo_Internal_Void_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_CopyMeshInfoVertexData_Public_Il2CppReferenceArray_1_TMP_MeshInfo_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0;

		// Token: 0x020000AF RID: 175
		private sealed class MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04000C9A RID: 3226
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B0 RID: 176
		private sealed class MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>
		{
			// Token: 0x04000C9B RID: 3227
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_TextInfo.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_Boolean_0, Il2CppClassPointerStore<TMP_TextInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
