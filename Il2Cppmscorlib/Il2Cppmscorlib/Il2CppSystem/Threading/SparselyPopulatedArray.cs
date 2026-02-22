using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025B RID: 603
	public class SparselyPopulatedArray<T> : Object where T : class
	{
		// Token: 0x060029F4 RID: 10740 RVA: 0x000D93A0 File Offset: 0x000D75A0
		// Note: this type is marked as 'beforefieldinit'.
		static SparselyPopulatedArray()
		{
			Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr);
			SparselyPopulatedArray<T>.NativeFieldInfoPtr_m_tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, "m_tail");
			SparselyPopulatedArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100669978);
			SparselyPopulatedArray<T>.NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100669979);
			SparselyPopulatedArray<T>.NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100669980);
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000D945C File Offset: 0x000D765C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330537, RefRangeEnd = 330538, XrefRangeStart = 330533, XrefRangeEnd = 330537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArray(int initialSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x000D94A4 File Offset: 0x000D76A4
		public unsafe SparselyPopulatedArrayFragment<T> Tail
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 330539, RefRangeEnd = 330541, XrefRangeStart = 330538, XrefRangeEnd = 330539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArray<T>.NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000D94E4 File Offset: 0x000D76E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330564, RefRangeEnd = 330565, XrefRangeStart = 330541, XrefRangeEnd = 330564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayAddInfo<T> Add(T element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = element;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArray<T>.NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return new SparselyPopulatedArrayAddInfo<T>(intPtr2);
			}
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x0000EA20 File Offset: 0x0000CC20
		public SparselyPopulatedArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000D9564 File Offset: 0x000D7764
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x0000EA29 File Offset: 0x0000CC29
		public unsafe SparselyPopulatedArrayFragment<T> m_tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArray<T>.NativeFieldInfoPtr_m_tail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArray<T>.NativeFieldInfoPtr_m_tail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024DD RID: 9437
		private static readonly IntPtr NativeFieldInfoPtr_m_tail;

		// Token: 0x040024DE RID: 9438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040024DF RID: 9439
		private static readonly IntPtr NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x040024E0 RID: 9440
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0;
	}
}
