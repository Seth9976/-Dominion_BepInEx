using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004AE RID: 1198
	public class IReadOnlyCollection<T> : Il2CppObjectBase
	{
		// Token: 0x060046D9 RID: 18137 RVA: 0x00145D88 File Offset: 0x00143F88
		// Note: this type is marked as 'beforefieldinit'.
		static IReadOnlyCollection()
		{
			Il2CppClassPointerStore<IReadOnlyCollection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IReadOnlyCollection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IReadOnlyCollection<T>.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReadOnlyCollection<T>>.NativeClassPtr, 100673802);
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x00145E00 File Offset: 0x00144000
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReadOnlyCollection<T>.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x0001AC56 File Offset: 0x00018E56
		public IReadOnlyCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400397C RID: 14716
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
