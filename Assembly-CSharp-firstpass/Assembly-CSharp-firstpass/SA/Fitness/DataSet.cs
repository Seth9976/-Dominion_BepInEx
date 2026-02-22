using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Fitness
{
	// Token: 0x02000333 RID: 819
	public class DataSet : Object
	{
		// Token: 0x0600300B RID: 12299 RVA: 0x000CCCD4 File Offset: 0x000CAED4
		// Note: this type is marked as 'beforefieldinit'.
		static DataSet()
		{
			Il2CppClassPointerStore<DataSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "DataSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataSet>.NativeClassPtr);
			DataSet.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "dataType");
			DataSet.NativeFieldInfoPtr_dataPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "dataPoints");
			DataSet.NativeMethodInfoPtr__ctor_Public_Void_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100669655);
			DataSet.NativeMethodInfoPtr_AddDataPoint_Internal_Void_DataPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100669656);
			DataSet.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100669657);
			DataSet.NativeMethodInfoPtr_get_DataPoints_Public_get_List_1_DataPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100669658);
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x000CCD7C File Offset: 0x000CAF7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 221456, RefRangeEnd = 221460, XrefRangeStart = 221449, XrefRangeEnd = 221456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataSet(DataType dataType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr__ctor_Public_Void_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x000CCDC8 File Offset: 0x000CAFC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 221464, RefRangeEnd = 221468, XrefRangeStart = 221460, XrefRangeEnd = 221464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDataPoint(DataPoint dataPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_AddDataPoint_Internal_Void_DataPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x000CCE0C File Offset: 0x000CB00C
		public unsafe DataType DataType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x000CCE4C File Offset: 0x000CB04C
		public unsafe List<DataPoint> DataPoints
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataSet.NativeMethodInfoPtr_get_DataPoints_Public_get_List_1_DataPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataPoint>>(intPtr3) : null;
			}
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x00012572 File Offset: 0x00010772
		public DataSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x000CCE8C File Offset: 0x000CB08C
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x0001257B File Offset: 0x0001077B
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x000CCEBC File Offset: 0x000CB0BC
		// (set) Token: 0x06003014 RID: 12308 RVA: 0x0001259A File Offset: 0x0001079A
		public unsafe List<DataPoint> dataPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_dataPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataSet.NativeFieldInfoPtr_dataPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DD7 RID: 11735
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002DD8 RID: 11736
		private static readonly IntPtr NativeFieldInfoPtr_dataPoints;

		// Token: 0x04002DD9 RID: 11737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataType_0;

		// Token: 0x04002DDA RID: 11738
		private static readonly IntPtr NativeMethodInfoPtr_AddDataPoint_Internal_Void_DataPoint_0;

		// Token: 0x04002DDB RID: 11739
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;

		// Token: 0x04002DDC RID: 11740
		private static readonly IntPtr NativeMethodInfoPtr_get_DataPoints_Public_get_List_1_DataPoint_0;
	}
}
