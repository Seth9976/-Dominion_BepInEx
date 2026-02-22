using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000080 RID: 128
	[StructLayout(2)]
	public struct Color32
	{
		// Token: 0x06000C9C RID: 3228 RVA: 0x00035D00 File Offset: 0x00033F00
		// Note: this type is marked as 'beforefieldinit'.
		static Color32()
		{
			Il2CppClassPointerStore<Color32>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Color32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color32>.NativeClassPtr);
			Color32.NativeFieldInfoPtr_rgba = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "rgba");
			Color32.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "r");
			Color32.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "g");
			Color32.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "b");
			Color32.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "a");
			Color32.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100663999);
			Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100664000);
			Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100664001);
			Color32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100664002);
			Color32.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100664003);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00035DF8 File Offset: 0x00033FF8
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 65044, RefRangeEnd = 65081, XrefRangeStart = 65044, XrefRangeEnd = 65044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32(byte r, byte g, byte b, byte a)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00035E54 File Offset: 0x00034054
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 65089, RefRangeEnd = 65185, XrefRangeStart = 65081, XrefRangeEnd = 65089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Color32(Color c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00035E94 File Offset: 0x00034094
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 65185, RefRangeEnd = 65236, XrefRangeStart = 65185, XrefRangeEnd = 65185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Color(Color32 c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00035ED4 File Offset: 0x000340D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65236, XrefRangeEnd = 65237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00035F00 File Offset: 0x00034100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65272, RefRangeEnd = 65273, XrefRangeStart = 65237, XrefRangeEnd = 65272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000090C4 File Offset: 0x000072C4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Color32>.NativeClassPtr, ref this));
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00035F50 File Offset: 0x00034150
		public static Color32 Lerp(Color32 a, Color32 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00035FD4 File Offset: 0x000341D4
		public static Color32 LerpUnclamped(Color32 a, Color32 b, float t)
		{
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x170002BE RID: 702
		public byte this[int index]
		{
			get
			{
				byte b;
				switch (index)
				{
				case 0:
					b = this.r;
					break;
				case 1:
					b = this.g;
					break;
				case 2:
					b = this.b;
					break;
				case 3:
					b = this.a;
					break;
				default:
					throw new IndexOutOfRangeException(String.Concat("Invalid Color32 index(", index.ToString(), ")!"));
				}
				return b;
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
					throw new IndexOutOfRangeException(String.Concat("Invalid Color32 index(", index.ToString(), ")!"));
				}
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00036128 File Offset: 0x00034328
		public bool InternalEquals(Color32 other)
		{
			return this.rgba == other.rgba;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00036148 File Offset: 0x00034348
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_rgba;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr_r;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_g;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000A21 RID: 2593
		[FieldOffset(0)]
		public int rgba;

		// Token: 0x04000A22 RID: 2594
		[FieldOffset(0)]
		public byte r;

		// Token: 0x04000A23 RID: 2595
		[FieldOffset(1)]
		public byte g;

		// Token: 0x04000A24 RID: 2596
		[FieldOffset(2)]
		public byte b;

		// Token: 0x04000A25 RID: 2597
		[FieldOffset(3)]
		public byte a;
	}
}
