using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000183 RID: 387
	[Serializable]
	public class ResourceManager : Object
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x0009AB80 File Offset: 0x00098D80
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceManager()
		{
			Il2CppClassPointerStore<ResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr);
			ResourceManager.NativeFieldInfoPtr_BaseNameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "BaseNameField");
			ResourceManager.NativeFieldInfoPtr_ResourceSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResourceSets");
			ResourceManager.NativeFieldInfoPtr__resourceSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_resourceSets");
			ResourceManager.NativeFieldInfoPtr_moduleDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "moduleDir");
			ResourceManager.NativeFieldInfoPtr_MainAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "MainAssembly");
			ResourceManager.NativeFieldInfoPtr__locationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_locationInfo");
			ResourceManager.NativeFieldInfoPtr__userResourceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_userResourceSet");
			ResourceManager.NativeFieldInfoPtr__neutralResourcesCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_neutralResourcesCulture");
			ResourceManager.NativeFieldInfoPtr__lastUsedResourceCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_lastUsedResourceCache");
			ResourceManager.NativeFieldInfoPtr__ignoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_ignoreCase");
			ResourceManager.NativeFieldInfoPtr_UseManifest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "UseManifest");
			ResourceManager.NativeFieldInfoPtr_UseSatelliteAssem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "UseSatelliteAssem");
			ResourceManager.NativeFieldInfoPtr__fallbackLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_fallbackLoc");
			ResourceManager.NativeFieldInfoPtr__satelliteContractVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_satelliteContractVersion");
			ResourceManager.NativeFieldInfoPtr__lookedForSatelliteContractVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_lookedForSatelliteContractVersion");
			ResourceManager.NativeFieldInfoPtr__callingAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_callingAssembly");
			ResourceManager.NativeFieldInfoPtr_m_callingAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_callingAssembly");
			ResourceManager.NativeFieldInfoPtr_resourceGroveler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "resourceGroveler");
			ResourceManager.NativeFieldInfoPtr_MagicNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "MagicNumber");
			ResourceManager.NativeFieldInfoPtr_HeaderVersionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "HeaderVersionNumber");
			ResourceManager.NativeFieldInfoPtr__minResourceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "_minResourceSet");
			ResourceManager.NativeFieldInfoPtr_ResReaderTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResReaderTypeName");
			ResourceManager.NativeFieldInfoPtr_ResSetTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResSetTypeName");
			ResourceManager.NativeFieldInfoPtr_MscorlibName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "MscorlibName");
			ResourceManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "DEBUG");
			ResourceManager.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667790);
			ResourceManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667791);
			ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667792);
			ResourceManager.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667793);
			ResourceManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667794);
			ResourceManager.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667795);
			ResourceManager.NativeMethodInfoPtr_CommonAssemblyInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667796);
			ResourceManager.NativeMethodInfoPtr_get_BaseName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667797);
			ResourceManager.NativeMethodInfoPtr_get_FallbackLocation_Protected_get_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667798);
			ResourceManager.NativeMethodInfoPtr_GetResourceFileName_Protected_Virtual_New_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667799);
			ResourceManager.NativeMethodInfoPtr_GetFirstResourceSet_Internal_ResourceSet_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667800);
			ResourceManager.NativeMethodInfoPtr_GetResourceSet_Public_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667801);
			ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Protected_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667802);
			ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Private_ResourceSet_CultureInfo_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667803);
			ResourceManager.NativeMethodInfoPtr_AddResourceSet_Private_Static_Void_Dictionary_2_String_ResourceSet_String_byref_ResourceSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667804);
			ResourceManager.NativeMethodInfoPtr_GetSatelliteContractVersion_Protected_Static_Version_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667805);
			ResourceManager.NativeMethodInfoPtr_CompareNames_Internal_Static_Boolean_String_String_AssemblyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667806);
			ResourceManager.NativeMethodInfoPtr_SetAppXConfiguration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667807);
			ResourceManager.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100667808);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x0009AF20 File Offset: 0x00099120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315894, RefRangeEnd = 315895, XrefRangeStart = 315891, XrefRangeEnd = 315894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x0009AF54 File Offset: 0x00099154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315895, XrefRangeEnd = 315909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x0009AF90 File Offset: 0x00099190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315909, XrefRangeEnd = 315947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceManager(string baseName, Assembly assembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0009AFF0 File Offset: 0x000991F0
		[CallerCount(0)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0009B038 File Offset: 0x00099238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315947, XrefRangeEnd = 315974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0009B080 File Offset: 0x00099280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315974, XrefRangeEnd = 315978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0009B0C8 File Offset: 0x000992C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315978, XrefRangeEnd = 316001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommonAssemblyInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CommonAssemblyInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0009B0FC File Offset: 0x000992FC
		public unsafe virtual string BaseName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_get_BaseName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x0009B140 File Offset: 0x00099340
		public unsafe UltimateResourceFallbackLocation FallbackLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_get_FallbackLocation_Protected_get_UltimateResourceFallbackLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0009B17C File Offset: 0x0009937C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316001, XrefRangeEnd = 316017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetResourceFileName(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_GetResourceFileName_Protected_Virtual_New_String_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0009B1D0 File Offset: 0x000993D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316028, RefRangeEnd = 316029, XrefRangeStart = 316017, XrefRangeEnd = 316028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet GetFirstResourceSet(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_GetFirstResourceSet_Internal_ResourceSet_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x0009B220 File Offset: 0x00099420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316029, XrefRangeEnd = 316039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_GetResourceSet_Public_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0009B298 File Offset: 0x00099498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316039, XrefRangeEnd = 316040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Protected_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0009B310 File Offset: 0x00099510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316053, RefRangeEnd = 316054, XrefRangeStart = 316040, XrefRangeEnd = 316053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedCulture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_InternalGetResourceSet_Private_ResourceSet_CultureInfo_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0009B38C File Offset: 0x0009958C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316054, XrefRangeEnd = 316068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localResourceSets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(rs);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_AddResourceSet_Private_Static_Void_Dictionary_2_String_ResourceSet_String_byref_ResourceSet_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			rs = ((intPtr4 == 0) ? null : new ResourceSet(intPtr4));
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0009B3FC File Offset: 0x000995FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316108, RefRangeEnd = 316109, XrefRangeStart = 316068, XrefRangeEnd = 316108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Version GetSatelliteContractVersion(Assembly a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_GetSatelliteContractVersion_Protected_Static_Version_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0009B440 File Offset: 0x00099640
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 316128, RefRangeEnd = 316133, XrefRangeStart = 316109, XrefRangeEnd = 316128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(asmTypeName1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asmName2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_CompareNames_Internal_Static_Boolean_String_String_AssemblyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0009B4A8 File Offset: 0x000996A8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppXConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_SetAppXConfiguration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0009B4DC File Offset: 0x000996DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316133, XrefRangeEnd = 316164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(string name, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceManager.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0000910B File Offset: 0x0000730B
		public ResourceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x0009B544 File Offset: 0x00099744
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x00009114 File Offset: 0x00007314
		public unsafe string BaseNameField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_BaseNameField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_BaseNameField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x0009B56C File Offset: 0x0009976C
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x00009133 File Offset: 0x00007333
		public unsafe Hashtable ResourceSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_ResourceSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_ResourceSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x0009B59C File Offset: 0x0009979C
		// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x00009152 File Offset: 0x00007352
		public unsafe Dictionary<string, ResourceSet> _resourceSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__resourceSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__resourceSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x0009B5CC File Offset: 0x000997CC
		// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x00009171 File Offset: 0x00007371
		public unsafe string moduleDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_moduleDir);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_moduleDir), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0009B5F4 File Offset: 0x000997F4
		// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x00009190 File Offset: 0x00007390
		public unsafe Assembly MainAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_MainAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_MainAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x0009B624 File Offset: 0x00099824
		// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x000091AF File Offset: 0x000073AF
		public unsafe Type _locationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__locationInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__locationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x0009B654 File Offset: 0x00099854
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x000091CE File Offset: 0x000073CE
		public unsafe Type _userResourceSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__userResourceSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__userResourceSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x0009B684 File Offset: 0x00099884
		// (set) Token: 0x06001ABC RID: 6844 RVA: 0x000091ED File Offset: 0x000073ED
		public unsafe CultureInfo _neutralResourcesCulture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__neutralResourcesCulture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__neutralResourcesCulture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x0009B6B4 File Offset: 0x000998B4
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x0000920C File Offset: 0x0000740C
		public unsafe ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lastUsedResourceCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager.CultureNameResourceSetPair>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lastUsedResourceCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0009B6E4 File Offset: 0x000998E4
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x0000922B File Offset: 0x0000742B
		public unsafe bool _ignoreCase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__ignoreCase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__ignoreCase)) = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x0009B70C File Offset: 0x0009990C
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x00009246 File Offset: 0x00007446
		public unsafe bool UseManifest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseManifest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseManifest)) = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0009B734 File Offset: 0x00099934
		// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x00009261 File Offset: 0x00007461
		public unsafe bool UseSatelliteAssem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseSatelliteAssem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_UseSatelliteAssem)) = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x0009B75C File Offset: 0x0009995C
		// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x0000927C File Offset: 0x0000747C
		public unsafe UltimateResourceFallbackLocation _fallbackLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__fallbackLoc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__fallbackLoc)) = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x0009B784 File Offset: 0x00099984
		// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x00009297 File Offset: 0x00007497
		public unsafe Version _satelliteContractVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__satelliteContractVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__satelliteContractVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0009B7B4 File Offset: 0x000999B4
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x000092B6 File Offset: 0x000074B6
		public unsafe bool _lookedForSatelliteContractVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lookedForSatelliteContractVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__lookedForSatelliteContractVersion)) = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x0009B7DC File Offset: 0x000999DC
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x000092D1 File Offset: 0x000074D1
		public unsafe Assembly _callingAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__callingAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr__callingAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0009B80C File Offset: 0x00099A0C
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x000092F0 File Offset: 0x000074F0
		public unsafe RuntimeAssembly m_callingAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_callingAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_callingAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0009B83C File Offset: 0x00099A3C
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x0000930F File Offset: 0x0000750F
		public unsafe IResourceGroveler resourceGroveler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_resourceGroveler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceGroveler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_resourceGroveler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0009B86C File Offset: 0x00099A6C
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0000932E File Offset: 0x0000752E
		public unsafe static int MagicNumber
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_MagicNumber, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_MagicNumber, (void*)(&value));
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0009B888 File Offset: 0x00099A88
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x0000933C File Offset: 0x0000753C
		public unsafe static int HeaderVersionNumber
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_HeaderVersionNumber, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_HeaderVersionNumber, (void*)(&value));
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x0009B8A4 File Offset: 0x00099AA4
		// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x0000934A File Offset: 0x0000754A
		public unsafe static Type _minResourceSet
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr__minResourceSet, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr__minResourceSet, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x0009B8CC File Offset: 0x00099ACC
		// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x0000935C File Offset: 0x0000755C
		public unsafe static string ResReaderTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_ResReaderTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_ResReaderTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x0009B8EC File Offset: 0x00099AEC
		// (set) Token: 0x06001ADA RID: 6874 RVA: 0x0000936E File Offset: 0x0000756E
		public unsafe static string ResSetTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_ResSetTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_ResSetTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x0009B90C File Offset: 0x00099B0C
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x00009380 File Offset: 0x00007580
		public unsafe static string MscorlibName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_MscorlibName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_MscorlibName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x0009B92C File Offset: 0x00099B2C
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x00009392 File Offset: 0x00007592
		public unsafe static int DEBUG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManager.NativeFieldInfoPtr_DEBUG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManager.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeFieldInfoPtr_BaseNameField;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeFieldInfoPtr_ResourceSets;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeFieldInfoPtr__resourceSets;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeFieldInfoPtr_moduleDir;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeFieldInfoPtr_MainAssembly;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeFieldInfoPtr__locationInfo;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeFieldInfoPtr__userResourceSet;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeFieldInfoPtr__neutralResourcesCulture;

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeFieldInfoPtr__lastUsedResourceCache;

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeFieldInfoPtr__ignoreCase;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeFieldInfoPtr_UseManifest;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeFieldInfoPtr_UseSatelliteAssem;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeFieldInfoPtr__fallbackLoc;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeFieldInfoPtr__satelliteContractVersion;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeFieldInfoPtr__lookedForSatelliteContractVersion;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeFieldInfoPtr__callingAssembly;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeFieldInfoPtr_m_callingAssembly;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeFieldInfoPtr_resourceGroveler;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeFieldInfoPtr_MagicNumber;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeFieldInfoPtr_HeaderVersionNumber;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeFieldInfoPtr__minResourceSet;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeFieldInfoPtr_ResReaderTypeName;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeFieldInfoPtr_ResSetTypeName;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeFieldInfoPtr_MscorlibName;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr_CommonAssemblyInit_Private_Void_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseName_Public_Virtual_New_get_String_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackLocation_Protected_get_UltimateResourceFallbackLocation_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceFileName_Protected_Virtual_New_String_CultureInfo_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstResourceSet_Internal_ResourceSet_CultureInfo_0;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceSet_Public_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetResourceSet_Protected_Virtual_New_ResourceSet_CultureInfo_Boolean_Boolean_0;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetResourceSet_Private_ResourceSet_CultureInfo_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeMethodInfoPtr_AddResourceSet_Private_Static_Void_Dictionary_2_String_ResourceSet_String_byref_ResourceSet_0;

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeMethodInfoPtr_GetSatelliteContractVersion_Protected_Static_Version_Assembly_0;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeMethodInfoPtr_CompareNames_Internal_Static_Boolean_String_String_AssemblyName_0;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeMethodInfoPtr_SetAppXConfiguration_Private_Void_0;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_String_CultureInfo_0;

		// Token: 0x020005BF RID: 1471
		public class CultureNameResourceSetPair : Object
		{
			// Token: 0x060050D9 RID: 20697 RVA: 0x0016A100 File Offset: 0x00168300
			// Note: this type is marked as 'beforefieldinit'.
			static CultureNameResourceSetPair()
			{
				Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "CultureNameResourceSetPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr);
				ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr, "lastCultureName");
				ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastResourceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr, "lastResourceSet");
				ResourceManager.CultureNameResourceSetPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr, 100667810);
			}

			// Token: 0x060050DA RID: 20698 RVA: 0x0016A168 File Offset: 0x00168368
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CultureNameResourceSetPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.CultureNameResourceSetPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.CultureNameResourceSetPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050DB RID: 20699 RVA: 0x0001ECAC File Offset: 0x0001CEAC
			public CultureNameResourceSetPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014A5 RID: 5285
			// (get) Token: 0x060050DC RID: 20700 RVA: 0x0016A1A4 File Offset: 0x001683A4
			// (set) Token: 0x060050DD RID: 20701 RVA: 0x0001ECB5 File Offset: 0x0001CEB5
			public unsafe string lastCultureName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastCultureName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014A6 RID: 5286
			// (get) Token: 0x060050DE RID: 20702 RVA: 0x0016A1CC File Offset: 0x001683CC
			// (set) Token: 0x060050DF RID: 20703 RVA: 0x0001ECD4 File Offset: 0x0001CED4
			public unsafe ResourceSet lastResourceSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastResourceSet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.CultureNameResourceSetPair.NativeFieldInfoPtr_lastResourceSet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400419F RID: 16799
			private static readonly IntPtr NativeFieldInfoPtr_lastCultureName;

			// Token: 0x040041A0 RID: 16800
			private static readonly IntPtr NativeFieldInfoPtr_lastResourceSet;

			// Token: 0x040041A1 RID: 16801
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005C0 RID: 1472
		public class ResourceManagerMediator : Object
		{
			// Token: 0x060050E0 RID: 20704 RVA: 0x0016A1FC File Offset: 0x001683FC
			// Note: this type is marked as 'beforefieldinit'.
			static ResourceManagerMediator()
			{
				Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "ResourceManagerMediator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr);
				ResourceManager.ResourceManagerMediator.NativeFieldInfoPtr__rm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, "_rm");
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667811);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_ModuleDir_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667812);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LocationInfo_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667813);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_UserResourceSet_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667814);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseNameField_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667815);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_NeutralResourcesCulture_Internal_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667816);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_GetResourceFileName_Internal_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667817);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LookedForSatelliteContractVersion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667818);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_LookedForSatelliteContractVersion_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667819);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_SatelliteContractVersion_Internal_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667820);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_SatelliteContractVersion_Internal_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667821);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_ObtainSatelliteContractVersion_Internal_Version_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667822);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_FallbackLoc_Internal_get_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667823);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_CallingAssembly_Internal_get_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667824);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_MainAssembly_Internal_get_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667825);
				ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr, 100667826);
			}

			// Token: 0x060050E1 RID: 20705 RVA: 0x0016A37C File Offset: 0x0016857C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 315827, RefRangeEnd = 315831, XrefRangeStart = 315826, XrefRangeEnd = 315827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResourceManagerMediator(ResourceManager rm)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager.ResourceManagerMediator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170014A8 RID: 5288
			// (get) Token: 0x060050E2 RID: 20706 RVA: 0x0016A3C8 File Offset: 0x001685C8
			public unsafe string ModuleDir
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 47133, RefRangeEnd = 47137, XrefRangeStart = 47133, XrefRangeEnd = 47137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_ModuleDir_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170014A9 RID: 5289
			// (get) Token: 0x060050E3 RID: 20707 RVA: 0x0016A400 File Offset: 0x00168600
			public unsafe Type LocationInfo
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 315831, RefRangeEnd = 315838, XrefRangeStart = 315831, XrefRangeEnd = 315831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LocationInfo_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x170014AA RID: 5290
			// (get) Token: 0x060050E4 RID: 20708 RVA: 0x0016A440 File Offset: 0x00168640
			public unsafe Type UserResourceSet
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 315838, RefRangeEnd = 315843, XrefRangeStart = 315838, XrefRangeEnd = 315838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_UserResourceSet_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x170014AB RID: 5291
			// (get) Token: 0x060050E5 RID: 20709 RVA: 0x0016A480 File Offset: 0x00168680
			public unsafe string BaseNameField
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseNameField_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170014AC RID: 5292
			// (get) Token: 0x060050E6 RID: 20710 RVA: 0x0016A4B8 File Offset: 0x001686B8
			public unsafe CultureInfo NeutralResourcesCulture
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 315843, RefRangeEnd = 315849, XrefRangeStart = 315843, XrefRangeEnd = 315843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_NeutralResourcesCulture_Internal_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
				}
			}

			// Token: 0x060050E7 RID: 20711 RVA: 0x0016A4F8 File Offset: 0x001686F8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 315850, RefRangeEnd = 315852, XrefRangeStart = 315849, XrefRangeEnd = 315850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetResourceFileName(CultureInfo culture)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_GetResourceFileName_Internal_String_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170014AD RID: 5293
			// (get) Token: 0x060050E8 RID: 20712 RVA: 0x0016A540 File Offset: 0x00168740
			// (set) Token: 0x060050E9 RID: 20713 RVA: 0x0016A57C File Offset: 0x0016877C
			public unsafe bool LookedForSatelliteContractVersion
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 315852, RefRangeEnd = 315853, XrefRangeStart = 315852, XrefRangeEnd = 315852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_LookedForSatelliteContractVersion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 315853, RefRangeEnd = 315854, XrefRangeStart = 315853, XrefRangeEnd = 315853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_LookedForSatelliteContractVersion_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170014AE RID: 5294
			// (get) Token: 0x060050EA RID: 20714 RVA: 0x0016A5BC File Offset: 0x001687BC
			// (set) Token: 0x060050EB RID: 20715 RVA: 0x0016A5FC File Offset: 0x001687FC
			public unsafe Version SatelliteContractVersion
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 315854, RefRangeEnd = 315857, XrefRangeStart = 315854, XrefRangeEnd = 315854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_SatelliteContractVersion_Internal_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 315857, RefRangeEnd = 315858, XrefRangeStart = 315857, XrefRangeEnd = 315857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_set_SatelliteContractVersion_Internal_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060050EC RID: 20716 RVA: 0x0016A640 File Offset: 0x00168840
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315862, RefRangeEnd = 315863, XrefRangeStart = 315858, XrefRangeEnd = 315862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Version ObtainSatelliteContractVersion(Assembly a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_ObtainSatelliteContractVersion_Internal_Version_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
				}
			}

			// Token: 0x170014AF RID: 5295
			// (get) Token: 0x060050ED RID: 20717 RVA: 0x0016A690 File Offset: 0x00168890
			public unsafe UltimateResourceFallbackLocation FallbackLoc
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 315863, RefRangeEnd = 315869, XrefRangeStart = 315863, XrefRangeEnd = 315863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_FallbackLoc_Internal_get_UltimateResourceFallbackLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014B0 RID: 5296
			// (get) Token: 0x060050EE RID: 20718 RVA: 0x0016A6CC File Offset: 0x001688CC
			public unsafe RuntimeAssembly CallingAssembly
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 315869, RefRangeEnd = 315872, XrefRangeStart = 315869, XrefRangeEnd = 315869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_CallingAssembly_Internal_get_RuntimeAssembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
				}
			}

			// Token: 0x170014B1 RID: 5297
			// (get) Token: 0x060050EF RID: 20719 RVA: 0x0016A70C File Offset: 0x0016890C
			public unsafe RuntimeAssembly MainAssembly
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 315874, RefRangeEnd = 315889, XrefRangeStart = 315872, XrefRangeEnd = 315874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_MainAssembly_Internal_get_RuntimeAssembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
				}
			}

			// Token: 0x170014B2 RID: 5298
			// (get) Token: 0x060050F0 RID: 20720 RVA: 0x0016A74C File Offset: 0x0016894C
			public unsafe string BaseName
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 315890, RefRangeEnd = 315891, XrefRangeStart = 315889, XrefRangeEnd = 315890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.ResourceManagerMediator.NativeMethodInfoPtr_get_BaseName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060050F1 RID: 20721 RVA: 0x0001ECF3 File Offset: 0x0001CEF3
			public ResourceManagerMediator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014A7 RID: 5287
			// (get) Token: 0x060050F2 RID: 20722 RVA: 0x0016A784 File Offset: 0x00168984
			// (set) Token: 0x060050F3 RID: 20723 RVA: 0x0001ECFC File Offset: 0x0001CEFC
			public unsafe ResourceManager _rm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.ResourceManagerMediator.NativeFieldInfoPtr__rm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.ResourceManagerMediator.NativeFieldInfoPtr__rm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041A2 RID: 16802
			private static readonly IntPtr NativeFieldInfoPtr__rm;

			// Token: 0x040041A3 RID: 16803
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ResourceManager_0;

			// Token: 0x040041A4 RID: 16804
			private static readonly IntPtr NativeMethodInfoPtr_get_ModuleDir_Internal_get_String_0;

			// Token: 0x040041A5 RID: 16805
			private static readonly IntPtr NativeMethodInfoPtr_get_LocationInfo_Internal_get_Type_0;

			// Token: 0x040041A6 RID: 16806
			private static readonly IntPtr NativeMethodInfoPtr_get_UserResourceSet_Internal_get_Type_0;

			// Token: 0x040041A7 RID: 16807
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseNameField_Internal_get_String_0;

			// Token: 0x040041A8 RID: 16808
			private static readonly IntPtr NativeMethodInfoPtr_get_NeutralResourcesCulture_Internal_get_CultureInfo_0;

			// Token: 0x040041A9 RID: 16809
			private static readonly IntPtr NativeMethodInfoPtr_GetResourceFileName_Internal_String_CultureInfo_0;

			// Token: 0x040041AA RID: 16810
			private static readonly IntPtr NativeMethodInfoPtr_get_LookedForSatelliteContractVersion_Internal_get_Boolean_0;

			// Token: 0x040041AB RID: 16811
			private static readonly IntPtr NativeMethodInfoPtr_set_LookedForSatelliteContractVersion_Internal_set_Void_Boolean_0;

			// Token: 0x040041AC RID: 16812
			private static readonly IntPtr NativeMethodInfoPtr_get_SatelliteContractVersion_Internal_get_Version_0;

			// Token: 0x040041AD RID: 16813
			private static readonly IntPtr NativeMethodInfoPtr_set_SatelliteContractVersion_Internal_set_Void_Version_0;

			// Token: 0x040041AE RID: 16814
			private static readonly IntPtr NativeMethodInfoPtr_ObtainSatelliteContractVersion_Internal_Version_Assembly_0;

			// Token: 0x040041AF RID: 16815
			private static readonly IntPtr NativeMethodInfoPtr_get_FallbackLoc_Internal_get_UltimateResourceFallbackLocation_0;

			// Token: 0x040041B0 RID: 16816
			private static readonly IntPtr NativeMethodInfoPtr_get_CallingAssembly_Internal_get_RuntimeAssembly_0;

			// Token: 0x040041B1 RID: 16817
			private static readonly IntPtr NativeMethodInfoPtr_get_MainAssembly_Internal_get_RuntimeAssembly_0;

			// Token: 0x040041B2 RID: 16818
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseName_Internal_get_String_0;
		}
	}
}
