using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000036 RID: 54
	[StructLayout(2)]
	public struct TextShadow
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00014A24 File Offset: 0x00012C24
		// Note: this type is marked as 'beforefieldinit'.
		static TextShadow()
		{
			Il2CppClassPointerStore<TextShadow>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextShadow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextShadow>.NativeClassPtr);
			TextShadow.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, "offset");
			TextShadow.NativeFieldInfoPtr_blurRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, "blurRadius");
			TextShadow.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, "color");
			TextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100663522);
			TextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100663523);
			TextShadow.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100663524);
			TextShadow.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextShadow_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100663525);
			TextShadow.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100663526);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00014AF4 File Offset: 0x00012CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92344, XrefRangeEnd = 92348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00014B38 File Offset: 0x00012D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92349, RefRangeEnd = 92351, XrefRangeStart = 92348, XrefRangeEnd = 92349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TextShadow other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextShadow_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00014B78 File Offset: 0x00012D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92351, XrefRangeEnd = 92354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00014BA8 File Offset: 0x00012DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92354, XrefRangeEnd = 92355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TextShadow style1, TextShadow style2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextShadow_TextShadow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00014BF4 File Offset: 0x00012DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92355, XrefRangeEnd = 92367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000366E File Offset: 0x0000186E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, ref this));
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00014C20 File Offset: 0x00012E20
		public static bool operator !=(TextShadow style1, TextShadow style2)
		{
			return !(style1 == style2);
		}

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_blurRadius;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextShadow_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextShadow_TextShadow_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001AB RID: 427
		[FieldOffset(0)]
		public Vector2 offset;

		// Token: 0x040001AC RID: 428
		[FieldOffset(8)]
		public float blurRadius;

		// Token: 0x040001AD RID: 429
		[FieldOffset(12)]
		public Color color;
	}
}
