using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000159 RID: 345
	public class Toggle : BaseBoolField
	{
		// Token: 0x06000FA7 RID: 4007 RVA: 0x0000A027 File Offset: 0x00008227
		public override void InitLabel()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000271 RID: 625
		public class UxmlFactory : UxmlFactory<Toggle, Toggle.UxmlTraits>
		{
		}

		// Token: 0x02000272 RID: 626
		public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
		{
		}
	}
}
