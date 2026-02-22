using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000127 RID: 295
	[Serializable]
	public sealed class Nullable<T> : ValueType where T : new()
	{
		// Token: 0x060014D3 RID: 5331 RVA: 0x00080DE0 File Offset: 0x0007EFE0
		// Note: this type is marked as 'beforefieldinit'.
		static Nullable()
		{
			Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Nullable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr);
			Nullable<T>.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, "value");
			Nullable<T>.NativeFieldInfoPtr_has_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, "has_value");
			Nullable<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, 100666846);
			Nullable<T>.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, 100666847);
			Nullable<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, 100666848);
			Nullable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, 100666849);
			Nullable<T>.NativeMethodInfoPtr_Equals_Private_Boolean_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, 100666850);
			Nullable<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, 100666851);
			Nullable<T>.NativeMethodInfoPtr_GetValueOrDefault_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, 100666852);
			Nullable<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, 100666853);
			Nullable<T>.NativeMethodInfoPtr_Box_Private_Static_Object_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, 100666854);
			Nullable<T>.NativeMethodInfoPtr_Unbox_Private_Static_Nullable_1_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr, 100666855);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00080F3C File Offset: 0x0007F13C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 306359, RefRangeEnd = 306363, XrefRangeStart = 306359, XrefRangeEnd = 306359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable(T value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr))
		{
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Nullable<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x00080FC4 File Offset: 0x0007F1C4
		public unsafe bool HasValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable<T>.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x00081008 File Offset: 0x0007F208
		public unsafe T Value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 306363, RefRangeEnd = 306366, XrefRangeStart = 306363, XrefRangeEnd = 306363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00081048 File Offset: 0x0007F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306366, XrefRangeEnd = 306376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0008109C File Offset: 0x0007F29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306376, XrefRangeEnd = 306380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Nullable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable<T>.NativeMethodInfoPtr_Equals_Private_Boolean_Nullable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000810F4 File Offset: 0x0007F2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306380, XrefRangeEnd = 306381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00081138 File Offset: 0x0007F338
		[CallerCount(0)]
		public unsafe T GetValueOrDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable<T>.NativeMethodInfoPtr_GetValueOrDefault_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00081178 File Offset: 0x0007F378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306381, XrefRangeEnd = 306383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x000811B4 File Offset: 0x0007F3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306383, XrefRangeEnd = 306386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Box(Nullable<T> o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(o));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable<T>.NativeMethodInfoPtr_Box_Private_Static_Object_Nullable_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00081200 File Offset: 0x0007F400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306386, XrefRangeEnd = 306390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<T> Unbox(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable<T>.NativeMethodInfoPtr_Unbox_Private_Static_Nullable_1_T_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<T>(intPtr);
			}
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00007495 File Offset: 0x00005695
		public Nullable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0000749E File Offset: 0x0000569E
		public Nullable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Nullable<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0008123C File Offset: 0x0007F43C
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x00081264 File Offset: 0x0007F464
		public unsafe T value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Nullable<T>.NativeFieldInfoPtr_value);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Nullable<T>.NativeFieldInfoPtr_value);
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

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0008130C File Offset: 0x0007F50C
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x000074B0 File Offset: 0x000056B0
		public unsafe bool has_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Nullable<T>.NativeFieldInfoPtr_has_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Nullable<T>.NativeFieldInfoPtr_has_value)) = value;
			}
		}

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr_has_value;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Private_Boolean_Nullable_1_T_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr_GetValueOrDefault_Public_T_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr_Box_Private_Static_Object_Nullable_1_T_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr_Unbox_Private_Static_Nullable_1_T_Object_0;
	}
}
