using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004CF RID: 1231
	public sealed class InvokeTypeInfo<ContainerType> : TraceLoggingTypeInfo<ContainerType>
	{
		// Token: 0x0600482E RID: 18478 RVA: 0x0014AE9C File Offset: 0x0014909C
		// Note: this type is marked as 'beforefieldinit'.
		static InvokeTypeInfo()
		{
			Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "InvokeTypeInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContainerType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr);
			InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, "properties");
			InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_accessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, "accessors");
			InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr__ctor_Public_Void_TypeAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, 100673974);
			InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, 100673975);
			InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, 100673976);
			InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, 100673977);
			InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr, 100673978);
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x0014AF94 File Offset: 0x00149194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366256, XrefRangeEnd = 366260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokeTypeInfo(TypeAnalysis typeAnalysis)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokeTypeInfo<ContainerType>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeAnalysis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr__ctor_Public_Void_TypeAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x0014AFE0 File Offset: 0x001491E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366260, XrefRangeEnd = 366263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x0014B044 File Offset: 0x00149244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366263, XrefRangeEnd = 366264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref ContainerType value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<ContainerType>(intPtr4, false, false));
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x0014B0B0 File Offset: 0x001492B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366264, XrefRangeEnd = 366271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetData(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x0014B100 File Offset: 0x00149300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366271, XrefRangeEnd = 366274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteObjectData(TraceLoggingDataCollector collector, Object valueObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeTypeInfo<ContainerType>.NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x0001B569 File Offset: 0x00019769
		public InvokeTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06004835 RID: 18485 RVA: 0x0014B154 File Offset: 0x00149354
		// (set) Token: 0x06004836 RID: 18486 RVA: 0x0001B572 File Offset: 0x00019772
		public unsafe Il2CppReferenceArray<PropertyAnalysis> properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyAnalysis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x0014B184 File Offset: 0x00149384
		// (set) Token: 0x06004838 RID: 18488 RVA: 0x0001B591 File Offset: 0x00019791
		public unsafe Il2CppReferenceArray<PropertyAccessor<ContainerType>> accessors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_accessors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyAccessor<ContainerType>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokeTypeInfo<ContainerType>.NativeFieldInfoPtr_accessors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A6E RID: 14958
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x04003A6F RID: 14959
		private static readonly IntPtr NativeFieldInfoPtr_accessors;

		// Token: 0x04003A70 RID: 14960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TypeAnalysis_0;

		// Token: 0x04003A71 RID: 14961
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003A72 RID: 14962
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0;

		// Token: 0x04003A73 RID: 14963
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0;

		// Token: 0x04003A74 RID: 14964
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectData_Public_Virtual_Void_TraceLoggingDataCollector_Object_0;
	}
}
