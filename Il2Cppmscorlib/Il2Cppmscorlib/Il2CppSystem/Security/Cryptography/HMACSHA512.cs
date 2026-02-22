using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002EE RID: 750
	public class HMACSHA512 : HMAC
	{
		// Token: 0x06003129 RID: 12585 RVA: 0x000F49FC File Offset: 0x000F2BFC
		// Note: this type is marked as 'beforefieldinit'.
		static HMACSHA512()
		{
			Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACSHA512");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr);
			HMACSHA512.NativeFieldInfoPtr_m_useLegacyBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr, "m_useLegacyBlockSize");
			HMACSHA512.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr, 100671015);
			HMACSHA512.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr, 100671016);
			HMACSHA512.NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr, 100671017);
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x000F4A7C File Offset: 0x000F2C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339755, XrefRangeEnd = 339768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA512()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA512.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x000F4AB8 File Offset: 0x000F2CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339768, XrefRangeEnd = 339780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA512(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA512>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA512.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x000F4B04 File Offset: 0x000F2D04
		public unsafe int BlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA512.NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x00011689 File Offset: 0x0000F889
		public HMACSHA512(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x000F4B40 File Offset: 0x000F2D40
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x00011692 File Offset: 0x0000F892
		public unsafe bool m_useLegacyBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMACSHA512.NativeFieldInfoPtr_m_useLegacyBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMACSHA512.NativeFieldInfoPtr_m_useLegacyBlockSize)) = value;
			}
		}

		// Token: 0x04002A39 RID: 10809
		private static readonly IntPtr NativeFieldInfoPtr_m_useLegacyBlockSize;

		// Token: 0x04002A3A RID: 10810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A3B RID: 10811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A3C RID: 10812
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0;
	}
}
