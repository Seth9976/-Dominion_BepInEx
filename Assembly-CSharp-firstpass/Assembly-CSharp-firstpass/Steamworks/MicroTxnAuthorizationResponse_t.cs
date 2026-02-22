using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000224 RID: 548
	[StructLayout(2)]
	public struct MicroTxnAuthorizationResponse_t
	{
		// Token: 0x0600250F RID: 9487 RVA: 0x000A8154 File Offset: 0x000A6354
		// Note: this type is marked as 'beforefieldinit'.
		static MicroTxnAuthorizationResponse_t()
		{
			Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MicroTxnAuthorizationResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr);
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "k_iCallback");
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_m_unAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "m_unAppID");
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_m_ulOrderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "m_ulOrderID");
			MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_m_bAuthorized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, "m_bAuthorized");
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0000E970 File Offset: 0x0000CB70
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MicroTxnAuthorizationResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x000A81D4 File Offset: 0x000A63D4
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x0000E982 File Offset: 0x0000CB82
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MicroTxnAuthorizationResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeFieldInfoPtr_m_unAppID;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeFieldInfoPtr_m_ulOrderID;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeFieldInfoPtr_m_bAuthorized;

		// Token: 0x04001E84 RID: 7812
		[FieldOffset(0)]
		public uint m_unAppID;

		// Token: 0x04001E85 RID: 7813
		[FieldOffset(8)]
		public ulong m_ulOrderID;

		// Token: 0x04001E86 RID: 7814
		[FieldOffset(16)]
		public byte m_bAuthorized;
	}
}
