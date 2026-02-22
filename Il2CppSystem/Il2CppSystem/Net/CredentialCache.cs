using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000BD RID: 189
	public class CredentialCache : Object
	{
		// Token: 0x06000B67 RID: 2919 RVA: 0x00006755 File Offset: 0x00004955
		// Note: this type is marked as 'beforefieldinit'.
		static CredentialCache()
		{
			Il2CppClassPointerStore<CredentialCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CredentialCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CredentialCache>.NativeClassPtr);
			CredentialCache.NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialCache>.NativeClassPtr, 100664927);
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0003BA5C File Offset: 0x00039C5C
		public unsafe static ICredentials DefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45831, XrefRangeEnd = 45835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CredentialCache.NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0000678E File Offset: 0x0000498E
		public CredentialCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0;
	}
}
