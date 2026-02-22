using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000044 RID: 68
	public static class Platform : Object
	{
		// Token: 0x060003DE RID: 990 RVA: 0x000200F0 File Offset: 0x0001E2F0
		// Note: this type is marked as 'beforefieldinit'.
		static Platform()
		{
			Il2CppClassPointerStore<Platform>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "Platform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Platform>.NativeClassPtr);
			Platform.NativeFieldInfoPtr_checkedOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "checkedOS");
			Platform.NativeFieldInfoPtr_isMacOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "isMacOS");
			Platform.NativeFieldInfoPtr_isFreeBSD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "isFreeBSD");
			Platform.NativeMethodInfoPtr_uname_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Platform>.NativeClassPtr, 100663903);
			Platform.NativeMethodInfoPtr_CheckOS_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Platform>.NativeClassPtr, 100663904);
			Platform.NativeMethodInfoPtr_get_IsMacOS_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Platform>.NativeClassPtr, 100663905);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00020198 File Offset: 0x0001E398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37139, XrefRangeEnd = 37141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int uname(IntPtr buf)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buf;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Platform.NativeMethodInfoPtr_uname_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000201D8 File Offset: 0x0001E3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37170, RefRangeEnd = 37171, XrefRangeStart = 37141, XrefRangeEnd = 37170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckOS()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Platform.NativeMethodInfoPtr_CheckOS_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00020200 File Offset: 0x0001E400
		public unsafe static bool IsMacOS
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37171, XrefRangeEnd = 37177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Platform.NativeMethodInfoPtr_get_IsMacOS_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000359F File Offset: 0x0000179F
		public Platform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00020230 File Offset: 0x0001E430
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000035A8 File Offset: 0x000017A8
		public unsafe static bool checkedOS
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Platform.NativeFieldInfoPtr_checkedOS, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Platform.NativeFieldInfoPtr_checkedOS, (void*)(&value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0002024C File Offset: 0x0001E44C
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000035B6 File Offset: 0x000017B6
		public unsafe static bool isMacOS
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Platform.NativeFieldInfoPtr_isMacOS, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Platform.NativeFieldInfoPtr_isMacOS, (void*)(&value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00020268 File Offset: 0x0001E468
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x000035C4 File Offset: 0x000017C4
		public unsafe static bool isFreeBSD
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Platform.NativeFieldInfoPtr_isFreeBSD, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Platform.NativeFieldInfoPtr_isFreeBSD, (void*)(&value));
			}
		}

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr_checkedOS;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr_isMacOS;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr_isFreeBSD;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_uname_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_CheckOS_Private_Static_Void_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMacOS_Public_Static_get_Boolean_0;
	}
}
