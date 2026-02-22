using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C5 RID: 1221
	public static class EnumHelper<UnderlyingType> : Object
	{
		// Token: 0x060047D7 RID: 18391 RVA: 0x00149B60 File Offset: 0x00147D60
		// Note: this type is marked as 'beforefieldinit'.
		static EnumHelper()
		{
			Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EnumHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnderlyingType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr);
			EnumHelper<UnderlyingType>.NativeFieldInfoPtr_IdentityInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr, "IdentityInfo");
			EnumHelper<UnderlyingType>.NativeMethodInfoPtr_Cast_Public_Static_UnderlyingType_ValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr, 100673931);
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x00149BF4 File Offset: 0x00147DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366103, XrefRangeEnd = 366108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnderlyingType Cast<ValueType>(ValueType value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(ValueType).IsValueType)
				{
					ValueType valueType = value;
					intPtr = ((valueType is string) ? IL2CPP.ManagedStringToIl2Cpp(valueType as string) : IL2CPP.Il2CppObjectBaseToPtr(valueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumHelper<ValueType>.MethodInfoStoreGeneric_Cast_Public_Static_UnderlyingType_ValueType_0.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<UnderlyingType>(intPtr2, false, true);
			}
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x0001B2DF File Offset: 0x000194DF
		public EnumHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060047DA RID: 18394 RVA: 0x00149C68 File Offset: 0x00147E68
		// (set) Token: 0x060047DB RID: 18395 RVA: 0x0001B2E8 File Offset: 0x000194E8
		public unsafe static MethodInfo IdentityInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumHelper<UnderlyingType>.NativeFieldInfoPtr_IdentityInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumHelper<UnderlyingType>.NativeFieldInfoPtr_IdentityInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A24 RID: 14884
		private static readonly IntPtr NativeFieldInfoPtr_IdentityInfo;

		// Token: 0x04003A25 RID: 14885
		private static readonly IntPtr NativeMethodInfoPtr_Cast_Public_Static_UnderlyingType_ValueType_0;

		// Token: 0x0200066D RID: 1645
		public sealed class Transformer<ValueType> : MulticastDelegate
		{
			// Token: 0x0600567A RID: 22138 RVA: 0x0017D97C File Offset: 0x0017BB7C
			// Note: this type is marked as 'beforefieldinit'.
			static Transformer()
			{
				Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Transformer<ValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr, "Transformer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnderlyingType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr))
				})).TypeHandle.value);
				EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Transformer<ValueType>>.NativeClassPtr, 100673933);
				EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_UnderlyingType_ValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Transformer<ValueType>>.NativeClassPtr, 100673934);
			}

			// Token: 0x0600567B RID: 22139 RVA: 0x0017DA14 File Offset: 0x0017BC14
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Transformer(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Transformer<ValueType>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600567C RID: 22140 RVA: 0x0017DA70 File Offset: 0x0017BC70
			[CallerCount(0)]
			public unsafe UnderlyingType Invoke(ValueType value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(ValueType).IsValueType)
					{
						ValueType valueType = value;
						intPtr = ((valueType is string) ? IL2CPP.ManagedStringToIl2Cpp(valueType as string) : IL2CPP.Il2CppObjectBaseToPtr(valueType as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumHelper<UnderlyingType>.Transformer<ValueType>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_UnderlyingType_ValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<UnderlyingType>(intPtr2, false, true);
				}
			}

			// Token: 0x0600567D RID: 22141 RVA: 0x0002163E File Offset: 0x0001F83E
			public Transformer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600567E RID: 22142 RVA: 0x00021647 File Offset: 0x0001F847
			public static implicit operator EnumHelper<UnderlyingType>.Transformer<ValueType>(Func<ValueType, UnderlyingType> A_0)
			{
				return DelegateSupport.ConvertDelegate<EnumHelper<UnderlyingType>.Transformer<ValueType>>(A_0);
			}

			// Token: 0x0600567F RID: 22143 RVA: 0x0002164F File Offset: 0x0001F84F
			public static EnumHelper<UnderlyingType>.Transformer<ValueType>operator +(EnumHelper<UnderlyingType>.Transformer<ValueType> A_0, EnumHelper<UnderlyingType>.Transformer<ValueType> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EnumHelper<UnderlyingType>.Transformer<ValueType>>();
			}

			// Token: 0x06005680 RID: 22144 RVA: 0x0002165D File Offset: 0x0001F85D
			public static EnumHelper<UnderlyingType>.Transformer<ValueType>operator -(EnumHelper<UnderlyingType>.Transformer<ValueType> A_0, EnumHelper<UnderlyingType>.Transformer<ValueType> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EnumHelper<UnderlyingType>.Transformer<ValueType>>();
				}
				return delegate2;
			}

			// Token: 0x04004556 RID: 17750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004557 RID: 17751
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_UnderlyingType_ValueType_0;
		}

		// Token: 0x0200066E RID: 1646
		public static class Caster<ValueType> : Object
		{
			// Token: 0x06005681 RID: 22145 RVA: 0x0017DAF0 File Offset: 0x0017BCF0
			// Note: this type is marked as 'beforefieldinit'.
			static Caster()
			{
				Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Caster<ValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumHelper<UnderlyingType>>.NativeClassPtr, "Caster`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnderlyingType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Caster<ValueType>>.NativeClassPtr);
				EnumHelper<UnderlyingType>.Caster<ValueType>.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumHelper<UnderlyingType>.Caster<ValueType>>.NativeClassPtr, "Instance");
			}

			// Token: 0x06005682 RID: 22146 RVA: 0x0002166E File Offset: 0x0001F86E
			public Caster(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700163F RID: 5695
			// (get) Token: 0x06005683 RID: 22147 RVA: 0x0017DB7C File Offset: 0x0017BD7C
			// (set) Token: 0x06005684 RID: 22148 RVA: 0x00021677 File Offset: 0x0001F877
			public unsafe static EnumHelper<UnderlyingType>.Transformer<ValueType> Instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumHelper<UnderlyingType>.Caster<ValueType>.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumHelper<UnderlyingType>.Transformer<ValueType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumHelper<UnderlyingType>.Caster<ValueType>.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004558 RID: 17752
			private static readonly IntPtr NativeFieldInfoPtr_Instance;
		}

		// Token: 0x0200066F RID: 1647
		private sealed class MethodInfoStoreGeneric_Cast_Public_Static_UnderlyingType_ValueType_0
		{
			// Token: 0x04004559 RID: 17753
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumHelper<ValueType>.NativeMethodInfoPtr_Cast_Public_Static_UnderlyingType_ValueType_0, Il2CppClassPointerStore<EnumHelper<ValueType>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueType>.NativeClassPtr)) }))));
		}
	}
}
