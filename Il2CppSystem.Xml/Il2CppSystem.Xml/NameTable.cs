using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000048 RID: 72
	public class NameTable : XmlNameTable
	{
		// Token: 0x06000608 RID: 1544 RVA: 0x00022A28 File Offset: 0x00020C28
		// Note: this type is marked as 'beforefieldinit'.
		static NameTable()
		{
			Il2CppClassPointerStore<NameTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "NameTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameTable>.NativeClassPtr);
			NameTable.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "entries");
			NameTable.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "count");
			NameTable.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "mask");
			NameTable.NativeFieldInfoPtr_hashCodeRandomizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "hashCodeRandomizer");
			NameTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100664288);
			NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100664289);
			NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100664290);
			NameTable.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100664291);
			NameTable.NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100664292);
			NameTable.NativeMethodInfoPtr_Grow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100664293);
			NameTable.NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100664294);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00022B34 File Offset: 0x00020D34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 16514, RefRangeEnd = 16518, XrefRangeStart = 16509, XrefRangeEnd = 16514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00022B70 File Offset: 0x00020D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16518, XrefRangeEnd = 16523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Add(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00022BC4 File Offset: 0x00020DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16523, XrefRangeEnd = 16528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Add(Il2CppStructArray<char> key, int start, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00022C34 File Offset: 0x00020E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16528, XrefRangeEnd = 16532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameTable.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00022C88 File Offset: 0x00020E88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16542, RefRangeEnd = 16544, XrefRangeStart = 16532, XrefRangeEnd = 16542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AddEntry(string str, int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00022CE0 File Offset: 0x00020EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16544, XrefRangeEnd = 16549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr_Grow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00022D14 File Offset: 0x00020F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16549, XrefRangeEnd = 16551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TextEquals(string str1, Il2CppStructArray<char> str2, int str2Start, int str2Length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(str2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref str2Start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref str2Length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00003FF2 File Offset: 0x000021F2
		public NameTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00022D84 File Offset: 0x00020F84
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00003FFB File Offset: 0x000021FB
		public unsafe Il2CppReferenceArray<NameTable.Entry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NameTable.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00022DB4 File Offset: 0x00020FB4
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x0000401A File Offset: 0x0000221A
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00022DDC File Offset: 0x00020FDC
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00004035 File Offset: 0x00002235
		public unsafe int mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_mask)) = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00022E04 File Offset: 0x00021004
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00004050 File Offset: 0x00002250
		public unsafe int hashCodeRandomizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_hashCodeRandomizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_hashCodeRandomizer)) = value;
			}
		}

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr_hashCodeRandomizer;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_String_String_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_String_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x02000123 RID: 291
		public class Entry : Object
		{
			// Token: 0x0600124D RID: 4685 RVA: 0x00054840 File Offset: 0x00052A40
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr);
				NameTable.Entry.NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, "str");
				NameTable.Entry.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, "hashCode");
				NameTable.Entry.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, "next");
				NameTable.Entry.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, 100664295);
			}

			// Token: 0x0600124E RID: 4686 RVA: 0x000548BC File Offset: 0x00052ABC
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 16496, RefRangeEnd = 16509, XrefRangeStart = 16495, XrefRangeEnd = 16496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(string str, int hashCode, NameTable.Entry next)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.Entry.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600124F RID: 4687 RVA: 0x00008129 File Offset: 0x00006329
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000668 RID: 1640
			// (get) Token: 0x06001250 RID: 4688 RVA: 0x00054928 File Offset: 0x00052B28
			// (set) Token: 0x06001251 RID: 4689 RVA: 0x00008132 File Offset: 0x00006332
			public unsafe string str
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_str);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_str), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000669 RID: 1641
			// (get) Token: 0x06001252 RID: 4690 RVA: 0x00054950 File Offset: 0x00052B50
			// (set) Token: 0x06001253 RID: 4691 RVA: 0x00008151 File Offset: 0x00006351
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x1700066A RID: 1642
			// (get) Token: 0x06001254 RID: 4692 RVA: 0x00054978 File Offset: 0x00052B78
			// (set) Token: 0x06001255 RID: 4693 RVA: 0x0000816C File Offset: 0x0000636C
			public unsafe NameTable.Entry next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameTable.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E2A RID: 3626
			private static readonly IntPtr NativeFieldInfoPtr_str;

			// Token: 0x04000E2B RID: 3627
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04000E2C RID: 3628
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04000E2D RID: 3629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0;
		}
	}
}
