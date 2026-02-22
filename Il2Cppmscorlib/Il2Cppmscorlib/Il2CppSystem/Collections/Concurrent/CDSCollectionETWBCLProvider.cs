using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Diagnostics.Tracing;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x02000487 RID: 1159
	public sealed class CDSCollectionETWBCLProvider : EventSource
	{
		// Token: 0x06004576 RID: 17782 RVA: 0x0013D968 File Offset: 0x0013BB68
		// Note: this type is marked as 'beforefieldinit'.
		static CDSCollectionETWBCLProvider()
		{
			Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "CDSCollectionETWBCLProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr);
			CDSCollectionETWBCLProvider.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, "Log");
			CDSCollectionETWBCLProvider.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, 100673514);
			CDSCollectionETWBCLProvider.NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, 100673515);
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x0013D9D4 File Offset: 0x0013BBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361142, XrefRangeEnd = 361146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CDSCollectionETWBCLProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CDSCollectionETWBCLProvider.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x0013DA10 File Offset: 0x0013BC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361148, RefRangeEnd = 361149, XrefRangeStart = 361146, XrefRangeEnd = 361148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numOfBuckets;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CDSCollectionETWBCLProvider.NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x0001A859 File Offset: 0x00018A59
		public CDSCollectionETWBCLProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x0013DA50 File Offset: 0x0013BC50
		// (set) Token: 0x0600457B RID: 17787 RVA: 0x0001A862 File Offset: 0x00018A62
		public unsafe static CDSCollectionETWBCLProvider Log
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CDSCollectionETWBCLProvider.NativeFieldInfoPtr_Log, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CDSCollectionETWBCLProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CDSCollectionETWBCLProvider.NativeFieldInfoPtr_Log, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400387D RID: 14461
		private static readonly IntPtr NativeFieldInfoPtr_Log;

		// Token: 0x0400387E RID: 14462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400387F RID: 14463
		private static readonly IntPtr NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0;
	}
}
