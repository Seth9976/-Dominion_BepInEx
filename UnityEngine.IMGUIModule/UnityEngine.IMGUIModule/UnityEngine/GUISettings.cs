using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public sealed class GUISettings : Object
	{
		// Token: 0x060002BD RID: 701 RVA: 0x0000C054 File Offset: 0x0000A254
		// Note: this type is marked as 'beforefieldinit'.
		static GUISettings()
		{
			Il2CppClassPointerStore<GUISettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUISettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUISettings>.NativeClassPtr);
			GUISettings.NativeFieldInfoPtr_m_DoubleClickSelectsWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_DoubleClickSelectsWord");
			GUISettings.NativeFieldInfoPtr_m_TripleClickSelectsLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_TripleClickSelectsLine");
			GUISettings.NativeFieldInfoPtr_m_CursorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_CursorColor");
			GUISettings.NativeFieldInfoPtr_m_CursorFlashSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_CursorFlashSpeed");
			GUISettings.NativeFieldInfoPtr_m_SelectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_SelectionColor");
			GUISettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, 100663485);
			GUISettings.Internal_GetCursorFlashSpeedDelegateField = IL2CPP.ResolveICall<GUISettings.Internal_GetCursorFlashSpeedDelegate>("UnityEngine.GUISettings::Internal_GetCursorFlashSpeed");
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000C10C File Offset: 0x0000A30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86572, XrefRangeEnd = 86575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUISettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUISettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000030E6 File Offset: 0x000012E6
		public GUISettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000C148 File Offset: 0x0000A348
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x000030EF File Offset: 0x000012EF
		public unsafe bool m_DoubleClickSelectsWord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_DoubleClickSelectsWord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_DoubleClickSelectsWord)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000C170 File Offset: 0x0000A370
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0000310A File Offset: 0x0000130A
		public unsafe bool m_TripleClickSelectsLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_TripleClickSelectsLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_TripleClickSelectsLine)) = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000C198 File Offset: 0x0000A398
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00003125 File Offset: 0x00001325
		public unsafe Color m_CursorColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorColor)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000C1C0 File Offset: 0x0000A3C0
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00003140 File Offset: 0x00001340
		public unsafe float m_CursorFlashSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorFlashSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorFlashSpeed)) = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000C1E8 File Offset: 0x0000A3E8
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0000315B File Offset: 0x0000135B
		public unsafe Color m_SelectionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_SelectionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_SelectionColor)) = value;
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003176 File Offset: 0x00001376
		public static float Internal_GetCursorFlashSpeed()
		{
			return GUISettings.Internal_GetCursorFlashSpeedDelegateField();
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000C210 File Offset: 0x0000A410
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00003182 File Offset: 0x00001382
		public bool doubleClickSelectsWord
		{
			get
			{
				return this.m_DoubleClickSelectsWord;
			}
			set
			{
				this.m_DoubleClickSelectsWord = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000C228 File Offset: 0x0000A428
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0000318C File Offset: 0x0000138C
		public bool tripleClickSelectsLine
		{
			get
			{
				return this.m_TripleClickSelectsLine;
			}
			set
			{
				this.m_TripleClickSelectsLine = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000C240 File Offset: 0x0000A440
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00003196 File Offset: 0x00001396
		public Color cursorColor
		{
			get
			{
				return this.m_CursorColor;
			}
			set
			{
				this.m_CursorColor = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000C258 File Offset: 0x0000A458
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x000031A0 File Offset: 0x000013A0
		public float cursorFlashSpeed
		{
			get
			{
				bool flag = this.m_CursorFlashSpeed >= 0f;
				float num;
				if (flag)
				{
					num = this.m_CursorFlashSpeed;
				}
				else
				{
					num = GUISettings.Internal_GetCursorFlashSpeed();
				}
				return num;
			}
			set
			{
				this.m_CursorFlashSpeed = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000C290 File Offset: 0x0000A490
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x000031AA File Offset: 0x000013AA
		public Color selectionColor
		{
			get
			{
				return this.m_SelectionColor;
			}
			set
			{
				this.m_SelectionColor = value;
			}
		}

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_m_DoubleClickSelectsWord;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_m_TripleClickSelectsLine;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorColor;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorFlashSpeed;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionColor;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400014A RID: 330
		private static readonly GUISettings.Internal_GetCursorFlashSpeedDelegate Internal_GetCursorFlashSpeedDelegateField;

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600069E RID: 1694
		private delegate float Internal_GetCursorFlashSpeedDelegate();
	}
}
