using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000A1 RID: 161
	[Serializable]
	public sealed class EventHandler : MulticastDelegate
	{
		// Token: 0x06000B62 RID: 2914 RVA: 0x00055ACC File Offset: 0x00053CCC
		// Note: this type is marked as 'beforefieldinit'.
		static EventHandler()
		{
			Il2CppClassPointerStore<EventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "EventHandler");
			EventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler>.NativeClassPtr, 100665227);
			EventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandler>.NativeClassPtr, 100665228);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00055B1C File Offset: 0x00053D1C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00055B78 File Offset: 0x00053D78
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object sender, EventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00004E49 File Offset: 0x00003049
		public EventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00004E52 File Offset: 0x00003052
		public static implicit operator EventHandler(Action<Object, EventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<EventHandler>(A_0);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00004E5A File Offset: 0x0000305A
		public static EventHandler operator +(EventHandler A_0, EventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<EventHandler>();
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00004E68 File Offset: 0x00003068
		public static EventHandler operator -(EventHandler A_0, EventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<EventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_EventArgs_0;
	}
}
