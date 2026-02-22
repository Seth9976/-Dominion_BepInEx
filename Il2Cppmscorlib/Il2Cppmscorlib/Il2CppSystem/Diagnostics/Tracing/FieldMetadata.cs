using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004CE RID: 1230
	public class FieldMetadata : Object
	{
		// Token: 0x0600481A RID: 18458 RVA: 0x0014AADC File Offset: 0x00148CDC
		// Note: this type is marked as 'beforefieldinit'.
		static FieldMetadata()
		{
			Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "FieldMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr);
			FieldMetadata.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "name");
			FieldMetadata.NativeFieldInfoPtr_nameSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "nameSize");
			FieldMetadata.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "tags");
			FieldMetadata.NativeFieldInfoPtr_custom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "custom");
			FieldMetadata.NativeFieldInfoPtr_fixedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "fixedCount");
			FieldMetadata.NativeFieldInfoPtr_inType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "inType");
			FieldMetadata.NativeFieldInfoPtr_outType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, "outType");
			FieldMetadata.NativeMethodInfoPtr__ctor_Public_Void_String_TraceLoggingDataType_EventFieldTags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, 100673970);
			FieldMetadata.NativeMethodInfoPtr__ctor_Private_Void_String_TraceLoggingDataType_EventFieldTags_Byte_UInt16_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, 100673971);
			FieldMetadata.NativeMethodInfoPtr_IncrementStructFieldCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, 100673972);
			FieldMetadata.NativeMethodInfoPtr_Encode_Public_Void_byref_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr, 100673973);
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x0014ABE8 File Offset: 0x00148DE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 366233, RefRangeEnd = 366237, XrefRangeStart = 366232, XrefRangeEnd = 366233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldMetadata(string name, TraceLoggingDataType type, EventFieldTags tags, bool variableCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref variableCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMetadata.NativeMethodInfoPtr__ctor_Public_Void_String_TraceLoggingDataType_EventFieldTags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x0014AC60 File Offset: 0x00148E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366243, RefRangeEnd = 366244, XrefRangeStart = 366237, XrefRangeEnd = 366243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldMetadata(string name, TraceLoggingDataType dataType, EventFieldTags tags, byte countFlags, ushort fixedCount = 0, Il2CppStructArray<byte> custom = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMetadata>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixedCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(custom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMetadata.NativeMethodInfoPtr__ctor_Private_Void_String_TraceLoggingDataType_EventFieldTags_Byte_UInt16_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x0014ACF8 File Offset: 0x00148EF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 366244, RefRangeEnd = 366248, XrefRangeStart = 366244, XrefRangeEnd = 366244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementStructFieldCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMetadata.NativeMethodInfoPtr_IncrementStructFieldCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x0014AD2C File Offset: 0x00148F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366255, RefRangeEnd = 366256, XrefRangeStart = 366248, XrefRangeEnd = 366255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encode(ref int pos, Il2CppStructArray<byte> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMetadata.NativeMethodInfoPtr_Encode_Public_Void_byref_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x0001B49B File Offset: 0x0001969B
		public FieldMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x0014AD7C File Offset: 0x00148F7C
		// (set) Token: 0x06004821 RID: 18465 RVA: 0x0001B4A4 File Offset: 0x000196A4
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06004822 RID: 18466 RVA: 0x0014ADA4 File Offset: 0x00148FA4
		// (set) Token: 0x06004823 RID: 18467 RVA: 0x0001B4C3 File Offset: 0x000196C3
		public unsafe int nameSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_nameSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_nameSize)) = value;
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06004824 RID: 18468 RVA: 0x0014ADCC File Offset: 0x00148FCC
		// (set) Token: 0x06004825 RID: 18469 RVA: 0x0001B4DE File Offset: 0x000196DE
		public unsafe EventFieldTags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_tags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_tags)) = value;
			}
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06004826 RID: 18470 RVA: 0x0014ADF4 File Offset: 0x00148FF4
		// (set) Token: 0x06004827 RID: 18471 RVA: 0x0001B4F9 File Offset: 0x000196F9
		public unsafe Il2CppStructArray<byte> custom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_custom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_custom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06004828 RID: 18472 RVA: 0x0014AE24 File Offset: 0x00149024
		// (set) Token: 0x06004829 RID: 18473 RVA: 0x0001B518 File Offset: 0x00019718
		public unsafe ushort fixedCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_fixedCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_fixedCount)) = value;
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x0600482A RID: 18474 RVA: 0x0014AE4C File Offset: 0x0014904C
		// (set) Token: 0x0600482B RID: 18475 RVA: 0x0001B533 File Offset: 0x00019733
		public unsafe byte inType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_inType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_inType)) = value;
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x0600482C RID: 18476 RVA: 0x0014AE74 File Offset: 0x00149074
		// (set) Token: 0x0600482D RID: 18477 RVA: 0x0001B54E File Offset: 0x0001974E
		public unsafe byte outType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_outType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMetadata.NativeFieldInfoPtr_outType)) = value;
			}
		}

		// Token: 0x04003A63 RID: 14947
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003A64 RID: 14948
		private static readonly IntPtr NativeFieldInfoPtr_nameSize;

		// Token: 0x04003A65 RID: 14949
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003A66 RID: 14950
		private static readonly IntPtr NativeFieldInfoPtr_custom;

		// Token: 0x04003A67 RID: 14951
		private static readonly IntPtr NativeFieldInfoPtr_fixedCount;

		// Token: 0x04003A68 RID: 14952
		private static readonly IntPtr NativeFieldInfoPtr_inType;

		// Token: 0x04003A69 RID: 14953
		private static readonly IntPtr NativeFieldInfoPtr_outType;

		// Token: 0x04003A6A RID: 14954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TraceLoggingDataType_EventFieldTags_Boolean_0;

		// Token: 0x04003A6B RID: 14955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_TraceLoggingDataType_EventFieldTags_Byte_UInt16_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003A6C RID: 14956
		private static readonly IntPtr NativeMethodInfoPtr_IncrementStructFieldCount_Public_Void_0;

		// Token: 0x04003A6D RID: 14957
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_Int32_Il2CppStructArray_1_Byte_0;
	}
}
