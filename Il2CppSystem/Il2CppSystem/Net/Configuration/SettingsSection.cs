using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000159 RID: 345
	public sealed class SettingsSection : ConfigurationSection
	{
		// Token: 0x0600159C RID: 5532 RVA: 0x00060DEC File Offset: 0x0005EFEC
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSection()
		{
			Il2CppClassPointerStore<SettingsSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "SettingsSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSection>.NativeClassPtr);
			SettingsSection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSection>.NativeClassPtr, 100666273);
			SettingsSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSection>.NativeClassPtr, 100666274);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00060E44 File Offset: 0x0005F044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57648, XrefRangeEnd = 57651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsSection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00060E80 File Offset: 0x0005F080
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57651, XrefRangeEnd = 57654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0000AEF4 File Offset: 0x000090F4
		public SettingsSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
