using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000344 RID: 836
	public class SerializationEvents : Object
	{
		// Token: 0x0600359B RID: 13723 RVA: 0x00105188 File Offset: 0x00103388
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEvents()
		{
			Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr);
			SerializationEvents.NativeFieldInfoPtr_m_OnSerializingMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "m_OnSerializingMethods");
			SerializationEvents.NativeFieldInfoPtr_m_OnSerializedMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "m_OnSerializedMethods");
			SerializationEvents.NativeFieldInfoPtr_m_OnDeserializingMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "m_OnDeserializingMethods");
			SerializationEvents.NativeFieldInfoPtr_m_OnDeserializedMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "m_OnDeserializedMethods");
			SerializationEvents.NativeMethodInfoPtr_GetMethodsWithAttribute_Private_List_1_MethodInfo_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671572);
			SerializationEvents.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671573);
			SerializationEvents.NativeMethodInfoPtr_get_HasOnSerializingEvents_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671574);
			SerializationEvents.NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671575);
			SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671576);
			SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671577);
			SerializationEvents.NativeMethodInfoPtr_AddOnSerialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671578);
			SerializationEvents.NativeMethodInfoPtr_AddOnDeserialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671579);
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x001052A8 File Offset: 0x001034A8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 343542, RefRangeEnd = 343550, XrefRangeStart = 343517, XrefRangeEnd = 343542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_GetMethodsWithAttribute_Private_List_1_MethodInfo_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr3) : null;
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x0010530C File Offset: 0x0010350C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343550, XrefRangeEnd = 343570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEvents(Type t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x00105358 File Offset: 0x00103558
		public unsafe bool HasOnSerializingEvents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_get_HasOnSerializingEvents_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x00105394 File Offset: 0x00103594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343600, RefRangeEnd = 343601, XrefRangeStart = 343570, XrefRangeEnd = 343600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnSerializing(Object obj, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x001053F0 File Offset: 0x001035F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343631, RefRangeEnd = 343633, XrefRangeStart = 343601, XrefRangeEnd = 343631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnDeserializing(Object obj, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x0010544C File Offset: 0x0010364C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343663, RefRangeEnd = 343665, XrefRangeStart = 343633, XrefRangeEnd = 343663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnDeserialized(Object obj, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x001054A8 File Offset: 0x001036A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343694, RefRangeEnd = 343696, XrefRangeStart = 343665, XrefRangeEnd = 343694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEventHandler AddOnSerialized(Object obj, SerializationEventHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_AddOnSerialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr3) : null;
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x0010550C File Offset: 0x0010370C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343725, RefRangeEnd = 343726, XrefRangeStart = 343696, XrefRangeEnd = 343725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEventHandler AddOnDeserialized(Object obj, SerializationEventHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_AddOnDeserialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr3) : null;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x000133DB File Offset: 0x000115DB
		public SerializationEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x00105570 File Offset: 0x00103770
		// (set) Token: 0x060035A6 RID: 13734 RVA: 0x000133E4 File Offset: 0x000115E4
		public unsafe List<MethodInfo> m_OnSerializingMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnSerializingMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnSerializingMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x001055A0 File Offset: 0x001037A0
		// (set) Token: 0x060035A8 RID: 13736 RVA: 0x00013403 File Offset: 0x00011603
		public unsafe List<MethodInfo> m_OnSerializedMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnSerializedMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnSerializedMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x001055D0 File Offset: 0x001037D0
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x00013422 File Offset: 0x00011622
		public unsafe List<MethodInfo> m_OnDeserializingMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnDeserializingMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnDeserializingMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x00105600 File Offset: 0x00103800
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x00013441 File Offset: 0x00011641
		public unsafe List<MethodInfo> m_OnDeserializedMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnDeserializedMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr_m_OnDeserializedMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D41 RID: 11585
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSerializingMethods;

		// Token: 0x04002D42 RID: 11586
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSerializedMethods;

		// Token: 0x04002D43 RID: 11587
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDeserializingMethods;

		// Token: 0x04002D44 RID: 11588
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDeserializedMethods;

		// Token: 0x04002D45 RID: 11589
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodsWithAttribute_Private_List_1_MethodInfo_Type_Type_0;

		// Token: 0x04002D46 RID: 11590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x04002D47 RID: 11591
		private static readonly IntPtr NativeMethodInfoPtr_get_HasOnSerializingEvents_Internal_get_Boolean_0;

		// Token: 0x04002D48 RID: 11592
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0;

		// Token: 0x04002D49 RID: 11593
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0;

		// Token: 0x04002D4A RID: 11594
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0;

		// Token: 0x04002D4B RID: 11595
		private static readonly IntPtr NativeMethodInfoPtr_AddOnSerialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0;

		// Token: 0x04002D4C RID: 11596
		private static readonly IntPtr NativeMethodInfoPtr_AddOnDeserialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0;
	}
}
