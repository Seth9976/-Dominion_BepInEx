using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.IO
{
	// Token: 0x02000201 RID: 513
	public class SearchResultHandler<TSource> : Object
	{
		// Token: 0x060020E6 RID: 8422 RVA: 0x000B62A0 File Offset: 0x000B44A0
		// Note: this type is marked as 'beforefieldinit'.
		static SearchResultHandler()
		{
			Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "SearchResultHandler`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr);
			SearchResultHandler<TSource>.NativeMethodInfoPtr_IsResultIncluded_Internal_Abstract_Virtual_New_Boolean_SearchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr, 100668756);
			SearchResultHandler<TSource>.NativeMethodInfoPtr_CreateObject_Internal_Abstract_Virtual_New_TSource_SearchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr, 100668757);
			SearchResultHandler<TSource>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr, 100668758);
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x000B6348 File Offset: 0x000B4548
		[CallerCount(0)]
		public unsafe virtual bool IsResultIncluded(SearchResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchResultHandler<TSource>.NativeMethodInfoPtr_IsResultIncluded_Internal_Abstract_Virtual_New_Boolean_SearchResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x000B63A0 File Offset: 0x000B45A0
		[CallerCount(0)]
		public unsafe virtual TSource CreateObject(SearchResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SearchResultHandler<TSource>.NativeMethodInfoPtr_CreateObject_Internal_Abstract_Virtual_New_TSource_SearchResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x000B63F8 File Offset: 0x000B45F8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SearchResultHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchResultHandler<TSource>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchResultHandler<TSource>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0000B23C File Offset: 0x0000943C
		public SearchResultHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeMethodInfoPtr_IsResultIncluded_Internal_Abstract_Virtual_New_Boolean_SearchResult_0;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeMethodInfoPtr_CreateObject_Internal_Abstract_Virtual_New_TSource_SearchResult_0;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
