using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace SA.Foundation.Events
{
	// Token: 0x02000032 RID: 50
	public class SA_iEvent<T, T1> : Il2CppObjectBase
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00009F98 File Offset: 0x00008198
		// Note: this type is marked as 'beforefieldinit'.
		static SA_iEvent()
		{
			Il2CppClassPointerStore<SA_iEvent<T, T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Events", "SA_iEvent`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			})).TypeHandle.value);
			SA_iEvent<T, T1>.NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_2_T_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iEvent<T, T1>>.NativeClassPtr, 100663547);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000A020 File Offset: 0x00008220
		[CallerCount(0)]
		public unsafe virtual void AddListener(Action<T, T1> listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iEvent<T, T1>.NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_2_T_T1_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000025D8 File Offset: 0x000007D8
		public SA_iEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_2_T_T1_0;
	}
}
