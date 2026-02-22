using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000221 RID: 545
	[StructLayout(2)]
	public struct IPCFailure_t
	{
		// Token: 0x06002503 RID: 9475 RVA: 0x000A8028 File Offset: 0x000A6228
		// Note: this type is marked as 'beforefieldinit'.
		static IPCFailure_t()
		{
			Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "IPCFailure_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr);
			IPCFailure_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, "k_iCallback");
			IPCFailure_t.NativeFieldInfoPtr_m_eFailureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, "m_eFailureType");
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x0000E8D7 File Offset: 0x0000CAD7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IPCFailure_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x000A8080 File Offset: 0x000A6280
		// (set) Token: 0x06002506 RID: 9478 RVA: 0x0000E8E9 File Offset: 0x0000CAE9
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPCFailure_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPCFailure_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeFieldInfoPtr_m_eFailureType;

		// Token: 0x04001E77 RID: 7799
		[FieldOffset(0)]
		public byte m_eFailureType;
	}
}
