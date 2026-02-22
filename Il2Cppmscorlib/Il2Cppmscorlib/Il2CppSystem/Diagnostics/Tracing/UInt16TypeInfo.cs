using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004DA RID: 1242
	public sealed class UInt16TypeInfo : TraceLoggingTypeInfo<ushort>
	{
		// Token: 0x06004887 RID: 18567 RVA: 0x0014C5D0 File Offset: 0x0014A7D0
		// Note: this type is marked as 'beforefieldinit'.
		static UInt16TypeInfo()
		{
			Il2CppClassPointerStore<UInt16TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "UInt16TypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UInt16TypeInfo>.NativeClassPtr);
			UInt16TypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt16TypeInfo>.NativeClassPtr, 100674014);
			UInt16TypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt16TypeInfo>.NativeClassPtr, 100674015);
			UInt16TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UInt16TypeInfo>.NativeClassPtr, 100674016);
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x0014C63C File Offset: 0x0014A83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366424, XrefRangeEnd = 366430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt16TypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x0014C6A0 File Offset: 0x0014A8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366430, XrefRangeEnd = 366434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref ushort value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt16TypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x0014C6F0 File Offset: 0x0014A8F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366437, RefRangeEnd = 366439, XrefRangeStart = 366434, XrefRangeEnd = 366437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UInt16TypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UInt16TypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UInt16TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x0001B784 File Offset: 0x00019984
		public UInt16TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AA2 RID: 15010
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003AA3 RID: 15011
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_UInt16_0;

		// Token: 0x04003AA4 RID: 15012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
