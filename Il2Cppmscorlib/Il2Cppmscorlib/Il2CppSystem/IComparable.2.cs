using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x020000B9 RID: 185
	public class IComparable<T> : Il2CppObjectBase
	{
		// Token: 0x06000CED RID: 3309 RVA: 0x0005C9D8 File Offset: 0x0005ABD8
		// Note: this type is marked as 'beforefieldinit'.
		static IComparable()
		{
			Il2CppClassPointerStore<IComparable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IComparable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IComparable<T>.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComparable<T>>.NativeClassPtr, 100665458);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0005CA50 File Offset: 0x0005AC50
		[CallerCount(0)]
		public unsafe virtual int CompareTo(T other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = other;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref other;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComparable<T>.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000056DC File Offset: 0x000038DC
		public IComparable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_T_0;
	}
}
