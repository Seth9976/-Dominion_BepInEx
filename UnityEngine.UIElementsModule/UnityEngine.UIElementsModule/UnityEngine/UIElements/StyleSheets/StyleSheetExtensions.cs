using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020000E6 RID: 230
	public static class StyleSheetExtensions : Object
	{
		// Token: 0x06000CE4 RID: 3300 RVA: 0x000082CA File Offset: 0x000064CA
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSheetExtensions()
		{
			Il2CppClassPointerStore<StyleSheetExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StyleSheetExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSheetExtensions>.NativeClassPtr);
			StyleSheetExtensions.NativeMethodInfoPtr_IsVarFunction_Public_Static_Boolean_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetExtensions>.NativeClassPtr, 100664283);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00033500 File Offset: 0x00031700
		[CallerCount(0)]
		public unsafe static bool IsVarFunction(this StyleValueHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetExtensions.NativeMethodInfoPtr_IsVarFunction_Public_Static_Boolean_StyleValueHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00008303 File Offset: 0x00006503
		public StyleSheetExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00033540 File Offset: 0x00031740
		public static string ReadAsString(StyleSheet sheet, StyleValueHandle handle)
		{
			string text = String.Empty;
			switch (handle.valueType)
			{
			case StyleValueType.Keyword:
				text = StyleValueKeywordExtension.ToUssString(sheet.ReadKeyword(handle));
				break;
			case StyleValueType.Float:
				text = sheet.ReadFloat(handle).ToString(CultureInfo.InvariantCulture.NumberFormat);
				break;
			case StyleValueType.Dimension:
				text = sheet.ReadDimension(handle).ToString();
				break;
			case StyleValueType.Color:
				text = sheet.ReadColor(handle).ToString();
				break;
			case StyleValueType.ResourcePath:
				text = sheet.ReadResourcePath(handle);
				break;
			case StyleValueType.AssetReference:
				text = sheet.ReadAssetReference(handle).ToString();
				break;
			case StyleValueType.Enum:
				text = sheet.ReadEnum(handle);
				break;
			case StyleValueType.Variable:
				text = sheet.ReadVariable(handle);
				break;
			case StyleValueType.String:
				text = sheet.ReadString(handle);
				break;
			case StyleValueType.Function:
				text = sheet.ReadFunctionName(handle);
				break;
			case StyleValueType.FunctionSeparator:
				text = ",";
				break;
			case StyleValueType.ScalableImage:
			{
				ScalableImage scalableImage = sheet.ReadScalableImage(handle);
				text = scalableImage.ToString();
				break;
			}
			default:
				text = String.Concat("Error reading value type (", handle.valueType.ToString(), ") at index ", handle.valueIndex.ToString());
				break;
			}
			return text;
		}

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_IsVarFunction_Public_Static_Boolean_StyleValueHandle_0;
	}
}
