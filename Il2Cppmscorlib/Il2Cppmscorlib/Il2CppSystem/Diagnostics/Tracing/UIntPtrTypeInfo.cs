using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004E0 RID: 1248
	public sealed class UIntPtrTypeInfo : TraceLoggingTypeInfo<UIntPtr>
	{
		// Token: 0x060048A5 RID: 18597 RVA: 0x0014CDF8 File Offset: 0x0014AFF8
		// Note: this type is marked as 'beforefieldinit'.
		static UIntPtrTypeInfo()
		{
			Il2CppClassPointerStore<UIntPtrTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "UIntPtrTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIntPtrTypeInfo>.NativeClassPtr);
			UIntPtrTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtrTypeInfo>.NativeClassPtr, 100674032);
			UIntPtrTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtrTypeInfo>.NativeClassPtr, 100674033);
			UIntPtrTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtrTypeInfo>.NativeClassPtr, 100674034);
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x0014CE64 File Offset: 0x0014B064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366509, XrefRangeEnd = 366516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtrTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x0014CEC8 File Offset: 0x0014B0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366516, XrefRangeEnd = 366523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref UIntPtr value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtrTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_UIntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x0014CF18 File Offset: 0x0014B118
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366526, RefRangeEnd = 366528, XrefRangeStart = 366523, XrefRangeEnd = 366526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIntPtrTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIntPtrTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtrTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x0001B7BA File Offset: 0x000199BA
		public UIntPtrTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AB4 RID: 15028
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003AB5 RID: 15029
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_UIntPtr_0;

		// Token: 0x04003AB6 RID: 15030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
