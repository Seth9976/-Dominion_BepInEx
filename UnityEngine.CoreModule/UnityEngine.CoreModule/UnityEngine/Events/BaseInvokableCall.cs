using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020000FB RID: 251
	public class BaseInvokableCall : Object
	{
		// Token: 0x06001558 RID: 5464 RVA: 0x00050F70 File Offset: 0x0004F170
		// Note: this type is marked as 'beforefieldinit'.
		static BaseInvokableCall()
		{
			Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "BaseInvokableCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr);
			BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100664857);
			BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100664858);
			BaseInvokableCall.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100664859);
			BaseInvokableCall.NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100664860);
			BaseInvokableCall.NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100664861);
			BaseInvokableCall.NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100664862);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00051018 File Offset: 0x0004F218
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInvokableCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00051054 File Offset: 0x0004F254
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 79956, RefRangeEnd = 79976, XrefRangeStart = 79953, XrefRangeEnd = 79956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInvokableCall(Object target, MethodInfo function)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000510B4 File Offset: 0x0004F2B4
		[CallerCount(0)]
		public unsafe virtual void Invoke(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInvokableCall.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00051104 File Offset: 0x0004F304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79976, XrefRangeEnd = 79978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOnInvalidArg<T>(Object arg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.MethodInfoStoreGeneric_ThrowOnInvalidArg_Protected_Static_Void_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0005113C File Offset: 0x0004F33C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 79991, RefRangeEnd = 80000, XrefRangeStart = 79978, XrefRangeEnd = 79991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllowInvoke(Delegate @delegate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@delegate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00051180 File Offset: 0x0004F380
		[CallerCount(0)]
		public unsafe virtual bool Find(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInvokableCall.NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0000C424 File Offset: 0x0000A624
		public BaseInvokableCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0;

		// Token: 0x020008C5 RID: 2245
		private sealed class MethodInfoStoreGeneric_ThrowOnInvalidArg_Protected_Static_Void_Object_0<T>
		{
			// Token: 0x04001CFB RID: 7419
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseInvokableCall.NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0, Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
