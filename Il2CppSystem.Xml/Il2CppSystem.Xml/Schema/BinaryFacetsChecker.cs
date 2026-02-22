using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000D5 RID: 213
	public class BinaryFacetsChecker : FacetsChecker
	{
		// Token: 0x06000CF0 RID: 3312 RVA: 0x0003EAF4 File Offset: 0x0003CCF4
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryFacetsChecker()
		{
			Il2CppClassPointerStore<BinaryFacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "BinaryFacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryFacetsChecker>.NativeClassPtr);
			BinaryFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFacetsChecker>.NativeClassPtr, 100665214);
			BinaryFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFacetsChecker>.NativeClassPtr, 100665215);
			BinaryFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFacetsChecker>.NativeClassPtr, 100665216);
			BinaryFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Private_Boolean_Il2CppStructArray_1_Byte_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFacetsChecker>.NativeClassPtr, 100665217);
			BinaryFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFacetsChecker>.NativeClassPtr, 100665218);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0003EB88 File Offset: 0x0003CD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23938, XrefRangeEnd = 23943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0003EBF8 File Offset: 0x0003CDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23943, XrefRangeEnd = 23954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(Il2CppStructArray<byte> value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0003EC68 File Offset: 0x0003CE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23954, XrefRangeEnd = 23963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0003ECE4 File Offset: 0x0003CEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23963, XrefRangeEnd = 23968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchEnumeration(Il2CppStructArray<byte> value, ArrayList enumeration, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Private_Boolean_Il2CppStructArray_1_Byte_ArrayList_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0003ED58 File Offset: 0x0003CF58
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryFacetsChecker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryFacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00006392 File Offset: 0x00004592
		public BinaryFacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Private_Boolean_Il2CppStructArray_1_Byte_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
