using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004B RID: 75
	public sealed class RegexBoyerMoore : Object
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x00021DB4 File Offset: 0x0001FFB4
		// Note: this type is marked as 'beforefieldinit'.
		static RegexBoyerMoore()
		{
			Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexBoyerMoore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr);
			RegexBoyerMoore.NativeFieldInfoPtr__positive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_positive");
			RegexBoyerMoore.NativeFieldInfoPtr__negativeASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_negativeASCII");
			RegexBoyerMoore.NativeFieldInfoPtr__negativeUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_negativeUnicode");
			RegexBoyerMoore.NativeFieldInfoPtr__pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_pattern");
			RegexBoyerMoore.NativeFieldInfoPtr__lowASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_lowASCII");
			RegexBoyerMoore.NativeFieldInfoPtr__highASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_highASCII");
			RegexBoyerMoore.NativeFieldInfoPtr__rightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_rightToLeft");
			RegexBoyerMoore.NativeFieldInfoPtr__caseInsensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_caseInsensitive");
			RegexBoyerMoore.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "_culture");
			RegexBoyerMoore.NativeFieldInfoPtr_infinite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, "infinite");
			RegexBoyerMoore.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100663951);
			RegexBoyerMoore.NativeMethodInfoPtr_MatchPattern_Private_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100663952);
			RegexBoyerMoore.NativeMethodInfoPtr_IsMatch_Internal_Boolean_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100663953);
			RegexBoyerMoore.NativeMethodInfoPtr_Scan_Internal_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100663954);
			RegexBoyerMoore.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr, 100663955);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00021F10 File Offset: 0x00020110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37609, RefRangeEnd = 37610, XrefRangeStart = 37578, XrefRangeEnd = 37609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexBoyerMoore>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightToLeft;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00021F8C File Offset: 0x0002018C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37611, RefRangeEnd = 37613, XrefRangeStart = 37610, XrefRangeEnd = 37611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchPattern(string text, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_MatchPattern_Private_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00021FE8 File Offset: 0x000201E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37613, XrefRangeEnd = 37615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatch(string text, int index, int beglimit, int endlimit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beglimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endlimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_IsMatch_Internal_Boolean_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00022060 File Offset: 0x00020260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37615, XrefRangeEnd = 37633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Scan(string text, int index, int beglimit, int endlimit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beglimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endlimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_Scan_Internal_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000220D8 File Offset: 0x000202D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexBoyerMoore.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000039EA File Offset: 0x00001BEA
		public RegexBoyerMoore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00022110 File Offset: 0x00020310
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x000039F3 File Offset: 0x00001BF3
		public unsafe Il2CppStructArray<int> _positive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__positive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__positive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00022140 File Offset: 0x00020340
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00003A12 File Offset: 0x00001C12
		public unsafe Il2CppStructArray<int> _negativeASCII
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__negativeASCII);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__negativeASCII), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00022170 File Offset: 0x00020370
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00003A31 File Offset: 0x00001C31
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> _negativeUnicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__negativeUnicode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__negativeUnicode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000221A0 File Offset: 0x000203A0
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00003A50 File Offset: 0x00001C50
		public unsafe string _pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x000221C8 File Offset: 0x000203C8
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00003A6F File Offset: 0x00001C6F
		public unsafe int _lowASCII
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__lowASCII);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__lowASCII)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000221F0 File Offset: 0x000203F0
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00003A8A File Offset: 0x00001C8A
		public unsafe int _highASCII
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__highASCII);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__highASCII)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00022218 File Offset: 0x00020418
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00003AA5 File Offset: 0x00001CA5
		public unsafe bool _rightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__rightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__rightToLeft)) = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00022240 File Offset: 0x00020440
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public unsafe bool _caseInsensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__caseInsensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__caseInsensitive)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00022268 File Offset: 0x00020468
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00003ADB File Offset: 0x00001CDB
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexBoyerMoore.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00022298 File Offset: 0x00020498
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00003AFA File Offset: 0x00001CFA
		public unsafe static int infinite
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexBoyerMoore.NativeFieldInfoPtr_infinite, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexBoyerMoore.NativeFieldInfoPtr_infinite, (void*)(&value));
			}
		}

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr__positive;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr__negativeASCII;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr__negativeUnicode;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr__pattern;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeFieldInfoPtr__lowASCII;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeFieldInfoPtr__highASCII;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeFieldInfoPtr__rightToLeft;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitive;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_infinite;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_CultureInfo_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_MatchPattern_Private_Boolean_String_Int32_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Internal_Boolean_String_Int32_Int32_Int32_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_Scan_Internal_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
