using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050A RID: 1290
	public class TraceLoggingTypeInfo : Object
	{
		// Token: 0x06004A78 RID: 19064 RVA: 0x001553A8 File Offset: 0x001535A8
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggingTypeInfo()
		{
			Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TraceLoggingTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr);
			TraceLoggingTypeInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "name");
			TraceLoggingTypeInfo.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "keywords");
			TraceLoggingTypeInfo.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "level");
			TraceLoggingTypeInfo.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "opcode");
			TraceLoggingTypeInfo.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "tags");
			TraceLoggingTypeInfo.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, "dataType");
			TraceLoggingTypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674333);
			TraceLoggingTypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_EventLevel_EventOpcode_EventKeywords_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674334);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674335);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674336);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674337);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674338);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674339);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_get_DataType_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674340);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Abstract_Virtual_New_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674341);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_WriteObjectData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674342);
			TraceLoggingTypeInfo.NativeMethodInfoPtr_GetData_Public_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr, 100674343);
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x0015552C File Offset: 0x0015372C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372393, RefRangeEnd = 372395, XrefRangeStart = 372389, XrefRangeEnd = 372393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingTypeInfo(Type dataType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x00155578 File Offset: 0x00153778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372403, RefRangeEnd = 372405, XrefRangeStart = 372395, XrefRangeEnd = 372403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingTypeInfo(Type dataType, string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opcode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_EventLevel_EventOpcode_EventKeywords_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06004A7B RID: 19067 RVA: 0x00155610 File Offset: 0x00153810
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x00155648 File Offset: 0x00153848
		public unsafe EventLevel Level
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06004A7D RID: 19069 RVA: 0x00155684 File Offset: 0x00153884
		public unsafe EventOpcode Opcode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06004A7E RID: 19070 RVA: 0x001556C0 File Offset: 0x001538C0
		public unsafe EventKeywords Keywords
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06004A7F RID: 19071 RVA: 0x001556FC File Offset: 0x001538FC
		public unsafe EventTags Tags
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06004A80 RID: 19072 RVA: 0x00155738 File Offset: 0x00153938
		public unsafe Type DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo.NativeMethodInfoPtr_get_DataType_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x00155778 File Offset: 0x00153978
		[CallerCount(0)]
		public unsafe virtual void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceLoggingTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Abstract_Virtual_New_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x001557E8 File Offset: 0x001539E8
		[CallerCount(0)]
		public unsafe virtual void WriteObjectData(TraceLoggingDataCollector collector, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceLoggingTypeInfo.NativeMethodInfoPtr_WriteObjectData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x00155848 File Offset: 0x00153A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23543, RefRangeEnd = 23544, XrefRangeStart = 23543, XrefRangeEnd = 23544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetData(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceLoggingTypeInfo.NativeMethodInfoPtr_GetData_Public_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x0001BEF9 File Offset: 0x0001A0F9
		public TraceLoggingTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x001558A4 File Offset: 0x00153AA4
		// (set) Token: 0x06004A86 RID: 19078 RVA: 0x0001BF02 File Offset: 0x0001A102
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06004A87 RID: 19079 RVA: 0x001558CC File Offset: 0x00153ACC
		// (set) Token: 0x06004A88 RID: 19080 RVA: 0x0001BF21 File Offset: 0x0001A121
		public unsafe EventKeywords keywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_keywords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_keywords)) = value;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06004A89 RID: 19081 RVA: 0x001558F4 File Offset: 0x00153AF4
		// (set) Token: 0x06004A8A RID: 19082 RVA: 0x0001BF3C File Offset: 0x0001A13C
		public unsafe EventLevel level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06004A8B RID: 19083 RVA: 0x0015591C File Offset: 0x00153B1C
		// (set) Token: 0x06004A8C RID: 19084 RVA: 0x0001BF57 File Offset: 0x0001A157
		public unsafe EventOpcode opcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_opcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_opcode)) = value;
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06004A8D RID: 19085 RVA: 0x00155944 File Offset: 0x00153B44
		// (set) Token: 0x06004A8E RID: 19086 RVA: 0x0001BF72 File Offset: 0x0001A172
		public unsafe EventTags tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_tags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_tags)) = value;
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06004A8F RID: 19087 RVA: 0x0015596C File Offset: 0x00153B6C
		// (set) Token: 0x06004A90 RID: 19088 RVA: 0x0001BF8D File Offset: 0x0001A18D
		public unsafe Type dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceLoggingTypeInfo.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C25 RID: 15397
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003C26 RID: 15398
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04003C27 RID: 15399
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003C28 RID: 15400
		private static readonly IntPtr NativeFieldInfoPtr_opcode;

		// Token: 0x04003C29 RID: 15401
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003C2A RID: 15402
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04003C2B RID: 15403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x04003C2C RID: 15404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_EventLevel_EventOpcode_EventKeywords_EventTags_0;

		// Token: 0x04003C2D RID: 15405
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04003C2E RID: 15406
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_EventLevel_0;

		// Token: 0x04003C2F RID: 15407
		private static readonly IntPtr NativeMethodInfoPtr_get_Opcode_Public_get_EventOpcode_0;

		// Token: 0x04003C30 RID: 15408
		private static readonly IntPtr NativeMethodInfoPtr_get_Keywords_Public_get_EventKeywords_0;

		// Token: 0x04003C31 RID: 15409
		private static readonly IntPtr NativeMethodInfoPtr_get_Tags_Public_get_EventTags_0;

		// Token: 0x04003C32 RID: 15410
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Internal_get_Type_0;

		// Token: 0x04003C33 RID: 15411
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Abstract_Virtual_New_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003C34 RID: 15412
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_Object_0;

		// Token: 0x04003C35 RID: 15413
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_New_Object_Object_0;
	}
}
