using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001B3 RID: 435
	[StructLayout(2)]
	public struct HTTPRequestHeadersReceived_t
	{
		// Token: 0x06002266 RID: 8806 RVA: 0x000A2BEC File Offset: 0x000A0DEC
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestHeadersReceived_t()
		{
			Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTTPRequestHeadersReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr);
			HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, "k_iCallback");
			HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_m_hRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, "m_hRequest");
			HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_m_ulContextValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, "m_ulContextValue");
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x0000CCBD File Offset: 0x0000AEBD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestHeadersReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x000A2C58 File Offset: 0x000A0E58
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x0000CCCF File Offset: 0x0000AECF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestHeadersReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeFieldInfoPtr_m_hRequest;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeFieldInfoPtr_m_ulContextValue;

		// Token: 0x04001BFE RID: 7166
		[FieldOffset(0)]
		public HTTPRequestHandle m_hRequest;

		// Token: 0x04001BFF RID: 7167
		[FieldOffset(8)]
		public ulong m_ulContextValue;
	}
}
