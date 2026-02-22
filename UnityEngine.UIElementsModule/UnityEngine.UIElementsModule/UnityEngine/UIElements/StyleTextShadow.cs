using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B2 RID: 178
	[StructLayout(2)]
	public struct StyleTextShadow
	{
		// Token: 0x060009FA RID: 2554 RVA: 0x0002BC00 File Offset: 0x00029E00
		// Note: this type is marked as 'beforefieldinit'.
		static StyleTextShadow()
		{
			Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleTextShadow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr);
			StyleTextShadow.NativeFieldInfoPtr_m_Keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, "m_Keyword");
			StyleTextShadow.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, "m_Value");
			StyleTextShadow.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100664180);
			StyleTextShadow.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100664181);
			StyleTextShadow.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTextShadow_StyleTextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100664182);
			StyleTextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100664183);
			StyleTextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100664184);
			StyleTextShadow.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100664185);
			StyleTextShadow.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, 100664186);
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0002BCE4 File Offset: 0x00029EE4
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00006496 File Offset: 0x00004696
		public unsafe TextShadow value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_TextShadow_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0002BD14 File Offset: 0x00029F14
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x000064A7 File Offset: 0x000046A7
		public unsafe StyleKeyword keyword
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0002BD44 File Offset: 0x00029F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96700, XrefRangeEnd = 96701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTextShadow_StyleTextShadow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0002BD90 File Offset: 0x00029F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96701, XrefRangeEnd = 96702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(StyleTextShadow other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTextShadow_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002BDD0 File Offset: 0x00029FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96702, XrefRangeEnd = 96706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002BE14 File Offset: 0x0002A014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96706, XrefRangeEnd = 96710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0002BE44 File Offset: 0x0002A044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96710, XrefRangeEnd = 96716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleTextShadow.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00006484 File Offset: 0x00004684
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleTextShadow>.NativeClassPtr, ref this));
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0002BE70 File Offset: 0x0002A070
		public static bool operator !=(StyleTextShadow lhs, StyleTextShadow rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0002BE8C File Offset: 0x0002A08C
		public static implicit operator StyleTextShadow(StyleKeyword keyword)
		{
			return new StyleTextShadow(keyword);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0002BEA4 File Offset: 0x0002A0A4
		public static implicit operator StyleTextShadow(TextShadow v)
		{
			return new StyleTextShadow(v);
		}

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyword;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_TextShadow_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Virtual_Final_New_get_StyleKeyword_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StyleTextShadow_StyleTextShadow_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StyleTextShadow_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000540 RID: 1344
		[FieldOffset(0)]
		public StyleKeyword m_Keyword;

		// Token: 0x04000541 RID: 1345
		[FieldOffset(4)]
		public TextShadow m_Value;
	}
}
