using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000219 RID: 537
	[StructLayout(2)]
	public struct AddAppDependencyResult_t
	{
		// Token: 0x060024D8 RID: 9432 RVA: 0x000A7AF8 File Offset: 0x000A5CF8
		// Note: this type is marked as 'beforefieldinit'.
		static AddAppDependencyResult_t()
		{
			Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AddAppDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr);
			AddAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "k_iCallback");
			AddAppDependencyResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "m_eResult");
			AddAppDependencyResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "m_nPublishedFileId");
			AddAppDependencyResult_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x0000E70A File Offset: 0x0000C90A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddAppDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x000A7B78 File Offset: 0x000A5D78
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x0000E71C File Offset: 0x0000C91C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AddAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001E4C RID: 7756
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001E4D RID: 7757
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001E4E RID: 7758
		[FieldOffset(16)]
		public AppId_t m_nAppID;
	}
}
