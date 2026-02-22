using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using SA.Foundation.Config;
using UnityEngine;

namespace SA.Foundation.Patterns
{
	// Token: 0x02000025 RID: 37
	public class SA_ScriptableSettings : ScriptableObject
	{
		// Token: 0x0600011F RID: 287 RVA: 0x00008248 File Offset: 0x00006448
		// Note: this type is marked as 'beforefieldinit'.
		static SA_ScriptableSettings()
		{
			Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Patterns", "SA_ScriptableSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr);
			SA_ScriptableSettings.NativeFieldInfoPtr_LastVersionCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr, "LastVersionCode");
			SA_ScriptableSettings.NativeFieldInfoPtr_s_pluginVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr, "s_pluginVersion");
			SA_ScriptableSettings.NativeMethodInfoPtr_get_BasePath_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr, 100663481);
			SA_ScriptableSettings.NativeMethodInfoPtr_GetPluginVersion_Public_PluginVersionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr, 100663482);
			SA_ScriptableSettings.NativeMethodInfoPtr_GetFormattedVersion_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr, 100663483);
			SA_ScriptableSettings.NativeMethodInfoPtr_get_PluginName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr, 100663484);
			SA_ScriptableSettings.NativeMethodInfoPtr_get_DocumentationURL_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr, 100663485);
			SA_ScriptableSettings.NativeMethodInfoPtr_get_SettingsUIMenuItem_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr, 100663486);
			SA_ScriptableSettings.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr, 100663487);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000832C File Offset: 0x0000652C
		public unsafe virtual string BasePath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_ScriptableSettings.NativeMethodInfoPtr_get_BasePath_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00008370 File Offset: 0x00006570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99781, RefRangeEnd = 99782, XrefRangeStart = 99774, XrefRangeEnd = 99781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PluginVersionHandler GetPluginVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSettings.NativeMethodInfoPtr_GetPluginVersion_Public_PluginVersionHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluginVersionHandler>(intPtr3) : null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000083B0 File Offset: 0x000065B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99808, RefRangeEnd = 99809, XrefRangeStart = 99782, XrefRangeEnd = 99808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFormattedVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSettings.NativeMethodInfoPtr_GetFormattedVersion_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000083E8 File Offset: 0x000065E8
		public unsafe virtual string PluginName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_ScriptableSettings.NativeMethodInfoPtr_get_PluginName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000842C File Offset: 0x0000662C
		public unsafe virtual string DocumentationURL
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_ScriptableSettings.NativeMethodInfoPtr_get_DocumentationURL_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00008470 File Offset: 0x00006670
		public unsafe virtual string SettingsUIMenuItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_ScriptableSettings.NativeMethodInfoPtr_get_SettingsUIMenuItem_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000084B4 File Offset: 0x000066B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99812, RefRangeEnd = 99814, XrefRangeStart = 99809, XrefRangeEnd = 99812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_ScriptableSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ScriptableSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSettings.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000023FB File Offset: 0x000005FB
		public SA_ScriptableSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000084F0 File Offset: 0x000066F0
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002404 File Offset: 0x00000604
		public unsafe string LastVersionCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScriptableSettings.NativeFieldInfoPtr_LastVersionCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScriptableSettings.NativeFieldInfoPtr_LastVersionCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00008518 File Offset: 0x00006718
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002423 File Offset: 0x00000623
		public unsafe PluginVersionHandler s_pluginVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScriptableSettings.NativeFieldInfoPtr_s_pluginVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluginVersionHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ScriptableSettings.NativeFieldInfoPtr_s_pluginVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_LastVersionCode;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_s_pluginVersion;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_get_BasePath_Protected_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_GetPluginVersion_Public_PluginVersionHandler_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_GetFormattedVersion_Public_String_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_PluginName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_DocumentationURL_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_SettingsUIMenuItem_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
