using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000022 RID: 34
	public class IPurchasingBinder : Il2CppObjectBase
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00007518 File Offset: 0x00005718
		// Note: this type is marked as 'beforefieldinit'.
		static IPurchasingBinder()
		{
			Il2CppClassPointerStore<IPurchasingBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing.Extension", "IPurchasingBinder");
			IPurchasingBinder.NativeMethodInfoPtr_RegisterStore_Public_Abstract_Virtual_New_Void_String_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPurchasingBinder>.NativeClassPtr, 100663458);
			IPurchasingBinder.NativeMethodInfoPtr_RegisterExtension_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPurchasingBinder>.NativeClassPtr, 100663459);
			IPurchasingBinder.NativeMethodInfoPtr_RegisterConfiguration_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPurchasingBinder>.NativeClassPtr, 100663460);
			IPurchasingBinder.NativeMethodInfoPtr_SetCatalogProviderFunction_Public_Abstract_Virtual_New_Void_Action_1_Action_1_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPurchasingBinder>.NativeClassPtr, 100663461);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007590 File Offset: 0x00005790
		[CallerCount(0)]
		public unsafe virtual void RegisterStore(string name, IStore store)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(store);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPurchasingBinder.NativeMethodInfoPtr_RegisterStore_Public_Abstract_Virtual_New_Void_String_IStore_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000075F0 File Offset: 0x000057F0
		[CallerCount(0)]
		public unsafe virtual void RegisterExtension<T>(T instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instance;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPurchasingBinder.MethodInfoStoreGeneric_RegisterExtension_Public_Abstract_Virtual_New_Void_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00007674 File Offset: 0x00005874
		[CallerCount(0)]
		public unsafe virtual void RegisterConfiguration<T>(T instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instance;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPurchasingBinder.MethodInfoStoreGeneric_RegisterConfiguration_Public_Abstract_Virtual_New_Void_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000076F8 File Offset: 0x000058F8
		[CallerCount(0)]
		public unsafe virtual void SetCatalogProviderFunction(Action<Action<HashSet<ProductDefinition>>> func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPurchasingBinder.NativeMethodInfoPtr_SetCatalogProviderFunction_Public_Abstract_Virtual_New_Void_Action_1_Action_1_HashSet_1_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002893 File Offset: 0x00000A93
		public IPurchasingBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_RegisterStore_Public_Abstract_Virtual_New_Void_String_IStore_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_RegisterExtension_Public_Abstract_Virtual_New_Void_T_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConfiguration_Public_Abstract_Virtual_New_Void_T_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_SetCatalogProviderFunction_Public_Abstract_Virtual_New_Void_Action_1_Action_1_HashSet_1_ProductDefinition_0;

		// Token: 0x02000034 RID: 52
		private sealed class MethodInfoStoreGeneric_RegisterExtension_Public_Abstract_Virtual_New_Void_T_0<T>
		{
			// Token: 0x04000121 RID: 289
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IPurchasingBinder.NativeMethodInfoPtr_RegisterExtension_Public_Abstract_Virtual_New_Void_T_0, Il2CppClassPointerStore<IPurchasingBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000035 RID: 53
		private sealed class MethodInfoStoreGeneric_RegisterConfiguration_Public_Abstract_Virtual_New_Void_T_0<T>
		{
			// Token: 0x04000122 RID: 290
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IPurchasingBinder.NativeMethodInfoPtr_RegisterConfiguration_Public_Abstract_Virtual_New_Void_T_0, Il2CppClassPointerStore<IPurchasingBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
