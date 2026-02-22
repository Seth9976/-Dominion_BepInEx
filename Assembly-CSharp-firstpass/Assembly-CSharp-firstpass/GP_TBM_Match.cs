using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000074 RID: 116
public class GP_TBM_Match : Object
{
	// Token: 0x060008C8 RID: 2248 RVA: 0x00035560 File Offset: 0x00033760
	// Note: this type is marked as 'beforefieldinit'.
	static GP_TBM_Match()
	{
		Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_TBM_Match");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr);
		GP_TBM_Match.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "Id");
		GP_TBM_Match.NativeFieldInfoPtr_RematchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "RematchId");
		GP_TBM_Match.NativeFieldInfoPtr_CreatorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "CreatorId");
		GP_TBM_Match.NativeFieldInfoPtr_LastUpdaterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "LastUpdaterId");
		GP_TBM_Match.NativeFieldInfoPtr_PendingParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "PendingParticipantId");
		GP_TBM_Match.NativeFieldInfoPtr_MatchNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "MatchNumber");
		GP_TBM_Match.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "Description");
		GP_TBM_Match.NativeFieldInfoPtr_AvailableAutoMatchSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "AvailableAutoMatchSlots");
		GP_TBM_Match.NativeFieldInfoPtr_CreationTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "CreationTimestamp");
		GP_TBM_Match.NativeFieldInfoPtr_LastUpdatedTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "LastUpdatedTimestamp");
		GP_TBM_Match.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "Status");
		GP_TBM_Match.NativeFieldInfoPtr_TurnStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "TurnStatus");
		GP_TBM_Match.NativeFieldInfoPtr_CanRematch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "CanRematch");
		GP_TBM_Match.NativeFieldInfoPtr_Variant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "Variant");
		GP_TBM_Match.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "Version");
		GP_TBM_Match.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "Data");
		GP_TBM_Match.NativeFieldInfoPtr_PreviousMatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "PreviousMatchData");
		GP_TBM_Match.NativeFieldInfoPtr_Participants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, "Participants");
		GP_TBM_Match.NativeMethodInfoPtr_SetData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, 100664374);
		GP_TBM_Match.NativeMethodInfoPtr_SetPreviousMatchData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, 100664375);
		GP_TBM_Match.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr, 100664376);
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x00035734 File Offset: 0x00033934
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 170234, RefRangeEnd = 170235, XrefRangeStart = 170230, XrefRangeEnd = 170234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(string val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_Match.NativeMethodInfoPtr_SetData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x00035778 File Offset: 0x00033978
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 170239, RefRangeEnd = 170240, XrefRangeStart = 170235, XrefRangeEnd = 170239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPreviousMatchData(string val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_Match.NativeMethodInfoPtr_SetPreviousMatchData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x000357BC File Offset: 0x000339BC
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_TBM_Match()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_TBM_Match>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_Match.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00005783 File Offset: 0x00003983
	public GP_TBM_Match(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x060008CD RID: 2253 RVA: 0x000357F8 File Offset: 0x000339F8
	// (set) Token: 0x060008CE RID: 2254 RVA: 0x0000578C File Offset: 0x0000398C
	public unsafe string Id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002D3 RID: 723
	// (get) Token: 0x060008CF RID: 2255 RVA: 0x00035820 File Offset: 0x00033A20
	// (set) Token: 0x060008D0 RID: 2256 RVA: 0x000057AB File Offset: 0x000039AB
	public unsafe string RematchId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_RematchId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_RematchId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002D4 RID: 724
	// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00035848 File Offset: 0x00033A48
	// (set) Token: 0x060008D2 RID: 2258 RVA: 0x000057CA File Offset: 0x000039CA
	public unsafe string CreatorId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_CreatorId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_CreatorId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00035870 File Offset: 0x00033A70
	// (set) Token: 0x060008D4 RID: 2260 RVA: 0x000057E9 File Offset: 0x000039E9
	public unsafe string LastUpdaterId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_LastUpdaterId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_LastUpdaterId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00035898 File Offset: 0x00033A98
	// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00005808 File Offset: 0x00003A08
	public unsafe string PendingParticipantId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_PendingParticipantId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_PendingParticipantId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x060008D7 RID: 2263 RVA: 0x000358C0 File Offset: 0x00033AC0
	// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00005827 File Offset: 0x00003A27
	public unsafe int MatchNumber
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_MatchNumber);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_MatchNumber)) = value;
		}
	}

	// Token: 0x170002D8 RID: 728
	// (get) Token: 0x060008D9 RID: 2265 RVA: 0x000358E8 File Offset: 0x00033AE8
	// (set) Token: 0x060008DA RID: 2266 RVA: 0x00005842 File Offset: 0x00003A42
	public unsafe string Description
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Description);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002D9 RID: 729
	// (get) Token: 0x060008DB RID: 2267 RVA: 0x00035910 File Offset: 0x00033B10
	// (set) Token: 0x060008DC RID: 2268 RVA: 0x00005861 File Offset: 0x00003A61
	public unsafe int AvailableAutoMatchSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_AvailableAutoMatchSlots);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_AvailableAutoMatchSlots)) = value;
		}
	}

	// Token: 0x170002DA RID: 730
	// (get) Token: 0x060008DD RID: 2269 RVA: 0x00035938 File Offset: 0x00033B38
	// (set) Token: 0x060008DE RID: 2270 RVA: 0x0000587C File Offset: 0x00003A7C
	public unsafe long CreationTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_CreationTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_CreationTimestamp)) = value;
		}
	}

	// Token: 0x170002DB RID: 731
	// (get) Token: 0x060008DF RID: 2271 RVA: 0x00035960 File Offset: 0x00033B60
	// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00005897 File Offset: 0x00003A97
	public unsafe long LastUpdatedTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_LastUpdatedTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_LastUpdatedTimestamp)) = value;
		}
	}

	// Token: 0x170002DC RID: 732
	// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00035988 File Offset: 0x00033B88
	// (set) Token: 0x060008E2 RID: 2274 RVA: 0x000058B2 File Offset: 0x00003AB2
	public unsafe GP_TBM_MatchStatus Status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Status);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Status)) = value;
		}
	}

	// Token: 0x170002DD RID: 733
	// (get) Token: 0x060008E3 RID: 2275 RVA: 0x000359B0 File Offset: 0x00033BB0
	// (set) Token: 0x060008E4 RID: 2276 RVA: 0x000058CD File Offset: 0x00003ACD
	public unsafe GP_TBM_MatchTurnStatus TurnStatus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_TurnStatus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_TurnStatus)) = value;
		}
	}

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000359D8 File Offset: 0x00033BD8
	// (set) Token: 0x060008E6 RID: 2278 RVA: 0x000058E8 File Offset: 0x00003AE8
	public unsafe bool CanRematch
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_CanRematch);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_CanRematch)) = value;
		}
	}

	// Token: 0x170002DF RID: 735
	// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00035A00 File Offset: 0x00033C00
	// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00005903 File Offset: 0x00003B03
	public unsafe int Variant
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Variant);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Variant)) = value;
		}
	}

	// Token: 0x170002E0 RID: 736
	// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00035A28 File Offset: 0x00033C28
	// (set) Token: 0x060008EA RID: 2282 RVA: 0x0000591E File Offset: 0x00003B1E
	public unsafe int Version
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Version);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Version)) = value;
		}
	}

	// Token: 0x170002E1 RID: 737
	// (get) Token: 0x060008EB RID: 2283 RVA: 0x00035A50 File Offset: 0x00033C50
	// (set) Token: 0x060008EC RID: 2284 RVA: 0x00005939 File Offset: 0x00003B39
	public unsafe Il2CppStructArray<byte> Data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002E2 RID: 738
	// (get) Token: 0x060008ED RID: 2285 RVA: 0x00035A80 File Offset: 0x00033C80
	// (set) Token: 0x060008EE RID: 2286 RVA: 0x00005958 File Offset: 0x00003B58
	public unsafe Il2CppStructArray<byte> PreviousMatchData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_PreviousMatchData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_PreviousMatchData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x060008EF RID: 2287 RVA: 0x00035AB0 File Offset: 0x00033CB0
	// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00005977 File Offset: 0x00003B77
	public unsafe List<GP_Participant> Participants
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Participants);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GP_Participant>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_Match.NativeFieldInfoPtr_Participants), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000720 RID: 1824
	private static readonly IntPtr NativeFieldInfoPtr_Id;

	// Token: 0x04000721 RID: 1825
	private static readonly IntPtr NativeFieldInfoPtr_RematchId;

	// Token: 0x04000722 RID: 1826
	private static readonly IntPtr NativeFieldInfoPtr_CreatorId;

	// Token: 0x04000723 RID: 1827
	private static readonly IntPtr NativeFieldInfoPtr_LastUpdaterId;

	// Token: 0x04000724 RID: 1828
	private static readonly IntPtr NativeFieldInfoPtr_PendingParticipantId;

	// Token: 0x04000725 RID: 1829
	private static readonly IntPtr NativeFieldInfoPtr_MatchNumber;

	// Token: 0x04000726 RID: 1830
	private static readonly IntPtr NativeFieldInfoPtr_Description;

	// Token: 0x04000727 RID: 1831
	private static readonly IntPtr NativeFieldInfoPtr_AvailableAutoMatchSlots;

	// Token: 0x04000728 RID: 1832
	private static readonly IntPtr NativeFieldInfoPtr_CreationTimestamp;

	// Token: 0x04000729 RID: 1833
	private static readonly IntPtr NativeFieldInfoPtr_LastUpdatedTimestamp;

	// Token: 0x0400072A RID: 1834
	private static readonly IntPtr NativeFieldInfoPtr_Status;

	// Token: 0x0400072B RID: 1835
	private static readonly IntPtr NativeFieldInfoPtr_TurnStatus;

	// Token: 0x0400072C RID: 1836
	private static readonly IntPtr NativeFieldInfoPtr_CanRematch;

	// Token: 0x0400072D RID: 1837
	private static readonly IntPtr NativeFieldInfoPtr_Variant;

	// Token: 0x0400072E RID: 1838
	private static readonly IntPtr NativeFieldInfoPtr_Version;

	// Token: 0x0400072F RID: 1839
	private static readonly IntPtr NativeFieldInfoPtr_Data;

	// Token: 0x04000730 RID: 1840
	private static readonly IntPtr NativeFieldInfoPtr_PreviousMatchData;

	// Token: 0x04000731 RID: 1841
	private static readonly IntPtr NativeFieldInfoPtr_Participants;

	// Token: 0x04000732 RID: 1842
	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_String_0;

	// Token: 0x04000733 RID: 1843
	private static readonly IntPtr NativeMethodInfoPtr_SetPreviousMatchData_Public_Void_String_0;

	// Token: 0x04000734 RID: 1844
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
