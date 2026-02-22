using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F4 RID: 244
	public class XmlSchemaObject : Object
	{
		// Token: 0x06000ED3 RID: 3795 RVA: 0x00045974 File Offset: 0x00043B74
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaObject()
		{
			Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr);
			XmlSchemaObject.NativeMethodInfoPtr_OnAdd_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100665452);
			XmlSchemaObject.NativeMethodInfoPtr_OnRemove_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100665453);
			XmlSchemaObject.NativeMethodInfoPtr_OnClear_Internal_Virtual_New_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100665454);
			XmlSchemaObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr, 100665455);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x000459F4 File Offset: 0x00043BF4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAdd(XmlSchemaObjectCollection container, Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_OnAdd_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00045A54 File Offset: 0x00043C54
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRemove(XmlSchemaObjectCollection container, Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_OnRemove_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00045AB4 File Offset: 0x00043CB4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnClear(XmlSchemaObjectCollection container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObject.NativeMethodInfoPtr_OnClear_Internal_Virtual_New_Void_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00045B04 File Offset: 0x00043D04
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0000703E File Offset: 0x0000523E
		public XmlSchemaObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_OnAdd_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_OnRemove_Internal_Virtual_New_Void_XmlSchemaObjectCollection_Object_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_OnClear_Internal_Virtual_New_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
