using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001D4 RID: 468
	[StructLayout(2)]
	public struct VolumeHasChanged_t
	{
		// Token: 0x060022FC RID: 8956 RVA: 0x000A4100 File Offset: 0x000A2300
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeHasChanged_t()
		{
			Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "VolumeHasChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr);
			VolumeHasChanged_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, "k_iCallback");
			VolumeHasChanged_t.NativeFieldInfoPtr_m_flNewVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, "m_flNewVolume");
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0000D27D File Offset: 0x0000B47D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumeHasChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x000A4158 File Offset: 0x000A2358
		// (set) Token: 0x060022FF RID: 8959 RVA: 0x0000D28F File Offset: 0x0000B48F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(VolumeHasChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumeHasChanged_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeFieldInfoPtr_m_flNewVolume;

		// Token: 0x04001CDA RID: 7386
		[FieldOffset(0)]
		public float m_flNewVolume;
	}
}
