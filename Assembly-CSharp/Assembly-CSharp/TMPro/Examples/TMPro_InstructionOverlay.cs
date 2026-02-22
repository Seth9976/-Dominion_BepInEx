using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200010B RID: 267
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		// Token: 0x06001F52 RID: 8018 RVA: 0x00079944 File Offset: 0x00077B44
		// Note: this type is marked as 'beforefieldinit'.
		static TMPro_InstructionOverlay()
		{
			Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TMPro_InstructionOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr);
			TMPro_InstructionOverlay.NativeFieldInfoPtr_AnchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr, "AnchorPosition");
			TMPro_InstructionOverlay.NativeFieldInfoPtr_instructions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr, "instructions");
			TMPro_InstructionOverlay.NativeFieldInfoPtr_m_TextMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr, "m_TextMeshPro");
			TMPro_InstructionOverlay.NativeFieldInfoPtr_m_textContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr, "m_textContainer");
			TMPro_InstructionOverlay.NativeFieldInfoPtr_m_frameCounter_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr, "m_frameCounter_transform");
			TMPro_InstructionOverlay.NativeFieldInfoPtr_m_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr, "m_camera");
			TMPro_InstructionOverlay.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr, 100665857);
			TMPro_InstructionOverlay.NativeMethodInfoPtr_Set_FrameCounter_Position_Private_Void_FpsCounterAnchorPositions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr, 100665858);
			TMPro_InstructionOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr, 100665859);
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00079A28 File Offset: 0x00077C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256372, XrefRangeEnd = 256419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_InstructionOverlay.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00079A5C File Offset: 0x00077C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256428, RefRangeEnd = 256429, XrefRangeStart = 256419, XrefRangeEnd = 256428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set_FrameCounter_Position(TMPro_InstructionOverlay.FpsCounterAnchorPositions anchor_position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchor_position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_InstructionOverlay.NativeMethodInfoPtr_Set_FrameCounter_Position_Private_Void_FpsCounterAnchorPositions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00079A9C File Offset: 0x00077C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256429, XrefRangeEnd = 256430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMPro_InstructionOverlay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMPro_InstructionOverlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_InstructionOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x0001388E File Offset: 0x00011A8E
		public TMPro_InstructionOverlay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00079AD8 File Offset: 0x00077CD8
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00013897 File Offset: 0x00011A97
		public unsafe TMPro_InstructionOverlay.FpsCounterAnchorPositions AnchorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPro_InstructionOverlay.NativeFieldInfoPtr_AnchorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPro_InstructionOverlay.NativeFieldInfoPtr_AnchorPosition)) = value;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x00079B00 File Offset: 0x00077D00
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x000138B2 File Offset: 0x00011AB2
		public unsafe static string instructions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_InstructionOverlay.NativeFieldInfoPtr_instructions, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_InstructionOverlay.NativeFieldInfoPtr_instructions, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00079B20 File Offset: 0x00077D20
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x000138C4 File Offset: 0x00011AC4
		public unsafe TextMeshPro m_TextMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPro_InstructionOverlay.NativeFieldInfoPtr_m_TextMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPro_InstructionOverlay.NativeFieldInfoPtr_m_TextMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x00079B50 File Offset: 0x00077D50
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x000138E3 File Offset: 0x00011AE3
		public unsafe TextContainer m_textContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPro_InstructionOverlay.NativeFieldInfoPtr_m_textContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPro_InstructionOverlay.NativeFieldInfoPtr_m_textContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00079B80 File Offset: 0x00077D80
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00013902 File Offset: 0x00011B02
		public unsafe Transform m_frameCounter_transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPro_InstructionOverlay.NativeFieldInfoPtr_m_frameCounter_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPro_InstructionOverlay.NativeFieldInfoPtr_m_frameCounter_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x00079BB0 File Offset: 0x00077DB0
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00013921 File Offset: 0x00011B21
		public unsafe Camera m_camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPro_InstructionOverlay.NativeFieldInfoPtr_m_camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPro_InstructionOverlay.NativeFieldInfoPtr_m_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeFieldInfoPtr_AnchorPosition;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeFieldInfoPtr_instructions;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeFieldInfoPtr_m_TextMeshPro;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeFieldInfoPtr_m_textContainer;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeFieldInfoPtr_m_frameCounter_transform;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeFieldInfoPtr_m_camera;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_Set_FrameCounter_Position_Private_Void_FpsCounterAnchorPositions_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200022D RID: 557
		public enum FpsCounterAnchorPositions
		{
			// Token: 0x04001D6C RID: 7532
			TopLeft,
			// Token: 0x04001D6D RID: 7533
			BottomLeft,
			// Token: 0x04001D6E RID: 7534
			TopRight,
			// Token: 0x04001D6F RID: 7535
			BottomRight
		}
	}
}
