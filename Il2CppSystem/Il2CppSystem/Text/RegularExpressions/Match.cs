using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000058 RID: 88
	[Serializable]
	public class Match : Group
	{
		// Token: 0x06000613 RID: 1555 RVA: 0x000270DC File Offset: 0x000252DC
		// Note: this type is marked as 'beforefieldinit'.
		static Match()
		{
			Il2CppClassPointerStore<Match>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Match");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match>.NativeClassPtr);
			Match.NativeFieldInfoPtr__empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_empty");
			Match.NativeFieldInfoPtr__groupcoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_groupcoll");
			Match.NativeFieldInfoPtr__regex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_regex");
			Match.NativeFieldInfoPtr__textbeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textbeg");
			Match.NativeFieldInfoPtr__textpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textpos");
			Match.NativeFieldInfoPtr__textend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textend");
			Match.NativeFieldInfoPtr__textstart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_textstart");
			Match.NativeFieldInfoPtr__matches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_matches");
			Match.NativeFieldInfoPtr__matchcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_matchcount");
			Match.NativeFieldInfoPtr__balancing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_balancing");
			Match.NativeMethodInfoPtr_get_Empty_Public_Static_get_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664103);
			Match.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664104);
			Match.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_Regex_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664105);
			Match.NativeMethodInfoPtr_get_Groups_Public_Virtual_New_get_GroupCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664106);
			Match.NativeMethodInfoPtr_NextMatch_Public_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664107);
			Match.NativeMethodInfoPtr_AddMatch_Internal_Virtual_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664108);
			Match.NativeMethodInfoPtr_BalanceMatch_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664109);
			Match.NativeMethodInfoPtr_RemoveMatch_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664110);
			Match.NativeMethodInfoPtr_IsMatched_Internal_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664111);
			Match.NativeMethodInfoPtr_MatchIndex_Internal_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664112);
			Match.NativeMethodInfoPtr_MatchLength_Internal_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664113);
			Match.NativeMethodInfoPtr_Tidy_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664114);
			Match.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100664116);
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x000272D8 File Offset: 0x000254D8
		public unsafe static Match Empty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39573, XrefRangeEnd = 39577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_Empty_Public_Static_get_Match_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0002730C File Offset: 0x0002550C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39592, RefRangeEnd = 39594, XrefRangeStart = 39577, XrefRangeEnd = 39592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match(Regex regex, int capcount, string text, int begpos, int len, int startpos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capcount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref begpos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000273A4 File Offset: 0x000255A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39594, XrefRangeEnd = 39595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textbeg;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textstart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_Regex_String_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00027430 File Offset: 0x00025630
		public unsafe virtual GroupCollection Groups
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39595, XrefRangeEnd = 39599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_Groups_Public_Virtual_New_get_GroupCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0002747C File Offset: 0x0002567C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 39600, RefRangeEnd = 39606, XrefRangeStart = 39599, XrefRangeEnd = 39600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match NextMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_NextMatch_Public_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000274BC File Offset: 0x000256BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39606, XrefRangeEnd = 39613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddMatch(int cap, int start, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_AddMatch_Internal_Virtual_New_Void_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00027524 File Offset: 0x00025724
		[CallerCount(0)]
		public unsafe virtual void BalanceMatch(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_BalanceMatch_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00027570 File Offset: 0x00025770
		[CallerCount(0)]
		public unsafe virtual void RemoveMatch(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_RemoveMatch_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000275BC File Offset: 0x000257BC
		[CallerCount(0)]
		public unsafe virtual bool IsMatched(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_IsMatched_Internal_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00027610 File Offset: 0x00025810
		[CallerCount(0)]
		public unsafe virtual int MatchIndex(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_MatchIndex_Internal_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00027664 File Offset: 0x00025864
		[CallerCount(0)]
		public unsafe virtual int MatchLength(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_MatchLength_Internal_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000276B8 File Offset: 0x000258B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39613, XrefRangeEnd = 39615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Tidy(int textpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref textpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_Tidy_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00027704 File Offset: 0x00025904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39615, XrefRangeEnd = 39618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0000455A File Offset: 0x0000275A
		public Match(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00027740 File Offset: 0x00025940
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00004563 File Offset: 0x00002763
		public unsafe static Match _empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Match.NativeFieldInfoPtr__empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Match.NativeFieldInfoPtr__empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00027768 File Offset: 0x00025968
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00004575 File Offset: 0x00002775
		public unsafe GroupCollection _groupcoll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__groupcoll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__groupcoll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00027798 File Offset: 0x00025998
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x00004594 File Offset: 0x00002794
		public unsafe Regex _regex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__regex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__regex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x000277C8 File Offset: 0x000259C8
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x000045B3 File Offset: 0x000027B3
		public unsafe int _textbeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textbeg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textbeg)) = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x000277F0 File Offset: 0x000259F0
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x000045CE File Offset: 0x000027CE
		public unsafe int _textpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textpos)) = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00027818 File Offset: 0x00025A18
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x000045E9 File Offset: 0x000027E9
		public unsafe int _textend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textend)) = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00027840 File Offset: 0x00025A40
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00004604 File Offset: 0x00002804
		public unsafe int _textstart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textstart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__textstart)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00027868 File Offset: 0x00025A68
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x0000461F File Offset: 0x0000281F
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> _matches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00027898 File Offset: 0x00025A98
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x0000463E File Offset: 0x0000283E
		public unsafe Il2CppStructArray<int> _matchcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matchcount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matchcount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x000278C8 File Offset: 0x00025AC8
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x0000465D File Offset: 0x0000285D
		public unsafe bool _balancing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__balancing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__balancing)) = value;
			}
		}

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr__empty;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr__groupcoll;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr__regex;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr__textbeg;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr__textpos;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr__textend;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr__textstart;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr__matches;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr__matchcount;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr__balancing;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_Match_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Regex_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_Regex_String_Int32_Int32_Int32_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Public_Virtual_New_get_GroupCollection_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_NextMatch_Public_Match_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_AddMatch_Internal_Virtual_New_Void_Int32_Int32_Int32_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_BalanceMatch_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMatch_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_IsMatched_Internal_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_MatchIndex_Internal_Virtual_New_Int32_Int32_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_MatchLength_Internal_Virtual_New_Int32_Int32_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_Tidy_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
