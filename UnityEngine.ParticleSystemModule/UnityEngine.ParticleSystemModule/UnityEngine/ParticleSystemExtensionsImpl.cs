using System;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000032 RID: 50
	public class ParticleSystemExtensionsImpl
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x000027FE File Offset: 0x000009FE
		public static int GetSafeCollisionEventSize(ParticleSystem ps)
		{
			return ParticleSystemExtensionsImpl.GetSafeCollisionEventSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps));
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002810 File Offset: 0x00000A10
		public static int GetSafeTriggerParticlesSize(ParticleSystem ps, int type)
		{
			return ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps), type);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002823 File Offset: 0x00000A23
		public static int GetTriggerParticles(ParticleSystem ps, int type, List<ParticleSystem.Particle> particles)
		{
			return ParticleSystemExtensionsImpl.GetTriggerParticlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps), type, IL2CPP.Il2CppObjectBaseToPtr(particles));
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000283C File Offset: 0x00000A3C
		public static void SetTriggerParticles(ParticleSystem ps, int type, List<ParticleSystem.Particle> particles, int offset, int count)
		{
			ParticleSystemExtensionsImpl.SetTriggerParticlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps), type, IL2CPP.Il2CppObjectBaseToPtr(particles), offset, count);
		}

		// Token: 0x0400015D RID: 349
		private static readonly ParticleSystemExtensionsImpl.GetSafeCollisionEventSizeDelegate GetSafeCollisionEventSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.GetSafeCollisionEventSizeDelegate>("UnityEngine.ParticleSystemExtensionsImpl::GetSafeCollisionEventSize");

		// Token: 0x0400015E RID: 350
		private static readonly ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSizeDelegate GetSafeTriggerParticlesSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSizeDelegate>("UnityEngine.ParticleSystemExtensionsImpl::GetSafeTriggerParticlesSize");

		// Token: 0x0400015F RID: 351
		private static readonly ParticleSystemExtensionsImpl.GetTriggerParticlesDelegate GetTriggerParticlesDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.GetTriggerParticlesDelegate>("UnityEngine.ParticleSystemExtensionsImpl::GetTriggerParticles");

		// Token: 0x04000160 RID: 352
		private static readonly ParticleSystemExtensionsImpl.SetTriggerParticlesDelegate SetTriggerParticlesDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.SetTriggerParticlesDelegate>("UnityEngine.ParticleSystemExtensionsImpl::SetTriggerParticles");

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate int GetSafeCollisionEventSizeDelegate(IntPtr ps);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate int GetSafeTriggerParticlesSizeDelegate(IntPtr ps, int type);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate int GetTriggerParticlesDelegate(IntPtr ps, int type, IntPtr particles);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate void SetTriggerParticlesDelegate(IntPtr ps, int type, IntPtr particles, int offset, int count);
	}
}
