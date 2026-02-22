using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004FE RID: 1278
	public sealed class DateTimeOffsetTypeInfo : TraceLoggingTypeInfo<DateTimeOffset>
	{
		// Token: 0x06004944 RID: 18756 RVA: 0x0014FEBC File Offset: 0x0014E0BC
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeOffsetTypeInfo()
		{
			Il2CppClassPointerStore<DateTimeOffsetTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "DateTimeOffsetTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeOffsetTypeInfo>.NativeClassPtr);
			DateTimeOffsetTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffsetTypeInfo>.NativeClassPtr, 100674131);
			DateTimeOffsetTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffsetTypeInfo>.NativeClassPtr, 100674132);
			DateTimeOffsetTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffsetTypeInfo>.NativeClassPtr, 100674133);
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x0014FF28 File Offset: 0x0014E128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368661, XrefRangeEnd = 368673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffsetTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x0014FF8C File Offset: 0x0014E18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368673, XrefRangeEnd = 368678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref DateTimeOffset value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffsetTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x0014FFDC File Offset: 0x0014E1DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368681, RefRangeEnd = 368683, XrefRangeStart = 368678, XrefRangeEnd = 368681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffsetTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeOffsetTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffsetTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x0001B8C8 File Offset: 0x00019AC8
		public DateTimeOffsetTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B17 RID: 15127
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003B18 RID: 15128
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_DateTimeOffset_0;

		// Token: 0x04003B19 RID: 15129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
