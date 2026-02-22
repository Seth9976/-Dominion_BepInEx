using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000B8 RID: 184
	[Serializable]
	public class Stack<T> : Object
	{
		// Token: 0x06000B3C RID: 2876 RVA: 0x0003B09C File Offset: 0x0003929C
		// Note: this type is marked as 'beforefieldinit'.
		static Stack()
		{
			Il2CppClassPointerStore<Stack<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "Stack`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr);
			Stack<T>.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "_array");
			Stack<T>.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "_size");
			Stack<T>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "_version");
			Stack<T>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "_syncRoot");
			Stack<T>.NativeFieldInfoPtr_DefaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "DefaultCapacity");
			Stack<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664901);
			Stack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664902);
			Stack<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664903);
			Stack<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664904);
			Stack<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664905);
			Stack<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664906);
			Stack<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664907);
			Stack<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664908);
			Stack<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664909);
			Stack<T>.NativeMethodInfoPtr_Peek_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664910);
			Stack<T>.NativeMethodInfoPtr_Pop_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664911);
			Stack<T>.NativeMethodInfoPtr_Push_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664912);
			Stack<T>.NativeMethodInfoPtr_ThrowForEmptyStack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, 100664913);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0003B270 File Offset: 0x00039470
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 44768, RefRangeEnd = 44784, XrefRangeStart = 44768, XrefRangeEnd = 44784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0003B2AC File Offset: 0x000394AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45696, XrefRangeEnd = 45699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0003B2F4 File Offset: 0x000394F4
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0003B330 File Offset: 0x00039530
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0003B364 File Offset: 0x00039564
		[CallerCount(0)]
		public unsafe bool Contains(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0003B3E8 File Offset: 0x000395E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45699, XrefRangeEnd = 45705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0003B438 File Offset: 0x00039638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45705, XrefRangeEnd = 45706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Stack<T>.Enumerator(intPtr);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0003B470 File Offset: 0x00039670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45706, XrefRangeEnd = 45709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0003B4B0 File Offset: 0x000396B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0003B4F0 File Offset: 0x000396F0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 45709, RefRangeEnd = 45722, XrefRangeStart = 45709, XrefRangeEnd = 45709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_Peek_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0003B52C File Offset: 0x0003972C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 45722, RefRangeEnd = 45734, XrefRangeStart = 45722, XrefRangeEnd = 45722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_Pop_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0003B568 File Offset: 0x00039768
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 45734, RefRangeEnd = 45745, XrefRangeStart = 45734, XrefRangeEnd = 45734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_Push_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0003B5E0 File Offset: 0x000397E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45745, XrefRangeEnd = 45757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowForEmptyStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.NativeMethodInfoPtr_ThrowForEmptyStack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00006656 File Offset: 0x00004856
		public Stack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0003B614 File Offset: 0x00039814
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x0000665F File Offset: 0x0000485F
		public unsafe Il2CppArrayBase<T> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__array);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0003B63C File Offset: 0x0003983C
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x0000667E File Offset: 0x0000487E
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0003B664 File Offset: 0x00039864
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00006699 File Offset: 0x00004899
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0003B68C File Offset: 0x0003988C
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x000066B4 File Offset: 0x000048B4
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0003B6BC File Offset: 0x000398BC
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x000066D3 File Offset: 0x000048D3
		public unsafe static int DefaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Stack<T>.NativeFieldInfoPtr_DefaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stack<T>.NativeFieldInfoPtr_DefaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCapacity;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_T_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_T_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_T_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_ThrowForEmptyStack_Private_Void_0;

		// Token: 0x020001AA RID: 426
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x0600185A RID: 6234 RVA: 0x00068E38 File Offset: 0x00067038
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stack<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr);
				Stack<T>.Enumerator.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, "_stack");
				Stack<T>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, "_version");
				Stack<T>.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, "_index");
				Stack<T>.Enumerator.NativeFieldInfoPtr__currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, "_currentElement");
				Stack<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Stack_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100664914);
				Stack<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100664915);
				Stack<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100664916);
				Stack<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100664917);
				Stack<T>.Enumerator.NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100664918);
				Stack<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100664919);
				Stack<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr, 100664920);
			}

			// Token: 0x0600185B RID: 6235 RVA: 0x00068F7C File Offset: 0x0006717C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 45661, RefRangeEnd = 45664, XrefRangeStart = 45661, XrefRangeEnd = 45661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Stack<T> stack)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Stack_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600185C RID: 6236 RVA: 0x00068FCC File Offset: 0x000671CC
			[CallerCount(0)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600185D RID: 6237 RVA: 0x00069004 File Offset: 0x00067204
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007D1 RID: 2001
			// (get) Token: 0x0600185E RID: 6238 RVA: 0x00069048 File Offset: 0x00067248
			public unsafe T Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600185F RID: 6239 RVA: 0x00069088 File Offset: 0x00067288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45664, XrefRangeEnd = 45692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ThrowEnumerationNotStartedOrEnded()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007D2 RID: 2002
			// (get) Token: 0x06001860 RID: 6240 RVA: 0x000690C0 File Offset: 0x000672C0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45692, XrefRangeEnd = 45696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001861 RID: 6241 RVA: 0x00069104 File Offset: 0x00067304
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stack<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001862 RID: 6242 RVA: 0x0000CC29 File Offset: 0x0000AE29
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001863 RID: 6243 RVA: 0x0000CC32 File Offset: 0x0000AE32
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stack<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x06001864 RID: 6244 RVA: 0x0006913C File Offset: 0x0006733C
			// (set) Token: 0x06001865 RID: 6245 RVA: 0x0000CC44 File Offset: 0x0000AE44
			public unsafe Stack<T> _stack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__stack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CE RID: 1998
			// (get) Token: 0x06001866 RID: 6246 RVA: 0x0006916C File Offset: 0x0006736C
			// (set) Token: 0x06001867 RID: 6247 RVA: 0x0000CC63 File Offset: 0x0000AE63
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170007CF RID: 1999
			// (get) Token: 0x06001868 RID: 6248 RVA: 0x00069194 File Offset: 0x00067394
			// (set) Token: 0x06001869 RID: 6249 RVA: 0x0000CC7E File Offset: 0x0000AE7E
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x170007D0 RID: 2000
			// (get) Token: 0x0600186A RID: 6250 RVA: 0x000691BC File Offset: 0x000673BC
			// (set) Token: 0x0600186B RID: 6251 RVA: 0x000691E4 File Offset: 0x000673E4
			public unsafe T _currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__currentElement);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stack<T>.Enumerator.NativeFieldInfoPtr__currentElement);
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

			// Token: 0x0400134A RID: 4938
			private static readonly IntPtr NativeFieldInfoPtr__stack;

			// Token: 0x0400134B RID: 4939
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x0400134C RID: 4940
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x0400134D RID: 4941
			private static readonly IntPtr NativeFieldInfoPtr__currentElement;

			// Token: 0x0400134E RID: 4942
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stack_1_T_0;

			// Token: 0x0400134F RID: 4943
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04001350 RID: 4944
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04001351 RID: 4945
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04001352 RID: 4946
			private static readonly IntPtr NativeMethodInfoPtr_ThrowEnumerationNotStartedOrEnded_Private_Void_0;

			// Token: 0x04001353 RID: 4947
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001354 RID: 4948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
