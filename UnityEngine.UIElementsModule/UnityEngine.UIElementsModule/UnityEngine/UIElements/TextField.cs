using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000157 RID: 343
	public class TextField : TextInputBaseField<string>
	{
		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00009FBF File Offset: 0x000081BF
		public TextField.TextInput textInput
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00036EC0 File Offset: 0x000350C0
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00009FCC File Offset: 0x000081CC
		public bool multiline
		{
			get
			{
				return this.textInput.multiline;
			}
			set
			{
				this.textInput.multiline = value;
			}
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00009FDC File Offset: 0x000081DC
		public void SelectRange(int rangeCursorIndex, int selectionIndex)
		{
			this.textInput.SelectRange(rangeCursorIndex, selectionIndex);
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00009FED File Offset: 0x000081ED
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x00009FFA File Offset: 0x000081FA
		public override string value
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

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0000A007 File Offset: 0x00008207
		public override void SetValueWithoutNotify(string newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0000A014 File Offset: 0x00008214
		public override void OnViewDataReady()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0000A021 File Offset: 0x00008221
		public override string ValueToString(string value)
		{
			return value;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0000A024 File Offset: 0x00008224
		public override string StringToValue(string str)
		{
			return str;
		}

		// Token: 0x0200026E RID: 622
		public class UxmlFactory : UxmlFactory<TextField, TextField.UxmlTraits>
		{
		}

		// Token: 0x0200026F RID: 623
		public class UxmlTraits : TextInputBaseField<string>.UxmlTraits
		{
		}

		// Token: 0x02000270 RID: 624
		public class TextInput : TextInputBaseField<string>.TextInputBase
		{
		}
	}
}
