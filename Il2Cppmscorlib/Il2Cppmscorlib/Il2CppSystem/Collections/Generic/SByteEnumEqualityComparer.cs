using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004A3 RID: 1187
	[Serializable]
	public sealed class SByteEnumEqualityComparer<T> : EnumEqualityComparer<T> where T : new()
	{
		// Token: 0x0600469E RID: 18078 RVA: 0x00144570 File Offset: 0x00142770
		// Note: this type is marked as 'beforefieldinit'.
		static SByteEnumEqualityComparer()
		{
			Il2CppClassPointerStore<SByteEnumEqualityComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "SByteEnumEqualityComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SByteEnumEqualityComparer<T>>.NativeClassPtr);
			SByteEnumEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteEnumEqualityComparer<T>>.NativeClassPtr, 100673765);
			SByteEnumEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteEnumEqualityComparer<T>>.NativeClassPtr, 100673766);
			SByteEnumEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SByteEnumEqualityComparer<T>>.NativeClassPtr, 100673767);
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x00144618 File Offset: 0x00142818
		[CallerCount(0)]
		public unsafe SByteEnumEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SByteEnumEqualityComparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SByteEnumEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x00144654 File Offset: 0x00142854
		[CallerCount(0)]
		public unsafe SByteEnumEqualityComparer(SerializationInfo information, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SByteEnumEqualityComparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(information);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SByteEnumEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x001446B8 File Offset: 0x001428B8
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SByteEnumEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x0001ABF3 File Offset: 0x00018DF3
		public SByteEnumEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003957 RID: 14679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003958 RID: 14680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003959 RID: 14681
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_T_0;
	}
}
