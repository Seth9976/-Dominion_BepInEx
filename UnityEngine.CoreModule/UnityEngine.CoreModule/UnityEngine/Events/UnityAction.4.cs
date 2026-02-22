using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x0200010D RID: 269
	public sealed class UnityAction<T0, T1, T2> : MulticastDelegate
	{
		// Token: 0x06001638 RID: 5688 RVA: 0x000548C8 File Offset: 0x00052AC8
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAction()
		{
			Il2CppClassPointerStore<UnityAction<T0, T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityAction`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			UnityAction<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0, T1, T2>>.NativeClassPtr, 100664956);
			UnityAction<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0, T1, T2>>.NativeClassPtr, 100664957);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00054978 File Offset: 0x00052B78
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAction<T0, T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x000549D4 File Offset: 0x00052BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81097, XrefRangeEnd = 81116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T0 arg0, T1 arg1, T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0000C8D1 File Offset: 0x0000AAD1
		public UnityAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x0000C8DA File Offset: 0x0000AADA
		public static implicit operator UnityAction<T0, T1, T2>(Action<T0, T1, T2> A_0)
		{
			return DelegateSupport.ConvertDelegate<UnityAction<T0, T1, T2>>(A_0);
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0000C8E2 File Offset: 0x0000AAE2
		public static UnityAction<T0, T1, T2>operator +(UnityAction<T0, T1, T2> A_0, UnityAction<T0, T1, T2> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnityAction<T0, T1, T2>>();
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
		public static UnityAction<T0, T1, T2>operator -(UnityAction<T0, T1, T2> A_0, UnityAction<T0, T1, T2> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UnityAction<T0, T1, T2>>();
			}
			return delegate2;
		}

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_0;
	}
}
