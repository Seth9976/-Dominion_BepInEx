using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000040 RID: 64
	public class UDP : Object
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00002FB4 File Offset: 0x000011B4
		// Note: this type is marked as 'beforefieldinit'.
		static UDP()
		{
			Il2CppClassPointerStore<UDP>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "UDP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UDP>.NativeClassPtr);
			UDP.NativeMethodInfoPtr_get_Name_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDP>.NativeClassPtr, 100663544);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000C654 File Offset: 0x0000A854
		public unsafe static string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152360, XrefRangeEnd = 152384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDP.NativeMethodInfoPtr_get_Name_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002FED File Offset: 0x000011ED
		public UDP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Static_get_String_0;
	}
}
