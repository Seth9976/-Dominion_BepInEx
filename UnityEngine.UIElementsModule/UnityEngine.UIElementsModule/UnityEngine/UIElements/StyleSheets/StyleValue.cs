using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020000E7 RID: 231
	[StructLayout(2)]
	public struct StyleValue
	{
		// Token: 0x06000CE8 RID: 3304 RVA: 0x000336A8 File Offset: 0x000318A8
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValue()
		{
			Il2CppClassPointerStore<StyleValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StyleValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValue>.NativeClassPtr);
			StyleValue.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "id");
			StyleValue.NativeFieldInfoPtr_keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "keyword");
			StyleValue.NativeFieldInfoPtr_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "number");
			StyleValue.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "length");
			StyleValue.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "color");
			StyleValue.NativeFieldInfoPtr_resource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, "resource");
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0000830C File Offset: 0x0000650C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleValue>.NativeClassPtr, ref this));
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00033750 File Offset: 0x00031950
		public static StyleValue Create(StylePropertyId id)
		{
			return new StyleValue
			{
				id = id
			};
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00033774 File Offset: 0x00031974
		public static StyleValue Create(StylePropertyId id, StyleKeyword keyword)
		{
			return new StyleValue
			{
				id = id,
				keyword = keyword
			};
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000337A0 File Offset: 0x000319A0
		public static StyleValue Create(StylePropertyId id, float number)
		{
			return new StyleValue
			{
				id = id,
				number = number
			};
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x000337CC File Offset: 0x000319CC
		public static StyleValue Create(StylePropertyId id, int number)
		{
			return new StyleValue
			{
				id = id,
				number = (float)number
			};
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000337F8 File Offset: 0x000319F8
		public static StyleValue Create(StylePropertyId id, Color color)
		{
			return new StyleValue
			{
				id = id,
				color = color
			};
		}

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_keyword;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_number;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_resource;

		// Token: 0x0400073F RID: 1855
		[FieldOffset(0)]
		public StylePropertyId id;

		// Token: 0x04000740 RID: 1856
		[FieldOffset(4)]
		public StyleKeyword keyword;

		// Token: 0x04000741 RID: 1857
		[FieldOffset(8)]
		public float number;

		// Token: 0x04000742 RID: 1858
		[FieldOffset(8)]
		public Length length;

		// Token: 0x04000743 RID: 1859
		[FieldOffset(8)]
		public Color color;

		// Token: 0x04000744 RID: 1860
		[FieldOffset(8)]
		public GCHandle resource;
	}
}
