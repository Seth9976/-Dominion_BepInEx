using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections
{
	// Token: 0x0200001D RID: 29
	public sealed class NativeArray<T> : ValueType where T : new()
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00018944 File Offset: 0x00016B44
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArray()
		{
			Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr);
			NativeArray<T>.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "m_Buffer");
			NativeArray<T>.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "m_Length");
			NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "m_AllocatorLabel");
			NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663315);
			NativeArray<T>.NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663316);
			NativeArray<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663317);
			NativeArray<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663318);
			NativeArray<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663319);
			NativeArray<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663320);
			NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663321);
			NativeArray<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663322);
			NativeArray<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663323);
			NativeArray<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663324);
			NativeArray<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663325);
			NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663326);
			NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663327);
			NativeArray<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663328);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663329);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663330);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663331);
			NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, 100663332);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00018B54 File Offset: 0x00016D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59006, RefRangeEnd = 59007, XrefRangeStart = 59000, XrefRangeEnd = 59006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray(Il2CppArrayBase<T> array, Allocator allocator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00018BB4 File Offset: 0x00016DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59007, XrefRangeEnd = 59014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Allocate(int length, Allocator allocator, out NativeArray<T> array)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new NativeArray<T>(intPtr4));
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00018C18 File Offset: 0x00016E18
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000031 RID: 49
		public unsafe T this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59014, XrefRangeEnd = 59017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59017, XrefRangeEnd = 59020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
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
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00018D34 File Offset: 0x00016F34
		public unsafe bool IsCreated
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 59020, RefRangeEnd = 59030, XrefRangeStart = 59020, XrefRangeEnd = 59020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00018D78 File Offset: 0x00016F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59030, XrefRangeEnd = 59031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00018DB0 File Offset: 0x00016FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59031, XrefRangeEnd = 59037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00018DEC File Offset: 0x00016FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59037, XrefRangeEnd = 59039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<T>.Enumerator(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00018E28 File Offset: 0x00017028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59039, XrefRangeEnd = 59044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00018E6C File Offset: 0x0001706C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59044, XrefRangeEnd = 59050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00018EB0 File Offset: 0x000170B0
		[CallerCount(0)]
		public unsafe bool Equals(NativeArray<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00018F08 File Offset: 0x00017108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59050, XrefRangeEnd = 59057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00018F5C File Offset: 0x0001715C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00018FA0 File Offset: 0x000171A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59057, XrefRangeEnd = 59060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppArrayBase<T> src, NativeArray<T> dst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00018FF0 File Offset: 0x000171F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59060, XrefRangeEnd = 59063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, Il2CppArrayBase<T> dst, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001904C File Offset: 0x0001724C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59063, XrefRangeEnd = 59077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Il2CppArrayBase<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dst));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000190C4 File Offset: 0x000172C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59077, XrefRangeEnd = 59091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(NativeArray<T> src, int srcIndex, Il2CppArrayBase<T> dst, int dstIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(src));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000028D4 File Offset: 0x00000AD4
		public NativeArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000028DD File Offset: 0x00000ADD
		public NativeArray()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0001913C File Offset: 0x0001733C
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000028EF File Offset: 0x00000AEF
		public unsafe void* m_Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Buffer)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00019160 File Offset: 0x00017360
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000290A File Offset: 0x00000B0A
		public unsafe int m_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00019188 File Offset: 0x00017388
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002925 File Offset: 0x00000B25
		public unsafe Allocator m_AllocatorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.NativeFieldInfoPtr_m_AllocatorLabel)) = value;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000191B0 File Offset: 0x000173B0
		public static void CheckAllocateArguments(int length, Allocator allocator, long totalSize)
		{
			bool flag = allocator <= Allocator.None;
			if (flag)
			{
				throw new ArgumentException("Allocator must be Temp, TempJob or Persistent", "allocator");
			}
			bool flag2 = length < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("length", "Length must be >= 0");
			}
			NativeArray<T>.IsUnmanagedAndThrow();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000191F8 File Offset: 0x000173F8
		public static void IsUnmanagedAndThrow()
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsValidNativeContainerElementType<T>();
			if (flag)
			{
				throw new InvalidOperationException(String.Format("{0} used in NativeArray<{1}> must be unmanaged (contain no managed types) and cannot itself be a native container type.", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002940 File Offset: 0x00000B40
		public void CheckElementReadAccess(int index)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002943 File Offset: 0x00000B43
		public void CheckElementWriteAccess(int index)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002946 File Offset: 0x00000B46
		public Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002953 File Offset: 0x00000B53
		public unsafe void CopyFrom(Il2CppArrayBase<T> array)
		{
			NativeArray<T>.Copy(array, *this);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002963 File Offset: 0x00000B63
		public unsafe void CopyFrom(NativeArray<T> array)
		{
			NativeArray<T>.Copy(array, *this);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002973 File Offset: 0x00000B73
		public unsafe void CopyTo(Il2CppArrayBase<T> array)
		{
			NativeArray<T>.Copy(*this, array);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002983 File Offset: 0x00000B83
		public unsafe void CopyTo(NativeArray<T> array)
		{
			NativeArray<T>.Copy(*this, array);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00019238 File Offset: 0x00017438
		public static bool operator ==(NativeArray<T> left, NativeArray<T> right)
		{
			return left.Equals(right);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00019254 File Offset: 0x00017454
		public static bool operator !=(NativeArray<T> left, NativeArray<T> right)
		{
			return !left.Equals(right);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00019274 File Offset: 0x00017474
		public static void CheckCopyLengths(int srcLength, int dstLength)
		{
			bool flag = srcLength != dstLength;
			if (flag)
			{
				throw new ArgumentException("source and destination length must be the same");
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002993 File Offset: 0x00000B93
		public static void Copy(NativeArray<T> src, NativeArray<T> dst)
		{
			NativeArray<T>.Copy(src, 0, dst, 0, src.Length);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000029A7 File Offset: 0x00000BA7
		public static void Copy(NativeArray<T> src, Il2CppArrayBase<T> dst)
		{
			NativeArray<T>.Copy(src, 0, dst, 0, src.Length);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000029BB File Offset: 0x00000BBB
		public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length)
		{
			NativeArray<T>.Copy(src, 0, dst, 0, length);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000029C9 File Offset: 0x00000BC9
		public static void Copy(Il2CppArrayBase<T> src, NativeArray<T> dst, int length)
		{
			NativeArray<T>.Copy(src, 0, dst, 0, length);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00019298 File Offset: 0x00017498
		public static void CheckCopyArguments(int srcLength, int srcIndex, int dstLength, int dstIndex, int length)
		{
			bool flag = length < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("length", "length must be equal or greater than zero.");
			}
			bool flag2 = srcIndex < 0 || srcIndex > srcLength || (srcIndex == srcLength && srcLength > 0);
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("srcIndex", "srcIndex is outside the range of valid indexes for the source NativeArray.");
			}
			bool flag3 = dstIndex < 0 || dstIndex > dstLength || (dstIndex == dstLength && dstLength > 0);
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("dstIndex", "dstIndex is outside the range of valid indexes for the destination NativeArray.");
			}
			bool flag4 = srcIndex + length > srcLength;
			if (flag4)
			{
				throw new ArgumentException("length is greater than the number of elements from srcIndex to the end of the source NativeArray.", "length");
			}
			bool flag5 = srcIndex + length < 0;
			if (flag5)
			{
				throw new ArgumentException("srcIndex + length causes an integer overflow");
			}
			bool flag6 = dstIndex + length > dstLength;
			if (flag6)
			{
				throw new ArgumentException("length is greater than the number of elements from dstIndex to the end of the destination NativeArray.", "length");
			}
			bool flag7 = dstIndex + length < 0;
			if (flag7)
			{
				throw new ArgumentException("dstIndex + length causes an integer overflow");
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000029D7 File Offset: 0x00000BD7
		public unsafe static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
			Unity.Collections.LowLevel.Unsafe.UnsafeUtility.MemCpy((void*)((byte*)dst.m_Buffer + dstIndex * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()), (void*)((byte*)src.m_Buffer + srcIndex * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()), (long)(length * Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()));
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002A05 File Offset: 0x00000C05
		public void CheckReinterpretLoadRange<U>(int sourceIndex) where U : struct
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002A08 File Offset: 0x00000C08
		public void CheckReinterpretStoreRange<U>(int destIndex) where U : struct
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0001937C File Offset: 0x0001757C
		public unsafe U ReinterpretLoad<U>(int sourceIndex) where U : struct
		{
			byte* ptr = (byte*)this.m_Buffer + (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() * (long)sourceIndex;
			return Unity.Collections.LowLevel.Unsafe.UnsafeUtility.ReadArrayElement<U>((void*)ptr, 0);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000193A8 File Offset: 0x000175A8
		public unsafe void ReinterpretStore<U>(int destIndex, U data) where U : struct
		{
			byte* ptr = (byte*)this.m_Buffer + (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() * (long)destIndex;
			Unity.Collections.LowLevel.Unsafe.UnsafeUtility.WriteArrayElement<U>((void*)ptr, 0, data);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000193D4 File Offset: 0x000175D4
		public NativeArray<U> InternalReinterpret<U>(int length) where U : struct
		{
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<U>(this.m_Buffer, length, this.m_AllocatorLabel);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000193FC File Offset: 0x000175FC
		public static void CheckReinterpretSize<U>() where U : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<U>();
			if (flag)
			{
				throw new InvalidOperationException(String.Format("Types {0} and {1} are different sizes - direct reinterpretation is not possible. If this is what you intended, use Reinterpret(<type size>)", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<U>())));
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00019444 File Offset: 0x00017644
		public NativeArray<U> Reinterpret<U>() where U : struct
		{
			return this.InternalReinterpret<U>(this.Length);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00019464 File Offset: 0x00017664
		public void CheckReinterpretSize<U>(long tSize, long uSize, int expectedTypeSize, long byteLen, long uLen)
		{
			bool flag = tSize != (long)expectedTypeSize;
			if (flag)
			{
				throw new InvalidOperationException(String.Format("Type {0} was expected to be {1} but is {2} bytes", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), expectedTypeSize, tSize));
			}
			bool flag2 = uLen * uSize != byteLen;
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("Types {0} (array length {1}) and {2} cannot be aliased due to size constraints. The size of the types and lengths involved must line up.", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), this.Length, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<U>())));
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000194E4 File Offset: 0x000176E4
		public NativeArray<U> Reinterpret<U>(int expectedTypeSize) where U : struct
		{
			long num = (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			long num2 = (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<U>();
			long num3 = (long)this.Length * num;
			long num4 = num3 / num2;
			return this.InternalReinterpret<U>((int)num4);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0001951C File Offset: 0x0001771C
		public void CheckGetSubArrayArguments(int start, int length)
		{
			bool flag = start < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("start", "start must be >= 0");
			}
			bool flag2 = start + length > this.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("length", String.Format("sub array range {0}-{1} is outside the range of the native array 0-{2}", start, start + length - 1, this.Length - 1));
			}
			bool flag3 = start + length < 0;
			if (flag3)
			{
				throw new ArgumentException(String.Format("sub array range {0}-{1} caused an integer overflow and is outside the range of the native array 0-{2}", start, start + length - 1, this.Length - 1));
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000195C0 File Offset: 0x000177C0
		public unsafe NativeArray<T> GetSubArray(int start, int length)
		{
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)((byte*)this.m_Buffer + (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() * (long)start), length, Allocator.Invalid);
		}

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocatorLabel;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_T_Allocator_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Private_Static_Void_Int32_Allocator_byref_NativeArray_1_T_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NativeArray_1_T_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_NativeArray_1_T_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppArrayBase_1_T_Int32_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_NativeArray_1_T_Int32_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x020002FA RID: 762
		public sealed class Enumerator : ValueType
		{
			// Token: 0x060023A5 RID: 9125 RVA: 0x0006AE28 File Offset: 0x00069028
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr);
				NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, "m_Array");
				NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, "m_Index");
				NativeArray<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663333);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663334);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663335);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663336);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663337);
				NativeArray<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr, 100663338);
			}

			// Token: 0x060023A6 RID: 9126 RVA: 0x0006AF30 File Offset: 0x00069130
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 58993, RefRangeEnd = 58996, XrefRangeStart = 58993, XrefRangeEnd = 58993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(ref NativeArray<T> array)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023A7 RID: 9127 RVA: 0x0006AF84 File Offset: 0x00069184
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023A8 RID: 9128 RVA: 0x0006AFBC File Offset: 0x000691BC
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023A9 RID: 9129 RVA: 0x0006B000 File Offset: 0x00069200
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x060023AA RID: 9130 RVA: 0x0006B038 File Offset: 0x00069238
			public unsafe T Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x060023AB RID: 9131 RVA: 0x0006B078 File Offset: 0x00069278
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58996, XrefRangeEnd = 59000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArray<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023AC RID: 9132 RVA: 0x00014FA9 File Offset: 0x000131A9
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060023AD RID: 9133 RVA: 0x00014FB2 File Offset: 0x000131B2
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeArray<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x060023AE RID: 9134 RVA: 0x0006B0BC File Offset: 0x000692BC
			// (set) Token: 0x060023AF RID: 9135 RVA: 0x00014FC4 File Offset: 0x000131C4
			public NativeArray<T> m_Array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array);
					return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0006B0EC File Offset: 0x000692EC
			// (set) Token: 0x060023B1 RID: 9137 RVA: 0x00014FF2 File Offset: 0x000131F2
			public unsafe int m_Index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeArray<T>.Enumerator.NativeFieldInfoPtr_m_Index)) = value;
				}
			}

			// Token: 0x04001C16 RID: 7190
			private static readonly IntPtr NativeFieldInfoPtr_m_Array;

			// Token: 0x04001C17 RID: 7191
			private static readonly IntPtr NativeFieldInfoPtr_m_Index;

			// Token: 0x04001C18 RID: 7192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_T_0;

			// Token: 0x04001C19 RID: 7193
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04001C1A RID: 7194
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C1B RID: 7195
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04001C1C RID: 7196
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04001C1D RID: 7197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
