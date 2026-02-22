using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Linq;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000230 RID: 560
	public static class EnumDataUtility
	{
		// Token: 0x06001F03 RID: 7939 RVA: 0x00011D2F File Offset: 0x0000FF2F
		public static Enum IntToEnumFlags(Type enumType, int value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00065758 File Offset: 0x00063958
		public static bool CheckObsoleteAddition(FieldInfo field, bool excludeObsolete)
		{
			Il2CppReferenceArray<Object> customAttributes = field.GetCustomAttributes(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ObsoleteAttribute>()), false);
			bool flag = customAttributes.Length != 0;
			return !flag || (!excludeObsolete && !customAttributes.First<Object>().Cast<ObsoleteAttribute>().IsError);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x000657AC File Offset: 0x000639AC
		public static string EnumTooltipFromEnumField(FieldInfo field)
		{
			Il2CppReferenceArray<Object> customAttributes = field.GetCustomAttributes(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TooltipAttribute>()), false);
			bool flag = customAttributes.Length != 0;
			string text;
			if (flag)
			{
				text = customAttributes.First<Object>().Cast<TooltipAttribute>().tooltip;
			}
			else
			{
				text = String.Empty;
			}
			return text;
		}

		// Token: 0x02000C0B RID: 3083
		public sealed class <>c__DisplayClass2_0
		{
		}

		// Token: 0x02000C0C RID: 3084
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
