using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Contracts
{
	// Token: 0x020004BF RID: 1215
	public static class Contract : Object
	{
		// Token: 0x06004794 RID: 18324 RVA: 0x0001B09C File Offset: 0x0001929C
		// Note: this type is marked as 'beforefieldinit'.
		static Contract()
		{
			Il2CppClassPointerStore<Contract>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Contracts", "Contract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract>.NativeClassPtr);
			Contract.NativeMethodInfoPtr_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100673906);
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x00148C18 File Offset: 0x00146E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365958, RefRangeEnd = 365959, XrefRangeStart = 365946, XrefRangeEnd = 365958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.MethodInfoStoreGeneric_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x0001B0D5 File Offset: 0x000192D5
		public Contract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040039FD RID: 14845
		private static readonly IntPtr NativeMethodInfoPtr_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0;

		// Token: 0x0200066C RID: 1644
		private sealed class MethodInfoStoreGeneric_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04004555 RID: 17749
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Contract.NativeMethodInfoPtr_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Contract>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
