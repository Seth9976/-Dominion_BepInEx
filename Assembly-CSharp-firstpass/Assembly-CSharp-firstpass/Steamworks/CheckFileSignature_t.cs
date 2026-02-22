using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200023B RID: 571
	[StructLayout(2)]
	public struct CheckFileSignature_t
	{
		// Token: 0x0600258D RID: 9613 RVA: 0x000A9290 File Offset: 0x000A7490
		// Note: this type is marked as 'beforefieldinit'.
		static CheckFileSignature_t()
		{
			Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CheckFileSignature_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr);
			CheckFileSignature_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, "k_iCallback");
			CheckFileSignature_t.NativeFieldInfoPtr_m_eCheckFileSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, "m_eCheckFileSignature");
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x0000EE1F File Offset: 0x0000D01F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CheckFileSignature_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x000A92E8 File Offset: 0x000A74E8
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x0000EE31 File Offset: 0x0000D031
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CheckFileSignature_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckFileSignature_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeFieldInfoPtr_m_eCheckFileSignature;

		// Token: 0x04001F0C RID: 7948
		[FieldOffset(0)]
		public ECheckFileSignature m_eCheckFileSignature;
	}
}
