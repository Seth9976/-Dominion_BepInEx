using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000068 RID: 104
	[Serializable]
	public class LocalizedProductDescription : Object
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x00011F10 File Offset: 0x00010110
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedProductDescription()
		{
			Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "LocalizedProductDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr);
			LocalizedProductDescription.NativeFieldInfoPtr_googleLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr, "googleLocale");
			LocalizedProductDescription.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr, "title");
			LocalizedProductDescription.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr, "description");
			LocalizedProductDescription.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr, 100663751);
			LocalizedProductDescription.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr, 100663752);
			LocalizedProductDescription.NativeMethodInfoPtr_DecodeNonLatinCharacters_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr, 100663753);
			LocalizedProductDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr, 100663754);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00011FCC File Offset: 0x000101CC
		public unsafe string Title
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154972, XrefRangeEnd = 154973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedProductDescription.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00012004 File Offset: 0x00010204
		public unsafe string Description
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154973, XrefRangeEnd = 154974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedProductDescription.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0001203C File Offset: 0x0001023C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 154993, RefRangeEnd = 154997, XrefRangeStart = 154974, XrefRangeEnd = 154993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecodeNonLatinCharacters(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedProductDescription.NativeMethodInfoPtr_DecodeNonLatinCharacters_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00012078 File Offset: 0x00010278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154997, XrefRangeEnd = 154998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedProductDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedProductDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003D94 File Offset: 0x00001F94
		public LocalizedProductDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003AD RID: 941 RVA: 0x000120B4 File Offset: 0x000102B4
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00003D9D File Offset: 0x00001F9D
		public unsafe TranslationLocale googleLocale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedProductDescription.NativeFieldInfoPtr_googleLocale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedProductDescription.NativeFieldInfoPtr_googleLocale)) = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003AF RID: 943 RVA: 0x000120DC File Offset: 0x000102DC
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003DB8 File Offset: 0x00001FB8
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedProductDescription.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedProductDescription.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00012104 File Offset: 0x00010304
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003DD7 File Offset: 0x00001FD7
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedProductDescription.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedProductDescription.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_googleLocale;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_DecodeNonLatinCharacters_Private_Static_String_String_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C0 RID: 192
		[ObfuscatedName("UnityEngine.Purchasing.LocalizedProductDescription+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000704 RID: 1796 RVA: 0x0001C7D4 File Offset: 0x0001A9D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LocalizedProductDescription.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedProductDescription>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedProductDescription.__c>.NativeClassPtr);
				LocalizedProductDescription.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedProductDescription.__c>.NativeClassPtr, "<>9");
				LocalizedProductDescription.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedProductDescription.__c>.NativeClassPtr, "<>9__11_0");
				LocalizedProductDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedProductDescription.__c>.NativeClassPtr, 100663756);
				LocalizedProductDescription.__c.NativeMethodInfoPtr__DecodeNonLatinCharacters_b__11_0_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedProductDescription.__c>.NativeClassPtr, 100663757);
			}

			// Token: 0x06000705 RID: 1797 RVA: 0x0001C850 File Offset: 0x0001AA50
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedProductDescription.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedProductDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000706 RID: 1798 RVA: 0x0001C88C File Offset: 0x0001AA8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154966, XrefRangeEnd = 154972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _DecodeNonLatinCharacters_b__11_0(Match m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedProductDescription.__c.NativeMethodInfoPtr__DecodeNonLatinCharacters_b__11_0_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000707 RID: 1799 RVA: 0x000058BB File Offset: 0x00003ABB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x06000708 RID: 1800 RVA: 0x0001C8D4 File Offset: 0x0001AAD4
			// (set) Token: 0x06000709 RID: 1801 RVA: 0x000058C4 File Offset: 0x00003AC4
			public unsafe static LocalizedProductDescription.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalizedProductDescription.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedProductDescription.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalizedProductDescription.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x0600070A RID: 1802 RVA: 0x0001C8FC File Offset: 0x0001AAFC
			// (set) Token: 0x0600070B RID: 1803 RVA: 0x000058D6 File Offset: 0x00003AD6
			public unsafe static MatchEvaluator __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalizedProductDescription.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchEvaluator>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalizedProductDescription.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400048C RID: 1164
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400048D RID: 1165
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400048E RID: 1166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400048F RID: 1167
			private static readonly IntPtr NativeMethodInfoPtr__DecodeNonLatinCharacters_b__11_0_Internal_String_Match_0;
		}
	}
}
