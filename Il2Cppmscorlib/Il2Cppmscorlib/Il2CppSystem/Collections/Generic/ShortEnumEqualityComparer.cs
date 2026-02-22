using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004A4 RID: 1188
	[Serializable]
	public sealed class ShortEnumEqualityComparer<T> : EnumEqualityComparer<T> where T : new()
	{
		// Token: 0x060046A3 RID: 18083 RVA: 0x0014473C File Offset: 0x0014293C
		// Note: this type is marked as 'beforefieldinit'.
		static ShortEnumEqualityComparer()
		{
			Il2CppClassPointerStore<ShortEnumEqualityComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ShortEnumEqualityComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShortEnumEqualityComparer<T>>.NativeClassPtr);
			ShortEnumEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortEnumEqualityComparer<T>>.NativeClassPtr, 100673768);
			ShortEnumEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortEnumEqualityComparer<T>>.NativeClassPtr, 100673769);
			ShortEnumEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShortEnumEqualityComparer<T>>.NativeClassPtr, 100673770);
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x001447E4 File Offset: 0x001429E4
		[CallerCount(0)]
		public unsafe ShortEnumEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortEnumEqualityComparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortEnumEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x00144820 File Offset: 0x00142A20
		[CallerCount(0)]
		public unsafe ShortEnumEqualityComparer(SerializationInfo information, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShortEnumEqualityComparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(information);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShortEnumEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x00144884 File Offset: 0x00142A84
		[CallerCount(0)]
		public unsafe override int GetHashCode(T obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref obj;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShortEnumEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x0001ABFC File Offset: 0x00018DFC
		public ShortEnumEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400395A RID: 14682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400395B RID: 14683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400395C RID: 14684
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_T_0;
	}
}
