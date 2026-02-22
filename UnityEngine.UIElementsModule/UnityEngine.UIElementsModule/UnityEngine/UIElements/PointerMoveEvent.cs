using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000097 RID: 151
	public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
	{
		// Token: 0x0600083C RID: 2108 RVA: 0x00027458 File Offset: 0x00025658
		// Note: this type is marked as 'beforefieldinit'.
		static PointerMoveEvent()
		{
			Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerMoveEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr);
			PointerMoveEvent.NativeFieldInfoPtr__isHandledByDraggable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, "<isHandledByDraggable>k__BackingField");
			PointerMoveEvent.NativeMethodInfoPtr_set_isHandledByDraggable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100664100);
			PointerMoveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100664101);
			PointerMoveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100664102);
			PointerMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100664103);
			PointerMoveEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr, 100664104);
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0000577C File Offset: 0x0000397C
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x00027500 File Offset: 0x00025700
		public unsafe bool isHandledByDraggable
		{
			get
			{
				return this._isHandledByDraggable_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr_set_isHandledByDraggable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00027540 File Offset: 0x00025740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96311, XrefRangeEnd = 96317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00027574 File Offset: 0x00025774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96317, XrefRangeEnd = 96320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000275A8 File Offset: 0x000257A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96320, XrefRangeEnd = 96326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerMoveEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerMoveEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000275E4 File Offset: 0x000257E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96326, XrefRangeEnd = 96367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerMoveEvent.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00005758 File Offset: 0x00003958
		public PointerMoveEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00027628 File Offset: 0x00025828
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00005761 File Offset: 0x00003961
		public unsafe bool _isHandledByDraggable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerMoveEvent.NativeFieldInfoPtr__isHandledByDraggable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerMoveEvent.NativeFieldInfoPtr__isHandledByDraggable_k__BackingField)) = value;
			}
		}

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr__isHandledByDraggable_k__BackingField;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_set_isHandledByDraggable_Internal_set_Void_Boolean_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;
	}
}
