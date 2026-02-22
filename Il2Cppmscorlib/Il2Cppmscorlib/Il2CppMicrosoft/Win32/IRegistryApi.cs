using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x0200003E RID: 62
	public class IRegistryApi : Il2CppObjectBase
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x00032420 File Offset: 0x00030620
		// Note: this type is marked as 'beforefieldinit'.
		static IRegistryApi()
		{
			Il2CppClassPointerStore<IRegistryApi>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "IRegistryApi");
			IRegistryApi.NativeMethodInfoPtr_OpenSubKey_Public_Abstract_Virtual_New_RegistryKey_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistryApi>.NativeClassPtr, 100663888);
			IRegistryApi.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistryApi>.NativeClassPtr, 100663889);
			IRegistryApi.NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistryApi>.NativeClassPtr, 100663890);
			IRegistryApi.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_RegistryKey_String_Object_RegistryValueOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistryApi>.NativeClassPtr, 100663891);
			IRegistryApi.NativeMethodInfoPtr_GetSubKeyNames_Public_Abstract_Virtual_New_Il2CppStringArray_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistryApi>.NativeClassPtr, 100663892);
			IRegistryApi.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistryApi>.NativeClassPtr, 100663893);
			IRegistryApi.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_IntPtr_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistryApi>.NativeClassPtr, 100663894);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000324D4 File Offset: 0x000306D4
		[CallerCount(0)]
		public unsafe virtual RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writtable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writtable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistryApi.NativeMethodInfoPtr_OpenSubKey_Public_Abstract_Virtual_New_RegistryKey_RegistryKey_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00032550 File Offset: 0x00030750
		[CallerCount(0)]
		public unsafe virtual void Flush(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistryApi.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_RegistryKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000325A0 File Offset: 0x000307A0
		[CallerCount(0)]
		public unsafe virtual void Close(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistryApi.NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_RegistryKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000325F0 File Offset: 0x000307F0
		[CallerCount(0)]
		public unsafe virtual Object GetValue(RegistryKey rkey, string name, Object default_value, RegistryValueOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(default_value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistryApi.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_RegistryKey_String_Object_RegistryValueOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00032680 File Offset: 0x00030880
		[CallerCount(0)]
		public unsafe virtual Il2CppStringArray GetSubKeyNames(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistryApi.NativeMethodInfoPtr_GetSubKeyNames_Public_Abstract_Virtual_New_Il2CppStringArray_RegistryKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000326DC File Offset: 0x000308DC
		[CallerCount(0)]
		public unsafe virtual string ToString(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistryApi.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_RegistryKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00032730 File Offset: 0x00030930
		[CallerCount(0)]
		public unsafe virtual IntPtr GetHandle(RegistryKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistryApi.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_IntPtr_RegistryKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00003AD5 File Offset: 0x00001CD5
		public IRegistryApi(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubKey_Public_Abstract_Virtual_New_RegistryKey_RegistryKey_String_Boolean_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_RegistryKey_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_RegistryKey_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_RegistryKey_String_Object_RegistryValueOptions_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_GetSubKeyNames_Public_Abstract_Virtual_New_Il2CppStringArray_RegistryKey_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_RegistryKey_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_IntPtr_RegistryKey_0;
	}
}
