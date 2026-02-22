using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine
{
	// Token: 0x020000CF RID: 207
	public class ISerializationCallbackReceiver : Il2CppObjectBase
	{
		// Token: 0x0600119F RID: 4511 RVA: 0x00047664 File Offset: 0x00045864
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializationCallbackReceiver()
		{
			Il2CppClassPointerStore<ISerializationCallbackReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ISerializationCallbackReceiver");
			ISerializationCallbackReceiver.NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationCallbackReceiver>.NativeClassPtr, 100664539);
			ISerializationCallbackReceiver.NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationCallbackReceiver>.NativeClassPtr, 100664540);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x000476B4 File Offset: 0x000458B4
		[CallerCount(0)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationCallbackReceiver.NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000476F0 File Offset: 0x000458F0
		[CallerCount(0)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationCallbackReceiver.NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0000A8FF File Offset: 0x00008AFF
		public ISerializationCallbackReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0;
	}
}
