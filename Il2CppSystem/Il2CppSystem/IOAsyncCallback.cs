using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000040 RID: 64
	public sealed class IOAsyncCallback : MulticastDelegate
	{
		// Token: 0x060003B3 RID: 947 RVA: 0x0001F8E4 File Offset: 0x0001DAE4
		// Note: this type is marked as 'beforefieldinit'.
		static IOAsyncCallback()
		{
			Il2CppClassPointerStore<IOAsyncCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IOAsyncCallback");
			IOAsyncCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncCallback>.NativeClassPtr, 100663887);
			IOAsyncCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncCallback>.NativeClassPtr, 100663888);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0001F934 File Offset: 0x0001DB34
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOAsyncCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOAsyncCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0001F990 File Offset: 0x0001DB90
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 37089, RefRangeEnd = 37101, XrefRangeStart = 37071, XrefRangeEnd = 37089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(IOAsyncResult ioares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ioares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000342F File Offset: 0x0000162F
		public IOAsyncCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00003438 File Offset: 0x00001638
		public static implicit operator IOAsyncCallback(Action<IOAsyncResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<IOAsyncCallback>(A_0);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00003440 File Offset: 0x00001640
		public static IOAsyncCallback operator +(IOAsyncCallback A_0, IOAsyncCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<IOAsyncCallback>();
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000344E File Offset: 0x0000164E
		public static IOAsyncCallback operator -(IOAsyncCallback A_0, IOAsyncCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<IOAsyncCallback>();
			}
			return delegate2;
		}

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IOAsyncResult_0;
	}
}
