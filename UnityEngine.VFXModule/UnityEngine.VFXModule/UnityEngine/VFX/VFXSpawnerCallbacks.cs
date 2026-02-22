using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.VFX
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class VFXSpawnerCallbacks : ScriptableObject
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00003B64 File Offset: 0x00001D64
		// Note: this type is marked as 'beforefieldinit'.
		static VFXSpawnerCallbacks()
		{
			Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXSpawnerCallbacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr);
			VFXSpawnerCallbacks.NativeMethodInfoPtr_OnPlay_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr, 100663307);
			VFXSpawnerCallbacks.NativeMethodInfoPtr_OnUpdate_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr, 100663308);
			VFXSpawnerCallbacks.NativeMethodInfoPtr_OnStop_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr, 100663309);
			VFXSpawnerCallbacks.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr, 100663310);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[CallerCount(0)]
		public unsafe virtual void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxValues);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxComponent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXSpawnerCallbacks.NativeMethodInfoPtr_OnPlay_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003C58 File Offset: 0x00001E58
		[CallerCount(0)]
		public unsafe virtual void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxValues);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxComponent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXSpawnerCallbacks.NativeMethodInfoPtr_OnUpdate_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003CCC File Offset: 0x00001ECC
		[CallerCount(0)]
		public unsafe virtual void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxValues);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxComponent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXSpawnerCallbacks.NativeMethodInfoPtr_OnStop_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003D40 File Offset: 0x00001F40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82720, RefRangeEnd = 82724, XrefRangeStart = 82720, XrefRangeEnd = 82724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXSpawnerCallbacks()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerCallbacks.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002501 File Offset: 0x00000701
		public VFXSpawnerCallbacks(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_OnPlay_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_OnStop_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
