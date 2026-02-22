using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001F RID: 31
	public class GooglePlayConfigurationInternal : Object
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00009320 File Offset: 0x00007520
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayConfigurationInternal()
		{
			Il2CppClassPointerStore<GooglePlayConfigurationInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayConfigurationInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayConfigurationInternal>.NativeClassPtr);
			GooglePlayConfigurationInternal.NativeFieldInfoPtr_m_GooglePlayConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConfigurationInternal>.NativeClassPtr, "m_GooglePlayConfiguration");
			GooglePlayConfigurationInternal.NativeMethodInfoPtr_SetGooglePlayConfiguration_Public_Virtual_Final_New_Void_GooglePlayConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConfigurationInternal>.NativeClassPtr, 100663428);
			GooglePlayConfigurationInternal.NativeMethodInfoPtr_NotifyInitializationConnectionFailed_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConfigurationInternal>.NativeClassPtr, 100663429);
			GooglePlayConfigurationInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConfigurationInternal>.NativeClassPtr, 100663430);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000093A0 File Offset: 0x000075A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGooglePlayConfiguration(GooglePlayConfiguration googlePlayConfiguration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayConfiguration);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConfigurationInternal.NativeMethodInfoPtr_SetGooglePlayConfiguration_Public_Virtual_Final_New_Void_GooglePlayConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000093E4 File Offset: 0x000075E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151427, XrefRangeEnd = 151428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyInitializationConnectionFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConfigurationInternal.NativeMethodInfoPtr_NotifyInitializationConnectionFailed_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00009418 File Offset: 0x00007618
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePlayConfigurationInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayConfigurationInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConfigurationInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000027E7 File Offset: 0x000009E7
		public GooglePlayConfigurationInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00009454 File Offset: 0x00007654
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000027F0 File Offset: 0x000009F0
		public unsafe GooglePlayConfiguration m_GooglePlayConfiguration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConfigurationInternal.NativeFieldInfoPtr_m_GooglePlayConfiguration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConfigurationInternal.NativeFieldInfoPtr_m_GooglePlayConfiguration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayConfiguration;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_SetGooglePlayConfiguration_Public_Virtual_Final_New_Void_GooglePlayConfiguration_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_NotifyInitializationConnectionFailed_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
