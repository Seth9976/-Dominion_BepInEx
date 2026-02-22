using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000FF RID: 255
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "XmlSchemaValidationFlags")]
	[Flags]
	public enum XmlSchemaValidationFlags
	{
		// Token: 0x04000B3F RID: 2879
		None = 0,
		// Token: 0x04000B40 RID: 2880
		ProcessInlineSchema = 1,
		// Token: 0x04000B41 RID: 2881
		ProcessSchemaLocation = 2,
		// Token: 0x04000B42 RID: 2882
		ReportValidationWarnings = 4,
		// Token: 0x04000B43 RID: 2883
		ProcessIdentityConstraints = 8,
		// Token: 0x04000B44 RID: 2884
		AllowXmlAttributes = 16
	}
}
