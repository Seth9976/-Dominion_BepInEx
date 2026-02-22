using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000043 RID: 67
	public class XmlUnspecifiedAttribute : XmlAttribute
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x00021FCC File Offset: 0x000201CC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlUnspecifiedAttribute()
		{
			Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlUnspecifiedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr);
			XmlUnspecifiedAttribute.NativeFieldInfoPtr_fSpecified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr, "fSpecified");
			XmlUnspecifiedAttribute.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr, 100664264);
			XmlUnspecifiedAttribute.NativeMethodInfoPtr_get_Specified_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr, 100664265);
			XmlUnspecifiedAttribute.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr, 100664266);
			XmlUnspecifiedAttribute.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr, 100664267);
			XmlUnspecifiedAttribute.NativeMethodInfoPtr_RemoveChild_Public_Virtual_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr, 100664268);
			XmlUnspecifiedAttribute.NativeMethodInfoPtr_AppendChild_Public_Virtual_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr, 100664269);
			XmlUnspecifiedAttribute.NativeMethodInfoPtr_SetSpecified_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr, 100664270);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0002209C File Offset: 0x0002029C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16437, RefRangeEnd = 16439, XrefRangeStart = 16436, XrefRangeEnd = 16437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUnspecifiedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUnspecifiedAttribute.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00022120 File Offset: 0x00020320
		public unsafe override bool Specified
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUnspecifiedAttribute.NativeMethodInfoPtr_get_Specified_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00022168 File Offset: 0x00020368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16439, XrefRangeEnd = 16441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUnspecifiedAttribute.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000270 RID: 624
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x000221C0 File Offset: 0x000203C0
		public unsafe override string InnerText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16441, XrefRangeEnd = 16442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUnspecifiedAttribute.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00022210 File Offset: 0x00020410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16442, XrefRangeEnd = 16443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode RemoveChild(XmlNode oldChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUnspecifiedAttribute.NativeMethodInfoPtr_RemoveChild_Public_Virtual_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0002226C File Offset: 0x0002046C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16443, XrefRangeEnd = 16444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode AppendChild(XmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUnspecifiedAttribute.NativeMethodInfoPtr_AppendChild_Public_Virtual_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000222C8 File Offset: 0x000204C8
		[CallerCount(0)]
		public unsafe void SetSpecified(bool f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUnspecifiedAttribute.NativeMethodInfoPtr_SetSpecified_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00003FA1 File Offset: 0x000021A1
		public XmlUnspecifiedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00022308 File Offset: 0x00020508
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00003FAA File Offset: 0x000021AA
		public unsafe bool fSpecified
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnspecifiedAttribute.NativeFieldInfoPtr_fSpecified);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnspecifiedAttribute.NativeFieldInfoPtr_fSpecified)) = value;
			}
		}

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_fSpecified;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_get_Specified_Public_Virtual_get_Boolean_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Public_Virtual_XmlNode_XmlNode_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_AppendChild_Public_Virtual_XmlNode_XmlNode_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecified_Internal_Void_Boolean_0;
	}
}
