using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000141 RID: 321
	public class Win32IPGlobalProperties : IPGlobalProperties
	{
		// Token: 0x060014FB RID: 5371 RVA: 0x0005F874 File Offset: 0x0005DA74
		// Note: this type is marked as 'beforefieldinit'.
		static Win32IPGlobalProperties()
		{
			Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32IPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr);
			Win32IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr, 100666238);
			Win32IPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr, 100666239);
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x0005F8CC File Offset: 0x0005DACC
		public unsafe override string DomainName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57512, XrefRangeEnd = 57531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Win32IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0005F910 File Offset: 0x0005DB10
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32IPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32IPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32IPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0000A8D7 File Offset: 0x00008AD7
		public Win32IPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
