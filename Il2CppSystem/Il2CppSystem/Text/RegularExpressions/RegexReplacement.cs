using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005E RID: 94
	public sealed class RegexReplacement : Object
	{
		// Token: 0x060006E1 RID: 1761 RVA: 0x0002A448 File Offset: 0x00028648
		// Note: this type is marked as 'beforefieldinit'.
		static RegexReplacement()
		{
			Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexReplacement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr);
			RegexReplacement.NativeMethodInfoPtr_Replace_Internal_Static_String_MatchEvaluator_Regex_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664217);
			RegexReplacement.NativeMethodInfoPtr_Split_Internal_Static_Il2CppStringArray_Regex_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexReplacement>.NativeClassPtr, 100664218);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0002A4A0 File Offset: 0x000286A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 40536, RefRangeEnd = 40540, XrefRangeStart = 40494, XrefRangeEnd = 40536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(regex);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_Replace_Internal_Static_String_MatchEvaluator_Regex_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0002A51C File Offset: 0x0002871C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 40585, RefRangeEnd = 40589, XrefRangeStart = 40540, XrefRangeEnd = 40585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Split(Regex regex, string input, int count, int startat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexReplacement.NativeMethodInfoPtr_Split_Internal_Static_Il2CppStringArray_Regex_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00004A3B File Offset: 0x00002C3B
		public RegexReplacement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Internal_Static_String_MatchEvaluator_Regex_String_Int32_Int32_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_Split_Internal_Static_Il2CppStringArray_Regex_String_Int32_Int32_0;
	}
}
