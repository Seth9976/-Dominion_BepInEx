using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.IO
{
	// Token: 0x02000200 RID: 512
	public class FileSystemEnumerableIterator<TSource> : Iterator<TSource>
	{
		// Token: 0x060020BF RID: 8383 RVA: 0x000B59C0 File Offset: 0x000B3BC0
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEnumerableIterator()
		{
			Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileSystemEnumerableIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr);
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__resultHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "_resultHandler");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "searchStack");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "searchData");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "searchCriteria");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__hnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "_hnd");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_needsParentPathDiscoveryDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "needsParentPathDiscoveryDemand");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "empty");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "userPath");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "searchOption");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_fullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "fullPath");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_normalizedSearchPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "normalizedSearchPath");
			FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__checkHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, "_checkHost");
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668743);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_CommonInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668744);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668745);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_Clone_Protected_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668746);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668747);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668748);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_CreateSearchResult_Private_SearchResult_SearchData_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668749);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_HandleError_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668750);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_AddSearchableDirsToStack_Private_Void_SearchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668751);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_DoDemand_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668752);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_NormalizeSearchPattern_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668753);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_GetNormalizedSearchCriteria_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668754);
			FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_GetFullSearchString_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr, 100668755);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x000B5C20 File Offset: 0x000B3E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320747, RefRangeEnd = 320748, XrefRangeStart = 320721, XrefRangeEnd = 320747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemEnumerableIterator(string path, string originalUserPath, string searchPattern, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalUserPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultHandler);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x000B5CC0 File Offset: 0x000B3EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320748, XrefRangeEnd = 320769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommonInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_CommonInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x000B5CF4 File Offset: 0x000B3EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320769, XrefRangeEnd = 320777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemEnumerableIterator(string fullPath, string normalizedSearchPath, string searchCriteria, string userPath, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableIterator<TSource>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(normalizedSearchPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchCriteria);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userPath);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultHandler);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x000B5DA8 File Offset: 0x000B3FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320777, XrefRangeEnd = 320779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Iterator<TSource> Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_Clone_Protected_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Iterator<TSource>>(intPtr3) : null;
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x000B5DF4 File Offset: 0x000B3FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320779, XrefRangeEnd = 320781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x000B5E40 File Offset: 0x000B4040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320781, XrefRangeEnd = 320811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x000B5E88 File Offset: 0x000B4088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320811, XrefRangeEnd = 320820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SearchResult CreateSearchResult(Directory.SearchData localSearchData, Win32Native.WIN32_FIND_DATA findData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localSearchData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(findData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_CreateSearchResult_Private_SearchResult_SearchData_WIN32_FIND_DATA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SearchResult>(intPtr3) : null;
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x000B5EEC File Offset: 0x000B40EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320820, XrefRangeEnd = 320822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleError(int hr, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_HandleError_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x000B5F3C File Offset: 0x000B413C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320822, XrefRangeEnd = 320859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSearchableDirsToStack(Directory.SearchData localSearchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localSearchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_AddSearchableDirsToStack_Private_Void_SearchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x000B5F80 File Offset: 0x000B4180
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoDemand(string fullPathToDemand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPathToDemand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_DoDemand_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x000B5FC4 File Offset: 0x000B41C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320859, XrefRangeEnd = 320872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NormalizeSearchPattern(string searchPattern)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_NormalizeSearchPattern_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x000B6000 File Offset: 0x000B4200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320872, XrefRangeEnd = 320879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNormalizedSearchCriteria(string fullSearchString, string fullPathMod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullSearchString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullPathMod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_GetNormalizedSearchCriteria_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x000B6050 File Offset: 0x000B4250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320879, XrefRangeEnd = 320891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullSearchString(string fullPath, string searchPattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableIterator<TSource>.NativeMethodInfoPtr_GetFullSearchString_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x0000B0CF File Offset: 0x000092CF
		public FileSystemEnumerableIterator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x000B60A0 File Offset: 0x000B42A0
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x0000B0D8 File Offset: 0x000092D8
		public unsafe SearchResultHandler<TSource> _resultHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__resultHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchResultHandler<TSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__resultHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x000B60D0 File Offset: 0x000B42D0
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x0000B0F7 File Offset: 0x000092F7
		public unsafe List<Directory.SearchData> searchStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Directory.SearchData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x000B6100 File Offset: 0x000B4300
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x0000B116 File Offset: 0x00009316
		public unsafe Directory.SearchData searchData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Directory.SearchData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x000B6130 File Offset: 0x000B4330
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x0000B135 File Offset: 0x00009335
		public unsafe string searchCriteria
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchCriteria);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchCriteria), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x000B6158 File Offset: 0x000B4358
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x0000B154 File Offset: 0x00009354
		public unsafe SafeFindHandle _hnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__hnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeFindHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__hnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x000B6188 File Offset: 0x000B4388
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x0000B173 File Offset: 0x00009373
		public unsafe bool needsParentPathDiscoveryDemand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_needsParentPathDiscoveryDemand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_needsParentPathDiscoveryDemand)) = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x000B61B0 File Offset: 0x000B43B0
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x0000B18E File Offset: 0x0000938E
		public unsafe bool empty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_empty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_empty)) = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x000B61D8 File Offset: 0x000B43D8
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x0000B1A9 File Offset: 0x000093A9
		public unsafe string userPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_userPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_userPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x000B6200 File Offset: 0x000B4400
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x0000B1C8 File Offset: 0x000093C8
		public unsafe SearchOption searchOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchOption);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_searchOption)) = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x000B6228 File Offset: 0x000B4428
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x0000B1E3 File Offset: 0x000093E3
		public unsafe string fullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_fullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_fullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x000B6250 File Offset: 0x000B4450
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x0000B202 File Offset: 0x00009402
		public unsafe string normalizedSearchPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_normalizedSearchPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr_normalizedSearchPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x000B6278 File Offset: 0x000B4478
		// (set) Token: 0x060020E5 RID: 8421 RVA: 0x0000B221 File Offset: 0x00009421
		public unsafe bool _checkHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__checkHost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableIterator<TSource>.NativeFieldInfoPtr__checkHost)) = value;
			}
		}

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeFieldInfoPtr__resultHandler;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeFieldInfoPtr_searchStack;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeFieldInfoPtr_searchData;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeFieldInfoPtr_searchCriteria;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeFieldInfoPtr__hnd;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeFieldInfoPtr_needsParentPathDiscoveryDemand;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeFieldInfoPtr_empty;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeFieldInfoPtr_userPath;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeFieldInfoPtr_searchOption;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeFieldInfoPtr_fullPath;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeFieldInfoPtr_normalizedSearchPath;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeFieldInfoPtr__checkHost;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeMethodInfoPtr_CommonInit_Private_Void_0;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_String_String_String_SearchOption_SearchResultHandler_1_TSource_Boolean_0;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Protected_Virtual_Iterator_1_TSource_0;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeMethodInfoPtr_CreateSearchResult_Private_SearchResult_SearchData_WIN32_FIND_DATA_0;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeMethodInfoPtr_HandleError_Private_Void_Int32_String_0;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeMethodInfoPtr_AddSearchableDirsToStack_Private_Void_SearchData_0;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeMethodInfoPtr_DoDemand_Internal_Void_String_0;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeSearchPattern_Private_Static_String_String_0;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedSearchCriteria_Private_Static_String_String_String_0;

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeMethodInfoPtr_GetFullSearchString_Private_Static_String_String_String_0;
	}
}
