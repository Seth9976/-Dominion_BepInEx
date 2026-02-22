using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001B2 RID: 434
	[StructLayout(2)]
	public struct HTTPRequestCompleted_t
	{
		// Token: 0x06002262 RID: 8802 RVA: 0x000A2B28 File Offset: 0x000A0D28
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestCompleted_t()
		{
			Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTTPRequestCompleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr);
			HTTPRequestCompleted_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "k_iCallback");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_m_hRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "m_hRequest");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_m_ulContextValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "m_ulContextValue");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_m_bRequestSuccessful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "m_bRequestSuccessful");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_m_eStatusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "m_eStatusCode");
			HTTPRequestCompleted_t.NativeFieldInfoPtr_m_unBodySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, "m_unBodySize");
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0000CC9D File Offset: 0x0000AE9D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestCompleted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x000A2BD0 File Offset: 0x000A0DD0
		// (set) Token: 0x06002265 RID: 8805 RVA: 0x0000CCAF File Offset: 0x0000AEAF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestCompleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeFieldInfoPtr_m_hRequest;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeFieldInfoPtr_m_ulContextValue;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeFieldInfoPtr_m_bRequestSuccessful;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeFieldInfoPtr_m_eStatusCode;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeFieldInfoPtr_m_unBodySize;

		// Token: 0x04001BF6 RID: 7158
		[FieldOffset(0)]
		public HTTPRequestHandle m_hRequest;

		// Token: 0x04001BF7 RID: 7159
		[FieldOffset(8)]
		public ulong m_ulContextValue;

		// Token: 0x04001BF8 RID: 7160
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bRequestSuccessful;

		// Token: 0x04001BF9 RID: 7161
		[FieldOffset(20)]
		public EHTTPStatusCode m_eStatusCode;

		// Token: 0x04001BFA RID: 7162
		[FieldOffset(24)]
		public uint m_unBodySize;
	}
}
