using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Net
{
	// Token: 0x02000017 RID: 23
	public class CFProxySettings : Object
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x000142A4 File Offset: 0x000124A4
		// Note: this type is marked as 'beforefieldinit'.
		static CFProxySettings()
		{
			Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFProxySettings");
			CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesHTTPEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr, "kCFNetworkProxiesHTTPEnable");
			CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesHTTPPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr, "kCFNetworkProxiesHTTPPort");
			CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesHTTPProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr, "kCFNetworkProxiesHTTPProxy");
			CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr, "kCFNetworkProxiesProxyAutoConfigEnable");
			CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigJavaScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr, "kCFNetworkProxiesProxyAutoConfigJavaScript");
			CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigURLString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr, "kCFNetworkProxiesProxyAutoConfigURLString");
			CFProxySettings.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr, "settings");
			CFProxySettings.NativeMethodInfoPtr__ctor_Public_Void_CFDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr, 100663491);
			CFProxySettings.NativeMethodInfoPtr_get_Dictionary_Public_get_CFDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr, 100663492);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00014380 File Offset: 0x00012580
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CFProxySettings(CFDictionary settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFProxySettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxySettings.NativeMethodInfoPtr__ctor_Public_Void_CFDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000143CC File Offset: 0x000125CC
		public unsafe CFDictionary Dictionary
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFProxySettings.NativeMethodInfoPtr_get_Dictionary_Public_get_CFDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002522 File Offset: 0x00000722
		public CFProxySettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0001440C File Offset: 0x0001260C
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000252B File Offset: 0x0000072B
		public unsafe static IntPtr kCFNetworkProxiesHTTPEnable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesHTTPEnable, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesHTTPEnable, (void*)(&value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00014428 File Offset: 0x00012628
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002539 File Offset: 0x00000739
		public unsafe static IntPtr kCFNetworkProxiesHTTPPort
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesHTTPPort, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesHTTPPort, (void*)(&value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00014444 File Offset: 0x00012644
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002547 File Offset: 0x00000747
		public unsafe static IntPtr kCFNetworkProxiesHTTPProxy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesHTTPProxy, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesHTTPProxy, (void*)(&value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00014460 File Offset: 0x00012660
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002555 File Offset: 0x00000755
		public unsafe static IntPtr kCFNetworkProxiesProxyAutoConfigEnable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigEnable, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigEnable, (void*)(&value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0001447C File Offset: 0x0001267C
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002563 File Offset: 0x00000763
		public unsafe static IntPtr kCFNetworkProxiesProxyAutoConfigJavaScript
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigJavaScript, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigJavaScript, (void*)(&value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00014498 File Offset: 0x00012698
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002571 File Offset: 0x00000771
		public unsafe static IntPtr kCFNetworkProxiesProxyAutoConfigURLString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigURLString, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFProxySettings.NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigURLString, (void*)(&value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000144B4 File Offset: 0x000126B4
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000257F File Offset: 0x0000077F
		public unsafe CFDictionary settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFProxySettings.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CFDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFProxySettings.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_kCFNetworkProxiesHTTPEnable;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_kCFNetworkProxiesHTTPPort;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_kCFNetworkProxiesHTTPProxy;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigEnable;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigJavaScript;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_kCFNetworkProxiesProxyAutoConfigURLString;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CFDictionary_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_get_Dictionary_Public_get_CFDictionary_0;
	}
}
