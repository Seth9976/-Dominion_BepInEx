using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004F9 RID: 1273
	public sealed class EnumUInt64TypeInfo<EnumType> : TraceLoggingTypeInfo<EnumType>
	{
		// Token: 0x06004929 RID: 18729 RVA: 0x0014F6A0 File Offset: 0x0014D8A0
		// Note: this type is marked as 'beforefieldinit'.
		static EnumUInt64TypeInfo()
		{
			Il2CppClassPointerStore<EnumUInt64TypeInfo<EnumType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EnumUInt64TypeInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EnumType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumUInt64TypeInfo<EnumType>>.NativeClassPtr);
			EnumUInt64TypeInfo<EnumType>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUInt64TypeInfo<EnumType>>.NativeClassPtr, 100674114);
			EnumUInt64TypeInfo<EnumType>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_EnumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUInt64TypeInfo<EnumType>>.NativeClassPtr, 100674115);
			EnumUInt64TypeInfo<EnumType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUInt64TypeInfo<EnumType>>.NativeClassPtr, 100674116);
			EnumUInt64TypeInfo<EnumType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUInt64TypeInfo<EnumType>>.NativeClassPtr, 100674117);
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x0014F75C File Offset: 0x0014D95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368453, XrefRangeEnd = 368549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUInt64TypeInfo<EnumType>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x0014F7C0 File Offset: 0x0014D9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368549, XrefRangeEnd = 368605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref EnumType value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumUInt64TypeInfo<EnumType>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_EnumType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<EnumType>(intPtr4, false, false));
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x0014F82C File Offset: 0x0014DA2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23543, RefRangeEnd = 23544, XrefRangeStart = 23543, XrefRangeEnd = 23544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetData(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUInt64TypeInfo<EnumType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x0014F87C File Offset: 0x0014DA7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93582, RefRangeEnd = 93584, XrefRangeStart = 93582, XrefRangeEnd = 93584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumUInt64TypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumUInt64TypeInfo<EnumType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUInt64TypeInfo<EnumType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x0001B89B File Offset: 0x00019A9B
		public EnumUInt64TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B06 RID: 15110
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003B07 RID: 15111
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_EnumType_0;

		// Token: 0x04003B08 RID: 15112
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0;

		// Token: 0x04003B09 RID: 15113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
