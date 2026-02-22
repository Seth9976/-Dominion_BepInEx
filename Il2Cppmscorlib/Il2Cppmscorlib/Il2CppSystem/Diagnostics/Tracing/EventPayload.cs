using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004CC RID: 1228
	public class EventPayload : Object
	{
		// Token: 0x06004800 RID: 18432 RVA: 0x0014A304 File Offset: 0x00148504
		// Note: this type is marked as 'beforefieldinit'.
		static EventPayload()
		{
			Il2CppClassPointerStore<EventPayload>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventPayload");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventPayload>.NativeClassPtr);
			EventPayload.NativeFieldInfoPtr_m_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, "m_names");
			EventPayload.NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, "m_values");
			EventPayload.NativeMethodInfoPtr__ctor_Internal_Void_List_1_String_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673946);
			EventPayload.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673947);
			EventPayload.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673948);
			EventPayload.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673949);
			EventPayload.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673950);
			EventPayload.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673951);
			EventPayload.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673952);
			EventPayload.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673953);
			EventPayload.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673954);
			EventPayload.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673955);
			EventPayload.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673956);
			EventPayload.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673957);
			EventPayload.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673958);
			EventPayload.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673959);
			EventPayload.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, 100673960);
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x0014A488 File Offset: 0x00148688
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventPayload(List<string> payloadNames, List<Object> payloadValues)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventPayload>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payloadNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(payloadValues);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr__ctor_Internal_Void_List_1_String_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06004802 RID: 18434 RVA: 0x0014A4E8 File Offset: 0x001486E8
		public unsafe virtual ICollection<string> Keys
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700122F RID: 4655
		public unsafe virtual string this[string key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366145, XrefRangeEnd = 366150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x0014A57C File Offset: 0x0014877C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366150, XrefRangeEnd = 366155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(string key, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x0014A5D0 File Offset: 0x001487D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366155, XrefRangeEnd = 366160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(KeyValuePair<string, Object> payloadEntry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(payloadEntry));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x0014A618 File Offset: 0x00148818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366160, XrefRangeEnd = 366165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x0014A64C File Offset: 0x0014884C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366165, XrefRangeEnd = 366167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(KeyValuePair<string, Object> entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entry));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x0014A6A0 File Offset: 0x001488A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366184, RefRangeEnd = 366185, XrefRangeStart = 366167, XrefRangeEnd = 366184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x0014A6F0 File Offset: 0x001488F0
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366185, XrefRangeEnd = 366186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600480A RID: 18442 RVA: 0x0014A72C File Offset: 0x0014892C
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x0014A768 File Offset: 0x00148968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366186, XrefRangeEnd = 366190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<string, Object>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, Object>>>(intPtr3) : null;
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x0014A7A8 File Offset: 0x001489A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366190, XrefRangeEnd = 366193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x0014A7E8 File Offset: 0x001489E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366193, XrefRangeEnd = 366198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<KeyValuePair<string, Object>> payloadEntries, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payloadEntries);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x0014A838 File Offset: 0x00148A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366198, XrefRangeEnd = 366203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(KeyValuePair<string, Object> entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entry));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x0014A88C File Offset: 0x00148A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366203, XrefRangeEnd = 366224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(string key, out Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventPayload.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x0001B442 File Offset: 0x00019642
		public EventPayload(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x0014A8FC File Offset: 0x00148AFC
		// (set) Token: 0x06004812 RID: 18450 RVA: 0x0001B44B File Offset: 0x0001964B
		public unsafe List<string> m_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload.NativeFieldInfoPtr_m_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload.NativeFieldInfoPtr_m_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x0014A92C File Offset: 0x00148B2C
		// (set) Token: 0x06004814 RID: 18452 RVA: 0x0001B46A File Offset: 0x0001966A
		public unsafe List<Object> m_values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload.NativeFieldInfoPtr_m_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload.NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A43 RID: 14915
		private static readonly IntPtr NativeFieldInfoPtr_m_names;

		// Token: 0x04003A44 RID: 14916
		private static readonly IntPtr NativeFieldInfoPtr_m_values;

		// Token: 0x04003A45 RID: 14917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_List_1_String_List_1_Object_0;

		// Token: 0x04003A46 RID: 14918
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0;

		// Token: 0x04003A47 RID: 14919
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_Object_0;

		// Token: 0x04003A48 RID: 14920
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_Object_0;

		// Token: 0x04003A49 RID: 14921
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_Object_0;

		// Token: 0x04003A4A RID: 14922
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003A4B RID: 14923
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_0;

		// Token: 0x04003A4C RID: 14924
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04003A4D RID: 14925
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003A4E RID: 14926
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003A4F RID: 14927
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_Object_0;

		// Token: 0x04003A50 RID: 14928
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003A51 RID: 14929
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_Object_Int32_0;

		// Token: 0x04003A52 RID: 14930
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_Object_0;

		// Token: 0x04003A53 RID: 14931
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_Object_0;

		// Token: 0x02000670 RID: 1648
		[ObfuscatedName("System.Diagnostics.Tracing.EventPayload+<GetEnumerator>d__17")]
		public sealed class _GetEnumerator_d__17 : Object
		{
			// Token: 0x06005686 RID: 22150 RVA: 0x0017DBF8 File Offset: 0x0017BDF8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__17()
			{
				Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventPayload>.NativeClassPtr, "<GetEnumerator>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr);
				EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr, "<>1__state");
				EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr, "<>2__current");
				EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr, "<>4__this");
				EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr__i_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr, "<i>5__1");
				EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr, 100673961);
				EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr, 100673962);
				EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr, 100673963);
				EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr, 100673964);
				EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr, 100673965);
				EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr, 100673966);
			}

			// Token: 0x06005687 RID: 22151 RVA: 0x0017DCEC File Offset: 0x0017BEEC
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventPayload._GetEnumerator_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005688 RID: 22152 RVA: 0x0017DD34 File Offset: 0x0017BF34
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005689 RID: 22153 RVA: 0x0017DD68 File Offset: 0x0017BF68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366126, XrefRangeEnd = 366137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001644 RID: 5700
			// (get) Token: 0x0600568A RID: 22154 RVA: 0x0017DDA4 File Offset: 0x0017BFA4
			public unsafe KeyValuePair<string, Object> prop_KeyValuePair_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, Object>(intPtr);
				}
			}

			// Token: 0x0600568B RID: 22155 RVA: 0x0017DDDC File Offset: 0x0017BFDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366137, XrefRangeEnd = 366142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001645 RID: 5701
			// (get) Token: 0x0600568C RID: 22156 RVA: 0x0017DE10 File Offset: 0x0017C010
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366142, XrefRangeEnd = 366145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventPayload._GetEnumerator_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600568D RID: 22157 RVA: 0x00021689 File Offset: 0x0001F889
			public _GetEnumerator_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001640 RID: 5696
			// (get) Token: 0x0600568E RID: 22158 RVA: 0x0017DE50 File Offset: 0x0017C050
			// (set) Token: 0x0600568F RID: 22159 RVA: 0x00021692 File Offset: 0x0001F892
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001641 RID: 5697
			// (get) Token: 0x06005690 RID: 22160 RVA: 0x0017DE78 File Offset: 0x0017C078
			// (set) Token: 0x06005691 RID: 22161 RVA: 0x000216AD File Offset: 0x0001F8AD
			public KeyValuePair<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001642 RID: 5698
			// (get) Token: 0x06005692 RID: 22162 RVA: 0x0017DEA8 File Offset: 0x0017C0A8
			// (set) Token: 0x06005693 RID: 22163 RVA: 0x000216DB File Offset: 0x0001F8DB
			public unsafe EventPayload __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventPayload>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001643 RID: 5699
			// (get) Token: 0x06005694 RID: 22164 RVA: 0x0017DED8 File Offset: 0x0017C0D8
			// (set) Token: 0x06005695 RID: 22165 RVA: 0x000216FA File Offset: 0x0001F8FA
			public unsafe int _i_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr__i_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventPayload._GetEnumerator_d__17.NativeFieldInfoPtr__i_5__1)) = value;
				}
			}

			// Token: 0x0400455A RID: 17754
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400455B RID: 17755
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400455C RID: 17756
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400455D RID: 17757
			private static readonly IntPtr NativeFieldInfoPtr__i_5__1;

			// Token: 0x0400455E RID: 17758
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400455F RID: 17759
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004560 RID: 17760
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004561 RID: 17761
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_Object_0;

			// Token: 0x04004562 RID: 17762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004563 RID: 17763
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
