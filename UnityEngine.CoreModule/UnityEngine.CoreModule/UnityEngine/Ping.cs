using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000225 RID: 549
	public sealed class Ping
	{
		// Token: 0x06001EEC RID: 7916 RVA: 0x00065704 File Offset: 0x00063904
		public ~Ping()
		{
			this.DestroyPing();
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00011BA9 File Offset: 0x0000FDA9
		public void DestroyPing()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00011BB6 File Offset: 0x0000FDB6
		public static void Internal_Destroy(IntPtr ptr)
		{
			Ping.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00011BC3 File Offset: 0x0000FDC3
		public static IntPtr Internal_Create(string address)
		{
			return Ping.Internal_CreateDelegateField(IL2CPP.ManagedStringToIl2Cpp(address));
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00011BD5 File Offset: 0x0000FDD5
		public bool isDone
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00011BE2 File Offset: 0x0000FDE2
		public bool Internal_IsDone()
		{
			return Ping.Internal_IsDoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00011BF4 File Offset: 0x0000FDF4
		public int time
		{
			get
			{
				return Ping.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x00065734 File Offset: 0x00063934
		public string ip
		{
			get
			{
				IntPtr intPtr = Ping.get_ipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0400188A RID: 6282
		private static readonly Ping.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<Ping.Internal_DestroyDelegate>("UnityEngine.Ping::Internal_Destroy");

		// Token: 0x0400188B RID: 6283
		private static readonly Ping.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Ping.Internal_CreateDelegate>("UnityEngine.Ping::Internal_Create");

		// Token: 0x0400188C RID: 6284
		private static readonly Ping.Internal_IsDoneDelegate Internal_IsDoneDelegateField = IL2CPP.ResolveICall<Ping.Internal_IsDoneDelegate>("UnityEngine.Ping::Internal_IsDone");

		// Token: 0x0400188D RID: 6285
		private static readonly Ping.get_timeDelegate get_timeDelegateField = IL2CPP.ResolveICall<Ping.get_timeDelegate>("UnityEngine.Ping::get_time");

		// Token: 0x0400188E RID: 6286
		private static readonly Ping.get_ipDelegate get_ipDelegateField = IL2CPP.ResolveICall<Ping.get_ipDelegate>("UnityEngine.Ping::get_ip");

		// Token: 0x02000C02 RID: 3074
		// (Invoke) Token: 0x060035F6 RID: 13814
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x02000C03 RID: 3075
		// (Invoke) Token: 0x060035F8 RID: 13816
		private delegate IntPtr Internal_CreateDelegate(IntPtr address);

		// Token: 0x02000C04 RID: 3076
		// (Invoke) Token: 0x060035FA RID: 13818
		private delegate bool Internal_IsDoneDelegate(IntPtr @this);

		// Token: 0x02000C05 RID: 3077
		// (Invoke) Token: 0x060035FC RID: 13820
		private delegate int get_timeDelegate(IntPtr @this);

		// Token: 0x02000C06 RID: 3078
		// (Invoke) Token: 0x060035FE RID: 13822
		private delegate IntPtr get_ipDelegate(IntPtr @this);
	}
}
