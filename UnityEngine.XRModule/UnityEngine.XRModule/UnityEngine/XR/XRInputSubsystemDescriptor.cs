using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x02000013 RID: 19
	public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem>
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00004F74 File Offset: 0x00003174
		// Note: this type is marked as 'beforefieldinit'.
		static XRInputSubsystemDescriptor()
		{
			Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRInputSubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr);
			XRInputSubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr, 100663336);
			XRInputSubsystemDescriptor.get_disablesLegacyInputDelegateField = IL2CPP.ResolveICall<XRInputSubsystemDescriptor.get_disablesLegacyInputDelegate>("UnityEngine.XR.XRInputSubsystemDescriptor::get_disablesLegacyInput");
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004FC8 File Offset: 0x000031C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158346, XrefRangeEnd = 158349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRInputSubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRInputSubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002B0B File Offset: 0x00000D0B
		public XRInputSubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00002B14 File Offset: 0x00000D14
		public bool disablesLegacyInput
		{
			get
			{
				return XRInputSubsystemDescriptor.get_disablesLegacyInputDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000D5 RID: 213
		private static readonly XRInputSubsystemDescriptor.get_disablesLegacyInputDelegate get_disablesLegacyInputDelegateField;

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x06000213 RID: 531
		private delegate bool get_disablesLegacyInputDelegate(IntPtr @this);
	}
}
