using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x0200052B RID: 1323
	public sealed class DynamicMethod : MethodInfo
	{
		// Token: 0x06004D44 RID: 19780 RVA: 0x0015CED8 File Offset: 0x0015B0D8
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicMethod()
		{
			Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "DynamicMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr);
			DynamicMethod.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_MethodAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674545);
			DynamicMethod.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674546);
			DynamicMethod.NativeMethodInfoPtr_get_MethodHandle_Public_Virtual_get_RuntimeMethodHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674547);
			DynamicMethod.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674548);
			DynamicMethod.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674549);
			DynamicMethod.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674550);
			DynamicMethod.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674551);
			DynamicMethod.NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Virtual_MethodImplAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674552);
			DynamicMethod.NativeMethodInfoPtr_GetParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674553);
			DynamicMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674554);
			DynamicMethod.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethod>.NativeClassPtr, 100674555);
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06004D45 RID: 19781 RVA: 0x0015CFE4 File Offset: 0x0015B1E4
		public unsafe override MethodAttributes Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375075, XrefRangeEnd = 375078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_MethodAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06004D46 RID: 19782 RVA: 0x0015D020 File Offset: 0x0015B220
		public unsafe override Type DeclaringType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375078, XrefRangeEnd = 375081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06004D47 RID: 19783 RVA: 0x0015D060 File Offset: 0x0015B260
		public unsafe override RuntimeMethodHandle MethodHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375081, XrefRangeEnd = 375084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_get_MethodHandle_Public_Virtual_get_RuntimeMethodHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06004D48 RID: 19784 RVA: 0x0015D09C File Offset: 0x0015B29C
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375084, XrefRangeEnd = 375087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06004D49 RID: 19785 RVA: 0x0015D0D4 File Offset: 0x0015B2D4
		public unsafe override Type ReflectedType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375087, XrefRangeEnd = 375090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x0015D114 File Offset: 0x0015B314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375090, XrefRangeEnd = 375093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x0015D160 File Offset: 0x0015B360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375093, XrefRangeEnd = 375096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x0015D1C0 File Offset: 0x0015B3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375096, XrefRangeEnd = 375099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodImplAttributes GetMethodImplementationFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Virtual_MethodImplAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x0015D1FC File Offset: 0x0015B3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375099, XrefRangeEnd = 375102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ParameterInfo> GetParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_GetParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x0015D23C File Offset: 0x0015B43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375102, XrefRangeEnd = 375105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x0015D2D4 File Offset: 0x0015B4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375105, XrefRangeEnd = 375108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethod.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x0001D365 File Offset: 0x0001B565
		public DynamicMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003E28 RID: 15912
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_MethodAttributes_0;

		// Token: 0x04003E29 RID: 15913
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0;

		// Token: 0x04003E2A RID: 15914
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodHandle_Public_Virtual_get_RuntimeMethodHandle_0;

		// Token: 0x04003E2B RID: 15915
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04003E2C RID: 15916
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0;

		// Token: 0x04003E2D RID: 15917
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04003E2E RID: 15918
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04003E2F RID: 15919
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Virtual_MethodImplAttributes_0;

		// Token: 0x04003E30 RID: 15920
		private static readonly IntPtr NativeMethodInfoPtr_GetParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003E31 RID: 15921
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x04003E32 RID: 15922
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;
	}
}
