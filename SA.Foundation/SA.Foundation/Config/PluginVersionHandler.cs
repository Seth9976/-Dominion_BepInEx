using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Config
{
	// Token: 0x0200003D RID: 61
	public class PluginVersionHandler : Object
	{
		// Token: 0x06000325 RID: 805 RVA: 0x00011238 File Offset: 0x0000F438
		// Note: this type is marked as 'beforefieldinit'.
		static PluginVersionHandler()
		{
			Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Config", "PluginVersionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr);
			PluginVersionHandler.NativeFieldInfoPtr_m_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr, "m_filename");
			PluginVersionHandler.NativeFieldInfoPtr_m_pluginVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr, "m_pluginVersion");
			PluginVersionHandler.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr, 100663831);
			PluginVersionHandler.NativeMethodInfoPtr_GetVersion_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr, 100663832);
			PluginVersionHandler.NativeMethodInfoPtr_UpgrageMinorVersion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr, 100663833);
			PluginVersionHandler.NativeMethodInfoPtr_UpgrageMajorVersionIfNeed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr, 100663834);
			PluginVersionHandler.NativeMethodInfoPtr_get_PluginVersion_Private_get_PluginVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr, 100663835);
			PluginVersionHandler.NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr, 100663836);
			PluginVersionHandler.NativeMethodInfoPtr_HasChanges_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr, 100663837);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0001131C File Offset: 0x0000F51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107537, XrefRangeEnd = 107541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PluginVersionHandler(string basePath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PluginVersionHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(basePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginVersionHandler.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00011368 File Offset: 0x0000F568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107541, XrefRangeEnd = 107543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginVersionHandler.NativeMethodInfoPtr_GetVersion_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000113A0 File Offset: 0x0000F5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107543, XrefRangeEnd = 107548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgrageMinorVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginVersionHandler.NativeMethodInfoPtr_UpgrageMinorVersion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000113D4 File Offset: 0x0000F5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107548, XrefRangeEnd = 107553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgrageMajorVersionIfNeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginVersionHandler.NativeMethodInfoPtr_UpgrageMajorVersionIfNeed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00011408 File Offset: 0x0000F608
		public unsafe PluginVersion PluginVersion
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 107560, RefRangeEnd = 107569, XrefRangeStart = 107553, XrefRangeEnd = 107560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginVersionHandler.NativeMethodInfoPtr_get_PluginVersion_Private_get_PluginVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluginVersion>(intPtr3) : null;
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00011448 File Offset: 0x0000F648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107569, XrefRangeEnd = 107572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginVersionHandler.NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0001147C File Offset: 0x0000F67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107572, XrefRangeEnd = 107573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginVersionHandler.NativeMethodInfoPtr_HasChanges_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public PluginVersionHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600032E RID: 814 RVA: 0x000114B8 File Offset: 0x0000F6B8
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00002BDF File Offset: 0x00000DDF
		public unsafe string m_filename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluginVersionHandler.NativeFieldInfoPtr_m_filename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluginVersionHandler.NativeFieldInfoPtr_m_filename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000330 RID: 816 RVA: 0x000114E0 File Offset: 0x0000F6E0
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00002BFE File Offset: 0x00000DFE
		public unsafe PluginVersion m_pluginVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluginVersionHandler.NativeFieldInfoPtr_m_pluginVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluginVersion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluginVersionHandler.NativeFieldInfoPtr_m_pluginVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_m_filename;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_m_pluginVersion;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_GetVersion_Public_String_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_UpgrageMinorVersion_Public_Void_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_UpgrageMajorVersionIfNeed_Public_Void_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_get_PluginVersion_Private_get_PluginVersion_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_Save_Private_Void_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_HasChanges_Public_Boolean_0;
	}
}
