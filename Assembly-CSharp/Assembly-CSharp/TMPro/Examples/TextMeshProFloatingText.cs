using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000109 RID: 265
	public class TextMeshProFloatingText : MonoBehaviour
	{
		// Token: 0x06001F2A RID: 7978 RVA: 0x000792EC File Offset: 0x000774EC
		// Note: this type is marked as 'beforefieldinit'.
		static TextMeshProFloatingText()
		{
			Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TextMeshProFloatingText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr);
			TextMeshProFloatingText.NativeFieldInfoPtr_TheFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "TheFont");
			TextMeshProFloatingText.NativeFieldInfoPtr_m_floatingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "m_floatingText");
			TextMeshProFloatingText.NativeFieldInfoPtr_m_textMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "m_textMeshPro");
			TextMeshProFloatingText.NativeFieldInfoPtr_m_textMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "m_textMesh");
			TextMeshProFloatingText.NativeFieldInfoPtr_m_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "m_transform");
			TextMeshProFloatingText.NativeFieldInfoPtr_m_floatingText_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "m_floatingText_Transform");
			TextMeshProFloatingText.NativeFieldInfoPtr_m_cameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "m_cameraTransform");
			TextMeshProFloatingText.NativeFieldInfoPtr_lastPOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "lastPOS");
			TextMeshProFloatingText.NativeFieldInfoPtr_lastRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "lastRotation");
			TextMeshProFloatingText.NativeFieldInfoPtr_SpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "SpawnType");
			TextMeshProFloatingText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, 100665849);
			TextMeshProFloatingText.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, 100665850);
			TextMeshProFloatingText.NativeMethodInfoPtr_DisplayTextMeshProFloatingText_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, 100665851);
			TextMeshProFloatingText.NativeMethodInfoPtr_DisplayTextMeshFloatingText_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, 100665852);
			TextMeshProFloatingText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, 100665853);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00079448 File Offset: 0x00077648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256245, XrefRangeEnd = 256256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x0007947C File Offset: 0x0007767C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256256, XrefRangeEnd = 256315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000794B0 File Offset: 0x000776B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256319, RefRangeEnd = 256320, XrefRangeStart = 256315, XrefRangeEnd = 256319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DisplayTextMeshProFloatingText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText.NativeMethodInfoPtr_DisplayTextMeshProFloatingText_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000794F0 File Offset: 0x000776F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256324, RefRangeEnd = 256325, XrefRangeStart = 256320, XrefRangeEnd = 256324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DisplayTextMeshFloatingText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText.NativeMethodInfoPtr_DisplayTextMeshFloatingText_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00079530 File Offset: 0x00077730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256325, XrefRangeEnd = 256328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMeshProFloatingText()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x000136DE File Offset: 0x000118DE
		public TextMeshProFloatingText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0007956C File Offset: 0x0007776C
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x000136E7 File Offset: 0x000118E7
		public unsafe Font TheFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_TheFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_TheFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x0007959C File Offset: 0x0007779C
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x00013706 File Offset: 0x00011906
		public unsafe GameObject m_floatingText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_floatingText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_floatingText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x000795CC File Offset: 0x000777CC
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x00013725 File Offset: 0x00011925
		public unsafe TextMeshPro m_textMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_textMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_textMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x000795FC File Offset: 0x000777FC
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x00013744 File Offset: 0x00011944
		public unsafe TextMesh m_textMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_textMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_textMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x0007962C File Offset: 0x0007782C
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x00013763 File Offset: 0x00011963
		public unsafe Transform m_transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x0007965C File Offset: 0x0007785C
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x00013782 File Offset: 0x00011982
		public unsafe Transform m_floatingText_Transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_floatingText_Transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_floatingText_Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x0007968C File Offset: 0x0007788C
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x000137A1 File Offset: 0x000119A1
		public unsafe Transform m_cameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_cameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_m_cameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x000796BC File Offset: 0x000778BC
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x000137C0 File Offset: 0x000119C0
		public unsafe Vector3 lastPOS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_lastPOS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_lastPOS)) = value;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x000796E4 File Offset: 0x000778E4
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x000137DB File Offset: 0x000119DB
		public unsafe Quaternion lastRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_lastRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_lastRotation)) = value;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x0007970C File Offset: 0x0007790C
		// (set) Token: 0x06001F44 RID: 8004 RVA: 0x000137F6 File Offset: 0x000119F6
		public unsafe int SpawnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_SpawnType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText.NativeFieldInfoPtr_SpawnType)) = value;
			}
		}

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeFieldInfoPtr_TheFont;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeFieldInfoPtr_m_floatingText;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeFieldInfoPtr_m_textMeshPro;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeFieldInfoPtr_m_textMesh;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeFieldInfoPtr_m_transform;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeFieldInfoPtr_m_floatingText_Transform;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeFieldInfoPtr_m_cameraTransform;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeFieldInfoPtr_lastPOS;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeFieldInfoPtr_lastRotation;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeFieldInfoPtr_SpawnType;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_DisplayTextMeshProFloatingText_Public_IEnumerator_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_DisplayTextMeshFloatingText_Public_IEnumerator_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200022B RID: 555
		[ObfuscatedName("TMPro.Examples.TextMeshProFloatingText+<DisplayTextMeshProFloatingText>d__12")]
		public sealed class _DisplayTextMeshProFloatingText_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06002ADF RID: 10975 RVA: 0x0009961C File Offset: 0x0009781C
			// Note: this type is marked as 'beforefieldinit'.
			static _DisplayTextMeshProFloatingText_d__12()
			{
				Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "<DisplayTextMeshProFloatingText>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr);
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, "<>1__state");
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, "<>2__current");
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, "<>4__this");
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__CountDuration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, "<CountDuration>5__2");
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__starting_Count_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, "<starting_Count>5__3");
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__current_Count_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, "<current_Count>5__4");
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__start_pos_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, "<start_pos>5__5");
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__start_color_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, "<start_color>5__6");
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__alpha_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, "<alpha>5__7");
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__fadeDuration_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, "<fadeDuration>5__8");
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, 100666677);
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, 100666678);
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, 100666679);
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, 100666680);
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, 100666681);
				TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr, 100666682);
			}

			// Token: 0x06002AE0 RID: 10976 RVA: 0x00099788 File Offset: 0x00097988
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DisplayTextMeshProFloatingText_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AE1 RID: 10977 RVA: 0x000997D0 File Offset: 0x000979D0
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AE2 RID: 10978 RVA: 0x00099804 File Offset: 0x00097A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256168, XrefRangeEnd = 256201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D8F RID: 3471
			// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x00099840 File Offset: 0x00097A40
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AE4 RID: 10980 RVA: 0x00099880 File Offset: 0x00097A80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256201, XrefRangeEnd = 256206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D90 RID: 3472
			// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x000998B4 File Offset: 0x00097AB4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AE6 RID: 10982 RVA: 0x0001A4E9 File Offset: 0x000186E9
			public _DisplayTextMeshProFloatingText_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D85 RID: 3461
			// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000998F4 File Offset: 0x00097AF4
			// (set) Token: 0x06002AE8 RID: 10984 RVA: 0x0001A4F2 File Offset: 0x000186F2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D86 RID: 3462
			// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x0009991C File Offset: 0x00097B1C
			// (set) Token: 0x06002AEA RID: 10986 RVA: 0x0001A50D File Offset: 0x0001870D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D87 RID: 3463
			// (get) Token: 0x06002AEB RID: 10987 RVA: 0x0009994C File Offset: 0x00097B4C
			// (set) Token: 0x06002AEC RID: 10988 RVA: 0x0001A52C File Offset: 0x0001872C
			public unsafe TextMeshProFloatingText __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProFloatingText>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D88 RID: 3464
			// (get) Token: 0x06002AED RID: 10989 RVA: 0x0009997C File Offset: 0x00097B7C
			// (set) Token: 0x06002AEE RID: 10990 RVA: 0x0001A54B File Offset: 0x0001874B
			public unsafe float _CountDuration_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__CountDuration_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__CountDuration_5__2)) = value;
				}
			}

			// Token: 0x17000D89 RID: 3465
			// (get) Token: 0x06002AEF RID: 10991 RVA: 0x000999A4 File Offset: 0x00097BA4
			// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x0001A566 File Offset: 0x00018766
			public unsafe float _starting_Count_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__starting_Count_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__starting_Count_5__3)) = value;
				}
			}

			// Token: 0x17000D8A RID: 3466
			// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x000999CC File Offset: 0x00097BCC
			// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x0001A581 File Offset: 0x00018781
			public unsafe float _current_Count_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__current_Count_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__current_Count_5__4)) = value;
				}
			}

			// Token: 0x17000D8B RID: 3467
			// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x000999F4 File Offset: 0x00097BF4
			// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x0001A59C File Offset: 0x0001879C
			public unsafe Vector3 _start_pos_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__start_pos_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__start_pos_5__5)) = value;
				}
			}

			// Token: 0x17000D8C RID: 3468
			// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x00099A1C File Offset: 0x00097C1C
			// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x0001A5B7 File Offset: 0x000187B7
			public unsafe Color32 _start_color_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__start_color_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__start_color_5__6)) = value;
				}
			}

			// Token: 0x17000D8D RID: 3469
			// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x00099A44 File Offset: 0x00097C44
			// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x0001A5D2 File Offset: 0x000187D2
			public unsafe float _alpha_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__alpha_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__alpha_5__7)) = value;
				}
			}

			// Token: 0x17000D8E RID: 3470
			// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x00099A6C File Offset: 0x00097C6C
			// (set) Token: 0x06002AFA RID: 11002 RVA: 0x0001A5ED File Offset: 0x000187ED
			public unsafe float _fadeDuration_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__fadeDuration_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshProFloatingText_d__12.NativeFieldInfoPtr__fadeDuration_5__8)) = value;
				}
			}

			// Token: 0x04001D4B RID: 7499
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D4C RID: 7500
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D4D RID: 7501
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D4E RID: 7502
			private static readonly IntPtr NativeFieldInfoPtr__CountDuration_5__2;

			// Token: 0x04001D4F RID: 7503
			private static readonly IntPtr NativeFieldInfoPtr__starting_Count_5__3;

			// Token: 0x04001D50 RID: 7504
			private static readonly IntPtr NativeFieldInfoPtr__current_Count_5__4;

			// Token: 0x04001D51 RID: 7505
			private static readonly IntPtr NativeFieldInfoPtr__start_pos_5__5;

			// Token: 0x04001D52 RID: 7506
			private static readonly IntPtr NativeFieldInfoPtr__start_color_5__6;

			// Token: 0x04001D53 RID: 7507
			private static readonly IntPtr NativeFieldInfoPtr__alpha_5__7;

			// Token: 0x04001D54 RID: 7508
			private static readonly IntPtr NativeFieldInfoPtr__fadeDuration_5__8;

			// Token: 0x04001D55 RID: 7509
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D56 RID: 7510
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D57 RID: 7511
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D58 RID: 7512
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D59 RID: 7513
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D5A RID: 7514
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200022C RID: 556
		[ObfuscatedName("TMPro.Examples.TextMeshProFloatingText+<DisplayTextMeshFloatingText>d__13")]
		public sealed class _DisplayTextMeshFloatingText_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x06002AFB RID: 11003 RVA: 0x00099A94 File Offset: 0x00097C94
			// Note: this type is marked as 'beforefieldinit'.
			static _DisplayTextMeshFloatingText_d__13()
			{
				Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextMeshProFloatingText>.NativeClassPtr, "<DisplayTextMeshFloatingText>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr);
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, "<>1__state");
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, "<>2__current");
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, "<>4__this");
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__CountDuration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, "<CountDuration>5__2");
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__starting_Count_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, "<starting_Count>5__3");
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__current_Count_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, "<current_Count>5__4");
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__start_pos_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, "<start_pos>5__5");
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__start_color_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, "<start_color>5__6");
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__alpha_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, "<alpha>5__7");
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__fadeDuration_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, "<fadeDuration>5__8");
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, 100666683);
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, 100666684);
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, 100666685);
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, 100666686);
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, 100666687);
				TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr, 100666688);
			}

			// Token: 0x06002AFC RID: 11004 RVA: 0x00099C00 File Offset: 0x00097E00
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DisplayTextMeshFloatingText_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AFD RID: 11005 RVA: 0x00099C48 File Offset: 0x00097E48
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AFE RID: 11006 RVA: 0x00099C7C File Offset: 0x00097E7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256206, XrefRangeEnd = 256240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D9B RID: 3483
			// (get) Token: 0x06002AFF RID: 11007 RVA: 0x00099CB8 File Offset: 0x00097EB8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B00 RID: 11008 RVA: 0x00099CF8 File Offset: 0x00097EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256240, XrefRangeEnd = 256245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D9C RID: 3484
			// (get) Token: 0x06002B01 RID: 11009 RVA: 0x00099D2C File Offset: 0x00097F2C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B02 RID: 11010 RVA: 0x0001A608 File Offset: 0x00018808
			public _DisplayTextMeshFloatingText_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D91 RID: 3473
			// (get) Token: 0x06002B03 RID: 11011 RVA: 0x00099D6C File Offset: 0x00097F6C
			// (set) Token: 0x06002B04 RID: 11012 RVA: 0x0001A611 File Offset: 0x00018811
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D92 RID: 3474
			// (get) Token: 0x06002B05 RID: 11013 RVA: 0x00099D94 File Offset: 0x00097F94
			// (set) Token: 0x06002B06 RID: 11014 RVA: 0x0001A62C File Offset: 0x0001882C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D93 RID: 3475
			// (get) Token: 0x06002B07 RID: 11015 RVA: 0x00099DC4 File Offset: 0x00097FC4
			// (set) Token: 0x06002B08 RID: 11016 RVA: 0x0001A64B File Offset: 0x0001884B
			public unsafe TextMeshProFloatingText __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProFloatingText>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D94 RID: 3476
			// (get) Token: 0x06002B09 RID: 11017 RVA: 0x00099DF4 File Offset: 0x00097FF4
			// (set) Token: 0x06002B0A RID: 11018 RVA: 0x0001A66A File Offset: 0x0001886A
			public unsafe float _CountDuration_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__CountDuration_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__CountDuration_5__2)) = value;
				}
			}

			// Token: 0x17000D95 RID: 3477
			// (get) Token: 0x06002B0B RID: 11019 RVA: 0x00099E1C File Offset: 0x0009801C
			// (set) Token: 0x06002B0C RID: 11020 RVA: 0x0001A685 File Offset: 0x00018885
			public unsafe float _starting_Count_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__starting_Count_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__starting_Count_5__3)) = value;
				}
			}

			// Token: 0x17000D96 RID: 3478
			// (get) Token: 0x06002B0D RID: 11021 RVA: 0x00099E44 File Offset: 0x00098044
			// (set) Token: 0x06002B0E RID: 11022 RVA: 0x0001A6A0 File Offset: 0x000188A0
			public unsafe float _current_Count_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__current_Count_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__current_Count_5__4)) = value;
				}
			}

			// Token: 0x17000D97 RID: 3479
			// (get) Token: 0x06002B0F RID: 11023 RVA: 0x00099E6C File Offset: 0x0009806C
			// (set) Token: 0x06002B10 RID: 11024 RVA: 0x0001A6BB File Offset: 0x000188BB
			public unsafe Vector3 _start_pos_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__start_pos_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__start_pos_5__5)) = value;
				}
			}

			// Token: 0x17000D98 RID: 3480
			// (get) Token: 0x06002B11 RID: 11025 RVA: 0x00099E94 File Offset: 0x00098094
			// (set) Token: 0x06002B12 RID: 11026 RVA: 0x0001A6D6 File Offset: 0x000188D6
			public unsafe Color32 _start_color_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__start_color_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__start_color_5__6)) = value;
				}
			}

			// Token: 0x17000D99 RID: 3481
			// (get) Token: 0x06002B13 RID: 11027 RVA: 0x00099EBC File Offset: 0x000980BC
			// (set) Token: 0x06002B14 RID: 11028 RVA: 0x0001A6F1 File Offset: 0x000188F1
			public unsafe float _alpha_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__alpha_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__alpha_5__7)) = value;
				}
			}

			// Token: 0x17000D9A RID: 3482
			// (get) Token: 0x06002B15 RID: 11029 RVA: 0x00099EE4 File Offset: 0x000980E4
			// (set) Token: 0x06002B16 RID: 11030 RVA: 0x0001A70C File Offset: 0x0001890C
			public unsafe float _fadeDuration_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__fadeDuration_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMeshProFloatingText._DisplayTextMeshFloatingText_d__13.NativeFieldInfoPtr__fadeDuration_5__8)) = value;
				}
			}

			// Token: 0x04001D5B RID: 7515
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D5C RID: 7516
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D5D RID: 7517
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D5E RID: 7518
			private static readonly IntPtr NativeFieldInfoPtr__CountDuration_5__2;

			// Token: 0x04001D5F RID: 7519
			private static readonly IntPtr NativeFieldInfoPtr__starting_Count_5__3;

			// Token: 0x04001D60 RID: 7520
			private static readonly IntPtr NativeFieldInfoPtr__current_Count_5__4;

			// Token: 0x04001D61 RID: 7521
			private static readonly IntPtr NativeFieldInfoPtr__start_pos_5__5;

			// Token: 0x04001D62 RID: 7522
			private static readonly IntPtr NativeFieldInfoPtr__start_color_5__6;

			// Token: 0x04001D63 RID: 7523
			private static readonly IntPtr NativeFieldInfoPtr__alpha_5__7;

			// Token: 0x04001D64 RID: 7524
			private static readonly IntPtr NativeFieldInfoPtr__fadeDuration_5__8;

			// Token: 0x04001D65 RID: 7525
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D66 RID: 7526
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D67 RID: 7527
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D68 RID: 7528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D69 RID: 7529
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D6A RID: 7530
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
