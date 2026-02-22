using System;

namespace UnityEngine.Lumin
{
	// Token: 0x02000273 RID: 627
	public sealed class UsesLuminPrivilegeAttribute : Attribute
	{
		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x00012878 File Offset: 0x00010A78
		public string privilege
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
