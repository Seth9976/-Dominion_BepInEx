using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000152 RID: 338
	public class ScrollView : VisualElement
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00009CD8 File Offset: 0x00007ED8
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x00009CE5 File Offset: 0x00007EE5
		public ScrollerVisibility horizontalScrollerVisibility
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

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00009CF2 File Offset: 0x00007EF2
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x00009CFF File Offset: 0x00007EFF
		public ScrollerVisibility verticalScrollerVisibility
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

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00009D0C File Offset: 0x00007F0C
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x00009D17 File Offset: 0x00007F17
		public bool showHorizontal
		{
			get
			{
				return this.horizontalScrollerVisibility == ScrollerVisibility.AlwaysVisible;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00009D24 File Offset: 0x00007F24
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x00009D2F File Offset: 0x00007F2F
		public bool showVertical
		{
			get
			{
				return this.verticalScrollerVisibility == ScrollerVisibility.AlwaysVisible;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x00036368 File Offset: 0x00034568
		public bool needsHorizontal
		{
			get
			{
				return this.horizontalScrollerVisibility == ScrollerVisibility.AlwaysVisible || (this.horizontalScrollerVisibility == ScrollerVisibility.Auto && this.scrollableWidth > 0f);
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x000363A0 File Offset: 0x000345A0
		public bool needsVertical
		{
			get
			{
				return this.verticalScrollerVisibility == ScrollerVisibility.AlwaysVisible || (this.verticalScrollerVisibility == ScrollerVisibility.Auto && this.scrollableHeight > 0f);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x000363D8 File Offset: 0x000345D8
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x00036408 File Offset: 0x00034608
		public Vector2 scrollOffset
		{
			get
			{
				return new Vector2(this.horizontalScroller.value, this.verticalScroller.value);
			}
			set
			{
				bool flag = value != this.scrollOffset;
				if (flag)
				{
					this.horizontalScroller.value = value.x;
					this.verticalScroller.value = value.y;
					this.UpdateContentViewTransform();
				}
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00009D3C File Offset: 0x00007F3C
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x00009D49 File Offset: 0x00007F49
		public float horizontalPageSize
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

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00009D56 File Offset: 0x00007F56
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00009D63 File Offset: 0x00007F63
		public float verticalPageSize
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

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00036454 File Offset: 0x00034654
		public float scrollableWidth
		{
			get
			{
				return this.contentContainer.boundingBox.width - this.contentViewport.layout.width;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00036490 File Offset: 0x00034690
		public float scrollableHeight
		{
			get
			{
				return this.contentContainer.boundingBox.height - this.contentViewport.layout.height;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00009D70 File Offset: 0x00007F70
		public bool hasInertia
		{
			get
			{
				return this.scrollDecelerationRate > 0f;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00009D7F File Offset: 0x00007F7F
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x00009D8C File Offset: 0x00007F8C
		public float scrollDecelerationRate
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00009D99 File Offset: 0x00007F99
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x00009DA6 File Offset: 0x00007FA6
		public float elasticity
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

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00009DB3 File Offset: 0x00007FB3
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00009DC0 File Offset: 0x00007FC0
		public ScrollView.TouchScrollBehavior touchScrollBehavior
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

		// Token: 0x06000F67 RID: 3943 RVA: 0x000364CC File Offset: 0x000346CC
		public void UpdateContentViewTransform()
		{
			Vector3 position = this.contentContainer.transform.position;
			Vector2 scrollOffset = this.scrollOffset;
			bool needsVertical = this.needsVertical;
			if (needsVertical)
			{
				scrollOffset.y += this.contentContainer.resolvedStyle.top;
			}
			position.x = GUIUtility.RoundToPixelGrid(-scrollOffset.x);
			position.y = GUIUtility.RoundToPixelGrid(-scrollOffset.y);
			this.contentContainer.transform.position = position;
			base.IncrementVersion(VersionChangeType.Repaint);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0003655C File Offset: 0x0003475C
		public void ScrollTo(VisualElement child)
		{
			bool flag = child == null;
			if (flag)
			{
				throw new ArgumentNullException("child");
			}
			bool flag2 = !this.contentContainer.Contains(child);
			if (flag2)
			{
				throw new ArgumentException("Cannot scroll to a VisualElement that is not a child of the ScrollView content-container.");
			}
			float num = 0f;
			float num2 = 0f;
			bool flag3 = this.scrollableHeight > 0f;
			if (flag3)
			{
				num = this.GetYDeltaOffset(child);
				this.verticalScroller.value = this.scrollOffset.y + num;
			}
			bool flag4 = this.scrollableWidth > 0f;
			if (flag4)
			{
				num2 = this.GetXDeltaOffset(child);
				this.horizontalScroller.value = this.scrollOffset.x + num2;
			}
			bool flag5 = num == 0f && num2 == 0f;
			if (!flag5)
			{
				this.UpdateContentViewTransform();
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00036638 File Offset: 0x00034838
		public float GetXDeltaOffset(VisualElement child)
		{
			float num = this.contentContainer.transform.position.x * -1f;
			Rect worldBound = this.contentViewport.worldBound;
			float num2 = worldBound.xMin + num;
			float num3 = worldBound.xMax + num;
			Rect worldBound2 = child.worldBound;
			float num4 = worldBound2.xMin + num;
			float num5 = worldBound2.xMax + num;
			bool flag = (num4 >= num2 && num5 <= num3) || Single.IsNaN(num4) || Single.IsNaN(num5);
			float num6;
			if (flag)
			{
				num6 = 0f;
			}
			else
			{
				float deltaDistance = this.GetDeltaDistance(num2, num3, num4, num5);
				num6 = deltaDistance * this.horizontalScroller.highValue / this.scrollableWidth;
			}
			return num6;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x000366F8 File Offset: 0x000348F8
		public float GetYDeltaOffset(VisualElement child)
		{
			float num = this.contentContainer.transform.position.y * -1f;
			Rect worldBound = this.contentViewport.worldBound;
			float num2 = worldBound.yMin + num;
			float num3 = worldBound.yMax + num;
			Rect worldBound2 = child.worldBound;
			float num4 = worldBound2.yMin + num;
			float num5 = worldBound2.yMax + num;
			bool flag = (num4 >= num2 && num5 <= num3) || Single.IsNaN(num4) || Single.IsNaN(num5);
			float num6;
			if (flag)
			{
				num6 = 0f;
			}
			else
			{
				float deltaDistance = this.GetDeltaDistance(num2, num3, num4, num5);
				num6 = deltaDistance * this.verticalScroller.highValue / this.scrollableHeight;
			}
			return num6;
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x000367B8 File Offset: 0x000349B8
		public float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax)
		{
			float num = viewMax - viewMin;
			float num2 = childBoundaryMax - childBoundaryMin;
			bool flag = num2 > num;
			float num3;
			if (flag)
			{
				bool flag2 = viewMin > childBoundaryMin && childBoundaryMax > viewMax;
				if (flag2)
				{
					num3 = 0f;
				}
				else
				{
					num3 = ((childBoundaryMin > viewMin) ? (childBoundaryMin - viewMin) : (childBoundaryMax - viewMax));
				}
			}
			else
			{
				float num4 = childBoundaryMax - viewMax;
				bool flag3 = num4 < -1f;
				if (flag3)
				{
					num4 = childBoundaryMin - viewMin;
				}
				num3 = num4;
			}
			return num3;
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00009DCD File Offset: 0x00007FCD
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00009DDA File Offset: 0x00007FDA
		public VisualElement contentViewport
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x00009DE7 File Offset: 0x00007FE7
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x00009DF4 File Offset: 0x00007FF4
		public Scroller horizontalScroller
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00009E01 File Offset: 0x00008001
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x00009E0E File Offset: 0x0000800E
		public Scroller verticalScroller
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x00009E1B File Offset: 0x0000801B
		public override VisualElement contentContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00009E28 File Offset: 0x00008028
		public void SetScrollViewMode(ScrollViewMode scrollViewMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00036824 File Offset: 0x00034A24
		public void OnAttachToPanel(AttachToPanelEvent evt)
		{
			bool flag = evt.destinationPanel == null;
			if (!flag)
			{
				bool flag2 = evt.destinationPanel.contextType == ContextType.Player;
				if (flag2)
				{
					this.contentViewport.RegisterCallback<PointerDownEvent>(new EventCallback<PointerDownEvent>(this.OnPointerDown), TrickleDown.TrickleDown);
					this.contentViewport.RegisterCallback<PointerMoveEvent>(new EventCallback<PointerMoveEvent>(this.OnPointerMove), TrickleDown.NoTrickleDown);
					this.contentViewport.RegisterCallback<PointerCancelEvent>(new EventCallback<PointerCancelEvent>(this.OnPointerCancel), TrickleDown.NoTrickleDown);
					this.contentViewport.RegisterCallback<PointerUpEvent>(new EventCallback<PointerUpEvent>(this.OnPointerUp), TrickleDown.TrickleDown);
					this.contentContainer.RegisterCallback<PointerCaptureEvent>(new EventCallback<PointerCaptureEvent>(this.OnPointerCapture), TrickleDown.NoTrickleDown);
					this.contentContainer.RegisterCallback<PointerCaptureOutEvent>(new EventCallback<PointerCaptureOutEvent>(this.OnPointerCaptureOut), TrickleDown.NoTrickleDown);
				}
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000368F4 File Offset: 0x00034AF4
		public void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
			bool flag = evt.originPanel == null;
			if (!flag)
			{
				bool flag2 = evt.originPanel.contextType == ContextType.Player;
				if (flag2)
				{
					this.contentViewport.UnregisterCallback<PointerDownEvent>(new EventCallback<PointerDownEvent>(this.OnPointerDown), TrickleDown.TrickleDown);
					this.contentViewport.UnregisterCallback<PointerMoveEvent>(new EventCallback<PointerMoveEvent>(this.OnPointerMove), TrickleDown.NoTrickleDown);
					this.contentViewport.UnregisterCallback<PointerCancelEvent>(new EventCallback<PointerCancelEvent>(this.OnPointerCancel), TrickleDown.NoTrickleDown);
					this.contentViewport.UnregisterCallback<PointerUpEvent>(new EventCallback<PointerUpEvent>(this.OnPointerUp), TrickleDown.TrickleDown);
					this.contentContainer.UnregisterCallback<PointerCaptureEvent>(new EventCallback<PointerCaptureEvent>(this.OnPointerCapture), TrickleDown.NoTrickleDown);
					this.contentContainer.UnregisterCallback<PointerCaptureOutEvent>(new EventCallback<PointerCaptureOutEvent>(this.OnPointerCaptureOut), TrickleDown.NoTrickleDown);
				}
			}
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00009E35 File Offset: 0x00008035
		public void OnPointerCapture(PointerCaptureEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00009E42 File Offset: 0x00008042
		public void OnPointerCaptureOut(PointerCaptureOutEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000369C4 File Offset: 0x00034BC4
		public void OnGeometryChanged(GeometryChangedEvent evt)
		{
			bool flag = evt.oldRect.size == evt.newRect.size;
			if (!flag)
			{
				bool flag2 = this.needsVertical;
				bool flag3 = this.needsHorizontal;
				bool flag4 = evt.layoutPass > 0;
				if (flag4)
				{
					flag2 = flag2 || this.verticalScroller.visible;
					flag3 = flag3 || this.horizontalScroller.visible;
				}
				this.UpdateScrollers(flag3, flag2);
				this.UpdateContentViewTransform();
			}
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00036A50 File Offset: 0x00034C50
		public static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit)
		{
			initialScrollOffset = Mathf.Max(initialScrollOffset, hardLowLimit * 0.95f);
			initialScrollOffset = Mathf.Min(initialScrollOffset, hardHighLimit * 0.95f);
			bool flag = initialScrollOffset < lowLimit && hardLowLimit < lowLimit;
			float num;
			float num3;
			if (flag)
			{
				num = lowLimit - hardLowLimit;
				float num2 = (lowLimit - initialScrollOffset) / num;
				num3 = num2 * num / (1f - num2);
				num3 += deltaPointer;
				initialScrollOffset = lowLimit;
			}
			else
			{
				bool flag2 = initialScrollOffset > highLimit && hardHighLimit > highLimit;
				if (flag2)
				{
					num = hardHighLimit - highLimit;
					float num4 = (initialScrollOffset - highLimit) / num;
					num3 = -1f * num4 * num / (1f - num4);
					num3 += deltaPointer;
					initialScrollOffset = highLimit;
				}
				else
				{
					num3 = deltaPointer;
				}
			}
			float num5 = initialScrollOffset - num3;
			bool flag3 = num5 < lowLimit;
			float num6;
			if (flag3)
			{
				num3 = lowLimit - num5;
				initialScrollOffset = lowLimit;
				num = lowLimit - hardLowLimit;
				num6 = 1f;
			}
			else
			{
				bool flag4 = num5 <= highLimit;
				if (flag4)
				{
					return num5;
				}
				num3 = num5 - highLimit;
				initialScrollOffset = highLimit;
				num = hardHighLimit - highLimit;
				num6 = -1f;
			}
			bool flag5 = Mathf.Abs(num3) < Mathf.Epsilon;
			float num7;
			if (flag5)
			{
				num7 = initialScrollOffset;
			}
			else
			{
				float num8 = num3 / (num3 + num);
				num8 *= num;
				num8 *= num6;
				num5 = initialScrollOffset - num8;
				num7 = num5;
			}
			return num7;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00009E4F File Offset: 0x0000804F
		public void ComputeInitialSpringBackVelocity()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00009E5C File Offset: 0x0000805C
		public void SpringBack()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00009E69 File Offset: 0x00008069
		public void ApplyScrollInertia()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00009E76 File Offset: 0x00008076
		public void PostPointerUpAnimation()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00009E83 File Offset: 0x00008083
		public void OnPointerDown(PointerDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00009E90 File Offset: 0x00008090
		public void OnPointerMove(PointerMoveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00036B80 File Offset: 0x00034D80
		public void OnPointerCancel(PointerCancelEvent evt)
		{
			bool flag = evt.target == this.contentContainer;
			if (flag)
			{
				this.ReleaseScrolling<PointerCancelEvent>(evt);
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00009E9D File Offset: 0x0000809D
		public void OnPointerUp(PointerUpEvent evt)
		{
			this.ReleaseScrolling<PointerUpEvent>(evt);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00009EA8 File Offset: 0x000080A8
		public void CancelTargetAndCapturePointer<T>(T evt) where T : PointerEventBase<T>, new()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00009EB5 File Offset: 0x000080B5
		public void ReleaseScrolling<T>(T evt) where T : PointerEventBase<T>, new()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00009EC2 File Offset: 0x000080C2
		public void UpdateScrollers(bool displayHorizontal, bool displayVertical)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00036BAC File Offset: 0x00034DAC
		public void OnScrollWheel(WheelEvent evt)
		{
			bool flag = this.contentContainer.boundingBox.height - base.layout.height > 0f;
			if (flag)
			{
				float value = this.verticalScroller.value;
				bool flag2 = evt.delta.y < 0f;
				if (flag2)
				{
					this.verticalScroller.ScrollPageUp(Mathf.Abs(evt.delta.y));
				}
				else
				{
					bool flag3 = evt.delta.y > 0f;
					if (flag3)
					{
						this.verticalScroller.ScrollPageDown(Mathf.Abs(evt.delta.y));
					}
				}
				bool flag4 = this.verticalScroller.value != value;
				if (flag4)
				{
					evt.StopPropagation();
				}
			}
			bool flag5 = this.contentContainer.boundingBox.width - base.layout.width > 0f;
			if (flag5)
			{
				float value2 = this.horizontalScroller.value;
				bool flag6 = evt.delta.x < 0f;
				if (flag6)
				{
					this.horizontalScroller.ScrollPageUp(Mathf.Abs(evt.delta.x));
				}
				else
				{
					bool flag7 = evt.delta.x > 0f;
					if (flag7)
					{
						this.horizontalScroller.ScrollPageDown(Mathf.Abs(evt.delta.x));
					}
				}
				bool flag8 = this.horizontalScroller.value != value2;
				if (flag8)
				{
					evt.StopPropagation();
				}
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00009ECF File Offset: 0x000080CF
		public void <.ctor>b__80_0(float value)
		{
			this.scrollOffset = new Vector2(value, this.scrollOffset.y);
			this.UpdateContentViewTransform();
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00009EF1 File Offset: 0x000080F1
		public void <.ctor>b__80_1(float value)
		{
			this.scrollOffset = new Vector2(this.scrollOffset.x, value);
			this.UpdateContentViewTransform();
		}

		// Token: 0x040007C8 RID: 1992
		public const float k_VelocityLerpTimeFactor = 10f;

		// Token: 0x040007C9 RID: 1993
		public const float k_ScrollThresholdSquared = 25f;

		// Token: 0x02000267 RID: 615
		public new class UxmlFactory : UxmlFactory<ScrollView, ScrollView.UxmlTraits>
		{
		}

		// Token: 0x02000268 RID: 616
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
		}

		// Token: 0x02000269 RID: 617
		public enum TouchScrollBehavior
		{
			// Token: 0x0400091E RID: 2334
			Unrestricted,
			// Token: 0x0400091F RID: 2335
			Elastic,
			// Token: 0x04000920 RID: 2336
			Clamped
		}
	}
}
