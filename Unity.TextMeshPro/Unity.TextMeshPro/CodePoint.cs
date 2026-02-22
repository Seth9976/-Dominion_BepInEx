using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x0200004C RID: 76
	public static class CodePoint : Object
	{
		// Token: 0x0600081E RID: 2078 RVA: 0x00025650 File Offset: 0x00023850
		// Note: this type is marked as 'beforefieldinit'.
		static CodePoint()
		{
			Il2CppClassPointerStore<CodePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "CodePoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePoint>.NativeClassPtr);
			CodePoint.NativeFieldInfoPtr_SPACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "SPACE");
			CodePoint.NativeFieldInfoPtr_DOUBLE_QUOTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "DOUBLE_QUOTE");
			CodePoint.NativeFieldInfoPtr_NUMBER_SIGN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "NUMBER_SIGN");
			CodePoint.NativeFieldInfoPtr_PERCENTAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "PERCENTAGE");
			CodePoint.NativeFieldInfoPtr_PLUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "PLUS");
			CodePoint.NativeFieldInfoPtr_MINUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "MINUS");
			CodePoint.NativeFieldInfoPtr_PERIOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "PERIOD");
			CodePoint.NativeFieldInfoPtr_HYPHEN_MINUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "HYPHEN_MINUS");
			CodePoint.NativeFieldInfoPtr_SOFT_HYPHEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "SOFT_HYPHEN");
			CodePoint.NativeFieldInfoPtr_HYPHEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "HYPHEN");
			CodePoint.NativeFieldInfoPtr_NON_BREAKING_HYPHEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "NON_BREAKING_HYPHEN");
			CodePoint.NativeFieldInfoPtr_ZERO_WIDTH_SPACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "ZERO_WIDTH_SPACE");
			CodePoint.NativeFieldInfoPtr_RIGHT_SINGLE_QUOTATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "RIGHT_SINGLE_QUOTATION");
			CodePoint.NativeFieldInfoPtr_APOSTROPHE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "APOSTROPHE");
			CodePoint.NativeFieldInfoPtr_WORD_JOINER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "WORD_JOINER");
			CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "HIGH_SURROGATE_START");
			CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "HIGH_SURROGATE_END");
			CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "LOW_SURROGATE_START");
			CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "LOW_SURROGATE_END");
			CodePoint.NativeFieldInfoPtr_UNICODE_PLANE01_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePoint>.NativeClassPtr, "UNICODE_PLANE01_START");
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00005C95 File Offset: 0x00003E95
		public CodePoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00025810 File Offset: 0x00023A10
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00005C9E File Offset: 0x00003E9E
		public unsafe static uint SPACE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_SPACE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_SPACE, (void*)(&value));
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x0002582C File Offset: 0x00023A2C
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x00005CAC File Offset: 0x00003EAC
		public unsafe static uint DOUBLE_QUOTE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_DOUBLE_QUOTE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_DOUBLE_QUOTE, (void*)(&value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00025848 File Offset: 0x00023A48
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00005CBA File Offset: 0x00003EBA
		public unsafe static uint NUMBER_SIGN
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_NUMBER_SIGN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_NUMBER_SIGN, (void*)(&value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00025864 File Offset: 0x00023A64
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public unsafe static uint PERCENTAGE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_PERCENTAGE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_PERCENTAGE, (void*)(&value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00025880 File Offset: 0x00023A80
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00005CD6 File Offset: 0x00003ED6
		public unsafe static uint PLUS
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_PLUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_PLUS, (void*)(&value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x0002589C File Offset: 0x00023A9C
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x00005CE4 File Offset: 0x00003EE4
		public unsafe static uint MINUS
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_MINUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_MINUS, (void*)(&value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000258B8 File Offset: 0x00023AB8
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00005CF2 File Offset: 0x00003EF2
		public unsafe static uint PERIOD
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_PERIOD, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_PERIOD, (void*)(&value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x000258D4 File Offset: 0x00023AD4
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x00005D00 File Offset: 0x00003F00
		public unsafe static uint HYPHEN_MINUS
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_HYPHEN_MINUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_HYPHEN_MINUS, (void*)(&value));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x000258F0 File Offset: 0x00023AF0
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00005D0E File Offset: 0x00003F0E
		public unsafe static uint SOFT_HYPHEN
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_SOFT_HYPHEN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_SOFT_HYPHEN, (void*)(&value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x0002590C File Offset: 0x00023B0C
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00005D1C File Offset: 0x00003F1C
		public unsafe static uint HYPHEN
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_HYPHEN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_HYPHEN, (void*)(&value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00025928 File Offset: 0x00023B28
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00005D2A File Offset: 0x00003F2A
		public unsafe static uint NON_BREAKING_HYPHEN
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_NON_BREAKING_HYPHEN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_NON_BREAKING_HYPHEN, (void*)(&value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00025944 File Offset: 0x00023B44
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00005D38 File Offset: 0x00003F38
		public unsafe static uint ZERO_WIDTH_SPACE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_ZERO_WIDTH_SPACE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_ZERO_WIDTH_SPACE, (void*)(&value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00025960 File Offset: 0x00023B60
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x00005D46 File Offset: 0x00003F46
		public unsafe static uint RIGHT_SINGLE_QUOTATION
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_RIGHT_SINGLE_QUOTATION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_RIGHT_SINGLE_QUOTATION, (void*)(&value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0002597C File Offset: 0x00023B7C
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x00005D54 File Offset: 0x00003F54
		public unsafe static uint APOSTROPHE
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_APOSTROPHE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_APOSTROPHE, (void*)(&value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00025998 File Offset: 0x00023B98
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x00005D62 File Offset: 0x00003F62
		public unsafe static uint WORD_JOINER
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_WORD_JOINER, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_WORD_JOINER, (void*)(&value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x000259B4 File Offset: 0x00023BB4
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00005D70 File Offset: 0x00003F70
		public unsafe static uint HIGH_SURROGATE_START
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_START, (void*)(&value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x000259D0 File Offset: 0x00023BD0
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x00005D7E File Offset: 0x00003F7E
		public unsafe static uint HIGH_SURROGATE_END
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_HIGH_SURROGATE_END, (void*)(&value));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000259EC File Offset: 0x00023BEC
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00005D8C File Offset: 0x00003F8C
		public unsafe static uint LOW_SURROGATE_START
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_START, (void*)(&value));
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00025A08 File Offset: 0x00023C08
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x00005D9A File Offset: 0x00003F9A
		public unsafe static uint LOW_SURROGATE_END
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_LOW_SURROGATE_END, (void*)(&value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00025A24 File Offset: 0x00023C24
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x00005DA8 File Offset: 0x00003FA8
		public unsafe static uint UNICODE_PLANE01_START
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(CodePoint.NativeFieldInfoPtr_UNICODE_PLANE01_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePoint.NativeFieldInfoPtr_UNICODE_PLANE01_START, (void*)(&value));
			}
		}

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeFieldInfoPtr_SPACE;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeFieldInfoPtr_DOUBLE_QUOTE;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeFieldInfoPtr_NUMBER_SIGN;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr_PERCENTAGE;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeFieldInfoPtr_PLUS;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr_MINUS;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr_PERIOD;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr_HYPHEN_MINUS;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr_SOFT_HYPHEN;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr_HYPHEN;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr_NON_BREAKING_HYPHEN;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr_ZERO_WIDTH_SPACE;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr_RIGHT_SINGLE_QUOTATION;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr_APOSTROPHE;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr_WORD_JOINER;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_SURROGATE_START;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_SURROGATE_END;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr_LOW_SURROGATE_START;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr_LOW_SURROGATE_END;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr_UNICODE_PLANE01_START;
	}
}
