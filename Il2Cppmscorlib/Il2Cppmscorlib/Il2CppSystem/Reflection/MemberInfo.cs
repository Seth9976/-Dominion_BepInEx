using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001AB RID: 427
	[Serializable]
	public class MemberInfo : Object
	{
		// Token: 0x06001BCD RID: 7117 RVA: 0x0009EE78 File Offset: 0x0009D078
		// Note: this type is marked as 'beforefieldinit'.
		static MemberInfo()
		{
			Il2CppClassPointerStore<MemberInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MemberInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr);
			MemberInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667933);
			MemberInfo.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667934);
			MemberInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667935);
			MemberInfo.NativeMethodInfoPtr_get_DeclaringType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667936);
			MemberInfo.NativeMethodInfoPtr_get_ReflectedType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667937);
			MemberInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667938);
			MemberInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667939);
			MemberInfo.NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667940);
			MemberInfo.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_New_IList_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667941);
			MemberInfo.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667942);
			MemberInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_New_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667943);
			MemberInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MemberInfo_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667944);
			MemberInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MemberInfo_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667945);
			MemberInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667946);
			MemberInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr, 100667947);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0009EFD4 File Offset: 0x0009D1D4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0009F010 File Offset: 0x0009D210
		public unsafe virtual MemberTypes MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x0009F058 File Offset: 0x0009D258
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x0009F09C File Offset: 0x0009D29C
		public unsafe virtual Type DeclaringType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_DeclaringType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x0009F0E8 File Offset: 0x0009D2E8
		public unsafe virtual Type ReflectedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_ReflectedType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0009F134 File Offset: 0x0009D334
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0009F18C File Offset: 0x0009D38C
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0009F1F8 File Offset: 0x0009D3F8
		[CallerCount(0)]
		public unsafe virtual bool IsDefined(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0009F260 File Offset: 0x0009D460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316839, XrefRangeEnd = 316844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_New_IList_1_CustomAttributeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x0009F2AC File Offset: 0x0009D4AC
		public unsafe virtual int MetadataToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316844, XrefRangeEnd = 316845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x0009F2F4 File Offset: 0x0009D4F4
		public unsafe virtual Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316845, XrefRangeEnd = 316853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_New_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0009F340 File Offset: 0x0009D540
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 316869, RefRangeEnd = 316876, XrefRangeStart = 316853, XrefRangeEnd = 316869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(MemberInfo left, MemberInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MemberInfo_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0009F394 File Offset: 0x0009D594
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316877, RefRangeEnd = 316879, XrefRangeStart = 316876, XrefRangeEnd = 316877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(MemberInfo left, MemberInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MemberInfo_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0009F3E8 File Offset: 0x0009D5E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210863, RefRangeEnd = 210865, XrefRangeStart = 210863, XrefRangeEnd = 210865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0009F440 File Offset: 0x0009D640
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221576, XrefRangeStart = 221564, XrefRangeEnd = 221576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x000099F2 File Offset: 0x00007BF2
		public MemberInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_MemberTypes_0;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_New_IList_1_CustomAttributeData_0;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_New_get_Module_0;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MemberInfo_MemberInfo_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MemberInfo_MemberInfo_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
