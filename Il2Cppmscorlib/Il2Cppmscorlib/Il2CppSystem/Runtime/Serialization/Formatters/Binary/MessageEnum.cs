using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000374 RID: 884
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "MessageEnum")]
	[Flags]
	[Serializable]
	public enum MessageEnum
	{
		// Token: 0x04002F41 RID: 12097
		NoArgs = 1,
		// Token: 0x04002F42 RID: 12098
		ArgsInline = 2,
		// Token: 0x04002F43 RID: 12099
		ArgsIsArray = 4,
		// Token: 0x04002F44 RID: 12100
		ArgsInArray = 8,
		// Token: 0x04002F45 RID: 12101
		NoContext = 16,
		// Token: 0x04002F46 RID: 12102
		ContextInline = 32,
		// Token: 0x04002F47 RID: 12103
		ContextInArray = 64,
		// Token: 0x04002F48 RID: 12104
		MethodSignatureInArray = 128,
		// Token: 0x04002F49 RID: 12105
		PropertyInArray = 256,
		// Token: 0x04002F4A RID: 12106
		NoReturnValue = 512,
		// Token: 0x04002F4B RID: 12107
		ReturnValueVoid = 1024,
		// Token: 0x04002F4C RID: 12108
		ReturnValueInline = 2048,
		// Token: 0x04002F4D RID: 12109
		ReturnValueInArray = 4096,
		// Token: 0x04002F4E RID: 12110
		ExceptionInArray = 8192,
		// Token: 0x04002F4F RID: 12111
		GenericMethod = 32768
	}
}
