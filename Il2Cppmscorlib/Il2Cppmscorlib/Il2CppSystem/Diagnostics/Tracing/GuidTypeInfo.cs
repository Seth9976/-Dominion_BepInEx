using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004FB RID: 1275
	public sealed class GuidTypeInfo : TraceLoggingTypeInfo<Guid>
	{
		// Token: 0x06004935 RID: 18741 RVA: 0x0014FA8C File Offset: 0x0014DC8C
		// Note: this type is marked as 'beforefieldinit'.
		static GuidTypeInfo()
		{
			Il2CppClassPointerStore<GuidTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "GuidTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidTypeInfo>.NativeClassPtr);
			GuidTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidTypeInfo>.NativeClassPtr, 100674122);
			GuidTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidTypeInfo>.NativeClassPtr, 100674123);
			GuidTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidTypeInfo>.NativeClassPtr, 100674124);
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x0014FAF8 File Offset: 0x0014DCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368621, XrefRangeEnd = 368627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuidTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x0014FB5C File Offset: 0x0014DD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368627, XrefRangeEnd = 368628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref Guid value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuidTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x0014FBAC File Offset: 0x0014DDAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368631, RefRangeEnd = 368633, XrefRangeStart = 368628, XrefRangeEnd = 368631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuidTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuidTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x0001B8AD File Offset: 0x00019AAD
		public GuidTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B0E RID: 15118
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003B0F RID: 15119
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Guid_0;

		// Token: 0x04003B10 RID: 15120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
