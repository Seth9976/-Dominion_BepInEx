using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000308 RID: 776
	public class SignatureDescription : Object
	{
		// Token: 0x060032AB RID: 12971 RVA: 0x000FA2F8 File Offset: 0x000F84F8
		// Note: this type is marked as 'beforefieldinit'.
		static SignatureDescription()
		{
			Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr);
			SignatureDescription.NativeFieldInfoPtr__strKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strKey");
			SignatureDescription.NativeFieldInfoPtr__strDigest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strDigest");
			SignatureDescription.NativeFieldInfoPtr__strFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strFormatter");
			SignatureDescription.NativeFieldInfoPtr__strDeformatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, "_strDeformatter");
			SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100671197);
			SignatureDescription.NativeMethodInfoPtr_set_KeyAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100671198);
			SignatureDescription.NativeMethodInfoPtr_set_DigestAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100671199);
			SignatureDescription.NativeMethodInfoPtr_set_FormatterAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100671200);
			SignatureDescription.NativeMethodInfoPtr_set_DeformatterAlgorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr, 100671201);
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x000FA3DC File Offset: 0x000F85DC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C32 RID: 3122
		// (set) Token: 0x060032AD RID: 12973 RVA: 0x000FA418 File Offset: 0x000F8618
		public unsafe string KeyAlgorithm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_KeyAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (set) Token: 0x060032AE RID: 12974 RVA: 0x000FA45C File Offset: 0x000F865C
		public unsafe string DigestAlgorithm
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_DigestAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (set) Token: 0x060032AF RID: 12975 RVA: 0x000FA4A0 File Offset: 0x000F86A0
		public unsafe string FormatterAlgorithm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_FormatterAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (set) Token: 0x060032B0 RID: 12976 RVA: 0x000FA4E4 File Offset: 0x000F86E4
		public unsafe string DeformatterAlgorithm
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignatureDescription.NativeMethodInfoPtr_set_DeformatterAlgorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00011FFD File Offset: 0x000101FD
		public SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x000FA528 File Offset: 0x000F8728
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x00012006 File Offset: 0x00010206
		public unsafe string _strKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000FA550 File Offset: 0x000F8750
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x00012025 File Offset: 0x00010225
		public unsafe string _strDigest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDigest);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDigest), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000FA578 File Offset: 0x000F8778
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x00012044 File Offset: 0x00010244
		public unsafe string _strFormatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strFormatter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strFormatter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000FA5A0 File Offset: 0x000F87A0
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x00012063 File Offset: 0x00010263
		public unsafe string _strDeformatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDeformatter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignatureDescription.NativeFieldInfoPtr__strDeformatter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002B3B RID: 11067
		private static readonly IntPtr NativeFieldInfoPtr__strKey;

		// Token: 0x04002B3C RID: 11068
		private static readonly IntPtr NativeFieldInfoPtr__strDigest;

		// Token: 0x04002B3D RID: 11069
		private static readonly IntPtr NativeFieldInfoPtr__strFormatter;

		// Token: 0x04002B3E RID: 11070
		private static readonly IntPtr NativeFieldInfoPtr__strDeformatter;

		// Token: 0x04002B3F RID: 11071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B40 RID: 11072
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyAlgorithm_Public_set_Void_String_0;

		// Token: 0x04002B41 RID: 11073
		private static readonly IntPtr NativeMethodInfoPtr_set_DigestAlgorithm_Public_set_Void_String_0;

		// Token: 0x04002B42 RID: 11074
		private static readonly IntPtr NativeMethodInfoPtr_set_FormatterAlgorithm_Public_set_Void_String_0;

		// Token: 0x04002B43 RID: 11075
		private static readonly IntPtr NativeMethodInfoPtr_set_DeformatterAlgorithm_Public_set_Void_String_0;
	}
}
