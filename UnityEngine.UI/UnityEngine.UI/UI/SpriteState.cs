using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x02000037 RID: 55
	[Serializable]
	public sealed class SpriteState : ValueType
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x00022BD0 File Offset: 0x00020DD0
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteState()
		{
			Il2CppClassPointerStore<SpriteState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "SpriteState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteState>.NativeClassPtr);
			SpriteState.NativeFieldInfoPtr_m_HighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, "m_HighlightedSprite");
			SpriteState.NativeFieldInfoPtr_m_PressedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, "m_PressedSprite");
			SpriteState.NativeFieldInfoPtr_m_SelectedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, "m_SelectedSprite");
			SpriteState.NativeFieldInfoPtr_m_DisabledSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, "m_DisabledSprite");
			SpriteState.NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664346);
			SpriteState.NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664347);
			SpriteState.NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664348);
			SpriteState.NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664349);
			SpriteState.NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664350);
			SpriteState.NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664351);
			SpriteState.NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664352);
			SpriteState.NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664353);
			SpriteState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, 100664354);
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00022D04 File Offset: 0x00020F04
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00022D48 File Offset: 0x00020F48
		public unsafe Sprite highlightedSprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00022D90 File Offset: 0x00020F90
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00022DD4 File Offset: 0x00020FD4
		public unsafe Sprite pressedSprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88837, RefRangeEnd = 88838, XrefRangeStart = 88837, XrefRangeEnd = 88838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00022E1C File Offset: 0x0002101C
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00022E60 File Offset: 0x00021060
		public unsafe Sprite selectedSprite
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00022EA8 File Offset: 0x000210A8
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00022EEC File Offset: 0x000210EC
		public unsafe Sprite disabledSprite
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00022F34 File Offset: 0x00021134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118670, XrefRangeEnd = 118683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SpriteState other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpriteState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000047D3 File Offset: 0x000029D3
		public SpriteState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000047DC File Offset: 0x000029DC
		public SpriteState()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteState>.NativeClassPtr))
		{
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00022F8C File Offset: 0x0002118C
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x000047EE File Offset: 0x000029EE
		public unsafe Sprite m_HighlightedSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_HighlightedSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_HighlightedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00022FBC File Offset: 0x000211BC
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0000480D File Offset: 0x00002A0D
		public unsafe Sprite m_PressedSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_PressedSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_PressedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00022FEC File Offset: 0x000211EC
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x0000482C File Offset: 0x00002A2C
		public unsafe Sprite m_SelectedSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_SelectedSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_SelectedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0002301C File Offset: 0x0002121C
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0000484B File Offset: 0x00002A4B
		public unsafe Sprite m_DisabledSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_DisabledSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteState.NativeFieldInfoPtr_m_DisabledSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightedSprite;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeFieldInfoPtr_m_PressedSprite;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedSprite;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeFieldInfoPtr_m_DisabledSprite;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpriteState_0;
	}
}
