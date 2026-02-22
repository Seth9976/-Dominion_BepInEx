using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000057 RID: 87
	public sealed class RegexInterpreter : RegexRunner
	{
		// Token: 0x060005D2 RID: 1490 RVA: 0x0002604C File Offset: 0x0002424C
		// Note: this type is marked as 'beforefieldinit'.
		static RegexInterpreter()
		{
			Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexInterpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr);
			RegexInterpreter.NativeFieldInfoPtr_runoperator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runoperator");
			RegexInterpreter.NativeFieldInfoPtr_runcodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runcodes");
			RegexInterpreter.NativeFieldInfoPtr_runcodepos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runcodepos");
			RegexInterpreter.NativeFieldInfoPtr_runstrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runstrings");
			RegexInterpreter.NativeFieldInfoPtr_runcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runcode");
			RegexInterpreter.NativeFieldInfoPtr_runfcPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runfcPrefix");
			RegexInterpreter.NativeFieldInfoPtr_runbmPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runbmPrefix");
			RegexInterpreter.NativeFieldInfoPtr_runanchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runanchors");
			RegexInterpreter.NativeFieldInfoPtr_runrtl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runrtl");
			RegexInterpreter.NativeFieldInfoPtr_runci = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runci");
			RegexInterpreter.NativeFieldInfoPtr_runculture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "runculture");
			RegexInterpreter.NativeMethodInfoPtr__ctor_Internal_Void_RegexCode_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664062);
			RegexInterpreter.NativeMethodInfoPtr_InitTrackCount_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664063);
			RegexInterpreter.NativeMethodInfoPtr_Advance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664064);
			RegexInterpreter.NativeMethodInfoPtr_Advance_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664065);
			RegexInterpreter.NativeMethodInfoPtr_Goto_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664066);
			RegexInterpreter.NativeMethodInfoPtr_Textto_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664067);
			RegexInterpreter.NativeMethodInfoPtr_Trackto_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664068);
			RegexInterpreter.NativeMethodInfoPtr_Textstart_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664069);
			RegexInterpreter.NativeMethodInfoPtr_Textpos_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664070);
			RegexInterpreter.NativeMethodInfoPtr_Trackpos_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664071);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664072);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664073);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664074);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664075);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664076);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664077);
			RegexInterpreter.NativeMethodInfoPtr_Backtrack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664078);
			RegexInterpreter.NativeMethodInfoPtr_SetOperator_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664079);
			RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664080);
			RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664081);
			RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664082);
			RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664083);
			RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664084);
			RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664085);
			RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664086);
			RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664087);
			RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664088);
			RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664089);
			RegexInterpreter.NativeMethodInfoPtr_Operator_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664090);
			RegexInterpreter.NativeMethodInfoPtr_Operand_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664091);
			RegexInterpreter.NativeMethodInfoPtr_Leftchars_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664092);
			RegexInterpreter.NativeMethodInfoPtr_Rightchars_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664093);
			RegexInterpreter.NativeMethodInfoPtr_Bump_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664094);
			RegexInterpreter.NativeMethodInfoPtr_Forwardchars_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664095);
			RegexInterpreter.NativeMethodInfoPtr_Forwardcharnext_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664096);
			RegexInterpreter.NativeMethodInfoPtr_Stringmatch_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664097);
			RegexInterpreter.NativeMethodInfoPtr_Refmatch_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664098);
			RegexInterpreter.NativeMethodInfoPtr_Backwardnext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664099);
			RegexInterpreter.NativeMethodInfoPtr_CharAt_Private_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664100);
			RegexInterpreter.NativeMethodInfoPtr_FindFirstChar_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664101);
			RegexInterpreter.NativeMethodInfoPtr_Go_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664102);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0002648C File Offset: 0x0002468C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39285, RefRangeEnd = 39286, XrefRangeStart = 39284, XrefRangeEnd = 39285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexInterpreter(RegexCode code, CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr__ctor_Internal_Void_RegexCode_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000264EC File Offset: 0x000246EC
		[CallerCount(0)]
		public unsafe override void InitTrackCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_InitTrackCount_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00026520 File Offset: 0x00024720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39286, XrefRangeEnd = 39287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Advance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Advance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00026554 File Offset: 0x00024754
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 39287, RefRangeEnd = 39308, XrefRangeStart = 39287, XrefRangeEnd = 39287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Advance(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Advance_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00026594 File Offset: 0x00024794
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 39309, RefRangeEnd = 39317, XrefRangeStart = 39308, XrefRangeEnd = 39309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Goto(int newpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Goto_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000265D4 File Offset: 0x000247D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Textto(int newpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Textto_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00026614 File Offset: 0x00024814
		[CallerCount(0)]
		public unsafe void Trackto(int newpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Trackto_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00026654 File Offset: 0x00024854
		[CallerCount(0)]
		public unsafe int Textstart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Textstart_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00026690 File Offset: 0x00024890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Textpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Textpos_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000266CC File Offset: 0x000248CC
		[CallerCount(0)]
		public unsafe int Trackpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Trackpos_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00026708 File Offset: 0x00024908
		[CallerCount(0)]
		public unsafe void TrackPush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0002673C File Offset: 0x0002493C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 39317, RefRangeEnd = 39322, XrefRangeStart = 39317, XrefRangeEnd = 39317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush(int I1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0002677C File Offset: 0x0002497C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39322, RefRangeEnd = 39325, XrefRangeStart = 39322, XrefRangeEnd = 39322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush(int I1, int I2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000267C8 File Offset: 0x000249C8
		[CallerCount(0)]
		public unsafe void TrackPush(int I1, int I2, int I3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00026824 File Offset: 0x00024A24
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 39325, RefRangeEnd = 39331, XrefRangeStart = 39325, XrefRangeEnd = 39325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush2(int I1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00026864 File Offset: 0x00024A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39331, RefRangeEnd = 39332, XrefRangeStart = 39331, XrefRangeEnd = 39331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush2(int I1, int I2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000268B0 File Offset: 0x00024AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39332, XrefRangeEnd = 39334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Backtrack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Backtrack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000268E4 File Offset: 0x00024AE4
		[CallerCount(0)]
		public unsafe void SetOperator(int op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_SetOperator_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00026924 File Offset: 0x00024B24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 39334, RefRangeEnd = 39339, XrefRangeStart = 39334, XrefRangeEnd = 39334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00026958 File Offset: 0x00024B58
		[CallerCount(0)]
		public unsafe void TrackPop(int framesize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref framesize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00026998 File Offset: 0x00024B98
		[CallerCount(0)]
		public unsafe int TrackPeek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000269D4 File Offset: 0x00024BD4
		[CallerCount(0)]
		public unsafe int TrackPeek(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00026A20 File Offset: 0x00024C20
		[CallerCount(0)]
		public unsafe void StackPush(int I1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00026A60 File Offset: 0x00024C60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 39339, RefRangeEnd = 39343, XrefRangeStart = 39339, XrefRangeEnd = 39339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StackPush(int I1, int I2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00026AAC File Offset: 0x00024CAC
		[CallerCount(0)]
		public unsafe void StackPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00026AE0 File Offset: 0x00024CE0
		[CallerCount(0)]
		public unsafe void StackPop(int framesize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref framesize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00026B20 File Offset: 0x00024D20
		[CallerCount(0)]
		public unsafe int StackPeek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00026B5C File Offset: 0x00024D5C
		[CallerCount(0)]
		public unsafe int StackPeek(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00026BA8 File Offset: 0x00024DA8
		[CallerCount(0)]
		public unsafe int Operator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Operator_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00026BE4 File Offset: 0x00024DE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 39343, RefRangeEnd = 39347, XrefRangeStart = 39343, XrefRangeEnd = 39343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Operand(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Operand_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00026C30 File Offset: 0x00024E30
		[CallerCount(0)]
		public unsafe int Leftchars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Leftchars_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00026C6C File Offset: 0x00024E6C
		[CallerCount(0)]
		public unsafe int Rightchars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Rightchars_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00026CA8 File Offset: 0x00024EA8
		[CallerCount(0)]
		public unsafe int Bump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Bump_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00026CE4 File Offset: 0x00024EE4
		[CallerCount(0)]
		public unsafe int Forwardchars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Forwardchars_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00026D20 File Offset: 0x00024F20
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 39353, RefRangeEnd = 39365, XrefRangeStart = 39347, XrefRangeEnd = 39353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char Forwardcharnext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Forwardcharnext_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00026D5C File Offset: 0x00024F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39372, RefRangeEnd = 39373, XrefRangeStart = 39365, XrefRangeEnd = 39372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Stringmatch(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Stringmatch_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00026DAC File Offset: 0x00024FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39381, RefRangeEnd = 39382, XrefRangeStart = 39373, XrefRangeEnd = 39381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Refmatch(int index, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Refmatch_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00026E04 File Offset: 0x00025004
		[CallerCount(0)]
		public unsafe void Backwardnext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Backwardnext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00026E38 File Offset: 0x00025038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39382, XrefRangeEnd = 39384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char CharAt(int j)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref j;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_CharAt_Private_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00026E84 File Offset: 0x00025084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39384, XrefRangeEnd = 39398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool FindFirstChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_FindFirstChar_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00026EC0 File Offset: 0x000250C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39398, XrefRangeEnd = 39573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Go()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Go_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00004410 File Offset: 0x00002610
		public RegexInterpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00026EF4 File Offset: 0x000250F4
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00004419 File Offset: 0x00002619
		public unsafe int runoperator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runoperator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runoperator)) = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00026F1C File Offset: 0x0002511C
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00004434 File Offset: 0x00002634
		public unsafe Il2CppStructArray<int> runcodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00026F4C File Offset: 0x0002514C
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00004453 File Offset: 0x00002653
		public unsafe int runcodepos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcodepos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcodepos)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00026F74 File Offset: 0x00025174
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x0000446E File Offset: 0x0000266E
		public unsafe Il2CppStringArray runstrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runstrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runstrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00026FA4 File Offset: 0x000251A4
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x0000448D File Offset: 0x0000268D
		public unsafe RegexCode runcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runcode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00026FD4 File Offset: 0x000251D4
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x000044AC File Offset: 0x000026AC
		public unsafe RegexPrefix runfcPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runfcPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runfcPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00027004 File Offset: 0x00025204
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x000044CB File Offset: 0x000026CB
		public unsafe RegexBoyerMoore runbmPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runbmPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexBoyerMoore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runbmPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00027034 File Offset: 0x00025234
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x000044EA File Offset: 0x000026EA
		public unsafe int runanchors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runanchors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runanchors)) = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x0002705C File Offset: 0x0002525C
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00004505 File Offset: 0x00002705
		public unsafe bool runrtl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runrtl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runrtl)) = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00027084 File Offset: 0x00025284
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00004520 File Offset: 0x00002720
		public unsafe bool runci
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runci);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runci)) = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x000270AC File Offset: 0x000252AC
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x0000453B File Offset: 0x0000273B
		public unsafe CultureInfo runculture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runculture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr_runculture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_runoperator;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_runcodes;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr_runcodepos;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_runstrings;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr_runcode;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_runfcPrefix;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_runbmPrefix;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_runanchors;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_runrtl;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_runci;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr_runculture;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RegexCode_CultureInfo_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_InitTrackCount_Protected_Virtual_Void_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Private_Void_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Private_Void_Int32_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Private_Void_Int32_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_Textto_Private_Void_Int32_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_Trackto_Private_Void_Int32_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_Textstart_Private_Int32_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_Textpos_Private_Int32_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_Trackpos_Private_Int32_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_Int32_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_Int32_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_Backtrack_Private_Void_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_SetOperator_Private_Void_Int32_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_TrackPop_Private_Void_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_TrackPop_Private_Void_Int32_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_TrackPeek_Private_Int32_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_TrackPeek_Private_Int32_Int32_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_StackPush_Private_Void_Int32_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_StackPush_Private_Void_Int32_Int32_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_StackPop_Private_Void_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_StackPop_Private_Void_Int32_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_StackPeek_Private_Int32_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_StackPeek_Private_Int32_Int32_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_Operator_Private_Int32_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_Operand_Private_Int32_Int32_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_Leftchars_Private_Int32_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_Rightchars_Private_Int32_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_Bump_Private_Int32_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_Forwardchars_Private_Int32_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_Forwardcharnext_Private_Char_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_Stringmatch_Private_Boolean_String_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_Refmatch_Private_Boolean_Int32_Int32_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_Backwardnext_Private_Void_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_CharAt_Private_Char_Int32_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstChar_Protected_Virtual_Boolean_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_Go_Protected_Virtual_Void_0;
	}
}
