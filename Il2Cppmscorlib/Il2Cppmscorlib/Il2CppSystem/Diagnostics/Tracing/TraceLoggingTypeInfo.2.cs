using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200050B RID: 1291
	public class TraceLoggingTypeInfo<DataType> : TraceLoggingTypeInfo
	{
		// Token: 0x06004A91 RID: 19089 RVA: 0x0015599C File Offset: 0x00153B9C
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggingTypeInfo()
		{
			Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TraceLoggingTypeInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DataType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr);
			TraceLoggingTypeInfo<DataType>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, "instance");
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674344);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr__ctor_Protected_Void_String_EventLevel_EventOpcode_EventKeywords_EventTags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674345);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_get_Instance_Public_Static_get_TraceLoggingTypeInfo_1_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674346);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_WriteData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674347);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674348);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_GetInstance_Internal_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674349);
			TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_InitInstance_Private_Static_TraceLoggingTypeInfo_1_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr, 100674350);
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x00155AA8 File Offset: 0x00153CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372405, XrefRangeEnd = 372411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x00155AE4 File Offset: 0x00153CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372411, XrefRangeEnd = 372416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingTypeInfo(string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingTypeInfo<DataType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opcode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr__ctor_Protected_Void_String_EventLevel_EventOpcode_EventKeywords_EventTags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06004A94 RID: 19092 RVA: 0x00155B68 File Offset: 0x00153D68
		public unsafe static TraceLoggingTypeInfo<DataType> Instance
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 372421, RefRangeEnd = 372424, XrefRangeStart = 372416, XrefRangeEnd = 372421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_get_Instance_Public_Static_get_TraceLoggingTypeInfo_1_DataType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<DataType>>(intPtr3) : null;
			}
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x00155B9C File Offset: 0x00153D9C
		[CallerCount(0)]
		public unsafe virtual void WriteData(TraceLoggingDataCollector collector, ref DataType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_WriteData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_DataType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<DataType>(intPtr4, false, false));
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x00155C14 File Offset: 0x00153E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372424, XrefRangeEnd = 372427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteObjectData(TraceLoggingDataCollector collector, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x00155C74 File Offset: 0x00153E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372427, XrefRangeEnd = 372444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingTypeInfo<DataType> GetInstance(List<Type> recursionCheck)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recursionCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_GetInstance_Internal_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<DataType>>(intPtr3) : null;
			}
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x00155CB8 File Offset: 0x00153EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372444, XrefRangeEnd = 372464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingTypeInfo<DataType> InitInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingTypeInfo<DataType>.NativeMethodInfoPtr_InitInstance_Private_Static_TraceLoggingTypeInfo_1_DataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<DataType>>(intPtr3) : null;
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x0001BFAC File Offset: 0x0001A1AC
		public TraceLoggingTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06004A9A RID: 19098 RVA: 0x00155CEC File Offset: 0x00153EEC
		// (set) Token: 0x06004A9B RID: 19099 RVA: 0x0001BFB5 File Offset: 0x0001A1B5
		public unsafe static TraceLoggingTypeInfo<DataType> instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TraceLoggingTypeInfo<DataType>.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<DataType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceLoggingTypeInfo<DataType>.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C36 RID: 15414
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04003C37 RID: 15415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003C38 RID: 15416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_EventLevel_EventOpcode_EventKeywords_EventTags_0;

		// Token: 0x04003C39 RID: 15417
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TraceLoggingTypeInfo_1_DataType_0;

		// Token: 0x04003C3A RID: 15418
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Abstract_Virtual_New_Void_TraceLoggingDataCollector_byref_DataType_0;

		// Token: 0x04003C3B RID: 15419
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0;

		// Token: 0x04003C3C RID: 15420
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Internal_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0;

		// Token: 0x04003C3D RID: 15421
		private static readonly IntPtr NativeMethodInfoPtr_InitInstance_Private_Static_TraceLoggingTypeInfo_1_DataType_0;
	}
}
