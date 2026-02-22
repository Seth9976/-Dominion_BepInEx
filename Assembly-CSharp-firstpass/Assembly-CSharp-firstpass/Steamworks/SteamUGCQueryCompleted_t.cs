using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200020C RID: 524
	public sealed class SteamUGCQueryCompleted_t : ValueType
	{
		// Token: 0x06002490 RID: 9360 RVA: 0x000A7124 File Offset: 0x000A5324
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGCQueryCompleted_t()
		{
			Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamUGCQueryCompleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr);
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "k_iCallback");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_handle");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_eResult");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_unNumResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_unNumResultsReturned");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_unTotalMatchingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_unTotalMatchingResults");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_bCachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_bCachedData");
			SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_rgchNextCursor_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, "m_rgchNextCursor_");
			SteamUGCQueryCompleted_t.NativeMethodInfoPtr_get_m_rgchNextCursor_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, 100668367);
			SteamUGCQueryCompleted_t.NativeMethodInfoPtr_set_m_rgchNextCursor_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr, 100668368);
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x000A7208 File Offset: 0x000A5408
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x000A7244 File Offset: 0x000A5444
		public unsafe string m_rgchNextCursor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCQueryCompleted_t.NativeMethodInfoPtr_get_m_rgchNextCursor_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206885, XrefRangeEnd = 206886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCQueryCompleted_t.NativeMethodInfoPtr_set_m_rgchNextCursor_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x0000E469 File Offset: 0x0000C669
		public SteamUGCQueryCompleted_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x0000E472 File Offset: 0x0000C672
		public SteamUGCQueryCompleted_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGCQueryCompleted_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x000A728C File Offset: 0x000A548C
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0000E484 File Offset: 0x0000C684
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x000A72A8 File Offset: 0x000A54A8
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0000E492 File Offset: 0x0000C692
		public unsafe UGCQueryHandle_t m_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_handle)) = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x000A72D0 File Offset: 0x000A54D0
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0000E4AD File Offset: 0x0000C6AD
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x000A72F8 File Offset: 0x000A54F8
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		public unsafe uint m_unNumResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_unNumResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_unNumResultsReturned)) = value;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x000A7320 File Offset: 0x000A5520
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x0000E4E3 File Offset: 0x0000C6E3
		public unsafe uint m_unTotalMatchingResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_unTotalMatchingResults);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_unTotalMatchingResults)) = value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x000A7348 File Offset: 0x000A5548
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x0000E4FE File Offset: 0x0000C6FE
		public unsafe bool m_bCachedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_bCachedData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_bCachedData)) = value;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x000A7370 File Offset: 0x000A5570
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x0000E519 File Offset: 0x0000C719
		public unsafe Il2CppStructArray<byte> m_rgchNextCursor_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_rgchNextCursor_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCQueryCompleted_t.NativeFieldInfoPtr_m_rgchNextCursor_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeFieldInfoPtr_m_handle;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeFieldInfoPtr_m_unNumResultsReturned;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeFieldInfoPtr_m_unTotalMatchingResults;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeFieldInfoPtr_m_bCachedData;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchNextCursor_;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchNextCursor_Public_get_String_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchNextCursor_Public_set_Void_String_0;
	}
}
