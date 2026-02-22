using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000197 RID: 407
	[StructLayout(2)]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		// Token: 0x06002191 RID: 8593 RVA: 0x000A130C File Offset: 0x0009F50C
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeNewPlayerCompatibilityResult_t()
		{
			Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ComputeNewPlayerCompatibilityResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr);
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "k_iCallback");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "m_eResult");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_m_cPlayersThatDontLikeCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "m_cPlayersThatDontLikeCandidate");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_m_cPlayersThatCandidateDoesntLike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "m_cPlayersThatCandidateDoesntLike");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_m_cClanPlayersThatDontLikeCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "m_cClanPlayersThatDontLikeCandidate");
			ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_m_SteamIDCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, "m_SteamIDCandidate");
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ComputeNewPlayerCompatibilityResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x000A13B4 File Offset: 0x0009F5B4
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x0000C3EA File Offset: 0x0000A5EA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputeNewPlayerCompatibilityResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeFieldInfoPtr_m_cPlayersThatDontLikeCandidate;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeFieldInfoPtr_m_cPlayersThatCandidateDoesntLike;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeFieldInfoPtr_m_cClanPlayersThatDontLikeCandidate;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamIDCandidate;

		// Token: 0x04001B51 RID: 6993
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001B52 RID: 6994
		[FieldOffset(4)]
		public int m_cPlayersThatDontLikeCandidate;

		// Token: 0x04001B53 RID: 6995
		[FieldOffset(8)]
		public int m_cPlayersThatCandidateDoesntLike;

		// Token: 0x04001B54 RID: 6996
		[FieldOffset(12)]
		public int m_cClanPlayersThatDontLikeCandidate;

		// Token: 0x04001B55 RID: 6997
		[FieldOffset(16)]
		public CSteamID m_SteamIDCandidate;
	}
}
