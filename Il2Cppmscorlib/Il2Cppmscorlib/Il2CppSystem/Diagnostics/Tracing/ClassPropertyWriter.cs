using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004D3 RID: 1235
	public class ClassPropertyWriter<ContainerType, ValueType> : PropertyAccessor<ContainerType>
	{
		// Token: 0x06004859 RID: 18521 RVA: 0x0014B9DC File Offset: 0x00149BDC
		// Note: this type is marked as 'beforefieldinit'.
		static ClassPropertyWriter()
		{
			Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ClassPropertyWriter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContainerType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr);
			ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_valueTypeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, "valueTypeInfo");
			ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, "getter");
			ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, 100673992);
			ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, 100673993);
			ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, 100673994);
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x0014BAC0 File Offset: 0x00149CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366353, XrefRangeEnd = 366366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClassPropertyWriter(PropertyAnalysis property)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x0014BB0C File Offset: 0x00149D0C
		[CallerCount(0)]
		public unsafe override void Write(TraceLoggingDataCollector collector, ref ContainerType container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collector);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(container);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			container = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<ContainerType>(intPtr4, false, false));
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x0014BB84 File Offset: 0x00149D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366366, XrefRangeEnd = 366368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetData(ContainerType container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(ContainerType).IsValueType)
				{
					ContainerType containerType = container;
					intPtr = ((containerType is string) ? IL2CPP.ManagedStringToIl2Cpp(containerType as string) : IL2CPP.Il2CppObjectBaseToPtr(containerType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref container;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClassPropertyWriter<ContainerType, ValueType>.NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Object>(intPtr4) : null;
			}
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x0001B68B File Offset: 0x0001988B
		public ClassPropertyWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x0014BC18 File Offset: 0x00149E18
		// (set) Token: 0x0600485F RID: 18527 RVA: 0x0001B694 File Offset: 0x00019894
		public unsafe TraceLoggingTypeInfo<ValueType> valueTypeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_valueTypeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<ValueType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_valueTypeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x0014BC48 File Offset: 0x00149E48
		// (set) Token: 0x06004861 RID: 18529 RVA: 0x0001B6B3 File Offset: 0x000198B3
		public unsafe ClassPropertyWriter<ContainerType, ValueType>.Getter getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClassPropertyWriter<ContainerType, ValueType>.Getter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassPropertyWriter<ContainerType, ValueType>.NativeFieldInfoPtr_getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A88 RID: 14984
		private static readonly IntPtr NativeFieldInfoPtr_valueTypeInfo;

		// Token: 0x04003A89 RID: 14985
		private static readonly IntPtr NativeFieldInfoPtr_getter;

		// Token: 0x04003A8A RID: 14986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyAnalysis_0;

		// Token: 0x04003A8B RID: 14987
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_TraceLoggingDataCollector_byref_ContainerType_0;

		// Token: 0x04003A8C RID: 14988
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Object_ContainerType_0;

		// Token: 0x02000671 RID: 1649
		public sealed class Getter : MulticastDelegate
		{
			// Token: 0x06005696 RID: 22166 RVA: 0x0017DF00 File Offset: 0x0017C100
			// Note: this type is marked as 'beforefieldinit'.
			static Getter()
			{
				Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>.Getter>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>>.NativeClassPtr, "Getter"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContainerType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr))
				})).TypeHandle.value);
				ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>.Getter>.NativeClassPtr, 100673995);
				ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ValueType_ContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>.Getter>.NativeClassPtr, 100673996);
			}

			// Token: 0x06005697 RID: 22167 RVA: 0x0017DF98 File Offset: 0x0017C198
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Getter(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassPropertyWriter<ContainerType, ValueType>.Getter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005698 RID: 22168 RVA: 0x0017DFF4 File Offset: 0x0017C1F4
			[CallerCount(0)]
			public unsafe ValueType Invoke(ContainerType container)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(ContainerType).IsValueType)
					{
						ContainerType containerType = container;
						intPtr = ((containerType is string) ? IL2CPP.ManagedStringToIl2Cpp(containerType as string) : IL2CPP.Il2CppObjectBaseToPtr(containerType as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref container;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ClassPropertyWriter<ContainerType, ValueType>.Getter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ValueType_ContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<ValueType>(intPtr2, false, true);
				}
			}

			// Token: 0x06005699 RID: 22169 RVA: 0x00021715 File Offset: 0x0001F915
			public Getter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600569A RID: 22170 RVA: 0x0002171E File Offset: 0x0001F91E
			public static implicit operator ClassPropertyWriter<ContainerType, ValueType>.Getter(Func<ContainerType, ValueType> A_0)
			{
				return DelegateSupport.ConvertDelegate<ClassPropertyWriter<ContainerType, ValueType>.Getter>(A_0);
			}

			// Token: 0x0600569B RID: 22171 RVA: 0x00021726 File Offset: 0x0001F926
			public static ClassPropertyWriter<ContainerType, ValueType>.Getter operator +(ClassPropertyWriter<ContainerType, ValueType>.Getter A_0, ClassPropertyWriter<ContainerType, ValueType>.Getter A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ClassPropertyWriter<ContainerType, ValueType>.Getter>();
			}

			// Token: 0x0600569C RID: 22172 RVA: 0x00021734 File Offset: 0x0001F934
			public static ClassPropertyWriter<ContainerType, ValueType>.Getter operator -(ClassPropertyWriter<ContainerType, ValueType>.Getter A_0, ClassPropertyWriter<ContainerType, ValueType>.Getter A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ClassPropertyWriter<ContainerType, ValueType>.Getter>();
				}
				return delegate2;
			}

			// Token: 0x04004564 RID: 17764
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004565 RID: 17765
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ValueType_ContainerType_0;
		}
	}
}
