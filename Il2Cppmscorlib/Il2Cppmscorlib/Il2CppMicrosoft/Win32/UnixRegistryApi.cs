using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000047 RID: 71
	public class UnixRegistryApi : Object
	{
		// Token: 0x06000499 RID: 1177 RVA: 0x00034148 File Offset: 0x00032348
		// Note: this type is marked as 'beforefieldinit'.
		static UnixRegistryApi()
		{
			Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "UnixRegistryApi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr);
			UnixRegistryApi.NativeMethodInfoPtr_ToUnix_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663952);
			UnixRegistryApi.NativeMethodInfoPtr_IsWellKnownKey_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663953);
			UnixRegistryApi.NativeMethodInfoPtr_OpenSubKey_Public_Virtual_Final_New_RegistryKey_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663954);
			UnixRegistryApi.NativeMethodInfoPtr_Flush_Public_Virtual_Final_New_Void_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663955);
			UnixRegistryApi.NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663956);
			UnixRegistryApi.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Object_RegistryKey_String_Object_RegistryValueOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663957);
			UnixRegistryApi.NativeMethodInfoPtr_GetSubKeyNames_Public_Virtual_Final_New_Il2CppStringArray_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663958);
			UnixRegistryApi.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663959);
			UnixRegistryApi.NativeMethodInfoPtr_CreateSubKey_Private_RegistryKey_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663960);
			UnixRegistryApi.NativeMethodInfoPtr_CreateSubKey_Private_RegistryKey_RegistryKey_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663961);
			UnixRegistryApi.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_IntPtr_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663962);
			UnixRegistryApi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr, 100663963);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00034268 File Offset: 0x00032468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265686, XrefRangeEnd = 265690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToUnix(string keyname)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_ToUnix_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000342A4 File Offset: 0x000324A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265690, XrefRangeEnd = 265701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWellKnownKey(string parentKeyName, string keyname)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(parentKeyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_IsWellKnownKey_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000342F8 File Offset: 0x000324F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265701, XrefRangeEnd = 265726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_OpenSubKey_Public_Virtual_Final_New_RegistryKey_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00034368 File Offset: 0x00032568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265726, XrefRangeEnd = 265731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Flush(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_Flush_Public_Virtual_Final_New_Void_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000343AC File Offset: 0x000325AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265731, XrefRangeEnd = 265735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000343F0 File Offset: 0x000325F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265735, XrefRangeEnd = 265741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Object_RegistryKey_String_Object_RegistryValueOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00034474 File Offset: 0x00032674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265741, XrefRangeEnd = 265747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray GetSubKeyNames(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_GetSubKeyNames_Public_Virtual_Final_New_Il2CppStringArray_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000344C4 File Offset: 0x000326C4
		[CallerCount(0)]
		public unsafe virtual string ToString(RegistryKey rkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0003450C File Offset: 0x0003270C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265747, XrefRangeEnd = 265748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_CreateSubKey_Private_RegistryKey_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0003457C File Offset: 0x0003277C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265773, RefRangeEnd = 265775, XrefRangeStart = 265748, XrefRangeEnd = 265773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable, bool is_volatile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_volatile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_CreateSubKey_Private_RegistryKey_RegistryKey_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000345FC File Offset: 0x000327FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265775, XrefRangeEnd = 265780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IntPtr GetHandle(RegistryKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_IntPtr_RegistryKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0003464C File Offset: 0x0003284C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnixRegistryApi()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnixRegistryApi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixRegistryApi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00003D66 File Offset: 0x00001F66
		public UnixRegistryApi(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_ToUnix_Private_Static_String_String_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_IsWellKnownKey_Private_Static_Boolean_String_String_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubKey_Public_Virtual_Final_New_RegistryKey_RegistryKey_String_Boolean_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Final_New_Void_RegistryKey_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_RegistryKey_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Object_RegistryKey_String_Object_RegistryValueOptions_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_GetSubKeyNames_Public_Virtual_Final_New_Il2CppStringArray_RegistryKey_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_RegistryKey_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_CreateSubKey_Private_RegistryKey_RegistryKey_String_Boolean_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_CreateSubKey_Private_RegistryKey_RegistryKey_String_Boolean_Boolean_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_IntPtr_RegistryKey_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
