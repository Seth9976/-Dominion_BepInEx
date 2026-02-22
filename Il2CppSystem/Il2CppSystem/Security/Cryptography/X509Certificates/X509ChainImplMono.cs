using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000096 RID: 150
	public class X509ChainImplMono : X509ChainImpl
	{
		// Token: 0x060008E2 RID: 2274 RVA: 0x00031440 File Offset: 0x0002F640
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainImplMono()
		{
			Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainImplMono");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr);
			X509ChainImplMono.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "location");
			X509ChainImplMono.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "elements");
			X509ChainImplMono.NativeFieldInfoPtr_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "policy");
			X509ChainImplMono.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "status");
			X509ChainImplMono.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "Empty");
			X509ChainImplMono.NativeFieldInfoPtr_working_public_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "working_public_key");
			X509ChainImplMono.NativeFieldInfoPtr_bce_restriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "bce_restriction");
			X509ChainImplMono.NativeFieldInfoPtr_roots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "roots");
			X509ChainImplMono.NativeFieldInfoPtr_cas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "cas");
			X509ChainImplMono.NativeFieldInfoPtr_root_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "root_store");
			X509ChainImplMono.NativeFieldInfoPtr_ca_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "ca_store");
			X509ChainImplMono.NativeFieldInfoPtr_user_root_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "user_root_store");
			X509ChainImplMono.NativeFieldInfoPtr_user_ca_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "user_ca_store");
			X509ChainImplMono.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, "collection");
			X509ChainImplMono.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100664467);
			X509ChainImplMono.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100664468);
			X509ChainImplMono.NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100664469);
			X509ChainImplMono.NativeMethodInfoPtr_set_ChainPolicy_Public_Virtual_set_Void_X509ChainPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100664470);
			X509ChainImplMono.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr, 100664471);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x000315EC File Offset: 0x0002F7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42701, XrefRangeEnd = 42715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainImplMono(bool useMachineContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainImplMono>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMachineContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImplMono.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00031634 File Offset: 0x0002F834
		public unsafe override bool IsValid
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0003167C File Offset: 0x0002F87C
		public unsafe override X509ChainElementCollection ChainElements
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170002BF RID: 703
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x000316C8 File Offset: 0x0002F8C8
		public unsafe override X509ChainPolicy ChainPolicy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_set_ChainPolicy_Public_Virtual_set_Void_X509ChainPolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00031718 File Offset: 0x0002F918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42715, XrefRangeEnd = 42719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImplMono.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000058A3 File Offset: 0x00003AA3
		public X509ChainImplMono(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00031754 File Offset: 0x0002F954
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x000058AC File Offset: 0x00003AAC
		public unsafe StoreLocation location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_location)) = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x0003177C File Offset: 0x0002F97C
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x000058C7 File Offset: 0x00003AC7
		public unsafe X509ChainElementCollection elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x000317AC File Offset: 0x0002F9AC
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x000058E6 File Offset: 0x00003AE6
		public unsafe X509ChainPolicy policy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_policy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainPolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_policy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x000317DC File Offset: 0x0002F9DC
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00005905 File Offset: 0x00003B05
		public unsafe Il2CppReferenceArray<X509ChainStatus> status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_status);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_status), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0003180C File Offset: 0x0002FA0C
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00005924 File Offset: 0x00003B24
		public unsafe static Il2CppReferenceArray<X509ChainStatus> Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509ChainImplMono.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509ChainImplMono.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00031834 File Offset: 0x0002FA34
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00005936 File Offset: 0x00003B36
		public unsafe AsymmetricAlgorithm working_public_key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_working_public_key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_working_public_key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00031864 File Offset: 0x0002FA64
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00005955 File Offset: 0x00003B55
		public unsafe X509ChainElement bce_restriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_bce_restriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_bce_restriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00031894 File Offset: 0x0002FA94
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00005974 File Offset: 0x00003B74
		public unsafe X509Certificate2Collection roots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_roots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_roots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x000318C4 File Offset: 0x0002FAC4
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00005993 File Offset: 0x00003B93
		public unsafe X509Certificate2Collection cas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_cas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_cas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x000318F4 File Offset: 0x0002FAF4
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x000059B2 File Offset: 0x00003BB2
		public unsafe X509Store root_store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_root_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_root_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00031924 File Offset: 0x0002FB24
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x000059D1 File Offset: 0x00003BD1
		public unsafe X509Store ca_store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_ca_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_ca_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00031954 File Offset: 0x0002FB54
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x000059F0 File Offset: 0x00003BF0
		public unsafe X509Store user_root_store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_user_root_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_user_root_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00031984 File Offset: 0x0002FB84
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00005A0F File Offset: 0x00003C0F
		public unsafe X509Store user_ca_store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_user_ca_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_user_ca_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x000319B4 File Offset: 0x0002FBB4
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x00005A2E File Offset: 0x00003C2E
		public unsafe X509Certificate2Collection collection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_collection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainImplMono.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_policy;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_working_public_key;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_bce_restriction;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr_roots;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_cas;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_root_store;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_ca_store;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_user_root_store;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_user_ca_store;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_collection;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainElements_Public_Virtual_get_X509ChainElementCollection_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_set_ChainPolicy_Public_Virtual_set_Void_X509ChainPolicy_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
	}
}
