using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.Profiling
{
	// Token: 0x02000255 RID: 597
	public sealed class CustomSampler : Sampler
	{
		// Token: 0x06001FDD RID: 8157 RVA: 0x0001263B File Offset: 0x0001083B
		public static CustomSampler Create(string name, [Optional] bool collectGpuData)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00012648 File Offset: 0x00010848
		public static IntPtr CreateInternal(string name, bool collectGpuData)
		{
			return CustomSampler.CreateInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), collectGpuData);
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0001265B File Offset: 0x0001085B
		public void Begin()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00012668 File Offset: 0x00010868
		public void Begin(Object targetObject)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00012675 File Offset: 0x00010875
		public void End()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00012682 File Offset: 0x00010882
		public static void Begin_Internal(IntPtr ptr)
		{
			CustomSampler.Begin_InternalDelegateField(ptr);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0001268F File Offset: 0x0001088F
		public static void BeginWithObject_Internal(IntPtr ptr, Object targetObject)
		{
			CustomSampler.BeginWithObject_InternalDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(targetObject));
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x000126A2 File Offset: 0x000108A2
		public static void End_Internal(IntPtr ptr)
		{
			CustomSampler.End_InternalDelegateField(ptr);
		}

		// Token: 0x04001939 RID: 6457
		private static readonly CustomSampler.CreateInternalDelegate CreateInternalDelegateField = IL2CPP.ResolveICall<CustomSampler.CreateInternalDelegate>("UnityEngine.Profiling.CustomSampler::CreateInternal");

		// Token: 0x0400193A RID: 6458
		private static readonly CustomSampler.Begin_InternalDelegate Begin_InternalDelegateField = IL2CPP.ResolveICall<CustomSampler.Begin_InternalDelegate>("UnityEngine.Profiling.CustomSampler::Begin_Internal");

		// Token: 0x0400193B RID: 6459
		private static readonly CustomSampler.BeginWithObject_InternalDelegate BeginWithObject_InternalDelegateField = IL2CPP.ResolveICall<CustomSampler.BeginWithObject_InternalDelegate>("UnityEngine.Profiling.CustomSampler::BeginWithObject_Internal");

		// Token: 0x0400193C RID: 6460
		private static readonly CustomSampler.End_InternalDelegate End_InternalDelegateField = IL2CPP.ResolveICall<CustomSampler.End_InternalDelegate>("UnityEngine.Profiling.CustomSampler::End_Internal");

		// Token: 0x02000C65 RID: 3173
		// (Invoke) Token: 0x060036B2 RID: 14002
		private delegate IntPtr CreateInternalDelegate(IntPtr name, bool collectGpuData);

		// Token: 0x02000C66 RID: 3174
		// (Invoke) Token: 0x060036B4 RID: 14004
		private delegate void Begin_InternalDelegate(IntPtr ptr);

		// Token: 0x02000C67 RID: 3175
		// (Invoke) Token: 0x060036B6 RID: 14006
		private delegate void BeginWithObject_InternalDelegate(IntPtr ptr, IntPtr targetObject);

		// Token: 0x02000C68 RID: 3176
		// (Invoke) Token: 0x060036B8 RID: 14008
		private delegate void End_InternalDelegate(IntPtr ptr);
	}
}
