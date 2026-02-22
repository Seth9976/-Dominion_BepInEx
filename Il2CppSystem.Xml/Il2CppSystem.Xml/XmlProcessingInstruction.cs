using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000040 RID: 64
	public class XmlProcessingInstruction : XmlLinkedNode
	{
		// Token: 0x060005BD RID: 1469 RVA: 0x000213D0 File Offset: 0x0001F5D0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlProcessingInstruction()
		{
			Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlProcessingInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr);
			XmlProcessingInstruction.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, "target");
			XmlProcessingInstruction.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, "data");
			XmlProcessingInstruction.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, 100664235);
			XmlProcessingInstruction.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, 100664236);
			XmlProcessingInstruction.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, 100664237);
			XmlProcessingInstruction.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, 100664238);
			XmlProcessingInstruction.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, 100664239);
			XmlProcessingInstruction.NativeMethodInfoPtr_set_Data_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, 100664240);
			XmlProcessingInstruction.NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, 100664241);
			XmlProcessingInstruction.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, 100664242);
			XmlProcessingInstruction.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, 100664243);
			XmlProcessingInstruction.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr, 100664244);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000214F0 File Offset: 0x0001F6F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16400, RefRangeEnd = 16402, XrefRangeStart = 16399, XrefRangeEnd = 16400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlProcessingInstruction(string target, string data, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlProcessingInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlProcessingInstruction.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00021560 File Offset: 0x0001F760
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16402, XrefRangeEnd = 16404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlProcessingInstruction.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x000215A4 File Offset: 0x0001F7A4
		public unsafe override string LocalName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 15010, RefRangeEnd = 15012, XrefRangeStart = 15010, XrefRangeEnd = 15012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlProcessingInstruction.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x000215E8 File Offset: 0x0001F7E8
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0002162C File Offset: 0x0001F82C
		public unsafe override string Value
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlProcessingInstruction.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16404, XrefRangeEnd = 16405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlProcessingInstruction.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700025F RID: 607
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x0002167C File Offset: 0x0001F87C
		public unsafe string Data
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 16405, RefRangeEnd = 16407, XrefRangeStart = 16405, XrefRangeEnd = 16405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlProcessingInstruction.NativeMethodInfoPtr_set_Data_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x000216C0 File Offset: 0x0001F8C0
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00021704 File Offset: 0x0001F904
		public unsafe override string InnerText
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlProcessingInstruction.NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlProcessingInstruction.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00021754 File Offset: 0x0001F954
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlProcessingInstruction.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0002179C File Offset: 0x0001F99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16407, XrefRangeEnd = 16408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlProcessingInstruction.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00003F48 File Offset: 0x00002148
		public XmlProcessingInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x000217F4 File Offset: 0x0001F9F4
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00003F51 File Offset: 0x00002151
		public unsafe string target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlProcessingInstruction.NativeFieldInfoPtr_target);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlProcessingInstruction.NativeFieldInfoPtr_target), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0002181C File Offset: 0x0001FA1C
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00003F70 File Offset: 0x00002170
		public unsafe string data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlProcessingInstruction.NativeFieldInfoPtr_data);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlProcessingInstruction.NativeFieldInfoPtr_data), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_XmlDocument_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_String_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;
	}
}
