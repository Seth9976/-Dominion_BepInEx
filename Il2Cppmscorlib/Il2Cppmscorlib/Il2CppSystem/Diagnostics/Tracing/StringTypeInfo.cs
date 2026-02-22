using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004FA RID: 1274
	public sealed class StringTypeInfo : TraceLoggingTypeInfo<string>
	{
		// Token: 0x0600492F RID: 18735 RVA: 0x0014F8B8 File Offset: 0x0014DAB8
		// Note: this type is marked as 'beforefieldinit'.
		static StringTypeInfo()
		{
			Il2CppClassPointerStore<StringTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "StringTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringTypeInfo>.NativeClassPtr);
			StringTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTypeInfo>.NativeClassPtr, 100674118);
			StringTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTypeInfo>.NativeClassPtr, 100674119);
			StringTypeInfo.NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTypeInfo>.NativeClassPtr, 100674120);
			StringTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTypeInfo>.NativeClassPtr, 100674121);
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x0014F938 File Offset: 0x0014DB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368605, XrefRangeEnd = 368611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x0014F99C File Offset: 0x0014DB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368611, XrefRangeEnd = 368613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StringTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x0014FA00 File Offset: 0x0014DC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368613, XrefRangeEnd = 368616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetData(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTypeInfo.NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x0014FA50 File Offset: 0x0014DC50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368619, RefRangeEnd = 368621, XrefRangeStart = 368616, XrefRangeEnd = 368619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x0001B8A4 File Offset: 0x00019AA4
		public StringTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B0A RID: 15114
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003B0B RID: 15115
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_String_0;

		// Token: 0x04003B0C RID: 15116
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Object_Object_0;

		// Token: 0x04003B0D RID: 15117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
