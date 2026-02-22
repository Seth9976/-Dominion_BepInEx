using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000146 RID: 326
	public sealed class SettingsSectionInternal : Object
	{
		// Token: 0x06001533 RID: 5427 RVA: 0x00060084 File Offset: 0x0005E284
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSectionInternal()
		{
			Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "SettingsSectionInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr);
			SettingsSectionInternal.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "instance");
			SettingsSectionInternal.NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "HttpListenerUnescapeRequestUrl");
			SettingsSectionInternal.NativeFieldInfoPtr_IPProtectionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "IPProtectionLevel");
			SettingsSectionInternal.NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100666248);
			SettingsSectionInternal.NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100666249);
			SettingsSectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100666250);
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0006012C File Offset: 0x0005E32C
		public unsafe static SettingsSectionInternal Section
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57581, XrefRangeEnd = 57585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSectionInternal.NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SettingsSectionInternal>(intPtr3) : null;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x00060160 File Offset: 0x0005E360
		public unsafe bool Ipv6Enabled
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSectionInternal.NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0006019C File Offset: 0x0005E39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57585, XrefRangeEnd = 57586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsSectionInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0000AB04 File Offset: 0x00008D04
		public SettingsSectionInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x000601D8 File Offset: 0x0005E3D8
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x0000AB0D File Offset: 0x00008D0D
		public unsafe static SettingsSectionInternal instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SettingsSectionInternal.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsSectionInternal>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsSectionInternal.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x00060200 File Offset: 0x0005E400
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x0000AB1F File Offset: 0x00008D1F
		public unsafe bool HttpListenerUnescapeRequestUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl)) = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x00060228 File Offset: 0x0005E428
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x0000AB3A File Offset: 0x00008D3A
		public unsafe IPProtectionLevel IPProtectionLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_IPProtectionLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_IPProtectionLevel)) = value;
			}
		}

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeFieldInfoPtr_IPProtectionLevel;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
