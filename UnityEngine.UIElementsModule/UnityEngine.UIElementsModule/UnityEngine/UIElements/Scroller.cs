using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014F RID: 335
	public class Scroller : VisualElement
	{
		// Token: 0x06000F39 RID: 3897 RVA: 0x00009BD0 File Offset: 0x00007DD0
		public void add_valueChanged(Action<float> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00009BDD File Offset: 0x00007DDD
		public void remove_valueChanged(Action<float> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00009BEA File Offset: 0x00007DEA
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00009BF7 File Offset: 0x00007DF7
		public Slider slider
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

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00009C04 File Offset: 0x00007E04
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00009C11 File Offset: 0x00007E11
		public RepeatButton lowButton
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

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00009C1E File Offset: 0x00007E1E
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00009C2B File Offset: 0x00007E2B
		public RepeatButton highButton
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

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00009C38 File Offset: 0x00007E38
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00009C45 File Offset: 0x00007E45
		public float value
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

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00009C52 File Offset: 0x00007E52
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x00009C5F File Offset: 0x00007E5F
		public float lowValue
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

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00009C6C File Offset: 0x00007E6C
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00009C79 File Offset: 0x00007E79
		public float highValue
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

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00036344 File Offset: 0x00034544
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x00009C86 File Offset: 0x00007E86
		public SliderDirection direction
		{
			get
			{
				return (base.resolvedStyle.flexDirection == FlexDirection.Row) ? SliderDirection.Horizontal : SliderDirection.Vertical;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00009C93 File Offset: 0x00007E93
		public void Adjust(float factor)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00009CA0 File Offset: 0x00007EA0
		public void ScrollPageUp()
		{
			this.ScrollPageUp(1f);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00009CAF File Offset: 0x00007EAF
		public void ScrollPageDown()
		{
			this.ScrollPageDown(1f);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00009CBE File Offset: 0x00007EBE
		public void ScrollPageUp(float factor)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00009CCB File Offset: 0x00007ECB
		public void ScrollPageDown(float factor)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040007BF RID: 1983
		public const float kDefaultPageSize = 20f;

		// Token: 0x02000265 RID: 613
		public new class UxmlFactory : UxmlFactory<Scroller, Scroller.UxmlTraits>
		{
		}

		// Token: 0x02000266 RID: 614
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x020002A6 RID: 678
			public sealed class <get_uxmlChildElementsDescription>d__5
			{
			}
		}
	}
}
