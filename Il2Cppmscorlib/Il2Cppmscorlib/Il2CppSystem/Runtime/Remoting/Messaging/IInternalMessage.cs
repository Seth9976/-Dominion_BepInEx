using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003F5 RID: 1013
	public class IInternalMessage : Il2CppObjectBase
	{
		// Token: 0x06004007 RID: 16391 RVA: 0x0012933C File Offset: 0x0012753C
		// Note: this type is marked as 'beforefieldinit'.
		static IInternalMessage()
		{
			Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IInternalMessage");
			IInternalMessage.NativeMethodInfoPtr_get_TargetIdentity_Public_Abstract_Virtual_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100672645);
			IInternalMessage.NativeMethodInfoPtr_set_TargetIdentity_Public_Abstract_Virtual_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100672646);
			IInternalMessage.NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100672647);
			IInternalMessage.NativeMethodInfoPtr_set_Uri_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalMessage>.NativeClassPtr, 100672648);
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06004008 RID: 16392 RVA: 0x001293B4 File Offset: 0x001275B4
		// (set) Token: 0x06004009 RID: 16393 RVA: 0x00129400 File Offset: 0x00127600
		public unsafe virtual Identity TargetIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_get_TargetIdentity_Public_Abstract_Virtual_New_get_Identity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_set_TargetIdentity_Public_Abstract_Virtual_New_set_Void_Identity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x0600400A RID: 16394 RVA: 0x00129450 File Offset: 0x00127650
		// (set) Token: 0x0600400B RID: 16395 RVA: 0x00129494 File Offset: 0x00127694
		public unsafe virtual string Uri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalMessage.NativeMethodInfoPtr_set_Uri_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x0001842A File Offset: 0x0001662A
		public IInternalMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003475 RID: 13429
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetIdentity_Public_Abstract_Virtual_New_get_Identity_0;

		// Token: 0x04003476 RID: 13430
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetIdentity_Public_Abstract_Virtual_New_set_Void_Identity_0;

		// Token: 0x04003477 RID: 13431
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04003478 RID: 13432
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_Abstract_Virtual_New_set_Void_String_0;
	}
}
