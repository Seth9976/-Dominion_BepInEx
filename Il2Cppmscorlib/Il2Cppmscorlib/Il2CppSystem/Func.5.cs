using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200006E RID: 110
	public sealed class Func<T1, T2, T3, T4, TResult> : MulticastDelegate
	{
		// Token: 0x060006DD RID: 1757 RVA: 0x00040C58 File Offset: 0x0003EE58
		// Note: this type is marked as 'beforefieldinit'.
		static Func()
		{
			Il2CppClassPointerStore<Func<T1, T2, T3, T4, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`5"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			Func<T1, T2, T3, T4, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, T3, T4, TResult>>.NativeClassPtr, 100664369);
			Func<T1, T2, T3, T4, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, T3, T4, TResult>>.NativeClassPtr, 100664370);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00040D2C File Offset: 0x0003EF2C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T1, T2, T3, T4, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Func<T1, T2, T3, T4, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00040D88 File Offset: 0x0003EF88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 10207, RefRangeEnd = 10209, XrefRangeStart = 10207, XrefRangeEnd = 10209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = arg3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg3;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T4).IsValueType)
			{
				T4 t4 = arg4;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg4;
			}
			ptr5 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(Func<T1, T2, T3, T4, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_T4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr5, false, true);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000043AB File Offset: 0x000025AB
		public Func(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000043B4 File Offset: 0x000025B4
		public static implicit operator Func<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<Func<T1, T2, T3, T4, TResult>>(A_0);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000043BC File Offset: 0x000025BC
		public static Func<T1, T2, T3, T4, TResult>operator +(Func<T1, T2, T3, T4, TResult> A_0, Func<T1, T2, T3, T4, TResult> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Func<T1, T2, T3, T4, TResult>>();
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000043CA File Offset: 0x000025CA
		public static Func<T1, T2, T3, T4, TResult>operator -(Func<T1, T2, T3, T4, TResult> A_0, Func<T1, T2, T3, T4, TResult> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Func<T1, T2, T3, T4, TResult>>();
			}
			return delegate2;
		}

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_T4_0;
	}
}
