using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x020000E9 RID: 233
	public class MetaData : Object
	{
		// Token: 0x0600145F RID: 5215 RVA: 0x0004E784 File Offset: 0x0004C984
		// Note: this type is marked as 'beforefieldinit'.
		static MetaData()
		{
			Il2CppClassPointerStore<MetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling.Memory.Experimental", "MetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaData>.NativeClassPtr);
			MetaData.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "content");
			MetaData.NativeFieldInfoPtr_platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "platform");
			MetaData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaData>.NativeClassPtr, 100664762);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0004E7F0 File Offset: 0x0004C9F0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0000BBBB File Offset: 0x00009DBB
		public MetaData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0004E82C File Offset: 0x0004CA2C
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		public unsafe string content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_content);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_content), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0004E854 File Offset: 0x0004CA54
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x0000BBE3 File Offset: 0x00009DE3
		public unsafe string platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_platform);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_platform), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeFieldInfoPtr_platform;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
