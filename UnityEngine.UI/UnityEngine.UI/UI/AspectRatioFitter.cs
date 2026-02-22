using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000019 RID: 25
	public class AspectRatioFitter : UIBehaviour
	{
		// Token: 0x06000368 RID: 872 RVA: 0x0001421C File Offset: 0x0001241C
		// Note: this type is marked as 'beforefieldinit'.
		static AspectRatioFitter()
		{
			Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "AspectRatioFitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr);
			AspectRatioFitter.NativeFieldInfoPtr_m_AspectMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_AspectMode");
			AspectRatioFitter.NativeFieldInfoPtr_m_AspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_AspectRatio");
			AspectRatioFitter.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_Rect");
			AspectRatioFitter.NativeFieldInfoPtr_m_DelayedSetDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_DelayedSetDirty");
			AspectRatioFitter.NativeFieldInfoPtr_m_DoesParentExist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_DoesParentExist");
			AspectRatioFitter.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, "m_Tracker");
			AspectRatioFitter.NativeMethodInfoPtr_get_aspectMode_Public_get_AspectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663795);
			AspectRatioFitter.NativeMethodInfoPtr_set_aspectMode_Public_set_Void_AspectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663796);
			AspectRatioFitter.NativeMethodInfoPtr_get_aspectRatio_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663797);
			AspectRatioFitter.NativeMethodInfoPtr_set_aspectRatio_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663798);
			AspectRatioFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663799);
			AspectRatioFitter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663800);
			AspectRatioFitter.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663801);
			AspectRatioFitter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663802);
			AspectRatioFitter.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663803);
			AspectRatioFitter.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663804);
			AspectRatioFitter.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663805);
			AspectRatioFitter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663806);
			AspectRatioFitter.NativeMethodInfoPtr_UpdateRect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663807);
			AspectRatioFitter.NativeMethodInfoPtr_GetSizeDeltaToProduceSize_Private_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663808);
			AspectRatioFitter.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663809);
			AspectRatioFitter.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663810);
			AspectRatioFitter.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663811);
			AspectRatioFitter.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663812);
			AspectRatioFitter.NativeMethodInfoPtr_IsComponentValidOnObject_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663813);
			AspectRatioFitter.NativeMethodInfoPtr_IsAspectModeValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663814);
			AspectRatioFitter.NativeMethodInfoPtr_DoesParentExists_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr, 100663815);
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00014468 File Offset: 0x00012668
		// (set) Token: 0x0600036A RID: 874 RVA: 0x000144A4 File Offset: 0x000126A4
		public unsafe AspectRatioFitter.AspectMode aspectMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_get_aspectMode_Public_get_AspectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114277, XrefRangeEnd = 114281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_set_aspectMode_Public_set_Void_AspectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600036B RID: 875 RVA: 0x000144E4 File Offset: 0x000126E4
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00014520 File Offset: 0x00012720
		public unsafe float aspectRatio
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_get_aspectRatio_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114281, XrefRangeEnd = 114285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_set_aspectRatio_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00014560 File Offset: 0x00012760
		public unsafe RectTransform rectTransform
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 114292, RefRangeEnd = 114306, XrefRangeStart = 114285, XrefRangeEnd = 114292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000145A0 File Offset: 0x000127A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114306, XrefRangeEnd = 114307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AspectRatioFitter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AspectRatioFitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000145DC File Offset: 0x000127DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114307, XrefRangeEnd = 114316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00014618 File Offset: 0x00012818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114316, XrefRangeEnd = 114319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00014654 File Offset: 0x00012854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114319, XrefRangeEnd = 114326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00014690 File Offset: 0x00012890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114326, XrefRangeEnd = 114335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000146CC File Offset: 0x000128CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114335, XrefRangeEnd = 114336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00014708 File Offset: 0x00012908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114336, XrefRangeEnd = 114337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00014744 File Offset: 0x00012944
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 114365, RefRangeEnd = 114372, XrefRangeStart = 114337, XrefRangeEnd = 114365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_UpdateRect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00014778 File Offset: 0x00012978
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114380, RefRangeEnd = 114382, XrefRangeStart = 114372, XrefRangeEnd = 114380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSizeDeltaToProduceSize(float size, int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_GetSizeDeltaToProduceSize_Private_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000147D0 File Offset: 0x000129D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114391, RefRangeEnd = 114393, XrefRangeStart = 114382, XrefRangeEnd = 114391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetParentSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0001480C File Offset: 0x00012A0C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00014848 File Offset: 0x00012A48
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AspectRatioFitter.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00014884 File Offset: 0x00012A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000148B8 File Offset: 0x00012AB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114403, RefRangeEnd = 114405, XrefRangeStart = 114393, XrefRangeEnd = 114403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsComponentValidOnObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_IsComponentValidOnObject_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000148F4 File Offset: 0x00012AF4
		[CallerCount(0)]
		public unsafe bool IsAspectModeValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_IsAspectModeValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00014930 File Offset: 0x00012B30
		[CallerCount(0)]
		public unsafe bool DoesParentExists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioFitter.NativeMethodInfoPtr_DoesParentExists_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000032FB File Offset: 0x000014FB
		public AspectRatioFitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0001496C File Offset: 0x00012B6C
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003304 File Offset: 0x00001504
		public unsafe AspectRatioFitter.AspectMode m_AspectMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_AspectMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_AspectMode)) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00014994 File Offset: 0x00012B94
		// (set) Token: 0x06000382 RID: 898 RVA: 0x0000331F File Offset: 0x0000151F
		public unsafe float m_AspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_AspectRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_AspectRatio)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000149BC File Offset: 0x00012BBC
		// (set) Token: 0x06000384 RID: 900 RVA: 0x0000333A File Offset: 0x0000153A
		public unsafe RectTransform m_Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000149EC File Offset: 0x00012BEC
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00003359 File Offset: 0x00001559
		public unsafe bool m_DelayedSetDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_DelayedSetDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_DelayedSetDirty)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00014A14 File Offset: 0x00012C14
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00003374 File Offset: 0x00001574
		public unsafe bool m_DoesParentExist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_DoesParentExist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_DoesParentExist)) = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00014A3C File Offset: 0x00012C3C
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0000338F File Offset: 0x0000158F
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioFitter.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_m_AspectMode;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_m_AspectRatio;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr_m_DelayedSetDirty;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr_m_DoesParentExist;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_get_aspectMode_Public_get_AspectMode_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_set_aspectMode_Public_set_Void_AspectMode_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_get_aspectRatio_Public_get_Single_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_set_aspectRatio_Public_set_Void_Single_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRect_Private_Void_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_GetSizeDeltaToProduceSize_Private_Single_Single_Int32_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_GetParentSize_Private_Vector2_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_IsComponentValidOnObject_Public_Boolean_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_IsAspectModeValid_Public_Boolean_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_DoesParentExists_Private_Boolean_0;

		// Token: 0x02000095 RID: 149
		public enum AspectMode
		{
			// Token: 0x0400093D RID: 2365
			None,
			// Token: 0x0400093E RID: 2366
			WidthControlsHeight,
			// Token: 0x0400093F RID: 2367
			HeightControlsWidth,
			// Token: 0x04000940 RID: 2368
			FitInParent,
			// Token: 0x04000941 RID: 2369
			EnvelopeParent
		}
	}
}
