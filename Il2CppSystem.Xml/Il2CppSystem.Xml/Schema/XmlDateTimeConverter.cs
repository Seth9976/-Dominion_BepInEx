using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000107 RID: 263
	public class XmlDateTimeConverter : XmlBaseConverter
	{
		// Token: 0x06001072 RID: 4210 RVA: 0x0004D178 File Offset: 0x0004B378
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDateTimeConverter()
		{
			Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlDateTimeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr);
			XmlDateTimeConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665716);
			XmlDateTimeConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665717);
			XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665718);
			XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665719);
			XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665720);
			XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665721);
			XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665722);
			XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665723);
			XmlDateTimeConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665724);
			XmlDateTimeConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665725);
			XmlDateTimeConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665726);
			XmlDateTimeConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665727);
			XmlDateTimeConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665728);
			XmlDateTimeConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr, 100665729);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0004D2C0 File Offset: 0x0004B4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27109, XrefRangeEnd = 27113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDateTimeConverter(XmlSchemaType schemaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDateTimeConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDateTimeConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0004D30C File Offset: 0x0004B50C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27120, RefRangeEnd = 27121, XrefRangeStart = 27113, XrefRangeEnd = 27120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDateTimeConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0004D350 File Offset: 0x0004B550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27121, XrefRangeEnd = 27125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0004D3A4 File Offset: 0x0004B5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27125, XrefRangeEnd = 27156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0004D3FC File Offset: 0x0004B5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27156, XrefRangeEnd = 27193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0004D454 File Offset: 0x0004B654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27193, XrefRangeEnd = 27194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0004D4A8 File Offset: 0x0004B6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27194, XrefRangeEnd = 27198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0004D500 File Offset: 0x0004B700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27198, XrefRangeEnd = 27238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0004D558 File Offset: 0x0004B758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27238, XrefRangeEnd = 27263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0004D5A8 File Offset: 0x0004B7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27263, XrefRangeEnd = 27267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0004D5F8 File Offset: 0x0004B7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27267, XrefRangeEnd = 27304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0004D660 File Offset: 0x0004B860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27304, XrefRangeEnd = 27358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(DateTime value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0004D6CC File Offset: 0x0004B8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27358, XrefRangeEnd = 27410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0004D74C File Offset: 0x0004B94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27410, XrefRangeEnd = 27542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDateTimeConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x000076FF File Offset: 0x000058FF
		public XmlDateTimeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;
	}
}
