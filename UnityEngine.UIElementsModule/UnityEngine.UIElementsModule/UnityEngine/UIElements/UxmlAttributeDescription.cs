using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A1 RID: 417
	public abstract class UxmlAttributeDescription
	{
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0000B1B8 File Offset: 0x000093B8
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x0000B1C5 File Offset: 0x000093C5
		public string name
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

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0000B1D2 File Offset: 0x000093D2
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x0000B1DF File Offset: 0x000093DF
		public IEnumerable<string> obsoleteNames
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

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0000B1EC File Offset: 0x000093EC
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x0000B1F9 File Offset: 0x000093F9
		public string type
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0000B206 File Offset: 0x00009406
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x0000B213 File Offset: 0x00009413
		public string typeNamespace
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

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0000B220 File Offset: 0x00009420
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x0000B22D File Offset: 0x0000942D
		public UxmlAttributeDescription.Use use
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

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x0000B23A File Offset: 0x0000943A
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x0000B247 File Offset: 0x00009447
		public UxmlTypeRestriction restriction
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

		// Token: 0x040007F8 RID: 2040
		public const string xmlSchemaNamespace = "http://www.w3.org/2001/XMLSchema";

		// Token: 0x0200027F RID: 639
		public enum Use
		{
			// Token: 0x04000922 RID: 2338
			None,
			// Token: 0x04000923 RID: 2339
			Optional,
			// Token: 0x04000924 RID: 2340
			Prohibited,
			// Token: 0x04000925 RID: 2341
			Required
		}
	}
}
