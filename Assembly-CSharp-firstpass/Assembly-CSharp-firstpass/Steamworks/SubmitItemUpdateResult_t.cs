using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200020F RID: 527
	[StructLayout(2)]
	public struct SubmitItemUpdateResult_t
	{
		// Token: 0x060024B0 RID: 9392 RVA: 0x000A751C File Offset: 0x000A571C
		// Note: this type is marked as 'beforefieldinit'.
		static SubmitItemUpdateResult_t()
		{
			Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SubmitItemUpdateResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr);
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "k_iCallback");
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "m_eResult");
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "m_bUserNeedsToAcceptWorkshopLegalAgreement");
			SubmitItemUpdateResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x0000E5CA File Offset: 0x0000C7CA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubmitItemUpdateResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x000A759C File Offset: 0x000A579C
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SubmitItemUpdateResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubmitItemUpdateResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E0C RID: 7692
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001E0D RID: 7693
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x04001E0E RID: 7694
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
