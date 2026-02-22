using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200027E RID: 638
	public sealed class WaitCallback : MulticastDelegate
	{
		// Token: 0x06002BAC RID: 11180 RVA: 0x000DFEB0 File Offset: 0x000DE0B0
		// Note: this type is marked as 'beforefieldinit'.
		static WaitCallback()
		{
			Il2CppClassPointerStore<WaitCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitCallback");
			WaitCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitCallback>.NativeClassPtr, 100670245);
			WaitCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitCallback>.NativeClassPtr, 100670246);
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x000DFF00 File Offset: 0x000DE100
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000DFF5C File Offset: 0x000DE15C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 37089, RefRangeEnd = 37101, XrefRangeStart = 37089, XrefRangeEnd = 37101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x0000F2EE File Offset: 0x0000D4EE
		public WaitCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x0000F2F7 File Offset: 0x0000D4F7
		public static implicit operator WaitCallback(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<WaitCallback>(A_0);
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x0000F2FF File Offset: 0x0000D4FF
		public static WaitCallback operator +(WaitCallback A_0, WaitCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<WaitCallback>();
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x0000F30D File Offset: 0x0000D50D
		public static WaitCallback operator -(WaitCallback A_0, WaitCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<WaitCallback>();
			}
			return delegate2;
		}

		// Token: 0x04002615 RID: 9749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002616 RID: 9750
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
