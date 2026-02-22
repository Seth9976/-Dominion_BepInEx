using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200020E RID: 526
	[StructLayout(2)]
	public struct CreateItemResult_t
	{
		// Token: 0x060024AC RID: 9388 RVA: 0x000A7480 File Offset: 0x000A5680
		// Note: this type is marked as 'beforefieldinit'.
		static CreateItemResult_t()
		{
			Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CreateItemResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr);
			CreateItemResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "k_iCallback");
			CreateItemResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "m_eResult");
			CreateItemResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "m_nPublishedFileId");
			CreateItemResult_t.NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, "m_bUserNeedsToAcceptWorkshopLegalAgreement");
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0000E5AA File Offset: 0x0000C7AA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateItemResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x000A7500 File Offset: 0x000A5700
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x0000E5BC File Offset: 0x0000C7BC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CreateItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreateItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x04001E05 RID: 7685
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001E06 RID: 7686
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001E07 RID: 7687
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
