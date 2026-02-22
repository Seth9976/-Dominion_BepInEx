using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010E RID: 270
	public class XmlListConverter : XmlBaseConverter
	{
		// Token: 0x060010EE RID: 4334 RVA: 0x00050008 File Offset: 0x0004E208
		// Note: this type is marked as 'beforefieldinit'.
		static XmlListConverter()
		{
			Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlListConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr);
			XmlListConverter.NativeFieldInfoPtr_atomicConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, "atomicConverter");
			XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665815);
			XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665816);
			XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665817);
			XmlListConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665818);
			XmlListConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665819);
			XmlListConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665820);
			XmlListConverter.NativeMethodInfoPtr_IsListType_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665821);
			XmlListConverter.NativeMethodInfoPtr_ToArray_Private_Il2CppArrayBase_1_T_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665822);
			XmlListConverter.NativeMethodInfoPtr_ToList_Private_IList_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665823);
			XmlListConverter.NativeMethodInfoPtr_StringAsList_Private_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665824);
			XmlListConverter.NativeMethodInfoPtr_ListAsString_Private_String_IEnumerable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665825);
			XmlListConverter.NativeMethodInfoPtr_CreateInvalidClrMappingException_Private_Exception_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr, 100665826);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0005013C File Offset: 0x0004E33C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 30403, RefRangeEnd = 30406, XrefRangeStart = 30399, XrefRangeEnd = 30403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlListConverter(XmlBaseConverter atomicConverter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atomicConverter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00050188 File Offset: 0x0004E388
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 30410, RefRangeEnd = 30413, XrefRangeStart = 30406, XrefRangeEnd = 30410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlListConverter(XmlBaseConverter atomicConverter, Type clrTypeDefault)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atomicConverter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clrTypeDefault);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x000501E8 File Offset: 0x0004E3E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30417, RefRangeEnd = 30418, XrefRangeStart = 30413, XrefRangeEnd = 30417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlListConverter(XmlSchemaType schemaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00050234 File Offset: 0x0004E434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30438, RefRangeEnd = 30439, XrefRangeStart = 30418, XrefRangeEnd = 30438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlValueConverter Create(XmlValueConverter atomicConverter)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atomicConverter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlValueConverter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00050278 File Offset: 0x0004E478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30439, XrefRangeEnd = 30455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlListConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x000502F8 File Offset: 0x0004E4F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30677, RefRangeEnd = 30678, XrefRangeStart = 30455, XrefRangeEnd = 30677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlListConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00050378 File Offset: 0x0004E578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30705, RefRangeEnd = 30706, XrefRangeStart = 30678, XrefRangeEnd = 30705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsListType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_IsListType_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x000503C8 File Offset: 0x0004E5C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30755, RefRangeEnd = 30756, XrefRangeStart = 30706, XrefRangeEnd = 30755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray<T>(Object list, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.MethodInfoStoreGeneric_ToArray_Private_Il2CppArrayBase_1_T_Object_IXmlNamespaceResolver_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00050424 File Offset: 0x0004E624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30810, RefRangeEnd = 30811, XrefRangeStart = 30756, XrefRangeEnd = 30810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList ToList(Object list, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_ToList_Private_IList_Object_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00050488 File Offset: 0x0004E688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30811, XrefRangeEnd = 30826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> StringAsList(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_StringAsList_Private_List_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x000504D8 File Offset: 0x0004E6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30826, XrefRangeEnd = 30854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_ListAsString_Private_String_IEnumerable_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00050534 File Offset: 0x0004E734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30854, XrefRangeEnd = 30873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlListConverter.NativeMethodInfoPtr_CreateInvalidClrMappingException_Private_Exception_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000077C5 File Offset: 0x000059C5
		public XmlListConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x00050598 File Offset: 0x0004E798
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x000077CE File Offset: 0x000059CE
		public unsafe XmlValueConverter atomicConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlListConverter.NativeFieldInfoPtr_atomicConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlListConverter.NativeFieldInfoPtr_atomicConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeFieldInfoPtr_atomicConverter;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlValueConverter_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_ChangeListType_Protected_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_IsListType_Private_Boolean_Type_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Private_Il2CppArrayBase_1_T_Object_IXmlNamespaceResolver_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_ToList_Private_IList_Object_IXmlNamespaceResolver_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_StringAsList_Private_List_1_String_String_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_ListAsString_Private_String_IEnumerable_IXmlNamespaceResolver_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidClrMappingException_Private_Exception_Type_Type_0;

		// Token: 0x02000138 RID: 312
		private sealed class MethodInfoStoreGeneric_ToArray_Private_Il2CppArrayBase_1_T_Object_IXmlNamespaceResolver_0<T>
		{
			// Token: 0x04000EDE RID: 3806
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(XmlListConverter.NativeMethodInfoPtr_ToArray_Private_Il2CppArrayBase_1_T_Object_IXmlNamespaceResolver_0, Il2CppClassPointerStore<XmlListConverter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
