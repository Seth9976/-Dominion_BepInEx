using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000153 RID: 339
	public sealed class ConnectionManagementSection : ConfigurationSection
	{
		// Token: 0x06001584 RID: 5508 RVA: 0x00060934 File Offset: 0x0005EB34
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionManagementSection()
		{
			Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ConnectionManagementSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr);
			ConnectionManagementSection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr, 100666261);
			ConnectionManagementSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr, 100666262);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0006098C File Offset: 0x0005EB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57612, XrefRangeEnd = 57615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionManagementSection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionManagementSection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManagementSection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x000609C8 File Offset: 0x0005EBC8
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57615, XrefRangeEnd = 57618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManagementSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0000AE85 File Offset: 0x00009085
		public ConnectionManagementSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
