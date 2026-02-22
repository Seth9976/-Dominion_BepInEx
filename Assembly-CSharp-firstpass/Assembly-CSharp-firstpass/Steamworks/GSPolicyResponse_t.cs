using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000192 RID: 402
	[StructLayout(2)]
	public struct GSPolicyResponse_t
	{
		// Token: 0x0600217D RID: 8573 RVA: 0x000A0FD8 File Offset: 0x0009F1D8
		// Note: this type is marked as 'beforefieldinit'.
		static GSPolicyResponse_t()
		{
			Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSPolicyResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr);
			GSPolicyResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, "k_iCallback");
			GSPolicyResponse_t.NativeFieldInfoPtr_m_bSecure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, "m_bSecure");
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x0000C338 File Offset: 0x0000A538
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSPolicyResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x000A1030 File Offset: 0x0009F230
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x0000C34A File Offset: 0x0000A54A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSPolicyResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSPolicyResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeFieldInfoPtr_m_bSecure;

		// Token: 0x04001B26 RID: 6950
		[FieldOffset(0)]
		public byte m_bSecure;
	}
}
