using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020001B9 RID: 441
	public abstract class BaseShaderInfoStorage
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x0000B9CA File Offset: 0x00009BCA
		// (set) Token: 0x06001200 RID: 4608 RVA: 0x0000B9D7 File Offset: 0x00009BD7
		public bool disposed
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

		// Token: 0x06001201 RID: 4609 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00039020 File Offset: 0x00037220
		public virtual void Dispose(bool disposing)
		{
			bool disposed = this.disposed;
			if (!disposed)
			{
				bool flag = !disposing;
				if (flag)
				{
				}
				this.disposed = true;
			}
		}
	}
}
