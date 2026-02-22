using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000208 RID: 520
	[StructLayout(2)]
	public struct RemoteStorageFileWriteAsyncComplete_t
	{
		// Token: 0x06002480 RID: 9344 RVA: 0x000A6F5C File Offset: 0x000A515C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageFileWriteAsyncComplete_t()
		{
			Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageFileWriteAsyncComplete_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr);
			RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageFileWriteAsyncComplete_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x000A6FB4 File Offset: 0x000A51B4
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x0000E3C2 File Offset: 0x0000C5C2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageFileWriteAsyncComplete_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001DE5 RID: 7653
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
