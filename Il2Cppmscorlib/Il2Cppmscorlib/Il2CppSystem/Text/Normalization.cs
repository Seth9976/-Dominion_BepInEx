using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000177 RID: 375
	public class Normalization : Object
	{
		// Token: 0x06001A12 RID: 6674 RVA: 0x00098848 File Offset: 0x00096A48
		// Note: this type is marked as 'beforefieldinit'.
		static Normalization()
		{
			Il2CppClassPointerStore<Normalization>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "Normalization");
			Normalization.NativeFieldInfoPtr_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "props");
			Normalization.NativeFieldInfoPtr_mappedChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "mappedChars");
			Normalization.NativeFieldInfoPtr_charMapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "charMapIndex");
			Normalization.NativeFieldInfoPtr_helperIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "helperIndex");
			Normalization.NativeFieldInfoPtr_mapIdxToComposite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "mapIdxToComposite");
			Normalization.NativeFieldInfoPtr_combiningClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "combiningClass");
			Normalization.NativeFieldInfoPtr_forLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "forLock");
			Normalization.NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "isReady");
			Normalization.NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667712);
			Normalization.NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667713);
			Normalization.NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667714);
			Normalization.NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667715);
			Normalization.NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667716);
			Normalization.NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667717);
			Normalization.NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667718);
			Normalization.NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667719);
			Normalization.NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667720);
			Normalization.NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667721);
			Normalization.NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667722);
			Normalization.NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667723);
			Normalization.NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667724);
			Normalization.NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667725);
			Normalization.NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667726);
			Normalization.NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667727);
			Normalization.NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667728);
			Normalization.NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667729);
			Normalization.NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667730);
			Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667731);
			Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667732);
			Normalization.NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100667733);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00098AC8 File Offset: 0x00096CC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314947, RefRangeEnd = 314949, XrefRangeStart = 314934, XrefRangeEnd = 314947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint PropValue(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00098B08 File Offset: 0x00096D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314949, XrefRangeEnd = 314962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CharMapIdx(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00098B48 File Offset: 0x00096D48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 314971, RefRangeEnd = 314977, XrefRangeStart = 314962, XrefRangeEnd = 314971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte GetCombiningClass(int c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00098B88 File Offset: 0x00096D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314986, RefRangeEnd = 314987, XrefRangeStart = 314977, XrefRangeEnd = 314986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPrimaryCompositeFromMapIndex(int src)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00098BC8 File Offset: 0x00096DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314987, XrefRangeEnd = 314996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPrimaryCompositeHelperIndex(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00098C08 File Offset: 0x00096E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315019, RefRangeEnd = 315020, XrefRangeStart = 314996, XrefRangeEnd = 315019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Compose(string source, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00098C54 File Offset: 0x00096E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315020, XrefRangeEnd = 315034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder Combine(string source, int start, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00098CB4 File Offset: 0x00096EB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315059, RefRangeEnd = 315062, XrefRangeStart = 315034, XrefRangeEnd = 315059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Combine(StringBuilder sb, int i, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00098D08 File Offset: 0x00096F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315062, XrefRangeEnd = 315079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHangul(StringBuilder sb, string s, int current)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00098D6C File Offset: 0x00096F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315079, XrefRangeEnd = 315080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Fetch(StringBuilder sb, string s, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00098DD0 File Offset: 0x00096FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315093, RefRangeEnd = 315094, XrefRangeStart = 315080, XrefRangeEnd = 315093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00098E34 File Offset: 0x00097034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315094, XrefRangeEnd = 315111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TryCompose(int i, int starter, int candidate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref starter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref candidate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00098E90 File Offset: 0x00097090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315111, XrefRangeEnd = 315115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Decompose(string source, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00098EDC File Offset: 0x000970DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315148, RefRangeEnd = 315151, XrefRangeStart = 315115, XrefRangeEnd = 315148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Decompose(string source, ref StringBuilder sb, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sb = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00098F48 File Offset: 0x00097148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315184, RefRangeEnd = 315185, XrefRangeStart = 315151, XrefRangeEnd = 315184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReorderCanonical(string src, ref StringBuilder sb, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sb = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00098FB4 File Offset: 0x000971B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315185, XrefRangeEnd = 315201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DecomposeChar(ref StringBuilder sb, ref Il2CppStructArray<int> buf, string s, int i, int checkType, ref int start)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &start;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sb = ((intPtr5 == 0) ? null : new StringBuilder(intPtr5));
			IntPtr intPtr6 = intPtr2;
			buf = ((intPtr6 == 0) ? null : new Il2CppStructArray<int>(intPtr6));
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00099068 File Offset: 0x00097268
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315205, RefRangeEnd = 315209, XrefRangeStart = 315201, XrefRangeEnd = 315205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NormalizationCheck QuickCheck(char c, int type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000990B4 File Offset: 0x000972B4
		[CallerCount(0)]
		public unsafe static int GetCanonicalHangul(int s, Il2CppStructArray<int> buf, int bufIdx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufIdx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00099114 File Offset: 0x00097314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315213, RefRangeEnd = 315215, XrefRangeStart = 315209, XrefRangeEnd = 315213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCanonical(int c, Il2CppStructArray<int> buf, int bufIdx, int checkType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufIdx;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00099180 File Offset: 0x00097380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315228, RefRangeEnd = 315229, XrefRangeStart = 315215, XrefRangeEnd = 315228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Normalize(string source, NormalizationForm normalizationForm)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizationForm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000991CC File Offset: 0x000973CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315240, RefRangeEnd = 315241, XrefRangeStart = 315229, XrefRangeEnd = 315240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Normalize(string source, int type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00099218 File Offset: 0x00097418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315241, XrefRangeEnd = 315242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &props;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mappedChars;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charMapIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &helperIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mapIdxToComposite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &combiningClass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Normalization.NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00008EB7 File Offset: 0x000070B7
		public Normalization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00099294 File Offset: 0x00097494
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x00008EC0 File Offset: 0x000070C0
		public unsafe static byte* props
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_props, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_props, (void*)value);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x000992B0 File Offset: 0x000974B0
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x00008ECD File Offset: 0x000070CD
		public unsafe static int* mappedChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_mappedChars, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_mappedChars, (void*)value);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x000992CC File Offset: 0x000974CC
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x00008EDA File Offset: 0x000070DA
		public unsafe static short* charMapIndex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_charMapIndex, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_charMapIndex, (void*)value);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x000992E8 File Offset: 0x000974E8
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x00008EE7 File Offset: 0x000070E7
		public unsafe static short* helperIndex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_helperIndex, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_helperIndex, (void*)value);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x00099304 File Offset: 0x00097504
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x00008EF4 File Offset: 0x000070F4
		public unsafe static ushort* mapIdxToComposite
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_mapIdxToComposite, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_mapIdxToComposite, (void*)value);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x00099320 File Offset: 0x00097520
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x00008F01 File Offset: 0x00007101
		public unsafe static byte* combiningClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_combiningClass, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_combiningClass, (void*)value);
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x0009933C File Offset: 0x0009753C
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x00008F0E File Offset: 0x0000710E
		public unsafe static Object forLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_forLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_forLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x00099364 File Offset: 0x00097564
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x00008F20 File Offset: 0x00007120
		public unsafe static bool isReady
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Normalization.NativeFieldInfoPtr_isReady, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Normalization.NativeFieldInfoPtr_isReady, (void*)(&value));
			}
		}

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeFieldInfoPtr_props;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeFieldInfoPtr_mappedChars;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeFieldInfoPtr_charMapIndex;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeFieldInfoPtr_helperIndex;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeFieldInfoPtr_mapIdxToComposite;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeFieldInfoPtr_combiningClass;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeFieldInfoPtr_forLock;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeFieldInfoPtr_isReady;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0;
	}
}
