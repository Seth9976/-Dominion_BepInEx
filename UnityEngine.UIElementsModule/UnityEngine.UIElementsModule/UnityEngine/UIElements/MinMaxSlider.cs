using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000148 RID: 328
	public class MinMaxSlider : BaseField<Vector2>
	{
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00009948 File Offset: 0x00007B48
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00009955 File Offset: 0x00007B55
		public VisualElement dragElement
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

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00009962 File Offset: 0x00007B62
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x0000996F File Offset: 0x00007B6F
		public VisualElement dragMinThumb
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0000997C File Offset: 0x00007B7C
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x00009989 File Offset: 0x00007B89
		public VisualElement dragMaxThumb
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

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x00009996 File Offset: 0x00007B96
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x000099A3 File Offset: 0x00007BA3
		public float minValue
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000099B0 File Offset: 0x00007BB0
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x000099BD File Offset: 0x00007BBD
		public float maxValue
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

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x000099CA File Offset: 0x00007BCA
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x000099D7 File Offset: 0x00007BD7
		public override Vector2 value
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

		// Token: 0x06000F0E RID: 3854 RVA: 0x000099E4 File Offset: 0x00007BE4
		public override void SetValueWithoutNotify(Vector2 newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00036264 File Offset: 0x00034464
		public float range
		{
			get
			{
				return Math.Abs(this.highLimit - this.lowLimit);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x000099F1 File Offset: 0x00007BF1
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x000099FE File Offset: 0x00007BFE
		public float lowLimit
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

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00009A0B File Offset: 0x00007C0B
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x00009A18 File Offset: 0x00007C18
		public float highLimit
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

		// Token: 0x06000F14 RID: 3860 RVA: 0x00009A25 File Offset: 0x00007C25
		public Vector2 ClampValues(Vector2 valueToClamp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00036288 File Offset: 0x00034488
		public void UpdateDragElementPosition(GeometryChangedEvent evt)
		{
			bool flag = evt.oldRect.size == evt.newRect.size;
			if (!flag)
			{
				this.UpdateDragElementPosition();
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00009A32 File Offset: 0x00007C32
		public void UpdateDragElementPosition()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000362C8 File Offset: 0x000344C8
		public float SliderLerpUnclamped(float a, float b, float interpolant)
		{
			return Mathf.LerpUnclamped(a, b, interpolant);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000362E4 File Offset: 0x000344E4
		public float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			return (currentValue - lowerValue) / (higherValue - lowerValue);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00009A3F File Offset: 0x00007C3F
		public float ComputeValueFromPosition(float positionToConvert)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00036300 File Offset: 0x00034500
		public override void ExecuteDefaultAction(EventBase evt)
		{
			base.ExecuteDefaultAction(evt);
			bool flag = evt == null;
			if (!flag)
			{
				bool flag2 = evt.eventTypeId == EventBase<GeometryChangedEvent>.TypeId();
				if (flag2)
				{
					this.UpdateDragElementPosition(evt.Cast<GeometryChangedEvent>());
				}
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00009A4C File Offset: 0x00007C4C
		public void SetSliderValueFromDrag()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00009A59 File Offset: 0x00007C59
		public void SetSliderValueFromClick()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00009A66 File Offset: 0x00007C66
		public void ComputeValueDragStateNoThumb(float lowLimitPosition, float highLimitPosition, float dragElementPos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00009A73 File Offset: 0x00007C73
		public void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00009A80 File Offset: 0x00007C80
		public override void UpdateMixedValueContent()
		{
		}

		// Token: 0x040007BD RID: 1981
		public const float kDefaultHighValue = 10f;

		// Token: 0x02000258 RID: 600
		public class UxmlFactory : UxmlFactory<MinMaxSlider, MinMaxSlider.UxmlTraits>
		{
		}

		// Token: 0x02000259 RID: 601
		public class UxmlTraits : BaseField<Vector2>.UxmlTraits
		{
		}

		// Token: 0x0200025A RID: 602
		public enum DragState
		{
			// Token: 0x04000919 RID: 2329
			NoThumb,
			// Token: 0x0400091A RID: 2330
			MinThumb,
			// Token: 0x0400091B RID: 2331
			MiddleThumb,
			// Token: 0x0400091C RID: 2332
			MaxThumb
		}
	}
}
