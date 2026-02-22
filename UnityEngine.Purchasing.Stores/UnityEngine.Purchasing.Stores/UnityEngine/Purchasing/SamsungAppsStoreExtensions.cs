using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003A RID: 58
	public class SamsungAppsStoreExtensions : AndroidJavaProxy
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x0000BE7C File Offset: 0x0000A07C
		// Note: this type is marked as 'beforefieldinit'.
		static SamsungAppsStoreExtensions()
		{
			Il2CppClassPointerStore<SamsungAppsStoreExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "SamsungAppsStoreExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SamsungAppsStoreExtensions>.NativeClassPtr);
			SamsungAppsStoreExtensions.NativeFieldInfoPtr_m_Java = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamsungAppsStoreExtensions>.NativeClassPtr, "m_Java");
			SamsungAppsStoreExtensions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamsungAppsStoreExtensions>.NativeClassPtr, 100663519);
			SamsungAppsStoreExtensions.NativeMethodInfoPtr_SetAndroidJavaObject_Public_Void_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamsungAppsStoreExtensions>.NativeClassPtr, 100663520);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152255, XrefRangeEnd = 152261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SamsungAppsStoreExtensions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SamsungAppsStoreExtensions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SamsungAppsStoreExtensions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000BF24 File Offset: 0x0000A124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAndroidJavaObject(AndroidJavaObject java)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(java);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SamsungAppsStoreExtensions.NativeMethodInfoPtr_SetAndroidJavaObject_Public_Void_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002E8F File Offset: 0x0000108F
		public SamsungAppsStoreExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000BF68 File Offset: 0x0000A168
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002E98 File Offset: 0x00001098
		public unsafe AndroidJavaObject m_Java
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamsungAppsStoreExtensions.NativeFieldInfoPtr_m_Java);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamsungAppsStoreExtensions.NativeFieldInfoPtr_m_Java), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_m_Java;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_SetAndroidJavaObject_Public_Void_AndroidJavaObject_0;
	}
}
