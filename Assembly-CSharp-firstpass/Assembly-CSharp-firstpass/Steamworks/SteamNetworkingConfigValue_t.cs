using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002F0 RID: 752
	[Serializable]
	[StructLayout(2)]
	public struct SteamNetworkingConfigValue_t
	{
		// Token: 0x06002B69 RID: 11113 RVA: 0x000BA28C File Offset: 0x000B848C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingConfigValue_t()
		{
			Il2CppClassPointerStore<SteamNetworkingConfigValue_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingConfigValue_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingConfigValue_t>.NativeClassPtr);
			SteamNetworkingConfigValue_t.NativeFieldInfoPtr_m_eValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingConfigValue_t>.NativeClassPtr, "m_eValue");
			SteamNetworkingConfigValue_t.NativeFieldInfoPtr_m_eDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingConfigValue_t>.NativeClassPtr, "m_eDataType");
			SteamNetworkingConfigValue_t.NativeFieldInfoPtr_m_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingConfigValue_t>.NativeClassPtr, "m_val");
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x000111B9 File Offset: 0x0000F3B9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingConfigValue_t>.NativeClassPtr, ref this));
		}

		// Token: 0x040029B8 RID: 10680
		private static readonly IntPtr NativeFieldInfoPtr_m_eValue;

		// Token: 0x040029B9 RID: 10681
		private static readonly IntPtr NativeFieldInfoPtr_m_eDataType;

		// Token: 0x040029BA RID: 10682
		private static readonly IntPtr NativeFieldInfoPtr_m_val;

		// Token: 0x040029BB RID: 10683
		[FieldOffset(0)]
		public ESteamNetworkingConfigValue m_eValue;

		// Token: 0x040029BC RID: 10684
		[FieldOffset(4)]
		public ESteamNetworkingConfigDataType m_eDataType;

		// Token: 0x040029BD RID: 10685
		[FieldOffset(8)]
		public SteamNetworkingConfigValue_t.OptionValue m_val;

		// Token: 0x020003C8 RID: 968
		[StructLayout(2)]
		public struct OptionValue
		{
			// Token: 0x06003846 RID: 14406 RVA: 0x000E5288 File Offset: 0x000E3488
			// Note: this type is marked as 'beforefieldinit'.
			static OptionValue()
			{
				Il2CppClassPointerStore<SteamNetworkingConfigValue_t.OptionValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamNetworkingConfigValue_t>.NativeClassPtr, "OptionValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingConfigValue_t.OptionValue>.NativeClassPtr);
				SteamNetworkingConfigValue_t.OptionValue.NativeFieldInfoPtr_m_int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingConfigValue_t.OptionValue>.NativeClassPtr, "m_int32");
				SteamNetworkingConfigValue_t.OptionValue.NativeFieldInfoPtr_m_int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingConfigValue_t.OptionValue>.NativeClassPtr, "m_int64");
				SteamNetworkingConfigValue_t.OptionValue.NativeFieldInfoPtr_m_float = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingConfigValue_t.OptionValue>.NativeClassPtr, "m_float");
				SteamNetworkingConfigValue_t.OptionValue.NativeFieldInfoPtr_m_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingConfigValue_t.OptionValue>.NativeClassPtr, "m_string");
				SteamNetworkingConfigValue_t.OptionValue.NativeFieldInfoPtr_m_functionPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingConfigValue_t.OptionValue>.NativeClassPtr, "m_functionPtr");
			}

			// Token: 0x06003847 RID: 14407 RVA: 0x00015CF4 File Offset: 0x00013EF4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingConfigValue_t.OptionValue>.NativeClassPtr, ref this));
			}

			// Token: 0x040032C9 RID: 13001
			private static readonly IntPtr NativeFieldInfoPtr_m_int32;

			// Token: 0x040032CA RID: 13002
			private static readonly IntPtr NativeFieldInfoPtr_m_int64;

			// Token: 0x040032CB RID: 13003
			private static readonly IntPtr NativeFieldInfoPtr_m_float;

			// Token: 0x040032CC RID: 13004
			private static readonly IntPtr NativeFieldInfoPtr_m_string;

			// Token: 0x040032CD RID: 13005
			private static readonly IntPtr NativeFieldInfoPtr_m_functionPtr;

			// Token: 0x040032CE RID: 13006
			[FieldOffset(0)]
			public int m_int32;

			// Token: 0x040032CF RID: 13007
			[FieldOffset(0)]
			public long m_int64;

			// Token: 0x040032D0 RID: 13008
			[FieldOffset(0)]
			public float m_float;

			// Token: 0x040032D1 RID: 13009
			[FieldOffset(0)]
			public IntPtr m_string;

			// Token: 0x040032D2 RID: 13010
			[FieldOffset(0)]
			public IntPtr m_functionPtr;
		}
	}
}
