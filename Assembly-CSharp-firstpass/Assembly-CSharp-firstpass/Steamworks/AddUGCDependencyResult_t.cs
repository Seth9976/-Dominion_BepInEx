using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000217 RID: 535
	[StructLayout(2)]
	public struct AddUGCDependencyResult_t
	{
		// Token: 0x060024D0 RID: 9424 RVA: 0x000A79C0 File Offset: 0x000A5BC0
		// Note: this type is marked as 'beforefieldinit'.
		static AddUGCDependencyResult_t()
		{
			Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AddUGCDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr);
			AddUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "k_iCallback");
			AddUGCDependencyResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "m_eResult");
			AddUGCDependencyResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "m_nPublishedFileId");
			AddUGCDependencyResult_t.NativeFieldInfoPtr_m_nChildPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, "m_nChildPublishedFileId");
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0000E6CA File Offset: 0x0000C8CA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddUGCDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000A7A40 File Offset: 0x000A5C40
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0000E6DC File Offset: 0x0000C8DC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AddUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeFieldInfoPtr_m_nChildPublishedFileId;

		// Token: 0x04001E3E RID: 7742
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001E3F RID: 7743
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001E40 RID: 7744
		[FieldOffset(16)]
		public PublishedFileId_t m_nChildPublishedFileId;
	}
}
