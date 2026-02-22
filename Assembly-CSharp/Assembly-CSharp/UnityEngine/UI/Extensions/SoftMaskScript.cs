using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000126 RID: 294
	public class SoftMaskScript : MonoBehaviour
	{
		// Token: 0x060020DE RID: 8414 RVA: 0x0007E0B4 File Offset: 0x0007C2B4
		// Note: this type is marked as 'beforefieldinit'.
		static SoftMaskScript()
		{
			Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "SoftMaskScript");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr);
			SoftMaskScript.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "mat");
			SoftMaskScript.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "canvas");
			SoftMaskScript.NativeFieldInfoPtr_MaskArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "MaskArea");
			SoftMaskScript.NativeFieldInfoPtr_myRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "myRect");
			SoftMaskScript.NativeFieldInfoPtr_maskScalingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "maskScalingRect");
			SoftMaskScript.NativeFieldInfoPtr_AlphaMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "AlphaMask");
			SoftMaskScript.NativeFieldInfoPtr_CutOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "CutOff");
			SoftMaskScript.NativeFieldInfoPtr_HardBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "HardBlend");
			SoftMaskScript.NativeFieldInfoPtr_FlipAlphaMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "FlipAlphaMask");
			SoftMaskScript.NativeFieldInfoPtr_DontClipMaskScalingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "DontClipMaskScalingRect");
			SoftMaskScript.NativeFieldInfoPtr_CascadeToALLChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "CascadeToALLChildren");
			SoftMaskScript.NativeFieldInfoPtr_worldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "worldCorners");
			SoftMaskScript.NativeFieldInfoPtr_AlphaUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "AlphaUV");
			SoftMaskScript.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "min");
			SoftMaskScript.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "max");
			SoftMaskScript.NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "p");
			SoftMaskScript.NativeFieldInfoPtr_siz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "siz");
			SoftMaskScript.NativeFieldInfoPtr_tp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "tp");
			SoftMaskScript.NativeFieldInfoPtr_MaterialNotSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "MaterialNotSupported");
			SoftMaskScript.NativeFieldInfoPtr_maskRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "maskRect");
			SoftMaskScript.NativeFieldInfoPtr_contentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "contentRect");
			SoftMaskScript.NativeFieldInfoPtr_centre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "centre");
			SoftMaskScript.NativeFieldInfoPtr_isText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "isText");
			SoftMaskScript.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100665983);
			SoftMaskScript.NativeMethodInfoPtr_SetSAM_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100665984);
			SoftMaskScript.NativeMethodInfoPtr_GetCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100665985);
			SoftMaskScript.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100665986);
			SoftMaskScript.NativeMethodInfoPtr_SetMask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100665987);
			SoftMaskScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100665988);
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x0007E328 File Offset: 0x0007C528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257967, XrefRangeEnd = 258072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoftMaskScript.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x0007E35C File Offset: 0x0007C55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258072, XrefRangeEnd = 258084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSAM(Transform t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoftMaskScript.NativeMethodInfoPtr_SetSAM_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x0007E3A0 File Offset: 0x0007C5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258084, XrefRangeEnd = 258098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoftMaskScript.NativeMethodInfoPtr_GetCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0007E3D4 File Offset: 0x0007C5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258098, XrefRangeEnd = 258099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoftMaskScript.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x0007E408 File Offset: 0x0007C608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258180, RefRangeEnd = 258181, XrefRangeStart = 258099, XrefRangeEnd = 258180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoftMaskScript.NativeMethodInfoPtr_SetMask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x0007E43C File Offset: 0x0007C63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258181, XrefRangeEnd = 258183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoftMaskScript()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoftMaskScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0001457B File Offset: 0x0001277B
		public SoftMaskScript(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x0007E478 File Offset: 0x0007C678
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x00014584 File Offset: 0x00012784
		public unsafe Material mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x0007E4A8 File Offset: 0x0007C6A8
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x000145A3 File Offset: 0x000127A3
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x0007E4D8 File Offset: 0x0007C6D8
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x000145C2 File Offset: 0x000127C2
		public unsafe RectTransform MaskArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_MaskArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_MaskArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x0007E508 File Offset: 0x0007C708
		// (set) Token: 0x060020ED RID: 8429 RVA: 0x000145E1 File Offset: 0x000127E1
		public unsafe RectTransform myRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_myRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_myRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x0007E538 File Offset: 0x0007C738
		// (set) Token: 0x060020EF RID: 8431 RVA: 0x00014600 File Offset: 0x00012800
		public unsafe RectTransform maskScalingRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_maskScalingRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_maskScalingRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x0007E568 File Offset: 0x0007C768
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x0001461F File Offset: 0x0001281F
		public unsafe Texture AlphaMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_AlphaMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_AlphaMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x0007E598 File Offset: 0x0007C798
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x0001463E File Offset: 0x0001283E
		public unsafe float CutOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_CutOff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_CutOff)) = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x0007E5C0 File Offset: 0x0007C7C0
		// (set) Token: 0x060020F5 RID: 8437 RVA: 0x00014659 File Offset: 0x00012859
		public unsafe bool HardBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_HardBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_HardBlend)) = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x0007E5E8 File Offset: 0x0007C7E8
		// (set) Token: 0x060020F7 RID: 8439 RVA: 0x00014674 File Offset: 0x00012874
		public unsafe bool FlipAlphaMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_FlipAlphaMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_FlipAlphaMask)) = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x0007E610 File Offset: 0x0007C810
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x0001468F File Offset: 0x0001288F
		public unsafe bool DontClipMaskScalingRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_DontClipMaskScalingRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_DontClipMaskScalingRect)) = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x0007E638 File Offset: 0x0007C838
		// (set) Token: 0x060020FB RID: 8443 RVA: 0x000146AA File Offset: 0x000128AA
		public unsafe bool CascadeToALLChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_CascadeToALLChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_CascadeToALLChildren)) = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0007E660 File Offset: 0x0007C860
		// (set) Token: 0x060020FD RID: 8445 RVA: 0x000146C5 File Offset: 0x000128C5
		public unsafe Il2CppStructArray<Vector3> worldCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_worldCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_worldCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0007E690 File Offset: 0x0007C890
		// (set) Token: 0x060020FF RID: 8447 RVA: 0x000146E4 File Offset: 0x000128E4
		public unsafe Vector2 AlphaUV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_AlphaUV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_AlphaUV)) = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x0007E6B8 File Offset: 0x0007C8B8
		// (set) Token: 0x06002101 RID: 8449 RVA: 0x000146FF File Offset: 0x000128FF
		public unsafe Vector2 min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x0007E6E0 File Offset: 0x0007C8E0
		// (set) Token: 0x06002103 RID: 8451 RVA: 0x0001471A File Offset: 0x0001291A
		public unsafe Vector2 max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x0007E708 File Offset: 0x0007C908
		// (set) Token: 0x06002105 RID: 8453 RVA: 0x00014735 File Offset: 0x00012935
		public unsafe Vector2 p
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_p);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_p)) = value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x0007E730 File Offset: 0x0007C930
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x00014750 File Offset: 0x00012950
		public unsafe Vector2 siz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_siz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_siz)) = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x0007E758 File Offset: 0x0007C958
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x0001476B File Offset: 0x0001296B
		public unsafe Vector2 tp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_tp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_tp)) = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x0007E780 File Offset: 0x0007C980
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x00014786 File Offset: 0x00012986
		public unsafe bool MaterialNotSupported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_MaterialNotSupported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_MaterialNotSupported)) = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x0007E7A8 File Offset: 0x0007C9A8
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x000147A1 File Offset: 0x000129A1
		public unsafe Rect maskRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_maskRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_maskRect)) = value;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x0007E7D0 File Offset: 0x0007C9D0
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x000147BC File Offset: 0x000129BC
		public unsafe Rect contentRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_contentRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_contentRect)) = value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x0007E7F8 File Offset: 0x0007C9F8
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x000147D7 File Offset: 0x000129D7
		public unsafe Vector2 centre
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_centre);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_centre)) = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x0007E820 File Offset: 0x0007CA20
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x000147F2 File Offset: 0x000129F2
		public unsafe bool isText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_isText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoftMaskScript.NativeFieldInfoPtr_isText)) = value;
			}
		}

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeFieldInfoPtr_mat;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeFieldInfoPtr_MaskArea;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeFieldInfoPtr_myRect;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeFieldInfoPtr_maskScalingRect;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeFieldInfoPtr_AlphaMask;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeFieldInfoPtr_CutOff;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeFieldInfoPtr_HardBlend;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeFieldInfoPtr_FlipAlphaMask;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeFieldInfoPtr_DontClipMaskScalingRect;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeFieldInfoPtr_CascadeToALLChildren;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeFieldInfoPtr_worldCorners;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeFieldInfoPtr_AlphaUV;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeFieldInfoPtr_p;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeFieldInfoPtr_siz;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeFieldInfoPtr_tp;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeFieldInfoPtr_MaterialNotSupported;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeFieldInfoPtr_maskRect;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeFieldInfoPtr_contentRect;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeFieldInfoPtr_centre;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeFieldInfoPtr_isText;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr_SetSAM_Private_Void_Transform_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvas_Private_Void_0;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr_SetMask_Private_Void_0;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
