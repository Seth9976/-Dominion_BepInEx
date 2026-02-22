using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x0200013F RID: 319
	public sealed class UnixNoLibCIPGlobalProperties : UnixIPGlobalProperties
	{
		// Token: 0x060014E6 RID: 5350 RVA: 0x0005F574 File Offset: 0x0005D774
		// Note: this type is marked as 'beforefieldinit'.
		static UnixNoLibCIPGlobalProperties()
		{
			Il2CppClassPointerStore<UnixNoLibCIPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "UnixNoLibCIPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnixNoLibCIPGlobalProperties>.NativeClassPtr);
			UnixNoLibCIPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixNoLibCIPGlobalProperties>.NativeClassPtr, 100666234);
			UnixNoLibCIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixNoLibCIPGlobalProperties>.NativeClassPtr, 100666235);
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x0005F5CC File Offset: 0x0005D7CC
		public unsafe override string DomainName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57488, XrefRangeEnd = 57490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixNoLibCIPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0005F604 File Offset: 0x0005D804
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnixNoLibCIPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnixNoLibCIPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixNoLibCIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0000A7F9 File Offset: 0x000089F9
		public UnixNoLibCIPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
