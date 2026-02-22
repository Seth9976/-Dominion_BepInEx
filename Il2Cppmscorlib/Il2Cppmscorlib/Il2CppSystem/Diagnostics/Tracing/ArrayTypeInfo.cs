using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C0 RID: 1216
	public sealed class ArrayTypeInfo<ElementType> : TraceLoggingTypeInfo<Il2CppArrayBase<ElementType>>
	{
		// Token: 0x06004797 RID: 18327 RVA: 0x00148C6C File Offset: 0x00146E6C
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayTypeInfo()
		{
			Il2CppClassPointerStore<ArrayTypeInfo<ElementType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ArrayTypeInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ElementType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayTypeInfo<ElementType>>.NativeClassPtr);
			ArrayTypeInfo<ElementType>.NativeFieldInfoPtr_elementInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayTypeInfo<ElementType>>.NativeClassPtr, "elementInfo");
			ArrayTypeInfo<ElementType>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTypeInfo<ElementType>>.NativeClassPtr, 100673907);
			ArrayTypeInfo<ElementType>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppArrayBase_1_ElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTypeInfo<ElementType>>.NativeClassPtr, 100673908);
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x00148D14 File Offset: 0x00146F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365959, XrefRangeEnd = 365962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTypeInfo<ElementType>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x00148D78 File Offset: 0x00146F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365962, XrefRangeEnd = 365968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref Il2CppArrayBase<ElementType> value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayTypeInfo<ElementType>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppArrayBase_1_ElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Il2CppArrayBase<ElementType>(intPtr4));
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x0001B0DE File Offset: 0x000192DE
		public ArrayTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x0600479B RID: 18331 RVA: 0x00148DE4 File Offset: 0x00146FE4
		// (set) Token: 0x0600479C RID: 18332 RVA: 0x0001B0E7 File Offset: 0x000192E7
		public unsafe TraceLoggingTypeInfo<ElementType> elementInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayTypeInfo<ElementType>.NativeFieldInfoPtr_elementInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<ElementType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayTypeInfo<ElementType>.NativeFieldInfoPtr_elementInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039FE RID: 14846
		private static readonly IntPtr NativeFieldInfoPtr_elementInfo;

		// Token: 0x040039FF RID: 14847
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003A00 RID: 14848
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Il2CppArrayBase_1_ElementType_0;
	}
}
