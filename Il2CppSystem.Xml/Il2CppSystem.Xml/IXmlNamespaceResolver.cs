using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000046 RID: 70
	public class IXmlNamespaceResolver : Il2CppObjectBase
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x00022830 File Offset: 0x00020A30
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlNamespaceResolver()
		{
			Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IXmlNamespaceResolver");
			IXmlNamespaceResolver.NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr, 100664284);
			IXmlNamespaceResolver.NativeMethodInfoPtr_LookupPrefix_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlNamespaceResolver>.NativeClassPtr, 100664285);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00022880 File Offset: 0x00020A80
		[CallerCount(0)]
		public unsafe virtual string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNamespaceResolver.NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x000228D4 File Offset: 0x00020AD4
		[CallerCount(0)]
		public unsafe virtual string LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlNamespaceResolver.NativeMethodInfoPtr_LookupPrefix_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00003FD7 File Offset: 0x000021D7
		public IXmlNamespaceResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Abstract_Virtual_New_String_String_0;
	}
}
