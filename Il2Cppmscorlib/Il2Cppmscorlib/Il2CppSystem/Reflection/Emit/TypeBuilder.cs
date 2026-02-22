using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x020001F2 RID: 498
	public class TypeBuilder : TypeInfo
	{
		// Token: 0x06001FCC RID: 8140 RVA: 0x000B1320 File Offset: 0x000AF520
		// Note: this type is marked as 'beforefieldinit'.
		static TypeBuilder()
		{
			Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "TypeBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr);
			TypeBuilder.NativeFieldInfoPtr_UnspecifiedTypeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, "UnspecifiedTypeSize");
			TypeBuilder.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668580);
			TypeBuilder.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668581);
			TypeBuilder.NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668582);
			TypeBuilder.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668583);
			TypeBuilder.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668584);
			TypeBuilder.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668585);
			TypeBuilder.NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668586);
			TypeBuilder.NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668587);
			TypeBuilder.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668588);
			TypeBuilder.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668589);
			TypeBuilder.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668590);
			TypeBuilder.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668591);
			TypeBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668592);
			TypeBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668593);
			TypeBuilder.NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668594);
			TypeBuilder.NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668595);
			TypeBuilder.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668596);
			TypeBuilder.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668597);
			TypeBuilder.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668598);
			TypeBuilder.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668599);
			TypeBuilder.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668600);
			TypeBuilder.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668601);
			TypeBuilder.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668602);
			TypeBuilder.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668603);
			TypeBuilder.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668604);
			TypeBuilder.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668605);
			TypeBuilder.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668606);
			TypeBuilder.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668607);
			TypeBuilder.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668608);
			TypeBuilder.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668609);
			TypeBuilder.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilder>.NativeClassPtr, 100668610);
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x000B15D0 File Offset: 0x000AF7D0
		public unsafe override Assembly Assembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319635, XrefRangeEnd = 319640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x000B161C File Offset: 0x000AF81C
		public unsafe override string AssemblyQualifiedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319640, XrefRangeEnd = 319645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x000B1660 File Offset: 0x000AF860
		public unsafe override Type BaseType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319645, XrefRangeEnd = 319650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x000B16AC File Offset: 0x000AF8AC
		public unsafe override string FullName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319650, XrefRangeEnd = 319655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x000B16F0 File Offset: 0x000AF8F0
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319655, XrefRangeEnd = 319660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x000B173C File Offset: 0x000AF93C
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319660, XrefRangeEnd = 319665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x000B1780 File Offset: 0x000AF980
		public unsafe override string Namespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319665, XrefRangeEnd = 319670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x000B17C4 File Offset: 0x000AF9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319670, XrefRangeEnd = 319675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetElementType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x000B1810 File Offset: 0x000AFA10
		public unsafe override Type UnderlyingSystemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319675, XrefRangeEnd = 319678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x000B185C File Offset: 0x000AFA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319678, XrefRangeEnd = 319681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeAttributes GetAttributeFlagsImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x000B18A4 File Offset: 0x000AFAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319681, XrefRangeEnd = 319684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x000B1944 File Offset: 0x000AFB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319684, XrefRangeEnd = 319687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ConstructorInfo> GetConstructors(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstructorInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x000B199C File Offset: 0x000AFB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319687, XrefRangeEnd = 319690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x000B19F4 File Offset: 0x000AFBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319690, XrefRangeEnd = 319693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x000B1A60 File Offset: 0x000AFC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319693, XrefRangeEnd = 319696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x000B1ACC File Offset: 0x000AFCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319696, XrefRangeEnd = 319699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x000B1B38 File Offset: 0x000AFD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319699, XrefRangeEnd = 319702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<FieldInfo> GetFields(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x000B1B90 File Offset: 0x000AFD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319702, XrefRangeEnd = 319705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetInterfaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x000B1BDC File Offset: 0x000AFDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319705, XrefRangeEnd = 319708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x000B1C8C File Offset: 0x000AFE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319708, XrefRangeEnd = 319711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MethodInfo> GetMethods(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x000B1CE4 File Offset: 0x000AFEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319711, XrefRangeEnd = 319714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x000B1D50 File Offset: 0x000AFF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319714, XrefRangeEnd = 319717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<PropertyInfo> GetProperties(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x000B1DA8 File Offset: 0x000AFFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319717, XrefRangeEnd = 319720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x000B1E5C File Offset: 0x000B005C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319720, XrefRangeEnd = 319723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasElementTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x000B1EA4 File Offset: 0x000B00A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319723, XrefRangeEnd = 319726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x000B1F80 File Offset: 0x000B0180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319726, XrefRangeEnd = 319729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x000B1FC8 File Offset: 0x000B01C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319729, XrefRangeEnd = 319732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x000B2010 File Offset: 0x000B0210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319732, XrefRangeEnd = 319735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsCOMObjectImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x000B2058 File Offset: 0x000B0258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319735, XrefRangeEnd = 319738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x000B20C0 File Offset: 0x000B02C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319738, XrefRangeEnd = 319741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x000B2108 File Offset: 0x000B0308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319741, XrefRangeEnd = 319744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPrimitiveImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeBuilder.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0000ACF7 File Offset: 0x00008EF7
		public TypeBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x000B2150 File Offset: 0x000B0350
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x0000AD00 File Offset: 0x00008F00
		public unsafe static int UnspecifiedTypeSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TypeBuilder.NativeFieldInfoPtr_UnspecifiedTypeSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeBuilder.NativeFieldInfoPtr_UnspecifiedTypeSize, (void*)(&value));
			}
		}

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeFieldInfoPtr_UnspecifiedTypeSize;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0;
	}
}
