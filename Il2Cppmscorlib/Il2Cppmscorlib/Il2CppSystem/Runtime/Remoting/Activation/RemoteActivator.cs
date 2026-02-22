using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D8 RID: 984
	public class RemoteActivator : MarshalByRefObject
	{
		// Token: 0x06003E98 RID: 16024 RVA: 0x00124474 File Offset: 0x00122674
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteActivator()
		{
			Il2CppClassPointerStore<RemoteActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "RemoteActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteActivator>.NativeClassPtr);
			RemoteActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteActivator>.NativeClassPtr, 100672487);
			RemoteActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteActivator>.NativeClassPtr, 100672488);
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x001244CC File Offset: 0x001226CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353887, XrefRangeEnd = 353940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06003E9A RID: 16026 RVA: 0x0012451C File Offset: 0x0012271C
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353940, XrefRangeEnd = 353945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x00017994 File Offset: 0x00015B94
		public RemoteActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400338D RID: 13197
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0;

		// Token: 0x0400338E RID: 13198
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0;
	}
}
