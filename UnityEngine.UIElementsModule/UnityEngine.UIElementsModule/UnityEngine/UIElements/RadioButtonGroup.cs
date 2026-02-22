using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014D RID: 333
	public class RadioButtonGroup : BaseField<int>
	{
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00009B9C File Offset: 0x00007D9C
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x00009BA9 File Offset: 0x00007DA9
		public IEnumerable<string> choices
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

		// Token: 0x06000F37 RID: 3895 RVA: 0x00009BB6 File Offset: 0x00007DB6
		public override void SetValueWithoutNotify(int newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00009BC3 File Offset: 0x00007DC3
		public void UpdateRadioButtons()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000261 RID: 609
		public class UxmlFactory : UxmlFactory<RadioButtonGroup, RadioButtonGroup.UxmlTraits>
		{
		}

		// Token: 0x02000262 RID: 610
		public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
		{
		}
	}
}
