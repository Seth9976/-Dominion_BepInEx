using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200018D RID: 397
	[StructLayout(2)]
	public struct GCMessageFailed_t
	{
		// Token: 0x06002157 RID: 8535 RVA: 0x0000C1A3 File Offset: 0x0000A3A3
		// Note: this type is marked as 'beforefieldinit'.
		static GCMessageFailed_t()
		{
			Il2CppClassPointerStore<GCMessageFailed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GCMessageFailed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GCMessageFailed_t>.NativeClassPtr);
			GCMessageFailed_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCMessageFailed_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x0000C1DC File Offset: 0x0000A3DC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GCMessageFailed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x000A0B1C File Offset: 0x0009ED1C
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x0000C1EE File Offset: 0x0000A3EE
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GCMessageFailed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GCMessageFailed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
