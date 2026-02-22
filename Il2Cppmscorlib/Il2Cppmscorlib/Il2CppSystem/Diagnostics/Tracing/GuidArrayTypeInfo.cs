using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004FC RID: 1276
	public sealed class GuidArrayTypeInfo : TraceLoggingTypeInfo<Il2CppStructArray<Guid>>
	{
		// Token: 0x0600493A RID: 18746 RVA: 0x0014FBE8 File Offset: 0x0014DDE8
		// Note: this type is marked as 'beforefieldinit'.
		static GuidArrayTypeInfo()
		{
			Il2CppClassPointerStore<GuidArrayTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "GuidArrayTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidArrayTypeInfo>.NativeClassPtr);
			GuidArrayTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidArrayTypeInfo>.NativeClassPtr, 100674125);
			GuidArrayTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidArrayTypeInfo>.NativeClassPtr, 100674126);
			GuidArrayTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidArrayTypeInfo>.NativeClassPtr, 100674127);
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x0014FC54 File Offset: 0x0014DE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368633, XrefRangeEnd = 368639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuidArrayTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x0014FCB8 File Offset: 0x0014DEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368639, XrefRangeEnd = 368641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref Il2CppStructArray<Guid> value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GuidArrayTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Il2CppStructArray<Guid>(intPtr4));
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x0014FD24 File Offset: 0x0014DF24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368644, RefRangeEnd = 368646, XrefRangeStart = 368641, XrefRangeEnd = 368644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuidArrayTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidArrayTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuidArrayTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x0001B8B6 File Offset: 0x00019AB6
		public GuidArrayTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B11 RID: 15121
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003B12 RID: 15122
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Guid_0;

		// Token: 0x04003B13 RID: 15123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
