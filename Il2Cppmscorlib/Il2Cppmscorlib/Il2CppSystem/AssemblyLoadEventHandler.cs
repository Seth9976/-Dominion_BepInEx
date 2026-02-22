using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200010D RID: 269
	[Serializable]
	public sealed class AssemblyLoadEventHandler : MulticastDelegate
	{
		// Token: 0x060013E1 RID: 5089 RVA: 0x0007D418 File Offset: 0x0007B618
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoadEventHandler()
		{
			Il2CppClassPointerStore<AssemblyLoadEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AssemblyLoadEventHandler");
			AssemblyLoadEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyLoadEventHandler>.NativeClassPtr, 100666706);
			AssemblyLoadEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_AssemblyLoadEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyLoadEventHandler>.NativeClassPtr, 100666707);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0007D468 File Offset: 0x0007B668
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyLoadEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyLoadEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyLoadEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0007D4C4 File Offset: 0x0007B6C4
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object sender, AssemblyLoadEventArgs args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyLoadEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_AssemblyLoadEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00006F36 File Offset: 0x00005136
		public AssemblyLoadEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00006F3F File Offset: 0x0000513F
		public static implicit operator AssemblyLoadEventHandler(Action<Object, AssemblyLoadEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<AssemblyLoadEventHandler>(A_0);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00006F47 File Offset: 0x00005147
		public static AssemblyLoadEventHandler operator +(AssemblyLoadEventHandler A_0, AssemblyLoadEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AssemblyLoadEventHandler>();
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00006F55 File Offset: 0x00005155
		public static AssemblyLoadEventHandler operator -(AssemblyLoadEventHandler A_0, AssemblyLoadEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AssemblyLoadEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_AssemblyLoadEventArgs_0;
	}
}
