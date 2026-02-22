using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Fitness
{
	// Token: 0x02000330 RID: 816
	public sealed class Bucket : Object
	{
		// Token: 0x06002FE7 RID: 12263 RVA: 0x000CC568 File Offset: 0x000CA768
		// Note: this type is marked as 'beforefieldinit'.
		static Bucket()
		{
			Il2CppClassPointerStore<Bucket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "Bucket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bucket>.NativeClassPtr);
			Bucket.NativeFieldInfoPtr_dataSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bucket>.NativeClassPtr, "dataSets");
			Bucket.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bucket>.NativeClassPtr, "type");
			Bucket.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bucket>.NativeClassPtr, "startTime");
			Bucket.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bucket>.NativeClassPtr, "endTime");
			Bucket.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bucket>.NativeClassPtr, 100669641);
			Bucket.NativeMethodInfoPtr_SetTimeRange_Public_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bucket>.NativeClassPtr, 100669642);
			Bucket.NativeMethodInfoPtr_AddDataSet_Public_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bucket>.NativeClassPtr, 100669643);
			Bucket.NativeMethodInfoPtr_get_Bucketing_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bucket>.NativeClassPtr, 100669644);
			Bucket.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bucket>.NativeClassPtr, 100669645);
			Bucket.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bucket>.NativeClassPtr, 100669646);
			Bucket.NativeMethodInfoPtr_get_DataSets_Public_get_List_1_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bucket>.NativeClassPtr, 100669647);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x000CC674 File Offset: 0x000CA874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221408, RefRangeEnd = 221409, XrefRangeStart = 221401, XrefRangeEnd = 221408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bucket(Bucket.Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bucket>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bucket.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x000CC6BC File Offset: 0x000CA8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221409, RefRangeEnd = 221410, XrefRangeStart = 221409, XrefRangeEnd = 221409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeRange(long startTime, long endTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bucket.NativeMethodInfoPtr_SetTimeRange_Public_Void_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x000CC708 File Offset: 0x000CA908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221414, RefRangeEnd = 221415, XrefRangeStart = 221410, XrefRangeEnd = 221414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDataSet(DataSet dataSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bucket.NativeMethodInfoPtr_AddDataSet_Public_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x000CC74C File Offset: 0x000CA94C
		public unsafe Bucket.Type Bucketing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bucket.NativeMethodInfoPtr_get_Bucketing_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002FEC RID: 12268 RVA: 0x000CC788 File Offset: 0x000CA988
		public unsafe long StartTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bucket.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x000CC7C4 File Offset: 0x000CA9C4
		public unsafe long EndTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bucket.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002FEE RID: 12270 RVA: 0x000CC800 File Offset: 0x000CAA00
		public unsafe List<DataSet> DataSets
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bucket.NativeMethodInfoPtr_get_DataSets_Public_get_List_1_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataSet>>(intPtr3) : null;
			}
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00012473 File Offset: 0x00010673
		public Bucket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x000CC840 File Offset: 0x000CAA40
		// (set) Token: 0x06002FF1 RID: 12273 RVA: 0x0001247C File Offset: 0x0001067C
		public unsafe List<DataSet> dataSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bucket.NativeFieldInfoPtr_dataSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bucket.NativeFieldInfoPtr_dataSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x000CC870 File Offset: 0x000CAA70
		// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x0001249B File Offset: 0x0001069B
		public unsafe Bucket.Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bucket.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bucket.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x000CC898 File Offset: 0x000CAA98
		// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x000124B6 File Offset: 0x000106B6
		public unsafe long startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bucket.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bucket.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x000CC8C0 File Offset: 0x000CAAC0
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x000124D1 File Offset: 0x000106D1
		public unsafe long endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bucket.NativeFieldInfoPtr_endTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bucket.NativeFieldInfoPtr_endTime)) = value;
			}
		}

		// Token: 0x04002DC1 RID: 11713
		private static readonly IntPtr NativeFieldInfoPtr_dataSets;

		// Token: 0x04002DC2 RID: 11714
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04002DC3 RID: 11715
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04002DC4 RID: 11716
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x04002DC5 RID: 11717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04002DC6 RID: 11718
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeRange_Public_Void_Int64_Int64_0;

		// Token: 0x04002DC7 RID: 11719
		private static readonly IntPtr NativeMethodInfoPtr_AddDataSet_Public_Void_DataSet_0;

		// Token: 0x04002DC8 RID: 11720
		private static readonly IntPtr NativeMethodInfoPtr_get_Bucketing_Public_get_Type_0;

		// Token: 0x04002DC9 RID: 11721
		private static readonly IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0;

		// Token: 0x04002DCA RID: 11722
		private static readonly IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0;

		// Token: 0x04002DCB RID: 11723
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSets_Public_get_List_1_DataSet_0;

		// Token: 0x020003E0 RID: 992
		public enum Type
		{
			// Token: 0x0400337E RID: 13182
			ActivitySegment = 4,
			// Token: 0x0400337F RID: 13183
			ActivityType = 3,
			// Token: 0x04003380 RID: 13184
			Session = 2,
			// Token: 0x04003381 RID: 13185
			Time = 1
		}
	}
}
