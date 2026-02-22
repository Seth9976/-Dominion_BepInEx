using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Text;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001E1 RID: 481
	[Serializable]
	public class ParameterInfo : Object
	{
		// Token: 0x06001EEC RID: 7916 RVA: 0x000AC8E4 File Offset: 0x000AAAE4
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterInfo()
		{
			Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ParameterInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr);
			ParameterInfo.NativeFieldInfoPtr_ClassImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "ClassImpl");
			ParameterInfo.NativeFieldInfoPtr_DefaultValueImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "DefaultValueImpl");
			ParameterInfo.NativeFieldInfoPtr_MemberImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "MemberImpl");
			ParameterInfo.NativeFieldInfoPtr_NameImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "NameImpl");
			ParameterInfo.NativeFieldInfoPtr_PositionImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "PositionImpl");
			ParameterInfo.NativeFieldInfoPtr_AttrsImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "AttrsImpl");
			ParameterInfo.NativeFieldInfoPtr_marshalAs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "marshalAs");
			ParameterInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668420);
			ParameterInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668421);
			ParameterInfo.NativeMethodInfoPtr_FormatParameters_Internal_Static_Void_StringBuilder_Il2CppReferenceArray_1_ParameterInfo_CallingConventions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668422);
			ParameterInfo.NativeMethodInfoPtr_get_ParameterType_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668423);
			ParameterInfo.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_ParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668424);
			ParameterInfo.NativeMethodInfoPtr_get_IsIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668425);
			ParameterInfo.NativeMethodInfoPtr_get_IsOptional_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668426);
			ParameterInfo.NativeMethodInfoPtr_get_IsOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668427);
			ParameterInfo.NativeMethodInfoPtr_get_IsRetval_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668428);
			ParameterInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668429);
			ParameterInfo.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668430);
			ParameterInfo.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668431);
			ParameterInfo.NativeMethodInfoPtr_GetDefaultValueImpl_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668432);
			ParameterInfo.NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668433);
			ParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668434);
			ParameterInfo.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668435);
			ParameterInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668436);
			ParameterInfo.NativeMethodInfoPtr_New_Internal_Static_ParameterInfo_ParameterInfo_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100668437);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000ACB08 File Offset: 0x000AAD08
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x000ACB44 File Offset: 0x000AAD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319071, XrefRangeEnd = 319087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x000ACB88 File Offset: 0x000AAD88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319107, RefRangeEnd = 319109, XrefRangeStart = 319087, XrefRangeEnd = 319107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatParameters(StringBuilder sb, Il2CppReferenceArray<ParameterInfo> p, CallingConventions callingConvention, bool serialization)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callingConvention;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serialization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_FormatParameters_Internal_Static_Void_StringBuilder_Il2CppReferenceArray_1_ParameterInfo_CallingConventions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x000ACBEC File Offset: 0x000AADEC
		public unsafe virtual Type ParameterType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_ParameterType_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x000ACC38 File Offset: 0x000AAE38
		public unsafe virtual ParameterAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_ParameterAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x000ACC80 File Offset: 0x000AAE80
		public unsafe bool IsIn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_get_IsIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x000ACCBC File Offset: 0x000AAEBC
		public unsafe bool IsOptional
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 319109, RefRangeEnd = 319110, XrefRangeStart = 319109, XrefRangeEnd = 319109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_get_IsOptional_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x000ACCF8 File Offset: 0x000AAEF8
		public unsafe bool IsOut
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 319110, RefRangeEnd = 319114, XrefRangeStart = 319110, XrefRangeEnd = 319110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_get_IsOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x000ACD34 File Offset: 0x000AAF34
		public unsafe bool IsRetval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_get_IsRetval_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x000ACD70 File Offset: 0x000AAF70
		public unsafe virtual string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x000ACDB4 File Offset: 0x000AAFB4
		public unsafe virtual int Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000ACDFC File Offset: 0x000AAFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319134, RefRangeEnd = 319135, XrefRangeStart = 319114, XrefRangeEnd = 319134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetPseudoCustomAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000ACE3C File Offset: 0x000AB03C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetDefaultValueImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_GetDefaultValueImpl_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x000ACE7C File Offset: 0x000AB07C
		public unsafe virtual Object DefaultValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319135, XrefRangeEnd = 319140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x000ACEC8 File Offset: 0x000AB0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319140, XrefRangeEnd = 319143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000ACF34 File Offset: 0x000AB134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319143, XrefRangeEnd = 319148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x000ACF8C File Offset: 0x000AB18C
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x000ACFF4 File Offset: 0x000AB1F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319152, RefRangeEnd = 319153, XrefRangeStart = 319148, XrefRangeEnd = 319152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParameterInfo New(ParameterInfo pinfo, MemberInfo member)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pinfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_New_Internal_Static_ParameterInfo_ParameterInfo_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterInfo>(intPtr3) : null;
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x0000A99E File Offset: 0x00008B9E
		public ParameterInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x000AD04C File Offset: 0x000AB24C
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x0000A9A7 File Offset: 0x00008BA7
		public unsafe Type ClassImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_ClassImpl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_ClassImpl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x000AD07C File Offset: 0x000AB27C
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x0000A9C6 File Offset: 0x00008BC6
		public unsafe Object DefaultValueImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_DefaultValueImpl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_DefaultValueImpl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x000AD0AC File Offset: 0x000AB2AC
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x0000A9E5 File Offset: 0x00008BE5
		public unsafe MemberInfo MemberImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_MemberImpl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_MemberImpl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x000AD0DC File Offset: 0x000AB2DC
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x0000AA04 File Offset: 0x00008C04
		public unsafe string NameImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_NameImpl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_NameImpl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x000AD104 File Offset: 0x000AB304
		// (set) Token: 0x06001F09 RID: 7945 RVA: 0x0000AA23 File Offset: 0x00008C23
		public unsafe int PositionImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_PositionImpl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_PositionImpl)) = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000AD12C File Offset: 0x000AB32C
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x0000AA3E File Offset: 0x00008C3E
		public unsafe ParameterAttributes AttrsImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_AttrsImpl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_AttrsImpl)) = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000AD154 File Offset: 0x000AB354
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x0000AA59 File Offset: 0x00008C59
		public unsafe MarshalAsAttribute marshalAs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_marshalAs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalAsAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_marshalAs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeFieldInfoPtr_ClassImpl;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValueImpl;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeFieldInfoPtr_MemberImpl;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeFieldInfoPtr_NameImpl;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeFieldInfoPtr_PositionImpl;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeFieldInfoPtr_AttrsImpl;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeFieldInfoPtr_marshalAs;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeMethodInfoPtr_FormatParameters_Internal_Static_Void_StringBuilder_Il2CppReferenceArray_1_ParameterInfo_CallingConventions_Boolean_0;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterType_Public_Virtual_New_get_Type_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_ParameterAttributes_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIn_Public_get_Boolean_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOptional_Public_get_Boolean_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOut_Public_get_Boolean_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRetval_Public_get_Boolean_0;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultValueImpl_Internal_Object_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_New_get_Object_0;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeMethodInfoPtr_New_Internal_Static_ParameterInfo_ParameterInfo_MemberInfo_0;
	}
}
