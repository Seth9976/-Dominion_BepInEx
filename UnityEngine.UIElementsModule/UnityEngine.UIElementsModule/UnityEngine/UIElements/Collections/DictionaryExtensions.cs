using System;
using System.Runtime.InteropServices;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.Collections
{
	// Token: 0x020001CD RID: 461
	public static class DictionaryExtensions
	{
		// Token: 0x06001284 RID: 4740 RVA: 0x000396DC File Offset: 0x000378DC
		public static TValue Get<TKey, TValue>(IDictionary<TKey, TValue> dict, TKey key, [Optional] TValue fallbackValue)
		{
			TValue tvalue;
			return dict.TryGetValue(key, out tvalue) ? tvalue : fallbackValue;
		}
	}
}
