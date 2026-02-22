using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002B0 RID: 688
	public struct ScopedSubPass
	{
		// Token: 0x060021B9 RID: 8633 RVA: 0x000140A8 File Offset: 0x000122A8
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001B71 RID: 7025
		public ScriptableRenderContext m_Context;
	}
}
