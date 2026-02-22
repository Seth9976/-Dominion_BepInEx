using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace SA.Foundation.Events
{
	// Token: 0x02000031 RID: 49
	public class SA_iEvent<T> : Il2CppObjectBase
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00009ED0 File Offset: 0x000080D0
		// Note: this type is marked as 'beforefieldinit'.
		static SA_iEvent()
		{
			Il2CppClassPointerStore<SA_iEvent<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Events", "SA_iEvent`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			SA_iEvent<T>.NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iEvent<T>>.NativeClassPtr, 100663546);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00009F48 File Offset: 0x00008148
		[CallerCount(0)]
		public unsafe virtual void AddListener(Action<T> listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iEvent<T>.NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000025CF File Offset: 0x000007CF
		public SA_iEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Action_1_T_0;
	}
}
