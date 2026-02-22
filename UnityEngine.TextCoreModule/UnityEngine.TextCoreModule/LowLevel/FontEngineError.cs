using System;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200000B RID: 11
	public enum FontEngineError
	{
		// Token: 0x0400009C RID: 156
		Success,
		// Token: 0x0400009D RID: 157
		Invalid_File_Path,
		// Token: 0x0400009E RID: 158
		Invalid_File_Format,
		// Token: 0x0400009F RID: 159
		Invalid_File_Structure,
		// Token: 0x040000A0 RID: 160
		Invalid_File,
		// Token: 0x040000A1 RID: 161
		Invalid_Table = 8,
		// Token: 0x040000A2 RID: 162
		Invalid_Glyph_Index = 16,
		// Token: 0x040000A3 RID: 163
		Invalid_Character_Code,
		// Token: 0x040000A4 RID: 164
		Invalid_Pixel_Size = 23,
		// Token: 0x040000A5 RID: 165
		Invalid_Library = 33,
		// Token: 0x040000A6 RID: 166
		Invalid_Face = 35,
		// Token: 0x040000A7 RID: 167
		Invalid_Library_or_Face = 41,
		// Token: 0x040000A8 RID: 168
		Atlas_Generation_Cancelled = 100,
		// Token: 0x040000A9 RID: 169
		Invalid_SharedTextureData
	}
}
