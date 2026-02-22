using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace SA.Common.Util
{
	// Token: 0x02000311 RID: 785
	public static class IconManager : global::Il2CppSystem.Object
	{
		// Token: 0x06002D4A RID: 11594 RVA: 0x000C1370 File Offset: 0x000BF570
		// Note: this type is marked as 'beforefieldinit'.
		static IconManager()
		{
			Il2CppClassPointerStore<IconManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Util", "IconManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconManager>.NativeClassPtr);
			IconManager.NativeFieldInfoPtr_s_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconManager>.NativeClassPtr, "s_icons");
			IconManager.NativeFieldInfoPtr_s_colorIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconManager>.NativeClassPtr, "s_colorIcons");
			IconManager.NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconManager>.NativeClassPtr, 100669210);
			IconManager.NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconManager>.NativeClassPtr, 100669211);
			IconManager.NativeMethodInfoPtr_GetIcon_Public_Static_Texture2D_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconManager>.NativeClassPtr, 100669212);
			IconManager.NativeMethodInfoPtr_GetIconAtPath_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconManager>.NativeClassPtr, 100669213);
			IconManager.NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconManager>.NativeClassPtr, 100669214);
			IconManager.NativeMethodInfoPtr_getPixel_Private_Static_Color_Texture2D_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconManager>.NativeClassPtr, 100669215);
			IconManager.NativeMethodInfoPtr_rot_x_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconManager>.NativeClassPtr, 100669216);
			IconManager.NativeMethodInfoPtr_rot_y_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconManager>.NativeClassPtr, 100669217);
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x000C1468 File Offset: 0x000BF668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212261, XrefRangeEnd = 212270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D GetIconFromHtmlColorString(string htmlString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconManager.NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x000C14AC File Offset: 0x000BF6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212270, XrefRangeEnd = 212274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconManager.NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x000C1500 File Offset: 0x000BF700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212298, RefRangeEnd = 212300, XrefRangeStart = 212274, XrefRangeEnd = 212298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconManager.NativeMethodInfoPtr_GetIcon_Public_Static_Texture2D_Color_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x000C155C File Offset: 0x000BF75C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212331, RefRangeEnd = 212332, XrefRangeStart = 212300, XrefRangeEnd = 212331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D GetIconAtPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconManager.NativeMethodInfoPtr_GetIconAtPath_Public_Static_Texture2D_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x000C15A0 File Offset: 0x000BF7A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212350, RefRangeEnd = 212351, XrefRangeStart = 212332, XrefRangeEnd = 212350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconManager.NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x000C15F4 File Offset: 0x000BF7F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99058, RefRangeEnd = 99060, XrefRangeStart = 99058, XrefRangeEnd = 99060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconManager.NativeMethodInfoPtr_getPixel_Private_Static_Color_Texture2D_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x000C1654 File Offset: 0x000BF854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconManager.NativeMethodInfoPtr_rot_x_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x000C16B0 File Offset: 0x000BF8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconManager.NativeMethodInfoPtr_rot_y_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x00011942 File Offset: 0x0000FB42
		public IconManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x000C170C File Offset: 0x000BF90C
		// (set) Token: 0x06002D55 RID: 11605 RVA: 0x0001194B File Offset: 0x0000FB4B
		public unsafe static Dictionary<string, Texture2D> s_icons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IconManager.NativeFieldInfoPtr_s_icons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IconManager.NativeFieldInfoPtr_s_icons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x000C1734 File Offset: 0x000BF934
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x0001195D File Offset: 0x0000FB5D
		public unsafe static Dictionary<float, Texture2D> s_colorIcons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IconManager.NativeFieldInfoPtr_s_colorIcons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<float, Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IconManager.NativeFieldInfoPtr_s_colorIcons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B48 RID: 11080
		private static readonly IntPtr NativeFieldInfoPtr_s_icons;

		// Token: 0x04002B49 RID: 11081
		private static readonly IntPtr NativeFieldInfoPtr_s_colorIcons;

		// Token: 0x04002B4A RID: 11082
		private static readonly IntPtr NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_0;

		// Token: 0x04002B4B RID: 11083
		private static readonly IntPtr NativeMethodInfoPtr_GetIconFromHtmlColorString_Public_Static_Texture2D_String_Color_0;

		// Token: 0x04002B4C RID: 11084
		private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Public_Static_Texture2D_Color_Int32_Int32_0;

		// Token: 0x04002B4D RID: 11085
		private static readonly IntPtr NativeMethodInfoPtr_GetIconAtPath_Public_Static_Texture2D_String_0;

		// Token: 0x04002B4E RID: 11086
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0;

		// Token: 0x04002B4F RID: 11087
		private static readonly IntPtr NativeMethodInfoPtr_getPixel_Private_Static_Color_Texture2D_Single_Single_0;

		// Token: 0x04002B50 RID: 11088
		private static readonly IntPtr NativeMethodInfoPtr_rot_x_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04002B51 RID: 11089
		private static readonly IntPtr NativeMethodInfoPtr_rot_y_Private_Static_Single_Single_Single_Single_0;
	}
}
