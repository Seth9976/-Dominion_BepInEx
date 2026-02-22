using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000E2 RID: 226
	public sealed class ValidationEventHandler : MulticastDelegate
	{
		// Token: 0x06000E1B RID: 3611 RVA: 0x00043018 File Offset: 0x00041218
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationEventHandler()
		{
			Il2CppClassPointerStore<ValidationEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ValidationEventHandler");
			ValidationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventHandler>.NativeClassPtr, 100665367);
			ValidationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ValidationEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventHandler>.NativeClassPtr, 100665368);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00043068 File Offset: 0x00041268
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000430C4 File Offset: 0x000412C4
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object sender, ValidationEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ValidationEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00006B06 File Offset: 0x00004D06
		public ValidationEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00006B0F File Offset: 0x00004D0F
		public static implicit operator ValidationEventHandler(Action<Object, ValidationEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<ValidationEventHandler>(A_0);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00006B17 File Offset: 0x00004D17
		public static ValidationEventHandler operator +(ValidationEventHandler A_0, ValidationEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ValidationEventHandler>();
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00006B25 File Offset: 0x00004D25
		public static ValidationEventHandler operator -(ValidationEventHandler A_0, ValidationEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ValidationEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ValidationEventArgs_0;
	}
}
