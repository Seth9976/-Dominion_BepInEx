using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200021C RID: 540
	[StructLayout(2)]
	public struct DeleteItemResult_t
	{
		// Token: 0x060024EF RID: 9455 RVA: 0x000A7DC4 File Offset: 0x000A5FC4
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteItemResult_t()
		{
			Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DeleteItemResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr);
			DeleteItemResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, "k_iCallback");
			DeleteItemResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, "m_eResult");
			DeleteItemResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x0000E7FE File Offset: 0x0000C9FE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeleteItemResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x000A7E30 File Offset: 0x000A6030
		// (set) Token: 0x060024F2 RID: 9458 RVA: 0x0000E810 File Offset: 0x0000CA10
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeleteItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeleteItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E5F RID: 7775
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001E60 RID: 7776
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
