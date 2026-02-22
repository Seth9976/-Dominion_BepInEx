using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033D RID: 829
	[Serializable]
	public sealed class SafeSerializationManager : Object
	{
		// Token: 0x06003571 RID: 13681 RVA: 0x0010497C File Offset: 0x00102B7C
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSerializationManager()
		{
			Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SafeSerializationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr);
			SafeSerializationManager.NativeFieldInfoPtr_m_serializedStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_serializedStates");
			SafeSerializationManager.NativeFieldInfoPtr_m_savedSerializationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_savedSerializationInfo");
			SafeSerializationManager.NativeFieldInfoPtr_m_realObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_realObject");
			SafeSerializationManager.NativeFieldInfoPtr_m_realType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_realType");
			SafeSerializationManager.NativeFieldInfoPtr_SerializeObjectState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "SerializeObjectState");
			SafeSerializationManager.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671556);
			SafeSerializationManager.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671557);
			SafeSerializationManager.NativeMethodInfoPtr_get_IsActive_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671558);
			SafeSerializationManager.NativeMethodInfoPtr_CompleteSerialization_Internal_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671559);
			SafeSerializationManager.NativeMethodInfoPtr_CompleteDeserialization_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671560);
			SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671561);
			SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_IObjectReference_GetRealObject_Private_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671562);
			SafeSerializationManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671563);
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00104AB0 File Offset: 0x00102CB0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSerializationManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x00104AEC File Offset: 0x00102CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343390, XrefRangeEnd = 343408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSerializationManager(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06003574 RID: 13684 RVA: 0x00104B50 File Offset: 0x00102D50
		public unsafe bool IsActive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254453, RefRangeEnd = 254454, XrefRangeStart = 254453, XrefRangeEnd = 254454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_get_IsActive_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x00104B8C File Offset: 0x00102D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343438, RefRangeEnd = 343439, XrefRangeStart = 343408, XrefRangeEnd = 343438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteSerialization(Object serializedObject, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_CompleteSerialization_Internal_Void_Object_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x00104BF8 File Offset: 0x00102DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343463, RefRangeEnd = 343464, XrefRangeStart = 343439, XrefRangeEnd = 343463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteDeserialization(Object deserializedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deserializedObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_CompleteDeserialization_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x00104C3C File Offset: 0x00102E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343464, XrefRangeEnd = 343473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x00104C98 File Offset: 0x00102E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343473, XrefRangeEnd = 343510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_Runtime_Serialization_IObjectReference_GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_IObjectReference_GetRealObject_Private_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x00104CF0 File Offset: 0x00102EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343510, XrefRangeEnd = 343516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x00013216 File Offset: 0x00011416
		public SafeSerializationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x0600357B RID: 13691 RVA: 0x00104D38 File Offset: 0x00102F38
		// (set) Token: 0x0600357C RID: 13692 RVA: 0x0001321F File Offset: 0x0001141F
		public unsafe IList<Object> m_serializedStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_serializedStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_serializedStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x00104D68 File Offset: 0x00102F68
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x0001323E File Offset: 0x0001143E
		public unsafe SerializationInfo m_savedSerializationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_savedSerializationInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_savedSerializationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x00104D98 File Offset: 0x00102F98
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x0001325D File Offset: 0x0001145D
		public unsafe Object m_realObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x00104DC8 File Offset: 0x00102FC8
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x0001327C File Offset: 0x0001147C
		public unsafe RuntimeType m_realType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x00104DF8 File Offset: 0x00102FF8
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x0001329B File Offset: 0x0001149B
		public unsafe EventHandler<SafeSerializationEventArgs> SerializeObjectState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_SerializeObjectState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SafeSerializationEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_SerializeObjectState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D2B RID: 11563
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedStates;

		// Token: 0x04002D2C RID: 11564
		private static readonly IntPtr NativeFieldInfoPtr_m_savedSerializationInfo;

		// Token: 0x04002D2D RID: 11565
		private static readonly IntPtr NativeFieldInfoPtr_m_realObject;

		// Token: 0x04002D2E RID: 11566
		private static readonly IntPtr NativeFieldInfoPtr_m_realType;

		// Token: 0x04002D2F RID: 11567
		private static readonly IntPtr NativeFieldInfoPtr_SerializeObjectState;

		// Token: 0x04002D30 RID: 11568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002D31 RID: 11569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002D32 RID: 11570
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Internal_get_Boolean_0;

		// Token: 0x04002D33 RID: 11571
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSerialization_Internal_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04002D34 RID: 11572
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDeserialization_Internal_Void_Object_0;

		// Token: 0x04002D35 RID: 11573
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002D36 RID: 11574
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IObjectReference_GetRealObject_Private_Virtual_Final_New_Object_StreamingContext_0;

		// Token: 0x04002D37 RID: 11575
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;
	}
}
