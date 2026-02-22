using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003F4 RID: 1012
	public sealed class HeaderHandler : MulticastDelegate
	{
		// Token: 0x06004000 RID: 16384 RVA: 0x00129240 File Offset: 0x00127440
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderHandler()
		{
			Il2CppClassPointerStore<HeaderHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "HeaderHandler");
			HeaderHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderHandler>.NativeClassPtr, 100672643);
			HeaderHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Header_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderHandler>.NativeClassPtr, 100672644);
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00129290 File Offset: 0x00127490
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x001292EC File Offset: 0x001274EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318952, RefRangeEnd = 318953, XrefRangeStart = 318952, XrefRangeEnd = 318953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Invoke(Il2CppReferenceArray<Header> headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Header_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x000183FA File Offset: 0x000165FA
		public HeaderHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x00018403 File Offset: 0x00016603
		public static implicit operator HeaderHandler(Func<Il2CppReferenceArray<Header>, Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<HeaderHandler>(A_0);
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x0001840B File Offset: 0x0001660B
		public static HeaderHandler operator +(HeaderHandler A_0, HeaderHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<HeaderHandler>();
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x00018419 File Offset: 0x00016619
		public static HeaderHandler operator -(HeaderHandler A_0, HeaderHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<HeaderHandler>();
			}
			return delegate2;
		}

		// Token: 0x04003473 RID: 13427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003474 RID: 13428
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Header_0;
	}
}
