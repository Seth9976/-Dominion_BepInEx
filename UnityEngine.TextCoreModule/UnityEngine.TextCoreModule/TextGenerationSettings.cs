using System;
using Il2CppSystem;

namespace UnityEngine.TextCore
{
	// Token: 0x02000027 RID: 39
	public class TextGenerationSettings
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x00002E3A File Offset: 0x0000103A
		public bool Equals(TextGenerationSettings other)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00007078 File Offset: 0x00005278
		public override bool Equals(Object obj)
		{
			bool flag = obj == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = this == obj;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = obj.GetType() != base.GetType();
					flag2 = !flag4 && this.Equals(obj.Cast<TextGenerationSettings>());
				}
			}
			return flag2;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002E47 File Offset: 0x00001047
		public override int GetHashCode()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000070C8 File Offset: 0x000052C8
		public static bool operator ==(TextGenerationSettings left, TextGenerationSettings right)
		{
			return Object.Equals(left, right);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000070E4 File Offset: 0x000052E4
		public static bool operator !=(TextGenerationSettings left, TextGenerationSettings right)
		{
			return !Object.Equals(left, right);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002E54 File Offset: 0x00001054
		public void Copy(TextGenerationSettings other)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
