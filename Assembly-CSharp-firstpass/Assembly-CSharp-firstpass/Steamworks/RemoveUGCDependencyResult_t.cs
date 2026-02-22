using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000218 RID: 536
	[StructLayout(2)]
	public struct RemoveUGCDependencyResult_t
	{
		// Token: 0x060024D4 RID: 9428 RVA: 0x000A7A5C File Offset: 0x000A5C5C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveUGCDependencyResult_t()
		{
			Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoveUGCDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr);
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "k_iCallback");
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "m_eResult");
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoveUGCDependencyResult_t.NativeFieldInfoPtr_m_nChildPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, "m_nChildPublishedFileId");
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x0000E6EA File Offset: 0x0000C8EA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveUGCDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000A7ADC File Offset: 0x000A5CDC
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoveUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoveUGCDependencyResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeFieldInfoPtr_m_nChildPublishedFileId;

		// Token: 0x04001E45 RID: 7749
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001E46 RID: 7750
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001E47 RID: 7751
		[FieldOffset(16)]
		public PublishedFileId_t m_nChildPublishedFileId;
	}
}
