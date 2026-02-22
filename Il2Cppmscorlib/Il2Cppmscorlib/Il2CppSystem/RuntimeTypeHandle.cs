using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000131 RID: 305
	[Serializable]
	[StructLayout(2)]
	public struct RuntimeTypeHandle
	{
		// Token: 0x060015B8 RID: 5560 RVA: 0x00084A2C File Offset: 0x00082C2C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeTypeHandle()
		{
			Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RuntimeTypeHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr);
			RuntimeTypeHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, "value");
			RuntimeTypeHandle.NativeMethodInfoPtr__ctor_Internal_Void_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666982);
			RuntimeTypeHandle.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666983);
			RuntimeTypeHandle.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666984);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666985);
			RuntimeTypeHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666986);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666987);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetAttributes_Internal_Static_TypeAttributes_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666988);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetMetadataToken_Private_Static_Int32_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666989);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetToken_Internal_Static_Int32_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666990);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericTypeDefinition_impl_Private_Static_Type_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666991);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericTypeDefinition_Internal_Static_Type_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666992);
			RuntimeTypeHandle.NativeMethodInfoPtr_HasElementType_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666993);
			RuntimeTypeHandle.NativeMethodInfoPtr_HasInstantiation_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666994);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsArray_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666995);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsByRef_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666996);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666997);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsInstanceOfType_Internal_Static_Boolean_RuntimeType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666998);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsPointer_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100666999);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsPrimitive_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667000);
			RuntimeTypeHandle.NativeMethodInfoPtr_HasReferences_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667001);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667002);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsContextful_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667003);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsEquivalentTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667004);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsSzArray_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667005);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsInterface_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667006);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetArrayRank_Internal_Static_Int32_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667007);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetAssembly_Internal_Static_RuntimeAssembly_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667008);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetElementType_Internal_Static_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667009);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetModule_Internal_Static_RuntimeModule_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667010);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsGenericVariable_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667011);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetBaseType_Internal_Static_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667012);
			RuntimeTypeHandle.NativeMethodInfoPtr_CanCastTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667013);
			RuntimeTypeHandle.NativeMethodInfoPtr_type_is_assignable_from_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667014);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsGenericTypeDefinition_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667015);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericParameterInfo_Internal_Static_IntPtr_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667016);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00084D2C File Offset: 0x00082F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308012, RefRangeEnd = 308013, XrefRangeStart = 308012, XrefRangeEnd = 308012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeTypeHandle(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr__ctor_Internal_Void_RuntimeType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00084D64 File Offset: 0x00082F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308013, XrefRangeEnd = 308026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeTypeHandle(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x00084DB4 File Offset: 0x00082FB4
		public unsafe IntPtr Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00084DE4 File Offset: 0x00082FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308026, XrefRangeEnd = 308043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00084E34 File Offset: 0x00083034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308043, XrefRangeEnd = 308055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00084E78 File Offset: 0x00083078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00084EA8 File Offset: 0x000830A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeAttributes GetAttributes(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetAttributes_Internal_Static_TypeAttributes_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00084EEC File Offset: 0x000830EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMetadataToken(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetMetadataToken_Private_Static_Int32_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00084F30 File Offset: 0x00083130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetToken(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetToken_Internal_Static_Int32_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00084F74 File Offset: 0x00083174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308055, XrefRangeEnd = 308056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetGenericTypeDefinition_impl(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericTypeDefinition_impl_Private_Static_Type_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00084FB8 File Offset: 0x000831B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetGenericTypeDefinition(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericTypeDefinition_Internal_Static_Type_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00084FFC File Offset: 0x000831FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasElementType(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_HasElementType_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00085040 File Offset: 0x00083240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasInstantiation(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_HasInstantiation_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00085084 File Offset: 0x00083284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsArray(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsArray_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000850C8 File Offset: 0x000832C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsByRef(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsByRef_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0008510C File Offset: 0x0008330C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262712, XrefRangeEnd = 262714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsComObject(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00085150 File Offset: 0x00083350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInstanceOfType(RuntimeType type, Object o)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsInstanceOfType_Internal_Static_Boolean_RuntimeType_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x000851A4 File Offset: 0x000833A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPointer(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsPointer_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x000851E8 File Offset: 0x000833E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitive(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsPrimitive_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0008522C File Offset: 0x0008342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308056, XrefRangeEnd = 308057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasReferences(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_HasReferences_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00085270 File Offset: 0x00083470
		[CallerCount(0)]
		public unsafe static bool IsComObject(RuntimeType type, bool isGenericCOM)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isGenericCOM;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x000852C0 File Offset: 0x000834C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsContextful(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsContextful_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00085304 File Offset: 0x00083504
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rtType1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rtType2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsEquivalentTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00085358 File Offset: 0x00083558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSzArray(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsSzArray_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0008539C File Offset: 0x0008359C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308057, XrefRangeEnd = 308058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInterface(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsInterface_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x000853E0 File Offset: 0x000835E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308058, XrefRangeEnd = 308059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetArrayRank(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetArrayRank_Internal_Static_Int32_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00085424 File Offset: 0x00083624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290974, RefRangeEnd = 290975, XrefRangeStart = 290974, XrefRangeEnd = 290975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeAssembly GetAssembly(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetAssembly_Internal_Static_RuntimeAssembly_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
			}
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00085468 File Offset: 0x00083668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType GetElementType(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetElementType_Internal_Static_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000854AC File Offset: 0x000836AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeModule GetModule(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetModule_Internal_Static_RuntimeModule_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeModule>(intPtr3) : null;
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x000854F0 File Offset: 0x000836F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericVariable(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsGenericVariable_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00085534 File Offset: 0x00083734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308059, XrefRangeEnd = 308060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType GetBaseType(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetBaseType_Internal_Static_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00085578 File Offset: 0x00083778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308060, XrefRangeEnd = 308061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanCastTo(RuntimeType type, RuntimeType target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_CanCastTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x000855CC File Offset: 0x000837CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308061, XrefRangeEnd = 308062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool type_is_assignable_from(Type a, Type b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_type_is_assignable_from_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00085620 File Offset: 0x00083820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericTypeDefinition(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsGenericTypeDefinition_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00085664 File Offset: 0x00083864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308062, XrefRangeEnd = 308063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetGenericParameterInfo(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericParameterInfo_Internal_Static_IntPtr_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0000788D File Offset: 0x00005A8D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RuntimeType_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Internal_Static_TypeAttributes_RuntimeType_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadataToken_Private_Static_Int32_RuntimeType_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_GetToken_Internal_Static_Int32_RuntimeType_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_impl_Private_Static_Type_RuntimeType_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_Internal_Static_Type_RuntimeType_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_HasElementType_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeMethodInfoPtr_HasInstantiation_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeMethodInfoPtr_IsArray_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr_IsByRef_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr_IsInstanceOfType_Internal_Static_Boolean_RuntimeType_Object_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr_IsPointer_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitive_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr_HasReferences_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_Boolean_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_IsContextful_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_IsSzArray_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_IsInterface_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Internal_Static_Int32_RuntimeType_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_GetAssembly_Internal_Static_RuntimeAssembly_RuntimeType_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Internal_Static_RuntimeType_RuntimeType_0;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Internal_Static_RuntimeModule_RuntimeType_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericVariable_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseType_Internal_Static_RuntimeType_RuntimeType_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_type_is_assignable_from_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericTypeDefinition_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericParameterInfo_Internal_Static_IntPtr_RuntimeType_0;

		// Token: 0x0400128B RID: 4747
		[FieldOffset(0)]
		public IntPtr value;
	}
}
