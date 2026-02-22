using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000BE RID: 190
	public class SystemNetworkCredential : NetworkCredential
	{
		// Token: 0x06000B6A RID: 2922 RVA: 0x0003BA90 File Offset: 0x00039C90
		// Note: this type is marked as 'beforefieldinit'.
		static SystemNetworkCredential()
		{
			Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "SystemNetworkCredential");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr);
			SystemNetworkCredential.NativeFieldInfoPtr_defaultCredential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr, "defaultCredential");
			SystemNetworkCredential.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr, 100664928);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0003BAE8 File Offset: 0x00039CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45835, XrefRangeEnd = 45838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemNetworkCredential()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemNetworkCredential.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00006797 File Offset: 0x00004997
		public SystemNetworkCredential(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0003BB24 File Offset: 0x00039D24
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x000067A0 File Offset: 0x000049A0
		public unsafe static SystemNetworkCredential defaultCredential
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemNetworkCredential.NativeFieldInfoPtr_defaultCredential, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemNetworkCredential>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemNetworkCredential.NativeFieldInfoPtr_defaultCredential, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_defaultCredential;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
	}
}
