using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security
{
	// Token: 0x020002BE RID: 702
	[Serializable]
	public sealed class SecurityElement : Object
	{
		// Token: 0x06002EF9 RID: 12025 RVA: 0x000ECFB0 File Offset: 0x000EB1B0
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityElement()
		{
			Il2CppClassPointerStore<SecurityElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr);
			SecurityElement.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "text");
			SecurityElement.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "tag");
			SecurityElement.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "attributes");
			SecurityElement.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "children");
			SecurityElement.NativeFieldInfoPtr_invalid_tag_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_tag_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_text_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_text_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_attr_name_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_attr_name_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_attr_value_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_attr_value_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_chars");
			SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670746);
			SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670747);
			SecurityElement.NativeMethodInfoPtr_get_Attributes_Public_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670748);
			SecurityElement.NativeMethodInfoPtr_get_Children_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670749);
			SecurityElement.NativeMethodInfoPtr_get_Tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670750);
			SecurityElement.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670751);
			SecurityElement.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670752);
			SecurityElement.NativeMethodInfoPtr_AddAttribute_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670753);
			SecurityElement.NativeMethodInfoPtr_AddChild_Public_Void_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670754);
			SecurityElement.NativeMethodInfoPtr_Escape_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670755);
			SecurityElement.NativeMethodInfoPtr_Unescape_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670756);
			SecurityElement.NativeMethodInfoPtr_FromString_Public_Static_SecurityElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670757);
			SecurityElement.NativeMethodInfoPtr_IsValidAttributeName_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670758);
			SecurityElement.NativeMethodInfoPtr_IsValidAttributeValue_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670759);
			SecurityElement.NativeMethodInfoPtr_IsValidTag_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670760);
			SecurityElement.NativeMethodInfoPtr_IsValidText_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670761);
			SecurityElement.NativeMethodInfoPtr_SearchForChildByTag_Public_SecurityElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670762);
			SecurityElement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670763);
			SecurityElement.NativeMethodInfoPtr_ToXml_Private_Void_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670764);
			SecurityElement.NativeMethodInfoPtr_GetAttribute_Internal_SecurityAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670765);
			SecurityElement.NativeMethodInfoPtr_set_m_strText_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670766);
			SecurityElement.NativeMethodInfoPtr_SearchForTextOfLocalName_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670767);
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x000ED24C File Offset: 0x000EB44C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 337435, RefRangeEnd = 337440, XrefRangeStart = 337411, XrefRangeEnd = 337435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement(string tag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x000ED298 File Offset: 0x000EB498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337440, XrefRangeEnd = 337466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement(string tag, string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x000ED2F8 File Offset: 0x000EB4F8
		public unsafe Hashtable Attributes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 337486, RefRangeEnd = 337487, XrefRangeStart = 337466, XrefRangeEnd = 337486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_get_Attributes_Public_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x000ED338 File Offset: 0x000EB538
		public unsafe ArrayList Children
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_get_Children_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x000ED378 File Offset: 0x000EB578
		public unsafe string Tag
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_get_Tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x000ED3B0 File Offset: 0x000EB5B0
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x000ED3E8 File Offset: 0x000EB5E8
		public unsafe string Text
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 337499, RefRangeEnd = 337503, XrefRangeStart = 337487, XrefRangeEnd = 337499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x000ED42C File Offset: 0x000EB62C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 337533, RefRangeEnd = 337541, XrefRangeStart = 337503, XrefRangeEnd = 337533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttribute(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_AddAttribute_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x000ED480 File Offset: 0x000EB680
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 337552, RefRangeEnd = 337555, XrefRangeStart = 337541, XrefRangeEnd = 337552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(SecurityElement child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_AddChild_Public_Void_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x000ED4C4 File Offset: 0x000EB6C4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 337586, RefRangeEnd = 337594, XrefRangeStart = 337555, XrefRangeEnd = 337586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Escape(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_Escape_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x000ED500 File Offset: 0x000EB700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337623, RefRangeEnd = 337625, XrefRangeStart = 337594, XrefRangeEnd = 337623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Unescape(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_Unescape_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x000ED53C File Offset: 0x000EB73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337656, RefRangeEnd = 337657, XrefRangeStart = 337625, XrefRangeEnd = 337656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SecurityElement FromString(string xml)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xml);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_FromString_Public_Static_SecurityElement_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
			}
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x000ED580 File Offset: 0x000EB780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337658, RefRangeEnd = 337659, XrefRangeStart = 337657, XrefRangeEnd = 337658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidAttributeName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidAttributeName_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x000ED5C4 File Offset: 0x000EB7C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337660, RefRangeEnd = 337661, XrefRangeStart = 337659, XrefRangeEnd = 337660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidAttributeValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidAttributeValue_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x000ED608 File Offset: 0x000EB808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337661, XrefRangeEnd = 337662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidTag(string tag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidTag_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x000ED64C File Offset: 0x000EB84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337662, XrefRangeEnd = 337663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidText(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidText_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x000ED690 File Offset: 0x000EB890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337667, RefRangeEnd = 337669, XrefRangeStart = 337663, XrefRangeEnd = 337667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement SearchForChildByTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_SearchForChildByTag_Public_SecurityElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
			}
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x000ED6E0 File Offset: 0x000EB8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337669, XrefRangeEnd = 337674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x000ED718 File Offset: 0x000EB918
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337741, RefRangeEnd = 337743, XrefRangeStart = 337674, XrefRangeEnd = 337741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToXml(ref StringBuilder s, int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(s);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_ToXml_Private_Void_byref_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			s = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x000ED780 File Offset: 0x000EB980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337758, RefRangeEnd = 337759, XrefRangeStart = 337743, XrefRangeEnd = 337758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement.SecurityAttribute GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_GetAttribute_Internal_SecurityAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement.SecurityAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (set) Token: 0x06002F0E RID: 12046 RVA: 0x000ED7D0 File Offset: 0x000EB9D0
		public unsafe string m_strText
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_set_m_strText_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x000ED814 File Offset: 0x000EBA14
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 337772, RefRangeEnd = 337789, XrefRangeStart = 337759, XrefRangeEnd = 337772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SearchForTextOfLocalName(string strLocalName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strLocalName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_SearchForTextOfLocalName_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00010670 File Offset: 0x0000E870
		public SecurityElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000ED85C File Offset: 0x000EBA5C
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x00010679 File Offset: 0x0000E879
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x000ED884 File Offset: 0x000EBA84
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x00010698 File Offset: 0x0000E898
		public unsafe string tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x000ED8AC File Offset: 0x000EBAAC
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x000106B7 File Offset: 0x0000E8B7
		public unsafe ArrayList attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x000ED8DC File Offset: 0x000EBADC
		// (set) Token: 0x06002F18 RID: 12056 RVA: 0x000106D6 File Offset: 0x0000E8D6
		public unsafe ArrayList children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x000ED90C File Offset: 0x000EBB0C
		// (set) Token: 0x06002F1A RID: 12058 RVA: 0x000106F5 File Offset: 0x0000E8F5
		public unsafe static Il2CppStructArray<char> invalid_tag_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_tag_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_tag_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x000ED934 File Offset: 0x000EBB34
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x00010707 File Offset: 0x0000E907
		public unsafe static Il2CppStructArray<char> invalid_text_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_text_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_text_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x000ED95C File Offset: 0x000EBB5C
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x00010719 File Offset: 0x0000E919
		public unsafe static Il2CppStructArray<char> invalid_attr_name_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_name_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_name_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x000ED984 File Offset: 0x000EBB84
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x0001072B File Offset: 0x0000E92B
		public unsafe static Il2CppStructArray<char> invalid_attr_value_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_value_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_value_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000ED9AC File Offset: 0x000EBBAC
		// (set) Token: 0x06002F22 RID: 12066 RVA: 0x0001073D File Offset: 0x0000E93D
		public unsafe static Il2CppStructArray<char> invalid_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028A2 RID: 10402
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040028A3 RID: 10403
		private static readonly IntPtr NativeFieldInfoPtr_tag;

		// Token: 0x040028A4 RID: 10404
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x040028A5 RID: 10405
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x040028A6 RID: 10406
		private static readonly IntPtr NativeFieldInfoPtr_invalid_tag_chars;

		// Token: 0x040028A7 RID: 10407
		private static readonly IntPtr NativeFieldInfoPtr_invalid_text_chars;

		// Token: 0x040028A8 RID: 10408
		private static readonly IntPtr NativeFieldInfoPtr_invalid_attr_name_chars;

		// Token: 0x040028A9 RID: 10409
		private static readonly IntPtr NativeFieldInfoPtr_invalid_attr_value_chars;

		// Token: 0x040028AA RID: 10410
		private static readonly IntPtr NativeFieldInfoPtr_invalid_chars;

		// Token: 0x040028AB RID: 10411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040028AC RID: 10412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040028AD RID: 10413
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_Hashtable_0;

		// Token: 0x040028AE RID: 10414
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_ArrayList_0;

		// Token: 0x040028AF RID: 10415
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_get_String_0;

		// Token: 0x040028B0 RID: 10416
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x040028B1 RID: 10417
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x040028B2 RID: 10418
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Void_String_String_0;

		// Token: 0x040028B3 RID: 10419
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Public_Void_SecurityElement_0;

		// Token: 0x040028B4 RID: 10420
		private static readonly IntPtr NativeMethodInfoPtr_Escape_Public_Static_String_String_0;

		// Token: 0x040028B5 RID: 10421
		private static readonly IntPtr NativeMethodInfoPtr_Unescape_Private_Static_String_String_0;

		// Token: 0x040028B6 RID: 10422
		private static readonly IntPtr NativeMethodInfoPtr_FromString_Public_Static_SecurityElement_String_0;

		// Token: 0x040028B7 RID: 10423
		private static readonly IntPtr NativeMethodInfoPtr_IsValidAttributeName_Public_Static_Boolean_String_0;

		// Token: 0x040028B8 RID: 10424
		private static readonly IntPtr NativeMethodInfoPtr_IsValidAttributeValue_Public_Static_Boolean_String_0;

		// Token: 0x040028B9 RID: 10425
		private static readonly IntPtr NativeMethodInfoPtr_IsValidTag_Public_Static_Boolean_String_0;

		// Token: 0x040028BA RID: 10426
		private static readonly IntPtr NativeMethodInfoPtr_IsValidText_Public_Static_Boolean_String_0;

		// Token: 0x040028BB RID: 10427
		private static readonly IntPtr NativeMethodInfoPtr_SearchForChildByTag_Public_SecurityElement_String_0;

		// Token: 0x040028BC RID: 10428
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040028BD RID: 10429
		private static readonly IntPtr NativeMethodInfoPtr_ToXml_Private_Void_byref_StringBuilder_Int32_0;

		// Token: 0x040028BE RID: 10430
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Internal_SecurityAttribute_String_0;

		// Token: 0x040028BF RID: 10431
		private static readonly IntPtr NativeMethodInfoPtr_set_m_strText_Internal_set_Void_String_0;

		// Token: 0x040028C0 RID: 10432
		private static readonly IntPtr NativeMethodInfoPtr_SearchForTextOfLocalName_Internal_String_String_0;

		// Token: 0x0200061C RID: 1564
		public class SecurityAttribute : Object
		{
			// Token: 0x06005382 RID: 21378 RVA: 0x00173188 File Offset: 0x00171388
			// Note: this type is marked as 'beforefieldinit'.
			static SecurityAttribute()
			{
				Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "SecurityAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr);
				SecurityElement.SecurityAttribute.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, "_name");
				SecurityElement.SecurityAttribute.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, "_value");
				SecurityElement.SecurityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, 100670769);
				SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, 100670770);
				SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, 100670771);
			}

			// Token: 0x06005383 RID: 21379 RVA: 0x00173218 File Offset: 0x00171418
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 337410, RefRangeEnd = 337411, XrefRangeStart = 337399, XrefRangeEnd = 337410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SecurityAttribute(string name, string value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.SecurityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001556 RID: 5462
			// (get) Token: 0x06005384 RID: 21380 RVA: 0x00173278 File Offset: 0x00171478
			public unsafe string Name
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001557 RID: 5463
			// (get) Token: 0x06005385 RID: 21381 RVA: 0x001732B0 File Offset: 0x001714B0
			public unsafe string Value
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005386 RID: 21382 RVA: 0x0001FFEB File Offset: 0x0001E1EB
			public SecurityAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001554 RID: 5460
			// (get) Token: 0x06005387 RID: 21383 RVA: 0x001732E8 File Offset: 0x001714E8
			// (set) Token: 0x06005388 RID: 21384 RVA: 0x0001FFF4 File Offset: 0x0001E1F4
			public unsafe string _name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001555 RID: 5461
			// (get) Token: 0x06005389 RID: 21385 RVA: 0x00173310 File Offset: 0x00171510
			// (set) Token: 0x0600538A RID: 21386 RVA: 0x00020013 File Offset: 0x0001E213
			public unsafe string _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04004374 RID: 17268
			private static readonly IntPtr NativeFieldInfoPtr__name;

			// Token: 0x04004375 RID: 17269
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x04004376 RID: 17270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

			// Token: 0x04004377 RID: 17271
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

			// Token: 0x04004378 RID: 17272
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
		}
	}
}
