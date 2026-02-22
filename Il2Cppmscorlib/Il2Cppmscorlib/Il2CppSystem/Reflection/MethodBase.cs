using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001AF RID: 431
	[Serializable]
	public class MethodBase : MemberInfo
	{
		// Token: 0x06001BF1 RID: 7153 RVA: 0x0009F8D8 File Offset: 0x0009DAD8
		// Note: this type is marked as 'beforefieldinit'.
		static MethodBase()
		{
			Il2CppClassPointerStore<MethodBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MethodBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodBase>.NativeClassPtr);
			MethodBase.NativeMethodInfoPtr_GetMethodFromHandle_Public_Static_MethodBase_RuntimeMethodHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667953);
			MethodBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667954);
			MethodBase.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodBase_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667955);
			MethodBase.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodBase_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667956);
			MethodBase.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667957);
			MethodBase.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667958);
			MethodBase.NativeMethodInfoPtr_GetParametersNoCopy_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667959);
			MethodBase.NativeMethodInfoPtr_GetParameters_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667960);
			MethodBase.NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Abstract_Virtual_New_MethodImplAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667961);
			MethodBase.NativeMethodInfoPtr_get_MethodHandle_Public_Abstract_Virtual_New_get_RuntimeMethodHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667962);
			MethodBase.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_MethodAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667963);
			MethodBase.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667964);
			MethodBase.NativeMethodInfoPtr_get_CallingConvention_Public_Virtual_New_get_CallingConventions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667965);
			MethodBase.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667966);
			MethodBase.NativeMethodInfoPtr_get_IsGenericMethodDefinition_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667967);
			MethodBase.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667968);
			MethodBase.NativeMethodInfoPtr_get_IsGenericMethod_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667969);
			MethodBase.NativeMethodInfoPtr_get_IsSecurityCritical_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667970);
			MethodBase.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Object_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667971);
			MethodBase.NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667972);
			MethodBase.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667973);
			MethodBase.NativeMethodInfoPtr_get_IsVirtual_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667974);
			MethodBase.NativeMethodInfoPtr_get_IsAbstract_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667975);
			MethodBase.NativeMethodInfoPtr_get_IsConstructor_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667976);
			MethodBase.NativeMethodInfoPtr_GetMethodBody_Public_Virtual_New_MethodBody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667977);
			MethodBase.NativeMethodInfoPtr_ConstructParameters_Internal_Static_String_Il2CppReferenceArray_1_Type_CallingConventions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667978);
			MethodBase.NativeMethodInfoPtr_FormatNameAndSig_Internal_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667979);
			MethodBase.NativeMethodInfoPtr_GetParameterTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667980);
			MethodBase.NativeMethodInfoPtr_GetParametersInternal_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667981);
			MethodBase.NativeMethodInfoPtr_GetParametersCount_Internal_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667982);
			MethodBase.NativeMethodInfoPtr_GetMethodFromHandleNoGenericCheck_Internal_Static_MethodBase_RuntimeMethodHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667983);
			MethodBase.NativeMethodInfoPtr_GetMethodFromHandleNoGenericCheck_Internal_Static_MethodBase_RuntimeMethodHandle_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667984);
			MethodBase.NativeMethodInfoPtr_GetMethodBodyInternal_Internal_Static_MethodBody_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667985);
			MethodBase.NativeMethodInfoPtr_GetMethodBody_Internal_Static_MethodBody_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667986);
			MethodBase.NativeMethodInfoPtr_GetMethodFromHandleInternalType_Private_Static_MethodBase_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667987);
			MethodBase.NativeMethodInfoPtr_GetMethodFromHandleInternalType_native_Internal_Static_MethodBase_IntPtr_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100667988);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0009FBD8 File Offset: 0x0009DDD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317029, RefRangeEnd = 317030, XrefRangeStart = 317020, XrefRangeEnd = 317029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_GetMethodFromHandle_Public_Static_MethodBase_RuntimeMethodHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0009FC18 File Offset: 0x0009DE18
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0009FC54 File Offset: 0x0009DE54
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 317039, RefRangeEnd = 317051, XrefRangeStart = 317030, XrefRangeEnd = 317039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(MethodBase left, MethodBase right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodBase_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0009FCA8 File Offset: 0x0009DEA8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 317052, RefRangeEnd = 317063, XrefRangeStart = 317051, XrefRangeEnd = 317052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(MethodBase left, MethodBase right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodBase_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0009FCFC File Offset: 0x0009DEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317063, XrefRangeEnd = 317064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0009FD54 File Offset: 0x0009DF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317065, RefRangeEnd = 317066, XrefRangeStart = 317064, XrefRangeEnd = 317065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0009FD9C File Offset: 0x0009DF9C
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ParameterInfo> GetParametersNoCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetParametersNoCopy_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0009FDE8 File Offset: 0x0009DFE8
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ParameterInfo> GetParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetParameters_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0009FE34 File Offset: 0x0009E034
		[CallerCount(0)]
		public unsafe virtual MethodImplAttributes GetMethodImplementationFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Abstract_Virtual_New_MethodImplAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x0009FE7C File Offset: 0x0009E07C
		public unsafe virtual RuntimeMethodHandle MethodHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_MethodHandle_Public_Abstract_Virtual_New_get_RuntimeMethodHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x0009FEC4 File Offset: 0x0009E0C4
		public unsafe virtual MethodAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_MethodAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0009FF0C File Offset: 0x0009E10C
		[CallerCount(0)]
		public unsafe virtual Object Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> parameters, CultureInfo culture)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x0009FFB0 File Offset: 0x0009E1B0
		public unsafe virtual CallingConventions CallingConvention
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_CallingConvention_Public_Virtual_New_get_CallingConventions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0009FFF8 File Offset: 0x0009E1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317066, XrefRangeEnd = 317073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x000A0044 File Offset: 0x0009E244
		public unsafe virtual bool IsGenericMethodDefinition
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_IsGenericMethodDefinition_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x000A008C File Offset: 0x0009E28C
		public unsafe virtual bool ContainsGenericParameters
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000A00D4 File Offset: 0x0009E2D4
		public unsafe virtual bool IsGenericMethod
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_IsGenericMethod_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x000A011C File Offset: 0x0009E31C
		public unsafe virtual bool IsSecurityCritical
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317073, XrefRangeEnd = 317078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_IsSecurityCritical_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000A0164 File Offset: 0x0009E364
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 317078, RefRangeEnd = 317094, XrefRangeStart = 317078, XrefRangeEnd = 317078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Invoke(Object obj, Il2CppReferenceArray<Object> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Object_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x000A01C8 File Offset: 0x0009E3C8
		public unsafe virtual bool IsPublic
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 317094, RefRangeEnd = 317096, XrefRangeStart = 317094, XrefRangeEnd = 317094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x000A0204 File Offset: 0x0009E404
		public unsafe virtual bool IsStatic
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 317096, RefRangeEnd = 317103, XrefRangeStart = 317096, XrefRangeEnd = 317096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x000A0240 File Offset: 0x0009E440
		public unsafe virtual bool IsVirtual
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsVirtual_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000A027C File Offset: 0x0009E47C
		public unsafe virtual bool IsAbstract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsAbstract_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x000A02B8 File Offset: 0x0009E4B8
		public unsafe virtual bool IsConstructor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 317105, RefRangeEnd = 317107, XrefRangeStart = 317103, XrefRangeEnd = 317105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsConstructor_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x000A02F4 File Offset: 0x0009E4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317107, XrefRangeEnd = 317112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodBody GetMethodBody()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetMethodBody_Public_Virtual_New_MethodBody_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBody>(intPtr3) : null;
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000A0340 File Offset: 0x0009E540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317141, RefRangeEnd = 317142, XrefRangeStart = 317112, XrefRangeEnd = 317141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConstructParameters(Il2CppReferenceArray<Type> parameterTypes, CallingConventions callingConvention, bool serialization)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameterTypes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callingConvention;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serialization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_ConstructParameters_Internal_Static_String_Il2CppReferenceArray_1_Type_CallingConventions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x000A0398 File Offset: 0x0009E598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317142, XrefRangeEnd = 317155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string FormatNameAndSig(bool serialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serialization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_FormatNameAndSig_Internal_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x000A03E8 File Offset: 0x0009E5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317155, XrefRangeEnd = 317160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetParameterTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetParameterTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000A0434 File Offset: 0x0009E634
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ParameterInfo> GetParametersInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetParametersInternal_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000A0480 File Offset: 0x0009E680
		[CallerCount(0)]
		public unsafe virtual int GetParametersCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetParametersCount_Internal_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000A04C8 File Offset: 0x0009E6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317160, XrefRangeEnd = 317162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_GetMethodFromHandleNoGenericCheck_Internal_Static_MethodBase_RuntimeMethodHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000A0508 File Offset: 0x0009E708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317163, RefRangeEnd = 317165, XrefRangeStart = 317162, XrefRangeEnd = 317163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectedType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_GetMethodFromHandleNoGenericCheck_Internal_Static_MethodBase_RuntimeMethodHandle_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x000A0558 File Offset: 0x0009E758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317165, XrefRangeEnd = 317166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBody GetMethodBodyInternal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_GetMethodBodyInternal_Internal_Static_MethodBody_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBody>(intPtr3) : null;
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000A0598 File Offset: 0x0009E798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBody GetMethodBody(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_GetMethodBody_Internal_Static_MethodBody_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBody>(intPtr3) : null;
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000A05D8 File Offset: 0x0009E7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317166, XrefRangeEnd = 317167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref method_handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type_handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_GetMethodFromHandleInternalType_Private_Static_MethodBase_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000A0628 File Offset: 0x0009E828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317167, XrefRangeEnd = 317168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref method_handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type_handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref genericCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_GetMethodFromHandleInternalType_native_Internal_Static_MethodBase_IntPtr_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00009ABA File Offset: 0x00007CBA
		public MethodBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodFromHandle_Public_Static_MethodBase_RuntimeMethodHandle_0;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodBase_MethodBase_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodBase_MethodBase_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersNoCopy_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_GetParameters_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Abstract_Virtual_New_MethodImplAttributes_0;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodHandle_Public_Abstract_Virtual_New_get_RuntimeMethodHandle_0;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_MethodAttributes_0;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeMethodInfoPtr_get_CallingConvention_Public_Virtual_New_get_CallingConventions_0;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericMethodDefinition_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericMethod_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSecurityCritical_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Object_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVirtual_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstract_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConstructor_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodBody_Public_Virtual_New_MethodBody_0;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeMethodInfoPtr_ConstructParameters_Internal_Static_String_Il2CppReferenceArray_1_Type_CallingConventions_Boolean_0;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeMethodInfoPtr_FormatNameAndSig_Internal_Virtual_New_String_Boolean_0;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeMethodInfoPtr_GetParameterTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersInternal_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersCount_Internal_Virtual_New_Int32_0;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodFromHandleNoGenericCheck_Internal_Static_MethodBase_RuntimeMethodHandle_0;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodFromHandleNoGenericCheck_Internal_Static_MethodBase_RuntimeMethodHandle_RuntimeTypeHandle_0;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodBodyInternal_Internal_Static_MethodBody_IntPtr_0;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodBody_Internal_Static_MethodBody_IntPtr_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodFromHandleInternalType_Private_Static_MethodBase_IntPtr_IntPtr_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodFromHandleInternalType_native_Internal_Static_MethodBase_IntPtr_IntPtr_Boolean_0;
	}
}
