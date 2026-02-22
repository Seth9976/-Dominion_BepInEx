using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000088 RID: 136
	public sealed class ConsoleCancelEventHandler : MulticastDelegate
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x00047D04 File Offset: 0x00045F04
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleCancelEventHandler()
		{
			Il2CppClassPointerStore<ConsoleCancelEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleCancelEventHandler");
			ConsoleCancelEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventHandler>.NativeClassPtr, 100664639);
			ConsoleCancelEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ConsoleCancelEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventHandler>.NativeClassPtr, 100664640);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00047D54 File Offset: 0x00045F54
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleCancelEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCancelEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00047DB0 File Offset: 0x00045FB0
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object sender, ConsoleCancelEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleCancelEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ConsoleCancelEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00004842 File Offset: 0x00002A42
		public ConsoleCancelEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0000484B File Offset: 0x00002A4B
		public static implicit operator ConsoleCancelEventHandler(Action<Object, ConsoleCancelEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<ConsoleCancelEventHandler>(A_0);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00004853 File Offset: 0x00002A53
		public static ConsoleCancelEventHandler operator +(ConsoleCancelEventHandler A_0, ConsoleCancelEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ConsoleCancelEventHandler>();
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00004861 File Offset: 0x00002A61
		public static ConsoleCancelEventHandler operator -(ConsoleCancelEventHandler A_0, ConsoleCancelEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ConsoleCancelEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ConsoleCancelEventArgs_0;
	}
}
