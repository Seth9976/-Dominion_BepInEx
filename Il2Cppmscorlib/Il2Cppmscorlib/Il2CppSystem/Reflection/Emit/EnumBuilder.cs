using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x020001E7 RID: 487
	public class EnumBuilder : TypeInfo
	{
		// Token: 0x06001F4A RID: 8010 RVA: 0x000AE4C8 File Offset: 0x000AC6C8
		// Note: this type is marked as 'beforefieldinit'.
		static EnumBuilder()
		{
			Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "EnumBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr);
			EnumBuilder.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668480);
			EnumBuilder.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668481);
			EnumBuilder.NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668482);
			EnumBuilder.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668483);
			EnumBuilder.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668484);
			EnumBuilder.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668485);
			EnumBuilder.NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668486);
			EnumBuilder.NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668487);
			EnumBuilder.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668488);
			EnumBuilder.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668489);
			EnumBuilder.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668490);
			EnumBuilder.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668491);
			EnumBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668492);
			EnumBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668493);
			EnumBuilder.NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668494);
			EnumBuilder.NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668495);
			EnumBuilder.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668496);
			EnumBuilder.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668497);
			EnumBuilder.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668498);
			EnumBuilder.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668499);
			EnumBuilder.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668500);
			EnumBuilder.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668501);
			EnumBuilder.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668502);
			EnumBuilder.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668503);
			EnumBuilder.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668504);
			EnumBuilder.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668505);
			EnumBuilder.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668506);
			EnumBuilder.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668507);
			EnumBuilder.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668508);
			EnumBuilder.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668509);
			EnumBuilder.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumBuilder>.NativeClassPtr, 100668510);
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000AE764 File Offset: 0x000AC964
		public unsafe override Assembly Assembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319271, XrefRangeEnd = 319276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x000AE7B0 File Offset: 0x000AC9B0
		public unsafe override string AssemblyQualifiedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319276, XrefRangeEnd = 319281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x000AE7F4 File Offset: 0x000AC9F4
		public unsafe override Type BaseType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319281, XrefRangeEnd = 319286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x000AE840 File Offset: 0x000ACA40
		public unsafe override string FullName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319286, XrefRangeEnd = 319291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x000AE884 File Offset: 0x000ACA84
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319291, XrefRangeEnd = 319296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x000AE8D0 File Offset: 0x000ACAD0
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319296, XrefRangeEnd = 319301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x000AE914 File Offset: 0x000ACB14
		public unsafe override string Namespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319301, XrefRangeEnd = 319306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x000AE958 File Offset: 0x000ACB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319306, XrefRangeEnd = 319311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetElementType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x000AE9A4 File Offset: 0x000ACBA4
		public unsafe override Type UnderlyingSystemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319311, XrefRangeEnd = 319314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x000AE9F0 File Offset: 0x000ACBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319314, XrefRangeEnd = 319317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeAttributes GetAttributeFlagsImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x000AEA38 File Offset: 0x000ACC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319317, XrefRangeEnd = 319320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConvention;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x000AEAD8 File Offset: 0x000ACCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319320, XrefRangeEnd = 319323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ConstructorInfo> GetConstructors(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstructorInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x000AEB30 File Offset: 0x000ACD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319323, XrefRangeEnd = 319326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000AEB88 File Offset: 0x000ACD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319326, XrefRangeEnd = 319329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x000AEBF4 File Offset: 0x000ACDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319329, XrefRangeEnd = 319332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x000AEC60 File Offset: 0x000ACE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319332, XrefRangeEnd = 319335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x000AECCC File Offset: 0x000ACECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319335, XrefRangeEnd = 319338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<FieldInfo> GetFields(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x000AED24 File Offset: 0x000ACF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319338, XrefRangeEnd = 319341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetInterfaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x000AED70 File Offset: 0x000ACF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319341, XrefRangeEnd = 319344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConvention;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000AEE20 File Offset: 0x000AD020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319344, XrefRangeEnd = 319347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MethodInfo> GetMethods(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x000AEE78 File Offset: 0x000AD078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319347, XrefRangeEnd = 319350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x000AEEE4 File Offset: 0x000AD0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319350, XrefRangeEnd = 319353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<PropertyInfo> GetProperties(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000AEF3C File Offset: 0x000AD13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319353, XrefRangeEnd = 319356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319356, XrefRangeEnd = 319359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasElementTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x000AF038 File Offset: 0x000AD238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319359, XrefRangeEnd = 319362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, Object target, Il2CppReferenceArray<Object> args, Il2CppReferenceArray<ParameterModifier> modifiers, CultureInfo culture, Il2CppStringArray namedParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namedParameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x000AF114 File Offset: 0x000AD314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319362, XrefRangeEnd = 319365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x000AF15C File Offset: 0x000AD35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319365, XrefRangeEnd = 319368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x000AF1A4 File Offset: 0x000AD3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319368, XrefRangeEnd = 319371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsCOMObjectImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x000AF1EC File Offset: 0x000AD3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319371, XrefRangeEnd = 319374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefined(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x000AF254 File Offset: 0x000AD454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319374, XrefRangeEnd = 319377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000AF29C File Offset: 0x000AD49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319377, XrefRangeEnd = 319380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPrimitiveImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumBuilder.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x0000AB67 File Offset: 0x00008D67
		public EnumBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0;

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0;

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0;
	}
}
