using System;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x02000261 RID: 609
	public class UnitySurrogateSelector
	{
		// Token: 0x06001FED RID: 8173 RVA: 0x00012711 File Offset: 0x00010911
		public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0001271E File Offset: 0x0001091E
		public void ChainSelector(ISurrogateSelector selector)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00012726 File Offset: 0x00010926
		public ISurrogateSelector GetNextSelector()
		{
			throw new NotImplementedException();
		}
	}
}
