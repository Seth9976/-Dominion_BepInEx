using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	public sealed class AudioReverbFilter : Behaviour
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000031CE File Offset: 0x000013CE
		// (set) Token: 0x0600017B RID: 379 RVA: 0x000031E0 File Offset: 0x000013E0
		public AudioReverbPreset reverbPreset
		{
			get
			{
				return AudioReverbFilter.get_reverbPresetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_reverbPresetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000031F3 File Offset: 0x000013F3
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00003205 File Offset: 0x00001405
		public float dryLevel
		{
			get
			{
				return AudioReverbFilter.get_dryLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_dryLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00003218 File Offset: 0x00001418
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0000322A File Offset: 0x0000142A
		public float room
		{
			get
			{
				return AudioReverbFilter.get_roomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_roomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000323D File Offset: 0x0000143D
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000324F File Offset: 0x0000144F
		public float roomHF
		{
			get
			{
				return AudioReverbFilter.get_roomHFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_roomHFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000060EC File Offset: 0x000042EC
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00003262 File Offset: 0x00001462
		public float roomRolloffFactor
		{
			get
			{
				Debug.LogWarning("Warning! roomRolloffFactor is no longer supported.");
				return 10f;
			}
			set
			{
				Debug.LogWarning("Warning! roomRolloffFactor is no longer supported.");
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00003270 File Offset: 0x00001470
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00003282 File Offset: 0x00001482
		public float decayTime
		{
			get
			{
				return AudioReverbFilter.get_decayTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_decayTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00003295 File Offset: 0x00001495
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000032A7 File Offset: 0x000014A7
		public float decayHFRatio
		{
			get
			{
				return AudioReverbFilter.get_decayHFRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_decayHFRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000032BA File Offset: 0x000014BA
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000032CC File Offset: 0x000014CC
		public float reflectionsLevel
		{
			get
			{
				return AudioReverbFilter.get_reflectionsLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_reflectionsLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000032DF File Offset: 0x000014DF
		// (set) Token: 0x0600018B RID: 395 RVA: 0x000032F1 File Offset: 0x000014F1
		public float reflectionsDelay
		{
			get
			{
				return AudioReverbFilter.get_reflectionsDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_reflectionsDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00003316 File Offset: 0x00001516
		public float reverbLevel
		{
			get
			{
				return AudioReverbFilter.get_reverbLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_reverbLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00003329 File Offset: 0x00001529
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0000333B File Offset: 0x0000153B
		public float reverbDelay
		{
			get
			{
				return AudioReverbFilter.get_reverbDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_reverbDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000334E File Offset: 0x0000154E
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00003360 File Offset: 0x00001560
		public float diffusion
		{
			get
			{
				return AudioReverbFilter.get_diffusionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_diffusionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00003373 File Offset: 0x00001573
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00003385 File Offset: 0x00001585
		public float density
		{
			get
			{
				return AudioReverbFilter.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00003398 File Offset: 0x00001598
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000033AA File Offset: 0x000015AA
		public float hfReference
		{
			get
			{
				return AudioReverbFilter.get_hfReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_hfReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000033BD File Offset: 0x000015BD
		// (set) Token: 0x06000197 RID: 407 RVA: 0x000033CF File Offset: 0x000015CF
		public float roomLF
		{
			get
			{
				return AudioReverbFilter.get_roomLFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_roomLFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000198 RID: 408 RVA: 0x000033E2 File Offset: 0x000015E2
		// (set) Token: 0x06000199 RID: 409 RVA: 0x000033F4 File Offset: 0x000015F4
		public float lfReference
		{
			get
			{
				return AudioReverbFilter.get_lfReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbFilter.set_lfReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400013F RID: 319
		private static readonly AudioReverbFilter.get_reverbPresetDelegate get_reverbPresetDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_reverbPresetDelegate>("UnityEngine.AudioReverbFilter::get_reverbPreset");

		// Token: 0x04000140 RID: 320
		private static readonly AudioReverbFilter.set_reverbPresetDelegate set_reverbPresetDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_reverbPresetDelegate>("UnityEngine.AudioReverbFilter::set_reverbPreset");

		// Token: 0x04000141 RID: 321
		private static readonly AudioReverbFilter.get_dryLevelDelegate get_dryLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_dryLevelDelegate>("UnityEngine.AudioReverbFilter::get_dryLevel");

		// Token: 0x04000142 RID: 322
		private static readonly AudioReverbFilter.set_dryLevelDelegate set_dryLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_dryLevelDelegate>("UnityEngine.AudioReverbFilter::set_dryLevel");

		// Token: 0x04000143 RID: 323
		private static readonly AudioReverbFilter.get_roomDelegate get_roomDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_roomDelegate>("UnityEngine.AudioReverbFilter::get_room");

		// Token: 0x04000144 RID: 324
		private static readonly AudioReverbFilter.set_roomDelegate set_roomDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_roomDelegate>("UnityEngine.AudioReverbFilter::set_room");

		// Token: 0x04000145 RID: 325
		private static readonly AudioReverbFilter.get_roomHFDelegate get_roomHFDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_roomHFDelegate>("UnityEngine.AudioReverbFilter::get_roomHF");

		// Token: 0x04000146 RID: 326
		private static readonly AudioReverbFilter.set_roomHFDelegate set_roomHFDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_roomHFDelegate>("UnityEngine.AudioReverbFilter::set_roomHF");

		// Token: 0x04000147 RID: 327
		private static readonly AudioReverbFilter.get_decayTimeDelegate get_decayTimeDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_decayTimeDelegate>("UnityEngine.AudioReverbFilter::get_decayTime");

		// Token: 0x04000148 RID: 328
		private static readonly AudioReverbFilter.set_decayTimeDelegate set_decayTimeDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_decayTimeDelegate>("UnityEngine.AudioReverbFilter::set_decayTime");

		// Token: 0x04000149 RID: 329
		private static readonly AudioReverbFilter.get_decayHFRatioDelegate get_decayHFRatioDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_decayHFRatioDelegate>("UnityEngine.AudioReverbFilter::get_decayHFRatio");

		// Token: 0x0400014A RID: 330
		private static readonly AudioReverbFilter.set_decayHFRatioDelegate set_decayHFRatioDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_decayHFRatioDelegate>("UnityEngine.AudioReverbFilter::set_decayHFRatio");

		// Token: 0x0400014B RID: 331
		private static readonly AudioReverbFilter.get_reflectionsLevelDelegate get_reflectionsLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_reflectionsLevelDelegate>("UnityEngine.AudioReverbFilter::get_reflectionsLevel");

		// Token: 0x0400014C RID: 332
		private static readonly AudioReverbFilter.set_reflectionsLevelDelegate set_reflectionsLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_reflectionsLevelDelegate>("UnityEngine.AudioReverbFilter::set_reflectionsLevel");

		// Token: 0x0400014D RID: 333
		private static readonly AudioReverbFilter.get_reflectionsDelayDelegate get_reflectionsDelayDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_reflectionsDelayDelegate>("UnityEngine.AudioReverbFilter::get_reflectionsDelay");

		// Token: 0x0400014E RID: 334
		private static readonly AudioReverbFilter.set_reflectionsDelayDelegate set_reflectionsDelayDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_reflectionsDelayDelegate>("UnityEngine.AudioReverbFilter::set_reflectionsDelay");

		// Token: 0x0400014F RID: 335
		private static readonly AudioReverbFilter.get_reverbLevelDelegate get_reverbLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_reverbLevelDelegate>("UnityEngine.AudioReverbFilter::get_reverbLevel");

		// Token: 0x04000150 RID: 336
		private static readonly AudioReverbFilter.set_reverbLevelDelegate set_reverbLevelDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_reverbLevelDelegate>("UnityEngine.AudioReverbFilter::set_reverbLevel");

		// Token: 0x04000151 RID: 337
		private static readonly AudioReverbFilter.get_reverbDelayDelegate get_reverbDelayDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_reverbDelayDelegate>("UnityEngine.AudioReverbFilter::get_reverbDelay");

		// Token: 0x04000152 RID: 338
		private static readonly AudioReverbFilter.set_reverbDelayDelegate set_reverbDelayDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_reverbDelayDelegate>("UnityEngine.AudioReverbFilter::set_reverbDelay");

		// Token: 0x04000153 RID: 339
		private static readonly AudioReverbFilter.get_diffusionDelegate get_diffusionDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_diffusionDelegate>("UnityEngine.AudioReverbFilter::get_diffusion");

		// Token: 0x04000154 RID: 340
		private static readonly AudioReverbFilter.set_diffusionDelegate set_diffusionDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_diffusionDelegate>("UnityEngine.AudioReverbFilter::set_diffusion");

		// Token: 0x04000155 RID: 341
		private static readonly AudioReverbFilter.get_densityDelegate get_densityDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_densityDelegate>("UnityEngine.AudioReverbFilter::get_density");

		// Token: 0x04000156 RID: 342
		private static readonly AudioReverbFilter.set_densityDelegate set_densityDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_densityDelegate>("UnityEngine.AudioReverbFilter::set_density");

		// Token: 0x04000157 RID: 343
		private static readonly AudioReverbFilter.get_hfReferenceDelegate get_hfReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_hfReferenceDelegate>("UnityEngine.AudioReverbFilter::get_hfReference");

		// Token: 0x04000158 RID: 344
		private static readonly AudioReverbFilter.set_hfReferenceDelegate set_hfReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_hfReferenceDelegate>("UnityEngine.AudioReverbFilter::set_hfReference");

		// Token: 0x04000159 RID: 345
		private static readonly AudioReverbFilter.get_roomLFDelegate get_roomLFDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_roomLFDelegate>("UnityEngine.AudioReverbFilter::get_roomLF");

		// Token: 0x0400015A RID: 346
		private static readonly AudioReverbFilter.set_roomLFDelegate set_roomLFDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_roomLFDelegate>("UnityEngine.AudioReverbFilter::set_roomLF");

		// Token: 0x0400015B RID: 347
		private static readonly AudioReverbFilter.get_lfReferenceDelegate get_lfReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.get_lfReferenceDelegate>("UnityEngine.AudioReverbFilter::get_lfReference");

		// Token: 0x0400015C RID: 348
		private static readonly AudioReverbFilter.set_lfReferenceDelegate set_lfReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbFilter.set_lfReferenceDelegate>("UnityEngine.AudioReverbFilter::set_lfReference");

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x060003A2 RID: 930
		private delegate AudioReverbPreset get_reverbPresetDelegate(IntPtr @this);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x060003A4 RID: 932
		private delegate void set_reverbPresetDelegate(IntPtr @this, AudioReverbPreset value);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x060003A6 RID: 934
		private delegate float get_dryLevelDelegate(IntPtr @this);

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x060003A8 RID: 936
		private delegate void set_dryLevelDelegate(IntPtr @this, float value);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x060003AA RID: 938
		private delegate float get_roomDelegate(IntPtr @this);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x060003AC RID: 940
		private delegate void set_roomDelegate(IntPtr @this, float value);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x060003AE RID: 942
		private delegate float get_roomHFDelegate(IntPtr @this);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x060003B0 RID: 944
		private delegate void set_roomHFDelegate(IntPtr @this, float value);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x060003B2 RID: 946
		private delegate float get_decayTimeDelegate(IntPtr @this);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x060003B4 RID: 948
		private delegate void set_decayTimeDelegate(IntPtr @this, float value);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x060003B6 RID: 950
		private delegate float get_decayHFRatioDelegate(IntPtr @this);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x060003B8 RID: 952
		private delegate void set_decayHFRatioDelegate(IntPtr @this, float value);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x060003BA RID: 954
		private delegate float get_reflectionsLevelDelegate(IntPtr @this);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x060003BC RID: 956
		private delegate void set_reflectionsLevelDelegate(IntPtr @this, float value);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x060003BE RID: 958
		private delegate float get_reflectionsDelayDelegate(IntPtr @this);

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x060003C0 RID: 960
		private delegate void set_reflectionsDelayDelegate(IntPtr @this, float value);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x060003C2 RID: 962
		private delegate float get_reverbLevelDelegate(IntPtr @this);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x060003C4 RID: 964
		private delegate void set_reverbLevelDelegate(IntPtr @this, float value);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x060003C6 RID: 966
		private delegate float get_reverbDelayDelegate(IntPtr @this);

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x060003C8 RID: 968
		private delegate void set_reverbDelayDelegate(IntPtr @this, float value);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x060003CA RID: 970
		private delegate float get_diffusionDelegate(IntPtr @this);

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x060003CC RID: 972
		private delegate void set_diffusionDelegate(IntPtr @this, float value);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x060003CE RID: 974
		private delegate float get_densityDelegate(IntPtr @this);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x060003D0 RID: 976
		private delegate void set_densityDelegate(IntPtr @this, float value);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x060003D2 RID: 978
		private delegate float get_hfReferenceDelegate(IntPtr @this);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x060003D4 RID: 980
		private delegate void set_hfReferenceDelegate(IntPtr @this, float value);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x060003D6 RID: 982
		private delegate float get_roomLFDelegate(IntPtr @this);

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x060003D8 RID: 984
		private delegate void set_roomLFDelegate(IntPtr @this, float value);

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x060003DA RID: 986
		private delegate float get_lfReferenceDelegate(IntPtr @this);

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x060003DC RID: 988
		private delegate void set_lfReferenceDelegate(IntPtr @this, float value);
	}
}
