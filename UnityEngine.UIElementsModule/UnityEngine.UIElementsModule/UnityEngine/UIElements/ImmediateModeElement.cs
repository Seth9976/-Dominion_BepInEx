using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010A RID: 266
	public abstract class ImmediateModeElement : VisualElement
	{
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00008B88 File Offset: 0x00006D88
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x00008B95 File Offset: 0x00006D95
		public bool cullingEnabled
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

		// Token: 0x06000DBA RID: 3514 RVA: 0x00008BA2 File Offset: 0x00006DA2
		public void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
