using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000027 RID: 39
	[DefaultMember("Item")]
	public sealed class XmlAttributeCollection : XmlNamedNodeMap
	{
		// Token: 0x0600034E RID: 846 RVA: 0x0001663C File Offset: 0x0001483C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAttributeCollection()
		{
			Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlAttributeCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr);
			XmlAttributeCollection.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663856);
			XmlAttributeCollection.NativeMethodInfoPtr_get_ItemOf_Public_get_XmlAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663857);
			XmlAttributeCollection.NativeMethodInfoPtr_SetNamedItem_Public_Virtual_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663858);
			XmlAttributeCollection.NativeMethodInfoPtr_Append_Public_XmlAttribute_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663859);
			XmlAttributeCollection.NativeMethodInfoPtr_Remove_Public_XmlAttribute_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663860);
			XmlAttributeCollection.NativeMethodInfoPtr_RemoveAt_Public_XmlAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663861);
			XmlAttributeCollection.NativeMethodInfoPtr_RemoveAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663862);
			XmlAttributeCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663863);
			XmlAttributeCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663864);
			XmlAttributeCollection.NativeMethodInfoPtr_AddNode_Internal_Virtual_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663865);
			XmlAttributeCollection.NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_XmlNode_Int32_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663866);
			XmlAttributeCollection.NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_XmlNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663867);
			XmlAttributeCollection.NativeMethodInfoPtr_Detach_Internal_Void_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663868);
			XmlAttributeCollection.NativeMethodInfoPtr_InsertParentIntoElementIdAttrMap_Internal_Void_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663869);
			XmlAttributeCollection.NativeMethodInfoPtr_RemoveParentFromElementIdAttrMap_Internal_Void_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663870);
			XmlAttributeCollection.NativeMethodInfoPtr_RemoveDuplicateAttribute_Internal_Int32_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663871);
			XmlAttributeCollection.NativeMethodInfoPtr_PrepareParentInElementIdAttrMap_Internal_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663872);
			XmlAttributeCollection.NativeMethodInfoPtr_ResetParentInElementIdAttrMap_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663873);
			XmlAttributeCollection.NativeMethodInfoPtr_InternalAppendAttribute_Internal_XmlAttribute_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr, 100663874);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000167E8 File Offset: 0x000149E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14791, RefRangeEnd = 14792, XrefRangeStart = 14790, XrefRangeEnd = 14791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributeCollection(XmlNode parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributeCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00016834 File Offset: 0x00014A34
		public unsafe XmlAttribute ItemOf
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 14795, RefRangeEnd = 14800, XrefRangeStart = 14792, XrefRangeEnd = 14795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_get_ItemOf_Public_get_XmlAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00016880 File Offset: 0x00014A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14800, XrefRangeEnd = 14804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode SetNamedItem(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_SetNamedItem_Public_Virtual_XmlNode_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000168D0 File Offset: 0x00014AD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14806, RefRangeEnd = 14809, XrefRangeStart = 14804, XrefRangeEnd = 14806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute Append(XmlAttribute node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_Append_Public_XmlAttribute_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00016920 File Offset: 0x00014B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14809, XrefRangeEnd = 14811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute Remove(XmlAttribute node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_Remove_Public_XmlAttribute_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00016970 File Offset: 0x00014B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14811, XrefRangeEnd = 14813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute RemoveAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_RemoveAt_Public_XmlAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000169BC File Offset: 0x00014BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14815, RefRangeEnd = 14816, XrefRangeStart = 14813, XrefRangeEnd = 14815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_RemoveAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000169F0 File Offset: 0x00014BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14816, XrefRangeEnd = 14818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_ICollection_CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00016A40 File Offset: 0x00014C40
		public unsafe int System.Collections.ICollection.Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14818, XrefRangeEnd = 14819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00016A7C File Offset: 0x00014C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14819, XrefRangeEnd = 14826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode AddNode(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_AddNode_Internal_Virtual_XmlNode_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00016ACC File Offset: 0x00014CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14826, XrefRangeEnd = 14830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode InsertNodeAt(int i, XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_XmlNode_Int32_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00016B2C File Offset: 0x00014D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14830, XrefRangeEnd = 14839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode RemoveNodeAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_XmlNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00016B78 File Offset: 0x00014D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14839, XrefRangeEnd = 14841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Detach(XmlAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_Detach_Internal_Void_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00016BBC File Offset: 0x00014DBC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14847, RefRangeEnd = 14851, XrefRangeStart = 14841, XrefRangeEnd = 14847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertParentIntoElementIdAttrMap(XmlAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_InsertParentIntoElementIdAttrMap_Internal_Void_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00016C00 File Offset: 0x00014E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14857, RefRangeEnd = 14858, XrefRangeStart = 14851, XrefRangeEnd = 14857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveParentFromElementIdAttrMap(XmlAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_RemoveParentFromElementIdAttrMap_Internal_Void_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00016C44 File Offset: 0x00014E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14870, RefRangeEnd = 14871, XrefRangeStart = 14858, XrefRangeEnd = 14870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RemoveDuplicateAttribute(XmlAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_RemoveDuplicateAttribute_Internal_Int32_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00016C94 File Offset: 0x00014E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14871, XrefRangeEnd = 14877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attrPrefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrLocalName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_PrepareParentInElementIdAttrMap_Internal_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00016CF4 File Offset: 0x00014EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14877, XrefRangeEnd = 14883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetParentInElementIdAttrMap(string oldVal, string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldVal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_ResetParentInElementIdAttrMap_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00016D48 File Offset: 0x00014F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14887, RefRangeEnd = 14888, XrefRangeStart = 14883, XrefRangeEnd = 14887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute InternalAppendAttribute(XmlAttribute node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeCollection.NativeMethodInfoPtr_InternalAppendAttribute_Internal_XmlAttribute_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000324C File Offset: 0x0000144C
		public XmlAttributeCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemOf_Public_get_XmlAttribute_Int32_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_SetNamedItem_Public_Virtual_XmlNode_XmlNode_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_XmlAttribute_XmlAttribute_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_XmlAttribute_XmlAttribute_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_XmlAttribute_Int32_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Void_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_AddNode_Internal_Virtual_XmlNode_XmlNode_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_XmlNode_Int32_XmlNode_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_XmlNode_Int32_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_Detach_Internal_Void_XmlAttribute_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_InsertParentIntoElementIdAttrMap_Internal_Void_XmlAttribute_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_RemoveParentFromElementIdAttrMap_Internal_Void_XmlAttribute_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDuplicateAttribute_Internal_Int32_XmlAttribute_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_PrepareParentInElementIdAttrMap_Internal_Boolean_String_String_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_ResetParentInElementIdAttrMap_Internal_Void_String_String_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_InternalAppendAttribute_Internal_XmlAttribute_XmlAttribute_0;
	}
}
