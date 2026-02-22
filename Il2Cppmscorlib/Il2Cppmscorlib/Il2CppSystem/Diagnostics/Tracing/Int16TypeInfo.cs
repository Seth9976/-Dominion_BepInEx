using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D9 RID: 1241
	public sealed class Int16TypeInfo : TraceLoggingTypeInfo<short>
	{
		// Token: 0x06004882 RID: 18562 RVA: 0x0014C474 File Offset: 0x0014A674
		// Note: this type is marked as 'beforefieldinit'.
		static Int16TypeInfo()
		{
			Il2CppClassPointerStore<Int16TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "Int16TypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int16TypeInfo>.NativeClassPtr);
			Int16TypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int16TypeInfo>.NativeClassPtr, 100674011);
			Int16TypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int16TypeInfo>.NativeClassPtr, 100674012);
			Int16TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int16TypeInfo>.NativeClassPtr, 100674013);
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x0014C4E0 File Offset: 0x0014A6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366411, XrefRangeEnd = 366417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int16TypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x0014C544 File Offset: 0x0014A744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366417, XrefRangeEnd = 366419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref short value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int16TypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x0014C594 File Offset: 0x0014A794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366422, RefRangeEnd = 366424, XrefRangeStart = 366419, XrefRangeEnd = 366422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int16TypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int16TypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int16TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x0001B77B File Offset: 0x0001997B
		public Int16TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003A9F RID: 15007
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003AA0 RID: 15008
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Int16_0;

		// Token: 0x04003AA1 RID: 15009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
