using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Uniject;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000054 RID: 84
	public class AdsIPC : Object
	{
		// Token: 0x060002D9 RID: 729 RVA: 0x0000F66C File Offset: 0x0000D86C
		// Note: this type is marked as 'beforefieldinit'.
		static AdsIPC()
		{
			Il2CppClassPointerStore<AdsIPC>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "AdsIPC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdsIPC>.NativeClassPtr);
			AdsIPC.NativeFieldInfoPtr_adsAdvertisementClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdsIPC>.NativeClassPtr, "adsAdvertisementClassName");
			AdsIPC.NativeFieldInfoPtr_adsMessageSendName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdsIPC>.NativeClassPtr, "adsMessageSendName");
			AdsIPC.NativeFieldInfoPtr_adsAdvertisementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdsIPC>.NativeClassPtr, "adsAdvertisementType");
			AdsIPC.NativeFieldInfoPtr_adsMessageSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdsIPC>.NativeClassPtr, "adsMessageSend");
			AdsIPC.NativeMethodInfoPtr_InitAdsIPC_Internal_Static_Boolean_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdsIPC>.NativeClassPtr, 100663663);
			AdsIPC.NativeMethodInfoPtr_VerifyMethodExists_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdsIPC>.NativeClassPtr, 100663664);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000F714 File Offset: 0x0000D914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154008, XrefRangeEnd = 154017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InitAdsIPC(IUtil util)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(util);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdsIPC.NativeMethodInfoPtr_InitAdsIPC_Internal_Static_Boolean_IUtil_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000F758 File Offset: 0x0000D958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154039, RefRangeEnd = 154041, XrefRangeStart = 154017, XrefRangeEnd = 154039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool VerifyMethodExists()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdsIPC.NativeMethodInfoPtr_VerifyMethodExists_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00003665 File Offset: 0x00001865
		public AdsIPC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000F788 File Offset: 0x0000D988
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0000366E File Offset: 0x0000186E
		public unsafe static string adsAdvertisementClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AdsIPC.NativeFieldInfoPtr_adsAdvertisementClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdsIPC.NativeFieldInfoPtr_adsAdvertisementClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00003680 File Offset: 0x00001880
		public unsafe static string adsMessageSendName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AdsIPC.NativeFieldInfoPtr_adsMessageSendName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdsIPC.NativeFieldInfoPtr_adsMessageSendName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00003692 File Offset: 0x00001892
		public unsafe static Type adsAdvertisementType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AdsIPC.NativeFieldInfoPtr_adsAdvertisementType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdsIPC.NativeFieldInfoPtr_adsAdvertisementType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000F7F0 File Offset: 0x0000D9F0
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x000036A4 File Offset: 0x000018A4
		public unsafe static MethodInfo adsMessageSend
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AdsIPC.NativeFieldInfoPtr_adsMessageSend, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdsIPC.NativeFieldInfoPtr_adsMessageSend, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_adsAdvertisementClassName;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_adsMessageSendName;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_adsAdvertisementType;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_adsMessageSend;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_InitAdsIPC_Internal_Static_Boolean_IUtil_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_VerifyMethodExists_Internal_Static_Boolean_0;
	}
}
