using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000089 RID: 137
	public class XsdSimpleValue : Object
	{
		// Token: 0x0600098F RID: 2447 RVA: 0x00031B4C File Offset: 0x0002FD4C
		// Note: this type is marked as 'beforefieldinit'.
		static XsdSimpleValue()
		{
			Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdSimpleValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr);
			XsdSimpleValue.NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, "xmlType");
			XsdSimpleValue.NativeFieldInfoPtr_typedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, "typedValue");
			XsdSimpleValue.NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100664806);
			XsdSimpleValue.NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdSimpleValue>.NativeClassPtr, 100664807);
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00031BCC File Offset: 0x0002FDCC
		public unsafe XmlSchemaSimpleType XmlType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdSimpleValue.NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00031C0C File Offset: 0x0002FE0C
		public unsafe Object TypedValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdSimpleValue.NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00005244 File Offset: 0x00003444
		public XsdSimpleValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00031C4C File Offset: 0x0002FE4C
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x0000524D File Offset: 0x0000344D
		public unsafe XmlSchemaSimpleType xmlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_xmlType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_xmlType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x00031C7C File Offset: 0x0002FE7C
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x0000526C File Offset: 0x0000346C
		public unsafe Object typedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_typedValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdSimpleValue.NativeFieldInfoPtr_typedValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeFieldInfoPtr_xmlType;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr_typedValue;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_get_Object_0;
	}
}
