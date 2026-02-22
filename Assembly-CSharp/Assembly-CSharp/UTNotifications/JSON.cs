using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UTNotifications
{
	// Token: 0x020000F9 RID: 249
	public static class JSON : Object
	{
		// Token: 0x06001E0C RID: 7692 RVA: 0x00012BED File Offset: 0x00010DED
		// Note: this type is marked as 'beforefieldinit'.
		static JSON()
		{
			Il2CppClassPointerStore<JSON>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "JSON");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSON>.NativeClassPtr);
			JSON.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100665781);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00076378 File Offset: 0x00074578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255526, XrefRangeEnd = 255527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode Parse(string aJSON)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aJSON);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00012C26 File Offset: 0x00010E26
		public JSON(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0;
	}
}
