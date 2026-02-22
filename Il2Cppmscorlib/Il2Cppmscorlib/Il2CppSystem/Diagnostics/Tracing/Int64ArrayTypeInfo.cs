using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004EB RID: 1259
	public sealed class Int64ArrayTypeInfo : TraceLoggingTypeInfo<Il2CppStructArray<long>>
	{
		// Token: 0x060048DC RID: 18652 RVA: 0x0014DDB0 File Offset: 0x0014BFB0
		// Note: this type is marked as 'beforefieldinit'.
		static Int64ArrayTypeInfo()
		{
			Il2CppClassPointerStore<Int64ArrayTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "Int64ArrayTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int64ArrayTypeInfo>.NativeClassPtr);
			Int64ArrayTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int64ArrayTypeInfo>.NativeClassPtr, 100674065);
			Int64ArrayTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int64ArrayTypeInfo>.NativeClassPtr, 100674066);
			Int64ArrayTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int64ArrayTypeInfo>.NativeClassPtr, 100674067);
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x0014DE1C File Offset: 0x0014C01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366673, XrefRangeEnd = 366679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64ArrayTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x0014DE80 File Offset: 0x0014C080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366679, XrefRangeEnd = 366681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref Il2CppStructArray<long> value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Int64ArrayTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Il2CppStructArray<long>(intPtr4));
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x0014DEEC File Offset: 0x0014C0EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366684, RefRangeEnd = 366686, XrefRangeStart = 366681, XrefRangeEnd = 366684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int64ArrayTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int64ArrayTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64ArrayTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x0001B81D File Offset: 0x00019A1D
		public Int64ArrayTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AD5 RID: 15061
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003AD6 RID: 15062
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Int64_0;

		// Token: 0x04003AD7 RID: 15063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
