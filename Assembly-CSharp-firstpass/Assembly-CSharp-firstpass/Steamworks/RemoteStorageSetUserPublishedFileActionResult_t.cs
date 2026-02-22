using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000204 RID: 516
	[StructLayout(2)]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		// Token: 0x06002463 RID: 9315 RVA: 0x000A6BC4 File Offset: 0x000A4DC4
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageSetUserPublishedFileActionResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageSetUserPublishedFileActionResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr);
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_m_eAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, "m_eAction");
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0000E27D File Offset: 0x0000C47D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageSetUserPublishedFileActionResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x000A6C44 File Offset: 0x000A4E44
		// (set) Token: 0x06002466 RID: 9318 RVA: 0x0000E28F File Offset: 0x0000C48F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageSetUserPublishedFileActionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeFieldInfoPtr_m_eAction;

		// Token: 0x04001DCD RID: 7629
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001DCE RID: 7630
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001DCF RID: 7631
		[FieldOffset(16)]
		public EWorkshopFileAction m_eAction;
	}
}
