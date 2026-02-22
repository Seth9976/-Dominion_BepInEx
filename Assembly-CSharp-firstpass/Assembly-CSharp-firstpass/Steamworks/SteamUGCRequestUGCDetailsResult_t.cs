using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200020D RID: 525
	public sealed class SteamUGCRequestUGCDetailsResult_t : ValueType
	{
		// Token: 0x060024A3 RID: 9379 RVA: 0x000A73A0 File Offset: 0x000A55A0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGCRequestUGCDetailsResult_t()
		{
			Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamUGCRequestUGCDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr);
			SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, "k_iCallback");
			SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_details = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, "m_details");
			SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_bCachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, "m_bCachedData");
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0000E538 File Offset: 0x0000C738
		public SteamUGCRequestUGCDetailsResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0000E541 File Offset: 0x0000C741
		public SteamUGCRequestUGCDetailsResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x000A740C File Offset: 0x000A560C
		// (set) Token: 0x060024A7 RID: 9383 RVA: 0x0000E553 File Offset: 0x0000C753
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x000A7428 File Offset: 0x000A5628
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x0000E561 File Offset: 0x0000C761
		public SteamUGCDetails_t m_details
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_details);
				return new SteamUGCDetails_t(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_details), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x000A7458 File Offset: 0x000A5658
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x0000E58F File Offset: 0x0000C78F
		public unsafe bool m_bCachedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_bCachedData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_m_bCachedData)) = value;
			}
		}

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeFieldInfoPtr_m_details;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeFieldInfoPtr_m_bCachedData;
	}
}
