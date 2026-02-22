using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D8 RID: 1240
	public sealed class SByteTypeInfo : TraceLoggingTypeInfo<sbyte>
	{
		// Token: 0x0600487D RID: 18557 RVA: 0x0014C318 File Offset: 0x0014A518
		// Note: this type is marked as 'beforefieldinit'.
		static SByteTypeInfo()
		{
			Il2CppClassPointerStore<SByteTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "SByteTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SByteTypeInfo>.NativeClassPtr);
			SByteTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteTypeInfo>.NativeClassPtr, 100674008);
			SByteTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteTypeInfo>.NativeClassPtr, 100674009);
			SByteTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteTypeInfo>.NativeClassPtr, 100674010);
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x0014C384 File Offset: 0x0014A584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366398, XrefRangeEnd = 366404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SByteTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x0014C3E8 File Offset: 0x0014A5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366404, XrefRangeEnd = 366406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref sbyte value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SByteTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x0014C438 File Offset: 0x0014A638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366409, RefRangeEnd = 366411, XrefRangeStart = 366406, XrefRangeEnd = 366409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SByteTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SByteTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SByteTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x0001B772 File Offset: 0x00019972
		public SByteTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003A9C RID: 15004
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003A9D RID: 15005
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_SByte_0;

		// Token: 0x04003A9E RID: 15006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
