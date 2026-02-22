using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200010D RID: 269
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		// Token: 0x06001F72 RID: 8050 RVA: 0x00079E1C File Offset: 0x0007801C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FrameRateCounter()
		{
			Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TMP_FrameRateCounter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr);
			TMP_FrameRateCounter.NativeFieldInfoPtr_UpdateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, "UpdateInterval");
			TMP_FrameRateCounter.NativeFieldInfoPtr_m_LastInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, "m_LastInterval");
			TMP_FrameRateCounter.NativeFieldInfoPtr_m_Frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, "m_Frames");
			TMP_FrameRateCounter.NativeFieldInfoPtr_AnchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, "AnchorPosition");
			TMP_FrameRateCounter.NativeFieldInfoPtr_htmlColorTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, "htmlColorTag");
			TMP_FrameRateCounter.NativeFieldInfoPtr_fpsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, "fpsLabel");
			TMP_FrameRateCounter.NativeFieldInfoPtr_m_TextMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, "m_TextMeshPro");
			TMP_FrameRateCounter.NativeFieldInfoPtr_m_frameCounter_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, "m_frameCounter_transform");
			TMP_FrameRateCounter.NativeFieldInfoPtr_m_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, "m_camera");
			TMP_FrameRateCounter.NativeFieldInfoPtr_last_AnchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, "last_AnchorPosition");
			TMP_FrameRateCounter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, 100665863);
			TMP_FrameRateCounter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, 100665864);
			TMP_FrameRateCounter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, 100665865);
			TMP_FrameRateCounter.NativeMethodInfoPtr_Set_FrameCounter_Position_Private_Void_FpsCounterAnchorPositions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, 100665866);
			TMP_FrameRateCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr, 100665867);
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00079F78 File Offset: 0x00078178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256465, XrefRangeEnd = 256509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FrameRateCounter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00079FAC File Offset: 0x000781AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256509, XrefRangeEnd = 256510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FrameRateCounter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00079FE0 File Offset: 0x000781E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256510, XrefRangeEnd = 256524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FrameRateCounter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0007A014 File Offset: 0x00078214
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256534, RefRangeEnd = 256536, XrefRangeStart = 256524, XrefRangeEnd = 256534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set_FrameCounter_Position(TMP_FrameRateCounter.FpsCounterAnchorPositions anchor_position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchor_position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FrameRateCounter.NativeMethodInfoPtr_Set_FrameCounter_Position_Private_Void_FpsCounterAnchorPositions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0007A054 File Offset: 0x00078254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256536, XrefRangeEnd = 256537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_FrameRateCounter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FrameRateCounter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FrameRateCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x000139CB File Offset: 0x00011BCB
		public TMP_FrameRateCounter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x0007A090 File Offset: 0x00078290
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x000139D4 File Offset: 0x00011BD4
		public unsafe float UpdateInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_UpdateInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_UpdateInterval)) = value;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x0007A0B8 File Offset: 0x000782B8
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x000139EF File Offset: 0x00011BEF
		public unsafe float m_LastInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_m_LastInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_m_LastInterval)) = value;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x0007A0E0 File Offset: 0x000782E0
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x00013A0A File Offset: 0x00011C0A
		public unsafe int m_Frames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_m_Frames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_m_Frames)) = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x0007A108 File Offset: 0x00078308
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x00013A25 File Offset: 0x00011C25
		public unsafe TMP_FrameRateCounter.FpsCounterAnchorPositions AnchorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_AnchorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_AnchorPosition)) = value;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0007A130 File Offset: 0x00078330
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x00013A40 File Offset: 0x00011C40
		public unsafe string htmlColorTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_htmlColorTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_htmlColorTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x0007A158 File Offset: 0x00078358
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x00013A5F File Offset: 0x00011C5F
		public unsafe static string fpsLabel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FrameRateCounter.NativeFieldInfoPtr_fpsLabel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FrameRateCounter.NativeFieldInfoPtr_fpsLabel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x0007A178 File Offset: 0x00078378
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x00013A71 File Offset: 0x00011C71
		public unsafe TextMeshPro m_TextMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_m_TextMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_m_TextMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x0007A1A8 File Offset: 0x000783A8
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x00013A90 File Offset: 0x00011C90
		public unsafe Transform m_frameCounter_transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_m_frameCounter_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_m_frameCounter_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0007A1D8 File Offset: 0x000783D8
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x00013AAF File Offset: 0x00011CAF
		public unsafe Camera m_camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_m_camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_m_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0007A208 File Offset: 0x00078408
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x00013ACE File Offset: 0x00011CCE
		public unsafe TMP_FrameRateCounter.FpsCounterAnchorPositions last_AnchorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_last_AnchorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_FrameRateCounter.NativeFieldInfoPtr_last_AnchorPosition)) = value;
			}
		}

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeFieldInfoPtr_UpdateInterval;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeFieldInfoPtr_m_LastInterval;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeFieldInfoPtr_m_Frames;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeFieldInfoPtr_AnchorPosition;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeFieldInfoPtr_htmlColorTag;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeFieldInfoPtr_fpsLabel;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeFieldInfoPtr_m_TextMeshPro;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeFieldInfoPtr_m_frameCounter_transform;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeFieldInfoPtr_m_camera;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeFieldInfoPtr_last_AnchorPosition;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_Set_FrameCounter_Position_Private_Void_FpsCounterAnchorPositions_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200022F RID: 559
		public enum FpsCounterAnchorPositions
		{
			// Token: 0x04001D74 RID: 7540
			TopLeft,
			// Token: 0x04001D75 RID: 7541
			BottomLeft,
			// Token: 0x04001D76 RID: 7542
			TopRight,
			// Token: 0x04001D77 RID: 7543
			BottomRight
		}
	}
}
