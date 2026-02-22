using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005F RID: 95
	public class RegexRunner : Object
	{
		// Token: 0x060006E5 RID: 1765 RVA: 0x0002A590 File Offset: 0x00028790
		// Note: this type is marked as 'beforefieldinit'.
		static RegexRunner()
		{
			Il2CppClassPointerStore<RegexRunner>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexRunner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr);
			RegexRunner.NativeFieldInfoPtr_runtextbeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextbeg");
			RegexRunner.NativeFieldInfoPtr_runtextend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextend");
			RegexRunner.NativeFieldInfoPtr_runtextstart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextstart");
			RegexRunner.NativeFieldInfoPtr_runtext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtext");
			RegexRunner.NativeFieldInfoPtr_runtextpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextpos");
			RegexRunner.NativeFieldInfoPtr_runtrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtrack");
			RegexRunner.NativeFieldInfoPtr_runtrackpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtrackpos");
			RegexRunner.NativeFieldInfoPtr_runstack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runstack");
			RegexRunner.NativeFieldInfoPtr_runstackpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runstackpos");
			RegexRunner.NativeFieldInfoPtr_runcrawl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runcrawl");
			RegexRunner.NativeFieldInfoPtr_runcrawlpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runcrawlpos");
			RegexRunner.NativeFieldInfoPtr_runtrackcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtrackcount");
			RegexRunner.NativeFieldInfoPtr_runmatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runmatch");
			RegexRunner.NativeFieldInfoPtr_runregex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runregex");
			RegexRunner.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "timeout");
			RegexRunner.NativeFieldInfoPtr_ignoreTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "ignoreTimeout");
			RegexRunner.NativeFieldInfoPtr_timeoutOccursAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "timeoutOccursAt");
			RegexRunner.NativeFieldInfoPtr_TimeoutCheckFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "TimeoutCheckFrequency");
			RegexRunner.NativeFieldInfoPtr_timeoutChecksToSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "timeoutChecksToSkip");
			RegexRunner.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664219);
			RegexRunner.NativeMethodInfoPtr_Scan_FamOrAssem_Match_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664220);
			RegexRunner.NativeMethodInfoPtr_StartTimeoutWatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664221);
			RegexRunner.NativeMethodInfoPtr_CheckTimeout_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664222);
			RegexRunner.NativeMethodInfoPtr_DoCheckTimeout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664223);
			RegexRunner.NativeMethodInfoPtr_Go_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664224);
			RegexRunner.NativeMethodInfoPtr_FindFirstChar_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664225);
			RegexRunner.NativeMethodInfoPtr_InitTrackCount_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664226);
			RegexRunner.NativeMethodInfoPtr_InitMatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664227);
			RegexRunner.NativeMethodInfoPtr_TidyMatch_Private_Match_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664228);
			RegexRunner.NativeMethodInfoPtr_EnsureStorage_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664229);
			RegexRunner.NativeMethodInfoPtr_IsBoundary_Protected_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664230);
			RegexRunner.NativeMethodInfoPtr_IsECMABoundary_Protected_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664231);
			RegexRunner.NativeMethodInfoPtr_DoubleTrack_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664232);
			RegexRunner.NativeMethodInfoPtr_DoubleStack_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664233);
			RegexRunner.NativeMethodInfoPtr_DoubleCrawl_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664234);
			RegexRunner.NativeMethodInfoPtr_Crawl_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664235);
			RegexRunner.NativeMethodInfoPtr_Popcrawl_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664236);
			RegexRunner.NativeMethodInfoPtr_Crawlpos_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664237);
			RegexRunner.NativeMethodInfoPtr_Capture_Protected_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664238);
			RegexRunner.NativeMethodInfoPtr_TransferCapture_Protected_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664239);
			RegexRunner.NativeMethodInfoPtr_Uncapture_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664240);
			RegexRunner.NativeMethodInfoPtr_IsMatched_Protected_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664241);
			RegexRunner.NativeMethodInfoPtr_MatchIndex_Protected_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664242);
			RegexRunner.NativeMethodInfoPtr_MatchLength_Protected_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664243);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0002A930 File Offset: 0x00028B30
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexRunner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0002A96C File Offset: 0x00028B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40615, RefRangeEnd = 40616, XrefRangeStart = 40589, XrefRangeEnd = 40615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textbeg;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textstart;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevlen;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quick;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Scan_FamOrAssem_Match_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0002AA24 File Offset: 0x00028C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40616, XrefRangeEnd = 40617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTimeoutWatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_StartTimeoutWatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0002AA58 File Offset: 0x00028C58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40618, RefRangeEnd = 40620, XrefRangeStart = 40617, XrefRangeEnd = 40618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_CheckTimeout_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0002AA8C File Offset: 0x00028C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40620, XrefRangeEnd = 40621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCheckTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoCheckTimeout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0002AAC0 File Offset: 0x00028CC0
		[CallerCount(0)]
		public unsafe virtual void Go()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunner.NativeMethodInfoPtr_Go_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0002AAFC File Offset: 0x00028CFC
		[CallerCount(0)]
		public unsafe virtual bool FindFirstChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunner.NativeMethodInfoPtr_FindFirstChar_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0002AB44 File Offset: 0x00028D44
		[CallerCount(0)]
		public unsafe virtual void InitTrackCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunner.NativeMethodInfoPtr_InitTrackCount_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0002AB80 File Offset: 0x00028D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40638, RefRangeEnd = 40639, XrefRangeStart = 40621, XrefRangeEnd = 40638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_InitMatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0002ABB4 File Offset: 0x00028DB4
		[CallerCount(0)]
		public unsafe Match TidyMatch(bool quick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quick;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_TidyMatch_Private_Match_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0002AC00 File Offset: 0x00028E00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40647, RefRangeEnd = 40650, XrefRangeStart = 40639, XrefRangeEnd = 40647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureStorage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_EnsureStorage_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0002AC34 File Offset: 0x00028E34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40661, RefRangeEnd = 40663, XrefRangeStart = 40650, XrefRangeEnd = 40661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBoundary(int index, int startpos, int endpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_IsBoundary_Protected_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0002AC9C File Offset: 0x00028E9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40674, RefRangeEnd = 40676, XrefRangeStart = 40663, XrefRangeEnd = 40674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsECMABoundary(int index, int startpos, int endpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_IsECMABoundary_Protected_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0002AD04 File Offset: 0x00028F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40676, XrefRangeEnd = 40680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoubleTrack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoubleTrack_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0002AD38 File Offset: 0x00028F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40680, XrefRangeEnd = 40684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoubleStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoubleStack_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0002AD6C File Offset: 0x00028F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40684, XrefRangeEnd = 40688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoubleCrawl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoubleCrawl_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0002ADA0 File Offset: 0x00028FA0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40693, RefRangeEnd = 40699, XrefRangeStart = 40688, XrefRangeEnd = 40693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Crawl(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Crawl_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0002ADE0 File Offset: 0x00028FE0
		[CallerCount(0)]
		public unsafe int Popcrawl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Popcrawl_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0002AE1C File Offset: 0x0002901C
		[CallerCount(0)]
		public unsafe int Crawlpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Crawlpos_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0002AE58 File Offset: 0x00029058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40699, XrefRangeEnd = 40701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Capture(int capnum, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Capture_Protected_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0002AEB4 File Offset: 0x000290B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40701, XrefRangeEnd = 40704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransferCapture(int capnum, int uncapnum, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uncapnum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_TransferCapture_Protected_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0002AF1C File Offset: 0x0002911C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40704, XrefRangeEnd = 40707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Uncapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Uncapture_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0002AF50 File Offset: 0x00029150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40707, XrefRangeEnd = 40708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatched(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_IsMatched_Protected_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0002AF9C File Offset: 0x0002919C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40708, XrefRangeEnd = 40709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchIndex(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_MatchIndex_Protected_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0002AFE8 File Offset: 0x000291E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40709, XrefRangeEnd = 40710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchLength(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_MatchLength_Protected_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00004A44 File Offset: 0x00002C44
		public RegexRunner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0002B034 File Offset: 0x00029234
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x00004A4D File Offset: 0x00002C4D
		public unsafe int runtextbeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextbeg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextbeg)) = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0002B05C File Offset: 0x0002925C
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x00004A68 File Offset: 0x00002C68
		public unsafe int runtextend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextend)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0002B084 File Offset: 0x00029284
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00004A83 File Offset: 0x00002C83
		public unsafe int runtextstart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextstart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextstart)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0002B0AC File Offset: 0x000292AC
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00004A9E File Offset: 0x00002C9E
		public unsafe string runtext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtext);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtext), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0002B0D4 File Offset: 0x000292D4
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00004ABD File Offset: 0x00002CBD
		public unsafe int runtextpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextpos)) = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0002B0FC File Offset: 0x000292FC
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00004AD8 File Offset: 0x00002CD8
		public unsafe Il2CppStructArray<int> runtrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0002B12C File Offset: 0x0002932C
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00004AF7 File Offset: 0x00002CF7
		public unsafe int runtrackpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackpos)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0002B154 File Offset: 0x00029354
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00004B12 File Offset: 0x00002D12
		public unsafe Il2CppStructArray<int> runstack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0002B184 File Offset: 0x00029384
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00004B31 File Offset: 0x00002D31
		public unsafe int runstackpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstackpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstackpos)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0002B1AC File Offset: 0x000293AC
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00004B4C File Offset: 0x00002D4C
		public unsafe Il2CppStructArray<int> runcrawl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0002B1DC File Offset: 0x000293DC
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00004B6B File Offset: 0x00002D6B
		public unsafe int runcrawlpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawlpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawlpos)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0002B204 File Offset: 0x00029404
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00004B86 File Offset: 0x00002D86
		public unsafe int runtrackcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackcount)) = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0002B22C File Offset: 0x0002942C
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00004BA1 File Offset: 0x00002DA1
		public unsafe Match runmatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runmatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runmatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0002B25C File Offset: 0x0002945C
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00004BC0 File Offset: 0x00002DC0
		public unsafe Regex runregex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runregex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runregex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0002B28C File Offset: 0x0002948C
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00004BDF File Offset: 0x00002DDF
		public unsafe int timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0002B2B4 File Offset: 0x000294B4
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00004BFA File Offset: 0x00002DFA
		public unsafe bool ignoreTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_ignoreTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_ignoreTimeout)) = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0002B2DC File Offset: 0x000294DC
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00004C15 File Offset: 0x00002E15
		public unsafe int timeoutOccursAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeoutOccursAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeoutOccursAt)) = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0002B304 File Offset: 0x00029504
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00004C30 File Offset: 0x00002E30
		public unsafe static int TimeoutCheckFrequency
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexRunner.NativeFieldInfoPtr_TimeoutCheckFrequency, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexRunner.NativeFieldInfoPtr_TimeoutCheckFrequency, (void*)(&value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0002B320 File Offset: 0x00029520
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00004C3E File Offset: 0x00002E3E
		public unsafe int timeoutChecksToSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeoutChecksToSkip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_timeoutChecksToSkip)) = value;
			}
		}

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeFieldInfoPtr_runtextbeg;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeFieldInfoPtr_runtextend;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeFieldInfoPtr_runtextstart;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeFieldInfoPtr_runtext;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeFieldInfoPtr_runtextpos;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeFieldInfoPtr_runtrack;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeFieldInfoPtr_runtrackpos;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeFieldInfoPtr_runstack;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeFieldInfoPtr_runstackpos;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeFieldInfoPtr_runcrawl;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeFieldInfoPtr_runcrawlpos;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeFieldInfoPtr_runtrackcount;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeFieldInfoPtr_runmatch;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeFieldInfoPtr_runregex;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeFieldInfoPtr_ignoreTimeout;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_timeoutOccursAt;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_TimeoutCheckFrequency;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_timeoutChecksToSkip;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_Scan_FamOrAssem_Match_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_StartTimeoutWatch_Private_Void_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_CheckTimeout_Protected_Void_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_DoCheckTimeout_Private_Void_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_Go_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstChar_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_InitTrackCount_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_InitMatch_Private_Void_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_TidyMatch_Private_Match_Boolean_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_EnsureStorage_Protected_Void_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_IsBoundary_Protected_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_IsECMABoundary_Protected_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_DoubleTrack_Protected_Void_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_DoubleStack_Protected_Void_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_DoubleCrawl_Protected_Void_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_Crawl_Protected_Void_Int32_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_Popcrawl_Protected_Int32_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_Crawlpos_Protected_Int32_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Protected_Void_Int32_Int32_Int32_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_TransferCapture_Protected_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_Uncapture_Protected_Void_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_IsMatched_Protected_Boolean_Int32_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_MatchIndex_Protected_Int32_Int32_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_MatchLength_Protected_Int32_Int32_0;
	}
}
