using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003D RID: 61
	public sealed class XmlNodeChangedEventHandler : MulticastDelegate
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x00020D48 File Offset: 0x0001EF48
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeChangedEventHandler()
		{
			Il2CppClassPointerStore<XmlNodeChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNodeChangedEventHandler");
			XmlNodeChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeChangedEventHandler>.NativeClassPtr, 100664221);
			XmlNodeChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeChangedEventHandler>.NativeClassPtr, 100664222);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00020D98 File Offset: 0x0001EF98
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeChangedEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeChangedEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00020DF4 File Offset: 0x0001EFF4
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object sender, XmlNodeChangedEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00003EA9 File Offset: 0x000020A9
		public XmlNodeChangedEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00003EB2 File Offset: 0x000020B2
		public static implicit operator XmlNodeChangedEventHandler(Action<Object, XmlNodeChangedEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<XmlNodeChangedEventHandler>(A_0);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00003EBA File Offset: 0x000020BA
		public static XmlNodeChangedEventHandler operator +(XmlNodeChangedEventHandler A_0, XmlNodeChangedEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<XmlNodeChangedEventHandler>();
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00003EC8 File Offset: 0x000020C8
		public static XmlNodeChangedEventHandler operator -(XmlNodeChangedEventHandler A_0, XmlNodeChangedEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<XmlNodeChangedEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeChangedEventArgs_0;
	}
}
