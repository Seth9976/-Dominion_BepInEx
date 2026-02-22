using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Fitness
{
	// Token: 0x02000332 RID: 818
	public class DataPoint : Object
	{
		// Token: 0x06002FFC RID: 12284 RVA: 0x000CC9D8 File Offset: 0x000CABD8
		// Note: this type is marked as 'beforefieldinit'.
		static DataPoint()
		{
			Il2CppClassPointerStore<DataPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "DataPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataPoint>.NativeClassPtr);
			DataPoint.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataPoint>.NativeClassPtr, "startTime");
			DataPoint.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataPoint>.NativeClassPtr, "endTime");
			DataPoint.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataPoint>.NativeClassPtr, "dataType");
			DataPoint.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataPoint>.NativeClassPtr, "fields");
			DataPoint.NativeMethodInfoPtr__ctor_Public_Void_DataType_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPoint>.NativeClassPtr, 100669650);
			DataPoint.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPoint>.NativeClassPtr, 100669651);
			DataPoint.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPoint>.NativeClassPtr, 100669652);
			DataPoint.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPoint>.NativeClassPtr, 100669653);
			DataPoint.NativeMethodInfoPtr_get_Fields_Public_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPoint>.NativeClassPtr, 100669654);
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x000CCABC File Offset: 0x000CACBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 221443, RefRangeEnd = 221449, XrefRangeStart = 221422, XrefRangeEnd = 221443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataPoint(DataType type, Il2CppStringArray bundle, string key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataPoint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bundle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataPoint.NativeMethodInfoPtr__ctor_Public_Void_DataType_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002FFE RID: 12286 RVA: 0x000CCB2C File Offset: 0x000CAD2C
		public unsafe long StartTime
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataPoint.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x000CCB68 File Offset: 0x000CAD68
		public unsafe long EndTime
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataPoint.NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06003000 RID: 12288 RVA: 0x000CCBA4 File Offset: 0x000CADA4
		public unsafe DataType DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataPoint.NativeMethodInfoPtr_get_DataType_Public_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr3) : null;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x000CCBE4 File Offset: 0x000CADE4
		public unsafe Dictionary<string, Object> Fields
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataPoint.NativeMethodInfoPtr_get_Fields_Public_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x000124F5 File Offset: 0x000106F5
		public DataPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x000CCC24 File Offset: 0x000CAE24
		// (set) Token: 0x06003004 RID: 12292 RVA: 0x000124FE File Offset: 0x000106FE
		public unsafe long startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataPoint.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataPoint.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x000CCC4C File Offset: 0x000CAE4C
		// (set) Token: 0x06003006 RID: 12294 RVA: 0x00012519 File Offset: 0x00010719
		public unsafe long endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataPoint.NativeFieldInfoPtr_endTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataPoint.NativeFieldInfoPtr_endTime)) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06003007 RID: 12295 RVA: 0x000CCC74 File Offset: 0x000CAE74
		// (set) Token: 0x06003008 RID: 12296 RVA: 0x00012534 File Offset: 0x00010734
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataPoint.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataPoint.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x000CCCA4 File Offset: 0x000CAEA4
		// (set) Token: 0x0600300A RID: 12298 RVA: 0x00012553 File Offset: 0x00010753
		public unsafe Dictionary<string, Object> fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataPoint.NativeFieldInfoPtr_fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataPoint.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DCE RID: 11726
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04002DCF RID: 11727
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x04002DD0 RID: 11728
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002DD1 RID: 11729
		private static readonly IntPtr NativeFieldInfoPtr_fields;

		// Token: 0x04002DD2 RID: 11730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataType_Il2CppStringArray_String_0;

		// Token: 0x04002DD3 RID: 11731
		private static readonly IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0;

		// Token: 0x04002DD4 RID: 11732
		private static readonly IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_Int64_0;

		// Token: 0x04002DD5 RID: 11733
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_DataType_0;

		// Token: 0x04002DD6 RID: 11734
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_Dictionary_2_String_Object_0;
	}
}
