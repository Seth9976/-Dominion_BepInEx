using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003AD RID: 941
	public class ILease : Il2CppObjectBase
	{
		// Token: 0x06003D2B RID: 15659 RVA: 0x0011F52C File Offset: 0x0011D72C
		// Note: this type is marked as 'beforefieldinit'.
		static ILease()
		{
			Il2CppClassPointerStore<ILease>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "ILease");
			ILease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100672304);
			ILease.NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100672305);
			ILease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100672306);
			ILease.NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100672307);
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06003D2C RID: 15660 RVA: 0x0011F5A4 File Offset: 0x0011D7A4
		public unsafe virtual TimeSpan CurrentLeaseTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06003D2D RID: 15661 RVA: 0x0011F5EC File Offset: 0x0011D7EC
		public unsafe virtual LeaseState CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06003D2E RID: 15662 RVA: 0x0011F634 File Offset: 0x0011D834
		public unsafe virtual TimeSpan RenewOnCallTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x0011F67C File Offset: 0x0011D87C
		[CallerCount(0)]
		public unsafe virtual TimeSpan Renew(TimeSpan renewalTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renewalTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00017065 File Offset: 0x00015265
		public ILease(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040032A7 RID: 12967
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0;

		// Token: 0x040032A8 RID: 12968
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0;

		// Token: 0x040032A9 RID: 12969
		private static readonly IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0;

		// Token: 0x040032AA RID: 12970
		private static readonly IntPtr NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0;
	}
}
