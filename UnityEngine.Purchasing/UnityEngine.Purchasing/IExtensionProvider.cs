using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000006 RID: 6
	public class IExtensionProvider : Il2CppObjectBase
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002143 File Offset: 0x00000343
		// Note: this type is marked as 'beforefieldinit'.
		static IExtensionProvider()
		{
			Il2CppClassPointerStore<IExtensionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "IExtensionProvider");
			IExtensionProvider.NativeMethodInfoPtr_GetExtension_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExtensionProvider>.NativeClassPtr, 100663312);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000032F4 File Offset: 0x000014F4
		[CallerCount(0)]
		public unsafe virtual T GetExtension<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExtensionProvider.MethodInfoStoreGeneric_GetExtension_Public_Abstract_Virtual_New_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002172 File Offset: 0x00000372
		public IExtensionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_GetExtension_Public_Abstract_Virtual_New_T_0;

		// Token: 0x02000029 RID: 41
		private sealed class MethodInfoStoreGeneric_GetExtension_Public_Abstract_Virtual_New_T_0<T>
		{
			// Token: 0x04000106 RID: 262
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IExtensionProvider.NativeMethodInfoPtr_GetExtension_Public_Abstract_Virtual_New_T_0, Il2CppClassPointerStore<IExtensionProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
