using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002B3 RID: 691
	[StructLayout(2)]
	public struct CallbackMsg_t
	{
		// Token: 0x06002799 RID: 10137 RVA: 0x000ACD88 File Offset: 0x000AAF88
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackMsg_t()
		{
			Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CallbackMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr);
			CallbackMsg_t.NativeFieldInfoPtr_m_hSteamUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_hSteamUser");
			CallbackMsg_t.NativeFieldInfoPtr_m_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_iCallback");
			CallbackMsg_t.NativeFieldInfoPtr_m_pubParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_pubParam");
			CallbackMsg_t.NativeFieldInfoPtr_m_cubParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, "m_cubParam");
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x0000FE6C File Offset: 0x0000E06C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x040026D5 RID: 9941
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamUser;

		// Token: 0x040026D6 RID: 9942
		private static readonly IntPtr NativeFieldInfoPtr_m_iCallback;

		// Token: 0x040026D7 RID: 9943
		private static readonly IntPtr NativeFieldInfoPtr_m_pubParam;

		// Token: 0x040026D8 RID: 9944
		private static readonly IntPtr NativeFieldInfoPtr_m_cubParam;

		// Token: 0x040026D9 RID: 9945
		[FieldOffset(0)]
		public int m_hSteamUser;

		// Token: 0x040026DA RID: 9946
		[FieldOffset(4)]
		public int m_iCallback;

		// Token: 0x040026DB RID: 9947
		[FieldOffset(8)]
		public IntPtr m_pubParam;

		// Token: 0x040026DC RID: 9948
		[FieldOffset(16)]
		public int m_cubParam;
	}
}
