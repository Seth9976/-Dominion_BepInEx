using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Foundation.Events;

namespace SA.Foundation.Patterns
{
	// Token: 0x02000022 RID: 34
	public class SA_iClosedList<T> : Il2CppObjectBase
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00007D40 File Offset: 0x00005F40
		// Note: this type is marked as 'beforefieldinit'.
		static SA_iClosedList()
		{
			Il2CppClassPointerStore<SA_iClosedList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Patterns", "SA_iClosedList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			SA_iClosedList<T>.NativeMethodInfoPtr_get_OnItemAdded_Public_Abstract_Virtual_New_get_SA_iEvent_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iClosedList<T>>.NativeClassPtr, 100663471);
			SA_iClosedList<T>.NativeMethodInfoPtr_get_OnItemRemoved_Public_Abstract_Virtual_New_get_SA_iEvent_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iClosedList<T>>.NativeClassPtr, 100663472);
			SA_iClosedList<T>.NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_iClosedList<T>>.NativeClassPtr, 100663473);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00007DE0 File Offset: 0x00005FE0
		public unsafe virtual SA_iEvent<T> OnItemAdded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iClosedList<T>.NativeMethodInfoPtr_get_OnItemAdded_Public_Abstract_Virtual_New_get_SA_iEvent_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iEvent<T>>(intPtr3) : null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00007E2C File Offset: 0x0000602C
		public unsafe virtual SA_iEvent<T> OnItemRemoved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iClosedList<T>.NativeMethodInfoPtr_get_OnItemRemoved_Public_Abstract_Virtual_New_get_SA_iEvent_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iEvent<T>>(intPtr3) : null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00007E78 File Offset: 0x00006078
		public unsafe virtual IEnumerable<T> Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_iClosedList<T>.NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_IEnumerable_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000023E0 File Offset: 0x000005E0
		public SA_iClosedList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_get_OnItemAdded_Public_Abstract_Virtual_New_get_SA_iEvent_1_T_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_get_OnItemRemoved_Public_Abstract_Virtual_New_get_SA_iEvent_1_T_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_IEnumerable_1_T_0;
	}
}
