using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004FF RID: 1279
	public sealed class TimeSpanTypeInfo : TraceLoggingTypeInfo<TimeSpan>
	{
		// Token: 0x06004949 RID: 18761 RVA: 0x00150018 File Offset: 0x0014E218
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanTypeInfo()
		{
			Il2CppClassPointerStore<TimeSpanTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TimeSpanTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanTypeInfo>.NativeClassPtr);
			TimeSpanTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanTypeInfo>.NativeClassPtr, 100674134);
			TimeSpanTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanTypeInfo>.NativeClassPtr, 100674135);
			TimeSpanTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanTypeInfo>.NativeClassPtr, 100674136);
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00150084 File Offset: 0x0014E284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368683, XrefRangeEnd = 368689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x001500E8 File Offset: 0x0014E2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref TimeSpan value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x00150138 File Offset: 0x0014E338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368692, RefRangeEnd = 368694, XrefRangeStart = 368689, XrefRangeEnd = 368692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpanTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x0001B8D1 File Offset: 0x00019AD1
		public TimeSpanTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B1A RID: 15130
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003B1B RID: 15131
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_TimeSpan_0;

		// Token: 0x04003B1C RID: 15132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
