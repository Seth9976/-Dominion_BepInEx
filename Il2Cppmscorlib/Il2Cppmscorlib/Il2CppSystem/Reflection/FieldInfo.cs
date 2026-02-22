using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C8 RID: 456
	[Serializable]
	public class FieldInfo : MemberInfo
	{
		// Token: 0x06001D4F RID: 7503 RVA: 0x000A56AC File Offset: 0x000A38AC
		// Note: this type is marked as 'beforefieldinit'.
		static FieldInfo()
		{
			Il2CppClassPointerStore<FieldInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "FieldInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr);
			FieldInfo.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_FieldAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668164);
			FieldInfo.NativeMethodInfoPtr_get_FieldHandle_Public_Abstract_Virtual_New_get_RuntimeFieldHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668165);
			FieldInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668166);
			FieldInfo.NativeMethodInfoPtr_get_FieldType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668167);
			FieldInfo.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668168);
			FieldInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668169);
			FieldInfo.NativeMethodInfoPtr_get_IsLiteral_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668170);
			FieldInfo.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668171);
			FieldInfo.NativeMethodInfoPtr_get_IsNotSerialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668172);
			FieldInfo.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668173);
			FieldInfo.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668174);
			FieldInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_FieldInfo_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668175);
			FieldInfo.NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668176);
			FieldInfo.NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668177);
			FieldInfo.NativeMethodInfoPtr_GetFieldOffset_Internal_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668178);
			FieldInfo.NativeMethodInfoPtr_SetValueDirect_Public_Virtual_New_Void_TypedReference_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668179);
			FieldInfo.NativeMethodInfoPtr_get_marshal_info_Private_MarshalAsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668180);
			FieldInfo.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668181);
			FieldInfo.NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668182);
			FieldInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668183);
			FieldInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668184);
			FieldInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FieldInfo_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668185);
			FieldInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FieldInfo_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr, 100668186);
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x000A58A8 File Offset: 0x000A3AA8
		public unsafe virtual FieldAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_FieldAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x000A58F0 File Offset: 0x000A3AF0
		public unsafe virtual RuntimeFieldHandle FieldHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_get_FieldHandle_Public_Abstract_Virtual_New_get_RuntimeFieldHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x000A5938 File Offset: 0x000A3B38
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x000A5974 File Offset: 0x000A3B74
		public unsafe virtual Type FieldType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_get_FieldType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x000A59C0 File Offset: 0x000A3BC0
		[CallerCount(0)]
		public unsafe virtual Object GetValue(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x000A5A1C File Offset: 0x000A3C1C
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x000A5A64 File Offset: 0x000A3C64
		public unsafe virtual bool IsLiteral
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 318240, RefRangeEnd = 318242, XrefRangeStart = 318240, XrefRangeEnd = 318240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_IsLiteral_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x000A5AA0 File Offset: 0x000A3CA0
		public unsafe virtual bool IsStatic
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x000A5ADC File Offset: 0x000A3CDC
		public unsafe virtual bool IsNotSerialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_IsNotSerialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x000A5B18 File Offset: 0x000A3D18
		[CallerCount(0)]
		public unsafe virtual void SetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x000A5BAC File Offset: 0x000A3DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318245, RefRangeEnd = 318246, XrefRangeStart = 318245, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValue(Object obj, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x000A5C00 File Offset: 0x000A3E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318246, XrefRangeEnd = 318247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref field_handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type_handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_FieldInfo_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x000A5C50 File Offset: 0x000A3E50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 318256, RefRangeEnd = 318259, XrefRangeStart = 318247, XrefRangeEnd = 318256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x000A5C90 File Offset: 0x000A3E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318262, RefRangeEnd = 318263, XrefRangeStart = 318259, XrefRangeEnd = 318262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declaringType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x000A5CE0 File Offset: 0x000A3EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318263, XrefRangeEnd = 318269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetFieldOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_GetFieldOffset_Internal_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x000A5D28 File Offset: 0x000A3F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318269, XrefRangeEnd = 318276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValueDirect(TypedReference obj, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_SetValueDirect_Public_Virtual_New_Void_TypedReference_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x000A5D84 File Offset: 0x000A3F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317376, RefRangeEnd = 317377, XrefRangeStart = 317376, XrefRangeEnd = 317377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalAsAttribute get_marshal_info()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_get_marshal_info_Private_MarshalAsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalAsAttribute>(intPtr3) : null;
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x000A5DC4 File Offset: 0x000A3FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318293, RefRangeEnd = 318294, XrefRangeStart = 318276, XrefRangeEnd = 318293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetPseudoCustomAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x000A5E04 File Offset: 0x000A4004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318294, XrefRangeEnd = 318300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRawConstantValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x000A5E50 File Offset: 0x000A4050
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x000A5EA8 File Offset: 0x000A40A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317065, RefRangeEnd = 317066, XrefRangeStart = 317065, XrefRangeEnd = 317066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FieldInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x000A5EF0 File Offset: 0x000A40F0
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 317559, RefRangeEnd = 317601, XrefRangeStart = 317559, XrefRangeEnd = 317601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FieldInfo left, FieldInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FieldInfo_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x000A5F44 File Offset: 0x000A4144
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 317601, RefRangeEnd = 317626, XrefRangeStart = 317601, XrefRangeEnd = 317626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(FieldInfo left, FieldInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FieldInfo_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0000A1C0 File Offset: 0x000083C0
		public FieldInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_FieldAttributes_0;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr_get_FieldHandle_Public_Abstract_Virtual_New_get_RuntimeFieldHandle_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_get_FieldType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_Object_0;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLiteral_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotSerialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_CultureInfo_0;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_internal_from_handle_type_Private_Static_FieldInfo_IntPtr_IntPtr_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_0;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldFromHandle_Public_Static_FieldInfo_RuntimeFieldHandle_RuntimeTypeHandle_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldOffset_Internal_Virtual_New_Int32_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_SetValueDirect_Public_Virtual_New_Void_TypedReference_Object_0;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_get_marshal_info_Private_MarshalAsAttribute_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr_GetRawConstantValue_Public_Virtual_New_Object_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FieldInfo_FieldInfo_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FieldInfo_FieldInfo_0;
	}
}
