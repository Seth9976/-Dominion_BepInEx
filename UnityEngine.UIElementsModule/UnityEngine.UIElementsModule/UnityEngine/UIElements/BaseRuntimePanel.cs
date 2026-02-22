using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000022 RID: 34
	public class BaseRuntimePanel : Panel
	{
		// Token: 0x06000242 RID: 578 RVA: 0x000132F0 File Offset: 0x000114F0
		// Note: this type is marked as 'beforefieldinit'.
		static BaseRuntimePanel()
		{
			Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseRuntimePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr);
			BaseRuntimePanel.NativeFieldInfoPtr_m_SelectableGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "m_SelectableGameObject");
			BaseRuntimePanel.NativeFieldInfoPtr_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "destroyed");
			BaseRuntimePanel.NativeFieldInfoPtr_m_StandardWorldSpaceShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "m_StandardWorldSpaceShader");
			BaseRuntimePanel.NativeFieldInfoPtr_m_DrawToCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "m_DrawToCameras");
			BaseRuntimePanel.NativeFieldInfoPtr_targetTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "targetTexture");
			BaseRuntimePanel.NativeFieldInfoPtr_panelToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "panelToWorld");
			BaseRuntimePanel.NativeFieldInfoPtr__targetDisplay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "<targetDisplay>k__BackingField");
			BaseRuntimePanel.NativeFieldInfoPtr_DefaultScreenToPanelSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "DefaultScreenToPanelSpace");
			BaseRuntimePanel.NativeFieldInfoPtr_m_ScreenToPanelSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "m_ScreenToPanelSpace");
			BaseRuntimePanel.NativeMethodInfoPtr_get_selectableGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100663472);
			BaseRuntimePanel.NativeMethodInfoPtr_set_selectableGameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100663473);
			BaseRuntimePanel.NativeMethodInfoPtr_add_destroyed_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100663474);
			BaseRuntimePanel.NativeMethodInfoPtr_remove_destroyed_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100663475);
			BaseRuntimePanel.NativeMethodInfoPtr_get_drawToCameras_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100663476);
			BaseRuntimePanel.NativeMethodInfoPtr_get_targetDisplay_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100663477);
			BaseRuntimePanel.NativeMethodInfoPtr_get_screenToPanelSpace_Public_get_Func_2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100663478);
			BaseRuntimePanel.NativeMethodInfoPtr_ScreenToPanel_Internal_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100663479);
			BaseRuntimePanel.NativeMethodInfoPtr_ScreenToPanel_Internal_Boolean_Vector2_Vector2_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100663480);
			BaseRuntimePanel.NativeMethodInfoPtr_AssignPanelToComponents_Private_Void_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100663481);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0001349C File Offset: 0x0001169C
		// (set) Token: 0x06000244 RID: 580 RVA: 0x000134DC File Offset: 0x000116DC
		public unsafe GameObject selectableGameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_selectableGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 92071, RefRangeEnd = 92073, XrefRangeStart = 92065, XrefRangeEnd = 92071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_set_selectableGameObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00013520 File Offset: 0x00011720
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 92077, RefRangeEnd = 92083, XrefRangeStart = 92073, XrefRangeEnd = 92077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_destroyed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_add_destroyed_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00013564 File Offset: 0x00011764
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 92087, RefRangeEnd = 92091, XrefRangeStart = 92083, XrefRangeEnd = 92087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_destroyed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_remove_destroyed_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000135A8 File Offset: 0x000117A8
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0001393C File Offset: 0x00011B3C
		public unsafe bool drawToCameras
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 92091, RefRangeEnd = 92092, XrefRangeStart = 92091, XrefRangeEnd = 92091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_drawToCameras_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = this.m_DrawToCameras != value;
				if (flag)
				{
					this.m_DrawToCameras = value;
					UIRRepaintUpdater uirrepaintUpdater = this.GetUpdater(VisualTreeUpdatePhase.Repaint).TryCast<UIRRepaintUpdater>();
					if (uirrepaintUpdater != null)
					{
						uirrepaintUpdater.DestroyRenderChain();
					}
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000135E4 File Offset: 0x000117E4
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00003375 File Offset: 0x00001575
		public unsafe int targetDisplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_targetDisplay_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._targetDisplay_k__BackingField = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00013620 File Offset: 0x00011820
		public unsafe Func<Vector2, Vector2> screenToPanelSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_screenToPanelSpace_Public_get_Func_2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Vector2, Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00013660 File Offset: 0x00011860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92095, RefRangeEnd = 92097, XrefRangeStart = 92092, XrefRangeEnd = 92095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ScreenToPanel(Vector2 screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_ScreenToPanel_Internal_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000136AC File Offset: 0x000118AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92102, RefRangeEnd = 92104, XrefRangeStart = 92097, XrefRangeEnd = 92102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &panelPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &panelDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_ScreenToPanel_Internal_Boolean_Vector2_Vector2_byref_Vector2_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00013720 File Offset: 0x00011920
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92139, RefRangeEnd = 92141, XrefRangeStart = 92104, XrefRangeEnd = 92139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignPanelToComponents(BaseRuntimePanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_AssignPanelToComponents_Private_Void_BaseRuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00003261 File Offset: 0x00001461
		public BaseRuntimePanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00013764 File Offset: 0x00011964
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0000326A File Offset: 0x0000146A
		public unsafe GameObject m_SelectableGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_SelectableGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_SelectableGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00013794 File Offset: 0x00011994
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00003289 File Offset: 0x00001489
		public unsafe Action destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_destroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_destroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000137C4 File Offset: 0x000119C4
		// (set) Token: 0x06000253 RID: 595 RVA: 0x000032A8 File Offset: 0x000014A8
		public unsafe Shader m_StandardWorldSpaceShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_StandardWorldSpaceShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_StandardWorldSpaceShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000137F4 File Offset: 0x000119F4
		// (set) Token: 0x06000255 RID: 597 RVA: 0x000032C7 File Offset: 0x000014C7
		public unsafe bool m_DrawToCameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_DrawToCameras);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_DrawToCameras)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0001381C File Offset: 0x00011A1C
		// (set) Token: 0x06000257 RID: 599 RVA: 0x000032E2 File Offset: 0x000014E2
		public unsafe RenderTexture targetTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_targetTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_targetTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0001384C File Offset: 0x00011A4C
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00003301 File Offset: 0x00001501
		public unsafe Matrix4x4 panelToWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_panelToWorld);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_panelToWorld)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00013874 File Offset: 0x00011A74
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0000331C File Offset: 0x0000151C
		public unsafe int _targetDisplay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr__targetDisplay_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr__targetDisplay_k__BackingField)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0001389C File Offset: 0x00011A9C
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00003337 File Offset: 0x00001537
		public unsafe static Func<Vector2, Vector2> DefaultScreenToPanelSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseRuntimePanel.NativeFieldInfoPtr_DefaultScreenToPanelSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseRuntimePanel.NativeFieldInfoPtr_DefaultScreenToPanelSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000138C4 File Offset: 0x00011AC4
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00003349 File Offset: 0x00001549
		public unsafe Func<Vector2, Vector2> m_ScreenToPanelSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_ScreenToPanelSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_ScreenToPanelSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00003368 File Offset: 0x00001568
		public override void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000261 RID: 609 RVA: 0x000138F4 File Offset: 0x00011AF4
		// (set) Token: 0x06000262 RID: 610 RVA: 0x0001390C File Offset: 0x00011B0C
		public override Shader standardWorldSpaceShader
		{
			get
			{
				return this.m_StandardWorldSpaceShader;
			}
			set
			{
				bool flag = this.m_StandardWorldSpaceShader != value;
				if (flag)
				{
					this.m_StandardWorldSpaceShader = value;
					base.InvokeStandardWorldSpaceShaderChanged();
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000337E File Offset: 0x0000157E
		public int screenRenderingWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000338B File Offset: 0x0000158B
		public int screenRenderingHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0001397C File Offset: 0x00011B7C
		public override void Repaint(Event e)
		{
			bool flag = this.targetTexture == null;
			if (flag)
			{
				RenderTexture active = RenderTexture.active;
				int num = ((active != null) ? active.width : this.screenRenderingWidth);
				int num2 = ((active != null) ? active.height : this.screenRenderingHeight);
				GL.Viewport(new Rect(0f, 0f, (float)num, (float)num2));
				base.Repaint(e);
			}
			else
			{
				RenderTexture active2 = RenderTexture.active;
				RenderTexture.active = this.targetTexture;
				GL.Viewport(new Rect(0f, 0f, (float)this.targetTexture.width, (float)this.targetTexture.height));
				base.Repaint(e);
				RenderTexture.active = active2;
			}
		}

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectableGameObject;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_destroyed;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_m_StandardWorldSpaceShader;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawToCameras;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_targetTexture;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_panelToWorld;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr__targetDisplay_k__BackingField;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_DefaultScreenToPanelSpace;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenToPanelSpace;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_get_selectableGameObject_Public_get_GameObject_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_set_selectableGameObject_Public_set_Void_GameObject_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_add_destroyed_Public_add_Void_Action_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_remove_destroyed_Public_rem_Void_Action_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_get_drawToCameras_Internal_get_Boolean_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_get_targetDisplay_Internal_get_Int32_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_get_screenToPanelSpace_Public_get_Func_2_Vector2_Vector2_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToPanel_Internal_Vector2_Vector2_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToPanel_Internal_Boolean_Vector2_Vector2_byref_Vector2_byref_Vector2_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_AssignPanelToComponents_Private_Void_BaseRuntimePanel_0;

		// Token: 0x020001EF RID: 495
		[ObfuscatedName("UnityEngine.UIElements.BaseRuntimePanel+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600134F RID: 4943 RVA: 0x0003B0B4 File Offset: 0x000392B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr);
				BaseRuntimePanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr, "<>9");
				BaseRuntimePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr, 100663484);
				BaseRuntimePanel.__c.NativeMethodInfoPtr___cctor_b__36_0_Internal_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr, 100663485);
			}

			// Token: 0x06001350 RID: 4944 RVA: 0x0003B11C File Offset: 0x0003931C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001351 RID: 4945 RVA: 0x0003B158 File Offset: 0x00039358
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23543, RefRangeEnd = 23544, XrefRangeStart = 23543, XrefRangeEnd = 23544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 __cctor_b__36_0(Vector2 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.__c.NativeMethodInfoPtr___cctor_b__36_0_Internal_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001352 RID: 4946 RVA: 0x0000C74D File Offset: 0x0000A94D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x06001353 RID: 4947 RVA: 0x0003B1A4 File Offset: 0x000393A4
			// (set) Token: 0x06001354 RID: 4948 RVA: 0x0000C756 File Offset: 0x0000A956
			public unsafe static BaseRuntimePanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BaseRuntimePanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BaseRuntimePanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000868 RID: 2152
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000869 RID: 2153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400086A RID: 2154
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__36_0_Internal_Vector2_Vector2_0;
		}

		// Token: 0x020001F0 RID: 496
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
