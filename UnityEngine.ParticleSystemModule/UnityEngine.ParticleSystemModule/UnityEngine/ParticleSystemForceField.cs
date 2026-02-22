using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000033 RID: 51
	public class ParticleSystemForceField : Component
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002858 File Offset: 0x00000A58
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000286A File Offset: 0x00000A6A
		public ParticleSystemForceFieldShape shape
		{
			get
			{
				return ParticleSystemForceField.get_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000287D File Offset: 0x00000A7D
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000288F File Offset: 0x00000A8F
		public float startRange
		{
			get
			{
				return ParticleSystemForceField.get_startRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_startRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000028A2 File Offset: 0x00000AA2
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000028B4 File Offset: 0x00000AB4
		public float endRange
		{
			get
			{
				return ParticleSystemForceField.get_endRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_endRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000028C7 File Offset: 0x00000AC7
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000028D9 File Offset: 0x00000AD9
		public float length
		{
			get
			{
				return ParticleSystemForceField.get_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000028EC File Offset: 0x00000AEC
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000028FE File Offset: 0x00000AFE
		public float gravityFocus
		{
			get
			{
				return ParticleSystemForceField.get_gravityFocusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_gravityFocusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004634 File Offset: 0x00002834
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002911 File Offset: 0x00000B11
		public Vector2 rotationRandomness
		{
			get
			{
				Vector2 vector;
				this.get_rotationRandomness_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rotationRandomness_Injected(ref value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000291B File Offset: 0x00000B1B
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000292D File Offset: 0x00000B2D
		public bool multiplyDragByParticleSize
		{
			get
			{
				return ParticleSystemForceField.get_multiplyDragByParticleSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_multiplyDragByParticleSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002952 File Offset: 0x00000B52
		public bool multiplyDragByParticleVelocity
		{
			get
			{
				return ParticleSystemForceField.get_multiplyDragByParticleVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_multiplyDragByParticleVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000464C File Offset: 0x0000284C
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002965 File Offset: 0x00000B65
		public Texture3D vectorField
		{
			get
			{
				IntPtr intPtr = ParticleSystemForceField.get_vectorFieldDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				ParticleSystemForceField.set_vectorFieldDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000297D File Offset: 0x00000B7D
		public void get_rotationRandomness_Injected(out Vector2 ret)
		{
			ParticleSystemForceField.get_rotationRandomness_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002990 File Offset: 0x00000B90
		public void set_rotationRandomness_Injected(ref Vector2 value)
		{
			ParticleSystemForceField.set_rotationRandomness_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000161 RID: 353
		private static readonly ParticleSystemForceField.get_shapeDelegate get_shapeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_shapeDelegate>("UnityEngine.ParticleSystemForceField::get_shape");

		// Token: 0x04000162 RID: 354
		private static readonly ParticleSystemForceField.set_shapeDelegate set_shapeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_shapeDelegate>("UnityEngine.ParticleSystemForceField::set_shape");

		// Token: 0x04000163 RID: 355
		private static readonly ParticleSystemForceField.get_startRangeDelegate get_startRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_startRangeDelegate>("UnityEngine.ParticleSystemForceField::get_startRange");

		// Token: 0x04000164 RID: 356
		private static readonly ParticleSystemForceField.set_startRangeDelegate set_startRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_startRangeDelegate>("UnityEngine.ParticleSystemForceField::set_startRange");

		// Token: 0x04000165 RID: 357
		private static readonly ParticleSystemForceField.get_endRangeDelegate get_endRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_endRangeDelegate>("UnityEngine.ParticleSystemForceField::get_endRange");

		// Token: 0x04000166 RID: 358
		private static readonly ParticleSystemForceField.set_endRangeDelegate set_endRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_endRangeDelegate>("UnityEngine.ParticleSystemForceField::set_endRange");

		// Token: 0x04000167 RID: 359
		private static readonly ParticleSystemForceField.get_lengthDelegate get_lengthDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_lengthDelegate>("UnityEngine.ParticleSystemForceField::get_length");

		// Token: 0x04000168 RID: 360
		private static readonly ParticleSystemForceField.set_lengthDelegate set_lengthDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_lengthDelegate>("UnityEngine.ParticleSystemForceField::set_length");

		// Token: 0x04000169 RID: 361
		private static readonly ParticleSystemForceField.get_gravityFocusDelegate get_gravityFocusDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_gravityFocusDelegate>("UnityEngine.ParticleSystemForceField::get_gravityFocus");

		// Token: 0x0400016A RID: 362
		private static readonly ParticleSystemForceField.set_gravityFocusDelegate set_gravityFocusDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_gravityFocusDelegate>("UnityEngine.ParticleSystemForceField::set_gravityFocus");

		// Token: 0x0400016B RID: 363
		private static readonly ParticleSystemForceField.get_multiplyDragByParticleSizeDelegate get_multiplyDragByParticleSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_multiplyDragByParticleSizeDelegate>("UnityEngine.ParticleSystemForceField::get_multiplyDragByParticleSize");

		// Token: 0x0400016C RID: 364
		private static readonly ParticleSystemForceField.set_multiplyDragByParticleSizeDelegate set_multiplyDragByParticleSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_multiplyDragByParticleSizeDelegate>("UnityEngine.ParticleSystemForceField::set_multiplyDragByParticleSize");

		// Token: 0x0400016D RID: 365
		private static readonly ParticleSystemForceField.get_multiplyDragByParticleVelocityDelegate get_multiplyDragByParticleVelocityDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_multiplyDragByParticleVelocityDelegate>("UnityEngine.ParticleSystemForceField::get_multiplyDragByParticleVelocity");

		// Token: 0x0400016E RID: 366
		private static readonly ParticleSystemForceField.set_multiplyDragByParticleVelocityDelegate set_multiplyDragByParticleVelocityDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_multiplyDragByParticleVelocityDelegate>("UnityEngine.ParticleSystemForceField::set_multiplyDragByParticleVelocity");

		// Token: 0x0400016F RID: 367
		private static readonly ParticleSystemForceField.get_vectorFieldDelegate get_vectorFieldDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_vectorFieldDelegate>("UnityEngine.ParticleSystemForceField::get_vectorField");

		// Token: 0x04000170 RID: 368
		private static readonly ParticleSystemForceField.set_vectorFieldDelegate set_vectorFieldDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_vectorFieldDelegate>("UnityEngine.ParticleSystemForceField::set_vectorField");

		// Token: 0x04000171 RID: 369
		private static readonly ParticleSystemForceField.get_rotationRandomness_InjectedDelegate get_rotationRandomness_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_rotationRandomness_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_rotationRandomness_Injected");

		// Token: 0x04000172 RID: 370
		private static readonly ParticleSystemForceField.set_rotationRandomness_InjectedDelegate set_rotationRandomness_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_rotationRandomness_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_rotationRandomness_Injected");

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate ParticleSystemForceFieldShape get_shapeDelegate(IntPtr @this);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate void set_shapeDelegate(IntPtr @this, ParticleSystemForceFieldShape value);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate float get_startRangeDelegate(IntPtr @this);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate void set_startRangeDelegate(IntPtr @this, float value);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate float get_endRangeDelegate(IntPtr @this);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate void set_endRangeDelegate(IntPtr @this, float value);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate float get_lengthDelegate(IntPtr @this);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x060001D2 RID: 466
		private delegate void set_lengthDelegate(IntPtr @this, float value);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x060001D4 RID: 468
		private delegate float get_gravityFocusDelegate(IntPtr @this);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x060001D6 RID: 470
		private delegate void set_gravityFocusDelegate(IntPtr @this, float value);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x060001D8 RID: 472
		private delegate bool get_multiplyDragByParticleSizeDelegate(IntPtr @this);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x060001DA RID: 474
		private delegate void set_multiplyDragByParticleSizeDelegate(IntPtr @this, bool value);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x060001DC RID: 476
		private delegate bool get_multiplyDragByParticleVelocityDelegate(IntPtr @this);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x060001DE RID: 478
		private delegate void set_multiplyDragByParticleVelocityDelegate(IntPtr @this, bool value);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x060001E0 RID: 480
		private delegate IntPtr get_vectorFieldDelegate(IntPtr @this);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x060001E2 RID: 482
		private delegate void set_vectorFieldDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x060001E4 RID: 484
		private delegate void get_rotationRandomness_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x060001E6 RID: 486
		private delegate void set_rotationRandomness_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
