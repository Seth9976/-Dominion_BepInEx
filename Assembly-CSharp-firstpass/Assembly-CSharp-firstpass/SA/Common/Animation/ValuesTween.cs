using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace SA.Common.Animation
{
	// Token: 0x0200031C RID: 796
	public class ValuesTween : MonoBehaviour
	{
		// Token: 0x06002DAA RID: 11690 RVA: 0x000C28F0 File Offset: 0x000C0AF0
		// Note: this type is marked as 'beforefieldinit'.
		static ValuesTween()
		{
			Il2CppClassPointerStore<ValuesTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Animation", "ValuesTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr);
			ValuesTween.NativeFieldInfoPtr_OnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, "OnComplete");
			ValuesTween.NativeFieldInfoPtr_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, "OnValueChanged");
			ValuesTween.NativeFieldInfoPtr_OnVectorValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, "OnVectorValueChanged");
			ValuesTween.NativeFieldInfoPtr_DestoryGameObjectOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, "DestoryGameObjectOnComplete");
			ValuesTween.NativeFieldInfoPtr_FinalFloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, "FinalFloatValue");
			ValuesTween.NativeFieldInfoPtr_FinalVectorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, "FinalVectorValue");
			ValuesTween.NativeMethodInfoPtr_add_OnComplete_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669262);
			ValuesTween.NativeMethodInfoPtr_remove_OnComplete_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669263);
			ValuesTween.NativeMethodInfoPtr_add_OnValueChanged_Public_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669264);
			ValuesTween.NativeMethodInfoPtr_remove_OnValueChanged_Public_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669265);
			ValuesTween.NativeMethodInfoPtr_add_OnVectorValueChanged_Public_add_Void_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669266);
			ValuesTween.NativeMethodInfoPtr_remove_OnVectorValueChanged_Public_rem_Void_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669267);
			ValuesTween.NativeMethodInfoPtr_Create_Public_Static_ValuesTween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669268);
			ValuesTween.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669269);
			ValuesTween.NativeMethodInfoPtr_ValueTo_Public_Void_Single_Single_Single_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669270);
			ValuesTween.NativeMethodInfoPtr_VectorTo_Public_Void_Vector3_Vector3_Single_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669271);
			ValuesTween.NativeMethodInfoPtr_ScaleTo_Public_Void_Vector3_Vector3_Single_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669272);
			ValuesTween.NativeMethodInfoPtr_VectorToS_Public_Void_Vector3_Vector3_Single_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669273);
			ValuesTween.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669274);
			ValuesTween.NativeMethodInfoPtr_onTweenComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669275);
			ValuesTween.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, 100669276);
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x000C2AC4 File Offset: 0x000C0CC4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 212796, RefRangeEnd = 212804, XrefRangeStart = 212792, XrefRangeEnd = 212796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnComplete(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_add_OnComplete_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x000C2B08 File Offset: 0x000C0D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212804, XrefRangeEnd = 212808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnComplete(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_remove_OnComplete_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x000C2B4C File Offset: 0x000C0D4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 212812, RefRangeEnd = 212818, XrefRangeStart = 212808, XrefRangeEnd = 212812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnValueChanged(Action<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_add_OnValueChanged_Public_add_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000C2B90 File Offset: 0x000C0D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212818, XrefRangeEnd = 212822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnValueChanged(Action<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_remove_OnValueChanged_Public_rem_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x000C2BD4 File Offset: 0x000C0DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212822, XrefRangeEnd = 212826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnVectorValueChanged(Action<Vector3> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_add_OnVectorValueChanged_Public_add_Void_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x000C2C18 File Offset: 0x000C0E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212826, XrefRangeEnd = 212830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnVectorValueChanged(Action<Vector3> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_remove_OnVectorValueChanged_Public_rem_Void_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000C2C5C File Offset: 0x000C0E5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 212840, RefRangeEnd = 212846, XrefRangeStart = 212830, XrefRangeEnd = 212840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValuesTween Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_Create_Public_Static_ValuesTween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValuesTween>(intPtr3) : null;
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000C2C90 File Offset: 0x000C0E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212846, XrefRangeEnd = 212856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x000C2CC4 File Offset: 0x000C0EC4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 212907, RefRangeEnd = 212913, XrefRangeStart = 212856, XrefRangeEnd = 212907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueTo(float from, float to, float time, EaseType easeType = EaseType.linear)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_ValueTo_Public_Void_Single_Single_Single_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x000C2D2C File Offset: 0x000C0F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212963, RefRangeEnd = 212964, XrefRangeStart = 212913, XrefRangeEnd = 212963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VectorTo(Vector3 from, Vector3 to, float time, EaseType easeType = EaseType.linear)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_VectorTo_Public_Void_Vector3_Vector3_Single_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000C2D94 File Offset: 0x000C0F94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213014, RefRangeEnd = 213015, XrefRangeStart = 212964, XrefRangeEnd = 213014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScaleTo(Vector3 from, Vector3 to, float time, EaseType easeType = EaseType.linear)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_ScaleTo_Public_Void_Vector3_Vector3_Single_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000C2DFC File Offset: 0x000C0FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213015, XrefRangeEnd = 213065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VectorToS(Vector3 from, Vector3 to, float speed, EaseType easeType = EaseType.linear)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_VectorToS_Public_Void_Vector3_Vector3_Single_EaseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x000C2E64 File Offset: 0x000C1064
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 213075, RefRangeEnd = 213080, XrefRangeStart = 213065, XrefRangeEnd = 213075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000C2E98 File Offset: 0x000C1098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213080, XrefRangeEnd = 213093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onTweenComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr_onTweenComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000C2ECC File Offset: 0x000C10CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213093, XrefRangeEnd = 213136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValuesTween()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00011B30 File Offset: 0x0000FD30
		public ValuesTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002DBB RID: 11707 RVA: 0x000C2F08 File Offset: 0x000C1108
		// (set) Token: 0x06002DBC RID: 11708 RVA: 0x00011B39 File Offset: 0x0000FD39
		public unsafe Action OnComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_OnComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_OnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002DBD RID: 11709 RVA: 0x000C2F38 File Offset: 0x000C1138
		// (set) Token: 0x06002DBE RID: 11710 RVA: 0x00011B58 File Offset: 0x0000FD58
		public unsafe Action<float> OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002DBF RID: 11711 RVA: 0x000C2F68 File Offset: 0x000C1168
		// (set) Token: 0x06002DC0 RID: 11712 RVA: 0x00011B77 File Offset: 0x0000FD77
		public unsafe Action<Vector3> OnVectorValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_OnVectorValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_OnVectorValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x000C2F98 File Offset: 0x000C1198
		// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x00011B96 File Offset: 0x0000FD96
		public unsafe bool DestoryGameObjectOnComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_DestoryGameObjectOnComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_DestoryGameObjectOnComplete)) = value;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000C2FC0 File Offset: 0x000C11C0
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x00011BB1 File Offset: 0x0000FDB1
		public unsafe float FinalFloatValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_FinalFloatValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_FinalFloatValue)) = value;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000C2FE8 File Offset: 0x000C11E8
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x00011BCC File Offset: 0x0000FDCC
		public unsafe Vector3 FinalVectorValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_FinalVectorValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValuesTween.NativeFieldInfoPtr_FinalVectorValue)) = value;
			}
		}

		// Token: 0x04002BA9 RID: 11177
		private static readonly IntPtr NativeFieldInfoPtr_OnComplete;

		// Token: 0x04002BAA RID: 11178
		private static readonly IntPtr NativeFieldInfoPtr_OnValueChanged;

		// Token: 0x04002BAB RID: 11179
		private static readonly IntPtr NativeFieldInfoPtr_OnVectorValueChanged;

		// Token: 0x04002BAC RID: 11180
		private static readonly IntPtr NativeFieldInfoPtr_DestoryGameObjectOnComplete;

		// Token: 0x04002BAD RID: 11181
		private static readonly IntPtr NativeFieldInfoPtr_FinalFloatValue;

		// Token: 0x04002BAE RID: 11182
		private static readonly IntPtr NativeFieldInfoPtr_FinalVectorValue;

		// Token: 0x04002BAF RID: 11183
		private static readonly IntPtr NativeMethodInfoPtr_add_OnComplete_Public_add_Void_Action_0;

		// Token: 0x04002BB0 RID: 11184
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnComplete_Public_rem_Void_Action_0;

		// Token: 0x04002BB1 RID: 11185
		private static readonly IntPtr NativeMethodInfoPtr_add_OnValueChanged_Public_add_Void_Action_1_Single_0;

		// Token: 0x04002BB2 RID: 11186
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnValueChanged_Public_rem_Void_Action_1_Single_0;

		// Token: 0x04002BB3 RID: 11187
		private static readonly IntPtr NativeMethodInfoPtr_add_OnVectorValueChanged_Public_add_Void_Action_1_Vector3_0;

		// Token: 0x04002BB4 RID: 11188
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnVectorValueChanged_Public_rem_Void_Action_1_Vector3_0;

		// Token: 0x04002BB5 RID: 11189
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ValuesTween_0;

		// Token: 0x04002BB6 RID: 11190
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002BB7 RID: 11191
		private static readonly IntPtr NativeMethodInfoPtr_ValueTo_Public_Void_Single_Single_Single_EaseType_0;

		// Token: 0x04002BB8 RID: 11192
		private static readonly IntPtr NativeMethodInfoPtr_VectorTo_Public_Void_Vector3_Vector3_Single_EaseType_0;

		// Token: 0x04002BB9 RID: 11193
		private static readonly IntPtr NativeMethodInfoPtr_ScaleTo_Public_Void_Vector3_Vector3_Single_EaseType_0;

		// Token: 0x04002BBA RID: 11194
		private static readonly IntPtr NativeMethodInfoPtr_VectorToS_Public_Void_Vector3_Vector3_Single_EaseType_0;

		// Token: 0x04002BBB RID: 11195
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04002BBC RID: 11196
		private static readonly IntPtr NativeMethodInfoPtr_onTweenComplete_Private_Void_0;

		// Token: 0x04002BBD RID: 11197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D3 RID: 979
		[ObfuscatedName("SA.Common.Animation.ValuesTween+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060038B6 RID: 14518 RVA: 0x000E6998 File Offset: 0x000E4B98
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValuesTween>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr);
				ValuesTween.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr, "<>9");
				ValuesTween.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr, "<>9__20_0");
				ValuesTween.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr, "<>9__20_1");
				ValuesTween.__c.NativeFieldInfoPtr___9__20_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr, "<>9__20_2");
				ValuesTween.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr, 100670467);
				ValuesTween.__c.NativeMethodInfoPtr___ctor_b__20_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr, 100670468);
				ValuesTween.__c.NativeMethodInfoPtr___ctor_b__20_1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr, 100670469);
				ValuesTween.__c.NativeMethodInfoPtr___ctor_b__20_2_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr, 100670470);
			}

			// Token: 0x060038B7 RID: 14519 RVA: 0x000E6A64 File Offset: 0x000E4C64
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValuesTween.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038B8 RID: 14520 RVA: 0x000E6AA0 File Offset: 0x000E4CA0
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__20_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.__c.NativeMethodInfoPtr___ctor_b__20_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038B9 RID: 14521 RVA: 0x000E6AD4 File Offset: 0x000E4CD4
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__20_1(float <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <p0>;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.__c.NativeMethodInfoPtr___ctor_b__20_1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038BA RID: 14522 RVA: 0x000E6B14 File Offset: 0x000E4D14
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__20_2(Vector3 <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <p0>;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValuesTween.__c.NativeMethodInfoPtr___ctor_b__20_2_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038BB RID: 14523 RVA: 0x00015F8D File Offset: 0x0001418D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D6A RID: 3434
			// (get) Token: 0x060038BC RID: 14524 RVA: 0x000E6B54 File Offset: 0x000E4D54
			// (set) Token: 0x060038BD RID: 14525 RVA: 0x00015F96 File Offset: 0x00014196
			public unsafe static ValuesTween.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValuesTween.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValuesTween.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValuesTween.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6B RID: 3435
			// (get) Token: 0x060038BE RID: 14526 RVA: 0x000E6B7C File Offset: 0x000E4D7C
			// (set) Token: 0x060038BF RID: 14527 RVA: 0x00015FA8 File Offset: 0x000141A8
			public unsafe static Action __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValuesTween.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValuesTween.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6C RID: 3436
			// (get) Token: 0x060038C0 RID: 14528 RVA: 0x000E6BA4 File Offset: 0x000E4DA4
			// (set) Token: 0x060038C1 RID: 14529 RVA: 0x00015FBA File Offset: 0x000141BA
			public unsafe static Action<float> __9__20_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValuesTween.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValuesTween.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6D RID: 3437
			// (get) Token: 0x060038C2 RID: 14530 RVA: 0x000E6BCC File Offset: 0x000E4DCC
			// (set) Token: 0x060038C3 RID: 14531 RVA: 0x00015FCC File Offset: 0x000141CC
			public unsafe static Action<Vector3> __9__20_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValuesTween.__c.NativeFieldInfoPtr___9__20_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValuesTween.__c.NativeFieldInfoPtr___9__20_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003319 RID: 13081
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400331A RID: 13082
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400331B RID: 13083
			private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

			// Token: 0x0400331C RID: 13084
			private static readonly IntPtr NativeFieldInfoPtr___9__20_2;

			// Token: 0x0400331D RID: 13085
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400331E RID: 13086
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__20_0_Internal_Void_0;

			// Token: 0x0400331F RID: 13087
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__20_1_Internal_Void_Single_0;

			// Token: 0x04003320 RID: 13088
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__20_2_Internal_Void_Vector3_0;
		}
	}
}
