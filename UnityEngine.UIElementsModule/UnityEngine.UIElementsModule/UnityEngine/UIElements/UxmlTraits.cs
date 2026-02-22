using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001AB RID: 427
	public abstract class UxmlTraits
	{
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0000B2F0 File Offset: 0x000094F0
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x0000B2FD File Offset: 0x000094FD
		public bool canHaveAnyAttribute
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

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0000B30A File Offset: 0x0000950A
		public virtual IEnumerable<UxmlAttributeDescription> uxmlAttributesDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0000B317 File Offset: 0x00009517
		public virtual IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0000B324 File Offset: 0x00009524
		public IEnumerable<UxmlAttributeDescription> GetAllAttributeDescriptionForType(Type t)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000288 RID: 648
		public sealed class <get_uxmlAttributesDescription>d__6
		{
		}

		// Token: 0x02000289 RID: 649
		public sealed class <get_uxmlChildElementsDescription>d__8
		{
		}

		// Token: 0x0200028A RID: 650
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x0200028B RID: 651
		public sealed class <GetAllAttributeDescriptionForType>d__10
		{
		}
	}
}
