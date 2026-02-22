using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000B3 RID: 179
	[Serializable]
	public sealed class TreeSet<T> : SortedSet<T>
	{
		// Token: 0x06000AE6 RID: 2790 RVA: 0x00039A88 File Offset: 0x00037C88
		// Note: this type is marked as 'beforefieldinit'.
		static TreeSet()
		{
			Il2CppClassPointerStore<TreeSet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "TreeSet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeSet<T>>.NativeClassPtr);
			TreeSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeSet<T>>.NativeClassPtr, 100664819);
			TreeSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeSet<T>>.NativeClassPtr, 100664820);
			TreeSet<T>.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeSet<T>>.NativeClassPtr, 100664821);
			TreeSet<T>.NativeMethodInfoPtr_AddIfNotPresent_Internal_Virtual_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeSet<T>>.NativeClassPtr, 100664822);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00039B44 File Offset: 0x00037D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45328, RefRangeEnd = 45330, XrefRangeStart = 45325, XrefRangeEnd = 45328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00039B80 File Offset: 0x00037D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45330, XrefRangeEnd = 45331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeSet(IComparer<T> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeSet<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00039BCC File Offset: 0x00037DCC
		[CallerCount(0)]
		public unsafe TreeSet(SerializationInfo siInfo, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(siInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeSet<T>.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00039C30 File Offset: 0x00037E30
		[CallerCount(0)]
		public unsafe override bool AddIfNotPresent(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TreeSet<T>.NativeMethodInfoPtr_AddIfNotPresent_Internal_Virtual_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0000646A File Offset: 0x0000466A
		public TreeSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_AddIfNotPresent_Internal_Virtual_Boolean_T_0;
	}
}
