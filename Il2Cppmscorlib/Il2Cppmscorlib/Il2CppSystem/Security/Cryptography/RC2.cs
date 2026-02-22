using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F5 RID: 757
	public class RC2 : SymmetricAlgorithm
	{
		// Token: 0x06003173 RID: 12659 RVA: 0x000F5BBC File Offset: 0x000F3DBC
		// Note: this type is marked as 'beforefieldinit'.
		static RC2()
		{
			Il2CppClassPointerStore<RC2>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RC2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RC2>.NativeClassPtr);
			RC2.NativeFieldInfoPtr_EffectiveKeySizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2>.NativeClassPtr, "EffectiveKeySizeValue");
			RC2.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2>.NativeClassPtr, "s_legalBlockSizes");
			RC2.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2>.NativeClassPtr, "s_legalKeySizes");
			RC2.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100671053);
			RC2.NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100671054);
			RC2.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100671055);
			RC2.NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100671056);
			RC2.NativeMethodInfoPtr_Create_Public_Static_RC2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100671057);
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x000F5C8C File Offset: 0x000F3E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339940, XrefRangeEnd = 339946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RC2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RC2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x000F5CC8 File Offset: 0x000F3EC8
		public unsafe virtual int EffectiveKeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2.NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x000F5D10 File Offset: 0x000F3F10
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x000F5D58 File Offset: 0x000F3F58
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339946, XrefRangeEnd = 339954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2.NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x000F5DA4 File Offset: 0x000F3FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339958, RefRangeEnd = 339959, XrefRangeStart = 339954, XrefRangeEnd = 339958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RC2 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2.NativeMethodInfoPtr_Create_Public_Static_RC2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RC2>(intPtr3) : null;
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x00011809 File Offset: 0x0000FA09
		public RC2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x000F5DD8 File Offset: 0x000F3FD8
		// (set) Token: 0x0600317B RID: 12667 RVA: 0x00011812 File Offset: 0x0000FA12
		public unsafe int EffectiveKeySizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2.NativeFieldInfoPtr_EffectiveKeySizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2.NativeFieldInfoPtr_EffectiveKeySizeValue)) = value;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x000F5E00 File Offset: 0x000F4000
		// (set) Token: 0x0600317D RID: 12669 RVA: 0x0001182D File Offset: 0x0000FA2D
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC2.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC2.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x000F5E28 File Offset: 0x000F4028
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x0001183F File Offset: 0x0000FA3F
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC2.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC2.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A6A RID: 10858
		private static readonly IntPtr NativeFieldInfoPtr_EffectiveKeySizeValue;

		// Token: 0x04002A6B RID: 10859
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x04002A6C RID: 10860
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x04002A6D RID: 10861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002A6E RID: 10862
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002A6F RID: 10863
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04002A70 RID: 10864
		private static readonly IntPtr NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04002A71 RID: 10865
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RC2_0;
	}
}
