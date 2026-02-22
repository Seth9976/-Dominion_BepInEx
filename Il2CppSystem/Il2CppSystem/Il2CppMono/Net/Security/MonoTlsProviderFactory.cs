using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000026 RID: 38
	public static class MonoTlsProviderFactory : Object
	{
		// Token: 0x0600020B RID: 523 RVA: 0x00018AE4 File Offset: 0x00016CE4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsProviderFactory()
		{
			Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MonoTlsProviderFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr);
			MonoTlsProviderFactory.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "locker");
			MonoTlsProviderFactory.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "initialized");
			MonoTlsProviderFactory.NativeFieldInfoPtr_defaultProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "defaultProvider");
			MonoTlsProviderFactory.NativeFieldInfoPtr_providerRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "providerRegistration");
			MonoTlsProviderFactory.NativeFieldInfoPtr_providerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "providerCache");
			MonoTlsProviderFactory.NativeFieldInfoPtr_UnityTlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "UnityTlsId");
			MonoTlsProviderFactory.NativeFieldInfoPtr_AppleTlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "AppleTlsId");
			MonoTlsProviderFactory.NativeFieldInfoPtr_BtlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "BtlsId");
			MonoTlsProviderFactory.NativeFieldInfoPtr_LegacyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "LegacyId");
			MonoTlsProviderFactory.NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663653);
			MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663654);
			MonoTlsProviderFactory.NativeMethodInfoPtr_LookupProvider_Private_Static_MonoTlsProvider_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663655);
			MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663656);
			MonoTlsProviderFactory.NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663657);
			MonoTlsProviderFactory.NativeMethodInfoPtr_GetProvider_Internal_Static_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663658);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00018C40 File Offset: 0x00016E40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 34041, RefRangeEnd = 34044, XrefRangeStart = 34030, XrefRangeEnd = 34041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsProvider GetProviderInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MonoTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00018C74 File Offset: 0x00016E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34086, RefRangeEnd = 34087, XrefRangeStart = 34044, XrefRangeEnd = 34086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00018C9C File Offset: 0x00016E9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34131, RefRangeEnd = 34133, XrefRangeStart = 34087, XrefRangeEnd = 34131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsProvider LookupProvider(string name, bool throwOnError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_LookupProvider_Private_Static_MonoTlsProvider_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00018CF0 File Offset: 0x00016EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34217, RefRangeEnd = 34219, XrefRangeStart = 34133, XrefRangeEnd = 34217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeProviderRegistration()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00018D18 File Offset: 0x00016F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34219, XrefRangeEnd = 34229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsProvider CreateDefaultProviderImpl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MonoTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00018D4C File Offset: 0x00016F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34233, RefRangeEnd = 34234, XrefRangeStart = 34229, XrefRangeEnd = 34233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsProvider GetProvider()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_GetProvider_Internal_Static_MonoTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002C14 File Offset: 0x00000E14
		public MonoTlsProviderFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00018D80 File Offset: 0x00016F80
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002C1D File Offset: 0x00000E1D
		public unsafe static Object locker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_locker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_locker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00018DA8 File Offset: 0x00016FA8
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002C2F File Offset: 0x00000E2F
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00018DC4 File Offset: 0x00016FC4
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002C3D File Offset: 0x00000E3D
		public unsafe static MonoTlsProvider defaultProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_defaultProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_defaultProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00018DEC File Offset: 0x00016FEC
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002C4F File Offset: 0x00000E4F
		public unsafe static Dictionary<string, Tuple<Guid, string>> providerRegistration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerRegistration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Tuple<Guid, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerRegistration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00018E14 File Offset: 0x00017014
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002C61 File Offset: 0x00000E61
		public unsafe static Dictionary<Guid, MonoTlsProvider> providerCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Guid, MonoTlsProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00018E3C File Offset: 0x0001703C
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002C73 File Offset: 0x00000E73
		public unsafe static Guid UnityTlsId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_UnityTlsId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_UnityTlsId, (void*)(&value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00018E58 File Offset: 0x00017058
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002C81 File Offset: 0x00000E81
		public unsafe static Guid AppleTlsId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_AppleTlsId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_AppleTlsId, (void*)(&value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00018E74 File Offset: 0x00017074
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002C8F File Offset: 0x00000E8F
		public unsafe static Guid BtlsId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_BtlsId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_BtlsId, (void*)(&value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00018E90 File Offset: 0x00017090
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002C9D File Offset: 0x00000E9D
		public unsafe static Guid LegacyId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_LegacyId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_LegacyId, (void*)(&value));
			}
		}

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_defaultProvider;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_providerRegistration;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_providerCache;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_UnityTlsId;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_AppleTlsId;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_BtlsId;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_LegacyId;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MonoTlsProvider_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_LookupProvider_Private_Static_MonoTlsProvider_String_Boolean_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MonoTlsProvider_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_GetProvider_Internal_Static_MonoTlsProvider_0;
	}
}
