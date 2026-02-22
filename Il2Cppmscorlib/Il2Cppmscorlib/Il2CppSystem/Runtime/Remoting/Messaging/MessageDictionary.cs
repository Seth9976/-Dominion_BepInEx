using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003FE RID: 1022
	[Serializable]
	public class MessageDictionary : Object
	{
		// Token: 0x06004060 RID: 16480 RVA: 0x0012A838 File Offset: 0x00128A38
		// Note: this type is marked as 'beforefieldinit'.
		static MessageDictionary()
		{
			Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MessageDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr);
			MessageDictionary.NativeFieldInfoPtr__internalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, "_internalProperties");
			MessageDictionary.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, "_message");
			MessageDictionary.NativeFieldInfoPtr__methodKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, "_methodKeys");
			MessageDictionary.NativeFieldInfoPtr__ownProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, "_ownProperties");
			MessageDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672693);
			MessageDictionary.NativeMethodInfoPtr_HasUserData_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672694);
			MessageDictionary.NativeMethodInfoPtr_get_InternalDictionary_Internal_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672695);
			MessageDictionary.NativeMethodInfoPtr_set_MethodKeys_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672696);
			MessageDictionary.NativeMethodInfoPtr_AllocInternalProperties_Protected_Virtual_New_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672697);
			MessageDictionary.NativeMethodInfoPtr_GetInternalProperties_Public_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672698);
			MessageDictionary.NativeMethodInfoPtr_IsOverridenKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672699);
			MessageDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672700);
			MessageDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672701);
			MessageDictionary.NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672702);
			MessageDictionary.NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672703);
			MessageDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672704);
			MessageDictionary.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672705);
			MessageDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672706);
			MessageDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672707);
			MessageDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672708);
			MessageDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672709);
			MessageDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672710);
			MessageDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100672711);
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x0012AA34 File Offset: 0x00128C34
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 33270, RefRangeEnd = 33281, XrefRangeStart = 33270, XrefRangeEnd = 33281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageDictionary(IMethodMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x0012AA80 File Offset: 0x00128C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355251, RefRangeEnd = 355252, XrefRangeStart = 355249, XrefRangeEnd = 355251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasUserData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_HasUserData_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06004063 RID: 16483 RVA: 0x0012AABC File Offset: 0x00128CBC
		public unsafe IDictionary InternalDictionary
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 355255, RefRangeEnd = 355257, XrefRangeStart = 355252, XrefRangeEnd = 355255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_InternalDictionary_Internal_get_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x17001063 RID: 4195
		// (set) Token: 0x06004064 RID: 16484 RVA: 0x0012AAFC File Offset: 0x00128CFC
		public unsafe Il2CppStringArray MethodKeys
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_set_MethodKeys_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x0012AB40 File Offset: 0x00128D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355257, XrefRangeEnd = 355261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary AllocInternalProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDictionary.NativeMethodInfoPtr_AllocInternalProperties_Protected_Virtual_New_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x0012AB8C File Offset: 0x00128D8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 355261, RefRangeEnd = 355264, XrefRangeStart = 355261, XrefRangeEnd = 355261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary GetInternalProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_GetInternalProperties_Public_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x0012ABCC File Offset: 0x00128DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355266, RefRangeEnd = 355267, XrefRangeStart = 355264, XrefRangeEnd = 355266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOverridenKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_IsOverridenKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001064 RID: 4196
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355267, XrefRangeEnd = 355272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355272, XrefRangeEnd = 355273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x0012ACC0 File Offset: 0x00128EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355325, RefRangeEnd = 355326, XrefRangeStart = 355273, XrefRangeEnd = 355325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetMethodProperty(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDictionary.NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x0012AD1C File Offset: 0x00128F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355360, RefRangeEnd = 355361, XrefRangeStart = 355326, XrefRangeEnd = 355360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMethodProperty(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDictionary.NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x0012AD7C File Offset: 0x00128F7C
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355361, XrefRangeEnd = 355391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x0012ADBC File Offset: 0x00128FBC
		public unsafe virtual ICollection Values
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 355421, RefRangeEnd = 355422, XrefRangeStart = 355391, XrefRangeEnd = 355421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x0012ADFC File Offset: 0x00128FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355427, RefRangeEnd = 355428, XrefRangeStart = 355422, XrefRangeEnd = 355427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x0012AE50 File Offset: 0x00129050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355428, XrefRangeEnd = 355433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06004070 RID: 16496 RVA: 0x0012AEA0 File Offset: 0x001290A0
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355433, XrefRangeEnd = 355434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x0012AEDC File Offset: 0x001290DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355434, XrefRangeEnd = 355440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x0012AF2C File Offset: 0x0012912C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355440, XrefRangeEnd = 355444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x0012AF6C File Offset: 0x0012916C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355444, XrefRangeEnd = 355448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x00018647 File Offset: 0x00016847
		public MessageDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06004075 RID: 16501 RVA: 0x0012AFAC File Offset: 0x001291AC
		// (set) Token: 0x06004076 RID: 16502 RVA: 0x00018650 File Offset: 0x00016850
		public unsafe IDictionary _internalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__internalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__internalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06004077 RID: 16503 RVA: 0x0012AFDC File Offset: 0x001291DC
		// (set) Token: 0x06004078 RID: 16504 RVA: 0x0001866F File Offset: 0x0001686F
		public unsafe IMethodMessage _message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMethodMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06004079 RID: 16505 RVA: 0x0012B00C File Offset: 0x0012920C
		// (set) Token: 0x0600407A RID: 16506 RVA: 0x0001868E File Offset: 0x0001688E
		public unsafe Il2CppStringArray _methodKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__methodKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__methodKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x0600407B RID: 16507 RVA: 0x0012B03C File Offset: 0x0012923C
		// (set) Token: 0x0600407C RID: 16508 RVA: 0x000186AD File Offset: 0x000168AD
		public unsafe bool _ownProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__ownProperties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__ownProperties)) = value;
			}
		}

		// Token: 0x040034B0 RID: 13488
		private static readonly IntPtr NativeFieldInfoPtr__internalProperties;

		// Token: 0x040034B1 RID: 13489
		private static readonly IntPtr NativeFieldInfoPtr__message;

		// Token: 0x040034B2 RID: 13490
		private static readonly IntPtr NativeFieldInfoPtr__methodKeys;

		// Token: 0x040034B3 RID: 13491
		private static readonly IntPtr NativeFieldInfoPtr__ownProperties;

		// Token: 0x040034B4 RID: 13492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;

		// Token: 0x040034B5 RID: 13493
		private static readonly IntPtr NativeMethodInfoPtr_HasUserData_Internal_Boolean_0;

		// Token: 0x040034B6 RID: 13494
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalDictionary_Internal_get_IDictionary_0;

		// Token: 0x040034B7 RID: 13495
		private static readonly IntPtr NativeMethodInfoPtr_set_MethodKeys_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x040034B8 RID: 13496
		private static readonly IntPtr NativeMethodInfoPtr_AllocInternalProperties_Protected_Virtual_New_IDictionary_0;

		// Token: 0x040034B9 RID: 13497
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalProperties_Public_IDictionary_0;

		// Token: 0x040034BA RID: 13498
		private static readonly IntPtr NativeMethodInfoPtr_IsOverridenKey_Private_Boolean_String_0;

		// Token: 0x040034BB RID: 13499
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x040034BC RID: 13500
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x040034BD RID: 13501
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_New_Object_String_0;

		// Token: 0x040034BE RID: 13502
		private static readonly IntPtr NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_New_Void_String_Object_0;

		// Token: 0x040034BF RID: 13503
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x040034C0 RID: 13504
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x040034C1 RID: 13505
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x040034C2 RID: 13506
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x040034C3 RID: 13507
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040034C4 RID: 13508
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040034C5 RID: 13509
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040034C6 RID: 13510
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x02000630 RID: 1584
		public class DictionaryEnumerator : Object
		{
			// Token: 0x06005464 RID: 21604 RVA: 0x00175704 File Offset: 0x00173904
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryEnumerator()
			{
				Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, "DictionaryEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr);
				MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__methodDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, "_methodDictionary");
				MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__hashtableEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, "_hashtableEnum");
				MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__posMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, "_posMethod");
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Public_Void_MessageDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100672712);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100672713);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100672714);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100672715);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100672716);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100672717);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100672718);
			}

			// Token: 0x06005465 RID: 21605 RVA: 0x001757F8 File Offset: 0x001739F8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 355222, RefRangeEnd = 355224, XrefRangeStart = 355217, XrefRangeEnd = 355222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryEnumerator(MessageDictionary methodDictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodDictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Public_Void_MessageDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170015A0 RID: 5536
			// (get) Token: 0x06005466 RID: 21606 RVA: 0x00175844 File Offset: 0x00173A44
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355224, XrefRangeEnd = 355228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005467 RID: 21607 RVA: 0x00175884 File Offset: 0x00173A84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355228, XrefRangeEnd = 355237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005468 RID: 21608 RVA: 0x001758C0 File Offset: 0x00173AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355237, XrefRangeEnd = 355241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015A1 RID: 5537
			// (get) Token: 0x06005469 RID: 21609 RVA: 0x001758F4 File Offset: 0x00173AF4
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 355244, RefRangeEnd = 355247, XrefRangeStart = 355241, XrefRangeEnd = 355244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170015A2 RID: 5538
			// (get) Token: 0x0600546A RID: 21610 RVA: 0x0017592C File Offset: 0x00173B2C
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355247, XrefRangeEnd = 355248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170015A3 RID: 5539
			// (get) Token: 0x0600546B RID: 21611 RVA: 0x0017596C File Offset: 0x00173B6C
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355248, XrefRangeEnd = 355249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600546C RID: 21612 RVA: 0x00020917 File Offset: 0x0001EB17
			public DictionaryEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700159D RID: 5533
			// (get) Token: 0x0600546D RID: 21613 RVA: 0x001759AC File Offset: 0x00173BAC
			// (set) Token: 0x0600546E RID: 21614 RVA: 0x00020920 File Offset: 0x0001EB20
			public unsafe MessageDictionary _methodDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__methodDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageDictionary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__methodDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700159E RID: 5534
			// (get) Token: 0x0600546F RID: 21615 RVA: 0x001759DC File Offset: 0x00173BDC
			// (set) Token: 0x06005470 RID: 21616 RVA: 0x0002093F File Offset: 0x0001EB3F
			public unsafe IDictionaryEnumerator _hashtableEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__hashtableEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__hashtableEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700159F RID: 5535
			// (get) Token: 0x06005471 RID: 21617 RVA: 0x00175A0C File Offset: 0x00173C0C
			// (set) Token: 0x06005472 RID: 21618 RVA: 0x0002095E File Offset: 0x0001EB5E
			public unsafe int _posMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__posMethod);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__posMethod)) = value;
				}
			}

			// Token: 0x040043F0 RID: 17392
			private static readonly IntPtr NativeFieldInfoPtr__methodDictionary;

			// Token: 0x040043F1 RID: 17393
			private static readonly IntPtr NativeFieldInfoPtr__hashtableEnum;

			// Token: 0x040043F2 RID: 17394
			private static readonly IntPtr NativeFieldInfoPtr__posMethod;

			// Token: 0x040043F3 RID: 17395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MessageDictionary_0;

			// Token: 0x040043F4 RID: 17396
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040043F5 RID: 17397
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040043F6 RID: 17398
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x040043F7 RID: 17399
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x040043F8 RID: 17400
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040043F9 RID: 17401
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
