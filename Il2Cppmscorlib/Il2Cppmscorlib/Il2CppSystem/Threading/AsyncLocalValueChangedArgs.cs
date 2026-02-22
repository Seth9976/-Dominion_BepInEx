using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000268 RID: 616
	public sealed class AsyncLocalValueChangedArgs<T> : ValueType
	{
		// Token: 0x06002A91 RID: 10897 RVA: 0x000DB940 File Offset: 0x000D9B40
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncLocalValueChangedArgs()
		{
			Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AsyncLocalValueChangedArgs`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr);
			AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__PreviousValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, "<PreviousValue>k__BackingField");
			AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, "<CurrentValue>k__BackingField");
			AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__ThreadContextChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, "<ThreadContextChanged>k__BackingField");
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_get_PreviousValue_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670064);
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_PreviousValue_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670065);
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_get_CurrentValue_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670066);
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670067);
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_ThreadContextChanged_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670068);
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr__ctor_Internal_Void_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670069);
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002A92 RID: 10898 RVA: 0x000DBA60 File Offset: 0x000D9C60
		// (set) Token: 0x06002A93 RID: 10899 RVA: 0x000DBAA0 File Offset: 0x000D9CA0
		public unsafe T PreviousValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_get_PreviousValue_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_PreviousValue_Private_set_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x000DBB20 File Offset: 0x000D9D20
		// (set) Token: 0x06002A95 RID: 10901 RVA: 0x000DBB60 File Offset: 0x000D9D60
		public unsafe T CurrentValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_get_CurrentValue_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88837, RefRangeEnd = 88838, XrefRangeStart = 88837, XrefRangeEnd = 88838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x000DBBE0 File Offset: 0x000D9DE0
		public unsafe bool ThreadContextChanged
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_ThreadContextChanged_Private_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000DBC24 File Offset: 0x000D9E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331242, XrefRangeEnd = 331245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = previousValue;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref previousValue;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = currentValue;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref currentValue;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextChanged;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr__ctor_Internal_Void_T_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x0000ED98 File Offset: 0x0000CF98
		public AsyncLocalValueChangedArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x0000EDA1 File Offset: 0x0000CFA1
		public AsyncLocalValueChangedArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x000DBD00 File Offset: 0x000D9F00
		// (set) Token: 0x06002A9B RID: 10907 RVA: 0x000DBD28 File Offset: 0x000D9F28
		public unsafe T _PreviousValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__PreviousValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__PreviousValue_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x000DBDD0 File Offset: 0x000D9FD0
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x000DBDF8 File Offset: 0x000D9FF8
		public unsafe T _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x000DBEA0 File Offset: 0x000DA0A0
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x0000EDB3 File Offset: 0x0000CFB3
		public unsafe bool _ThreadContextChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__ThreadContextChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__ThreadContextChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeFieldInfoPtr__PreviousValue_k__BackingField;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeFieldInfoPtr__ThreadContextChanged_k__BackingField;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousValue_Public_get_T_0;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeMethodInfoPtr_set_PreviousValue_Private_set_Void_T_0;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_T_0;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_T_0;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeMethodInfoPtr_set_ThreadContextChanged_Private_set_Void_Boolean_0;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_T_T_Boolean_0;
	}
}
