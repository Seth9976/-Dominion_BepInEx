using System;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x02000153 RID: 339
	public class Slider : BaseSlider<float>
	{
		// Token: 0x06000F88 RID: 3976 RVA: 0x00009F13 File Offset: 0x00008113
		public override float SliderLerpUnclamped(float a, float b, float interpolant)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00036D4C File Offset: 0x00034F4C
		public override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			return (currentValue - lowerValue) / (higherValue - lowerValue);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00009F20 File Offset: 0x00008120
		public override float SliderRange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00036D68 File Offset: 0x00034F68
		public override float ParseStringToValue(string stringValue)
		{
			float num;
			bool flag = Single.TryParse(stringValue.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out num);
			float num2;
			if (flag)
			{
				num2 = num;
			}
			else
			{
				num2 = 0f;
			}
			return num2;
		}

		// Token: 0x040007CA RID: 1994
		public const float kDefaultHighValue = 10f;

		// Token: 0x0200026A RID: 618
		public class UxmlFactory : UxmlFactory<Slider, Slider.UxmlTraits>
		{
		}

		// Token: 0x0200026B RID: 619
		public class UxmlTraits : BaseFieldTraits<float, UxmlFloatAttributeDescription>
		{
		}
	}
}
