using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000196 RID: 406
	[StructLayout(2)]
	public struct AssociateWithClanResult_t
	{
		// Token: 0x0600218D RID: 8589 RVA: 0x000A1298 File Offset: 0x0009F498
		// Note: this type is marked as 'beforefieldinit'.
		static AssociateWithClanResult_t()
		{
			Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AssociateWithClanResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr);
			AssociateWithClanResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, "k_iCallback");
			AssociateWithClanResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssociateWithClanResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x000A12F0 File Offset: 0x0009F4F0
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x0000C3CA File Offset: 0x0000A5CA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssociateWithClanResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssociateWithClanResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001B4A RID: 6986
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
