using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	public sealed class UnhandledExceptionEventHandler : MulticastDelegate
	{
		// Token: 0x060012B5 RID: 4789 RVA: 0x00079288 File Offset: 0x00077488
		// Note: this type is marked as 'beforefieldinit'.
		static UnhandledExceptionEventHandler()
		{
			Il2CppClassPointerStore<UnhandledExceptionEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnhandledExceptionEventHandler");
			UnhandledExceptionEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventHandler>.NativeClassPtr, 100666569);
			UnhandledExceptionEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_UnhandledExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventHandler>.NativeClassPtr, 100666570);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000792D8 File Offset: 0x000774D8
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnhandledExceptionEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnhandledExceptionEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00079334 File Offset: 0x00077534
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object sender, UnhandledExceptionEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_UnhandledExceptionEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000066B4 File Offset: 0x000048B4
		public UnhandledExceptionEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000066BD File Offset: 0x000048BD
		public static implicit operator UnhandledExceptionEventHandler(Action<Object, UnhandledExceptionEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<UnhandledExceptionEventHandler>(A_0);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000066C5 File Offset: 0x000048C5
		public static UnhandledExceptionEventHandler operator +(UnhandledExceptionEventHandler A_0, UnhandledExceptionEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnhandledExceptionEventHandler>();
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000066D3 File Offset: 0x000048D3
		public static UnhandledExceptionEventHandler operator -(UnhandledExceptionEventHandler A_0, UnhandledExceptionEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UnhandledExceptionEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_UnhandledExceptionEventArgs_0;
	}
}
