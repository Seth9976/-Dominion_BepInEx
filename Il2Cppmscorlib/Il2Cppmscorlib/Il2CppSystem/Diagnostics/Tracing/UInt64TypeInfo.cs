using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004DE RID: 1246
	public sealed class UInt64TypeInfo : TraceLoggingTypeInfo<ulong>
	{
		// Token: 0x0600489B RID: 18587 RVA: 0x0014CB40 File Offset: 0x0014AD40
		// Note: this type is marked as 'beforefieldinit'.
		static UInt64TypeInfo()
		{
			Il2CppClassPointerStore<UInt64TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "UInt64TypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UInt64TypeInfo>.NativeClassPtr);
			UInt64TypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64TypeInfo>.NativeClassPtr, 100674026);
			UInt64TypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64TypeInfo>.NativeClassPtr, 100674027);
			UInt64TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt64TypeInfo>.NativeClassPtr, 100674028);
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x0014CBAC File Offset: 0x0014ADAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366480, XrefRangeEnd = 366486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64TypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x0014CC10 File Offset: 0x0014AE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366486, XrefRangeEnd = 366490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref ulong value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64TypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x0014CC60 File Offset: 0x0014AE60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366493, RefRangeEnd = 366495, XrefRangeStart = 366490, XrefRangeEnd = 366493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UInt64TypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UInt64TypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt64TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x0001B7A8 File Offset: 0x000199A8
		public UInt64TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AAE RID: 15022
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003AAF RID: 15023
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_UInt64_0;

		// Token: 0x04003AB0 RID: 15024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
