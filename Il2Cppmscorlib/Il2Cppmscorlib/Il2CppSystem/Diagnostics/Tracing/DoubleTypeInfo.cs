using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004E1 RID: 1249
	public sealed class DoubleTypeInfo : TraceLoggingTypeInfo<double>
	{
		// Token: 0x060048AA RID: 18602 RVA: 0x0014CF54 File Offset: 0x0014B154
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleTypeInfo()
		{
			Il2CppClassPointerStore<DoubleTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "DoubleTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleTypeInfo>.NativeClassPtr);
			DoubleTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleTypeInfo>.NativeClassPtr, 100674035);
			DoubleTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleTypeInfo>.NativeClassPtr, 100674036);
			DoubleTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleTypeInfo>.NativeClassPtr, 100674037);
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x0014CFC0 File Offset: 0x0014B1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366528, XrefRangeEnd = 366534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x0014D024 File Offset: 0x0014B224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366534, XrefRangeEnd = 366536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref double value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x0014D074 File Offset: 0x0014B274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366539, RefRangeEnd = 366541, XrefRangeStart = 366536, XrefRangeEnd = 366539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x0001B7C3 File Offset: 0x000199C3
		public DoubleTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AB7 RID: 15031
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003AB8 RID: 15032
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Double_0;

		// Token: 0x04003AB9 RID: 15033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
