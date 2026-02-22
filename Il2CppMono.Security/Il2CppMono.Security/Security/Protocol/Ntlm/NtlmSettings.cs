using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000014 RID: 20
	public static class NtlmSettings : Object
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00007ED0 File Offset: 0x000060D0
		// Note: this type is marked as 'beforefieldinit'.
		static NtlmSettings()
		{
			Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "NtlmSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr);
			NtlmSettings.NativeFieldInfoPtr_defaultAuthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr, "defaultAuthLevel");
			NtlmSettings.NativeMethodInfoPtr_get_DefaultAuthLevel_Public_Static_get_NtlmAuthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr, 100663467);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00007F28 File Offset: 0x00006128
		public unsafe static NtlmAuthLevel DefaultAuthLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8829, XrefRangeEnd = 8833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmSettings.NativeMethodInfoPtr_get_DefaultAuthLevel_Public_Static_get_NtlmAuthLevel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002849 File Offset: 0x00000A49
		public NtlmSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00007F58 File Offset: 0x00006158
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002852 File Offset: 0x00000A52
		public unsafe static NtlmAuthLevel defaultAuthLevel
		{
			get
			{
				NtlmAuthLevel ntlmAuthLevel;
				IL2CPP.il2cpp_field_static_get_value(NtlmSettings.NativeFieldInfoPtr_defaultAuthLevel, (void*)(&ntlmAuthLevel));
				return ntlmAuthLevel;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NtlmSettings.NativeFieldInfoPtr_defaultAuthLevel, (void*)(&value));
			}
		}

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_defaultAuthLevel;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAuthLevel_Public_Static_get_NtlmAuthLevel_0;
	}
}
