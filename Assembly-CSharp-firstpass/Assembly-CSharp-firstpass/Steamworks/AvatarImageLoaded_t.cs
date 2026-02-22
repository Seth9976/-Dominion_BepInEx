using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200017C RID: 380
	[StructLayout(2)]
	public struct AvatarImageLoaded_t
	{
		// Token: 0x060020FE RID: 8446 RVA: 0x0009FF58 File Offset: 0x0009E158
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarImageLoaded_t()
		{
			Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AvatarImageLoaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr);
			AvatarImageLoaded_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "k_iCallback");
			AvatarImageLoaded_t.NativeFieldInfoPtr_m_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "m_steamID");
			AvatarImageLoaded_t.NativeFieldInfoPtr_m_iImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "m_iImage");
			AvatarImageLoaded_t.NativeFieldInfoPtr_m_iWide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "m_iWide");
			AvatarImageLoaded_t.NativeFieldInfoPtr_m_iTall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, "m_iTall");
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x0000BE66 File Offset: 0x0000A066
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AvatarImageLoaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x0009FFEC File Offset: 0x0009E1EC
		// (set) Token: 0x06002101 RID: 8449 RVA: 0x0000BE78 File Offset: 0x0000A078
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AvatarImageLoaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarImageLoaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeFieldInfoPtr_m_steamID;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeFieldInfoPtr_m_iImage;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeFieldInfoPtr_m_iWide;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeFieldInfoPtr_m_iTall;

		// Token: 0x04001AB4 RID: 6836
		[FieldOffset(0)]
		public CSteamID m_steamID;

		// Token: 0x04001AB5 RID: 6837
		[FieldOffset(8)]
		public int m_iImage;

		// Token: 0x04001AB6 RID: 6838
		[FieldOffset(12)]
		public int m_iWide;

		// Token: 0x04001AB7 RID: 6839
		[FieldOffset(16)]
		public int m_iTall;
	}
}
