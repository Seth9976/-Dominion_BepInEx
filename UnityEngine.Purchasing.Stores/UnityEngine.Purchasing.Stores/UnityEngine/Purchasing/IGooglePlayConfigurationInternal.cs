using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000025 RID: 37
	public class IGooglePlayConfigurationInternal : Il2CppObjectBase
	{
		// Token: 0x0600014C RID: 332 RVA: 0x0000A284 File Offset: 0x00008484
		// Note: this type is marked as 'beforefieldinit'.
		static IGooglePlayConfigurationInternal()
		{
			Il2CppClassPointerStore<IGooglePlayConfigurationInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IGooglePlayConfigurationInternal");
			IGooglePlayConfigurationInternal.NativeMethodInfoPtr_SetGooglePlayConfiguration_Public_Abstract_Virtual_New_Void_GooglePlayConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayConfigurationInternal>.NativeClassPtr, 100663453);
			IGooglePlayConfigurationInternal.NativeMethodInfoPtr_NotifyInitializationConnectionFailed_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayConfigurationInternal>.NativeClassPtr, 100663454);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000A2D4 File Offset: 0x000084D4
		[CallerCount(0)]
		public unsafe virtual void SetGooglePlayConfiguration(GooglePlayConfiguration googlePlayConfiguration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayConfiguration);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayConfigurationInternal.NativeMethodInfoPtr_SetGooglePlayConfiguration_Public_Abstract_Virtual_New_Void_GooglePlayConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000A324 File Offset: 0x00008524
		[CallerCount(0)]
		public unsafe virtual void NotifyInitializationConnectionFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayConfigurationInternal.NativeMethodInfoPtr_NotifyInitializationConnectionFailed_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002A47 File Offset: 0x00000C47
		public IGooglePlayConfigurationInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_SetGooglePlayConfiguration_Public_Abstract_Virtual_New_Void_GooglePlayConfiguration_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_NotifyInitializationConnectionFailed_Public_Abstract_Virtual_New_Void_0;
	}
}
