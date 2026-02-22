using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200006A RID: 106
	public sealed class Func<TResult> : MulticastDelegate
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x000405BC File Offset: 0x0003E7BC
		// Note: this type is marked as 'beforefieldinit'.
		static Func()
		{
			Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			Func<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr, 100664361);
			Func<TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr, 100664362);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00040648 File Offset: 0x0003E848
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Func<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000406A4 File Offset: 0x0003E8A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91949, RefRangeEnd = 91951, XrefRangeStart = 91949, XrefRangeEnd = 91951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Func<TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000042EB File Offset: 0x000024EB
		public Func(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000042F4 File Offset: 0x000024F4
		public static implicit operator Func<TResult>(Func<TResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<Func<TResult>>(A_0);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000042FC File Offset: 0x000024FC
		public static Func<TResult>operator +(Func<TResult> A_0, Func<TResult> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Func<TResult>>();
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0000430A File Offset: 0x0000250A
		public static Func<TResult>operator -(Func<TResult> A_0, Func<TResult> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Func<TResult>>();
			}
			return delegate2;
		}

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_0;
	}
}
