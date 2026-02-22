using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using SA.Foundation.Events;
using UnityEngine;

namespace SA.Foundation.Animation
{
	// Token: 0x02000039 RID: 57
	public class SA_ValuesTween : MonoBehaviour
	{
		// Token: 0x060001AF RID: 431 RVA: 0x0000A598 File Offset: 0x00008798
		// Note: this type is marked as 'beforefieldinit'.
		static SA_ValuesTween()
		{
			Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Animation", "SA_ValuesTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr);
			SA_ValuesTween.NativeFieldInfoPtr_m_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, "m_onComplete");
			SA_ValuesTween.NativeFieldInfoPtr_m_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, "m_onValueChanged");
			SA_ValuesTween.NativeFieldInfoPtr_m_onVectorValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, "m_onVectorValueChanged");
			SA_ValuesTween.NativeFieldInfoPtr_DestoryGameObjectOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, "DestoryGameObjectOnComplete");
			SA_ValuesTween.NativeFieldInfoPtr_FinalFloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, "FinalFloatValue");
			SA_ValuesTween.NativeFieldInfoPtr_FinalVectorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, "FinalVectorValue");
			SA_ValuesTween.NativeMethodInfoPtr_Create_Public_Static_SA_ValuesTween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663559);
			SA_ValuesTween.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663560);
			SA_ValuesTween.NativeMethodInfoPtr_ValueTo_Public_Void_Single_Single_Single_SA_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663561);
			SA_ValuesTween.NativeMethodInfoPtr_VectorTo_Public_Void_Vector3_Vector3_Single_SA_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663562);
			SA_ValuesTween.NativeMethodInfoPtr_RotateTo_Public_Void_Vector3_Vector3_Single_SA_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663563);
			SA_ValuesTween.NativeMethodInfoPtr_ScaleTo_Public_Void_Vector3_Vector3_Single_SA_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663564);
			SA_ValuesTween.NativeMethodInfoPtr_VectorToS_Public_Void_Vector3_Vector3_Single_SA_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663565);
			SA_ValuesTween.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663566);
			SA_ValuesTween.NativeMethodInfoPtr_get_OnComplete_Public_get_SA_iSafeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663567);
			SA_ValuesTween.NativeMethodInfoPtr_get_OnValueChanged_Public_get_SA_iSafeEvent_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663568);
			SA_ValuesTween.NativeMethodInfoPtr_get_OnVectorValueChanged_Public_get_SA_iSafeEvent_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663569);
			SA_ValuesTween.NativeMethodInfoPtr_onTweenComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663570);
			SA_ValuesTween.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr, 100663571);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000A744 File Offset: 0x00008944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100627, XrefRangeEnd = 100641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SA_ValuesTween Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_Create_Public_Static_SA_ValuesTween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_ValuesTween>(intPtr3) : null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000A778 File Offset: 0x00008978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100641, XrefRangeEnd = 100657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000A7AC File Offset: 0x000089AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100657, XrefRangeEnd = 100708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueTo(float from, float to, float time, SA_EaseType easeType = SA_EaseType.linear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_ValueTo_Public_Void_Single_Single_Single_SA_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000A814 File Offset: 0x00008A14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100758, RefRangeEnd = 100760, XrefRangeStart = 100708, XrefRangeEnd = 100758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VectorTo(Vector3 from, Vector3 to, float time, SA_EaseType easeType = SA_EaseType.linear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_VectorTo_Public_Void_Vector3_Vector3_Single_SA_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000A87C File Offset: 0x00008A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100811, RefRangeEnd = 100812, XrefRangeStart = 100760, XrefRangeEnd = 100811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateTo(Vector3 from, Vector3 to, float time, SA_EaseType easeType = SA_EaseType.linear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_RotateTo_Public_Void_Vector3_Vector3_Single_SA_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000A8E4 File Offset: 0x00008AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100862, RefRangeEnd = 100863, XrefRangeStart = 100812, XrefRangeEnd = 100862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScaleTo(Vector3 from, Vector3 to, float time, SA_EaseType easeType = SA_EaseType.linear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_ScaleTo_Public_Void_Vector3_Vector3_Single_SA_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000A94C File Offset: 0x00008B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100863, XrefRangeEnd = 100913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VectorToS(Vector3 from, Vector3 to, float speed, SA_EaseType easeType = SA_EaseType.linear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_VectorToS_Public_Void_Vector3_Vector3_Single_SA_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000A9B4 File Offset: 0x00008BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100913, XrefRangeEnd = 100923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000A9E8 File Offset: 0x00008BE8
		public unsafe SA_iSafeEvent OnComplete
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_get_OnComplete_Public_get_SA_iSafeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iSafeEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000AA28 File Offset: 0x00008C28
		public unsafe SA_iSafeEvent<float> OnValueChanged
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_get_OnValueChanged_Public_get_SA_iSafeEvent_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iSafeEvent<float>>(intPtr3) : null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000AA68 File Offset: 0x00008C68
		public unsafe SA_iSafeEvent<Vector3> OnVectorValueChanged
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_get_OnVectorValueChanged_Public_get_SA_iSafeEvent_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iSafeEvent<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000AAA8 File Offset: 0x00008CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100923, XrefRangeEnd = 100940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onTweenComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr_onTweenComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000AADC File Offset: 0x00008CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100940, XrefRangeEnd = 100963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_ValuesTween()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ValuesTween>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ValuesTween.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000263D File Offset: 0x0000083D
		public SA_ValuesTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000AB18 File Offset: 0x00008D18
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00002646 File Offset: 0x00000846
		public unsafe SA_Event m_onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_m_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_m_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000AB48 File Offset: 0x00008D48
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002665 File Offset: 0x00000865
		public unsafe SA_Event<float> m_onValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_m_onValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Event<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_m_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000AB78 File Offset: 0x00008D78
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002684 File Offset: 0x00000884
		public unsafe SA_Event<Vector3> m_onVectorValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_m_onVectorValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Event<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_m_onVectorValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000026A3 File Offset: 0x000008A3
		public unsafe bool DestoryGameObjectOnComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_DestoryGameObjectOnComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_DestoryGameObjectOnComplete)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000ABD0 File Offset: 0x00008DD0
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x000026BE File Offset: 0x000008BE
		public unsafe float FinalFloatValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_FinalFloatValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_FinalFloatValue)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000ABF8 File Offset: 0x00008DF8
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000026D9 File Offset: 0x000008D9
		public unsafe Vector3 FinalVectorValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_FinalVectorValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ValuesTween.NativeFieldInfoPtr_FinalVectorValue)) = value;
			}
		}

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_m_onComplete;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_m_onValueChanged;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_m_onVectorValueChanged;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_DestoryGameObjectOnComplete;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_FinalFloatValue;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_FinalVectorValue;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SA_ValuesTween_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_ValueTo_Public_Void_Single_Single_Single_SA_EaseType_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_VectorTo_Public_Void_Vector3_Vector3_Single_SA_EaseType_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_RotateTo_Public_Void_Vector3_Vector3_Single_SA_EaseType_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_ScaleTo_Public_Void_Vector3_Vector3_Single_SA_EaseType_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_VectorToS_Public_Void_Vector3_Vector3_Single_SA_EaseType_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_get_OnComplete_Public_get_SA_iSafeEvent_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_get_OnValueChanged_Public_get_SA_iSafeEvent_1_Single_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_get_OnVectorValueChanged_Public_get_SA_iSafeEvent_1_Vector3_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_onTweenComplete_Private_Void_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
