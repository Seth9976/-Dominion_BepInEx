using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000026 RID: 38
	public class IScheduler : Il2CppObjectBase
	{
		// Token: 0x0600028A RID: 650 RVA: 0x000142A8 File Offset: 0x000124A8
		// Note: this type is marked as 'beforefieldinit'.
		static IScheduler()
		{
			Il2CppClassPointerStore<IScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IScheduler");
			IScheduler.NativeMethodInfoPtr_Unschedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScheduler>.NativeClassPtr, 100663506);
			IScheduler.NativeMethodInfoPtr_Schedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScheduler>.NativeClassPtr, 100663507);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000142F8 File Offset: 0x000124F8
		[CallerCount(0)]
		public unsafe virtual void Unschedule(ScheduledItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScheduler.NativeMethodInfoPtr_Unschedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00014348 File Offset: 0x00012548
		[CallerCount(0)]
		public unsafe virtual void Schedule(ScheduledItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScheduler.NativeMethodInfoPtr_Schedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000346B File Offset: 0x0000166B
		public IScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_Unschedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0;
	}
}
