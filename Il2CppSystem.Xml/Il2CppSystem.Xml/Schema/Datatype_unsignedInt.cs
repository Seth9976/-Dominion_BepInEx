using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000C1 RID: 193
	public class Datatype_unsignedInt : Datatype_unsignedLong
	{
		// Token: 0x06000C32 RID: 3122 RVA: 0x0003B0D8 File Offset: 0x000392D8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_unsignedInt()
		{
			Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_unsignedInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr);
			Datatype_unsignedInt.NativeFieldInfoPtr_atomicValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr, "atomicValueType");
			Datatype_unsignedInt.NativeFieldInfoPtr_listValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr, "listValueType");
			Datatype_unsignedInt.NativeFieldInfoPtr_numeric10FacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr, "numeric10FacetsChecker");
			Datatype_unsignedInt.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr, 100665095);
			Datatype_unsignedInt.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr, 100665096);
			Datatype_unsignedInt.NativeMethodInfoPtr_Compare_Internal_Virtual_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr, 100665097);
			Datatype_unsignedInt.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr, 100665098);
			Datatype_unsignedInt.NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr, 100665099);
			Datatype_unsignedInt.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr, 100665100);
			Datatype_unsignedInt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr, 100665101);
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0003B1D0 File Offset: 0x000393D0
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23286, XrefRangeEnd = 23290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_unsignedInt.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0003B21C File Offset: 0x0003941C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_unsignedInt.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0003B264 File Offset: 0x00039464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23290, XrefRangeEnd = 23294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Compare(Object value1, Object value2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_unsignedInt.NativeMethodInfoPtr_Compare_Internal_Virtual_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0003B2D0 File Offset: 0x000394D0
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23294, XrefRangeEnd = 23298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_unsignedInt.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0003B31C File Offset: 0x0003951C
		public unsafe override Type ListValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23298, XrefRangeEnd = 23302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_unsignedInt.NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0003B368 File Offset: 0x00039568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23302, XrefRangeEnd = 23316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_unsignedInt.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0003B40C File Offset: 0x0003960C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23316, XrefRangeEnd = 23320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_unsignedInt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_unsignedInt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_unsignedInt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00006119 File Offset: 0x00004319
		public Datatype_unsignedInt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0003B448 File Offset: 0x00039648
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00006122 File Offset: 0x00004322
		public new unsafe static Type atomicValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_unsignedInt.NativeFieldInfoPtr_atomicValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_unsignedInt.NativeFieldInfoPtr_atomicValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0003B470 File Offset: 0x00039670
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x00006134 File Offset: 0x00004334
		public new unsafe static Type listValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_unsignedInt.NativeFieldInfoPtr_listValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_unsignedInt.NativeFieldInfoPtr_listValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0003B498 File Offset: 0x00039698
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x00006146 File Offset: 0x00004346
		public new unsafe static FacetsChecker numeric10FacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_unsignedInt.NativeFieldInfoPtr_numeric10FacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_unsignedInt.NativeFieldInfoPtr_numeric10FacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr_atomicValueType;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr_listValueType;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr_numeric10FacetsChecker;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Virtual_Int32_Object_Object_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
