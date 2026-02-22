using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001E0 RID: 480
	[StructLayout(2)]
	public struct MusicPlayerSelectsQueueEntry_t
	{
		// Token: 0x0600232C RID: 9004 RVA: 0x000A43B0 File Offset: 0x000A25B0
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerSelectsQueueEntry_t()
		{
			Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MusicPlayerSelectsQueueEntry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr);
			MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, "k_iCallback");
			MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr_nID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, "nID");
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0000D5C5 File Offset: 0x0000B7C5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicPlayerSelectsQueueEntry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x000A4408 File Offset: 0x000A2608
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x0000D5D7 File Offset: 0x0000B7D7
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayerSelectsQueueEntry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeFieldInfoPtr_nID;

		// Token: 0x04001CEE RID: 7406
		[FieldOffset(0)]
		public int nID;
	}
}
