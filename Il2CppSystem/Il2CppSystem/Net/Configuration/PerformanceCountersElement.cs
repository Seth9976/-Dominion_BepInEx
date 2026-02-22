using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200015A RID: 346
	public sealed class PerformanceCountersElement : ConfigurationElement
	{
		// Token: 0x060015A0 RID: 5536 RVA: 0x00060EC0 File Offset: 0x0005F0C0
		// Note: this type is marked as 'beforefieldinit'.
		static PerformanceCountersElement()
		{
			Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "PerformanceCountersElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr);
			PerformanceCountersElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr, 100666275);
			PerformanceCountersElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr, 100666276);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00060F18 File Offset: 0x0005F118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57654, XrefRangeEnd = 57657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerformanceCountersElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerformanceCountersElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceCountersElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00060F54 File Offset: 0x0005F154
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57657, XrefRangeEnd = 57660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceCountersElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0000AEFD File Offset: 0x000090FD
		public PerformanceCountersElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}
