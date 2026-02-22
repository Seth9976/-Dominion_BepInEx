using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000438 RID: 1080
	public sealed class ConditionalWeakTable<TKey, TValue> : Object where TKey : class where TValue : class
	{
		// Token: 0x0600426C RID: 17004 RVA: 0x001319BC File Offset: 0x0012FBBC
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionalWeakTable()
		{
			Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConditionalWeakTable`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr);
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "data");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "_lock");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "size");
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100672944);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100672945);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RehashWithoutResize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100672946);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RecomputeSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100672947);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Rehash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100672948);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100672949);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100672950);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100672951);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_GetValue_Public_TValue_TKey_CreateValueCallback_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100672952);
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x00131B2C File Offset: 0x0012FD2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 357123, RefRangeEnd = 357127, XrefRangeStart = 357111, XrefRangeEnd = 357123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalWeakTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x00131B68 File Offset: 0x0012FD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357127, XrefRangeEnd = 357129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x00131B9C File Offset: 0x0012FD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357129, XrefRangeEnd = 357136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RehashWithoutResize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RehashWithoutResize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00131BD0 File Offset: 0x0012FDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357136, XrefRangeEnd = 357137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecomputeSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RecomputeSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x00131C04 File Offset: 0x0012FE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357137, XrefRangeEnd = 357143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rehash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Rehash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x00131C38 File Offset: 0x0012FE38
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 357153, RefRangeEnd = 357160, XrefRangeStart = 357143, XrefRangeEnd = 357153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x00131CF8 File Offset: 0x0012FEF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 357170, RefRangeEnd = 357172, XrefRangeStart = 357160, XrefRangeEnd = 357170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x00131D7C File Offset: 0x0012FF7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 357183, RefRangeEnd = 357185, XrefRangeStart = 357172, XrefRangeEnd = 357183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			IntPtr intPtr3;
			if (!typeof(TValue).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref value;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x00131E50 File Offset: 0x00130050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 357189, RefRangeEnd = 357191, XrefRangeStart = 357185, XrefRangeEnd = 357189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue GetValue(TKey key, ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createValueCallback);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_GetValue_Public_TValue_TKey_CreateValueCallback_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x0001967B File Offset: 0x0001787B
		public ConditionalWeakTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x00131EE4 File Offset: 0x001300E4
		// (set) Token: 0x06004278 RID: 17016 RVA: 0x00019684 File Offset: 0x00017884
		public unsafe Il2CppReferenceArray<Ephemeron> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Ephemeron>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x00131F14 File Offset: 0x00130114
		// (set) Token: 0x0600427A RID: 17018 RVA: 0x000196A3 File Offset: 0x000178A3
		public unsafe Object _lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr__lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr__lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x00131F44 File Offset: 0x00130144
		// (set) Token: 0x0600427C RID: 17020 RVA: 0x000196C2 File Offset: 0x000178C2
		public unsafe int size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x040035FC RID: 13820
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040035FD RID: 13821
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x040035FE RID: 13822
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040035FF RID: 13823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003600 RID: 13824
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04003601 RID: 13825
		private static readonly IntPtr NativeMethodInfoPtr_RehashWithoutResize_Private_Void_0;

		// Token: 0x04003602 RID: 13826
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeSize_Private_Void_0;

		// Token: 0x04003603 RID: 13827
		private static readonly IntPtr NativeMethodInfoPtr_Rehash_Private_Void_0;

		// Token: 0x04003604 RID: 13828
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0;

		// Token: 0x04003605 RID: 13829
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0;

		// Token: 0x04003606 RID: 13830
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0;

		// Token: 0x04003607 RID: 13831
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_TValue_TKey_CreateValueCallback_TKey_TValue_0;

		// Token: 0x02000643 RID: 1603
		public sealed class CreateValueCallback : MulticastDelegate
		{
			// Token: 0x060054C1 RID: 21697 RVA: 0x00176A98 File Offset: 0x00174C98
			// Note: this type is marked as 'beforefieldinit'.
			static CreateValueCallback()
			{
				Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "CreateValueCallback"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr, 100672953);
				ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr, 100672954);
			}

			// Token: 0x060054C2 RID: 21698 RVA: 0x00176B30 File Offset: 0x00174D30
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateValueCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054C3 RID: 21699 RVA: 0x00176B8C File Offset: 0x00174D8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 275479, RefRangeEnd = 275480, XrefRangeStart = 275479, XrefRangeEnd = 275480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TValue Invoke(TKey key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = key;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref key;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}

			// Token: 0x060054C4 RID: 21700 RVA: 0x00020B84 File Offset: 0x0001ED84
			public CreateValueCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060054C5 RID: 21701 RVA: 0x00020B8D File Offset: 0x0001ED8D
			public static implicit operator ConditionalWeakTable<TKey, TValue>.CreateValueCallback(Func<TKey, TValue> A_0)
			{
				return DelegateSupport.ConvertDelegate<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>(A_0);
			}

			// Token: 0x060054C6 RID: 21702 RVA: 0x00020B95 File Offset: 0x0001ED95
			public static ConditionalWeakTable<TKey, TValue>.CreateValueCallback operator +(ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_0, ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>();
			}

			// Token: 0x060054C7 RID: 21703 RVA: 0x00020BA3 File Offset: 0x0001EDA3
			public static ConditionalWeakTable<TKey, TValue>.CreateValueCallback operator -(ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_0, ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>();
				}
				return delegate2;
			}

			// Token: 0x04004429 RID: 17449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400442A RID: 17450
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TKey_0;
		}
	}
}
