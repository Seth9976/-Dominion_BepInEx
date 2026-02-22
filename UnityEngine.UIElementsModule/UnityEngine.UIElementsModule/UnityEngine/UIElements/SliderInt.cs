using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000154 RID: 340
	public class SliderInt : BaseSlider<int>
	{
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00009F2D File Offset: 0x0000812D
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00009F3A File Offset: 0x0000813A
		public override float pageSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00036DAC File Offset: 0x00034FAC
		public override int SliderLerpUnclamped(int a, int b, float interpolant)
		{
			return Mathf.RoundToInt(Mathf.LerpUnclamped((float)a, (float)b, interpolant));
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00036DD0 File Offset: 0x00034FD0
		public override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue)
		{
			return ((float)currentValue - (float)lowerValue) / ((float)higherValue - (float)lowerValue);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00009F47 File Offset: 0x00008147
		public override int SliderRange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00036DF0 File Offset: 0x00034FF0
		public override int ParseStringToValue(string stringValue)
		{
			int num;
			bool flag = Int32.TryParse(stringValue, out num);
			int num2;
			if (flag)
			{
				num2 = num;
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00009F54 File Offset: 0x00008154
		public override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040007CB RID: 1995
		public const int kDefaultHighValue = 10;

		// Token: 0x0200026C RID: 620
		public class UxmlFactory : UxmlFactory<SliderInt, SliderInt.UxmlTraits>
		{
		}

		// Token: 0x0200026D RID: 621
		public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
		{
		}
	}
}
