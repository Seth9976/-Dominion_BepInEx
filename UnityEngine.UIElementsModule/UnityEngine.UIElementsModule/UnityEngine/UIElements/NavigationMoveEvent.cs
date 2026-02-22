using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000087 RID: 135
	public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
	{
		// Token: 0x06000749 RID: 1865 RVA: 0x00023CD8 File Offset: 0x00021ED8
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationMoveEvent()
		{
			Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "NavigationMoveEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr);
			NavigationMoveEvent.NativeFieldInfoPtr__direction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, "<direction>k__BackingField");
			NavigationMoveEvent.NativeFieldInfoPtr__move_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, "<move>k__BackingField");
			NavigationMoveEvent.NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100663982);
			NavigationMoveEvent.NativeMethodInfoPtr_set_direction_Private_set_Void_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100663983);
			NavigationMoveEvent.NativeMethodInfoPtr_set_move_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100663984);
			NavigationMoveEvent.NativeMethodInfoPtr_GetPooled_Public_Static_NavigationMoveEvent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100663985);
			NavigationMoveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100663986);
			NavigationMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr, 100663987);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00023DA8 File Offset: 0x00021FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95712, XrefRangeEnd = 95715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NavigationMoveEvent.Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00005240 File Offset: 0x00003440
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00023E04 File Offset: 0x00022004
		public unsafe NavigationMoveEvent.Direction direction
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
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_set_direction_Private_set_Void_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00005248 File Offset: 0x00003448
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00023E44 File Offset: 0x00022044
		public unsafe Vector2 move
		{
			get
			{
				return this._move_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_set_move_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00023E84 File Offset: 0x00022084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95724, RefRangeEnd = 95725, XrefRangeStart = 95715, XrefRangeEnd = 95724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NavigationMoveEvent GetPooled(Vector2 moveVector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveVector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr_GetPooled_Public_Static_NavigationMoveEvent_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationMoveEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00023EC4 File Offset: 0x000220C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95725, XrefRangeEnd = 95729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NavigationMoveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00023F00 File Offset: 0x00022100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95729, XrefRangeEnd = 95732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationMoveEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationMoveEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00005201 File Offset: 0x00003401
		public NavigationMoveEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00023F3C File Offset: 0x0002213C
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x0000520A File Offset: 0x0000340A
		public unsafe NavigationMoveEvent.Direction _direction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationMoveEvent.NativeFieldInfoPtr__direction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationMoveEvent.NativeFieldInfoPtr__direction_k__BackingField)) = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00023F64 File Offset: 0x00022164
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00005225 File Offset: 0x00003425
		public unsafe Vector2 _move_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationMoveEvent.NativeFieldInfoPtr__move_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationMoveEvent.NativeFieldInfoPtr__move_k__BackingField)) = value;
			}
		}

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr__direction_k__BackingField;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr__move_k__BackingField;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Single_Single_Single_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Private_set_Void_Direction_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_set_move_Private_set_Void_Vector2_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_NavigationMoveEvent_Vector2_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000217 RID: 535
		public enum Direction
		{
			// Token: 0x040008BD RID: 2237
			None,
			// Token: 0x040008BE RID: 2238
			Left,
			// Token: 0x040008BF RID: 2239
			Up,
			// Token: 0x040008C0 RID: 2240
			Right,
			// Token: 0x040008C1 RID: 2241
			Down
		}
	}
}
