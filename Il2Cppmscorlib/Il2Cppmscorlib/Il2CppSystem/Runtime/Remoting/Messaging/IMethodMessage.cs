using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003FA RID: 1018
	public class IMethodMessage : Il2CppObjectBase
	{
		// Token: 0x06004018 RID: 16408 RVA: 0x0012964C File Offset: 0x0012784C
		// Note: this type is marked as 'beforefieldinit'.
		static IMethodMessage()
		{
			Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IMethodMessage");
			IMethodMessage.NativeMethodInfoPtr_get_ArgCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100672652);
			IMethodMessage.NativeMethodInfoPtr_get_Args_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100672653);
			IMethodMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Abstract_Virtual_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100672654);
			IMethodMessage.NativeMethodInfoPtr_get_MethodBase_Public_Abstract_Virtual_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100672655);
			IMethodMessage.NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100672656);
			IMethodMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100672657);
			IMethodMessage.NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100672658);
			IMethodMessage.NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100672659);
			IMethodMessage.NativeMethodInfoPtr_GetArg_Public_Abstract_Virtual_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100672660);
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06004019 RID: 16409 RVA: 0x00129728 File Offset: 0x00127928
		public unsafe virtual int ArgCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_ArgCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x0600401A RID: 16410 RVA: 0x00129770 File Offset: 0x00127970
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_Args_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x0600401B RID: 16411 RVA: 0x001297BC File Offset: 0x001279BC
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Abstract_Virtual_New_get_LogicalCallContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x00129808 File Offset: 0x00127A08
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_MethodBase_Public_Abstract_Virtual_New_get_MethodBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x0600401D RID: 16413 RVA: 0x00129854 File Offset: 0x00127A54
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x0600401E RID: 16414 RVA: 0x00129898 File Offset: 0x00127A98
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x0600401F RID: 16415 RVA: 0x001298E4 File Offset: 0x00127AE4
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06004020 RID: 16416 RVA: 0x00129928 File Offset: 0x00127B28
		public unsafe virtual string Uri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x0012996C File Offset: 0x00127B6C
		[CallerCount(0)]
		public unsafe virtual Object GetArg(int argNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_GetArg_Public_Abstract_Virtual_New_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x000184BC File Offset: 0x000166BC
		public IMethodMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400347C RID: 13436
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400347D RID: 13437
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400347E RID: 13438
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Abstract_Virtual_New_get_LogicalCallContext_0;

		// Token: 0x0400347F RID: 13439
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Abstract_Virtual_New_get_MethodBase_0;

		// Token: 0x04003480 RID: 13440
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04003481 RID: 13441
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04003482 RID: 13442
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04003483 RID: 13443
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04003484 RID: 13444
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Abstract_Virtual_New_Object_Int32_0;
	}
}
