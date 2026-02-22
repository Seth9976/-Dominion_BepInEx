using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x0200001A RID: 26
	public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem>
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// Note: this type is marked as 'beforefieldinit'.
		static XRMeshSubsystemDescriptor()
		{
			Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRMeshSubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr);
			XRMeshSubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr, 100663353);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00005840 File Offset: 0x00003A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158392, XrefRangeEnd = 158395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRMeshSubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRMeshSubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002CF1 File Offset: 0x00000EF1
		public XRMeshSubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
