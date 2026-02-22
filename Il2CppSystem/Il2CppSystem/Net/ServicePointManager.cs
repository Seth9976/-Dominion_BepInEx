using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Specialized;

namespace Il2CppSystem.Net
{
	// Token: 0x02000114 RID: 276
	public class ServicePointManager : Object
	{
		// Token: 0x06001197 RID: 4503 RVA: 0x00052358 File Offset: 0x00050558
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePointManager()
		{
			Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServicePointManager");
			ServicePointManager.NativeFieldInfoPtr_servicePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "servicePoints");
			ServicePointManager.NativeFieldInfoPtr_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "policy");
			ServicePointManager.NativeFieldInfoPtr_defaultConnectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "defaultConnectionLimit");
			ServicePointManager.NativeFieldInfoPtr_maxServicePointIdleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "maxServicePointIdleTime");
			ServicePointManager.NativeFieldInfoPtr_maxServicePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "maxServicePoints");
			ServicePointManager.NativeFieldInfoPtr_dnsRefreshTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "dnsRefreshTimeout");
			ServicePointManager.NativeFieldInfoPtr__checkCRL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "_checkCRL");
			ServicePointManager.NativeFieldInfoPtr__securityProtocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "_securityProtocol");
			ServicePointManager.NativeFieldInfoPtr_expectContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "expectContinue");
			ServicePointManager.NativeFieldInfoPtr_useNagle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "useNagle");
			ServicePointManager.NativeFieldInfoPtr_server_cert_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "server_cert_cb");
			ServicePointManager.NativeFieldInfoPtr_tcp_keepalive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive");
			ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive_time");
			ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive_interval");
			ServicePointManager.NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665719);
			ServicePointManager.NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665720);
			ServicePointManager.NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665721);
			ServicePointManager.NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665722);
			ServicePointManager.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665723);
			ServicePointManager.NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665724);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00052510 File Offset: 0x00050710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52997, XrefRangeEnd = 53001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICertificatePolicy GetLegacyCertificatePolicy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICertificatePolicy>(intPtr3) : null;
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00052544 File Offset: 0x00050744
		public unsafe static bool CheckCertificateRevocationList
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53001, XrefRangeEnd = 53005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00052574 File Offset: 0x00050774
		public unsafe static int DnsRefreshTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53005, XrefRangeEnd = 53009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x000525A4 File Offset: 0x000507A4
		public unsafe static SecurityProtocolType SecurityProtocol
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53009, XrefRangeEnd = 53013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x000525D4 File Offset: 0x000507D4
		public unsafe static ServerCertValidationCallback ServerCertValidationCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53013, XrefRangeEnd = 53017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00052608 File Offset: 0x00050808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53089, RefRangeEnd = 53091, XrefRangeStart = 53017, XrefRangeEnd = 53089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00009265 File Offset: 0x00007465
		public ServicePointManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x00052660 File Offset: 0x00050860
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x0000926E File Offset: 0x0000746E
		public unsafe static HybridDictionary servicePoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_servicePoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HybridDictionary>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_servicePoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00052688 File Offset: 0x00050888
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x00009280 File Offset: 0x00007480
		public unsafe static ICertificatePolicy policy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_policy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICertificatePolicy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_policy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x000526B0 File Offset: 0x000508B0
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x00009292 File Offset: 0x00007492
		public unsafe static int defaultConnectionLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_defaultConnectionLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_defaultConnectionLimit, (void*)(&value));
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x000526CC File Offset: 0x000508CC
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x000092A0 File Offset: 0x000074A0
		public unsafe static int maxServicePointIdleTime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_maxServicePointIdleTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_maxServicePointIdleTime, (void*)(&value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x000526E8 File Offset: 0x000508E8
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x000092AE File Offset: 0x000074AE
		public unsafe static int maxServicePoints
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_maxServicePoints, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_maxServicePoints, (void*)(&value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00052704 File Offset: 0x00050904
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x000092BC File Offset: 0x000074BC
		public unsafe static int dnsRefreshTimeout
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_dnsRefreshTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_dnsRefreshTimeout, (void*)(&value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00052720 File Offset: 0x00050920
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x000092CA File Offset: 0x000074CA
		public unsafe static bool _checkCRL
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr__checkCRL, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr__checkCRL, (void*)(&value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x0005273C File Offset: 0x0005093C
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x000092D8 File Offset: 0x000074D8
		public unsafe static SecurityProtocolType _securityProtocol
		{
			get
			{
				SecurityProtocolType securityProtocolType;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr__securityProtocol, (void*)(&securityProtocolType));
				return securityProtocolType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr__securityProtocol, (void*)(&value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x00052758 File Offset: 0x00050958
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x000092E6 File Offset: 0x000074E6
		public unsafe static bool expectContinue
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_expectContinue, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_expectContinue, (void*)(&value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00052774 File Offset: 0x00050974
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x000092F4 File Offset: 0x000074F4
		public unsafe static bool useNagle
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_useNagle, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_useNagle, (void*)(&value));
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00052790 File Offset: 0x00050990
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x00009302 File Offset: 0x00007502
		public unsafe static ServerCertValidationCallback server_cert_cb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_server_cert_cb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_server_cert_cb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000527B8 File Offset: 0x000509B8
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x00009314 File Offset: 0x00007514
		public unsafe static bool tcp_keepalive
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive, (void*)(&value));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000527D4 File Offset: 0x000509D4
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x00009322 File Offset: 0x00007522
		public unsafe static int tcp_keepalive_time
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_time, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_time, (void*)(&value));
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000527F0 File Offset: 0x000509F0
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x00009330 File Offset: 0x00007530
		public unsafe static int tcp_keepalive_interval
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_interval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_interval, (void*)(&value));
			}
		}

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeFieldInfoPtr_servicePoints;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeFieldInfoPtr_policy;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeFieldInfoPtr_defaultConnectionLimit;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeFieldInfoPtr_maxServicePointIdleTime;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeFieldInfoPtr_maxServicePoints;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeFieldInfoPtr_dnsRefreshTimeout;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr__checkCRL;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr__securityProtocol;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr_expectContinue;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeFieldInfoPtr_useNagle;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeFieldInfoPtr_server_cert_cb;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_time;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_interval;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0;

		// Token: 0x020001CC RID: 460
		public class SPKey : Object
		{
			// Token: 0x0600198D RID: 6541 RVA: 0x0006C238 File Offset: 0x0006A438
			// Note: this type is marked as 'beforefieldinit'.
			static SPKey()
			{
				Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "SPKey");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr);
				ServicePointManager.SPKey.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, "uri");
				ServicePointManager.SPKey.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, "proxy");
				ServicePointManager.SPKey.NativeFieldInfoPtr_use_connect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, "use_connect");
				ServicePointManager.SPKey.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100665725);
				ServicePointManager.SPKey.NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100665726);
				ServicePointManager.SPKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100665727);
				ServicePointManager.SPKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100665728);
			}

			// Token: 0x0600198E RID: 6542 RVA: 0x0006C2F0 File Offset: 0x0006A4F0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 52975, RefRangeEnd = 52980, XrefRangeStart = 52974, XrefRangeEnd = 52975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SPKey(Uri uri, Uri proxy, bool use_connect)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref use_connect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.SPKey.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x0600198F RID: 6543 RVA: 0x0006C35C File Offset: 0x0006A55C
			public unsafe bool UsesProxy
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 52984, RefRangeEnd = 52987, XrefRangeStart = 52980, XrefRangeEnd = 52984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.SPKey.NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001990 RID: 6544 RVA: 0x0006C398 File Offset: 0x0006A598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52987, XrefRangeEnd = 52992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServicePointManager.SPKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001991 RID: 6545 RVA: 0x0006C3E0 File Offset: 0x0006A5E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52992, XrefRangeEnd = 52997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServicePointManager.SPKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001992 RID: 6546 RVA: 0x0000D90D File Offset: 0x0000BB0D
			public SPKey(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700082B RID: 2091
			// (get) Token: 0x06001993 RID: 6547 RVA: 0x0006C438 File Offset: 0x0006A638
			// (set) Token: 0x06001994 RID: 6548 RVA: 0x0000D916 File Offset: 0x0000BB16
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082C RID: 2092
			// (get) Token: 0x06001995 RID: 6549 RVA: 0x0006C468 File Offset: 0x0006A668
			// (set) Token: 0x06001996 RID: 6550 RVA: 0x0000D935 File Offset: 0x0000BB35
			public unsafe Uri proxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_proxy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x06001997 RID: 6551 RVA: 0x0006C498 File Offset: 0x0006A698
			// (set) Token: 0x06001998 RID: 6552 RVA: 0x0000D954 File Offset: 0x0000BB54
			public unsafe bool use_connect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_use_connect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_use_connect)) = value;
				}
			}

			// Token: 0x04001406 RID: 5126
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x04001407 RID: 5127
			private static readonly IntPtr NativeFieldInfoPtr_proxy;

			// Token: 0x04001408 RID: 5128
			private static readonly IntPtr NativeFieldInfoPtr_use_connect;

			// Token: 0x04001409 RID: 5129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0;

			// Token: 0x0400140A RID: 5130
			private static readonly IntPtr NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0;

			// Token: 0x0400140B RID: 5131
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x0400140C RID: 5132
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
		}
	}
}
