using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000066 RID: 102
	public class FocusEventBase<T> : EventBase<T> where T : FocusEventBase<T>, new()
	{
		// Token: 0x06000645 RID: 1605 RVA: 0x00020098 File Offset: 0x0001E298
		// Note: this type is marked as 'beforefieldinit'.
		static FocusEventBase()
		{
			Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr);
			FocusEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, "<relatedTarget>k__BackingField");
			FocusEventBase<T>.NativeFieldInfoPtr__direction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, "<direction>k__BackingField");
			FocusEventBase<T>.NativeFieldInfoPtr__focusController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, "<focusController>k__BackingField");
			FocusEventBase<T>.NativeFieldInfoPtr__IsFocusDelegated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, "<IsFocusDelegated>k__BackingField");
			FocusEventBase<T>.NativeMethodInfoPtr_get_relatedTarget_Public_Virtual_Final_New_get_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100663845);
			FocusEventBase<T>.NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100663846);
			FocusEventBase<T>.NativeMethodInfoPtr_set_direction_Private_set_Void_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100663847);
			FocusEventBase<T>.NativeMethodInfoPtr_get_focusController_Protected_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100663848);
			FocusEventBase<T>.NativeMethodInfoPtr_set_focusController_Private_set_Void_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100663849);
			FocusEventBase<T>.NativeMethodInfoPtr_set_IsFocusDelegated_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100663850);
			FocusEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100663851);
			FocusEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100663852);
			FocusEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_Focusable_FocusChangeDirection_FocusController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100663853);
			FocusEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100663854);
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0002021C File Offset: 0x0001E41C
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x0002025C File Offset: 0x0001E45C
		public unsafe virtual Focusable relatedTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_get_relatedTarget_Public_Virtual_Final_New_get_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x00004DFC File Offset: 0x00002FFC
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x000202A0 File Offset: 0x0001E4A0
		public unsafe FocusChangeDirection direction
		{
			get
			{
				return this._direction_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_set_direction_Private_set_Void_FocusChangeDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000202E4 File Offset: 0x0001E4E4
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00020324 File Offset: 0x0001E524
		public unsafe FocusController focusController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_get_focusController_Protected_get_FocusController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_set_focusController_Private_set_Void_FocusController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00004E04 File Offset: 0x00003004
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00020368 File Offset: 0x0001E568
		public unsafe bool IsFocusDelegated
		{
			get
			{
				return this._IsFocusDelegated_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_set_IsFocusDelegated_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000203A8 File Offset: 0x0001E5A8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 93528, RefRangeEnd = 93542, XrefRangeStart = 93528, XrefRangeEnd = 93542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000203E4 File Offset: 0x0001E5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94668, XrefRangeEnd = 94677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00020418 File Offset: 0x0001E618
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 94700, RefRangeEnd = 94704, XrefRangeStart = 94677, XrefRangeEnd = 94700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relatedTarget);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focusController);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsFocusDelegated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_Focusable_FocusChangeDirection_FocusController_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0002049C File Offset: 0x0001E69C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 94709, RefRangeEnd = 94713, XrefRangeStart = 94704, XrefRangeEnd = 94709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00004D7B File Offset: 0x00002F7B
		public FocusEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x000204D8 File Offset: 0x0001E6D8
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00004D84 File Offset: 0x00002F84
		public unsafe Focusable _relatedTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00020508 File Offset: 0x0001E708
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00004DA3 File Offset: 0x00002FA3
		public unsafe FocusChangeDirection _direction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__direction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__direction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00020538 File Offset: 0x0001E738
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00004DC2 File Offset: 0x00002FC2
		public unsafe FocusController _focusController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__focusController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__focusController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00020568 File Offset: 0x0001E768
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x00004DE1 File Offset: 0x00002FE1
		public unsafe bool _IsFocusDelegated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__IsFocusDelegated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__IsFocusDelegated_k__BackingField)) = value;
			}
		}

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr__relatedTarget_k__BackingField;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr__direction_k__BackingField;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr__focusController_k__BackingField;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr__IsFocusDelegated_k__BackingField;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_get_relatedTarget_Public_Virtual_Final_New_get_Focusable_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_Focusable_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Private_set_Void_FocusChangeDirection_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Protected_get_FocusController_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_set_focusController_Private_set_Void_FocusController_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFocusDelegated_Private_set_Void_Boolean_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_Focusable_FocusChangeDirection_FocusController_Boolean_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
