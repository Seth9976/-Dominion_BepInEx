using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000138 RID: 312
	public static class IBindingExtensions
	{
		// Token: 0x06000E64 RID: 3684 RVA: 0x00035AEC File Offset: 0x00033CEC
		public static bool IsBound(IBindable control)
		{
			return ((control != null) ? control.binding : null) != null;
		}
	}
}
