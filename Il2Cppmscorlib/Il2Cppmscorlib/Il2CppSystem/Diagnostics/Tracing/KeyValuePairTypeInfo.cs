using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000501 RID: 1281
	public sealed class KeyValuePairTypeInfo<K, V> : TraceLoggingTypeInfo<KeyValuePair<K, V>>
	{
		// Token: 0x06004953 RID: 18771 RVA: 0x001502D0 File Offset: 0x0014E4D0
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePairTypeInfo()
		{
			Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "KeyValuePairTypeInfo`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr);
			KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_keyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr, "keyInfo");
			KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_valueInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr, "valueInfo");
			KeyValuePairTypeInfo<K, V>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr, 100674140);
			KeyValuePairTypeInfo<K, V>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairTypeInfo<K, V>>.NativeClassPtr, 100674141);
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x001503A0 File Offset: 0x0014E5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368715, XrefRangeEnd = 368730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePairTypeInfo<K, V>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x00150404 File Offset: 0x0014E604
		[CallerCount(0)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref KeyValuePair<K, V> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePairTypeInfo<K, V>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x0001B8E3 File Offset: 0x00019AE3
		public KeyValuePairTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x0015045C File Offset: 0x0014E65C
		// (set) Token: 0x06004958 RID: 18776 RVA: 0x0001B8EC File Offset: 0x00019AEC
		public unsafe TraceLoggingTypeInfo<K> keyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_keyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<K>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_keyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06004959 RID: 18777 RVA: 0x0015048C File Offset: 0x0014E68C
		// (set) Token: 0x0600495A RID: 18778 RVA: 0x0001B90B File Offset: 0x00019B0B
		public unsafe TraceLoggingTypeInfo<V> valueInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_valueInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<V>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePairTypeInfo<K, V>.NativeFieldInfoPtr_valueInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B20 RID: 15136
		private static readonly IntPtr NativeFieldInfoPtr_keyInfo;

		// Token: 0x04003B21 RID: 15137
		private static readonly IntPtr NativeFieldInfoPtr_valueInfo;

		// Token: 0x04003B22 RID: 15138
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003B23 RID: 15139
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_KeyValuePair_2_K_V_0;
	}
}
