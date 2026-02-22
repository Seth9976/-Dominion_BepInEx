using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000100 RID: 256
	[Serializable]
	public class UnitySerializationHolder : Object
	{
		// Token: 0x060012BC RID: 4796 RVA: 0x00079388 File Offset: 0x00077588
		// Note: this type is marked as 'beforefieldinit'.
		static UnitySerializationHolder()
		{
			Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnitySerializationHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr);
			UnitySerializationHolder.NativeFieldInfoPtr_m_instantiation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_instantiation");
			UnitySerializationHolder.NativeFieldInfoPtr_m_elementTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_elementTypes");
			UnitySerializationHolder.NativeFieldInfoPtr_m_genericParameterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_genericParameterPosition");
			UnitySerializationHolder.NativeFieldInfoPtr_m_declaringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_declaringType");
			UnitySerializationHolder.NativeFieldInfoPtr_m_declaringMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_declaringMethod");
			UnitySerializationHolder.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_data");
			UnitySerializationHolder.NativeFieldInfoPtr_m_assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_assemblyName");
			UnitySerializationHolder.NativeFieldInfoPtr_m_unityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, "m_unityType");
			UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Missing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666571);
			UnitySerializationHolder.NativeMethodInfoPtr_AddElementTypes_Internal_Static_RuntimeType_SerializationInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666572);
			UnitySerializationHolder.NativeMethodInfoPtr_MakeElementTypes_Internal_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666573);
			UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666574);
			UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_String_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666575);
			UnitySerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666576);
			UnitySerializationHolder.NativeMethodInfoPtr_ThrowInsufficientInformation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666577);
			UnitySerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666578);
			UnitySerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr, 100666579);
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0007950C File Offset: 0x0007770C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303200, RefRangeEnd = 303201, XrefRangeStart = 303189, XrefRangeEnd = 303200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUnitySerializationInfo(SerializationInfo info, Missing missing)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(missing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Missing_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00079554 File Offset: 0x00077754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303234, RefRangeEnd = 303235, XrefRangeStart = 303201, XrefRangeEnd = 303234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_AddElementTypes_Internal_Static_RuntimeType_SerializationInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x000795AC File Offset: 0x000777AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303235, XrefRangeEnd = 303238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type MakeElementTypes(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_MakeElementTypes_Internal_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x000795FC File Offset: 0x000777FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303282, RefRangeEnd = 303283, XrefRangeStart = 303238, XrefRangeEnd = 303282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00079644 File Offset: 0x00077844
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 303307, RefRangeEnd = 303311, XrefRangeStart = 303283, XrefRangeEnd = 303307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_String_RuntimeAssembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x000796AC File Offset: 0x000778AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303311, XrefRangeEnd = 303348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySerializationHolder(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySerializationHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00079710 File Offset: 0x00077910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303348, XrefRangeEnd = 303360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInsufficientInformation(string field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySerializationHolder.NativeMethodInfoPtr_ThrowInsufficientInformation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00079754 File Offset: 0x00077954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303360, XrefRangeEnd = 303367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitySerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x000797B8 File Offset: 0x000779B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303367, XrefRangeEnd = 303380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitySerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x000066E4 File Offset: 0x000048E4
		public UnitySerializationHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00079818 File Offset: 0x00077A18
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x000066ED File Offset: 0x000048ED
		public unsafe Il2CppReferenceArray<Type> m_instantiation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_instantiation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_instantiation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00079848 File Offset: 0x00077A48
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x0000670C File Offset: 0x0000490C
		public unsafe Il2CppStructArray<int> m_elementTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_elementTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_elementTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x00079878 File Offset: 0x00077A78
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x0000672B File Offset: 0x0000492B
		public unsafe int m_genericParameterPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_genericParameterPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_genericParameterPosition)) = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x000798A0 File Offset: 0x00077AA0
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x00006746 File Offset: 0x00004946
		public unsafe Type m_declaringType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x000798D0 File Offset: 0x00077AD0
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x00006765 File Offset: 0x00004965
		public unsafe MethodBase m_declaringMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_declaringMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00079900 File Offset: 0x00077B00
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x00006784 File Offset: 0x00004984
		public unsafe string m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_data);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_data), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00079928 File Offset: 0x00077B28
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x000067A3 File Offset: 0x000049A3
		public unsafe string m_assemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_assemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00079950 File Offset: 0x00077B50
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x000067C2 File Offset: 0x000049C2
		public unsafe int m_unityType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_unityType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySerializationHolder.NativeFieldInfoPtr_m_unityType)) = value;
			}
		}

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeFieldInfoPtr_m_instantiation;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeFieldInfoPtr_m_elementTypes;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeFieldInfoPtr_m_genericParameterPosition;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeFieldInfoPtr_m_declaringType;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeFieldInfoPtr_m_declaringMethod;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr_m_assemblyName;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeFieldInfoPtr_m_unityType;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Missing_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_AddElementTypes_Internal_Static_RuntimeType_SerializationInfo_RuntimeType_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_MakeElementTypes_Internal_Type_Type_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_RuntimeType_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitySerializationInfo_Internal_Static_Void_SerializationInfo_Int32_String_RuntimeAssembly_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInsufficientInformation_Private_Void_String_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0;
	}
}
