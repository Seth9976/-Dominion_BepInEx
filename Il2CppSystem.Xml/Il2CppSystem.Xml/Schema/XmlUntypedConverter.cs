using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010B RID: 267
	public class XmlUntypedConverter : XmlListConverter
	{
		// Token: 0x0600109D RID: 4253 RVA: 0x0004E23C File Offset: 0x0004C43C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlUntypedConverter()
		{
			Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlUntypedConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr);
			XmlUntypedConverter.NativeFieldInfoPtr_allowListToList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, "allowListToList");
			XmlUntypedConverter.NativeFieldInfoPtr_Untyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, "Untyped");
			XmlUntypedConverter.NativeFieldInfoPtr_UntypedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, "UntypedList");
			XmlUntypedConverter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665751);
			XmlUntypedConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlUntypedConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665752);
			XmlUntypedConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665753);
			XmlUntypedConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665754);
			XmlUntypedConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665755);
			XmlUntypedConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665756);
			XmlUntypedConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665757);
			XmlUntypedConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665758);
			XmlUntypedConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665759);
			XmlUntypedConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665760);
			XmlUntypedConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665761);
			XmlUntypedConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665762);
			XmlUntypedConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665763);
			XmlUntypedConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665764);
			XmlUntypedConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665765);
			XmlUntypedConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665766);
			XmlUntypedConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665767);
			XmlUntypedConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665768);
			XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665769);
			XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665770);
			XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665771);
			XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665772);
			XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665773);
			XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665774);
			XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665775);
			XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665776);
			XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665777);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665778);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665779);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665780);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665781);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665782);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665783);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665784);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665785);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeTypeWildcardDestination_Private_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665786);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeTypeWildcardSource_Private_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665787);
			XmlUntypedConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665788);
			XmlUntypedConverter.NativeMethodInfoPtr_SupportsType_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr, 100665789);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0004E5B4 File Offset: 0x0004C7B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 28241, RefRangeEnd = 28243, XrefRangeStart = 28232, XrefRangeEnd = 28241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUntypedConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUntypedConverter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0004E5F0 File Offset: 0x0004C7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28243, XrefRangeEnd = 28251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUntypedConverter(XmlUntypedConverter atomicConverter, bool allowListToList)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUntypedConverter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atomicConverter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowListToList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUntypedConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlUntypedConverter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0004E64C File Offset: 0x0004C84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28251, XrefRangeEnd = 28261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0004E6A4 File Offset: 0x0004C8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28261, XrefRangeEnd = 28279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0004E6FC File Offset: 0x0004C8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28279, XrefRangeEnd = 28289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0004E754 File Offset: 0x0004C954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28289, XrefRangeEnd = 28306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0004E7AC File Offset: 0x0004C9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28306, XrefRangeEnd = 28310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0004E804 File Offset: 0x0004CA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28310, XrefRangeEnd = 28327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0004E85C File Offset: 0x0004CA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28327, XrefRangeEnd = 28331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0004E8B4 File Offset: 0x0004CAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28331, XrefRangeEnd = 28349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0004E90C File Offset: 0x0004CB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28349, XrefRangeEnd = 28359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0004E964 File Offset: 0x0004CB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28359, XrefRangeEnd = 28377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0004E9BC File Offset: 0x0004CBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28377, XrefRangeEnd = 28387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0004EA14 File Offset: 0x0004CC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28387, XrefRangeEnd = 28405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0004EA6C File Offset: 0x0004CC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28405, XrefRangeEnd = 28415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0004EAC4 File Offset: 0x0004CCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28415, XrefRangeEnd = 28433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0004EB1C File Offset: 0x0004CD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28433, XrefRangeEnd = 28443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0004EB74 File Offset: 0x0004CD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28443, XrefRangeEnd = 28461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0004EBCC File Offset: 0x0004CDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28461, XrefRangeEnd = 28488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0004EC1C File Offset: 0x0004CE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28488, XrefRangeEnd = 28492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0004EC6C File Offset: 0x0004CE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28492, XrefRangeEnd = 28496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0004ECBC File Offset: 0x0004CEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28496, XrefRangeEnd = 28500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0004ED0C File Offset: 0x0004CF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28500, XrefRangeEnd = 28504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0004ED5C File Offset: 0x0004CF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28504, XrefRangeEnd = 28508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0004EDAC File Offset: 0x0004CFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28508, XrefRangeEnd = 28512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0004EDFC File Offset: 0x0004CFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28512, XrefRangeEnd = 28516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0004EE4C File Offset: 0x0004D04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28516, XrefRangeEnd = 28666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0004EEB4 File Offset: 0x0004D0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28666, XrefRangeEnd = 28688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0004EF20 File Offset: 0x0004D120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28688, XrefRangeEnd = 28709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0004EF8C File Offset: 0x0004D18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28709, XrefRangeEnd = 28731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0004EFF8 File Offset: 0x0004D1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28731, XrefRangeEnd = 28753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0004F064 File Offset: 0x0004D264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28753, XrefRangeEnd = 28775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0004F0D0 File Offset: 0x0004D2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28775, XrefRangeEnd = 28797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0004F13C File Offset: 0x0004D33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28797, XrefRangeEnd = 28983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0004F1BC File Offset: 0x0004D3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28983, XrefRangeEnd = 29415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0004F23C File Offset: 0x0004D43C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 29428, RefRangeEnd = 29437, XrefRangeStart = 29415, XrefRangeEnd = 29428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUntypedConverter.NativeMethodInfoPtr_ChangeTypeWildcardDestination_Private_Object_Object_Type_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0004F2B0 File Offset: 0x0004D4B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 29456, RefRangeEnd = 29463, XrefRangeStart = 29437, XrefRangeEnd = 29456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUntypedConverter.NativeMethodInfoPtr_ChangeTypeWildcardSource_Private_Object_Object_Type_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0004F324 File Offset: 0x0004D524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29463, XrefRangeEnd = 29522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeListType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUntypedConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0004F3A4 File Offset: 0x0004D5A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29632, RefRangeEnd = 29634, XrefRangeStart = 29522, XrefRangeEnd = 29632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SupportsType(Type clrType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clrType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUntypedConverter.NativeMethodInfoPtr_SupportsType_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00007723 File Offset: 0x00005923
		public XmlUntypedConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x0004F3F4 File Offset: 0x0004D5F4
		// (set) Token: 0x060010C7 RID: 4295 RVA: 0x0000772C File Offset: 0x0000592C
		public unsafe bool allowListToList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUntypedConverter.NativeFieldInfoPtr_allowListToList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUntypedConverter.NativeFieldInfoPtr_allowListToList)) = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0004F41C File Offset: 0x0004D61C
		// (set) Token: 0x060010C9 RID: 4297 RVA: 0x00007747 File Offset: 0x00005947
		public unsafe static XmlValueConverter Untyped
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlUntypedConverter.NativeFieldInfoPtr_Untyped, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlUntypedConverter.NativeFieldInfoPtr_Untyped, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x0004F444 File Offset: 0x0004D644
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x00007759 File Offset: 0x00005959
		public unsafe static XmlValueConverter UntypedList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlUntypedConverter.NativeFieldInfoPtr_UntypedList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlUntypedConverter.NativeFieldInfoPtr_UntypedList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_allowListToList;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeFieldInfoPtr_Untyped;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeFieldInfoPtr_UntypedList;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlUntypedConverter_Boolean_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTypeWildcardDestination_Private_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTypeWildcardSource_Private_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_ChangeListType_Protected_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_SupportsType_Private_Boolean_Type_0;
	}
}
