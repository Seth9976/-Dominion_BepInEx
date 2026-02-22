using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004F1 RID: 1265
	public sealed class SingleArrayTypeInfo : TraceLoggingTypeInfo<Il2CppStructArray<float>>
	{
		// Token: 0x060048FA RID: 18682 RVA: 0x0014E680 File Offset: 0x0014C880
		// Note: this type is marked as 'beforefieldinit'.
		static SingleArrayTypeInfo()
		{
			Il2CppClassPointerStore<SingleArrayTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "SingleArrayTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleArrayTypeInfo>.NativeClassPtr);
			SingleArrayTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleArrayTypeInfo>.NativeClassPtr, 100674083);
			SingleArrayTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleArrayTypeInfo>.NativeClassPtr, 100674084);
			SingleArrayTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleArrayTypeInfo>.NativeClassPtr, 100674085);
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x0014E6EC File Offset: 0x0014C8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366766, XrefRangeEnd = 366772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleArrayTypeInfo.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x0014E750 File Offset: 0x0014C950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366772, XrefRangeEnd = 366774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref Il2CppStructArray<float> value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SingleArrayTypeInfo.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x0014E7BC File Offset: 0x0014C9BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366777, RefRangeEnd = 366779, XrefRangeStart = 366774, XrefRangeEnd = 366777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleArrayTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleArrayTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleArrayTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x0001B853 File Offset: 0x00019A53
		public SingleArrayTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AE7 RID: 15079
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003AE8 RID: 15080
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppStructArray_1_Single_0;

		// Token: 0x04003AE9 RID: 15081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
