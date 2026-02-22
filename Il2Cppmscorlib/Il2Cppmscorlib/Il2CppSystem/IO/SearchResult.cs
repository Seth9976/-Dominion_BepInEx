using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;

namespace Il2CppSystem.IO
{
	// Token: 0x02000203 RID: 515
	public sealed class SearchResult : Object
	{
		// Token: 0x060020F4 RID: 8436 RVA: 0x000B661C File Offset: 0x000B481C
		// Note: this type is marked as 'beforefieldinit'.
		static SearchResult()
		{
			Il2CppClassPointerStore<SearchResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "SearchResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchResult>.NativeClassPtr);
			SearchResult.NativeFieldInfoPtr_fullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, "fullPath");
			SearchResult.NativeFieldInfoPtr_userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, "userPath");
			SearchResult.NativeFieldInfoPtr_findData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, "findData");
			SearchResult.NativeMethodInfoPtr__ctor_Internal_Void_String_String_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, 100668762);
			SearchResult.NativeMethodInfoPtr_get_UserPath_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, 100668763);
			SearchResult.NativeMethodInfoPtr_get_FindData_Internal_get_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, 100668764);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000B66C4 File Offset: 0x000B48C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150611, RefRangeEnd = 150613, XrefRangeStart = 150611, XrefRangeEnd = 150613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SearchResult(string fullPath, string userPath, Win32Native.WIN32_FIND_DATA findData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(findData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchResult.NativeMethodInfoPtr__ctor_Internal_Void_String_String_WIN32_FIND_DATA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x000B6734 File Offset: 0x000B4934
		public unsafe string UserPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchResult.NativeMethodInfoPtr_get_UserPath_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x000B676C File Offset: 0x000B496C
		public unsafe Win32Native.WIN32_FIND_DATA FindData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchResult.NativeMethodInfoPtr_get_FindData_Internal_get_WIN32_FIND_DATA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Win32Native.WIN32_FIND_DATA>(intPtr3) : null;
			}
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x0000B284 File Offset: 0x00009484
		public SearchResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x000B67AC File Offset: 0x000B49AC
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x0000B28D File Offset: 0x0000948D
		public unsafe string fullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_fullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_fullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x000B67D4 File Offset: 0x000B49D4
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x0000B2AC File Offset: 0x000094AC
		public unsafe string userPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_userPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_userPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x000B67FC File Offset: 0x000B49FC
		// (set) Token: 0x060020FE RID: 8446 RVA: 0x0000B2CB File Offset: 0x000094CB
		public unsafe Win32Native.WIN32_FIND_DATA findData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_findData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Win32Native.WIN32_FIND_DATA>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_findData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeFieldInfoPtr_fullPath;

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeFieldInfoPtr_userPath;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeFieldInfoPtr_findData;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_WIN32_FIND_DATA_0;

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeMethodInfoPtr_get_UserPath_Internal_get_String_0;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeMethodInfoPtr_get_FindData_Internal_get_WIN32_FIND_DATA_0;
	}
}
