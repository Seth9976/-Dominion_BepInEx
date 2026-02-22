using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004FD RID: 1277
	public sealed class DateTimeTypeInfo : TraceLoggingTypeInfo<DateTime>
	{
		// Token: 0x0600493F RID: 18751 RVA: 0x0014FD60 File Offset: 0x0014DF60
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeTypeInfo()
		{
			Il2CppClassPointerStore<DateTimeTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "DateTimeTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeTypeInfo>.NativeClassPtr);
			DateTimeTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeTypeInfo>.NativeClassPtr, 100674128);
			DateTimeTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeTypeInfo>.NativeClassPtr, 100674129);
			DateTimeTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeTypeInfo>.NativeClassPtr, 100674130);
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x0014FDCC File Offset: 0x0014DFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368646, XrefRangeEnd = 368652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x0014FE30 File Offset: 0x0014E030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368652, XrefRangeEnd = 368656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref DateTime value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x0014FE80 File Offset: 0x0014E080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368659, RefRangeEnd = 368661, XrefRangeStart = 368656, XrefRangeEnd = 368659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x0001B8BF File Offset: 0x00019ABF
		public DateTimeTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B14 RID: 15124
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003B15 RID: 15125
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_DateTime_0;

		// Token: 0x04003B16 RID: 15126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
