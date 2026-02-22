using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E9 RID: 745
	public class HMACMD5 : HMAC
	{
		// Token: 0x06003111 RID: 12561 RVA: 0x000F44A0 File Offset: 0x000F26A0
		// Note: this type is marked as 'beforefieldinit'.
		static HMACMD5()
		{
			Il2CppClassPointerStore<HMACMD5>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACMD5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr);
			HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr, 100671003);
			HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr, 100671004);
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x000F44F8 File Offset: 0x000F26F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339632, XrefRangeEnd = 339644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACMD5()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x000F4534 File Offset: 0x000F2734
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339655, RefRangeEnd = 339657, XrefRangeStart = 339644, XrefRangeEnd = 339655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACMD5(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACMD5>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACMD5.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x00011641 File Offset: 0x0000F841
		public HMACMD5(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A2C RID: 10796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A2D RID: 10797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
