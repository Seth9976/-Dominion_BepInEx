using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000D7 RID: 215
	public class UnionFacetsChecker : FacetsChecker
	{
		// Token: 0x06000CFC RID: 3324 RVA: 0x0003EF28 File Offset: 0x0003D128
		// Note: this type is marked as 'beforefieldinit'.
		static UnionFacetsChecker()
		{
			Il2CppClassPointerStore<UnionFacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "UnionFacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnionFacetsChecker>.NativeClassPtr);
			UnionFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnionFacetsChecker>.NativeClassPtr, 100665222);
			UnionFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnionFacetsChecker>.NativeClassPtr, 100665223);
			UnionFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnionFacetsChecker>.NativeClassPtr, 100665224);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0003EF94 File Offset: 0x0003D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23985, XrefRangeEnd = 23993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnionFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0003F004 File Offset: 0x0003D204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnionFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0003F080 File Offset: 0x0003D280
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnionFacetsChecker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnionFacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnionFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000063A4 File Offset: 0x000045A4
		public UnionFacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
