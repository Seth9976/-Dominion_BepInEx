using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public sealed class CanvasGroup : Behaviour
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000023E8 File Offset: 0x000005E8
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasGroup()
		{
			Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "CanvasGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr);
			CanvasGroup.NativeMethodInfoPtr_get_alpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663298);
			CanvasGroup.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663299);
			CanvasGroup.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663300);
			CanvasGroup.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663301);
			CanvasGroup.NativeMethodInfoPtr_get_blocksRaycasts_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663302);
			CanvasGroup.NativeMethodInfoPtr_set_blocksRaycasts_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663303);
			CanvasGroup.NativeMethodInfoPtr_get_ignoreParentGroups_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663304);
			CanvasGroup.NativeMethodInfoPtr_set_ignoreParentGroups_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663305);
			CanvasGroup.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroup>.NativeClassPtr, 100663306);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000024CC File Offset: 0x000006CC
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002508 File Offset: 0x00000708
		public unsafe float alpha
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 97374, RefRangeEnd = 97378, XrefRangeStart = 97372, XrefRangeEnd = 97374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_get_alpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 97380, RefRangeEnd = 97384, XrefRangeStart = 97378, XrefRangeEnd = 97380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002548 File Offset: 0x00000748
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002584 File Offset: 0x00000784
		public unsafe bool interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97386, RefRangeEnd = 97387, XrefRangeStart = 97384, XrefRangeEnd = 97386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97389, RefRangeEnd = 97390, XrefRangeStart = 97387, XrefRangeEnd = 97389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000025C4 File Offset: 0x000007C4
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002600 File Offset: 0x00000800
		public unsafe bool blocksRaycasts
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97390, XrefRangeEnd = 97392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_get_blocksRaycasts_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 97394, RefRangeEnd = 97396, XrefRangeStart = 97392, XrefRangeEnd = 97394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_set_blocksRaycasts_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002640 File Offset: 0x00000840
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000267C File Offset: 0x0000087C
		public unsafe bool ignoreParentGroups
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 97398, RefRangeEnd = 97400, XrefRangeStart = 97396, XrefRangeEnd = 97398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_get_ignoreParentGroups_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 97402, RefRangeEnd = 97404, XrefRangeStart = 97400, XrefRangeEnd = 97402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_set_ignoreParentGroups_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000026BC File Offset: 0x000008BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroup.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002088 File Offset: 0x00000288
		public CanvasGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_get_alpha_Public_get_Single_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_blocksRaycasts_Public_get_Boolean_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_set_blocksRaycasts_Public_set_Void_Boolean_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreParentGroups_Public_get_Boolean_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreParentGroups_Public_set_Void_Boolean_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0;
	}
}
