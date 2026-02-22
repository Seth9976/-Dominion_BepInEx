using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000D0 RID: 208
	public class DurationFacetsChecker : FacetsChecker
	{
		// Token: 0x06000CCC RID: 3276 RVA: 0x0003DEE8 File Offset: 0x0003C0E8
		// Note: this type is marked as 'beforefieldinit'.
		static DurationFacetsChecker()
		{
			Il2CppClassPointerStore<DurationFacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DurationFacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DurationFacetsChecker>.NativeClassPtr);
			DurationFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationFacetsChecker>.NativeClassPtr, 100665190);
			DurationFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_TimeSpan_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationFacetsChecker>.NativeClassPtr, 100665191);
			DurationFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationFacetsChecker>.NativeClassPtr, 100665192);
			DurationFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Private_Boolean_TimeSpan_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationFacetsChecker>.NativeClassPtr, 100665193);
			DurationFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationFacetsChecker>.NativeClassPtr, 100665194);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0003DF7C File Offset: 0x0003C17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23725, XrefRangeEnd = 23736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DurationFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0003DFEC File Offset: 0x0003C1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23736, XrefRangeEnd = 23754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DurationFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_TimeSpan_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0003E058 File Offset: 0x0003C258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23754, XrefRangeEnd = 23760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DurationFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0003E0D4 File Offset: 0x0003C2D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23767, RefRangeEnd = 23768, XrefRangeStart = 23760, XrefRangeEnd = 23767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchEnumeration(TimeSpan value, ArrayList enumeration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumeration);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DurationFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Private_Boolean_TimeSpan_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0003E130 File Offset: 0x0003C330
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DurationFacetsChecker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DurationFacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DurationFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0000631A File Offset: 0x0000451A
		public DurationFacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_TimeSpan_XmlSchemaDatatype_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Private_Boolean_TimeSpan_ArrayList_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
