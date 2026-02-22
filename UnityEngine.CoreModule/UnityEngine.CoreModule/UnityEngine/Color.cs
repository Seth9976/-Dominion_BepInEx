using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200007F RID: 127
	[StructLayout(2)]
	public struct Color
	{
		// Token: 0x06000C6E RID: 3182 RVA: 0x00034C74 File Offset: 0x00032E74
		// Note: this type is marked as 'beforefieldinit'.
		static Color()
		{
			Il2CppClassPointerStore<Color>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Color");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color>.NativeClassPtr);
			Color.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "r");
			Color.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "g");
			Color.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "b");
			Color.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "a");
			Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663972);
			Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663973);
			Color.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663974);
			Color.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663975);
			Color.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663976);
			Color.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663977);
			Color.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663978);
			Color.NativeMethodInfoPtr_op_Addition_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663979);
			Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663980);
			Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663981);
			Color.NativeMethodInfoPtr_op_Division_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663982);
			Color.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663983);
			Color.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663984);
			Color.NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663985);
			Color.NativeMethodInfoPtr_RGBMultiplied_Internal_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663986);
			Color.NativeMethodInfoPtr_get_red_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663987);
			Color.NativeMethodInfoPtr_get_green_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663988);
			Color.NativeMethodInfoPtr_get_blue_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663989);
			Color.NativeMethodInfoPtr_get_white_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663990);
			Color.NativeMethodInfoPtr_get_black_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663991);
			Color.NativeMethodInfoPtr_get_yellow_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663992);
			Color.NativeMethodInfoPtr_get_cyan_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663993);
			Color.NativeMethodInfoPtr_get_clear_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663994);
			Color.NativeMethodInfoPtr_get_linear_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663995);
			Color.NativeMethodInfoPtr_get_maxColorComponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663996);
			Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663997);
			Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100663998);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00034F10 File Offset: 0x00033110
		[CallerCount(113)]
		[CachedScanResults(RefRangeStart = 61474, RefRangeEnd = 61587, XrefRangeStart = 61474, XrefRangeEnd = 61587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color(float r, float g, float b, float a)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00034F6C File Offset: 0x0003316C
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 64830, RefRangeEnd = 64873, XrefRangeStart = 64830, XrefRangeEnd = 64830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color(float r, float g, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00034FBC File Offset: 0x000331BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64873, XrefRangeEnd = 64874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00034FE8 File Offset: 0x000331E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64912, RefRangeEnd = 64913, XrefRangeStart = 64874, XrefRangeEnd = 64912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00035038 File Offset: 0x00033238
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 64915, RefRangeEnd = 64924, XrefRangeStart = 64913, XrefRangeEnd = 64915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00035068 File Offset: 0x00033268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64924, XrefRangeEnd = 64931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x000350AC File Offset: 0x000332AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64935, RefRangeEnd = 64936, XrefRangeStart = 64931, XrefRangeEnd = 64935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Color other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000350EC File Offset: 0x000332EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64936, RefRangeEnd = 64937, XrefRangeStart = 64936, XrefRangeEnd = 64936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color operator +(Color a, Color b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Addition_Public_Static_Color_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00035138 File Offset: 0x00033338
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 64937, RefRangeEnd = 64949, XrefRangeStart = 64937, XrefRangeEnd = 64937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color operator *(Color a, Color b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00035184 File Offset: 0x00033384
		[CallerCount(0)]
		public unsafe static Color operator *(Color a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x000351D0 File Offset: 0x000333D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64949, RefRangeEnd = 64950, XrefRangeStart = 64949, XrefRangeEnd = 64949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color operator /(Color a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Division_Public_Static_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0003521C File Offset: 0x0003341C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 64952, RefRangeEnd = 64970, XrefRangeStart = 64950, XrefRangeEnd = 64952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Color lhs, Color rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00035268 File Offset: 0x00033468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64970, XrefRangeEnd = 64972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Color lhs, Color rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000352B4 File Offset: 0x000334B4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 64973, RefRangeEnd = 64985, XrefRangeStart = 64972, XrefRangeEnd = 64973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color Lerp(Color a, Color b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00035310 File Offset: 0x00033510
		[CallerCount(0)]
		public unsafe Color RGBMultiplied(float multiplier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiplier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_RGBMultiplied_Internal_Color_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00035350 File Offset: 0x00033550
		public unsafe static Color red
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 64985, RefRangeEnd = 64990, XrefRangeStart = 64985, XrefRangeEnd = 64985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_red_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00035380 File Offset: 0x00033580
		public unsafe static Color green
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 64990, RefRangeEnd = 64992, XrefRangeStart = 64990, XrefRangeEnd = 64990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_green_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x000353B0 File Offset: 0x000335B0
		public unsafe static Color blue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 64992, RefRangeEnd = 64993, XrefRangeStart = 64992, XrefRangeEnd = 64992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_blue_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x000353E0 File Offset: 0x000335E0
		public unsafe static Color white
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 64993, RefRangeEnd = 65022, XrefRangeStart = 64993, XrefRangeEnd = 64993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_white_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00035410 File Offset: 0x00033610
		public unsafe static Color black
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 65022, RefRangeEnd = 65033, XrefRangeStart = 65022, XrefRangeEnd = 65022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_black_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00035440 File Offset: 0x00033640
		public unsafe static Color yellow
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 65033, RefRangeEnd = 65035, XrefRangeStart = 65033, XrefRangeEnd = 65033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_yellow_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00035470 File Offset: 0x00033670
		public unsafe static Color cyan
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 65035, RefRangeEnd = 65036, XrefRangeStart = 65035, XrefRangeEnd = 65035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_cyan_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x000354A0 File Offset: 0x000336A0
		public unsafe static Color clear
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 61594, RefRangeEnd = 61618, XrefRangeStart = 61594, XrefRangeEnd = 61618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_clear_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x000354D0 File Offset: 0x000336D0
		public unsafe Color linear
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 65042, RefRangeEnd = 65043, XrefRangeStart = 65036, XrefRangeEnd = 65042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_linear_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00035500 File Offset: 0x00033700
		public unsafe float maxColorComponent
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_maxColorComponent_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00035530 File Offset: 0x00033730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65043, XrefRangeEnd = 65044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector4(Color c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00035570 File Offset: 0x00033770
		[CallerCount(0)]
		public unsafe static implicit operator Color(Vector4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000090B2 File Offset: 0x000072B2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Color>.NativeClassPtr, ref this));
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000355B0 File Offset: 0x000337B0
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000355CC File Offset: 0x000337CC
		public static Color operator -(Color a, Color b)
		{
			return new Color(a.r - b.r, a.g - b.g, a.b - b.b, a.a - b.a);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00035618 File Offset: 0x00033818
		public static Color operator *(float b, Color a)
		{
			return new Color(a.r * b, a.g * b, a.b * b, a.a * b);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00035650 File Offset: 0x00033850
		public static Color LerpUnclamped(Color a, Color b, float t)
		{
			return new Color(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x000356C0 File Offset: 0x000338C0
		public Color AlphaMultiplied(float multiplier)
		{
			return new Color(this.r, this.g, this.b, this.a * multiplier);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000356F4 File Offset: 0x000338F4
		public Color RGBMultiplied(Color multiplier)
		{
			return new Color(this.r * multiplier.r, this.g * multiplier.g, this.b * multiplier.b, this.a);
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00035738 File Offset: 0x00033938
		public static Color magenta
		{
			get
			{
				return new Color(1f, 0f, 1f, 1f);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00035764 File Offset: 0x00033964
		public static Color gray
		{
			get
			{
				return new Color(0.5f, 0.5f, 0.5f, 1f);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00035790 File Offset: 0x00033990
		public static Color grey
		{
			get
			{
				return new Color(0.5f, 0.5f, 0.5f, 1f);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x000357BC File Offset: 0x000339BC
		public float grayscale
		{
			get
			{
				return 0.299f * this.r + 0.587f * this.g + 0.114f * this.b;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x000357F4 File Offset: 0x000339F4
		public Color gamma
		{
			get
			{
				return new Color(Mathf.LinearToGammaSpace(this.r), Mathf.LinearToGammaSpace(this.g), Mathf.LinearToGammaSpace(this.b), this.a);
			}
		}

		// Token: 0x170002BD RID: 701
		public float this[int index]
		{
			get
			{
				float num;
				switch (index)
				{
				case 0:
					num = this.r;
					break;
				case 1:
					num = this.g;
					break;
				case 2:
					num = this.b;
					break;
				case 3:
					num = this.a;
					break;
				default:
					throw new IndexOutOfRangeException(String.Concat("Invalid Color index(", index.ToString(), ")!"));
				}
				return num;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.r = value;
					break;
				case 1:
					this.g = value;
					break;
				case 2:
					this.b = value;
					break;
				case 3:
					this.a = value;
					break;
				default:
					throw new IndexOutOfRangeException(String.Concat("Invalid Color index(", index.ToString(), ")!"));
				}
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0003590C File Offset: 0x00033B0C
		public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V)
		{
			bool flag = rgbColor.b > rgbColor.g && rgbColor.b > rgbColor.r;
			if (flag)
			{
				Color.RGBToHSVHelper(4f, rgbColor.b, rgbColor.r, rgbColor.g, out H, out S, out V);
			}
			else
			{
				bool flag2 = rgbColor.g > rgbColor.r;
				if (flag2)
				{
					Color.RGBToHSVHelper(2f, rgbColor.g, rgbColor.b, rgbColor.r, out H, out S, out V);
				}
				else
				{
					Color.RGBToHSVHelper(0f, rgbColor.r, rgbColor.g, rgbColor.b, out H, out S, out V);
				}
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x000359B4 File Offset: 0x00033BB4
		public static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V)
		{
			V = dominantcolor;
			bool flag = V != 0f;
			if (flag)
			{
				bool flag2 = colorone > colortwo;
				float num;
				if (flag2)
				{
					num = colortwo;
				}
				else
				{
					num = colorone;
				}
				float num2 = V - num;
				bool flag3 = num2 != 0f;
				if (flag3)
				{
					S = num2 / V;
					H = offset + (colorone - colortwo) / num2;
				}
				else
				{
					S = 0f;
					H = offset + (colorone - colortwo);
				}
				H /= 6f;
				bool flag4 = H < 0f;
				if (flag4)
				{
					H += 1f;
				}
			}
			else
			{
				S = 0f;
				H = 0f;
			}
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00035A68 File Offset: 0x00033C68
		public static Color HSVToRGB(float H, float S, float V)
		{
			return Color.HSVToRGB(H, S, V, true);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00035A84 File Offset: 0x00033C84
		public static Color HSVToRGB(float H, float S, float V, bool hdr)
		{
			Color white = Color.white;
			bool flag = S == 0f;
			if (flag)
			{
				white.r = V;
				white.g = V;
				white.b = V;
			}
			else
			{
				bool flag2 = V == 0f;
				if (flag2)
				{
					white.r = 0f;
					white.g = 0f;
					white.b = 0f;
				}
				else
				{
					white.r = 0f;
					white.g = 0f;
					white.b = 0f;
					float num = H * 6f;
					int num2 = (int)Mathf.Floor(num);
					float num3 = num - (float)num2;
					float num4 = V * (1f - S);
					float num5 = V * (1f - S * num3);
					float num6 = V * (1f - S * (1f - num3));
					switch (num2)
					{
					case -1:
						white.r = V;
						white.g = num4;
						white.b = num5;
						break;
					case 0:
						white.r = V;
						white.g = num6;
						white.b = num4;
						break;
					case 1:
						white.r = num5;
						white.g = V;
						white.b = num4;
						break;
					case 2:
						white.r = num4;
						white.g = V;
						white.b = num6;
						break;
					case 3:
						white.r = num4;
						white.g = num5;
						white.b = V;
						break;
					case 4:
						white.r = num6;
						white.g = num4;
						white.b = V;
						break;
					case 5:
						white.r = V;
						white.g = num4;
						white.b = num5;
						break;
					case 6:
						white.r = V;
						white.g = num6;
						white.b = num4;
						break;
					}
					bool flag3 = !hdr;
					if (flag3)
					{
						white.r = Mathf.Clamp(white.r, 0f, 1f);
						white.g = Mathf.Clamp(white.g, 0f, 1f);
						white.b = Mathf.Clamp(white.b, 0f, 1f);
					}
				}
			}
			return white;
		}

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_r;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr_g;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Color_Color_Color_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Color_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Single_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Color_Color_Single_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Color_Color_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Color_Color_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_RGBMultiplied_Internal_Color_Single_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_get_red_Public_Static_get_Color_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_get_green_Public_Static_get_Color_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_get_blue_Public_Static_get_Color_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_get_white_Public_Static_get_Color_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_get_black_Public_Static_get_Color_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_get_yellow_Public_Static_get_Color_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_get_cyan_Public_Static_get_Color_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_get_clear_Public_Static_get_Color_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_get_linear_Public_get_Color_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_get_maxColorComponent_Public_get_Single_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Color_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Vector4_0;

		// Token: 0x04000A13 RID: 2579
		[FieldOffset(0)]
		public float r;

		// Token: 0x04000A14 RID: 2580
		[FieldOffset(4)]
		public float g;

		// Token: 0x04000A15 RID: 2581
		[FieldOffset(8)]
		public float b;

		// Token: 0x04000A16 RID: 2582
		[FieldOffset(12)]
		public float a;
	}
}
