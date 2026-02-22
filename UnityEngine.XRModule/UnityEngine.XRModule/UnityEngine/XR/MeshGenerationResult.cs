using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000017 RID: 23
	public sealed class MeshGenerationResult : ValueType
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00005288 File Offset: 0x00003488
		// Note: this type is marked as 'beforefieldinit'.
		static MeshGenerationResult()
		{
			Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "MeshGenerationResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr);
			MeshGenerationResult.NativeFieldInfoPtr__MeshId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<MeshId>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__Mesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Mesh>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__MeshCollider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<MeshCollider>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Status>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__Attributes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Attributes>k__BackingField");
			MeshGenerationResult.NativeMethodInfoPtr_get_MeshId_Public_get_MeshId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663343);
			MeshGenerationResult.NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663344);
			MeshGenerationResult.NativeMethodInfoPtr_get_MeshCollider_Public_get_MeshCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663345);
			MeshGenerationResult.NativeMethodInfoPtr_get_Status_Public_get_MeshGenerationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663346);
			MeshGenerationResult.NativeMethodInfoPtr_get_Attributes_Public_get_MeshVertexAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663347);
			MeshGenerationResult.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663348);
			MeshGenerationResult.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshGenerationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663349);
			MeshGenerationResult.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663350);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000053BC File Offset: 0x000035BC
		public unsafe MeshId MeshId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 108457, RefRangeEnd = 108458, XrefRangeStart = 108457, XrefRangeEnd = 108458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_MeshId_Public_get_MeshId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00005400 File Offset: 0x00003600
		public unsafe Mesh Mesh
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00005444 File Offset: 0x00003644
		public unsafe MeshCollider MeshCollider
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_MeshCollider_Public_get_MeshCollider_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshCollider>(intPtr3) : null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00005488 File Offset: 0x00003688
		public unsafe MeshGenerationStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_Status_Public_get_MeshGenerationStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000054CC File Offset: 0x000036CC
		public unsafe MeshVertexAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_Attributes_Public_get_MeshVertexAttributes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00005510 File Offset: 0x00003710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158364, XrefRangeEnd = 158368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00005564 File Offset: 0x00003764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158381, RefRangeEnd = 158382, XrefRangeStart = 158368, XrefRangeEnd = 158381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(MeshGenerationResult other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshGenerationResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000055BC File Offset: 0x000037BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158382, XrefRangeEnd = 158386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002B88 File Offset: 0x00000D88
		public MeshGenerationResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002B91 File Offset: 0x00000D91
		public MeshGenerationResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr))
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00005600 File Offset: 0x00003800
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002BA3 File Offset: 0x00000DA3
		public unsafe MeshId _MeshId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__MeshId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__MeshId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00005628 File Offset: 0x00003828
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002BBE File Offset: 0x00000DBE
		public unsafe Mesh _Mesh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Mesh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Mesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00005658 File Offset: 0x00003858
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002BDD File Offset: 0x00000DDD
		public unsafe MeshCollider _MeshCollider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__MeshCollider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__MeshCollider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00005688 File Offset: 0x00003888
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002BFC File Offset: 0x00000DFC
		public unsafe MeshGenerationStatus _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Status_k__BackingField)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000056B0 File Offset: 0x000038B0
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002C17 File Offset: 0x00000E17
		public unsafe MeshVertexAttributes _Attributes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Attributes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Attributes_k__BackingField)) = value;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000056D8 File Offset: 0x000038D8
		public static bool operator ==(MeshGenerationResult lhs, MeshGenerationResult rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000056F4 File Offset: 0x000038F4
		public static bool operator !=(MeshGenerationResult lhs, MeshGenerationResult rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr__MeshId_k__BackingField;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr__Mesh_k__BackingField;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr__MeshCollider_k__BackingField;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr__Attributes_k__BackingField;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_get_MeshId_Public_get_MeshId_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_get_MeshCollider_Public_get_MeshCollider_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_MeshGenerationStatus_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_MeshVertexAttributes_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshGenerationResult_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
