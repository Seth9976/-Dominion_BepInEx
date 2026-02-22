using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D2 RID: 978
	[Serializable]
	public class ConstructionLevelActivator : Object
	{
		// Token: 0x06003E77 RID: 15991 RVA: 0x00123CB4 File Offset: 0x00121EB4
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionLevelActivator()
		{
			Il2CppClassPointerStore<ConstructionLevelActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "ConstructionLevelActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionLevelActivator>.NativeClassPtr);
			ConstructionLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionLevelActivator>.NativeClassPtr, 100672470);
			ConstructionLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionLevelActivator>.NativeClassPtr, 100672471);
			ConstructionLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionLevelActivator>.NativeClassPtr, 100672472);
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x00123D20 File Offset: 0x00121F20
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x00123D60 File Offset: 0x00121F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353834, XrefRangeEnd = 353841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x00123DB0 File Offset: 0x00121FB0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionLevelActivator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionLevelActivator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x00017905 File Offset: 0x00015B05
		public ConstructionLevelActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400337A RID: 13178
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0;

		// Token: 0x0400337B RID: 13179
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0;

		// Token: 0x0400337C RID: 13180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
