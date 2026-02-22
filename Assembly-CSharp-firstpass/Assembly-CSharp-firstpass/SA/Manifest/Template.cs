using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml;

namespace SA.Manifest
{
	// Token: 0x02000327 RID: 807
	public class Template : BaseTemplate
	{
		// Token: 0x06002F76 RID: 12150 RVA: 0x000CAC74 File Offset: 0x000C8E74
		// Note: this type is marked as 'beforefieldinit'.
		static Template()
		{
			Il2CppClassPointerStore<Template>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Manifest", "Template");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Template>.NativeClassPtr);
			Template.NativeFieldInfoPtr__applicationTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Template>.NativeClassPtr, "_applicationTemplate");
			Template.NativeFieldInfoPtr__permissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Template>.NativeClassPtr, "_permissions");
			Template.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Template>.NativeClassPtr, 100669586);
			Template.NativeMethodInfoPtr_HasPermission_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Template>.NativeClassPtr, 100669587);
			Template.NativeMethodInfoPtr_RemovePermission_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Template>.NativeClassPtr, 100669588);
			Template.NativeMethodInfoPtr_RemovePermission_Public_Void_PropertyTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Template>.NativeClassPtr, 100669589);
			Template.NativeMethodInfoPtr_AddPermission_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Template>.NativeClassPtr, 100669590);
			Template.NativeMethodInfoPtr_AddPermission_Public_Void_PropertyTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Template>.NativeClassPtr, 100669591);
			Template.NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Template>.NativeClassPtr, 100669592);
			Template.NativeMethodInfoPtr_get_ApplicationTemplate_Public_get_ApplicationTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Template>.NativeClassPtr, 100669593);
			Template.NativeMethodInfoPtr_get_Permissions_Public_get_List_1_PropertyTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Template>.NativeClassPtr, 100669594);
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x000CAD80 File Offset: 0x000C8F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220433, XrefRangeEnd = 220444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Template()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Template>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Template.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x000CADBC File Offset: 0x000C8FBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220462, RefRangeEnd = 220464, XrefRangeStart = 220444, XrefRangeEnd = 220462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasPermission(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Template.NativeMethodInfoPtr_HasPermission_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x000CAE0C File Offset: 0x000C900C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220464, XrefRangeEnd = 220481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePermission(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Template.NativeMethodInfoPtr_RemovePermission_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x000CAE50 File Offset: 0x000C9050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220485, RefRangeEnd = 220486, XrefRangeStart = 220481, XrefRangeEnd = 220485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePermission(PropertyTemplate permission)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(permission);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Template.NativeMethodInfoPtr_RemovePermission_Public_Void_PropertyTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x000CAE94 File Offset: 0x000C9094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220486, XrefRangeEnd = 220497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPermission(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Template.NativeMethodInfoPtr_AddPermission_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x000CAED8 File Offset: 0x000C90D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220497, XrefRangeEnd = 220501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPermission(PropertyTemplate permission)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(permission);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Template.NativeMethodInfoPtr_AddPermission_Public_Void_PropertyTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x000CAF1C File Offset: 0x000C911C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220501, XrefRangeEnd = 220523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Template.NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002F7E RID: 12158 RVA: 0x000CAF7C File Offset: 0x000C917C
		public unsafe ApplicationTemplate ApplicationTemplate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Template.NativeMethodInfoPtr_get_ApplicationTemplate_Public_get_ApplicationTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ApplicationTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002F7F RID: 12159 RVA: 0x000CAFBC File Offset: 0x000C91BC
		public unsafe List<PropertyTemplate> Permissions
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Template.NativeMethodInfoPtr_get_Permissions_Public_get_List_1_PropertyTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PropertyTemplate>>(intPtr3) : null;
			}
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x000121CE File Offset: 0x000103CE
		public Template(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x000CAFFC File Offset: 0x000C91FC
		// (set) Token: 0x06002F82 RID: 12162 RVA: 0x000121D7 File Offset: 0x000103D7
		public unsafe ApplicationTemplate _applicationTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Template.NativeFieldInfoPtr__applicationTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApplicationTemplate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Template.NativeFieldInfoPtr__applicationTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x000CB02C File Offset: 0x000C922C
		// (set) Token: 0x06002F84 RID: 12164 RVA: 0x000121F6 File Offset: 0x000103F6
		public unsafe List<PropertyTemplate> _permissions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Template.NativeFieldInfoPtr__permissions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyTemplate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Template.NativeFieldInfoPtr__permissions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D65 RID: 11621
		private static readonly IntPtr NativeFieldInfoPtr__applicationTemplate;

		// Token: 0x04002D66 RID: 11622
		private static readonly IntPtr NativeFieldInfoPtr__permissions;

		// Token: 0x04002D67 RID: 11623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D68 RID: 11624
		private static readonly IntPtr NativeMethodInfoPtr_HasPermission_Public_Boolean_String_0;

		// Token: 0x04002D69 RID: 11625
		private static readonly IntPtr NativeMethodInfoPtr_RemovePermission_Public_Void_String_0;

		// Token: 0x04002D6A RID: 11626
		private static readonly IntPtr NativeMethodInfoPtr_RemovePermission_Public_Void_PropertyTemplate_0;

		// Token: 0x04002D6B RID: 11627
		private static readonly IntPtr NativeMethodInfoPtr_AddPermission_Public_Void_String_0;

		// Token: 0x04002D6C RID: 11628
		private static readonly IntPtr NativeMethodInfoPtr_AddPermission_Public_Void_PropertyTemplate_0;

		// Token: 0x04002D6D RID: 11629
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0;

		// Token: 0x04002D6E RID: 11630
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationTemplate_Public_get_ApplicationTemplate_0;

		// Token: 0x04002D6F RID: 11631
		private static readonly IntPtr NativeMethodInfoPtr_get_Permissions_Public_get_List_1_PropertyTemplate_0;
	}
}
