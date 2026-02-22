using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class HashSet<T> : Object
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00005F18 File Offset: 0x00004118
		// Note: this type is marked as 'beforefieldinit'.
		static HashSet()
		{
			Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Collections.Generic", "HashSet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr);
			HashSet<T>.NativeFieldInfoPtr_Lower31BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "Lower31BitMask");
			HashSet<T>.NativeFieldInfoPtr_StackAllocThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "StackAllocThreshold");
			HashSet<T>.NativeFieldInfoPtr_ShrinkThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "ShrinkThreshold");
			HashSet<T>.NativeFieldInfoPtr_CapacityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "CapacityName");
			HashSet<T>.NativeFieldInfoPtr_ElementsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "ElementsName");
			HashSet<T>.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "ComparerName");
			HashSet<T>.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "VersionName");
			HashSet<T>.NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_buckets");
			HashSet<T>.NativeFieldInfoPtr__slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_slots");
			HashSet<T>.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_count");
			HashSet<T>.NativeFieldInfoPtr__lastIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_lastIndex");
			HashSet<T>.NativeFieldInfoPtr__freeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_freeList");
			HashSet<T>.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_comparer");
			HashSet<T>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_version");
			HashSet<T>.NativeFieldInfoPtr__siInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_siInfo");
			HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663487);
			HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663488);
			HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663489);
			HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663490);
			HashSet<T>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663491);
			HashSet<T>.NativeMethodInfoPtr_CopyFrom_Private_Void_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663492);
			HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663493);
			HashSet<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663494);
			HashSet<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663495);
			HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663496);
			HashSet<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663497);
			HashSet<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663498);
			HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663499);
			HashSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663500);
			HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663501);
			HashSet<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663502);
			HashSet<T>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663503);
			HashSet<T>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663504);
			HashSet<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663505);
			HashSet<T>.NativeMethodInfoPtr_UnionWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663506);
			HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663507);
			HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663508);
			HashSet<T>.NativeMethodInfoPtr_get_Comparer_Public_get_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663509);
			HashSet<T>.NativeMethodInfoPtr_TrimExcess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663510);
			HashSet<T>.NativeMethodInfoPtr_Initialize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663511);
			HashSet<T>.NativeMethodInfoPtr_IncreaseCapacity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663512);
			HashSet<T>.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663513);
			HashSet<T>.NativeMethodInfoPtr_AddIfNotPresent_Private_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663514);
			HashSet<T>.NativeMethodInfoPtr_AddValue_Private_Void_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663515);
			HashSet<T>.NativeMethodInfoPtr_AreEqualityComparersEqual_Private_Static_Boolean_HashSet_1_T_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663516);
			HashSet<T>.NativeMethodInfoPtr_InternalGetHashCode_Private_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100663517);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000631C File Offset: 0x0000451C
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 58590, RefRangeEnd = 58633, XrefRangeStart = 58589, XrefRangeEnd = 58590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006358 File Offset: 0x00004558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58633, XrefRangeEnd = 58634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet(IEqualityComparer<T> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000063A4 File Offset: 0x000045A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58637, RefRangeEnd = 58638, XrefRangeStart = 58634, XrefRangeEnd = 58637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet(IEnumerable<T> collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000063F0 File Offset: 0x000045F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58638, XrefRangeEnd = 58640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00006450 File Offset: 0x00004650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58640, XrefRangeEnd = 58641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000064B4 File Offset: 0x000046B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58641, XrefRangeEnd = 58654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(HashSet<T> source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_CopyFrom_Private_Void_HashSet_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000064F8 File Offset: 0x000046F8
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 58655, RefRangeEnd = 58708, XrefRangeStart = 58654, XrefRangeEnd = 58655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006570 File Offset: 0x00004770
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 58710, RefRangeEnd = 58731, XrefRangeStart = 58708, XrefRangeEnd = 58710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000065A4 File Offset: 0x000047A4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 58733, RefRangeEnd = 58751, XrefRangeStart = 58731, XrefRangeEnd = 58733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006628 File Offset: 0x00004828
		[CallerCount(0)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006678 File Offset: 0x00004878
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 58753, RefRangeEnd = 58756, XrefRangeStart = 58751, XrefRangeEnd = 58753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000066FC File Offset: 0x000048FC
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00006738 File Offset: 0x00004938
		public unsafe virtual bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006774 File Offset: 0x00004974
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 58757, RefRangeEnd = 58769, XrefRangeStart = 58756, XrefRangeEnd = 58757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new HashSet<T>.Enumerator(intPtr);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000067AC File Offset: 0x000049AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58769, XrefRangeEnd = 58772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000067EC File Offset: 0x000049EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000682C File Offset: 0x00004A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58772, XrefRangeEnd = 58794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashSet<T>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006890 File Offset: 0x00004A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58794, XrefRangeEnd = 58812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashSet<T>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000068E0 File Offset: 0x00004AE0
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 58655, RefRangeEnd = 58708, XrefRangeStart = 58655, XrefRangeEnd = 58708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00006964 File Offset: 0x00004B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58812, XrefRangeEnd = 58825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnionWith(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_UnionWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000069A8 File Offset: 0x00004BA8
		[CallerCount(0)]
		public unsafe void CopyTo(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000069EC File Offset: 0x00004BEC
		[CallerCount(0)]
		public unsafe void CopyTo(Il2CppArrayBase<T> array, int arrayIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00006A4C File Offset: 0x00004C4C
		public unsafe IEqualityComparer<T> Comparer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_get_Comparer_Public_get_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00006A8C File Offset: 0x00004C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58825, XrefRangeEnd = 58834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrimExcess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_TrimExcess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006AC0 File Offset: 0x00004CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58834, XrefRangeEnd = 58843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Initialize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006B00 File Offset: 0x00004D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58843, XrefRangeEnd = 58853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_IncreaseCapacity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006B34 File Offset: 0x00004D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58853, XrefRangeEnd = 58859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapacity(int newSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006B74 File Offset: 0x00004D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58859, XrefRangeEnd = 58862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddIfNotPresent(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_AddIfNotPresent_Private_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006BF8 File Offset: 0x00004DF8
		[CallerCount(0)]
		public unsafe void AddValue(int index, int hashCode, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_AddValue_Private_Void_Int32_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00006C8C File Offset: 0x00004E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58862, XrefRangeEnd = 58869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(set1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(set2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_AreEqualityComparersEqual_Private_Static_Boolean_HashSet_1_T_HashSet_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006CE0 File Offset: 0x00004EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58869, XrefRangeEnd = 58871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalGetHashCode(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_InternalGetHashCode_Private_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000023CD File Offset: 0x000005CD
		public HashSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00006D64 File Offset: 0x00004F64
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000023D6 File Offset: 0x000005D6
		public unsafe static int Lower31BitMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_Lower31BitMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_Lower31BitMask, (void*)(&value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00006D80 File Offset: 0x00004F80
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000023E4 File Offset: 0x000005E4
		public unsafe static int StackAllocThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_StackAllocThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_StackAllocThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00006D9C File Offset: 0x00004F9C
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000023F2 File Offset: 0x000005F2
		public unsafe static int ShrinkThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_ShrinkThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_ShrinkThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00006DB8 File Offset: 0x00004FB8
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002400 File Offset: 0x00000600
		public unsafe static string CapacityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_CapacityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_CapacityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00006DD8 File Offset: 0x00004FD8
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002412 File Offset: 0x00000612
		public unsafe static string ElementsName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_ElementsName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_ElementsName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00006DF8 File Offset: 0x00004FF8
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002424 File Offset: 0x00000624
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00006E18 File Offset: 0x00005018
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002436 File Offset: 0x00000636
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00006E38 File Offset: 0x00005038
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002448 File Offset: 0x00000648
		public unsafe Il2CppStructArray<int> _buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00006E68 File Offset: 0x00005068
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002467 File Offset: 0x00000667
		public unsafe Il2CppReferenceArray<HashSet<T>.Slot> _slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HashSet<T>.Slot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00006E98 File Offset: 0x00005098
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002486 File Offset: 0x00000686
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00006EC0 File Offset: 0x000050C0
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000024A1 File Offset: 0x000006A1
		public unsafe int _lastIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__lastIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__lastIndex)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00006EE8 File Offset: 0x000050E8
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000024BC File Offset: 0x000006BC
		public unsafe int _freeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__freeList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__freeList)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00006F10 File Offset: 0x00005110
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000024D7 File Offset: 0x000006D7
		public unsafe IEqualityComparer<T> _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00006F40 File Offset: 0x00005140
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000024F6 File Offset: 0x000006F6
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00006F68 File Offset: 0x00005168
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002511 File Offset: 0x00000711
		public unsafe SerializationInfo _siInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__siInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__siInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_Lower31BitMask;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_StackAllocThreshold;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_ShrinkThreshold;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_CapacityName;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_ElementsName;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr__buckets;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr__slots;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr__lastIndex;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr__freeList;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr__siInfo;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_T_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_IEqualityComparer_1_T_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Private_Void_HashSet_1_T_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_UnionWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_get_Comparer_Public_get_IEqualityComparer_1_T_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_TrimExcess_Public_Void_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Int32_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacity_Private_Void_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_AddIfNotPresent_Private_Boolean_T_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Private_Void_Int32_Int32_T_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_AreEqualityComparersEqual_Private_Static_Boolean_HashSet_1_T_HashSet_1_T_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Private_Int32_T_0;

		// Token: 0x02000042 RID: 66
		public sealed class Slot : ValueType
		{
			// Token: 0x0600022E RID: 558 RVA: 0x0000BA7C File Offset: 0x00009C7C
			// Note: this type is marked as 'beforefieldinit'.
			static Slot()
			{
				Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "Slot"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr);
				HashSet<T>.Slot.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr, "hashCode");
				HashSet<T>.Slot.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr, "next");
				HashSet<T>.Slot.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr, "value");
			}

			// Token: 0x0600022F RID: 559 RVA: 0x00002D4B File Offset: 0x00000F4B
			public Slot(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000230 RID: 560 RVA: 0x00002D54 File Offset: 0x00000F54
			public Slot()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr))
			{
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000231 RID: 561 RVA: 0x0000BB20 File Offset: 0x00009D20
			// (set) Token: 0x06000232 RID: 562 RVA: 0x00002D66 File Offset: 0x00000F66
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x06000233 RID: 563 RVA: 0x0000BB48 File Offset: 0x00009D48
			// (set) Token: 0x06000234 RID: 564 RVA: 0x00002D81 File Offset: 0x00000F81
			public unsafe int next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_next);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_next)) = value;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x06000235 RID: 565 RVA: 0x0000BB70 File Offset: 0x00009D70
			// (set) Token: 0x06000236 RID: 566 RVA: 0x0000BB98 File Offset: 0x00009D98
			public unsafe T value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_value);
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

			// Token: 0x04000174 RID: 372
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04000175 RID: 373
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04000176 RID: 374
			private static readonly IntPtr NativeFieldInfoPtr_value;
		}

		// Token: 0x02000043 RID: 67
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06000237 RID: 567 RVA: 0x0000BC40 File Offset: 0x00009E40
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr);
				HashSet<T>.Enumerator.NativeFieldInfoPtr__set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, "_set");
				HashSet<T>.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, "_index");
				HashSet<T>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, "_version");
				HashSet<T>.Enumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, "_current");
				HashSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100663518);
				HashSet<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100663519);
				HashSet<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100663520);
				HashSet<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100663521);
				HashSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100663522);
				HashSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100663523);
			}

			// Token: 0x06000238 RID: 568 RVA: 0x0000BD70 File Offset: 0x00009F70
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58570, RefRangeEnd = 58572, XrefRangeStart = 58570, XrefRangeEnd = 58570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(HashSet<T> set)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_HashSet_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000239 RID: 569 RVA: 0x0000BDC0 File Offset: 0x00009FC0
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600023A RID: 570 RVA: 0x0000BDF8 File Offset: 0x00009FF8
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 58573, RefRangeEnd = 58585, XrefRangeStart = 58572, XrefRangeEnd = 58573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x0600023B RID: 571 RVA: 0x0000BE3C File Offset: 0x0000A03C
			public unsafe T Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x0600023C RID: 572 RVA: 0x0000BE7C File Offset: 0x0000A07C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58585, XrefRangeEnd = 58589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600023D RID: 573 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00002D9C File Offset: 0x00000F9C
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600023F RID: 575 RVA: 0x00002DA5 File Offset: 0x00000FA5
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x06000240 RID: 576 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
			// (set) Token: 0x06000241 RID: 577 RVA: 0x00002DB7 File Offset: 0x00000FB7
			public unsafe HashSet<T> _set
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__set);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__set), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000242 RID: 578 RVA: 0x0000BF28 File Offset: 0x0000A128
			// (set) Token: 0x06000243 RID: 579 RVA: 0x00002DD6 File Offset: 0x00000FD6
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000244 RID: 580 RVA: 0x0000BF50 File Offset: 0x0000A150
			// (set) Token: 0x06000245 RID: 581 RVA: 0x00002DF1 File Offset: 0x00000FF1
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000246 RID: 582 RVA: 0x0000BF78 File Offset: 0x0000A178
			// (set) Token: 0x06000247 RID: 583 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
			public unsafe T _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__current);
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

			// Token: 0x04000177 RID: 375
			private static readonly IntPtr NativeFieldInfoPtr__set;

			// Token: 0x04000178 RID: 376
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04000179 RID: 377
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x0400017A RID: 378
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x0400017B RID: 379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HashSet_1_T_0;

			// Token: 0x0400017C RID: 380
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400017D RID: 381
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x0400017E RID: 382
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x0400017F RID: 383
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000180 RID: 384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
