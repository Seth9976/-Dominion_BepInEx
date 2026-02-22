using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AE RID: 174
	public class StyleValueCollection : Object
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x00006112 File Offset: 0x00004312
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValueCollection()
		{
			Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleValueCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr);
			StyleValueCollection.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValueCollection>.NativeClassPtr, "m_Values");
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0000614B File Offset: 0x0000434B
		public StyleValueCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0002A1D8 File Offset: 0x000283D8
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00006154 File Offset: 0x00004354
		public unsafe List<UnityEngine.UIElements.StyleSheets.StyleValue> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValueCollection.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.UIElements.StyleSheets.StyleValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleValueCollection.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0002A208 File Offset: 0x00028408
		public StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = this.TryGetStyleValue(id, ref styleValue);
			StyleLength styleLength;
			if (flag)
			{
				styleLength = new StyleLength(styleValue.length, styleValue.keyword);
			}
			else
			{
				styleLength = StyleKeyword.Null;
			}
			return styleLength;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0002A24C File Offset: 0x0002844C
		public StyleColor GetStyleColor(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = this.TryGetStyleValue(id, ref styleValue);
			StyleColor styleColor;
			if (flag)
			{
				styleColor = new StyleColor(styleValue.color, styleValue.keyword);
			}
			else
			{
				styleColor = StyleKeyword.Null;
			}
			return styleColor;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0002A290 File Offset: 0x00028490
		public StyleBackground GetStyleBackground(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = this.TryGetStyleValue(id, ref styleValue);
			if (flag)
			{
				Texture2D texture2D = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<Texture2D>() : null);
				bool flag2 = texture2D != null;
				if (flag2)
				{
					return new StyleBackground(texture2D, styleValue.keyword);
				}
				Sprite sprite = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<Sprite>() : null);
				bool flag3 = sprite != null;
				if (flag3)
				{
					return new StyleBackground(sprite, styleValue.keyword);
				}
				VectorImage vectorImage = (styleValue.resource.IsAllocated ? styleValue.resource.Target.TryCast<VectorImage>() : null);
				bool flag4 = vectorImage != null;
				if (flag4)
				{
					return new StyleBackground(vectorImage, styleValue.keyword);
				}
			}
			return StyleKeyword.Null;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0002A38C File Offset: 0x0002858C
		public StyleFontDefinition GetStyleFontDefinition(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			UnityEngine.UIElements.StyleSheets.StyleValue styleValue = default(UnityEngine.UIElements.StyleSheets.StyleValue);
			bool flag = this.TryGetStyleValue(id, ref styleValue);
			StyleFontDefinition styleFontDefinition;
			if (flag)
			{
				Object @object = (styleValue.resource.IsAllocated ? styleValue.resource.Target : null);
				styleFontDefinition = new StyleFontDefinition(@object, styleValue.keyword);
			}
			else
			{
				styleFontDefinition = StyleKeyword.Null;
			}
			return styleFontDefinition;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0002A3E8 File Offset: 0x000285E8
		public bool TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, ref UnityEngine.UIElements.StyleSheets.StyleValue value)
		{
			value.id = UnityEngine.UIElements.StyleSheets.StylePropertyId.Unknown;
			List<UnityEngine.UIElements.StyleSheets.StyleValue>.Enumerator enumerator = this.m_Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					UnityEngine.UIElements.StyleSheets.StyleValue styleValue = enumerator.Current;
					bool flag = styleValue.id == id;
					if (flag)
					{
						value = styleValue;
						return true;
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			return false;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0002A460 File Offset: 0x00028660
		public void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value)
		{
			for (int i = 0; i < this.m_Values.Count; i++)
			{
				bool flag = this.m_Values[i].id == value.id;
				if (flag)
				{
					bool flag2 = value.keyword == StyleKeyword.Null;
					if (flag2)
					{
						this.m_Values.RemoveAt(i);
					}
					else
					{
						this.m_Values[i] = value;
					}
					return;
				}
			}
			this.m_Values.Add(value);
		}

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;
	}
}
