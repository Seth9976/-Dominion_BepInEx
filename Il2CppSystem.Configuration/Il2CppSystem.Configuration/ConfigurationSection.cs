using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Configuration
{
	// Token: 0x02000002 RID: 2
	public class ConfigurationSection : ConfigurationElement
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002170 File Offset: 0x00000370
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationSection()
		{
			Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "System.Configuration", "ConfigurationSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr);
			ConfigurationSection.NativeMethodInfoPtr_DeserializeSection_FamOrAssem_Virtual_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr, 100663297);
			ConfigurationSection.NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr, 100663298);
			ConfigurationSection.NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr, 100663299);
			ConfigurationSection.NativeMethodInfoPtr_SerializeSection_FamOrAssem_Virtual_New_String_ConfigurationElement_String_ConfigurationSaveMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationSection>.NativeClassPtr, 100663300);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000021F0 File Offset: 0x000003F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 3, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeserializeSection(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationSection.NativeMethodInfoPtr_DeserializeSection_FamOrAssem_Virtual_New_Void_XmlReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002240 File Offset: 0x00000440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationSection.NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002288 File Offset: 0x00000488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6, XrefRangeEnd = 9, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationSection.NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022C4 File Offset: 0x000004C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9, XrefRangeEnd = 12, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationSection.NativeMethodInfoPtr_SerializeSection_FamOrAssem_Virtual_New_String_ConfigurationElement_String_ConfigurationSaveMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		public ConfigurationSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSection_FamOrAssem_Virtual_New_Void_XmlReader_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_Boolean_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_Void_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSection_FamOrAssem_Virtual_New_String_ConfigurationElement_String_ConfigurationSaveMode_0;
	}
}
