using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Resources
{
	// Token: 0x0200017E RID: 382
	public class ManifestBasedResourceGroveler : Object
	{
		// Token: 0x06001A67 RID: 6759 RVA: 0x00099EB0 File Offset: 0x000980B0
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestBasedResourceGroveler()
		{
			Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ManifestBasedResourceGroveler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr);
			ManifestBasedResourceGroveler.NativeFieldInfoPtr__mediator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, "_mediator");
			ManifestBasedResourceGroveler.NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667759);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667760);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_UltimateFallbackFixup_Private_CultureInfo_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667761);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetNeutralResourcesLanguage_Internal_Static_CultureInfo_Assembly_byref_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667762);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_CreateResourceSet_Internal_ResourceSet_Stream_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667763);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetManifestResourceStream_Private_Stream_RuntimeAssembly_String_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667764);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_CaseInsensitiveManifestResourceStreamLookup_Private_Stream_RuntimeAssembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667765);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetSatelliteAssembly_Private_RuntimeAssembly_CultureInfo_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667766);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_CanUseDefaultResourceClasses_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667767);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetSatelliteAssemblyName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667768);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_HandleSatelliteMissing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667769);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_HandleResourceStreamMissing_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667770);
			ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetNeutralResourcesLanguageAttribute_Private_Static_Boolean_Assembly_byref_String_byref_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr, 100667771);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00099FF8 File Offset: 0x000981F8
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManifestBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestBasedResourceGroveler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mediator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0009A044 File Offset: 0x00098244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315426, XrefRangeEnd = 315465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0009A0D4 File Offset: 0x000982D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315465, XrefRangeEnd = 315476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookForCulture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_UltimateFallbackFixup_Private_CultureInfo_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0009A124 File Offset: 0x00098324
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315498, RefRangeEnd = 315501, XrefRangeStart = 315476, XrefRangeEnd = 315498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fallbackLocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetNeutralResourcesLanguage_Internal_Static_CultureInfo_Assembly_byref_UltimateResourceFallbackLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0009A178 File Offset: 0x00098378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315555, RefRangeEnd = 315556, XrefRangeStart = 315501, XrefRangeEnd = 315555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet CreateResourceSet(Stream store, Assembly assembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_CreateResourceSet_Internal_ResourceSet_Stream_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0009A1DC File Offset: 0x000983DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315556, XrefRangeEnd = 315565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(satellite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetManifestResourceStream_Private_Stream_RuntimeAssembly_String_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0009A24C File Offset: 0x0009844C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315594, RefRangeEnd = 315596, XrefRangeStart = 315565, XrefRangeEnd = 315594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(satellite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_CaseInsensitiveManifestResourceStreamLookup_Private_Stream_RuntimeAssembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0009A2B0 File Offset: 0x000984B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315610, RefRangeEnd = 315611, XrefRangeStart = 315596, XrefRangeEnd = 315610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookForCulture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetSatelliteAssembly_Private_RuntimeAssembly_CultureInfo_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0009A310 File Offset: 0x00098510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315611, XrefRangeEnd = 315632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(readerTypeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(resSetTypeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_CanUseDefaultResourceClasses_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0009A370 File Offset: 0x00098570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315632, XrefRangeEnd = 315638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSatelliteAssemblyName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetSatelliteAssemblyName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0009A3A8 File Offset: 0x000985A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315638, XrefRangeEnd = 315720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSatelliteMissing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_HandleSatelliteMissing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0009A3DC File Offset: 0x000985DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315720, XrefRangeEnd = 315791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleResourceStreamMissing(string fileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_HandleResourceStreamMissing_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0009A420 File Offset: 0x00098620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315791, XrefRangeEnd = 315794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fallbackLocation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ManifestBasedResourceGroveler.NativeMethodInfoPtr_GetNeutralResourcesLanguageAttribute_Private_Static_Boolean_Assembly_byref_String_byref_Int16_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			cultureName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0000900D File Offset: 0x0000720D
		public ManifestBasedResourceGroveler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0009A490 File Offset: 0x00098690
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x00009016 File Offset: 0x00007216
		public unsafe ResourceManager.ResourceManagerMediator _mediator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBasedResourceGroveler.NativeFieldInfoPtr__mediator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager.ResourceManagerMediator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBasedResourceGroveler.NativeFieldInfoPtr__mediator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeFieldInfoPtr__mediator;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr_UltimateFallbackFixup_Private_CultureInfo_CultureInfo_0;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr_GetNeutralResourcesLanguage_Internal_Static_CultureInfo_Assembly_byref_UltimateResourceFallbackLocation_0;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeMethodInfoPtr_CreateResourceSet_Internal_ResourceSet_Stream_Assembly_0;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr_GetManifestResourceStream_Private_Stream_RuntimeAssembly_String_byref_StackCrawlMark_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_CaseInsensitiveManifestResourceStreamLookup_Private_Stream_RuntimeAssembly_String_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_GetSatelliteAssembly_Private_RuntimeAssembly_CultureInfo_byref_StackCrawlMark_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_CanUseDefaultResourceClasses_Private_Boolean_String_String_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_GetSatelliteAssemblyName_Private_String_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_HandleSatelliteMissing_Private_Void_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_HandleResourceStreamMissing_Private_Void_String_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr_GetNeutralResourcesLanguageAttribute_Private_Static_Boolean_Assembly_byref_String_byref_Int16_0;
	}
}
