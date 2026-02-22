using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200015B RID: 347
	public sealed class ServicePointManagerElement : ConfigurationElement
	{
		// Token: 0x060015A4 RID: 5540 RVA: 0x00060F94 File Offset: 0x0005F194
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePointManagerElement()
		{
			Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ServicePointManagerElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr);
			ServicePointManagerElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr, 100666277);
			ServicePointManagerElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr, 100666278);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00060FEC File Offset: 0x0005F1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57660, XrefRangeEnd = 57663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePointManagerElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManagerElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x00061028 File Offset: 0x0005F228
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57663, XrefRangeEnd = 57666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManagerElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0000AF06 File Offset: 0x00009106
		public ServicePointManagerElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
