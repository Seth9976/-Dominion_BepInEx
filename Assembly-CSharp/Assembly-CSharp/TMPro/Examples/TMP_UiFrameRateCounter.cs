using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000112 RID: 274
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		// Token: 0x06001FE9 RID: 8169 RVA: 0x0007B244 File Offset: 0x00079444
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_UiFrameRateCounter()
		{
			Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TMP_UiFrameRateCounter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr);
			TMP_UiFrameRateCounter.NativeFieldInfoPtr_UpdateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, "UpdateInterval");
			TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_LastInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, "m_LastInterval");
			TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_Frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, "m_Frames");
			TMP_UiFrameRateCounter.NativeFieldInfoPtr_AnchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, "AnchorPosition");
			TMP_UiFrameRateCounter.NativeFieldInfoPtr_htmlColorTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, "htmlColorTag");
			TMP_UiFrameRateCounter.NativeFieldInfoPtr_fpsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, "fpsLabel");
			TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_TextMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, "m_TextMeshPro");
			TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_frameCounter_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, "m_frameCounter_transform");
			TMP_UiFrameRateCounter.NativeFieldInfoPtr_last_AnchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, "last_AnchorPosition");
			TMP_UiFrameRateCounter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, 100665892);
			TMP_UiFrameRateCounter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, 100665893);
			TMP_UiFrameRateCounter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, 100665894);
			TMP_UiFrameRateCounter.NativeMethodInfoPtr_Set_FrameCounter_Position_Private_Void_FpsCounterAnchorPositions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, 100665895);
			TMP_UiFrameRateCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr, 100665896);
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0007B38C File Offset: 0x0007958C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256904, XrefRangeEnd = 256947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UiFrameRateCounter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0007B3C0 File Offset: 0x000795C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UiFrameRateCounter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0007B3F4 File Offset: 0x000795F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256947, XrefRangeEnd = 256961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UiFrameRateCounter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0007B428 File Offset: 0x00079628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256981, RefRangeEnd = 256983, XrefRangeStart = 256961, XrefRangeEnd = 256981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set_FrameCounter_Position(TMP_UiFrameRateCounter.FpsCounterAnchorPositions anchor_position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchor_position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UiFrameRateCounter.NativeMethodInfoPtr_Set_FrameCounter_Position_Private_Void_FpsCounterAnchorPositions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0007B468 File Offset: 0x00079668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_UiFrameRateCounter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_UiFrameRateCounter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UiFrameRateCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00013E59 File Offset: 0x00012059
		public TMP_UiFrameRateCounter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x0007B4A4 File Offset: 0x000796A4
		// (set) Token: 0x06001FF1 RID: 8177 RVA: 0x00013E62 File Offset: 0x00012062
		public unsafe float UpdateInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_UpdateInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_UpdateInterval)) = value;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x0007B4CC File Offset: 0x000796CC
		// (set) Token: 0x06001FF3 RID: 8179 RVA: 0x00013E7D File Offset: 0x0001207D
		public unsafe float m_LastInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_LastInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_LastInterval)) = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x0007B4F4 File Offset: 0x000796F4
		// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x00013E98 File Offset: 0x00012098
		public unsafe int m_Frames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_Frames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_Frames)) = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x0007B51C File Offset: 0x0007971C
		// (set) Token: 0x06001FF7 RID: 8183 RVA: 0x00013EB3 File Offset: 0x000120B3
		public unsafe TMP_UiFrameRateCounter.FpsCounterAnchorPositions AnchorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_AnchorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_AnchorPosition)) = value;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x0007B544 File Offset: 0x00079744
		// (set) Token: 0x06001FF9 RID: 8185 RVA: 0x00013ECE File Offset: 0x000120CE
		public unsafe string htmlColorTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_htmlColorTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_htmlColorTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x0007B56C File Offset: 0x0007976C
		// (set) Token: 0x06001FFB RID: 8187 RVA: 0x00013EED File Offset: 0x000120ED
		public unsafe static string fpsLabel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_UiFrameRateCounter.NativeFieldInfoPtr_fpsLabel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UiFrameRateCounter.NativeFieldInfoPtr_fpsLabel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x0007B58C File Offset: 0x0007978C
		// (set) Token: 0x06001FFD RID: 8189 RVA: 0x00013EFF File Offset: 0x000120FF
		public unsafe TextMeshProUGUI m_TextMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_TextMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_TextMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x0007B5BC File Offset: 0x000797BC
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x00013F1E File Offset: 0x0001211E
		public unsafe RectTransform m_frameCounter_transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_frameCounter_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_m_frameCounter_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x0007B5EC File Offset: 0x000797EC
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x00013F3D File Offset: 0x0001213D
		public unsafe TMP_UiFrameRateCounter.FpsCounterAnchorPositions last_AnchorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_last_AnchorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UiFrameRateCounter.NativeFieldInfoPtr_last_AnchorPosition)) = value;
			}
		}

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeFieldInfoPtr_UpdateInterval;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeFieldInfoPtr_m_LastInterval;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeFieldInfoPtr_m_Frames;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeFieldInfoPtr_AnchorPosition;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeFieldInfoPtr_htmlColorTag;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeFieldInfoPtr_fpsLabel;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeFieldInfoPtr_m_TextMeshPro;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeFieldInfoPtr_m_frameCounter_transform;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeFieldInfoPtr_last_AnchorPosition;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_Set_FrameCounter_Position_Private_Void_FpsCounterAnchorPositions_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000230 RID: 560
		public enum FpsCounterAnchorPositions
		{
			// Token: 0x04001D79 RID: 7545
			TopLeft,
			// Token: 0x04001D7A RID: 7546
			BottomLeft,
			// Token: 0x04001D7B RID: 7547
			TopRight,
			// Token: 0x04001D7C RID: 7548
			BottomRight
		}
	}
}
