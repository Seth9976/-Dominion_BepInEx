using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200012D RID: 301
	[Serializable]
	public sealed class ResolveEventHandler : MulticastDelegate
	{
		// Token: 0x0600159C RID: 5532 RVA: 0x000842F0 File Offset: 0x000824F0
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveEventHandler()
		{
			Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ResolveEventHandler");
			ResolveEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr, 100666962);
			ResolveEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Assembly_Object_ResolveEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr, 100666963);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00084340 File Offset: 0x00082540
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0008439C File Offset: 0x0008259C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 225167, RefRangeEnd = 225172, XrefRangeStart = 225167, XrefRangeEnd = 225172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly Invoke(Object sender, ResolveEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Assembly_Object_ResolveEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000077EE File Offset: 0x000059EE
		public ResolveEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000077F7 File Offset: 0x000059F7
		public static implicit operator ResolveEventHandler(Func<Object, ResolveEventArgs, Assembly> A_0)
		{
			return DelegateSupport.ConvertDelegate<ResolveEventHandler>(A_0);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x000077FF File Offset: 0x000059FF
		public static ResolveEventHandler operator +(ResolveEventHandler A_0, ResolveEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ResolveEventHandler>();
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x0000780D File Offset: 0x00005A0D
		public static ResolveEventHandler operator -(ResolveEventHandler A_0, ResolveEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ResolveEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Assembly_Object_ResolveEventArgs_0;
	}
}
