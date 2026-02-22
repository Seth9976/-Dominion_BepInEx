using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002D8 RID: 728
	[Serializable]
	public sealed class SteamDatagramHostedAddress : ValueType
	{
		// Token: 0x06002A3E RID: 10814 RVA: 0x000B5748 File Offset: 0x000B3948
		// Note: this type is marked as 'beforefieldinit'.
		static SteamDatagramHostedAddress()
		{
			Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamDatagramHostedAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr);
			SteamDatagramHostedAddress.NativeFieldInfoPtr_m_cbSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, "m_cbSize");
			SteamDatagramHostedAddress.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, "m_data");
			SteamDatagramHostedAddress.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, 100668706);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000B57B4 File Offset: 0x000B39B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210759, XrefRangeEnd = 210762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamDatagramHostedAddress.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00010DB9 File Offset: 0x0000EFB9
		public SteamDatagramHostedAddress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00010DC2 File Offset: 0x0000EFC2
		public SteamDatagramHostedAddress()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr))
		{
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x000B57EC File Offset: 0x000B39EC
		// (set) Token: 0x06002A43 RID: 10819 RVA: 0x00010DD4 File Offset: 0x0000EFD4
		public unsafe int m_cbSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramHostedAddress.NativeFieldInfoPtr_m_cbSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramHostedAddress.NativeFieldInfoPtr_m_cbSize)) = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000B5814 File Offset: 0x000B3A14
		// (set) Token: 0x06002A45 RID: 10821 RVA: 0x00010DEF File Offset: 0x0000EFEF
		public unsafe Il2CppStructArray<byte> m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramHostedAddress.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramHostedAddress.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028B4 RID: 10420
		private static readonly IntPtr NativeFieldInfoPtr_m_cbSize;

		// Token: 0x040028B5 RID: 10421
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x040028B6 RID: 10422
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
	}
}
