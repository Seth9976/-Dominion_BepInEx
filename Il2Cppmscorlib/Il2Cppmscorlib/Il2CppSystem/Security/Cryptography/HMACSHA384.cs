using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002ED RID: 749
	public class HMACSHA384 : HMAC
	{
		// Token: 0x06003122 RID: 12578 RVA: 0x000F4890 File Offset: 0x000F2A90
		// Note: this type is marked as 'beforefieldinit'.
		static HMACSHA384()
		{
			Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMACSHA384");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr);
			HMACSHA384.NativeFieldInfoPtr_m_useLegacyBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, "m_useLegacyBlockSize");
			HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, 100671012);
			HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, 100671013);
			HMACSHA384.NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr, 100671014);
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x000F4910 File Offset: 0x000F2B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339730, XrefRangeEnd = 339743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA384()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000F494C File Offset: 0x000F2B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339743, XrefRangeEnd = 339755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMACSHA384(Il2CppStructArray<byte> key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMACSHA384>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA384.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06003125 RID: 12581 RVA: 0x000F4998 File Offset: 0x000F2B98
		public unsafe int BlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMACSHA384.NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00011665 File Offset: 0x0000F865
		public HMACSHA384(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x000F49D4 File Offset: 0x000F2BD4
		// (set) Token: 0x06003128 RID: 12584 RVA: 0x0001166E File Offset: 0x0000F86E
		public unsafe bool m_useLegacyBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMACSHA384.NativeFieldInfoPtr_m_useLegacyBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMACSHA384.NativeFieldInfoPtr_m_useLegacyBlockSize)) = value;
			}
		}

		// Token: 0x04002A35 RID: 10805
		private static readonly IntPtr NativeFieldInfoPtr_m_useLegacyBlockSize;

		// Token: 0x04002A36 RID: 10806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A37 RID: 10807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A38 RID: 10808
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSize_Private_get_Int32_0;
	}
}
