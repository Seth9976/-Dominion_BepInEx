using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001D0 RID: 464
	[StructLayout(2)]
	public struct ChangeNumOpenSlotsCallback_t
	{
		// Token: 0x060022EC RID: 8940 RVA: 0x000A4038 File Offset: 0x000A2238
		// Note: this type is marked as 'beforefieldinit'.
		static ChangeNumOpenSlotsCallback_t()
		{
			Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ChangeNumOpenSlotsCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr);
			ChangeNumOpenSlotsCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr, "k_iCallback");
			ChangeNumOpenSlotsCallback_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x0000D152 File Offset: 0x0000B352
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeNumOpenSlotsCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x000A4090 File Offset: 0x000A2290
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x0000D164 File Offset: 0x0000B364
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ChangeNumOpenSlotsCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChangeNumOpenSlotsCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001CD4 RID: 7380
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
