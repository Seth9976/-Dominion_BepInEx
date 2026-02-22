using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000347 RID: 839
	public sealed class SerializationFieldInfo : FieldInfo
	{
		// Token: 0x060035BA RID: 13754 RVA: 0x001058F4 File Offset: 0x00103AF4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationFieldInfo()
		{
			Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationFieldInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr);
			SerializationFieldInfo.NativeFieldInfoPtr_m_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, "m_field");
			SerializationFieldInfo.NativeFieldInfoPtr_m_serializationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, "m_serializationName");
			SerializationFieldInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671587);
			SerializationFieldInfo.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671588);
			SerializationFieldInfo.NativeMethodInfoPtr__ctor_Internal_Void_RuntimeFieldInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671589);
			SerializationFieldInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671590);
			SerializationFieldInfo.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671591);
			SerializationFieldInfo.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671592);
			SerializationFieldInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671593);
			SerializationFieldInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671594);
			SerializationFieldInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671595);
			SerializationFieldInfo.NativeMethodInfoPtr_get_FieldType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671596);
			SerializationFieldInfo.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671597);
			SerializationFieldInfo.NativeMethodInfoPtr_InternalGetValue_Internal_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671598);
			SerializationFieldInfo.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_BindingFlags_Binder_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671599);
			SerializationFieldInfo.NativeMethodInfoPtr_InternalSetValue_Internal_Void_Object_Object_BindingFlags_Binder_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671600);
			SerializationFieldInfo.NativeMethodInfoPtr_get_FieldInfo_Internal_get_RuntimeFieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671601);
			SerializationFieldInfo.NativeMethodInfoPtr_get_FieldHandle_Public_Virtual_get_RuntimeFieldHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671602);
			SerializationFieldInfo.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_FieldAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr, 100671603);
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x00105AA0 File Offset: 0x00103CA0
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343814, XrefRangeEnd = 343815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x00105AE0 File Offset: 0x00103CE0
		public unsafe override int MetadataToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00105B1C File Offset: 0x00103D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343819, RefRangeEnd = 343820, XrefRangeStart = 343815, XrefRangeEnd = 343819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationFieldInfo(RuntimeFieldInfo field, string namePrefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationFieldInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namePrefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr__ctor_Internal_Void_RuntimeFieldInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x00105B7C File Offset: 0x00103D7C
		public unsafe override string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060035BF RID: 13759 RVA: 0x00105BB4 File Offset: 0x00103DB4
		public unsafe override Type DeclaringType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x00105BF4 File Offset: 0x00103DF4
		public unsafe override Type ReflectedType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00105C34 File Offset: 0x00103E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343820, XrefRangeEnd = 343821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00105C80 File Offset: 0x00103E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343821, XrefRangeEnd = 343822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00105CE0 File Offset: 0x00103EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343822, XrefRangeEnd = 343823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x00105D3C File Offset: 0x00103F3C
		public unsafe override Type FieldType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12035, RefRangeEnd = 12037, XrefRangeStart = 12035, XrefRangeEnd = 12037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_get_FieldType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00105D7C File Offset: 0x00103F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343823, XrefRangeEnd = 343824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetValue(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00105DCC File Offset: 0x00103FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343832, RefRangeEnd = 343833, XrefRangeStart = 343824, XrefRangeEnd = 343832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalGetValue(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_InternalGetValue_Internal_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x00105E1C File Offset: 0x0010401C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343833, XrefRangeEnd = 343834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_BindingFlags_Binder_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x00105EA4 File Offset: 0x001040A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343834, XrefRangeEnd = 343839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_InternalSetValue_Internal_Void_Object_Object_BindingFlags_Binder_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x00105F2C File Offset: 0x0010412C
		public unsafe RuntimeFieldInfo FieldInfo
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_get_FieldInfo_Internal_get_RuntimeFieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeFieldInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x00105F6C File Offset: 0x0010416C
		public unsafe override RuntimeFieldHandle FieldHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_get_FieldHandle_Public_Virtual_get_RuntimeFieldHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x00105FA8 File Offset: 0x001041A8
		public unsafe override FieldAttributes Attributes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 48849, RefRangeEnd = 48852, XrefRangeStart = 48849, XrefRangeEnd = 48852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationFieldInfo.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_FieldAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x00013496 File Offset: 0x00011696
		public SerializationFieldInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x00105FE4 File Offset: 0x001041E4
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x0001349F File Offset: 0x0001169F
		public unsafe RuntimeFieldInfo m_field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationFieldInfo.NativeFieldInfoPtr_m_field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeFieldInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationFieldInfo.NativeFieldInfoPtr_m_field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x00106014 File Offset: 0x00104214
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x000134BE File Offset: 0x000116BE
		public unsafe string m_serializationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationFieldInfo.NativeFieldInfoPtr_m_serializationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationFieldInfo.NativeFieldInfoPtr_m_serializationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002D54 RID: 11604
		private static readonly IntPtr NativeFieldInfoPtr_m_field;

		// Token: 0x04002D55 RID: 11605
		private static readonly IntPtr NativeFieldInfoPtr_m_serializationName;

		// Token: 0x04002D56 RID: 11606
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x04002D57 RID: 11607
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0;

		// Token: 0x04002D58 RID: 11608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RuntimeFieldInfo_String_0;

		// Token: 0x04002D59 RID: 11609
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04002D5A RID: 11610
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0;

		// Token: 0x04002D5B RID: 11611
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0;

		// Token: 0x04002D5C RID: 11612
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04002D5D RID: 11613
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04002D5E RID: 11614
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04002D5F RID: 11615
		private static readonly IntPtr NativeMethodInfoPtr_get_FieldType_Public_Virtual_get_Type_0;

		// Token: 0x04002D60 RID: 11616
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0;

		// Token: 0x04002D61 RID: 11617
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetValue_Internal_Object_Object_0;

		// Token: 0x04002D62 RID: 11618
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_BindingFlags_Binder_CultureInfo_0;

		// Token: 0x04002D63 RID: 11619
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetValue_Internal_Void_Object_Object_BindingFlags_Binder_CultureInfo_0;

		// Token: 0x04002D64 RID: 11620
		private static readonly IntPtr NativeMethodInfoPtr_get_FieldInfo_Internal_get_RuntimeFieldInfo_0;

		// Token: 0x04002D65 RID: 11621
		private static readonly IntPtr NativeMethodInfoPtr_get_FieldHandle_Public_Virtual_get_RuntimeFieldHandle_0;

		// Token: 0x04002D66 RID: 11622
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_FieldAttributes_0;
	}
}
