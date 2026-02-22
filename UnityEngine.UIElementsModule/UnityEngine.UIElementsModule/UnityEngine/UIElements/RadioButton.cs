using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014C RID: 332
	public class RadioButton : BaseBoolField
	{
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x00009B2F File Offset: 0x00007D2F
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00009B3C File Offset: 0x00007D3C
		public override bool value
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

		// Token: 0x06000F2F RID: 3887 RVA: 0x00009B49 File Offset: 0x00007D49
		public override void InitLabel()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00009B56 File Offset: 0x00007D56
		public override void ToggleValue()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00009B63 File Offset: 0x00007D63
		public void SetSelected(bool selected)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00009B70 File Offset: 0x00007D70
		public override void SetValueWithoutNotify(bool newValue)
		{
			base.SetValueWithoutNotify(newValue);
			this.UpdateCheckmark();
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00009B82 File Offset: 0x00007D82
		public void UpdateCheckmark()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00009B8F File Offset: 0x00007D8F
		public override void UpdateMixedValueContent()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0200025F RID: 607
		public class UxmlFactory : UxmlFactory<RadioButton, RadioButton.UxmlTraits>
		{
		}

		// Token: 0x02000260 RID: 608
		public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
		{
		}
	}
}
