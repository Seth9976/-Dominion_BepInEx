using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.AI
{
	// Token: 0x02000006 RID: 6
	public sealed class NavMeshPath
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002202 File Offset: 0x00000402
		public override void Finalize()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000220F File Offset: 0x0000040F
		public static IntPtr InitializeNavMeshPath()
		{
			return NavMeshPath.InitializeNavMeshPathDelegateField();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000221B File Offset: 0x0000041B
		public static void DestroyNavMeshPath(IntPtr ptr)
		{
			NavMeshPath.DestroyNavMeshPathDelegateField(ptr);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002228 File Offset: 0x00000428
		public int GetCornersNonAlloc([Out] Il2CppStructArray<Vector3> results)
		{
			return NavMeshPath.GetCornersNonAllocDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(results));
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002EE8 File Offset: 0x000010E8
		public Il2CppStructArray<Vector3> CalculateCornersInternal()
		{
			IntPtr intPtr = NavMeshPath.CalculateCornersInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002240 File Offset: 0x00000440
		public void ClearCornersInternal()
		{
			NavMeshPath.ClearCornersInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002252 File Offset: 0x00000452
		public void ClearCorners()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000225F File Offset: 0x0000045F
		public void CalculateCorners()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000226C File Offset: 0x0000046C
		public Il2CppStructArray<Vector3> corners
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002279 File Offset: 0x00000479
		public NavMeshPathStatus status
		{
			get
			{
				return NavMeshPath.get_statusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000022 RID: 34
		private static readonly NavMeshPath.InitializeNavMeshPathDelegate InitializeNavMeshPathDelegateField = IL2CPP.ResolveICall<NavMeshPath.InitializeNavMeshPathDelegate>("UnityEngine.AI.NavMeshPath::InitializeNavMeshPath");

		// Token: 0x04000023 RID: 35
		private static readonly NavMeshPath.DestroyNavMeshPathDelegate DestroyNavMeshPathDelegateField = IL2CPP.ResolveICall<NavMeshPath.DestroyNavMeshPathDelegate>("UnityEngine.AI.NavMeshPath::DestroyNavMeshPath");

		// Token: 0x04000024 RID: 36
		private static readonly NavMeshPath.GetCornersNonAllocDelegate GetCornersNonAllocDelegateField = IL2CPP.ResolveICall<NavMeshPath.GetCornersNonAllocDelegate>("UnityEngine.AI.NavMeshPath::GetCornersNonAlloc");

		// Token: 0x04000025 RID: 37
		private static readonly NavMeshPath.CalculateCornersInternalDelegate CalculateCornersInternalDelegateField = IL2CPP.ResolveICall<NavMeshPath.CalculateCornersInternalDelegate>("UnityEngine.AI.NavMeshPath::CalculateCornersInternal");

		// Token: 0x04000026 RID: 38
		private static readonly NavMeshPath.ClearCornersInternalDelegate ClearCornersInternalDelegateField = IL2CPP.ResolveICall<NavMeshPath.ClearCornersInternalDelegate>("UnityEngine.AI.NavMeshPath::ClearCornersInternal");

		// Token: 0x04000027 RID: 39
		private static readonly NavMeshPath.get_statusDelegate get_statusDelegateField = IL2CPP.ResolveICall<NavMeshPath.get_statusDelegate>("UnityEngine.AI.NavMeshPath::get_status");

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000105 RID: 261
		private delegate IntPtr InitializeNavMeshPathDelegate();

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000107 RID: 263
		private delegate void DestroyNavMeshPathDelegate(IntPtr ptr);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000109 RID: 265
		private delegate int GetCornersNonAllocDelegate(IntPtr @this, [Out] IntPtr results);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600010B RID: 267
		private delegate IntPtr CalculateCornersInternalDelegate(IntPtr @this);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x0600010D RID: 269
		private delegate void ClearCornersInternalDelegate(IntPtr @this);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x0600010F RID: 271
		private delegate NavMeshPathStatus get_statusDelegate(IntPtr @this);
	}
}
