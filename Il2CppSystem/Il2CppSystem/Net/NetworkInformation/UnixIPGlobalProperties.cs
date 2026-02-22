using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x0200013E RID: 318
	public class UnixIPGlobalProperties : CommonUnixIPGlobalProperties
	{
		// Token: 0x060014E3 RID: 5347 RVA: 0x0000A7B7 File Offset: 0x000089B7
		// Note: this type is marked as 'beforefieldinit'.
		static UnixIPGlobalProperties()
		{
			Il2CppClassPointerStore<UnixIPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "UnixIPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnixIPGlobalProperties>.NativeClassPtr);
			UnixIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixIPGlobalProperties>.NativeClassPtr, 100666233);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0005F538 File Offset: 0x0005D738
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnixIPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnixIPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0000A7F0 File Offset: 0x000089F0
		public UnixIPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
