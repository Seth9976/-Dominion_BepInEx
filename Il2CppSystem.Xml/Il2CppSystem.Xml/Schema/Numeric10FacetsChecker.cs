using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000CE RID: 206
	public class Numeric10FacetsChecker : FacetsChecker
	{
		// Token: 0x06000CB3 RID: 3251 RVA: 0x0003D650 File Offset: 0x0003B850
		// Note: this type is marked as 'beforefieldinit'.
		static Numeric10FacetsChecker()
		{
			Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Numeric10FacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr);
			Numeric10FacetsChecker.NativeFieldInfoPtr_signs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, "signs");
			Numeric10FacetsChecker.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, "maxValue");
			Numeric10FacetsChecker.NativeFieldInfoPtr_minValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, "minValue");
			Numeric10FacetsChecker.NativeMethodInfoPtr__ctor_Internal_Void_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100665174);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100665175);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Decimal_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100665176);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int64_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100665177);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int32_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100665178);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int16_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100665179);
			Numeric10FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100665180);
			Numeric10FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Boolean_Decimal_ArrayList_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100665181);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckTotalAndFractionDigits_Internal_Exception_Decimal_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100665182);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0003D770 File Offset: 0x0003B970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23609, XrefRangeEnd = 23610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Numeric10FacetsChecker(Decimal minVal, Decimal maxVal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minVal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Numeric10FacetsChecker.NativeMethodInfoPtr__ctor_Internal_Void_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0003D7C8 File Offset: 0x0003B9C8
		[CallerCount(0)]
		public unsafe override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0003D838 File Offset: 0x0003BA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23610, XrefRangeEnd = 23638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Decimal_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0003D8A4 File Offset: 0x0003BAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23638, XrefRangeEnd = 23642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int64_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0003D910 File Offset: 0x0003BB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23642, XrefRangeEnd = 23646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int32_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0003D97C File Offset: 0x0003BB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23646, XrefRangeEnd = 23650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int16_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0003D9E8 File Offset: 0x0003BBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23650, XrefRangeEnd = 23655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0003DA64 File Offset: 0x0003BC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23655, XrefRangeEnd = 23660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumeration);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueConverter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Numeric10FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Boolean_Decimal_ArrayList_XmlValueConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0003DAD4 File Offset: 0x0003BCD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23708, RefRangeEnd = 23710, XrefRangeStart = 23660, XrefRangeEnd = 23708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalDigits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fractionDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkTotal;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Numeric10FacetsChecker.NativeMethodInfoPtr_CheckTotalAndFractionDigits_Internal_Exception_Decimal_Int32_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x000062C0 File Offset: 0x000044C0
		public Numeric10FacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0003DB58 File Offset: 0x0003BD58
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x000062C9 File Offset: 0x000044C9
		public unsafe static Il2CppStructArray<char> signs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Numeric10FacetsChecker.NativeFieldInfoPtr_signs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Numeric10FacetsChecker.NativeFieldInfoPtr_signs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0003DB80 File Offset: 0x0003BD80
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x000062DB File Offset: 0x000044DB
		public unsafe Decimal maxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Numeric10FacetsChecker.NativeFieldInfoPtr_maxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Numeric10FacetsChecker.NativeFieldInfoPtr_maxValue)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0003DBA8 File Offset: 0x0003BDA8
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x000062F6 File Offset: 0x000044F6
		public unsafe Decimal minValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Numeric10FacetsChecker.NativeFieldInfoPtr_minValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Numeric10FacetsChecker.NativeFieldInfoPtr_minValue)) = value;
			}
		}

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_signs;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr_minValue;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Decimal_Decimal_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Decimal_XmlSchemaDatatype_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int64_XmlSchemaDatatype_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int32_XmlSchemaDatatype_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int16_XmlSchemaDatatype_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Boolean_Decimal_ArrayList_XmlValueConverter_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_CheckTotalAndFractionDigits_Internal_Exception_Decimal_Int32_Int32_Boolean_Boolean_0;
	}
}
