using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002AF RID: 687
	[StructLayout(2)]
	public struct SteamParamStringArray_t
	{
		// Token: 0x06002748 RID: 10056 RVA: 0x000AC048 File Offset: 0x000AA248
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParamStringArray_t()
		{
			Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamParamStringArray_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr);
			SteamParamStringArray_t.NativeFieldInfoPtr_m_ppStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr, "m_ppStrings");
			SteamParamStringArray_t.NativeFieldInfoPtr_m_nNumStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr, "m_nNumStrings");
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0000FB02 File Offset: 0x0000DD02
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400269C RID: 9884
		private static readonly IntPtr NativeFieldInfoPtr_m_ppStrings;

		// Token: 0x0400269D RID: 9885
		private static readonly IntPtr NativeFieldInfoPtr_m_nNumStrings;

		// Token: 0x0400269E RID: 9886
		[FieldOffset(0)]
		public IntPtr m_ppStrings;

		// Token: 0x0400269F RID: 9887
		[FieldOffset(8)]
		public int m_nNumStrings;
	}
}
