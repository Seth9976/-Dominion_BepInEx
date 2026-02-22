using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000293 RID: 659
	public sealed class TimerCallback : MulticastDelegate
	{
		// Token: 0x06002CF0 RID: 11504 RVA: 0x000E3E8C File Offset: 0x000E208C
		// Note: this type is marked as 'beforefieldinit'.
		static TimerCallback()
		{
			Il2CppClassPointerStore<TimerCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "TimerCallback");
			TimerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerCallback>.NativeClassPtr, 100670385);
			TimerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerCallback>.NativeClassPtr, 100670386);
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x000E3EDC File Offset: 0x000E20DC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x000E3F38 File Offset: 0x000E2138
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x0000FD1B File Offset: 0x0000DF1B
		public TimerCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x0000FD24 File Offset: 0x0000DF24
		public static implicit operator TimerCallback(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<TimerCallback>(A_0);
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x0000FD2C File Offset: 0x0000DF2C
		public static TimerCallback operator +(TimerCallback A_0, TimerCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<TimerCallback>();
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x0000FD3A File Offset: 0x0000DF3A
		public static TimerCallback operator -(TimerCallback A_0, TimerCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<TimerCallback>();
			}
			return delegate2;
		}

		// Token: 0x040026E8 RID: 9960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040026E9 RID: 9961
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
