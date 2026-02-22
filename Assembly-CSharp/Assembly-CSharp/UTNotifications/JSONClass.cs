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
	// Token: 0x020000F6 RID: 246
	public class JSONClass : JSONNode
	{
		// Token: 0x06001DCC RID: 7628 RVA: 0x00074E68 File Offset: 0x00073068
		// Note: this type is marked as 'beforefieldinit'.
		static JSONClass()
		{
			Il2CppClassPointerStore<JSONClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "JSONClass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONClass>.NativeClassPtr);
			JSONClass.NativeFieldInfoPtr_m_Dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, "m_Dict");
			JSONClass.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665731);
			JSONClass.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665732);
			JSONClass.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665733);
			JSONClass.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665734);
			JSONClass.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665735);
			JSONClass.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665736);
			JSONClass.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665737);
			JSONClass.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665738);
			JSONClass.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665739);
			JSONClass.NativeMethodInfoPtr_get_Childs_Public_Virtual_get_IEnumerable_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665740);
			JSONClass.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665741);
			JSONClass.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665742);
			JSONClass.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665743);
			JSONClass.NativeMethodInfoPtr_Serialize_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665744);
			JSONClass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, 100665745);
		}

		// Token: 0x17000985 RID: 2437
		public unsafe override JSONNode this[string aKey]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255160, XrefRangeEnd = 255168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255168, XrefRangeEnd = 255178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000986 RID: 2438
		public unsafe override JSONNode this[int aIndex]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255178, XrefRangeEnd = 255185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref aIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255185, XrefRangeEnd = 255195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x00075148 File Offset: 0x00073348
		public unsafe override int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255195, XrefRangeEnd = 255199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00075190 File Offset: 0x00073390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255199, XrefRangeEnd = 255210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x000751F0 File Offset: 0x000733F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255210, XrefRangeEnd = 255219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JSONNode Remove(string aKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0007524C File Offset: 0x0007344C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255219, XrefRangeEnd = 255230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JSONNode Remove(int aIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x000752A4 File Offset: 0x000734A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255230, XrefRangeEnd = 255253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JSONNode Remove(JSONNode aNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x00075300 File Offset: 0x00073500
		public unsafe override IEnumerable<JSONNode> Childs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255253, XrefRangeEnd = 255257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_get_Childs_Public_Virtual_get_IEnumerable_1_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JSONNode>>(intPtr3) : null;
			}
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0007534C File Offset: 0x0007354C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255257, XrefRangeEnd = 255261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0007538C File Offset: 0x0007358C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255261, XrefRangeEnd = 255301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x000753D0 File Offset: 0x000735D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255301, XrefRangeEnd = 255349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(string aPrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aPrefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00075424 File Offset: 0x00073624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255349, XrefRangeEnd = 255372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Serialize(BinaryWriter aWriter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONClass.NativeMethodInfoPtr_Serialize_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00075474 File Offset: 0x00073674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255379, RefRangeEnd = 255381, XrefRangeStart = 255372, XrefRangeEnd = 255379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONClass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONClass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00012B56 File Offset: 0x00010D56
		public JSONClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x000754B0 File Offset: 0x000736B0
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x00012B5F File Offset: 0x00010D5F
		public unsafe Dictionary<string, JSONNode> m_Dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass.NativeFieldInfoPtr_m_Dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, JSONNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass.NativeFieldInfoPtr_m_Dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeFieldInfoPtr_m_Dict;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_String_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_Int32_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_JSONNode_JSONNode_0;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr_get_Childs_Public_Virtual_get_IEnumerable_1_JSONNode_0;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Void_BinaryWriter_0;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200021B RID: 539
		[ObfuscatedName("UTNotifications.JSONClass+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06002A27 RID: 10791 RVA: 0x000974F8 File Offset: 0x000956F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<JSONClass.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONClass.__c__DisplayClass12_0>.NativeClassPtr);
				JSONClass.__c__DisplayClass12_0.NativeFieldInfoPtr_aNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass.__c__DisplayClass12_0>.NativeClassPtr, "aNode");
				JSONClass.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass.__c__DisplayClass12_0>.NativeClassPtr, 100666613);
				JSONClass.__c__DisplayClass12_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_KeyValuePair_2_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass.__c__DisplayClass12_0>.NativeClassPtr, 100666614);
			}

			// Token: 0x06002A28 RID: 10792 RVA: 0x00097560 File Offset: 0x00095760
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONClass.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A29 RID: 10793 RVA: 0x0009759C File Offset: 0x0009579C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255096, XrefRangeEnd = 255098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Remove_b__0(KeyValuePair<string, JSONNode> k)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(k));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass.__c__DisplayClass12_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_KeyValuePair_2_String_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002A2A RID: 10794 RVA: 0x00019E43 File Offset: 0x00018043
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D45 RID: 3397
			// (get) Token: 0x06002A2B RID: 10795 RVA: 0x000975F0 File Offset: 0x000957F0
			// (set) Token: 0x06002A2C RID: 10796 RVA: 0x00019E4C File Offset: 0x0001804C
			public unsafe JSONNode aNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass.__c__DisplayClass12_0.NativeFieldInfoPtr_aNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass.__c__DisplayClass12_0.NativeFieldInfoPtr_aNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CD5 RID: 7381
			private static readonly IntPtr NativeFieldInfoPtr_aNode;

			// Token: 0x04001CD6 RID: 7382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001CD7 RID: 7383
			private static readonly IntPtr NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_KeyValuePair_2_String_JSONNode_0;
		}

		// Token: 0x0200021C RID: 540
		[ObfuscatedName("UTNotifications.JSONClass+<get_Childs>d__14")]
		public sealed class _get_Childs_d__14 : Object
		{
			// Token: 0x06002A2D RID: 10797 RVA: 0x00097620 File Offset: 0x00095820
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Childs_d__14()
			{
				Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, "<get_Childs>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr);
				JSONClass._get_Childs_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, "<>1__state");
				JSONClass._get_Childs_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, "<>2__current");
				JSONClass._get_Childs_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, "<>l__initialThreadId");
				JSONClass._get_Childs_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, "<>4__this");
				JSONClass._get_Childs_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, "<>7__wrap1");
				JSONClass._get_Childs_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, 100666615);
				JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, 100666616);
				JSONClass._get_Childs_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, 100666617);
				JSONClass._get_Childs_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, 100666618);
				JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, 100666619);
				JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, 100666620);
				JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, 100666621);
				JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, 100666622);
				JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr, 100666623);
			}

			// Token: 0x06002A2E RID: 10798 RVA: 0x00097764 File Offset: 0x00095964
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 254576, RefRangeEnd = 254582, XrefRangeStart = 254576, XrefRangeEnd = 254582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Childs_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONClass._get_Childs_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._get_Childs_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A2F RID: 10799 RVA: 0x000977AC File Offset: 0x000959AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 255102, RefRangeEnd = 255103, XrefRangeStart = 255098, XrefRangeEnd = 255102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A30 RID: 10800 RVA: 0x000977E0 File Offset: 0x000959E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255103, XrefRangeEnd = 255119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._get_Childs_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002A31 RID: 10801 RVA: 0x0009781C File Offset: 0x00095A1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255119, XrefRangeEnd = 255122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._get_Childs_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D4B RID: 3403
			// (get) Token: 0x06002A32 RID: 10802 RVA: 0x00097850 File Offset: 0x00095A50
			public unsafe JSONNode System.Collections.Generic.IEnumerator<UTNotifications.JSONNode>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}

			// Token: 0x06002A33 RID: 10803 RVA: 0x00097890 File Offset: 0x00095A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255122, XrefRangeEnd = 255127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D4C RID: 3404
			// (get) Token: 0x06002A34 RID: 10804 RVA: 0x000978C4 File Offset: 0x00095AC4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A35 RID: 10805 RVA: 0x00097904 File Offset: 0x00095B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255127, XrefRangeEnd = 255129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JSONNode> System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr3) : null;
			}

			// Token: 0x06002A36 RID: 10806 RVA: 0x00097944 File Offset: 0x00095B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._get_Childs_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002A37 RID: 10807 RVA: 0x00019E6B File Offset: 0x0001806B
			public _get_Childs_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D46 RID: 3398
			// (get) Token: 0x06002A38 RID: 10808 RVA: 0x00097984 File Offset: 0x00095B84
			// (set) Token: 0x06002A39 RID: 10809 RVA: 0x00019E74 File Offset: 0x00018074
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._get_Childs_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._get_Childs_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D47 RID: 3399
			// (get) Token: 0x06002A3A RID: 10810 RVA: 0x000979AC File Offset: 0x00095BAC
			// (set) Token: 0x06002A3B RID: 10811 RVA: 0x00019E8F File Offset: 0x0001808F
			public unsafe JSONNode __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._get_Childs_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._get_Childs_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D48 RID: 3400
			// (get) Token: 0x06002A3C RID: 10812 RVA: 0x000979DC File Offset: 0x00095BDC
			// (set) Token: 0x06002A3D RID: 10813 RVA: 0x00019EAE File Offset: 0x000180AE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._get_Childs_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._get_Childs_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D49 RID: 3401
			// (get) Token: 0x06002A3E RID: 10814 RVA: 0x00097A04 File Offset: 0x00095C04
			// (set) Token: 0x06002A3F RID: 10815 RVA: 0x00019EC9 File Offset: 0x000180C9
			public unsafe JSONClass __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._get_Childs_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONClass>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._get_Childs_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4A RID: 3402
			// (get) Token: 0x06002A40 RID: 10816 RVA: 0x00097A34 File Offset: 0x00095C34
			// (set) Token: 0x06002A41 RID: 10817 RVA: 0x00019EE8 File Offset: 0x000180E8
			public Dictionary<string, JSONNode>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._get_Childs_d__14.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<string, JSONNode>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, JSONNode>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._get_Childs_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, JSONNode>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001CD8 RID: 7384
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CD9 RID: 7385
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CDA RID: 7386
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001CDB RID: 7387
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CDC RID: 7388
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001CDD RID: 7389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CDE RID: 7390
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CDF RID: 7391
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CE0 RID: 7392
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001CE1 RID: 7393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0;

			// Token: 0x04001CE2 RID: 7394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CE3 RID: 7395
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CE4 RID: 7396
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0;

			// Token: 0x04001CE5 RID: 7397
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200021D RID: 541
		[ObfuscatedName("UTNotifications.JSONClass+<GetEnumerator>d__15")]
		public sealed class _GetEnumerator_d__15 : Object
		{
			// Token: 0x06002A42 RID: 10818 RVA: 0x00097A64 File Offset: 0x00095C64
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__15()
			{
				Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONClass>.NativeClassPtr, "<GetEnumerator>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr);
				JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, "<>1__state");
				JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, "<>2__current");
				JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, "<>4__this");
				JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, "<>7__wrap1");
				JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, 100666624);
				JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, 100666625);
				JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, 100666626);
				JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, 100666627);
				JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, 100666628);
				JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, 100666629);
				JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr, 100666630);
			}

			// Token: 0x06002A43 RID: 10819 RVA: 0x00097B6C File Offset: 0x00095D6C
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONClass._GetEnumerator_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A44 RID: 10820 RVA: 0x00097BB4 File Offset: 0x00095DB4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 255133, RefRangeEnd = 255134, XrefRangeStart = 255129, XrefRangeEnd = 255133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A45 RID: 10821 RVA: 0x00097BE8 File Offset: 0x00095DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255134, XrefRangeEnd = 255152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002A46 RID: 10822 RVA: 0x00097C24 File Offset: 0x00095E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255152, XrefRangeEnd = 255155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D51 RID: 3409
			// (get) Token: 0x06002A47 RID: 10823 RVA: 0x00097C58 File Offset: 0x00095E58
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A48 RID: 10824 RVA: 0x00097C98 File Offset: 0x00095E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255155, XrefRangeEnd = 255160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D52 RID: 3410
			// (get) Token: 0x06002A49 RID: 10825 RVA: 0x00097CCC File Offset: 0x00095ECC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONClass._GetEnumerator_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A4A RID: 10826 RVA: 0x00019F16 File Offset: 0x00018116
			public _GetEnumerator_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D4D RID: 3405
			// (get) Token: 0x06002A4B RID: 10827 RVA: 0x00097D0C File Offset: 0x00095F0C
			// (set) Token: 0x06002A4C RID: 10828 RVA: 0x00019F1F File Offset: 0x0001811F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D4E RID: 3406
			// (get) Token: 0x06002A4D RID: 10829 RVA: 0x00097D34 File Offset: 0x00095F34
			// (set) Token: 0x06002A4E RID: 10830 RVA: 0x00019F3A File Offset: 0x0001813A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4F RID: 3407
			// (get) Token: 0x06002A4F RID: 10831 RVA: 0x00097D64 File Offset: 0x00095F64
			// (set) Token: 0x06002A50 RID: 10832 RVA: 0x00019F59 File Offset: 0x00018159
			public unsafe JSONClass __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONClass>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D50 RID: 3408
			// (get) Token: 0x06002A51 RID: 10833 RVA: 0x00097D94 File Offset: 0x00095F94
			// (set) Token: 0x06002A52 RID: 10834 RVA: 0x00019F78 File Offset: 0x00018178
			public Dictionary<string, JSONNode>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<string, JSONNode>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, JSONNode>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONClass._GetEnumerator_d__15.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, JSONNode>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001CE6 RID: 7398
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CE7 RID: 7399
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CE8 RID: 7400
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CE9 RID: 7401
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001CEA RID: 7402
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CEB RID: 7403
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CEC RID: 7404
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CED RID: 7405
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001CEE RID: 7406
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CEF RID: 7407
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CF0 RID: 7408
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
