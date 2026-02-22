using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200008C RID: 140
	public class RestrictionFacets : Object
	{
		// Token: 0x06000997 RID: 2455 RVA: 0x00031CAC File Offset: 0x0002FEAC
		// Note: this type is marked as 'beforefieldinit'.
		static RestrictionFacets()
		{
			Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RestrictionFacets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr);
			RestrictionFacets.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Length");
			RestrictionFacets.NativeFieldInfoPtr_MinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinLength");
			RestrictionFacets.NativeFieldInfoPtr_MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxLength");
			RestrictionFacets.NativeFieldInfoPtr_Patterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Patterns");
			RestrictionFacets.NativeFieldInfoPtr_Enumeration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Enumeration");
			RestrictionFacets.NativeFieldInfoPtr_WhiteSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "WhiteSpace");
			RestrictionFacets.NativeFieldInfoPtr_MaxInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxInclusive");
			RestrictionFacets.NativeFieldInfoPtr_MaxExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxExclusive");
			RestrictionFacets.NativeFieldInfoPtr_MinInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinInclusive");
			RestrictionFacets.NativeFieldInfoPtr_MinExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinExclusive");
			RestrictionFacets.NativeFieldInfoPtr_TotalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "TotalDigits");
			RestrictionFacets.NativeFieldInfoPtr_FractionDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "FractionDigits");
			RestrictionFacets.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Flags");
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0000528B File Offset: 0x0000348B
		public RestrictionFacets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00031DE0 File Offset: 0x0002FFE0
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x00005294 File Offset: 0x00003494
		public unsafe int Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Length)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00031E08 File Offset: 0x00030008
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x000052AF File Offset: 0x000034AF
		public unsafe int MinLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinLength)) = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00031E30 File Offset: 0x00030030
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x000052CA File Offset: 0x000034CA
		public unsafe int MaxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxLength)) = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x00031E58 File Offset: 0x00030058
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x000052E5 File Offset: 0x000034E5
		public unsafe ArrayList Patterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Patterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Patterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00031E88 File Offset: 0x00030088
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00005304 File Offset: 0x00003504
		public unsafe ArrayList Enumeration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Enumeration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Enumeration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00031EB8 File Offset: 0x000300B8
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x00005323 File Offset: 0x00003523
		public unsafe XmlSchemaWhiteSpace WhiteSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_WhiteSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_WhiteSpace)) = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00031EE0 File Offset: 0x000300E0
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x0000533E File Offset: 0x0000353E
		public unsafe Object MaxInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxInclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxInclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00031F10 File Offset: 0x00030110
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x0000535D File Offset: 0x0000355D
		public unsafe Object MaxExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00031F40 File Offset: 0x00030140
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x0000537C File Offset: 0x0000357C
		public unsafe Object MinInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinInclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinInclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00031F70 File Offset: 0x00030170
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0000539B File Offset: 0x0000359B
		public unsafe Object MinExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00031FA0 File Offset: 0x000301A0
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x000053BA File Offset: 0x000035BA
		public unsafe int TotalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_TotalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_TotalDigits)) = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00031FC8 File Offset: 0x000301C8
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x000053D5 File Offset: 0x000035D5
		public unsafe int FractionDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_FractionDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_FractionDigits)) = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00031FF0 File Offset: 0x000301F0
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x000053F0 File Offset: 0x000035F0
		public unsafe RestrictionFlags Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Flags)) = value;
			}
		}

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_MinLength;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_MaxLength;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr_Patterns;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeFieldInfoPtr_Enumeration;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr_WhiteSpace;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeFieldInfoPtr_MaxInclusive;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr_MaxExclusive;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeFieldInfoPtr_MinInclusive;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_MinExclusive;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_TotalDigits;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr_FractionDigits;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_Flags;
	}
}
