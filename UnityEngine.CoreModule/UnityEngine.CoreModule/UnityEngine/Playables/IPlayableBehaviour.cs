using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200014B RID: 331
	public class IPlayableBehaviour : Il2CppObjectBase
	{
		// Token: 0x06001947 RID: 6471 RVA: 0x0005C254 File Offset: 0x0005A454
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayableBehaviour()
		{
			Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "IPlayableBehaviour");
			IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100665176);
			IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100665177);
			IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100665178);
			IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100665179);
			IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100665180);
			IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100665181);
			IPlayableBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100665182);
			IPlayableBehaviour.NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100665183);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0005C31C File Offset: 0x0005A51C
		[CallerCount(0)]
		public unsafe virtual void OnGraphStart(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0005C368 File Offset: 0x0005A568
		[CallerCount(0)]
		public unsafe virtual void OnGraphStop(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0005C3B4 File Offset: 0x0005A5B4
		[CallerCount(0)]
		public unsafe virtual void OnPlayableCreate(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0005C400 File Offset: 0x0005A600
		[CallerCount(0)]
		public unsafe virtual void OnPlayableDestroy(Playable playable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0005C44C File Offset: 0x0005A64C
		[CallerCount(0)]
		public unsafe virtual void OnBehaviourPlay(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0005C4A4 File Offset: 0x0005A6A4
		[CallerCount(0)]
		public unsafe virtual void OnBehaviourPause(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0005C4FC File Offset: 0x0005A6FC
		[CallerCount(0)]
		public unsafe virtual void PrepareFrame(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0005C554 File Offset: 0x0005A754
		[CallerCount(0)]
		public unsafe virtual void ProcessFrame(Playable playable, FrameData info, Object playerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayableBehaviour.NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0000E1CE File Offset: 0x0000C3CE
		public IPlayableBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0;
	}
}
