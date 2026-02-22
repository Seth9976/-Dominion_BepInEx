using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace SA.Common.Util
{
	// Token: 0x02000314 RID: 788
	public static class Screen : global::Il2CppSystem.Object
	{
		// Token: 0x06002D63 RID: 11619 RVA: 0x00011993 File Offset: 0x0000FB93
		// Note: this type is marked as 'beforefieldinit'.
		static Screen()
		{
			Il2CppClassPointerStore<Screen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Util", "Screen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Screen>.NativeClassPtr);
			Screen.NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100669224);
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x000C197C File Offset: 0x000BFB7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212456, RefRangeEnd = 212458, XrefRangeStart = 212437, XrefRangeEnd = 212456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TakeScreenshot(Action<Texture2D> callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Action_1_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x000119CC File Offset: 0x0000FBCC
		public Screen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B58 RID: 11096
		private static readonly IntPtr NativeMethodInfoPtr_TakeScreenshot_Public_Static_Void_Action_1_Texture2D_0;
	}
}
