using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C6 RID: 1222
	public sealed class EnumerableTypeInfo<IterableType, ElementType> : TraceLoggingTypeInfo<IterableType>
	{
		// Token: 0x060047DC RID: 18396 RVA: 0x00149C90 File Offset: 0x00147E90
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerableTypeInfo()
		{
			Il2CppClassPointerStore<EnumerableTypeInfo<IterableType, ElementType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EnumerableTypeInfo`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IterableType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ElementType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableTypeInfo<IterableType, ElementType>>.NativeClassPtr);
			EnumerableTypeInfo<IterableType, ElementType>.NativeFieldInfoPtr_elementInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableTypeInfo<IterableType, ElementType>>.NativeClassPtr, "elementInfo");
			EnumerableTypeInfo<IterableType, ElementType>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableTypeInfo<IterableType, ElementType>>.NativeClassPtr, 100673936);
			EnumerableTypeInfo<IterableType, ElementType>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_IterableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableTypeInfo<IterableType, ElementType>>.NativeClassPtr, 100673937);
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x00149D4C File Offset: 0x00147F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableTypeInfo<IterableType, ElementType>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x00149DB0 File Offset: 0x00147FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366108, XrefRangeEnd = 366126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref IterableType value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumerableTypeInfo<IterableType, ElementType>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_IterableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<IterableType>(intPtr4, false, false));
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x0001B2FA File Offset: 0x000194FA
		public EnumerableTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060047E0 RID: 18400 RVA: 0x00149E1C File Offset: 0x0014801C
		// (set) Token: 0x060047E1 RID: 18401 RVA: 0x0001B303 File Offset: 0x00019503
		public unsafe TraceLoggingTypeInfo<ElementType> elementInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableTypeInfo<IterableType, ElementType>.NativeFieldInfoPtr_elementInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<ElementType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableTypeInfo<IterableType, ElementType>.NativeFieldInfoPtr_elementInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A26 RID: 14886
		private static readonly IntPtr NativeFieldInfoPtr_elementInfo;

		// Token: 0x04003A27 RID: 14887
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003A28 RID: 14888
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_IterableType_0;
	}
}
