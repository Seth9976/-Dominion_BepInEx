using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200048C RID: 1164
	[Serializable]
	public sealed class KeyValuePair<TKey, TValue> : ValueType
	{
		// Token: 0x060045BC RID: 17852 RVA: 0x0013F39C File Offset: 0x0013D59C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePair()
		{
			Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "KeyValuePair`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr);
			KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, "key");
			KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, "value");
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100673579);
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Key_Public_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100673580);
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Value_Public_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100673581);
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100673582);
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x0013F494 File Offset: 0x0013D694
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 52612, RefRangeEnd = 52647, XrefRangeStart = 52612, XrefRangeEnd = 52647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePair(TKey key, TValue value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr))
		{
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x060045BE RID: 17854 RVA: 0x0013F564 File Offset: 0x0013D764
		public unsafe TKey Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Key_Public_get_TKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x060045BF RID: 17855 RVA: 0x0013F5A4 File Offset: 0x0013D7A4
		public unsafe TValue Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Value_Public_get_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x0013F5E4 File Offset: 0x0013D7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361557, XrefRangeEnd = 361563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x0001A953 File Offset: 0x00018B53
		public KeyValuePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x0001A95C File Offset: 0x00018B5C
		public KeyValuePair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr))
		{
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x060045C3 RID: 17859 RVA: 0x0013F620 File Offset: 0x0013D820
		// (set) Token: 0x060045C4 RID: 17860 RVA: 0x0013F648 File Offset: 0x0013D848
		public unsafe TKey key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_key);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_key);
				Type typeFromHandle = typeof(TKey);
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

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x060045C5 RID: 17861 RVA: 0x0013F6F0 File Offset: 0x0013D8F0
		// (set) Token: 0x060045C6 RID: 17862 RVA: 0x0013F718 File Offset: 0x0013D918
		public unsafe TValue value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_value);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_value);
				Type typeFromHandle = typeof(TValue);
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

		// Token: 0x040038B3 RID: 14515
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040038B4 RID: 14516
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040038B5 RID: 14517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0;

		// Token: 0x040038B6 RID: 14518
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_TKey_0;

		// Token: 0x040038B7 RID: 14519
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_TValue_0;

		// Token: 0x040038B8 RID: 14520
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
