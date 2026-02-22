using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001E2 RID: 482
	[StructLayout(2)]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		// Token: 0x06002334 RID: 9012 RVA: 0x000A4498 File Offset: 0x000A2698
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerWantsPlayingRepeatStatus_t()
		{
			Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerWantsPlayingRepeatStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr);
			MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr_m_nPlayingRepeatStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, "m_nPlayingRepeatStatus");
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x0000D605 File Offset: 0x0000B805
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerWantsPlayingRepeatStatus_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000A44F0 File Offset: 0x000A26F0
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x0000D617 File Offset: 0x0000B817
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerWantsPlayingRepeatStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeFieldInfoPtr_m_nPlayingRepeatStatus;

		// Token: 0x04001CF4 RID: 7412
		[FieldOffset(0)]
		public int m_nPlayingRepeatStatus;
	}
}
