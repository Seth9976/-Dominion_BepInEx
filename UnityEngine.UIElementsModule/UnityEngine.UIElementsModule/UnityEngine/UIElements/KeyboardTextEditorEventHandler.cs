using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000144 RID: 324
	public class KeyboardTextEditorEventHandler : TextEditorEventHandler
	{
		// Token: 0x06000EAA RID: 3754 RVA: 0x00035E98 File Offset: 0x00034098
		public override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			base.ExecuteDefaultActionAtTarget(evt);
			bool flag = evt.eventTypeId == EventBase<FocusEvent>.TypeId();
			if (flag)
			{
				this.OnFocus(evt.TryCast<FocusEvent>());
			}
			else
			{
				bool flag2 = evt.eventTypeId == EventBase<BlurEvent>.TypeId();
				if (flag2)
				{
					this.OnBlur(evt.TryCast<BlurEvent>());
				}
				else
				{
					bool flag3 = evt.eventTypeId == EventBase<MouseDownEvent>.TypeId();
					if (flag3)
					{
						this.OnMouseDown(evt.TryCast<MouseDownEvent>());
					}
					else
					{
						bool flag4 = evt.eventTypeId == EventBase<MouseUpEvent>.TypeId();
						if (flag4)
						{
							this.OnMouseUp(evt.TryCast<MouseUpEvent>());
						}
						else
						{
							bool flag5 = evt.eventTypeId == EventBase<MouseMoveEvent>.TypeId();
							if (flag5)
							{
								this.OnMouseMove(evt.TryCast<MouseMoveEvent>());
							}
							else
							{
								bool flag6 = evt.eventTypeId == EventBase<KeyDownEvent>.TypeId();
								if (flag6)
								{
									this.OnKeyDown(evt.TryCast<KeyDownEvent>());
								}
								else
								{
									bool flag7 = evt.eventTypeId == EventBase<ValidateCommandEvent>.TypeId();
									if (flag7)
									{
										this.OnValidateCommandEvent(evt.TryCast<ValidateCommandEvent>());
									}
									else
									{
										bool flag8 = evt.eventTypeId == EventBase<ExecuteCommandEvent>.TypeId();
										if (flag8)
										{
											this.OnExecuteCommandEvent(evt.TryCast<ExecuteCommandEvent>());
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00009576 File Offset: 0x00007776
		public void OnFocus(FocusEvent _)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00009583 File Offset: 0x00007783
		public void OnBlur(BlurEvent _)
		{
			GUIUtility.imeCompositionMode = IMECompositionMode.Auto;
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0000958D File Offset: 0x0000778D
		public void OnMouseDown(MouseDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0000959A File Offset: 0x0000779A
		public void OnMouseUp(MouseUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x000095A7 File Offset: 0x000077A7
		public void OnMouseMove(MouseMoveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x000095B4 File Offset: 0x000077B4
		public void OnKeyDown(KeyDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x000095C1 File Offset: 0x000077C1
		public void OnValidateCommandEvent(ValidateCommandEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000095CE File Offset: 0x000077CE
		public void OnExecuteCommandEvent(ExecuteCommandEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000095DB File Offset: 0x000077DB
		public void PreDrawCursor(string newText)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x000095E8 File Offset: 0x000077E8
		public void PostDrawCursor()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
