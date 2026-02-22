using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200006C RID: 108
	public sealed class Func<T1, T2, TResult> : MulticastDelegate
	{
		// Token: 0x060006CF RID: 1743 RVA: 0x00040858 File Offset: 0x0003EA58
		// Note: this type is marked as 'beforefieldinit'.
		static Func()
		{
			Il2CppClassPointerStore<Func<T1, T2, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			Func<T1, T2, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, TResult>>.NativeClassPtr, 100664365);
			Func<T1, T2, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, TResult>>.NativeClassPtr, 100664366);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00040908 File Offset: 0x0003EB08
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T1, T2, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Func<T1, T2, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00040964 File Offset: 0x0003EB64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 225167, RefRangeEnd = 225172, XrefRangeStart = 225167, XrefRangeEnd = 225172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult Invoke(T1 arg1, T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = arg1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = arg2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg2;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Func<T1, T2, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr3, false, true);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0000434B File Offset: 0x0000254B
		public Func(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00004354 File Offset: 0x00002554
		public static implicit operator Func<T1, T2, TResult>(Func<T1, T2, TResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<Func<T1, T2, TResult>>(A_0);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000435C File Offset: 0x0000255C
		public static Func<T1, T2, TResult>operator +(Func<T1, T2, TResult> A_0, Func<T1, T2, TResult> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Func<T1, T2, TResult>>();
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0000436A File Offset: 0x0000256A
		public static Func<T1, T2, TResult>operator -(Func<T1, T2, TResult> A_0, Func<T1, T2, TResult> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Func<T1, T2, TResult>>();
			}
			return delegate2;
		}

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_0;
	}
}
