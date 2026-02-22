using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Remoting.Activation;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003B9 RID: 953
	public class IContextAttribute : Il2CppObjectBase
	{
		// Token: 0x06003DD6 RID: 15830 RVA: 0x00121ADC File Offset: 0x0011FCDC
		// Note: this type is marked as 'beforefieldinit'.
		static IContextAttribute()
		{
			Il2CppClassPointerStore<IContextAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContextAttribute");
			IContextAttribute.NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Abstract_Virtual_New_Void_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextAttribute>.NativeClassPtr, 100672396);
			IContextAttribute.NativeMethodInfoPtr_IsContextOK_Public_Abstract_Virtual_New_Boolean_Context_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextAttribute>.NativeClassPtr, 100672397);
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x00121B2C File Offset: 0x0011FD2C
		[CallerCount(0)]
		public unsafe virtual void GetPropertiesForNewContext(IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextAttribute.NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Abstract_Virtual_New_Void_IConstructionCallMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00121B7C File Offset: 0x0011FD7C
		[CallerCount(0)]
		public unsafe virtual bool IsContextOK(Context ctx, IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextAttribute.NativeMethodInfoPtr_IsContextOK_Public_Abstract_Virtual_New_Boolean_Context_IConstructionCallMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00017444 File Offset: 0x00015644
		public IContextAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400331F RID: 13087
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Abstract_Virtual_New_Void_IConstructionCallMessage_0;

		// Token: 0x04003320 RID: 13088
		private static readonly IntPtr NativeMethodInfoPtr_IsContextOK_Public_Abstract_Virtual_New_Boolean_Context_IConstructionCallMessage_0;
	}
}
