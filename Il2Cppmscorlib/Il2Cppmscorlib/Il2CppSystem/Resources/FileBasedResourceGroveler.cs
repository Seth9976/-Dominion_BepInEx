using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Resources
{
	// Token: 0x0200017B RID: 379
	public class FileBasedResourceGroveler : Object
	{
		// Token: 0x06001A58 RID: 6744 RVA: 0x00099AF4 File Offset: 0x00097CF4
		// Note: this type is marked as 'beforefieldinit'.
		static FileBasedResourceGroveler()
		{
			Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "FileBasedResourceGroveler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr);
			FileBasedResourceGroveler.NativeFieldInfoPtr__mediator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, "_mediator");
			FileBasedResourceGroveler.NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100667752);
			FileBasedResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100667753);
			FileBasedResourceGroveler.NativeMethodInfoPtr_FindResourceFile_Private_String_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100667754);
			FileBasedResourceGroveler.NativeMethodInfoPtr_CreateResourceSet_Private_ResourceSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100667755);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00099B88 File Offset: 0x00097D88
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mediator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00099BD4 File Offset: 0x00097DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315390, XrefRangeEnd = 315400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localResourceSets);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00099C64 File Offset: 0x00097E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315400, XrefRangeEnd = 315407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FindResourceFile(CultureInfo culture, string fileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr_FindResourceFile_Private_String_CultureInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00099CC0 File Offset: 0x00097EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315425, RefRangeEnd = 315426, XrefRangeStart = 315407, XrefRangeEnd = 315425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet CreateResourceSet(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr_CreateResourceSet_Private_ResourceSet_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00008FA4 File Offset: 0x000071A4
		public FileBasedResourceGroveler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00099D10 File Offset: 0x00097F10
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x00008FAD File Offset: 0x000071AD
		public unsafe ResourceManager.ResourceManagerMediator _mediator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileBasedResourceGroveler.NativeFieldInfoPtr__mediator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager.ResourceManagerMediator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileBasedResourceGroveler.NativeFieldInfoPtr__mediator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeFieldInfoPtr__mediator;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeMethodInfoPtr_FindResourceFile_Private_String_CultureInfo_String_0;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeMethodInfoPtr_CreateResourceSet_Private_ResourceSet_String_0;
	}
}
