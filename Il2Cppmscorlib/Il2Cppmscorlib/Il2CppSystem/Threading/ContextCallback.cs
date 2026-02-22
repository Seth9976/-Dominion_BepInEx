using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200026C RID: 620
	public sealed class ContextCallback : MulticastDelegate
	{
		// Token: 0x06002AA9 RID: 10921 RVA: 0x000DC0C8 File Offset: 0x000DA2C8
		// Note: this type is marked as 'beforefieldinit'.
		static ContextCallback()
		{
			Il2CppClassPointerStore<ContextCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ContextCallback");
			ContextCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextCallback>.NativeClassPtr, 100670075);
			ContextCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextCallback>.NativeClassPtr, 100670076);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000DC118 File Offset: 0x000DA318
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000DC174 File Offset: 0x000DA374
		[CallerCount(277)]
		[CachedScanResults(RefRangeStart = 94180, RefRangeEnd = 94457, XrefRangeStart = 94180, XrefRangeEnd = 94457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x0000EE19 File Offset: 0x0000D019
		public ContextCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x0000EE22 File Offset: 0x0000D022
		public static implicit operator ContextCallback(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<ContextCallback>(A_0);
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x0000EE2A File Offset: 0x0000D02A
		public static ContextCallback operator +(ContextCallback A_0, ContextCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ContextCallback>();
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x0000EE38 File Offset: 0x0000D038
		public static ContextCallback operator -(ContextCallback A_0, ContextCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ContextCallback>();
			}
			return delegate2;
		}

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
