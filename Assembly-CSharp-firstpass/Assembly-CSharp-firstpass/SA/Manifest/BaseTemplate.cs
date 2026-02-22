using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml;

namespace SA.Manifest
{
	// Token: 0x02000323 RID: 803
	public class BaseTemplate : Object
	{
		// Token: 0x06002F49 RID: 12105 RVA: 0x000C9F60 File Offset: 0x000C8160
		// Note: this type is marked as 'beforefieldinit'.
		static BaseTemplate()
		{
			Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Manifest", "BaseTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr);
			BaseTemplate.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, "_properties");
			BaseTemplate.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, "_values");
			BaseTemplate.NativeMethodInfoPtr_GetOrCreateIntentFilterWithName_Public_PropertyTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669555);
			BaseTemplate.NativeMethodInfoPtr_GetIntentFilterWithName_Public_PropertyTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669556);
			BaseTemplate.NativeMethodInfoPtr_GetIntentFilterName_Public_String_PropertyTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669557);
			BaseTemplate.NativeMethodInfoPtr_GetOrCreatePropertyWithName_Public_PropertyTemplate_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669558);
			BaseTemplate.NativeMethodInfoPtr_GetPropertyWithName_Public_PropertyTemplate_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669559);
			BaseTemplate.NativeMethodInfoPtr_GetOrCreatePropertyWithTag_Public_PropertyTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669560);
			BaseTemplate.NativeMethodInfoPtr_GetPropertyWithTag_Public_PropertyTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669561);
			BaseTemplate.NativeMethodInfoPtr_GetPropertiesWithTag_Public_List_1_PropertyTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669562);
			BaseTemplate.NativeMethodInfoPtr_ToXmlElement_Public_Abstract_Virtual_New_Void_XmlDocument_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669563);
			BaseTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669564);
			BaseTemplate.NativeMethodInfoPtr_AddProperty_Public_Void_PropertyTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669565);
			BaseTemplate.NativeMethodInfoPtr_AddProperty_Public_Void_String_PropertyTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669566);
			BaseTemplate.NativeMethodInfoPtr_SetValue_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669567);
			BaseTemplate.NativeMethodInfoPtr_GetValue_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669568);
			BaseTemplate.NativeMethodInfoPtr_RemoveProperty_Public_Void_PropertyTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669569);
			BaseTemplate.NativeMethodInfoPtr_RemoveValue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669570);
			BaseTemplate.NativeMethodInfoPtr_AddPropertiesToXml_Public_Void_XmlDocument_XmlElement_BaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669571);
			BaseTemplate.NativeMethodInfoPtr_AddAttributesToXml_Public_Void_XmlDocument_XmlElement_BaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669572);
			BaseTemplate.NativeMethodInfoPtr_get_Values_Public_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669573);
			BaseTemplate.NativeMethodInfoPtr_get_Properties_Public_get_Dictionary_2_String_List_1_PropertyTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr, 100669574);
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x000CA148 File Offset: 0x000C8348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220069, XrefRangeEnd = 220086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyTemplate GetOrCreateIntentFilterWithName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_GetOrCreateIntentFilterWithName_Public_PropertyTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x000CA198 File Offset: 0x000C8398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220123, RefRangeEnd = 220124, XrefRangeStart = 220086, XrefRangeEnd = 220123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyTemplate GetIntentFilterWithName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_GetIntentFilterWithName_Public_PropertyTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x000CA1E8 File Offset: 0x000C83E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220124, XrefRangeEnd = 220132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetIntentFilterName(PropertyTemplate intent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(intent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_GetIntentFilterName_Public_String_PropertyTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x000CA230 File Offset: 0x000C8430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220132, XrefRangeEnd = 220141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyTemplate GetOrCreatePropertyWithName(string tag, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_GetOrCreatePropertyWithName_Public_PropertyTemplate_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyTemplate>(intPtr3) : null;
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x000CA294 File Offset: 0x000C8494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220168, RefRangeEnd = 220169, XrefRangeStart = 220141, XrefRangeEnd = 220168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyTemplate GetPropertyWithName(string tag, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_GetPropertyWithName_Public_PropertyTemplate_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyTemplate>(intPtr3) : null;
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x000CA2F8 File Offset: 0x000C84F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220169, XrefRangeEnd = 220178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyTemplate GetOrCreatePropertyWithTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_GetOrCreatePropertyWithTag_Public_PropertyTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000CA348 File Offset: 0x000C8548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220178, XrefRangeEnd = 220181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyTemplate GetPropertyWithTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_GetPropertyWithTag_Public_PropertyTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000CA398 File Offset: 0x000C8598
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220191, RefRangeEnd = 220197, XrefRangeStart = 220181, XrefRangeEnd = 220191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PropertyTemplate> GetPropertiesWithTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_GetPropertiesWithTag_Public_List_1_PropertyTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PropertyTemplate>>(intPtr3) : null;
			}
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x000CA3E8 File Offset: 0x000C85E8
		[CallerCount(0)]
		public unsafe virtual void ToXmlElement(XmlDocument doc, XmlElement parent)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseTemplate.NativeMethodInfoPtr_ToXmlElement_Public_Abstract_Virtual_New_Void_XmlDocument_XmlElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x000CA448 File Offset: 0x000C8648
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220210, RefRangeEnd = 220213, XrefRangeStart = 220197, XrefRangeEnd = 220210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseTemplate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseTemplate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x000CA484 File Offset: 0x000C8684
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 220232, RefRangeEnd = 220236, XrefRangeStart = 220213, XrefRangeEnd = 220232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddProperty(PropertyTemplate property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_AddProperty_Public_Void_PropertyTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x000CA4C8 File Offset: 0x000C86C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220255, RefRangeEnd = 220260, XrefRangeStart = 220236, XrefRangeEnd = 220255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddProperty(string tag, PropertyTemplate property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_AddProperty_Public_Void_String_PropertyTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x000CA51C File Offset: 0x000C871C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 220270, RefRangeEnd = 220281, XrefRangeStart = 220260, XrefRangeEnd = 220270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_SetValue_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000CA570 File Offset: 0x000C8770
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220287, RefRangeEnd = 220290, XrefRangeStart = 220281, XrefRangeEnd = 220287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetValue(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_GetValue_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x000CA5B8 File Offset: 0x000C87B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220290, XrefRangeEnd = 220297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveProperty(PropertyTemplate property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_RemoveProperty_Public_Void_PropertyTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000CA5FC File Offset: 0x000C87FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220297, XrefRangeEnd = 220301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveValue(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_RemoveValue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x000CA640 File Offset: 0x000C8840
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220334, RefRangeEnd = 220339, XrefRangeStart = 220301, XrefRangeEnd = 220334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPropertiesToXml(XmlDocument doc, XmlElement parent, BaseTemplate template)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(template);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_AddPropertiesToXml_Public_Void_XmlDocument_XmlElement_BaseTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000CA6A8 File Offset: 0x000C88A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220376, RefRangeEnd = 220381, XrefRangeStart = 220339, XrefRangeEnd = 220376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttributesToXml(XmlDocument doc, XmlElement parent, BaseTemplate template)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(template);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_AddAttributesToXml_Public_Void_XmlDocument_XmlElement_BaseTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002F5C RID: 12124 RVA: 0x000CA710 File Offset: 0x000C8910
		public unsafe Dictionary<string, string> Values
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_get_Values_Public_get_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x000CA750 File Offset: 0x000C8950
		public unsafe Dictionary<string, List<PropertyTemplate>> Properties
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseTemplate.NativeMethodInfoPtr_get_Properties_Public_get_Dictionary_2_String_List_1_PropertyTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<PropertyTemplate>>>(intPtr3) : null;
			}
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x0001213B File Offset: 0x0001033B
		public BaseTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x000CA790 File Offset: 0x000C8990
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x00012144 File Offset: 0x00010344
		public unsafe Dictionary<string, List<PropertyTemplate>> _properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTemplate.NativeFieldInfoPtr__properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<PropertyTemplate>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTemplate.NativeFieldInfoPtr__properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x000CA7C0 File Offset: 0x000C89C0
		// (set) Token: 0x06002F62 RID: 12130 RVA: 0x00012163 File Offset: 0x00010363
		public unsafe Dictionary<string, string> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTemplate.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseTemplate.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D03 RID: 11523
		private static readonly IntPtr NativeFieldInfoPtr__properties;

		// Token: 0x04002D04 RID: 11524
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04002D05 RID: 11525
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateIntentFilterWithName_Public_PropertyTemplate_String_0;

		// Token: 0x04002D06 RID: 11526
		private static readonly IntPtr NativeMethodInfoPtr_GetIntentFilterWithName_Public_PropertyTemplate_String_0;

		// Token: 0x04002D07 RID: 11527
		private static readonly IntPtr NativeMethodInfoPtr_GetIntentFilterName_Public_String_PropertyTemplate_0;

		// Token: 0x04002D08 RID: 11528
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreatePropertyWithName_Public_PropertyTemplate_String_String_0;

		// Token: 0x04002D09 RID: 11529
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyWithName_Public_PropertyTemplate_String_String_0;

		// Token: 0x04002D0A RID: 11530
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreatePropertyWithTag_Public_PropertyTemplate_String_0;

		// Token: 0x04002D0B RID: 11531
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyWithTag_Public_PropertyTemplate_String_0;

		// Token: 0x04002D0C RID: 11532
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesWithTag_Public_List_1_PropertyTemplate_String_0;

		// Token: 0x04002D0D RID: 11533
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlElement_Public_Abstract_Virtual_New_Void_XmlDocument_XmlElement_0;

		// Token: 0x04002D0E RID: 11534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D0F RID: 11535
		private static readonly IntPtr NativeMethodInfoPtr_AddProperty_Public_Void_PropertyTemplate_0;

		// Token: 0x04002D10 RID: 11536
		private static readonly IntPtr NativeMethodInfoPtr_AddProperty_Public_Void_String_PropertyTemplate_0;

		// Token: 0x04002D11 RID: 11537
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_String_String_0;

		// Token: 0x04002D12 RID: 11538
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_String_String_0;

		// Token: 0x04002D13 RID: 11539
		private static readonly IntPtr NativeMethodInfoPtr_RemoveProperty_Public_Void_PropertyTemplate_0;

		// Token: 0x04002D14 RID: 11540
		private static readonly IntPtr NativeMethodInfoPtr_RemoveValue_Public_Void_String_0;

		// Token: 0x04002D15 RID: 11541
		private static readonly IntPtr NativeMethodInfoPtr_AddPropertiesToXml_Public_Void_XmlDocument_XmlElement_BaseTemplate_0;

		// Token: 0x04002D16 RID: 11542
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributesToXml_Public_Void_XmlDocument_XmlElement_BaseTemplate_0;

		// Token: 0x04002D17 RID: 11543
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_Dictionary_2_String_String_0;

		// Token: 0x04002D18 RID: 11544
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_Dictionary_2_String_List_1_PropertyTemplate_0;
	}
}
