using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001CD RID: 461
	[Serializable]
	public class MonoAssembly : RuntimeAssembly
	{
		// Token: 0x06001DB0 RID: 7600 RVA: 0x000A6EE0 File Offset: 0x000A50E0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoAssembly()
		{
			Il2CppClassPointerStore<MonoAssembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoAssembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoAssembly>.NativeClassPtr);
			MonoAssembly.NativeMethodInfoPtr_GetType_Public_Virtual_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoAssembly>.NativeClassPtr, 100668214);
			MonoAssembly.NativeMethodInfoPtr_GetModule_Public_Virtual_Module_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoAssembly>.NativeClassPtr, 100668215);
			MonoAssembly.NativeMethodInfoPtr_GetModules_Public_Virtual_Il2CppReferenceArray_1_Module_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoAssembly>.NativeClassPtr, 100668216);
			MonoAssembly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoAssembly>.NativeClassPtr, 100668217);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000A6F60 File Offset: 0x000A5160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318413, XrefRangeEnd = 318414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoAssembly.NativeMethodInfoPtr_GetType_Public_Virtual_Type_String_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x000A6FD8 File Offset: 0x000A51D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318414, XrefRangeEnd = 318416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Module GetModule(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoAssembly.NativeMethodInfoPtr_GetModule_Public_Virtual_Module_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x000A7034 File Offset: 0x000A5234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318416, XrefRangeEnd = 318429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Module> GetModules(bool getResourceModules)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref getResourceModules;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoAssembly.NativeMethodInfoPtr_GetModules_Public_Virtual_Il2CppReferenceArray_1_Module_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Module>>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x000A708C File Offset: 0x000A528C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318429, XrefRangeEnd = 318430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoAssembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoAssembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoAssembly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x0000A3EF File Offset: 0x000085EF
		public MonoAssembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Virtual_Type_String_Boolean_Boolean_0;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Public_Virtual_Module_String_0;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeMethodInfoPtr_GetModules_Public_Virtual_Il2CppReferenceArray_1_Module_Boolean_0;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
