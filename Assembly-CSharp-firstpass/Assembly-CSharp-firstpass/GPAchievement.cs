using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000045 RID: 69
[Serializable]
public class GPAchievement : global::Il2CppSystem.Object
{
	// Token: 0x060005A0 RID: 1440 RVA: 0x0002A42C File Offset: 0x0002862C
	// Note: this type is marked as 'beforefieldinit'.
	static GPAchievement()
	{
		Il2CppClassPointerStore<GPAchievement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GPAchievement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr);
		GPAchievement.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, "IsOpen");
		GPAchievement.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, "_id");
		GPAchievement.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, "_name");
		GPAchievement.NativeFieldInfoPtr__description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, "_description");
		GPAchievement.NativeFieldInfoPtr__Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, "_Texture");
		GPAchievement.NativeFieldInfoPtr__currentSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, "_currentSteps");
		GPAchievement.NativeFieldInfoPtr__totalSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, "_totalSteps");
		GPAchievement.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, "_type");
		GPAchievement.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, "_state");
		GPAchievement.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100663992);
		GPAchievement.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100663993);
		GPAchievement.NativeMethodInfoPtr_get_id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100663994);
		GPAchievement.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100663995);
		GPAchievement.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100663996);
		GPAchievement.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100663997);
		GPAchievement.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100663998);
		GPAchievement.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100663999);
		GPAchievement.NativeMethodInfoPtr_get_description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664000);
		GPAchievement.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664001);
		GPAchievement.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664002);
		GPAchievement.NativeMethodInfoPtr_get_currentSteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664003);
		GPAchievement.NativeMethodInfoPtr_get_CurrentSteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664004);
		GPAchievement.NativeMethodInfoPtr_get_totalSteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664005);
		GPAchievement.NativeMethodInfoPtr_get_TotalSteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664006);
		GPAchievement.NativeMethodInfoPtr_get_type_Public_get_GPAchievementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664007);
		GPAchievement.NativeMethodInfoPtr_get_Type_Public_get_GPAchievementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664008);
		GPAchievement.NativeMethodInfoPtr_get_state_Public_get_GPAchievementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664009);
		GPAchievement.NativeMethodInfoPtr_get_State_Public_get_GPAchievementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664010);
		GPAchievement.NativeMethodInfoPtr_get_Texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664011);
		GPAchievement.NativeMethodInfoPtr_set_Texture_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr, 100664012);
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x0002A6B4 File Offset: 0x000288B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166240, XrefRangeEnd = 166245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPAchievement(string id, string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x0002A714 File Offset: 0x00028914
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166259, RefRangeEnd = 166260, XrefRangeStart = 166245, XrefRangeEnd = 166259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPAchievement(string aId, string aName, string aDescr, string aCurentSteps, string aTotalSteps, string aState, string aType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPAchievement>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(aId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aName);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aDescr);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aCurentSteps);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aTotalSteps);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aState);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aType);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0002A7D0 File Offset: 0x000289D0
	public unsafe string id
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0002A808 File Offset: 0x00028A08
	// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0002A840 File Offset: 0x00028A40
	public unsafe string Id
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0002A884 File Offset: 0x00028A84
	public unsafe string name
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0002A8BC File Offset: 0x00028ABC
	// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0002A8F4 File Offset: 0x00028AF4
	public unsafe string Name
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0002A938 File Offset: 0x00028B38
	public unsafe string description
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x060005AA RID: 1450 RVA: 0x0002A970 File Offset: 0x00028B70
	// (set) Token: 0x060005AB RID: 1451 RVA: 0x0002A9A8 File Offset: 0x00028BA8
	public unsafe string Description
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x060005AC RID: 1452 RVA: 0x0002A9EC File Offset: 0x00028BEC
	public unsafe int currentSteps
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_currentSteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x060005AD RID: 1453 RVA: 0x0002AA28 File Offset: 0x00028C28
	public unsafe int CurrentSteps
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_CurrentSteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x060005AE RID: 1454 RVA: 0x0002AA64 File Offset: 0x00028C64
	public unsafe int totalSteps
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_totalSteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x060005AF RID: 1455 RVA: 0x0002AAA0 File Offset: 0x00028CA0
	public unsafe int TotalSteps
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_TotalSteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0002AADC File Offset: 0x00028CDC
	public unsafe GPAchievementType type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_type_Public_get_GPAchievementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0002AB18 File Offset: 0x00028D18
	public unsafe GPAchievementType Type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_Type_Public_get_GPAchievementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0002AB54 File Offset: 0x00028D54
	public unsafe GPAchievementState state
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_state_Public_get_GPAchievementState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0002AB90 File Offset: 0x00028D90
	public unsafe GPAchievementState State
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_State_Public_get_GPAchievementState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0002ABCC File Offset: 0x00028DCC
	// (set) Token: 0x060005B5 RID: 1461 RVA: 0x0002AC0C File Offset: 0x00028E0C
	public unsafe Texture2D Texture
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_get_Texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPAchievement.NativeMethodInfoPtr_set_Texture_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x000043A2 File Offset: 0x000025A2
	public GPAchievement(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0002AC50 File Offset: 0x00028E50
	// (set) Token: 0x060005B8 RID: 1464 RVA: 0x000043AB File Offset: 0x000025AB
	public unsafe bool IsOpen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr_IsOpen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr_IsOpen)) = value;
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0002AC78 File Offset: 0x00028E78
	// (set) Token: 0x060005BA RID: 1466 RVA: 0x000043C6 File Offset: 0x000025C6
	public unsafe string _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x060005BB RID: 1467 RVA: 0x0002ACA0 File Offset: 0x00028EA0
	// (set) Token: 0x060005BC RID: 1468 RVA: 0x000043E5 File Offset: 0x000025E5
	public unsafe string _name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x060005BD RID: 1469 RVA: 0x0002ACC8 File Offset: 0x00028EC8
	// (set) Token: 0x060005BE RID: 1470 RVA: 0x00004404 File Offset: 0x00002604
	public unsafe string _description
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__description);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__description), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x060005BF RID: 1471 RVA: 0x0002ACF0 File Offset: 0x00028EF0
	// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00004423 File Offset: 0x00002623
	public unsafe Texture2D _Texture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__Texture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0002AD20 File Offset: 0x00028F20
	// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00004442 File Offset: 0x00002642
	public unsafe int _currentSteps
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__currentSteps);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__currentSteps)) = value;
		}
	}

	// Token: 0x170001CF RID: 463
	// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0002AD48 File Offset: 0x00028F48
	// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0000445D File Offset: 0x0000265D
	public unsafe int _totalSteps
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__totalSteps);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__totalSteps)) = value;
		}
	}

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0002AD70 File Offset: 0x00028F70
	// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00004478 File Offset: 0x00002678
	public unsafe GPAchievementType _type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__type);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__type)) = value;
		}
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0002AD98 File Offset: 0x00028F98
	// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00004493 File Offset: 0x00002693
	public unsafe GPAchievementState _state
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__state);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPAchievement.NativeFieldInfoPtr__state)) = value;
		}
	}

	// Token: 0x040004BA RID: 1210
	private static readonly IntPtr NativeFieldInfoPtr_IsOpen;

	// Token: 0x040004BB RID: 1211
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x040004BC RID: 1212
	private static readonly IntPtr NativeFieldInfoPtr__name;

	// Token: 0x040004BD RID: 1213
	private static readonly IntPtr NativeFieldInfoPtr__description;

	// Token: 0x040004BE RID: 1214
	private static readonly IntPtr NativeFieldInfoPtr__Texture;

	// Token: 0x040004BF RID: 1215
	private static readonly IntPtr NativeFieldInfoPtr__currentSteps;

	// Token: 0x040004C0 RID: 1216
	private static readonly IntPtr NativeFieldInfoPtr__totalSteps;

	// Token: 0x040004C1 RID: 1217
	private static readonly IntPtr NativeFieldInfoPtr__type;

	// Token: 0x040004C2 RID: 1218
	private static readonly IntPtr NativeFieldInfoPtr__state;

	// Token: 0x040004C3 RID: 1219
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x040004C4 RID: 1220
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_String_0;

	// Token: 0x040004C5 RID: 1221
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_String_0;

	// Token: 0x040004C6 RID: 1222
	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

	// Token: 0x040004C7 RID: 1223
	private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;

	// Token: 0x040004C8 RID: 1224
	private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	// Token: 0x040004C9 RID: 1225
	private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

	// Token: 0x040004CA RID: 1226
	private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

	// Token: 0x040004CB RID: 1227
	private static readonly IntPtr NativeMethodInfoPtr_get_description_Public_get_String_0;

	// Token: 0x040004CC RID: 1228
	private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

	// Token: 0x040004CD RID: 1229
	private static readonly IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;

	// Token: 0x040004CE RID: 1230
	private static readonly IntPtr NativeMethodInfoPtr_get_currentSteps_Public_get_Int32_0;

	// Token: 0x040004CF RID: 1231
	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSteps_Public_get_Int32_0;

	// Token: 0x040004D0 RID: 1232
	private static readonly IntPtr NativeMethodInfoPtr_get_totalSteps_Public_get_Int32_0;

	// Token: 0x040004D1 RID: 1233
	private static readonly IntPtr NativeMethodInfoPtr_get_TotalSteps_Public_get_Int32_0;

	// Token: 0x040004D2 RID: 1234
	private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_GPAchievementType_0;

	// Token: 0x040004D3 RID: 1235
	private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_GPAchievementType_0;

	// Token: 0x040004D4 RID: 1236
	private static readonly IntPtr NativeMethodInfoPtr_get_state_Public_get_GPAchievementState_0;

	// Token: 0x040004D5 RID: 1237
	private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_GPAchievementState_0;

	// Token: 0x040004D6 RID: 1238
	private static readonly IntPtr NativeMethodInfoPtr_get_Texture_Public_get_Texture2D_0;

	// Token: 0x040004D7 RID: 1239
	private static readonly IntPtr NativeMethodInfoPtr_set_Texture_Public_set_Void_Texture2D_0;
}
