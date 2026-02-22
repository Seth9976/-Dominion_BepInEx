using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003F RID: 63
	public class XmlNotation : XmlNode
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x0002101C File Offset: 0x0001F21C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNotation()
		{
			Il2CppClassPointerStore<XmlNotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr);
			XmlNotation.NativeFieldInfoPtr_publicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr, "publicId");
			XmlNotation.NativeFieldInfoPtr_systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr, "systemId");
			XmlNotation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr, "name");
			XmlNotation.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr, 100664228);
			XmlNotation.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr, 100664229);
			XmlNotation.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr, 100664230);
			XmlNotation.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr, 100664231);
			XmlNotation.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr, 100664232);
			XmlNotation.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr, 100664233);
			XmlNotation.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr, 100664234);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00021114 File Offset: 0x0001F314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16384, RefRangeEnd = 16385, XrefRangeStart = 16382, XrefRangeEnd = 16384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNotation(string name, string publicId, string systemId, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNotation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNotation.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00021198 File Offset: 0x0001F398
		public unsafe override string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNotation.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000211DC File Offset: 0x0001F3DC
		public unsafe override string LocalName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNotation.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00021220 File Offset: 0x0001F420
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNotation.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00021268 File Offset: 0x0001F468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16385, XrefRangeEnd = 16392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNotation.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x000212C0 File Offset: 0x0001F4C0
		public unsafe override bool IsReadOnly
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNotation.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000259 RID: 601
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00021308 File Offset: 0x0001F508
		public unsafe override string InnerXml
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16392, XrefRangeEnd = 16399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNotation.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00003EE2 File Offset: 0x000020E2
		public XmlNotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00021358 File Offset: 0x0001F558
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00003EEB File Offset: 0x000020EB
		public unsafe string publicId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNotation.NativeFieldInfoPtr_publicId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNotation.NativeFieldInfoPtr_publicId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00021380 File Offset: 0x0001F580
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00003F0A File Offset: 0x0000210A
		public unsafe string systemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNotation.NativeFieldInfoPtr_systemId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNotation.NativeFieldInfoPtr_systemId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x000213A8 File Offset: 0x0001F5A8
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00003F29 File Offset: 0x00002129
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNotation.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNotation.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_publicId;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_systemId;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_XmlDocument_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0;
	}
}
