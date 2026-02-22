using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E5 RID: 229
	public class NetRes : Object
	{
		// Token: 0x06000D35 RID: 3381 RVA: 0x000423A4 File Offset: 0x000405A4
		// Note: this type is marked as 'beforefieldinit'.
		static NetRes()
		{
			Il2CppClassPointerStore<NetRes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NetRes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetRes>.NativeClassPtr);
			NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRes>.NativeClassPtr, 100665156);
			NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRes>.NativeClassPtr, 100665157);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000423FC File Offset: 0x000405FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47664, RefRangeEnd = 47666, XrefRangeStart = 47653, XrefRangeEnd = 47664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebStatusString(string Res, WebExceptionStatus Status)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00042448 File Offset: 0x00040648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47671, RefRangeEnd = 47672, XrefRangeStart = 47666, XrefRangeEnd = 47671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebStatusString(WebExceptionStatus Status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0000725F File Offset: 0x0000545F
		public NetRes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0;
	}
}
