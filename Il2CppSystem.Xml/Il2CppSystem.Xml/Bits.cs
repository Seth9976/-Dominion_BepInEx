using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200000B RID: 11
	public static class Bits : Object
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000A7F8 File Offset: 0x000089F8
		// Note: this type is marked as 'beforefieldinit'.
		static Bits()
		{
			Il2CppClassPointerStore<Bits>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Bits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bits>.NativeClassPtr);
			Bits.NativeFieldInfoPtr_MASK_0101010101010101 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0101010101010101");
			Bits.NativeFieldInfoPtr_MASK_0011001100110011 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0011001100110011");
			Bits.NativeFieldInfoPtr_MASK_0000111100001111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0000111100001111");
			Bits.NativeFieldInfoPtr_MASK_0000000011111111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0000000011111111");
			Bits.NativeFieldInfoPtr_MASK_1111111111111111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_1111111111111111");
			Bits.NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bits>.NativeClassPtr, 100663353);
			Bits.NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bits>.NativeClassPtr, 100663354);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11721, XrefRangeEnd = 11725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count(uint num)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bits.NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11733, RefRangeEnd = 11735, XrefRangeStart = 11725, XrefRangeEnd = 11733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LeastPosition(uint num)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bits.NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000240E File Offset: 0x0000060E
		public Bits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000A934 File Offset: 0x00008B34
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002417 File Offset: 0x00000617
		public unsafe static uint MASK_0101010101010101
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0101010101010101, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0101010101010101, (void*)(&value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000A950 File Offset: 0x00008B50
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002425 File Offset: 0x00000625
		public unsafe static uint MASK_0011001100110011
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0011001100110011, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0011001100110011, (void*)(&value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000A96C File Offset: 0x00008B6C
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002433 File Offset: 0x00000633
		public unsafe static uint MASK_0000111100001111
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0000111100001111, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0000111100001111, (void*)(&value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000A988 File Offset: 0x00008B88
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002441 File Offset: 0x00000641
		public unsafe static uint MASK_0000000011111111
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0000000011111111, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0000000011111111, (void*)(&value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000A9A4 File Offset: 0x00008BA4
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000244F File Offset: 0x0000064F
		public unsafe static uint MASK_1111111111111111
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_1111111111111111, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_1111111111111111, (void*)(&value));
			}
		}

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0101010101010101;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0011001100110011;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0000111100001111;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0000000011111111;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_MASK_1111111111111111;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0;
	}
}
