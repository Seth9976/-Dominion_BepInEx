using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000166 RID: 358
	public static class SteamParentalSettings : Object
	{
		// Token: 0x06001BE6 RID: 7142 RVA: 0x0007FEC4 File Offset: 0x0007E0C4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParentalSettings()
		{
			Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamParentalSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr);
			SteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100667126);
			SteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockLocked_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100667127);
			SteamParentalSettings.NativeMethodInfoPtr_BIsAppBlocked_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100667128);
			SteamParentalSettings.NativeMethodInfoPtr_BIsAppInBlockList_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100667129);
			SteamParentalSettings.NativeMethodInfoPtr_BIsFeatureBlocked_Public_Static_Boolean_EParentalFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100667130);
			SteamParentalSettings.NativeMethodInfoPtr_BIsFeatureInBlockList_Public_Static_Boolean_EParentalFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100667131);
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0007FF6C File Offset: 0x0007E16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201057, XrefRangeEnd = 201061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsParentalLockEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0007FF9C File Offset: 0x0007E19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201061, XrefRangeEnd = 201065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsParentalLockLocked()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockLocked_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0007FFCC File Offset: 0x0007E1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201065, XrefRangeEnd = 201069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsAppBlocked(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsAppBlocked_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0008000C File Offset: 0x0007E20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201069, XrefRangeEnd = 201073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsAppInBlockList(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsAppInBlockList_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0008004C File Offset: 0x0007E24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201073, XrefRangeEnd = 201077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsFeatureBlocked(EParentalFeature eFeature)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eFeature;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsFeatureBlocked_Public_Static_Boolean_EParentalFeature_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0008008C File Offset: 0x0007E28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201077, XrefRangeEnd = 201081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsFeatureInBlockList(EParentalFeature eFeature)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eFeature;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsFeatureInBlockList_Public_Static_Boolean_EParentalFeature_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0000BAF6 File Offset: 0x00009CF6
		public SteamParentalSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeMethodInfoPtr_BIsParentalLockEnabled_Public_Static_Boolean_0;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeMethodInfoPtr_BIsParentalLockLocked_Public_Static_Boolean_0;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeMethodInfoPtr_BIsAppBlocked_Public_Static_Boolean_AppId_t_0;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeMethodInfoPtr_BIsAppInBlockList_Public_Static_Boolean_AppId_t_0;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeMethodInfoPtr_BIsFeatureBlocked_Public_Static_Boolean_EParentalFeature_0;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeMethodInfoPtr_BIsFeatureInBlockList_Public_Static_Boolean_EParentalFeature_0;
	}
}
