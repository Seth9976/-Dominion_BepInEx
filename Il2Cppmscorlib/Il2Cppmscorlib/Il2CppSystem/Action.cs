using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000065 RID: 101
	public sealed class Action<T> : MulticastDelegate
	{
		// Token: 0x0600069E RID: 1694 RVA: 0x0003FD40 File Offset: 0x0003DF40
		// Note: this type is marked as 'beforefieldinit'.
		static Action()
		{
			Il2CppClassPointerStore<Action<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			Action<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T>>.NativeClassPtr, 100664351);
			Action<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T>>.NativeClassPtr, 100664352);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0003FDCC File Offset: 0x0003DFCC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Action<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0003FE28 File Offset: 0x0003E028
		[CallerCount(277)]
		[CachedScanResults(RefRangeStart = 94180, RefRangeEnd = 94457, XrefRangeStart = 94180, XrefRangeEnd = 94457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T obj)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Action<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000041FB File Offset: 0x000023FB
		public Action(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00004204 File Offset: 0x00002404
		public static implicit operator Action<T>(Action<T> A_0)
		{
			return DelegateSupport.ConvertDelegate<Action<T>>(A_0);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0000420C File Offset: 0x0000240C
		public static Action<T>operator +(Action<T> A_0, Action<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Action<T>>();
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000421A File Offset: 0x0000241A
		public static Action<T>operator -(Action<T> A_0, Action<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Action<T>>();
			}
			return delegate2;
		}

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0;
	}
}
