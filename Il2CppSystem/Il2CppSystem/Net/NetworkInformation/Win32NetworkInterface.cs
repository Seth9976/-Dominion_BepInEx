using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000142 RID: 322
	public class Win32NetworkInterface : Object
	{
		// Token: 0x060014FF RID: 5375 RVA: 0x0005F94C File Offset: 0x0005DB4C
		// Note: this type is marked as 'beforefieldinit'.
		static Win32NetworkInterface()
		{
			Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32NetworkInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr);
			Win32NetworkInterface.NativeFieldInfoPtr_fixedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, "fixedInfo");
			Win32NetworkInterface.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, "initialized");
			Win32NetworkInterface.NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100666240);
			Win32NetworkInterface.NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100666241);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0005F9CC File Offset: 0x0005DBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57531, XrefRangeEnd = 57534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNetworkParams(IntPtr ptr, ref int size)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32NetworkInterface.NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x0005FA18 File Offset: 0x0005DC18
		public unsafe static Win32_FIXED_INFO FixedInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57534, XrefRangeEnd = 57553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32NetworkInterface.NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Win32_FIXED_INFO(intPtr);
			}
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0000A8E0 File Offset: 0x00008AE0
		public Win32NetworkInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x0005FA44 File Offset: 0x0005DC44
		// (set) Token: 0x06001504 RID: 5380 RVA: 0x0000A8E9 File Offset: 0x00008AE9
		public unsafe static Win32_FIXED_INFO fixedInfo
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(Win32NetworkInterface.NativeFieldInfoPtr_fixedInfo, intPtr);
				return new Win32_FIXED_INFO(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Win32NetworkInterface.NativeFieldInfoPtr_fixedInfo, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0005FA80 File Offset: 0x0005DC80
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x0000A900 File Offset: 0x00008B00
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Win32NetworkInterface.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Win32NetworkInterface.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeFieldInfoPtr_fixedInfo;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0;
	}
}
