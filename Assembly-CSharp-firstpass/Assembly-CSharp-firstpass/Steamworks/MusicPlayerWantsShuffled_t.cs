using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001DD RID: 477
	[StructLayout(2)]
	public struct MusicPlayerWantsShuffled_t
	{
		// Token: 0x06002320 RID: 8992 RVA: 0x000A4254 File Offset: 0x000A2454
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsShuffled_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsShuffled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr);
			MusicPlayerWantsShuffled_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerWantsShuffled_t.NativeFieldInfoPtr_m_bShuffled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, "m_bShuffled");
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x0000D565 File Offset: 0x0000B765
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsShuffled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x000A42AC File Offset: 0x000A24AC
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x0000D577 File Offset: 0x0000B777
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsShuffled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsShuffled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeFieldInfoPtr_m_bShuffled;

		// Token: 0x04001CE5 RID: 7397
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bShuffled;
	}
}
