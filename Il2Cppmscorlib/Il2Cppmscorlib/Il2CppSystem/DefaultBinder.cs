using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000099 RID: 153
	[Serializable]
	public class DefaultBinder : Binder
	{
		// Token: 0x06000ABE RID: 2750 RVA: 0x000525A8 File Offset: 0x000507A8
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultBinder()
		{
			Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DefaultBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr);
			DefaultBinder.NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665087);
			DefaultBinder.NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665088);
			DefaultBinder.NativeMethodInfoPtr_SelectMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665089);
			DefaultBinder.NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665090);
			DefaultBinder.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665091);
			DefaultBinder.NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665092);
			DefaultBinder.NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665093);
			DefaultBinder.NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665094);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665095);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665096);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665097);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665098);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665099);
			DefaultBinder.NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665100);
			DefaultBinder.NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665101);
			DefaultBinder.NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665102);
			DefaultBinder.NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665103);
			DefaultBinder.NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665104);
			DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665105);
			DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665106);
			DefaultBinder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665107);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0005277C File Offset: 0x0005097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281356, XrefRangeEnd = 281523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodBase BindToMethod(BindingFlags bindingAttr, Il2CppReferenceArray<MethodBase> match, ref Il2CppReferenceArray<Object> args, Il2CppReferenceArray<ParameterModifier> modifiers, CultureInfo cultureInfo, Il2CppStringArray names, out Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cultureInfo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			args = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			state = ((intPtr6 == 0) ? null : new Object(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr7) : null;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0005286C File Offset: 0x00050A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281523, XrefRangeEnd = 281570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FieldInfo BindToField(BindingFlags bindingAttr, Il2CppReferenceArray<FieldInfo> match, Object value, CultureInfo cultureInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cultureInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x000528FC File Offset: 0x00050AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281570, XrefRangeEnd = 281610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodBase SelectMethod(BindingFlags bindingAttr, Il2CppReferenceArray<MethodBase> match, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_SelectMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0005298C File Offset: 0x00050B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281610, XrefRangeEnd = 281703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PropertyInfo SelectProperty(BindingFlags bindingAttr, Il2CppReferenceArray<PropertyInfo> match, Type returnType, Il2CppReferenceArray<Type> indexes, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00052A30 File Offset: 0x00050C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281703, XrefRangeEnd = 281710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Object value, Type type, CultureInfo cultureInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cultureInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00052AB0 File Offset: 0x00050CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281710, XrefRangeEnd = 281717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReorderArgumentArray(ref Il2CppReferenceArray<Object> args, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00052B24 File Offset: 0x00050D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281725, RefRangeEnd = 281726, XrefRangeStart = 281717, XrefRangeEnd = 281725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase ExactBinding(Il2CppReferenceArray<MethodBase> match, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00052B8C File Offset: 0x00050D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281726, XrefRangeEnd = 281740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo ExactPropertyBinding(Il2CppReferenceArray<PropertyInfo> match, Type returnType, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00052C08 File Offset: 0x00050E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281769, RefRangeEnd = 281770, XrefRangeStart = 281740, XrefRangeEnd = 281769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecific(Il2CppReferenceArray<ParameterInfo> p1, Il2CppStructArray<int> paramOrder1, Type paramArrayType1, Il2CppReferenceArray<ParameterInfo> p2, Il2CppStructArray<int> paramOrder2, Type paramArrayType2, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType2);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00052CCC File Offset: 0x00050ECC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281803, RefRangeEnd = 281806, XrefRangeStart = 281770, XrefRangeEnd = 281803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificType(Type c1, Type c2, Type t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00052D34 File Offset: 0x00050F34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281813, RefRangeEnd = 281815, XrefRangeStart = 281806, XrefRangeEnd = 281813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificMethod(MethodBase m1, Il2CppStructArray<int> paramOrder1, Type paramArrayType1, MethodBase m2, Il2CppStructArray<int> paramOrder2, Type paramArrayType2, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType2);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00052DF8 File Offset: 0x00050FF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281818, RefRangeEnd = 281819, XrefRangeStart = 281815, XrefRangeEnd = 281818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cur1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cur2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00052E4C File Offset: 0x0005104C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281818, RefRangeEnd = 281819, XrefRangeStart = 281818, XrefRangeEnd = 281819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cur1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cur2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00052EA0 File Offset: 0x000510A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281823, RefRangeEnd = 281824, XrefRangeStart = 281819, XrefRangeEnd = 281823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00052EF4 File Offset: 0x000510F4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 281828, RefRangeEnd = 281836, XrefRangeStart = 281824, XrefRangeEnd = 281828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHierarchyDepth(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00052F38 File Offset: 0x00051138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281837, RefRangeEnd = 281838, XrefRangeStart = 281836, XrefRangeEnd = 281837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase FindMostDerivedNewSlotMeth(Il2CppReferenceArray<MethodBase> match, int cMatches)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMatches;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00052F8C File Offset: 0x0005118C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281845, RefRangeEnd = 281847, XrefRangeStart = 281838, XrefRangeEnd = 281845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReorderParams(Il2CppStructArray<int> paramOrder, Il2CppReferenceArray<Object> vars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paramOrder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00052FD4 File Offset: 0x000511D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281855, RefRangeEnd = 281856, XrefRangeStart = 281847, XrefRangeEnd = 281855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateParamOrder(Il2CppStructArray<int> paramOrder, Il2CppReferenceArray<ParameterInfo> pars, Il2CppStringArray names)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paramOrder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pars);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0005303C File Offset: 0x0005123C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 281866, RefRangeEnd = 281873, XrefRangeStart = 281856, XrefRangeEnd = 281866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanConvertPrimitive(RuntimeType source, RuntimeType target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00053090 File Offset: 0x00051290
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281882, RefRangeEnd = 281885, XrefRangeStart = 281873, XrefRangeEnd = 281882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanConvertPrimitiveObjectToType(Object source, RuntimeType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x000530E4 File Offset: 0x000512E4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultBinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00004D45 File Offset: 0x00002F45
		public DefaultBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_SelectMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200058D RID: 1421
		public class BinderState : Object
		{
			// Token: 0x06004EDB RID: 20187 RVA: 0x001635B0 File Offset: 0x001617B0
			// Note: this type is marked as 'beforefieldinit'.
			static BinderState()
			{
				Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, "BinderState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr);
				DefaultBinder.BinderState.NativeFieldInfoPtr_m_argsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, "m_argsMap");
				DefaultBinder.BinderState.NativeFieldInfoPtr_m_originalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, "m_originalSize");
				DefaultBinder.BinderState.NativeFieldInfoPtr_m_isParamArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, "m_isParamArray");
				DefaultBinder.BinderState.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, 100665108);
			}

			// Token: 0x06004EDC RID: 20188 RVA: 0x0016362C File Offset: 0x0016182C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 281351, RefRangeEnd = 281352, XrefRangeStart = 281350, XrefRangeEnd = 281351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BinderState(Il2CppStructArray<int> argsMap, int originalSize, bool isParamArray)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(argsMap);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalSize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isParamArray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.BinderState.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EDD RID: 20189 RVA: 0x0001DCB6 File Offset: 0x0001BEB6
			public BinderState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001406 RID: 5126
			// (get) Token: 0x06004EDE RID: 20190 RVA: 0x00163694 File Offset: 0x00161894
			// (set) Token: 0x06004EDF RID: 20191 RVA: 0x0001DCBF File Offset: 0x0001BEBF
			public unsafe Il2CppStructArray<int> m_argsMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_argsMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_argsMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001407 RID: 5127
			// (get) Token: 0x06004EE0 RID: 20192 RVA: 0x001636C4 File Offset: 0x001618C4
			// (set) Token: 0x06004EE1 RID: 20193 RVA: 0x0001DCDE File Offset: 0x0001BEDE
			public unsafe int m_originalSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_originalSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_originalSize)) = value;
				}
			}

			// Token: 0x17001408 RID: 5128
			// (get) Token: 0x06004EE2 RID: 20194 RVA: 0x001636EC File Offset: 0x001618EC
			// (set) Token: 0x06004EE3 RID: 20195 RVA: 0x0001DCF9 File Offset: 0x0001BEF9
			public unsafe bool m_isParamArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_isParamArray);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_isParamArray)) = value;
				}
			}

			// Token: 0x04003FA2 RID: 16290
			private static readonly IntPtr NativeFieldInfoPtr_m_argsMap;

			// Token: 0x04003FA3 RID: 16291
			private static readonly IntPtr NativeFieldInfoPtr_m_originalSize;

			// Token: 0x04003FA4 RID: 16292
			private static readonly IntPtr NativeFieldInfoPtr_m_isParamArray;

			// Token: 0x04003FA5 RID: 16293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0;
		}

		// Token: 0x0200058E RID: 1422
		[ObfuscatedName("System.DefaultBinder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004EE4 RID: 20196 RVA: 0x00163714 File Offset: 0x00161914
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr);
				DefaultBinder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, "<>9");
				DefaultBinder.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, "<>9__3_0");
				DefaultBinder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, 100665110);
				DefaultBinder.__c.NativeMethodInfoPtr__SelectProperty_b__3_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, 100665111);
			}

			// Token: 0x06004EE5 RID: 20197 RVA: 0x00163790 File Offset: 0x00161990
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EE6 RID: 20198 RVA: 0x001637CC File Offset: 0x001619CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281352, XrefRangeEnd = 281356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectProperty_b__3_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.__c.NativeMethodInfoPtr__SelectProperty_b__3_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004EE7 RID: 20199 RVA: 0x0001DD14 File Offset: 0x0001BF14
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001409 RID: 5129
			// (get) Token: 0x06004EE8 RID: 20200 RVA: 0x0016381C File Offset: 0x00161A1C
			// (set) Token: 0x06004EE9 RID: 20201 RVA: 0x0001DD1D File Offset: 0x0001BF1D
			public unsafe static DefaultBinder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultBinder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultBinder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultBinder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700140A RID: 5130
			// (get) Token: 0x06004EEA RID: 20202 RVA: 0x00163844 File Offset: 0x00161A44
			// (set) Token: 0x06004EEB RID: 20203 RVA: 0x0001DD2F File Offset: 0x0001BF2F
			public unsafe static Predicate<Type> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultBinder.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultBinder.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FA6 RID: 16294
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003FA7 RID: 16295
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04003FA8 RID: 16296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003FA9 RID: 16297
			private static readonly IntPtr NativeMethodInfoPtr__SelectProperty_b__3_0_Internal_Boolean_Type_0;
		}
	}
}
