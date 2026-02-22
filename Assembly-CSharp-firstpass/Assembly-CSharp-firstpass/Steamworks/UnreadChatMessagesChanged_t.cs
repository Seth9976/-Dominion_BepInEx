using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200018A RID: 394
	[StructLayout(2)]
	public struct UnreadChatMessagesChanged_t
	{
		// Token: 0x06002146 RID: 8518 RVA: 0x0000C0E2 File Offset: 0x0000A2E2
		// Note: this type is marked as 'beforefieldinit'.
		static UnreadChatMessagesChanged_t()
		{
			Il2CppClassPointerStore<UnreadChatMessagesChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UnreadChatMessagesChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnreadChatMessagesChanged_t>.NativeClassPtr);
			UnreadChatMessagesChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnreadChatMessagesChanged_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0000C11B File Offset: 0x0000A31B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnreadChatMessagesChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x000A093C File Offset: 0x0009EB3C
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x0000C12D File Offset: 0x0000A32D
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UnreadChatMessagesChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnreadChatMessagesChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
