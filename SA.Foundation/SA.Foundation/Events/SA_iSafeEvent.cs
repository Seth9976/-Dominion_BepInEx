using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace SA.Foundation.Events
{
	// Token: 0x02000034 RID: 52
	public class SA_iSafeEvent<T> : Il2CppObjectBase
	{
		// Token: 0x0600019D RID: 413 RVA: 0x0000A0C0 File Offset: 0x000082C0
		// Note: this type is marked as 'beforefieldinit'.
		static SA_iSafeEvent()
		{
			Il2CppClassPointerStore<SA_iSafeEvent<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Events", "SA_iSafeEvent`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			SA_iSafeEvent<T>.NativeMethodInfoPtr_AddSafeListener_Public_Abstract_Virtual_New_Void_Object_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iSafeEvent<T>>.NativeClassPtr, 100663549);
			SA_iSafeEvent<T>.NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iSafeEvent<T>>.NativeClassPtr, 100663550);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000A14C File Offset: 0x0000834C
		[CallerCount(0)]
		public unsafe virtual void AddSafeListener(Object callbackTarget, Action<T> listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackTarget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iSafeEvent<T>.NativeMethodInfoPtr_AddSafeListener_Public_Abstract_Virtual_New_Void_Object_Action_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000A1AC File Offset: 0x000083AC
		[CallerCount(0)]
		public unsafe virtual void RemoveListener(Action<T> listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iSafeEvent<T>.NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002619 File Offset: 0x00000819
		public SA_iSafeEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_AddSafeListener_Public_Abstract_Virtual_New_Void_Object_Action_1_T_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_1_T_0;
	}
}
