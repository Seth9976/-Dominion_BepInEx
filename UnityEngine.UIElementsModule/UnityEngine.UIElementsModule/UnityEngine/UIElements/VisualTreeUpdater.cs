using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004A RID: 74
	public sealed class VisualTreeUpdater : Object
	{
		// Token: 0x060004F7 RID: 1271 RVA: 0x0001B658 File Offset: 0x00019858
		// Note: this type is marked as 'beforefieldinit'.
		static VisualTreeUpdater()
		{
			Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualTreeUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr);
			VisualTreeUpdater.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, "m_Panel");
			VisualTreeUpdater.NativeFieldInfoPtr_m_UpdaterArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, "m_UpdaterArray");
			VisualTreeUpdater.NativeMethodInfoPtr_UpdateVisualTreePhase_Public_Void_VisualTreeUpdatePhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, 100663678);
			VisualTreeUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, 100663679);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001B6D8 File Offset: 0x000198D8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 93510, RefRangeEnd = 93523, XrefRangeStart = 93499, XrefRangeEnd = 93510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisualTreePhase(VisualTreeUpdatePhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.NativeMethodInfoPtr_UpdateVisualTreePhase_Public_Void_VisualTreeUpdatePhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001B718 File Offset: 0x00019918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93526, RefRangeEnd = 93527, XrefRangeStart = 93523, XrefRangeEnd = 93526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionChangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Void_VisualElement_VersionChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00004527 File Offset: 0x00002727
		public VisualTreeUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001B768 File Offset: 0x00019968
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00004530 File Offset: 0x00002730
		public unsafe BaseVisualElementPanel m_Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.NativeFieldInfoPtr_m_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVisualElementPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0001B798 File Offset: 0x00019998
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x0000454F File Offset: 0x0000274F
		public unsafe VisualTreeUpdater.UpdaterArray m_UpdaterArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.NativeFieldInfoPtr_m_UpdaterArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeUpdater.UpdaterArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.NativeFieldInfoPtr_m_UpdaterArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001B7C8 File Offset: 0x000199C8
		public void Dispose()
		{
			for (int i = 0; i < 7; i++)
			{
				IVisualTreeUpdater visualTreeUpdater = this.m_UpdaterArray[i];
				visualTreeUpdater.Dispose();
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001B7FC File Offset: 0x000199FC
		public void UpdateVisualTree()
		{
			for (int i = 0; i < 7; i++)
			{
				IVisualTreeUpdater visualTreeUpdater = this.m_UpdaterArray[i];
				using (visualTreeUpdater.profilerMarker.Auto())
				{
					visualTreeUpdater.Update();
				}
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000456E File Offset: 0x0000276E
		public void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase)
		{
			IVisualTreeUpdater visualTreeUpdater = this.m_UpdaterArray[phase];
			if (visualTreeUpdater != null)
			{
				visualTreeUpdater.Dispose();
			}
			updater.panel = this.m_Panel;
			this.m_UpdaterArray[phase] = updater;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001B864 File Offset: 0x00019A64
		public void SetUpdater<T>(VisualTreeUpdatePhase phase) where T : new()
		{
			IVisualTreeUpdater visualTreeUpdater = this.m_UpdaterArray[phase];
			if (visualTreeUpdater != null)
			{
				visualTreeUpdater.Dispose();
			}
			T t = Activator.CreateInstance<T>();
			t.panel = this.m_Panel;
			T t2 = t;
			this.m_UpdaterArray[phase] = t2;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001B8BC File Offset: 0x00019ABC
		public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
		{
			return this.m_UpdaterArray[phase];
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000045A4 File Offset: 0x000027A4
		public void SetDefaultUpdaters()
		{
			this.SetUpdater<VisualTreeViewDataUpdater>(VisualTreeUpdatePhase.ViewData);
			this.SetUpdater<VisualTreeBindingsUpdater>(VisualTreeUpdatePhase.Bindings);
			this.SetUpdater<VisualElementAnimationSystem>(VisualTreeUpdatePhase.Animation);
			this.SetUpdater<VisualTreeStyleUpdater>(VisualTreeUpdatePhase.Styles);
			this.SetUpdater<UIRLayoutUpdater>(VisualTreeUpdatePhase.Layout);
			this.SetUpdater<VisualTreeTransformClipUpdater>(VisualTreeUpdatePhase.TransformClip);
			this.SetUpdater<UIRRepaintUpdater>(VisualTreeUpdatePhase.Repaint);
		}

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_m_Panel;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdaterArray;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisualTreePhase_Public_Void_VisualTreeUpdatePhase_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Void_VisualElement_VersionChangeType_0;

		// Token: 0x0200020B RID: 523
		public class UpdaterArray : Object
		{
			// Token: 0x0600139B RID: 5019 RVA: 0x0003C10C File Offset: 0x0003A30C
			// Note: this type is marked as 'beforefieldinit'.
			static UpdaterArray()
			{
				Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeUpdater>.NativeClassPtr, "UpdaterArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr);
				VisualTreeUpdater.UpdaterArray.NativeFieldInfoPtr_m_VisualTreeUpdaters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr, "m_VisualTreeUpdaters");
				VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_VisualTreeUpdatePhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr, 100663680);
				VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeUpdater.UpdaterArray>.NativeClassPtr, 100663681);
			}

			// Token: 0x17000617 RID: 1559
			public unsafe IVisualTreeUpdater this[VisualTreeUpdatePhase phase]
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref phase;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_VisualTreeUpdatePhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualTreeUpdater>(intPtr3) : null;
					}
				}
			}

			// Token: 0x17000618 RID: 1560
			public unsafe IVisualTreeUpdater this[int index]
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeUpdater.UpdaterArray.NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualTreeUpdater>(intPtr3) : null;
					}
				}
			}

			// Token: 0x0600139E RID: 5022 RVA: 0x0000C913 File Offset: 0x0000AB13
			public UpdaterArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x0600139F RID: 5023 RVA: 0x0003C20C File Offset: 0x0003A40C
			// (set) Token: 0x060013A0 RID: 5024 RVA: 0x0000C91C File Offset: 0x0000AB1C
			public unsafe Il2CppReferenceArray<IVisualTreeUpdater> m_VisualTreeUpdaters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.UpdaterArray.NativeFieldInfoPtr_m_VisualTreeUpdaters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IVisualTreeUpdater>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeUpdater.UpdaterArray.NativeFieldInfoPtr_m_VisualTreeUpdaters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400089D RID: 2205
			private static readonly IntPtr NativeFieldInfoPtr_m_VisualTreeUpdaters;

			// Token: 0x0400089E RID: 2206
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_VisualTreeUpdatePhase_0;

			// Token: 0x0400089F RID: 2207
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IVisualTreeUpdater_Int32_0;
		}
	}
}
