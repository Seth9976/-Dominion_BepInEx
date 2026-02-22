using System;

namespace UnityEngine
{
	// Token: 0x020000C4 RID: 196
	[Flags]
	public enum HideFlags
	{
		// Token: 0x04000CE4 RID: 3300
		None = 0,
		// Token: 0x04000CE5 RID: 3301
		HideInHierarchy = 1,
		// Token: 0x04000CE6 RID: 3302
		HideInInspector = 2,
		// Token: 0x04000CE7 RID: 3303
		DontSaveInEditor = 4,
		// Token: 0x04000CE8 RID: 3304
		NotEditable = 8,
		// Token: 0x04000CE9 RID: 3305
		DontSaveInBuild = 16,
		// Token: 0x04000CEA RID: 3306
		DontUnloadUnusedAsset = 32,
		// Token: 0x04000CEB RID: 3307
		DontSave = 52,
		// Token: 0x04000CEC RID: 3308
		HideAndDontSave = 61
	}
}
