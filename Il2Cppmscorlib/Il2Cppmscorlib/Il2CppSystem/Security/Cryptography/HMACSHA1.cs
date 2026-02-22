using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002EB RID: 747
	public class HMACSHA1 : HMAC
	{
		// Token: 0x06003119 RID: 12569 RVA: 0x000F4660 File Offset: 0x000F2860
		// Note: this type is marked as 'beforefieldinit'.
		static HMACSHA1()
		{
			Il2CppClassPointerStore<HMACSHA1>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACSHA1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACSHA1>.NativeClassPtr);
			HMACSHA1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA1>.NativeClassPtr, 100671007);
			HMACSHA1.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA1>.NativeClassPtr, 100671008);
			HMACSHA1.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA1>.NativeClassPtr, 100671009);
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x000F46CC File Offset: 0x000F28CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339692, RefRangeEnd = 339693, XrefRangeStart = 339680, XrefRangeEnd = 339692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x000F4708 File Offset: 0x000F2908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339704, RefRangeEnd = 339705, XrefRangeStart = 339693, XrefRangeEnd = 339704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA1(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA1>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA1.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x000F4754 File Offset: 0x000F2954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339704, RefRangeEnd = 339705, XrefRangeStart = 339704, XrefRangeEnd = 339705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA1(Il2CppStructArray<byte> key, bool useManagedSha1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA1>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useManagedSha1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA1.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x00011653 File Offset: 0x0000F853
		public HMACSHA1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A30 RID: 10800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A31 RID: 10801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A32 RID: 10802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0;
	}
}
