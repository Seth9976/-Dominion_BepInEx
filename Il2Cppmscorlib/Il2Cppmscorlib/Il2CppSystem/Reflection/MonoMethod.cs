using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001D6 RID: 470
	[Serializable]
	public class MonoMethod : RuntimeMethodInfo
	{
		// Token: 0x06001E39 RID: 7737 RVA: 0x000A9214 File Offset: 0x000A7414
		// Note: this type is marked as 'beforefieldinit'.
		static MonoMethod()
		{
			Il2CppClassPointerStore<MonoMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr);
			MonoMethod.NativeFieldInfoPtr_mhandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, "mhandle");
			MonoMethod.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, "name");
			MonoMethod.NativeFieldInfoPtr_reftype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, "reftype");
			MonoMethod.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668291);
			MonoMethod.NativeMethodInfoPtr_get_name_Internal_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668292);
			MonoMethod.NativeMethodInfoPtr_get_base_method_Internal_Static_MonoMethod_MonoMethod_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668293);
			MonoMethod.NativeMethodInfoPtr_GetBaseMethod_Internal_Virtual_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668294);
			MonoMethod.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668295);
			MonoMethod.NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Virtual_MethodImplAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668296);
			MonoMethod.NativeMethodInfoPtr_GetParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668297);
			MonoMethod.NativeMethodInfoPtr_GetParametersInternal_Internal_Virtual_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668298);
			MonoMethod.NativeMethodInfoPtr_GetParametersCount_Internal_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668299);
			MonoMethod.NativeMethodInfoPtr_InternalInvoke_Internal_Object_Object_Il2CppReferenceArray_1_Object_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668300);
			MonoMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668301);
			MonoMethod.NativeMethodInfoPtr_ConvertValues_Internal_Static_Void_Binder_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterInfo_CultureInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668302);
			MonoMethod.NativeMethodInfoPtr_get_MethodHandle_Public_Virtual_get_RuntimeMethodHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668303);
			MonoMethod.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_MethodAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668304);
			MonoMethod.NativeMethodInfoPtr_get_CallingConvention_Public_Virtual_get_CallingConventions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668305);
			MonoMethod.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668306);
			MonoMethod.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668307);
			MonoMethod.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668308);
			MonoMethod.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668309);
			MonoMethod.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668310);
			MonoMethod.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668311);
			MonoMethod.NativeMethodInfoPtr_GetPInvoke_Internal_Void_byref_PInvokeAttributes_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668312);
			MonoMethod.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668313);
			MonoMethod.NativeMethodInfoPtr_MakeGenericMethod_Public_Virtual_MethodInfo_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668314);
			MonoMethod.NativeMethodInfoPtr_MakeGenericMethod_impl_Private_MethodInfo_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668315);
			MonoMethod.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668316);
			MonoMethod.NativeMethodInfoPtr_GetGenericMethodDefinition_impl_Private_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668317);
			MonoMethod.NativeMethodInfoPtr_GetGenericMethodDefinition_Public_Virtual_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668318);
			MonoMethod.NativeMethodInfoPtr_get_IsGenericMethodDefinition_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668319);
			MonoMethod.NativeMethodInfoPtr_get_IsGenericMethod_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668320);
			MonoMethod.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668321);
			MonoMethod.NativeMethodInfoPtr_GetMethodBody_Public_Virtual_MethodBody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668322);
			MonoMethod.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668323);
			MonoMethod.NativeMethodInfoPtr_get_core_clr_security_level_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668324);
			MonoMethod.NativeMethodInfoPtr_get_IsSecurityCritical_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr, 100668325);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x000A953C File Offset: 0x000A773C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoMethod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethod.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x000A9578 File Offset: 0x000A7778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318657, XrefRangeEnd = 318658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string get_name(MethodBase method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethod.NativeMethodInfoPtr_get_name_Internal_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x000A95B4 File Offset: 0x000A77B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318658, XrefRangeEnd = 318659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoMethod get_base_method(MonoMethod method, bool definition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref definition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethod.NativeMethodInfoPtr_get_base_method_Internal_Static_MonoMethod_MonoMethod_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoMethod>(intPtr3) : null;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000A9608 File Offset: 0x000A7808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318659, XrefRangeEnd = 318660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetBaseMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetBaseMethod_Internal_Virtual_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x000A9654 File Offset: 0x000A7854
		public unsafe override Type ReturnType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318660, XrefRangeEnd = 318661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x000A96A0 File Offset: 0x000A78A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318661, XrefRangeEnd = 318662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodImplAttributes GetMethodImplementationFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Virtual_MethodImplAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x000A96E8 File Offset: 0x000A78E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318662, XrefRangeEnd = 318667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ParameterInfo> GetParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x000A9734 File Offset: 0x000A7934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318667, XrefRangeEnd = 318668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ParameterInfo> GetParametersInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetParametersInternal_Internal_Virtual_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x000A9780 File Offset: 0x000A7980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318668, XrefRangeEnd = 318669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetParametersCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetParametersCount_Internal_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x000A97C8 File Offset: 0x000A79C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318670, RefRangeEnd = 318671, XrefRangeStart = 318669, XrefRangeEnd = 318670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalInvoke(Object obj, Il2CppReferenceArray<Object> parameters, out Exception exc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoMethod.NativeMethodInfoPtr_InternalInvoke_Internal_Object_Object_Il2CppReferenceArray_1_Object_byref_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			exc = ((intPtr4 == 0) ? null : new Exception(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x000A9850 File Offset: 0x000A7A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318671, XrefRangeEnd = 318677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> parameters, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x000A98F4 File Offset: 0x000A7AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318692, RefRangeEnd = 318694, XrefRangeStart = 318677, XrefRangeEnd = 318692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertValues(Binder binder, Il2CppReferenceArray<Object> args, Il2CppReferenceArray<ParameterInfo> pinfo, CultureInfo culture, BindingFlags invokeAttr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pinfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethod.NativeMethodInfoPtr_ConvertValues_Internal_Static_Void_Binder_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterInfo_CultureInfo_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x000A9970 File Offset: 0x000A7B70
		public unsafe override RuntimeMethodHandle MethodHandle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_MethodHandle_Public_Virtual_get_RuntimeMethodHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x000A99B8 File Offset: 0x000A7BB8
		public unsafe override MethodAttributes Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318694, XrefRangeEnd = 318695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_MethodAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x000A9A00 File Offset: 0x000A7C00
		public unsafe override CallingConventions CallingConvention
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318695, XrefRangeEnd = 318696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_CallingConvention_Public_Virtual_get_CallingConventions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x000A9A48 File Offset: 0x000A7C48
		public unsafe override Type ReflectedType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x000A9A94 File Offset: 0x000A7C94
		public unsafe override Type DeclaringType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318696, XrefRangeEnd = 318697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x000A9AE0 File Offset: 0x000A7CE0
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000A9B24 File Offset: 0x000A7D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318697, XrefRangeEnd = 318701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x000A9B8C File Offset: 0x000A7D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318701, XrefRangeEnd = 318705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x000A9BE4 File Offset: 0x000A7DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318705, XrefRangeEnd = 318709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000A9C50 File Offset: 0x000A7E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318710, RefRangeEnd = 318711, XrefRangeStart = 318709, XrefRangeEnd = 318710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &flags;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MonoMethod.NativeMethodInfoPtr_GetPInvoke_Internal_Void_byref_PInvokeAttributes_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			entryPoint = IL2CPP.Il2CppStringToManaged(intPtr);
			dllName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000A9CC4 File Offset: 0x000A7EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318723, RefRangeEnd = 318724, XrefRangeStart = 318711, XrefRangeEnd = 318723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetPseudoCustomAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethod.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x000A9D04 File Offset: 0x000A7F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318724, XrefRangeEnd = 318733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo MakeGenericMethod([Optional] Il2CppReferenceArray<Type> methodInstantiation)
		{
			if (methodInstantiation == null)
			{
				methodInstantiation = new Il2CppReferenceArray<Type>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodInstantiation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_MakeGenericMethod_Public_Virtual_MethodInfo_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x000A9D6C File Offset: 0x000A7F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318733, XrefRangeEnd = 318734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo MakeGenericMethod_impl(Il2CppReferenceArray<Type> types)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethod.NativeMethodInfoPtr_MakeGenericMethod_impl_Private_MethodInfo_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000A9DBC File Offset: 0x000A7FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318734, XrefRangeEnd = 318735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000A9E08 File Offset: 0x000A8008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318735, XrefRangeEnd = 318736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo GetGenericMethodDefinition_impl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethod.NativeMethodInfoPtr_GetGenericMethodDefinition_impl_Private_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000A9E48 File Offset: 0x000A8048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318736, XrefRangeEnd = 318738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetGenericMethodDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetGenericMethodDefinition_Public_Virtual_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x000A9E94 File Offset: 0x000A8094
		public unsafe override bool IsGenericMethodDefinition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318738, XrefRangeEnd = 318739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_IsGenericMethodDefinition_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x000A9EDC File Offset: 0x000A80DC
		public unsafe override bool IsGenericMethod
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318739, XrefRangeEnd = 318740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_IsGenericMethod_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x000A9F24 File Offset: 0x000A8124
		public unsafe override bool ContainsGenericParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318740, XrefRangeEnd = 318741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x000A9F6C File Offset: 0x000A816C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318741, XrefRangeEnd = 318742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodBody GetMethodBody()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetMethodBody_Public_Virtual_MethodBody_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBody>(intPtr3) : null;
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x000A9FB8 File Offset: 0x000A81B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IList<CustomAttributeData> GetCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x000AA004 File Offset: 0x000A8204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int get_core_clr_security_level()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethod.NativeMethodInfoPtr_get_core_clr_security_level_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x000AA034 File Offset: 0x000A8234
		public unsafe override bool IsSecurityCritical
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoMethod.NativeMethodInfoPtr_get_IsSecurityCritical_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0000A6AC File Offset: 0x000088AC
		public override MethodInfo MakeGenericMethod(params Type[] methodInstantiation)
		{
			return this.MakeGenericMethod(new Il2CppReferenceArray<Type>(methodInstantiation));
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0000A6BA File Offset: 0x000088BA
		public MonoMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x000AA07C File Offset: 0x000A827C
		// (set) Token: 0x06001E60 RID: 7776 RVA: 0x0000A6C3 File Offset: 0x000088C3
		public unsafe IntPtr mhandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethod.NativeFieldInfoPtr_mhandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethod.NativeFieldInfoPtr_mhandle)) = value;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x000AA0A4 File Offset: 0x000A82A4
		// (set) Token: 0x06001E62 RID: 7778 RVA: 0x0000A6DE File Offset: 0x000088DE
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethod.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethod.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x000AA0CC File Offset: 0x000A82CC
		// (set) Token: 0x06001E64 RID: 7780 RVA: 0x0000A6FD File Offset: 0x000088FD
		public unsafe Type reftype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethod.NativeFieldInfoPtr_reftype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethod.NativeFieldInfoPtr_reftype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeFieldInfoPtr_mhandle;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeFieldInfoPtr_reftype;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Internal_Static_String_MethodBase_0;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_get_base_method_Internal_Static_MonoMethod_MonoMethod_Boolean_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseMethod_Internal_Virtual_MethodInfo_0;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_Type_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Virtual_MethodImplAttributes_0;

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeMethodInfoPtr_GetParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersInternal_Internal_Virtual_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersCount_Internal_Virtual_Int32_0;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeMethodInfoPtr_InternalInvoke_Internal_Object_Object_Il2CppReferenceArray_1_Object_byref_Exception_0;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValues_Internal_Static_Void_Binder_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterInfo_CultureInfo_BindingFlags_0;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodHandle_Public_Virtual_get_RuntimeMethodHandle_0;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_MethodAttributes_0;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_get_CallingConvention_Public_Virtual_get_CallingConventions_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeMethodInfoPtr_GetPInvoke_Internal_Void_byref_PInvokeAttributes_byref_String_byref_String_0;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericMethod_Public_Virtual_MethodInfo_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericMethod_impl_Private_MethodInfo_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericMethodDefinition_impl_Private_MethodInfo_0;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericMethodDefinition_Public_Virtual_MethodInfo_0;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericMethodDefinition_Public_Virtual_get_Boolean_0;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericMethod_Public_Virtual_get_Boolean_0;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_get_Boolean_0;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodBody_Public_Virtual_MethodBody_0;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr_get_core_clr_security_level_Private_Static_Int32_0;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSecurityCritical_Public_Virtual_get_Boolean_0;
	}
}
