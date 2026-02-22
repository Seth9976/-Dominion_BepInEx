using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000041 RID: 65
	public sealed class RegistryKey : MarshalByRefObject
	{
		// Token: 0x06000437 RID: 1079 RVA: 0x0003295C File Offset: 0x00030B5C
		// Note: this type is marked as 'beforefieldinit'.
		static RegistryKey()
		{
			Il2CppClassPointerStore<RegistryKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "RegistryKey");
			RegistryKey.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "handle");
			RegistryKey.NativeFieldInfoPtr_safe_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "safe_handle");
			RegistryKey.NativeFieldInfoPtr_hive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "hive");
			RegistryKey.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "qname");
			RegistryKey.NativeFieldInfoPtr_isRemoteRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "isRemoteRoot");
			RegistryKey.NativeFieldInfoPtr_isWritable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "isWritable");
			RegistryKey.NativeFieldInfoPtr_RegistryApi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "RegistryApi");
			RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663897);
			RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663898);
			RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663899);
			RegistryKey.NativeMethodInfoPtr_IsEquals_Internal_Static_Boolean_RegistryKey_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663900);
			RegistryKey.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663901);
			RegistryKey.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663902);
			RegistryKey.NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663903);
			RegistryKey.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663904);
			RegistryKey.NativeMethodInfoPtr_get_Handle_Public_get_SafeRegistryHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663905);
			RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663906);
			RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663907);
			RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663908);
			RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663909);
			RegistryKey.NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663910);
			RegistryKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663911);
			RegistryKey.NativeMethodInfoPtr_get_IsRoot_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663912);
			RegistryKey.NativeMethodInfoPtr_get_Hive_Internal_get_RegistryHive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663913);
			RegistryKey.NativeMethodInfoPtr_get_InternalHandle_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663914);
			RegistryKey.NativeMethodInfoPtr_AssertKeyStillValid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663915);
			RegistryKey.NativeMethodInfoPtr_AssertKeyNameLength_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663916);
			RegistryKey.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663917);
			RegistryKey.NativeMethodInfoPtr_CreateMarkedForDeletionException_Internal_Static_IOException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663918);
			RegistryKey.NativeMethodInfoPtr_GetHiveName_Private_Static_String_RegistryHive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663919);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00032BDC File Offset: 0x00030DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264684, XrefRangeEnd = 264686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey(RegistryHive hiveId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hiveId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00032C24 File Offset: 0x00030E24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264716, RefRangeEnd = 264717, XrefRangeStart = 264686, XrefRangeEnd = 264716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hiveId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remoteRoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00032C88 File Offset: 0x00030E88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 264718, RefRangeEnd = 264722, XrefRangeStart = 264717, XrefRangeEnd = 264718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey(Object data, string keyName, bool writable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr__ctor_Internal_Void_Object_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00032CF4 File Offset: 0x00030EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264722, XrefRangeEnd = 264723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEquals(RegistryKey a, RegistryKey b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_IsEquals_Internal_Static_Boolean_RegistryKey_RegistryKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00032D48 File Offset: 0x00030F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264723, XrefRangeEnd = 264741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00032D7C File Offset: 0x00030F7C
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00032DB4 File Offset: 0x00030FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264741, XrefRangeEnd = 264749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00032DE8 File Offset: 0x00030FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264749, XrefRangeEnd = 264763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00032E1C File Offset: 0x0003101C
		public unsafe SafeRegistryHandle Handle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264774, RefRangeEnd = 264775, XrefRangeStart = 264763, XrefRangeEnd = 264774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_get_Handle_Public_get_SafeRegistryHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeRegistryHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00032E5C File Offset: 0x0003105C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264775, XrefRangeEnd = 264776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey OpenSubKey(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00032EAC File Offset: 0x000310AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 264783, RefRangeEnd = 264788, XrefRangeStart = 264776, XrefRangeEnd = 264783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey OpenSubKey(string name, bool writable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00032F0C File Offset: 0x0003110C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 264795, RefRangeEnd = 264801, XrefRangeStart = 264788, XrefRangeEnd = 264795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00032F5C File Offset: 0x0003115C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264801, XrefRangeEnd = 264808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(string name, Object defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00032FC0 File Offset: 0x000311C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264808, XrefRangeEnd = 264823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetSubKeyNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00033000 File Offset: 0x00031200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264823, XrefRangeEnd = 264853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00033038 File Offset: 0x00031238
		public unsafe bool IsRoot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254450, RefRangeEnd = 254451, XrefRangeStart = 254450, XrefRangeEnd = 254451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_get_IsRoot_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00033074 File Offset: 0x00031274
		public unsafe RegistryHive Hive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264856, RefRangeEnd = 264857, XrefRangeStart = 264853, XrefRangeEnd = 264856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_get_Hive_Internal_get_RegistryHive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x000330B0 File Offset: 0x000312B0
		public unsafe Object InternalHandle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_get_InternalHandle_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000330F0 File Offset: 0x000312F0
		[CallerCount(0)]
		public unsafe void AssertKeyStillValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_AssertKeyStillValid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00033124 File Offset: 0x00031324
		[CallerCount(0)]
		public unsafe void AssertKeyNameLength(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_AssertKeyNameLength_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00033168 File Offset: 0x00031368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264863, RefRangeEnd = 264864, XrefRangeStart = 264857, XrefRangeEnd = 264863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecodeString(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000331A4 File Offset: 0x000313A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264870, RefRangeEnd = 264872, XrefRangeStart = 264864, XrefRangeEnd = 264870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOException CreateMarkedForDeletionException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_CreateMarkedForDeletionException_Internal_Static_IOException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOException>(intPtr3) : null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000331D8 File Offset: 0x000313D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264872, XrefRangeEnd = 264880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHiveName(RegistryHive hive)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetHiveName_Private_Static_String_RegistryHive_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00003B65 File Offset: 0x00001D65
		public RegistryKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00033210 File Offset: 0x00031410
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00003B6E File Offset: 0x00001D6E
		public unsafe Object handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00033240 File Offset: 0x00031440
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00003B8D File Offset: 0x00001D8D
		public unsafe SafeRegistryHandle safe_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_safe_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeRegistryHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_safe_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00033270 File Offset: 0x00031470
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00003BAC File Offset: 0x00001DAC
		public unsafe Object hive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_hive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_hive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x000332A0 File Offset: 0x000314A0
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00003BCB File Offset: 0x00001DCB
		public unsafe string qname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_qname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_qname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000332C8 File Offset: 0x000314C8
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00003BEA File Offset: 0x00001DEA
		public unsafe bool isRemoteRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_isRemoteRoot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_isRemoteRoot)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000332F0 File Offset: 0x000314F0
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00003C05 File Offset: 0x00001E05
		public unsafe bool isWritable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_isWritable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr_isWritable)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00033318 File Offset: 0x00031518
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003C20 File Offset: 0x00001E20
		public unsafe static IRegistryApi RegistryApi
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegistryKey.NativeFieldInfoPtr_RegistryApi, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRegistryApi>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegistryKey.NativeFieldInfoPtr_RegistryApi, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_safe_handle;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_hive;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_qname;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_isRemoteRoot;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_isWritable;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_RegistryApi;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RegistryHive_IntPtr_Boolean_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_String_Boolean_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_IsEquals_Internal_Static_Boolean_RegistryKey_RegistryKey_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_SafeRegistryHandle_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_Object_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRoot_Internal_get_Boolean_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_get_Hive_Internal_get_RegistryHive_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalHandle_Internal_get_Object_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_AssertKeyStillValid_Private_Void_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_AssertKeyNameLength_Private_Void_String_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarkedForDeletionException_Internal_Static_IOException_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_GetHiveName_Private_Static_String_RegistryHive_0;
	}
}
