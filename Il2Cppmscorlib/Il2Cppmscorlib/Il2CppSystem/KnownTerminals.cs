using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200011E RID: 286
	public static class KnownTerminals : Object
	{
		// Token: 0x06001480 RID: 5248 RVA: 0x0007FB84 File Offset: 0x0007DD84
		// Note: this type is marked as 'beforefieldinit'.
		static KnownTerminals()
		{
			Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "KnownTerminals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr);
			KnownTerminals.NativeMethodInfoPtr_get_linux_Public_Static_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr, 100666804);
			KnownTerminals.NativeMethodInfoPtr_get_xterm_Public_Static_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr, 100666805);
			KnownTerminals.NativeMethodInfoPtr_get_ansi_Public_Static_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr, 100666806);
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0007FBF0 File Offset: 0x0007DDF0
		public unsafe static Il2CppStructArray<byte> linux
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 305872, RefRangeEnd = 305873, XrefRangeStart = 305866, XrefRangeEnd = 305872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownTerminals.NativeMethodInfoPtr_get_linux_Public_Static_get_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0007FC24 File Offset: 0x0007DE24
		public unsafe static Il2CppStructArray<byte> xterm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 305879, RefRangeEnd = 305880, XrefRangeStart = 305873, XrefRangeEnd = 305879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownTerminals.NativeMethodInfoPtr_get_xterm_Public_Static_get_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0007FC58 File Offset: 0x0007DE58
		public unsafe static Il2CppStructArray<byte> ansi
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 305886, RefRangeEnd = 305887, XrefRangeStart = 305880, XrefRangeEnd = 305886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownTerminals.NativeMethodInfoPtr_get_ansi_Public_Static_get_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00007270 File Offset: 0x00005470
		public KnownTerminals(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_get_linux_Public_Static_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_get_xterm_Public_Static_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_get_ansi_Public_Static_get_Il2CppStructArray_1_Byte_0;
	}
}
