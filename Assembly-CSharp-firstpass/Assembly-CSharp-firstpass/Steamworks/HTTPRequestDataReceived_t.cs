using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001B4 RID: 436
	[StructLayout(2)]
	public struct HTTPRequestDataReceived_t
	{
		// Token: 0x0600226A RID: 8810 RVA: 0x000A2C74 File Offset: 0x000A0E74
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestDataReceived_t()
		{
			Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTTPRequestDataReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr);
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "k_iCallback");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_m_hRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "m_hRequest");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_m_ulContextValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "m_ulContextValue");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_m_cOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "m_cOffset");
			HTTPRequestDataReceived_t.NativeFieldInfoPtr_m_cBytesReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, "m_cBytesReceived");
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x0000CCDD File Offset: 0x0000AEDD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestDataReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x000A2D08 File Offset: 0x000A0F08
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x0000CCEF File Offset: 0x0000AEEF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestDataReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestDataReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeFieldInfoPtr_m_hRequest;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeFieldInfoPtr_m_ulContextValue;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeFieldInfoPtr_m_cOffset;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeFieldInfoPtr_m_cBytesReceived;

		// Token: 0x04001C05 RID: 7173
		[FieldOffset(0)]
		public HTTPRequestHandle m_hRequest;

		// Token: 0x04001C06 RID: 7174
		[FieldOffset(8)]
		public ulong m_ulContextValue;

		// Token: 0x04001C07 RID: 7175
		[FieldOffset(16)]
		public uint m_cOffset;

		// Token: 0x04001C08 RID: 7176
		[FieldOffset(20)]
		public uint m_cBytesReceived;
	}
}
