using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008B RID: 139
	public class PanelChangedEventBase<T> : EventBase<T> where T : PanelChangedEventBase<T>, new()
	{
		// Token: 0x06000767 RID: 1895 RVA: 0x0002420C File Offset: 0x0002240C
		// Note: this type is marked as 'beforefieldinit'.
		static PanelChangedEventBase()
		{
			Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PanelChangedEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr);
			PanelChangedEventBase<T>.NativeFieldInfoPtr__originPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, "<originPanel>k__BackingField");
			PanelChangedEventBase<T>.NativeFieldInfoPtr__destinationPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, "<destinationPanel>k__BackingField");
			PanelChangedEventBase<T>.NativeMethodInfoPtr_set_originPanel_Private_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100663995);
			PanelChangedEventBase<T>.NativeMethodInfoPtr_set_destinationPanel_Private_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100663996);
			PanelChangedEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100663997);
			PanelChangedEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100663998);
			PanelChangedEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr, 100663999);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00005347 File Offset: 0x00003547
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00024304 File Offset: 0x00022504
		public unsafe IPanel originPanel
		{
			get
			{
				return this._originPanel_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr_set_originPanel_Private_set_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0000534F File Offset: 0x0000354F
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00024348 File Offset: 0x00022548
		public unsafe IPanel destinationPanel
		{
			get
			{
				return this._destinationPanel_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr_set_destinationPanel_Private_set_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0002438C File Offset: 0x0002258C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 93528, RefRangeEnd = 93542, XrefRangeStart = 93528, XrefRangeEnd = 93542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelChangedEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x000243C8 File Offset: 0x000225C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95752, XrefRangeEnd = 95753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000243FC File Offset: 0x000225FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95758, RefRangeEnd = 95760, XrefRangeStart = 95753, XrefRangeEnd = 95758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanelChangedEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelChangedEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangedEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00005300 File Offset: 0x00003500
		public PanelChangedEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00024438 File Offset: 0x00022638
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00005309 File Offset: 0x00003509
		public unsafe IPanel _originPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelChangedEventBase<T>.NativeFieldInfoPtr__originPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelChangedEventBase<T>.NativeFieldInfoPtr__originPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00024468 File Offset: 0x00022668
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00005328 File Offset: 0x00003528
		public unsafe IPanel _destinationPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelChangedEventBase<T>.NativeFieldInfoPtr__destinationPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelChangedEventBase<T>.NativeFieldInfoPtr__destinationPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00024498 File Offset: 0x00022698
		public static T GetPooled(IPanel originPanel, IPanel destinationPanel)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.originPanel = originPanel;
			pooled.destinationPanel = destinationPanel;
			return pooled;
		}

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr__originPanel_k__BackingField;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr__destinationPanel_k__BackingField;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_set_originPanel_Private_set_Void_IPanel_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_set_destinationPanel_Private_set_Void_IPanel_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
