using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000213 RID: 531
	[StructLayout(2)]
	public struct SetUserItemVoteResult_t
	{
		// Token: 0x060024C0 RID: 9408 RVA: 0x000A7778 File Offset: 0x000A5978
		// Note: this type is marked as 'beforefieldinit'.
		static SetUserItemVoteResult_t()
		{
			Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SetUserItemVoteResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr);
			SetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "k_iCallback");
			SetUserItemVoteResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "m_nPublishedFileId");
			SetUserItemVoteResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "m_eResult");
			SetUserItemVoteResult_t.NativeFieldInfoPtr_m_bVoteUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "m_bVoteUp");
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0000E64A File Offset: 0x0000C84A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x000A77F8 File Offset: 0x000A59F8
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x0000E65C File Offset: 0x0000C85C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeFieldInfoPtr_m_bVoteUp;

		// Token: 0x04001E26 RID: 7718
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001E27 RID: 7719
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x04001E28 RID: 7720
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_bVoteUp;
	}
}
