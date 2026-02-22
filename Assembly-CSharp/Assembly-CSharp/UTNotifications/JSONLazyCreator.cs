using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UTNotifications
{
	// Token: 0x020000F8 RID: 248
	public class JSONLazyCreator : JSONNode
	{
		// Token: 0x06001DED RID: 7661 RVA: 0x000758FC File Offset: 0x00073AFC
		// Note: this type is marked as 'beforefieldinit'.
		static JSONLazyCreator()
		{
			Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "JSONLazyCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr);
			JSONLazyCreator.NativeFieldInfoPtr_m_Node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, "m_Node");
			JSONLazyCreator.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, "m_Key");
			JSONLazyCreator.NativeMethodInfoPtr__ctor_Public_Void_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665756);
			JSONLazyCreator.NativeMethodInfoPtr__ctor_Public_Void_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665757);
			JSONLazyCreator.NativeMethodInfoPtr_Set_Private_Void_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665758);
			JSONLazyCreator.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665759);
			JSONLazyCreator.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665760);
			JSONLazyCreator.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665761);
			JSONLazyCreator.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665762);
			JSONLazyCreator.NativeMethodInfoPtr_Add_Public_Virtual_Void_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665763);
			JSONLazyCreator.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665764);
			JSONLazyCreator.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_JSONLazyCreator_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665765);
			JSONLazyCreator.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_JSONLazyCreator_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665766);
			JSONLazyCreator.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665767);
			JSONLazyCreator.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665768);
			JSONLazyCreator.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665769);
			JSONLazyCreator.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665770);
			JSONLazyCreator.NativeMethodInfoPtr_get_AsInt_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665771);
			JSONLazyCreator.NativeMethodInfoPtr_set_AsInt_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665772);
			JSONLazyCreator.NativeMethodInfoPtr_get_AsFloat_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665773);
			JSONLazyCreator.NativeMethodInfoPtr_set_AsFloat_Public_Virtual_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665774);
			JSONLazyCreator.NativeMethodInfoPtr_get_AsDouble_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665775);
			JSONLazyCreator.NativeMethodInfoPtr_set_AsDouble_Public_Virtual_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665776);
			JSONLazyCreator.NativeMethodInfoPtr_get_AsBool_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665777);
			JSONLazyCreator.NativeMethodInfoPtr_set_AsBool_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665778);
			JSONLazyCreator.NativeMethodInfoPtr_get_AsArray_Public_Virtual_get_JSONArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665779);
			JSONLazyCreator.NativeMethodInfoPtr_get_AsObject_Public_Virtual_get_JSONClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr, 100665780);
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00075B48 File Offset: 0x00073D48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 255404, RefRangeEnd = 255408, XrefRangeStart = 255403, XrefRangeEnd = 255404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONLazyCreator(JSONNode aNode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONLazyCreator.NativeMethodInfoPtr__ctor_Public_Void_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00075B94 File Offset: 0x00073D94
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONLazyCreator(JSONNode aNode, string aKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONLazyCreator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONLazyCreator.NativeMethodInfoPtr__ctor_Public_Void_JSONNode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00075BF4 File Offset: 0x00073DF4
		[CallerCount(0)]
		public unsafe void Set(JSONNode aVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aVal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONLazyCreator.NativeMethodInfoPtr_Set_Private_Void_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700098D RID: 2445
		public unsafe override JSONNode this[int aIndex]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255408, XrefRangeEnd = 255412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref aIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255412, XrefRangeEnd = 255423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700098E RID: 2446
		public unsafe override JSONNode this[string aKey]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255423, XrefRangeEnd = 255427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255427, XrefRangeEnd = 255438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00075DA8 File Offset: 0x00073FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255438, XrefRangeEnd = 255449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Add(JSONNode aItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_Add_Public_Virtual_Void_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00075DF8 File Offset: 0x00073FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255449, XrefRangeEnd = 255460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00075E58 File Offset: 0x00074058
		[CallerCount(0)]
		public unsafe static bool operator ==(JSONLazyCreator a, Object b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONLazyCreator.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_JSONLazyCreator_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00075EAC File Offset: 0x000740AC
		[CallerCount(0)]
		public unsafe static bool operator !=(JSONLazyCreator a, Object b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONLazyCreator.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_JSONLazyCreator_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00075F00 File Offset: 0x00074100
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00075F58 File Offset: 0x00074158
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221576, XrefRangeStart = 221564, XrefRangeEnd = 221576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00075FA0 File Offset: 0x000741A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255460, XrefRangeEnd = 255462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00075FE4 File Offset: 0x000741E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255462, XrefRangeEnd = 255464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(string aPrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aPrefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00076038 File Offset: 0x00074238
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x00076080 File Offset: 0x00074280
		public unsafe override int AsInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255464, XrefRangeEnd = 255469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_get_AsInt_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255469, XrefRangeEnd = 255474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_set_AsInt_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x000760CC File Offset: 0x000742CC
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x00076114 File Offset: 0x00074314
		public unsafe override float AsFloat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255474, XrefRangeEnd = 255479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_get_AsFloat_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255479, XrefRangeEnd = 255484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_set_AsFloat_Public_Virtual_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x00076160 File Offset: 0x00074360
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x000761A8 File Offset: 0x000743A8
		public unsafe override double AsDouble
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255484, XrefRangeEnd = 255489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_get_AsDouble_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255489, XrefRangeEnd = 255494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_set_AsDouble_Public_Virtual_set_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x000761F4 File Offset: 0x000743F4
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0007623C File Offset: 0x0007443C
		public unsafe override bool AsBool
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255494, XrefRangeEnd = 255499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_get_AsBool_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255499, XrefRangeEnd = 255504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_set_AsBool_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x00076288 File Offset: 0x00074488
		public unsafe override JSONArray AsArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255504, XrefRangeEnd = 255515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_get_AsArray_Public_Virtual_get_JSONArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x000762D4 File Offset: 0x000744D4
		public unsafe override JSONClass AsObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255515, XrefRangeEnd = 255526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONLazyCreator.NativeMethodInfoPtr_get_AsObject_Public_Virtual_get_JSONClass_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONClass>(intPtr3) : null;
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00012BA6 File Offset: 0x00010DA6
		public JSONLazyCreator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x00076320 File Offset: 0x00074520
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x00012BAF File Offset: 0x00010DAF
		public unsafe JSONNode m_Node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONLazyCreator.NativeFieldInfoPtr_m_Node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONLazyCreator.NativeFieldInfoPtr_m_Node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x00076350 File Offset: 0x00074550
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x00012BCE File Offset: 0x00010DCE
		public unsafe string m_Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONLazyCreator.NativeFieldInfoPtr_m_Key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONLazyCreator.NativeFieldInfoPtr_m_Key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeFieldInfoPtr_m_Node;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeFieldInfoPtr_m_Key;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JSONNode_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JSONNode_String_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_JSONNode_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_Int32_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_JSONNode_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JSONNode_String_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_String_JSONNode_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_JSONNode_0;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_String_JSONNode_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_JSONLazyCreator_Object_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_JSONLazyCreator_Object_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_get_AsInt_Public_Virtual_get_Int32_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr_set_AsInt_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_get_AsFloat_Public_Virtual_get_Single_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_set_AsFloat_Public_Virtual_set_Void_Single_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_get_AsDouble_Public_Virtual_get_Double_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_set_AsDouble_Public_Virtual_set_Void_Double_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_get_AsBool_Public_Virtual_get_Boolean_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_set_AsBool_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_get_AsArray_Public_Virtual_get_JSONArray_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_get_AsObject_Public_Virtual_get_JSONClass_0;
	}
}
