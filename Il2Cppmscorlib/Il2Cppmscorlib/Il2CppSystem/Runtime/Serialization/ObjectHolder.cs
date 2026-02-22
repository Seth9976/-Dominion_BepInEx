using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000334 RID: 820
	public sealed class ObjectHolder : Object
	{
		// Token: 0x060034D9 RID: 13529 RVA: 0x00102774 File Offset: 0x00100974
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectHolder()
		{
			Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr);
			ObjectHolder.NativeFieldInfoPtr_m_object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_object");
			ObjectHolder.NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_id");
			ObjectHolder.NativeFieldInfoPtr_m_missingElementsRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_missingElementsRemaining");
			ObjectHolder.NativeFieldInfoPtr_m_missingDecendents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_missingDecendents");
			ObjectHolder.NativeFieldInfoPtr_m_serInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_serInfo");
			ObjectHolder.NativeFieldInfoPtr_m_surrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_surrogate");
			ObjectHolder.NativeFieldInfoPtr_m_missingElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_missingElements");
			ObjectHolder.NativeFieldInfoPtr_m_dependentObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_dependentObjects");
			ObjectHolder.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_next");
			ObjectHolder.NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_flags");
			ObjectHolder.NativeFieldInfoPtr_m_markForFixupWhenAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_markForFixupWhenAvailable");
			ObjectHolder.NativeFieldInfoPtr_m_valueFixup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_valueFixup");
			ObjectHolder.NativeFieldInfoPtr_m_typeLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_typeLoad");
			ObjectHolder.NativeFieldInfoPtr_m_reachable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_reachable");
			ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671486);
			ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Object_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671487);
			ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671488);
			ObjectHolder.NativeMethodInfoPtr_IncrementDescendentFixups_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671489);
			ObjectHolder.NativeMethodInfoPtr_DecrementFixupsRemaining_Internal_Void_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671490);
			ObjectHolder.NativeMethodInfoPtr_RemoveDependency_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671491);
			ObjectHolder.NativeMethodInfoPtr_AddFixup_Internal_Void_FixupHolder_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671492);
			ObjectHolder.NativeMethodInfoPtr_UpdateDescendentDependencyChain_Private_Void_Int32_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671493);
			ObjectHolder.NativeMethodInfoPtr_AddDependency_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671494);
			ObjectHolder.NativeMethodInfoPtr_UpdateData_Internal_Void_Object_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671495);
			ObjectHolder.NativeMethodInfoPtr_MarkForCompletionWhenAvailable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671496);
			ObjectHolder.NativeMethodInfoPtr_SetFlags_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671497);
			ObjectHolder.NativeMethodInfoPtr_get_IsIncompleteObjectReference_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671498);
			ObjectHolder.NativeMethodInfoPtr_set_IsIncompleteObjectReference_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671499);
			ObjectHolder.NativeMethodInfoPtr_get_RequiresDelayedFixup_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671500);
			ObjectHolder.NativeMethodInfoPtr_get_RequiresValueTypeFixup_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671501);
			ObjectHolder.NativeMethodInfoPtr_get_ValueTypeFixupPerformed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671502);
			ObjectHolder.NativeMethodInfoPtr_set_ValueTypeFixupPerformed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671503);
			ObjectHolder.NativeMethodInfoPtr_get_HasISerializable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671504);
			ObjectHolder.NativeMethodInfoPtr_get_HasSurrogate_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671505);
			ObjectHolder.NativeMethodInfoPtr_get_CanSurrogatedObjectValueChange_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671506);
			ObjectHolder.NativeMethodInfoPtr_get_CanObjectValueChange_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671507);
			ObjectHolder.NativeMethodInfoPtr_get_DirectlyDependentObjects_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671508);
			ObjectHolder.NativeMethodInfoPtr_get_TotalDependentObjects_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671509);
			ObjectHolder.NativeMethodInfoPtr_get_Reachable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671510);
			ObjectHolder.NativeMethodInfoPtr_set_Reachable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671511);
			ObjectHolder.NativeMethodInfoPtr_get_TypeLoadExceptionReachable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671512);
			ObjectHolder.NativeMethodInfoPtr_get_TypeLoadException_Internal_get_TypeLoadExceptionHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671513);
			ObjectHolder.NativeMethodInfoPtr_set_TypeLoadException_Internal_set_Void_TypeLoadExceptionHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671514);
			ObjectHolder.NativeMethodInfoPtr_get_ObjectValue_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671515);
			ObjectHolder.NativeMethodInfoPtr_SetObjectValue_Internal_Void_Object_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671516);
			ObjectHolder.NativeMethodInfoPtr_get_SerializationInfo_Internal_get_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671517);
			ObjectHolder.NativeMethodInfoPtr_set_SerializationInfo_Internal_set_Void_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671518);
			ObjectHolder.NativeMethodInfoPtr_get_Surrogate_Internal_get_ISerializationSurrogate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671519);
			ObjectHolder.NativeMethodInfoPtr_get_DependentObjects_Internal_get_LongList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671520);
			ObjectHolder.NativeMethodInfoPtr_set_DependentObjects_Internal_set_Void_LongList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671521);
			ObjectHolder.NativeMethodInfoPtr_get_RequiresSerInfoFixup_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671522);
			ObjectHolder.NativeMethodInfoPtr_set_RequiresSerInfoFixup_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671523);
			ObjectHolder.NativeMethodInfoPtr_get_ValueFixup_Internal_get_ValueTypeFixupInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671524);
			ObjectHolder.NativeMethodInfoPtr_get_CompletelyFixed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671525);
			ObjectHolder.NativeMethodInfoPtr_get_ContainerID_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671526);
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x00102BF0 File Offset: 0x00100DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343243, XrefRangeEnd = 343244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder(long objID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x00102C38 File Offset: 0x00100E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343244, XrefRangeEnd = 343262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder(Object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Il2CppStructArray<int> arrayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Object_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x00102CEC File Offset: 0x00100EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343262, XrefRangeEnd = 343266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Il2CppStructArray<int> arrayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x00102DA0 File Offset: 0x00100FA0
		[CallerCount(0)]
		public unsafe void IncrementDescendentFixups(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_IncrementDescendentFixups_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x00102DE0 File Offset: 0x00100FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343266, XrefRangeEnd = 343268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecrementFixupsRemaining(ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_DecrementFixupsRemaining_Internal_Void_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x00102E24 File Offset: 0x00101024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343268, XrefRangeEnd = 343270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDependency(long id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_RemoveDependency_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x00102E64 File Offset: 0x00101064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343270, XrefRangeEnd = 343276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFixup(FixupHolder fixup, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_AddFixup_Internal_Void_FixupHolder_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x00102EB8 File Offset: 0x001010B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343276, XrefRangeEnd = 343278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDescendentDependencyChain(int amount, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_UpdateDescendentDependencyChain_Private_Void_Int32_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00102F08 File Offset: 0x00101108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343278, XrefRangeEnd = 343284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDependency(long dependentObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dependentObject;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_AddDependency_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00102F48 File Offset: 0x00101148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343296, RefRangeEnd = 343297, XrefRangeStart = 343284, XrefRangeEnd = 343296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateData(Object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, Il2CppStructArray<int> arrayIndex, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_UpdateData_Internal_Void_Object_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00102FF8 File Offset: 0x001011F8
		[CallerCount(0)]
		public unsafe void MarkForCompletionWhenAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_MarkForCompletionWhenAvailable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x0010302C File Offset: 0x0010122C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 343304, RefRangeEnd = 343307, XrefRangeStart = 343297, XrefRangeEnd = 343304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_SetFlags_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060034E6 RID: 13542 RVA: 0x00103060 File Offset: 0x00101260
		// (set) Token: 0x060034E7 RID: 13543 RVA: 0x0010309C File Offset: 0x0010129C
		public unsafe bool IsIncompleteObjectReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_IsIncompleteObjectReference_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_IsIncompleteObjectReference_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060034E8 RID: 13544 RVA: 0x001030DC File Offset: 0x001012DC
		public unsafe bool RequiresDelayedFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_RequiresDelayedFixup_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x00103118 File Offset: 0x00101318
		public unsafe bool RequiresValueTypeFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_RequiresValueTypeFixup_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x00103154 File Offset: 0x00101354
		// (set) Token: 0x060034EB RID: 13547 RVA: 0x00103190 File Offset: 0x00101390
		public unsafe bool ValueTypeFixupPerformed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ValueTypeFixupPerformed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_ValueTypeFixupPerformed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x001031D0 File Offset: 0x001013D0
		public unsafe bool HasISerializable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_HasISerializable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060034ED RID: 13549 RVA: 0x0010320C File Offset: 0x0010140C
		public unsafe bool HasSurrogate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_HasSurrogate_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x00103248 File Offset: 0x00101448
		public unsafe bool CanSurrogatedObjectValueChange
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 343309, RefRangeEnd = 343311, XrefRangeStart = 343307, XrefRangeEnd = 343309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_CanSurrogatedObjectValueChange_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060034EF RID: 13551 RVA: 0x00103284 File Offset: 0x00101484
		public unsafe bool CanObjectValueChange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_CanObjectValueChange_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x001032C0 File Offset: 0x001014C0
		public unsafe int DirectlyDependentObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_DirectlyDependentObjects_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060034F1 RID: 13553 RVA: 0x001032FC File Offset: 0x001014FC
		public unsafe int TotalDependentObjects
		{
			[CallerCount(114)]
			[CachedScanResults(RefRangeStart = 312007, RefRangeEnd = 312121, XrefRangeStart = 312007, XrefRangeEnd = 312121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_TotalDependentObjects_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x00103338 File Offset: 0x00101538
		// (set) Token: 0x060034F3 RID: 13555 RVA: 0x00103374 File Offset: 0x00101574
		public unsafe bool Reachable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_Reachable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_Reachable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x001033B4 File Offset: 0x001015B4
		public unsafe bool TypeLoadExceptionReachable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_TypeLoadExceptionReachable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060034F5 RID: 13557 RVA: 0x001033F0 File Offset: 0x001015F0
		// (set) Token: 0x060034F6 RID: 13558 RVA: 0x00103430 File Offset: 0x00101630
		public unsafe TypeLoadExceptionHolder TypeLoadException
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_TypeLoadException_Internal_get_TypeLoadExceptionHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeLoadExceptionHolder>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_TypeLoadException_Internal_set_Void_TypeLoadExceptionHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x00103474 File Offset: 0x00101674
		public unsafe Object ObjectValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ObjectValue_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x001034B4 File Offset: 0x001016B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343314, RefRangeEnd = 343315, XrefRangeStart = 343311, XrefRangeEnd = 343314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectValue(Object obj, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_SetObjectValue_Internal_Void_Object_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060034F9 RID: 13561 RVA: 0x00103508 File Offset: 0x00101708
		// (set) Token: 0x060034FA RID: 13562 RVA: 0x00103548 File Offset: 0x00101748
		public unsafe SerializationInfo SerializationInfo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_SerializationInfo_Internal_get_SerializationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_SerializationInfo_Internal_set_Void_SerializationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060034FB RID: 13563 RVA: 0x0010358C File Offset: 0x0010178C
		public unsafe ISerializationSurrogate Surrogate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_Surrogate_Internal_get_ISerializationSurrogate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr3) : null;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x001035CC File Offset: 0x001017CC
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x0010360C File Offset: 0x0010180C
		public unsafe LongList DependentObjects
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_DependentObjects_Internal_get_LongList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LongList>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_DependentObjects_Internal_set_Void_LongList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x00103650 File Offset: 0x00101850
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x0010368C File Offset: 0x0010188C
		public unsafe bool RequiresSerInfoFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_RequiresSerInfoFixup_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_RequiresSerInfoFixup_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x001036CC File Offset: 0x001018CC
		public unsafe ValueTypeFixupInfo ValueFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ValueFixup_Internal_get_ValueTypeFixupInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueTypeFixupInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06003501 RID: 13569 RVA: 0x0010370C File Offset: 0x0010190C
		public unsafe bool CompletelyFixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_CompletelyFixed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x00103748 File Offset: 0x00101948
		public unsafe long ContainerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ContainerID_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00012DE7 File Offset: 0x00010FE7
		public ObjectHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x00103784 File Offset: 0x00101984
		// (set) Token: 0x06003505 RID: 13573 RVA: 0x00012DF0 File Offset: 0x00010FF0
		public unsafe Object m_object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x001037B4 File Offset: 0x001019B4
		// (set) Token: 0x06003507 RID: 13575 RVA: 0x00012E0F File Offset: 0x0001100F
		public unsafe long m_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_id)) = value;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x001037DC File Offset: 0x001019DC
		// (set) Token: 0x06003509 RID: 13577 RVA: 0x00012E2A File Offset: 0x0001102A
		public unsafe int m_missingElementsRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElementsRemaining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElementsRemaining)) = value;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x00103804 File Offset: 0x00101A04
		// (set) Token: 0x0600350B RID: 13579 RVA: 0x00012E45 File Offset: 0x00011045
		public unsafe int m_missingDecendents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingDecendents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingDecendents)) = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x0010382C File Offset: 0x00101A2C
		// (set) Token: 0x0600350D RID: 13581 RVA: 0x00012E60 File Offset: 0x00011060
		public unsafe SerializationInfo m_serInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_serInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_serInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x0010385C File Offset: 0x00101A5C
		// (set) Token: 0x0600350F RID: 13583 RVA: 0x00012E7F File Offset: 0x0001107F
		public unsafe ISerializationSurrogate m_surrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_surrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_surrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x0010388C File Offset: 0x00101A8C
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x00012E9E File Offset: 0x0001109E
		public unsafe FixupHolderList m_missingElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FixupHolderList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x001038BC File Offset: 0x00101ABC
		// (set) Token: 0x06003513 RID: 13587 RVA: 0x00012EBD File Offset: 0x000110BD
		public unsafe LongList m_dependentObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_dependentObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LongList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_dependentObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x001038EC File Offset: 0x00101AEC
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x00012EDC File Offset: 0x000110DC
		public unsafe ObjectHolder m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x0010391C File Offset: 0x00101B1C
		// (set) Token: 0x06003517 RID: 13591 RVA: 0x00012EFB File Offset: 0x000110FB
		public unsafe int m_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_flags)) = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x00103944 File Offset: 0x00101B44
		// (set) Token: 0x06003519 RID: 13593 RVA: 0x00012F16 File Offset: 0x00011116
		public unsafe bool m_markForFixupWhenAvailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_markForFixupWhenAvailable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_markForFixupWhenAvailable)) = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x0600351A RID: 13594 RVA: 0x0010396C File Offset: 0x00101B6C
		// (set) Token: 0x0600351B RID: 13595 RVA: 0x00012F31 File Offset: 0x00011131
		public unsafe ValueTypeFixupInfo m_valueFixup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_valueFixup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTypeFixupInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_valueFixup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x0600351C RID: 13596 RVA: 0x0010399C File Offset: 0x00101B9C
		// (set) Token: 0x0600351D RID: 13597 RVA: 0x00012F50 File Offset: 0x00011150
		public unsafe TypeLoadExceptionHolder m_typeLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_typeLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeLoadExceptionHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_typeLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x0600351E RID: 13598 RVA: 0x001039CC File Offset: 0x00101BCC
		// (set) Token: 0x0600351F RID: 13599 RVA: 0x00012F6F File Offset: 0x0001116F
		public unsafe bool m_reachable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_reachable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_reachable)) = value;
			}
		}

		// Token: 0x04002CC5 RID: 11461
		private static readonly IntPtr NativeFieldInfoPtr_m_object;

		// Token: 0x04002CC6 RID: 11462
		private static readonly IntPtr NativeFieldInfoPtr_m_id;

		// Token: 0x04002CC7 RID: 11463
		private static readonly IntPtr NativeFieldInfoPtr_m_missingElementsRemaining;

		// Token: 0x04002CC8 RID: 11464
		private static readonly IntPtr NativeFieldInfoPtr_m_missingDecendents;

		// Token: 0x04002CC9 RID: 11465
		private static readonly IntPtr NativeFieldInfoPtr_m_serInfo;

		// Token: 0x04002CCA RID: 11466
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogate;

		// Token: 0x04002CCB RID: 11467
		private static readonly IntPtr NativeFieldInfoPtr_m_missingElements;

		// Token: 0x04002CCC RID: 11468
		private static readonly IntPtr NativeFieldInfoPtr_m_dependentObjects;

		// Token: 0x04002CCD RID: 11469
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x04002CCE RID: 11470
		private static readonly IntPtr NativeFieldInfoPtr_m_flags;

		// Token: 0x04002CCF RID: 11471
		private static readonly IntPtr NativeFieldInfoPtr_m_markForFixupWhenAvailable;

		// Token: 0x04002CD0 RID: 11472
		private static readonly IntPtr NativeFieldInfoPtr_m_valueFixup;

		// Token: 0x04002CD1 RID: 11473
		private static readonly IntPtr NativeFieldInfoPtr_m_typeLoad;

		// Token: 0x04002CD2 RID: 11474
		private static readonly IntPtr NativeFieldInfoPtr_m_reachable;

		// Token: 0x04002CD3 RID: 11475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_0;

		// Token: 0x04002CD4 RID: 11476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002CD5 RID: 11477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002CD6 RID: 11478
		private static readonly IntPtr NativeMethodInfoPtr_IncrementDescendentFixups_Private_Void_Int32_0;

		// Token: 0x04002CD7 RID: 11479
		private static readonly IntPtr NativeMethodInfoPtr_DecrementFixupsRemaining_Internal_Void_ObjectManager_0;

		// Token: 0x04002CD8 RID: 11480
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDependency_Internal_Void_Int64_0;

		// Token: 0x04002CD9 RID: 11481
		private static readonly IntPtr NativeMethodInfoPtr_AddFixup_Internal_Void_FixupHolder_ObjectManager_0;

		// Token: 0x04002CDA RID: 11482
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDescendentDependencyChain_Private_Void_Int32_ObjectManager_0;

		// Token: 0x04002CDB RID: 11483
		private static readonly IntPtr NativeMethodInfoPtr_AddDependency_Internal_Void_Int64_0;

		// Token: 0x04002CDC RID: 11484
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Internal_Void_Object_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_ObjectManager_0;

		// Token: 0x04002CDD RID: 11485
		private static readonly IntPtr NativeMethodInfoPtr_MarkForCompletionWhenAvailable_Internal_Void_0;

		// Token: 0x04002CDE RID: 11486
		private static readonly IntPtr NativeMethodInfoPtr_SetFlags_Internal_Void_0;

		// Token: 0x04002CDF RID: 11487
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIncompleteObjectReference_Internal_get_Boolean_0;

		// Token: 0x04002CE0 RID: 11488
		private static readonly IntPtr NativeMethodInfoPtr_set_IsIncompleteObjectReference_Internal_set_Void_Boolean_0;

		// Token: 0x04002CE1 RID: 11489
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresDelayedFixup_Internal_get_Boolean_0;

		// Token: 0x04002CE2 RID: 11490
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresValueTypeFixup_Internal_get_Boolean_0;

		// Token: 0x04002CE3 RID: 11491
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueTypeFixupPerformed_Internal_get_Boolean_0;

		// Token: 0x04002CE4 RID: 11492
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueTypeFixupPerformed_Internal_set_Void_Boolean_0;

		// Token: 0x04002CE5 RID: 11493
		private static readonly IntPtr NativeMethodInfoPtr_get_HasISerializable_Internal_get_Boolean_0;

		// Token: 0x04002CE6 RID: 11494
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSurrogate_Internal_get_Boolean_0;

		// Token: 0x04002CE7 RID: 11495
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSurrogatedObjectValueChange_Internal_get_Boolean_0;

		// Token: 0x04002CE8 RID: 11496
		private static readonly IntPtr NativeMethodInfoPtr_get_CanObjectValueChange_Internal_get_Boolean_0;

		// Token: 0x04002CE9 RID: 11497
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectlyDependentObjects_Internal_get_Int32_0;

		// Token: 0x04002CEA RID: 11498
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDependentObjects_Internal_get_Int32_0;

		// Token: 0x04002CEB RID: 11499
		private static readonly IntPtr NativeMethodInfoPtr_get_Reachable_Internal_get_Boolean_0;

		// Token: 0x04002CEC RID: 11500
		private static readonly IntPtr NativeMethodInfoPtr_set_Reachable_Internal_set_Void_Boolean_0;

		// Token: 0x04002CED RID: 11501
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeLoadExceptionReachable_Internal_get_Boolean_0;

		// Token: 0x04002CEE RID: 11502
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeLoadException_Internal_get_TypeLoadExceptionHolder_0;

		// Token: 0x04002CEF RID: 11503
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeLoadException_Internal_set_Void_TypeLoadExceptionHolder_0;

		// Token: 0x04002CF0 RID: 11504
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectValue_Internal_get_Object_0;

		// Token: 0x04002CF1 RID: 11505
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectValue_Internal_Void_Object_ObjectManager_0;

		// Token: 0x04002CF2 RID: 11506
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationInfo_Internal_get_SerializationInfo_0;

		// Token: 0x04002CF3 RID: 11507
		private static readonly IntPtr NativeMethodInfoPtr_set_SerializationInfo_Internal_set_Void_SerializationInfo_0;

		// Token: 0x04002CF4 RID: 11508
		private static readonly IntPtr NativeMethodInfoPtr_get_Surrogate_Internal_get_ISerializationSurrogate_0;

		// Token: 0x04002CF5 RID: 11509
		private static readonly IntPtr NativeMethodInfoPtr_get_DependentObjects_Internal_get_LongList_0;

		// Token: 0x04002CF6 RID: 11510
		private static readonly IntPtr NativeMethodInfoPtr_set_DependentObjects_Internal_set_Void_LongList_0;

		// Token: 0x04002CF7 RID: 11511
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresSerInfoFixup_Internal_get_Boolean_0;

		// Token: 0x04002CF8 RID: 11512
		private static readonly IntPtr NativeMethodInfoPtr_set_RequiresSerInfoFixup_Internal_set_Void_Boolean_0;

		// Token: 0x04002CF9 RID: 11513
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueFixup_Internal_get_ValueTypeFixupInfo_0;

		// Token: 0x04002CFA RID: 11514
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletelyFixed_Internal_get_Boolean_0;

		// Token: 0x04002CFB RID: 11515
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainerID_Internal_get_Int64_0;
	}
}
