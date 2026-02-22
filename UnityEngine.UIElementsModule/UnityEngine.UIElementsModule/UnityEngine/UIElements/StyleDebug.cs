using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018C RID: 396
	public static class StyleDebug
	{
		// Token: 0x06001104 RID: 4356 RVA: 0x0000AF42 File Offset: 0x00009142
		public static Il2CppStringArray GetStylePropertyNames()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0000AF4F File Offset: 0x0000914F
		public static Il2CppStringArray GetLonghandPropertyNames(string shorthandName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0000AF5C File Offset: 0x0000915C
		public static UnityEngine.UIElements.StyleSheets.StylePropertyId GetStylePropertyIdFromName(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0000AF69 File Offset: 0x00009169
		public static Object GetComputedStyleActualValue(ComputedStyle computedStyle, string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0000AF76 File Offset: 0x00009176
		public static Object GetInlineStyleValue(IStyle style, string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0000AF83 File Offset: 0x00009183
		public static void SetInlineStyleValue(IStyle style, string name, Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0000AF90 File Offset: 0x00009190
		public static Type GetInlineStyleType(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0000AF9D File Offset: 0x0000919D
		public static Type GetComputedStyleType(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0000AFAA File Offset: 0x000091AA
		public static Object GetComputedStyleValue(ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00037E6C File Offset: 0x0003606C
		public static Object GetComputedStyleActualValue(ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			Object @object;
			switch (id)
			{
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Color:
				@object = computedStyle.color;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize:
				@object = computedStyle.fontSize;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFont:
				@object = computedStyle.unityFont;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontStyleAndWeight:
				@object = computedStyle.unityFontStyleAndWeight;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextAlign:
				@object = computedStyle.unityTextAlign;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Visibility:
				@object = computedStyle.visibility;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.WhiteSpace:
				@object = computedStyle.whiteSpace;
				break;
			default:
				switch (id)
				{
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignContent:
					@object = computedStyle.alignContent;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignItems:
					@object = computedStyle.alignItems;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignSelf:
					@object = computedStyle.alignSelf;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundColor:
					@object = computedStyle.backgroundColor;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage:
					@object = computedStyle.backgroundImage;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomColor:
					@object = computedStyle.borderBottomColor;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomLeftRadius:
					@object = computedStyle.borderBottomLeftRadius;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomRightRadius:
					@object = computedStyle.borderBottomRightRadius;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomWidth:
					@object = computedStyle.borderBottomWidth;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftColor:
					@object = computedStyle.borderLeftColor;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftWidth:
					@object = computedStyle.borderLeftWidth;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightColor:
					@object = computedStyle.borderRightColor;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightWidth:
					@object = computedStyle.borderRightWidth;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopColor:
					@object = computedStyle.borderTopColor;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopLeftRadius:
					@object = computedStyle.borderTopLeftRadius;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopRightRadius:
					@object = computedStyle.borderTopRightRadius;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopWidth:
					@object = computedStyle.borderTopWidth;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Bottom:
					@object = computedStyle.bottom;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Cursor:
					@object = computedStyle.cursor;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Display:
					@object = computedStyle.display;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexBasis:
					@object = computedStyle.flexBasis;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexDirection:
					@object = computedStyle.flexDirection;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexGrow:
					@object = computedStyle.flexGrow;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexShrink:
					@object = computedStyle.flexShrink;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexWrap:
					@object = computedStyle.flexWrap;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Height:
					@object = computedStyle.height;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.JustifyContent:
					@object = computedStyle.justifyContent;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Left:
					@object = computedStyle.left;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginBottom:
					@object = computedStyle.marginBottom;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginLeft:
					@object = computedStyle.marginLeft;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginRight:
					@object = computedStyle.marginRight;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginTop:
					@object = computedStyle.marginTop;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxHeight:
					@object = computedStyle.maxHeight;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxWidth:
					@object = computedStyle.maxWidth;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.MinHeight:
					@object = computedStyle.minHeight;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.MinWidth:
					@object = computedStyle.minWidth;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Opacity:
					@object = computedStyle.opacity;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Overflow:
					@object = computedStyle.overflow;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingBottom:
					@object = computedStyle.paddingBottom;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingLeft:
					@object = computedStyle.paddingLeft;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingRight:
					@object = computedStyle.paddingRight;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingTop:
					@object = computedStyle.paddingTop;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Position:
					@object = computedStyle.position;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Right:
					@object = computedStyle.right;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.TextOverflow:
					@object = computedStyle.textOverflow;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Top:
					@object = computedStyle.top;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundImageTintColor:
					@object = computedStyle.unityBackgroundImageTintColor;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundScaleMode:
					@object = computedStyle.unityBackgroundScaleMode;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityOverflowClipBox:
					@object = computedStyle.unityOverflowClipBox;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceBottom:
					@object = computedStyle.unitySliceBottom;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceLeft:
					@object = computedStyle.unitySliceLeft;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceRight:
					@object = computedStyle.unitySliceRight;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceTop:
					@object = computedStyle.unitySliceTop;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOverflowPosition:
					@object = computedStyle.unityTextOverflowPosition;
					break;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Width:
					@object = computedStyle.width;
					break;
				default:
					Debug.LogAssertion(String.Format("Cannot get computed style value for property id {0}", id));
					@object = null;
					break;
				}
				break;
			}
			return @object;
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0000AFB7 File Offset: 0x000091B7
		public static Object GetInlineStyleValue(IStyle style, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0000AFC4 File Offset: 0x000091C4
		public static void SetInlineStyleValue(IStyle style, UnityEngine.UIElements.StyleSheets.StylePropertyId id, Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0000AFD1 File Offset: 0x000091D1
		public static Type GetInlineStyleType(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0000AFDE File Offset: 0x000091DE
		public static Il2CppStringArray GetLonghandPropertyNames(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000383AC File Offset: 0x000365AC
		public static bool IsShorthandProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			bool flag;
			switch (id)
			{
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderColor:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRadius:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderWidth:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Flex:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Margin:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Padding:
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			return flag;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00038404 File Offset: 0x00036604
		public static bool IsInheritedProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			bool flag;
			switch (id)
			{
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Color:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFont:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontStyleAndWeight:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextAlign:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Visibility:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.WhiteSpace:
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			return flag;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0000AFEB File Offset: 0x000091EB
		public static Il2CppStructArray<UnityEngine.UIElements.StyleSheets.StylePropertyId> GetInheritedProperties()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040007E6 RID: 2022
		public const int UnitySpecificity = -1;

		// Token: 0x040007E7 RID: 2023
		public const int UndefinedSpecificity = 0;

		// Token: 0x040007E8 RID: 2024
		public const int InheritedSpecificity = 2147483646;

		// Token: 0x040007E9 RID: 2025
		public const int InlineSpecificity = 2147483647;
	}
}
