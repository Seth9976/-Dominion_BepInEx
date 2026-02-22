using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000239 RID: 569
	public sealed class Security
	{
		// Token: 0x06001F0D RID: 7949 RVA: 0x00065820 File Offset: 0x00063A20
		public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData, string authorizationKey)
		{
			return null;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00065834 File Offset: 0x00063A34
		public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData)
		{
			return null;
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00065848 File Offset: 0x00063A48
		public static bool PrefetchSocketPolicy(string ip, int atPort)
		{
			int num = 3000;
			return Security.PrefetchSocketPolicy(ip, atPort, num);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00065868 File Offset: 0x00063A68
		public static bool PrefetchSocketPolicy(string ip, int atPort, int timeout)
		{
			return false;
		}
	}
}
