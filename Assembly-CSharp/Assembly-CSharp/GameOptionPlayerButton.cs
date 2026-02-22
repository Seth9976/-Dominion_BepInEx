using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

// Token: 0x02000030 RID: 48
public class GameOptionPlayerButton : MonoBehaviour
{
	// Token: 0x0600091E RID: 2334 RVA: 0x00034B68 File Offset: 0x00032D68
	// Note: this type is marked as 'beforefieldinit'.
	static GameOptionPlayerButton()
	{
		Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameOptionPlayerButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr);
		GameOptionPlayerButton.NativeFieldInfoPtr_m_TextPlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, "m_TextPlayerName");
		GameOptionPlayerButton.NativeFieldInfoPtr_m_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, "m_Avatar");
		GameOptionPlayerButton.NativeFieldInfoPtr_m_HonorObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, "m_HonorObj");
		GameOptionPlayerButton.NativeFieldInfoPtr_m_HonorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, "m_HonorText");
		GameOptionPlayerButton.NativeFieldInfoPtr_m_InsightObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, "m_InsightObj");
		GameOptionPlayerButton.NativeFieldInfoPtr_m_InsightText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, "m_InsightText");
		GameOptionPlayerButton.NativeFieldInfoPtr_m_ActivateSelectionHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, "m_ActivateSelectionHint");
		GameOptionPlayerButton.NativeFieldInfoPtr_m_ActivateSelectionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, "m_ActivateSelectionID");
		GameOptionPlayerButton.NativeMethodInfoPtr_SetPlayerOption_Public_Void_UInt16_UInt16_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, 100663908);
		GameOptionPlayerButton.NativeMethodInfoPtr_SetAvailable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, 100663909);
		GameOptionPlayerButton.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, 100663910);
		GameOptionPlayerButton.NativeMethodInfoPtr_OnGameOptionPlayerButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, 100663911);
		GameOptionPlayerButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr, 100663912);
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00034C9C File Offset: 0x00032E9C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235407, RefRangeEnd = 235410, XrefRangeStart = 235380, XrefRangeEnd = 235407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerOption(ushort selectionHint, ushort selectionID, string playerName, int avatarIndex, string honorString, string insightString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionHint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerName);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref avatarIndex;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(honorString);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(insightString);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionPlayerButton.NativeMethodInfoPtr_SetPlayerOption_Public_Void_UInt16_UInt16_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00034D30 File Offset: 0x00032F30
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 235352, RefRangeEnd = 235360, XrefRangeStart = 235352, XrefRangeEnd = 235360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAvailable(bool bAvailable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bAvailable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionPlayerButton.NativeMethodInfoPtr_SetAvailable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00034D70 File Offset: 0x00032F70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235410, XrefRangeEnd = 235419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSelectionState(bool bHighlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionPlayerButton.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00034DB0 File Offset: 0x00032FB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235419, XrefRangeEnd = 235427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameOptionPlayerButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionPlayerButton.NativeMethodInfoPtr_OnGameOptionPlayerButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00034DE4 File Offset: 0x00032FE4
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameOptionPlayerButton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameOptionPlayerButton>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameOptionPlayerButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00007A97 File Offset: 0x00005C97
	public GameOptionPlayerButton(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x06000925 RID: 2341 RVA: 0x00034E20 File Offset: 0x00033020
	// (set) Token: 0x06000926 RID: 2342 RVA: 0x00007AA0 File Offset: 0x00005CA0
	public unsafe TextMeshProUGUI m_TextPlayerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_TextPlayerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_TextPlayerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x06000927 RID: 2343 RVA: 0x00034E50 File Offset: 0x00033050
	// (set) Token: 0x06000928 RID: 2344 RVA: 0x00007ABF File Offset: 0x00005CBF
	public unsafe Avatar_UI m_Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_Avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700033B RID: 827
	// (get) Token: 0x06000929 RID: 2345 RVA: 0x00034E80 File Offset: 0x00033080
	// (set) Token: 0x0600092A RID: 2346 RVA: 0x00007ADE File Offset: 0x00005CDE
	public unsafe GameObject m_HonorObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_HonorObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_HonorObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x0600092B RID: 2347 RVA: 0x00034EB0 File Offset: 0x000330B0
	// (set) Token: 0x0600092C RID: 2348 RVA: 0x00007AFD File Offset: 0x00005CFD
	public unsafe TextMeshProUGUI m_HonorText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_HonorText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_HonorText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x0600092D RID: 2349 RVA: 0x00034EE0 File Offset: 0x000330E0
	// (set) Token: 0x0600092E RID: 2350 RVA: 0x00007B1C File Offset: 0x00005D1C
	public unsafe GameObject m_InsightObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_InsightObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_InsightObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x0600092F RID: 2351 RVA: 0x00034F10 File Offset: 0x00033110
	// (set) Token: 0x06000930 RID: 2352 RVA: 0x00007B3B File Offset: 0x00005D3B
	public unsafe TextMeshProUGUI m_InsightText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_InsightText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_InsightText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x06000931 RID: 2353 RVA: 0x00034F40 File Offset: 0x00033140
	// (set) Token: 0x06000932 RID: 2354 RVA: 0x00007B5A File Offset: 0x00005D5A
	public unsafe ushort m_ActivateSelectionHint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_ActivateSelectionHint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_ActivateSelectionHint)) = value;
		}
	}

	// Token: 0x17000340 RID: 832
	// (get) Token: 0x06000933 RID: 2355 RVA: 0x00034F68 File Offset: 0x00033168
	// (set) Token: 0x06000934 RID: 2356 RVA: 0x00007B75 File Offset: 0x00005D75
	public unsafe ushort m_ActivateSelectionID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_ActivateSelectionID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameOptionPlayerButton.NativeFieldInfoPtr_m_ActivateSelectionID)) = value;
		}
	}

	// Token: 0x040005A8 RID: 1448
	private static readonly IntPtr NativeFieldInfoPtr_m_TextPlayerName;

	// Token: 0x040005A9 RID: 1449
	private static readonly IntPtr NativeFieldInfoPtr_m_Avatar;

	// Token: 0x040005AA RID: 1450
	private static readonly IntPtr NativeFieldInfoPtr_m_HonorObj;

	// Token: 0x040005AB RID: 1451
	private static readonly IntPtr NativeFieldInfoPtr_m_HonorText;

	// Token: 0x040005AC RID: 1452
	private static readonly IntPtr NativeFieldInfoPtr_m_InsightObj;

	// Token: 0x040005AD RID: 1453
	private static readonly IntPtr NativeFieldInfoPtr_m_InsightText;

	// Token: 0x040005AE RID: 1454
	private static readonly IntPtr NativeFieldInfoPtr_m_ActivateSelectionHint;

	// Token: 0x040005AF RID: 1455
	private static readonly IntPtr NativeFieldInfoPtr_m_ActivateSelectionID;

	// Token: 0x040005B0 RID: 1456
	private static readonly IntPtr NativeMethodInfoPtr_SetPlayerOption_Public_Void_UInt16_UInt16_String_Int32_String_String_0;

	// Token: 0x040005B1 RID: 1457
	private static readonly IntPtr NativeMethodInfoPtr_SetAvailable_Public_Void_Boolean_0;

	// Token: 0x040005B2 RID: 1458
	private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0;

	// Token: 0x040005B3 RID: 1459
	private static readonly IntPtr NativeMethodInfoPtr_OnGameOptionPlayerButtonPressed_Public_Void_0;

	// Token: 0x040005B4 RID: 1460
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
