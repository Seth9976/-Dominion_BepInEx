using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace UTNotifications
{
	// Token: 0x020000F5 RID: 245
	public class JSONArray : JSONNode
	{
		// Token: 0x06001DBA RID: 7610 RVA: 0x00074860 File Offset: 0x00072A60
		// Note: this type is marked as 'beforefieldinit'.
		static JSONArray()
		{
			Il2CppClassPointerStore<JSONArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "JSONArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONArray>.NativeClassPtr);
			JSONArray.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, "m_List");
			JSONArray.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665717);
			JSONArray.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665718);
			JSONArray.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665719);
			JSONArray.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665720);
			JSONArray.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665721);
			JSONArray.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665722);
			JSONArray.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665723);
			JSONArray.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665724);
			JSONArray.NativeMethodInfoPtr_get_Childs_Public_Virtual_get_IEnumerable_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665725);
			JSONArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665726);
			JSONArray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665727);
			JSONArray.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665728);
			JSONArray.NativeMethodInfoPtr_Serialize_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665729);
			JSONArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, 100665730);
		}

		// Token: 0x17000980 RID: 2432
		public unsafe override JSONNode this[int aIndex]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254986, XrefRangeEnd = 254990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref aIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254990, XrefRangeEnd = 254998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref aIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000981 RID: 2433
		public unsafe override JSONNode this[string aKey]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254998, XrefRangeEnd = 255002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255002, XrefRangeEnd = 255006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00074B2C File Offset: 0x00072D2C
		public unsafe override int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255006, XrefRangeEnd = 255007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00074B74 File Offset: 0x00072D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255007, XrefRangeEnd = 255011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Add(string aKey, JSONNode aItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00074BD4 File Offset: 0x00072DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255011, XrefRangeEnd = 255017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JSONNode Remove(int aIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00074C2C File Offset: 0x00072E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255017, XrefRangeEnd = 255020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JSONNode Remove(JSONNode aNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x00074C88 File Offset: 0x00072E88
		public unsafe override IEnumerable<JSONNode> Childs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255020, XrefRangeEnd = 255024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_get_Childs_Public_Virtual_get_IEnumerable_1_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JSONNode>>(intPtr3) : null;
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00074CD4 File Offset: 0x00072ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255024, XrefRangeEnd = 255028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00074D14 File Offset: 0x00072F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255028, XrefRangeEnd = 255051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00074D58 File Offset: 0x00072F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255051, XrefRangeEnd = 255082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(string aPrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aPrefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00074DAC File Offset: 0x00072FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255082, XrefRangeEnd = 255086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Serialize(BinaryWriter aWriter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONArray.NativeMethodInfoPtr_Serialize_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00074DFC File Offset: 0x00072FFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255093, RefRangeEnd = 255096, XrefRangeStart = 255086, XrefRangeEnd = 255093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00012B2E File Offset: 0x00010D2E
		public JSONArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00074E38 File Offset: 0x00073038
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x00012B37 File Offset: 0x00010D37
		public unsafe List<JSONNode> m_List
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray.NativeFieldInfoPtr_m_List);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<JSONNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_Int32_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_JSONNode_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_get_Childs_Public_Virtual_get_IEnumerable_1_JSONNode_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Void_BinaryWriter_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000219 RID: 537
		[ObfuscatedName("UTNotifications.JSONArray+<get_Childs>d__13")]
		public sealed class _get_Childs_d__13 : Object
		{
			// Token: 0x06002A01 RID: 10753 RVA: 0x00096D54 File Offset: 0x00094F54
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Childs_d__13()
			{
				Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, "<get_Childs>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr);
				JSONArray._get_Childs_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, "<>1__state");
				JSONArray._get_Childs_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, "<>2__current");
				JSONArray._get_Childs_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, "<>l__initialThreadId");
				JSONArray._get_Childs_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, "<>4__this");
				JSONArray._get_Childs_d__13.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, "<>7__wrap1");
				JSONArray._get_Childs_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, 100666597);
				JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, 100666598);
				JSONArray._get_Childs_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, 100666599);
				JSONArray._get_Childs_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, 100666600);
				JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, 100666601);
				JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, 100666602);
				JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, 100666603);
				JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, 100666604);
				JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr, 100666605);
			}

			// Token: 0x06002A02 RID: 10754 RVA: 0x00096E98 File Offset: 0x00095098
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 254576, RefRangeEnd = 254582, XrefRangeStart = 254576, XrefRangeEnd = 254582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Childs_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONArray._get_Childs_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Childs_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A03 RID: 10755 RVA: 0x00096EE0 File Offset: 0x000950E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254932, RefRangeEnd = 254933, XrefRangeStart = 254928, XrefRangeEnd = 254932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A04 RID: 10756 RVA: 0x00096F14 File Offset: 0x00095114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254933, XrefRangeEnd = 254948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Childs_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002A05 RID: 10757 RVA: 0x00096F50 File Offset: 0x00095150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254948, XrefRangeEnd = 254951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Childs_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D3D RID: 3389
			// (get) Token: 0x06002A06 RID: 10758 RVA: 0x00096F84 File Offset: 0x00095184
			public unsafe JSONNode System.Collections.Generic.IEnumerator<UTNotifications.JSONNode>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}

			// Token: 0x06002A07 RID: 10759 RVA: 0x00096FC4 File Offset: 0x000951C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254951, XrefRangeEnd = 254956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D3E RID: 3390
			// (get) Token: 0x06002A08 RID: 10760 RVA: 0x00096FF8 File Offset: 0x000951F8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A09 RID: 10761 RVA: 0x00097038 File Offset: 0x00095238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254956, XrefRangeEnd = 254958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JSONNode> System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr3) : null;
			}

			// Token: 0x06002A0A RID: 10762 RVA: 0x00097078 File Offset: 0x00095278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._get_Childs_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002A0B RID: 10763 RVA: 0x00019D08 File Offset: 0x00017F08
			public _get_Childs_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D38 RID: 3384
			// (get) Token: 0x06002A0C RID: 10764 RVA: 0x000970B8 File Offset: 0x000952B8
			// (set) Token: 0x06002A0D RID: 10765 RVA: 0x00019D11 File Offset: 0x00017F11
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Childs_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Childs_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D39 RID: 3385
			// (get) Token: 0x06002A0E RID: 10766 RVA: 0x000970E0 File Offset: 0x000952E0
			// (set) Token: 0x06002A0F RID: 10767 RVA: 0x00019D2C File Offset: 0x00017F2C
			public unsafe JSONNode __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Childs_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Childs_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3A RID: 3386
			// (get) Token: 0x06002A10 RID: 10768 RVA: 0x00097110 File Offset: 0x00095310
			// (set) Token: 0x06002A11 RID: 10769 RVA: 0x00019D4B File Offset: 0x00017F4B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Childs_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Childs_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D3B RID: 3387
			// (get) Token: 0x06002A12 RID: 10770 RVA: 0x00097138 File Offset: 0x00095338
			// (set) Token: 0x06002A13 RID: 10771 RVA: 0x00019D66 File Offset: 0x00017F66
			public unsafe JSONArray __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Childs_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Childs_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3C RID: 3388
			// (get) Token: 0x06002A14 RID: 10772 RVA: 0x00097168 File Offset: 0x00095368
			// (set) Token: 0x06002A15 RID: 10773 RVA: 0x00019D85 File Offset: 0x00017F85
			public List<JSONNode>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Childs_d__13.NativeFieldInfoPtr___7__wrap1);
					return new List<JSONNode>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<JSONNode>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._get_Childs_d__13.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<JSONNode>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001CBC RID: 7356
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CBD RID: 7357
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CBE RID: 7358
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001CBF RID: 7359
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CC0 RID: 7360
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001CC1 RID: 7361
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CC2 RID: 7362
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CC3 RID: 7363
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CC4 RID: 7364
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001CC5 RID: 7365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0;

			// Token: 0x04001CC6 RID: 7366
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CC7 RID: 7367
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CC8 RID: 7368
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0;

			// Token: 0x04001CC9 RID: 7369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200021A RID: 538
		[ObfuscatedName("UTNotifications.JSONArray+<GetEnumerator>d__14")]
		public sealed class _GetEnumerator_d__14 : Object
		{
			// Token: 0x06002A16 RID: 10774 RVA: 0x00097198 File Offset: 0x00095398
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__14()
			{
				Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONArray>.NativeClassPtr, "<GetEnumerator>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr);
				JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, "<>1__state");
				JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, "<>2__current");
				JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, "<>4__this");
				JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, "<>7__wrap1");
				JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, 100666606);
				JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, 100666607);
				JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, 100666608);
				JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, 100666609);
				JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, 100666610);
				JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, 100666611);
				JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr, 100666612);
			}

			// Token: 0x06002A17 RID: 10775 RVA: 0x000972A0 File Offset: 0x000954A0
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONArray._GetEnumerator_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A18 RID: 10776 RVA: 0x000972E8 File Offset: 0x000954E8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254962, RefRangeEnd = 254963, XrefRangeStart = 254958, XrefRangeEnd = 254962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A19 RID: 10777 RVA: 0x0009731C File Offset: 0x0009551C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254963, XrefRangeEnd = 254978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002A1A RID: 10778 RVA: 0x00097358 File Offset: 0x00095558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254978, XrefRangeEnd = 254981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D43 RID: 3395
			// (get) Token: 0x06002A1B RID: 10779 RVA: 0x0009738C File Offset: 0x0009558C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A1C RID: 10780 RVA: 0x000973CC File Offset: 0x000955CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254981, XrefRangeEnd = 254986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D44 RID: 3396
			// (get) Token: 0x06002A1D RID: 10781 RVA: 0x00097400 File Offset: 0x00095600
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONArray._GetEnumerator_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A1E RID: 10782 RVA: 0x00019DB3 File Offset: 0x00017FB3
			public _GetEnumerator_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D3F RID: 3391
			// (get) Token: 0x06002A1F RID: 10783 RVA: 0x00097440 File Offset: 0x00095640
			// (set) Token: 0x06002A20 RID: 10784 RVA: 0x00019DBC File Offset: 0x00017FBC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D40 RID: 3392
			// (get) Token: 0x06002A21 RID: 10785 RVA: 0x00097468 File Offset: 0x00095668
			// (set) Token: 0x06002A22 RID: 10786 RVA: 0x00019DD7 File Offset: 0x00017FD7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D41 RID: 3393
			// (get) Token: 0x06002A23 RID: 10787 RVA: 0x00097498 File Offset: 0x00095698
			// (set) Token: 0x06002A24 RID: 10788 RVA: 0x00019DF6 File Offset: 0x00017FF6
			public unsafe JSONArray __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D42 RID: 3394
			// (get) Token: 0x06002A25 RID: 10789 RVA: 0x000974C8 File Offset: 0x000956C8
			// (set) Token: 0x06002A26 RID: 10790 RVA: 0x00019E15 File Offset: 0x00018015
			public List<JSONNode>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___7__wrap1);
					return new List<JSONNode>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<JSONNode>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONArray._GetEnumerator_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<JSONNode>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001CCA RID: 7370
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CCB RID: 7371
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CCC RID: 7372
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CCD RID: 7373
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001CCE RID: 7374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CCF RID: 7375
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CD0 RID: 7376
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CD1 RID: 7377
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001CD2 RID: 7378
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CD3 RID: 7379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CD4 RID: 7380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
