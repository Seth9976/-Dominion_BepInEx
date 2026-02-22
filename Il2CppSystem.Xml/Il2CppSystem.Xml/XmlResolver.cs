using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000066 RID: 102
	public class XmlResolver : Object
	{
		// Token: 0x06000821 RID: 2081 RVA: 0x0002C368 File Offset: 0x0002A568
		// Note: this type is marked as 'beforefieldinit'.
		static XmlResolver()
		{
			Il2CppClassPointerStore<XmlResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr);
			XmlResolver.NativeMethodInfoPtr_GetEntity_Public_Abstract_Virtual_New_Object_Uri_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr, 100664633);
			XmlResolver.NativeMethodInfoPtr_ResolveUri_Public_Virtual_New_Uri_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr, 100664634);
			XmlResolver.NativeMethodInfoPtr_SupportsType_Public_Virtual_New_Boolean_Uri_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr, 100664635);
			XmlResolver.NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_New_Task_1_Object_Uri_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr, 100664636);
			XmlResolver.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr, 100664637);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0002C3FC File Offset: 0x0002A5FC
		[CallerCount(0)]
		public unsafe virtual Object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(role);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ofObjectToReturn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlResolver.NativeMethodInfoPtr_GetEntity_Public_Abstract_Virtual_New_Object_Uri_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0002C47C File Offset: 0x0002A67C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21103, RefRangeEnd = 21104, XrefRangeStart = 21092, XrefRangeEnd = 21103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlResolver.NativeMethodInfoPtr_ResolveUri_Public_Virtual_New_Uri_Uri_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0002C4EC File Offset: 0x0002A6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21104, XrefRangeEnd = 21118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SupportsType(Uri absoluteUri, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlResolver.NativeMethodInfoPtr_SupportsType_Public_Virtual_New_Boolean_Uri_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0002C558 File Offset: 0x0002A758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21118, XrefRangeEnd = 21123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(role);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ofObjectToReturn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlResolver.NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_New_Task_1_Object_Uri_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0002C5D8 File Offset: 0x0002A7D8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlResolver.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00004965 File Offset: 0x00002B65
		public XmlResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_GetEntity_Public_Abstract_Virtual_New_Object_Uri_String_Type_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_ResolveUri_Public_Virtual_New_Uri_Uri_String_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_SupportsType_Public_Virtual_New_Boolean_Uri_Type_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_New_Task_1_Object_Uri_String_Type_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
