using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000103 RID: 259
	public class XmlValueConverter : Object
	{
		// Token: 0x06000F50 RID: 3920 RVA: 0x000471D4 File Offset: 0x000453D4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlValueConverter()
		{
			Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlValueConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665497);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665498);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665499);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665500);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665501);
			XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665502);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665503);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665504);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665505);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665506);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665507);
			XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665508);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665509);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665510);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665511);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665512);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665513);
			XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665514);
			XmlValueConverter.NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665515);
			XmlValueConverter.NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665516);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665517);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665518);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665519);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665520);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665521);
			XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665522);
			XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665523);
			XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665524);
			XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665525);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665526);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665527);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665528);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665529);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665530);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665531);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665532);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665533);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665534);
			XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665535);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665536);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665537);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665538);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665539);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665540);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665541);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665542);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665543);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665544);
			XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665545);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665546);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665547);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int64_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665548);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Decimal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665549);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Double_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665550);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_DateTime_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665551);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_String_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665552);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665553);
			XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665554);
			XmlValueConverter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr, 100665555);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x000476A0 File Offset: 0x000458A0
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x000476F4 File Offset: 0x000458F4
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00047748 File Offset: 0x00045948
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0004779C File Offset: 0x0004599C
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x000477F0 File Offset: 0x000459F0
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00047848 File Offset: 0x00045A48
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000478A0 File Offset: 0x00045AA0
		[CallerCount(0)]
		public unsafe virtual int ToInt32(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x000478F4 File Offset: 0x00045AF4
		[CallerCount(0)]
		public unsafe virtual int ToInt32(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00047948 File Offset: 0x00045B48
		[CallerCount(0)]
		public unsafe virtual int ToInt32(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0004799C File Offset: 0x00045B9C
		[CallerCount(0)]
		public unsafe virtual int ToInt32(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000479F0 File Offset: 0x00045BF0
		[CallerCount(0)]
		public unsafe virtual int ToInt32(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00047A48 File Offset: 0x00045C48
		[CallerCount(0)]
		public unsafe virtual int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00047AA0 File Offset: 0x00045CA0
		[CallerCount(0)]
		public unsafe virtual long ToInt64(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00047AF4 File Offset: 0x00045CF4
		[CallerCount(0)]
		public unsafe virtual long ToInt64(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00047B48 File Offset: 0x00045D48
		[CallerCount(0)]
		public unsafe virtual long ToInt64(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00047B9C File Offset: 0x00045D9C
		[CallerCount(0)]
		public unsafe virtual long ToInt64(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00047BF0 File Offset: 0x00045DF0
		[CallerCount(0)]
		public unsafe virtual long ToInt64(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00047C48 File Offset: 0x00045E48
		[CallerCount(0)]
		public unsafe virtual long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00047CA0 File Offset: 0x00045EA0
		[CallerCount(0)]
		public unsafe virtual Decimal ToDecimal(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00047CF8 File Offset: 0x00045EF8
		[CallerCount(0)]
		public unsafe virtual Decimal ToDecimal(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00047D50 File Offset: 0x00045F50
		[CallerCount(0)]
		public unsafe virtual double ToDouble(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00047DA4 File Offset: 0x00045FA4
		[CallerCount(0)]
		public unsafe virtual double ToDouble(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00047DF8 File Offset: 0x00045FF8
		[CallerCount(0)]
		public unsafe virtual double ToDouble(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00047E4C File Offset: 0x0004604C
		[CallerCount(0)]
		public unsafe virtual double ToDouble(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00047EA0 File Offset: 0x000460A0
		[CallerCount(0)]
		public unsafe virtual double ToDouble(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00047EF8 File Offset: 0x000460F8
		[CallerCount(0)]
		public unsafe virtual double ToDouble(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00047F50 File Offset: 0x00046150
		[CallerCount(0)]
		public unsafe virtual float ToSingle(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00047FA4 File Offset: 0x000461A4
		[CallerCount(0)]
		public unsafe virtual float ToSingle(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00047FFC File Offset: 0x000461FC
		[CallerCount(0)]
		public unsafe virtual float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00048054 File Offset: 0x00046254
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000480A8 File Offset: 0x000462A8
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x000480FC File Offset: 0x000462FC
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00048150 File Offset: 0x00046350
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x000481A4 File Offset: 0x000463A4
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x000481F8 File Offset: 0x000463F8
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00048250 File Offset: 0x00046450
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000482A8 File Offset: 0x000464A8
		[CallerCount(0)]
		public unsafe virtual DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x000482FC File Offset: 0x000464FC
		[CallerCount(0)]
		public unsafe virtual DateTimeOffset ToDateTimeOffset(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00048354 File Offset: 0x00046554
		[CallerCount(0)]
		public unsafe virtual DateTimeOffset ToDateTimeOffset(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000483AC File Offset: 0x000465AC
		[CallerCount(0)]
		public unsafe virtual string ToString(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x000483FC File Offset: 0x000465FC
		[CallerCount(0)]
		public unsafe virtual string ToString(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0004844C File Offset: 0x0004664C
		[CallerCount(0)]
		public unsafe virtual string ToString(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0004849C File Offset: 0x0004669C
		[CallerCount(0)]
		public unsafe virtual string ToString(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000484EC File Offset: 0x000466EC
		[CallerCount(0)]
		public unsafe virtual string ToString(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0004853C File Offset: 0x0004673C
		[CallerCount(0)]
		public unsafe virtual string ToString(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0004858C File Offset: 0x0004678C
		[CallerCount(0)]
		public unsafe virtual string ToString(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000485DC File Offset: 0x000467DC
		[CallerCount(0)]
		public unsafe virtual string ToString(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0004862C File Offset: 0x0004682C
		[CallerCount(0)]
		public unsafe virtual string ToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00048680 File Offset: 0x00046880
		[CallerCount(0)]
		public unsafe virtual string ToString(Object value, IXmlNamespaceResolver nsResolver)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x000486E8 File Offset: 0x000468E8
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(bool value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00048754 File Offset: 0x00046954
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(int value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int32_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x000487C0 File Offset: 0x000469C0
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(long value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int64_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0004882C File Offset: 0x00046A2C
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(Decimal value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Decimal_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00048898 File Offset: 0x00046A98
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(double value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Double_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00048904 File Offset: 0x00046B04
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(DateTime value, Type destinationType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_DateTime_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00048970 File Offset: 0x00046B70
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_String_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x000489F0 File Offset: 0x00046BF0
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(Object value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00048A60 File Offset: 0x00046C60
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlValueConverter.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00048AE0 File Offset: 0x00046CE0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlValueConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlValueConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValueConverter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00007478 File Offset: 0x00005678
		public XmlValueConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int64_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Double_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_DateTime_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Object_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Boolean_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Int64_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Double_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_DateTime_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Object_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Boolean_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Int32_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Double_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_DateTime_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_String_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Object_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_String_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_Object_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Boolean_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int32_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Int64_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_DateTime_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_String_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_Object_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Double_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_String_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Object_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Boolean_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int32_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Int64_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Double_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_DateTimeOffset_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_String_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_Object_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_DateTime_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_String_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Abstract_Virtual_New_DateTimeOffset_Object_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Boolean_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int32_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Int64_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Decimal_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Single_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Double_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTime_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_DateTimeOffset_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_IXmlNamespaceResolver_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Boolean_Type_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int32_Type_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Int64_Type_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Decimal_Type_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Double_Type_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_DateTime_Type_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_String_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
