using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011E RID: 286
	public class TextElement : BindableElement
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00008CB1 File Offset: 0x00006EB1
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x00008CBE File Offset: 0x00006EBE
		public ITextHandle textHandle
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

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00035180 File Offset: 0x00033380
		public override void HandleEvent(EventBase evt)
		{
			AttachToPanelEvent attachToPanelEvent;
			bool flag;
			if (evt.eventTypeId == EventBase<AttachToPanelEvent>.TypeId())
			{
				attachToPanelEvent = evt.TryCast<AttachToPanelEvent>();
				flag = attachToPanelEvent != null;
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			if (flag2)
			{
				this.textHandle = ((attachToPanelEvent.destinationPanel.contextType == ContextType.Editor) ? TextHandleFactory.GetEditorHandle() : TextHandleFactory.GetRuntimeHandle());
			}
			else
			{
				bool flag3;
				if (evt.eventTypeId == EventBase<DetachFromPanelEvent>.TypeId())
				{
					DetachFromPanelEvent detachFromPanelEvent = evt.TryCast<DetachFromPanelEvent>();
					flag3 = detachFromPanelEvent != null;
				}
				else
				{
					flag3 = false;
				}
				bool flag4 = flag3;
				if (flag4)
				{
				}
			}
			base.HandleEvent(evt);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00008CCB File Offset: 0x00006ECB
		public void OnGeometryChanged(GeometryChangedEvent e)
		{
			this.UpdateVisibleText();
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x00008CD5 File Offset: 0x00006ED5
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x00008CE2 File Offset: 0x00006EE2
		public virtual string text
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

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00008CEF File Offset: 0x00006EEF
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x00008CFC File Offset: 0x00006EFC
		public bool enableRichText
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x00008D09 File Offset: 0x00006F09
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x00008D16 File Offset: 0x00006F16
		public bool displayTooltipWhenElided
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

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x00008D23 File Offset: 0x00006F23
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x00008D30 File Offset: 0x00006F30
		public bool isElided
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

		// Token: 0x06000DEB RID: 3563 RVA: 0x00008D3D File Offset: 0x00006F3D
		public void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000351FC File Offset: 0x000333FC
		public string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition)
		{
			float num = base.resolvedStyle.paddingRight;
			bool flag = Single.IsNaN(num);
			if (flag)
			{
				num = 0f;
			}
			float num2 = Mathf.Clamp(num, 1f / base.scaledPixelsPerPoint, 1f);
			Vector2 vector = this.MeasureTextSize(drawText, 0f, VisualElement.MeasureMode.Undefined, 0f, VisualElement.MeasureMode.Undefined);
			bool flag2 = vector.x <= width + num2 || String.IsNullOrEmpty(ellipsisText);
			string text;
			if (flag2)
			{
				text = drawText;
			}
			else
			{
				string text2 = ((drawText.Length > 1) ? ellipsisText : drawText);
				Vector2 vector2 = this.MeasureTextSize(text2, 0f, VisualElement.MeasureMode.Undefined, 0f, VisualElement.MeasureMode.Undefined);
				bool flag3 = vector2.x >= width;
				if (flag3)
				{
					text = text2;
				}
				else
				{
					int num3 = drawText.Length - 1;
					int num4 = -1;
					string text3 = drawText;
					int i = ((textOverflowPosition == TextOverflowPosition.Start) ? 1 : 0);
					int num5 = ((textOverflowPosition == TextOverflowPosition.Start || textOverflowPosition == TextOverflowPosition.Middle) ? num3 : (num3 - 1));
					int num6 = (i + num5) / 2;
					while (i <= num5)
					{
						bool flag4 = textOverflowPosition == TextOverflowPosition.Start;
						if (flag4)
						{
							text3 = String.Concat(ellipsisText, drawText.Substring(num6, num3 - (num6 - 1)));
						}
						else
						{
							bool flag5 = textOverflowPosition == TextOverflowPosition.End;
							if (flag5)
							{
								text3 = String.Concat(drawText.Substring(0, num6), ellipsisText);
							}
							else
							{
								bool flag6 = textOverflowPosition == TextOverflowPosition.Middle;
								if (flag6)
								{
									text3 = String.Concat(drawText.Substring(0, num6 - 1), ellipsisText, drawText.Substring(num3 - (num6 - 1)));
								}
							}
						}
						vector = this.MeasureTextSize(text3, 0f, VisualElement.MeasureMode.Undefined, 0f, VisualElement.MeasureMode.Undefined);
						bool flag7 = Math.Abs(vector.x - width) < Mathf.Epsilon;
						if (flag7)
						{
							return text3;
						}
						bool flag8 = textOverflowPosition == TextOverflowPosition.Start;
						if (flag8)
						{
							bool flag9 = vector.x > width;
							if (flag9)
							{
								bool flag10 = num4 == num6 - 1;
								if (flag10)
								{
									return String.Concat(ellipsisText, drawText.Substring(num4, num3 - (num4 - 1)));
								}
								i = num6 + 1;
							}
							else
							{
								num5 = num6 - 1;
								num4 = num6;
							}
						}
						else
						{
							bool flag11 = textOverflowPosition == TextOverflowPosition.End || textOverflowPosition == TextOverflowPosition.Middle;
							if (flag11)
							{
								bool flag12 = vector.x > width;
								if (flag12)
								{
									bool flag13 = num4 == num6 - 1;
									if (flag13)
									{
										bool flag14 = textOverflowPosition == TextOverflowPosition.End;
										if (flag14)
										{
											return String.Concat(drawText.Substring(0, num4), ellipsisText);
										}
										return String.Concat(drawText.Substring(0, num4 - 1), ellipsisText, drawText.Substring(num3 - (num4 - 1)));
									}
									else
									{
										num5 = num6 - 1;
									}
								}
								else
								{
									i = num6 + 1;
									num4 = num6;
								}
							}
						}
						num6 = (i + num5) / 2;
					}
					text = text3;
				}
			}
			return text;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00008D4A File Offset: 0x00006F4A
		public void UpdateTooltip()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00008D57 File Offset: 0x00006F57
		public void UpdateVisibleText()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x000354A4 File Offset: 0x000336A4
		public bool ShouldElide()
		{
			return base.computedStyle.textOverflow == TextOverflow.Ellipsis && base.computedStyle.overflow == OverflowInternal.Hidden && base.computedStyle.whiteSpace == WhiteSpace.NoWrap;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00008D64 File Offset: 0x00006F64
		public Vector2 MeasureTextSize(string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000354E4 File Offset: 0x000336E4
		public override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			return this.MeasureTextSize(this.text, desiredWidth, widthMode, desiredHeight, heightMode);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00008D71 File Offset: 0x00006F71
		public int VerticesCount(string text)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00008D7E File Offset: 0x00006F7E
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x00008D8B File Offset: 0x00006F8B
		public string UnityEngine.UIElements.INotifyValueChanged<System.String>.value
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

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00008D98 File Offset: 0x00006F98
		public void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000237 RID: 567
		public new class UxmlFactory : UxmlFactory<TextElement, TextElement.UxmlTraits>
		{
		}

		// Token: 0x02000238 RID: 568
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x020002A1 RID: 673
			public sealed class <get_uxmlChildElementsDescription>d__4
			{
			}
		}
	}
}
