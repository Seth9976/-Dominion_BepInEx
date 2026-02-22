using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x0200013D RID: 317
	public sealed class BatchCullingContext : ValueType
	{
		// Token: 0x060017CD RID: 6093 RVA: 0x00058FD0 File Offset: 0x000571D0
		// Note: this type is marked as 'beforefieldinit'.
		static BatchCullingContext()
		{
			Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr);
			BatchCullingContext.NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingPlanes");
			BatchCullingContext.NativeFieldInfoPtr_batchVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "batchVisibility");
			BatchCullingContext.NativeFieldInfoPtr_visibleIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "visibleIndices");
			BatchCullingContext.NativeFieldInfoPtr_visibleIndicesY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "visibleIndicesY");
			BatchCullingContext.NativeFieldInfoPtr_lodParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "lodParameters");
			BatchCullingContext.NativeFieldInfoPtr_cullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingMatrix");
			BatchCullingContext.NativeFieldInfoPtr_nearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "nearPlane");
			BatchCullingContext.NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_BatchVisibility_NativeArray_1_Int32_NativeArray_1_Int32_LODParameters_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, 100665092);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x000590A0 File Offset: 0x000572A0
		[CallerCount(0)]
		public unsafe BatchCullingContext(Unity.Collections.NativeArray<Plane> inCullingPlanes, Unity.Collections.NativeArray<BatchVisibility> inOutBatchVisibility, Unity.Collections.NativeArray<int> outVisibleIndices, Unity.Collections.NativeArray<int> outVisibleIndicesY, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inCullingPlanes));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inOutBatchVisibility));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(outVisibleIndices));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(outVisibleIndicesY));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLodParameters;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inCullingMatrix;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inNearPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchCullingContext.NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_BatchVisibility_NativeArray_1_Int32_NativeArray_1_Int32_LODParameters_Matrix4x4_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0000D4F5 File Offset: 0x0000B6F5
		public BatchCullingContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0000D4FE File Offset: 0x0000B6FE
		public BatchCullingContext()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x00059168 File Offset: 0x00057368
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x0000D510 File Offset: 0x0000B710
		public Unity.Collections.NativeArray<Plane> cullingPlanes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingPlanes);
				return new Unity.Collections.NativeArray<Plane>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Plane>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingPlanes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Plane>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00059198 File Offset: 0x00057398
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0000D53E File Offset: 0x0000B73E
		public Unity.Collections.NativeArray<BatchVisibility> batchVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_batchVisibility);
				return new Unity.Collections.NativeArray<BatchVisibility>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<BatchVisibility>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_batchVisibility), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<BatchVisibility>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x000591C8 File Offset: 0x000573C8
		// (set) Token: 0x060017D6 RID: 6102 RVA: 0x0000D56C File Offset: 0x0000B76C
		public Unity.Collections.NativeArray<int> visibleIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_visibleIndices);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_visibleIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x000591F8 File Offset: 0x000573F8
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x0000D59A File Offset: 0x0000B79A
		public Unity.Collections.NativeArray<int> visibleIndicesY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_visibleIndicesY);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_visibleIndicesY), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x00059228 File Offset: 0x00057428
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x0000D5C8 File Offset: 0x0000B7C8
		public unsafe LODParameters lodParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_lodParameters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_lodParameters)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x00059250 File Offset: 0x00057450
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x0000D5E3 File Offset: 0x0000B7E3
		public unsafe Matrix4x4 cullingMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingMatrix)) = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00059278 File Offset: 0x00057478
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x0000D5FE File Offset: 0x0000B7FE
		public unsafe float nearPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_nearPlane);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_nearPlane)) = value;
			}
		}

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlanes;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_batchVisibility;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_visibleIndices;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_visibleIndicesY;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr_lodParameters;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeFieldInfoPtr_cullingMatrix;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeFieldInfoPtr_nearPlane;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_BatchVisibility_NativeArray_1_Int32_NativeArray_1_Int32_LODParameters_Matrix4x4_Single_0;
	}
}
