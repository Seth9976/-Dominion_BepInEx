using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000185 RID: 389
	public sealed class ResourceReader : Object
	{
		// Token: 0x06001AEB RID: 6891 RVA: 0x0009BBCC File Offset: 0x00099DCC
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceReader()
		{
			Il2CppClassPointerStore<ResourceReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr);
			ResourceReader.NativeFieldInfoPtr__store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_store");
			ResourceReader.NativeFieldInfoPtr__resCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_resCache");
			ResourceReader.NativeFieldInfoPtr__nameSectionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_nameSectionOffset");
			ResourceReader.NativeFieldInfoPtr__dataSectionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_dataSectionOffset");
			ResourceReader.NativeFieldInfoPtr__nameHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_nameHashes");
			ResourceReader.NativeFieldInfoPtr__nameHashesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_nameHashesPtr");
			ResourceReader.NativeFieldInfoPtr__namePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_namePositions");
			ResourceReader.NativeFieldInfoPtr__namePositionsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_namePositionsPtr");
			ResourceReader.NativeFieldInfoPtr__typeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_typeTable");
			ResourceReader.NativeFieldInfoPtr__typeNamePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_typeNamePositions");
			ResourceReader.NativeFieldInfoPtr__objFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_objFormatter");
			ResourceReader.NativeFieldInfoPtr__numResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_numResources");
			ResourceReader.NativeFieldInfoPtr__ums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_ums");
			ResourceReader.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "_version");
			ResourceReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Dictionary_2_String_ResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667832);
			ResourceReader.NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667833);
			ResourceReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667834);
			ResourceReader.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667835);
			ResourceReader.NativeMethodInfoPtr_ReadUnalignedI4_Internal_Static_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667836);
			ResourceReader.NativeMethodInfoPtr_SkipString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667837);
			ResourceReader.NativeMethodInfoPtr_GetNameHash_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667838);
			ResourceReader.NativeMethodInfoPtr_GetNamePosition_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667839);
			ResourceReader.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667840);
			ResourceReader.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667841);
			ResourceReader.NativeMethodInfoPtr_GetEnumeratorInternal_Internal_ResourceEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667842);
			ResourceReader.NativeMethodInfoPtr_FindPosForResource_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667843);
			ResourceReader.NativeMethodInfoPtr_CompareStringEqualsName_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667844);
			ResourceReader.NativeMethodInfoPtr_AllocateStringForNameIndex_Private_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667845);
			ResourceReader.NativeMethodInfoPtr_GetValueForNameIndex_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667846);
			ResourceReader.NativeMethodInfoPtr_LoadString_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667847);
			ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667848);
			ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_byref_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667849);
			ResourceReader.NativeMethodInfoPtr_LoadObjectV1_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667850);
			ResourceReader.NativeMethodInfoPtr__LoadObjectV1_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667851);
			ResourceReader.NativeMethodInfoPtr_LoadObjectV2_Internal_Object_Int32_byref_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667852);
			ResourceReader.NativeMethodInfoPtr__LoadObjectV2_Private_Object_Int32_byref_ResourceTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667853);
			ResourceReader.NativeMethodInfoPtr_DeserializeObject_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667854);
			ResourceReader.NativeMethodInfoPtr_ReadResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667855);
			ResourceReader.NativeMethodInfoPtr__ReadResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667856);
			ResourceReader.NativeMethodInfoPtr_FindType_Private_RuntimeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, 100667857);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0009BF1C File Offset: 0x0009A11C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316252, RefRangeEnd = 316254, XrefRangeStart = 316241, XrefRangeEnd = 316252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceReader(Stream stream, Dictionary<string, ResourceLocator> resCache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Dictionary_2_String_ResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0009BF7C File Offset: 0x0009A17C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316254, RefRangeEnd = 316255, XrefRangeStart = 316254, XrefRangeEnd = 316254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0009BFB0 File Offset: 0x0009A1B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316254, RefRangeEnd = 316255, XrefRangeStart = 316254, XrefRangeEnd = 316255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0009BFE4 File Offset: 0x0009A1E4
		[CallerCount(0)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0009C024 File Offset: 0x0009A224
		[CallerCount(0)]
		public unsafe static int ReadUnalignedI4(int* p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_ReadUnalignedI4_Internal_Static_Int32_ptr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0009C060 File Offset: 0x0009A260
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316264, RefRangeEnd = 316267, XrefRangeStart = 316255, XrefRangeEnd = 316264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_SkipString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0009C094 File Offset: 0x0009A294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316267, RefRangeEnd = 316269, XrefRangeStart = 316267, XrefRangeEnd = 316267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNameHash(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetNameHash_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0009C0E0 File Offset: 0x0009A2E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316270, RefRangeEnd = 316273, XrefRangeStart = 316269, XrefRangeEnd = 316270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNamePosition(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetNamePosition_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0009C12C File Offset: 0x0009A32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316273, XrefRangeEnd = 316277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0009C16C File Offset: 0x0009A36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0009C1AC File Offset: 0x0009A3AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316281, RefRangeEnd = 316282, XrefRangeStart = 316277, XrefRangeEnd = 316281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceReader.ResourceEnumerator GetEnumeratorInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetEnumeratorInternal_Internal_ResourceEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceReader.ResourceEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0009C1EC File Offset: 0x0009A3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316297, RefRangeEnd = 316298, XrefRangeStart = 316282, XrefRangeEnd = 316297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPosForResource(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_FindPosForResource_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0009C23C File Offset: 0x0009A43C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316306, RefRangeEnd = 316307, XrefRangeStart = 316298, XrefRangeEnd = 316306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareStringEqualsName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_CompareStringEqualsName_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0009C28C File Offset: 0x0009A48C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316328, RefRangeEnd = 316330, XrefRangeStart = 316307, XrefRangeEnd = 316328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AllocateStringForNameIndex(int index, out int dataOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dataOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_AllocateStringForNameIndex_Private_String_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0009C2E0 File Offset: 0x0009A4E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316338, RefRangeEnd = 316340, XrefRangeStart = 316330, XrefRangeEnd = 316338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValueForNameIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_GetValueForNameIndex_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0009C32C File Offset: 0x0009A52C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316350, RefRangeEnd = 316351, XrefRangeStart = 316340, XrefRangeEnd = 316350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LoadString(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadString_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0009C370 File Offset: 0x0009A570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316352, RefRangeEnd = 316353, XrefRangeStart = 316351, XrefRangeEnd = 316352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObject(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0009C3BC File Offset: 0x0009A5BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316357, RefRangeEnd = 316359, XrefRangeStart = 316353, XrefRangeEnd = 316357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObject(int pos, out ResourceTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_byref_ResourceTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0009C418 File Offset: 0x0009A618
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316360, RefRangeEnd = 316362, XrefRangeStart = 316359, XrefRangeEnd = 316360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObjectV1(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObjectV1_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0009C464 File Offset: 0x0009A664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316471, RefRangeEnd = 316472, XrefRangeStart = 316362, XrefRangeEnd = 316471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _LoadObjectV1(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__LoadObjectV1_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0009C4B0 File Offset: 0x0009A6B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316473, RefRangeEnd = 316476, XrefRangeStart = 316472, XrefRangeEnd = 316473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_LoadObjectV2_Internal_Object_Int32_byref_ResourceTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0009C50C File Offset: 0x0009A70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316499, RefRangeEnd = 316500, XrefRangeStart = 316476, XrefRangeEnd = 316499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object _LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__LoadObjectV2_Private_Object_Int32_byref_ResourceTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0009C568 File Offset: 0x0009A768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316507, RefRangeEnd = 316508, XrefRangeStart = 316500, XrefRangeEnd = 316507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object DeserializeObject(int typeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_DeserializeObject_Private_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0009C5B4 File Offset: 0x0009A7B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316514, RefRangeEnd = 316515, XrefRangeStart = 316508, XrefRangeEnd = 316514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_ReadResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0009C5E8 File Offset: 0x0009A7E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316548, RefRangeEnd = 316549, XrefRangeStart = 316515, XrefRangeEnd = 316548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ReadResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr__ReadResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0009C61C File Offset: 0x0009A81C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316566, RefRangeEnd = 316569, XrefRangeStart = 316549, XrefRangeEnd = 316566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType FindType(int typeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.NativeMethodInfoPtr_FindType_Private_RuntimeType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x000093F5 File Offset: 0x000075F5
		public ResourceReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0009C668 File Offset: 0x0009A868
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x000093FE File Offset: 0x000075FE
		public unsafe BinaryReader _store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0009C698 File Offset: 0x0009A898
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x0000941D File Offset: 0x0000761D
		public unsafe Dictionary<string, ResourceLocator> _resCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__resCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceLocator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__resCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x0009C6C8 File Offset: 0x0009A8C8
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x0000943C File Offset: 0x0000763C
		public unsafe long _nameSectionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameSectionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameSectionOffset)) = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x0009C6F0 File Offset: 0x0009A8F0
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x00009457 File Offset: 0x00007657
		public unsafe long _dataSectionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__dataSectionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__dataSectionOffset)) = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0009C718 File Offset: 0x0009A918
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x00009472 File Offset: 0x00007672
		public unsafe Il2CppStructArray<int> _nameHashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x0009C748 File Offset: 0x0009A948
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x00009491 File Offset: 0x00007691
		public unsafe int* _nameHashesPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashesPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__nameHashesPtr)) = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x0009C76C File Offset: 0x0009A96C
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x000094AC File Offset: 0x000076AC
		public unsafe Il2CppStructArray<int> _namePositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x0009C79C File Offset: 0x0009A99C
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x000094CB File Offset: 0x000076CB
		public unsafe int* _namePositionsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositionsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__namePositionsPtr)) = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x0009C7C0 File Offset: 0x0009A9C0
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x000094E6 File Offset: 0x000076E6
		public unsafe Il2CppReferenceArray<RuntimeType> _typeTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0009C7F0 File Offset: 0x0009A9F0
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x00009505 File Offset: 0x00007705
		public unsafe Il2CppStructArray<int> _typeNamePositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeNamePositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__typeNamePositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x0009C820 File Offset: 0x0009AA20
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x00009524 File Offset: 0x00007724
		public unsafe BinaryFormatter _objFormatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__objFormatter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryFormatter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__objFormatter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x0009C850 File Offset: 0x0009AA50
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00009543 File Offset: 0x00007743
		public unsafe int _numResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__numResources);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__numResources)) = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x0009C878 File Offset: 0x0009AA78
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0000955E File Offset: 0x0000775E
		public unsafe UnmanagedMemoryStream _ums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__ums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnmanagedMemoryStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__ums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x0009C8A8 File Offset: 0x0009AAA8
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x0000957D File Offset: 0x0000777D
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeFieldInfoPtr__store;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeFieldInfoPtr__resCache;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr__nameSectionOffset;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeFieldInfoPtr__dataSectionOffset;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeFieldInfoPtr__nameHashes;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeFieldInfoPtr__nameHashesPtr;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeFieldInfoPtr__namePositions;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeFieldInfoPtr__namePositionsPtr;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeFieldInfoPtr__typeTable;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeFieldInfoPtr__typeNamePositions;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeFieldInfoPtr__objFormatter;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeFieldInfoPtr__numResources;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeFieldInfoPtr__ums;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_Dictionary_2_String_ResourceLocator_0;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr_ReadUnalignedI4_Internal_Static_Int32_ptr_Int32_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr_SkipString_Private_Void_0;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_GetNameHash_Private_Int32_Int32_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_GetNamePosition_Private_Int32_Int32_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumeratorInternal_Internal_ResourceEnumerator_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr_FindPosForResource_Internal_Int32_String_0;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeMethodInfoPtr_CompareStringEqualsName_Private_Boolean_String_0;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr_AllocateStringForNameIndex_Private_String_Int32_byref_Int32_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_GetValueForNameIndex_Private_Object_Int32_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_LoadString_Internal_String_Int32_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_LoadObject_Internal_Object_Int32_byref_ResourceTypeCode_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_LoadObjectV1_Internal_Object_Int32_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr__LoadObjectV1_Private_Object_Int32_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_LoadObjectV2_Internal_Object_Int32_byref_ResourceTypeCode_0;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr__LoadObjectV2_Private_Object_Int32_byref_ResourceTypeCode_0;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Private_Object_Int32_0;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeMethodInfoPtr_ReadResources_Private_Void_0;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr__ReadResources_Private_Void_0;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_FindType_Private_RuntimeType_Int32_0;

		// Token: 0x020005C1 RID: 1473
		public sealed class ResourceEnumerator : Object
		{
			// Token: 0x060050F4 RID: 20724 RVA: 0x0016A7B4 File Offset: 0x001689B4
			// Note: this type is marked as 'beforefieldinit'.
			static ResourceEnumerator()
			{
				Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceReader>.NativeClassPtr, "ResourceEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr);
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_reader");
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_currentIsValid");
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_currentName");
				ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__dataPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, "_dataPosition");
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667858);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667859);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667860);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667861);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667862);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667863);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667864);
				ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr, 100667865);
			}

			// Token: 0x060050F5 RID: 20725 RVA: 0x0016A8D0 File Offset: 0x00168AD0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 316170, RefRangeEnd = 316173, XrefRangeStart = 316169, XrefRangeEnd = 316170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResourceEnumerator(ResourceReader reader)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceReader.ResourceEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ResourceReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050F6 RID: 20726 RVA: 0x0016A91C File Offset: 0x00168B1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 316173, RefRangeEnd = 316174, XrefRangeStart = 316173, XrefRangeEnd = 316173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170014B7 RID: 5303
			// (get) Token: 0x060050F7 RID: 20727 RVA: 0x0016A958 File Offset: 0x00168B58
			public unsafe Object Key
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 316197, RefRangeEnd = 316198, XrefRangeStart = 316174, XrefRangeEnd = 316197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170014B8 RID: 5304
			// (get) Token: 0x060050F8 RID: 20728 RVA: 0x0016A998 File Offset: 0x00168B98
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316198, XrefRangeEnd = 316202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170014B9 RID: 5305
			// (get) Token: 0x060050F9 RID: 20729 RVA: 0x0016A9D8 File Offset: 0x00168BD8
			public unsafe int DataPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014BA RID: 5306
			// (get) Token: 0x060050FA RID: 20730 RVA: 0x0016AA14 File Offset: 0x00168C14
			public unsafe DictionaryEntry Entry
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 316217, RefRangeEnd = 316218, XrefRangeStart = 316202, XrefRangeEnd = 316217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170014BB RID: 5307
			// (get) Token: 0x060050FB RID: 20731 RVA: 0x0016AA4C File Offset: 0x00168C4C
			public unsafe Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316218, XrefRangeEnd = 316241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050FC RID: 20732 RVA: 0x0016AA8C File Offset: 0x00168C8C
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceReader.ResourceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050FD RID: 20733 RVA: 0x0001ED1B File Offset: 0x0001CF1B
			public ResourceEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014B3 RID: 5299
			// (get) Token: 0x060050FE RID: 20734 RVA: 0x0016AAC0 File Offset: 0x00168CC0
			// (set) Token: 0x060050FF RID: 20735 RVA: 0x0001ED24 File Offset: 0x0001CF24
			public unsafe ResourceReader _reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014B4 RID: 5300
			// (get) Token: 0x06005100 RID: 20736 RVA: 0x0016AAF0 File Offset: 0x00168CF0
			// (set) Token: 0x06005101 RID: 20737 RVA: 0x0001ED43 File Offset: 0x0001CF43
			public unsafe bool _currentIsValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentIsValid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentIsValid)) = value;
				}
			}

			// Token: 0x170014B5 RID: 5301
			// (get) Token: 0x06005102 RID: 20738 RVA: 0x0016AB18 File Offset: 0x00168D18
			// (set) Token: 0x06005103 RID: 20739 RVA: 0x0001ED5E File Offset: 0x0001CF5E
			public unsafe int _currentName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentName);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__currentName)) = value;
				}
			}

			// Token: 0x170014B6 RID: 5302
			// (get) Token: 0x06005104 RID: 20740 RVA: 0x0016AB40 File Offset: 0x00168D40
			// (set) Token: 0x06005105 RID: 20741 RVA: 0x0001ED79 File Offset: 0x0001CF79
			public unsafe int _dataPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__dataPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceReader.ResourceEnumerator.NativeFieldInfoPtr__dataPosition)) = value;
				}
			}

			// Token: 0x040041B3 RID: 16819
			private static readonly IntPtr NativeFieldInfoPtr__reader;

			// Token: 0x040041B4 RID: 16820
			private static readonly IntPtr NativeFieldInfoPtr__currentIsValid;

			// Token: 0x040041B5 RID: 16821
			private static readonly IntPtr NativeFieldInfoPtr__currentName;

			// Token: 0x040041B6 RID: 16822
			private static readonly IntPtr NativeFieldInfoPtr__dataPosition;

			// Token: 0x040041B7 RID: 16823
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ResourceReader_0;

			// Token: 0x040041B8 RID: 16824
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040041B9 RID: 16825
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040041BA RID: 16826
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040041BB RID: 16827
			private static readonly IntPtr NativeMethodInfoPtr_get_DataPosition_Internal_get_Int32_0;

			// Token: 0x040041BC RID: 16828
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x040041BD RID: 16829
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040041BE RID: 16830
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}
	}
}
