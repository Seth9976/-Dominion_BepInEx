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
	// Token: 0x020000F4 RID: 244
	public class JSONNode : Object
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x00073614 File Offset: 0x00071814
		// Note: this type is marked as 'beforefieldinit'.
		static JSONNode()
		{
			Il2CppClassPointerStore<JSONNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "JSONNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNode>.NativeClassPtr);
			JSONNode.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665668);
			JSONNode.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665669);
			JSONNode.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665670);
			JSONNode.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665671);
			JSONNode.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665672);
			JSONNode.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665673);
			JSONNode.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665674);
			JSONNode.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665675);
			JSONNode.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665676);
			JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665677);
			JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665678);
			JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665679);
			JSONNode.NativeMethodInfoPtr_get_Childs_Public_Virtual_New_get_IEnumerable_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665680);
			JSONNode.NativeMethodInfoPtr_get_DeepChilds_Public_get_IEnumerable_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665681);
			JSONNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665682);
			JSONNode.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665683);
			JSONNode.NativeMethodInfoPtr_get_AsInt_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665684);
			JSONNode.NativeMethodInfoPtr_set_AsInt_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665685);
			JSONNode.NativeMethodInfoPtr_get_AsFloat_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665686);
			JSONNode.NativeMethodInfoPtr_set_AsFloat_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665687);
			JSONNode.NativeMethodInfoPtr_get_AsDouble_Public_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665688);
			JSONNode.NativeMethodInfoPtr_set_AsDouble_Public_Virtual_New_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665689);
			JSONNode.NativeMethodInfoPtr_get_AsBool_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665690);
			JSONNode.NativeMethodInfoPtr_set_AsBool_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665691);
			JSONNode.NativeMethodInfoPtr_get_AsArray_Public_Virtual_New_get_JSONArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665692);
			JSONNode.NativeMethodInfoPtr_get_AsObject_Public_Virtual_New_get_JSONClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665693);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665694);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665695);
			JSONNode.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_JSONNode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665696);
			JSONNode.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_JSONNode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665697);
			JSONNode.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665698);
			JSONNode.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665699);
			JSONNode.NativeMethodInfoPtr_Escape_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665700);
			JSONNode.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665701);
			JSONNode.NativeMethodInfoPtr_Serialize_Public_Virtual_New_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665702);
			JSONNode.NativeMethodInfoPtr_SaveToStream_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665703);
			JSONNode.NativeMethodInfoPtr_SaveToCompressedStream_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665704);
			JSONNode.NativeMethodInfoPtr_SaveToCompressedFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665705);
			JSONNode.NativeMethodInfoPtr_SaveToCompressedBase64_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665706);
			JSONNode.NativeMethodInfoPtr_SaveToFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665707);
			JSONNode.NativeMethodInfoPtr_SaveToBase64_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665708);
			JSONNode.NativeMethodInfoPtr_Deserialize_Public_Static_JSONNode_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665709);
			JSONNode.NativeMethodInfoPtr_LoadFromCompressedFile_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665710);
			JSONNode.NativeMethodInfoPtr_LoadFromCompressedStream_Public_Static_JSONNode_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665711);
			JSONNode.NativeMethodInfoPtr_LoadFromCompressedBase64_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665712);
			JSONNode.NativeMethodInfoPtr_LoadFromStream_Public_Static_JSONNode_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665713);
			JSONNode.NativeMethodInfoPtr_LoadFromFile_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665714);
			JSONNode.NativeMethodInfoPtr_LoadFromBase64_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665715);
			JSONNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100665716);
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00073A18 File Offset: 0x00071C18
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(string aKey, JSONNode aItem)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000973 RID: 2419
		public unsafe virtual JSONNode this[int aIndex]
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref aIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000974 RID: 2420
		public unsafe virtual JSONNode this[string aKey]
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00073BE8 File Offset: 0x00071DE8
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x00073C2C File Offset: 0x00071E2C
		public unsafe virtual string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254639, XrefRangeEnd = 254641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00073C7C File Offset: 0x00071E7C
		public unsafe virtual int Count
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00073CC4 File Offset: 0x00071EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254641, XrefRangeEnd = 254643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(JSONNode aItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00073D14 File Offset: 0x00071F14
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JSONNode Remove(string aKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00073D70 File Offset: 0x00071F70
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JSONNode Remove(int aIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00073DC8 File Offset: 0x00071FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23543, RefRangeEnd = 23544, XrefRangeStart = 23543, XrefRangeEnd = 23544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JSONNode Remove(JSONNode aNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00073E24 File Offset: 0x00072024
		public unsafe virtual IEnumerable<JSONNode> Childs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254643, XrefRangeEnd = 254647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Childs_Public_Virtual_New_get_IEnumerable_1_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JSONNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00073E70 File Offset: 0x00072070
		public unsafe IEnumerable<JSONNode> DeepChilds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254651, RefRangeEnd = 254652, XrefRangeStart = 254647, XrefRangeEnd = 254651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_get_DeepChilds_Public_get_IEnumerable_1_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JSONNode>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00073EB0 File Offset: 0x000720B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254652, XrefRangeEnd = 254654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00073EF4 File Offset: 0x000720F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254654, XrefRangeEnd = 254656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(string aPrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aPrefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x00073F48 File Offset: 0x00072148
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x00073F90 File Offset: 0x00072190
		public unsafe virtual int AsInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254656, XrefRangeEnd = 254657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsInt_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254657, XrefRangeEnd = 254658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_AsInt_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x00073FDC File Offset: 0x000721DC
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x00074024 File Offset: 0x00072224
		public unsafe virtual float AsFloat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254658, XrefRangeEnd = 254659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsFloat_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254659, XrefRangeEnd = 254660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_AsFloat_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x00074070 File Offset: 0x00072270
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x000740B8 File Offset: 0x000722B8
		public unsafe virtual double AsDouble
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254660, XrefRangeEnd = 254664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsDouble_Public_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254664, XrefRangeEnd = 254665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_AsDouble_Public_Virtual_New_set_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x00074104 File Offset: 0x00072304
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0007414C File Offset: 0x0007234C
		public unsafe virtual bool AsBool
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254665, XrefRangeEnd = 254670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsBool_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254670, XrefRangeEnd = 254675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_AsBool_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x00074198 File Offset: 0x00072398
		public unsafe virtual JSONArray AsArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254675, XrefRangeEnd = 254676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsArray_Public_Virtual_New_get_JSONArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x000741E4 File Offset: 0x000723E4
		public unsafe virtual JSONClass AsObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254676, XrefRangeEnd = 254677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsObject_Public_Virtual_New_get_JSONClass_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONClass>(intPtr3) : null;
			}
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00074230 File Offset: 0x00072430
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254681, RefRangeEnd = 254685, XrefRangeStart = 254677, XrefRangeEnd = 254681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JSONNode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00074274 File Offset: 0x00072474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254685, XrefRangeEnd = 254687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator string(JSONNode d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_String_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x000742B0 File Offset: 0x000724B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254689, RefRangeEnd = 254690, XrefRangeStart = 254687, XrefRangeEnd = 254689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(JSONNode a, Object b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_JSONNode_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00074304 File Offset: 0x00072504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254690, XrefRangeEnd = 254692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(JSONNode a, Object b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_JSONNode_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00074358 File Offset: 0x00072558
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x000743B0 File Offset: 0x000725B0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221576, XrefRangeStart = 221564, XrefRangeEnd = 221576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000743F8 File Offset: 0x000725F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254719, RefRangeEnd = 254723, XrefRangeStart = 254692, XrefRangeEnd = 254719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Escape(string aText)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_Escape_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00074434 File Offset: 0x00072634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254824, RefRangeEnd = 254825, XrefRangeStart = 254723, XrefRangeEnd = 254824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode Parse(string aJSON)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aJSON);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00074478 File Offset: 0x00072678
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Serialize(BinaryWriter aWriter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Serialize_Public_Virtual_New_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x000744C8 File Offset: 0x000726C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254829, RefRangeEnd = 254831, XrefRangeStart = 254825, XrefRangeEnd = 254829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveToStream(Stream aData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_SaveToStream_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0007450C File Offset: 0x0007270C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254831, XrefRangeEnd = 254837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveToCompressedStream(Stream aData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_SaveToCompressedStream_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00074550 File Offset: 0x00072750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254837, XrefRangeEnd = 254843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveToCompressedFile(string aFileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aFileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_SaveToCompressedFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00074594 File Offset: 0x00072794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254843, XrefRangeEnd = 254849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SaveToCompressedBase64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_SaveToCompressedBase64_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000745CC File Offset: 0x000727CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254849, XrefRangeEnd = 254861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveToFile(string aFileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aFileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_SaveToFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00074610 File Offset: 0x00072810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254861, XrefRangeEnd = 254874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SaveToBase64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_SaveToBase64_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00074648 File Offset: 0x00072848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254881, RefRangeEnd = 254883, XrefRangeStart = 254874, XrefRangeEnd = 254881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode Deserialize(BinaryReader aReader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_Deserialize_Public_Static_JSONNode_BinaryReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0007468C File Offset: 0x0007288C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254883, XrefRangeEnd = 254889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode LoadFromCompressedFile(string aFileName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aFileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_LoadFromCompressedFile_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x000746D0 File Offset: 0x000728D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254889, XrefRangeEnd = 254895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode LoadFromCompressedStream(Stream aData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_LoadFromCompressedStream_Public_Static_JSONNode_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00074714 File Offset: 0x00072914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254895, XrefRangeEnd = 254901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aBase64);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_LoadFromCompressedBase64_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00074758 File Offset: 0x00072958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254910, RefRangeEnd = 254912, XrefRangeStart = 254901, XrefRangeEnd = 254910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode LoadFromStream(Stream aData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_LoadFromStream_Public_Static_JSONNode_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x0007479C File Offset: 0x0007299C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254912, XrefRangeEnd = 254918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode LoadFromFile(string aFileName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aFileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_LoadFromFile_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x000747E0 File Offset: 0x000729E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254918, XrefRangeEnd = 254928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode LoadFromBase64(string aBase64)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aBase64);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_LoadFromBase64_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00074824 File Offset: 0x00072A24
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00012B25 File Offset: 0x00010D25
		public JSONNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_JSONNode_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_Int32_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_JSONNode_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_String_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_String_JSONNode_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_JSONNode_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_String_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_Int32_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_JSONNode_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_get_Childs_Public_Virtual_New_get_IEnumerable_1_JSONNode_0;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_get_DeepChilds_Public_get_IEnumerable_1_JSONNode_0;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_New_String_String_0;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_get_AsInt_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_set_AsInt_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_get_AsFloat_Public_Virtual_New_get_Single_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_set_AsFloat_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_get_AsDouble_Public_Virtual_New_get_Double_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_set_AsDouble_Public_Virtual_New_set_Void_Double_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_get_AsBool_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_set_AsBool_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_get_AsArray_Public_Virtual_New_get_JSONArray_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_get_AsObject_Public_Virtual_New_get_JSONClass_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_String_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_JSONNode_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_JSONNode_Object_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_JSONNode_Object_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_Escape_Internal_Static_String_String_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_New_Void_BinaryWriter_0;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeMethodInfoPtr_SaveToStream_Public_Void_Stream_0;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr_SaveToCompressedStream_Public_Void_Stream_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr_SaveToCompressedFile_Public_Void_String_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_SaveToCompressedBase64_Public_String_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_SaveToFile_Public_Void_String_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_SaveToBase64_Public_String_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_JSONNode_BinaryReader_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromCompressedFile_Public_Static_JSONNode_String_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromCompressedStream_Public_Static_JSONNode_Stream_0;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromCompressedBase64_Public_Static_JSONNode_String_0;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromStream_Public_Static_JSONNode_Stream_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFile_Public_Static_JSONNode_String_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromBase64_Public_Static_JSONNode_String_0;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000217 RID: 535
		[ObfuscatedName("UTNotifications.JSONNode+<get_Childs>d__17")]
		public sealed class _get_Childs_d__17 : Object
		{
			// Token: 0x060029D9 RID: 10713 RVA: 0x00096510 File Offset: 0x00094710
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Childs_d__17()
			{
				Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "<get_Childs>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr);
				JSONNode._get_Childs_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, "<>1__state");
				JSONNode._get_Childs_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, "<>2__current");
				JSONNode._get_Childs_d__17.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, "<>l__initialThreadId");
				JSONNode._get_Childs_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, 100666579);
				JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, 100666580);
				JSONNode._get_Childs_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, 100666581);
				JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, 100666582);
				JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, 100666583);
				JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, 100666584);
				JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, 100666585);
				JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr, 100666586);
			}

			// Token: 0x060029DA RID: 10714 RVA: 0x00096618 File Offset: 0x00094818
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 254576, RefRangeEnd = 254582, XrefRangeStart = 254574, XrefRangeEnd = 254576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Childs_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode._get_Childs_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Childs_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029DB RID: 10715 RVA: 0x00096660 File Offset: 0x00094860
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029DC RID: 10716 RVA: 0x00096694 File Offset: 0x00094894
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Childs_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D2E RID: 3374
			// (get) Token: 0x060029DD RID: 10717 RVA: 0x000966D0 File Offset: 0x000948D0
			public unsafe JSONNode System.Collections.Generic.IEnumerator<UTNotifications.JSONNode>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}

			// Token: 0x060029DE RID: 10718 RVA: 0x00096710 File Offset: 0x00094910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254582, XrefRangeEnd = 254587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D2F RID: 3375
			// (get) Token: 0x060029DF RID: 10719 RVA: 0x00096744 File Offset: 0x00094944
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029E0 RID: 10720 RVA: 0x00096784 File Offset: 0x00094984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254587, XrefRangeEnd = 254589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JSONNode> System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr3) : null;
			}

			// Token: 0x060029E1 RID: 10721 RVA: 0x000967C4 File Offset: 0x000949C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Childs_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060029E2 RID: 10722 RVA: 0x00019BEF File Offset: 0x00017DEF
			public _get_Childs_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D2B RID: 3371
			// (get) Token: 0x060029E3 RID: 10723 RVA: 0x00096804 File Offset: 0x00094A04
			// (set) Token: 0x060029E4 RID: 10724 RVA: 0x00019BF8 File Offset: 0x00017DF8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Childs_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Childs_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D2C RID: 3372
			// (get) Token: 0x060029E5 RID: 10725 RVA: 0x0009682C File Offset: 0x00094A2C
			// (set) Token: 0x060029E6 RID: 10726 RVA: 0x00019C13 File Offset: 0x00017E13
			public unsafe JSONNode __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Childs_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Childs_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D2D RID: 3373
			// (get) Token: 0x060029E7 RID: 10727 RVA: 0x0009685C File Offset: 0x00094A5C
			// (set) Token: 0x060029E8 RID: 10728 RVA: 0x00019C32 File Offset: 0x00017E32
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Childs_d__17.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Childs_d__17.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04001CA1 RID: 7329
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CA2 RID: 7330
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CA3 RID: 7331
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001CA4 RID: 7332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CA5 RID: 7333
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CA6 RID: 7334
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CA7 RID: 7335
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0;

			// Token: 0x04001CA8 RID: 7336
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CA9 RID: 7337
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CAA RID: 7338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0;

			// Token: 0x04001CAB RID: 7339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000218 RID: 536
		[ObfuscatedName("UTNotifications.JSONNode+<get_DeepChilds>d__19")]
		public sealed class _get_DeepChilds_d__19 : Object
		{
			// Token: 0x060029E9 RID: 10729 RVA: 0x00096884 File Offset: 0x00094A84
			// Note: this type is marked as 'beforefieldinit'.
			static _get_DeepChilds_d__19()
			{
				Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "<get_DeepChilds>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr);
				JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, "<>1__state");
				JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, "<>2__current");
				JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, "<>l__initialThreadId");
				JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, "<>4__this");
				JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, "<>7__wrap1");
				JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, "<>7__wrap2");
				JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, 100666587);
				JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, 100666588);
				JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, 100666589);
				JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, 100666590);
				JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, 100666591);
				JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, 100666592);
				JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, 100666593);
				JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, 100666594);
				JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, 100666595);
				JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr, 100666596);
			}

			// Token: 0x060029EA RID: 10730 RVA: 0x000969F0 File Offset: 0x00094BF0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 254576, RefRangeEnd = 254582, XrefRangeStart = 254576, XrefRangeEnd = 254582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_DeepChilds_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode._get_DeepChilds_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029EB RID: 10731 RVA: 0x00096A38 File Offset: 0x00094C38
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254597, RefRangeEnd = 254598, XrefRangeStart = 254589, XrefRangeEnd = 254597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029EC RID: 10732 RVA: 0x00096A6C File Offset: 0x00094C6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254598, XrefRangeEnd = 254626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060029ED RID: 10733 RVA: 0x00096AA8 File Offset: 0x00094CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254626, XrefRangeEnd = 254629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029EE RID: 10734 RVA: 0x00096ADC File Offset: 0x00094CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254629, XrefRangeEnd = 254632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D36 RID: 3382
			// (get) Token: 0x060029EF RID: 10735 RVA: 0x00096B10 File Offset: 0x00094D10
			public unsafe JSONNode System.Collections.Generic.IEnumerator<UTNotifications.JSONNode>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}

			// Token: 0x060029F0 RID: 10736 RVA: 0x00096B50 File Offset: 0x00094D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254632, XrefRangeEnd = 254637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D37 RID: 3383
			// (get) Token: 0x060029F1 RID: 10737 RVA: 0x00096B84 File Offset: 0x00094D84
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029F2 RID: 10738 RVA: 0x00096BC4 File Offset: 0x00094DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254637, XrefRangeEnd = 254639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JSONNode> System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr3) : null;
			}

			// Token: 0x060029F3 RID: 10739 RVA: 0x00096C04 File Offset: 0x00094E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChilds_d__19.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060029F4 RID: 10740 RVA: 0x00019C4D File Offset: 0x00017E4D
			public _get_DeepChilds_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D30 RID: 3376
			// (get) Token: 0x060029F5 RID: 10741 RVA: 0x00096C44 File Offset: 0x00094E44
			// (set) Token: 0x060029F6 RID: 10742 RVA: 0x00019C56 File Offset: 0x00017E56
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D31 RID: 3377
			// (get) Token: 0x060029F7 RID: 10743 RVA: 0x00096C6C File Offset: 0x00094E6C
			// (set) Token: 0x060029F8 RID: 10744 RVA: 0x00019C71 File Offset: 0x00017E71
			public unsafe JSONNode __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D32 RID: 3378
			// (get) Token: 0x060029F9 RID: 10745 RVA: 0x00096C9C File Offset: 0x00094E9C
			// (set) Token: 0x060029FA RID: 10746 RVA: 0x00019C90 File Offset: 0x00017E90
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D33 RID: 3379
			// (get) Token: 0x060029FB RID: 10747 RVA: 0x00096CC4 File Offset: 0x00094EC4
			// (set) Token: 0x060029FC RID: 10748 RVA: 0x00019CAB File Offset: 0x00017EAB
			public unsafe JSONNode __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D34 RID: 3380
			// (get) Token: 0x060029FD RID: 10749 RVA: 0x00096CF4 File Offset: 0x00094EF4
			// (set) Token: 0x060029FE RID: 10750 RVA: 0x00019CCA File Offset: 0x00017ECA
			public unsafe IEnumerator<JSONNode> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D35 RID: 3381
			// (get) Token: 0x060029FF RID: 10751 RVA: 0x00096D24 File Offset: 0x00094F24
			// (set) Token: 0x06002A00 RID: 10752 RVA: 0x00019CE9 File Offset: 0x00017EE9
			public unsafe IEnumerator<JSONNode> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChilds_d__19.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CAC RID: 7340
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CAD RID: 7341
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CAE RID: 7342
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001CAF RID: 7343
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CB0 RID: 7344
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001CB1 RID: 7345
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001CB2 RID: 7346
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CB3 RID: 7347
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CB4 RID: 7348
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CB5 RID: 7349
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001CB6 RID: 7350
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001CB7 RID: 7351
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UTNotifications_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0;

			// Token: 0x04001CB8 RID: 7352
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CB9 RID: 7353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CBA RID: 7354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UTNotifications_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0;

			// Token: 0x04001CBB RID: 7355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
