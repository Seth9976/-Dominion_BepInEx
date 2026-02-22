using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000032 RID: 50
	public class RC4 : SymmetricAlgorithm
	{
		// Token: 0x06000332 RID: 818 RVA: 0x0002E808 File Offset: 0x0002CA08
		// Note: this type is marked as 'beforefieldinit'.
		static RC4()
		{
			Il2CppClassPointerStore<RC4>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "RC4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RC4>.NativeClassPtr);
			RC4.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC4>.NativeClassPtr, "s_legalBlockSizes");
			RC4.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC4>.NativeClassPtr, "s_legalKeySizes");
			RC4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC4>.NativeClassPtr, 100663729);
			RC4.NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC4>.NativeClassPtr, 100663730);
			RC4.NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC4>.NativeClassPtr, 100663731);
			RC4.NativeMethodInfoPtr_Create_Public_Static_RC4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC4>.NativeClassPtr, 100663732);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0002E8B0 File Offset: 0x0002CAB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263100, RefRangeEnd = 263101, XrefRangeStart = 263094, XrefRangeEnd = 263100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RC4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RC4>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0002E8EC File Offset: 0x0002CAEC
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0002E938 File Offset: 0x0002CB38
		public unsafe override Il2CppStructArray<byte> IV
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263101, XrefRangeEnd = 263104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC4.NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC4.NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0002E988 File Offset: 0x0002CB88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263108, RefRangeEnd = 263109, XrefRangeStart = 263104, XrefRangeEnd = 263108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RC4 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC4.NativeMethodInfoPtr_Create_Public_Static_RC4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RC4>(intPtr3) : null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003542 File Offset: 0x00001742
		public RC4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0002E9BC File Offset: 0x0002CBBC
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000354B File Offset: 0x0000174B
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC4.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC4.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0002E9E4 File Offset: 0x0002CBE4
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000355D File Offset: 0x0000175D
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC4.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC4.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_get_IV_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_set_IV_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RC4_0;
	}
}
