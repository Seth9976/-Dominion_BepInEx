using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000069 RID: 105
	public sealed class Action<T1, T2, T3, T4> : MulticastDelegate
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x0004034C File Offset: 0x0003E54C
		// Note: this type is marked as 'beforefieldinit'.
		static Action()
		{
			Il2CppClassPointerStore<Action<T1, T2, T3, T4>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
			})).TypeHandle.value);
			Action<T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3, T4>>.NativeClassPtr, 100664359);
			Action<T1, T2, T3, T4>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2, T3, T4>>.NativeClassPtr, 100664360);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0004040C File Offset: 0x0003E60C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T1, T2, T3, T4>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Action<T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00040468 File Offset: 0x0003E668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81202, RefRangeEnd = 81203, XrefRangeStart = 81202, XrefRangeEnd = 81203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
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
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(Action<T1, T2, T3, T4>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000042BB File Offset: 0x000024BB
		public Action(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000042C4 File Offset: 0x000024C4
		public static implicit operator Action<T1, T2, T3, T4>(Action<T1, T2, T3, T4> A_0)
		{
			return DelegateSupport.ConvertDelegate<Action<T1, T2, T3, T4>>(A_0);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x000042CC File Offset: 0x000024CC
		public static Action<T1, T2, T3, T4>operator +(Action<T1, T2, T3, T4> A_0, Action<T1, T2, T3, T4> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Action<T1, T2, T3, T4>>();
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000042DA File Offset: 0x000024DA
		public static Action<T1, T2, T3, T4>operator -(Action<T1, T2, T3, T4> A_0, Action<T1, T2, T3, T4> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Action<T1, T2, T3, T4>>();
			}
			return delegate2;
		}

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_T3_T4_0;
	}
}
