using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000329 RID: 809
	public static class FormatterServices : Object
	{
		// Token: 0x06003453 RID: 13395 RVA: 0x001003C4 File Offset: 0x000FE5C4
		// Note: this type is marked as 'beforefieldinit'.
		static FormatterServices()
		{
			Il2CppClassPointerStore<FormatterServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FormatterServices");
			FormatterServices.NativeFieldInfoPtr_m_MemberInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "m_MemberInfoTable");
			FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "unsafeTypeForwardersIsEnabled");
			FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "unsafeTypeForwardersIsEnabledInitialized");
			FormatterServices.NativeFieldInfoPtr_advancedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "advancedTypes");
			FormatterServices.NativeFieldInfoPtr_s_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "s_binder");
			FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671413);
			FormatterServices.NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671414);
			FormatterServices.NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671415);
			FormatterServices.NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671416);
			FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671417);
			FormatterServices.NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671418);
			FormatterServices.NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671419);
			FormatterServices.NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671420);
			FormatterServices.NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671421);
			FormatterServices.NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671422);
			FormatterServices.NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671423);
			FormatterServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671424);
			FormatterServices.NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671425);
			FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671426);
			FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671427);
			FormatterServices.NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671428);
			FormatterServices.NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671429);
			FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671430);
			FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671431);
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x001005CC File Offset: 0x000FE7CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342491, RefRangeEnd = 342492, XrefRangeStart = 342489, XrefRangeEnd = 342491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<MemberInfo> GetSerializableMembers(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00100610 File Offset: 0x000FE810
		[CallerCount(0)]
		public unsafe static bool CheckSerializable(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00100654 File Offset: 0x000FE854
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342546, RefRangeEnd = 342548, XrefRangeStart = 342492, XrefRangeEnd = 342546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<MemberInfo> InternalGetSerializableMembers(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00100698 File Offset: 0x000FE898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342576, RefRangeEnd = 342577, XrefRangeStart = 342548, XrefRangeEnd = 342576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetParentTypes(RuntimeType parentType, out Il2CppReferenceArray<RuntimeType> parentTypes, out int parentTypeCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parentTypeCount;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parentTypes = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<RuntimeType>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x0010070C File Offset: 0x000FE90C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342625, RefRangeEnd = 342627, XrefRangeStart = 342577, XrefRangeEnd = 342625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<MemberInfo> GetSerializableMembers(Type type, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00100768 File Offset: 0x000FE968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 342655, RefRangeEnd = 342658, XrefRangeStart = 342627, XrefRangeEnd = 342655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetUninitializedObject(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x001007AC File Offset: 0x000FE9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342658, XrefRangeEnd = 342659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object nativeGetUninitializedObject(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x001007F0 File Offset: 0x000FE9F0
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetEnableUnsafeTypeForwarders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00100820 File Offset: 0x000FEA20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 342672, RefRangeEnd = 342677, XrefRangeStart = 342659, XrefRangeEnd = 342672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnsafeTypeForwardersIsEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x00100850 File Offset: 0x000FEA50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 342686, RefRangeEnd = 342689, XrefRangeStart = 342677, XrefRangeEnd = 342686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SerializationSetValue(MemberInfo fi, Object target, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x001008AC File Offset: 0x000FEAAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342695, RefRangeEnd = 342696, XrefRangeStart = 342689, XrefRangeEnd = 342695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object PopulateObjectMembers(Object obj, Il2CppReferenceArray<MemberInfo> members, Il2CppReferenceArray<Object> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x00100914 File Offset: 0x000FEB14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342710, RefRangeEnd = 342711, XrefRangeStart = 342696, XrefRangeEnd = 342710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetObjectData(Object obj, Il2CppReferenceArray<MemberInfo> members)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x0010096C File Offset: 0x000FEB6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 342712, RefRangeEnd = 342715, XrefRangeStart = 342711, XrefRangeEnd = 342712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetTypeFromAssembly(Assembly assem, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x001009C4 File Offset: 0x000FEBC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342716, RefRangeEnd = 342717, XrefRangeStart = 342715, XrefRangeEnd = 342716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadAssemblyFromString(string assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00100A08 File Offset: 0x000FEC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342721, RefRangeEnd = 342722, XrefRangeStart = 342717, XrefRangeEnd = 342721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadAssemblyFromStringNoThrow(string assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00100A4C File Offset: 0x000FEC4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342730, RefRangeEnd = 342732, XrefRangeStart = 342722, XrefRangeEnd = 342730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasTypeForwardedFrom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00100A98 File Offset: 0x000FEC98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 342740, RefRangeEnd = 342744, XrefRangeStart = 342732, XrefRangeEnd = 342740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrTypeFullName(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00100AD4 File Offset: 0x000FECD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342774, RefRangeEnd = 342775, XrefRangeStart = 342744, XrefRangeEnd = 342774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrTypeFullNameForArray(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00100B10 File Offset: 0x000FED10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342803, RefRangeEnd = 342804, XrefRangeStart = 342775, XrefRangeEnd = 342803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrTypeFullNameForNonArrayTypes(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00012A81 File Offset: 0x00010C81
		public FormatterServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06003468 RID: 13416 RVA: 0x00100B4C File Offset: 0x000FED4C
		// (set) Token: 0x06003469 RID: 13417 RVA: 0x00012A8A File Offset: 0x00010C8A
		public unsafe static ConcurrentDictionary<MemberHolder, Il2CppReferenceArray<MemberInfo>> m_MemberInfoTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_m_MemberInfoTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<MemberHolder, Il2CppReferenceArray<MemberInfo>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_m_MemberInfoTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600346A RID: 13418 RVA: 0x00100B74 File Offset: 0x000FED74
		// (set) Token: 0x0600346B RID: 13419 RVA: 0x00012A9C File Offset: 0x00010C9C
		public unsafe static bool unsafeTypeForwardersIsEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled, (void*)(&value));
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600346C RID: 13420 RVA: 0x00100B90 File Offset: 0x000FED90
		// (set) Token: 0x0600346D RID: 13421 RVA: 0x00012AAA File Offset: 0x00010CAA
		public unsafe static bool unsafeTypeForwardersIsEnabledInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized, (void*)(&value));
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x00100BAC File Offset: 0x000FEDAC
		// (set) Token: 0x0600346F RID: 13423 RVA: 0x00012AB8 File Offset: 0x00010CB8
		public unsafe static Il2CppReferenceArray<Type> advancedTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_advancedTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_advancedTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x00100BD4 File Offset: 0x000FEDD4
		// (set) Token: 0x06003471 RID: 13425 RVA: 0x00012ACA File Offset: 0x00010CCA
		public unsafe static Binder s_binder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_s_binder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Binder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_s_binder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C6A RID: 11370
		private static readonly IntPtr NativeFieldInfoPtr_m_MemberInfoTable;

		// Token: 0x04002C6B RID: 11371
		private static readonly IntPtr NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled;

		// Token: 0x04002C6C RID: 11372
		private static readonly IntPtr NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized;

		// Token: 0x04002C6D RID: 11373
		private static readonly IntPtr NativeFieldInfoPtr_advancedTypes;

		// Token: 0x04002C6E RID: 11374
		private static readonly IntPtr NativeFieldInfoPtr_s_binder;

		// Token: 0x04002C6F RID: 11375
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0;

		// Token: 0x04002C70 RID: 11376
		private static readonly IntPtr NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0;

		// Token: 0x04002C71 RID: 11377
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0;

		// Token: 0x04002C72 RID: 11378
		private static readonly IntPtr NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0;

		// Token: 0x04002C73 RID: 11379
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0;

		// Token: 0x04002C74 RID: 11380
		private static readonly IntPtr NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0;

		// Token: 0x04002C75 RID: 11381
		private static readonly IntPtr NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0;

		// Token: 0x04002C76 RID: 11382
		private static readonly IntPtr NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0;

		// Token: 0x04002C77 RID: 11383
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0;

		// Token: 0x04002C78 RID: 11384
		private static readonly IntPtr NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0;

		// Token: 0x04002C79 RID: 11385
		private static readonly IntPtr NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002C7A RID: 11386
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0;

		// Token: 0x04002C7B RID: 11387
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0;

		// Token: 0x04002C7C RID: 11388
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0;

		// Token: 0x04002C7D RID: 11389
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0;

		// Token: 0x04002C7E RID: 11390
		private static readonly IntPtr NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0;

		// Token: 0x04002C7F RID: 11391
		private static readonly IntPtr NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0;

		// Token: 0x04002C80 RID: 11392
		private static readonly IntPtr NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0;

		// Token: 0x04002C81 RID: 11393
		private static readonly IntPtr NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0;

		// Token: 0x02000626 RID: 1574
		[ObfuscatedName("System.Runtime.Serialization.FormatterServices+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06005418 RID: 21528 RVA: 0x001749B8 File Offset: 0x00172BB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr);
				FormatterServices.__c__DisplayClass9_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr, "type");
				FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr, 100671432);
				FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr, 100671433);
			}

			// Token: 0x06005419 RID: 21529 RVA: 0x00174A20 File Offset: 0x00172C20
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600541A RID: 21530 RVA: 0x00174A5C File Offset: 0x00172C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342476, XrefRangeEnd = 342489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<MemberInfo> _GetSerializableMembers_b__0(MemberHolder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
				}
			}

			// Token: 0x0600541B RID: 21531 RVA: 0x00020682 File Offset: 0x0001E882
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700158B RID: 5515
			// (get) Token: 0x0600541C RID: 21532 RVA: 0x00174AAC File Offset: 0x00172CAC
			// (set) Token: 0x0600541D RID: 21533 RVA: 0x0002068B File Offset: 0x0001E88B
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatterServices.__c__DisplayClass9_0.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatterServices.__c__DisplayClass9_0.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043CD RID: 17357
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040043CE RID: 17358
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040043CF RID: 17359
			private static readonly IntPtr NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0;
		}
	}
}
