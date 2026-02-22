using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000055 RID: 85
	public class Array : Object
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x0003840C File Offset: 0x0003660C
		// Note: this type is marked as 'beforefieldinit'.
		static Array()
		{
			Il2CppClassPointerStore<Array>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Array");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array>.NativeClassPtr);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664068);
			Array.NativeMethodInfoPtr_AsReadOnly_Public_Static_ReadOnlyCollection_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664069);
			Array.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664070);
			Array.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664071);
			Array.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664072);
			Array.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664073);
			Array.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664074);
			Array.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664075);
			Array.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664076);
			Array.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664077);
			Array.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664078);
			Array.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664079);
			Array.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664080);
			Array.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664081);
			Array.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664082);
			Array.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664083);
			Array.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664084);
			Array.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664085);
			Array.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664086);
			Array.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664087);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664088);
			Array.NativeMethodInfoPtr_ConvertAll_Public_Static_Il2CppArrayBase_1_TOutput_Il2CppArrayBase_1_TInput_Converter_2_TInput_TOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664089);
			Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664090);
			Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int64_Array_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664091);
			Array.NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664092);
			Array.NativeMethodInfoPtr_ForEach_Public_Static_Void_Il2CppArrayBase_1_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664093);
			Array.NativeMethodInfoPtr_get_LongLength_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664094);
			Array.NativeMethodInfoPtr_GetLongLength_Public_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664095);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664096);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664097);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664098);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664099);
			Array.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664100);
			Array.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664101);
			Array.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664102);
			Array.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664103);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664104);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664105);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664106);
			Array.NativeMethodInfoPtr_GetMedian_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664107);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664108);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664109);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664110);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664111);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664112);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664113);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664114);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664115);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664116);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664117);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664118);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664119);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664120);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664121);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664122);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664123);
			Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664124);
			Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664125);
			Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664126);
			Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664127);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664128);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664129);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664130);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664131);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664132);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664133);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664134);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664135);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664136);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664137);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664138);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664139);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664140);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664141);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664142);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664143);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664144);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664145);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664146);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664147);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664148);
			Array.NativeMethodInfoPtr_Exists_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664149);
			Array.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664150);
			Array.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664151);
			Array.NativeMethodInfoPtr_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664152);
			Array.NativeMethodInfoPtr_FindAll_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664153);
			Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664154);
			Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664155);
			Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664156);
			Array.NativeMethodInfoPtr_FindLast_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664157);
			Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664158);
			Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664159);
			Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664160);
			Array.NativeMethodInfoPtr_TrueForAll_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664161);
			Array.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664162);
			Array.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664163);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_get_Count_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664164);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_get_IsReadOnly_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664165);
			Array.NativeMethodInfoPtr_InternalArray__IEnumerable_GetEnumerator_Internal_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664166);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664167);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_Add_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664168);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_Remove_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664169);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_Contains_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664170);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_CopyTo_Internal_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664171);
			Array.NativeMethodInfoPtr_InternalArray__IReadOnlyList_get_Item_Internal_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664172);
			Array.NativeMethodInfoPtr_InternalArray__IReadOnlyCollection_get_Count_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664173);
			Array.NativeMethodInfoPtr_InternalArray__Insert_Internal_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664174);
			Array.NativeMethodInfoPtr_InternalArray__RemoveAt_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664175);
			Array.NativeMethodInfoPtr_InternalArray__IndexOf_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664176);
			Array.NativeMethodInfoPtr_InternalArray__get_Item_Internal_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664177);
			Array.NativeMethodInfoPtr_InternalArray__set_Item_Internal_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664178);
			Array.NativeMethodInfoPtr_GetGenericValueImpl_Internal_Void_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664179);
			Array.NativeMethodInfoPtr_SetGenericValueImpl_Internal_Void_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664180);
			Array.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664181);
			Array.NativeMethodInfoPtr_get_Rank_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664182);
			Array.NativeMethodInfoPtr_GetRank_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664183);
			Array.NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664184);
			Array.NativeMethodInfoPtr_GetLowerBound_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664185);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664186);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664187);
			Array.NativeMethodInfoPtr_GetValueImpl_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664188);
			Array.NativeMethodInfoPtr_SetValueImpl_Internal_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664189);
			Array.NativeMethodInfoPtr_FastCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664190);
			Array.NativeMethodInfoPtr_CreateInstanceImpl_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664191);
			Array.NativeMethodInfoPtr_GetUpperBound_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664192);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664193);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664194);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664195);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664196);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664197);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664198);
			Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664199);
			Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664200);
			Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664201);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664202);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664203);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664204);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664205);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664206);
			Array.NativeMethodInfoPtr_Clear_Public_Static_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664207);
			Array.NativeMethodInfoPtr_ClearInternal_Private_Static_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664208);
			Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664209);
			Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664210);
			Array.NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664211);
			Array.NativeMethodInfoPtr_CanAssignArrayElement_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664212);
			Array.NativeMethodInfoPtr_ConstrainedCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664213);
			Array.NativeMethodInfoPtr_Empty_Public_Static_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664214);
			Array.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664215);
			Array.NativeMethodInfoPtr_IndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664216);
			Array.NativeMethodInfoPtr_LastIndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664217);
			Array.NativeMethodInfoPtr_SortImpl_Private_Static_Void_Array_Array_Int32_Int32_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664218);
			Array.NativeMethodInfoPtr_UnsafeLoad_Internal_Static_T_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664219);
			Array.NativeMethodInfoPtr_UnsafeStore_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664220);
			Array.NativeMethodInfoPtr_UnsafeMov_Internal_Static_R_S_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100664221);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00039044 File Offset: 0x00037244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268809, XrefRangeEnd = 268838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, [Optional] Il2CppStructArray<long> lengths)
		{
			if (lengths == null)
			{
				lengths = new Il2CppStructArray<long>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000390A8 File Offset: 0x000372A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268840, RefRangeEnd = 268841, XrefRangeStart = 268838, XrefRangeEnd = 268840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<T> AsReadOnly<T>(Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_AsReadOnly_Public_Static_ReadOnlyCollection_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000390EC File Offset: 0x000372EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 268844, RefRangeEnd = 268850, XrefRangeStart = 268841, XrefRangeEnd = 268844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resize<T>(ref Il2CppArrayBase<T> array, int newSize)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00039148 File Offset: 0x00037348
		public unsafe virtual int System.Collections.ICollection.Count
		{
			[CallerCount(75)]
			[CachedScanResults(RefRangeStart = 268854, RefRangeEnd = 268929, XrefRangeStart = 268850, XrefRangeEnd = 268854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00039184 File Offset: 0x00037384
		public unsafe virtual bool System.Collections.IList.IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x000391C0 File Offset: 0x000373C0
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0003920C File Offset: 0x0003740C
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268929, XrefRangeEnd = 268930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268930, XrefRangeEnd = 268931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0003925C File Offset: 0x0003745C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268931, XrefRangeEnd = 268937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000392AC File Offset: 0x000374AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268937, XrefRangeEnd = 268943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000392FC File Offset: 0x000374FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268943, XrefRangeEnd = 268949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00039330 File Offset: 0x00037530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268949, XrefRangeEnd = 268955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00039380 File Offset: 0x00037580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268955, XrefRangeEnd = 268961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000393D0 File Offset: 0x000375D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268961, XrefRangeEnd = 268967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00039414 File Offset: 0x00037614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268967, XrefRangeEnd = 268973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00039454 File Offset: 0x00037654
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 268980, RefRangeEnd = 269003, XrefRangeStart = 268973, XrefRangeEnd = 268980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000394A4 File Offset: 0x000376A4
		[CallerCount(92)]
		[CachedScanResults(RefRangeStart = 267191, RefRangeEnd = 267283, XrefRangeStart = 267191, XrefRangeEnd = 267283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000394E4 File Offset: 0x000376E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269003, XrefRangeEnd = 269018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IStructuralComparable_CompareTo(Object other, IComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00039544 File Offset: 0x00037744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269018, XrefRangeEnd = 269034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IStructuralEquatable_Equals(Object other, IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000395A4 File Offset: 0x000377A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269034, RefRangeEnd = 269035, XrefRangeStart = 269034, XrefRangeEnd = 269034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000395F0 File Offset: 0x000377F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269035, XrefRangeEnd = 269051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IStructuralEquatable_GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00039640 File Offset: 0x00037840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269051, XrefRangeEnd = 269057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch(Array array, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00039694 File Offset: 0x00037894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269057, XrefRangeEnd = 269060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<TOutput> ConvertAll<TInput, TOutput>(Il2CppArrayBase<TInput> array, Converter<TInput, TOutput> converter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_ConvertAll_Public_Static_Il2CppArrayBase_1_TOutput_Il2CppArrayBase_1_TInput_Converter_2_TInput_TOutput_0<TInput, TOutput>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<TOutput>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000396E4 File Offset: 0x000378E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269060, XrefRangeEnd = 269063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Array sourceArray, Array destinationArray, long length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationArray);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0003973C File Offset: 0x0003793C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269063, XrefRangeEnd = 269085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationArray);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int64_Array_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000397B0 File Offset: 0x000379B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269085, XrefRangeEnd = 269093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Array array, long index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00039800 File Offset: 0x00037A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269093, XrefRangeEnd = 269094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForEach<T>(Il2CppArrayBase<T> array, Action<T> action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_ForEach_Public_Static_Void_Il2CppArrayBase_1_T_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00039848 File Offset: 0x00037A48
		public unsafe long LongLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269094, XrefRangeEnd = 269098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_LongLength_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00039884 File Offset: 0x00037A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269098, XrefRangeEnd = 269099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetLongLength(int dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimension;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetLongLength_Public_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000398D0 File Offset: 0x00037AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269099, XrefRangeEnd = 269107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(long index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0003991C File Offset: 0x00037B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269107, XrefRangeEnd = 269130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(long index1, long index2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00039978 File Offset: 0x00037B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269130, XrefRangeEnd = 269162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(long index1, long index2, long index3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000399E0 File Offset: 0x00037BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269162, XrefRangeEnd = 269192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue([Optional] Il2CppStructArray<long> indices)
		{
			if (indices == null)
			{
				indices = new Il2CppStructArray<long>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00039A40 File Offset: 0x00037C40
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00039A7C File Offset: 0x00037C7C
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00039AB8 File Offset: 0x00037CB8
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00039AF4 File Offset: 0x00037CF4
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(734)]
			[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00039B34 File Offset: 0x00037D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269192, XrefRangeEnd = 269193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch(Array array, int index, int length, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00039BA4 File Offset: 0x00037DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269199, RefRangeEnd = 269200, XrefRangeStart = 269193, XrefRangeEnd = 269199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch(Array array, Object value, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00039C0C File Offset: 0x00037E0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 269219, RefRangeEnd = 269226, XrefRangeStart = 269200, XrefRangeEnd = 269219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch(Array array, int index, int length, Object value, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00039C90 File Offset: 0x00037E90
		[CallerCount(0)]
		public unsafe static int GetMedian(int low, int hi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref low;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetMedian_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00039CDC File Offset: 0x00037EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269226, RefRangeEnd = 269227, XrefRangeStart = 269226, XrefRangeEnd = 269226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch<T>(Il2CppArrayBase<T> array, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00039D68 File Offset: 0x00037F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269227, RefRangeEnd = 269228, XrefRangeStart = 269227, XrefRangeEnd = 269227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch<T>(Il2CppArrayBase<T> array, T value, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00039E04 File Offset: 0x00038004
		[CallerCount(0)]
		public unsafe static int BinarySearch<T>(Il2CppArrayBase<T> array, int index, int length, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00039EAC File Offset: 0x000380AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269228, XrefRangeEnd = 269266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch<T>(Il2CppArrayBase<T> array, int index, int length, T value, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00039F64 File Offset: 0x00038164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Array array, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00039FB8 File Offset: 0x000381B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269266, XrefRangeEnd = 269272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Array array, Object value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0003A01C File Offset: 0x0003821C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 269280, RefRangeEnd = 269285, XrefRangeStart = 269272, XrefRangeEnd = 269280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Array array, Object value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0003A08C File Offset: 0x0003828C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 269285, RefRangeEnd = 269291, XrefRangeStart = 269285, XrefRangeEnd = 269285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf<T>(Il2CppArrayBase<T> array, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0003A118 File Offset: 0x00038318
		[CallerCount(0)]
		public unsafe static int IndexOf<T>(Il2CppArrayBase<T> array, T value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0003A1B0 File Offset: 0x000383B0
		[CallerCount(0)]
		public unsafe static int IndexOf<T>(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0003A258 File Offset: 0x00038458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269291, XrefRangeEnd = 269300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf(Array array, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0003A2AC File Offset: 0x000384AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269300, XrefRangeEnd = 269301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf(Array array, Object value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0003A310 File Offset: 0x00038510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269311, RefRangeEnd = 269313, XrefRangeStart = 269301, XrefRangeEnd = 269311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf(Array array, Object value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0003A380 File Offset: 0x00038580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269313, RefRangeEnd = 269314, XrefRangeStart = 269313, XrefRangeEnd = 269313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf<T>(Il2CppArrayBase<T> array, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0003A40C File Offset: 0x0003860C
		[CallerCount(0)]
		public unsafe static int LastIndexOf<T>(Il2CppArrayBase<T> array, T value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0003A4A4 File Offset: 0x000386A4
		[CallerCount(0)]
		public unsafe static int LastIndexOf<T>(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0003A54C File Offset: 0x0003874C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269314, XrefRangeEnd = 269326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reverse(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0003A584 File Offset: 0x00038784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269336, RefRangeEnd = 269338, XrefRangeStart = 269326, XrefRangeEnd = 269336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reverse(Array array, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0003A5D8 File Offset: 0x000387D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269344, RefRangeEnd = 269347, XrefRangeStart = 269338, XrefRangeEnd = 269344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reverse<T>(Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0003A610 File Offset: 0x00038810
		[CallerCount(0)]
		public unsafe static void Reverse<T>(Il2CppArrayBase<T> array, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0003A664 File Offset: 0x00038864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269347, XrefRangeEnd = 269355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, long index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0003A6B4 File Offset: 0x000388B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269355, XrefRangeEnd = 269378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, long index1, long index2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0003A714 File Offset: 0x00038914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269378, XrefRangeEnd = 269410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, long index1, long index2, long index3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0003A780 File Offset: 0x00038980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269410, XrefRangeEnd = 269440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, [Optional] Il2CppStructArray<long> indices)
		{
			if (indices == null)
			{
				indices = new Il2CppStructArray<long>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0003A7E4 File Offset: 0x000389E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269440, XrefRangeEnd = 269446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0003A81C File Offset: 0x00038A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269446, XrefRangeEnd = 269447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array array, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0003A870 File Offset: 0x00038A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269447, XrefRangeEnd = 269453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array array, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0003A8B8 File Offset: 0x00038AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269453, XrefRangeEnd = 269454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array array, int index, int length, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0003A91C File Offset: 0x00038B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269460, RefRangeEnd = 269461, XrefRangeStart = 269454, XrefRangeEnd = 269460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array keys, Array items)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0003A964 File Offset: 0x00038B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269461, XrefRangeEnd = 269467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array keys, Array items, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0003A9C0 File Offset: 0x00038BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269467, XrefRangeEnd = 269468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array keys, Array items, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0003AA24 File Offset: 0x00038C24
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 269481, RefRangeEnd = 269488, XrefRangeStart = 269468, XrefRangeEnd = 269481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array keys, Array items, int index, int length, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0003AA9C File Offset: 0x00038C9C
		[CallerCount(0)]
		public unsafe static void Sort<T>(Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0003AAD4 File Offset: 0x00038CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269488, RefRangeEnd = 269489, XrefRangeStart = 269488, XrefRangeEnd = 269488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<T>(Il2CppArrayBase<T> array, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0003AB28 File Offset: 0x00038D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269489, RefRangeEnd = 269490, XrefRangeStart = 269489, XrefRangeEnd = 269489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<T>(Il2CppArrayBase<T> array, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0003AB70 File Offset: 0x00038D70
		[CallerCount(0)]
		public unsafe static void Sort<T>(Il2CppArrayBase<T> array, int index, int length, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0003ABD4 File Offset: 0x00038DD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269490, RefRangeEnd = 269492, XrefRangeStart = 269490, XrefRangeEnd = 269490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<T>(Il2CppArrayBase<T> array, Comparison<T> comparison)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparison);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0003AC1C File Offset: 0x00038E1C
		[CallerCount(0)]
		public unsafe static void Sort<TKey, TValue>(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> items)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0003AC64 File Offset: 0x00038E64
		[CallerCount(0)]
		public unsafe static void Sort<TKey, TValue>(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> items, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0003ACC8 File Offset: 0x00038EC8
		[CallerCount(0)]
		public unsafe static void Sort<TKey, TValue>(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> items, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0003AD24 File Offset: 0x00038F24
		[CallerCount(0)]
		public unsafe static void Sort<TKey, TValue>(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> items, int index, int length, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0003AD9C File Offset: 0x00038F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269492, RefRangeEnd = 269493, XrefRangeStart = 269492, XrefRangeEnd = 269492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Exists_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0003ADF0 File Offset: 0x00038FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269493, XrefRangeEnd = 269494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fill<T>(Il2CppArrayBase<T> array, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0003AE70 File Offset: 0x00039070
		[CallerCount(0)]
		public unsafe static void Fill<T>(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0003AF0C File Offset: 0x0003910C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269494, XrefRangeEnd = 269495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Find<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0003AF5C File Offset: 0x0003915C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269500, RefRangeEnd = 269502, XrefRangeStart = 269495, XrefRangeEnd = 269500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FindAll<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindAll_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0003AFAC File Offset: 0x000391AC
		[CallerCount(0)]
		public unsafe static int FindIndex<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0003B000 File Offset: 0x00039200
		[CallerCount(0)]
		public unsafe static int FindIndex<T>(Il2CppArrayBase<T> array, int startIndex, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0003B064 File Offset: 0x00039264
		[CallerCount(0)]
		public unsafe static int FindIndex<T>(Il2CppArrayBase<T> array, int startIndex, int count, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0003B0D4 File Offset: 0x000392D4
		[CallerCount(0)]
		public unsafe static T FindLast<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindLast_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0003B124 File Offset: 0x00039324
		[CallerCount(0)]
		public unsafe static int FindLastIndex<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0003B178 File Offset: 0x00039378
		[CallerCount(0)]
		public unsafe static int FindLastIndex<T>(Il2CppArrayBase<T> array, int startIndex, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0003B1DC File Offset: 0x000393DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269502, XrefRangeEnd = 269503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindLastIndex<T>(Il2CppArrayBase<T> array, int startIndex, int count, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0003B24C File Offset: 0x0003944C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269503, XrefRangeEnd = 269504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrueForAll<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_TrueForAll_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0003B2A0 File Offset: 0x000394A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 269508, RefRangeEnd = 269513, XrefRangeStart = 269504, XrefRangeEnd = 269508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0003B2E0 File Offset: 0x000394E0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0003B31C File Offset: 0x0003951C
		[CallerCount(75)]
		[CachedScanResults(RefRangeStart = 268854, RefRangeEnd = 268929, XrefRangeStart = 268854, XrefRangeEnd = 268929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalArray__ICollection_get_Count()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_InternalArray__ICollection_get_Count_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0003B358 File Offset: 0x00039558
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalArray__ICollection_get_IsReadOnly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_InternalArray__ICollection_get_IsReadOnly_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0003B394 File Offset: 0x00039594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269513, XrefRangeEnd = 269517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__IEnumerable_GetEnumerator_Internal_IEnumerator_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0003B3D4 File Offset: 0x000395D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269517, XrefRangeEnd = 269523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__ICollection_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_InternalArray__ICollection_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0003B408 File Offset: 0x00039608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269523, XrefRangeEnd = 270953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__ICollection_Add<T>(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__ICollection_Add_Internal_Void_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0003B480 File Offset: 0x00039680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270953, XrefRangeEnd = 272375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalArray__ICollection_Remove<T>(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__ICollection_Remove_Internal_Boolean_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0003B504 File Offset: 0x00039704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272375, XrefRangeEnd = 272381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalArray__ICollection_Contains<T>(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__ICollection_Contains_Internal_Boolean_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0003B588 File Offset: 0x00039788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272381, XrefRangeEnd = 272384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__ICollection_CopyTo<T>(Il2CppArrayBase<T> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__ICollection_CopyTo_Internal_Void_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0003B5D8 File Offset: 0x000397D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272384, XrefRangeEnd = 272386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T InternalArray__IReadOnlyList_get_Item<T>(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__IReadOnlyList_get_Item_Internal_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0003B620 File Offset: 0x00039820
		[CallerCount(75)]
		[CachedScanResults(RefRangeStart = 268854, RefRangeEnd = 268929, XrefRangeStart = 268854, XrefRangeEnd = 268929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalArray__IReadOnlyCollection_get_Count()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_InternalArray__IReadOnlyCollection_get_Count_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0003B65C File Offset: 0x0003985C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272386, XrefRangeEnd = 273810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__Insert<T>(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__Insert_Internal_Void_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0003B6E4 File Offset: 0x000398E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273810, XrefRangeEnd = 273816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_InternalArray__RemoveAt_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0003B724 File Offset: 0x00039924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273816, XrefRangeEnd = 273823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalArray__IndexOf<T>(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__IndexOf_Internal_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0003B7A8 File Offset: 0x000399A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273823, XrefRangeEnd = 273825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T InternalArray__get_Item<T>(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__get_Item_Internal_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0003B7F0 File Offset: 0x000399F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273825, XrefRangeEnd = 273830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__set_Item<T>(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__set_Item_Internal_Void_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0003B878 File Offset: 0x00039A78
		[CallerCount(0)]
		public unsafe void GetGenericValueImpl<T>(int pos, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_GetGenericValueImpl_Internal_Void_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0003B904 File Offset: 0x00039B04
		[CallerCount(0)]
		public unsafe void SetGenericValueImpl<T>(int pos, ref T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_SetGenericValueImpl_Internal_Void_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0003B96C File Offset: 0x00039B6C
		public unsafe int Length
		{
			[CallerCount(75)]
			[CachedScanResults(RefRangeStart = 268854, RefRangeEnd = 268929, XrefRangeStart = 268854, XrefRangeEnd = 268929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0003B9A8 File Offset: 0x00039BA8
		public unsafe int Rank
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 273831, RefRangeEnd = 273862, XrefRangeStart = 273830, XrefRangeEnd = 273831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_Rank_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0003B9E4 File Offset: 0x00039BE4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 273831, RefRangeEnd = 273862, XrefRangeStart = 273831, XrefRangeEnd = 273862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetRank_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0003BA20 File Offset: 0x00039C20
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 273863, RefRangeEnd = 273894, XrefRangeStart = 273862, XrefRangeEnd = 273863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLength(int dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimension;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0003BA6C File Offset: 0x00039C6C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 273895, RefRangeEnd = 273908, XrefRangeStart = 273894, XrefRangeEnd = 273895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLowerBound(int dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimension;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetLowerBound_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0003BAB8 File Offset: 0x00039CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273909, RefRangeEnd = 273910, XrefRangeStart = 273908, XrefRangeEnd = 273909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue([Optional] Il2CppStructArray<int> indices)
		{
			if (indices == null)
			{
				indices = new Il2CppStructArray<int>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0003BB18 File Offset: 0x00039D18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 273911, RefRangeEnd = 273917, XrefRangeStart = 273910, XrefRangeEnd = 273911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, [Optional] Il2CppStructArray<int> indices)
		{
			if (indices == null)
			{
				indices = new Il2CppStructArray<int>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0003BB7C File Offset: 0x00039D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273918, RefRangeEnd = 273919, XrefRangeStart = 273917, XrefRangeEnd = 273918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValueImpl(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValueImpl_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0003BBC8 File Offset: 0x00039DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273919, XrefRangeEnd = 273920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValueImpl(Object value, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValueImpl_Internal_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0003BC18 File Offset: 0x00039E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273921, RefRangeEnd = 273922, XrefRangeStart = 273920, XrefRangeEnd = 273921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source_idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest_idx;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_FastCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0003BC98 File Offset: 0x00039E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273922, XrefRangeEnd = 273923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstanceImpl(Type elementType, Il2CppStructArray<int> lengths, Il2CppStructArray<int> bounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstanceImpl_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0003BD00 File Offset: 0x00039F00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273925, RefRangeEnd = 273926, XrefRangeStart = 273923, XrefRangeEnd = 273925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUpperBound(int dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimension;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetUpperBound_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0003BD4C File Offset: 0x00039F4C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 273953, RefRangeEnd = 273997, XrefRangeStart = 273926, XrefRangeEnd = 273953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0003BD98 File Offset: 0x00039F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273997, XrefRangeEnd = 274006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index1, int index2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0003BDF4 File Offset: 0x00039FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274006, XrefRangeEnd = 274017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index1, int index2, int index3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0003BE5C File Offset: 0x0003A05C
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 274044, RefRangeEnd = 274086, XrefRangeStart = 274017, XrefRangeEnd = 274044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0003BEAC File Offset: 0x0003A0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274086, XrefRangeEnd = 274095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, int index1, int index2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0003BF0C File Offset: 0x0003A10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274095, XrefRangeEnd = 274106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, int index1, int index2, int index3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0003BF78 File Offset: 0x0003A178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274106, XrefRangeEnd = 274107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array UnsafeCreateInstance(Type elementType, Il2CppStructArray<int> lengths, Il2CppStructArray<int> lowerBounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBounds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0003BFE0 File Offset: 0x0003A1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274107, XrefRangeEnd = 274116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array UnsafeCreateInstance(Type elementType, int length1, int length2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0003C040 File Offset: 0x0003A240
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 274117, RefRangeEnd = 274121, XrefRangeStart = 274116, XrefRangeEnd = 274117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array UnsafeCreateInstance(Type elementType, [Optional] Il2CppStructArray<int> lengths)
		{
			if (lengths == null)
			{
				lengths = new Il2CppStructArray<int>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0003C0A4 File Offset: 0x0003A2A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 274128, RefRangeEnd = 274135, XrefRangeStart = 274121, XrefRangeEnd = 274128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0003C0F8 File Offset: 0x0003A2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, int length1, int length2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0003C158 File Offset: 0x0003A358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274135, XrefRangeEnd = 274146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, int length1, int length2, int length3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0003C1C8 File Offset: 0x0003A3C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 274200, RefRangeEnd = 274207, XrefRangeStart = 274146, XrefRangeEnd = 274200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, [Optional] Il2CppStructArray<int> lengths)
		{
			if (lengths == null)
			{
				lengths = new Il2CppStructArray<int>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0003C22C File Offset: 0x0003A42C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274302, RefRangeEnd = 274303, XrefRangeStart = 274207, XrefRangeEnd = 274302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, Il2CppStructArray<int> lengths, Il2CppStructArray<int> lowerBounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBounds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0003C294 File Offset: 0x0003A494
		[CallerCount(135)]
		[CachedScanResults(RefRangeStart = 274330, RefRangeEnd = 274465, XrefRangeStart = 274303, XrefRangeEnd = 274330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(Array array, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Clear_Public_Static_Void_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0003C2E8 File Offset: 0x0003A4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274465, XrefRangeEnd = 274466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearInternal(Array a, int index, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_ClearInternal_Private_Static_Void_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0003C33C File Offset: 0x0003A53C
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 274469, RefRangeEnd = 274535, XrefRangeStart = 274466, XrefRangeEnd = 274469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Array sourceArray, Array destinationArray, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationArray);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0003C394 File Offset: 0x0003A594
		[CallerCount(125)]
		[CachedScanResults(RefRangeStart = 274554, RefRangeEnd = 274679, XrefRangeStart = 274535, XrefRangeEnd = 274554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationArray);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0003C408 File Offset: 0x0003A608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274679, XrefRangeEnd = 274687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateArrayTypeMismatchException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0003C43C File Offset: 0x0003A63C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274690, RefRangeEnd = 274692, XrefRangeStart = 274687, XrefRangeEnd = 274690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanAssignArrayElement(Type source, Type target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CanAssignArrayElement_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0003C490 File Offset: 0x0003A690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274692, XrefRangeEnd = 274693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationArray);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_ConstrainedCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0003C504 File Offset: 0x0003A704
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 58322, RefRangeEnd = 58381, XrefRangeStart = 58322, XrefRangeEnd = 58381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> Empty<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Empty_Public_Static_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0003C530 File Offset: 0x0003A730
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0003C564 File Offset: 0x0003A764
		[CallerCount(0)]
		public unsafe static int IndexOfImpl<T>(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_IndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0003C60C File Offset: 0x0003A80C
		[CallerCount(0)]
		public unsafe static int LastIndexOfImpl<T>(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_LastIndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0003C6B4 File Offset: 0x0003A8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274693, XrefRangeEnd = 274703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SortImpl_Private_Static_Void_Array_Array_Int32_Int32_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0003C72C File Offset: 0x0003A92C
		[CallerCount(0)]
		public unsafe static T UnsafeLoad<T>(Il2CppArrayBase<T> array, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_UnsafeLoad_Internal_Static_T_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0003C778 File Offset: 0x0003A978
		[CallerCount(0)]
		public unsafe static void UnsafeStore<T>(Il2CppArrayBase<T> array, int index, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_UnsafeStore_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0003C804 File Offset: 0x0003AA04
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static R UnsafeMov<S, R>(S instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(S).IsValueType)
				{
					S s = instance;
					intPtr = ((s is string) ? IL2CPP.ManagedStringToIl2Cpp(s as string) : IL2CPP.Il2CppObjectBaseToPtr(s as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_UnsafeMov_Internal_Static_R_S_0<S, R>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<R>(intPtr2, false, true);
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00003E89 File Offset: 0x00002089
		public static Array CreateInstance(Type elementType, params long[] lengths)
		{
			return Array.CreateInstance(elementType, new Il2CppStructArray<long>(lengths));
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00003E97 File Offset: 0x00002097
		public Object GetValue(params long[] indices)
		{
			return this.GetValue(new Il2CppStructArray<long>(indices));
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00003EA5 File Offset: 0x000020A5
		public void SetValue(Object value, params long[] indices)
		{
			this.SetValue(value, new Il2CppStructArray<long>(indices));
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00003EB4 File Offset: 0x000020B4
		public Object GetValue(params int[] indices)
		{
			return this.GetValue(new Il2CppStructArray<int>(indices));
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00003EC2 File Offset: 0x000020C2
		public void SetValue(Object value, params int[] indices)
		{
			this.SetValue(value, new Il2CppStructArray<int>(indices));
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00003ED1 File Offset: 0x000020D1
		public static Array UnsafeCreateInstance(Type elementType, params int[] lengths)
		{
			return Array.UnsafeCreateInstance(elementType, new Il2CppStructArray<int>(lengths));
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00003EDF File Offset: 0x000020DF
		public static Array CreateInstance(Type elementType, params int[] lengths)
		{
			return Array.CreateInstance(elementType, new Il2CppStructArray<int>(lengths));
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00003EED File Offset: 0x000020ED
		public Array(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int64_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_AsReadOnly_Public_Static_ReadOnlyCollection_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_ConvertAll_Public_Static_Il2CppArrayBase_1_TOutput_Il2CppArrayBase_1_TInput_Converter_2_TInput_TOutput_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int64_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int64_Array_Int64_Int64_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int64_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_ForEach_Public_Static_Void_Il2CppArrayBase_1_T_Action_1_T_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_get_LongLength_Public_get_Int64_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_GetLongLength_Public_Int64_Int32_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int64_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_Int64_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int64_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_IComparer_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_IComparer_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_GetMedian_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_IComparer_1_T_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_Int32_Int32_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_Int64_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int64_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_IComparer_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_IComparer_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_IComparer_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_IComparer_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_IComparer_1_T_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_FindAll_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_FindLast_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_TrueForAll_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_get_Count_Internal_Int32_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_get_IsReadOnly_Internal_Boolean_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__IEnumerable_GetEnumerator_Internal_IEnumerator_1_T_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_Clear_Internal_Void_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_Add_Internal_Void_T_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_Remove_Internal_Boolean_T_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_Contains_Internal_Boolean_T_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_CopyTo_Internal_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__IReadOnlyList_get_Item_Internal_T_Int32_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__IReadOnlyCollection_get_Count_Internal_Int32_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__Insert_Internal_Void_Int32_T_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__RemoveAt_Internal_Void_Int32_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__IndexOf_Internal_Int32_T_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__get_Item_Internal_T_Int32_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__set_Item_Internal_Void_Int32_T_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericValueImpl_Internal_Void_Int32_byref_T_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_SetGenericValueImpl_Internal_Void_Int32_byref_T_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_get_Rank_Public_get_Int32_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_GetRank_Private_Int32_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_GetLowerBound_Public_Int32_Int32_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_GetValueImpl_Internal_Object_Int32_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_SetValueImpl_Internal_Void_Object_Int32_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_FastCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceImpl_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_GetUpperBound_Public_Int32_Int32_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_Int32_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_Int32_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Int32_Int32_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_Int32_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Array_Int32_Int32_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_ClearInternal_Private_Static_Void_Array_Int32_Int32_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int32_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_Exception_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_CanAssignArrayElement_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_ConstrainedCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_Empty_Public_Static_Il2CppArrayBase_1_T_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_SortImpl_Private_Static_Void_Array_Array_Int32_Int32_IComparer_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeLoad_Internal_Static_T_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeStore_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_T_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeMov_Internal_Static_R_S_0;

		// Token: 0x0200054D RID: 1357
		public sealed class ArrayEnumerator : Object
		{
			// Token: 0x06004E47 RID: 20039 RVA: 0x00160C80 File Offset: 0x0015EE80
			// Note: this type is marked as 'beforefieldinit'.
			static ArrayEnumerator()
			{
				Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "ArrayEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr);
				Array.ArrayEnumerator.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, "_array");
				Array.ArrayEnumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, "_index");
				Array.ArrayEnumerator.NativeFieldInfoPtr__endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, "_endIndex");
				Array.ArrayEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, 100664222);
				Array.ArrayEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, 100664223);
				Array.ArrayEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, 100664224);
				Array.ArrayEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, 100664225);
				Array.ArrayEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, 100664226);
			}

			// Token: 0x06004E48 RID: 20040 RVA: 0x00160D4C File Offset: 0x0015EF4C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 267189, RefRangeEnd = 267190, XrefRangeStart = 267187, XrefRangeEnd = 267189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArrayEnumerator(Array array)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.ArrayEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E49 RID: 20041 RVA: 0x00160D98 File Offset: 0x0015EF98
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.ArrayEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E4A RID: 20042 RVA: 0x00160DD4 File Offset: 0x0015EFD4
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.ArrayEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E4B RID: 20043 RVA: 0x00160E08 File Offset: 0x0015F008
			[CallerCount(92)]
			[CachedScanResults(RefRangeStart = 267191, RefRangeEnd = 267283, XrefRangeStart = 267190, XrefRangeEnd = 267191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.ArrayEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x170013F2 RID: 5106
			// (get) Token: 0x06004E4C RID: 20044 RVA: 0x00160E48 File Offset: 0x0015F048
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267283, XrefRangeEnd = 267305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.ArrayEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E4D RID: 20045 RVA: 0x0001DA7F File Offset: 0x0001BC7F
			public ArrayEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013EF RID: 5103
			// (get) Token: 0x06004E4E RID: 20046 RVA: 0x00160E88 File Offset: 0x0015F088
			// (set) Token: 0x06004E4F RID: 20047 RVA: 0x0001DA88 File Offset: 0x0001BC88
			public unsafe Array _array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F0 RID: 5104
			// (get) Token: 0x06004E50 RID: 20048 RVA: 0x00160EB8 File Offset: 0x0015F0B8
			// (set) Token: 0x06004E51 RID: 20049 RVA: 0x0001DAA7 File Offset: 0x0001BCA7
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x170013F1 RID: 5105
			// (get) Token: 0x06004E52 RID: 20050 RVA: 0x00160EE0 File Offset: 0x0015F0E0
			// (set) Token: 0x06004E53 RID: 20051 RVA: 0x0001DAC2 File Offset: 0x0001BCC2
			public unsafe int _endIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__endIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__endIndex)) = value;
				}
			}

			// Token: 0x04003F2D RID: 16173
			private static readonly IntPtr NativeFieldInfoPtr__array;

			// Token: 0x04003F2E RID: 16174
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04003F2F RID: 16175
			private static readonly IntPtr NativeFieldInfoPtr__endIndex;

			// Token: 0x04003F30 RID: 16176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Array_0;

			// Token: 0x04003F31 RID: 16177
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F32 RID: 16178
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003F33 RID: 16179
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x04003F34 RID: 16180
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200054E RID: 1358
		public sealed class InternalEnumerator<T> : ValueType
		{
			// Token: 0x06004E54 RID: 20052 RVA: 0x00160F08 File Offset: 0x0015F108
			// Note: this type is marked as 'beforefieldinit'.
			static InternalEnumerator()
			{
				Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "InternalEnumerator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr);
				Array.InternalEnumerator<T>.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, "array");
				Array.InternalEnumerator<T>.NativeFieldInfoPtr_idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, "idx");
				Array.InternalEnumerator<T>.NativeMethodInfoPtr__ctor_Internal_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100664227);
				Array.InternalEnumerator<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100664228);
				Array.InternalEnumerator<T>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100664229);
				Array.InternalEnumerator<T>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100664230);
				Array.InternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100664231);
				Array.InternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100664232);
			}

			// Token: 0x06004E55 RID: 20053 RVA: 0x00161010 File Offset: 0x0015F210
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 267305, RefRangeEnd = 267306, XrefRangeStart = 267305, XrefRangeEnd = 267305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalEnumerator(Array array)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr__ctor_Internal_Void_Array_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E56 RID: 20054 RVA: 0x00161060 File Offset: 0x0015F260
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E57 RID: 20055 RVA: 0x00161098 File Offset: 0x0015F298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267306, XrefRangeEnd = 267307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170013F5 RID: 5109
			// (get) Token: 0x06004E58 RID: 20056 RVA: 0x001610DC File Offset: 0x0015F2DC
			public unsafe T Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267307, XrefRangeEnd = 267311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06004E59 RID: 20057 RVA: 0x0016111C File Offset: 0x0015F31C
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170013F6 RID: 5110
			// (get) Token: 0x06004E5A RID: 20058 RVA: 0x00161154 File Offset: 0x0015F354
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267311, XrefRangeEnd = 267316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E5B RID: 20059 RVA: 0x0001DADD File Offset: 0x0001BCDD
			public InternalEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004E5C RID: 20060 RVA: 0x0001DAE6 File Offset: 0x0001BCE6
			public InternalEnumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr))
			{
			}

			// Token: 0x170013F3 RID: 5107
			// (get) Token: 0x06004E5D RID: 20061 RVA: 0x00161198 File Offset: 0x0015F398
			// (set) Token: 0x06004E5E RID: 20062 RVA: 0x0001DAF8 File Offset: 0x0001BCF8
			public unsafe Array array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.InternalEnumerator<T>.NativeFieldInfoPtr_array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.InternalEnumerator<T>.NativeFieldInfoPtr_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F4 RID: 5108
			// (get) Token: 0x06004E5F RID: 20063 RVA: 0x001611C8 File Offset: 0x0015F3C8
			// (set) Token: 0x06004E60 RID: 20064 RVA: 0x0001DB17 File Offset: 0x0001BD17
			public unsafe int idx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.InternalEnumerator<T>.NativeFieldInfoPtr_idx);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.InternalEnumerator<T>.NativeFieldInfoPtr_idx)) = value;
				}
			}

			// Token: 0x04003F35 RID: 16181
			private static readonly IntPtr NativeFieldInfoPtr_array;

			// Token: 0x04003F36 RID: 16182
			private static readonly IntPtr NativeFieldInfoPtr_idx;

			// Token: 0x04003F37 RID: 16183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Array_0;

			// Token: 0x04003F38 RID: 16184
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003F39 RID: 16185
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F3A RID: 16186
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04003F3B RID: 16187
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F3C RID: 16188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200054F RID: 1359
		public class EmptyInternalEnumerator<T> : Object
		{
			// Token: 0x06004E61 RID: 20065 RVA: 0x001611F0 File Offset: 0x0015F3F0
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyInternalEnumerator()
			{
				Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "EmptyInternalEnumerator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr);
				Array.EmptyInternalEnumerator<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, "Value");
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100664233);
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100664234);
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100664235);
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100664236);
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100664237);
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100664238);
			}

			// Token: 0x06004E62 RID: 20066 RVA: 0x001612E4 File Offset: 0x0015F4E4
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E63 RID: 20067 RVA: 0x00161318 File Offset: 0x0015F518
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170013F8 RID: 5112
			// (get) Token: 0x06004E64 RID: 20068 RVA: 0x00161354 File Offset: 0x0015F554
			public unsafe virtual T Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267316, XrefRangeEnd = 268612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x170013F9 RID: 5113
			// (get) Token: 0x06004E65 RID: 20069 RVA: 0x00161390 File Offset: 0x0015F590
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268612, XrefRangeEnd = 268614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E66 RID: 20070 RVA: 0x001613D0 File Offset: 0x0015F5D0
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E67 RID: 20071 RVA: 0x00161404 File Offset: 0x0015F604
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmptyInternalEnumerator()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E68 RID: 20072 RVA: 0x0001DB32 File Offset: 0x0001BD32
			public EmptyInternalEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013F7 RID: 5111
			// (get) Token: 0x06004E69 RID: 20073 RVA: 0x00161440 File Offset: 0x0015F640
			// (set) Token: 0x06004E6A RID: 20074 RVA: 0x0001DB3B File Offset: 0x0001BD3B
			public unsafe static Array.EmptyInternalEnumerator<T> Value
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Array.EmptyInternalEnumerator<T>.NativeFieldInfoPtr_Value, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array.EmptyInternalEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Array.EmptyInternalEnumerator<T>.NativeFieldInfoPtr_Value, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F3D RID: 16189
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04003F3E RID: 16190
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003F3F RID: 16191
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F40 RID: 16192
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04003F41 RID: 16193
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F42 RID: 16194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F43 RID: 16195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000550 RID: 1360
		public sealed class SorterObjectArray : ValueType
		{
			// Token: 0x06004E6B RID: 20075 RVA: 0x00161468 File Offset: 0x0015F668
			// Note: this type is marked as 'beforefieldinit'.
			static SorterObjectArray()
			{
				Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "SorterObjectArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr);
				Array.SorterObjectArray.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, "keys");
				Array.SorterObjectArray.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, "items");
				Array.SorterObjectArray.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, "comparer");
				Array.SorterObjectArray.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100664240);
				Array.SorterObjectArray.NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100664241);
				Array.SorterObjectArray.NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100664242);
				Array.SorterObjectArray.NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100664243);
				Array.SorterObjectArray.NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100664244);
				Array.SorterObjectArray.NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100664245);
				Array.SorterObjectArray.NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100664246);
				Array.SorterObjectArray.NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100664247);
				Array.SorterObjectArray.NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100664248);
				Array.SorterObjectArray.NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100664249);
			}

			// Token: 0x06004E6C RID: 20076 RVA: 0x00161598 File Offset: 0x0015F798
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 268618, RefRangeEnd = 268620, XrefRangeStart = 268614, XrefRangeEnd = 268618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SorterObjectArray(Il2CppReferenceArray<Object> keys, Il2CppReferenceArray<Object> items, IComparer comparer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_IComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E6D RID: 20077 RVA: 0x0016160C File Offset: 0x0015F80C
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 268627, RefRangeEnd = 268633, XrefRangeStart = 268620, XrefRangeEnd = 268627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SwapIfGreaterWithItems(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E6E RID: 20078 RVA: 0x00161660 File Offset: 0x0015F860
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 268637, RefRangeEnd = 268641, XrefRangeStart = 268633, XrefRangeEnd = 268637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Swap(int i, int j)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E6F RID: 20079 RVA: 0x001616B4 File Offset: 0x0015F8B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 268642, RefRangeEnd = 268644, XrefRangeStart = 268641, XrefRangeEnd = 268642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Sort(int left, int length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E70 RID: 20080 RVA: 0x00161708 File Offset: 0x0015F908
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268648, RefRangeEnd = 268649, XrefRangeStart = 268644, XrefRangeEnd = 268648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void IntrospectiveSort(int left, int length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E71 RID: 20081 RVA: 0x0016175C File Offset: 0x0015F95C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 268659, RefRangeEnd = 268661, XrefRangeStart = 268649, XrefRangeEnd = 268659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void IntroSort(int lo, int hi, int depthLimit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLimit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E72 RID: 20082 RVA: 0x001617BC File Offset: 0x0015F9BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268673, RefRangeEnd = 268674, XrefRangeStart = 268661, XrefRangeEnd = 268673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int PickPivotAndPartition(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E73 RID: 20083 RVA: 0x00161818 File Offset: 0x0015FA18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268677, RefRangeEnd = 268678, XrefRangeStart = 268674, XrefRangeEnd = 268677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Heapsort(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E74 RID: 20084 RVA: 0x0016186C File Offset: 0x0015FA6C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 268689, RefRangeEnd = 268691, XrefRangeStart = 268678, XrefRangeEnd = 268689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DownHeap(int i, int n, int lo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E75 RID: 20085 RVA: 0x001618CC File Offset: 0x0015FACC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268699, RefRangeEnd = 268700, XrefRangeStart = 268691, XrefRangeEnd = 268699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InsertionSort(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E76 RID: 20086 RVA: 0x0001DB4D File Offset: 0x0001BD4D
			public SorterObjectArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004E77 RID: 20087 RVA: 0x0001DB56 File Offset: 0x0001BD56
			public SorterObjectArray()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr))
			{
			}

			// Token: 0x170013FA RID: 5114
			// (get) Token: 0x06004E78 RID: 20088 RVA: 0x00161920 File Offset: 0x0015FB20
			// (set) Token: 0x06004E79 RID: 20089 RVA: 0x0001DB68 File Offset: 0x0001BD68
			public unsafe Il2CppReferenceArray<Object> keys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_keys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013FB RID: 5115
			// (get) Token: 0x06004E7A RID: 20090 RVA: 0x00161950 File Offset: 0x0015FB50
			// (set) Token: 0x06004E7B RID: 20091 RVA: 0x0001DB87 File Offset: 0x0001BD87
			public unsafe Il2CppReferenceArray<Object> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013FC RID: 5116
			// (get) Token: 0x06004E7C RID: 20092 RVA: 0x00161980 File Offset: 0x0015FB80
			// (set) Token: 0x06004E7D RID: 20093 RVA: 0x0001DBA6 File Offset: 0x0001BDA6
			public unsafe IComparer comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F44 RID: 16196
			private static readonly IntPtr NativeFieldInfoPtr_keys;

			// Token: 0x04003F45 RID: 16197
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x04003F46 RID: 16198
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x04003F47 RID: 16199
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_IComparer_0;

			// Token: 0x04003F48 RID: 16200
			private static readonly IntPtr NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0;

			// Token: 0x04003F49 RID: 16201
			private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0;

			// Token: 0x04003F4A RID: 16202
			private static readonly IntPtr NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0;

			// Token: 0x04003F4B RID: 16203
			private static readonly IntPtr NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0;

			// Token: 0x04003F4C RID: 16204
			private static readonly IntPtr NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0;

			// Token: 0x04003F4D RID: 16205
			private static readonly IntPtr NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0;

			// Token: 0x04003F4E RID: 16206
			private static readonly IntPtr NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0;

			// Token: 0x04003F4F RID: 16207
			private static readonly IntPtr NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0;

			// Token: 0x04003F50 RID: 16208
			private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0;
		}

		// Token: 0x02000551 RID: 1361
		public sealed class SorterGenericArray : ValueType
		{
			// Token: 0x06004E7E RID: 20094 RVA: 0x001619B0 File Offset: 0x0015FBB0
			// Note: this type is marked as 'beforefieldinit'.
			static SorterGenericArray()
			{
				Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "SorterGenericArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr);
				Array.SorterGenericArray.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, "keys");
				Array.SorterGenericArray.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, "items");
				Array.SorterGenericArray.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, "comparer");
				Array.SorterGenericArray.NativeMethodInfoPtr__ctor_Internal_Void_Array_Array_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100664250);
				Array.SorterGenericArray.NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100664251);
				Array.SorterGenericArray.NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100664252);
				Array.SorterGenericArray.NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100664253);
				Array.SorterGenericArray.NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100664254);
				Array.SorterGenericArray.NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100664255);
				Array.SorterGenericArray.NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100664256);
				Array.SorterGenericArray.NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100664257);
				Array.SorterGenericArray.NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100664258);
				Array.SorterGenericArray.NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100664259);
			}

			// Token: 0x06004E7F RID: 20095 RVA: 0x00161AE0 File Offset: 0x0015FCE0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268704, RefRangeEnd = 268705, XrefRangeStart = 268700, XrefRangeEnd = 268704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SorterGenericArray(Array keys, Array items, IComparer comparer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr__ctor_Internal_Void_Array_Array_IComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E80 RID: 20096 RVA: 0x00161B54 File Offset: 0x0015FD54
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 268718, RefRangeEnd = 268724, XrefRangeStart = 268705, XrefRangeEnd = 268718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SwapIfGreaterWithItems(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E81 RID: 20097 RVA: 0x00161BA8 File Offset: 0x0015FDA8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 268732, RefRangeEnd = 268736, XrefRangeStart = 268724, XrefRangeEnd = 268732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Swap(int i, int j)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E82 RID: 20098 RVA: 0x00161BFC File Offset: 0x0015FDFC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268737, RefRangeEnd = 268738, XrefRangeStart = 268736, XrefRangeEnd = 268737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Sort(int left, int length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E83 RID: 20099 RVA: 0x00161C50 File Offset: 0x0015FE50
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268743, RefRangeEnd = 268744, XrefRangeStart = 268738, XrefRangeEnd = 268743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void IntrospectiveSort(int left, int length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E84 RID: 20100 RVA: 0x00161CA4 File Offset: 0x0015FEA4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 268754, RefRangeEnd = 268756, XrefRangeStart = 268744, XrefRangeEnd = 268754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void IntroSort(int lo, int hi, int depthLimit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLimit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E85 RID: 20101 RVA: 0x00161D04 File Offset: 0x0015FF04
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268771, RefRangeEnd = 268772, XrefRangeStart = 268756, XrefRangeEnd = 268771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int PickPivotAndPartition(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E86 RID: 20102 RVA: 0x00161D60 File Offset: 0x0015FF60
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268775, RefRangeEnd = 268776, XrefRangeStart = 268772, XrefRangeEnd = 268775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Heapsort(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E87 RID: 20103 RVA: 0x00161DB4 File Offset: 0x0015FFB4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 268793, RefRangeEnd = 268795, XrefRangeStart = 268776, XrefRangeEnd = 268793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DownHeap(int i, int n, int lo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E88 RID: 20104 RVA: 0x00161E14 File Offset: 0x00160014
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 268808, RefRangeEnd = 268809, XrefRangeStart = 268795, XrefRangeEnd = 268808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InsertionSort(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E89 RID: 20105 RVA: 0x0001DBC5 File Offset: 0x0001BDC5
			public SorterGenericArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004E8A RID: 20106 RVA: 0x0001DBCE File Offset: 0x0001BDCE
			public SorterGenericArray()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr))
			{
			}

			// Token: 0x170013FD RID: 5117
			// (get) Token: 0x06004E8B RID: 20107 RVA: 0x00161E68 File Offset: 0x00160068
			// (set) Token: 0x06004E8C RID: 20108 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
			public unsafe Array keys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_keys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013FE RID: 5118
			// (get) Token: 0x06004E8D RID: 20109 RVA: 0x00161E98 File Offset: 0x00160098
			// (set) Token: 0x06004E8E RID: 20110 RVA: 0x0001DBFF File Offset: 0x0001BDFF
			public unsafe Array items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013FF RID: 5119
			// (get) Token: 0x06004E8F RID: 20111 RVA: 0x00161EC8 File Offset: 0x001600C8
			// (set) Token: 0x06004E90 RID: 20112 RVA: 0x0001DC1E File Offset: 0x0001BE1E
			public unsafe IComparer comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F51 RID: 16209
			private static readonly IntPtr NativeFieldInfoPtr_keys;

			// Token: 0x04003F52 RID: 16210
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x04003F53 RID: 16211
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x04003F54 RID: 16212
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Array_Array_IComparer_0;

			// Token: 0x04003F55 RID: 16213
			private static readonly IntPtr NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0;

			// Token: 0x04003F56 RID: 16214
			private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0;

			// Token: 0x04003F57 RID: 16215
			private static readonly IntPtr NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0;

			// Token: 0x04003F58 RID: 16216
			private static readonly IntPtr NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0;

			// Token: 0x04003F59 RID: 16217
			private static readonly IntPtr NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0;

			// Token: 0x04003F5A RID: 16218
			private static readonly IntPtr NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0;

			// Token: 0x04003F5B RID: 16219
			private static readonly IntPtr NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0;

			// Token: 0x04003F5C RID: 16220
			private static readonly IntPtr NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0;

			// Token: 0x04003F5D RID: 16221
			private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0;
		}

		// Token: 0x02000552 RID: 1362
		private sealed class MethodInfoStoreGeneric_AsReadOnly_Public_Static_ReadOnlyCollection_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04003F5E RID: 16222
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_AsReadOnly_Public_Static_ReadOnlyCollection_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000553 RID: 1363
		private sealed class MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04003F5F RID: 16223
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000554 RID: 1364
		private sealed class MethodInfoStoreGeneric_ConvertAll_Public_Static_Il2CppArrayBase_1_TOutput_Il2CppArrayBase_1_TInput_Converter_2_TInput_TOutput_0<TInput, TOutput>
		{
			// Token: 0x04003F60 RID: 16224
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_ConvertAll_Public_Static_Il2CppArrayBase_1_TOutput_Il2CppArrayBase_1_TInput_Converter_2_TInput_TOutput_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInput>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutput>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000555 RID: 1365
		private sealed class MethodInfoStoreGeneric_ForEach_Public_Static_Void_Il2CppArrayBase_1_T_Action_1_T_0<T>
		{
			// Token: 0x04003F61 RID: 16225
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_ForEach_Public_Static_Void_Il2CppArrayBase_1_T_Action_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000556 RID: 1366
		private sealed class MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04003F62 RID: 16226
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000557 RID: 1367
		private sealed class MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_IComparer_1_T_0<T>
		{
			// Token: 0x04003F63 RID: 16227
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_IComparer_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000558 RID: 1368
		private sealed class MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_0<T>
		{
			// Token: 0x04003F64 RID: 16228
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000559 RID: 1369
		private sealed class MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0<T>
		{
			// Token: 0x04003F65 RID: 16229
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200055A RID: 1370
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04003F66 RID: 16230
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200055B RID: 1371
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0<T>
		{
			// Token: 0x04003F67 RID: 16231
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200055C RID: 1372
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x04003F68 RID: 16232
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200055D RID: 1373
		private sealed class MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04003F69 RID: 16233
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200055E RID: 1374
		private sealed class MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0<T>
		{
			// Token: 0x04003F6A RID: 16234
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200055F RID: 1375
		private sealed class MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x04003F6B RID: 16235
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000560 RID: 1376
		private sealed class MethodInfoStoreGeneric_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04003F6C RID: 16236
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000561 RID: 1377
		private sealed class MethodInfoStoreGeneric_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04003F6D RID: 16237
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000562 RID: 1378
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04003F6E RID: 16238
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000563 RID: 1379
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04003F6F RID: 16239
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000564 RID: 1380
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_IComparer_1_T_0<T>
		{
			// Token: 0x04003F70 RID: 16240
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_IComparer_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000565 RID: 1381
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0<T>
		{
			// Token: 0x04003F71 RID: 16241
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000566 RID: 1382
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_0<T>
		{
			// Token: 0x04003F72 RID: 16242
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000567 RID: 1383
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_0<TKey, TValue>
		{
			// Token: 0x04003F73 RID: 16243
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000568 RID: 1384
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0<TKey, TValue>
		{
			// Token: 0x04003F74 RID: 16244
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000569 RID: 1385
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_0<TKey, TValue>
		{
			// Token: 0x04003F75 RID: 16245
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200056A RID: 1386
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0<TKey, TValue>
		{
			// Token: 0x04003F76 RID: 16246
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200056B RID: 1387
		private sealed class MethodInfoStoreGeneric_Exists_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04003F77 RID: 16247
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Exists_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200056C RID: 1388
		private sealed class MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04003F78 RID: 16248
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200056D RID: 1389
		private sealed class MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x04003F79 RID: 16249
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200056E RID: 1390
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04003F7A RID: 16250
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200056F RID: 1391
		private sealed class MethodInfoStoreGeneric_FindAll_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04003F7B RID: 16251
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindAll_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000570 RID: 1392
		private sealed class MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04003F7C RID: 16252
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000571 RID: 1393
		private sealed class MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0<T>
		{
			// Token: 0x04003F7D RID: 16253
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000572 RID: 1394
		private sealed class MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0<T>
		{
			// Token: 0x04003F7E RID: 16254
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000573 RID: 1395
		private sealed class MethodInfoStoreGeneric_FindLast_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04003F7F RID: 16255
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindLast_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000574 RID: 1396
		private sealed class MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04003F80 RID: 16256
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000575 RID: 1397
		private sealed class MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0<T>
		{
			// Token: 0x04003F81 RID: 16257
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000576 RID: 1398
		private sealed class MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0<T>
		{
			// Token: 0x04003F82 RID: 16258
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000577 RID: 1399
		private sealed class MethodInfoStoreGeneric_TrueForAll_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04003F83 RID: 16259
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_TrueForAll_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000578 RID: 1400
		private sealed class MethodInfoStoreGeneric_InternalArray__IEnumerable_GetEnumerator_Internal_IEnumerator_1_T_0<T>
		{
			// Token: 0x04003F84 RID: 16260
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__IEnumerable_GetEnumerator_Internal_IEnumerator_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000579 RID: 1401
		private sealed class MethodInfoStoreGeneric_InternalArray__ICollection_Add_Internal_Void_T_0<T>
		{
			// Token: 0x04003F85 RID: 16261
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__ICollection_Add_Internal_Void_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200057A RID: 1402
		private sealed class MethodInfoStoreGeneric_InternalArray__ICollection_Remove_Internal_Boolean_T_0<T>
		{
			// Token: 0x04003F86 RID: 16262
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__ICollection_Remove_Internal_Boolean_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200057B RID: 1403
		private sealed class MethodInfoStoreGeneric_InternalArray__ICollection_Contains_Internal_Boolean_T_0<T>
		{
			// Token: 0x04003F87 RID: 16263
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__ICollection_Contains_Internal_Boolean_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200057C RID: 1404
		private sealed class MethodInfoStoreGeneric_InternalArray__ICollection_CopyTo_Internal_Void_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04003F88 RID: 16264
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__ICollection_CopyTo_Internal_Void_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200057D RID: 1405
		private sealed class MethodInfoStoreGeneric_InternalArray__IReadOnlyList_get_Item_Internal_T_Int32_0<T>
		{
			// Token: 0x04003F89 RID: 16265
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__IReadOnlyList_get_Item_Internal_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200057E RID: 1406
		private sealed class MethodInfoStoreGeneric_InternalArray__Insert_Internal_Void_Int32_T_0<T>
		{
			// Token: 0x04003F8A RID: 16266
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__Insert_Internal_Void_Int32_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200057F RID: 1407
		private sealed class MethodInfoStoreGeneric_InternalArray__IndexOf_Internal_Int32_T_0<T>
		{
			// Token: 0x04003F8B RID: 16267
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__IndexOf_Internal_Int32_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000580 RID: 1408
		private sealed class MethodInfoStoreGeneric_InternalArray__get_Item_Internal_T_Int32_0<T>
		{
			// Token: 0x04003F8C RID: 16268
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__get_Item_Internal_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000581 RID: 1409
		private sealed class MethodInfoStoreGeneric_InternalArray__set_Item_Internal_Void_Int32_T_0<T>
		{
			// Token: 0x04003F8D RID: 16269
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__set_Item_Internal_Void_Int32_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000582 RID: 1410
		private sealed class MethodInfoStoreGeneric_GetGenericValueImpl_Internal_Void_Int32_byref_T_0<T>
		{
			// Token: 0x04003F8E RID: 16270
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_GetGenericValueImpl_Internal_Void_Int32_byref_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000583 RID: 1411
		private sealed class MethodInfoStoreGeneric_SetGenericValueImpl_Internal_Void_Int32_byref_T_0<T>
		{
			// Token: 0x04003F8F RID: 16271
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_SetGenericValueImpl_Internal_Void_Int32_byref_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000584 RID: 1412
		private sealed class MethodInfoStoreGeneric_Empty_Public_Static_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04003F90 RID: 16272
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Empty_Public_Static_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000585 RID: 1413
		private sealed class MethodInfoStoreGeneric_IndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x04003F91 RID: 16273
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_IndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000586 RID: 1414
		private sealed class MethodInfoStoreGeneric_LastIndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x04003F92 RID: 16274
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_LastIndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000587 RID: 1415
		private sealed class MethodInfoStoreGeneric_UnsafeLoad_Internal_Static_T_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04003F93 RID: 16275
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_UnsafeLoad_Internal_Static_T_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000588 RID: 1416
		private sealed class MethodInfoStoreGeneric_UnsafeStore_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_T_0<T>
		{
			// Token: 0x04003F94 RID: 16276
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_UnsafeStore_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000589 RID: 1417
		private sealed class MethodInfoStoreGeneric_UnsafeMov_Internal_Static_R_S_0<S, R>
		{
			// Token: 0x04003F95 RID: 16277
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_UnsafeMov_Internal_Static_R_S_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<S>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr))
			}))));
		}
	}
}
