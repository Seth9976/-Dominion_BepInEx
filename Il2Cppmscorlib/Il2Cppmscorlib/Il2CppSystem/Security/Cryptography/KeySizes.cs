using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002DA RID: 730
	public sealed class KeySizes : Object
	{
		// Token: 0x06003047 RID: 12359 RVA: 0x000F157C File Offset: 0x000EF77C
		// Note: this type is marked as 'beforefieldinit'.
		static KeySizes()
		{
			Il2CppClassPointerStore<KeySizes>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "KeySizes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeySizes>.NativeClassPtr);
			KeySizes.NativeFieldInfoPtr_m_minSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, "m_minSize");
			KeySizes.NativeFieldInfoPtr_m_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, "m_maxSize");
			KeySizes.NativeFieldInfoPtr_m_skipSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, "m_skipSize");
			KeySizes.NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100670905);
			KeySizes.NativeMethodInfoPtr_get_MaxSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100670906);
			KeySizes.NativeMethodInfoPtr_get_SkipSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100670907);
			KeySizes.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100670908);
			KeySizes.NativeMethodInfoPtr_IsLegal_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100670909);
			KeySizes.NativeMethodInfoPtr_IsLegalKeySize_Internal_Static_Boolean_Il2CppReferenceArray_1_KeySizes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100670910);
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x000F1660 File Offset: 0x000EF860
		public unsafe int MinSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06003049 RID: 12361 RVA: 0x000F169C File Offset: 0x000EF89C
		public unsafe int MaxSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr_get_MaxSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x000F16D8 File Offset: 0x000EF8D8
		public unsafe int SkipSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr_get_SkipSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x000F1714 File Offset: 0x000EF914
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 338855, RefRangeEnd = 338862, XrefRangeStart = 338854, XrefRangeEnd = 338855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeySizes(int minSize, int maxSize, int skipSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeySizes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x000F1778 File Offset: 0x000EF978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338862, XrefRangeEnd = 338863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLegal(int keySize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr_IsLegal_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x000F17C4 File Offset: 0x000EF9C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338865, RefRangeEnd = 338866, XrefRangeStart = 338863, XrefRangeEnd = 338865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLegalKeySize(Il2CppReferenceArray<KeySizes> legalKeys, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(legalKeys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySizes.NativeMethodInfoPtr_IsLegalKeySize_Internal_Static_Boolean_Il2CppReferenceArray_1_KeySizes_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x000110EF File Offset: 0x0000F2EF
		public KeySizes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x0600304F RID: 12367 RVA: 0x000F1814 File Offset: 0x000EFA14
		// (set) Token: 0x06003050 RID: 12368 RVA: 0x000110F8 File Offset: 0x0000F2F8
		public unsafe int m_minSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_minSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_minSize)) = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x000F183C File Offset: 0x000EFA3C
		// (set) Token: 0x06003052 RID: 12370 RVA: 0x00011113 File Offset: 0x0000F313
		public unsafe int m_maxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_maxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_maxSize)) = value;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x000F1864 File Offset: 0x000EFA64
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x0001112E File Offset: 0x0000F32E
		public unsafe int m_skipSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_skipSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySizes.NativeFieldInfoPtr_m_skipSize)) = value;
			}
		}

		// Token: 0x0400299B RID: 10651
		private static readonly IntPtr NativeFieldInfoPtr_m_minSize;

		// Token: 0x0400299C RID: 10652
		private static readonly IntPtr NativeFieldInfoPtr_m_maxSize;

		// Token: 0x0400299D RID: 10653
		private static readonly IntPtr NativeFieldInfoPtr_m_skipSize;

		// Token: 0x0400299E RID: 10654
		private static readonly IntPtr NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0;

		// Token: 0x0400299F RID: 10655
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSize_Public_get_Int32_0;

		// Token: 0x040029A0 RID: 10656
		private static readonly IntPtr NativeMethodInfoPtr_get_SkipSize_Public_get_Int32_0;

		// Token: 0x040029A1 RID: 10657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040029A2 RID: 10658
		private static readonly IntPtr NativeMethodInfoPtr_IsLegal_Internal_Boolean_Int32_0;

		// Token: 0x040029A3 RID: 10659
		private static readonly IntPtr NativeMethodInfoPtr_IsLegalKeySize_Internal_Static_Boolean_Il2CppReferenceArray_1_KeySizes_Int32_0;
	}
}
