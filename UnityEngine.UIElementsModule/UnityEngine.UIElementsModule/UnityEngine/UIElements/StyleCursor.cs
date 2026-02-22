using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B1 RID: 177
	public sealed class StyleCursor : ValueType
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x0002B86C File Offset: 0x00029A6C
		// Note: this type is marked as 'beforefieldinit'.
		static StyleCursor()
		{
			Il2CppClassPointerStore<StyleCursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleCursor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr);
			StyleCursor.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, "m_Value");
			StyleCursor.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, "m_Keyword");
			StyleCursor.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Cursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100664173);
			StyleCursor.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100664174);
			StyleCursor.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleCursor_StyleCursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100664175);
			StyleCursor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleCursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100664176);
			StyleCursor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100664177);
			StyleCursor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100664178);
			StyleCursor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, 100664179);
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0002B950 File Offset: 0x00029B50
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00006469 File Offset: 0x00004669
		public unsafe Cursor value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Cursor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Cursor(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0002B98C File Offset: 0x00029B8C
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x0000647A File Offset: 0x0000467A
		public unsafe StyleKeyword keyword
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 88838, RefRangeEnd = 88870, XrefRangeStart = 88838, XrefRangeEnd = 88870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0002B9D0 File Offset: 0x00029BD0
		[CallerCount(0)]
		public unsafe static bool operator ==(StyleCursor lhs, StyleCursor rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleCursor_StyleCursor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0002BA30 File Offset: 0x00029C30
		[CallerCount(0)]
		public unsafe bool Equals(StyleCursor other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleCursor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0002BA88 File Offset: 0x00029C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96689, XrefRangeEnd = 96693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0002BADC File Offset: 0x00029CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96693, XrefRangeEnd = 96694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0002BB20 File Offset: 0x00029D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96694, XrefRangeEnd = 96700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleCursor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00006405 File Offset: 0x00004605
		public StyleCursor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0000640E File Offset: 0x0000460E
		public StyleCursor()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr))
		{
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0002BB5C File Offset: 0x00029D5C
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00006420 File Offset: 0x00004620
		public Cursor m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleCursor.NativeFieldInfoPtr_m_Value);
				return new Cursor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cursor>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleCursor.NativeFieldInfoPtr_m_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Cursor>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0002BB8C File Offset: 0x00029D8C
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x0000644E File Offset: 0x0000464E
		public unsafe StyleKeyword m_Keyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleCursor.NativeFieldInfoPtr_m_Keyword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleCursor.NativeFieldInfoPtr_m_Keyword)) = value;
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0002BBB4 File Offset: 0x00029DB4
		public static bool operator !=(StyleCursor lhs, StyleCursor rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002BBD0 File Offset: 0x00029DD0
		public static implicit operator StyleCursor(StyleKeyword keyword)
		{
			return new StyleCursor(keyword);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0002BBE8 File Offset: 0x00029DE8
		public static implicit operator StyleCursor(Cursor v)
		{
			return new StyleCursor(v);
		}

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Cursor_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleCursor_StyleCursor_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleCursor_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
