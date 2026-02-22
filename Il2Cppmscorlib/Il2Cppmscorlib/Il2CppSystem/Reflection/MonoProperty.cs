using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001E0 RID: 480
	[Serializable]
	public class MonoProperty : RuntimePropertyInfo
	{
		// Token: 0x06001EC5 RID: 7877 RVA: 0x000ABC34 File Offset: 0x000A9E34
		// Note: this type is marked as 'beforefieldinit'.
		static MonoProperty()
		{
			Il2CppClassPointerStore<MonoProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr);
			MonoProperty.NativeFieldInfoPtr_klass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, "klass");
			MonoProperty.NativeFieldInfoPtr_prop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, "prop");
			MonoProperty.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, "info");
			MonoProperty.NativeFieldInfoPtr_cached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, "cached");
			MonoProperty.NativeFieldInfoPtr_cached_getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, "cached_getter");
			MonoProperty.NativeMethodInfoPtr_CachePropertyInfo_Private_Void_PInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668387);
			MonoProperty.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_PropertyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668388);
			MonoProperty.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668389);
			MonoProperty.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668390);
			MonoProperty.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668391);
			MonoProperty.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668392);
			MonoProperty.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668393);
			MonoProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668394);
			MonoProperty.NativeMethodInfoPtr_GetAccessors_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668395);
			MonoProperty.NativeMethodInfoPtr_GetGetMethod_Public_Virtual_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668396);
			MonoProperty.NativeMethodInfoPtr_GetIndexParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668397);
			MonoProperty.NativeMethodInfoPtr_GetSetMethod_Public_Virtual_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668398);
			MonoProperty.NativeMethodInfoPtr_GetConstantValue_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668399);
			MonoProperty.NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668400);
			MonoProperty.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668401);
			MonoProperty.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668402);
			MonoProperty.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668403);
			MonoProperty.NativeMethodInfoPtr_GetterAdapterFrame_Private_Static_Object_Getter_2_T_R_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668404);
			MonoProperty.NativeMethodInfoPtr_StaticGetterAdapterFrame_Private_Static_Object_StaticGetter_1_R_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668405);
			MonoProperty.NativeMethodInfoPtr_CreateGetterDelegate_Private_Static_GetterAdapter_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668406);
			MonoProperty.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668407);
			MonoProperty.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668408);
			MonoProperty.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668409);
			MonoProperty.NativeMethodInfoPtr_GetOptionalCustomModifiers_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668410);
			MonoProperty.NativeMethodInfoPtr_GetRequiredCustomModifiers_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668411);
			MonoProperty.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668412);
			MonoProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, 100668413);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x000ABEE4 File Offset: 0x000AA0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318953, XrefRangeEnd = 318954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CachePropertyInfo(PInfo flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoProperty.NativeMethodInfoPtr_CachePropertyInfo_Private_Void_PInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x000ABF24 File Offset: 0x000AA124
		public unsafe override PropertyAttributes Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318954, XrefRangeEnd = 318955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_PropertyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x000ABF6C File Offset: 0x000AA16C
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318955, XrefRangeEnd = 318957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x000ABFB4 File Offset: 0x000AA1B4
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318957, XrefRangeEnd = 318959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x000ABFFC File Offset: 0x000AA1FC
		public unsafe override Type PropertyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318959, XrefRangeEnd = 318964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x000AC048 File Offset: 0x000AA248
		public unsafe override Type ReflectedType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318964, XrefRangeEnd = 318965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x000AC094 File Offset: 0x000AA294
		public unsafe override Type DeclaringType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318965, XrefRangeEnd = 318966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x000AC0E0 File Offset: 0x000AA2E0
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318966, XrefRangeEnd = 318967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x000AC124 File Offset: 0x000AA324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318967, XrefRangeEnd = 318976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MethodInfo> GetAccessors(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetAccessors_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x000AC17C File Offset: 0x000AA37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318976, XrefRangeEnd = 318978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetGetMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetGetMethod_Public_Virtual_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x000AC1D4 File Offset: 0x000AA3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318978, XrefRangeEnd = 318992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ParameterInfo> GetIndexParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetIndexParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x000AC220 File Offset: 0x000AA420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318992, XrefRangeEnd = 318994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetSetMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetSetMethod_Public_Virtual_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x000AC278 File Offset: 0x000AA478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetConstantValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetConstantValue_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x000AC2C4 File Offset: 0x000AA4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetRawConstantValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000AC310 File Offset: 0x000AA510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318994, XrefRangeEnd = 318998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x000AC378 File Offset: 0x000AA578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318998, XrefRangeEnd = 319002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000AC3D0 File Offset: 0x000AA5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319002, XrefRangeEnd = 319006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000AC43C File Offset: 0x000AA63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319006, XrefRangeEnd = 319011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoProperty.MethodInfoStoreGeneric_GetterAdapterFrame_Private_Static_Object_Getter_2_T_R_Object_0<T, R>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000AC494 File Offset: 0x000AA694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319011, XrefRangeEnd = 319012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoProperty.MethodInfoStoreGeneric_StaticGetterAdapterFrame_Private_Static_Object_StaticGetter_1_R_Object_0<R>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x000AC4EC File Offset: 0x000AA6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319012, XrefRangeEnd = 319048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoProperty.NativeMethodInfoPtr_CreateGetterDelegate_Private_Static_GetterAdapter_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoProperty.GetterAdapter>(intPtr3) : null;
			}
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000AC530 File Offset: 0x000AA730
		[CallerCount(0)]
		public unsafe override Object GetValue(Object obj, Il2CppReferenceArray<Object> index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x000AC5A0 File Offset: 0x000AA7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319048, XrefRangeEnd = 319051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetValue(Object obj, BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> index, CultureInfo culture)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000AC644 File Offset: 0x000AA844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319051, XrefRangeEnd = 319061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> index, CultureInfo culture)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x000AC6EC File Offset: 0x000AA8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319061, XrefRangeEnd = 319066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetOptionalCustomModifiers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetOptionalCustomModifiers_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x000AC738 File Offset: 0x000AA938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319066, XrefRangeEnd = 319071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetRequiredCustomModifiers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetRequiredCustomModifiers_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x000AC784 File Offset: 0x000AA984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IList<CustomAttributeData> GetCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoProperty.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000AC7D0 File Offset: 0x000AA9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0000A8F7 File Offset: 0x00008AF7
		public MonoProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x000AC80C File Offset: 0x000AAA0C
		// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x0000A900 File Offset: 0x00008B00
		public unsafe IntPtr klass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoProperty.NativeFieldInfoPtr_klass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoProperty.NativeFieldInfoPtr_klass)) = value;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x000AC834 File Offset: 0x000AAA34
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x0000A91B File Offset: 0x00008B1B
		public unsafe IntPtr prop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoProperty.NativeFieldInfoPtr_prop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoProperty.NativeFieldInfoPtr_prop)) = value;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x000AC85C File Offset: 0x000AAA5C
		// (set) Token: 0x06001EE7 RID: 7911 RVA: 0x0000A936 File Offset: 0x00008B36
		public MonoPropertyInfo info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoProperty.NativeFieldInfoPtr_info);
				return new MonoPropertyInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoProperty.NativeFieldInfoPtr_info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x000AC88C File Offset: 0x000AAA8C
		// (set) Token: 0x06001EE9 RID: 7913 RVA: 0x0000A964 File Offset: 0x00008B64
		public unsafe PInfo cached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoProperty.NativeFieldInfoPtr_cached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoProperty.NativeFieldInfoPtr_cached)) = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x000AC8B4 File Offset: 0x000AAAB4
		// (set) Token: 0x06001EEB RID: 7915 RVA: 0x0000A97F File Offset: 0x00008B7F
		public unsafe MonoProperty.GetterAdapter cached_getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoProperty.NativeFieldInfoPtr_cached_getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoProperty.GetterAdapter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoProperty.NativeFieldInfoPtr_cached_getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeFieldInfoPtr_klass;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeFieldInfoPtr_prop;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeFieldInfoPtr_cached;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeFieldInfoPtr_cached_getter;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeMethodInfoPtr_CachePropertyInfo_Private_Void_PInfo_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_PropertyAttributes_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessors_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_Boolean_0;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_GetGetMethod_Public_Virtual_MethodInfo_Boolean_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_GetSetMethod_Public_Virtual_MethodInfo_Boolean_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_GetConstantValue_Public_Virtual_Object_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_Object_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_GetterAdapterFrame_Private_Static_Object_Getter_2_T_R_Object_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_StaticGetterAdapterFrame_Private_Static_Object_StaticGetter_1_R_Object_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_CreateGetterDelegate_Private_Static_GetterAdapter_MethodInfo_0;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionalCustomModifiers_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredCustomModifiers_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005C8 RID: 1480
		public sealed class GetterAdapter : MulticastDelegate
		{
			// Token: 0x06005121 RID: 20769 RVA: 0x0001EEC5 File Offset: 0x0001D0C5
			// Note: this type is marked as 'beforefieldinit'.
			static GetterAdapter()
			{
				Il2CppClassPointerStore<MonoProperty.GetterAdapter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, "GetterAdapter");
				MonoProperty.GetterAdapter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty.GetterAdapter>.NativeClassPtr, 100668414);
				MonoProperty.GetterAdapter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty.GetterAdapter>.NativeClassPtr, 100668415);
			}

			// Token: 0x06005122 RID: 20770 RVA: 0x0016AF80 File Offset: 0x00169180
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetterAdapter(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoProperty.GetterAdapter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoProperty.GetterAdapter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005123 RID: 20771 RVA: 0x0016AFDC File Offset: 0x001691DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318952, RefRangeEnd = 318953, XrefRangeStart = 318952, XrefRangeEnd = 318952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object Invoke(Object _this)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_this);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoProperty.GetterAdapter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005124 RID: 20772 RVA: 0x0001EF03 File Offset: 0x0001D103
			public GetterAdapter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005125 RID: 20773 RVA: 0x0001EF0C File Offset: 0x0001D10C
			public static implicit operator MonoProperty.GetterAdapter(Func<Object, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<MonoProperty.GetterAdapter>(A_0);
			}

			// Token: 0x06005126 RID: 20774 RVA: 0x0001EF14 File Offset: 0x0001D114
			public static MonoProperty.GetterAdapter operator +(MonoProperty.GetterAdapter A_0, MonoProperty.GetterAdapter A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MonoProperty.GetterAdapter>();
			}

			// Token: 0x06005127 RID: 20775 RVA: 0x0001EF22 File Offset: 0x0001D122
			public static MonoProperty.GetterAdapter operator -(MonoProperty.GetterAdapter A_0, MonoProperty.GetterAdapter A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<MonoProperty.GetterAdapter>();
				}
				return delegate2;
			}

			// Token: 0x040041CB RID: 16843
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040041CC RID: 16844
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Object_0;
		}

		// Token: 0x020005C9 RID: 1481
		public sealed class Getter<T, R> : MulticastDelegate
		{
			// Token: 0x06005128 RID: 20776 RVA: 0x0016B02C File Offset: 0x0016922C
			// Note: this type is marked as 'beforefieldinit'.
			static Getter()
			{
				Il2CppClassPointerStore<MonoProperty.Getter<T, R>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, "Getter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr))
				})).TypeHandle.value);
				MonoProperty.Getter<T, R>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty.Getter<T, R>>.NativeClassPtr, 100668416);
				MonoProperty.Getter<T, R>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty.Getter<T, R>>.NativeClassPtr, 100668417);
			}

			// Token: 0x06005129 RID: 20777 RVA: 0x0016B0C4 File Offset: 0x001692C4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Getter(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoProperty.Getter<T, R>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoProperty.Getter<T, R>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600512A RID: 20778 RVA: 0x0016B120 File Offset: 0x00169320
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 275479, RefRangeEnd = 275480, XrefRangeStart = 275479, XrefRangeEnd = 275480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe R Invoke(T _this)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _this;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _this;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoProperty.Getter<T, R>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<R>(intPtr2, false, true);
				}
			}

			// Token: 0x0600512B RID: 20779 RVA: 0x0001EF33 File Offset: 0x0001D133
			public Getter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600512C RID: 20780 RVA: 0x0001EF3C File Offset: 0x0001D13C
			public static implicit operator MonoProperty.Getter<T, R>(Func<T, R> A_0)
			{
				return DelegateSupport.ConvertDelegate<MonoProperty.Getter<T, R>>(A_0);
			}

			// Token: 0x0600512D RID: 20781 RVA: 0x0001EF44 File Offset: 0x0001D144
			public static MonoProperty.Getter<T, R>operator +(MonoProperty.Getter<T, R> A_0, MonoProperty.Getter<T, R> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MonoProperty.Getter<T, R>>();
			}

			// Token: 0x0600512E RID: 20782 RVA: 0x0001EF52 File Offset: 0x0001D152
			public static MonoProperty.Getter<T, R>operator -(MonoProperty.Getter<T, R> A_0, MonoProperty.Getter<T, R> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<MonoProperty.Getter<T, R>>();
				}
				return delegate2;
			}

			// Token: 0x040041CD RID: 16845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040041CE RID: 16846
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_T_0;
		}

		// Token: 0x020005CA RID: 1482
		public sealed class StaticGetter<R> : MulticastDelegate
		{
			// Token: 0x0600512F RID: 20783 RVA: 0x0016B1A0 File Offset: 0x001693A0
			// Note: this type is marked as 'beforefieldinit'.
			static StaticGetter()
			{
				Il2CppClassPointerStore<MonoProperty.StaticGetter<R>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoProperty>.NativeClassPtr, "StaticGetter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr)) })).TypeHandle.value);
				MonoProperty.StaticGetter<R>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty.StaticGetter<R>>.NativeClassPtr, 100668418);
				MonoProperty.StaticGetter<R>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoProperty.StaticGetter<R>>.NativeClassPtr, 100668419);
			}

			// Token: 0x06005130 RID: 20784 RVA: 0x0016B224 File Offset: 0x00169424
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StaticGetter(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoProperty.StaticGetter<R>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoProperty.StaticGetter<R>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005131 RID: 20785 RVA: 0x0016B280 File Offset: 0x00169480
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 91949, RefRangeEnd = 91951, XrefRangeStart = 91949, XrefRangeEnd = 91951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe R Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoProperty.StaticGetter<R>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<R>(intPtr, false, true);
			}

			// Token: 0x06005132 RID: 20786 RVA: 0x0001EF63 File Offset: 0x0001D163
			public StaticGetter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005133 RID: 20787 RVA: 0x0001EF6C File Offset: 0x0001D16C
			public static implicit operator MonoProperty.StaticGetter<R>(Func<R> A_0)
			{
				return DelegateSupport.ConvertDelegate<MonoProperty.StaticGetter<R>>(A_0);
			}

			// Token: 0x06005134 RID: 20788 RVA: 0x0001EF74 File Offset: 0x0001D174
			public static MonoProperty.StaticGetter<R>operator +(MonoProperty.StaticGetter<R> A_0, MonoProperty.StaticGetter<R> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<MonoProperty.StaticGetter<R>>();
			}

			// Token: 0x06005135 RID: 20789 RVA: 0x0001EF82 File Offset: 0x0001D182
			public static MonoProperty.StaticGetter<R>operator -(MonoProperty.StaticGetter<R> A_0, MonoProperty.StaticGetter<R> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<MonoProperty.StaticGetter<R>>();
				}
				return delegate2;
			}

			// Token: 0x040041CF RID: 16847
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040041D0 RID: 16848
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_0;
		}

		// Token: 0x020005CB RID: 1483
		private sealed class MethodInfoStoreGeneric_GetterAdapterFrame_Private_Static_Object_Getter_2_T_R_Object_0<T, R>
		{
			// Token: 0x040041D1 RID: 16849
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MonoProperty.NativeMethodInfoPtr_GetterAdapterFrame_Private_Static_Object_Getter_2_T_R_Object_0, Il2CppClassPointerStore<MonoProperty>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr))
			}))));
		}

		// Token: 0x020005CC RID: 1484
		private sealed class MethodInfoStoreGeneric_StaticGetterAdapterFrame_Private_Static_Object_StaticGetter_1_R_Object_0<R>
		{
			// Token: 0x040041D2 RID: 16850
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MonoProperty.NativeMethodInfoPtr_StaticGetterAdapterFrame_Private_Static_Object_StaticGetter_1_R_Object_0, Il2CppClassPointerStore<MonoProperty>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr)) }))));
		}
	}
}
