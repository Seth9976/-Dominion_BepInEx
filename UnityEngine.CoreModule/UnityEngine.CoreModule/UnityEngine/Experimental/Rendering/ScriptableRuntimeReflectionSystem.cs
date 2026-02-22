using System;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002D0 RID: 720
	public abstract class ScriptableRuntimeReflectionSystem
	{
		// Token: 0x060022F5 RID: 8949 RVA: 0x0006A8D8 File Offset: 0x00068AD8
		public virtual bool TickRealtimeProbes()
		{
			return false;
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00014845 File Offset: 0x00012A45
		public virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00014848 File Offset: 0x00012A48
		public void System.IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
