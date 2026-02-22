using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000152 RID: 338
	[DefaultMember("Item")]
	public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06001581 RID: 5505 RVA: 0x0000AE43 File Offset: 0x00009043
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionManagementElementCollection()
		{
			Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ConnectionManagementElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr);
			ConnectionManagementElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr, 100666260);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x000608F8 File Offset: 0x0005EAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57609, XrefRangeEnd = 57612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionManagementElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionManagementElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionManagementElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0000AE7C File Offset: 0x0000907C
		public ConnectionManagementElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
