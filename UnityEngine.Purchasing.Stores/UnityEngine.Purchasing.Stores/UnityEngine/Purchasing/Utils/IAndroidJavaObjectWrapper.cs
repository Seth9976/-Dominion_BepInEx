using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing.Utils
{
	// Token: 0x02000095 RID: 149
	public class IAndroidJavaObjectWrapper : Il2CppObjectBase
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x00004DC5 File Offset: 0x00002FC5
		// Note: this type is marked as 'beforefieldinit'.
		static IAndroidJavaObjectWrapper()
		{
			Il2CppClassPointerStore<IAndroidJavaObjectWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Utils", "IAndroidJavaObjectWrapper");
			IAndroidJavaObjectWrapper.NativeMethodInfoPtr_Call_Public_Abstract_Virtual_New_ReturnType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAndroidJavaObjectWrapper>.NativeClassPtr, 100663993);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00018C90 File Offset: 0x00016E90
		[CallerCount(0)]
		public unsafe virtual ReturnType Call<ReturnType>(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAndroidJavaObjectWrapper.MethodInfoStoreGeneric_Call_Public_Abstract_Virtual_New_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00004DF4 File Offset: 0x00002FF4
		public virtual ReturnType Call<ReturnType>(string methodName, params Object[] args)
		{
			return this.Call(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00004E03 File Offset: 0x00003003
		public IAndroidJavaObjectWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_Abstract_Virtual_New_ReturnType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x020000C9 RID: 201
		private sealed class MethodInfoStoreGeneric_Call_Public_Abstract_Virtual_New_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x040004B0 RID: 1200
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IAndroidJavaObjectWrapper.NativeMethodInfoPtr_Call_Public_Abstract_Virtual_New_ReturnType_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<IAndroidJavaObjectWrapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}
	}
}
