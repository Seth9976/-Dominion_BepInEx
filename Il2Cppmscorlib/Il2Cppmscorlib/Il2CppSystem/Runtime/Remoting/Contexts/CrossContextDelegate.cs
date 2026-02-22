using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003B8 RID: 952
	public sealed class CrossContextDelegate : MulticastDelegate
	{
		// Token: 0x06003DCF RID: 15823 RVA: 0x001219FC File Offset: 0x0011FBFC
		// Note: this type is marked as 'beforefieldinit'.
		static CrossContextDelegate()
		{
			Il2CppClassPointerStore<CrossContextDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "CrossContextDelegate");
			CrossContextDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextDelegate>.NativeClassPtr, 100672394);
			CrossContextDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextDelegate>.NativeClassPtr, 100672395);
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x00121A4C File Offset: 0x0011FC4C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossContextDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContextDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00121AA8 File Offset: 0x0011FCA8
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x00017414 File Offset: 0x00015614
		public CrossContextDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x0001741D File Offset: 0x0001561D
		public static implicit operator CrossContextDelegate(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<CrossContextDelegate>(A_0);
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00017425 File Offset: 0x00015625
		public static CrossContextDelegate operator +(CrossContextDelegate A_0, CrossContextDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CrossContextDelegate>();
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x00017433 File Offset: 0x00015633
		public static CrossContextDelegate operator -(CrossContextDelegate A_0, CrossContextDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CrossContextDelegate>();
			}
			return delegate2;
		}

		// Token: 0x0400331D RID: 13085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400331E RID: 13086
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}
