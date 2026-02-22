using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net;
using Il2CppSystem.Threading;

namespace Il2CppMono.Net
{
	// Token: 0x02000018 RID: 24
	public static class CFNetwork : Object
	{
		// Token: 0x06000104 RID: 260 RVA: 0x000144E4 File Offset: 0x000126E4
		// Note: this type is marked as 'beforefieldinit'.
		static CFNetwork()
		{
			Il2CppClassPointerStore<CFNetwork>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFNetwork");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr);
			CFNetwork.NativeFieldInfoPtr_lock_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "lock_obj");
			CFNetwork.NativeFieldInfoPtr_get_proxy_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "get_proxy_queue");
			CFNetwork.NativeFieldInfoPtr_proxy_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "proxy_event");
			CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptSequential_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663493);
			CFNetwork.NativeMethodInfoPtr_CFNetworkExecuteProxyAutoConfigurationURL_Private_Static_IntPtr_IntPtr_IntPtr_CFProxyAutoConfigurationResultCallback_byref_CFStreamClientContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663494);
			CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptThread_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663495);
			CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScript_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663496);
			CFNetwork.NativeMethodInfoPtr_CopyProxiesForAutoConfigurationScript_Private_Static_CFArray_IntPtr_CFUrl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663497);
			CFNetwork.NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_CFUrl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663498);
			CFNetwork.NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663499);
			CFNetwork.NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663500);
			CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForURL_Private_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663501);
			CFNetwork.NativeMethodInfoPtr_CopyProxiesForURL_Private_Static_CFArray_CFUrl_CFDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663502);
			CFNetwork.NativeMethodInfoPtr_GetProxiesForURL_Public_Static_Il2CppReferenceArray_1_CFProxy_CFUrl_CFProxySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663503);
			CFNetwork.NativeMethodInfoPtr_GetProxiesForUri_Public_Static_Il2CppReferenceArray_1_CFProxy_Uri_CFProxySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663504);
			CFNetwork.NativeMethodInfoPtr_CFNetworkCopySystemProxySettings_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663505);
			CFNetwork.NativeMethodInfoPtr_GetSystemProxySettings_Public_Static_CFProxySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663506);
			CFNetwork.NativeMethodInfoPtr_GetDefaultProxy_Public_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663507);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0001467C File Offset: 0x0001287C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32899, RefRangeEnd = 32900, XrefRangeStart = 32897, XrefRangeEnd = 32899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigurationScript;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetURL;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptSequential_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000146D8 File Offset: 0x000128D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32900, XrefRangeEnd = 32902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigURL;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetURL;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &clientContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkExecuteProxyAutoConfigurationURL_Private_Static_IntPtr_IntPtr_IntPtr_CFProxyAutoConfigurationResultCallback_byref_CFStreamClientContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00014744 File Offset: 0x00012944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32902, XrefRangeEnd = 32969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CFNetworkCopyProxiesForAutoConfigurationScriptThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptThread_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001476C File Offset: 0x0001296C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33021, RefRangeEnd = 33023, XrefRangeStart = 32969, XrefRangeEnd = 33021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigurationScript;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetURL;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScript_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000147C8 File Offset: 0x000129C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33023, XrefRangeEnd = 33033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigurationScript;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CopyProxiesForAutoConfigurationScript_Private_Static_CFArray_IntPtr_CFUrl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFArray>(intPtr3) : null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0001481C File Offset: 0x00012A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33071, XrefRangeStart = 33033, XrefRangeEnd = 33070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CFProxy> GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigurationScript;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_CFUrl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr3) : null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00014870 File Offset: 0x00012A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33084, RefRangeEnd = 33085, XrefRangeStart = 33071, XrefRangeEnd = 33084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CFProxy> GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigurationScript;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr3) : null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000148C4 File Offset: 0x00012AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33119, RefRangeEnd = 33120, XrefRangeStart = 33085, XrefRangeEnd = 33119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CFProxy> ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigURL;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr3) : null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00014918 File Offset: 0x00012B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33120, XrefRangeEnd = 33122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref url;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proxySettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForURL_Private_Static_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00014964 File Offset: 0x00012B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33122, XrefRangeEnd = 33134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxySettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CopyProxiesForURL_Private_Static_CFArray_CFUrl_CFDictionary_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFArray>(intPtr3) : null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000149BC File Offset: 0x00012BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33191, RefRangeEnd = 33192, XrefRangeStart = 33134, XrefRangeEnd = 33191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CFProxy> GetProxiesForURL(CFUrl url, CFProxySettings proxySettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxySettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetProxiesForURL_Public_Static_Il2CppReferenceArray_1_CFProxy_CFUrl_CFProxySettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr3) : null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00014A14 File Offset: 0x00012C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33203, RefRangeEnd = 33204, XrefRangeStart = 33192, XrefRangeEnd = 33203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CFProxy> GetProxiesForUri(Uri uri, CFProxySettings proxySettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxySettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetProxiesForUri_Public_Static_Il2CppReferenceArray_1_CFProxy_Uri_CFProxySettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr3) : null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00014A6C File Offset: 0x00012C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33204, XrefRangeEnd = 33206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFNetworkCopySystemProxySettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkCopySystemProxySettings_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00014A9C File Offset: 0x00012C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33221, RefRangeEnd = 33222, XrefRangeStart = 33206, XrefRangeEnd = 33221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CFProxySettings GetSystemProxySettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetSystemProxySettings_Public_Static_CFProxySettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFProxySettings>(intPtr3) : null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00014AD0 File Offset: 0x00012CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33222, XrefRangeEnd = 33226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy GetDefaultProxy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetDefaultProxy_Public_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000259E File Offset: 0x0000079E
		public CFNetwork(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00014B04 File Offset: 0x00012D04
		// (set) Token: 0x06000116 RID: 278 RVA: 0x000025A7 File Offset: 0x000007A7
		public unsafe static Object lock_obj
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFNetwork.NativeFieldInfoPtr_lock_obj, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFNetwork.NativeFieldInfoPtr_lock_obj, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00014B2C File Offset: 0x00012D2C
		// (set) Token: 0x06000118 RID: 280 RVA: 0x000025B9 File Offset: 0x000007B9
		public unsafe static Queue<CFNetwork.GetProxyData> get_proxy_queue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFNetwork.NativeFieldInfoPtr_get_proxy_queue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<CFNetwork.GetProxyData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFNetwork.NativeFieldInfoPtr_get_proxy_queue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00014B54 File Offset: 0x00012D54
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000025CB File Offset: 0x000007CB
		public unsafe static AutoResetEvent proxy_event
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFNetwork.NativeFieldInfoPtr_proxy_event, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoResetEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFNetwork.NativeFieldInfoPtr_proxy_event, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_lock_obj;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_get_proxy_queue;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_proxy_event;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptSequential_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkExecuteProxyAutoConfigurationURL_Private_Static_IntPtr_IntPtr_IntPtr_CFProxyAutoConfigurationResultCallback_byref_CFStreamClientContext_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptThread_Private_Static_Void_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScript_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_CopyProxiesForAutoConfigurationScript_Private_Static_CFArray_IntPtr_CFUrl_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_CFUrl_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkCopyProxiesForURL_Private_Static_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_CopyProxiesForURL_Private_Static_CFArray_CFUrl_CFDictionary_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiesForURL_Public_Static_Il2CppReferenceArray_1_CFProxy_CFUrl_CFProxySettings_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiesForUri_Public_Static_Il2CppReferenceArray_1_CFProxy_Uri_CFProxySettings_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkCopySystemProxySettings_Private_Static_IntPtr_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemProxySettings_Public_Static_CFProxySettings_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProxy_Public_Static_IWebProxy_0;

		// Token: 0x02000178 RID: 376
		public class GetProxyData : Object
		{
			// Token: 0x06001638 RID: 5688 RVA: 0x00062430 File Offset: 0x00060630
			// Note: this type is marked as 'beforefieldinit'.
			static GetProxyData()
			{
				Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "GetProxyData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr);
				CFNetwork.GetProxyData.NativeFieldInfoPtr_script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, "script");
				CFNetwork.GetProxyData.NativeFieldInfoPtr_targetUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, "targetUri");
				CFNetwork.GetProxyData.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, "error");
				CFNetwork.GetProxyData.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, "result");
				CFNetwork.GetProxyData.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, "evt");
				CFNetwork.GetProxyData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, 100663509);
				CFNetwork.GetProxyData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, 100663510);
			}

			// Token: 0x06001639 RID: 5689 RVA: 0x000624E8 File Offset: 0x000606E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32644, XrefRangeEnd = 32645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.GetProxyData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600163A RID: 5690 RVA: 0x0006251C File Offset: 0x0006071C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32775, RefRangeEnd = 32776, XrefRangeStart = 32645, XrefRangeEnd = 32775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetProxyData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.GetProxyData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600163B RID: 5691 RVA: 0x0000B7B7 File Offset: 0x000099B7
			public GetProxyData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x0600163C RID: 5692 RVA: 0x00062558 File Offset: 0x00060758
			// (set) Token: 0x0600163D RID: 5693 RVA: 0x0000B7C0 File Offset: 0x000099C0
			public unsafe IntPtr script
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_script);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_script)) = value;
				}
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x0600163E RID: 5694 RVA: 0x00062580 File Offset: 0x00060780
			// (set) Token: 0x0600163F RID: 5695 RVA: 0x0000B7DB File Offset: 0x000099DB
			public unsafe IntPtr targetUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_targetUri);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_targetUri)) = value;
				}
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06001640 RID: 5696 RVA: 0x000625A8 File Offset: 0x000607A8
			// (set) Token: 0x06001641 RID: 5697 RVA: 0x0000B7F6 File Offset: 0x000099F6
			public unsafe IntPtr error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_error);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_error)) = value;
				}
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06001642 RID: 5698 RVA: 0x000625D0 File Offset: 0x000607D0
			// (set) Token: 0x06001643 RID: 5699 RVA: 0x0000B811 File Offset: 0x00009A11
			public unsafe IntPtr result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x06001644 RID: 5700 RVA: 0x000625F8 File Offset: 0x000607F8
			// (set) Token: 0x06001645 RID: 5701 RVA: 0x0000B82C File Offset: 0x00009A2C
			public unsafe ManualResetEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011BF RID: 4543
			private static readonly IntPtr NativeFieldInfoPtr_script;

			// Token: 0x040011C0 RID: 4544
			private static readonly IntPtr NativeFieldInfoPtr_targetUri;

			// Token: 0x040011C1 RID: 4545
			private static readonly IntPtr NativeFieldInfoPtr_error;

			// Token: 0x040011C2 RID: 4546
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x040011C3 RID: 4547
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x040011C4 RID: 4548
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040011C5 RID: 4549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000179 RID: 377
		public sealed class CFProxyAutoConfigurationResultCallback : MulticastDelegate
		{
			// Token: 0x06001646 RID: 5702 RVA: 0x0000B84B File Offset: 0x00009A4B
			// Note: this type is marked as 'beforefieldinit'.
			static CFProxyAutoConfigurationResultCallback()
			{
				Il2CppClassPointerStore<CFNetwork.CFProxyAutoConfigurationResultCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "CFProxyAutoConfigurationResultCallback");
				CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFProxyAutoConfigurationResultCallback>.NativeClassPtr, 100663511);
				CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFProxyAutoConfigurationResultCallback>.NativeClassPtr, 100663512);
			}

			// Token: 0x06001647 RID: 5703 RVA: 0x00062628 File Offset: 0x00060828
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CFProxyAutoConfigurationResultCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFNetwork.CFProxyAutoConfigurationResultCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001648 RID: 5704 RVA: 0x00062684 File Offset: 0x00060884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32776, XrefRangeEnd = 32780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr client, IntPtr proxyList, IntPtr error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref client;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proxyList;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001649 RID: 5705 RVA: 0x0000B889 File Offset: 0x00009A89
			public CFProxyAutoConfigurationResultCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600164A RID: 5706 RVA: 0x0000B892 File Offset: 0x00009A92
			public static implicit operator CFNetwork.CFProxyAutoConfigurationResultCallback(Action<IntPtr, IntPtr, IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<CFNetwork.CFProxyAutoConfigurationResultCallback>(A_0);
			}

			// Token: 0x0600164B RID: 5707 RVA: 0x0000B89A File Offset: 0x00009A9A
			public static CFNetwork.CFProxyAutoConfigurationResultCallback operator +(CFNetwork.CFProxyAutoConfigurationResultCallback A_0, CFNetwork.CFProxyAutoConfigurationResultCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CFNetwork.CFProxyAutoConfigurationResultCallback>();
			}

			// Token: 0x0600164C RID: 5708 RVA: 0x0000B8A8 File Offset: 0x00009AA8
			public static CFNetwork.CFProxyAutoConfigurationResultCallback operator -(CFNetwork.CFProxyAutoConfigurationResultCallback A_0, CFNetwork.CFProxyAutoConfigurationResultCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CFNetwork.CFProxyAutoConfigurationResultCallback>();
				}
				return delegate2;
			}

			// Token: 0x040011C6 RID: 4550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040011C7 RID: 4551
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0;
		}

		// Token: 0x0200017A RID: 378
		public class CFWebProxy : Object
		{
			// Token: 0x0600164D RID: 5709 RVA: 0x000626E0 File Offset: 0x000608E0
			// Note: this type is marked as 'beforefieldinit'.
			static CFWebProxy()
			{
				Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "CFWebProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr);
				CFNetwork.CFWebProxy.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, "credentials");
				CFNetwork.CFWebProxy.NativeFieldInfoPtr_userSpecified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, "userSpecified");
				CFNetwork.CFWebProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663513);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663514);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxyUri_Private_Static_Uri_CFProxy_byref_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663515);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxyUriFromScript_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663516);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663517);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_SelectProxy_Private_Static_Uri_Il2CppReferenceArray_1_CFProxy_Uri_byref_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663518);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663519);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663520);
			}

			// Token: 0x0600164E RID: 5710 RVA: 0x000627D4 File Offset: 0x000609D4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CFWebProxy()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x0600164F RID: 5711 RVA: 0x00062810 File Offset: 0x00060A10
			public unsafe virtual ICredentials Credentials
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
				}
			}

			// Token: 0x06001650 RID: 5712 RVA: 0x00062850 File Offset: 0x00060A50
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 32807, RefRangeEnd = 32809, XrefRangeStart = 32780, XrefRangeEnd = 32807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxyUri_Private_Static_Uri_CFProxy_byref_NetworkCredential_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				credentials = ((intPtr4 == 0) ? null : new NetworkCredential(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
			}

			// Token: 0x06001651 RID: 5713 RVA: 0x000628B8 File Offset: 0x00060AB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32814, RefRangeEnd = 32815, XrefRangeStart = 32809, XrefRangeEnd = 32814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Uri GetProxyUriFromScript(IntPtr script, Uri targetUri, out NetworkCredential credentials)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref script;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxyUriFromScript_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				credentials = ((intPtr4 == 0) ? null : new NetworkCredential(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
			}

			// Token: 0x06001652 RID: 5714 RVA: 0x00062930 File Offset: 0x00060B30
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32820, RefRangeEnd = 32821, XrefRangeStart = 32815, XrefRangeEnd = 32820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Uri ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref proxyAutoConfigURL;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				credentials = ((intPtr4 == 0) ? null : new NetworkCredential(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
			}

			// Token: 0x06001653 RID: 5715 RVA: 0x000629A8 File Offset: 0x00060BA8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 32826, RefRangeEnd = 32828, XrefRangeStart = 32821, XrefRangeEnd = 32826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Uri SelectProxy(Il2CppReferenceArray<CFProxy> proxies, Uri targetUri, out NetworkCredential credentials)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxies);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_SelectProxy_Private_Static_Uri_Il2CppReferenceArray_1_CFProxy_Uri_byref_NetworkCredential_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				credentials = ((intPtr4 == 0) ? null : new NetworkCredential(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
			}

			// Token: 0x06001654 RID: 5716 RVA: 0x00062A24 File Offset: 0x00060C24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32854, RefRangeEnd = 32855, XrefRangeStart = 32828, XrefRangeEnd = 32854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Uri GetProxy(Uri targetUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
				}
			}

			// Token: 0x06001655 RID: 5717 RVA: 0x00062A74 File Offset: 0x00060C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32855, XrefRangeEnd = 32869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool IsBypassed(Uri targetUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001656 RID: 5718 RVA: 0x0000B8B9 File Offset: 0x00009AB9
			public CFWebProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x06001657 RID: 5719 RVA: 0x00062AC4 File Offset: 0x00060CC4
			// (set) Token: 0x06001658 RID: 5720 RVA: 0x0000B8C2 File Offset: 0x00009AC2
			public unsafe ICredentials credentials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.CFWebProxy.NativeFieldInfoPtr_credentials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.CFWebProxy.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06001659 RID: 5721 RVA: 0x00062AF4 File Offset: 0x00060CF4
			// (set) Token: 0x0600165A RID: 5722 RVA: 0x0000B8E1 File Offset: 0x00009AE1
			public unsafe bool userSpecified
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.CFWebProxy.NativeFieldInfoPtr_userSpecified);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.CFWebProxy.NativeFieldInfoPtr_userSpecified)) = value;
				}
			}

			// Token: 0x040011C8 RID: 4552
			private static readonly IntPtr NativeFieldInfoPtr_credentials;

			// Token: 0x040011C9 RID: 4553
			private static readonly IntPtr NativeFieldInfoPtr_userSpecified;

			// Token: 0x040011CA RID: 4554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011CB RID: 4555
			private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0;

			// Token: 0x040011CC RID: 4556
			private static readonly IntPtr NativeMethodInfoPtr_GetProxyUri_Private_Static_Uri_CFProxy_byref_NetworkCredential_0;

			// Token: 0x040011CD RID: 4557
			private static readonly IntPtr NativeMethodInfoPtr_GetProxyUriFromScript_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0;

			// Token: 0x040011CE RID: 4558
			private static readonly IntPtr NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0;

			// Token: 0x040011CF RID: 4559
			private static readonly IntPtr NativeMethodInfoPtr_SelectProxy_Private_Static_Uri_Il2CppReferenceArray_1_CFProxy_Uri_byref_NetworkCredential_0;

			// Token: 0x040011D0 RID: 4560
			private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0;

			// Token: 0x040011D1 RID: 4561
			private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0;
		}

		// Token: 0x0200017B RID: 379
		[ObfuscatedName("Mono.Net.CFNetwork+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600165B RID: 5723 RVA: 0x00062B1C File Offset: 0x00060D1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr);
				CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_proxies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr, "proxies");
				CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_runLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr, "runLoop");
				CFNetwork.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr, 100663521);
				CFNetwork.__c__DisplayClass13_0.NativeMethodInfoPtr__ExecuteProxyAutoConfigurationURL_b__0_Internal_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr, 100663522);
			}

			// Token: 0x0600165C RID: 5724 RVA: 0x00062B98 File Offset: 0x00060D98
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600165D RID: 5725 RVA: 0x00062BD4 File Offset: 0x00060DD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32869, XrefRangeEnd = 32897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExecuteProxyAutoConfigurationURL_b__0(IntPtr client, IntPtr proxyList, IntPtr error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref client;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proxyList;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.__c__DisplayClass13_0.NativeMethodInfoPtr__ExecuteProxyAutoConfigurationURL_b__0_Internal_Void_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600165E RID: 5726 RVA: 0x0000B8FC File Offset: 0x00009AFC
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x0600165F RID: 5727 RVA: 0x00062C30 File Offset: 0x00060E30
			// (set) Token: 0x06001660 RID: 5728 RVA: 0x0000B905 File Offset: 0x00009B05
			public unsafe Il2CppReferenceArray<CFProxy> proxies
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_proxies);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_proxies), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x06001661 RID: 5729 RVA: 0x00062C60 File Offset: 0x00060E60
			// (set) Token: 0x06001662 RID: 5730 RVA: 0x0000B924 File Offset: 0x00009B24
			public unsafe CFRunLoop runLoop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_runLoop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CFRunLoop>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_runLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011D2 RID: 4562
			private static readonly IntPtr NativeFieldInfoPtr_proxies;

			// Token: 0x040011D3 RID: 4563
			private static readonly IntPtr NativeFieldInfoPtr_runLoop;

			// Token: 0x040011D4 RID: 4564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011D5 RID: 4565
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteProxyAutoConfigurationURL_b__0_Internal_Void_IntPtr_IntPtr_IntPtr_0;
		}
	}
}
