using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001F2 RID: 498
	public sealed class RemoteStorageFileShareResult_t : ValueType
	{
		// Token: 0x060023A2 RID: 9122 RVA: 0x000A51EC File Offset: 0x000A33EC
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageFileShareResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageFileShareResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr);
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_hFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "m_hFile");
			RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_rgchFilename_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, "m_rgchFilename_");
			RemoteStorageFileShareResult_t.NativeMethodInfoPtr_get_m_rgchFilename_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, 100668353);
			RemoteStorageFileShareResult_t.NativeMethodInfoPtr_set_m_rgchFilename_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr, 100668354);
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x000A5294 File Offset: 0x000A3494
		// (set) Token: 0x060023A4 RID: 9124 RVA: 0x000A52D0 File Offset: 0x000A34D0
		public unsafe string m_rgchFilename
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 206854, RefRangeEnd = 206855, XrefRangeStart = 206854, XrefRangeEnd = 206855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageFileShareResult_t.NativeMethodInfoPtr_get_m_rgchFilename_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206873, XrefRangeEnd = 206874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageFileShareResult_t.NativeMethodInfoPtr_set_m_rgchFilename_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0000DA84 File Offset: 0x0000BC84
		public RemoteStorageFileShareResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x0000DA8D File Offset: 0x0000BC8D
		public RemoteStorageFileShareResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageFileShareResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x000A5318 File Offset: 0x000A3518
		// (set) Token: 0x060023A8 RID: 9128 RVA: 0x0000DA9F File Offset: 0x0000BC9F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x000A5334 File Offset: 0x000A3534
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x0000DAAD File Offset: 0x0000BCAD
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x000A535C File Offset: 0x000A355C
		// (set) Token: 0x060023AC RID: 9132 RVA: 0x0000DAC8 File Offset: 0x0000BCC8
		public unsafe UGCHandle_t m_hFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_hFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_hFile)) = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x000A5384 File Offset: 0x000A3584
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x0000DAE3 File Offset: 0x0000BCE3
		public unsafe Il2CppStructArray<byte> m_rgchFilename_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_rgchFilename_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageFileShareResult_t.NativeFieldInfoPtr_m_rgchFilename_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeFieldInfoPtr_m_hFile;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchFilename_;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchFilename_Public_get_String_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchFilename_Public_set_Void_String_0;
	}
}
