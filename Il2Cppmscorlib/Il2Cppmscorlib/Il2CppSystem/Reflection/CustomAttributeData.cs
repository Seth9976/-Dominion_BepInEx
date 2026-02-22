using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C2 RID: 450
	[Serializable]
	public class CustomAttributeData : Object
	{
		// Token: 0x06001CF4 RID: 7412 RVA: 0x000A4068 File Offset: 0x000A2268
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeData()
		{
			Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr);
			CustomAttributeData.NativeFieldInfoPtr_ctorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "ctorInfo");
			CustomAttributeData.NativeFieldInfoPtr_ctorArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "ctorArgs");
			CustomAttributeData.NativeFieldInfoPtr_namedArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "namedArgs");
			CustomAttributeData.NativeFieldInfoPtr_lazyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "lazyData");
			CustomAttributeData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668116);
			CustomAttributeData.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Assembly_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668117);
			CustomAttributeData.NativeMethodInfoPtr_ResolveArgumentsInternal_Private_Static_Void_ConstructorInfo_Assembly_IntPtr_UInt32_byref_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668118);
			CustomAttributeData.NativeMethodInfoPtr_ResolveArguments_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668119);
			CustomAttributeData.NativeMethodInfoPtr_get_Constructor_Public_Virtual_New_get_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668120);
			CustomAttributeData.NativeMethodInfoPtr_get_ConstructorArguments_Public_Virtual_New_get_IList_1_CustomAttributeTypedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668121);
			CustomAttributeData.NativeMethodInfoPtr_get_NamedArguments_Public_Virtual_New_get_IList_1_CustomAttributeNamedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668122);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668123);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668124);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_IList_1_CustomAttributeData_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668125);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668126);
			CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668127);
			CustomAttributeData.NativeMethodInfoPtr_get_AttributeType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668128);
			CustomAttributeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668129);
			CustomAttributeData.NativeMethodInfoPtr_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668130);
			CustomAttributeData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668131);
			CustomAttributeData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, 100668132);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000A423C File Offset: 0x000A243C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000A4278 File Offset: 0x000A2478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317915, XrefRangeEnd = 317920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data_length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Assembly_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000A42F4 File Offset: 0x000A24F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317920, XrefRangeEnd = 317921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out Il2CppReferenceArray<Object> ctorArgs, out Il2CppReferenceArray<Object> namedArgs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data_length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_ResolveArgumentsInternal_Private_Static_Void_ConstructorInfo_Assembly_IntPtr_UInt32_byref_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			ctorArgs = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			namedArgs = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000A43A0 File Offset: 0x000A25A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317944, RefRangeEnd = 317947, XrefRangeStart = 317921, XrefRangeEnd = 317944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_ResolveArguments_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x000A43D4 File Offset: 0x000A25D4
		public unsafe virtual ConstructorInfo Constructor
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_get_Constructor_Public_Virtual_New_get_ConstructorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x000A4420 File Offset: 0x000A2620
		public unsafe virtual IList<CustomAttributeTypedArgument> ConstructorArguments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317947, XrefRangeEnd = 317948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_get_ConstructorArguments_Public_Virtual_New_get_IList_1_CustomAttributeTypedArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeTypedArgument>>(intPtr3) : null;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x000A446C File Offset: 0x000A266C
		public unsafe virtual IList<CustomAttributeNamedArgument> NamedArguments
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317948, XrefRangeEnd = 317949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_get_NamedArguments_Public_Virtual_New_get_IList_1_CustomAttributeNamedArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeNamedArgument>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000A44B8 File Offset: 0x000A26B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317953, RefRangeEnd = 317954, XrefRangeStart = 317949, XrefRangeEnd = 317953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(Assembly target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x000A44FC File Offset: 0x000A26FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 317958, RefRangeEnd = 317963, XrefRangeStart = 317954, XrefRangeEnd = 317958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x000A4540 File Offset: 0x000A2740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317967, RefRangeEnd = 317968, XrefRangeStart = 317963, XrefRangeEnd = 317967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_IList_1_CustomAttributeData_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x000A4584 File Offset: 0x000A2784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317968, XrefRangeEnd = 317972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(Module target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Module_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x000A45C8 File Offset: 0x000A27C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317972, XrefRangeEnd = 317976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_ParameterInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x000A460C File Offset: 0x000A280C
		public unsafe Type AttributeType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.NativeMethodInfoPtr_get_AttributeType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000A464C File Offset: 0x000A284C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317976, XrefRangeEnd = 318038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000A4690 File Offset: 0x000A2890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318043, RefRangeEnd = 318044, XrefRangeStart = 318038, XrefRangeEnd = 318043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> UnboxValues<T>(Il2CppReferenceArray<Object> values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.MethodInfoStoreGeneric_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000A46CC File Offset: 0x000A28CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318044, XrefRangeEnd = 318090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000A4724 File Offset: 0x000A2924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318090, XrefRangeEnd = 318115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomAttributeData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00009F7F File Offset: 0x0000817F
		public CustomAttributeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x000A476C File Offset: 0x000A296C
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x00009F88 File Offset: 0x00008188
		public unsafe ConstructorInfo ctorInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x000A479C File Offset: 0x000A299C
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x00009FA7 File Offset: 0x000081A7
		public unsafe IList<CustomAttributeTypedArgument> ctorArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeTypedArgument>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_ctorArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x000A47CC File Offset: 0x000A29CC
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x00009FC6 File Offset: 0x000081C6
		public unsafe IList<CustomAttributeNamedArgument> namedArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_namedArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeNamedArgument>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_namedArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x000A47FC File Offset: 0x000A29FC
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x00009FE5 File Offset: 0x000081E5
		public unsafe CustomAttributeData.LazyCAttrData lazyData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_lazyData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomAttributeData.LazyCAttrData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.NativeFieldInfoPtr_lazyData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeFieldInfoPtr_ctorInfo;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeFieldInfoPtr_ctorArgs;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeFieldInfoPtr_namedArgs;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeFieldInfoPtr_lazyData;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConstructorInfo_Assembly_IntPtr_UInt32_0;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeMethodInfoPtr_ResolveArgumentsInternal_Private_Static_Void_ConstructorInfo_Assembly_IntPtr_UInt32_byref_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeMethodInfoPtr_ResolveArguments_Private_Void_0;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeMethodInfoPtr_get_Constructor_Public_Virtual_New_get_ConstructorInfo_0;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructorArguments_Public_Virtual_New_get_IList_1_CustomAttributeTypedArgument_0;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeMethodInfoPtr_get_NamedArguments_Public_Virtual_New_get_IList_1_CustomAttributeNamedArgument_0;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Assembly_0;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_MemberInfo_0;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_IList_1_CustomAttributeData_RuntimeType_0;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_Module_0;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_IList_1_CustomAttributeData_ParameterInfo_0;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeType_Public_get_Type_0;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeMethodInfoPtr_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x020005C5 RID: 1477
		public class LazyCAttrData : Object
		{
			// Token: 0x06005110 RID: 20752 RVA: 0x0016AD44 File Offset: 0x00168F44
			// Note: this type is marked as 'beforefieldinit'.
			static LazyCAttrData()
			{
				Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr, "LazyCAttrData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr);
				CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, "assembly");
				CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, "data");
				CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, "data_length");
				CustomAttributeData.LazyCAttrData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr, 100668133);
			}

			// Token: 0x06005111 RID: 20753 RVA: 0x0016ADC0 File Offset: 0x00168FC0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LazyCAttrData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeData.LazyCAttrData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeData.LazyCAttrData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005112 RID: 20754 RVA: 0x0001EDF9 File Offset: 0x0001CFF9
			public LazyCAttrData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014BD RID: 5309
			// (get) Token: 0x06005113 RID: 20755 RVA: 0x0016ADFC File Offset: 0x00168FFC
			// (set) Token: 0x06005114 RID: 20756 RVA: 0x0001EE02 File Offset: 0x0001D002
			public unsafe Assembly assembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_assembly);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_assembly), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014BE RID: 5310
			// (get) Token: 0x06005115 RID: 20757 RVA: 0x0016AE2C File Offset: 0x0016902C
			// (set) Token: 0x06005116 RID: 20758 RVA: 0x0001EE21 File Offset: 0x0001D021
			public unsafe IntPtr data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data)) = value;
				}
			}

			// Token: 0x170014BF RID: 5311
			// (get) Token: 0x06005117 RID: 20759 RVA: 0x0016AE54 File Offset: 0x00169054
			// (set) Token: 0x06005118 RID: 20760 RVA: 0x0001EE3C File Offset: 0x0001D03C
			public unsafe uint data_length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeData.LazyCAttrData.NativeFieldInfoPtr_data_length)) = value;
				}
			}

			// Token: 0x040041C4 RID: 16836
			private static readonly IntPtr NativeFieldInfoPtr_assembly;

			// Token: 0x040041C5 RID: 16837
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040041C6 RID: 16838
			private static readonly IntPtr NativeFieldInfoPtr_data_length;

			// Token: 0x040041C7 RID: 16839
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005C6 RID: 1478
		private sealed class MethodInfoStoreGeneric_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x040041C8 RID: 16840
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeData.NativeMethodInfoPtr_UnboxValues_Private_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<CustomAttributeData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
