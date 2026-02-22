using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.VFX
{
	// Token: 0x02000004 RID: 4
	public static class VFXManager : Object
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00003A54 File Offset: 0x00001C54
		// Note: this type is marked as 'beforefieldinit'.
		static VFXManager()
		{
			Il2CppClassPointerStore<VFXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXManager>.NativeClassPtr);
			VFXManager.GetComponentsDelegateField = IL2CPP.ResolveICall<VFXManager.GetComponentsDelegate>("UnityEngine.VFX.VFXManager::GetComponents");
			VFXManager.get_fixedTimeStepDelegateField = IL2CPP.ResolveICall<VFXManager.get_fixedTimeStepDelegate>("UnityEngine.VFX.VFXManager::get_fixedTimeStep");
			VFXManager.set_fixedTimeStepDelegateField = IL2CPP.ResolveICall<VFXManager.set_fixedTimeStepDelegate>("UnityEngine.VFX.VFXManager::set_fixedTimeStep");
			VFXManager.get_maxDeltaTimeDelegateField = IL2CPP.ResolveICall<VFXManager.get_maxDeltaTimeDelegate>("UnityEngine.VFX.VFXManager::get_maxDeltaTime");
			VFXManager.set_maxDeltaTimeDelegateField = IL2CPP.ResolveICall<VFXManager.set_maxDeltaTimeDelegate>("UnityEngine.VFX.VFXManager::set_maxDeltaTime");
			VFXManager.get_renderPipeSettingsPathDelegateField = IL2CPP.ResolveICall<VFXManager.get_renderPipeSettingsPathDelegate>("UnityEngine.VFX.VFXManager::get_renderPipeSettingsPath");
			VFXManager.PrepareCameraDelegateField = IL2CPP.ResolveICall<VFXManager.PrepareCameraDelegate>("UnityEngine.VFX.VFXManager::PrepareCamera");
			VFXManager.ProcessCameraCommandDelegateField = IL2CPP.ResolveICall<VFXManager.ProcessCameraCommandDelegate>("UnityEngine.VFX.VFXManager::ProcessCameraCommand");
			VFXManager.IsCameraBufferNeededDelegateField = IL2CPP.ResolveICall<VFXManager.IsCameraBufferNeededDelegate>("UnityEngine.VFX.VFXManager::IsCameraBufferNeeded");
			VFXManager.SetCameraBufferDelegateField = IL2CPP.ResolveICall<VFXManager.SetCameraBufferDelegate>("UnityEngine.VFX.VFXManager::SetCameraBuffer");
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002458 File Offset: 0x00000658
		public VFXManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003B1C File Offset: 0x00001D1C
		public static Il2CppReferenceArray<VisualEffect> GetComponents()
		{
			IntPtr intPtr = VFXManager.GetComponentsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualEffect>>(intPtr2) : null;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002461 File Offset: 0x00000661
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000246D File Offset: 0x0000066D
		public static float fixedTimeStep
		{
			get
			{
				return VFXManager.get_fixedTimeStepDelegateField();
			}
			set
			{
				VFXManager.set_fixedTimeStepDelegateField(value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000247A File Offset: 0x0000067A
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002486 File Offset: 0x00000686
		public static float maxDeltaTime
		{
			get
			{
				return VFXManager.get_maxDeltaTimeDelegateField();
			}
			set
			{
				VFXManager.set_maxDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003B44 File Offset: 0x00001D44
		public static string renderPipeSettingsPath
		{
			get
			{
				IntPtr intPtr = VFXManager.get_renderPipeSettingsPathDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002493 File Offset: 0x00000693
		public static void ProcessCamera(Camera cam)
		{
			VFXManager.PrepareCamera(cam);
			VFXManager.ProcessCameraCommand(cam, null);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000024A5 File Offset: 0x000006A5
		public static void PrepareCamera(Camera cam)
		{
			VFXManager.PrepareCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cam));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000024B7 File Offset: 0x000006B7
		public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd)
		{
			VFXManager.ProcessCameraCommandDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cam), IL2CPP.Il2CppObjectBaseToPtr(cmd));
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000024CF File Offset: 0x000006CF
		public static VFXCameraBufferTypes IsCameraBufferNeeded(Camera cam)
		{
			return VFXManager.IsCameraBufferNeededDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cam));
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000024E1 File Offset: 0x000006E1
		public static void SetCameraBuffer(Camera cam, VFXCameraBufferTypes type, Texture buffer, int x, int y, int width, int height)
		{
			VFXManager.SetCameraBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(cam), type, IL2CPP.Il2CppObjectBaseToPtr(buffer), x, y, width, height);
		}

		// Token: 0x04000035 RID: 53
		private static readonly VFXManager.GetComponentsDelegate GetComponentsDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly VFXManager.get_fixedTimeStepDelegate get_fixedTimeStepDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly VFXManager.set_fixedTimeStepDelegate set_fixedTimeStepDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly VFXManager.get_maxDeltaTimeDelegate get_maxDeltaTimeDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly VFXManager.set_maxDeltaTimeDelegate set_maxDeltaTimeDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly VFXManager.get_renderPipeSettingsPathDelegate get_renderPipeSettingsPathDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly VFXManager.PrepareCameraDelegate PrepareCameraDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly VFXManager.ProcessCameraCommandDelegate ProcessCameraCommandDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly VFXManager.IsCameraBufferNeededDelegate IsCameraBufferNeededDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly VFXManager.SetCameraBufferDelegate SetCameraBufferDelegateField;

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000198 RID: 408
		private delegate IntPtr GetComponentsDelegate();

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x0600019A RID: 410
		private delegate float get_fixedTimeStepDelegate();

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x0600019C RID: 412
		private delegate void set_fixedTimeStepDelegate(float value);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600019E RID: 414
		private delegate float get_maxDeltaTimeDelegate();

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060001A0 RID: 416
		private delegate void set_maxDeltaTimeDelegate(float value);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060001A2 RID: 418
		private delegate IntPtr get_renderPipeSettingsPathDelegate();

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060001A4 RID: 420
		private delegate void PrepareCameraDelegate(IntPtr cam);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060001A6 RID: 422
		private delegate void ProcessCameraCommandDelegate(IntPtr cam, IntPtr cmd);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060001A8 RID: 424
		private delegate VFXCameraBufferTypes IsCameraBufferNeededDelegate(IntPtr cam);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060001AA RID: 426
		private delegate void SetCameraBufferDelegate(IntPtr cam, VFXCameraBufferTypes type, IntPtr buffer, int x, int y, int width, int height);
	}
}
