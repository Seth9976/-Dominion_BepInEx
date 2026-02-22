using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x0200008E RID: 142
	public class IGoogleLastKnownProductService : Il2CppObjectBase
	{
		// Token: 0x06000593 RID: 1427 RVA: 0x000183F8 File Offset: 0x000165F8
		// Note: this type is marked as 'beforefieldinit'.
		static IGoogleLastKnownProductService()
		{
			Il2CppClassPointerStore<IGoogleLastKnownProductService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Interfaces", "IGoogleLastKnownProductService");
			IGoogleLastKnownProductService.NativeMethodInfoPtr_GetLastKnownProductId_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleLastKnownProductService>.NativeClassPtr, 100663974);
			IGoogleLastKnownProductService.NativeMethodInfoPtr_SetLastKnownProductId_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleLastKnownProductService>.NativeClassPtr, 100663975);
			IGoogleLastKnownProductService.NativeMethodInfoPtr_GetLastKnownProrationMode_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleLastKnownProductService>.NativeClassPtr, 100663976);
			IGoogleLastKnownProductService.NativeMethodInfoPtr_SetLastKnownProrationMode_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleLastKnownProductService>.NativeClassPtr, 100663977);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00018470 File Offset: 0x00016670
		[CallerCount(0)]
		public unsafe virtual string GetLastKnownProductId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleLastKnownProductService.NativeMethodInfoPtr_GetLastKnownProductId_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000184B4 File Offset: 0x000166B4
		[CallerCount(0)]
		public unsafe virtual void SetLastKnownProductId(string lastKnownProductId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lastKnownProductId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleLastKnownProductService.NativeMethodInfoPtr_SetLastKnownProductId_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00018504 File Offset: 0x00016704
		[CallerCount(0)]
		public unsafe virtual int GetLastKnownProrationMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleLastKnownProductService.NativeMethodInfoPtr_GetLastKnownProrationMode_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0001854C File Offset: 0x0001674C
		[CallerCount(0)]
		public unsafe virtual void SetLastKnownProrationMode(int lastKnownProrationMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lastKnownProrationMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleLastKnownProductService.NativeMethodInfoPtr_SetLastKnownProrationMode_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00004D0D File Offset: 0x00002F0D
		public IGoogleLastKnownProductService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_GetLastKnownProductId_Public_Abstract_Virtual_New_String_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_SetLastKnownProductId_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_GetLastKnownProrationMode_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_SetLastKnownProrationMode_Public_Abstract_Virtual_New_Void_Int32_0;
	}
}
