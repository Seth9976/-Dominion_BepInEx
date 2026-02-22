using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003AF RID: 943
	public class Lease : MarshalByRefObject
	{
		// Token: 0x06003D34 RID: 15668 RVA: 0x0011F728 File Offset: 0x0011D928
		// Note: this type is marked as 'beforefieldinit'.
		static Lease()
		{
			Il2CppClassPointerStore<Lease>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "Lease");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lease>.NativeClassPtr);
			Lease.NativeFieldInfoPtr__leaseExpireTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_leaseExpireTime");
			Lease.NativeFieldInfoPtr__currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_currentState");
			Lease.NativeFieldInfoPtr__initialLeaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_initialLeaseTime");
			Lease.NativeFieldInfoPtr__renewOnCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_renewOnCallTime");
			Lease.NativeFieldInfoPtr__sponsorshipTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_sponsorshipTimeout");
			Lease.NativeFieldInfoPtr__sponsors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_sponsors");
			Lease.NativeFieldInfoPtr__renewingSponsors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_renewingSponsors");
			Lease.NativeFieldInfoPtr__renewalDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lease>.NativeClassPtr, "_renewalDelegate");
			Lease.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672309);
			Lease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Virtual_Final_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672310);
			Lease.NativeMethodInfoPtr_get_CurrentState_Public_Virtual_Final_New_get_LeaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672311);
			Lease.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672312);
			Lease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Virtual_Final_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672313);
			Lease.NativeMethodInfoPtr_Renew_Public_Virtual_Final_New_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672314);
			Lease.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_ISponsor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672315);
			Lease.NativeMethodInfoPtr_UpdateState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672316);
			Lease.NativeMethodInfoPtr_CheckNextSponsor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672317);
			Lease.NativeMethodInfoPtr_ProcessSponsorResponse_Private_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease>.NativeClassPtr, 100672318);
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x0011F8C0 File Offset: 0x0011DAC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352006, RefRangeEnd = 352007, XrefRangeStart = 351984, XrefRangeEnd = 352006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lease()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lease>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06003D36 RID: 15670 RVA: 0x0011F8FC File Offset: 0x0011DAFC
		public unsafe virtual TimeSpan CurrentLeaseTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352007, XrefRangeEnd = 352012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Virtual_Final_New_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06003D37 RID: 15671 RVA: 0x0011F938 File Offset: 0x0011DB38
		public unsafe virtual LeaseState CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_get_CurrentState_Public_Virtual_Final_New_get_LeaseState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x0011F974 File Offset: 0x0011DB74
		[CallerCount(0)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x0011F9A8 File Offset: 0x0011DBA8
		public unsafe virtual TimeSpan RenewOnCallTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Virtual_Final_New_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x0011F9E4 File Offset: 0x0011DBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352012, XrefRangeEnd = 352023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TimeSpan Renew(TimeSpan renewalTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renewalTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_Renew_Public_Virtual_Final_New_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x0011FA30 File Offset: 0x0011DC30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352029, RefRangeEnd = 352030, XrefRangeStart = 352023, XrefRangeEnd = 352029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unregister(ISponsor obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_ISponsor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x0011FA74 File Offset: 0x0011DC74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352041, RefRangeEnd = 352042, XrefRangeStart = 352030, XrefRangeEnd = 352041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_UpdateState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x0011FAA8 File Offset: 0x0011DCA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352062, RefRangeEnd = 352063, XrefRangeStart = 352042, XrefRangeEnd = 352062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNextSponsor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_CheckNextSponsor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x0011FADC File Offset: 0x0011DCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352063, XrefRangeEnd = 352091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSponsorResponse(Object state, bool timedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.NativeMethodInfoPtr_ProcessSponsorResponse_Private_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x000170A6 File Offset: 0x000152A6
		public Lease(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06003D40 RID: 15680 RVA: 0x0011FB2C File Offset: 0x0011DD2C
		// (set) Token: 0x06003D41 RID: 15681 RVA: 0x000170AF File Offset: 0x000152AF
		public unsafe DateTime _leaseExpireTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__leaseExpireTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__leaseExpireTime)) = value;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06003D42 RID: 15682 RVA: 0x0011FB54 File Offset: 0x0011DD54
		// (set) Token: 0x06003D43 RID: 15683 RVA: 0x000170CA File Offset: 0x000152CA
		public unsafe LeaseState _currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__currentState)) = value;
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06003D44 RID: 15684 RVA: 0x0011FB7C File Offset: 0x0011DD7C
		// (set) Token: 0x06003D45 RID: 15685 RVA: 0x000170E5 File Offset: 0x000152E5
		public unsafe TimeSpan _initialLeaseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__initialLeaseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__initialLeaseTime)) = value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06003D46 RID: 15686 RVA: 0x0011FBA4 File Offset: 0x0011DDA4
		// (set) Token: 0x06003D47 RID: 15687 RVA: 0x00017100 File Offset: 0x00015300
		public unsafe TimeSpan _renewOnCallTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewOnCallTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewOnCallTime)) = value;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06003D48 RID: 15688 RVA: 0x0011FBCC File Offset: 0x0011DDCC
		// (set) Token: 0x06003D49 RID: 15689 RVA: 0x0001711B File Offset: 0x0001531B
		public unsafe TimeSpan _sponsorshipTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsorshipTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsorshipTimeout)) = value;
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x0011FBF4 File Offset: 0x0011DDF4
		// (set) Token: 0x06003D4B RID: 15691 RVA: 0x00017136 File Offset: 0x00015336
		public unsafe ArrayList _sponsors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__sponsors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x0011FC24 File Offset: 0x0011DE24
		// (set) Token: 0x06003D4D RID: 15693 RVA: 0x00017155 File Offset: 0x00015355
		public unsafe Queue _renewingSponsors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewingSponsors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewingSponsors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x0011FC54 File Offset: 0x0011DE54
		// (set) Token: 0x06003D4F RID: 15695 RVA: 0x00017174 File Offset: 0x00015374
		public unsafe Lease.RenewalDelegate _renewalDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewalDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lease.RenewalDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lease.NativeFieldInfoPtr__renewalDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032AC RID: 12972
		private static readonly IntPtr NativeFieldInfoPtr__leaseExpireTime;

		// Token: 0x040032AD RID: 12973
		private static readonly IntPtr NativeFieldInfoPtr__currentState;

		// Token: 0x040032AE RID: 12974
		private static readonly IntPtr NativeFieldInfoPtr__initialLeaseTime;

		// Token: 0x040032AF RID: 12975
		private static readonly IntPtr NativeFieldInfoPtr__renewOnCallTime;

		// Token: 0x040032B0 RID: 12976
		private static readonly IntPtr NativeFieldInfoPtr__sponsorshipTimeout;

		// Token: 0x040032B1 RID: 12977
		private static readonly IntPtr NativeFieldInfoPtr__sponsors;

		// Token: 0x040032B2 RID: 12978
		private static readonly IntPtr NativeFieldInfoPtr__renewingSponsors;

		// Token: 0x040032B3 RID: 12979
		private static readonly IntPtr NativeFieldInfoPtr__renewalDelegate;

		// Token: 0x040032B4 RID: 12980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040032B5 RID: 12981
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Virtual_Final_New_get_TimeSpan_0;

		// Token: 0x040032B6 RID: 12982
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Public_Virtual_Final_New_get_LeaseState_0;

		// Token: 0x040032B7 RID: 12983
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x040032B8 RID: 12984
		private static readonly IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Virtual_Final_New_get_TimeSpan_0;

		// Token: 0x040032B9 RID: 12985
		private static readonly IntPtr NativeMethodInfoPtr_Renew_Public_Virtual_Final_New_TimeSpan_TimeSpan_0;

		// Token: 0x040032BA RID: 12986
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_ISponsor_0;

		// Token: 0x040032BB RID: 12987
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Internal_Void_0;

		// Token: 0x040032BC RID: 12988
		private static readonly IntPtr NativeMethodInfoPtr_CheckNextSponsor_Private_Void_0;

		// Token: 0x040032BD RID: 12989
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSponsorResponse_Private_Void_Object_Boolean_0;

		// Token: 0x0200062B RID: 1579
		public sealed class RenewalDelegate : MulticastDelegate
		{
			// Token: 0x06005439 RID: 21561 RVA: 0x00174F34 File Offset: 0x00173134
			// Note: this type is marked as 'beforefieldinit'.
			static RenewalDelegate()
			{
				Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lease>.NativeClassPtr, "RenewalDelegate");
				Lease.RenewalDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100672319);
				Lease.RenewalDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TimeSpan_ILease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100672320);
				Lease.RenewalDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ILease_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100672321);
				Lease.RenewalDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TimeSpan_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr, 100672322);
			}

			// Token: 0x0600543A RID: 21562 RVA: 0x00174FA8 File Offset: 0x001731A8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenewalDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lease.RenewalDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600543B RID: 21563 RVA: 0x00175004 File Offset: 0x00173204
			[CallerCount(0)]
			public unsafe TimeSpan Invoke(ILease lease)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TimeSpan_ILease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600543C RID: 21564 RVA: 0x00175054 File Offset: 0x00173254
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ILease_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600543D RID: 21565 RVA: 0x001750C8 File Offset: 0x001732C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 351983, RefRangeEnd = 351984, XrefRangeStart = 351981, XrefRangeEnd = 351983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lease.RenewalDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TimeSpan_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600543E RID: 21566 RVA: 0x000207A7 File Offset: 0x0001E9A7
			public RenewalDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600543F RID: 21567 RVA: 0x000207B0 File Offset: 0x0001E9B0
			public static implicit operator Lease.RenewalDelegate(Func<ILease, TimeSpan> A_0)
			{
				return DelegateSupport.ConvertDelegate<Lease.RenewalDelegate>(A_0);
			}

			// Token: 0x06005440 RID: 21568 RVA: 0x000207B8 File Offset: 0x0001E9B8
			public static Lease.RenewalDelegate operator +(Lease.RenewalDelegate A_0, Lease.RenewalDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Lease.RenewalDelegate>();
			}

			// Token: 0x06005441 RID: 21569 RVA: 0x000207C6 File Offset: 0x0001E9C6
			public static Lease.RenewalDelegate operator -(Lease.RenewalDelegate A_0, Lease.RenewalDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Lease.RenewalDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040043DC RID: 17372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040043DD RID: 17373
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TimeSpan_ILease_0;

			// Token: 0x040043DE RID: 17374
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ILease_AsyncCallback_Object_0;

			// Token: 0x040043DF RID: 17375
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TimeSpan_IAsyncResult_0;
		}
	}
}
