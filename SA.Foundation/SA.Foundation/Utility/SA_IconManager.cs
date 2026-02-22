using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace SA.Foundation.Utility
{
	// Token: 0x02000014 RID: 20
	public static class SA_IconManager : global::Il2CppSystem.Object
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00005D40 File Offset: 0x00003F40
		// Note: this type is marked as 'beforefieldinit'.
		static SA_IconManager()
		{
			Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Utility", "SA_IconManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr);
			SA_IconManager.NativeFieldInfoPtr_s_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, "s_icons");
			SA_IconManager.NativeFieldInfoPtr_s_colorIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, "s_colorIcons");
			SA_IconManager.NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663394);
			SA_IconManager.NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663395);
			SA_IconManager.NativeMethodInfoPtr_GetIcon_Public_Static_Texture2D_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663396);
			SA_IconManager.NativeMethodInfoPtr_GetIconAtPath_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663397);
			SA_IconManager.NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663398);
			SA_IconManager.NativeMethodInfoPtr_ResizeTexture_Public_Static_Texture2D_Texture2D_ImageFilterMode_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663399);
			SA_IconManager.NativeMethodInfoPtr_Resize_Public_Static_Texture2D_Texture2D_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663400);
			SA_IconManager.NativeMethodInfoPtr_GetColorFromHtml_Public_Static_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663401);
			SA_IconManager.NativeMethodInfoPtr_GetColorFromHtml_Public_Static_Color_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663402);
			SA_IconManager.NativeMethodInfoPtr_getPixel_Private_Static_Color_Texture2D_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663403);
			SA_IconManager.NativeMethodInfoPtr_rot_x_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663404);
			SA_IconManager.NativeMethodInfoPtr_rot_y_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_IconManager>.NativeClassPtr, 100663405);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005E88 File Offset: 0x00004088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98905, XrefRangeEnd = 98914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D GetIconFromHtmlColorString(string htmlString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005ECC File Offset: 0x000040CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98914, XrefRangeEnd = 98919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D GetIconFromHtmlColorString(string htmlString, Color fallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005F20 File Offset: 0x00004120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98943, RefRangeEnd = 98945, XrefRangeStart = 98919, XrefRangeEnd = 98943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D GetIcon(Color color, int width = 1, int height = 1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_GetIcon_Public_Static_Texture2D_Color_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005F7C File Offset: 0x0000417C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98976, RefRangeEnd = 98977, XrefRangeStart = 98945, XrefRangeEnd = 98976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D GetIconAtPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_GetIconAtPath_Public_Static_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005FC0 File Offset: 0x000041C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98995, RefRangeEnd = 98996, XrefRangeStart = 98977, XrefRangeEnd = 98995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D Rotate(Texture2D tex, float angle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00006014 File Offset: 0x00004214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98996, XrefRangeEnd = 99031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D ResizeTexture(Texture2D pSource, SA_IconManager.ImageFilterMode pFilterMode, float pScale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pSource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pFilterMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_ResizeTexture_Public_Static_Texture2D_Texture2D_ImageFilterMode_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00006074 File Offset: 0x00004274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99031, XrefRangeEnd = 99047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D Resize(Texture2D source, int newWidth, int newHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_Resize_Public_Static_Texture2D_Texture2D_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000060D4 File Offset: 0x000042D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99047, XrefRangeEnd = 99052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColorFromHtml(string htmlString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_GetColorFromHtml_Public_Static_Color_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00006118 File Offset: 0x00004318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99052, XrefRangeEnd = 99053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColorFromHtml(string htmlString, Color fallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_GetColorFromHtml_Public_Static_Color_String_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006168 File Offset: 0x00004368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99058, RefRangeEnd = 99060, XrefRangeStart = 99053, XrefRangeEnd = 99058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color getPixel(Texture2D tex, float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_getPixel_Private_Static_Color_Texture2D_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000061C8 File Offset: 0x000043C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99060, XrefRangeEnd = 99062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float rot_x(float angle, float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_rot_x_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006224 File Offset: 0x00004424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99062, XrefRangeEnd = 99064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float rot_y(float angle, float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_IconManager.NativeMethodInfoPtr_rot_y_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000021B0 File Offset: 0x000003B0
		public SA_IconManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00006280 File Offset: 0x00004480
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000021B9 File Offset: 0x000003B9
		public unsafe static Dictionary<string, Texture2D> s_icons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_IconManager.NativeFieldInfoPtr_s_icons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_IconManager.NativeFieldInfoPtr_s_icons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000062A8 File Offset: 0x000044A8
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000021CB File Offset: 0x000003CB
		public unsafe static Dictionary<float, Texture2D> s_colorIcons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_IconManager.NativeFieldInfoPtr_s_colorIcons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<float, Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_IconManager.NativeFieldInfoPtr_s_colorIcons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_s_icons;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_s_colorIcons;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_Color_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Public_Static_Texture2D_Color_Int32_Int32_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_GetIconAtPath_Public_Static_Texture2D_String_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_ResizeTexture_Public_Static_Texture2D_Texture2D_ImageFilterMode_Single_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Static_Texture2D_Texture2D_Int32_Int32_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_GetColorFromHtml_Public_Static_Color_String_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_GetColorFromHtml_Public_Static_Color_String_Color_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_getPixel_Private_Static_Color_Texture2D_Single_Single_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_rot_x_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_rot_y_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x0200004A RID: 74
		public enum ImageFilterMode
		{
			// Token: 0x040002EB RID: 747
			Nearest,
			// Token: 0x040002EC RID: 748
			Biliner,
			// Token: 0x040002ED RID: 749
			Average
		}
	}
}
