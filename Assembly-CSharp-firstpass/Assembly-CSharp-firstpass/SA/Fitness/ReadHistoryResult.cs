using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Models;

namespace SA.Fitness
{
	// Token: 0x0200033D RID: 829
	public class ReadHistoryResult : Result
	{
		// Token: 0x06003200 RID: 12800 RVA: 0x000D1624 File Offset: 0x000CF824
		// Note: this type is marked as 'beforefieldinit'.
		static ReadHistoryResult()
		{
			Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "ReadHistoryResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr);
			ReadHistoryResult.NativeFieldInfoPtr_buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, "buckets");
			ReadHistoryResult.NativeFieldInfoPtr_dataSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, "dataSets");
			ReadHistoryResult.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, "id");
			ReadHistoryResult.NativeFieldInfoPtr_isAggregated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, "isAggregated");
			ReadHistoryResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, 100669728);
			ReadHistoryResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, 100669729);
			ReadHistoryResult.NativeMethodInfoPtr_AddDataSet_Public_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, 100669730);
			ReadHistoryResult.NativeMethodInfoPtr_AddBucket_Public_Void_Bucket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, 100669731);
			ReadHistoryResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, 100669732);
			ReadHistoryResult.NativeMethodInfoPtr_get_IsAggregated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, 100669733);
			ReadHistoryResult.NativeMethodInfoPtr_get_Buckets_Public_get_List_1_Bucket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, 100669734);
			ReadHistoryResult.NativeMethodInfoPtr_get_DataSets_Public_get_List_1_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr, 100669735);
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x000D1744 File Offset: 0x000CF944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222079, RefRangeEnd = 222081, XrefRangeStart = 222066, XrefRangeEnd = 222079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadHistoryResult(int id, bool isAggregated)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAggregated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x000D179C File Offset: 0x000CF99C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222098, RefRangeEnd = 222100, XrefRangeStart = 222081, XrefRangeEnd = 222098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadHistoryResult(int id, int resultCode, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadHistoryResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x000D1804 File Offset: 0x000CFA04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222104, RefRangeEnd = 222105, XrefRangeStart = 222100, XrefRangeEnd = 222104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDataSet(DataSet dataSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryResult.NativeMethodInfoPtr_AddDataSet_Public_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x000D1848 File Offset: 0x000CFA48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222109, RefRangeEnd = 222110, XrefRangeStart = 222105, XrefRangeEnd = 222109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBucket(Bucket bucket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bucket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryResult.NativeMethodInfoPtr_AddBucket_Public_Void_Bucket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06003205 RID: 12805 RVA: 0x000D188C File Offset: 0x000CFA8C
		public unsafe int Id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryResult.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x000D18C8 File Offset: 0x000CFAC8
		public unsafe bool IsAggregated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryResult.NativeMethodInfoPtr_get_IsAggregated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06003207 RID: 12807 RVA: 0x000D1904 File Offset: 0x000CFB04
		public unsafe List<Bucket> Buckets
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryResult.NativeMethodInfoPtr_get_Buckets_Public_get_List_1_Bucket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Bucket>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x000D1944 File Offset: 0x000CFB44
		public unsafe List<DataSet> DataSets
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadHistoryResult.NativeMethodInfoPtr_get_DataSets_Public_get_List_1_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataSet>>(intPtr3) : null;
			}
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x000135E9 File Offset: 0x000117E9
		public ReadHistoryResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x000D1984 File Offset: 0x000CFB84
		// (set) Token: 0x0600320B RID: 12811 RVA: 0x000135F2 File Offset: 0x000117F2
		public unsafe List<Bucket> buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryResult.NativeFieldInfoPtr_buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Bucket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryResult.NativeFieldInfoPtr_buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x000D19B4 File Offset: 0x000CFBB4
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x00013611 File Offset: 0x00011811
		public unsafe List<DataSet> dataSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryResult.NativeFieldInfoPtr_dataSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryResult.NativeFieldInfoPtr_dataSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x000D19E4 File Offset: 0x000CFBE4
		// (set) Token: 0x0600320F RID: 12815 RVA: 0x00013630 File Offset: 0x00011830
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryResult.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryResult.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x000D1A0C File Offset: 0x000CFC0C
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x0001364B File Offset: 0x0001184B
		public unsafe bool isAggregated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryResult.NativeFieldInfoPtr_isAggregated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadHistoryResult.NativeFieldInfoPtr_isAggregated)) = value;
			}
		}

		// Token: 0x04002EEA RID: 12010
		private static readonly IntPtr NativeFieldInfoPtr_buckets;

		// Token: 0x04002EEB RID: 12011
		private static readonly IntPtr NativeFieldInfoPtr_dataSets;

		// Token: 0x04002EEC RID: 12012
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002EED RID: 12013
		private static readonly IntPtr NativeFieldInfoPtr_isAggregated;

		// Token: 0x04002EEE RID: 12014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x04002EEF RID: 12015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0;

		// Token: 0x04002EF0 RID: 12016
		private static readonly IntPtr NativeMethodInfoPtr_AddDataSet_Public_Void_DataSet_0;

		// Token: 0x04002EF1 RID: 12017
		private static readonly IntPtr NativeMethodInfoPtr_AddBucket_Public_Void_Bucket_0;

		// Token: 0x04002EF2 RID: 12018
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002EF3 RID: 12019
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAggregated_Public_get_Boolean_0;

		// Token: 0x04002EF4 RID: 12020
		private static readonly IntPtr NativeMethodInfoPtr_get_Buckets_Public_get_List_1_Bucket_0;

		// Token: 0x04002EF5 RID: 12021
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSets_Public_get_List_1_DataSet_0;
	}
}
