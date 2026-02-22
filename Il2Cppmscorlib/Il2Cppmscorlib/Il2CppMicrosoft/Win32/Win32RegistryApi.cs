using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000048 RID: 72
	public class Win32RegistryApi : Object
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x00034688 File Offset: 0x00032888
		// Note: this type is marked as 'beforefieldinit'.
		static Win32RegistryApi()
		{
			Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "Win32RegistryApi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr);
			Win32RegistryApi.NativeFieldInfoPtr_NativeBytesPerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, "NativeBytesPerCharacter");
			Win32RegistryApi.NativeMethodInfoPtr_RegCloseKey_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663964);
			Win32RegistryApi.NativeMethodInfoPtr_RegFlushKey_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663965);
			Win32RegistryApi.NativeMethodInfoPtr_RegOpenKeyEx_Private_Static_Int32_IntPtr_String_IntPtr_Int32_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663966);
			Win32RegistryApi.NativeMethodInfoPtr_RegEnumKeyEx_Internal_Static_Int32_IntPtr_Int32_ptr_Char_byref_Int32_Il2CppStructArray_1_Int32_StringBuilder_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663967);
			Win32RegistryApi.NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663968);
			Win32RegistryApi.NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663969);
			Win32RegistryApi.NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663970);
			Win32RegistryApi.NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_byref_Int64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663971);
			Win32RegistryApi.NativeMethodInfoPtr_RegQueryInfoKey_Internal_Static_Int32_IntPtr_StringBuilder_Il2CppStructArray_1_Int32_IntPtr_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663972);
			Win32RegistryApi.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_IntPtr_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663973);
			Win32RegistryApi.NativeMethodInfoPtr_IsHandleValid_Private_Static_Boolean_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663974);
			Win32RegistryApi.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Object_RegistryKey_String_Object_RegistryValueOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663975);
			Win32RegistryApi.NativeMethodInfoPtr_GetBinaryValue_Private_Int32_RegistryKey_String_RegistryValueKind_byref_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663976);
			Win32RegistryApi.NativeMethodInfoPtr_SubKeyCount_Public_Virtual_Final_New_Int32_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663977);
			Win32RegistryApi.NativeMethodInfoPtr_OpenSubKey_Public_Virtual_Final_New_RegistryKey_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663978);
			Win32RegistryApi.NativeMethodInfoPtr_Flush_Public_Virtual_Final_New_Void_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663979);
			Win32RegistryApi.NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663980);
			Win32RegistryApi.NativeMethodInfoPtr_GetSubKeyNames_Public_Virtual_Final_New_Il2CppStringArray_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663981);
			Win32RegistryApi.NativeMethodInfoPtr_GenerateException_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663982);
			Win32RegistryApi.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663983);
			Win32RegistryApi.NativeMethodInfoPtr_CombineName_Internal_Static_String_RegistryKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663984);
			Win32RegistryApi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr, 100663985);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00034884 File Offset: 0x00032A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265780, XrefRangeEnd = 265782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegCloseKey(IntPtr keyHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_RegCloseKey_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000348C4 File Offset: 0x00032AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265782, XrefRangeEnd = 265784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegFlushKey(IntPtr keyHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_RegFlushKey_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00034904 File Offset: 0x00032B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265784, XrefRangeEnd = 265786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegOpenKeyEx(IntPtr keyBase, string keyName, IntPtr reserved, int access, out IntPtr keyHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyBase;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &keyHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_RegOpenKeyEx_Private_Static_Int32_IntPtr_String_IntPtr_Int32_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00034980 File Offset: 0x00032B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265786, XrefRangeEnd = 265790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegEnumKeyEx(IntPtr keyHandle, int dwIndex, char* lpName, ref int lpcbName, Il2CppStructArray<int> lpReserved, [Out] StringBuilder lpClass, Il2CppStructArray<int> lpcbClass, Il2CppStructArray<long> lpftLastWriteTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = lpName;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpcbName;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpReserved);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbClass);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpftLastWriteTime);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_RegEnumKeyEx_Internal_Static_Int32_IntPtr_Int32_ptr_Char_byref_Int32_Il2CppStructArray_1_Int32_StringBuilder_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*lpClass = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00034A44 File Offset: 0x00032C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265790, XrefRangeEnd = 265792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, IntPtr zero, ref int dataSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyBase;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &type;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zero;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_IntPtr_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00034ACC File Offset: 0x00032CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265792, XrefRangeEnd = 265798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, [Out] Il2CppStructArray<byte> data, ref int dataSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyBase;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &type;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_Il2CppStructArray_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*data = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00034B6C File Offset: 0x00032D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265798, XrefRangeEnd = 265800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref int data, ref int dataSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyBase;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &type;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00034BF8 File Offset: 0x00032DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265800, XrefRangeEnd = 265802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref long data, ref int dataSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyBase;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reserved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &type;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_byref_Int64_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00034C84 File Offset: 0x00032E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265802, XrefRangeEnd = 265806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryInfoKey(IntPtr hKey, [Out] StringBuilder lpClass, Il2CppStructArray<int> lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, Il2CppStructArray<int> lpcbMaxSubKeyLen, Il2CppStructArray<int> lpcbMaxClassLen, ref int lpcValues, Il2CppStructArray<int> lpcbMaxValueNameLen, Il2CppStructArray<int> lpcbMaxValueLen, Il2CppStructArray<int> lpcbSecurityDescriptor, Il2CppStructArray<int> lpftLastWriteTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hKey;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbClass);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lpReserved_MustBeZero;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpcSubKeys;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbMaxSubKeyLen);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbMaxClassLen);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpcValues;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbMaxValueNameLen);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbMaxValueLen);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpcbSecurityDescriptor);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lpftLastWriteTime);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_RegQueryInfoKey_Internal_Static_Int32_IntPtr_StringBuilder_Il2CppStructArray_1_Int32_IntPtr_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*lpClass = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00034D98 File Offset: 0x00032F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265806, XrefRangeEnd = 265809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IntPtr GetHandle(RegistryKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_IntPtr_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00034DE8 File Offset: 0x00032FE8
		[CallerCount(0)]
		public unsafe static bool IsHandleValid(RegistryKey key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_IsHandleValid_Private_Static_Boolean_RegistryKey_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00034E2C File Offset: 0x0003302C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265809, XrefRangeEnd = 265827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetValue(RegistryKey rkey, string name, Object defaultValue, RegistryValueOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Object_RegistryKey_String_Object_RegistryValueOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00034EB0 File Offset: 0x000330B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265840, RefRangeEnd = 265841, XrefRangeStart = 265827, XrefRangeEnd = 265840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBinaryValue(RegistryKey rkey, string name, RegistryValueKind type, out Il2CppStructArray<byte> data, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_GetBinaryValue_Private_Int32_RegistryKey_String_RegistryValueKind_byref_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00034F50 File Offset: 0x00033150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265841, XrefRangeEnd = 265849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int SubKeyCount(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_SubKeyCount_Public_Virtual_Final_New_Int32_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00034FA0 File Offset: 0x000331A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265849, XrefRangeEnd = 265864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RegistryKey OpenSubKey(RegistryKey rkey, string keyName, bool writable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_OpenSubKey_Public_Virtual_Final_New_RegistryKey_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00035010 File Offset: 0x00033210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265864, XrefRangeEnd = 265869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Flush(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_Flush_Public_Virtual_Final_New_Void_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00035054 File Offset: 0x00033254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265869, XrefRangeEnd = 265875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00035098 File Offset: 0x00033298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265875, XrefRangeEnd = 265899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray GetSubKeyNames(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_GetSubKeyNames_Public_Virtual_Final_New_Il2CppStringArray_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000350E8 File Offset: 0x000332E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265899, XrefRangeEnd = 265939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateException(int errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_GenerateException_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00035128 File Offset: 0x00033328
		[CallerCount(0)]
		public unsafe virtual string ToString(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00035170 File Offset: 0x00033370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265939, XrefRangeEnd = 265943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CombineName(RegistryKey rkey, string localName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr_CombineName_Internal_Static_String_RegistryKey_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000351C0 File Offset: 0x000333C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265948, RefRangeEnd = 265949, XrefRangeStart = 265943, XrefRangeEnd = 265948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Win32RegistryApi()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32RegistryApi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Win32RegistryApi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00003D6F File Offset: 0x00001F6F
		public Win32RegistryApi(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x000351FC File Offset: 0x000333FC
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00003D78 File Offset: 0x00001F78
		public unsafe int NativeBytesPerCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32RegistryApi.NativeFieldInfoPtr_NativeBytesPerCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32RegistryApi.NativeFieldInfoPtr_NativeBytesPerCharacter)) = value;
			}
		}

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_NativeBytesPerCharacter;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_RegCloseKey_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_RegFlushKey_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_RegOpenKeyEx_Private_Static_Int32_IntPtr_String_IntPtr_Int32_byref_IntPtr_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_RegEnumKeyEx_Internal_Static_Int32_IntPtr_Int32_ptr_Char_byref_Int32_Il2CppStructArray_1_Int32_StringBuilder_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int64_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_IntPtr_byref_Int32_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_byref_Int32_byref_Int32_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_RegQueryValueEx_Private_Static_Int32_IntPtr_String_IntPtr_byref_RegistryValueKind_byref_Int64_byref_Int32_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_RegQueryInfoKey_Internal_Static_Int32_IntPtr_StringBuilder_Il2CppStructArray_1_Int32_IntPtr_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_IntPtr_RegistryKey_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_IsHandleValid_Private_Static_Boolean_RegistryKey_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Object_RegistryKey_String_Object_RegistryValueOptions_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_GetBinaryValue_Private_Int32_RegistryKey_String_RegistryValueKind_byref_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_SubKeyCount_Public_Virtual_Final_New_Int32_RegistryKey_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubKey_Public_Virtual_Final_New_RegistryKey_RegistryKey_String_Boolean_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Final_New_Void_RegistryKey_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_RegistryKey_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_GetSubKeyNames_Public_Virtual_Final_New_Il2CppStringArray_RegistryKey_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_GenerateException_Private_Void_Int32_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_RegistryKey_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_CombineName_Internal_Static_String_RegistryKey_String_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
