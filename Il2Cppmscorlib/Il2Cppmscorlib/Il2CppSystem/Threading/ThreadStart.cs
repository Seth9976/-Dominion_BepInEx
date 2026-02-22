using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000286 RID: 646
	public sealed class ThreadStart : MulticastDelegate
	{
		// Token: 0x06002C0A RID: 11274 RVA: 0x000E10D8 File Offset: 0x000DF2D8
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadStart()
		{
			Il2CppClassPointerStore<ThreadStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadStart");
			ThreadStart.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadStart>.NativeClassPtr, 100670300);
			ThreadStart.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadStart>.NativeClassPtr, 100670301);
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000E1128 File Offset: 0x000DF328
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadStart(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadStart>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadStart.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000E1184 File Offset: 0x000DF384
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadStart.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x0000F55E File Offset: 0x0000D75E
		public ThreadStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x0000F567 File Offset: 0x0000D767
		public static implicit operator ThreadStart(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<ThreadStart>(A_0);
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x0000F56F File Offset: 0x0000D76F
		public static ThreadStart operator +(ThreadStart A_0, ThreadStart A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ThreadStart>();
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x0000F57D File Offset: 0x0000D77D
		public static ThreadStart operator -(ThreadStart A_0, ThreadStart A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ThreadStart>();
			}
			return delegate2;
		}

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}
