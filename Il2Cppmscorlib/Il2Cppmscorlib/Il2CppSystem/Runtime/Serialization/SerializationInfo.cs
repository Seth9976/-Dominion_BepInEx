using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000348 RID: 840
	public sealed class SerializationInfo : Object
	{
		// Token: 0x060035D1 RID: 13777 RVA: 0x0010603C File Offset: 0x0010423C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationInfo()
		{
			Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr);
			SerializationInfo.NativeFieldInfoPtr_defaultSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "defaultSize");
			SerializationInfo.NativeFieldInfoPtr_s_mscorlibAssemblySimpleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "s_mscorlibAssemblySimpleName");
			SerializationInfo.NativeFieldInfoPtr_s_mscorlibFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "s_mscorlibFileName");
			SerializationInfo.NativeFieldInfoPtr_m_members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_members");
			SerializationInfo.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_data");
			SerializationInfo.NativeFieldInfoPtr_m_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_types");
			SerializationInfo.NativeFieldInfoPtr_m_nameToIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_nameToIndex");
			SerializationInfo.NativeFieldInfoPtr_m_currMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_currMember");
			SerializationInfo.NativeFieldInfoPtr_m_converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_converter");
			SerializationInfo.NativeFieldInfoPtr_m_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_fullTypeName");
			SerializationInfo.NativeFieldInfoPtr_m_assemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_assemName");
			SerializationInfo.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "objectType");
			SerializationInfo.NativeFieldInfoPtr_isFullTypeNameSetExplicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "isFullTypeNameSetExplicit");
			SerializationInfo.NativeFieldInfoPtr_isAssemblyNameSetExplicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "isAssemblyNameSetExplicit");
			SerializationInfo.NativeFieldInfoPtr_requireSameTokenInPartialTrust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "requireSameTokenInPartialTrust");
			SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671604);
			SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671605);
			SerializationInfo.NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671606);
			SerializationInfo.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671607);
			SerializationInfo.NativeMethodInfoPtr_SetType_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671608);
			SerializationInfo.NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671609);
			SerializationInfo.NativeMethodInfoPtr_DemandForUnsafeAssemblyNameAssignments_Internal_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671610);
			SerializationInfo.NativeMethodInfoPtr_IsAssemblyNameAssignmentSafe_Internal_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671611);
			SerializationInfo.NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671612);
			SerializationInfo.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671613);
			SerializationInfo.NativeMethodInfoPtr_get_IsFullTypeNameSetExplicit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671614);
			SerializationInfo.NativeMethodInfoPtr_get_IsAssemblyNameSetExplicit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671615);
			SerializationInfo.NativeMethodInfoPtr_GetEnumerator_Public_SerializationInfoEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671616);
			SerializationInfo.NativeMethodInfoPtr_ExpandArrays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671617);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671618);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671619);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671620);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671621);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671622);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671623);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671624);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671625);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671626);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671627);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671628);
			SerializationInfo.NativeMethodInfoPtr_AddValueInternal_Internal_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671629);
			SerializationInfo.NativeMethodInfoPtr_UpdateValue_Internal_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671630);
			SerializationInfo.NativeMethodInfoPtr_FindElement_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671631);
			SerializationInfo.NativeMethodInfoPtr_GetElement_Private_Object_String_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671632);
			SerializationInfo.NativeMethodInfoPtr_GetElementNoThrow_Private_Object_String_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671633);
			SerializationInfo.NativeMethodInfoPtr_GetValue_Public_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671634);
			SerializationInfo.NativeMethodInfoPtr_GetValueNoThrow_Internal_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671635);
			SerializationInfo.NativeMethodInfoPtr_GetBoolean_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671636);
			SerializationInfo.NativeMethodInfoPtr_GetInt32_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671637);
			SerializationInfo.NativeMethodInfoPtr_GetInt64_Public_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671638);
			SerializationInfo.NativeMethodInfoPtr_GetSingle_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671639);
			SerializationInfo.NativeMethodInfoPtr_GetString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671640);
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x0010647C File Offset: 0x0010467C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343840, RefRangeEnd = 343842, XrefRangeStart = 343839, XrefRangeEnd = 343840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfo(Type type, IFormatterConverter converter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x001064DC File Offset: 0x001046DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343858, RefRangeEnd = 343860, XrefRangeStart = 343842, XrefRangeEnd = 343858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requireSameTokenInPartialTrust;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x060035D4 RID: 13780 RVA: 0x00106548 File Offset: 0x00104748
		public unsafe string FullTypeName
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x00106580 File Offset: 0x00104780
		public unsafe string AssemblyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x001065B8 File Offset: 0x001047B8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 343861, RefRangeEnd = 343873, XrefRangeStart = 343860, XrefRangeEnd = 343861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_SetType_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x001065FC File Offset: 0x001047FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343873, XrefRangeEnd = 343874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(Il2CppStructArray<byte> a, Il2CppStructArray<byte> b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x00106650 File Offset: 0x00104850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343874, XrefRangeEnd = 343875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalAssemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newAssemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_DemandForUnsafeAssemblyNameAssignments_Internal_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00106698 File Offset: 0x00104898
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 343892, RefRangeEnd = 343897, XrefRangeStart = 343875, XrefRangeEnd = 343892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalAssemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newAssemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_IsAssemblyNameAssignmentSafe_Internal_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x001066EC File Offset: 0x001048EC
		public unsafe int MemberCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x00106728 File Offset: 0x00104928
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060035DC RID: 13788 RVA: 0x00106768 File Offset: 0x00104968
		public unsafe bool IsFullTypeNameSetExplicit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_IsFullTypeNameSetExplicit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060035DD RID: 13789 RVA: 0x001067A4 File Offset: 0x001049A4
		public unsafe bool IsAssemblyNameSetExplicit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_IsAssemblyNameSetExplicit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x001067E0 File Offset: 0x001049E0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 343901, RefRangeEnd = 343916, XrefRangeStart = 343897, XrefRangeEnd = 343901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfoEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetEnumerator_Public_SerializationInfoEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationInfoEnumerator>(intPtr3) : null;
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x00106820 File Offset: 0x00104A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343916, XrefRangeEnd = 343928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandArrays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_ExpandArrays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x00106854 File Offset: 0x00104A54
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 343941, RefRangeEnd = 344029, XrefRangeStart = 343928, XrefRangeEnd = 343941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x001068BC File Offset: 0x00104ABC
		[CallerCount(142)]
		[CachedScanResults(RefRangeStart = 344033, RefRangeEnd = 344175, XrefRangeStart = 344029, XrefRangeEnd = 344033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00106910 File Offset: 0x00104B10
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 344185, RefRangeEnd = 344208, XrefRangeStart = 344175, XrefRangeEnd = 344185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x00106960 File Offset: 0x00104B60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 344218, RefRangeEnd = 344220, XrefRangeStart = 344208, XrefRangeEnd = 344218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x001069B0 File Offset: 0x00104BB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344230, RefRangeEnd = 344233, XrefRangeStart = 344220, XrefRangeEnd = 344230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00106A00 File Offset: 0x00104C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344243, RefRangeEnd = 344244, XrefRangeStart = 344233, XrefRangeEnd = 344243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x00106A50 File Offset: 0x00104C50
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 344254, RefRangeEnd = 344302, XrefRangeStart = 344244, XrefRangeEnd = 344254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x00106AA0 File Offset: 0x00104CA0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 344312, RefRangeEnd = 344320, XrefRangeStart = 344302, XrefRangeEnd = 344312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x00106AF0 File Offset: 0x00104CF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 344330, RefRangeEnd = 344332, XrefRangeStart = 344320, XrefRangeEnd = 344330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x00106B40 File Offset: 0x00104D40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344342, RefRangeEnd = 344343, XrefRangeStart = 344332, XrefRangeEnd = 344342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00106B90 File Offset: 0x00104D90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 344353, RefRangeEnd = 344357, XrefRangeStart = 344343, XrefRangeEnd = 344353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x00106BE0 File Offset: 0x00104DE0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 344378, RefRangeEnd = 344391, XrefRangeStart = 344357, XrefRangeEnd = 344378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValueInternal(string name, Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValueInternal_Internal_Void_String_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x00106C48 File Offset: 0x00104E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344396, RefRangeEnd = 344397, XrefRangeStart = 344391, XrefRangeEnd = 344396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValue(string name, Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_UpdateValue_Internal_Void_String_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x00106CB0 File Offset: 0x00104EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344397, XrefRangeEnd = 344400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_FindElement_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x00106D00 File Offset: 0x00104F00
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 344403, RefRangeEnd = 344409, XrefRangeStart = 344400, XrefRangeEnd = 344403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetElement(string name, out Type foundType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetElement_Private_Object_String_byref_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x00106D74 File Offset: 0x00104F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344409, XrefRangeEnd = 344412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetElementNoThrow(string name, out Type foundType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetElementNoThrow_Private_Object_String_byref_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x00106DE8 File Offset: 0x00104FE8
		[CallerCount(123)]
		[CachedScanResults(RefRangeStart = 344422, RefRangeEnd = 344545, XrefRangeStart = 344412, XrefRangeEnd = 344422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetValue_Public_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x00106E4C File Offset: 0x0010504C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 344551, RefRangeEnd = 344558, XrefRangeStart = 344545, XrefRangeEnd = 344551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValueNoThrow(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetValueNoThrow_Internal_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x00106EB0 File Offset: 0x001050B0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 344569, RefRangeEnd = 344582, XrefRangeStart = 344558, XrefRangeEnd = 344569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBoolean(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetBoolean_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x00106F00 File Offset: 0x00105100
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 344593, RefRangeEnd = 344622, XrefRangeStart = 344582, XrefRangeEnd = 344593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt32(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetInt32_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x00106F50 File Offset: 0x00105150
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 344633, RefRangeEnd = 344640, XrefRangeStart = 344622, XrefRangeEnd = 344633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetInt64(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetInt64_Public_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x00106FA0 File Offset: 0x001051A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344651, RefRangeEnd = 344652, XrefRangeStart = 344640, XrefRangeEnd = 344651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSingle(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetSingle_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x00106FF0 File Offset: 0x001051F0
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 344663, RefRangeEnd = 344727, XrefRangeStart = 344652, XrefRangeEnd = 344663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x000134DD File Offset: 0x000116DD
		public SerializationInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x00107038 File Offset: 0x00105238
		// (set) Token: 0x060035F9 RID: 13817 RVA: 0x000134E6 File Offset: 0x000116E6
		public unsafe static int defaultSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SerializationInfo.NativeFieldInfoPtr_defaultSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationInfo.NativeFieldInfoPtr_defaultSize, (void*)(&value));
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x00107054 File Offset: 0x00105254
		// (set) Token: 0x060035FB RID: 13819 RVA: 0x000134F4 File Offset: 0x000116F4
		public unsafe static string s_mscorlibAssemblySimpleName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibAssemblySimpleName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibAssemblySimpleName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x00107074 File Offset: 0x00105274
		// (set) Token: 0x060035FD RID: 13821 RVA: 0x00013506 File Offset: 0x00011706
		public unsafe static string s_mscorlibFileName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibFileName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibFileName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x00107094 File Offset: 0x00105294
		// (set) Token: 0x060035FF RID: 13823 RVA: 0x00013518 File Offset: 0x00011718
		public unsafe Il2CppStringArray m_members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06003600 RID: 13824 RVA: 0x001070C4 File Offset: 0x001052C4
		// (set) Token: 0x06003601 RID: 13825 RVA: 0x00013537 File Offset: 0x00011737
		public unsafe Il2CppReferenceArray<Object> m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06003602 RID: 13826 RVA: 0x001070F4 File Offset: 0x001052F4
		// (set) Token: 0x06003603 RID: 13827 RVA: 0x00013556 File Offset: 0x00011756
		public unsafe Il2CppReferenceArray<Type> m_types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x00107124 File Offset: 0x00105324
		// (set) Token: 0x06003605 RID: 13829 RVA: 0x00013575 File Offset: 0x00011775
		public unsafe Dictionary<string, int> m_nameToIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_nameToIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_nameToIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x00107154 File Offset: 0x00105354
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x00013594 File Offset: 0x00011794
		public unsafe int m_currMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_currMember);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_currMember)) = value;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06003608 RID: 13832 RVA: 0x0010717C File Offset: 0x0010537C
		// (set) Token: 0x06003609 RID: 13833 RVA: 0x000135AF File Offset: 0x000117AF
		public unsafe IFormatterConverter m_converter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_converter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_converter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x001071AC File Offset: 0x001053AC
		// (set) Token: 0x0600360B RID: 13835 RVA: 0x000135CE File Offset: 0x000117CE
		public unsafe string m_fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x0600360C RID: 13836 RVA: 0x001071D4 File Offset: 0x001053D4
		// (set) Token: 0x0600360D RID: 13837 RVA: 0x000135ED File Offset: 0x000117ED
		public unsafe string m_assemName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_assemName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_assemName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x0600360E RID: 13838 RVA: 0x001071FC File Offset: 0x001053FC
		// (set) Token: 0x0600360F RID: 13839 RVA: 0x0001360C File Offset: 0x0001180C
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06003610 RID: 13840 RVA: 0x0010722C File Offset: 0x0010542C
		// (set) Token: 0x06003611 RID: 13841 RVA: 0x0001362B File Offset: 0x0001182B
		public unsafe bool isFullTypeNameSetExplicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isFullTypeNameSetExplicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isFullTypeNameSetExplicit)) = value;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06003612 RID: 13842 RVA: 0x00107254 File Offset: 0x00105454
		// (set) Token: 0x06003613 RID: 13843 RVA: 0x00013646 File Offset: 0x00011846
		public unsafe bool isAssemblyNameSetExplicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isAssemblyNameSetExplicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isAssemblyNameSetExplicit)) = value;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06003614 RID: 13844 RVA: 0x0010727C File Offset: 0x0010547C
		// (set) Token: 0x06003615 RID: 13845 RVA: 0x00013661 File Offset: 0x00011861
		public unsafe bool requireSameTokenInPartialTrust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_requireSameTokenInPartialTrust);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_requireSameTokenInPartialTrust)) = value;
			}
		}

		// Token: 0x04002D67 RID: 11623
		private static readonly IntPtr NativeFieldInfoPtr_defaultSize;

		// Token: 0x04002D68 RID: 11624
		private static readonly IntPtr NativeFieldInfoPtr_s_mscorlibAssemblySimpleName;

		// Token: 0x04002D69 RID: 11625
		private static readonly IntPtr NativeFieldInfoPtr_s_mscorlibFileName;

		// Token: 0x04002D6A RID: 11626
		private static readonly IntPtr NativeFieldInfoPtr_m_members;

		// Token: 0x04002D6B RID: 11627
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x04002D6C RID: 11628
		private static readonly IntPtr NativeFieldInfoPtr_m_types;

		// Token: 0x04002D6D RID: 11629
		private static readonly IntPtr NativeFieldInfoPtr_m_nameToIndex;

		// Token: 0x04002D6E RID: 11630
		private static readonly IntPtr NativeFieldInfoPtr_m_currMember;

		// Token: 0x04002D6F RID: 11631
		private static readonly IntPtr NativeFieldInfoPtr_m_converter;

		// Token: 0x04002D70 RID: 11632
		private static readonly IntPtr NativeFieldInfoPtr_m_fullTypeName;

		// Token: 0x04002D71 RID: 11633
		private static readonly IntPtr NativeFieldInfoPtr_m_assemName;

		// Token: 0x04002D72 RID: 11634
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x04002D73 RID: 11635
		private static readonly IntPtr NativeFieldInfoPtr_isFullTypeNameSetExplicit;

		// Token: 0x04002D74 RID: 11636
		private static readonly IntPtr NativeFieldInfoPtr_isAssemblyNameSetExplicit;

		// Token: 0x04002D75 RID: 11637
		private static readonly IntPtr NativeFieldInfoPtr_requireSameTokenInPartialTrust;

		// Token: 0x04002D76 RID: 11638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_0;

		// Token: 0x04002D77 RID: 11639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_Boolean_0;

		// Token: 0x04002D78 RID: 11640
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0;

		// Token: 0x04002D79 RID: 11641
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0;

		// Token: 0x04002D7A RID: 11642
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Public_Void_Type_0;

		// Token: 0x04002D7B RID: 11643
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002D7C RID: 11644
		private static readonly IntPtr NativeMethodInfoPtr_DemandForUnsafeAssemblyNameAssignments_Internal_Static_Void_String_String_0;

		// Token: 0x04002D7D RID: 11645
		private static readonly IntPtr NativeMethodInfoPtr_IsAssemblyNameAssignmentSafe_Internal_Static_Boolean_String_String_0;

		// Token: 0x04002D7E RID: 11646
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0;

		// Token: 0x04002D7F RID: 11647
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x04002D80 RID: 11648
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullTypeNameSetExplicit_Public_get_Boolean_0;

		// Token: 0x04002D81 RID: 11649
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAssemblyNameSetExplicit_Public_get_Boolean_0;

		// Token: 0x04002D82 RID: 11650
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_SerializationInfoEnumerator_0;

		// Token: 0x04002D83 RID: 11651
		private static readonly IntPtr NativeMethodInfoPtr_ExpandArrays_Private_Void_0;

		// Token: 0x04002D84 RID: 11652
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Object_Type_0;

		// Token: 0x04002D85 RID: 11653
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Object_0;

		// Token: 0x04002D86 RID: 11654
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Boolean_0;

		// Token: 0x04002D87 RID: 11655
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Char_0;

		// Token: 0x04002D88 RID: 11656
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Byte_0;

		// Token: 0x04002D89 RID: 11657
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Int16_0;

		// Token: 0x04002D8A RID: 11658
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Int32_0;

		// Token: 0x04002D8B RID: 11659
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Int64_0;

		// Token: 0x04002D8C RID: 11660
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_UInt64_0;

		// Token: 0x04002D8D RID: 11661
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Single_0;

		// Token: 0x04002D8E RID: 11662
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_DateTime_0;

		// Token: 0x04002D8F RID: 11663
		private static readonly IntPtr NativeMethodInfoPtr_AddValueInternal_Internal_Void_String_Object_Type_0;

		// Token: 0x04002D90 RID: 11664
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Internal_Void_String_Object_Type_0;

		// Token: 0x04002D91 RID: 11665
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Private_Int32_String_0;

		// Token: 0x04002D92 RID: 11666
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Private_Object_String_byref_Type_0;

		// Token: 0x04002D93 RID: 11667
		private static readonly IntPtr NativeMethodInfoPtr_GetElementNoThrow_Private_Object_String_byref_Type_0;

		// Token: 0x04002D94 RID: 11668
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_Type_0;

		// Token: 0x04002D95 RID: 11669
		private static readonly IntPtr NativeMethodInfoPtr_GetValueNoThrow_Internal_Object_String_Type_0;

		// Token: 0x04002D96 RID: 11670
		private static readonly IntPtr NativeMethodInfoPtr_GetBoolean_Public_Boolean_String_0;

		// Token: 0x04002D97 RID: 11671
		private static readonly IntPtr NativeMethodInfoPtr_GetInt32_Public_Int32_String_0;

		// Token: 0x04002D98 RID: 11672
		private static readonly IntPtr NativeMethodInfoPtr_GetInt64_Public_Int64_String_0;

		// Token: 0x04002D99 RID: 11673
		private static readonly IntPtr NativeMethodInfoPtr_GetSingle_Public_Single_String_0;

		// Token: 0x04002D9A RID: 11674
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_String_0;
	}
}
