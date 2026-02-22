using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000081 RID: 129
	public class ColorUtility : Object
	{
		// Token: 0x06000CA9 RID: 3241 RVA: 0x00036164 File Offset: 0x00034364
		// Note: this type is marked as 'beforefieldinit'.
		static ColorUtility()
		{
			Il2CppClassPointerStore<ColorUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr);
			ColorUtility.NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100664004);
			ColorUtility.NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100664005);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x000361BC File Offset: 0x000343BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65273, XrefRangeEnd = 65275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoTryParseHtmlColor(string htmlString, out Color32 color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0003620C File Offset: 0x0003440C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 65277, RefRangeEnd = 65281, XrefRangeStart = 65275, XrefRangeEnd = 65277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseHtmlString(string htmlString, out Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000090D6 File Offset: 0x000072D6
		public ColorUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x000090DF File Offset: 0x000072DF
		public static string ToHtmlStringRGB(Color color)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x000090EC File Offset: 0x000072EC
		public static string ToHtmlStringRGBA(Color color)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0;
	}
}
