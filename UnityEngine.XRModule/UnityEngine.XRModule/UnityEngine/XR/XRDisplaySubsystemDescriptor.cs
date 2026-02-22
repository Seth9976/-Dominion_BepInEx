using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x02000011 RID: 17
	public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem>
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00004C94 File Offset: 0x00002E94
		// Note: this type is marked as 'beforefieldinit'.
		static XRDisplaySubsystemDescriptor()
		{
			Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRDisplaySubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr);
			XRDisplaySubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr, 100663332);
			XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::get_disablesLegacyVr");
			XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegateField = IL2CPP.ResolveICall<XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::get_enableBackBufferMSAA");
			XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::GetAvailableMirrorBlitModeCount");
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004D08 File Offset: 0x00002F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158322, XrefRangeEnd = 158325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRDisplaySubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000029B9 File Offset: 0x00000BB9
		public XRDisplaySubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000029C2 File Offset: 0x00000BC2
		public bool disablesLegacyVr
		{
			get
			{
				return XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000029D4 File Offset: 0x00000BD4
		public bool enableBackBufferMSAA
		{
			get
			{
				return XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000029E6 File Offset: 0x00000BE6
		public int GetAvailableMirrorBlitModeCount()
		{
			return XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000C5 RID: 197
		private static readonly XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegate get_disablesLegacyVrDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegate get_enableBackBufferMSAADelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegate GetAvailableMirrorBlitModeCountDelegateField;

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060001FF RID: 511
		private delegate bool get_disablesLegacyVrDelegate(IntPtr @this);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000201 RID: 513
		private delegate bool get_enableBackBufferMSAADelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x06000203 RID: 515
		private delegate int GetAvailableMirrorBlitModeCountDelegate(IntPtr @this);
	}
}
