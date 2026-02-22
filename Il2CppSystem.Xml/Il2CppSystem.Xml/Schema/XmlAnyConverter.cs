using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.XPath;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010C RID: 268
	public class XmlAnyConverter : XmlBaseConverter
	{
		// Token: 0x060010CC RID: 4300 RVA: 0x0004F46C File Offset: 0x0004D66C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyConverter()
		{
			Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlAnyConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr);
			XmlAnyConverter.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, "Item");
			XmlAnyConverter.NativeFieldInfoPtr_AnyAtomic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, "AnyAtomic");
			XmlAnyConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665791);
			XmlAnyConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665792);
			XmlAnyConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665793);
			XmlAnyConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665794);
			XmlAnyConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665795);
			XmlAnyConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665796);
			XmlAnyConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665797);
			XmlAnyConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665798);
			XmlAnyConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665799);
			XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665800);
			XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665801);
			XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665802);
			XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665803);
			XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665804);
			XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665805);
			XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665806);
			XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665807);
			XmlAnyConverter.NativeMethodInfoPtr_ChangeTypeWildcardDestination_Private_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665808);
			XmlAnyConverter.NativeMethodInfoPtr_ChangeTypeWildcardSource_Private_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665809);
			XmlAnyConverter.NativeMethodInfoPtr_ToNavigator_Private_XPathNavigator_XPathNavigator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr, 100665810);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0004F654 File Offset: 0x0004D854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29634, XrefRangeEnd = 29642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAnyConverter(XmlTypeCode typeCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAnyConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0004F69C File Offset: 0x0004D89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29642, XrefRangeEnd = 29659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0004F6F4 File Offset: 0x0004D8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29659, XrefRangeEnd = 29676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0004F74C File Offset: 0x0004D94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29676, XrefRangeEnd = 29698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0004F7A4 File Offset: 0x0004D9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29698, XrefRangeEnd = 29720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0004F7FC File Offset: 0x0004D9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29720, XrefRangeEnd = 29737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0004F854 File Offset: 0x0004DA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29737, XrefRangeEnd = 29754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0004F8AC File Offset: 0x0004DAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29754, XrefRangeEnd = 29771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0004F904 File Offset: 0x0004DB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29771, XrefRangeEnd = 29793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0004F95C File Offset: 0x0004DB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29793, XrefRangeEnd = 29815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0004F9C8 File Offset: 0x0004DBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29815, XrefRangeEnd = 29837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0004FA34 File Offset: 0x0004DC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29837, XrefRangeEnd = 29859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0004FAA0 File Offset: 0x0004DCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29859, XrefRangeEnd = 29881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(double value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0004FB0C File Offset: 0x0004DD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29881, XrefRangeEnd = 29903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0004FB78 File Offset: 0x0004DD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29903, XrefRangeEnd = 29925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0004FBE4 File Offset: 0x0004DDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29925, XrefRangeEnd = 29944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0004FC64 File Offset: 0x0004DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29944, XrefRangeEnd = 30300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0004FCE4 File Offset: 0x0004DEE4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 30313, RefRangeEnd = 30321, XrefRangeStart = 30300, XrefRangeEnd = 30313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyConverter.NativeMethodInfoPtr_ChangeTypeWildcardDestination_Private_Object_Object_Type_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0004FD58 File Offset: 0x0004DF58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 30330, RefRangeEnd = 30337, XrefRangeStart = 30321, XrefRangeEnd = 30330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyConverter.NativeMethodInfoPtr_ChangeTypeWildcardSource_Private_Object_Object_Type_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0004FDCC File Offset: 0x0004DFCC
		[CallerCount(0)]
		public unsafe XPathNavigator ToNavigator(XPathNavigator nav)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nav);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyConverter.NativeMethodInfoPtr_ToNavigator_Private_XPathNavigator_XPathNavigator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNavigator>(intPtr3) : null;
			}
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0000776B File Offset: 0x0000596B
		public XmlAnyConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x0004FE1C File Offset: 0x0004E01C
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00007774 File Offset: 0x00005974
		public unsafe static XmlValueConverter Item
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlAnyConverter.NativeFieldInfoPtr_Item, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlAnyConverter.NativeFieldInfoPtr_Item, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0004FE44 File Offset: 0x0004E044
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00007786 File Offset: 0x00005986
		public unsafe static XmlValueConverter AnyAtomic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlAnyConverter.NativeFieldInfoPtr_AnyAtomic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlAnyConverter.NativeFieldInfoPtr_AnyAtomic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeFieldInfoPtr_AnyAtomic;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTypeWildcardDestination_Private_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTypeWildcardSource_Private_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_ToNavigator_Private_XPathNavigator_XPathNavigator_0;
	}
}
