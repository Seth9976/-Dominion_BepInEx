using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Configuration
{
	// Token: 0x02000003 RID: 3
	[DefaultMember("Item")]
	public class ConfigurationElement : Object
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002338 File Offset: 0x00000538
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationElement()
		{
			Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "System.Configuration", "ConfigurationElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr);
			ConfigurationElement.NativeMethodInfoPtr_get_Properties_FamOrAssem_Virtual_New_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr, 100663301);
			ConfigurationElement.NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr, 100663302);
			ConfigurationElement.NativeMethodInfoPtr_Reset_FamOrAssem_Virtual_New_Void_ConfigurationElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr, 100663303);
			ConfigurationElement.NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationElement>.NativeClassPtr, 100663304);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000023B8 File Offset: 0x000005B8
		public unsafe virtual ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12, XrefRangeEnd = 15, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationElement.NativeMethodInfoPtr_get_Properties_FamOrAssem_Virtual_New_get_ConfigurationPropertyCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002404 File Offset: 0x00000604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15, XrefRangeEnd = 18, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationElement.NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000244C File Offset: 0x0000064C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset(ConfigurationElement parentElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentElement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationElement.NativeMethodInfoPtr_Reset_FamOrAssem_Virtual_New_Void_ConfigurationElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000249C File Offset: 0x0000069C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21, XrefRangeEnd = 24, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationElement.NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002059 File Offset: 0x00000259
		public ConfigurationElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_FamOrAssem_Virtual_New_get_ConfigurationPropertyCollection_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_IsModified_FamOrAssem_Virtual_New_Boolean_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Reset_FamOrAssem_Virtual_New_Void_ConfigurationElement_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_ResetModified_FamOrAssem_Virtual_New_Void_0;
	}
}
