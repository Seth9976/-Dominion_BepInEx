using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AF RID: 175
	public class InlineStyleAccess : StyleValueCollection
	{
		// Token: 0x06000972 RID: 2418 RVA: 0x0002A4E8 File Offset: 0x000286E8
		// Note: this type is marked as 'beforefieldinit'.
		static InlineStyleAccess()
		{
			Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "InlineStyleAccess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr);
			InlineStyleAccess.NativeFieldInfoPtr_s_StylePropertyReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "s_StylePropertyReader");
			InlineStyleAccess.NativeFieldInfoPtr__ve_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "<ve>k__BackingField");
			InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_HasInlineCursor");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineCursor");
			InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTextShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_HasInlineTextShadow");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineTextShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineTextShadow");
			InlineStyleAccess.NativeFieldInfoPtr_m_InlineRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "m_InlineRule");
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00006173 File Offset: 0x00004373
		public InlineStyleAccess(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0002A5A4 File Offset: 0x000287A4
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x0000617C File Offset: 0x0000437C
		public unsafe static UnityEngine.UIElements.StyleSheets.StylePropertyReader s_StylePropertyReader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InlineStyleAccess.NativeFieldInfoPtr_s_StylePropertyReader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.StyleSheets.StylePropertyReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InlineStyleAccess.NativeFieldInfoPtr_s_StylePropertyReader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0002A5CC File Offset: 0x000287CC
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0000618E File Offset: 0x0000438E
		public unsafe VisualElement _ve_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr__ve_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr__ve_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0002A5FC File Offset: 0x000287FC
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x000061AD File Offset: 0x000043AD
		public unsafe bool m_HasInlineCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineCursor)) = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0002A624 File Offset: 0x00028824
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x000061C8 File Offset: 0x000043C8
		public StyleCursor m_InlineCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineCursor);
				return new StyleCursor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineCursor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StyleCursor>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0002A654 File Offset: 0x00028854
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x000061F6 File Offset: 0x000043F6
		public unsafe bool m_HasInlineTextShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTextShadow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_HasInlineTextShadow)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0002A67C File Offset: 0x0002887C
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00006211 File Offset: 0x00004411
		public unsafe StyleTextShadow m_InlineTextShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineTextShadow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineTextShadow)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0002A6A4 File Offset: 0x000288A4
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x0000622C File Offset: 0x0000442C
		public InlineStyleAccess.InlineRule m_InlineRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineRule);
				return new InlineStyleAccess.InlineRule(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.NativeFieldInfoPtr_m_InlineRule), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0000625A File Offset: 0x0000445A
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00006262 File Offset: 0x00004462
		public VisualElement ve
		{
			get
			{
				return this._ve_k__BackingField;
			}
			set
			{
				this._ve_k__BackingField = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0000626B File Offset: 0x0000446B
		public InlineStyleAccess.InlineRule inlineRule
		{
			get
			{
				return this.m_InlineRule;
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0002A6D4 File Offset: 0x000288D4
		public override void Finalize()
		{
			try
			{
				UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
				bool flag = base.TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage, ref styleValue);
				if (flag)
				{
					bool isAllocated = styleValue.resource.IsAllocated;
					if (isAllocated)
					{
						styleValue.resource.Free();
					}
				}
				bool flag2 = base.TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFont, ref styleValue);
				if (flag2)
				{
					bool isAllocated2 = styleValue.resource.IsAllocated;
					if (isAllocated2)
					{
						styleValue.resource.Free();
					}
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00006273 File Offset: 0x00004473
		public void SetInlineRule(StyleSheet sheet, StyleRule rule)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00006280 File Offset: 0x00004480
		public void ApplyInlineStyles(ComputedStyle sharedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0002A764 File Offset: 0x00028964
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x0002A794 File Offset: 0x00028994
		public StyleCursor UnityEngine.UIElements.IStyle.cursor
		{
			get
			{
				StyleCursor styleCursor = null;
				bool flag = this.TryGetInlineCursor(ref styleCursor);
				StyleCursor styleCursor2;
				if (flag)
				{
					styleCursor2 = styleCursor;
				}
				else
				{
					styleCursor2 = StyleKeyword.Null;
				}
				return styleCursor2;
			}
			set
			{
				bool flag = this.SetInlineCursor(value, this.ve.sharedStyle.cursor);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles);
				}
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0002A7D0 File Offset: 0x000289D0
		public bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleLength inlineValue, Length sharedValue)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool flag2 = styleValue.length == inlineValue.value && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.length = StyleValueExtensions.ToLength(inlineValue);
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			if (flag4)
			{
				styleValue.length = sharedValue;
			}
			this.ApplyStyleValue(styleValue);
			return true;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0002A88C File Offset: 0x00028A8C
		public bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleColor inlineValue, Color sharedValue)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				bool flag2 = styleValue.color == inlineValue.value && styleValue.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			styleValue.color = inlineValue.value;
			base.SetStyleValue(styleValue);
			bool flag4 = inlineValue.keyword == StyleKeyword.Null;
			if (flag4)
			{
				styleValue.color = sharedValue;
			}
			this.ApplyStyleValue(styleValue);
			return true;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0002A94C File Offset: 0x00028B4C
		public bool SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleBackground inlineValue, Background sharedValue)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = base.TryGetStyleValue(id, ref styleValue);
			Background background;
			if (flag)
			{
				VectorImage vectorImage = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<VectorImage>() : null);
				Sprite sprite = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<Sprite>() : null);
				Texture2D texture2D = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<Texture2D>() : null);
				RenderTexture renderTexture = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<RenderTexture>() : null);
				Object @object = vectorImage;
				background = inlineValue.value;
				bool flag2;
				if (@object == background.vectorImage)
				{
					Object object2 = texture2D;
					background = inlineValue.value;
					if (object2 == background.texture)
					{
						Object object3 = sprite;
						background = inlineValue.value;
						if (object3 == background.sprite)
						{
							Object object4 = renderTexture;
							background = inlineValue.value;
							if (object4 == background.renderTexture)
							{
								flag2 = styleValue.keyword == inlineValue.keyword;
								goto IL_011C;
							}
						}
					}
				}
				flag2 = false;
				IL_011C:
				bool flag3 = flag2;
				if (flag3)
				{
					return false;
				}
				bool isAllocated = styleValue.resource.IsAllocated;
				if (isAllocated)
				{
					styleValue.resource.Free();
				}
			}
			else
			{
				bool flag4 = inlineValue.keyword == StyleKeyword.Null;
				if (flag4)
				{
					return false;
				}
			}
			styleValue.id = id;
			styleValue.keyword = inlineValue.keyword;
			background = inlineValue.value;
			bool flag5 = background.vectorImage != null;
			if (flag5)
			{
				background = inlineValue.value;
				styleValue.resource = GCHandle.Alloc(background.vectorImage);
			}
			else
			{
				background = inlineValue.value;
				bool flag6 = background.sprite != null;
				if (flag6)
				{
					background = inlineValue.value;
					styleValue.resource = GCHandle.Alloc(background.sprite);
				}
				else
				{
					background = inlineValue.value;
					bool flag7 = background.texture != null;
					if (flag7)
					{
						background = inlineValue.value;
						styleValue.resource = GCHandle.Alloc(background.texture);
					}
					else
					{
						background = inlineValue.value;
						bool flag8 = background.renderTexture != null;
						if (flag8)
						{
							background = inlineValue.value;
							styleValue.resource = GCHandle.Alloc(background.renderTexture);
						}
						else
						{
							styleValue.resource = default(GCHandle);
						}
					}
				}
			}
			base.SetStyleValue(styleValue);
			bool flag9 = inlineValue.keyword == StyleKeyword.Null;
			if (flag9)
			{
				bool flag10 = sharedValue.texture != null;
				if (flag10)
				{
					styleValue.resource = GCHandle.Alloc(sharedValue.texture);
				}
				else
				{
					bool flag11 = sharedValue.sprite != null;
					if (flag11)
					{
						styleValue.resource = GCHandle.Alloc(sharedValue.sprite);
					}
					else
					{
						bool flag12 = sharedValue.renderTexture != null;
						if (flag12)
						{
							styleValue.resource = GCHandle.Alloc(sharedValue.renderTexture);
						}
						else
						{
							bool flag13 = sharedValue.vectorImage != null;
							if (flag13)
							{
								styleValue.resource = GCHandle.Alloc(sharedValue.vectorImage);
							}
							else
							{
								styleValue.resource = default(GCHandle);
							}
						}
					}
				}
			}
			this.ApplyStyleValue(styleValue);
			return true;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0002ACAC File Offset: 0x00028EAC
		public bool SetInlineCursor(StyleCursor inlineValue, Cursor sharedValue)
		{
			StyleCursor styleCursor = null;
			bool flag = this.TryGetInlineCursor(ref styleCursor);
			if (flag)
			{
				bool flag2 = styleCursor.value == inlineValue.value && styleCursor.keyword == inlineValue.keyword;
				if (flag2)
				{
					return false;
				}
			}
			else
			{
				bool flag3 = inlineValue.keyword == StyleKeyword.Null;
				if (flag3)
				{
					return false;
				}
			}
			styleCursor.value = inlineValue.value;
			styleCursor.keyword = inlineValue.keyword;
			this.SetInlineCursor(styleCursor);
			bool flag4 = styleCursor.keyword == StyleKeyword.Null;
			if (flag4)
			{
				styleCursor.value = sharedValue;
			}
			this.ve.computedStyle.ApplyStyleCursor(styleCursor.value);
			return true;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0002AD78 File Offset: 0x00028F78
		public void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value)
		{
			VisualElement.Hierarchy hierarchy = this.ve.hierarchy;
			VisualElement parent = hierarchy.parent;
			ComputedStyle computedStyle = ((parent != null) ? parent.computedStyle : null);
			this.ve.computedStyle.ApplyStyleValue(value, computedStyle);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0002ADBC File Offset: 0x00028FBC
		public bool TryGetInlineCursor(ref StyleCursor value)
		{
			bool hasInlineCursor = this.m_HasInlineCursor;
			bool flag;
			if (hasInlineCursor)
			{
				value = this.m_InlineCursor;
				flag = true;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0000628D File Offset: 0x0000448D
		public void SetInlineCursor(StyleCursor value)
		{
			this.m_InlineCursor = value;
			this.m_HasInlineCursor = true;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0002ADEC File Offset: 0x00028FEC
		public bool TryGetInlineTextShadow(ref StyleTextShadow value)
		{
			bool hasInlineTextShadow = this.m_HasInlineTextShadow;
			bool flag;
			if (hasInlineTextShadow)
			{
				value = this.m_InlineTextShadow;
				flag = true;
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0000629E File Offset: 0x0000449E
		public void SetInlineTextShadow(StyleTextShadow value)
		{
			this.m_InlineTextShadow = value;
			this.m_HasInlineTextShadow = true;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x0002AE1C File Offset: 0x0002901C
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x0002AE3C File Offset: 0x0002903C
		public StyleColor UnityEngine.UIElements.IStyle.backgroundColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundColor, value, this.ve.sharedStyle.backgroundColor);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0002AE80 File Offset: 0x00029080
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x0002AEA0 File Offset: 0x000290A0
		public StyleBackground UnityEngine.UIElements.IStyle.backgroundImage
		{
			get
			{
				return base.GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage, value, this.ve.sharedStyle.backgroundImage);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0002AEE4 File Offset: 0x000290E4
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x0002AF04 File Offset: 0x00029104
		public StyleColor UnityEngine.UIElements.IStyle.borderBottomColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomColor, value, this.ve.sharedStyle.borderBottomColor);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0002AF48 File Offset: 0x00029148
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x0002AF68 File Offset: 0x00029168
		public StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomLeftRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomLeftRadius, value, this.ve.sharedStyle.borderBottomLeftRadius);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.BorderRadius | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0002AFAC File Offset: 0x000291AC
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x0002AFCC File Offset: 0x000291CC
		public StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomRightRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomRightRadius, value, this.ve.sharedStyle.borderBottomRightRadius);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.BorderRadius | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0002B010 File Offset: 0x00029210
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x0002B030 File Offset: 0x00029230
		public StyleColor UnityEngine.UIElements.IStyle.borderLeftColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftColor, value, this.ve.sharedStyle.borderLeftColor);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0002B074 File Offset: 0x00029274
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x0002B094 File Offset: 0x00029294
		public StyleColor UnityEngine.UIElements.IStyle.borderRightColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightColor, value, this.ve.sharedStyle.borderRightColor);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0002B0D8 File Offset: 0x000292D8
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x0002B0F8 File Offset: 0x000292F8
		public StyleColor UnityEngine.UIElements.IStyle.borderTopColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopColor, value, this.ve.sharedStyle.borderTopColor);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0002B13C File Offset: 0x0002933C
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x0002B15C File Offset: 0x0002935C
		public StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopLeftRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopLeftRadius, value, this.ve.sharedStyle.borderTopLeftRadius);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.BorderRadius | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0002B1A0 File Offset: 0x000293A0
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x0002B1C0 File Offset: 0x000293C0
		public StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopRightRadius);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopRightRadius, value, this.ve.sharedStyle.borderTopRightRadius);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.BorderRadius | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0002B204 File Offset: 0x00029404
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x000062AF File Offset: 0x000044AF
		public StyleLength UnityEngine.UIElements.IStyle.bottom
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Bottom);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0002B224 File Offset: 0x00029424
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x0002B240 File Offset: 0x00029440
		public StyleColor UnityEngine.UIElements.IStyle.color
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.Color);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.Color, value, this.ve.sharedStyle.color);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0002B280 File Offset: 0x00029480
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x000062BC File Offset: 0x000044BC
		public StyleLength UnityEngine.UIElements.IStyle.flexBasis
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexBasis);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0002B2A0 File Offset: 0x000294A0
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x0002B2BC File Offset: 0x000294BC
		public StyleLength UnityEngine.UIElements.IStyle.fontSize
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize, value, this.ve.sharedStyle.fontSize);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles);
				}
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0002B2F8 File Offset: 0x000294F8
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x000062C9 File Offset: 0x000044C9
		public StyleLength UnityEngine.UIElements.IStyle.height
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Height);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0002B318 File Offset: 0x00029518
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x000062D6 File Offset: 0x000044D6
		public StyleLength UnityEngine.UIElements.IStyle.left
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Left);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0002B338 File Offset: 0x00029538
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x000062E3 File Offset: 0x000044E3
		public StyleLength UnityEngine.UIElements.IStyle.marginBottom
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginBottom);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0002B358 File Offset: 0x00029558
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x000062F0 File Offset: 0x000044F0
		public StyleLength UnityEngine.UIElements.IStyle.marginLeft
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginLeft);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0002B378 File Offset: 0x00029578
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x000062FD File Offset: 0x000044FD
		public StyleLength UnityEngine.UIElements.IStyle.marginRight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginRight);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0002B398 File Offset: 0x00029598
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x0000630A File Offset: 0x0000450A
		public StyleLength UnityEngine.UIElements.IStyle.marginTop
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginTop);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0002B3B8 File Offset: 0x000295B8
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00006317 File Offset: 0x00004517
		public StyleLength UnityEngine.UIElements.IStyle.maxHeight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxHeight);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0002B3D8 File Offset: 0x000295D8
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x00006324 File Offset: 0x00004524
		public StyleLength UnityEngine.UIElements.IStyle.maxWidth
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxWidth);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0002B3F8 File Offset: 0x000295F8
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00006331 File Offset: 0x00004531
		public StyleLength UnityEngine.UIElements.IStyle.minHeight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MinHeight);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0002B418 File Offset: 0x00029618
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x0000633E File Offset: 0x0000453E
		public StyleLength UnityEngine.UIElements.IStyle.minWidth
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.MinWidth);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0002B438 File Offset: 0x00029638
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x0000634B File Offset: 0x0000454B
		public StyleLength UnityEngine.UIElements.IStyle.paddingBottom
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingBottom);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0002B458 File Offset: 0x00029658
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x00006358 File Offset: 0x00004558
		public StyleLength UnityEngine.UIElements.IStyle.paddingLeft
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingLeft);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0002B478 File Offset: 0x00029678
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00006365 File Offset: 0x00004565
		public StyleLength UnityEngine.UIElements.IStyle.paddingRight
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingRight);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0002B498 File Offset: 0x00029698
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x00006372 File Offset: 0x00004572
		public StyleLength UnityEngine.UIElements.IStyle.paddingTop
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingTop);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x0002B4B8 File Offset: 0x000296B8
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x0000637F File Offset: 0x0000457F
		public StyleLength UnityEngine.UIElements.IStyle.right
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Right);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x0002B4D8 File Offset: 0x000296D8
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x0000638C File Offset: 0x0000458C
		public StyleLength UnityEngine.UIElements.IStyle.top
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Top);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0002B4F8 File Offset: 0x000296F8
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x0002B518 File Offset: 0x00029718
		public StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor
		{
			get
			{
				return base.GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundImageTintColor);
			}
			set
			{
				bool flag = this.SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundImageTintColor, value, this.ve.sharedStyle.unityBackgroundImageTintColor);
				if (flag)
				{
					this.ve.IncrementVersion(VersionChangeType.Styles | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0002B55C File Offset: 0x0002975C
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00006399 File Offset: 0x00004599
		public StyleLength UnityEngine.UIElements.IStyle.width
		{
			get
			{
				return base.GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId.Width);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeFieldInfoPtr_s_StylePropertyReader;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeFieldInfoPtr__ve_k__BackingField;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeFieldInfoPtr_m_HasInlineCursor;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineCursor;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeFieldInfoPtr_m_HasInlineTextShadow;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineTextShadow;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeFieldInfoPtr_m_InlineRule;

		// Token: 0x0200021E RID: 542
		public sealed class InlineRule : ValueType
		{
			// Token: 0x060013B2 RID: 5042 RVA: 0x0003C5E4 File Offset: 0x0003A7E4
			// Note: this type is marked as 'beforefieldinit'.
			static InlineRule()
			{
				Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InlineStyleAccess>.NativeClassPtr, "InlineRule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr);
				InlineStyleAccess.InlineRule.NativeFieldInfoPtr_sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr, "sheet");
				InlineStyleAccess.InlineRule.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr, "properties");
				InlineStyleAccess.InlineRule.NativeFieldInfoPtr_propertyIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr, "propertyIds");
			}

			// Token: 0x060013B3 RID: 5043 RVA: 0x0000C9AB File Offset: 0x0000ABAB
			public InlineRule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060013B4 RID: 5044 RVA: 0x0000C9B4 File Offset: 0x0000ABB4
			public InlineRule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InlineStyleAccess.InlineRule>.NativeClassPtr))
			{
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0003C64C File Offset: 0x0003A84C
			// (set) Token: 0x060013B6 RID: 5046 RVA: 0x0000C9C6 File Offset: 0x0000ABC6
			public unsafe StyleSheet sheet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_sheet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0003C67C File Offset: 0x0003A87C
			// (set) Token: 0x060013B8 RID: 5048 RVA: 0x0000C9E5 File Offset: 0x0000ABE5
			public unsafe Il2CppReferenceArray<StyleProperty> properties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_properties);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleProperty>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0003C6AC File Offset: 0x0003A8AC
			// (set) Token: 0x060013BA RID: 5050 RVA: 0x0000CA04 File Offset: 0x0000AC04
			public unsafe Il2CppStructArray<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_propertyIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UnityEngine.UIElements.StyleSheets.StylePropertyId>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InlineStyleAccess.InlineRule.NativeFieldInfoPtr_propertyIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008D3 RID: 2259
			private static readonly IntPtr NativeFieldInfoPtr_sheet;

			// Token: 0x040008D4 RID: 2260
			private static readonly IntPtr NativeFieldInfoPtr_properties;

			// Token: 0x040008D5 RID: 2261
			private static readonly IntPtr NativeFieldInfoPtr_propertyIds;
		}
	}
}
