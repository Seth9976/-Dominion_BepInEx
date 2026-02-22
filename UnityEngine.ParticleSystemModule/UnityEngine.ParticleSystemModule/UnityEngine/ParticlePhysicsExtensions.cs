using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	public static class ParticlePhysicsExtensions
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00004458 File Offset: 0x00002658
		public static int GetSafeCollisionEventSize(ParticleSystem ps)
		{
			return ParticleSystemExtensionsImpl.GetSafeCollisionEventSize(ps);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004470 File Offset: 0x00002670
		public static int GetSafeTriggerParticlesSize(ParticleSystem ps, ParticleSystemTriggerEventType type)
		{
			return ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSize(ps, (int)type);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000448C File Offset: 0x0000268C
		public static int GetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles)
		{
			return ParticleSystemExtensionsImpl.GetTriggerParticles(ps, (int)type, particles);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000044A8 File Offset: 0x000026A8
		public static void SetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles, int offset, int count)
		{
			bool flag = particles == null;
			if (flag)
			{
				throw new ArgumentNullException("particles");
			}
			bool flag2 = offset >= particles.Count;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("offset", "offset should be smaller than the size of the particles list.");
			}
			bool flag3 = offset + count >= particles.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("count", "offset+count should be smaller than the size of the particles list.");
			}
			ParticleSystemExtensionsImpl.SetTriggerParticles(ps, (int)type, particles, offset, count);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000027AD File Offset: 0x000009AD
		public static void SetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles)
		{
			ParticleSystemExtensionsImpl.SetTriggerParticles(ps, (int)type, particles, 0, particles.Count);
		}
	}
}
