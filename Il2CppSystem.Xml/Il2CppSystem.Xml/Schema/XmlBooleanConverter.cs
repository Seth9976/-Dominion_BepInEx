using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000108 RID: 264
	public class XmlBooleanConverter : XmlBaseConverter
	{
		// Token: 0x06001082 RID: 4226 RVA: 0x0004D7CC File Offset: 0x0004B9CC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlBooleanConverter()
		{
			Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlBooleanConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr);
			XmlBooleanConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr, 100665730);
			XmlBooleanConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr, 100665731);
			XmlBooleanConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr, 100665732);
			XmlBooleanConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr, 100665733);
			XmlBooleanConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr, 100665734);
			XmlBooleanConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr, 100665735);
			XmlBooleanConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr, 100665736);
			XmlBooleanConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr, 100665737);
			XmlBooleanConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr, 100665738);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0004D8B0 File Offset: 0x0004BAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27542, XrefRangeEnd = 27546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBooleanConverter(XmlSchemaType schemaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBooleanConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBooleanConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0004D8FC File Offset: 0x0004BAFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27553, RefRangeEnd = 27554, XrefRangeStart = 27546, XrefRangeEnd = 27553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBooleanConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0004D940 File Offset: 0x0004BB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27554, XrefRangeEnd = 27564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBooleanConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0004D998 File Offset: 0x0004BB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27564, XrefRangeEnd = 27595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBooleanConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0004D9F0 File Offset: 0x0004BBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27595, XrefRangeEnd = 27602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBooleanConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0004DA40 File Offset: 0x0004BC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27602, XrefRangeEnd = 27633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(Object value, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBooleanConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0004DAA8 File Offset: 0x0004BCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27633, XrefRangeEnd = 27674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(bool value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBooleanConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0004DB14 File Offset: 0x0004BD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27674, XrefRangeEnd = 27713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBooleanConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0004DB94 File Offset: 0x0004BD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27713, XrefRangeEnd = 27804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBooleanConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00007708 File Offset: 0x00005908
		public XmlBooleanConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;
	}
}
