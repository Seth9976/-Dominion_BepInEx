using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D5 RID: 981
	public class IConstructionCallMessage : Il2CppObjectBase
	{
		// Token: 0x06003E87 RID: 16007 RVA: 0x00124070 File Offset: 0x00122270
		// Note: this type is marked as 'beforefieldinit'.
		static IConstructionCallMessage()
		{
			Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "IConstructionCallMessage");
			IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672478);
			IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationTypeName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672479);
			IConstructionCallMessage.NativeMethodInfoPtr_get_Activator_Public_Abstract_Virtual_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672480);
			IConstructionCallMessage.NativeMethodInfoPtr_set_Activator_Public_Abstract_Virtual_New_set_Void_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672481);
			IConstructionCallMessage.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672482);
			IConstructionCallMessage.NativeMethodInfoPtr_get_ContextProperties_Public_Abstract_Virtual_New_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100672483);
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06003E88 RID: 16008 RVA: 0x00124110 File Offset: 0x00122310
		public unsafe virtual Type ActivationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x0012415C File Offset: 0x0012235C
		public unsafe virtual string ActivationTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationTypeName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06003E8A RID: 16010 RVA: 0x001241A0 File Offset: 0x001223A0
		// (set) Token: 0x06003E8B RID: 16011 RVA: 0x001241EC File Offset: 0x001223EC
		public unsafe virtual IActivator Activator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_Activator_Public_Abstract_Virtual_New_get_IActivator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_set_Activator_Public_Abstract_Virtual_New_set_Void_IActivator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06003E8C RID: 16012 RVA: 0x0012423C File Offset: 0x0012243C
		public unsafe virtual Il2CppReferenceArray<Object> CallSiteActivationAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06003E8D RID: 16013 RVA: 0x00124288 File Offset: 0x00122488
		public unsafe virtual IList ContextProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_ContextProperties_Public_Abstract_Virtual_New_get_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x0001793F File Offset: 0x00015B3F
		public IConstructionCallMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003383 RID: 13187
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04003384 RID: 13188
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationTypeName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04003385 RID: 13189
		private static readonly IntPtr NativeMethodInfoPtr_get_Activator_Public_Abstract_Virtual_New_get_IActivator_0;

		// Token: 0x04003386 RID: 13190
		private static readonly IntPtr NativeMethodInfoPtr_set_Activator_Public_Abstract_Virtual_New_set_Void_IActivator_0;

		// Token: 0x04003387 RID: 13191
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003388 RID: 13192
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextProperties_Public_Abstract_Virtual_New_get_IList_0;
	}
}
