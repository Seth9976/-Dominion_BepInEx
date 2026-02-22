using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200018C RID: 396
	[StructLayout(2)]
	public struct GCMessageAvailable_t
	{
		// Token: 0x06002153 RID: 8531 RVA: 0x000A0AA8 File Offset: 0x0009ECA8
		// Note: this type is marked as 'beforefieldinit'.
		static GCMessageAvailable_t()
		{
			Il2CppClassPointerStore<GCMessageAvailable_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GCMessageAvailable_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GCMessageAvailable_t>.NativeClassPtr);
			GCMessageAvailable_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCMessageAvailable_t>.NativeClassPtr, "k_iCallback");
			GCMessageAvailable_t.NativeFieldInfoPtr_m_nMessageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCMessageAvailable_t>.NativeClassPtr, "m_nMessageSize");
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0000C183 File Offset: 0x0000A383
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GCMessageAvailable_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x000A0B00 File Offset: 0x0009ED00
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x0000C195 File Offset: 0x0000A395
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GCMessageAvailable_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GCMessageAvailable_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeFieldInfoPtr_m_nMessageSize;

		// Token: 0x04001B0C RID: 6924
		[FieldOffset(0)]
		public uint m_nMessageSize;
	}
}
