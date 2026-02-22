using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000274 RID: 628
	public sealed class SendOrPostCallback : MulticastDelegate
	{
		// Token: 0x06002B19 RID: 11033 RVA: 0x000DDBFC File Offset: 0x000DBDFC
		// Note: this type is marked as 'beforefieldinit'.
		static SendOrPostCallback()
		{
			Il2CppClassPointerStore<SendOrPostCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SendOrPostCallback");
			SendOrPostCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendOrPostCallback>.NativeClassPtr, 100670151);
			SendOrPostCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendOrPostCallback>.NativeClassPtr, 100670152);
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x000DDC4C File Offset: 0x000DBE4C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendOrPostCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendOrPostCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendOrPostCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000DDCA8 File Offset: 0x000DBEA8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendOrPostCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x0000F068 File Offset: 0x0000D268
		public SendOrPostCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x0000F071 File Offset: 0x0000D271
		public static implicit operator SendOrPostCallback(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<SendOrPostCallback>(A_0);
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x0000F079 File Offset: 0x0000D279
		public static SendOrPostCallback operator +(SendOrPostCallback A_0, SendOrPostCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SendOrPostCallback>();
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x0000F087 File Offset: 0x0000D287
		public static SendOrPostCallback operator -(SendOrPostCallback A_0, SendOrPostCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SendOrPostCallback>();
			}
			return delegate2;
		}

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
