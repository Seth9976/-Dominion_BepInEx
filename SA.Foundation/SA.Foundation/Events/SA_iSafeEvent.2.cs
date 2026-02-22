using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace SA.Foundation.Events
{
	// Token: 0x02000035 RID: 53
	public class SA_iSafeEvent<T, T1> : Il2CppObjectBase
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x0000A1FC File Offset: 0x000083FC
		// Note: this type is marked as 'beforefieldinit'.
		static SA_iSafeEvent()
		{
			Il2CppClassPointerStore<SA_iSafeEvent<T, T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Events", "SA_iSafeEvent`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			})).TypeHandle.value);
			SA_iSafeEvent<T, T1>.NativeMethodInfoPtr_AddSafeListener_Public_Abstract_Virtual_New_Void_Object_Action_2_T_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iSafeEvent<T, T1>>.NativeClassPtr, 100663551);
			SA_iSafeEvent<T, T1>.NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_2_T_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iSafeEvent<T, T1>>.NativeClassPtr, 100663552);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000A298 File Offset: 0x00008498
		[CallerCount(0)]
		public unsafe virtual void AddSafeListener(Object callbackTarget, Action<T, T1> listner)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iSafeEvent<T, T1>.NativeMethodInfoPtr_AddSafeListener_Public_Abstract_Virtual_New_Void_Object_Action_2_T_T1_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000A2F8 File Offset: 0x000084F8
		[CallerCount(0)]
		public unsafe virtual void RemoveListener(Action<T, T1> listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iSafeEvent<T, T1>.NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_2_T_T1_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002622 File Offset: 0x00000822
		public SA_iSafeEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_AddSafeListener_Public_Abstract_Virtual_New_Void_Object_Action_2_T_T1_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Action_2_T_T1_0;
	}
}
