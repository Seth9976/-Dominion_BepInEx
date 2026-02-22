using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Xml;

namespace SA.Manifest
{
	// Token: 0x02000326 RID: 806
	public class PropertyTemplate : BaseTemplate
	{
		// Token: 0x06002F67 RID: 12135 RVA: 0x000CA8C0 File Offset: 0x000C8AC0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyTemplate()
		{
			Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Manifest", "PropertyTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr);
			PropertyTemplate.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, "IsOpen");
			PropertyTemplate.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, "_tag");
			PropertyTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, 100669577);
			PropertyTemplate.NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, 100669578);
			PropertyTemplate.NativeMethodInfoPtr_get_Tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, 100669579);
			PropertyTemplate.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, 100669580);
			PropertyTemplate.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, 100669581);
			PropertyTemplate.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, 100669582);
			PropertyTemplate.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, 100669583);
			PropertyTemplate.NativeMethodInfoPtr_get_Label_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, 100669584);
			PropertyTemplate.NativeMethodInfoPtr_set_Label_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr, 100669585);
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x000CA9CC File Offset: 0x000C8BCC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 220399, RefRangeEnd = 220410, XrefRangeStart = 220396, XrefRangeEnd = 220399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyTemplate(string tag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x000CAA18 File Offset: 0x000C8C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220410, XrefRangeEnd = 220412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ToXmlElement(XmlDocument doc, XmlElement parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyTemplate.NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x000CAA78 File Offset: 0x000C8C78
		public unsafe string Tag
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTemplate.NativeMethodInfoPtr_get_Tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x000CAAB0 File Offset: 0x000C8CB0
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x000CAAE8 File Offset: 0x000C8CE8
		public unsafe string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 220415, RefRangeEnd = 220417, XrefRangeStart = 220412, XrefRangeEnd = 220415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTemplate.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 220420, RefRangeEnd = 220421, XrefRangeStart = 220417, XrefRangeEnd = 220420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTemplate.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x000CAB2C File Offset: 0x000C8D2C
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x000CAB64 File Offset: 0x000C8D64
		public unsafe string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220421, XrefRangeEnd = 220424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTemplate.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220424, XrefRangeEnd = 220427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTemplate.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x000CABA8 File Offset: 0x000C8DA8
		// (set) Token: 0x06002F70 RID: 12144 RVA: 0x000CABE0 File Offset: 0x000C8DE0
		public unsafe string Label
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220427, XrefRangeEnd = 220430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTemplate.NativeMethodInfoPtr_get_Label_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220430, XrefRangeEnd = 220433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyTemplate.NativeMethodInfoPtr_set_Label_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x0001218B File Offset: 0x0001038B
		public PropertyTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x000CAC24 File Offset: 0x000C8E24
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x00012194 File Offset: 0x00010394
		public unsafe bool IsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTemplate.NativeFieldInfoPtr_IsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTemplate.NativeFieldInfoPtr_IsOpen)) = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x000CAC4C File Offset: 0x000C8E4C
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x000121AF File Offset: 0x000103AF
		public unsafe string _tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTemplate.NativeFieldInfoPtr__tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyTemplate.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002D5A RID: 11610
		private static readonly IntPtr NativeFieldInfoPtr_IsOpen;

		// Token: 0x04002D5B RID: 11611
		private static readonly IntPtr NativeFieldInfoPtr__tag;

		// Token: 0x04002D5C RID: 11612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002D5D RID: 11613
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0;

		// Token: 0x04002D5E RID: 11614
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_get_String_0;

		// Token: 0x04002D5F RID: 11615
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002D60 RID: 11616
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04002D61 RID: 11617
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04002D62 RID: 11618
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x04002D63 RID: 11619
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_String_0;

		// Token: 0x04002D64 RID: 11620
		private static readonly IntPtr NativeMethodInfoPtr_set_Label_Public_set_Void_String_0;
	}
}
