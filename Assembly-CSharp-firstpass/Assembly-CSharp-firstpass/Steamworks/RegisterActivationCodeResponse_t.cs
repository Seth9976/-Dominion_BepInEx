using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000173 RID: 371
	[StructLayout(2)]
	public struct RegisterActivationCodeResponse_t
	{
		// Token: 0x060020BD RID: 8381 RVA: 0x0009F6E4 File Offset: 0x0009D8E4
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterActivationCodeResponse_t()
		{
			Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RegisterActivationCodeResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr);
			RegisterActivationCodeResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, "k_iCallback");
			RegisterActivationCodeResponse_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, "m_eResult");
			RegisterActivationCodeResponse_t.NativeFieldInfoPtr_m_unPackageRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, "m_unPackageRegistered");
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterActivationCodeResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x0009F750 File Offset: 0x0009D950
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x0000BBE6 File Offset: 0x00009DE6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegisterActivationCodeResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegisterActivationCodeResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeFieldInfoPtr_m_unPackageRegistered;

		// Token: 0x04001A83 RID: 6787
		[FieldOffset(0)]
		public ERegisterActivationCodeResult m_eResult;

		// Token: 0x04001A84 RID: 6788
		[FieldOffset(4)]
		public uint m_unPackageRegistered;
	}
}
