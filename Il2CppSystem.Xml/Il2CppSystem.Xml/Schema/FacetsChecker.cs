using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000CD RID: 205
	public class FacetsChecker : Object
	{
		// Token: 0x06000C9F RID: 3231 RVA: 0x0003CD50 File Offset: 0x0003AF50
		// Note: this type is marked as 'beforefieldinit'.
		static FacetsChecker()
		{
			Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "FacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr);
			FacetsChecker.NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665156);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665157);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665158);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665159);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665160);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665161);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665162);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665163);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665164);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665165);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665166);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665167);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665168);
			FacetsChecker.NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665169);
			FacetsChecker.NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665170);
			FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665171);
			FacetsChecker.NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665172);
			FacetsChecker.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100665173);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0003CEE8 File Offset: 0x0003B0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23568, XrefRangeEnd = 23585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(parseString);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			parseString = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr4) : null;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0003CF64 File Offset: 0x0003B164
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0003CFD4 File Offset: 0x0003B1D4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0003D040 File Offset: 0x0003B240
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0003D0AC File Offset: 0x0003B2AC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0003D118 File Offset: 0x0003B318
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0003D184 File Offset: 0x0003B384
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0003D1F0 File Offset: 0x0003B3F0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x0003D25C File Offset: 0x0003B45C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0003D2C8 File Offset: 0x0003B4C8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0003D338 File Offset: 0x0003B538
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(Il2CppStructArray<byte> value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0003D3A8 File Offset: 0x0003B5A8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0003D414 File Offset: 0x0003B614
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0003D484 File Offset: 0x0003B684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23585, XrefRangeEnd = 23586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(s);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			s = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0003D4E8 File Offset: 0x0003B6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23586, XrefRangeEnd = 23599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CheckPatternFacets(RestrictionFacets restriction, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(restriction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0003D54C File Offset: 0x0003B74C
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumeration);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0003D5C8 File Offset: 0x0003B7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23599, XrefRangeEnd = 23609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Power(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0003D614 File Offset: 0x0003B814
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FacetsChecker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000062B7 File Offset: 0x000044B7
		public FacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
