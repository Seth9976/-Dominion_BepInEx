using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001D4 RID: 468
	public sealed class MonoMethodInfo : ValueType
	{
		// Token: 0x06001E17 RID: 7703 RVA: 0x000A89DC File Offset: 0x000A6BDC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoMethodInfo()
		{
			Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoMethodInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr);
			MonoMethodInfo.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "parent");
			MonoMethodInfo.NativeFieldInfoPtr_ret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "ret");
			MonoMethodInfo.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "attrs");
			MonoMethodInfo.NativeFieldInfoPtr_iattrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "iattrs");
			MonoMethodInfo.NativeFieldInfoPtr_callconv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "callconv");
			MonoMethodInfo.NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668272);
			MonoMethodInfo.NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668273);
			MonoMethodInfo.NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668274);
			MonoMethodInfo.NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668275);
			MonoMethodInfo.NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668276);
			MonoMethodInfo.NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668277);
			MonoMethodInfo.NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668278);
			MonoMethodInfo.NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668279);
			MonoMethodInfo.NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668280);
			MonoMethodInfo.NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100668281);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x000A8B38 File Offset: 0x000A6D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318592, XrefRangeEnd = 318593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_method_info(IntPtr handle, out MonoMethodInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			info = ((intPtr4 == 0) ? null : new MonoMethodInfo(intPtr4));
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000A8B8C File Offset: 0x000A6D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318593, XrefRangeEnd = 318594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int get_method_attributes(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x000A8BCC File Offset: 0x000A6DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318594, XrefRangeEnd = 318595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoMethodInfo GetMethodInfo(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MonoMethodInfo(intPtr);
			}
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x000A8C04 File Offset: 0x000A6E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318595, XrefRangeEnd = 318596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetDeclaringType(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x000A8C44 File Offset: 0x000A6E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318596, XrefRangeEnd = 318597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetReturnType(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x000A8C84 File Offset: 0x000A6E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodAttributes GetAttributes(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000A8CC4 File Offset: 0x000A6EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318597, XrefRangeEnd = 318598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallingConventions GetCallingConvention(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x000A8D04 File Offset: 0x000A6F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318598, XrefRangeEnd = 318599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x000A8D44 File Offset: 0x000A6F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318599, XrefRangeEnd = 318600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterInfo> get_parameter_info(IntPtr handle, MemberInfo member)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x000A8D98 File Offset: 0x000A6F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterInfo> GetParametersInfo(IntPtr handle, MemberInfo member)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0000A5F9 File Offset: 0x000087F9
		public MonoMethodInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0000A602 File Offset: 0x00008802
		public MonoMethodInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x000A8DEC File Offset: 0x000A6FEC
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x0000A614 File Offset: 0x00008814
		public unsafe Type parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x000A8E1C File Offset: 0x000A701C
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x0000A633 File Offset: 0x00008833
		public unsafe Type ret
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_ret);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_ret), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x000A8E4C File Offset: 0x000A704C
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x0000A652 File Offset: 0x00008852
		public unsafe MethodAttributes attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_attrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_attrs)) = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000A8E74 File Offset: 0x000A7074
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x0000A66D File Offset: 0x0000886D
		public unsafe MethodImplAttributes iattrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_iattrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_iattrs)) = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x000A8E9C File Offset: 0x000A709C
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x0000A688 File Offset: 0x00008888
		public unsafe CallingConventions callconv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_callconv);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_callconv)) = value;
			}
		}

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeFieldInfoPtr_ret;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeFieldInfoPtr_iattrs;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeFieldInfoPtr_callconv;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0;
	}
}
