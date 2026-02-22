using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class AscensionAnimationLocatorSorted : AscensionAnimationLocator
{
	// Token: 0x060001AE RID: 430 RVA: 0x0001FBDC File Offset: 0x0001DDDC
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionAnimationLocatorSorted()
	{
		Il2CppClassPointerStore<AscensionAnimationLocatorSorted>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionAnimationLocatorSorted");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionAnimationLocatorSorted>.NativeClassPtr);
		AscensionAnimationLocatorSorted.NativeFieldInfoPtr_m_SortCompareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorSorted>.NativeClassPtr, "m_SortCompareFunction");
		AscensionAnimationLocatorSorted.NativeMethodInfoPtr_SetSortCompareFunction_Public_Void_SortCompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorSorted>.NativeClassPtr, 100663438);
		AscensionAnimationLocatorSorted.NativeMethodInfoPtr_CalculateInsertSiblingIndex_Private_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorSorted>.NativeClassPtr, 100663439);
		AscensionAnimationLocatorSorted.NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorSorted>.NativeClassPtr, 100663440);
		AscensionAnimationLocatorSorted.NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_Void_AnimateObject_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorSorted>.NativeClassPtr, 100663441);
		AscensionAnimationLocatorSorted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorSorted>.NativeClassPtr, 100663442);
	}

	// Token: 0x060001AF RID: 431 RVA: 0x0001FC84 File Offset: 0x0001DE84
	[CallerCount(0)]
	public unsafe void SetSortCompareFunction(AscensionAnimationLocatorSorted.SortCompareFunction func)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorSorted.NativeMethodInfoPtr_SetSortCompareFunction_Public_Void_SortCompareFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225179, RefRangeEnd = 225180, XrefRangeStart = 225172, XrefRangeEnd = 225179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CalculateInsertSiblingIndex(GameObject insert)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(insert);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorSorted.NativeMethodInfoPtr_CalculateInsertSiblingIndex_Private_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0001FD18 File Offset: 0x0001DF18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225180, XrefRangeEnd = 225194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetPlaceholderParent(GameObject placeholder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(placeholder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionAnimationLocatorSorted.NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x0001FD68 File Offset: 0x0001DF68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225194, XrefRangeEnd = 225198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PlaceAnimateObject(AnimateObject animate_object, bool bSetPosition = false, bool bSetRotation = false, bool bIgnoreOverride = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSetPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSetRotation;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIgnoreOverride;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionAnimationLocatorSorted.NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_Void_AnimateObject_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x0001FDE0 File Offset: 0x0001DFE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocatorSorted()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionAnimationLocatorSorted>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorSorted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00002EB8 File Offset: 0x000010B8
	public AscensionAnimationLocatorSorted(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x060001B5 RID: 437 RVA: 0x0001FE1C File Offset: 0x0001E01C
	// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002EC1 File Offset: 0x000010C1
	public unsafe AscensionAnimationLocatorSorted.SortCompareFunction m_SortCompareFunction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorSorted.NativeFieldInfoPtr_m_SortCompareFunction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocatorSorted.SortCompareFunction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorSorted.NativeFieldInfoPtr_m_SortCompareFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000112 RID: 274
	private static readonly IntPtr NativeFieldInfoPtr_m_SortCompareFunction;

	// Token: 0x04000113 RID: 275
	private static readonly IntPtr NativeMethodInfoPtr_SetSortCompareFunction_Public_Void_SortCompareFunction_0;

	// Token: 0x04000114 RID: 276
	private static readonly IntPtr NativeMethodInfoPtr_CalculateInsertSiblingIndex_Private_Int32_GameObject_0;

	// Token: 0x04000115 RID: 277
	private static readonly IntPtr NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_Void_GameObject_0;

	// Token: 0x04000116 RID: 278
	private static readonly IntPtr NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_Void_AnimateObject_Boolean_Boolean_Boolean_0;

	// Token: 0x04000117 RID: 279
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000168 RID: 360
	public sealed class SortCompareFunction : MulticastDelegate
	{
		// Token: 0x060022A7 RID: 8871 RVA: 0x00082104 File Offset: 0x00080304
		// Note: this type is marked as 'beforefieldinit'.
		static SortCompareFunction()
		{
			Il2CppClassPointerStore<AscensionAnimationLocatorSorted.SortCompareFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionAnimationLocatorSorted>.NativeClassPtr, "SortCompareFunction");
			AscensionAnimationLocatorSorted.SortCompareFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorSorted.SortCompareFunction>.NativeClassPtr, 100666025);
			AscensionAnimationLocatorSorted.SortCompareFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorSorted.SortCompareFunction>.NativeClassPtr, 100666026);
			AscensionAnimationLocatorSorted.SortCompareFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Transform_Transform_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorSorted.SortCompareFunction>.NativeClassPtr, 100666027);
			AscensionAnimationLocatorSorted.SortCompareFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorSorted.SortCompareFunction>.NativeClassPtr, 100666028);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x00082178 File Offset: 0x00080378
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortCompareFunction(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionAnimationLocatorSorted.SortCompareFunction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorSorted.SortCompareFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000821D4 File Offset: 0x000803D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 225167, RefRangeEnd = 225172, XrefRangeStart = 225167, XrefRangeEnd = 225167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Invoke(Transform a, Transform b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorSorted.SortCompareFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00082234 File Offset: 0x00080434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Transform a, Transform b, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorSorted.SortCompareFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Transform_Transform_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x000822BC File Offset: 0x000804BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43352, RefRangeEnd = 43355, XrefRangeStart = 43352, XrefRangeEnd = 43355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorSorted.SortCompareFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00015D21 File Offset: 0x00013F21
		public SortCompareFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00015D2A File Offset: 0x00013F2A
		public static implicit operator AscensionAnimationLocatorSorted.SortCompareFunction(Func<Transform, Transform, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<AscensionAnimationLocatorSorted.SortCompareFunction>(A_0);
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00015D32 File Offset: 0x00013F32
		public static AscensionAnimationLocatorSorted.SortCompareFunction operator +(AscensionAnimationLocatorSorted.SortCompareFunction A_0, AscensionAnimationLocatorSorted.SortCompareFunction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AscensionAnimationLocatorSorted.SortCompareFunction>();
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00015D40 File Offset: 0x00013F40
		public static AscensionAnimationLocatorSorted.SortCompareFunction operator -(AscensionAnimationLocatorSorted.SortCompareFunction A_0, AscensionAnimationLocatorSorted.SortCompareFunction A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AscensionAnimationLocatorSorted.SortCompareFunction>();
			}
			return delegate2;
		}

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Transform_Transform_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Transform_Transform_AsyncCallback_Object_0;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
	}
}
