using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004C RID: 76
	public class AxisEventData : BaseEventData
	{
		// Token: 0x060008C7 RID: 2247 RVA: 0x00029678 File Offset: 0x00027878
		// Note: this type is marked as 'beforefieldinit'.
		static AxisEventData()
		{
			Il2CppClassPointerStore<AxisEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "AxisEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr);
			AxisEventData.NativeFieldInfoPtr__moveVector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, "<moveVector>k__BackingField");
			AxisEventData.NativeFieldInfoPtr__moveDir_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, "<moveDir>k__BackingField");
			AxisEventData.NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664595);
			AxisEventData.NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664596);
			AxisEventData.NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664597);
			AxisEventData.NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664598);
			AxisEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr, 100664599);
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00029734 File Offset: 0x00027934
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00029770 File Offset: 0x00027970
		public unsafe Vector2 moveVector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x000297B0 File Offset: 0x000279B0
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x000297EC File Offset: 0x000279EC
		public unsafe MoveDirection moveDir
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0002982C File Offset: 0x00027A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120910, XrefRangeEnd = 120912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisEventData(EventSystem eventSystem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00005002 File Offset: 0x00003202
		public AxisEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x00029878 File Offset: 0x00027A78
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0000500B File Offset: 0x0000320B
		public unsafe Vector2 _moveVector_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveVector_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveVector_k__BackingField)) = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x000298A0 File Offset: 0x00027AA0
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00005026 File Offset: 0x00003226
		public unsafe MoveDirection _moveDir_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveDir_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisEventData.NativeFieldInfoPtr__moveDir_k__BackingField)) = value;
			}
		}

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeFieldInfoPtr__moveVector_k__BackingField;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr__moveDir_k__BackingField;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_get_moveVector_Public_get_Vector2_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_set_moveVector_Public_set_Void_Vector2_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_get_moveDir_Public_get_MoveDirection_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_set_moveDir_Public_set_Void_MoveDirection_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;
	}
}
