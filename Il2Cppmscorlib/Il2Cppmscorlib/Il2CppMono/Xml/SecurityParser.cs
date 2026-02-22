using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Security;

namespace Il2CppMono.Xml
{
	// Token: 0x02000011 RID: 17
	public class SecurityParser : SmallXmlParser
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00023E24 File Offset: 0x00022024
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityParser()
		{
			Il2CppClassPointerStore<SecurityParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Xml", "SecurityParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr);
			SecurityParser.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, "root");
			SecurityParser.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, "current");
			SecurityParser.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, "stack");
			SecurityParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663354);
			SecurityParser.NativeMethodInfoPtr_LoadXml_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663355);
			SecurityParser.NativeMethodInfoPtr_ToXml_Public_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663356);
			SecurityParser.NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663357);
			SecurityParser.NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663358);
			SecurityParser.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663359);
			SecurityParser.NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663360);
			SecurityParser.NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663361);
			SecurityParser.NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663362);
			SecurityParser.NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr, 100663363);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00023F58 File Offset: 0x00022158
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258505, RefRangeEnd = 258507, XrefRangeStart = 258482, XrefRangeEnd = 258505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00023F94 File Offset: 0x00022194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258513, RefRangeEnd = 258515, XrefRangeStart = 258507, XrefRangeEnd = 258513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadXml(string xml)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xml);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_LoadXml_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00023FD8 File Offset: 0x000221D8
		[CallerCount(0)]
		public unsafe SecurityElement ToXml()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_ToXml_Public_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00024018 File Offset: 0x00022218
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartParsing(SmallXmlParser parser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0002405C File Offset: 0x0002225C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnProcessingInstruction(string name, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000240B0 File Offset: 0x000222B0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnIgnorableWhitespace(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000240F4 File Offset: 0x000222F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258515, XrefRangeEnd = 258536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00024148 File Offset: 0x00022348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258536, XrefRangeEnd = 258538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0002418C File Offset: 0x0002238C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258538, XrefRangeEnd = 258544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnChars(string ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000241D0 File Offset: 0x000223D0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndParsing(SmallXmlParser parser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityParser.NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000219E File Offset: 0x0000039E
		public SecurityParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00024214 File Offset: 0x00022414
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000021A7 File Offset: 0x000003A7
		public unsafe SecurityElement root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00024244 File Offset: 0x00022444
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000021C6 File Offset: 0x000003C6
		public unsafe SecurityElement current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00024274 File Offset: 0x00022474
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000021E5 File Offset: 0x000003E5
		public unsafe Stack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityParser.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_LoadXml_Public_Void_String_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_ToXml_Public_SecurityElement_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0;
	}
}
