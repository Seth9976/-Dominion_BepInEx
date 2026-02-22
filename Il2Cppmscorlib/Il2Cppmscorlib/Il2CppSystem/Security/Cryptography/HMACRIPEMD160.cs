using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002EA RID: 746
	public class HMACRIPEMD160 : HMAC
	{
		// Token: 0x06003115 RID: 12565 RVA: 0x000F4580 File Offset: 0x000F2780
		// Note: this type is marked as 'beforefieldinit'.
		static HMACRIPEMD160()
		{
			Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACRIPEMD160");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr);
			HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr, 100671005);
			HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr, 100671006);
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x000F45D8 File Offset: 0x000F27D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339657, XrefRangeEnd = 339669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACRIPEMD160()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x000F4614 File Offset: 0x000F2814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339669, XrefRangeEnd = 339680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACRIPEMD160(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACRIPEMD160>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACRIPEMD160.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0001164A File Offset: 0x0000F84A
		public HMACRIPEMD160(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A2E RID: 10798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A2F RID: 10799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
