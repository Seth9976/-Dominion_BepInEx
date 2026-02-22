using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000158 RID: 344
	public sealed class NetSectionGroup : ConfigurationSectionGroup
	{
		// Token: 0x06001599 RID: 5529 RVA: 0x0000AEB2 File Offset: 0x000090B2
		// Note: this type is marked as 'beforefieldinit'.
		static NetSectionGroup()
		{
			Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "NetSectionGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr);
			NetSectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr, 100666272);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00060DB0 File Offset: 0x0005EFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57645, XrefRangeEnd = 57648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetSectionGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetSectionGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetSectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0000AEEB File Offset: 0x000090EB
		public NetSectionGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
