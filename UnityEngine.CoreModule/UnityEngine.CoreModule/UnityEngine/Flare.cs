using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020001F0 RID: 496
	public sealed class Flare : Object
	{
		// Token: 0x06001E64 RID: 7780 RVA: 0x00011406 File Offset: 0x0000F606
		public static void Internal_Create(Flare self)
		{
			Flare.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x04001783 RID: 6019
		private static readonly Flare.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Flare.Internal_CreateDelegate>("UnityEngine.Flare::Internal_Create");

		// Token: 0x02000B9E RID: 2974
		// (Invoke) Token: 0x0600353A RID: 13626
		private delegate void Internal_CreateDelegate(IntPtr self);
	}
}
