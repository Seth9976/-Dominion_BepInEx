using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002EC RID: 748
	public class HMACSHA256 : HMAC
	{
		// Token: 0x0600311E RID: 12574 RVA: 0x000F47B0 File Offset: 0x000F29B0
		// Note: this type is marked as 'beforefieldinit'.
		static HMACSHA256()
		{
			Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACSHA256");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr);
			HMACSHA256.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr, 100671010);
			HMACSHA256.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr, 100671011);
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x000F4808 File Offset: 0x000F2A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339705, XrefRangeEnd = 339717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA256()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA256.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000F4844 File Offset: 0x000F2A44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339728, RefRangeEnd = 339730, XrefRangeStart = 339717, XrefRangeEnd = 339728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA256(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA256>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA256.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x0001165C File Offset: 0x0000F85C
		public HMACSHA256(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A33 RID: 10803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A34 RID: 10804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
