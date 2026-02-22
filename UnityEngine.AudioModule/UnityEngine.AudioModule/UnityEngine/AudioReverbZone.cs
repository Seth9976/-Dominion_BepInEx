using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000014 RID: 20
	public sealed class AudioReverbZone : Behaviour
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00002C91 File Offset: 0x00000E91
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002CA3 File Offset: 0x00000EA3
		public float minDistance
		{
			get
			{
				return AudioReverbZone.get_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002CB6 File Offset: 0x00000EB6
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public float maxDistance
		{
			get
			{
				return AudioReverbZone.get_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002CDB File Offset: 0x00000EDB
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002CED File Offset: 0x00000EED
		public AudioReverbPreset reverbPreset
		{
			get
			{
				return AudioReverbZone.get_reverbPresetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_reverbPresetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002D00 File Offset: 0x00000F00
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002D12 File Offset: 0x00000F12
		public int room
		{
			get
			{
				return AudioReverbZone.get_roomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_roomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002D25 File Offset: 0x00000F25
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002D37 File Offset: 0x00000F37
		public int roomHF
		{
			get
			{
				return AudioReverbZone.get_roomHFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_roomHFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002D4A File Offset: 0x00000F4A
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002D5C File Offset: 0x00000F5C
		public int roomLF
		{
			get
			{
				return AudioReverbZone.get_roomLFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_roomLFDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002D6F File Offset: 0x00000F6F
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002D81 File Offset: 0x00000F81
		public float decayTime
		{
			get
			{
				return AudioReverbZone.get_decayTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_decayTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002D94 File Offset: 0x00000F94
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002DA6 File Offset: 0x00000FA6
		public float decayHFRatio
		{
			get
			{
				return AudioReverbZone.get_decayHFRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_decayHFRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00002DB9 File Offset: 0x00000FB9
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00002DCB File Offset: 0x00000FCB
		public int reflections
		{
			get
			{
				return AudioReverbZone.get_reflectionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_reflectionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00002DDE File Offset: 0x00000FDE
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00002DF0 File Offset: 0x00000FF0
		public float reflectionsDelay
		{
			get
			{
				return AudioReverbZone.get_reflectionsDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_reflectionsDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00002E03 File Offset: 0x00001003
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002E15 File Offset: 0x00001015
		public int reverb
		{
			get
			{
				return AudioReverbZone.get_reverbDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_reverbDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00002E28 File Offset: 0x00001028
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002E3A File Offset: 0x0000103A
		public float reverbDelay
		{
			get
			{
				return AudioReverbZone.get_reverbDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_reverbDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00002E4D File Offset: 0x0000104D
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002E5F File Offset: 0x0000105F
		public float HFReference
		{
			get
			{
				return AudioReverbZone.get_HFReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_HFReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00002E72 File Offset: 0x00001072
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002E84 File Offset: 0x00001084
		public float LFReference
		{
			get
			{
				return AudioReverbZone.get_LFReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_LFReferenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00005CC0 File Offset: 0x00003EC0
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002E97 File Offset: 0x00001097
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002EA5 File Offset: 0x000010A5
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002EB7 File Offset: 0x000010B7
		public float diffusion
		{
			get
			{
				return AudioReverbZone.get_diffusionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_diffusionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002ECA File Offset: 0x000010CA
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002EDC File Offset: 0x000010DC
		public float density
		{
			get
			{
				return AudioReverbZone.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioReverbZone.set_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040000FD RID: 253
		private static readonly AudioReverbZone.get_minDistanceDelegate get_minDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_minDistanceDelegate>("UnityEngine.AudioReverbZone::get_minDistance");

		// Token: 0x040000FE RID: 254
		private static readonly AudioReverbZone.set_minDistanceDelegate set_minDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_minDistanceDelegate>("UnityEngine.AudioReverbZone::set_minDistance");

		// Token: 0x040000FF RID: 255
		private static readonly AudioReverbZone.get_maxDistanceDelegate get_maxDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_maxDistanceDelegate>("UnityEngine.AudioReverbZone::get_maxDistance");

		// Token: 0x04000100 RID: 256
		private static readonly AudioReverbZone.set_maxDistanceDelegate set_maxDistanceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_maxDistanceDelegate>("UnityEngine.AudioReverbZone::set_maxDistance");

		// Token: 0x04000101 RID: 257
		private static readonly AudioReverbZone.get_reverbPresetDelegate get_reverbPresetDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reverbPresetDelegate>("UnityEngine.AudioReverbZone::get_reverbPreset");

		// Token: 0x04000102 RID: 258
		private static readonly AudioReverbZone.set_reverbPresetDelegate set_reverbPresetDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_reverbPresetDelegate>("UnityEngine.AudioReverbZone::set_reverbPreset");

		// Token: 0x04000103 RID: 259
		private static readonly AudioReverbZone.get_roomDelegate get_roomDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_roomDelegate>("UnityEngine.AudioReverbZone::get_room");

		// Token: 0x04000104 RID: 260
		private static readonly AudioReverbZone.set_roomDelegate set_roomDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_roomDelegate>("UnityEngine.AudioReverbZone::set_room");

		// Token: 0x04000105 RID: 261
		private static readonly AudioReverbZone.get_roomHFDelegate get_roomHFDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_roomHFDelegate>("UnityEngine.AudioReverbZone::get_roomHF");

		// Token: 0x04000106 RID: 262
		private static readonly AudioReverbZone.set_roomHFDelegate set_roomHFDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_roomHFDelegate>("UnityEngine.AudioReverbZone::set_roomHF");

		// Token: 0x04000107 RID: 263
		private static readonly AudioReverbZone.get_roomLFDelegate get_roomLFDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_roomLFDelegate>("UnityEngine.AudioReverbZone::get_roomLF");

		// Token: 0x04000108 RID: 264
		private static readonly AudioReverbZone.set_roomLFDelegate set_roomLFDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_roomLFDelegate>("UnityEngine.AudioReverbZone::set_roomLF");

		// Token: 0x04000109 RID: 265
		private static readonly AudioReverbZone.get_decayTimeDelegate get_decayTimeDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_decayTimeDelegate>("UnityEngine.AudioReverbZone::get_decayTime");

		// Token: 0x0400010A RID: 266
		private static readonly AudioReverbZone.set_decayTimeDelegate set_decayTimeDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_decayTimeDelegate>("UnityEngine.AudioReverbZone::set_decayTime");

		// Token: 0x0400010B RID: 267
		private static readonly AudioReverbZone.get_decayHFRatioDelegate get_decayHFRatioDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_decayHFRatioDelegate>("UnityEngine.AudioReverbZone::get_decayHFRatio");

		// Token: 0x0400010C RID: 268
		private static readonly AudioReverbZone.set_decayHFRatioDelegate set_decayHFRatioDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_decayHFRatioDelegate>("UnityEngine.AudioReverbZone::set_decayHFRatio");

		// Token: 0x0400010D RID: 269
		private static readonly AudioReverbZone.get_reflectionsDelegate get_reflectionsDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reflectionsDelegate>("UnityEngine.AudioReverbZone::get_reflections");

		// Token: 0x0400010E RID: 270
		private static readonly AudioReverbZone.set_reflectionsDelegate set_reflectionsDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_reflectionsDelegate>("UnityEngine.AudioReverbZone::set_reflections");

		// Token: 0x0400010F RID: 271
		private static readonly AudioReverbZone.get_reflectionsDelayDelegate get_reflectionsDelayDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reflectionsDelayDelegate>("UnityEngine.AudioReverbZone::get_reflectionsDelay");

		// Token: 0x04000110 RID: 272
		private static readonly AudioReverbZone.set_reflectionsDelayDelegate set_reflectionsDelayDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_reflectionsDelayDelegate>("UnityEngine.AudioReverbZone::set_reflectionsDelay");

		// Token: 0x04000111 RID: 273
		private static readonly AudioReverbZone.get_reverbDelegate get_reverbDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reverbDelegate>("UnityEngine.AudioReverbZone::get_reverb");

		// Token: 0x04000112 RID: 274
		private static readonly AudioReverbZone.set_reverbDelegate set_reverbDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_reverbDelegate>("UnityEngine.AudioReverbZone::set_reverb");

		// Token: 0x04000113 RID: 275
		private static readonly AudioReverbZone.get_reverbDelayDelegate get_reverbDelayDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_reverbDelayDelegate>("UnityEngine.AudioReverbZone::get_reverbDelay");

		// Token: 0x04000114 RID: 276
		private static readonly AudioReverbZone.set_reverbDelayDelegate set_reverbDelayDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_reverbDelayDelegate>("UnityEngine.AudioReverbZone::set_reverbDelay");

		// Token: 0x04000115 RID: 277
		private static readonly AudioReverbZone.get_HFReferenceDelegate get_HFReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_HFReferenceDelegate>("UnityEngine.AudioReverbZone::get_HFReference");

		// Token: 0x04000116 RID: 278
		private static readonly AudioReverbZone.set_HFReferenceDelegate set_HFReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_HFReferenceDelegate>("UnityEngine.AudioReverbZone::set_HFReference");

		// Token: 0x04000117 RID: 279
		private static readonly AudioReverbZone.get_LFReferenceDelegate get_LFReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_LFReferenceDelegate>("UnityEngine.AudioReverbZone::get_LFReference");

		// Token: 0x04000118 RID: 280
		private static readonly AudioReverbZone.set_LFReferenceDelegate set_LFReferenceDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_LFReferenceDelegate>("UnityEngine.AudioReverbZone::set_LFReference");

		// Token: 0x04000119 RID: 281
		private static readonly AudioReverbZone.get_diffusionDelegate get_diffusionDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_diffusionDelegate>("UnityEngine.AudioReverbZone::get_diffusion");

		// Token: 0x0400011A RID: 282
		private static readonly AudioReverbZone.set_diffusionDelegate set_diffusionDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_diffusionDelegate>("UnityEngine.AudioReverbZone::set_diffusion");

		// Token: 0x0400011B RID: 283
		private static readonly AudioReverbZone.get_densityDelegate get_densityDelegateField = IL2CPP.ResolveICall<AudioReverbZone.get_densityDelegate>("UnityEngine.AudioReverbZone::get_density");

		// Token: 0x0400011C RID: 284
		private static readonly AudioReverbZone.set_densityDelegate set_densityDelegateField = IL2CPP.ResolveICall<AudioReverbZone.set_densityDelegate>("UnityEngine.AudioReverbZone::set_density");

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x0600031E RID: 798
		private delegate float get_minDistanceDelegate(IntPtr @this);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x06000320 RID: 800
		private delegate void set_minDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000322 RID: 802
		private delegate float get_maxDistanceDelegate(IntPtr @this);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x06000324 RID: 804
		private delegate void set_maxDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000326 RID: 806
		private delegate AudioReverbPreset get_reverbPresetDelegate(IntPtr @this);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x06000328 RID: 808
		private delegate void set_reverbPresetDelegate(IntPtr @this, AudioReverbPreset value);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x0600032A RID: 810
		private delegate int get_roomDelegate(IntPtr @this);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x0600032C RID: 812
		private delegate void set_roomDelegate(IntPtr @this, int value);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x0600032E RID: 814
		private delegate int get_roomHFDelegate(IntPtr @this);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x06000330 RID: 816
		private delegate void set_roomHFDelegate(IntPtr @this, int value);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x06000332 RID: 818
		private delegate int get_roomLFDelegate(IntPtr @this);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x06000334 RID: 820
		private delegate void set_roomLFDelegate(IntPtr @this, int value);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x06000336 RID: 822
		private delegate float get_decayTimeDelegate(IntPtr @this);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x06000338 RID: 824
		private delegate void set_decayTimeDelegate(IntPtr @this, float value);

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x0600033A RID: 826
		private delegate float get_decayHFRatioDelegate(IntPtr @this);

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x0600033C RID: 828
		private delegate void set_decayHFRatioDelegate(IntPtr @this, float value);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x0600033E RID: 830
		private delegate int get_reflectionsDelegate(IntPtr @this);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x06000340 RID: 832
		private delegate void set_reflectionsDelegate(IntPtr @this, int value);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x06000342 RID: 834
		private delegate float get_reflectionsDelayDelegate(IntPtr @this);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x06000344 RID: 836
		private delegate void set_reflectionsDelayDelegate(IntPtr @this, float value);

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x06000346 RID: 838
		private delegate int get_reverbDelegate(IntPtr @this);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x06000348 RID: 840
		private delegate void set_reverbDelegate(IntPtr @this, int value);

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x0600034A RID: 842
		private delegate float get_reverbDelayDelegate(IntPtr @this);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x0600034C RID: 844
		private delegate void set_reverbDelayDelegate(IntPtr @this, float value);

		// Token: 0x020000CC RID: 204
		// (Invoke) Token: 0x0600034E RID: 846
		private delegate float get_HFReferenceDelegate(IntPtr @this);

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x06000350 RID: 848
		private delegate void set_HFReferenceDelegate(IntPtr @this, float value);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x06000352 RID: 850
		private delegate float get_LFReferenceDelegate(IntPtr @this);

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x06000354 RID: 852
		private delegate void set_LFReferenceDelegate(IntPtr @this, float value);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x06000356 RID: 854
		private delegate float get_diffusionDelegate(IntPtr @this);

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x06000358 RID: 856
		private delegate void set_diffusionDelegate(IntPtr @this, float value);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x0600035A RID: 858
		private delegate float get_densityDelegate(IntPtr @this);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x0600035C RID: 860
		private delegate void set_densityDelegate(IntPtr @this, float value);
	}
}
