using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000073 RID: 115
	public class SubscriptionInfo : Object
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x00015668 File Offset: 0x00013868
		// Note: this type is marked as 'beforefieldinit'.
		static SubscriptionInfo()
		{
			Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "SubscriptionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr);
			SubscriptionInfo.NativeFieldInfoPtr_is_subscribed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "is_subscribed");
			SubscriptionInfo.NativeFieldInfoPtr_is_expired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "is_expired");
			SubscriptionInfo.NativeFieldInfoPtr_is_cancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "is_cancelled");
			SubscriptionInfo.NativeFieldInfoPtr_is_free_trial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "is_free_trial");
			SubscriptionInfo.NativeFieldInfoPtr_is_auto_renewing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "is_auto_renewing");
			SubscriptionInfo.NativeFieldInfoPtr_is_introductory_price_period = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "is_introductory_price_period");
			SubscriptionInfo.NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "productId");
			SubscriptionInfo.NativeFieldInfoPtr_purchaseDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "purchaseDate");
			SubscriptionInfo.NativeFieldInfoPtr_subscriptionExpireDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "subscriptionExpireDate");
			SubscriptionInfo.NativeFieldInfoPtr_subscriptionCancelDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "subscriptionCancelDate");
			SubscriptionInfo.NativeFieldInfoPtr_remainedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "remainedTime");
			SubscriptionInfo.NativeFieldInfoPtr_introductory_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "introductory_price");
			SubscriptionInfo.NativeFieldInfoPtr_introductory_price_period = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "introductory_price_period");
			SubscriptionInfo.NativeFieldInfoPtr_introductory_price_cycles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, "introductory_price_cycles");
			SubscriptionInfo.NativeMethodInfoPtr__ctor_Public_Void_AppleInAppPurchaseReceipt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, 100663873);
			SubscriptionInfo.NativeMethodInfoPtr_isExpired_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr, 100663874);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000157D8 File Offset: 0x000139D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156352, RefRangeEnd = 156354, XrefRangeStart = 156207, XrefRangeEnd = 156352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriptionInfo(AppleInAppPurchaseReceipt r, string intro_json)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriptionInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(intro_json);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionInfo.NativeMethodInfoPtr__ctor_Public_Void_AppleInAppPurchaseReceipt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00015838 File Offset: 0x00013A38
		[CallerCount(0)]
		public unsafe Result isExpired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionInfo.NativeMethodInfoPtr_isExpired_Public_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00004576 File Offset: 0x00002776
		public SubscriptionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00015874 File Offset: 0x00013A74
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x0000457F File Offset: 0x0000277F
		public unsafe Result is_subscribed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_subscribed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_subscribed)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0001589C File Offset: 0x00013A9C
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x0000459A File Offset: 0x0000279A
		public unsafe Result is_expired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_expired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_expired)) = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x000158C4 File Offset: 0x00013AC4
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x000045B5 File Offset: 0x000027B5
		public unsafe Result is_cancelled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_cancelled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_cancelled)) = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x000158EC File Offset: 0x00013AEC
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x000045D0 File Offset: 0x000027D0
		public unsafe Result is_free_trial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_free_trial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_free_trial)) = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00015914 File Offset: 0x00013B14
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x000045EB File Offset: 0x000027EB
		public unsafe Result is_auto_renewing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_auto_renewing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_auto_renewing)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0001593C File Offset: 0x00013B3C
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00004606 File Offset: 0x00002806
		public unsafe Result is_introductory_price_period
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_introductory_price_period);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_is_introductory_price_period)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00015964 File Offset: 0x00013B64
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00004621 File Offset: 0x00002821
		public unsafe string productId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_productId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_productId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0001598C File Offset: 0x00013B8C
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00004640 File Offset: 0x00002840
		public unsafe DateTime purchaseDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_purchaseDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_purchaseDate)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x000159B4 File Offset: 0x00013BB4
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x0000465B File Offset: 0x0000285B
		public unsafe DateTime subscriptionExpireDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_subscriptionExpireDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_subscriptionExpireDate)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x000159DC File Offset: 0x00013BDC
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00004676 File Offset: 0x00002876
		public unsafe DateTime subscriptionCancelDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_subscriptionCancelDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_subscriptionCancelDate)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00015A04 File Offset: 0x00013C04
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00004691 File Offset: 0x00002891
		public unsafe TimeSpan remainedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_remainedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_remainedTime)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00015A2C File Offset: 0x00013C2C
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x000046AC File Offset: 0x000028AC
		public unsafe string introductory_price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_introductory_price);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_introductory_price), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00015A54 File Offset: 0x00013C54
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x000046CB File Offset: 0x000028CB
		public unsafe TimeSpan introductory_price_period
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_introductory_price_period);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_introductory_price_period)) = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00015A7C File Offset: 0x00013C7C
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000046E6 File Offset: 0x000028E6
		public unsafe long introductory_price_cycles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_introductory_price_cycles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionInfo.NativeFieldInfoPtr_introductory_price_cycles)) = value;
			}
		}

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_is_subscribed;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_is_expired;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_is_cancelled;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_is_free_trial;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_is_auto_renewing;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_is_introductory_price_period;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_productId;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr_purchaseDate;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeFieldInfoPtr_subscriptionExpireDate;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr_subscriptionCancelDate;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr_remainedTime;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr_introductory_price;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr_introductory_price_period;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeFieldInfoPtr_introductory_price_cycles;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AppleInAppPurchaseReceipt_String_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_isExpired_Public_Result_0;
	}
}
