using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000333 RID: 819
	public class ObjectManager : Object
	{
		// Token: 0x060034AA RID: 13482 RVA: 0x001018C4 File Offset: 0x000FFAC4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectManager()
		{
			Il2CppClassPointerStore<ObjectManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr);
			ObjectManager.NativeFieldInfoPtr_m_onDeserializationHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_onDeserializationHandler");
			ObjectManager.NativeFieldInfoPtr_m_onDeserializedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_onDeserializedHandler");
			ObjectManager.NativeFieldInfoPtr_m_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_objects");
			ObjectManager.NativeFieldInfoPtr_m_topObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_topObject");
			ObjectManager.NativeFieldInfoPtr_m_specialFixupObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_specialFixupObjects");
			ObjectManager.NativeFieldInfoPtr_m_fixupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_fixupCount");
			ObjectManager.NativeFieldInfoPtr_m_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_selector");
			ObjectManager.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_context");
			ObjectManager.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671457);
			ObjectManager.NativeMethodInfoPtr_CanCallGetType_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671458);
			ObjectManager.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671459);
			ObjectManager.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671460);
			ObjectManager.NativeMethodInfoPtr_get_SpecialFixupObjects_Internal_get_ObjectHolderList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671461);
			ObjectManager.NativeMethodInfoPtr_FindObjectHolder_Internal_ObjectHolder_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671462);
			ObjectManager.NativeMethodInfoPtr_FindOrCreateObjectHolder_Internal_ObjectHolder_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671463);
			ObjectManager.NativeMethodInfoPtr_AddObjectHolder_Private_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671464);
			ObjectManager.NativeMethodInfoPtr_GetCompletionInfo_Private_Boolean_FixupHolder_byref_ObjectHolder_byref_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671465);
			ObjectManager.NativeMethodInfoPtr_FixupSpecialObject_Private_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671466);
			ObjectManager.NativeMethodInfoPtr_ResolveObjectReference_Private_Boolean_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671467);
			ObjectManager.NativeMethodInfoPtr_DoValueTypeFixup_Private_Boolean_FieldInfo_ObjectHolder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671468);
			ObjectManager.NativeMethodInfoPtr_CompleteObject_Internal_Void_ObjectHolder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671469);
			ObjectManager.NativeMethodInfoPtr_DoNewlyRegisteredObjectFixups_Private_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671470);
			ObjectManager.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671471);
			ObjectManager.NativeMethodInfoPtr_RegisterString_Internal_Void_String_Int64_SerializationInfo_Int64_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671472);
			ObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_Int64_SerializationInfo_Int64_MemberInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671473);
			ObjectManager.NativeMethodInfoPtr_CompleteISerializableObject_Internal_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671474);
			ObjectManager.NativeMethodInfoPtr_GetConstructor_Internal_Static_RuntimeConstructorInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671475);
			ObjectManager.NativeMethodInfoPtr_DoFixups_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671476);
			ObjectManager.NativeMethodInfoPtr_RegisterFixup_Private_Void_FixupHolder_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671477);
			ObjectManager.NativeMethodInfoPtr_RecordFixup_Public_Virtual_New_Void_Int64_MemberInfo_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671478);
			ObjectManager.NativeMethodInfoPtr_RecordDelayedFixup_Public_Virtual_New_Void_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671479);
			ObjectManager.NativeMethodInfoPtr_RecordArrayElementFixup_Public_Virtual_New_Void_Int64_Il2CppStructArray_1_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671480);
			ObjectManager.NativeMethodInfoPtr_RaiseDeserializationEvent_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671481);
			ObjectManager.NativeMethodInfoPtr_AddOnDeserialization_Internal_Virtual_New_Void_DeserializationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671482);
			ObjectManager.NativeMethodInfoPtr_AddOnDeserialized_Internal_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671483);
			ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializedEvent_Internal_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671484);
			ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializingEvent_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671485);
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00101BD8 File Offset: 0x000FFDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342855, XrefRangeEnd = 342858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkSecurity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCrossAppDomain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00101C58 File Offset: 0x000FFE58
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCallGetType(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_CanCallGetType_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x00101CEC File Offset: 0x000FFEEC
		// (set) Token: 0x060034AD RID: 13485 RVA: 0x00101CA8 File Offset: 0x000FFEA8
		public unsafe Object TopObject
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060034AF RID: 13487 RVA: 0x00101D2C File Offset: 0x000FFF2C
		public unsafe ObjectHolderList SpecialFixupObjects
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 342864, RefRangeEnd = 342867, XrefRangeStart = 342858, XrefRangeEnd = 342864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_get_SpecialFixupObjects_Internal_get_ObjectHolderList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolderList>(intPtr3) : null;
			}
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x00101D6C File Offset: 0x000FFF6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 342867, RefRangeEnd = 342870, XrefRangeStart = 342867, XrefRangeEnd = 342867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder FindObjectHolder(long objectID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_FindObjectHolder_Internal_ObjectHolder_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr3) : null;
			}
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x00101DB8 File Offset: 0x000FFFB8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 342875, RefRangeEnd = 342885, XrefRangeStart = 342870, XrefRangeEnd = 342875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder FindOrCreateObjectHolder(long objectID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_FindOrCreateObjectHolder_Internal_ObjectHolder_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr3) : null;
			}
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x00101E04 File Offset: 0x00100004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342891, RefRangeEnd = 342893, XrefRangeStart = 342885, XrefRangeEnd = 342891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddObjectHolder(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_AddObjectHolder_Private_Void_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x00101E48 File Offset: 0x00100048
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342898, RefRangeEnd = 342900, XrefRangeStart = 342893, XrefRangeEnd = 342898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out Object member, bool bThrowIfMissing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bThrowIfMissing;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_GetCompletionInfo_Private_Boolean_FixupHolder_byref_ObjectHolder_byref_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			holder = ((intPtr5 == 0) ? null : new ObjectHolder(intPtr5));
			IntPtr intPtr6 = intPtr2;
			member = ((intPtr6 == 0) ? null : new Object(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00101EEC File Offset: 0x001000EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342930, RefRangeEnd = 342931, XrefRangeStart = 342900, XrefRangeEnd = 342930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupSpecialObject(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_FixupSpecialObject_Private_Void_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00101F30 File Offset: 0x00100130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342944, RefRangeEnd = 342945, XrefRangeStart = 342931, XrefRangeEnd = 342944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveObjectReference(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_ResolveObjectReference_Private_Boolean_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00101F80 File Offset: 0x00100180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342988, RefRangeEnd = 342990, XrefRangeStart = 342945, XrefRangeEnd = 342988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberToFix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(holder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_DoValueTypeFixup_Private_Boolean_FieldInfo_ObjectHolder_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00101FF4 File Offset: 0x001001F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 343024, RefRangeEnd = 343031, XrefRangeStart = 342990, XrefRangeEnd = 343024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bObjectFullyComplete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_CompleteObject_Internal_Void_ObjectHolder_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00102044 File Offset: 0x00100244
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 343041, RefRangeEnd = 343044, XrefRangeStart = 343031, XrefRangeEnd = 343041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoNewlyRegisteredObjectFixups(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_DoNewlyRegisteredObjectFixups_Private_Void_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00102088 File Offset: 0x00100288
		[CallerCount(0)]
		public unsafe virtual Object GetObject(long objectID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x001020E0 File Offset: 0x001002E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343044, XrefRangeEnd = 343052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RegisterString_Internal_Void_String_Int64_SerializationInfo_Int64_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00102164 File Offset: 0x00100364
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 343089, RefRangeEnd = 343092, XrefRangeStart = 343052, XrefRangeEnd = 343089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, Il2CppStructArray<int> arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_Int64_SerializationInfo_Int64_MemberInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x001021FC File Offset: 0x001003FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343105, RefRangeEnd = 343106, XrefRangeStart = 343092, XrefRangeEnd = 343105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteISerializableObject(Object obj, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_CompleteISerializableObject_Internal_Void_Object_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x00102268 File Offset: 0x00100468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343111, RefRangeEnd = 343112, XrefRangeStart = 343106, XrefRangeEnd = 343111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeConstructorInfo GetConstructor(RuntimeType t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_GetConstructor_Internal_Static_RuntimeConstructorInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x001022AC File Offset: 0x001004AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343112, XrefRangeEnd = 343127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DoFixups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_DoFixups_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x001022E8 File Offset: 0x001004E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 343140, RefRangeEnd = 343143, XrefRangeStart = 343127, XrefRangeEnd = 343140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectToBeFixed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RegisterFixup_Private_Void_FixupHolder_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00102348 File Offset: 0x00100548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343143, XrefRangeEnd = 343182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectToBeFixed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RecordFixup_Public_Virtual_New_Void_Int64_MemberInfo_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x001023B4 File Offset: 0x001005B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343182, XrefRangeEnd = 343201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectToBeFixed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RecordDelayedFixup_Public_Virtual_New_Void_Int64_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00102420 File Offset: 0x00100620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343201, XrefRangeEnd = 343220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordArrayElementFixup(long arrayToBeFixed, Il2CppStructArray<int> indices, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arrayToBeFixed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RecordArrayElementFixup_Public_Virtual_New_Void_Int64_Il2CppStructArray_1_Int32_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x0010248C File Offset: 0x0010068C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343220, XrefRangeEnd = 343222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RaiseDeserializationEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RaiseDeserializationEvent_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x001024C8 File Offset: 0x001006C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343222, XrefRangeEnd = 343225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddOnDeserialization(DeserializationEventHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_AddOnDeserialization_Internal_Virtual_New_Void_DeserializationEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00102518 File Offset: 0x00100718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343225, XrefRangeEnd = 343231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddOnDeserialized(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_AddOnDeserialized_Internal_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x00102568 File Offset: 0x00100768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343231, XrefRangeEnd = 343237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RaiseOnDeserializedEvent(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializedEvent_Internal_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x001025B8 File Offset: 0x001007B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343237, XrefRangeEnd = 343243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseOnDeserializingEvent(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializingEvent_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00012CDB File Offset: 0x00010EDB
		public ObjectManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060034C9 RID: 13513 RVA: 0x001025FC File Offset: 0x001007FC
		// (set) Token: 0x060034CA RID: 13514 RVA: 0x00012CE4 File Offset: 0x00010EE4
		public unsafe DeserializationEventHandler m_onDeserializationHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializationHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeserializationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializationHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060034CB RID: 13515 RVA: 0x0010262C File Offset: 0x0010082C
		// (set) Token: 0x060034CC RID: 13516 RVA: 0x00012D03 File Offset: 0x00010F03
		public unsafe SerializationEventHandler m_onDeserializedHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializedHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializedHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x0010265C File Offset: 0x0010085C
		// (set) Token: 0x060034CE RID: 13518 RVA: 0x00012D22 File Offset: 0x00010F22
		public unsafe Il2CppReferenceArray<ObjectHolder> m_objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectHolder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060034CF RID: 13519 RVA: 0x0010268C File Offset: 0x0010088C
		// (set) Token: 0x060034D0 RID: 13520 RVA: 0x00012D41 File Offset: 0x00010F41
		public unsafe Object m_topObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_topObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_topObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060034D1 RID: 13521 RVA: 0x001026BC File Offset: 0x001008BC
		// (set) Token: 0x060034D2 RID: 13522 RVA: 0x00012D60 File Offset: 0x00010F60
		public unsafe ObjectHolderList m_specialFixupObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_specialFixupObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectHolderList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_specialFixupObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060034D3 RID: 13523 RVA: 0x001026EC File Offset: 0x001008EC
		// (set) Token: 0x060034D4 RID: 13524 RVA: 0x00012D7F File Offset: 0x00010F7F
		public unsafe long m_fixupCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_fixupCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_fixupCount)) = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060034D5 RID: 13525 RVA: 0x00102714 File Offset: 0x00100914
		// (set) Token: 0x060034D6 RID: 13526 RVA: 0x00012D9A File Offset: 0x00010F9A
		public unsafe ISurrogateSelector m_selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060034D7 RID: 13527 RVA: 0x00102744 File Offset: 0x00100944
		// (set) Token: 0x060034D8 RID: 13528 RVA: 0x00012DB9 File Offset: 0x00010FB9
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002CA0 RID: 11424
		private static readonly IntPtr NativeFieldInfoPtr_m_onDeserializationHandler;

		// Token: 0x04002CA1 RID: 11425
		private static readonly IntPtr NativeFieldInfoPtr_m_onDeserializedHandler;

		// Token: 0x04002CA2 RID: 11426
		private static readonly IntPtr NativeFieldInfoPtr_m_objects;

		// Token: 0x04002CA3 RID: 11427
		private static readonly IntPtr NativeFieldInfoPtr_m_topObject;

		// Token: 0x04002CA4 RID: 11428
		private static readonly IntPtr NativeFieldInfoPtr_m_specialFixupObjects;

		// Token: 0x04002CA5 RID: 11429
		private static readonly IntPtr NativeFieldInfoPtr_m_fixupCount;

		// Token: 0x04002CA6 RID: 11430
		private static readonly IntPtr NativeFieldInfoPtr_m_selector;

		// Token: 0x04002CA7 RID: 11431
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04002CA8 RID: 11432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_Boolean_Boolean_0;

		// Token: 0x04002CA9 RID: 11433
		private static readonly IntPtr NativeMethodInfoPtr_CanCallGetType_Private_Boolean_Object_0;

		// Token: 0x04002CAA RID: 11434
		private static readonly IntPtr NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0;

		// Token: 0x04002CAB RID: 11435
		private static readonly IntPtr NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0;

		// Token: 0x04002CAC RID: 11436
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialFixupObjects_Internal_get_ObjectHolderList_0;

		// Token: 0x04002CAD RID: 11437
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectHolder_Internal_ObjectHolder_Int64_0;

		// Token: 0x04002CAE RID: 11438
		private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateObjectHolder_Internal_ObjectHolder_Int64_0;

		// Token: 0x04002CAF RID: 11439
		private static readonly IntPtr NativeMethodInfoPtr_AddObjectHolder_Private_Void_ObjectHolder_0;

		// Token: 0x04002CB0 RID: 11440
		private static readonly IntPtr NativeMethodInfoPtr_GetCompletionInfo_Private_Boolean_FixupHolder_byref_ObjectHolder_byref_Object_Boolean_0;

		// Token: 0x04002CB1 RID: 11441
		private static readonly IntPtr NativeMethodInfoPtr_FixupSpecialObject_Private_Void_ObjectHolder_0;

		// Token: 0x04002CB2 RID: 11442
		private static readonly IntPtr NativeMethodInfoPtr_ResolveObjectReference_Private_Boolean_ObjectHolder_0;

		// Token: 0x04002CB3 RID: 11443
		private static readonly IntPtr NativeMethodInfoPtr_DoValueTypeFixup_Private_Boolean_FieldInfo_ObjectHolder_Object_0;

		// Token: 0x04002CB4 RID: 11444
		private static readonly IntPtr NativeMethodInfoPtr_CompleteObject_Internal_Void_ObjectHolder_Boolean_0;

		// Token: 0x04002CB5 RID: 11445
		private static readonly IntPtr NativeMethodInfoPtr_DoNewlyRegisteredObjectFixups_Private_Void_ObjectHolder_0;

		// Token: 0x04002CB6 RID: 11446
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_Int64_0;

		// Token: 0x04002CB7 RID: 11447
		private static readonly IntPtr NativeMethodInfoPtr_RegisterString_Internal_Void_String_Int64_SerializationInfo_Int64_MemberInfo_0;

		// Token: 0x04002CB8 RID: 11448
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Public_Void_Object_Int64_SerializationInfo_Int64_MemberInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002CB9 RID: 11449
		private static readonly IntPtr NativeMethodInfoPtr_CompleteISerializableObject_Internal_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04002CBA RID: 11450
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructor_Internal_Static_RuntimeConstructorInfo_RuntimeType_0;

		// Token: 0x04002CBB RID: 11451
		private static readonly IntPtr NativeMethodInfoPtr_DoFixups_Public_Virtual_New_Void_0;

		// Token: 0x04002CBC RID: 11452
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFixup_Private_Void_FixupHolder_Int64_Int64_0;

		// Token: 0x04002CBD RID: 11453
		private static readonly IntPtr NativeMethodInfoPtr_RecordFixup_Public_Virtual_New_Void_Int64_MemberInfo_Int64_0;

		// Token: 0x04002CBE RID: 11454
		private static readonly IntPtr NativeMethodInfoPtr_RecordDelayedFixup_Public_Virtual_New_Void_Int64_String_Int64_0;

		// Token: 0x04002CBF RID: 11455
		private static readonly IntPtr NativeMethodInfoPtr_RecordArrayElementFixup_Public_Virtual_New_Void_Int64_Il2CppStructArray_1_Int32_Int64_0;

		// Token: 0x04002CC0 RID: 11456
		private static readonly IntPtr NativeMethodInfoPtr_RaiseDeserializationEvent_Public_Virtual_New_Void_0;

		// Token: 0x04002CC1 RID: 11457
		private static readonly IntPtr NativeMethodInfoPtr_AddOnDeserialization_Internal_Virtual_New_Void_DeserializationEventHandler_0;

		// Token: 0x04002CC2 RID: 11458
		private static readonly IntPtr NativeMethodInfoPtr_AddOnDeserialized_Internal_Virtual_New_Void_Object_0;

		// Token: 0x04002CC3 RID: 11459
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnDeserializedEvent_Internal_Virtual_New_Void_Object_0;

		// Token: 0x04002CC4 RID: 11460
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnDeserializingEvent_Public_Void_Object_0;
	}
}
