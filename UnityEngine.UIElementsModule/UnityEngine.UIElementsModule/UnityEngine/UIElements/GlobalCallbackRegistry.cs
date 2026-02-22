using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A6 RID: 166
	public static class GlobalCallbackRegistry : Object
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x00028A34 File Offset: 0x00026C34
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalCallbackRegistry()
		{
			Il2CppClassPointerStore<GlobalCallbackRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "GlobalCallbackRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalCallbackRegistry>.NativeClassPtr);
			GlobalCallbackRegistry.NativeMethodInfoPtr_RegisterListeners_Public_Static_Void_CallbackEventHandler_Delegate_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalCallbackRegistry>.NativeClassPtr, 100664142);
			GlobalCallbackRegistry.NativeMethodInfoPtr_UnregisterListeners_Public_Static_Void_CallbackEventHandler_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalCallbackRegistry>.NativeClassPtr, 100664143);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00028A8C File Offset: 0x00026C8C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterListeners<TEventType>(CallbackEventHandler ceh, Delegate callback, TrickleDown useTrickleDown)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ceh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalCallbackRegistry.MethodInfoStoreGeneric_RegisterListeners_Public_Static_Void_CallbackEventHandler_Delegate_TrickleDown_0<TEventType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00028AE4 File Offset: 0x00026CE4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterListeners<TEventType>(CallbackEventHandler ceh, Delegate callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ceh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalCallbackRegistry.MethodInfoStoreGeneric_UnregisterListeners_Public_Static_Void_CallbackEventHandler_Delegate_0<TEventType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00005A74 File Offset: 0x00003C74
		public GlobalCallbackRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_RegisterListeners_Public_Static_Void_CallbackEventHandler_Delegate_TrickleDown_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterListeners_Public_Static_Void_CallbackEventHandler_Delegate_0;

		// Token: 0x0200021A RID: 538
		private sealed class MethodInfoStoreGeneric_RegisterListeners_Public_Static_Void_CallbackEventHandler_Delegate_TrickleDown_0<TEventType>
		{
			// Token: 0x040008CA RID: 2250
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GlobalCallbackRegistry.NativeMethodInfoPtr_RegisterListeners_Public_Static_Void_CallbackEventHandler_Delegate_TrickleDown_0, Il2CppClassPointerStore<GlobalCallbackRegistry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200021B RID: 539
		private sealed class MethodInfoStoreGeneric_UnregisterListeners_Public_Static_Void_CallbackEventHandler_Delegate_0<TEventType>
		{
			// Token: 0x040008CB RID: 2251
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GlobalCallbackRegistry.NativeMethodInfoPtr_UnregisterListeners_Public_Static_Void_CallbackEventHandler_Delegate_0, Il2CppClassPointerStore<GlobalCallbackRegistry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}
	}
}
