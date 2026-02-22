using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x02000109 RID: 265
	public sealed class UnityAction<T0> : MulticastDelegate
	{
		// Token: 0x06001614 RID: 5652 RVA: 0x00053E1C File Offset: 0x0005201C
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAction()
		{
			Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityAction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)) })).TypeHandle.value);
			UnityAction<T0>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr, 100664938);
			UnityAction<T0>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr, 100664939);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00053EA8 File Offset: 0x000520A8
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAction<T0>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00053F04 File Offset: 0x00052104
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 80701, RefRangeEnd = 80719, XrefRangeStart = 80697, XrefRangeEnd = 80701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T0 arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnityAction<T0>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0000C821 File Offset: 0x0000AA21
		public UnityAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x0000C82A File Offset: 0x0000AA2A
		public static implicit operator UnityAction<T0>(Action<T0> A_0)
		{
			return DelegateSupport.ConvertDelegate<UnityAction<T0>>(A_0);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0000C832 File Offset: 0x0000AA32
		public static UnityAction<T0>operator +(UnityAction<T0> A_0, UnityAction<T0> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnityAction<T0>>();
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0000C840 File Offset: 0x0000AA40
		public static UnityAction<T0>operator -(UnityAction<T0> A_0, UnityAction<T0> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UnityAction<T0>>();
			}
			return delegate2;
		}

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_0;
	}
}
