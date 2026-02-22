using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200018F RID: 399
	public sealed class GSClientDeny_t : ValueType
	{
		// Token: 0x0600215F RID: 8543 RVA: 0x000A0BC0 File Offset: 0x0009EDC0
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientDeny_t()
		{
			Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSClientDeny_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr);
			GSClientDeny_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "k_iCallback");
			GSClientDeny_t.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "m_SteamID");
			GSClientDeny_t.NativeFieldInfoPtr_m_eDenyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "m_eDenyReason");
			GSClientDeny_t.NativeFieldInfoPtr_m_rgchOptionalText_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, "m_rgchOptionalText_");
			GSClientDeny_t.NativeMethodInfoPtr_get_m_rgchOptionalText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, 100668339);
			GSClientDeny_t.NativeMethodInfoPtr_set_m_rgchOptionalText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr, 100668340);
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x000A0C68 File Offset: 0x0009EE68
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x000A0CA4 File Offset: 0x0009EEA4
		public unsafe string m_rgchOptionalText
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 206854, RefRangeEnd = 206855, XrefRangeStart = 206854, XrefRangeEnd = 206855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientDeny_t.NativeMethodInfoPtr_get_m_rgchOptionalText_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206862, XrefRangeEnd = 206863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientDeny_t.NativeMethodInfoPtr_set_m_rgchOptionalText_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x0000C21C File Offset: 0x0000A41C
		public GSClientDeny_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x0000C225 File Offset: 0x0000A425
		public GSClientDeny_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GSClientDeny_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x000A0CEC File Offset: 0x0009EEEC
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x0000C237 File Offset: 0x0000A437
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientDeny_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientDeny_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x000A0D08 File Offset: 0x0009EF08
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x0000C245 File Offset: 0x0000A445
		public unsafe CSteamID m_SteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_SteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_SteamID)) = value;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x000A0D30 File Offset: 0x0009EF30
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x0000C260 File Offset: 0x0000A460
		public unsafe EDenyReason m_eDenyReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_eDenyReason);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_eDenyReason)) = value;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x000A0D58 File Offset: 0x0009EF58
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x0000C27B File Offset: 0x0000A47B
		public unsafe Il2CppStructArray<byte> m_rgchOptionalText_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_rgchOptionalText_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GSClientDeny_t.NativeFieldInfoPtr_m_rgchOptionalText_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeFieldInfoPtr_m_eDenyReason;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchOptionalText_;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchOptionalText_Public_get_String_0;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchOptionalText_Public_set_Void_String_0;
	}
}
