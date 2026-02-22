using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000070 RID: 112
	public sealed class Converter<TInput, TOutput> : MulticastDelegate
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x00041098 File Offset: 0x0003F298
		// Note: this type is marked as 'beforefieldinit'.
		static Converter()
		{
			Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Converter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInput>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutput>.NativeClassPtr))
			})).TypeHandle.value);
			Converter<TInput, TOutput>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr, 100664373);
			Converter<TInput, TOutput>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr, 100664374);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00041134 File Offset: 0x0003F334
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Converter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter<TInput, TOutput>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00041190 File Offset: 0x0003F390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275479, RefRangeEnd = 275480, XrefRangeStart = 275479, XrefRangeEnd = 275479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TOutput Invoke(TInput input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TInput).IsValueType)
				{
					TInput tinput = input;
					intPtr = ((tinput is string) ? IL2CPP.ManagedStringToIl2Cpp(tinput as string) : IL2CPP.Il2CppObjectBaseToPtr(tinput as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref input;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Converter<TInput, TOutput>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TOutput>(intPtr2, false, true);
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0000440B File Offset: 0x0000260B
		public Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00004414 File Offset: 0x00002614
		public static implicit operator Converter<TInput, TOutput>(Func<TInput, TOutput> A_0)
		{
			return DelegateSupport.ConvertDelegate<Converter<TInput, TOutput>>(A_0);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0000441C File Offset: 0x0000261C
		public static Converter<TInput, TOutput>operator +(Converter<TInput, TOutput> A_0, Converter<TInput, TOutput> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Converter<TInput, TOutput>>();
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0000442A File Offset: 0x0000262A
		public static Converter<TInput, TOutput>operator -(Converter<TInput, TOutput> A_0, Converter<TInput, TOutput> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Converter<TInput, TOutput>>();
			}
			return delegate2;
		}

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0;
	}
}
