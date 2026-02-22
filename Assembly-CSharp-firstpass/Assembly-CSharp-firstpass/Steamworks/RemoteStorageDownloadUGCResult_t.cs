using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001FA RID: 506
	public sealed class RemoteStorageDownloadUGCResult_t : ValueType
	{
		// Token: 0x060023DF RID: 9183 RVA: 0x000A5978 File Offset: 0x000A3B78
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageDownloadUGCResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageDownloadUGCResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr);
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_hFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_hFile");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_nAppID");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_nSizeInBytes");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_pchFileName_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_pchFileName_");
			RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_ulSteamIDOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, "m_ulSteamIDOwner");
			RemoteStorageDownloadUGCResult_t.NativeMethodInfoPtr_get_m_pchFileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, 100668355);
			RemoteStorageDownloadUGCResult_t.NativeMethodInfoPtr_set_m_pchFileName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr, 100668356);
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x000A5A5C File Offset: 0x000A3C5C
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x000A5A98 File Offset: 0x000A3C98
		public unsafe string m_pchFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206874, XrefRangeEnd = 206875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageDownloadUGCResult_t.NativeMethodInfoPtr_get_m_pchFileName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206875, XrefRangeEnd = 206876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageDownloadUGCResult_t.NativeMethodInfoPtr_set_m_pchFileName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x0000DCF3 File Offset: 0x0000BEF3
		public RemoteStorageDownloadUGCResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0000DCFC File Offset: 0x0000BEFC
		public RemoteStorageDownloadUGCResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageDownloadUGCResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x000A5AE0 File Offset: 0x000A3CE0
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x0000DD0E File Offset: 0x0000BF0E
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000A5AFC File Offset: 0x000A3CFC
		// (set) Token: 0x060023E7 RID: 9191 RVA: 0x0000DD1C File Offset: 0x0000BF1C
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000A5B24 File Offset: 0x000A3D24
		// (set) Token: 0x060023E9 RID: 9193 RVA: 0x0000DD37 File Offset: 0x0000BF37
		public unsafe UGCHandle_t m_hFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_hFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_hFile)) = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x000A5B4C File Offset: 0x000A3D4C
		// (set) Token: 0x060023EB RID: 9195 RVA: 0x0000DD52 File Offset: 0x0000BF52
		public unsafe AppId_t m_nAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nAppID)) = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000A5B74 File Offset: 0x000A3D74
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x0000DD6D File Offset: 0x0000BF6D
		public unsafe int m_nSizeInBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nSizeInBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_nSizeInBytes)) = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x000A5B9C File Offset: 0x000A3D9C
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x0000DD88 File Offset: 0x0000BF88
		public unsafe Il2CppStructArray<byte> m_pchFileName_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_pchFileName_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_pchFileName_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x000A5BCC File Offset: 0x000A3DCC
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x0000DDA7 File Offset: 0x0000BFA7
		public unsafe ulong m_ulSteamIDOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_ulSteamIDOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageDownloadUGCResult_t.NativeFieldInfoPtr_m_ulSteamIDOwner)) = value;
			}
		}

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeFieldInfoPtr_m_hFile;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeFieldInfoPtr_m_nSizeInBytes;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeFieldInfoPtr_m_pchFileName_;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDOwner;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_get_m_pchFileName_Public_get_String_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_set_m_pchFileName_Public_set_Void_String_0;
	}
}
