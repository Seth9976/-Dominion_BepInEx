using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000B4 RID: 180
	[Serializable]
	public class SortedSet<T> : Object
	{
		// Token: 0x06000AEC RID: 2796 RVA: 0x00039CB4 File Offset: 0x00037EB4
		// Note: this type is marked as 'beforefieldinit'.
		static SortedSet()
		{
			Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "SortedSet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr);
			SortedSet<T>.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "root");
			SortedSet<T>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "comparer");
			SortedSet<T>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "count");
			SortedSet<T>.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "version");
			SortedSet<T>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "_syncRoot");
			SortedSet<T>.NativeFieldInfoPtr_siInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "siInfo");
			SortedSet<T>.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "ComparerName");
			SortedSet<T>.NativeFieldInfoPtr_CountName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "CountName");
			SortedSet<T>.NativeFieldInfoPtr_ItemsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "ItemsName");
			SortedSet<T>.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "VersionName");
			SortedSet<T>.NativeFieldInfoPtr_TreeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "TreeName");
			SortedSet<T>.NativeFieldInfoPtr_NodeValueName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "NodeValueName");
			SortedSet<T>.NativeFieldInfoPtr_EnumStartName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "EnumStartName");
			SortedSet<T>.NativeFieldInfoPtr_ReverseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "ReverseName");
			SortedSet<T>.NativeFieldInfoPtr_EnumVersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "EnumVersionName");
			SortedSet<T>.NativeFieldInfoPtr_MinName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "MinName");
			SortedSet<T>.NativeFieldInfoPtr_MaxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "MaxName");
			SortedSet<T>.NativeFieldInfoPtr_LowerBoundActiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "LowerBoundActiveName");
			SortedSet<T>.NativeFieldInfoPtr_UpperBoundActiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "UpperBoundActiveName");
			SortedSet<T>.NativeFieldInfoPtr_StackAllocThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "StackAllocThreshold");
			SortedSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664823);
			SortedSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664824);
			SortedSet<T>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664825);
			SortedSet<T>.NativeMethodInfoPtr_InOrderTreeWalk_Internal_Virtual_New_Boolean_TreeWalkPredicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664826);
			SortedSet<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664827);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664828);
			SortedSet<T>.NativeMethodInfoPtr_VersionCheck_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664829);
			SortedSet<T>.NativeMethodInfoPtr_IsWithinRange_Internal_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664830);
			SortedSet<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664831);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664832);
			SortedSet<T>.NativeMethodInfoPtr_AddIfNotPresent_Internal_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664833);
			SortedSet<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664834);
			SortedSet<T>.NativeMethodInfoPtr_DoRemove_Internal_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664835);
			SortedSet<T>.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664836);
			SortedSet<T>.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664837);
			SortedSet<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664838);
			SortedSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664839);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664840);
			SortedSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664841);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664842);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664843);
			SortedSet<T>.NativeMethodInfoPtr_InsertionBalance_Private_Void_Node_T_byref_Node_T_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664844);
			SortedSet<T>.NativeMethodInfoPtr_ReplaceChildOrRoot_Private_Void_Node_T_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664845);
			SortedSet<T>.NativeMethodInfoPtr_ReplaceNode_Private_Void_Node_T_Node_T_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664846);
			SortedSet<T>.NativeMethodInfoPtr_FindNode_Internal_Virtual_New_Node_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664847);
			SortedSet<T>.NativeMethodInfoPtr_UpdateVersion_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664848);
			SortedSet<T>.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664849);
			SortedSet<T>.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664850);
			SortedSet<T>.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664851);
			SortedSet<T>.NativeMethodInfoPtr_OnDeserialization_Protected_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664852);
			SortedSet<T>.NativeMethodInfoPtr_Log2_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100664853);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0003A11C File Offset: 0x0003831C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45491, XrefRangeEnd = 45492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0003A158 File Offset: 0x00038358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45492, XrefRangeEnd = 45493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedSet(IComparer<T> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0003A1A4 File Offset: 0x000383A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45493, XrefRangeEnd = 45494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedSet(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0003A208 File Offset: 0x00038408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45494, XrefRangeEnd = 45499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_InOrderTreeWalk_Internal_Virtual_New_Boolean_TreeWalkPredicate_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0003A260 File Offset: 0x00038460
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0003A29C File Offset: 0x0003849C
		public unsafe virtual bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0003A2D8 File Offset: 0x000384D8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void VersionCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_VersionCheck_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0003A314 File Offset: 0x00038514
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsWithinRange(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_IsWithinRange_Internal_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0003A3A4 File Offset: 0x000385A4
		[CallerCount(0)]
		public unsafe virtual bool Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0003A428 File Offset: 0x00038628
		[CallerCount(0)]
		public unsafe virtual void System_Collections_Generic_ICollection_T__Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0003A4A0 File Offset: 0x000386A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45499, XrefRangeEnd = 45506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AddIfNotPresent(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_AddIfNotPresent_Internal_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0003A530 File Offset: 0x00038730
		[CallerCount(0)]
		public unsafe virtual bool Remove(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0003A5B4 File Offset: 0x000387B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45506, XrefRangeEnd = 45515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoRemove(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_DoRemove_Internal_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0003A644 File Offset: 0x00038844
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0003A680 File Offset: 0x00038880
		[CallerCount(0)]
		public unsafe virtual bool Contains(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0003A710 File Offset: 0x00038910
		[CallerCount(0)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0003A760 File Offset: 0x00038960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45515, XrefRangeEnd = 45585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppArrayBase<T> array, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0003A7C0 File Offset: 0x000389C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45585, XrefRangeEnd = 45600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0003A810 File Offset: 0x00038A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45600, XrefRangeEnd = 45601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedSet<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SortedSet<T>.Enumerator(intPtr);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0003A848 File Offset: 0x00038A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45601, XrefRangeEnd = 45603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0003A888 File Offset: 0x00038A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0003A8C8 File Offset: 0x00038AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45603, XrefRangeEnd = 45607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertionBalance(SortedSet<T>.Node current, ref SortedSet<T>.Node parent, SortedSet<T>.Node grandParent, SortedSet<T>.Node greatGrandParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grandParent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(greatGrandParent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_InsertionBalance_Private_Void_Node_T_byref_Node_T_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parent = ((intPtr4 == 0) ? null : new SortedSet<T>.Node(intPtr4));
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0003A958 File Offset: 0x00038B58
		[CallerCount(0)]
		public unsafe void ReplaceChildOrRoot(SortedSet<T>.Node parent, SortedSet<T>.Node child, SortedSet<T>.Node newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(child);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_ReplaceChildOrRoot_Private_Void_Node_T_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0003A9C0 File Offset: 0x00038BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45607, XrefRangeEnd = 45610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceNode(SortedSet<T>.Node match, SortedSet<T>.Node parentOfMatch, SortedSet<T>.Node successor, SortedSet<T>.Node parentOfSuccessor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentOfMatch);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(successor);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentOfSuccessor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_ReplaceNode_Private_Void_Node_T_Node_T_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0003AA3C File Offset: 0x00038C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45610, XrefRangeEnd = 45614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SortedSet<T>.Node FindNode(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_FindNode_Internal_Virtual_New_Node_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr4) : null;
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0003AAD0 File Offset: 0x00038CD0
		[CallerCount(0)]
		public unsafe void UpdateVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_UpdateVersion_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0003AB04 File Offset: 0x00038D04
		[CallerCount(0)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0003AB60 File Offset: 0x00038D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45614, XrefRangeEnd = 45635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0003ABC4 File Offset: 0x00038DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45635, XrefRangeEnd = 45636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0003AC08 File Offset: 0x00038E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45636, XrefRangeEnd = 45661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_OnDeserialization_Protected_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0003AC58 File Offset: 0x00038E58
		[CallerCount(0)]
		public unsafe static int Log2(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_Log2_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00006473 File Offset: 0x00004673
		public SortedSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0003AC98 File Offset: 0x00038E98
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x0000647C File Offset: 0x0000467C
		public unsafe SortedSet<T>.Node root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0003ACC8 File Offset: 0x00038EC8
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x0000649B File Offset: 0x0000469B
		public unsafe IComparer<T> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x0003ACF8 File Offset: 0x00038EF8
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x000064BA File Offset: 0x000046BA
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0003AD20 File Offset: 0x00038F20
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x000064D5 File Offset: 0x000046D5
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0003AD48 File Offset: 0x00038F48
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x000064F0 File Offset: 0x000046F0
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0003AD78 File Offset: 0x00038F78
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x0000650F File Offset: 0x0000470F
		public unsafe SerializationInfo siInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_siInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_siInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0003ADA8 File Offset: 0x00038FA8
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x0000652E File Offset: 0x0000472E
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0003ADC8 File Offset: 0x00038FC8
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00006540 File Offset: 0x00004740
		public unsafe static string CountName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_CountName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_CountName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0003ADE8 File Offset: 0x00038FE8
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00006552 File Offset: 0x00004752
		public unsafe static string ItemsName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_ItemsName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_ItemsName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0003AE08 File Offset: 0x00039008
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00006564 File Offset: 0x00004764
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0003AE28 File Offset: 0x00039028
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00006576 File Offset: 0x00004776
		public unsafe static string TreeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_TreeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_TreeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x0003AE48 File Offset: 0x00039048
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00006588 File Offset: 0x00004788
		public unsafe static string NodeValueName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_NodeValueName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_NodeValueName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0003AE68 File Offset: 0x00039068
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x0000659A File Offset: 0x0000479A
		public unsafe static string EnumStartName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_EnumStartName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_EnumStartName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0003AE88 File Offset: 0x00039088
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x000065AC File Offset: 0x000047AC
		public unsafe static string ReverseName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_ReverseName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_ReverseName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0003AEA8 File Offset: 0x000390A8
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x000065BE File Offset: 0x000047BE
		public unsafe static string EnumVersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_EnumVersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_EnumVersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0003AEC8 File Offset: 0x000390C8
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x000065D0 File Offset: 0x000047D0
		public unsafe static string MinName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_MinName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_MinName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0003AEE8 File Offset: 0x000390E8
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x000065E2 File Offset: 0x000047E2
		public unsafe static string MaxName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_MaxName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_MaxName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0003AF08 File Offset: 0x00039108
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x000065F4 File Offset: 0x000047F4
		public unsafe static string LowerBoundActiveName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_LowerBoundActiveName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_LowerBoundActiveName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0003AF28 File Offset: 0x00039128
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00006606 File Offset: 0x00004806
		public unsafe static string UpperBoundActiveName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_UpperBoundActiveName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_UpperBoundActiveName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0003AF48 File Offset: 0x00039148
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00006618 File Offset: 0x00004818
		public unsafe static int StackAllocThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_StackAllocThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_StackAllocThreshold, (void*)(&value));
			}
		}

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeFieldInfoPtr_siInfo;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr_CountName;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr_ItemsName;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr_TreeName;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeFieldInfoPtr_NodeValueName;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeFieldInfoPtr_EnumStartName;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeFieldInfoPtr_ReverseName;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeFieldInfoPtr_EnumVersionName;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeFieldInfoPtr_MinName;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeFieldInfoPtr_MaxName;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeFieldInfoPtr_LowerBoundActiveName;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeFieldInfoPtr_UpperBoundActiveName;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr_StackAllocThreshold;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_InOrderTreeWalk_Internal_Virtual_New_Boolean_TreeWalkPredicate_1_T_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_VersionCheck_Internal_Virtual_New_Void_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_IsWithinRange_Internal_Virtual_New_Boolean_T_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_AddIfNotPresent_Internal_Virtual_New_Boolean_T_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_DoRemove_Internal_Virtual_New_Boolean_T_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_T_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_InsertionBalance_Private_Void_Node_T_byref_Node_T_Node_T_Node_T_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceChildOrRoot_Private_Void_Node_T_Node_T_Node_T_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceNode_Private_Void_Node_T_Node_T_Node_T_Node_T_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_FindNode_Internal_Virtual_New_Node_T_T_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVersion_Internal_Void_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Protected_Virtual_New_Void_Object_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_Log2_Private_Static_Int32_Int32_0;

		// Token: 0x020001A5 RID: 421
		[Serializable]
		public sealed class Node : Object
		{
			// Token: 0x06001803 RID: 6147 RVA: 0x00067828 File Offset: 0x00065A28
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "Node"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr);
				SortedSet<T>.Node.NativeFieldInfoPtr__Item_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, "<Item>k__BackingField");
				SortedSet<T>.Node.NativeFieldInfoPtr__Left_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, "<Left>k__BackingField");
				SortedSet<T>.Node.NativeFieldInfoPtr__Right_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, "<Right>k__BackingField");
				SortedSet<T>.Node.NativeFieldInfoPtr__Color_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, "<Color>k__BackingField");
				SortedSet<T>.Node.NativeMethodInfoPtr__ctor_Public_Void_T_NodeColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664854);
				SortedSet<T>.Node.NativeMethodInfoPtr_IsNonNullRed_Public_Static_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664855);
				SortedSet<T>.Node.NativeMethodInfoPtr_IsNullOrBlack_Public_Static_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664856);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Item_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664857);
				SortedSet<T>.Node.NativeMethodInfoPtr_set_Item_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664858);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Left_Public_get_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664859);
				SortedSet<T>.Node.NativeMethodInfoPtr_set_Left_Public_set_Void_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664860);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Right_Public_get_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664861);
				SortedSet<T>.Node.NativeMethodInfoPtr_set_Right_Public_set_Void_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664862);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Color_Public_get_NodeColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664863);
				SortedSet<T>.Node.NativeMethodInfoPtr_set_Color_Public_set_Void_NodeColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664864);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_IsBlack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664865);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_IsRed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664866);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Is2Node_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664867);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Is4Node_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664868);
				SortedSet<T>.Node.NativeMethodInfoPtr_ColorBlack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664869);
				SortedSet<T>.Node.NativeMethodInfoPtr_ColorRed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664870);
				SortedSet<T>.Node.NativeMethodInfoPtr_GetRotation_Public_TreeRotation_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664871);
				SortedSet<T>.Node.NativeMethodInfoPtr_GetSibling_Public_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664872);
				SortedSet<T>.Node.NativeMethodInfoPtr_Split4Node_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664873);
				SortedSet<T>.Node.NativeMethodInfoPtr_Rotate_Public_Node_T_TreeRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664874);
				SortedSet<T>.Node.NativeMethodInfoPtr_RotateLeft_Public_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664875);
				SortedSet<T>.Node.NativeMethodInfoPtr_RotateLeftRight_Public_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664876);
				SortedSet<T>.Node.NativeMethodInfoPtr_RotateRight_Public_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664877);
				SortedSet<T>.Node.NativeMethodInfoPtr_RotateRightLeft_Public_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664878);
				SortedSet<T>.Node.NativeMethodInfoPtr_Merge2Nodes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664879);
				SortedSet<T>.Node.NativeMethodInfoPtr_ReplaceChild_Public_Void_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100664880);
			}

			// Token: 0x06001804 RID: 6148 RVA: 0x00067AFC File Offset: 0x00065CFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45331, XrefRangeEnd = 45335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node(T item, NodeColor color)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = item;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr__ctor_Public_Void_T_NodeColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06001805 RID: 6149 RVA: 0x00067B8C File Offset: 0x00065D8C
			[CallerCount(0)]
			public unsafe static bool IsNonNullRed(SortedSet<T>.Node node)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_IsNonNullRed_Public_Static_Boolean_Node_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001806 RID: 6150 RVA: 0x00067BD0 File Offset: 0x00065DD0
			[CallerCount(0)]
			public unsafe static bool IsNullOrBlack(SortedSet<T>.Node node)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_IsNullOrBlack_Public_Static_Boolean_Node_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x06001807 RID: 6151 RVA: 0x00067C14 File Offset: 0x00065E14
			// (set) Token: 0x06001808 RID: 6152 RVA: 0x00067C50 File Offset: 0x00065E50
			public unsafe T Item
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Item_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						IntPtr intPtr;
						if (!typeof(T).IsValueType)
						{
							T t = value;
							intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						}
						else
						{
							intPtr = ref value;
						}
						ptr2 = intPtr;
						IntPtr intPtr3;
						IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_set_Item_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
						Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					}
				}
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x06001809 RID: 6153 RVA: 0x00067CC8 File Offset: 0x00065EC8
			// (set) Token: 0x0600180A RID: 6154 RVA: 0x00067D08 File Offset: 0x00065F08
			public unsafe SortedSet<T>.Node Left
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Left_Public_get_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
				}
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_set_Left_Public_set_Void_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x0600180B RID: 6155 RVA: 0x00067D4C File Offset: 0x00065F4C
			// (set) Token: 0x0600180C RID: 6156 RVA: 0x00067D8C File Offset: 0x00065F8C
			public unsafe SortedSet<T>.Node Right
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Right_Public_get_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_set_Right_Public_set_Void_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x0600180D RID: 6157 RVA: 0x00067DD0 File Offset: 0x00065FD0
			// (set) Token: 0x0600180E RID: 6158 RVA: 0x00067E0C File Offset: 0x0006600C
			public unsafe NodeColor Color
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Color_Public_get_NodeColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_set_Color_Public_set_Void_NodeColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x0600180F RID: 6159 RVA: 0x00067E4C File Offset: 0x0006604C
			public unsafe bool IsBlack
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_IsBlack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170007BB RID: 1979
			// (get) Token: 0x06001810 RID: 6160 RVA: 0x00067E88 File Offset: 0x00066088
			public unsafe bool IsRed
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_IsRed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170007BC RID: 1980
			// (get) Token: 0x06001811 RID: 6161 RVA: 0x00067EC4 File Offset: 0x000660C4
			public unsafe bool Is2Node
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Is2Node_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170007BD RID: 1981
			// (get) Token: 0x06001812 RID: 6162 RVA: 0x00067F00 File Offset: 0x00066100
			public unsafe bool Is4Node
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Is4Node_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001813 RID: 6163 RVA: 0x00067F3C File Offset: 0x0006613C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45335, XrefRangeEnd = 45336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ColorBlack()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_ColorBlack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001814 RID: 6164 RVA: 0x00067F70 File Offset: 0x00066170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45336, XrefRangeEnd = 45337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ColorRed()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_ColorRed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001815 RID: 6165 RVA: 0x00067FA4 File Offset: 0x000661A4
			[CallerCount(0)]
			public unsafe TreeRotation GetRotation(SortedSet<T>.Node current, SortedSet<T>.Node sibling)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sibling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_GetRotation_Public_TreeRotation_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001816 RID: 6166 RVA: 0x00068004 File Offset: 0x00066204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45337, XrefRangeEnd = 45339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SortedSet<T>.Node GetSibling(SortedSet<T>.Node node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_GetSibling_Public_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
				}
			}

			// Token: 0x06001817 RID: 6167 RVA: 0x00068054 File Offset: 0x00066254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45339, XrefRangeEnd = 45344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Split4Node()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_Split4Node_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001818 RID: 6168 RVA: 0x00068088 File Offset: 0x00066288
			[CallerCount(0)]
			public unsafe SortedSet<T>.Node Rotate(TreeRotation rotation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref rotation;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_Rotate_Public_Node_T_TreeRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
				}
			}

			// Token: 0x06001819 RID: 6169 RVA: 0x000680D4 File Offset: 0x000662D4
			[CallerCount(0)]
			public unsafe SortedSet<T>.Node RotateLeft()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_RotateLeft_Public_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
			}

			// Token: 0x0600181A RID: 6170 RVA: 0x00068114 File Offset: 0x00066314
			[CallerCount(0)]
			public unsafe SortedSet<T>.Node RotateLeftRight()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_RotateLeftRight_Public_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
			}

			// Token: 0x0600181B RID: 6171 RVA: 0x00068154 File Offset: 0x00066354
			[CallerCount(0)]
			public unsafe SortedSet<T>.Node RotateRight()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_RotateRight_Public_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
			}

			// Token: 0x0600181C RID: 6172 RVA: 0x00068194 File Offset: 0x00066394
			[CallerCount(0)]
			public unsafe SortedSet<T>.Node RotateRightLeft()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_RotateRightLeft_Public_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
			}

			// Token: 0x0600181D RID: 6173 RVA: 0x000681D4 File Offset: 0x000663D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45344, XrefRangeEnd = 45345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Merge2Nodes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_Merge2Nodes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600181E RID: 6174 RVA: 0x00068208 File Offset: 0x00066408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45345, XrefRangeEnd = 45347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ReplaceChild(SortedSet<T>.Node child, SortedSet<T>.Node newChild)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_ReplaceChild_Public_Void_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600181F RID: 6175 RVA: 0x0000CA3E File Offset: 0x0000AC3E
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B2 RID: 1970
			// (get) Token: 0x06001820 RID: 6176 RVA: 0x0006825C File Offset: 0x0006645C
			// (set) Token: 0x06001821 RID: 6177 RVA: 0x00068284 File Offset: 0x00066484
			public unsafe T _Item_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Item_k__BackingField);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Item_k__BackingField);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x06001822 RID: 6178 RVA: 0x0006832C File Offset: 0x0006652C
			// (set) Token: 0x06001823 RID: 6179 RVA: 0x0000CA47 File Offset: 0x0000AC47
			public unsafe SortedSet<T>.Node _Left_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Left_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Left_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x06001824 RID: 6180 RVA: 0x0006835C File Offset: 0x0006655C
			// (set) Token: 0x06001825 RID: 6181 RVA: 0x0000CA66 File Offset: 0x0000AC66
			public unsafe SortedSet<T>.Node _Right_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Right_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Right_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x06001826 RID: 6182 RVA: 0x0006838C File Offset: 0x0006658C
			// (set) Token: 0x06001827 RID: 6183 RVA: 0x0000CA85 File Offset: 0x0000AC85
			public unsafe NodeColor _Color_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Color_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Color_k__BackingField)) = value;
				}
			}

			// Token: 0x0400130E RID: 4878
			private static readonly IntPtr NativeFieldInfoPtr__Item_k__BackingField;

			// Token: 0x0400130F RID: 4879
			private static readonly IntPtr NativeFieldInfoPtr__Left_k__BackingField;

			// Token: 0x04001310 RID: 4880
			private static readonly IntPtr NativeFieldInfoPtr__Right_k__BackingField;

			// Token: 0x04001311 RID: 4881
			private static readonly IntPtr NativeFieldInfoPtr__Color_k__BackingField;

			// Token: 0x04001312 RID: 4882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_NodeColor_0;

			// Token: 0x04001313 RID: 4883
			private static readonly IntPtr NativeMethodInfoPtr_IsNonNullRed_Public_Static_Boolean_Node_T_0;

			// Token: 0x04001314 RID: 4884
			private static readonly IntPtr NativeMethodInfoPtr_IsNullOrBlack_Public_Static_Boolean_Node_T_0;

			// Token: 0x04001315 RID: 4885
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_0;

			// Token: 0x04001316 RID: 4886
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_T_0;

			// Token: 0x04001317 RID: 4887
			private static readonly IntPtr NativeMethodInfoPtr_get_Left_Public_get_Node_T_0;

			// Token: 0x04001318 RID: 4888
			private static readonly IntPtr NativeMethodInfoPtr_set_Left_Public_set_Void_Node_T_0;

			// Token: 0x04001319 RID: 4889
			private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Node_T_0;

			// Token: 0x0400131A RID: 4890
			private static readonly IntPtr NativeMethodInfoPtr_set_Right_Public_set_Void_Node_T_0;

			// Token: 0x0400131B RID: 4891
			private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_NodeColor_0;

			// Token: 0x0400131C RID: 4892
			private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_NodeColor_0;

			// Token: 0x0400131D RID: 4893
			private static readonly IntPtr NativeMethodInfoPtr_get_IsBlack_Public_get_Boolean_0;

			// Token: 0x0400131E RID: 4894
			private static readonly IntPtr NativeMethodInfoPtr_get_IsRed_Public_get_Boolean_0;

			// Token: 0x0400131F RID: 4895
			private static readonly IntPtr NativeMethodInfoPtr_get_Is2Node_Public_get_Boolean_0;

			// Token: 0x04001320 RID: 4896
			private static readonly IntPtr NativeMethodInfoPtr_get_Is4Node_Public_get_Boolean_0;

			// Token: 0x04001321 RID: 4897
			private static readonly IntPtr NativeMethodInfoPtr_ColorBlack_Public_Void_0;

			// Token: 0x04001322 RID: 4898
			private static readonly IntPtr NativeMethodInfoPtr_ColorRed_Public_Void_0;

			// Token: 0x04001323 RID: 4899
			private static readonly IntPtr NativeMethodInfoPtr_GetRotation_Public_TreeRotation_Node_T_Node_T_0;

			// Token: 0x04001324 RID: 4900
			private static readonly IntPtr NativeMethodInfoPtr_GetSibling_Public_Node_T_Node_T_0;

			// Token: 0x04001325 RID: 4901
			private static readonly IntPtr NativeMethodInfoPtr_Split4Node_Public_Void_0;

			// Token: 0x04001326 RID: 4902
			private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Node_T_TreeRotation_0;

			// Token: 0x04001327 RID: 4903
			private static readonly IntPtr NativeMethodInfoPtr_RotateLeft_Public_Node_T_0;

			// Token: 0x04001328 RID: 4904
			private static readonly IntPtr NativeMethodInfoPtr_RotateLeftRight_Public_Node_T_0;

			// Token: 0x04001329 RID: 4905
			private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Public_Node_T_0;

			// Token: 0x0400132A RID: 4906
			private static readonly IntPtr NativeMethodInfoPtr_RotateRightLeft_Public_Node_T_0;

			// Token: 0x0400132B RID: 4907
			private static readonly IntPtr NativeMethodInfoPtr_Merge2Nodes_Public_Void_0;

			// Token: 0x0400132C RID: 4908
			private static readonly IntPtr NativeMethodInfoPtr_ReplaceChild_Public_Void_Node_T_Node_T_0;
		}

		// Token: 0x020001A6 RID: 422
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06001828 RID: 6184 RVA: 0x000683B4 File Offset: 0x000665B4
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr);
				SortedSet<T>.Enumerator.NativeFieldInfoPtr_s_dummyNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "s_dummyNode");
				SortedSet<T>.Enumerator.NativeFieldInfoPtr__tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "_tree");
				SortedSet<T>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "_version");
				SortedSet<T>.Enumerator.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "_stack");
				SortedSet<T>.Enumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "_current");
				SortedSet<T>.Enumerator.NativeFieldInfoPtr__reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "_reverse");
				SortedSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664881);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664882);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664883);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664884);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664885);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664886);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664887);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664888);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664889);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664890);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664891);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100664892);
			}

			// Token: 0x06001829 RID: 6185 RVA: 0x00068584 File Offset: 0x00066784
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45349, RefRangeEnd = 45350, XrefRangeStart = 45347, XrefRangeEnd = 45349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(SortedSet<T> set)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600182A RID: 6186 RVA: 0x000685D4 File Offset: 0x000667D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45365, RefRangeEnd = 45366, XrefRangeStart = 45350, XrefRangeEnd = 45365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(SortedSet<T> set, bool reverse)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600182B RID: 6187 RVA: 0x00068634 File Offset: 0x00066834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45366, XrefRangeEnd = 45371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600182C RID: 6188 RVA: 0x00068694 File Offset: 0x00066894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45371, XrefRangeEnd = 45386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600182D RID: 6189 RVA: 0x000686DC File Offset: 0x000668DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 45410, RefRangeEnd = 45412, XrefRangeStart = 45386, XrefRangeEnd = 45410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Initialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600182E RID: 6190 RVA: 0x00068714 File Offset: 0x00066914
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 45449, RefRangeEnd = 45451, XrefRangeStart = 45412, XrefRangeEnd = 45449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600182F RID: 6191 RVA: 0x00068758 File Offset: 0x00066958
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x06001830 RID: 6192 RVA: 0x00068790 File Offset: 0x00066990
			public unsafe T Current
			{
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 45451, RefRangeEnd = 45459, XrefRangeStart = 45451, XrefRangeEnd = 45451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x170007C5 RID: 1989
			// (get) Token: 0x06001831 RID: 6193 RVA: 0x000687D0 File Offset: 0x000669D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45459, XrefRangeEnd = 45465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x06001832 RID: 6194 RVA: 0x00068814 File Offset: 0x00066A14
			public unsafe bool NotStartedOrEnded
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 45465, RefRangeEnd = 45471, XrefRangeStart = 45465, XrefRangeEnd = 45465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001833 RID: 6195 RVA: 0x00068858 File Offset: 0x00066A58
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 45483, RefRangeEnd = 45486, XrefRangeStart = 45471, XrefRangeEnd = 45483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001834 RID: 6196 RVA: 0x00068890 File Offset: 0x00066A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45486, XrefRangeEnd = 45488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001835 RID: 6197 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001836 RID: 6198 RVA: 0x0000CAA9 File Offset: 0x0000ACA9
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170007BE RID: 1982
			// (get) Token: 0x06001837 RID: 6199 RVA: 0x000688C8 File Offset: 0x00066AC8
			// (set) Token: 0x06001838 RID: 6200 RVA: 0x0000CABB File Offset: 0x0000ACBB
			public unsafe static SortedSet<T>.Node s_dummyNode
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.Enumerator.NativeFieldInfoPtr_s_dummyNode, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.Enumerator.NativeFieldInfoPtr_s_dummyNode, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007BF RID: 1983
			// (get) Token: 0x06001839 RID: 6201 RVA: 0x000688F0 File Offset: 0x00066AF0
			// (set) Token: 0x0600183A RID: 6202 RVA: 0x0000CACD File Offset: 0x0000ACCD
			public unsafe SortedSet<T> _tree
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__tree);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__tree), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C0 RID: 1984
			// (get) Token: 0x0600183B RID: 6203 RVA: 0x00068920 File Offset: 0x00066B20
			// (set) Token: 0x0600183C RID: 6204 RVA: 0x0000CAEC File Offset: 0x0000ACEC
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170007C1 RID: 1985
			// (get) Token: 0x0600183D RID: 6205 RVA: 0x00068948 File Offset: 0x00066B48
			// (set) Token: 0x0600183E RID: 6206 RVA: 0x0000CB07 File Offset: 0x0000AD07
			public unsafe Stack<SortedSet<T>.Node> _stack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__stack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<SortedSet<T>.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C2 RID: 1986
			// (get) Token: 0x0600183F RID: 6207 RVA: 0x00068978 File Offset: 0x00066B78
			// (set) Token: 0x06001840 RID: 6208 RVA: 0x0000CB26 File Offset: 0x0000AD26
			public unsafe SortedSet<T>.Node _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C3 RID: 1987
			// (get) Token: 0x06001841 RID: 6209 RVA: 0x000689A8 File Offset: 0x00066BA8
			// (set) Token: 0x06001842 RID: 6210 RVA: 0x0000CB45 File Offset: 0x0000AD45
			public unsafe bool _reverse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__reverse);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__reverse)) = value;
				}
			}

			// Token: 0x0400132D RID: 4909
			private static readonly IntPtr NativeFieldInfoPtr_s_dummyNode;

			// Token: 0x0400132E RID: 4910
			private static readonly IntPtr NativeFieldInfoPtr__tree;

			// Token: 0x0400132F RID: 4911
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04001330 RID: 4912
			private static readonly IntPtr NativeFieldInfoPtr__stack;

			// Token: 0x04001331 RID: 4913
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x04001332 RID: 4914
			private static readonly IntPtr NativeFieldInfoPtr__reverse;

			// Token: 0x04001333 RID: 4915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_0;

			// Token: 0x04001334 RID: 4916
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_Boolean_0;

			// Token: 0x04001335 RID: 4917
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04001336 RID: 4918
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

			// Token: 0x04001337 RID: 4919
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

			// Token: 0x04001338 RID: 4920
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04001339 RID: 4921
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400133A RID: 4922
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x0400133B RID: 4923
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400133C RID: 4924
			private static readonly IntPtr NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0;

			// Token: 0x0400133D RID: 4925
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

			// Token: 0x0400133E RID: 4926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x020001A7 RID: 423
		[ObfuscatedName("System.Collections.Generic.SortedSet`1+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : Object
		{
			// Token: 0x06001843 RID: 6211 RVA: 0x000689D0 File Offset: 0x00066BD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "<>c__DisplayClass52_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr);
				SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr, "index");
				SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr, "count");
				SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr, "array");
				SortedSet<T>.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr, 100664894);
				SortedSet<T>.__c__DisplayClass52_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr, 100664895);
			}

			// Token: 0x06001844 RID: 6212 RVA: 0x00068A9C File Offset: 0x00066C9C
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001845 RID: 6213 RVA: 0x00068AD8 File Offset: 0x00066CD8
			[CallerCount(0)]
			public unsafe bool _CopyTo_b__0(SortedSet<T>.Node node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.__c__DisplayClass52_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001846 RID: 6214 RVA: 0x0000CB60 File Offset: 0x0000AD60
			public __c__DisplayClass52_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x06001847 RID: 6215 RVA: 0x00068B28 File Offset: 0x00066D28
			// (set) Token: 0x06001848 RID: 6216 RVA: 0x0000CB69 File Offset: 0x0000AD69
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170007C8 RID: 1992
			// (get) Token: 0x06001849 RID: 6217 RVA: 0x00068B50 File Offset: 0x00066D50
			// (set) Token: 0x0600184A RID: 6218 RVA: 0x0000CB84 File Offset: 0x0000AD84
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x0600184B RID: 6219 RVA: 0x00068B78 File Offset: 0x00066D78
			// (set) Token: 0x0600184C RID: 6220 RVA: 0x0000CB9F File Offset: 0x0000AD9F
			public unsafe Il2CppArrayBase<T> array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_array);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400133F RID: 4927
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04001340 RID: 4928
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04001341 RID: 4929
			private static readonly IntPtr NativeFieldInfoPtr_array;

			// Token: 0x04001342 RID: 4930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001343 RID: 4931
			private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_T_0;
		}

		// Token: 0x020001A8 RID: 424
		[ObfuscatedName("System.Collections.Generic.SortedSet`1+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Object
		{
			// Token: 0x0600184D RID: 6221 RVA: 0x00068BA0 File Offset: 0x00066DA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "<>c__DisplayClass53_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr);
				SortedSet<T>.__c__DisplayClass53_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr, "index");
				SortedSet<T>.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr, 100664896);
			}

			// Token: 0x0600184E RID: 6222 RVA: 0x00068C30 File Offset: 0x00066E30
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600184F RID: 6223 RVA: 0x0000CBBE File Offset: 0x0000ADBE
			public __c__DisplayClass53_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007CA RID: 1994
			// (get) Token: 0x06001850 RID: 6224 RVA: 0x00068C6C File Offset: 0x00066E6C
			// (set) Token: 0x06001851 RID: 6225 RVA: 0x0000CBC7 File Offset: 0x0000ADC7
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass53_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass53_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x04001344 RID: 4932
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04001345 RID: 4933
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A9 RID: 425
		[ObfuscatedName("System.Collections.Generic.SortedSet`1+<>c__DisplayClass53_1")]
		public sealed class __c__DisplayClass53_1 : Object
		{
			// Token: 0x06001852 RID: 6226 RVA: 0x00068C94 File Offset: 0x00066E94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_1()
			{
				Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "<>c__DisplayClass53_1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_1>.NativeClassPtr);
				SortedSet<T>.__c__DisplayClass53_1.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_1>.NativeClassPtr, "objects");
				SortedSet<T>.__c__DisplayClass53_1.NativeFieldInfoPtr_field_Public___c__DisplayClass53_0_T_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_1>.NativeClassPtr, "CS$<>8__locals1");
				SortedSet<T>.__c__DisplayClass53_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_1>.NativeClassPtr, 100664897);
				SortedSet<T>.__c__DisplayClass53_1.NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_1>.NativeClassPtr, 100664898);
			}

			// Token: 0x06001853 RID: 6227 RVA: 0x00068D4C File Offset: 0x00066F4C
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.__c__DisplayClass53_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001854 RID: 6228 RVA: 0x00068D88 File Offset: 0x00066F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45488, XrefRangeEnd = 45491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _System_Collections_ICollection_CopyTo_b__0(SortedSet<T>.Node node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.__c__DisplayClass53_1.NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001855 RID: 6229 RVA: 0x0000CBE2 File Offset: 0x0000ADE2
			public __c__DisplayClass53_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007CB RID: 1995
			// (get) Token: 0x06001856 RID: 6230 RVA: 0x00068DD8 File Offset: 0x00066FD8
			// (set) Token: 0x06001857 RID: 6231 RVA: 0x0000CBEB File Offset: 0x0000ADEB
			public unsafe Il2CppReferenceArray<Object> objects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass53_1.NativeFieldInfoPtr_objects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass53_1.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CC RID: 1996
			// (get) Token: 0x06001858 RID: 6232 RVA: 0x00068E08 File Offset: 0x00067008
			// (set) Token: 0x06001859 RID: 6233 RVA: 0x0000CC0A File Offset: 0x0000AE0A
			public unsafe SortedSet<T>.__c__DisplayClass53_0 field_Public___c__DisplayClass53_0_T_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass53_1.NativeFieldInfoPtr_field_Public___c__DisplayClass53_0_T_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.__c__DisplayClass53_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass53_1.NativeFieldInfoPtr_field_Public___c__DisplayClass53_0_T_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001346 RID: 4934
			private static readonly IntPtr NativeFieldInfoPtr_objects;

			// Token: 0x04001347 RID: 4935
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass53_0_T_0;

			// Token: 0x04001348 RID: 4936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001349 RID: 4937
			private static readonly IntPtr NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_T_0;
		}
	}
}
