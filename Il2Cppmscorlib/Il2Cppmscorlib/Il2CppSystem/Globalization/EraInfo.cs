using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000236 RID: 566
	[Serializable]
	public class EraInfo : Object
	{
		// Token: 0x06002612 RID: 9746 RVA: 0x000CAAA8 File Offset: 0x000C8CA8
		// Note: this type is marked as 'beforefieldinit'.
		static EraInfo()
		{
			Il2CppClassPointerStore<EraInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "EraInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EraInfo>.NativeClassPtr);
			EraInfo.NativeFieldInfoPtr_era = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "era");
			EraInfo.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "ticks");
			EraInfo.NativeFieldInfoPtr_yearOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "yearOffset");
			EraInfo.NativeFieldInfoPtr_minEraYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "minEraYear");
			EraInfo.NativeFieldInfoPtr_maxEraYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "maxEraYear");
			EraInfo.NativeFieldInfoPtr_eraName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "eraName");
			EraInfo.NativeFieldInfoPtr_abbrevEraName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "abbrevEraName");
			EraInfo.NativeFieldInfoPtr_englishEraName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, "englishEraName");
			EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, 100669500);
			EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EraInfo>.NativeClassPtr, 100669501);
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x000CABA0 File Offset: 0x000C8DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326549, RefRangeEnd = 326550, XrefRangeStart = 326546, XrefRangeEnd = 326549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EraInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startMonth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDay;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yearOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minEraYear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEraYear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x000CAC3C File Offset: 0x000C8E3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 326553, RefRangeEnd = 326557, XrefRangeStart = 326550, XrefRangeEnd = 326553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EraInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref era;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startYear;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startMonth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDay;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yearOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minEraYear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEraYear;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eraName);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(abbrevEraName);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(englishEraName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EraInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x0000D0A2 File Offset: 0x0000B2A2
		public EraInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x000CAD14 File Offset: 0x000C8F14
		// (set) Token: 0x06002617 RID: 9751 RVA: 0x0000D0AB File Offset: 0x0000B2AB
		public unsafe int era
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_era);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_era)) = value;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x000CAD3C File Offset: 0x000C8F3C
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x0000D0C6 File Offset: 0x0000B2C6
		public unsafe long ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_ticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_ticks)) = value;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000CAD64 File Offset: 0x000C8F64
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x0000D0E1 File Offset: 0x0000B2E1
		public unsafe int yearOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_yearOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_yearOffset)) = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x000CAD8C File Offset: 0x000C8F8C
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		public unsafe int minEraYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_minEraYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_minEraYear)) = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x000CADB4 File Offset: 0x000C8FB4
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x0000D117 File Offset: 0x0000B317
		public unsafe int maxEraYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_maxEraYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_maxEraYear)) = value;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x000CADDC File Offset: 0x000C8FDC
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x0000D132 File Offset: 0x0000B332
		public unsafe string eraName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_eraName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_eraName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x000CAE04 File Offset: 0x000C9004
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x0000D151 File Offset: 0x0000B351
		public unsafe string abbrevEraName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_abbrevEraName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_abbrevEraName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x000CAE2C File Offset: 0x000C902C
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x0000D170 File Offset: 0x0000B370
		public unsafe string englishEraName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_englishEraName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EraInfo.NativeFieldInfoPtr_englishEraName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeFieldInfoPtr_era;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeFieldInfoPtr_ticks;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeFieldInfoPtr_yearOffset;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeFieldInfoPtr_minEraYear;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeFieldInfoPtr_maxEraYear;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeFieldInfoPtr_eraName;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeFieldInfoPtr_abbrevEraName;

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeFieldInfoPtr_englishEraName;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_String_String_0;
	}
}
