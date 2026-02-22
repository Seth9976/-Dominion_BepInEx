using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000193 RID: 403
	[StructLayout(2)]
	public struct GSGameplayStats_t
	{
		// Token: 0x06002181 RID: 8577 RVA: 0x000A104C File Offset: 0x0009F24C
		// Note: this type is marked as 'beforefieldinit'.
		static GSGameplayStats_t()
		{
			Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSGameplayStats_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr);
			GSGameplayStats_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "k_iCallback");
			GSGameplayStats_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "m_eResult");
			GSGameplayStats_t.NativeFieldInfoPtr_m_nRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "m_nRank");
			GSGameplayStats_t.NativeFieldInfoPtr_m_unTotalConnects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "m_unTotalConnects");
			GSGameplayStats_t.NativeFieldInfoPtr_m_unTotalMinutesPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, "m_unTotalMinutesPlayed");
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x0000C358 File Offset: 0x0000A558
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSGameplayStats_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x000A10E0 File Offset: 0x0009F2E0
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x0000C36A File Offset: 0x0000A56A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSGameplayStats_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSGameplayStats_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeFieldInfoPtr_m_nRank;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeFieldInfoPtr_m_unTotalConnects;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeFieldInfoPtr_m_unTotalMinutesPlayed;

		// Token: 0x04001B2C RID: 6956
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001B2D RID: 6957
		[FieldOffset(4)]
		public int m_nRank;

		// Token: 0x04001B2E RID: 6958
		[FieldOffset(8)]
		public uint m_unTotalConnects;

		// Token: 0x04001B2F RID: 6959
		[FieldOffset(12)]
		public uint m_unTotalMinutesPlayed;
	}
}
