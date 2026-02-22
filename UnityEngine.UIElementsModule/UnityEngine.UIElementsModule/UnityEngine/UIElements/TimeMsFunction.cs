using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001E RID: 30
	public sealed class TimeMsFunction : MulticastDelegate
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00011E14 File Offset: 0x00010014
		// Note: this type is marked as 'beforefieldinit'.
		static TimeMsFunction()
		{
			Il2CppClassPointerStore<TimeMsFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TimeMsFunction");
			TimeMsFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeMsFunction>.NativeClassPtr, 100663441);
			TimeMsFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeMsFunction>.NativeClassPtr, 100663442);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00011E64 File Offset: 0x00010064
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeMsFunction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeMsFunction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeMsFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00011EC0 File Offset: 0x000100C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91949, RefRangeEnd = 91951, XrefRangeStart = 91949, XrefRangeEnd = 91949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeMsFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002DD8 File Offset: 0x00000FD8
		public TimeMsFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002DE1 File Offset: 0x00000FE1
		public static implicit operator TimeMsFunction(Func<long> A_0)
		{
			return DelegateSupport.ConvertDelegate<TimeMsFunction>(A_0);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002DE9 File Offset: 0x00000FE9
		public static TimeMsFunction operator +(TimeMsFunction A_0, TimeMsFunction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<TimeMsFunction>();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002DF7 File Offset: 0x00000FF7
		public static TimeMsFunction operator -(TimeMsFunction A_0, TimeMsFunction A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<TimeMsFunction>();
			}
			return delegate2;
		}

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int64_0;
	}
}
