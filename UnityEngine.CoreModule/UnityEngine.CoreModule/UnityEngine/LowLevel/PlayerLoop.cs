using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.LowLevel
{
	// Token: 0x0200026E RID: 622
	public class PlayerLoop
	{
		// Token: 0x06002007 RID: 8199 RVA: 0x00067168 File Offset: 0x00065368
		public static PlayerLoopSystem GetDefaultPlayerLoop()
		{
			Il2CppReferenceArray<PlayerLoopSystemInternal> defaultPlayerLoopInternal = PlayerLoop.GetDefaultPlayerLoopInternal();
			int num = 0;
			return PlayerLoop.InternalToPlayerLoopSystem(defaultPlayerLoopInternal, ref num);
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0006718C File Offset: 0x0006538C
		public static PlayerLoopSystem GetCurrentPlayerLoop()
		{
			Il2CppReferenceArray<PlayerLoopSystemInternal> currentPlayerLoopInternal = PlayerLoop.GetCurrentPlayerLoopInternal();
			int num = 0;
			return PlayerLoop.InternalToPlayerLoopSystem(currentPlayerLoopInternal, ref num);
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x000671B0 File Offset: 0x000653B0
		public static void SetPlayerLoop(PlayerLoopSystem loop)
		{
			List<PlayerLoopSystemInternal> list = new List<PlayerLoopSystemInternal>();
			PlayerLoop.PlayerLoopSystemToInternal(loop, ref list);
			PlayerLoop.SetPlayerLoopInternal(list.ToArray());
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0001283F File Offset: 0x00010A3F
		public static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0001284C File Offset: 0x00010A4C
		public static PlayerLoopSystem InternalToPlayerLoopSystem(Il2CppReferenceArray<PlayerLoopSystemInternal> internalSys, ref int offset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x000671DC File Offset: 0x000653DC
		public static Il2CppReferenceArray<PlayerLoopSystemInternal> GetDefaultPlayerLoopInternal()
		{
			IntPtr intPtr = PlayerLoop.GetDefaultPlayerLoopInternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(intPtr2) : null;
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00067204 File Offset: 0x00065404
		public static Il2CppReferenceArray<PlayerLoopSystemInternal> GetCurrentPlayerLoopInternal()
		{
			IntPtr intPtr = PlayerLoop.GetCurrentPlayerLoopInternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(intPtr2) : null;
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00012859 File Offset: 0x00010A59
		public static void SetPlayerLoopInternal(Il2CppReferenceArray<PlayerLoopSystemInternal> loop)
		{
			PlayerLoop.SetPlayerLoopInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(loop));
		}

		// Token: 0x04001959 RID: 6489
		private static readonly PlayerLoop.GetDefaultPlayerLoopInternalDelegate GetDefaultPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.GetDefaultPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::GetDefaultPlayerLoopInternal");

		// Token: 0x0400195A RID: 6490
		private static readonly PlayerLoop.GetCurrentPlayerLoopInternalDelegate GetCurrentPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.GetCurrentPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::GetCurrentPlayerLoopInternal");

		// Token: 0x0400195B RID: 6491
		private static readonly PlayerLoop.SetPlayerLoopInternalDelegate SetPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.SetPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::SetPlayerLoopInternal");

		// Token: 0x02000C74 RID: 3188
		// (Invoke) Token: 0x060036CE RID: 14030
		private delegate IntPtr GetDefaultPlayerLoopInternalDelegate();

		// Token: 0x02000C75 RID: 3189
		// (Invoke) Token: 0x060036D0 RID: 14032
		private delegate IntPtr GetCurrentPlayerLoopInternalDelegate();

		// Token: 0x02000C76 RID: 3190
		// (Invoke) Token: 0x060036D2 RID: 14034
		private delegate void SetPlayerLoopInternalDelegate(IntPtr loop);
	}
}
