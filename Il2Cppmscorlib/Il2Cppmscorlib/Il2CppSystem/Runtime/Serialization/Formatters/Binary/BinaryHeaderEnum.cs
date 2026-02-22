using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000369 RID: 873
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryHeaderEnum")]
	[Serializable]
	public enum BinaryHeaderEnum
	{
		// Token: 0x04002EDA RID: 11994
		SerializedStreamHeader,
		// Token: 0x04002EDB RID: 11995
		Object,
		// Token: 0x04002EDC RID: 11996
		ObjectWithMap,
		// Token: 0x04002EDD RID: 11997
		ObjectWithMapAssemId,
		// Token: 0x04002EDE RID: 11998
		ObjectWithMapTyped,
		// Token: 0x04002EDF RID: 11999
		ObjectWithMapTypedAssemId,
		// Token: 0x04002EE0 RID: 12000
		ObjectString,
		// Token: 0x04002EE1 RID: 12001
		Array,
		// Token: 0x04002EE2 RID: 12002
		MemberPrimitiveTyped,
		// Token: 0x04002EE3 RID: 12003
		MemberReference,
		// Token: 0x04002EE4 RID: 12004
		ObjectNull,
		// Token: 0x04002EE5 RID: 12005
		MessageEnd,
		// Token: 0x04002EE6 RID: 12006
		Assembly,
		// Token: 0x04002EE7 RID: 12007
		ObjectNullMultiple256,
		// Token: 0x04002EE8 RID: 12008
		ObjectNullMultiple,
		// Token: 0x04002EE9 RID: 12009
		ArraySinglePrimitive,
		// Token: 0x04002EEA RID: 12010
		ArraySingleObject,
		// Token: 0x04002EEB RID: 12011
		ArraySingleString,
		// Token: 0x04002EEC RID: 12012
		CrossAppDomainMap,
		// Token: 0x04002EED RID: 12013
		CrossAppDomainString,
		// Token: 0x04002EEE RID: 12014
		CrossAppDomainAssembly,
		// Token: 0x04002EEF RID: 12015
		MethodCall,
		// Token: 0x04002EF0 RID: 12016
		MethodReturn
	}
}
