using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000088 RID: 136
	public class NavigationTabEvent : NavigationEventBase<NavigationTabEvent>
	{
		// Token: 0x06000757 RID: 1879 RVA: 0x00023F8C File Offset: 0x0002218C
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationTabEvent()
		{
			Il2CppClassPointerStore<NavigationTabEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "NavigationTabEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationTabEvent>.NativeClassPtr);
			NavigationTabEvent.NativeFieldInfoPtr__direction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationTabEvent>.NativeClassPtr, "<direction>k__BackingField");
			NavigationTabEvent.NativeMethodInfoPtr_set_direction_Private_set_Void_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationTabEvent>.NativeClassPtr, 100663988);
			NavigationTabEvent.NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationTabEvent>.NativeClassPtr, 100663989);
			NavigationTabEvent.NativeMethodInfoPtr_GetPooled_Public_Static_NavigationTabEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationTabEvent>.NativeClassPtr, 100663990);
			NavigationTabEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationTabEvent>.NativeClassPtr, 100663991);
			NavigationTabEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationTabEvent>.NativeClassPtr, 100663992);
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00005274 File Offset: 0x00003474
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00024034 File Offset: 0x00022234
		public unsafe NavigationTabEvent.Direction direction
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationTabEvent.NativeMethodInfoPtr_set_direction_Private_set_Void_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00024074 File Offset: 0x00022274
		[CallerCount(0)]
		public unsafe static NavigationTabEvent.Direction DetermineMoveDirection(int moveValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationTabEvent.NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000240B4 File Offset: 0x000222B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95739, RefRangeEnd = 95740, XrefRangeStart = 95732, XrefRangeEnd = 95739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NavigationTabEvent GetPooled(int moveValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationTabEvent.NativeMethodInfoPtr_GetPooled_Public_Static_NavigationTabEvent_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationTabEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000240F4 File Offset: 0x000222F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95740, XrefRangeEnd = 95743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NavigationTabEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00024130 File Offset: 0x00022330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95743, XrefRangeEnd = 95746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationTabEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationTabEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationTabEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00005250 File Offset: 0x00003450
		public NavigationTabEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x0002416C File Offset: 0x0002236C
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00005259 File Offset: 0x00003459
		public unsafe NavigationTabEvent.Direction _direction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationTabEvent.NativeFieldInfoPtr__direction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationTabEvent.NativeFieldInfoPtr__direction_k__BackingField)) = value;
			}
		}

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr__direction_k__BackingField;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Private_set_Void_Direction_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Int32_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_NavigationTabEvent_Int32_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000218 RID: 536
		public enum Direction
		{
			// Token: 0x040008C3 RID: 2243
			None,
			// Token: 0x040008C4 RID: 2244
			Next,
			// Token: 0x040008C5 RID: 2245
			Previous
		}
	}
}
