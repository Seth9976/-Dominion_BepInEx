using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000202 RID: 514
	public class StringResultHandler : SearchResultHandler<string>
	{
		// Token: 0x060020EB RID: 8427 RVA: 0x000B6434 File Offset: 0x000B4634
		// Note: this type is marked as 'beforefieldinit'.
		static StringResultHandler()
		{
			Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "StringResultHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr);
			StringResultHandler.NativeFieldInfoPtr__includeFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr, "_includeFiles");
			StringResultHandler.NativeFieldInfoPtr__includeDirs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr, "_includeDirs");
			StringResultHandler.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr, 100668759);
			StringResultHandler.NativeMethodInfoPtr_IsResultIncluded_Internal_Virtual_Boolean_SearchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr, 100668760);
			StringResultHandler.NativeMethodInfoPtr_CreateObject_Internal_Virtual_String_SearchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr, 100668761);
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x000B64C8 File Offset: 0x000B46C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320894, RefRangeEnd = 320895, XrefRangeStart = 320891, XrefRangeEnd = 320894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringResultHandler(bool includeFiles, bool includeDirs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeFiles;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDirs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringResultHandler.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x000B6520 File Offset: 0x000B4720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320895, XrefRangeEnd = 320897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsResultIncluded(SearchResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringResultHandler.NativeMethodInfoPtr_IsResultIncluded_Internal_Virtual_Boolean_SearchResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000B6578 File Offset: 0x000B4778
		[CallerCount(0)]
		public unsafe override string CreateObject(SearchResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringResultHandler.NativeMethodInfoPtr_CreateObject_Internal_Virtual_String_SearchResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x0000B245 File Offset: 0x00009445
		public StringResultHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x000B65CC File Offset: 0x000B47CC
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x0000B24E File Offset: 0x0000944E
		public unsafe bool _includeFiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringResultHandler.NativeFieldInfoPtr__includeFiles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringResultHandler.NativeFieldInfoPtr__includeFiles)) = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x000B65F4 File Offset: 0x000B47F4
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x0000B269 File Offset: 0x00009469
		public unsafe bool _includeDirs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringResultHandler.NativeFieldInfoPtr__includeDirs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringResultHandler.NativeFieldInfoPtr__includeDirs)) = value;
			}
		}

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeFieldInfoPtr__includeFiles;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeFieldInfoPtr__includeDirs;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_0;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_IsResultIncluded_Internal_Virtual_Boolean_SearchResult_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_CreateObject_Internal_Virtual_String_SearchResult_0;
	}
}
