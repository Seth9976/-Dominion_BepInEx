using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Services
{
	// Token: 0x020003A7 RID: 935
	public class ITrackingHandler : Il2CppObjectBase
	{
		// Token: 0x06003CD3 RID: 15571 RVA: 0x0011DF1C File Offset: 0x0011C11C
		// Note: this type is marked as 'beforefieldinit'.
		static ITrackingHandler()
		{
			Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Services", "ITrackingHandler");
			ITrackingHandler.NativeMethodInfoPtr_DisconnectedObject_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr, 100672260);
			ITrackingHandler.NativeMethodInfoPtr_MarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr, 100672261);
			ITrackingHandler.NativeMethodInfoPtr_UnmarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr, 100672262);
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x0011DF80 File Offset: 0x0011C180
		[CallerCount(0)]
		public unsafe virtual void DisconnectedObject(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackingHandler.NativeMethodInfoPtr_DisconnectedObject_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x0011DFD0 File Offset: 0x0011C1D0
		[CallerCount(0)]
		public unsafe virtual void MarshaledObject(Object obj, ObjRef or)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackingHandler.NativeMethodInfoPtr_MarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x0011E030 File Offset: 0x0011C230
		[CallerCount(0)]
		public unsafe virtual void UnmarshaledObject(Object obj, ObjRef or)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackingHandler.NativeMethodInfoPtr_UnmarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x00016E57 File Offset: 0x00015057
		public ITrackingHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400326C RID: 12908
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectedObject_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x0400326D RID: 12909
		private static readonly IntPtr NativeMethodInfoPtr_MarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0;

		// Token: 0x0400326E RID: 12910
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0;
	}
}
