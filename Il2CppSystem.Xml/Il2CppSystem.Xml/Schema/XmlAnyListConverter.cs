using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010D RID: 269
	public class XmlAnyListConverter : XmlListConverter
	{
		// Token: 0x060010E6 RID: 4326 RVA: 0x0004FE6C File Offset: 0x0004E06C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyListConverter()
		{
			Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlAnyListConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr);
			XmlAnyListConverter.NativeFieldInfoPtr_ItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, "ItemList");
			XmlAnyListConverter.NativeFieldInfoPtr_AnyAtomicList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, "AnyAtomicList");
			XmlAnyListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, 100665812);
			XmlAnyListConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, 100665813);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0004FEEC File Offset: 0x0004E0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30337, XrefRangeEnd = 30338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAnyListConverter(XmlBaseConverter atomicConverter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atomicConverter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0004FF38 File Offset: 0x0004E138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30338, XrefRangeEnd = 30399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyListConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00007798 File Offset: 0x00005998
		public XmlAnyListConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0004FFB8 File Offset: 0x0004E1B8
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x000077A1 File Offset: 0x000059A1
		public unsafe static XmlValueConverter ItemList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlAnyListConverter.NativeFieldInfoPtr_ItemList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlAnyListConverter.NativeFieldInfoPtr_ItemList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x0004FFE0 File Offset: 0x0004E1E0
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x000077B3 File Offset: 0x000059B3
		public unsafe static XmlValueConverter AnyAtomicList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlAnyListConverter.NativeFieldInfoPtr_AnyAtomicList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlAnyListConverter.NativeFieldInfoPtr_AnyAtomicList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeFieldInfoPtr_ItemList;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeFieldInfoPtr_AnyAtomicList;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;
	}
}
