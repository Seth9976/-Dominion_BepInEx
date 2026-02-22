using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004E9 RID: 1257
	public sealed class Int32ArrayTypeInfo : TraceLoggingTypeInfo<Il2CppStructArray<int>>
	{
		// Token: 0x060048D2 RID: 18642 RVA: 0x0014DAC0 File Offset: 0x0014BCC0
		// Note: this type is marked as 'beforefieldinit'.
		static Int32ArrayTypeInfo()
		{
			Il2CppClassPointerStore<Int32ArrayTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "Int32ArrayTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int32ArrayTypeInfo>.NativeClassPtr);
			Int32ArrayTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int32ArrayTypeInfo>.NativeClassPtr, 100674059);
			Int32ArrayTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int32ArrayTypeInfo>.NativeClassPtr, 100674060);
			Int32ArrayTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int32ArrayTypeInfo>.NativeClassPtr, 100674061);
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x0014DB2C File Offset: 0x0014BD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366642, XrefRangeEnd = 366648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int32ArrayTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x0014DB90 File Offset: 0x0014BD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366648, XrefRangeEnd = 366650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref Il2CppStructArray<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Int32ArrayTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x0014DBFC File Offset: 0x0014BDFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366653, RefRangeEnd = 366655, XrefRangeStart = 366650, XrefRangeEnd = 366653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int32ArrayTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int32ArrayTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int32ArrayTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x0001B80B File Offset: 0x00019A0B
		public Int32ArrayTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003ACF RID: 15055
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003AD0 RID: 15056
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003AD1 RID: 15057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
