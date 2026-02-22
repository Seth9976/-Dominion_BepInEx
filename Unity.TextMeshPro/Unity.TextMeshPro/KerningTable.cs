using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	public class KerningTable : Object
	{
		// Token: 0x060005AB RID: 1451 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
		// Note: this type is marked as 'beforefieldinit'.
		static KerningTable()
		{
			Il2CppClassPointerStore<KerningTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "KerningTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable>.NativeClassPtr);
			KerningTable.NativeFieldInfoPtr_kerningPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "kerningPairs");
			KerningTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663826);
			KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663827);
			KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Int32_UInt32_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663828);
			KerningTable.NativeMethodInfoPtr_AddGlyphPairAdjustmentRecord_Public_Int32_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663829);
			KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663830);
			KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663831);
			KerningTable.NativeMethodInfoPtr_SortKerningPairs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, 100663832);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140480, XrefRangeEnd = 140487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KerningTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0001C200 File Offset: 0x0001A400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140487, XrefRangeEnd = 140507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKerningPair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001C234 File Offset: 0x0001A434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140507, XrefRangeEnd = 140524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKerningPair(uint first, uint second, float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_AddKerningPair_Public_Int32_UInt32_UInt32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0001C29C File Offset: 0x0001A49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140524, XrefRangeEnd = 140541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstAdjustments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondAdjustments;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_AddGlyphPairAdjustmentRecord_Public_Int32_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001C310 File Offset: 0x0001A510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140541, XrefRangeEnd = 140559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKerningPair(int left, int right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001C35C File Offset: 0x0001A55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140559, XrefRangeEnd = 140563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKerningPair(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0001C39C File Offset: 0x0001A59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140563, XrefRangeEnd = 140600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortKerningPairs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.NativeMethodInfoPtr_SortKerningPairs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00004DCF File Offset: 0x00002FCF
		public KerningTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00004DD8 File Offset: 0x00002FD8
		public unsafe List<KerningPair> kerningPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.NativeFieldInfoPtr_kerningPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KerningPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.NativeFieldInfoPtr_kerningPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr_kerningPairs;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_AddKerningPair_Public_Void_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_AddKerningPair_Public_Int32_UInt32_UInt32_Single_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_AddGlyphPairAdjustmentRecord_Public_Int32_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_Int32_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKerningPair_Public_Void_Int32_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_SortKerningPairs_Public_Void_0;

		// Token: 0x02000088 RID: 136
		[ObfuscatedName("TMPro.KerningTable+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06000F15 RID: 3861 RVA: 0x0003C798 File Offset: 0x0003A998
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr);
				KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, "first");
				KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, "second");
				KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, 100664840);
				KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__AddKerningPair_b__0_Internal_Boolean_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr, 100664841);
			}

			// Token: 0x06000F16 RID: 3862 RVA: 0x0003C814 File Offset: 0x0003AA14
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F17 RID: 3863 RVA: 0x0003C850 File Offset: 0x0003AA50
			[CallerCount(0)]
			public unsafe bool _AddKerningPair_b__0(KerningPair item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass3_0.NativeMethodInfoPtr__AddKerningPair_b__0_Internal_Boolean_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F18 RID: 3864 RVA: 0x00009209 File Offset: 0x00007409
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700058C RID: 1420
			// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0003C8A0 File Offset: 0x0003AAA0
			// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00009212 File Offset: 0x00007412
			public unsafe uint first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_first);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_first)) = value;
				}
			}

			// Token: 0x1700058D RID: 1421
			// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0003C8C8 File Offset: 0x0003AAC8
			// (set) Token: 0x06000F1C RID: 3868 RVA: 0x0000922D File Offset: 0x0000742D
			public unsafe uint second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_second);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass3_0.NativeFieldInfoPtr_second)) = value;
				}
			}

			// Token: 0x04000BE6 RID: 3046
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000BE7 RID: 3047
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000BE8 RID: 3048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BE9 RID: 3049
			private static readonly IntPtr NativeMethodInfoPtr__AddKerningPair_b__0_Internal_Boolean_KerningPair_0;
		}

		// Token: 0x02000089 RID: 137
		[ObfuscatedName("TMPro.KerningTable+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06000F1D RID: 3869 RVA: 0x0003C8F0 File Offset: 0x0003AAF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr);
				KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, "first");
				KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, "second");
				KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, 100664842);
				KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__AddGlyphPairAdjustmentRecord_b__0_Internal_Boolean_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr, 100664843);
			}

			// Token: 0x06000F1E RID: 3870 RVA: 0x0003C96C File Offset: 0x0003AB6C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F1F RID: 3871 RVA: 0x0003C9A8 File Offset: 0x0003ABA8
			[CallerCount(0)]
			public unsafe bool _AddGlyphPairAdjustmentRecord_b__0(KerningPair item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass4_0.NativeMethodInfoPtr__AddGlyphPairAdjustmentRecord_b__0_Internal_Boolean_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F20 RID: 3872 RVA: 0x00009248 File Offset: 0x00007448
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700058E RID: 1422
			// (get) Token: 0x06000F21 RID: 3873 RVA: 0x0003C9F8 File Offset: 0x0003ABF8
			// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00009251 File Offset: 0x00007451
			public unsafe uint first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_first);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_first)) = value;
				}
			}

			// Token: 0x1700058F RID: 1423
			// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0003CA20 File Offset: 0x0003AC20
			// (set) Token: 0x06000F24 RID: 3876 RVA: 0x0000926C File Offset: 0x0000746C
			public unsafe uint second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_second);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass4_0.NativeFieldInfoPtr_second)) = value;
				}
			}

			// Token: 0x04000BEA RID: 3050
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000BEB RID: 3051
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000BEC RID: 3052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BED RID: 3053
			private static readonly IntPtr NativeMethodInfoPtr__AddGlyphPairAdjustmentRecord_b__0_Internal_Boolean_KerningPair_0;
		}

		// Token: 0x0200008A RID: 138
		[ObfuscatedName("TMPro.KerningTable+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06000F25 RID: 3877 RVA: 0x0003CA48 File Offset: 0x0003AC48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr);
				KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, "left");
				KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, "right");
				KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, 100664844);
				KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__RemoveKerningPair_b__0_Internal_Boolean_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr, 100664845);
			}

			// Token: 0x06000F26 RID: 3878 RVA: 0x0003CAC4 File Offset: 0x0003ACC4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F27 RID: 3879 RVA: 0x0003CB00 File Offset: 0x0003AD00
			[CallerCount(0)]
			public unsafe bool _RemoveKerningPair_b__0(KerningPair item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c__DisplayClass5_0.NativeMethodInfoPtr__RemoveKerningPair_b__0_Internal_Boolean_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F28 RID: 3880 RVA: 0x00009287 File Offset: 0x00007487
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000590 RID: 1424
			// (get) Token: 0x06000F29 RID: 3881 RVA: 0x0003CB50 File Offset: 0x0003AD50
			// (set) Token: 0x06000F2A RID: 3882 RVA: 0x00009290 File Offset: 0x00007490
			public unsafe int left
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_left);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_left)) = value;
				}
			}

			// Token: 0x17000591 RID: 1425
			// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0003CB78 File Offset: 0x0003AD78
			// (set) Token: 0x06000F2C RID: 3884 RVA: 0x000092AB File Offset: 0x000074AB
			public unsafe int right
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_right);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KerningTable.__c__DisplayClass5_0.NativeFieldInfoPtr_right)) = value;
				}
			}

			// Token: 0x04000BEE RID: 3054
			private static readonly IntPtr NativeFieldInfoPtr_left;

			// Token: 0x04000BEF RID: 3055
			private static readonly IntPtr NativeFieldInfoPtr_right;

			// Token: 0x04000BF0 RID: 3056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BF1 RID: 3057
			private static readonly IntPtr NativeMethodInfoPtr__RemoveKerningPair_b__0_Internal_Boolean_KerningPair_0;
		}

		// Token: 0x0200008B RID: 139
		[ObfuscatedName("TMPro.KerningTable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F2D RID: 3885 RVA: 0x0003CBA0 File Offset: 0x0003ADA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KerningTable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr);
				KerningTable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, "<>9");
				KerningTable.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, "<>9__7_0");
				KerningTable.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, "<>9__7_1");
				KerningTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, 100664847);
				KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_0_Internal_UInt32_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, 100664848);
				KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_1_Internal_UInt32_KerningPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr, 100664849);
			}

			// Token: 0x06000F2E RID: 3886 RVA: 0x0003CC44 File Offset: 0x0003AE44
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningTable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F2F RID: 3887 RVA: 0x0003CC80 File Offset: 0x0003AE80
			[CallerCount(0)]
			public unsafe uint _SortKerningPairs_b__7_0(KerningPair s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_0_Internal_UInt32_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F30 RID: 3888 RVA: 0x0003CCD0 File Offset: 0x0003AED0
			[CallerCount(0)]
			public unsafe uint _SortKerningPairs_b__7_1(KerningPair s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KerningTable.__c.NativeMethodInfoPtr__SortKerningPairs_b__7_1_Internal_UInt32_KerningPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F31 RID: 3889 RVA: 0x000092C6 File Offset: 0x000074C6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000592 RID: 1426
			// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0003CD20 File Offset: 0x0003AF20
			// (set) Token: 0x06000F33 RID: 3891 RVA: 0x000092CF File Offset: 0x000074CF
			public unsafe static KerningTable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KerningTable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KerningTable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KerningTable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000593 RID: 1427
			// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0003CD48 File Offset: 0x0003AF48
			// (set) Token: 0x06000F35 RID: 3893 RVA: 0x000092E1 File Offset: 0x000074E1
			public unsafe static Func<KerningPair, uint> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KerningTable.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KerningPair, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KerningTable.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000594 RID: 1428
			// (get) Token: 0x06000F36 RID: 3894 RVA: 0x0003CD70 File Offset: 0x0003AF70
			// (set) Token: 0x06000F37 RID: 3895 RVA: 0x000092F3 File Offset: 0x000074F3
			public unsafe static Func<KerningPair, uint> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KerningTable.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KerningPair, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KerningTable.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BF2 RID: 3058
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000BF3 RID: 3059
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04000BF4 RID: 3060
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04000BF5 RID: 3061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000BF6 RID: 3062
			private static readonly IntPtr NativeMethodInfoPtr__SortKerningPairs_b__7_0_Internal_UInt32_KerningPair_0;

			// Token: 0x04000BF7 RID: 3063
			private static readonly IntPtr NativeMethodInfoPtr__SortKerningPairs_b__7_1_Internal_UInt32_KerningPair_0;
		}
	}
}
