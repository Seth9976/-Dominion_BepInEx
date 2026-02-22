using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004E5 RID: 1253
	public sealed class ByteArrayTypeInfo : TraceLoggingTypeInfo<Il2CppStructArray<byte>>
	{
		// Token: 0x060048BE RID: 18622 RVA: 0x0014D4E0 File Offset: 0x0014B6E0
		// Note: this type is marked as 'beforefieldinit'.
		static ByteArrayTypeInfo()
		{
			Il2CppClassPointerStore<ByteArrayTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ByteArrayTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteArrayTypeInfo>.NativeClassPtr);
			ByteArrayTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteArrayTypeInfo>.NativeClassPtr, 100674047);
			ByteArrayTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteArrayTypeInfo>.NativeClassPtr, 100674048);
			ByteArrayTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteArrayTypeInfo>.NativeClassPtr, 100674049);
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x0014D54C File Offset: 0x0014B74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366580, XrefRangeEnd = 366591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteArrayTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x0014D5B0 File Offset: 0x0014B7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366591, XrefRangeEnd = 366593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref Il2CppStructArray<byte> value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ByteArrayTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x0014D61C File Offset: 0x0014B81C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366596, RefRangeEnd = 366598, XrefRangeStart = 366593, XrefRangeEnd = 366596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteArrayTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteArrayTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteArrayTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x0001B7E7 File Offset: 0x000199E7
		public ByteArrayTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AC3 RID: 15043
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003AC4 RID: 15044
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003AC5 RID: 15045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
