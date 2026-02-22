using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	// Token: 0x0200013F RID: 319
	public class BatchRendererGroup : Object
	{
		// Token: 0x060017E1 RID: 6113 RVA: 0x00059398 File Offset: 0x00057598
		// Note: this type is marked as 'beforefieldinit'.
		static BatchRendererGroup()
		{
			Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr);
			BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_GroupHandle");
			BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_PerformCulling");
			BatchRendererGroup.NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100665093);
			BatchRendererGroup.SetBatchFlagsDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetBatchFlagsDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetBatchFlags");
			BatchRendererGroup.InternalSetBatchPropertyMetadataDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.InternalSetBatchPropertyMetadataDelegate>("UnityEngine.Rendering.BatchRendererGroup::InternalSetBatchPropertyMetadata");
			BatchRendererGroup.SetInstancingDataDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetInstancingDataDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetInstancingData");
			BatchRendererGroup.GetNumBatchesDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetNumBatchesDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetNumBatches");
			BatchRendererGroup.RemoveBatchDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RemoveBatchDelegate>("UnityEngine.Rendering.BatchRendererGroup::RemoveBatch");
			BatchRendererGroup.GetBatchMatricesDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchMatricesDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchMatrices");
			BatchRendererGroup.GetBatchScalarArrayDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchScalarArrayDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchScalarArray");
			BatchRendererGroup.GetBatchVectorArrayDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchVectorArrayDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchVectorArray");
			BatchRendererGroup.GetBatchMatrixArrayDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchMatrixArrayDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchMatrixArray");
			BatchRendererGroup.GetBatchScalarArray_InternalDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchScalarArray_InternalDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchScalarArray_Internal");
			BatchRendererGroup.GetBatchVectorArray_InternalDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchVectorArray_InternalDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchVectorArray_Internal");
			BatchRendererGroup.GetBatchMatrixArray_InternalDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBatchMatrixArray_InternalDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBatchMatrixArray_Internal");
			BatchRendererGroup.EnableVisibleIndicesYArrayDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.EnableVisibleIndicesYArrayDelegate>("UnityEngine.Rendering.BatchRendererGroup::EnableVisibleIndicesYArray");
			BatchRendererGroup.CreateDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.CreateDelegate>("UnityEngine.Rendering.BatchRendererGroup::Create");
			BatchRendererGroup.DestroyDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.DestroyDelegate>("UnityEngine.Rendering.BatchRendererGroup::Destroy");
			BatchRendererGroup.AddBatch_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.AddBatch_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::AddBatch_Injected");
			BatchRendererGroup.SetBatchBounds_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetBatchBounds_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetBatchBounds_Injected");
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00059504 File Offset: 0x00057704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82237, XrefRangeEnd = 82252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lodParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0000D62B File Offset: 0x0000B82B
		public BatchRendererGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x00059558 File Offset: 0x00057758
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x0000D634 File Offset: 0x0000B834
		public unsafe IntPtr m_GroupHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle)) = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00059580 File Offset: 0x00057780
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0000D64F File Offset: 0x0000B84F
		public unsafe BatchRendererGroup.OnPerformCulling m_PerformCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchRendererGroup.OnPerformCulling>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0000D66E File Offset: 0x0000B86E
		public void Dispose()
		{
			BatchRendererGroup.Destroy(this.m_GroupHandle);
			this.m_GroupHandle = IntPtr.Zero;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x000595B0 File Offset: 0x000577B0
		public int AddBatch(Mesh mesh, int subMeshIndex, Material material, int layer, ShadowCastingMode castShadows, bool receiveShadows, bool invertCulling, Bounds bounds, int instanceCount, MaterialPropertyBlock customProps, GameObject associatedSceneObject, [Optional] ulong sceneCullingMask, [Optional] uint renderingLayerMask)
		{
			return this.AddBatch_Injected(mesh, subMeshIndex, material, layer, castShadows, receiveShadows, invertCulling, ref bounds, instanceCount, customProps, associatedSceneObject, sceneCullingMask, renderingLayerMask);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0000D688 File Offset: 0x0000B888
		public void SetBatchFlags(int batchIndex, ulong flags)
		{
			BatchRendererGroup.SetBatchFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, flags);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x0000D69C File Offset: 0x0000B89C
		public void SetBatchPropertyMetadata(int batchIndex, Unity.Collections.NativeArray<int> cbufferLengths, Unity.Collections.NativeArray<int> cbufferMetadata)
		{
			this.InternalSetBatchPropertyMetadata(batchIndex, (IntPtr)cbufferLengths.GetUnsafeReadOnlyPtr<int>(), cbufferLengths.Length, (IntPtr)cbufferMetadata.GetUnsafeReadOnlyPtr<int>(), cbufferMetadata.Length);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0000D6CB File Offset: 0x0000B8CB
		public void InternalSetBatchPropertyMetadata(int batchIndex, IntPtr cbufferLengths, int cbufferLengthsCount, IntPtr cbufferMetadata, int cbufferMetadataCount)
		{
			BatchRendererGroup.InternalSetBatchPropertyMetadataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, cbufferLengths, cbufferLengthsCount, cbufferMetadata, cbufferMetadataCount);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		public void SetInstancingData(int batchIndex, int instanceCount, MaterialPropertyBlock customProps)
		{
			BatchRendererGroup.SetInstancingDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(customProps));
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x000595DC File Offset: 0x000577DC
		public unsafe Unity.Collections.NativeArray<Matrix4x4> GetBatchMatrices(int batchIndex)
		{
			int num = 0;
			void* batchMatrices = this.GetBatchMatrices(batchIndex, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>(batchMatrices, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00059604 File Offset: 0x00057804
		public unsafe Unity.Collections.NativeArray<int> GetBatchScalarArrayInt(int batchIndex, string propertyName)
		{
			int num = 0;
			void* batchScalarArray = this.GetBatchScalarArray(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(batchScalarArray, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00059630 File Offset: 0x00057830
		public unsafe Unity.Collections.NativeArray<float> GetBatchScalarArray(int batchIndex, string propertyName)
		{
			int num = 0;
			void* batchScalarArray = this.GetBatchScalarArray(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float>(batchScalarArray, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0005965C File Offset: 0x0005785C
		public unsafe Unity.Collections.NativeArray<int> GetBatchVectorArrayInt(int batchIndex, string propertyName)
		{
			int num = 0;
			void* batchVectorArray = this.GetBatchVectorArray(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(batchVectorArray, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00059688 File Offset: 0x00057888
		public unsafe Unity.Collections.NativeArray<Vector4> GetBatchVectorArray(int batchIndex, string propertyName)
		{
			int num = 0;
			void* batchVectorArray = this.GetBatchVectorArray(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector4>(batchVectorArray, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x000596B4 File Offset: 0x000578B4
		public unsafe Unity.Collections.NativeArray<Matrix4x4> GetBatchMatrixArray(int batchIndex, string propertyName)
		{
			int num = 0;
			void* batchMatrixArray = this.GetBatchMatrixArray(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>(batchMatrixArray, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x000596E0 File Offset: 0x000578E0
		public unsafe Unity.Collections.NativeArray<int> GetBatchScalarArrayInt(int batchIndex, int propertyName)
		{
			int num = 0;
			void* batchScalarArray_Internal = this.GetBatchScalarArray_Internal(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(batchScalarArray_Internal, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0005970C File Offset: 0x0005790C
		public unsafe Unity.Collections.NativeArray<float> GetBatchScalarArray(int batchIndex, int propertyName)
		{
			int num = 0;
			void* batchScalarArray_Internal = this.GetBatchScalarArray_Internal(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float>(batchScalarArray_Internal, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00059738 File Offset: 0x00057938
		public unsafe Unity.Collections.NativeArray<int> GetBatchVectorArrayInt(int batchIndex, int propertyName)
		{
			int num = 0;
			void* batchVectorArray_Internal = this.GetBatchVectorArray_Internal(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(batchVectorArray_Internal, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00059764 File Offset: 0x00057964
		public unsafe Unity.Collections.NativeArray<Vector4> GetBatchVectorArray(int batchIndex, int propertyName)
		{
			int num = 0;
			void* batchVectorArray_Internal = this.GetBatchVectorArray_Internal(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector4>(batchVectorArray_Internal, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00059790 File Offset: 0x00057990
		public unsafe Unity.Collections.NativeArray<Matrix4x4> GetBatchMatrixArray(int batchIndex, int propertyName)
		{
			int num = 0;
			void* batchMatrixArray_Internal = this.GetBatchMatrixArray_Internal(batchIndex, propertyName, out num);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>(batchMatrixArray_Internal, num, Unity.Collections.Allocator.Invalid);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0000D6FE File Offset: 0x0000B8FE
		public void SetBatchBounds(int batchIndex, Bounds bounds)
		{
			this.SetBatchBounds_Injected(batchIndex, ref bounds);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0000D709 File Offset: 0x0000B909
		public int GetNumBatches()
		{
			return BatchRendererGroup.GetNumBatchesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0000D71B File Offset: 0x0000B91B
		public void RemoveBatch(int index)
		{
			BatchRendererGroup.RemoveBatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0000D72E File Offset: 0x0000B92E
		public unsafe void* GetBatchMatrices(int batchIndex, out int matrixCount)
		{
			return BatchRendererGroup.GetBatchMatricesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, out matrixCount);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0000D742 File Offset: 0x0000B942
		public unsafe void* GetBatchScalarArray(int batchIndex, string propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchScalarArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, IL2CPP.ManagedStringToIl2Cpp(propertyName), out elementCount);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0000D75C File Offset: 0x0000B95C
		public unsafe void* GetBatchVectorArray(int batchIndex, string propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, IL2CPP.ManagedStringToIl2Cpp(propertyName), out elementCount);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0000D776 File Offset: 0x0000B976
		public unsafe void* GetBatchMatrixArray(int batchIndex, string propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, IL2CPP.ManagedStringToIl2Cpp(propertyName), out elementCount);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0000D790 File Offset: 0x0000B990
		public unsafe void* GetBatchScalarArray_Internal(int batchIndex, int propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchScalarArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, propertyName, out elementCount);
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x0000D7A5 File Offset: 0x0000B9A5
		public unsafe void* GetBatchVectorArray_Internal(int batchIndex, int propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchVectorArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, propertyName, out elementCount);
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0000D7BA File Offset: 0x0000B9BA
		public unsafe void* GetBatchMatrixArray_Internal(int batchIndex, int propertyName, out int elementCount)
		{
			return BatchRendererGroup.GetBatchMatrixArray_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, propertyName, out elementCount);
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x0000D7CF File Offset: 0x0000B9CF
		public void EnableVisibleIndicesYArray(bool enabled)
		{
			BatchRendererGroup.EnableVisibleIndicesYArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), enabled);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x0000D7E2 File Offset: 0x0000B9E2
		public static IntPtr Create(BatchRendererGroup group)
		{
			return BatchRendererGroup.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(group));
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
		public static void Destroy(IntPtr groupHandle)
		{
			BatchRendererGroup.DestroyDelegateField(groupHandle);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x000597BC File Offset: 0x000579BC
		public int AddBatch_Injected(Mesh mesh, int subMeshIndex, Material material, int layer, ShadowCastingMode castShadows, bool receiveShadows, bool invertCulling, ref Bounds bounds, int instanceCount, MaterialPropertyBlock customProps, GameObject associatedSceneObject, [Optional] ulong sceneCullingMask, [Optional] uint renderingLayerMask)
		{
			return BatchRendererGroup.AddBatch_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), subMeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), layer, castShadows, receiveShadows, invertCulling, ref bounds, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(customProps), IL2CPP.Il2CppObjectBaseToPtr(associatedSceneObject), sceneCullingMask, renderingLayerMask);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0000D801 File Offset: 0x0000BA01
		public void SetBatchBounds_Injected(int batchIndex, ref Bounds bounds)
		{
			BatchRendererGroup.SetBatchBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), batchIndex, ref bounds);
		}

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeFieldInfoPtr_m_GroupHandle;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeFieldInfoPtr_m_PerformCulling;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly BatchRendererGroup.SetBatchFlagsDelegate SetBatchFlagsDelegateField;

		// Token: 0x040011D5 RID: 4565
		private static readonly BatchRendererGroup.InternalSetBatchPropertyMetadataDelegate InternalSetBatchPropertyMetadataDelegateField;

		// Token: 0x040011D6 RID: 4566
		private static readonly BatchRendererGroup.SetInstancingDataDelegate SetInstancingDataDelegateField;

		// Token: 0x040011D7 RID: 4567
		private static readonly BatchRendererGroup.GetNumBatchesDelegate GetNumBatchesDelegateField;

		// Token: 0x040011D8 RID: 4568
		private static readonly BatchRendererGroup.RemoveBatchDelegate RemoveBatchDelegateField;

		// Token: 0x040011D9 RID: 4569
		private static readonly BatchRendererGroup.GetBatchMatricesDelegate GetBatchMatricesDelegateField;

		// Token: 0x040011DA RID: 4570
		private static readonly BatchRendererGroup.GetBatchScalarArrayDelegate GetBatchScalarArrayDelegateField;

		// Token: 0x040011DB RID: 4571
		private static readonly BatchRendererGroup.GetBatchVectorArrayDelegate GetBatchVectorArrayDelegateField;

		// Token: 0x040011DC RID: 4572
		private static readonly BatchRendererGroup.GetBatchMatrixArrayDelegate GetBatchMatrixArrayDelegateField;

		// Token: 0x040011DD RID: 4573
		private static readonly BatchRendererGroup.GetBatchScalarArray_InternalDelegate GetBatchScalarArray_InternalDelegateField;

		// Token: 0x040011DE RID: 4574
		private static readonly BatchRendererGroup.GetBatchVectorArray_InternalDelegate GetBatchVectorArray_InternalDelegateField;

		// Token: 0x040011DF RID: 4575
		private static readonly BatchRendererGroup.GetBatchMatrixArray_InternalDelegate GetBatchMatrixArray_InternalDelegateField;

		// Token: 0x040011E0 RID: 4576
		private static readonly BatchRendererGroup.EnableVisibleIndicesYArrayDelegate EnableVisibleIndicesYArrayDelegateField;

		// Token: 0x040011E1 RID: 4577
		private static readonly BatchRendererGroup.CreateDelegate CreateDelegateField;

		// Token: 0x040011E2 RID: 4578
		private static readonly BatchRendererGroup.DestroyDelegate DestroyDelegateField;

		// Token: 0x040011E3 RID: 4579
		private static readonly BatchRendererGroup.AddBatch_InjectedDelegate AddBatch_InjectedDelegateField;

		// Token: 0x040011E4 RID: 4580
		private static readonly BatchRendererGroup.SetBatchBounds_InjectedDelegate SetBatchBounds_InjectedDelegateField;

		// Token: 0x02000985 RID: 2437
		public sealed class OnPerformCulling : MulticastDelegate
		{
			// Token: 0x06003127 RID: 12583 RVA: 0x00017762 File Offset: 0x00015962
			// Note: this type is marked as 'beforefieldinit'.
			static OnPerformCulling()
			{
				Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "OnPerformCulling");
				BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100665094);
				BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100665095);
			}

			// Token: 0x06003128 RID: 12584 RVA: 0x0006E568 File Offset: 0x0006C768
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPerformCulling(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003129 RID: 12585 RVA: 0x0006E5C4 File Offset: 0x0006C7C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82236, RefRangeEnd = 82237, XrefRangeStart = 82236, XrefRangeEnd = 82236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Unity.Jobs.JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererGroup);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cullingContext));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600312A RID: 12586 RVA: 0x000177A0 File Offset: 0x000159A0
			public OnPerformCulling(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600312B RID: 12587 RVA: 0x000177A9 File Offset: 0x000159A9
			public static implicit operator BatchRendererGroup.OnPerformCulling(Func<BatchRendererGroup, BatchCullingContext, Unity.Jobs.JobHandle> A_0)
			{
				return DelegateSupport.ConvertDelegate<BatchRendererGroup.OnPerformCulling>(A_0);
			}

			// Token: 0x0600312C RID: 12588 RVA: 0x000177B1 File Offset: 0x000159B1
			public static BatchRendererGroup.OnPerformCulling operator +(BatchRendererGroup.OnPerformCulling A_0, BatchRendererGroup.OnPerformCulling A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<BatchRendererGroup.OnPerformCulling>();
			}

			// Token: 0x0600312D RID: 12589 RVA: 0x000177BF File Offset: 0x000159BF
			public static BatchRendererGroup.OnPerformCulling operator -(BatchRendererGroup.OnPerformCulling A_0, BatchRendererGroup.OnPerformCulling A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<BatchRendererGroup.OnPerformCulling>();
				}
				return delegate2;
			}

			// Token: 0x04001D21 RID: 7457
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001D22 RID: 7458
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_0;
		}

		// Token: 0x02000986 RID: 2438
		// (Invoke) Token: 0x0600312F RID: 12591
		private delegate void SetBatchFlagsDelegate(IntPtr @this, int batchIndex, ulong flags);

		// Token: 0x02000987 RID: 2439
		// (Invoke) Token: 0x06003131 RID: 12593
		private delegate void InternalSetBatchPropertyMetadataDelegate(IntPtr @this, int batchIndex, IntPtr cbufferLengths, int cbufferLengthsCount, IntPtr cbufferMetadata, int cbufferMetadataCount);

		// Token: 0x02000988 RID: 2440
		// (Invoke) Token: 0x06003133 RID: 12595
		private delegate void SetInstancingDataDelegate(IntPtr @this, int batchIndex, int instanceCount, IntPtr customProps);

		// Token: 0x02000989 RID: 2441
		// (Invoke) Token: 0x06003135 RID: 12597
		private delegate int GetNumBatchesDelegate(IntPtr @this);

		// Token: 0x0200098A RID: 2442
		// (Invoke) Token: 0x06003137 RID: 12599
		private delegate void RemoveBatchDelegate(IntPtr @this, int index);

		// Token: 0x0200098B RID: 2443
		// (Invoke) Token: 0x06003139 RID: 12601
		private delegate IntPtr GetBatchMatricesDelegate(IntPtr @this, int batchIndex, [Out] IntPtr matrixCount);

		// Token: 0x0200098C RID: 2444
		// (Invoke) Token: 0x0600313B RID: 12603
		private delegate IntPtr GetBatchScalarArrayDelegate(IntPtr @this, int batchIndex, IntPtr propertyName, [Out] IntPtr elementCount);

		// Token: 0x0200098D RID: 2445
		// (Invoke) Token: 0x0600313D RID: 12605
		private delegate IntPtr GetBatchVectorArrayDelegate(IntPtr @this, int batchIndex, IntPtr propertyName, [Out] IntPtr elementCount);

		// Token: 0x0200098E RID: 2446
		// (Invoke) Token: 0x0600313F RID: 12607
		private delegate IntPtr GetBatchMatrixArrayDelegate(IntPtr @this, int batchIndex, IntPtr propertyName, [Out] IntPtr elementCount);

		// Token: 0x0200098F RID: 2447
		// (Invoke) Token: 0x06003141 RID: 12609
		private delegate IntPtr GetBatchScalarArray_InternalDelegate(IntPtr @this, int batchIndex, int propertyName, [Out] IntPtr elementCount);

		// Token: 0x02000990 RID: 2448
		// (Invoke) Token: 0x06003143 RID: 12611
		private delegate IntPtr GetBatchVectorArray_InternalDelegate(IntPtr @this, int batchIndex, int propertyName, [Out] IntPtr elementCount);

		// Token: 0x02000991 RID: 2449
		// (Invoke) Token: 0x06003145 RID: 12613
		private delegate IntPtr GetBatchMatrixArray_InternalDelegate(IntPtr @this, int batchIndex, int propertyName, [Out] IntPtr elementCount);

		// Token: 0x02000992 RID: 2450
		// (Invoke) Token: 0x06003147 RID: 12615
		private delegate void EnableVisibleIndicesYArrayDelegate(IntPtr @this, bool enabled);

		// Token: 0x02000993 RID: 2451
		// (Invoke) Token: 0x06003149 RID: 12617
		private delegate IntPtr CreateDelegate(IntPtr group);

		// Token: 0x02000994 RID: 2452
		// (Invoke) Token: 0x0600314B RID: 12619
		private delegate void DestroyDelegate(IntPtr groupHandle);

		// Token: 0x02000995 RID: 2453
		// (Invoke) Token: 0x0600314D RID: 12621
		private delegate int AddBatch_InjectedDelegate(IntPtr @this, IntPtr mesh, int subMeshIndex, IntPtr material, int layer, ShadowCastingMode castShadows, bool receiveShadows, bool invertCulling, IntPtr bounds, int instanceCount, IntPtr customProps, IntPtr associatedSceneObject, ulong sceneCullingMask, uint renderingLayerMask);

		// Token: 0x02000996 RID: 2454
		// (Invoke) Token: 0x0600314F RID: 12623
		private delegate void SetBatchBounds_InjectedDelegate(IntPtr @this, int batchIndex, IntPtr bounds);
	}
}
