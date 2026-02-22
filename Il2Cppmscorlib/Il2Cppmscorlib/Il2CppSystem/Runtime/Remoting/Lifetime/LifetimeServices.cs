using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003B3 RID: 947
	public sealed class LifetimeServices : Object
	{
		// Token: 0x06003D64 RID: 15716 RVA: 0x00120128 File Offset: 0x0011E328
		// Note: this type is marked as 'beforefieldinit'.
		static LifetimeServices()
		{
			Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LifetimeServices");
			LifetimeServices.NativeFieldInfoPtr__leaseManagerPollTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseManagerPollTime");
			LifetimeServices.NativeFieldInfoPtr__leaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseTime");
			LifetimeServices.NativeFieldInfoPtr__renewOnCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_renewOnCallTime");
			LifetimeServices.NativeFieldInfoPtr__sponsorshipTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_sponsorshipTimeout");
			LifetimeServices.NativeFieldInfoPtr__leaseManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseManager");
			LifetimeServices.NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672334);
			LifetimeServices.NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672335);
			LifetimeServices.NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672336);
			LifetimeServices.NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672337);
			LifetimeServices.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672338);
			LifetimeServices.NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672339);
			LifetimeServices.NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672340);
			LifetimeServices.NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672341);
			LifetimeServices.NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100672342);
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x00120268 File Offset: 0x0011E468
		// (set) Token: 0x06003D66 RID: 15718 RVA: 0x00120298 File Offset: 0x0011E498
		public unsafe static TimeSpan LeaseManagerPollTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352192, XrefRangeEnd = 352196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 352203, RefRangeEnd = 352204, XrefRangeStart = 352196, XrefRangeEnd = 352203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06003D67 RID: 15719 RVA: 0x001202CC File Offset: 0x0011E4CC
		// (set) Token: 0x06003D68 RID: 15720 RVA: 0x001202FC File Offset: 0x0011E4FC
		public unsafe static TimeSpan LeaseTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352204, XrefRangeEnd = 352208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352208, XrefRangeEnd = 352212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06003D69 RID: 15721 RVA: 0x00120330 File Offset: 0x0011E530
		// (set) Token: 0x06003D6A RID: 15722 RVA: 0x00120360 File Offset: 0x0011E560
		public unsafe static TimeSpan RenewOnCallTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352212, XrefRangeEnd = 352216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352216, XrefRangeEnd = 352220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06003D6B RID: 15723 RVA: 0x00120394 File Offset: 0x0011E594
		// (set) Token: 0x06003D6C RID: 15724 RVA: 0x001203C4 File Offset: 0x0011E5C4
		public unsafe static TimeSpan SponsorshipTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352220, XrefRangeEnd = 352224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352224, XrefRangeEnd = 352228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x001203F8 File Offset: 0x0011E5F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352255, RefRangeEnd = 352257, XrefRangeStart = 352228, XrefRangeEnd = 352255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrackLifetime(ServerIdentity identity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LifetimeServices.NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x00017202 File Offset: 0x00015402
		public LifetimeServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06003D6F RID: 15727 RVA: 0x00120430 File Offset: 0x0011E630
		// (set) Token: 0x06003D70 RID: 15728 RVA: 0x0001720B File Offset: 0x0001540B
		public unsafe static TimeSpan _leaseManagerPollTime
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__leaseManagerPollTime, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__leaseManagerPollTime, (void*)(&value));
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06003D71 RID: 15729 RVA: 0x0012044C File Offset: 0x0011E64C
		// (set) Token: 0x06003D72 RID: 15730 RVA: 0x00017219 File Offset: 0x00015419
		public unsafe static TimeSpan _leaseTime
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__leaseTime, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__leaseTime, (void*)(&value));
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06003D73 RID: 15731 RVA: 0x00120468 File Offset: 0x0011E668
		// (set) Token: 0x06003D74 RID: 15732 RVA: 0x00017227 File Offset: 0x00015427
		public unsafe static TimeSpan _renewOnCallTime
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__renewOnCallTime, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__renewOnCallTime, (void*)(&value));
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06003D75 RID: 15733 RVA: 0x00120484 File Offset: 0x0011E684
		// (set) Token: 0x06003D76 RID: 15734 RVA: 0x00017235 File Offset: 0x00015435
		public unsafe static TimeSpan _sponsorshipTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__sponsorshipTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__sponsorshipTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06003D77 RID: 15735 RVA: 0x001204A0 File Offset: 0x0011E6A0
		// (set) Token: 0x06003D78 RID: 15736 RVA: 0x00017243 File Offset: 0x00015443
		public unsafe static LeaseManager _leaseManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LifetimeServices.NativeFieldInfoPtr__leaseManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaseManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LifetimeServices.NativeFieldInfoPtr__leaseManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032D1 RID: 13009
		private static readonly IntPtr NativeFieldInfoPtr__leaseManagerPollTime;

		// Token: 0x040032D2 RID: 13010
		private static readonly IntPtr NativeFieldInfoPtr__leaseTime;

		// Token: 0x040032D3 RID: 13011
		private static readonly IntPtr NativeFieldInfoPtr__renewOnCallTime;

		// Token: 0x040032D4 RID: 13012
		private static readonly IntPtr NativeFieldInfoPtr__sponsorshipTimeout;

		// Token: 0x040032D5 RID: 13013
		private static readonly IntPtr NativeFieldInfoPtr__leaseManager;

		// Token: 0x040032D6 RID: 13014
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0;

		// Token: 0x040032D7 RID: 13015
		private static readonly IntPtr NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x040032D8 RID: 13016
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0;

		// Token: 0x040032D9 RID: 13017
		private static readonly IntPtr NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x040032DA RID: 13018
		private static readonly IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0;

		// Token: 0x040032DB RID: 13019
		private static readonly IntPtr NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x040032DC RID: 13020
		private static readonly IntPtr NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0;

		// Token: 0x040032DD RID: 13021
		private static readonly IntPtr NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0;

		// Token: 0x040032DE RID: 13022
		private static readonly IntPtr NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0;
	}
}
