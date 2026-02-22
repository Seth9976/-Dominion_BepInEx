using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000105 RID: 261
	public class XmlNumeric10Converter : XmlBaseConverter
	{
		// Token: 0x0600104C RID: 4172 RVA: 0x0004C1EC File Offset: 0x0004A3EC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNumeric10Converter()
		{
			Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlNumeric10Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr);
			XmlNumeric10Converter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665682);
			XmlNumeric10Converter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665683);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665684);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665685);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665686);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665687);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665688);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665689);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665690);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665691);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665692);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665693);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665694);
			XmlNumeric10Converter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665695);
			XmlNumeric10Converter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665696);
			XmlNumeric10Converter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665697);
			XmlNumeric10Converter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665698);
			XmlNumeric10Converter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665699);
			XmlNumeric10Converter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665700);
			XmlNumeric10Converter.NativeMethodInfoPtr_ChangeTypeWildcardDestination_Private_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665701);
			XmlNumeric10Converter.NativeMethodInfoPtr_ChangeTypeWildcardSource_Private_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr, 100665702);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0004C3C0 File Offset: 0x0004A5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25827, XrefRangeEnd = 25831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNumeric10Converter(XmlSchemaType schemaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNumeric10Converter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNumeric10Converter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0004C40C File Offset: 0x0004A60C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25838, RefRangeEnd = 25839, XrefRangeStart = 25831, XrefRangeEnd = 25838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNumeric10Converter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0004C450 File Offset: 0x0004A650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25839, XrefRangeEnd = 25843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0004C4A8 File Offset: 0x0004A6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25843, XrefRangeEnd = 25893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0004C500 File Offset: 0x0004A700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25893, XrefRangeEnd = 25897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0004C554 File Offset: 0x0004A754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25897, XrefRangeEnd = 25907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0004C5AC File Offset: 0x0004A7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25907, XrefRangeEnd = 25952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0004C604 File Offset: 0x0004A804
		[CallerCount(0)]
		public unsafe override long ToInt64(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0004C658 File Offset: 0x0004A858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25952, XrefRangeEnd = 25962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0004C6B0 File Offset: 0x0004A8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25962, XrefRangeEnd = 26007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0004C708 File Offset: 0x0004A908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26007, XrefRangeEnd = 26015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0004C758 File Offset: 0x0004A958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26015, XrefRangeEnd = 26019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0004C7A8 File Offset: 0x0004A9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26019, XrefRangeEnd = 26023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0004C7F8 File Offset: 0x0004A9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26023, XrefRangeEnd = 26069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0004C860 File Offset: 0x0004AA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26069, XrefRangeEnd = 26141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Decimal value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0004C8CC File Offset: 0x0004AACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26141, XrefRangeEnd = 26207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(int value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0004C938 File Offset: 0x0004AB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26207, XrefRangeEnd = 26273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(long value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0004C9A4 File Offset: 0x0004ABA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26273, XrefRangeEnd = 26333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0004CA24 File Offset: 0x0004AC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26333, XrefRangeEnd = 26594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNumeric10Converter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0004CAA4 File Offset: 0x0004ACA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 26640, RefRangeEnd = 26644, XrefRangeStart = 26594, XrefRangeEnd = 26640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ChangeTypeWildcardDestination(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNumeric10Converter.NativeMethodInfoPtr_ChangeTypeWildcardDestination_Private_Object_Object_Type_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0004CB18 File Offset: 0x0004AD18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 26720, RefRangeEnd = 26724, XrefRangeStart = 26644, XrefRangeEnd = 26720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ChangeTypeWildcardSource(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNumeric10Converter.NativeMethodInfoPtr_ChangeTypeWildcardSource_Private_Object_Object_Type_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x000076ED File Offset: 0x000058ED
		public XmlNumeric10Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTypeWildcardDestination_Private_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTypeWildcardSource_Private_Object_Object_Type_IXmlNamespaceResolver_0;
	}
}
