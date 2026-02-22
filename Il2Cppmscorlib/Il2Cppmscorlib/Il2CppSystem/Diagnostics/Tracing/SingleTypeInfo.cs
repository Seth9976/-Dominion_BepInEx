using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004E2 RID: 1250
	public sealed class SingleTypeInfo : TraceLoggingTypeInfo<float>
	{
		// Token: 0x060048AF RID: 18607 RVA: 0x0014D0B0 File Offset: 0x0014B2B0
		// Note: this type is marked as 'beforefieldinit'.
		static SingleTypeInfo()
		{
			Il2CppClassPointerStore<SingleTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "SingleTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleTypeInfo>.NativeClassPtr);
			SingleTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleTypeInfo>.NativeClassPtr, 100674038);
			SingleTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleTypeInfo>.NativeClassPtr, 100674039);
			SingleTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleTypeInfo>.NativeClassPtr, 100674040);
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x0014D11C File Offset: 0x0014B31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366541, XrefRangeEnd = 366547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x0014D180 File Offset: 0x0014B380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366547, XrefRangeEnd = 366549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref float value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x0014D1D0 File Offset: 0x0014B3D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366552, RefRangeEnd = 366554, XrefRangeStart = 366549, XrefRangeEnd = 366552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x0001B7CC File Offset: 0x000199CC
		public SingleTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003ABA RID: 15034
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003ABB RID: 15035
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Single_0;

		// Token: 0x04003ABC RID: 15036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
