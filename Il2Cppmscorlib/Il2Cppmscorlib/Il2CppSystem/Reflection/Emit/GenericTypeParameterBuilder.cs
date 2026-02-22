using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x020001EA RID: 490
	public class GenericTypeParameterBuilder : TypeInfo
	{
		// Token: 0x06001F7A RID: 8058 RVA: 0x000AF7C4 File Offset: 0x000AD9C4
		// Note: this type is marked as 'beforefieldinit'.
		static GenericTypeParameterBuilder()
		{
			Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "GenericTypeParameterBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668522);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668523);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668524);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668525);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668526);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668527);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668528);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668529);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668530);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668531);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668532);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668533);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668534);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668535);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668536);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668537);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668538);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668539);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668540);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668541);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668542);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668543);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668544);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668545);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668546);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668547);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668548);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668549);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668550);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668551);
			GenericTypeParameterBuilder.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTypeParameterBuilder>.NativeClassPtr, 100668552);
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x000AFA60 File Offset: 0x000ADC60
		public unsafe override Assembly Assembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319423, XrefRangeEnd = 319428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x000AFAAC File Offset: 0x000ADCAC
		public unsafe override string AssemblyQualifiedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319428, XrefRangeEnd = 319433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x000AFAF0 File Offset: 0x000ADCF0
		public unsafe override Type BaseType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319433, XrefRangeEnd = 319438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x000AFB3C File Offset: 0x000ADD3C
		public unsafe override string FullName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319438, XrefRangeEnd = 319443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x000AFB80 File Offset: 0x000ADD80
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319443, XrefRangeEnd = 319448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x000AFBCC File Offset: 0x000ADDCC
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319448, XrefRangeEnd = 319453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x000AFC10 File Offset: 0x000ADE10
		public unsafe override string Namespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319453, XrefRangeEnd = 319458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x000AFC54 File Offset: 0x000ADE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319458, XrefRangeEnd = 319463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetElementType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x000AFCA0 File Offset: 0x000ADEA0
		public unsafe override Type UnderlyingSystemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319463, XrefRangeEnd = 319466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x000AFCEC File Offset: 0x000ADEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319466, XrefRangeEnd = 319469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeAttributes GetAttributeFlagsImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x000AFD34 File Offset: 0x000ADF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319469, XrefRangeEnd = 319472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x000AFDD4 File Offset: 0x000ADFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319472, XrefRangeEnd = 319475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ConstructorInfo> GetConstructors(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstructorInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x000AFE2C File Offset: 0x000AE02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319475, XrefRangeEnd = 319478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x000AFE84 File Offset: 0x000AE084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319478, XrefRangeEnd = 319481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x000AFEF0 File Offset: 0x000AE0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319481, XrefRangeEnd = 319484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x000AFF5C File Offset: 0x000AE15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319484, XrefRangeEnd = 319487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x000AFFC8 File Offset: 0x000AE1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319487, XrefRangeEnd = 319490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<FieldInfo> GetFields(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000B0020 File Offset: 0x000AE220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319490, XrefRangeEnd = 319493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetInterfaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000B006C File Offset: 0x000AE26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319493, XrefRangeEnd = 319496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x000B011C File Offset: 0x000AE31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319496, XrefRangeEnd = 319499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MethodInfo> GetMethods(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x000B0174 File Offset: 0x000AE374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319499, XrefRangeEnd = 319502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x000B01E0 File Offset: 0x000AE3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319502, XrefRangeEnd = 319505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<PropertyInfo> GetProperties(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x000B0238 File Offset: 0x000AE438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319505, XrefRangeEnd = 319508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x000B02EC File Offset: 0x000AE4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319508, XrefRangeEnd = 319511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasElementTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000B0334 File Offset: 0x000AE534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319511, XrefRangeEnd = 319514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x000B0410 File Offset: 0x000AE610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319514, XrefRangeEnd = 319517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000B0458 File Offset: 0x000AE658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319517, XrefRangeEnd = 319520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000B04A0 File Offset: 0x000AE6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319520, XrefRangeEnd = 319523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsCOMObjectImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000B04E8 File Offset: 0x000AE6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319523, XrefRangeEnd = 319526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x000B0550 File Offset: 0x000AE750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319526, XrefRangeEnd = 319529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000B0598 File Offset: 0x000AE798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319529, XrefRangeEnd = 319532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPrimitiveImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericTypeParameterBuilder.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x0000ABA7 File Offset: 0x00008DA7
		public GenericTypeParameterBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0;
	}
}
