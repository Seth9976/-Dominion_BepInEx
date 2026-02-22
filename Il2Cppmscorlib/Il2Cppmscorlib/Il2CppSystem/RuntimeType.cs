using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x020000E0 RID: 224
	[Serializable]
	public class RuntimeType : TypeInfo
	{
		// Token: 0x06000E8A RID: 3722 RVA: 0x000640E4 File Offset: 0x000622E4
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeType()
		{
			Il2CppClassPointerStore<RuntimeType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RuntimeType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr);
			RuntimeType.NativeFieldInfoPtr_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "ValueType");
			RuntimeType.NativeFieldInfoPtr_EnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "EnumType");
			RuntimeType.NativeFieldInfoPtr_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "ObjectType");
			RuntimeType.NativeFieldInfoPtr_StringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "StringType");
			RuntimeType.NativeFieldInfoPtr_DelegateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "DelegateType");
			RuntimeType.NativeFieldInfoPtr_s_SICtorParamTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "s_SICtorParamTypes");
			RuntimeType.NativeFieldInfoPtr_MemberBindingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "MemberBindingMask");
			RuntimeType.NativeFieldInfoPtr_InvocationMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "InvocationMask");
			RuntimeType.NativeFieldInfoPtr_BinderNonCreateInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderNonCreateInstance");
			RuntimeType.NativeFieldInfoPtr_BinderGetSetProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderGetSetProperty");
			RuntimeType.NativeFieldInfoPtr_BinderSetInvokeProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderSetInvokeProperty");
			RuntimeType.NativeFieldInfoPtr_BinderGetSetField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderGetSetField");
			RuntimeType.NativeFieldInfoPtr_BinderSetInvokeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderSetInvokeField");
			RuntimeType.NativeFieldInfoPtr_BinderNonFieldGetSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderNonFieldGetSet");
			RuntimeType.NativeFieldInfoPtr_ClassicBindingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "ClassicBindingMask");
			RuntimeType.NativeFieldInfoPtr_s_typedRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "s_typedRef");
			RuntimeType.NativeFieldInfoPtr_type_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "type_info");
			RuntimeType.NativeFieldInfoPtr_GenericCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "GenericCache");
			RuntimeType.NativeFieldInfoPtr_m_serializationCtor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "m_serializationCtor");
			RuntimeType.NativeMethodInfoPtr_ThrowIfTypeNeverValidGenericArgument_Private_Static_Void_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665737);
			RuntimeType.NativeMethodInfoPtr_SanityCheckGenericArguments_Internal_Static_Void_Il2CppReferenceArray_1_RuntimeType_Il2CppReferenceArray_1_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665738);
			RuntimeType.NativeMethodInfoPtr_SplitName_Private_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665739);
			RuntimeType.NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_Boolean_byref_Boolean_byref_Boolean_byref_MemberListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665740);
			RuntimeType.NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_byref_Boolean_byref_MemberListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665741);
			RuntimeType.NativeMethodInfoPtr_FilterApplyPrefixLookup_Private_Static_Boolean_MemberInfo_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665742);
			RuntimeType.NativeMethodInfoPtr_FilterApplyBase_Private_Static_Boolean_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665743);
			RuntimeType.NativeMethodInfoPtr_FilterApplyType_Private_Static_Boolean_Type_BindingFlags_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665744);
			RuntimeType.NativeMethodInfoPtr_FilterApplyMethodInfo_Private_Static_Boolean_RuntimeMethodInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665745);
			RuntimeType.NativeMethodInfoPtr_FilterApplyConstructorInfo_Private_Static_Boolean_RuntimeConstructorInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665746);
			RuntimeType.NativeMethodInfoPtr_FilterApplyMethodBase_Private_Static_Boolean_MethodBase_BindingFlags_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665747);
			RuntimeType.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665748);
			RuntimeType.NativeMethodInfoPtr_IsSpecialSerializableType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665749);
			RuntimeType.NativeMethodInfoPtr_GetMethodCandidates_Private_ListBuilder_1_MethodInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665750);
			RuntimeType.NativeMethodInfoPtr_GetConstructorCandidates_Private_ListBuilder_1_ConstructorInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665751);
			RuntimeType.NativeMethodInfoPtr_GetPropertyCandidates_Private_ListBuilder_1_PropertyInfo_String_BindingFlags_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665752);
			RuntimeType.NativeMethodInfoPtr_GetEventCandidates_Private_ListBuilder_1_EventInfo_String_BindingFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665753);
			RuntimeType.NativeMethodInfoPtr_GetFieldCandidates_Private_ListBuilder_1_FieldInfo_String_BindingFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665754);
			RuntimeType.NativeMethodInfoPtr_GetNestedTypeCandidates_Private_ListBuilder_1_Type_String_BindingFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665755);
			RuntimeType.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665756);
			RuntimeType.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665757);
			RuntimeType.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665758);
			RuntimeType.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665759);
			RuntimeType.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665760);
			RuntimeType.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665761);
			RuntimeType.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665762);
			RuntimeType.NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665763);
			RuntimeType.NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665764);
			RuntimeType.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665765);
			RuntimeType.NativeMethodInfoPtr_GetMember_Public_Virtual_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665766);
			RuntimeType.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665767);
			RuntimeType.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665768);
			RuntimeType.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665769);
			RuntimeType.NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665770);
			RuntimeType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665771);
			RuntimeType.NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665772);
			RuntimeType.NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665773);
			RuntimeType.NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665774);
			RuntimeType.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665775);
			RuntimeType.NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665776);
			RuntimeType.NativeMethodInfoPtr_GetBaseType_Private_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665777);
			RuntimeType.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665778);
			RuntimeType.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665779);
			RuntimeType.NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665780);
			RuntimeType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665781);
			RuntimeType.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665782);
			RuntimeType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665783);
			RuntimeType.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665784);
			RuntimeType.NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665785);
			RuntimeType.NativeMethodInfoPtr_get_IsEnum_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665786);
			RuntimeType.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665787);
			RuntimeType.NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_get_GenericParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665788);
			RuntimeType.NativeMethodInfoPtr_get_IsSzArray_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665789);
			RuntimeType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665790);
			RuntimeType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665791);
			RuntimeType.NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665792);
			RuntimeType.NativeMethodInfoPtr_GetEnumNames_Public_Virtual_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665793);
			RuntimeType.NativeMethodInfoPtr_GetEnumValues_Public_Virtual_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665794);
			RuntimeType.NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665795);
			RuntimeType.NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665796);
			RuntimeType.NativeMethodInfoPtr_GetEnumName_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665797);
			RuntimeType.NativeMethodInfoPtr_GetGenericArgumentsInternal_Internal_Il2CppReferenceArray_1_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665798);
			RuntimeType.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665799);
			RuntimeType.NativeMethodInfoPtr_MakeGenericType_Public_Virtual_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665800);
			RuntimeType.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665801);
			RuntimeType.NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665802);
			RuntimeType.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665803);
			RuntimeType.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665804);
			RuntimeType.NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665805);
			RuntimeType.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665806);
			RuntimeType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665807);
			RuntimeType.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665808);
			RuntimeType.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665809);
			RuntimeType.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665810);
			RuntimeType.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665811);
			RuntimeType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665812);
			RuntimeType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665813);
			RuntimeType.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665814);
			RuntimeType.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665815);
			RuntimeType.NativeMethodInfoPtr_FormatTypeName_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665816);
			RuntimeType.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665817);
			RuntimeType.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665818);
			RuntimeType.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665819);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceCheckThis_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665820);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceImpl_Internal_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665821);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceDefaultCtor_Internal_Object_Boolean_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665822);
			RuntimeType.NativeMethodInfoPtr_GetDefaultConstructor_Internal_MonoCMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665823);
			RuntimeType.NativeMethodInfoPtr_GetDefaultMemberName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665824);
			RuntimeType.NativeMethodInfoPtr_GetSerializationCtor_Internal_RuntimeConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665825);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceSlow_Internal_Object_Boolean_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665826);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceMono_Private_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665827);
			RuntimeType.NativeMethodInfoPtr_CheckValue_Internal_Object_Object_Binder_CultureInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665828);
			RuntimeType.NativeMethodInfoPtr_TryConvertToType_Private_Object_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665829);
			RuntimeType.NativeMethodInfoPtr_IsConvertibleToPrimitiveType_Private_Static_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665830);
			RuntimeType.NativeMethodInfoPtr_GetCachedName_Private_String_TypeNameKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665831);
			RuntimeType.NativeMethodInfoPtr_make_array_type_Private_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665832);
			RuntimeType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665833);
			RuntimeType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665834);
			RuntimeType.NativeMethodInfoPtr_make_byref_type_Private_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665835);
			RuntimeType.NativeMethodInfoPtr_MakeByRefType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665836);
			RuntimeType.NativeMethodInfoPtr_MakePointerType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665837);
			RuntimeType.NativeMethodInfoPtr_MakePointerType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665838);
			RuntimeType.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665839);
			RuntimeType.NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665840);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceForAnotherGenericParameter_Internal_Static_Object_Type_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665841);
			RuntimeType.NativeMethodInfoPtr_MakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665842);
			RuntimeType.NativeMethodInfoPtr_GetMethodsByName_native_Internal_IntPtr_IntPtr_BindingFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665843);
			RuntimeType.NativeMethodInfoPtr_GetMethodsByName_Internal_Il2CppReferenceArray_1_RuntimeMethodInfo_String_BindingFlags_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665844);
			RuntimeType.NativeMethodInfoPtr_GetPropertiesByName_native_Private_IntPtr_IntPtr_BindingFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665845);
			RuntimeType.NativeMethodInfoPtr_GetConstructors_native_Private_IntPtr_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665846);
			RuntimeType.NativeMethodInfoPtr_GetConstructors_internal_Private_Il2CppReferenceArray_1_RuntimeConstructorInfo_BindingFlags_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665847);
			RuntimeType.NativeMethodInfoPtr_GetPropertiesByName_Private_Il2CppReferenceArray_1_RuntimePropertyInfo_String_BindingFlags_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665848);
			RuntimeType.NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665849);
			RuntimeType.NativeMethodInfoPtr_GetTypeCodeImplInternal_Private_Static_TypeCode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665850);
			RuntimeType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665851);
			RuntimeType.NativeMethodInfoPtr_IsGenericCOMObjectImpl_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665852);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceInternal_Private_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665853);
			RuntimeType.NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665854);
			RuntimeType.NativeMethodInfoPtr_getFullName_Internal_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665855);
			RuntimeType.NativeMethodInfoPtr_GetGenericArgumentsInternal_Private_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665856);
			RuntimeType.NativeMethodInfoPtr_GetGenericParameterAttributes_Private_GenericParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665857);
			RuntimeType.NativeMethodInfoPtr_GetGenericParameterPosition_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665858);
			RuntimeType.NativeMethodInfoPtr_GetEvents_native_Private_IntPtr_IntPtr_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665859);
			RuntimeType.NativeMethodInfoPtr_GetFields_native_Private_IntPtr_IntPtr_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665860);
			RuntimeType.NativeMethodInfoPtr_GetFields_internal_Private_Il2CppReferenceArray_1_RuntimeFieldInfo_String_BindingFlags_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665861);
			RuntimeType.NativeMethodInfoPtr_GetEvents_internal_Private_Il2CppReferenceArray_1_RuntimeEventInfo_String_BindingFlags_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665862);
			RuntimeType.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665863);
			RuntimeType.NativeMethodInfoPtr_GetNestedTypes_native_Private_IntPtr_IntPtr_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665864);
			RuntimeType.NativeMethodInfoPtr_GetNestedTypes_internal_Private_Il2CppReferenceArray_1_RuntimeType_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665865);
			RuntimeType.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665866);
			RuntimeType.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665867);
			RuntimeType.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665868);
			RuntimeType.NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665869);
			RuntimeType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665870);
			RuntimeType.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100665871);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00064D1C File Offset: 0x00062F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290523, RefRangeEnd = 290524, XrefRangeStart = 290514, XrefRangeEnd = 290523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_ThrowIfTypeNeverValidGenericArgument_Private_Static_Void_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00064D54 File Offset: 0x00062F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290524, XrefRangeEnd = 290531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SanityCheckGenericArguments(Il2CppReferenceArray<RuntimeType> genericArguments, Il2CppReferenceArray<RuntimeType> genericParamters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(genericArguments);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericParamters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_SanityCheckGenericArguments_Internal_Static_Void_Il2CppReferenceArray_1_RuntimeType_Il2CppReferenceArray_1_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00064D9C File Offset: 0x00062F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290531, XrefRangeEnd = 290538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitName(string fullname, out string name, out string ns)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullname);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_SplitName_Private_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
			ns = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00064E08 File Offset: 0x00063008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290538, XrefRangeEnd = 290540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingFlags;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &prefixLookup;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ignoreCase;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &listType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_Boolean_byref_Boolean_byref_Boolean_byref_MemberListType_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00064E94 File Offset: 0x00063094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290540, XrefRangeEnd = 290551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingFlags;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &listType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_byref_Boolean_byref_MemberListType_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00064F04 File Offset: 0x00063104
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 290552, RefRangeEnd = 290557, XrefRangeStart = 290551, XrefRangeEnd = 290552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyPrefixLookup_Private_Static_Boolean_MemberInfo_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00064F68 File Offset: 0x00063168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290559, RefRangeEnd = 290560, XrefRangeStart = 290557, XrefRangeEnd = 290559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPublic;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNonProtectedInternal;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyBase_Private_Static_Boolean_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00065004 File Offset: 0x00063204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290569, RefRangeEnd = 290571, XrefRangeStart = 290560, XrefRangeEnd = 290569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefixLookup;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyType_Private_Static_Boolean_Type_BindingFlags_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00065088 File Offset: 0x00063288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290575, RefRangeEnd = 290576, XrefRangeStart = 290571, XrefRangeEnd = 290575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Il2CppReferenceArray<Type> argumentTypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyMethodInfo_Private_Static_Boolean_RuntimeMethodInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x000650F8 File Offset: 0x000632F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290580, RefRangeEnd = 290582, XrefRangeStart = 290576, XrefRangeEnd = 290580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Il2CppReferenceArray<Type> argumentTypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyConstructorInfo_Private_Static_Boolean_RuntimeConstructorInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00065168 File Offset: 0x00063368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290593, RefRangeEnd = 290595, XrefRangeStart = 290582, XrefRangeEnd = 290593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Il2CppReferenceArray<Type> argumentTypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyMethodBase_Private_Static_Boolean_MethodBase_BindingFlags_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000651E8 File Offset: 0x000633E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290601, RefRangeEnd = 290602, XrefRangeStart = 290595, XrefRangeEnd = 290601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00065224 File Offset: 0x00063424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290602, XrefRangeEnd = 290612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSpecialSerializableType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_IsSpecialSerializableType_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00065260 File Offset: 0x00063460
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290638, RefRangeEnd = 290641, XrefRangeStart = 290612, XrefRangeEnd = 290638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Il2CppReferenceArray<Type> types, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetMethodCandidates_Private_ListBuilder_1_MethodInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<MethodInfo>(intPtr);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x000652E8 File Offset: 0x000634E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290679, RefRangeEnd = 290682, XrefRangeStart = 290641, XrefRangeEnd = 290679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Il2CppReferenceArray<Type> types, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetConstructorCandidates_Private_ListBuilder_1_ConstructorInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<ConstructorInfo>(intPtr);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00065370 File Offset: 0x00063570
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290705, RefRangeEnd = 290708, XrefRangeStart = 290682, XrefRangeEnd = 290705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Il2CppReferenceArray<Type> types, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetPropertyCandidates_Private_ListBuilder_1_PropertyInfo_String_BindingFlags_Il2CppReferenceArray_1_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<PropertyInfo>(intPtr);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000653E8 File Offset: 0x000635E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290731, RefRangeEnd = 290732, XrefRangeStart = 290708, XrefRangeEnd = 290731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetEventCandidates_Private_ListBuilder_1_EventInfo_String_BindingFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<EventInfo>(intPtr);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0006544C File Offset: 0x0006364C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290755, RefRangeEnd = 290757, XrefRangeStart = 290732, XrefRangeEnd = 290755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetFieldCandidates_Private_ListBuilder_1_FieldInfo_String_BindingFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<FieldInfo>(intPtr);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x000654B0 File Offset: 0x000636B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290789, RefRangeEnd = 290790, XrefRangeStart = 290757, XrefRangeEnd = 290789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetNestedTypeCandidates_Private_ListBuilder_1_Type_String_BindingFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<Type>(intPtr);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00065514 File Offset: 0x00063714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290790, XrefRangeEnd = 290794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MethodInfo> GetMethods(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0006556C File Offset: 0x0006376C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290794, XrefRangeEnd = 290798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ConstructorInfo> GetConstructors(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstructorInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x000655C4 File Offset: 0x000637C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290798, XrefRangeEnd = 290802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<PropertyInfo> GetProperties(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0006561C File Offset: 0x0006381C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290802, XrefRangeEnd = 290806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<FieldInfo> GetFields(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00065674 File Offset: 0x00063874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290806, XrefRangeEnd = 290832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00065724 File Offset: 0x00063924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290832, XrefRangeEnd = 290853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000657C4 File Offset: 0x000639C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290853, XrefRangeEnd = 290863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00065878 File Offset: 0x00063A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290863, XrefRangeEnd = 290879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x000658E4 File Offset: 0x00063AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290879, XrefRangeEnd = 290900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00065950 File Offset: 0x00063B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290900, XrefRangeEnd = 290928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetNestedType(string fullname, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000659BC File Offset: 0x00063BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290928, XrefRangeEnd = 290972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MemberInfo> GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetMember_Public_Virtual_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00065A34 File Offset: 0x00063C34
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290972, XrefRangeEnd = 290973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00065A80 File Offset: 0x00063C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeModule GetRuntimeModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeModule>(intPtr3) : null;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00065AC0 File Offset: 0x00063CC0
		public unsafe override Assembly Assembly
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 290974, RefRangeEnd = 290975, XrefRangeStart = 290973, XrefRangeEnd = 290974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00065B0C File Offset: 0x00063D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290974, RefRangeEnd = 290975, XrefRangeStart = 290974, XrefRangeEnd = 290975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAssembly GetRuntimeAssembly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00065B4C File Offset: 0x00063D4C
		public unsafe override RuntimeTypeHandle TypeHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00065B94 File Offset: 0x00063D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290975, XrefRangeEnd = 290976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsInstanceOfType(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00065BEC File Offset: 0x00063DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290976, XrefRangeEnd = 290989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsSubclassOf(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00065C44 File Offset: 0x00063E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290989, XrefRangeEnd = 290995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsAssignableFrom(Type c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00065C9C File Offset: 0x00063E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290995, XrefRangeEnd = 290998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEquivalentTo(Type other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00065CF4 File Offset: 0x00063EF4
		public unsafe override Type BaseType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290998, XrefRangeEnd = 290999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00065D40 File Offset: 0x00063F40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 291014, RefRangeEnd = 291018, XrefRangeStart = 290999, XrefRangeEnd = 291014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType GetBaseType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetBaseType_Private_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00065D80 File Offset: 0x00063F80
		public unsafe override Type UnderlyingSystemType
		{
			[CallerCount(734)]
			[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00065DCC File Offset: 0x00063FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291018, XrefRangeEnd = 291019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeAttributes GetAttributeFlagsImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00065E14 File Offset: 0x00064014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291019, XrefRangeEnd = 291026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsContextfulImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00065E5C File Offset: 0x0006405C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291026, XrefRangeEnd = 291027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00065EA4 File Offset: 0x000640A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291027, XrefRangeEnd = 291028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPrimitiveImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00065EEC File Offset: 0x000640EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291028, XrefRangeEnd = 291029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00065F34 File Offset: 0x00064134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262712, XrefRangeEnd = 262714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsCOMObjectImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00065F7C File Offset: 0x0006417C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291029, XrefRangeEnd = 291046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00065FC4 File Offset: 0x000641C4
		public unsafe override bool IsEnum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291046, XrefRangeEnd = 291051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsEnum_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0006600C File Offset: 0x0006420C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291051, XrefRangeEnd = 291054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasElementTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00066054 File Offset: 0x00064254
		public unsafe override GenericParameterAttributes GenericParameterAttributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291054, XrefRangeEnd = 291056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_get_GenericParameterAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0006609C File Offset: 0x0006429C
		public unsafe override bool IsSzArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291056, XrefRangeEnd = 291057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsSzArray_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x000660E4 File Offset: 0x000642E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291057, XrefRangeEnd = 291058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0006612C File Offset: 0x0006432C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291058, XrefRangeEnd = 291066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetArrayRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00066174 File Offset: 0x00064374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291066, XrefRangeEnd = 291067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetElementType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x000661C0 File Offset: 0x000643C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291067, XrefRangeEnd = 291075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStringArray GetEnumNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEnumNames_Public_Virtual_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0006620C File Offset: 0x0006440C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291075, XrefRangeEnd = 291088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Array GetEnumValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEnumValues_Public_Virtual_Array_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00066258 File Offset: 0x00064458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291088, XrefRangeEnd = 291100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetEnumUnderlyingType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000662A4 File Offset: 0x000644A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291100, XrefRangeEnd = 291129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnumDefined(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x000662FC File Offset: 0x000644FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291129, XrefRangeEnd = 291142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEnumName(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEnumName_Public_Virtual_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00066350 File Offset: 0x00064550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291142, XrefRangeEnd = 291145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeType> GetGenericArgumentsInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetGenericArgumentsInternal_Internal_Il2CppReferenceArray_1_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeType>>(intPtr3) : null;
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00066390 File Offset: 0x00064590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291145, XrefRangeEnd = 291150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x000663DC File Offset: 0x000645DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291150, XrefRangeEnd = 291170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeGenericType([Optional] Il2CppReferenceArray<Type> instantiation)
		{
			if (instantiation == null)
			{
				instantiation = new Il2CppReferenceArray<Type>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instantiation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_MakeGenericType_Public_Virtual_Type_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00066444 File Offset: 0x00064644
		public unsafe override bool IsGenericTypeDefinition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291170, XrefRangeEnd = 291171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0006648C File Offset: 0x0006468C
		public unsafe override bool IsGenericParameter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291171, XrefRangeEnd = 291172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x000664D4 File Offset: 0x000646D4
		public unsafe override int GenericParameterPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291172, XrefRangeEnd = 291180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0006651C File Offset: 0x0006471C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291180, XrefRangeEnd = 291188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetGenericTypeDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00066568 File Offset: 0x00064768
		public unsafe override bool IsGenericType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291188, XrefRangeEnd = 291189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000665B0 File Offset: 0x000647B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291189, XrefRangeEnd = 291246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, Object target, Il2CppReferenceArray<Object> providedArgs, Il2CppReferenceArray<ParameterModifier> modifiers, CultureInfo culture, Il2CppStringArray namedParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(providedArgs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namedParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0006668C File Offset: 0x0006488C
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000666E4 File Offset: 0x000648E4
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RuntimeType left, RuntimeType right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00066738 File Offset: 0x00064938
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(RuntimeType left, RuntimeType right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0006678C File Offset: 0x0006498C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000667CC File Offset: 0x000649CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291246, XrefRangeEnd = 291253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00066828 File Offset: 0x00064A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291253, XrefRangeEnd = 291261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00066880 File Offset: 0x00064A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291261, XrefRangeEnd = 291284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000668EC File Offset: 0x00064AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291284, XrefRangeEnd = 291307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00066954 File Offset: 0x00064B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291307, XrefRangeEnd = 291308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IList<CustomAttributeData> GetCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000669A0 File Offset: 0x00064BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291308, XrefRangeEnd = 291327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string FormatTypeName(bool serialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serialization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_FormatTypeName_Internal_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x000669F0 File Offset: 0x00064BF0
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291327, XrefRangeEnd = 291329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x00066A38 File Offset: 0x00064C38
		public unsafe override Type ReflectedType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 16379, RefRangeEnd = 16382, XrefRangeStart = 16379, XrefRangeEnd = 16382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00066A84 File Offset: 0x00064C84
		public unsafe override int MetadataToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291329, XrefRangeEnd = 291330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00066ACC File Offset: 0x00064CCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 291344, RefRangeEnd = 291348, XrefRangeStart = 291330, XrefRangeEnd = 291344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateInstanceCheckThis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceCheckThis_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00066B00 File Offset: 0x00064D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291405, RefRangeEnd = 291406, XrefRangeStart = 291348, XrefRangeEnd = 291405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, Il2CppReferenceArray<Object> args, CultureInfo culture, Il2CppReferenceArray<Object> activationAttributes, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceImpl_Internal_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00066BA8 File Offset: 0x00064DA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291423, RefRangeEnd = 291425, XrefRangeStart = 291406, XrefRangeEnd = 291423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref publicOnly;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipCheckThis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillCache;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceDefaultCtor_Internal_Object_Boolean_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00066C20 File Offset: 0x00064E20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291437, RefRangeEnd = 291439, XrefRangeStart = 291425, XrefRangeEnd = 291437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoCMethod GetDefaultConstructor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetDefaultConstructor_Internal_MonoCMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoCMethod>(intPtr3) : null;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00066C60 File Offset: 0x00064E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291439, XrefRangeEnd = 291447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDefaultMemberName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetDefaultMemberName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00066C98 File Offset: 0x00064E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 291469, RefRangeEnd = 291472, XrefRangeStart = 291447, XrefRangeEnd = 291469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeConstructorInfo GetSerializationCtor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetSerializationCtor_Internal_RuntimeConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00066CD8 File Offset: 0x00064ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291472, XrefRangeEnd = 291474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref publicOnly;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipCheckThis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillCache;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceSlow_Internal_Object_Boolean_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00066D50 File Offset: 0x00064F50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 291532, RefRangeEnd = 291535, XrefRangeStart = 291474, XrefRangeEnd = 291532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateInstanceMono(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceMono_Private_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00066D9C File Offset: 0x00064F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291540, RefRangeEnd = 291542, XrefRangeStart = 291535, XrefRangeEnd = 291540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CheckValue(Object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CheckValue_Internal_Object_Object_Binder_CultureInfo_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00066E20 File Offset: 0x00065020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291561, RefRangeEnd = 291562, XrefRangeStart = 291542, XrefRangeEnd = 291561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object TryConvertToType(Object value, ref bool failed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &failed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_TryConvertToType_Private_Object_Object_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00066E80 File Offset: 0x00065080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291562, XrefRangeEnd = 291595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object IsConvertibleToPrimitiveType(Object value, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_IsConvertibleToPrimitiveType_Private_Static_Object_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00066ED8 File Offset: 0x000650D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291595, XrefRangeEnd = 291600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCachedName(TypeNameKind kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetCachedName_Private_String_TypeNameKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00066F1C File Offset: 0x0006511C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291600, XrefRangeEnd = 291601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type make_array_type(int rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_make_array_type_Private_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00066F68 File Offset: 0x00065168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291601, XrefRangeEnd = 291602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeArrayType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00066FB4 File Offset: 0x000651B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291602, XrefRangeEnd = 291608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeArrayType(int rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0006700C File Offset: 0x0006520C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291608, XrefRangeEnd = 291609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type make_byref_type()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_make_byref_type_Private_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0006704C File Offset: 0x0006524C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291609, XrefRangeEnd = 291617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeByRefType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_MakeByRefType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00067098 File Offset: 0x00065298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291617, XrefRangeEnd = 291618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type MakePointerType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_MakePointerType_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000670DC File Offset: 0x000652DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291618, XrefRangeEnd = 291622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakePointerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_MakePointerType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x00067128 File Offset: 0x00065328
		public unsafe override bool ContainsGenericParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291622, XrefRangeEnd = 291624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00067170 File Offset: 0x00065370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291624, XrefRangeEnd = 291631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericParameterConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000671BC File Offset: 0x000653BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 291648, RefRangeEnd = 291655, XrefRangeStart = 291631, XrefRangeEnd = 291648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(genericType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericArgument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceForAnotherGenericParameter_Internal_Static_Object_Type_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00067214 File Offset: 0x00065414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291655, XrefRangeEnd = 291656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type MakeGenericType(Type gt, Il2CppReferenceArray<Type> types)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_MakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0006726C File Offset: 0x0006546C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291656, XrefRangeEnd = 291657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namePtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetMethodsByName_native_Internal_IntPtr_IntPtr_BindingFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000672D4 File Offset: 0x000654D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291676, RefRangeEnd = 291677, XrefRangeStart = 291657, XrefRangeEnd = 291676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeMethodInfo> GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetMethodsByName_Internal_Il2CppReferenceArray_1_RuntimeMethodInfo_String_BindingFlags_Boolean_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeMethodInfo>>(intPtr3) : null;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00067354 File Offset: 0x00065554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291677, XrefRangeEnd = 291678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref icase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetPropertiesByName_native_Private_IntPtr_IntPtr_BindingFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x000673BC File Offset: 0x000655BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291678, XrefRangeEnd = 291679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetConstructors_native(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetConstructors_native_Private_IntPtr_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00067408 File Offset: 0x00065608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291694, RefRangeEnd = 291695, XrefRangeStart = 291679, XrefRangeEnd = 291694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeConstructorInfo> GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetConstructors_internal_Private_Il2CppReferenceArray_1_RuntimeConstructorInfo_BindingFlags_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeConstructorInfo>>(intPtr3) : null;
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00067468 File Offset: 0x00065668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291714, RefRangeEnd = 291715, XrefRangeStart = 291695, XrefRangeEnd = 291714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimePropertyInfo> GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref icase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetPropertiesByName_Private_Il2CppReferenceArray_1_RuntimePropertyInfo_String_BindingFlags_Boolean_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimePropertyInfo>>(intPtr3) : null;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000674E8 File Offset: 0x000656E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291715, XrefRangeEnd = 291719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeCode GetTypeCodeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_TypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00067530 File Offset: 0x00065730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291719, XrefRangeEnd = 291720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode GetTypeCodeImplInternal(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetTypeCodeImplInternal_Private_Static_TypeCode_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00067574 File Offset: 0x00065774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291720, XrefRangeEnd = 291721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x000675B8 File Offset: 0x000657B8
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGenericCOMObjectImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_IsGenericCOMObjectImpl_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x000675F4 File Offset: 0x000657F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291721, XrefRangeEnd = 291722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstanceInternal(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceInternal_Private_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00067638 File Offset: 0x00065838
		public unsafe override MethodBase DeclaringMethod
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_get_MethodBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00067684 File Offset: 0x00065884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291722, XrefRangeEnd = 291723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getFullName(bool full_name, bool assembly_qualified)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref full_name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assembly_qualified;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_getFullName_Internal_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x000676D8 File Offset: 0x000658D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291723, XrefRangeEnd = 291724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Type> GetGenericArgumentsInternal(bool runtimeArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref runtimeArray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetGenericArgumentsInternal_Private_Il2CppReferenceArray_1_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00067724 File Offset: 0x00065924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291724, XrefRangeEnd = 291726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericParameterAttributes GetGenericParameterAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetGenericParameterAttributes_Private_GenericParameterAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00067760 File Offset: 0x00065960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291726, XrefRangeEnd = 291727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGenericParameterPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetGenericParameterPosition_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0006779C File Offset: 0x0006599C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291727, XrefRangeEnd = 291728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetEvents_native_Private_IntPtr_IntPtr_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x000677F4 File Offset: 0x000659F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291728, XrefRangeEnd = 291729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetFields_native_Private_IntPtr_IntPtr_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0006784C File Offset: 0x00065A4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291748, RefRangeEnd = 291750, XrefRangeStart = 291729, XrefRangeEnd = 291748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeFieldInfo> GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetFields_internal_Private_Il2CppReferenceArray_1_RuntimeFieldInfo_String_BindingFlags_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeFieldInfo>>(intPtr3) : null;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x000678BC File Offset: 0x00065ABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291769, RefRangeEnd = 291771, XrefRangeStart = 291750, XrefRangeEnd = 291769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeEventInfo> GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetEvents_internal_Private_Il2CppReferenceArray_1_RuntimeEventInfo_String_BindingFlags_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeEventInfo>>(intPtr3) : null;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0006792C File Offset: 0x00065B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291771, XrefRangeEnd = 291772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetInterfaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00067978 File Offset: 0x00065B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291772, XrefRangeEnd = 291773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetNestedTypes_native_Private_IntPtr_IntPtr_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x000679D0 File Offset: 0x00065BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291800, RefRangeEnd = 291802, XrefRangeStart = 291773, XrefRangeEnd = 291800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeType> GetNestedTypes_internal(string displayName, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetNestedTypes_internal_Private_Il2CppReferenceArray_1_RuntimeType_String_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeType>>(intPtr3) : null;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00067A30 File Offset: 0x00065C30
		public unsafe override string AssemblyQualifiedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291802, XrefRangeEnd = 291803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00067A74 File Offset: 0x00065C74
		public unsafe override Type DeclaringType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291803, XrefRangeEnd = 291804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00067AC0 File Offset: 0x00065CC0
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291804, XrefRangeEnd = 291805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00067B04 File Offset: 0x00065D04
		public unsafe override string Namespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291805, XrefRangeEnd = 291806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00067B48 File Offset: 0x00065D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291806, XrefRangeEnd = 291815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00067B90 File Offset: 0x00065D90
		public unsafe override string FullName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291815, XrefRangeEnd = 291816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00005C56 File Offset: 0x00003E56
		public override Type MakeGenericType(params Type[] instantiation)
		{
			return this.MakeGenericType(new Il2CppReferenceArray<Type>(instantiation));
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00005C64 File Offset: 0x00003E64
		public RuntimeType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00067BD4 File Offset: 0x00065DD4
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x00005C6D File Offset: 0x00003E6D
		public unsafe static RuntimeType ValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_ValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_ValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00067BFC File Offset: 0x00065DFC
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x00005C7F File Offset: 0x00003E7F
		public unsafe static RuntimeType EnumType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_EnumType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_EnumType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x00067C24 File Offset: 0x00065E24
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x00005C91 File Offset: 0x00003E91
		public unsafe static RuntimeType ObjectType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_ObjectType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_ObjectType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x00067C4C File Offset: 0x00065E4C
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x00005CA3 File Offset: 0x00003EA3
		public unsafe static RuntimeType StringType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_StringType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_StringType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x00067C74 File Offset: 0x00065E74
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x00005CB5 File Offset: 0x00003EB5
		public unsafe static RuntimeType DelegateType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_DelegateType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_DelegateType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00067C9C File Offset: 0x00065E9C
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x00005CC7 File Offset: 0x00003EC7
		public unsafe static Il2CppReferenceArray<Type> s_SICtorParamTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_s_SICtorParamTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_s_SICtorParamTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00067CC4 File Offset: 0x00065EC4
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x00005CD9 File Offset: 0x00003ED9
		public unsafe static BindingFlags MemberBindingMask
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_MemberBindingMask, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_MemberBindingMask, (void*)(&value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00067CE0 File Offset: 0x00065EE0
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x00005CE7 File Offset: 0x00003EE7
		public unsafe static BindingFlags InvocationMask
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_InvocationMask, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_InvocationMask, (void*)(&value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00067CFC File Offset: 0x00065EFC
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x00005CF5 File Offset: 0x00003EF5
		public unsafe static BindingFlags BinderNonCreateInstance
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderNonCreateInstance, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderNonCreateInstance, (void*)(&value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00067D18 File Offset: 0x00065F18
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x00005D03 File Offset: 0x00003F03
		public unsafe static BindingFlags BinderGetSetProperty
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderGetSetProperty, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderGetSetProperty, (void*)(&value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00067D34 File Offset: 0x00065F34
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x00005D11 File Offset: 0x00003F11
		public unsafe static BindingFlags BinderSetInvokeProperty
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderSetInvokeProperty, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderSetInvokeProperty, (void*)(&value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00067D50 File Offset: 0x00065F50
		// (set) Token: 0x06000F2B RID: 3883 RVA: 0x00005D1F File Offset: 0x00003F1F
		public unsafe static BindingFlags BinderGetSetField
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderGetSetField, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderGetSetField, (void*)(&value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x00067D6C File Offset: 0x00065F6C
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x00005D2D File Offset: 0x00003F2D
		public unsafe static BindingFlags BinderSetInvokeField
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderSetInvokeField, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderSetInvokeField, (void*)(&value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00067D88 File Offset: 0x00065F88
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00005D3B File Offset: 0x00003F3B
		public unsafe static BindingFlags BinderNonFieldGetSet
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderNonFieldGetSet, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderNonFieldGetSet, (void*)(&value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00067DA4 File Offset: 0x00065FA4
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x00005D49 File Offset: 0x00003F49
		public unsafe static BindingFlags ClassicBindingMask
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_ClassicBindingMask, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_ClassicBindingMask, (void*)(&value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00067DC0 File Offset: 0x00065FC0
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x00005D57 File Offset: 0x00003F57
		public unsafe static RuntimeType s_typedRef
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_s_typedRef, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_s_typedRef, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00067DE8 File Offset: 0x00065FE8
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x00005D69 File Offset: 0x00003F69
		public unsafe MonoTypeInfo type_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_type_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTypeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_type_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00067E18 File Offset: 0x00066018
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x00005D88 File Offset: 0x00003F88
		public unsafe Object GenericCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_GenericCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_GenericCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00067E48 File Offset: 0x00066048
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x00005DA7 File Offset: 0x00003FA7
		public unsafe RuntimeConstructorInfo m_serializationCtor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_m_serializationCtor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_m_serializationCtor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeFieldInfoPtr_ValueType;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeFieldInfoPtr_EnumType;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeFieldInfoPtr_ObjectType;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeFieldInfoPtr_StringType;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeFieldInfoPtr_DelegateType;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeFieldInfoPtr_s_SICtorParamTypes;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeFieldInfoPtr_MemberBindingMask;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeFieldInfoPtr_InvocationMask;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeFieldInfoPtr_BinderNonCreateInstance;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeFieldInfoPtr_BinderGetSetProperty;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeFieldInfoPtr_BinderSetInvokeProperty;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeFieldInfoPtr_BinderGetSetField;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeFieldInfoPtr_BinderSetInvokeField;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeFieldInfoPtr_BinderNonFieldGetSet;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeFieldInfoPtr_ClassicBindingMask;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeFieldInfoPtr_s_typedRef;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeFieldInfoPtr_type_info;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeFieldInfoPtr_GenericCache;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr_m_serializationCtor;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfTypeNeverValidGenericArgument_Private_Static_Void_RuntimeType_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_SanityCheckGenericArguments_Internal_Static_Void_Il2CppReferenceArray_1_RuntimeType_Il2CppReferenceArray_1_RuntimeType_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_SplitName_Private_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_Boolean_byref_Boolean_byref_Boolean_byref_MemberListType_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_byref_Boolean_byref_MemberListType_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyPrefixLookup_Private_Static_Boolean_MemberInfo_String_Boolean_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyBase_Private_Static_Boolean_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyType_Private_Static_Boolean_Type_BindingFlags_String_Boolean_String_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyMethodInfo_Private_Static_Boolean_RuntimeMethodInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyConstructorInfo_Private_Static_Boolean_RuntimeConstructorInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyMethodBase_Private_Static_Boolean_MethodBase_BindingFlags_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecialSerializableType_Internal_Boolean_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodCandidates_Private_ListBuilder_1_MethodInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorCandidates_Private_ListBuilder_1_ConstructorInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyCandidates_Private_ListBuilder_1_PropertyInfo_String_BindingFlags_Il2CppReferenceArray_1_Type_Boolean_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_GetEventCandidates_Private_ListBuilder_1_EventInfo_String_BindingFlags_Boolean_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldCandidates_Private_ListBuilder_1_FieldInfo_String_BindingFlags_Boolean_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedTypeCandidates_Private_ListBuilder_1_Type_String_BindingFlags_Boolean_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Public_Virtual_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_Boolean_Type_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Boolean_Type_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Type_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseType_Private_RuntimeType_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnum_Public_Virtual_get_Boolean_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_get_GenericParameterAttributes_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSzArray_Internal_Virtual_get_Boolean_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Int32_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumNames_Public_Virtual_Il2CppStringArray_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumValues_Public_Virtual_Array_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_Type_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumName_Public_Virtual_String_Object_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArgumentsInternal_Internal_Il2CppReferenceArray_1_RuntimeType_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericType_Public_Virtual_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_get_Int32_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Type_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_FormatTypeName_Internal_Virtual_String_Boolean_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceCheckThis_Private_Void_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceImpl_Internal_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_byref_StackCrawlMark_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceDefaultCtor_Internal_Object_Boolean_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultConstructor_Internal_MonoCMethod_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultMemberName_Private_String_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationCtor_Internal_RuntimeConstructorInfo_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceSlow_Internal_Object_Boolean_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceMono_Private_Object_Boolean_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_CheckValue_Internal_Object_Object_Binder_CultureInfo_BindingFlags_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertToType_Private_Object_Object_byref_Boolean_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_IsConvertibleToPrimitiveType_Private_Static_Object_Object_Type_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedName_Private_String_TypeNameKind_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_make_array_type_Private_Type_Int32_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_Int32_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_make_byref_type_Private_Type_0;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr_MakeByRefType_Public_Virtual_Type_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr_MakePointerType_Private_Static_Type_Type_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_MakePointerType_Public_Virtual_Type_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceForAnotherGenericParameter_Internal_Static_Object_Type_RuntimeType_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodsByName_native_Internal_IntPtr_IntPtr_BindingFlags_Boolean_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodsByName_Internal_Il2CppReferenceArray_1_RuntimeMethodInfo_String_BindingFlags_Boolean_RuntimeType_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesByName_native_Private_IntPtr_IntPtr_BindingFlags_Boolean_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_native_Private_IntPtr_BindingFlags_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_internal_Private_Il2CppReferenceArray_1_RuntimeConstructorInfo_BindingFlags_RuntimeType_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesByName_Private_Il2CppReferenceArray_1_RuntimePropertyInfo_String_BindingFlags_Boolean_RuntimeType_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_TypeCode_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCodeImplInternal_Private_Static_TypeCode_Type_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericCOMObjectImpl_Private_Boolean_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceInternal_Private_Static_Object_Type_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_get_MethodBase_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_getFullName_Internal_String_Boolean_Boolean_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArgumentsInternal_Private_Il2CppReferenceArray_1_Type_Boolean_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericParameterAttributes_Private_GenericParameterAttributes_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericParameterPosition_Private_Int32_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_native_Private_IntPtr_IntPtr_BindingFlags_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_native_Private_IntPtr_IntPtr_BindingFlags_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_internal_Private_Il2CppReferenceArray_1_RuntimeFieldInfo_String_BindingFlags_RuntimeType_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_internal_Private_Il2CppReferenceArray_1_RuntimeEventInfo_String_BindingFlags_RuntimeType_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedTypes_native_Private_IntPtr_IntPtr_BindingFlags_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedTypes_internal_Private_Il2CppReferenceArray_1_RuntimeType_String_BindingFlags_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0;

		// Token: 0x0200059C RID: 1436
		public enum MemberListType
		{
			// Token: 0x0400403D RID: 16445
			All,
			// Token: 0x0400403E RID: 16446
			CaseSensitive,
			// Token: 0x0400403F RID: 16447
			CaseInsensitive,
			// Token: 0x04004040 RID: 16448
			HandleToInfo
		}

		// Token: 0x0200059D RID: 1437
		public sealed class ListBuilder<T> : ValueType where T : class
		{
			// Token: 0x06004F2A RID: 20266 RVA: 0x001643F4 File Offset: 0x001625F4
			// Note: this type is marked as 'beforefieldinit'.
			static ListBuilder()
			{
				Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "ListBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr);
				RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, "_items");
				RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, "_item");
				RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, "_count");
				RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, "_capacity");
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100665873);
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100665874);
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100665875);
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100665876);
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100665877);
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100665878);
			}

			// Token: 0x06004F2B RID: 20267 RVA: 0x00164524 File Offset: 0x00162724
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 290456, RefRangeEnd = 290463, XrefRangeStart = 290456, XrefRangeEnd = 290456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ListBuilder(int capacity)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref capacity;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001420 RID: 5152
			public unsafe T this[int index]
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 290463, RefRangeEnd = 290466, XrefRangeStart = 290463, XrefRangeEnd = 290463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
					}
				}
			}

			// Token: 0x06004F2D RID: 20269 RVA: 0x001645BC File Offset: 0x001627BC
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 290483, RefRangeEnd = 290493, XrefRangeStart = 290466, XrefRangeEnd = 290483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppArrayBase<T> ToArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}

			// Token: 0x06004F2E RID: 20270 RVA: 0x001645F8 File Offset: 0x001627F8
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 290494, RefRangeEnd = 290500, XrefRangeStart = 290493, XrefRangeEnd = 290494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Il2CppReferenceArray<Object> array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001421 RID: 5153
			// (get) Token: 0x06004F2F RID: 20271 RVA: 0x00164650 File Offset: 0x00162850
			public unsafe int Count
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F30 RID: 20272 RVA: 0x00164694 File Offset: 0x00162894
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 290508, RefRangeEnd = 290514, XrefRangeStart = 290500, XrefRangeEnd = 290508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(T item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = item;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_Add_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06004F31 RID: 20273 RVA: 0x0001DFC3 File Offset: 0x0001C1C3
			public ListBuilder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F32 RID: 20274 RVA: 0x0001DFCC File Offset: 0x0001C1CC
			public ListBuilder()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700141C RID: 5148
			// (get) Token: 0x06004F33 RID: 20275 RVA: 0x00164714 File Offset: 0x00162914
			// (set) Token: 0x06004F34 RID: 20276 RVA: 0x0001DFDE File Offset: 0x0001C1DE
			public unsafe Il2CppArrayBase<T> _items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__items);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700141D RID: 5149
			// (get) Token: 0x06004F35 RID: 20277 RVA: 0x0016473C File Offset: 0x0016293C
			// (set) Token: 0x06004F36 RID: 20278 RVA: 0x00164764 File Offset: 0x00162964
			public unsafe T _item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__item);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__item);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x1700141E RID: 5150
			// (get) Token: 0x06004F37 RID: 20279 RVA: 0x0016480C File Offset: 0x00162A0C
			// (set) Token: 0x06004F38 RID: 20280 RVA: 0x0001DFFD File Offset: 0x0001C1FD
			public unsafe int _count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__count)) = value;
				}
			}

			// Token: 0x1700141F RID: 5151
			// (get) Token: 0x06004F39 RID: 20281 RVA: 0x00164834 File Offset: 0x00162A34
			// (set) Token: 0x06004F3A RID: 20282 RVA: 0x0001E018 File Offset: 0x0001C218
			public unsafe int _capacity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__capacity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__capacity)) = value;
				}
			}

			// Token: 0x04004041 RID: 16449
			private static readonly IntPtr NativeFieldInfoPtr__items;

			// Token: 0x04004042 RID: 16450
			private static readonly IntPtr NativeFieldInfoPtr__item;

			// Token: 0x04004043 RID: 16451
			private static readonly IntPtr NativeFieldInfoPtr__count;

			// Token: 0x04004044 RID: 16452
			private static readonly IntPtr NativeFieldInfoPtr__capacity;

			// Token: 0x04004045 RID: 16453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004046 RID: 16454
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

			// Token: 0x04004047 RID: 16455
			private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

			// Token: 0x04004048 RID: 16456
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_Object_Int32_0;

			// Token: 0x04004049 RID: 16457
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x0400404A RID: 16458
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;
		}
	}
}
