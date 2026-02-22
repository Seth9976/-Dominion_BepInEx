using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000500 RID: 1280
	public sealed class DecimalTypeInfo : TraceLoggingTypeInfo<Decimal>
	{
		// Token: 0x0600494E RID: 18766 RVA: 0x00150174 File Offset: 0x0014E374
		// Note: this type is marked as 'beforefieldinit'.
		static DecimalTypeInfo()
		{
			Il2CppClassPointerStore<DecimalTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "DecimalTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecimalTypeInfo>.NativeClassPtr);
			DecimalTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalTypeInfo>.NativeClassPtr, 100674137);
			DecimalTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalTypeInfo>.NativeClassPtr, 100674138);
			DecimalTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalTypeInfo>.NativeClassPtr, 100674139);
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x001501E0 File Offset: 0x0014E3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368694, XrefRangeEnd = 368700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x00150244 File Offset: 0x0014E444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368700, XrefRangeEnd = 368710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref Decimal value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x00150294 File Offset: 0x0014E494
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368713, RefRangeEnd = 368715, XrefRangeStart = 368710, XrefRangeEnd = 368713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecimalTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecimalTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x0001B8DA File Offset: 0x00019ADA
		public DecimalTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B1D RID: 15133
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003B1E RID: 15134
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Decimal_0;

		// Token: 0x04003B1F RID: 15135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
