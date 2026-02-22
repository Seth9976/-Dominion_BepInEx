using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000502 RID: 1282
	public sealed class NullableTypeInfo<T> : TraceLoggingTypeInfo<Nullable<T>> where T : new()
	{
		// Token: 0x0600495B RID: 18779 RVA: 0x001504BC File Offset: 0x0014E6BC
		// Note: this type is marked as 'beforefieldinit'.
		static NullableTypeInfo()
		{
			Il2CppClassPointerStore<NullableTypeInfo<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "NullableTypeInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableTypeInfo<T>>.NativeClassPtr);
			NullableTypeInfo<T>.NativeFieldInfoPtr_valueInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableTypeInfo<T>>.NativeClassPtr, "valueInfo");
			NullableTypeInfo<T>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableTypeInfo<T>>.NativeClassPtr, 100674142);
			NullableTypeInfo<T>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableTypeInfo<T>>.NativeClassPtr, 100674143);
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x00150564 File Offset: 0x0014E764
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableTypeInfo<T>.NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x001505C8 File Offset: 0x0014E7C8
		[CallerCount(0)]
		public unsafe override void WriteData(TraceLoggingDataCollector collector, ref Nullable<T> value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableTypeInfo<T>.NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Nullable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x0001B92A File Offset: 0x00019B2A
		public NullableTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x00150620 File Offset: 0x0014E820
		// (set) Token: 0x06004960 RID: 18784 RVA: 0x0001B933 File Offset: 0x00019B33
		public unsafe TraceLoggingTypeInfo<T> valueInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableTypeInfo<T>.NativeFieldInfoPtr_valueInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableTypeInfo<T>.NativeFieldInfoPtr_valueInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B24 RID: 15140
		private static readonly IntPtr NativeFieldInfoPtr_valueInfo;

		// Token: 0x04003B25 RID: 15141
		private static readonly IntPtr NativeMethodInfoPtr_WriteMetadata_Public_Virtual_Void_TraceLoggingMetadataCollector_String_EventFieldFormat_0;

		// Token: 0x04003B26 RID: 15142
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_Void_TraceLoggingDataCollector_byref_Nullable_1_T_0;
	}
}
