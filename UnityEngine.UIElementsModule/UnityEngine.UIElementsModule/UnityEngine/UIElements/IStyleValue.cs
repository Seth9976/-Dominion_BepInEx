using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B3 RID: 179
	public class IStyleValue<T> : Il2CppObjectBase
	{
		// Token: 0x06000A08 RID: 2568 RVA: 0x0002BEBC File Offset: 0x0002A0BC
		// Note: this type is marked as 'beforefieldinit'.
		static IStyleValue()
		{
			Il2CppClassPointerStore<IStyleValue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IStyleValue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IStyleValue<T>.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStyleValue<T>>.NativeClassPtr, 100664187);
			IStyleValue<T>.NativeMethodInfoPtr_get_keyword_Public_Abstract_Virtual_New_get_StyleKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStyleValue<T>>.NativeClassPtr, 100664188);
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0002BF48 File Offset: 0x0002A148
		public unsafe virtual T value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStyleValue<T>.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0002BF8C File Offset: 0x0002A18C
		public unsafe virtual StyleKeyword keyword
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStyleValue<T>.NativeMethodInfoPtr_get_keyword_Public_Abstract_Virtual_New_get_StyleKeyword_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x000064B1 File Offset: 0x000046B1
		public IStyleValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_T_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_get_keyword_Public_Abstract_Virtual_New_get_StyleKeyword_0;
	}
}
