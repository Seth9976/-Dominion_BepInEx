using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x020000A9 RID: 169
	[Serializable]
	public class StringCollection : Object
	{
		// Token: 0x06000A4A RID: 2634 RVA: 0x00036D64 File Offset: 0x00034F64
		// Note: this type is marked as 'beforefieldinit'.
		static StringCollection()
		{
			Il2CppClassPointerStore<StringCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "StringCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringCollection>.NativeClassPtr);
			StringCollection.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, "data");
			StringCollection.NativeMethodInfoPtr_get_Item_Public_get_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664680);
			StringCollection.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664681);
			StringCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664682);
			StringCollection.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664683);
			StringCollection.NativeMethodInfoPtr_Add_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664684);
			StringCollection.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664685);
			StringCollection.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664686);
			StringCollection.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664687);
			StringCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664688);
			StringCollection.NativeMethodInfoPtr_Insert_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664689);
			StringCollection.NativeMethodInfoPtr_Remove_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664690);
			StringCollection.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664691);
			StringCollection.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664692);
			StringCollection.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664693);
			StringCollection.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664694);
			StringCollection.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664695);
			StringCollection.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664696);
			StringCollection.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664697);
			StringCollection.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664698);
			StringCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664699);
			StringCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664700);
			StringCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringCollection>.NativeClassPtr, 100664701);
		}

		// Token: 0x17000318 RID: 792
		public unsafe string this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44416, XrefRangeEnd = 44418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_get_Item_Public_get_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44418, XrefRangeEnd = 44419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00036FF4 File Offset: 0x000351F4
		public unsafe virtual int Count
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 12038, RefRangeEnd = 12046, XrefRangeStart = 12038, XrefRangeEnd = 12046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00037030 File Offset: 0x00035230
		public unsafe virtual bool System.Collections.IList.IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0003706C File Offset: 0x0003526C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 41402, RefRangeEnd = 41405, XrefRangeStart = 41402, XrefRangeEnd = 41405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_Add_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000370BC File Offset: 0x000352BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000370F0 File Offset: 0x000352F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44419, XrefRangeEnd = 44420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00037140 File Offset: 0x00035340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42661, RefRangeEnd = 42662, XrefRangeStart = 42661, XrefRangeEnd = 42662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppStringArray array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00037190 File Offset: 0x00035390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44420, XrefRangeEnd = 44421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000371E0 File Offset: 0x000353E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44421, XrefRangeEnd = 44422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_Insert_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00037230 File Offset: 0x00035430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44422, XrefRangeEnd = 44423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_Remove_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00037274 File Offset: 0x00035474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44423, XrefRangeEnd = 44424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x000372B4 File Offset: 0x000354B4
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00037300 File Offset: 0x00035500
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44424, XrefRangeEnd = 44428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00037350 File Offset: 0x00035550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44428, XrefRangeEnd = 44432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000373A0 File Offset: 0x000355A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44432, XrefRangeEnd = 44436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000373F0 File Offset: 0x000355F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44436, XrefRangeEnd = 44440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00037440 File Offset: 0x00035640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44440, XrefRangeEnd = 44444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Insert(int index, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00037490 File Offset: 0x00035690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44444, XrefRangeEnd = 44448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x000374D4 File Offset: 0x000356D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42661, RefRangeEnd = 42662, XrefRangeStart = 42661, XrefRangeEnd = 42662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00037524 File Offset: 0x00035724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44448, XrefRangeEnd = 44449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00037564 File Offset: 0x00035764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44454, RefRangeEnd = 44455, XrefRangeStart = 44449, XrefRangeEnd = 44454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000061A8 File Offset: 0x000043A8
		public StringCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x000375A0 File Offset: 0x000357A0
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x000061B1 File Offset: 0x000043B1
		public unsafe ArrayList data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCollection.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringCollection.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_String_Int32_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_String_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_String_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppStringArray_Int32_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_String_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_String_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
