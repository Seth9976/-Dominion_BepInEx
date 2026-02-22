using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000052 RID: 82
	public class OpenedHost : Object
	{
		// Token: 0x06000744 RID: 1860 RVA: 0x00028218 File Offset: 0x00026418
		// Note: this type is marked as 'beforefieldinit'.
		static OpenedHost()
		{
			Il2CppClassPointerStore<OpenedHost>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "OpenedHost");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr);
			OpenedHost.NativeFieldInfoPtr_nonCachedConnectionsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr, "nonCachedConnectionsCount");
			OpenedHost.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr, 100664504);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00028270 File Offset: 0x00026470
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpenedHost()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenedHost.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00004579 File Offset: 0x00002779
		public OpenedHost(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x000282AC File Offset: 0x000264AC
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00004582 File Offset: 0x00002782
		public unsafe int nonCachedConnectionsCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenedHost.NativeFieldInfoPtr_nonCachedConnectionsCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenedHost.NativeFieldInfoPtr_nonCachedConnectionsCount)) = value;
			}
		}

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr_nonCachedConnectionsCount;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
