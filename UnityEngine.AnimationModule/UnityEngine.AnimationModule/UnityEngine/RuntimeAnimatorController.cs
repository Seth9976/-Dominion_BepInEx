using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	public class RuntimeAnimatorController : Object
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00003504 File Offset: 0x00001704
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeAnimatorController()
		{
			Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "RuntimeAnimatorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeAnimatorController>.NativeClassPtr);
			RuntimeAnimatorController.get_animationClipsDelegateField = IL2CPP.ResolveICall<RuntimeAnimatorController.get_animationClipsDelegate>("UnityEngine.RuntimeAnimatorController::get_animationClips");
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00003538 File Offset: 0x00001738
		public RuntimeAnimatorController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00009198 File Offset: 0x00007398
		public Il2CppReferenceArray<AnimationClip> animationClips
		{
			get
			{
				IntPtr intPtr = RuntimeAnimatorController.get_animationClipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationClip>>(intPtr2) : null;
			}
		}

		// Token: 0x0400013C RID: 316
		private static readonly RuntimeAnimatorController.get_animationClipsDelegate get_animationClipsDelegateField;

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x060006F6 RID: 1782
		private delegate IntPtr get_animationClipsDelegate(IntPtr @this);
	}
}
