using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Config
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	public class PluginVersion : Object
	{
		// Token: 0x06000319 RID: 793 RVA: 0x00011014 File Offset: 0x0000F214
		// Note: this type is marked as 'beforefieldinit'.
		static PluginVersion()
		{
			Il2CppClassPointerStore<PluginVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Config", "PluginVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PluginVersion>.NativeClassPtr);
			PluginVersion.NativeFieldInfoPtr_MajorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginVersion>.NativeClassPtr, "MajorVersion");
			PluginVersion.NativeFieldInfoPtr_MinorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginVersion>.NativeClassPtr, "MinorVersion");
			PluginVersion.NativeFieldInfoPtr_SaveDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginVersion>.NativeClassPtr, "SaveDelegate");
			PluginVersion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersion>.NativeClassPtr, 100663827);
			PluginVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersion>.NativeClassPtr, 100663828);
			PluginVersion.NativeMethodInfoPtr_UpgradeMinorVersion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersion>.NativeClassPtr, 100663829);
			PluginVersion.NativeMethodInfoPtr_UpgradeMajorVersion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginVersion>.NativeClassPtr, 100663830);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000110D0 File Offset: 0x0000F2D0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PluginVersion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PluginVersion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginVersion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0001110C File Offset: 0x0000F30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107524, XrefRangeEnd = 107537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PluginVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00011150 File Offset: 0x0000F350
		[CallerCount(0)]
		public unsafe void UpgradeMinorVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginVersion.NativeMethodInfoPtr_UpgradeMinorVersion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00011184 File Offset: 0x0000F384
		[CallerCount(0)]
		public unsafe void UpgradeMajorVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginVersion.NativeMethodInfoPtr_UpgradeMajorVersion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002B78 File Offset: 0x00000D78
		public PluginVersion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000111B8 File Offset: 0x0000F3B8
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00002B81 File Offset: 0x00000D81
		public unsafe int MajorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluginVersion.NativeFieldInfoPtr_MajorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluginVersion.NativeFieldInfoPtr_MajorVersion)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000321 RID: 801 RVA: 0x000111E0 File Offset: 0x0000F3E0
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00002B9C File Offset: 0x00000D9C
		public unsafe int MinorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluginVersion.NativeFieldInfoPtr_MinorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluginVersion.NativeFieldInfoPtr_MinorVersion)) = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00011208 File Offset: 0x0000F408
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00002BB7 File Offset: 0x00000DB7
		public unsafe Action SaveDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluginVersion.NativeFieldInfoPtr_SaveDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluginVersion.NativeFieldInfoPtr_SaveDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_MajorVersion;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_MinorVersion;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_SaveDelegate;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeMinorVersion_Public_Void_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeMajorVersion_Public_Void_0;
	}
}
