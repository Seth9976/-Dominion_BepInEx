using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001E2 RID: 482
	[Serializable]
	public class PropertyInfo : MemberInfo
	{
		// Token: 0x06001F0E RID: 7950 RVA: 0x000AD184 File Offset: 0x000AB384
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyInfo()
		{
			Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "PropertyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr);
			PropertyInfo.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_PropertyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668438);
			PropertyInfo.NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668439);
			PropertyInfo.NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668440);
			PropertyInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668441);
			PropertyInfo.NativeMethodInfoPtr_get_PropertyType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668442);
			PropertyInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668443);
			PropertyInfo.NativeMethodInfoPtr_GetAccessors_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668444);
			PropertyInfo.NativeMethodInfoPtr_GetGetMethod_Public_Virtual_Final_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668445);
			PropertyInfo.NativeMethodInfoPtr_GetGetMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668446);
			PropertyInfo.NativeMethodInfoPtr_GetIndexParameters_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668447);
			PropertyInfo.NativeMethodInfoPtr_GetSetMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668448);
			PropertyInfo.NativeMethodInfoPtr_GetValue_Public_Virtual_New_Object_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668449);
			PropertyInfo.NativeMethodInfoPtr_GetValue_Public_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668450);
			PropertyInfo.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668451);
			PropertyInfo.NativeMethodInfoPtr_SetValue_Public_Virtual_New_Void_Object_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668452);
			PropertyInfo.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668453);
			PropertyInfo.NativeMethodInfoPtr_GetOptionalCustomModifiers_Public_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668454);
			PropertyInfo.NativeMethodInfoPtr_GetRequiredCustomModifiers_Public_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668455);
			PropertyInfo.NativeMethodInfoPtr_CreateNIE_Private_Static_NotImplementedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668456);
			PropertyInfo.NativeMethodInfoPtr_GetConstantValue_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668457);
			PropertyInfo.NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668458);
			PropertyInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668459);
			PropertyInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668460);
			PropertyInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668461);
			PropertyInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PropertyInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668462);
			PropertyInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_PropertyInfo_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668463);
			PropertyInfo.NativeMethodInfoPtr_GetPropertyFromHandle_Internal_Static_PropertyInfo_RuntimePropertyHandle_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr, 100668464);
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x000AD3D0 File Offset: 0x000AB5D0
		public unsafe virtual PropertyAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_PropertyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x000AD418 File Offset: 0x000AB618
		public unsafe virtual bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x000AD460 File Offset: 0x000AB660
		public unsafe virtual bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x000AD4A8 File Offset: 0x000AB6A8
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x000AD4F0 File Offset: 0x000AB6F0
		public unsafe virtual Type PropertyType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_get_PropertyType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x000AD53C File Offset: 0x000AB73C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x000AD578 File Offset: 0x000AB778
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<MethodInfo> GetAccessors(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetAccessors_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000AD5D0 File Offset: 0x000AB7D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319153, RefRangeEnd = 319154, XrefRangeStart = 319153, XrefRangeEnd = 319153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetGetMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyInfo.NativeMethodInfoPtr_GetGetMethod_Public_Virtual_Final_New_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x000AD610 File Offset: 0x000AB810
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetGetMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetGetMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x000AD668 File Offset: 0x000AB868
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ParameterInfo> GetIndexParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetIndexParameters_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x000AD6B4 File Offset: 0x000AB8B4
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetSetMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetSetMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x000AD70C File Offset: 0x000AB90C
		[CallerCount(0)]
		public unsafe virtual Object GetValue(Object obj, Il2CppReferenceArray<Object> index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetValue_Public_Virtual_New_Object_Object_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x000AD77C File Offset: 0x000AB97C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319154, RefRangeEnd = 319155, XrefRangeStart = 319154, XrefRangeEnd = 319154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyInfo.NativeMethodInfoPtr_GetValue_Public_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x000AD7CC File Offset: 0x000AB9CC
		[CallerCount(0)]
		public unsafe virtual Object GetValue(Object obj, BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> index, CultureInfo culture)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x000AD870 File Offset: 0x000ABA70
		[CallerCount(0)]
		public unsafe virtual void SetValue(Object obj, Object value, Il2CppReferenceArray<Object> index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_SetValue_Public_Virtual_New_Void_Object_Object_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x000AD8E4 File Offset: 0x000ABAE4
		[CallerCount(0)]
		public unsafe virtual void SetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> index, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x000AD98C File Offset: 0x000ABB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319155, XrefRangeEnd = 319159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetOptionalCustomModifiers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetOptionalCustomModifiers_Public_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x000AD9D8 File Offset: 0x000ABBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319159, XrefRangeEnd = 319163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetRequiredCustomModifiers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetRequiredCustomModifiers_Public_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x000ADA24 File Offset: 0x000ABC24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319167, RefRangeEnd = 319169, XrefRangeStart = 319163, XrefRangeEnd = 319167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NotImplementedException CreateNIE()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyInfo.NativeMethodInfoPtr_CreateNIE_Private_Static_NotImplementedException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotImplementedException>(intPtr3) : null;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x000ADA58 File Offset: 0x000ABC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319169, XrefRangeEnd = 319172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetConstantValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetConstantValue_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x000ADAA4 File Offset: 0x000ABCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319172, XrefRangeEnd = 319175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRawConstantValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x000ADAF0 File Offset: 0x000ABCF0
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x000ADB48 File Offset: 0x000ABD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317065, RefRangeEnd = 317066, XrefRangeStart = 317065, XrefRangeEnd = 317066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000ADB90 File Offset: 0x000ABD90
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 317559, RefRangeEnd = 317601, XrefRangeStart = 317559, XrefRangeEnd = 317601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PropertyInfo left, PropertyInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyInfo_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x000ADBE4 File Offset: 0x000ABDE4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 317601, RefRangeEnd = 317626, XrefRangeStart = 317601, XrefRangeEnd = 317626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(PropertyInfo left, PropertyInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PropertyInfo_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x000ADC38 File Offset: 0x000ABE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319175, XrefRangeEnd = 319176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref event_handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type_handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_PropertyInfo_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x000ADC88 File Offset: 0x000ABE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319179, RefRangeEnd = 319180, XrefRangeStart = 319176, XrefRangeEnd = 319179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectedType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyInfo.NativeMethodInfoPtr_GetPropertyFromHandle_Internal_Static_PropertyInfo_RuntimePropertyHandle_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x0000AA78 File Offset: 0x00008C78
		public PropertyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_PropertyAttributes_0;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessors_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_MethodInfo_Boolean_0;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeMethodInfoPtr_GetGetMethod_Public_Virtual_Final_New_MethodInfo_0;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeMethodInfoPtr_GetGetMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexParameters_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeMethodInfoPtr_GetSetMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_New_Object_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Object_0;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_New_Void_Object_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionalCustomModifiers_Public_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredCustomModifiers_Public_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeMethodInfoPtr_CreateNIE_Private_Static_NotImplementedException_0;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeMethodInfoPtr_GetConstantValue_Public_Virtual_New_Object_0;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_New_Object_0;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyInfo_PropertyInfo_0;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PropertyInfo_PropertyInfo_0;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeMethodInfoPtr_internal_from_handle_type_Private_Static_PropertyInfo_IntPtr_IntPtr_0;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyFromHandle_Internal_Static_PropertyInfo_RuntimePropertyHandle_RuntimeTypeHandle_0;
	}
}
