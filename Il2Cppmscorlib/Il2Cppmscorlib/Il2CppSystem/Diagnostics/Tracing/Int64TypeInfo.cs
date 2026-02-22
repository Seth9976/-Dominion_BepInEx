using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004DD RID: 1245
	public sealed class Int64TypeInfo : TraceLoggingTypeInfo<long>
	{
		// Token: 0x06004896 RID: 18582 RVA: 0x0014C9E4 File Offset: 0x0014ABE4
		// Note: this type is marked as 'beforefieldinit'.
		static Int64TypeInfo()
		{
			Il2CppClassPointerStore<Int64TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "Int64TypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int64TypeInfo>.NativeClassPtr);
			Int64TypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int64TypeInfo>.NativeClassPtr, 100674023);
			Int64TypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int64TypeInfo>.NativeClassPtr, 100674024);
			Int64TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int64TypeInfo>.NativeClassPtr, 100674025);
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x0014CA50 File Offset: 0x0014AC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366467, XrefRangeEnd = 366473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64TypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x0014CAB4 File Offset: 0x0014ACB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366473, XrefRangeEnd = 366475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64TypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x0014CB04 File Offset: 0x0014AD04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366478, RefRangeEnd = 366480, XrefRangeStart = 366475, XrefRangeEnd = 366478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int64TypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int64TypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x0001B79F File Offset: 0x0001999F
		public Int64TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AAB RID: 15019
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003AAC RID: 15020
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Int64_0;

		// Token: 0x04003AAD RID: 15021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
