using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000071 RID: 113
	public sealed class Predicate<T> : MulticastDelegate
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x00041210 File Offset: 0x0003F410
		// Note: this type is marked as 'beforefieldinit'.
		static Predicate()
		{
			Il2CppClassPointerStore<Predicate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Predicate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			Predicate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Predicate<T>>.NativeClassPtr, 100664375);
			Predicate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Predicate<T>>.NativeClassPtr, 100664376);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0004129C File Offset: 0x0003F49C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Predicate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Predicate<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Predicate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000412F8 File Offset: 0x0003F4F8
		[CallerCount(0)]
		public unsafe bool Invoke(T obj)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Predicate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000443B File Offset: 0x0000263B
		public Predicate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00004444 File Offset: 0x00002644
		public static implicit operator Predicate<T>(Func<T, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<Predicate<T>>(A_0);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0000444C File Offset: 0x0000264C
		public static Predicate<T>operator +(Predicate<T> A_0, Predicate<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Predicate<T>>();
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0000445A File Offset: 0x0000265A
		public static Predicate<T>operator -(Predicate<T> A_0, Predicate<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Predicate<T>>();
			}
			return delegate2;
		}

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_T_0;
	}
}
