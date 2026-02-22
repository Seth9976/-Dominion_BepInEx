using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000052 RID: 82
	public sealed class RegexFC : Object
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x00025170 File Offset: 0x00023370
		// Note: this type is marked as 'beforefieldinit'.
		static RegexFC()
		{
			Il2CppClassPointerStore<RegexFC>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexFC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexFC>.NativeClassPtr);
			RegexFC.NativeFieldInfoPtr__cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, "_cc");
			RegexFC.NativeFieldInfoPtr__nullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, "_nullable");
			RegexFC.NativeFieldInfoPtr__caseInsensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, "_caseInsensitive");
			RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664033);
			RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_Char_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664034);
			RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664035);
			RegexFC.NativeMethodInfoPtr_AddFC_Internal_Boolean_RegexFC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664036);
			RegexFC.NativeMethodInfoPtr_GetFirstChars_Internal_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664037);
			RegexFC.NativeMethodInfoPtr_IsCaseInsensitive_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFC>.NativeClassPtr, 100664038);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00025254 File Offset: 0x00023454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39160, XrefRangeEnd = 39165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC(bool nullable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFC>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nullable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0002529C File Offset: 0x0002349C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39171, RefRangeEnd = 39172, XrefRangeStart = 39165, XrefRangeEnd = 39171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC(char ch, bool not, bool nullable, bool caseInsensitive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFC>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref not;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_Char_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00025310 File Offset: 0x00023510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39172, XrefRangeEnd = 39177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC(string charClass, bool nullable, bool caseInsensitive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFC>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00025378 File Offset: 0x00023578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39177, XrefRangeEnd = 39181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddFC(RegexFC fc, bool concatenate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref concatenate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr_AddFC_Internal_Boolean_RegexFC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000253D4 File Offset: 0x000235D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39181, XrefRangeEnd = 39184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFirstChars(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr_GetFirstChars_Internal_String_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0002541C File Offset: 0x0002361C
		[CallerCount(0)]
		public unsafe bool IsCaseInsensitive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFC.NativeMethodInfoPtr_IsCaseInsensitive_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00004221 File Offset: 0x00002421
		public RegexFC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00025458 File Offset: 0x00023658
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0000422A File Offset: 0x0000242A
		public unsafe RegexCharClass _cc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__cc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__cc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00025488 File Offset: 0x00023688
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00004249 File Offset: 0x00002449
		public unsafe bool _nullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__nullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__nullable)) = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x000254B0 File Offset: 0x000236B0
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00004264 File Offset: 0x00002464
		public unsafe bool _caseInsensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__caseInsensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFC.NativeFieldInfoPtr__caseInsensitive)) = value;
			}
		}

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr__cc;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr__nullable;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitive;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_Boolean_Boolean_Boolean_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_AddFC_Internal_Boolean_RegexFC_Boolean_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstChars_Internal_String_CultureInfo_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_IsCaseInsensitive_Internal_Boolean_0;
	}
}
