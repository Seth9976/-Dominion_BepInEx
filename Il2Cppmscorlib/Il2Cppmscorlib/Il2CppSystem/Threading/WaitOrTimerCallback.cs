using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200027F RID: 639
	public sealed class WaitOrTimerCallback : MulticastDelegate
	{
		// Token: 0x06002BB3 RID: 11187 RVA: 0x000DFFA0 File Offset: 0x000DE1A0
		// Note: this type is marked as 'beforefieldinit'.
		static WaitOrTimerCallback()
		{
			Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitOrTimerCallback");
			WaitOrTimerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr, 100670247);
			WaitOrTimerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr, 100670248);
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x000DFFF0 File Offset: 0x000DE1F0
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitOrTimerCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitOrTimerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000E004C File Offset: 0x000DE24C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332892, RefRangeEnd = 332893, XrefRangeStart = 332873, XrefRangeEnd = 332892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object state, bool timedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitOrTimerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x0000F31E File Offset: 0x0000D51E
		public WaitOrTimerCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x0000F327 File Offset: 0x0000D527
		public static implicit operator WaitOrTimerCallback(Action<Object, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<WaitOrTimerCallback>(A_0);
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x0000F32F File Offset: 0x0000D52F
		public static WaitOrTimerCallback operator +(WaitOrTimerCallback A_0, WaitOrTimerCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<WaitOrTimerCallback>();
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x0000F33D File Offset: 0x0000D53D
		public static WaitOrTimerCallback operator -(WaitOrTimerCallback A_0, WaitOrTimerCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<WaitOrTimerCallback>();
			}
			return delegate2;
		}

		// Token: 0x04002617 RID: 9751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002618 RID: 9752
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Boolean_0;
	}
}
