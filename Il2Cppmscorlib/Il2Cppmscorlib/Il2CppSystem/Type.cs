using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000F6 RID: 246
	[Serializable]
	public class Type : MemberInfo
	{
		// Token: 0x06001184 RID: 4484 RVA: 0x0007307C File Offset: 0x0007127C
		// Note: this type is marked as 'beforefieldinit'.
		static Type()
		{
			Il2CppClassPointerStore<Type>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Type");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Type>.NativeClassPtr);
			Type.NativeFieldInfoPtr_FilterAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type>.NativeClassPtr, "FilterAttribute");
			Type.NativeFieldInfoPtr_FilterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type>.NativeClassPtr, "FilterName");
			Type.NativeFieldInfoPtr_FilterNameIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type>.NativeClassPtr, "FilterNameIgnoreCase");
			Type.NativeFieldInfoPtr_Missing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type>.NativeClassPtr, "Missing");
			Type.NativeFieldInfoPtr_Delimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type>.NativeClassPtr, "Delimiter");
			Type.NativeFieldInfoPtr_EmptyTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type>.NativeClassPtr, "EmptyTypes");
			Type.NativeFieldInfoPtr_defaultBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type>.NativeClassPtr, "defaultBinder");
			Type.NativeFieldInfoPtr_DefaultLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type>.NativeClassPtr, "DefaultLookup");
			Type.NativeFieldInfoPtr_DeclaredOnlyLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type>.NativeClassPtr, "DeclaredOnlyLookup");
			Type.NativeFieldInfoPtr__impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type>.NativeClassPtr, "_impl");
			Type.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666328);
			Type.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666329);
			Type.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666330);
			Type.NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666331);
			Type.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666332);
			Type.NativeMethodInfoPtr_GetType_Public_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666333);
			Type.NativeMethodInfoPtr_MakePointerType_Public_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666334);
			Type.NativeMethodInfoPtr_MakeByRefType_Public_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666335);
			Type.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666336);
			Type.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_New_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666337);
			Type.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666338);
			Type.NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666339);
			Type.NativeMethodInfoPtr_get_DefaultBinder_Public_Static_get_Binder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666340);
			Type.NativeMethodInfoPtr_CreateBinder_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666341);
			Type.NativeMethodInfoPtr_InvokeMember_Public_Abstract_Virtual_New_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666342);
			Type.NativeMethodInfoPtr_get_Module_Public_Abstract_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666343);
			Type.NativeMethodInfoPtr_get_Assembly_Public_Abstract_Virtual_New_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666344);
			Type.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_New_get_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666345);
			Type.NativeMethodInfoPtr_GetTypeHandle_Public_Static_RuntimeTypeHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666346);
			Type.NativeMethodInfoPtr_get_FullName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666347);
			Type.NativeMethodInfoPtr_get_Namespace_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666348);
			Type.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666349);
			Type.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666350);
			Type.NativeMethodInfoPtr_get_BaseType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666351);
			Type.NativeMethodInfoPtr_GetConstructor_Public_Virtual_Final_New_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666352);
			Type.NativeMethodInfoPtr_GetConstructor_Public_Virtual_Final_New_ConstructorInfo_BindingFlags_Binder_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666353);
			Type.NativeMethodInfoPtr_GetConstructor_Public_Virtual_Final_New_ConstructorInfo_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666354);
			Type.NativeMethodInfoPtr_GetConstructorImpl_Protected_Abstract_Virtual_New_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666355);
			Type.NativeMethodInfoPtr_GetConstructors_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666356);
			Type.NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_BindingFlags_Binder_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666357);
			Type.NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666358);
			Type.NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666359);
			Type.NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666360);
			Type.NativeMethodInfoPtr_GetMethodImpl_Protected_Abstract_Virtual_New_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666361);
			Type.NativeMethodInfoPtr_GetMethods_Public_Virtual_Final_New_Il2CppReferenceArray_1_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666362);
			Type.NativeMethodInfoPtr_GetMethods_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666363);
			Type.NativeMethodInfoPtr_GetField_Public_Abstract_Virtual_New_FieldInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666364);
			Type.NativeMethodInfoPtr_GetField_Public_Virtual_Final_New_FieldInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666365);
			Type.NativeMethodInfoPtr_GetFields_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666366);
			Type.NativeMethodInfoPtr_GetInterfaces_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666367);
			Type.NativeMethodInfoPtr_FindInterfaces_Public_Virtual_New_Il2CppReferenceArray_1_Type_TypeFilter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666368);
			Type.NativeMethodInfoPtr_GetEvent_Public_Abstract_Virtual_New_EventInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666369);
			Type.NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666370);
			Type.NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666371);
			Type.NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666372);
			Type.NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666373);
			Type.NativeMethodInfoPtr_GetPropertyImpl_Protected_Abstract_Virtual_New_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666374);
			Type.NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666375);
			Type.NativeMethodInfoPtr_GetProperties_Public_Virtual_Final_New_Il2CppReferenceArray_1_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666376);
			Type.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Final_New_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666377);
			Type.NativeMethodInfoPtr_GetNestedType_Public_Abstract_Virtual_New_Type_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666378);
			Type.NativeMethodInfoPtr_GetMember_Public_Virtual_Final_New_Il2CppReferenceArray_1_MemberInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666379);
			Type.NativeMethodInfoPtr_GetMember_Public_Virtual_New_Il2CppReferenceArray_1_MemberInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666380);
			Type.NativeMethodInfoPtr_GetMember_Public_Virtual_New_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666381);
			Type.NativeMethodInfoPtr_get_IsNested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666382);
			Type.NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_TypeAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666383);
			Type.NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_New_get_GenericParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666384);
			Type.NativeMethodInfoPtr_get_IsNotPublic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666385);
			Type.NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666386);
			Type.NativeMethodInfoPtr_get_IsNestedPublic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666387);
			Type.NativeMethodInfoPtr_get_IsNestedAssembly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666388);
			Type.NativeMethodInfoPtr_get_IsExplicitLayout_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666389);
			Type.NativeMethodInfoPtr_get_IsClass_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666390);
			Type.NativeMethodInfoPtr_get_IsInterface_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666391);
			Type.NativeMethodInfoPtr_get_IsValueType_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666392);
			Type.NativeMethodInfoPtr_get_IsAbstract_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666393);
			Type.NativeMethodInfoPtr_get_IsSealed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666394);
			Type.NativeMethodInfoPtr_get_IsEnum_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666395);
			Type.NativeMethodInfoPtr_get_IsSerializable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666396);
			Type.NativeMethodInfoPtr_get_IsArray_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666397);
			Type.NativeMethodInfoPtr_get_IsSzArray_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666398);
			Type.NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666399);
			Type.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666400);
			Type.NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666401);
			Type.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666402);
			Type.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666403);
			Type.NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666404);
			Type.NativeMethodInfoPtr_get_IsByRef_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666405);
			Type.NativeMethodInfoPtr_get_IsPointer_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666406);
			Type.NativeMethodInfoPtr_get_IsPrimitive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666407);
			Type.NativeMethodInfoPtr_get_IsCOMObject_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666408);
			Type.NativeMethodInfoPtr_get_HasElementType_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666409);
			Type.NativeMethodInfoPtr_get_IsContextful_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666410);
			Type.NativeMethodInfoPtr_get_IsMarshalByRef_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666411);
			Type.NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666412);
			Type.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Abstract_Virtual_New_TypeAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666413);
			Type.NativeMethodInfoPtr_IsArrayImpl_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666414);
			Type.NativeMethodInfoPtr_IsByRefImpl_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666415);
			Type.NativeMethodInfoPtr_IsPointerImpl_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666416);
			Type.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666417);
			Type.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666418);
			Type.NativeMethodInfoPtr_MakeGenericType_Public_Virtual_New_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666419);
			Type.NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666420);
			Type.NativeMethodInfoPtr_IsMarshalByRefImpl_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666421);
			Type.NativeMethodInfoPtr_GetElementType_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666422);
			Type.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666423);
			Type.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666424);
			Type.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666425);
			Type.NativeMethodInfoPtr_GetRootElementType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666426);
			Type.NativeMethodInfoPtr_GetEnumNames_Public_Virtual_New_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666427);
			Type.NativeMethodInfoPtr_GetEnumValues_Public_Virtual_New_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666428);
			Type.NativeMethodInfoPtr_GetEnumRawConstantValues_Private_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666429);
			Type.NativeMethodInfoPtr_GetEnumData_Private_Void_byref_Il2CppStringArray_byref_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666430);
			Type.NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666431);
			Type.NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666432);
			Type.NativeMethodInfoPtr_GetEnumName_Public_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666433);
			Type.NativeMethodInfoPtr_BinarySearch_Private_Static_Int32_Array_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666434);
			Type.NativeMethodInfoPtr_IsIntegerType_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666435);
			Type.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666436);
			Type.NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666437);
			Type.NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666438);
			Type.NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666439);
			Type.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666440);
			Type.NativeMethodInfoPtr_ImplementInterface_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666441);
			Type.NativeMethodInfoPtr_FormatTypeName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666442);
			Type.NativeMethodInfoPtr_FormatTypeName_Internal_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666443);
			Type.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666444);
			Type.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666445);
			Type.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666446);
			Type.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666447);
			Type.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666448);
			Type.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666449);
			Type.NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666450);
			Type.NativeMethodInfoPtr_internal_from_name_Private_Static_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666451);
			Type.NativeMethodInfoPtr_GetType_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666452);
			Type.NativeMethodInfoPtr_GetType_Public_Static_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666453);
			Type.NativeMethodInfoPtr_GetType_Public_Static_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666454);
			Type.NativeMethodInfoPtr_GetTypeFromHandle_Public_Static_Type_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666455);
			Type.NativeMethodInfoPtr_internal_from_handle_Private_Static_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type>.NativeClassPtr, 100666456);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00073B88 File Offset: 0x00071D88
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Type>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x00073BC4 File Offset: 0x00071DC4
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00073C0C File Offset: 0x00071E0C
		public unsafe override Type DeclaringType
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00073C58 File Offset: 0x00071E58
		public unsafe virtual MethodBase DeclaringMethod
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_New_get_MethodBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00073CA4 File Offset: 0x00071EA4
		public unsafe override Type ReflectedType
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00073CF0 File Offset: 0x00071EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300464, RefRangeEnd = 300465, XrefRangeStart = 300462, XrefRangeEnd = 300464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyResolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeResolver);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetType_Public_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00073D68 File Offset: 0x00071F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300465, XrefRangeEnd = 300470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type MakePointerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_MakePointerType_Public_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00073DB4 File Offset: 0x00071FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300470, XrefRangeEnd = 300475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type MakeByRefType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_MakeByRefType_Public_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00073E00 File Offset: 0x00072000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300475, XrefRangeEnd = 300480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type MakeArrayType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00073E4C File Offset: 0x0007204C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300480, XrefRangeEnd = 300485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type MakeArrayType(int rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_New_Type_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00073EA4 File Offset: 0x000720A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 300488, RefRangeEnd = 300496, XrefRangeStart = 300485, XrefRangeEnd = 300488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode GetTypeCode(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00073EE8 File Offset: 0x000720E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300496, XrefRangeEnd = 300507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeCode GetTypeCodeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_New_TypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x00073F30 File Offset: 0x00072130
		public unsafe static Binder DefaultBinder
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 300528, RefRangeEnd = 300537, XrefRangeStart = 300507, XrefRangeEnd = 300528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_DefaultBinder_Public_Static_get_Binder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Binder>(intPtr3) : null;
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00073F64 File Offset: 0x00072164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300537, XrefRangeEnd = 300549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateBinder()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_CreateBinder_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00073F8C File Offset: 0x0007218C
		[CallerCount(0)]
		public unsafe virtual Object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, Object target, Il2CppReferenceArray<Object> args, Il2CppReferenceArray<ParameterModifier> modifiers, CultureInfo culture, Il2CppStringArray namedParameters)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_InvokeMember_Public_Abstract_Virtual_New_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00074068 File Offset: 0x00072268
		public unsafe override Module Module
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_Module_Public_Abstract_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x000740B4 File Offset: 0x000722B4
		public unsafe virtual Assembly Assembly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_Assembly_Public_Abstract_Virtual_New_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00074100 File Offset: 0x00072300
		public unsafe virtual RuntimeTypeHandle TypeHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300549, XrefRangeEnd = 300554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_New_get_RuntimeTypeHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00074148 File Offset: 0x00072348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300558, RefRangeEnd = 300559, XrefRangeStart = 300554, XrefRangeEnd = 300558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeTypeHandle GetTypeHandle(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetTypeHandle_Public_Static_RuntimeTypeHandle_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0007418C File Offset: 0x0007238C
		public unsafe virtual string FullName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_FullName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x000741D0 File Offset: 0x000723D0
		public unsafe virtual string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_Namespace_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00074214 File Offset: 0x00072414
		public unsafe virtual string AssemblyQualifiedName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00074258 File Offset: 0x00072458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300559, XrefRangeEnd = 300566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetArrayRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x000742A0 File Offset: 0x000724A0
		public unsafe virtual Type BaseType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_BaseType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000742EC File Offset: 0x000724EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300585, RefRangeEnd = 300586, XrefRangeStart = 300566, XrefRangeEnd = 300585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetConstructor_Public_Virtual_Final_New_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00074380 File Offset: 0x00072580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300591, RefRangeEnd = 300593, XrefRangeStart = 300586, XrefRangeEnd = 300591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetConstructor_Public_Virtual_Final_New_ConstructorInfo_BindingFlags_Binder_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00074404 File Offset: 0x00072604
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300598, RefRangeEnd = 300600, XrefRangeStart = 300593, XrefRangeEnd = 300598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConstructorInfo GetConstructor(Il2CppReferenceArray<Type> types)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetConstructor_Public_Virtual_Final_New_ConstructorInfo_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00074454 File Offset: 0x00072654
		[CallerCount(0)]
		public unsafe virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetConstructorImpl_Protected_Abstract_Virtual_New_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000744F4 File Offset: 0x000726F4
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ConstructorInfo> GetConstructors(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetConstructors_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstructorInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0007454C File Offset: 0x0007274C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 300606, RefRangeEnd = 300612, XrefRangeStart = 300600, XrefRangeEnd = 300606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_BindingFlags_Binder_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x000745E4 File Offset: 0x000727E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 300617, RefRangeEnd = 300623, XrefRangeStart = 300612, XrefRangeEnd = 300617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetMethod(string name, Il2CppReferenceArray<Type> types)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00074648 File Offset: 0x00072848
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 300623, RefRangeEnd = 300644, XrefRangeStart = 300623, XrefRangeEnd = 300623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetMethod(string name, BindingFlags bindingAttr)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x000746A8 File Offset: 0x000728A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 300644, RefRangeEnd = 300651, XrefRangeStart = 300644, XrefRangeEnd = 300644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetMethod(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x000746F8 File Offset: 0x000728F8
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetMethodImpl_Protected_Abstract_Virtual_New_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x000747A8 File Offset: 0x000729A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300651, RefRangeEnd = 300652, XrefRangeStart = 300651, XrefRangeEnd = 300651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<MethodInfo> GetMethods()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetMethods_Public_Virtual_Final_New_Il2CppReferenceArray_1_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x000747E8 File Offset: 0x000729E8
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<MethodInfo> GetMethods(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetMethods_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00074840 File Offset: 0x00072A40
		[CallerCount(0)]
		public unsafe virtual FieldInfo GetField(string name, BindingFlags bindingAttr)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetField_Public_Abstract_Virtual_New_FieldInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x000748AC File Offset: 0x00072AAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 300652, RefRangeEnd = 300657, XrefRangeStart = 300652, XrefRangeEnd = 300652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual FieldInfo GetField(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetField_Public_Virtual_Final_New_FieldInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x000748FC File Offset: 0x00072AFC
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<FieldInfo> GetFields(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetFields_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00074954 File Offset: 0x00072B54
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Type> GetInterfaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetInterfaces_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x000749A0 File Offset: 0x00072BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300657, XrefRangeEnd = 300670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> FindInterfaces(TypeFilter filter, Object filterCriteria)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterCriteria);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_FindInterfaces_Public_Virtual_New_Il2CppReferenceArray_1_Type_TypeFilter_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00074A10 File Offset: 0x00072C10
		[CallerCount(0)]
		public unsafe virtual EventInfo GetEvent(string name, BindingFlags bindingAttr)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetEvent_Public_Abstract_Virtual_New_EventInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00074A7C File Offset: 0x00072C7C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 300670, RefRangeEnd = 300687, XrefRangeStart = 300670, XrefRangeEnd = 300670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyInfo GetProperty(string name, BindingFlags bindingAttr)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00074ADC File Offset: 0x00072CDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300687, RefRangeEnd = 300688, XrefRangeStart = 300687, XrefRangeEnd = 300687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyInfo GetProperty(string name, Type returnType, Il2CppReferenceArray<Type> types)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_Type_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00074B50 File Offset: 0x00072D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300688, XrefRangeEnd = 300691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyInfo GetProperty(string name, Type returnType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00074BB4 File Offset: 0x00072DB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 300691, RefRangeEnd = 300694, XrefRangeStart = 300691, XrefRangeEnd = 300691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyInfo GetProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00074C04 File Offset: 0x00072E04
		[CallerCount(0)]
		public unsafe virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetPropertyImpl_Protected_Abstract_Virtual_New_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00074CB8 File Offset: 0x00072EB8
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<PropertyInfo> GetProperties(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00074D10 File Offset: 0x00072F10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 300694, RefRangeEnd = 300697, XrefRangeStart = 300694, XrefRangeEnd = 300694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<PropertyInfo> GetProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetProperties_Public_Virtual_Final_New_Il2CppReferenceArray_1_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr3) : null;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00074D50 File Offset: 0x00072F50
		[CallerCount(0)]
		public unsafe virtual Type GetNestedType(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Final_New_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00074DA0 File Offset: 0x00072FA0
		[CallerCount(0)]
		public unsafe virtual Type GetNestedType(string name, BindingFlags bindingAttr)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetNestedType_Public_Abstract_Virtual_New_Type_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00074E0C File Offset: 0x0007300C
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<MemberInfo> GetMember(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetMember_Public_Virtual_Final_New_Il2CppReferenceArray_1_MemberInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00074E5C File Offset: 0x0007305C
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<MemberInfo> GetMember(string name, BindingFlags bindingAttr)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetMember_Public_Virtual_New_Il2CppReferenceArray_1_MemberInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00074EC8 File Offset: 0x000730C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300697, XrefRangeEnd = 300704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<MemberInfo> GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetMember_Public_Virtual_New_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00074F40 File Offset: 0x00073140
		public unsafe bool IsNested
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300707, RefRangeEnd = 300708, XrefRangeStart = 300704, XrefRangeEnd = 300707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsNested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00074F7C File Offset: 0x0007317C
		public unsafe virtual TypeAttributes Attributes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300708, RefRangeEnd = 300710, XrefRangeStart = 300708, XrefRangeEnd = 300708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_TypeAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00074FB8 File Offset: 0x000731B8
		public unsafe virtual GenericParameterAttributes GenericParameterAttributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300710, XrefRangeEnd = 300715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_New_get_GenericParameterAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00075000 File Offset: 0x00073200
		public unsafe virtual bool IsNotPublic
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300715, RefRangeEnd = 300716, XrefRangeStart = 300715, XrefRangeEnd = 300715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsNotPublic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0007503C File Offset: 0x0007323C
		public unsafe virtual bool IsPublic
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300716, RefRangeEnd = 300718, XrefRangeStart = 300716, XrefRangeEnd = 300716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00075078 File Offset: 0x00073278
		public unsafe virtual bool IsNestedPublic
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300718, RefRangeEnd = 300719, XrefRangeStart = 300718, XrefRangeEnd = 300718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsNestedPublic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x000750B4 File Offset: 0x000732B4
		public unsafe virtual bool IsNestedAssembly
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300719, RefRangeEnd = 300720, XrefRangeStart = 300719, XrefRangeEnd = 300719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsNestedAssembly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x000750F0 File Offset: 0x000732F0
		public unsafe virtual bool IsExplicitLayout
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300720, RefRangeEnd = 300722, XrefRangeStart = 300720, XrefRangeEnd = 300720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsExplicitLayout_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0007512C File Offset: 0x0007332C
		public unsafe virtual bool IsClass
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300722, RefRangeEnd = 300723, XrefRangeStart = 300722, XrefRangeEnd = 300722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsClass_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00075168 File Offset: 0x00073368
		public unsafe virtual bool IsInterface
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 300729, RefRangeEnd = 300747, XrefRangeStart = 300723, XrefRangeEnd = 300729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsInterface_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x000751A4 File Offset: 0x000733A4
		public unsafe virtual bool IsValueType
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 132538, RefRangeEnd = 132556, XrefRangeStart = 132538, XrefRangeEnd = 132556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsValueType_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x000751E0 File Offset: 0x000733E0
		public unsafe virtual bool IsAbstract
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 300747, RefRangeEnd = 300751, XrefRangeStart = 300747, XrefRangeEnd = 300747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsAbstract_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x0007521C File Offset: 0x0007341C
		public unsafe virtual bool IsSealed
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 300751, RefRangeEnd = 300754, XrefRangeStart = 300751, XrefRangeEnd = 300751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsSealed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x00075258 File Offset: 0x00073458
		public unsafe virtual bool IsEnum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300754, XrefRangeEnd = 300758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_IsEnum_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x000752A0 File Offset: 0x000734A0
		public unsafe virtual bool IsSerializable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300758, XrefRangeEnd = 300764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_IsSerializable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x000752E8 File Offset: 0x000734E8
		public unsafe virtual bool IsArray
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 300764, RefRangeEnd = 300783, XrefRangeStart = 300764, XrefRangeEnd = 300764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsArray_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x00075324 File Offset: 0x00073524
		public unsafe virtual bool IsSzArray
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_IsSzArray_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x0007536C File Offset: 0x0007356C
		public unsafe virtual bool IsGenericType
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x000753B4 File Offset: 0x000735B4
		public unsafe virtual bool IsGenericTypeDefinition
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x000753FC File Offset: 0x000735FC
		public unsafe virtual bool IsGenericParameter
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x00075444 File Offset: 0x00073644
		public unsafe virtual int GenericParameterPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300783, XrefRangeEnd = 300790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x0007548C File Offset: 0x0007368C
		public unsafe virtual bool ContainsGenericParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300790, XrefRangeEnd = 300791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x000754D4 File Offset: 0x000736D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300791, XrefRangeEnd = 300803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetGenericParameterConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00075520 File Offset: 0x00073720
		public unsafe virtual bool IsByRef
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 300803, RefRangeEnd = 300825, XrefRangeStart = 300803, XrefRangeEnd = 300803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsByRef_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0007555C File Offset: 0x0007375C
		public unsafe virtual bool IsPointer
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 146304, RefRangeEnd = 146312, XrefRangeStart = 146304, XrefRangeEnd = 146312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsPointer_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00075598 File Offset: 0x00073798
		public unsafe virtual bool IsPrimitive
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 300825, RefRangeEnd = 300849, XrefRangeStart = 300825, XrefRangeEnd = 300825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsPrimitive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000755D4 File Offset: 0x000737D4
		public unsafe virtual bool IsCOMObject
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300849, RefRangeEnd = 300851, XrefRangeStart = 300849, XrefRangeEnd = 300849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsCOMObject_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00075610 File Offset: 0x00073810
		public unsafe virtual bool HasElementType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 300851, RefRangeEnd = 300855, XrefRangeStart = 300851, XrefRangeEnd = 300851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_HasElementType_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0007564C File Offset: 0x0007384C
		public unsafe virtual bool IsContextful
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 300855, RefRangeEnd = 300863, XrefRangeStart = 300855, XrefRangeEnd = 300855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsContextful_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00075688 File Offset: 0x00073888
		public unsafe virtual bool IsMarshalByRef
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300863, RefRangeEnd = 300865, XrefRangeStart = 300863, XrefRangeEnd = 300863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_get_IsMarshalByRef_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x000756C4 File Offset: 0x000738C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300865, XrefRangeEnd = 300869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValueTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0007570C File Offset: 0x0007390C
		[CallerCount(0)]
		public unsafe virtual TypeAttributes GetAttributeFlagsImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Abstract_Virtual_New_TypeAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00075754 File Offset: 0x00073954
		[CallerCount(0)]
		public unsafe virtual bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsArrayImpl_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0007579C File Offset: 0x0007399C
		[CallerCount(0)]
		public unsafe virtual bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsByRefImpl_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x000757E4 File Offset: 0x000739E4
		[CallerCount(0)]
		public unsafe virtual bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsPointerImpl_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0007582C File Offset: 0x00073A2C
		[CallerCount(0)]
		public unsafe virtual bool IsPrimitiveImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00075874 File Offset: 0x00073A74
		[CallerCount(0)]
		public unsafe virtual bool IsCOMObjectImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x000758BC File Offset: 0x00073ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300869, XrefRangeEnd = 300876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type MakeGenericType([Optional] Il2CppReferenceArray<Type> typeArguments)
		{
			if (typeArguments == null)
			{
				typeArguments = new Il2CppReferenceArray<Type>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeArguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_MakeGenericType_Public_Virtual_New_Type_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00075924 File Offset: 0x00073B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300876, XrefRangeEnd = 300883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsContextfulImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0007596C File Offset: 0x00073B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300883, XrefRangeEnd = 300890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsMarshalByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsMarshalByRefImpl_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000759B4 File Offset: 0x00073BB4
		[CallerCount(0)]
		public unsafe virtual Type GetElementType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetElementType_Public_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00075A00 File Offset: 0x00073C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300890, XrefRangeEnd = 300897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00075A4C File Offset: 0x00073C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300897, XrefRangeEnd = 300904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type GetGenericTypeDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00075A98 File Offset: 0x00073C98
		[CallerCount(0)]
		public unsafe virtual bool HasElementTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00075AE0 File Offset: 0x00073CE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 300905, RefRangeEnd = 300909, XrefRangeStart = 300904, XrefRangeEnd = 300905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetRootElementType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetRootElementType_Internal_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00075B20 File Offset: 0x00073D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300909, XrefRangeEnd = 300910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray GetEnumNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetEnumNames_Public_Virtual_New_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00075B6C File Offset: 0x00073D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300910, XrefRangeEnd = 300923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Array GetEnumValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetEnumValues_Public_Virtual_New_Array_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00075BB8 File Offset: 0x00073DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300923, XrefRangeEnd = 300924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array GetEnumRawConstantValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetEnumRawConstantValues_Private_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00075BF8 File Offset: 0x00073DF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 300946, RefRangeEnd = 300950, XrefRangeStart = 300924, XrefRangeEnd = 300946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetEnumData(out Il2CppStringArray enumNames, out Array enumValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetEnumData_Private_Void_byref_Il2CppStringArray_byref_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			enumNames = ((intPtr5 == 0) ? null : new Il2CppStringArray(intPtr5));
			IntPtr intPtr6 = intPtr2;
			enumValues = ((intPtr6 == 0) ? null : new Array(intPtr6));
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00075C6C File Offset: 0x00073E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300950, XrefRangeEnd = 300967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type GetEnumUnderlyingType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00075CB8 File Offset: 0x00073EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300967, XrefRangeEnd = 301000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsEnumDefined(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00075D10 File Offset: 0x00073F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301000, XrefRangeEnd = 301025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetEnumName(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetEnumName_Public_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00075D64 File Offset: 0x00073F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301025, XrefRangeEnd = 301045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch(Array array, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_BinarySearch_Private_Static_Int32_Array_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00075DB8 File Offset: 0x00073FB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 301096, RefRangeEnd = 301100, XrefRangeStart = 301045, XrefRangeEnd = 301096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIntegerType(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_IsIntegerType_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x00075DFC File Offset: 0x00073FFC
		public unsafe virtual Type UnderlyingSystemType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00075E48 File Offset: 0x00074048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301100, XrefRangeEnd = 301109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsSubclassOf(Type c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00075EA0 File Offset: 0x000740A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301109, XrefRangeEnd = 301110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsInstanceOfType(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00075EF8 File Offset: 0x000740F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301110, XrefRangeEnd = 301127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsAssignableFrom(Type c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00075F50 File Offset: 0x00074150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301127, XrefRangeEnd = 301130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsEquivalentTo(Type other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00075FA8 File Offset: 0x000741A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301143, RefRangeEnd = 301145, XrefRangeStart = 301130, XrefRangeEnd = 301143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImplementInterface(Type ifaceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ifaceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_ImplementInterface_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00075FF8 File Offset: 0x000741F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301145, RefRangeEnd = 301146, XrefRangeStart = 301145, XrefRangeEnd = 301145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatTypeName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_FormatTypeName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00076030 File Offset: 0x00074230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301146, XrefRangeEnd = 301151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string FormatTypeName(bool serialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serialization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_FormatTypeName_Internal_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00076080 File Offset: 0x00074280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301151, XrefRangeEnd = 301185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x000760C4 File Offset: 0x000742C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301185, XrefRangeEnd = 301188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0007611C File Offset: 0x0007431C
		[CallerCount(0)]
		public unsafe virtual bool Equals(Type o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00076174 File Offset: 0x00074374
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Type left, Type right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x000761C8 File Offset: 0x000743C8
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Type left, Type right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0007621C File Offset: 0x0007441C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301188, XrefRangeEnd = 301190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00076264 File Offset: 0x00074464
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 283525, RefRangeEnd = 283532, XrefRangeStart = 283525, XrefRangeEnd = 283532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual Type GetIl2CppType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x000762A4 File Offset: 0x000744A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301190, XrefRangeEnd = 301191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type internal_from_name(string name, bool throwOnError, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_internal_from_name_Private_Static_Type_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00076304 File Offset: 0x00074504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301191, XrefRangeEnd = 301199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetType(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetType_Public_Static_Type_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00076348 File Offset: 0x00074548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301199, XrefRangeEnd = 301207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetType(string typeName, bool throwOnError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetType_Public_Static_Type_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0007639C File Offset: 0x0007459C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301207, XrefRangeEnd = 301216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetType(string typeName, bool throwOnError, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetType_Public_Static_Type_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x000763FC File Offset: 0x000745FC
		[CallerCount(1323)]
		[CachedScanResults(RefRangeStart = 301222, RefRangeEnd = 302545, XrefRangeStart = 301216, XrefRangeEnd = 301222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetTypeFromHandle(RuntimeTypeHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_GetTypeFromHandle_Public_Static_Type_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0007643C File Offset: 0x0007463C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302545, XrefRangeEnd = 302546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type internal_from_handle(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type.NativeMethodInfoPtr_internal_from_handle_Private_Static_Type_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0000645B File Offset: 0x0000465B
		public virtual Type MakeGenericType(params Type[] typeArguments)
		{
			return this.MakeGenericType(new Il2CppReferenceArray<Type>(typeArguments));
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00006469 File Offset: 0x00004669
		public Type(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x0007647C File Offset: 0x0007467C
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x00006472 File Offset: 0x00004672
		public unsafe static MemberFilter FilterAttribute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Type.NativeFieldInfoPtr_FilterAttribute, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberFilter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Type.NativeFieldInfoPtr_FilterAttribute, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x000764A4 File Offset: 0x000746A4
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x00006484 File Offset: 0x00004684
		public unsafe static MemberFilter FilterName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Type.NativeFieldInfoPtr_FilterName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberFilter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Type.NativeFieldInfoPtr_FilterName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x000764CC File Offset: 0x000746CC
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x00006496 File Offset: 0x00004696
		public unsafe static MemberFilter FilterNameIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Type.NativeFieldInfoPtr_FilterNameIgnoreCase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberFilter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Type.NativeFieldInfoPtr_FilterNameIgnoreCase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000764F4 File Offset: 0x000746F4
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x000064A8 File Offset: 0x000046A8
		public unsafe static Object Missing
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Type.NativeFieldInfoPtr_Missing, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Type.NativeFieldInfoPtr_Missing, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x0007651C File Offset: 0x0007471C
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x000064BA File Offset: 0x000046BA
		public unsafe static char Delimiter
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Type.NativeFieldInfoPtr_Delimiter, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Type.NativeFieldInfoPtr_Delimiter, (void*)(&value));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x00076538 File Offset: 0x00074738
		// (set) Token: 0x06001213 RID: 4627 RVA: 0x000064C8 File Offset: 0x000046C8
		public unsafe static Il2CppReferenceArray<Type> EmptyTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Type.NativeFieldInfoPtr_EmptyTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Type.NativeFieldInfoPtr_EmptyTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x00076560 File Offset: 0x00074760
		// (set) Token: 0x06001215 RID: 4629 RVA: 0x000064DA File Offset: 0x000046DA
		public unsafe static Binder defaultBinder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Type.NativeFieldInfoPtr_defaultBinder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Binder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Type.NativeFieldInfoPtr_defaultBinder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x00076588 File Offset: 0x00074788
		// (set) Token: 0x06001217 RID: 4631 RVA: 0x000064EC File Offset: 0x000046EC
		public unsafe static BindingFlags DefaultLookup
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(Type.NativeFieldInfoPtr_DefaultLookup, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Type.NativeFieldInfoPtr_DefaultLookup, (void*)(&value));
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x000765A4 File Offset: 0x000747A4
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x000064FA File Offset: 0x000046FA
		public unsafe static BindingFlags DeclaredOnlyLookup
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(Type.NativeFieldInfoPtr_DeclaredOnlyLookup, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Type.NativeFieldInfoPtr_DeclaredOnlyLookup, (void*)(&value));
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x000765C0 File Offset: 0x000747C0
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x00006508 File Offset: 0x00004708
		public unsafe RuntimeTypeHandle _impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type.NativeFieldInfoPtr__impl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type.NativeFieldInfoPtr__impl)) = value;
			}
		}

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_FilterAttribute;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_FilterName;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeFieldInfoPtr_FilterNameIgnoreCase;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeFieldInfoPtr_Missing;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeFieldInfoPtr_Delimiter;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeFieldInfoPtr_EmptyTypes;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr_defaultBinder;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLookup;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeFieldInfoPtr_DeclaredOnlyLookup;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeFieldInfoPtr__impl;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_New_get_MethodBase_0;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Static_Type_String_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_MakePointerType_Public_Virtual_New_Type_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_MakeByRefType_Public_Virtual_New_Type_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_MakeArrayType_Public_Virtual_New_Type_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_MakeArrayType_Public_Virtual_New_Type_Int32_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Type_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_New_TypeCode_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultBinder_Public_Static_get_Binder_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_CreateBinder_Private_Static_Void_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMember_Public_Abstract_Virtual_New_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Abstract_Virtual_get_Module_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Abstract_Virtual_New_get_Assembly_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_New_get_RuntimeTypeHandle_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeHandle_Public_Static_RuntimeTypeHandle_Object_0;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Public_Virtual_New_Int32_0;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructor_Public_Virtual_Final_New_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructor_Public_Virtual_Final_New_ConstructorInfo_BindingFlags_Binder_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructor_Public_Virtual_Final_New_ConstructorInfo_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorImpl_Protected_Abstract_Virtual_New_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_BindingFlags_Binder_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_BindingFlags_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Virtual_Final_New_MethodInfo_String_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Abstract_Virtual_New_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Virtual_Final_New_Il2CppReferenceArray_1_MethodInfo_0;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_GetField_Public_Abstract_Virtual_New_FieldInfo_String_BindingFlags_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_GetField_Public_Virtual_Final_New_FieldInfo_String_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaces_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeMethodInfoPtr_FindInterfaces_Public_Virtual_New_Il2CppReferenceArray_1_Type_TypeFilter_Object_0;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr_GetEvent_Public_Abstract_Virtual_New_EventInfo_String_BindingFlags_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_BindingFlags_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_Type_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Virtual_Final_New_PropertyInfo_String_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyImpl_Protected_Abstract_Virtual_New_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_Final_New_Il2CppReferenceArray_1_PropertyInfo_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedType_Public_Virtual_Final_New_Type_String_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedType_Public_Abstract_Virtual_New_Type_String_BindingFlags_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Public_Virtual_Final_New_Il2CppReferenceArray_1_MemberInfo_String_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Public_Virtual_New_Il2CppReferenceArray_1_MemberInfo_String_BindingFlags_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Public_Virtual_New_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNested_Public_get_Boolean_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_Final_New_get_TypeAttributes_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_New_get_GenericParameterAttributes_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotPublic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNestedPublic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNestedAssembly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExplicitLayout_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClass_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInterface_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValueType_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstract_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSealed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnum_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSerializable_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeMethodInfoPtr_get_IsArray_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSzArray_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_get_IsByRef_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPointer_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPrimitive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCOMObject_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_get_HasElementType_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContextful_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMarshalByRef_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Abstract_Virtual_New_TypeAttributes_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericType_Public_Virtual_New_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_IsMarshalByRefImpl_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Public_Abstract_Virtual_New_Type_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_New_Type_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_HasElementTypeImpl_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_GetRootElementType_Internal_Type_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumNames_Public_Virtual_New_Il2CppStringArray_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumValues_Public_Virtual_New_Array_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumRawConstantValues_Private_Array_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumData_Private_Void_byref_Il2CppStringArray_byref_Array_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_New_Type_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumName_Public_Virtual_New_String_Object_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Private_Static_Int32_Array_Object_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_IsIntegerType_Internal_Static_Boolean_Type_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_New_Boolean_Type_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_New_Boolean_Type_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_New_Boolean_Type_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_ImplementInterface_Internal_Boolean_Type_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_FormatTypeName_Internal_String_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_FormatTypeName_Internal_Virtual_New_String_Boolean_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Type_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_internal_from_name_Private_Static_Type_String_Boolean_Boolean_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Static_Type_String_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Static_Type_String_Boolean_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Static_Type_String_Boolean_Boolean_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromHandle_Public_Static_Type_RuntimeTypeHandle_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_internal_from_handle_Private_Static_Type_IntPtr_0;
	}
}
