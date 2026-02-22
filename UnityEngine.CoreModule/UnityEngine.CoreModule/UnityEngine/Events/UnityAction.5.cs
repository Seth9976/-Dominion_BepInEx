using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x0200010F RID: 271
	public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate
	{
		// Token: 0x0600164A RID: 5706 RVA: 0x00054F2C File Offset: 0x0005312C
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAction()
		{
			Il2CppClassPointerStore<UnityAction<T0, T1, T2, T3>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityAction`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			})).TypeHandle.value);
			UnityAction<T0, T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0, T1, T2, T3>>.NativeClassPtr, 100664965);
			UnityAction<T0, T1, T2, T3>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0, T1, T2, T3>>.NativeClassPtr, 100664966);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00054FEC File Offset: 0x000531EC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAction<T0, T1, T2, T3>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0, T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00055048 File Offset: 0x00053248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81202, RefRangeEnd = 81203, XrefRangeStart = 81184, XrefRangeEnd = 81202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0, T1, T2, T3>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0000C929 File Offset: 0x0000AB29
		public UnityAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0000C932 File Offset: 0x0000AB32
		public static implicit operator UnityAction<T0, T1, T2, T3>(Action<T0, T1, T2, T3> A_0)
		{
			return DelegateSupport.ConvertDelegate<UnityAction<T0, T1, T2, T3>>(A_0);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0000C93A File Offset: 0x0000AB3A
		public static UnityAction<T0, T1, T2, T3>operator +(UnityAction<T0, T1, T2, T3> A_0, UnityAction<T0, T1, T2, T3> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnityAction<T0, T1, T2, T3>>();
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0000C948 File Offset: 0x0000AB48
		public static UnityAction<T0, T1, T2, T3>operator -(UnityAction<T0, T1, T2, T3> A_0, UnityAction<T0, T1, T2, T3> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UnityAction<T0, T1, T2, T3>>();
			}
			return delegate2;
		}

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_T3_0;
	}
}
