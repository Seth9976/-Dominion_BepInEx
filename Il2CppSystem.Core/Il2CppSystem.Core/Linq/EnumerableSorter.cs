using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200000D RID: 13
	public class EnumerableSorter<TElement> : Object
	{
		// Token: 0x06000098 RID: 152 RVA: 0x000057B4 File Offset: 0x000039B4
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerableSorter()
		{
			Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "EnumerableSorter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr);
			EnumerableSorter<TElement>.NativeMethodInfoPtr_ComputeKeys_Internal_Abstract_Virtual_New_Void_Il2CppArrayBase_1_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr, 100663477);
			EnumerableSorter<TElement>.NativeMethodInfoPtr_CompareKeys_Internal_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr, 100663478);
			EnumerableSorter<TElement>.NativeMethodInfoPtr_Sort_Internal_Il2CppStructArray_1_Int32_Il2CppArrayBase_1_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr, 100663479);
			EnumerableSorter<TElement>.NativeMethodInfoPtr_QuickSort_Private_Void_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr, 100663480);
			EnumerableSorter<TElement>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr, 100663481);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00005884 File Offset: 0x00003A84
		[CallerCount(0)]
		public unsafe virtual void ComputeKeys(Il2CppArrayBase<TElement> elements, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumerableSorter<TElement>.NativeMethodInfoPtr_ComputeKeys_Internal_Abstract_Virtual_New_Void_Il2CppArrayBase_1_TElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000058E0 File Offset: 0x00003AE0
		[CallerCount(0)]
		public unsafe virtual int CompareKeys(int index1, int index2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumerableSorter<TElement>.NativeMethodInfoPtr_CompareKeys_Internal_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005944 File Offset: 0x00003B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58516, XrefRangeEnd = 58519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> Sort(Il2CppArrayBase<TElement> elements, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableSorter<TElement>.NativeMethodInfoPtr_Sort_Internal_Il2CppStructArray_1_Int32_Il2CppArrayBase_1_TElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000059A4 File Offset: 0x00003BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58519, XrefRangeEnd = 58521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuickSort(Il2CppStructArray<int> map, int left, int right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableSorter<TElement>.NativeMethodInfoPtr_QuickSort_Private_Void_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005A04 File Offset: 0x00003C04
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumerableSorter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableSorter<TElement>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000022CF File Offset: 0x000004CF
		public EnumerableSorter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_ComputeKeys_Internal_Abstract_Virtual_New_Void_Il2CppArrayBase_1_TElement_Int32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_CompareKeys_Internal_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Internal_Il2CppStructArray_1_Int32_Il2CppArrayBase_1_TElement_Int32_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Private_Void_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
