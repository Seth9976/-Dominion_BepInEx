using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000B6 RID: 182
	public sealed class TreeWalkPredicate<T> : MulticastDelegate
	{
		// Token: 0x06000B35 RID: 2869 RVA: 0x0003AF64 File Offset: 0x00039164
		// Note: this type is marked as 'beforefieldinit'.
		static TreeWalkPredicate()
		{
			Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "TreeWalkPredicate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			TreeWalkPredicate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr, 100664899);
			TreeWalkPredicate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr, 100664900);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0003AFF0 File Offset: 0x000391F0
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeWalkPredicate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeWalkPredicate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0003B04C File Offset: 0x0003924C
		[CallerCount(0)]
		public unsafe bool Invoke(SortedSet<T>.Node node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeWalkPredicate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00006626 File Offset: 0x00004826
		public TreeWalkPredicate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0000662F File Offset: 0x0000482F
		public static implicit operator TreeWalkPredicate<T>(Func<SortedSet<T>.Node, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<TreeWalkPredicate<T>>(A_0);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00006637 File Offset: 0x00004837
		public static TreeWalkPredicate<T>operator +(TreeWalkPredicate<T> A_0, TreeWalkPredicate<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<TreeWalkPredicate<T>>();
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00006645 File Offset: 0x00004845
		public static TreeWalkPredicate<T>operator -(TreeWalkPredicate<T> A_0, TreeWalkPredicate<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<TreeWalkPredicate<T>>();
			}
			return delegate2;
		}

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Node_T_0;
	}
}
