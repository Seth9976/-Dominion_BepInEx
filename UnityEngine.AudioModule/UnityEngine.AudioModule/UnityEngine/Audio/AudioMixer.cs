using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Audio
{
	// Token: 0x02000022 RID: 34
	public class AudioMixer : Object
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00006808 File Offset: 0x00004A08
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000366A File Offset: 0x0000186A
		public AudioMixerGroup outputAudioMixerGroup
		{
			get
			{
				IntPtr intPtr = AudioMixer.get_outputAudioMixerGroupDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				AudioMixer.set_outputAudioMixerGroupDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00006834 File Offset: 0x00004A34
		public AudioMixerSnapshot FindSnapshot(string name)
		{
			IntPtr intPtr = AudioMixer.FindSnapshotDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00006868 File Offset: 0x00004A68
		public Il2CppReferenceArray<AudioMixerGroup> FindMatchingGroups(string subPath)
		{
			IntPtr intPtr = AudioMixer.FindMatchingGroupsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(subPath));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioMixerGroup>>(intPtr2) : null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00003682 File Offset: 0x00001882
		public void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000368F File Offset: 0x0000188F
		public void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach)
		{
			AudioMixer.TransitionToSnapshotInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(snapshot), timeToReach);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000036A8 File Offset: 0x000018A8
		public void TransitionToSnapshots(Il2CppReferenceArray<AudioMixerSnapshot> snapshots, Il2CppStructArray<float> weights, float timeToReach)
		{
			AudioMixer.TransitionToSnapshotsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(snapshots), IL2CPP.Il2CppObjectBaseToPtr(weights), timeToReach);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000036C7 File Offset: 0x000018C7
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x000036D9 File Offset: 0x000018D9
		public AudioMixerUpdateMode updateMode
		{
			get
			{
				return AudioMixer.get_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioMixer.set_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000036EC File Offset: 0x000018EC
		public bool SetFloat(string name, float value)
		{
			return AudioMixer.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00003705 File Offset: 0x00001905
		public bool ClearFloat(string name)
		{
			return AudioMixer.ClearFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000371D File Offset: 0x0000191D
		public bool GetFloat(string name, out float value)
		{
			return AudioMixer.GetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), out value);
		}

		// Token: 0x0400018A RID: 394
		private static readonly AudioMixer.get_outputAudioMixerGroupDelegate get_outputAudioMixerGroupDelegateField = IL2CPP.ResolveICall<AudioMixer.get_outputAudioMixerGroupDelegate>("UnityEngine.Audio.AudioMixer::get_outputAudioMixerGroup");

		// Token: 0x0400018B RID: 395
		private static readonly AudioMixer.set_outputAudioMixerGroupDelegate set_outputAudioMixerGroupDelegateField = IL2CPP.ResolveICall<AudioMixer.set_outputAudioMixerGroupDelegate>("UnityEngine.Audio.AudioMixer::set_outputAudioMixerGroup");

		// Token: 0x0400018C RID: 396
		private static readonly AudioMixer.FindSnapshotDelegate FindSnapshotDelegateField = IL2CPP.ResolveICall<AudioMixer.FindSnapshotDelegate>("UnityEngine.Audio.AudioMixer::FindSnapshot");

		// Token: 0x0400018D RID: 397
		private static readonly AudioMixer.FindMatchingGroupsDelegate FindMatchingGroupsDelegateField = IL2CPP.ResolveICall<AudioMixer.FindMatchingGroupsDelegate>("UnityEngine.Audio.AudioMixer::FindMatchingGroups");

		// Token: 0x0400018E RID: 398
		private static readonly AudioMixer.TransitionToSnapshotInternalDelegate TransitionToSnapshotInternalDelegateField = IL2CPP.ResolveICall<AudioMixer.TransitionToSnapshotInternalDelegate>("UnityEngine.Audio.AudioMixer::TransitionToSnapshotInternal");

		// Token: 0x0400018F RID: 399
		private static readonly AudioMixer.TransitionToSnapshotsDelegate TransitionToSnapshotsDelegateField = IL2CPP.ResolveICall<AudioMixer.TransitionToSnapshotsDelegate>("UnityEngine.Audio.AudioMixer::TransitionToSnapshots");

		// Token: 0x04000190 RID: 400
		private static readonly AudioMixer.get_updateModeDelegate get_updateModeDelegateField = IL2CPP.ResolveICall<AudioMixer.get_updateModeDelegate>("UnityEngine.Audio.AudioMixer::get_updateMode");

		// Token: 0x04000191 RID: 401
		private static readonly AudioMixer.set_updateModeDelegate set_updateModeDelegateField = IL2CPP.ResolveICall<AudioMixer.set_updateModeDelegate>("UnityEngine.Audio.AudioMixer::set_updateMode");

		// Token: 0x04000192 RID: 402
		private static readonly AudioMixer.SetFloatDelegate SetFloatDelegateField = IL2CPP.ResolveICall<AudioMixer.SetFloatDelegate>("UnityEngine.Audio.AudioMixer::SetFloat");

		// Token: 0x04000193 RID: 403
		private static readonly AudioMixer.ClearFloatDelegate ClearFloatDelegateField = IL2CPP.ResolveICall<AudioMixer.ClearFloatDelegate>("UnityEngine.Audio.AudioMixer::ClearFloat");

		// Token: 0x04000194 RID: 404
		private static readonly AudioMixer.GetFloatDelegate GetFloatDelegateField = IL2CPP.ResolveICall<AudioMixer.GetFloatDelegate>("UnityEngine.Audio.AudioMixer::GetFloat");

		// Token: 0x02000136 RID: 310
		// (Invoke) Token: 0x06000422 RID: 1058
		private delegate IntPtr get_outputAudioMixerGroupDelegate(IntPtr @this);

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x06000424 RID: 1060
		private delegate void set_outputAudioMixerGroupDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x06000426 RID: 1062
		private delegate IntPtr FindSnapshotDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x06000428 RID: 1064
		private delegate IntPtr FindMatchingGroupsDelegate(IntPtr @this, IntPtr subPath);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x0600042A RID: 1066
		private delegate void TransitionToSnapshotInternalDelegate(IntPtr @this, IntPtr snapshot, float timeToReach);

		// Token: 0x0200013B RID: 315
		// (Invoke) Token: 0x0600042C RID: 1068
		private delegate void TransitionToSnapshotsDelegate(IntPtr @this, IntPtr snapshots, IntPtr weights, float timeToReach);

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x0600042E RID: 1070
		private delegate AudioMixerUpdateMode get_updateModeDelegate(IntPtr @this);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x06000430 RID: 1072
		private delegate void set_updateModeDelegate(IntPtr @this, AudioMixerUpdateMode value);

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x06000432 RID: 1074
		private delegate bool SetFloatDelegate(IntPtr @this, IntPtr name, float value);

		// Token: 0x0200013F RID: 319
		// (Invoke) Token: 0x06000434 RID: 1076
		private delegate bool ClearFloatDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x06000436 RID: 1078
		private delegate bool GetFloatDelegate(IntPtr @this, IntPtr name, [Out] IntPtr value);
	}
}
