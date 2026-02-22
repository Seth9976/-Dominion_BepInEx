using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	public sealed class Microphone
	{
		// Token: 0x0600019B RID: 411 RVA: 0x00003407 File Offset: 0x00001607
		public static int GetMicrophoneDeviceIDFromName(string name)
		{
			return Microphone.GetMicrophoneDeviceIDFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00006188 File Offset: 0x00004388
		public static AudioClip StartRecord(int deviceID, bool loop, float lengthSec, int frequency)
		{
			IntPtr intPtr = Microphone.StartRecordDelegateField(deviceID, loop, lengthSec, frequency);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00003419 File Offset: 0x00001619
		public static void EndRecord(int deviceID)
		{
			Microphone.EndRecordDelegateField(deviceID);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00003426 File Offset: 0x00001626
		public static bool IsRecording(int deviceID)
		{
			return Microphone.IsRecordingDelegateField(deviceID);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00003433 File Offset: 0x00001633
		public static int GetRecordPosition(int deviceID)
		{
			return Microphone.GetRecordPositionDelegateField(deviceID);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00003440 File Offset: 0x00001640
		public static void GetDeviceCaps(int deviceID, out int minFreq, out int maxFreq)
		{
			Microphone.GetDeviceCapsDelegateField(deviceID, out minFreq, out maxFreq);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000061B4 File Offset: 0x000043B4
		public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency)
		{
			int microphoneDeviceIDFromName = Microphone.GetMicrophoneDeviceIDFromName(deviceName);
			bool flag = microphoneDeviceIDFromName == -1;
			if (flag)
			{
				throw new ArgumentException(String.Concat("Couldn't acquire device ID for device name ", deviceName));
			}
			bool flag2 = lengthSec <= 0;
			if (flag2)
			{
				throw new ArgumentException(String.Concat("Length of recording must be greater than zero seconds (was: ", lengthSec.ToString(), " seconds)"));
			}
			bool flag3 = lengthSec > 3600;
			if (flag3)
			{
				throw new ArgumentException(String.Concat("Length of recording must be less than one hour (was: ", lengthSec.ToString(), " seconds)"));
			}
			bool flag4 = frequency <= 0;
			if (flag4)
			{
				throw new ArgumentException(String.Concat("Frequency of recording must be greater than zero (was: ", frequency.ToString(), " Hz)"));
			}
			return Microphone.StartRecord(microphoneDeviceIDFromName, loop, (float)lengthSec, frequency);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000626C File Offset: 0x0000446C
		public static void End(string deviceName)
		{
			int microphoneDeviceIDFromName = Microphone.GetMicrophoneDeviceIDFromName(deviceName);
			bool flag = microphoneDeviceIDFromName == -1;
			if (!flag)
			{
				Microphone.EndRecord(microphoneDeviceIDFromName);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00006294 File Offset: 0x00004494
		public static Il2CppStringArray devices
		{
			get
			{
				IntPtr intPtr = Microphone.get_devicesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000062BC File Offset: 0x000044BC
		public static bool IsRecording(string deviceName)
		{
			int microphoneDeviceIDFromName = Microphone.GetMicrophoneDeviceIDFromName(deviceName);
			bool flag = microphoneDeviceIDFromName == -1;
			return !flag && Microphone.IsRecording(microphoneDeviceIDFromName);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000062E8 File Offset: 0x000044E8
		public static int GetPosition(string deviceName)
		{
			int microphoneDeviceIDFromName = Microphone.GetMicrophoneDeviceIDFromName(deviceName);
			bool flag = microphoneDeviceIDFromName == -1;
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				num = Microphone.GetRecordPosition(microphoneDeviceIDFromName);
			}
			return num;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006314 File Offset: 0x00004514
		public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq)
		{
			minFreq = 0;
			maxFreq = 0;
			int microphoneDeviceIDFromName = Microphone.GetMicrophoneDeviceIDFromName(deviceName);
			bool flag = microphoneDeviceIDFromName == -1;
			if (!flag)
			{
				Microphone.GetDeviceCaps(microphoneDeviceIDFromName, out minFreq, out maxFreq);
			}
		}

		// Token: 0x0400015D RID: 349
		private static readonly Microphone.GetMicrophoneDeviceIDFromNameDelegate GetMicrophoneDeviceIDFromNameDelegateField = IL2CPP.ResolveICall<Microphone.GetMicrophoneDeviceIDFromNameDelegate>("UnityEngine.Microphone::GetMicrophoneDeviceIDFromName");

		// Token: 0x0400015E RID: 350
		private static readonly Microphone.StartRecordDelegate StartRecordDelegateField = IL2CPP.ResolveICall<Microphone.StartRecordDelegate>("UnityEngine.Microphone::StartRecord");

		// Token: 0x0400015F RID: 351
		private static readonly Microphone.EndRecordDelegate EndRecordDelegateField = IL2CPP.ResolveICall<Microphone.EndRecordDelegate>("UnityEngine.Microphone::EndRecord");

		// Token: 0x04000160 RID: 352
		private static readonly Microphone.IsRecordingDelegate IsRecordingDelegateField = IL2CPP.ResolveICall<Microphone.IsRecordingDelegate>("UnityEngine.Microphone::IsRecording");

		// Token: 0x04000161 RID: 353
		private static readonly Microphone.GetRecordPositionDelegate GetRecordPositionDelegateField = IL2CPP.ResolveICall<Microphone.GetRecordPositionDelegate>("UnityEngine.Microphone::GetRecordPosition");

		// Token: 0x04000162 RID: 354
		private static readonly Microphone.GetDeviceCapsDelegate GetDeviceCapsDelegateField = IL2CPP.ResolveICall<Microphone.GetDeviceCapsDelegate>("UnityEngine.Microphone::GetDeviceCaps");

		// Token: 0x04000163 RID: 355
		private static readonly Microphone.get_devicesDelegate get_devicesDelegateField = IL2CPP.ResolveICall<Microphone.get_devicesDelegate>("UnityEngine.Microphone::get_devices");

		// Token: 0x02000114 RID: 276
		// (Invoke) Token: 0x060003DE RID: 990
		private delegate int GetMicrophoneDeviceIDFromNameDelegate(IntPtr name);

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x060003E0 RID: 992
		private delegate IntPtr StartRecordDelegate(int deviceID, bool loop, float lengthSec, int frequency);

		// Token: 0x02000116 RID: 278
		// (Invoke) Token: 0x060003E2 RID: 994
		private delegate void EndRecordDelegate(int deviceID);

		// Token: 0x02000117 RID: 279
		// (Invoke) Token: 0x060003E4 RID: 996
		private delegate bool IsRecordingDelegate(int deviceID);

		// Token: 0x02000118 RID: 280
		// (Invoke) Token: 0x060003E6 RID: 998
		private delegate int GetRecordPositionDelegate(int deviceID);

		// Token: 0x02000119 RID: 281
		// (Invoke) Token: 0x060003E8 RID: 1000
		private delegate void GetDeviceCapsDelegate(int deviceID, [Out] IntPtr minFreq, [Out] IntPtr maxFreq);

		// Token: 0x0200011A RID: 282
		// (Invoke) Token: 0x060003EA RID: 1002
		private delegate IntPtr get_devicesDelegate();
	}
}
