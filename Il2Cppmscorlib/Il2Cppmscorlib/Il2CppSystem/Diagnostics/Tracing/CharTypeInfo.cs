using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004E3 RID: 1251
	public sealed class CharTypeInfo : TraceLoggingTypeInfo<char>
	{
		// Token: 0x060048B4 RID: 18612 RVA: 0x0014D20C File Offset: 0x0014B40C
		// Note: this type is marked as 'beforefieldinit'.
		static CharTypeInfo()
		{
			Il2CppClassPointerStore<CharTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "CharTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharTypeInfo>.NativeClassPtr);
			CharTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharTypeInfo>.NativeClassPtr, 100674041);
			CharTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharTypeInfo>.NativeClassPtr, 100674042);
			CharTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharTypeInfo>.NativeClassPtr, 100674043);
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x0014D278 File Offset: 0x0014B478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366554, XrefRangeEnd = 366560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x0014D2DC File Offset: 0x0014B4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366560, XrefRangeEnd = 366562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref char value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x0014D32C File Offset: 0x0014B52C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366565, RefRangeEnd = 366567, XrefRangeStart = 366562, XrefRangeEnd = 366565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x0001B7D5 File Offset: 0x000199D5
		public CharTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003ABD RID: 15037
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003ABE RID: 15038
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Char_0;

		// Token: 0x04003ABF RID: 15039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
