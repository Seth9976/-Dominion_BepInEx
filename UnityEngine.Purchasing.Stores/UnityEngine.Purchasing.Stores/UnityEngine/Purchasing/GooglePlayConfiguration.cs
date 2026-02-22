using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001E RID: 30
	public class GooglePlayConfiguration : Object
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00009178 File Offset: 0x00007378
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayConfiguration()
		{
			Il2CppClassPointerStore<GooglePlayConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayConfiguration>.NativeClassPtr);
			GooglePlayConfiguration.NativeFieldInfoPtr_m_InitializationConnectionLister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConfiguration>.NativeClassPtr, "m_InitializationConnectionLister");
			GooglePlayConfiguration.NativeFieldInfoPtr_m_GooglePlayConfigurationInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConfiguration>.NativeClassPtr, "m_GooglePlayConfigurationInternal");
			GooglePlayConfiguration.NativeMethodInfoPtr_SetGooglePlayConfigurationInternal_Internal_Void_IGooglePlayConfigurationInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConfiguration>.NativeClassPtr, 100663425);
			GooglePlayConfiguration.NativeMethodInfoPtr_NotifyInitializationConnectionFailed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConfiguration>.NativeClassPtr, 100663426);
			GooglePlayConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConfiguration>.NativeClassPtr, 100663427);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000920C File Offset: 0x0000740C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151416, XrefRangeEnd = 151426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGooglePlayConfigurationInternal(IGooglePlayConfigurationInternal googlePlayConfigurationInternal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayConfigurationInternal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConfiguration.NativeMethodInfoPtr_SetGooglePlayConfigurationInternal_Internal_Void_IGooglePlayConfigurationInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00009250 File Offset: 0x00007450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151426, XrefRangeEnd = 151427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyInitializationConnectionFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConfiguration.NativeMethodInfoPtr_NotifyInitializationConnectionFailed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00009284 File Offset: 0x00007484
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePlayConfiguration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000027A0 File Offset: 0x000009A0
		public GooglePlayConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000092C0 File Offset: 0x000074C0
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000027A9 File Offset: 0x000009A9
		public unsafe Action m_InitializationConnectionLister
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConfiguration.NativeFieldInfoPtr_m_InitializationConnectionLister);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConfiguration.NativeFieldInfoPtr_m_InitializationConnectionLister), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000092F0 File Offset: 0x000074F0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x000027C8 File Offset: 0x000009C8
		public unsafe IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConfiguration.NativeFieldInfoPtr_m_GooglePlayConfigurationInternal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayConfigurationInternal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConfiguration.NativeFieldInfoPtr_m_GooglePlayConfigurationInternal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_m_InitializationConnectionLister;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayConfigurationInternal;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_SetGooglePlayConfigurationInternal_Internal_Void_IGooglePlayConfigurationInternal_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_NotifyInitializationConnectionFailed_Public_Void_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
