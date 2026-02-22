using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200021A RID: 538
	[StructLayout(2)]
	public struct RemoveAppDependencyResult_t
	{
		// Token: 0x060024DC RID: 9436 RVA: 0x000A7B94 File Offset: 0x000A5D94
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveAppDependencyResult_t()
		{
			Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoveAppDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr);
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "k_iCallback");
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "m_eResult");
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x0000E72A File Offset: 0x0000C92A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x000A7C14 File Offset: 0x000A5E14
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x0000E73C File Offset: 0x0000C93C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoveAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoveAppDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001E53 RID: 7763
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001E54 RID: 7764
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001E55 RID: 7765
		[FieldOffset(16)]
		public AppId_t m_nAppID;
	}
}
