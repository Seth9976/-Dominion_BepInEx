using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x02000262 RID: 610
	public class ListSerializationSurrogate
	{
		// Token: 0x06001FF0 RID: 8176 RVA: 0x00066FCC File Offset: 0x000651CC
		public void GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
		{
			IList list = obj.Cast<IList>();
			info.AddValue("_size", list.Count);
			info.AddValue("_items", ListSerializationSurrogate.ArrayFromGenericList(list));
			info.AddValue("_version", 0);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00067014 File Offset: 0x00065214
		public Object SetObjectData(Object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			IList list = Activator.CreateInstance(obj.GetType()).Cast<IList>();
			int @int = info.GetInt32("_size");
			bool flag = @int == 0;
			Object @object;
			if (flag)
			{
				@object = list;
			}
			else
			{
				IEnumerator enumerator = info.GetValue("_items", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<IEnumerable>())).Cast<IEnumerable>().GetEnumerator();
				for (int i = 0; i < @int; i++)
				{
					bool flag2 = !enumerator.MoveNext();
					if (flag2)
					{
						throw new InvalidOperationException();
					}
					list.Add(enumerator.Current);
				}
				@object = list;
			}
			return @object;
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x0001272E File Offset: 0x0001092E
		public static Array ArrayFromGenericList(IList list)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
