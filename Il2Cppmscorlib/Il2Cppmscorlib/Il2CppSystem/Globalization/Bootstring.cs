using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000251 RID: 593
	public class Bootstring : Object
	{
		// Token: 0x06002924 RID: 10532 RVA: 0x000D6594 File Offset: 0x000D4794
		// Note: this type is marked as 'beforefieldinit'.
		static Bootstring()
		{
			Il2CppClassPointerStore<Bootstring>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "Bootstring");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bootstring>.NativeClassPtr);
			Bootstring.NativeFieldInfoPtr_delimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "delimiter");
			Bootstring.NativeFieldInfoPtr_base_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "base_num");
			Bootstring.NativeFieldInfoPtr_tmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "tmin");
			Bootstring.NativeFieldInfoPtr_tmax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "tmax");
			Bootstring.NativeFieldInfoPtr_skew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "skew");
			Bootstring.NativeFieldInfoPtr_damp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "damp");
			Bootstring.NativeFieldInfoPtr_initial_bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "initial_bias");
			Bootstring.NativeFieldInfoPtr_initial_n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "initial_n");
			Bootstring.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100669883);
			Bootstring.NativeMethodInfoPtr_Encode_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100669884);
			Bootstring.NativeMethodInfoPtr_EncodeDigit_Private_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100669885);
			Bootstring.NativeMethodInfoPtr_DecodeDigit_Private_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100669886);
			Bootstring.NativeMethodInfoPtr_Adapt_Private_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100669887);
			Bootstring.NativeMethodInfoPtr_Decode_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100669888);
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000D66DC File Offset: 0x000D48DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329896, RefRangeEnd = 329897, XrefRangeStart = 329895, XrefRangeEnd = 329896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bootstring>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delimiter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tmin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tmax;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skew;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damp;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialBias;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialN;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000D6788 File Offset: 0x000D4988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329935, RefRangeEnd = 329936, XrefRangeStart = 329897, XrefRangeEnd = 329935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Encode(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_Encode_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000D67E0 File Offset: 0x000D49E0
		[CallerCount(0)]
		public unsafe char EncodeDigit(int d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_EncodeDigit_Private_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000D682C File Offset: 0x000D4A2C
		[CallerCount(0)]
		public unsafe int DecodeDigit(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_DecodeDigit_Private_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000D6878 File Offset: 0x000D4A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329936, XrefRangeEnd = 329937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Adapt(int delta, int numPoints, bool firstTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_Adapt_Private_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000D68E0 File Offset: 0x000D4AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329953, RefRangeEnd = 329954, XrefRangeStart = 329937, XrefRangeEnd = 329953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Decode(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_Decode_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x0000E45E File Offset: 0x0000C65E
		public Bootstring(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x000D6938 File Offset: 0x000D4B38
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x0000E467 File Offset: 0x0000C667
		public unsafe char delimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_delimiter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_delimiter)) = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x000D6960 File Offset: 0x000D4B60
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x0000E482 File Offset: 0x0000C682
		public unsafe int base_num
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_base_num);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_base_num)) = value;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x000D6988 File Offset: 0x000D4B88
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x0000E49D File Offset: 0x0000C69D
		public unsafe int tmin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmin)) = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x000D69B0 File Offset: 0x000D4BB0
		// (set) Token: 0x06002933 RID: 10547 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
		public unsafe int tmax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmax)) = value;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x000D69D8 File Offset: 0x000D4BD8
		// (set) Token: 0x06002935 RID: 10549 RVA: 0x0000E4D3 File Offset: 0x0000C6D3
		public unsafe int skew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_skew);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_skew)) = value;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x000D6A00 File Offset: 0x000D4C00
		// (set) Token: 0x06002937 RID: 10551 RVA: 0x0000E4EE File Offset: 0x0000C6EE
		public unsafe int damp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_damp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_damp)) = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x000D6A28 File Offset: 0x000D4C28
		// (set) Token: 0x06002939 RID: 10553 RVA: 0x0000E509 File Offset: 0x0000C709
		public unsafe int initial_bias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_bias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_bias)) = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x000D6A50 File Offset: 0x000D4C50
		// (set) Token: 0x0600293B RID: 10555 RVA: 0x0000E524 File Offset: 0x0000C724
		public unsafe int initial_n
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_n);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_n)) = value;
			}
		}

		// Token: 0x04002453 RID: 9299
		private static readonly IntPtr NativeFieldInfoPtr_delimiter;

		// Token: 0x04002454 RID: 9300
		private static readonly IntPtr NativeFieldInfoPtr_base_num;

		// Token: 0x04002455 RID: 9301
		private static readonly IntPtr NativeFieldInfoPtr_tmin;

		// Token: 0x04002456 RID: 9302
		private static readonly IntPtr NativeFieldInfoPtr_tmax;

		// Token: 0x04002457 RID: 9303
		private static readonly IntPtr NativeFieldInfoPtr_skew;

		// Token: 0x04002458 RID: 9304
		private static readonly IntPtr NativeFieldInfoPtr_damp;

		// Token: 0x04002459 RID: 9305
		private static readonly IntPtr NativeFieldInfoPtr_initial_bias;

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeFieldInfoPtr_initial_n;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_String_String_Int32_0;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeMethodInfoPtr_EncodeDigit_Private_Char_Int32_0;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeMethodInfoPtr_DecodeDigit_Private_Int32_Char_0;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeMethodInfoPtr_Adapt_Private_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_String_String_Int32_0;
	}
}
