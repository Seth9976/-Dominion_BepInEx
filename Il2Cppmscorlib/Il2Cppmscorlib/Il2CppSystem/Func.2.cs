using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200006B RID: 107
	public sealed class Func<T, TResult> : MulticastDelegate
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x000406E0 File Offset: 0x0003E8E0
		// Note: this type is marked as 'beforefieldinit'.
		static Func()
		{
			Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			Func<T, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr, 100664363);
			Func<T, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr, 100664364);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0004077C File Offset: 0x0003E97C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Func<T, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000407D8 File Offset: 0x0003E9D8
		[CallerCount(0)]
		public unsafe TResult Invoke(T arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = arg;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Func<T, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000431B File Offset: 0x0000251B
		public Func(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00004324 File Offset: 0x00002524
		public static implicit operator Func<T, TResult>(Func<T, TResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<Func<T, TResult>>(A_0);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000432C File Offset: 0x0000252C
		public static Func<T, TResult>operator +(Func<T, TResult> A_0, Func<T, TResult> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Func<T, TResult>>();
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0000433A File Offset: 0x0000253A
		public static Func<T, TResult>operator -(Func<T, TResult> A_0, Func<T, TResult> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Func<T, TResult>>();
			}
			return delegate2;
		}

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_0;
	}
}
