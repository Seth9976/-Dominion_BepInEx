using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	public class TMP_ColorGradient : ScriptableObject
	{
		// Token: 0x0600037D RID: 893 RVA: 0x00014CF0 File Offset: 0x00012EF0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ColorGradient()
		{
			Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ColorGradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr);
			TMP_ColorGradient.NativeFieldInfoPtr_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "colorMode");
			TMP_ColorGradient.NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "topLeft");
			TMP_ColorGradient.NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "topRight");
			TMP_ColorGradient.NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "bottomLeft");
			TMP_ColorGradient.NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "bottomRight");
			TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "k_DefaultColorMode");
			TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, "k_DefaultColor");
			TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, 100663605);
			TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, 100663606);
			TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr, 100663607);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00014DE8 File Offset: 0x00012FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137662, XrefRangeEnd = 137670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ColorGradient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00014E24 File Offset: 0x00013024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137670, XrefRangeEnd = 137671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ColorGradient(Color color)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00014E6C File Offset: 0x0001306C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137671, XrefRangeEnd = 137672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ColorGradient>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ColorGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00003CB1 File Offset: 0x00001EB1
		public TMP_ColorGradient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00014EE0 File Offset: 0x000130E0
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00003CBA File Offset: 0x00001EBA
		public unsafe ColorMode colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_colorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_colorMode)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00014F08 File Offset: 0x00013108
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00003CD5 File Offset: 0x00001ED5
		public unsafe Color topLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topLeft)) = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00014F30 File Offset: 0x00013130
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00003CF0 File Offset: 0x00001EF0
		public unsafe Color topRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_topRight)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00014F58 File Offset: 0x00013158
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00003D0B File Offset: 0x00001F0B
		public unsafe Color bottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomLeft)) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00014F80 File Offset: 0x00013180
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00003D26 File Offset: 0x00001F26
		public unsafe Color bottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ColorGradient.NativeFieldInfoPtr_bottomRight)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00014FA8 File Offset: 0x000131A8
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00003D41 File Offset: 0x00001F41
		public unsafe static ColorMode k_DefaultColorMode
		{
			get
			{
				ColorMode colorMode;
				IL2CPP.il2cpp_field_static_get_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColorMode, (void*)(&colorMode));
				return colorMode;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColorMode, (void*)(&value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00014FC4 File Offset: 0x000131C4
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00003D4F File Offset: 0x00001F4F
		public unsafe static Color k_DefaultColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ColorGradient.NativeFieldInfoPtr_k_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr_colorMode;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr_topLeft;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_topRight;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_bottomLeft;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_bottomRight;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColorMode;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColor;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0;
	}
}
