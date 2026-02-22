using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;

namespace Il2CppSystem
{
	// Token: 0x02000133 RID: 307
	public class TermInfoDriver : Object
	{
		// Token: 0x060015DD RID: 5597 RVA: 0x000856A8 File Offset: 0x000838A8
		// Note: this type is marked as 'beforefieldinit'.
		static TermInfoDriver()
		{
			Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TermInfoDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr);
			TermInfoDriver.NativeFieldInfoPtr_native_terminal_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "native_terminal_size");
			TermInfoDriver.NativeFieldInfoPtr_terminal_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "terminal_size");
			TermInfoDriver.NativeFieldInfoPtr_locations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "locations");
			TermInfoDriver.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "reader");
			TermInfoDriver.NativeFieldInfoPtr_cursorLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorLeft");
			TermInfoDriver.NativeFieldInfoPtr_cursorTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorTop");
			TermInfoDriver.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "title");
			TermInfoDriver.NativeFieldInfoPtr_titleFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "titleFormat");
			TermInfoDriver.NativeFieldInfoPtr_cursorVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorVisible");
			TermInfoDriver.NativeFieldInfoPtr_csrVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "csrVisible");
			TermInfoDriver.NativeFieldInfoPtr_csrInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "csrInvisible");
			TermInfoDriver.NativeFieldInfoPtr_clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "clear");
			TermInfoDriver.NativeFieldInfoPtr_bell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "bell");
			TermInfoDriver.NativeFieldInfoPtr_term = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "term");
			TermInfoDriver.NativeFieldInfoPtr_stdin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "stdin");
			TermInfoDriver.NativeFieldInfoPtr_stdout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "stdout");
			TermInfoDriver.NativeFieldInfoPtr_windowWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "windowWidth");
			TermInfoDriver.NativeFieldInfoPtr_windowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "windowHeight");
			TermInfoDriver.NativeFieldInfoPtr_bufferHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "bufferHeight");
			TermInfoDriver.NativeFieldInfoPtr_bufferWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "bufferWidth");
			TermInfoDriver.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "buffer");
			TermInfoDriver.NativeFieldInfoPtr_readpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "readpos");
			TermInfoDriver.NativeFieldInfoPtr_writepos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "writepos");
			TermInfoDriver.NativeFieldInfoPtr_keypadXmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "keypadXmit");
			TermInfoDriver.NativeFieldInfoPtr_keypadLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "keypadLocal");
			TermInfoDriver.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "inited");
			TermInfoDriver.NativeFieldInfoPtr_initLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "initLock");
			TermInfoDriver.NativeFieldInfoPtr_initKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "initKeys");
			TermInfoDriver.NativeFieldInfoPtr_origPair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "origPair");
			TermInfoDriver.NativeFieldInfoPtr_origColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "origColors");
			TermInfoDriver.NativeFieldInfoPtr_cursorAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorAddress");
			TermInfoDriver.NativeFieldInfoPtr_fgcolor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "fgcolor");
			TermInfoDriver.NativeFieldInfoPtr_setfgcolor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "setfgcolor");
			TermInfoDriver.NativeFieldInfoPtr_setbgcolor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "setbgcolor");
			TermInfoDriver.NativeFieldInfoPtr_maxColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "maxColors");
			TermInfoDriver.NativeFieldInfoPtr_noGetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "noGetPosition");
			TermInfoDriver.NativeFieldInfoPtr_keymap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "keymap");
			TermInfoDriver.NativeFieldInfoPtr_rootmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "rootmap");
			TermInfoDriver.NativeFieldInfoPtr_rl_startx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "rl_startx");
			TermInfoDriver.NativeFieldInfoPtr_rl_starty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "rl_starty");
			TermInfoDriver.NativeFieldInfoPtr_control_characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "control_characters");
			TermInfoDriver.NativeFieldInfoPtr__consoleColorToAnsiCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "_consoleColorToAnsiCode");
			TermInfoDriver.NativeFieldInfoPtr_echobuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "echobuf");
			TermInfoDriver.NativeFieldInfoPtr_echon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "echon");
			TermInfoDriver.NativeMethodInfoPtr_TryTermInfoDir_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667017);
			TermInfoDriver.NativeMethodInfoPtr_SearchTerminfo_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667018);
			TermInfoDriver.NativeMethodInfoPtr_WriteConsole_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667019);
			TermInfoDriver.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667020);
			TermInfoDriver.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667021);
			TermInfoDriver.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667022);
			TermInfoDriver.NativeMethodInfoPtr_IncrementX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667023);
			TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667024);
			TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667025);
			TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667026);
			TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667027);
			TermInfoDriver.NativeMethodInfoPtr_GetCursorPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667028);
			TermInfoDriver.NativeMethodInfoPtr_CheckWindowDimensions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667029);
			TermInfoDriver.NativeMethodInfoPtr_get_WindowHeight_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667030);
			TermInfoDriver.NativeMethodInfoPtr_get_WindowWidth_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667031);
			TermInfoDriver.NativeMethodInfoPtr_AddToBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667032);
			TermInfoDriver.NativeMethodInfoPtr_AdjustBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667033);
			TermInfoDriver.NativeMethodInfoPtr_CreateKeyInfoFromInt_Private_ConsoleKeyInfo_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667034);
			TermInfoDriver.NativeMethodInfoPtr_GetKeyFromBuffer_Private_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667035);
			TermInfoDriver.NativeMethodInfoPtr_ReadKeyInternal_Private_ConsoleKeyInfo_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667036);
			TermInfoDriver.NativeMethodInfoPtr_InputPending_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667037);
			TermInfoDriver.NativeMethodInfoPtr_QueueEcho_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667038);
			TermInfoDriver.NativeMethodInfoPtr_Echo_Private_Void_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667039);
			TermInfoDriver.NativeMethodInfoPtr_EchoFlush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667040);
			TermInfoDriver.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667041);
			TermInfoDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667042);
			TermInfoDriver.NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667043);
			TermInfoDriver.NativeMethodInfoPtr_ReadToEnd_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667044);
			TermInfoDriver.NativeMethodInfoPtr_ReadUntilConditionInternal_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667045);
			TermInfoDriver.NativeMethodInfoPtr_SetCursorPosition_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667046);
			TermInfoDriver.NativeMethodInfoPtr_CreateKeyMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667047);
			TermInfoDriver.NativeMethodInfoPtr_InitKeys_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667048);
			TermInfoDriver.NativeMethodInfoPtr_AddStringMapping_Private_Void_TermInfoStrings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667049);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00085CDC File Offset: 0x00083EDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308077, RefRangeEnd = 308079, XrefRangeStart = 308063, XrefRangeEnd = 308077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TryTermInfoDir(string dir, string term)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(term);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_TryTermInfoDir_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00085D2C File Offset: 0x00083F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308098, RefRangeEnd = 308099, XrefRangeStart = 308079, XrefRangeEnd = 308098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SearchTerminfo(string term)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_SearchTerminfo_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00085D68 File Offset: 0x00083F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308099, XrefRangeEnd = 308100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteConsole(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_WriteConsole_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00085DAC File Offset: 0x00083FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308142, RefRangeEnd = 308143, XrefRangeStart = 308100, XrefRangeEnd = 308142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoDriver(string term)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00085DF8 File Offset: 0x00083FF8
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00085E34 File Offset: 0x00084034
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 308235, RefRangeEnd = 308244, XrefRangeStart = 308143, XrefRangeEnd = 308235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00085E68 File Offset: 0x00084068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308244, XrefRangeEnd = 308248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_IncrementX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00085E9C File Offset: 0x0008409C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308261, RefRangeEnd = 308263, XrefRangeStart = 308248, XrefRangeEnd = 308261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSpecialKey(ConsoleKeyInfo key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_ConsoleKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00085EDC File Offset: 0x000840DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308265, RefRangeEnd = 308267, XrefRangeStart = 308263, XrefRangeEnd = 308265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSpecialKey(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00085F1C File Offset: 0x0008411C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308267, RefRangeEnd = 308269, XrefRangeStart = 308267, XrefRangeEnd = 308267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSpecialKey(ConsoleKeyInfo key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_ConsoleKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00085F68 File Offset: 0x00084168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308271, RefRangeEnd = 308273, XrefRangeStart = 308269, XrefRangeEnd = 308271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSpecialKey(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00085FB4 File Offset: 0x000841B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308292, RefRangeEnd = 308294, XrefRangeStart = 308273, XrefRangeEnd = 308292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCursorPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_GetCursorPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00085FE8 File Offset: 0x000841E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 308309, RefRangeEnd = 308316, XrefRangeStart = 308294, XrefRangeEnd = 308309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckWindowDimensions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_CheckWindowDimensions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x0008601C File Offset: 0x0008421C
		public unsafe virtual int WindowHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308316, XrefRangeEnd = 308318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_get_WindowHeight_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x00086058 File Offset: 0x00084258
		public unsafe virtual int WindowWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308318, XrefRangeEnd = 308320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_get_WindowWidth_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00086094 File Offset: 0x00084294
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 308327, RefRangeEnd = 308335, XrefRangeStart = 308320, XrefRangeEnd = 308327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToBuffer(int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_AddToBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000860D4 File Offset: 0x000842D4
		[CallerCount(0)]
		public unsafe void AdjustBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_AdjustBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00086108 File Offset: 0x00084308
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 308343, RefRangeEnd = 308347, XrefRangeStart = 308335, XrefRangeEnd = 308343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_CreateKeyInfoFromInt_Private_ConsoleKeyInfo_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00086160 File Offset: 0x00084360
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 308371, RefRangeEnd = 308376, XrefRangeStart = 308347, XrefRangeEnd = 308371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetKeyFromBuffer(bool cooked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cooked;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_GetKeyFromBuffer_Private_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000861AC File Offset: 0x000843AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308399, RefRangeEnd = 308402, XrefRangeStart = 308376, XrefRangeEnd = 308399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleKeyInfo ReadKeyInternal(out bool fresh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &fresh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadKeyInternal_Private_ConsoleKeyInfo_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x000861F8 File Offset: 0x000843F8
		[CallerCount(0)]
		public unsafe bool InputPending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_InputPending_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00086234 File Offset: 0x00084434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308402, XrefRangeEnd = 308407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueEcho(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_QueueEcho_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00086274 File Offset: 0x00084474
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308410, RefRangeEnd = 308413, XrefRangeStart = 308407, XrefRangeEnd = 308410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Echo(ConsoleKeyInfo key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_Echo_Private_Void_ConsoleKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x000862B4 File Offset: 0x000844B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308413, XrefRangeEnd = 308414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EchoFlush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_EchoFlush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x000862E8 File Offset: 0x000844E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308439, RefRangeEnd = 308440, XrefRangeStart = 308414, XrefRangeEnd = 308439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read([In] [Out] Il2CppStructArray<char> dest, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*dest = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00086364 File Offset: 0x00084564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308440, XrefRangeEnd = 308443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x000863B0 File Offset: 0x000845B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308444, RefRangeEnd = 308445, XrefRangeStart = 308443, XrefRangeEnd = 308444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x000863E8 File Offset: 0x000845E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308446, RefRangeEnd = 308447, XrefRangeStart = 308445, XrefRangeEnd = 308446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadToEnd_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00086420 File Offset: 0x00084620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308462, RefRangeEnd = 308464, XrefRangeStart = 308447, XrefRangeEnd = 308462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadUntilConditionInternal(bool haltOnNewLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref haltOnNewLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadUntilConditionInternal_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00086464 File Offset: 0x00084664
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308473, RefRangeEnd = 308475, XrefRangeStart = 308464, XrefRangeEnd = 308473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCursorPosition(int left, int top)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_SetCursorPosition_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x000864B0 File Offset: 0x000846B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308781, RefRangeEnd = 308782, XrefRangeStart = 308475, XrefRangeEnd = 308781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateKeyMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_CreateKeyMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000864E4 File Offset: 0x000846E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308801, RefRangeEnd = 308802, XrefRangeStart = 308782, XrefRangeEnd = 308801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_InitKeys_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00086518 File Offset: 0x00084718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308802, XrefRangeEnd = 308804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStringMapping(TermInfoStrings s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_AddStringMapping_Private_Void_TermInfoStrings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0000789F File Offset: 0x00005A9F
		public TermInfoDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x00086558 File Offset: 0x00084758
		// (set) Token: 0x06001601 RID: 5633 RVA: 0x000078A8 File Offset: 0x00005AA8
		public unsafe static int* native_terminal_size
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr_native_terminal_size, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr_native_terminal_size, (void*)value);
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x00086574 File Offset: 0x00084774
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x000078B5 File Offset: 0x00005AB5
		public unsafe static int terminal_size
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr_terminal_size, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr_terminal_size, (void*)(&value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x00086590 File Offset: 0x00084790
		// (set) Token: 0x06001605 RID: 5637 RVA: 0x000078C3 File Offset: 0x00005AC3
		public unsafe static Il2CppStringArray locations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr_locations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr_locations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x000865B8 File Offset: 0x000847B8
		// (set) Token: 0x06001607 RID: 5639 RVA: 0x000078D5 File Offset: 0x00005AD5
		public unsafe TermInfoReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TermInfoReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x000865E8 File Offset: 0x000847E8
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x000078F4 File Offset: 0x00005AF4
		public unsafe int cursorLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorLeft)) = value;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x00086610 File Offset: 0x00084810
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x0000790F File Offset: 0x00005B0F
		public unsafe int cursorTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorTop)) = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00086638 File Offset: 0x00084838
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x0000792A File Offset: 0x00005B2A
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00086660 File Offset: 0x00084860
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x00007949 File Offset: 0x00005B49
		public unsafe string titleFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_titleFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_titleFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x00086688 File Offset: 0x00084888
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x00007968 File Offset: 0x00005B68
		public unsafe bool cursorVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorVisible)) = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x000866B0 File Offset: 0x000848B0
		// (set) Token: 0x06001613 RID: 5651 RVA: 0x00007983 File Offset: 0x00005B83
		public unsafe string csrVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrVisible);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrVisible), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x000866D8 File Offset: 0x000848D8
		// (set) Token: 0x06001615 RID: 5653 RVA: 0x000079A2 File Offset: 0x00005BA2
		public unsafe string csrInvisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrInvisible);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrInvisible), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x00086700 File Offset: 0x00084900
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x000079C1 File Offset: 0x00005BC1
		public unsafe string clear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_clear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_clear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x00086728 File Offset: 0x00084928
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x000079E0 File Offset: 0x00005BE0
		public unsafe string bell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bell);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bell), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x00086750 File Offset: 0x00084950
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x000079FF File Offset: 0x00005BFF
		public unsafe string term
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_term);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_term), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x00086778 File Offset: 0x00084978
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x00007A1E File Offset: 0x00005C1E
		public unsafe StreamReader stdin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x000867A8 File Offset: 0x000849A8
		// (set) Token: 0x0600161F RID: 5663 RVA: 0x00007A3D File Offset: 0x00005C3D
		public unsafe CStreamWriter stdout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CStreamWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x000867D8 File Offset: 0x000849D8
		// (set) Token: 0x06001621 RID: 5665 RVA: 0x00007A5C File Offset: 0x00005C5C
		public unsafe int windowWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowWidth)) = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x00086800 File Offset: 0x00084A00
		// (set) Token: 0x06001623 RID: 5667 RVA: 0x00007A77 File Offset: 0x00005C77
		public unsafe int windowHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowHeight)) = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x00086828 File Offset: 0x00084A28
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x00007A92 File Offset: 0x00005C92
		public unsafe int bufferHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferHeight)) = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00086850 File Offset: 0x00084A50
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x00007AAD File Offset: 0x00005CAD
		public unsafe int bufferWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferWidth)) = value;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x00086878 File Offset: 0x00084A78
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x00007AC8 File Offset: 0x00005CC8
		public unsafe Il2CppStructArray<char> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x000868A8 File Offset: 0x00084AA8
		// (set) Token: 0x0600162B RID: 5675 RVA: 0x00007AE7 File Offset: 0x00005CE7
		public unsafe int readpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_readpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_readpos)) = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x000868D0 File Offset: 0x00084AD0
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x00007B02 File Offset: 0x00005D02
		public unsafe int writepos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_writepos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_writepos)) = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x000868F8 File Offset: 0x00084AF8
		// (set) Token: 0x0600162F RID: 5679 RVA: 0x00007B1D File Offset: 0x00005D1D
		public unsafe string keypadXmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadXmit);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadXmit), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x00086920 File Offset: 0x00084B20
		// (set) Token: 0x06001631 RID: 5681 RVA: 0x00007B3C File Offset: 0x00005D3C
		public unsafe string keypadLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadLocal);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadLocal), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00086948 File Offset: 0x00084B48
		// (set) Token: 0x06001633 RID: 5683 RVA: 0x00007B5B File Offset: 0x00005D5B
		public unsafe bool inited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_inited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_inited)) = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x00086970 File Offset: 0x00084B70
		// (set) Token: 0x06001635 RID: 5685 RVA: 0x00007B76 File Offset: 0x00005D76
		public unsafe Object initLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x000869A0 File Offset: 0x00084BA0
		// (set) Token: 0x06001637 RID: 5687 RVA: 0x00007B95 File Offset: 0x00005D95
		public unsafe bool initKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initKeys);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initKeys)) = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x000869C8 File Offset: 0x00084BC8
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x00007BB0 File Offset: 0x00005DB0
		public unsafe string origPair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origPair);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origPair), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x000869F0 File Offset: 0x00084BF0
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x00007BCF File Offset: 0x00005DCF
		public unsafe string origColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origColors);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origColors), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x00086A18 File Offset: 0x00084C18
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x00007BEE File Offset: 0x00005DEE
		public unsafe string cursorAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x00086A40 File Offset: 0x00084C40
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x00007C0D File Offset: 0x00005E0D
		public unsafe ConsoleColor fgcolor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_fgcolor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_fgcolor)) = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00086A68 File Offset: 0x00084C68
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x00007C28 File Offset: 0x00005E28
		public unsafe string setfgcolor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setfgcolor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setfgcolor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00086A90 File Offset: 0x00084C90
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x00007C47 File Offset: 0x00005E47
		public unsafe string setbgcolor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setbgcolor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setbgcolor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x00086AB8 File Offset: 0x00084CB8
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x00007C66 File Offset: 0x00005E66
		public unsafe int maxColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_maxColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_maxColors)) = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x00086AE0 File Offset: 0x00084CE0
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x00007C81 File Offset: 0x00005E81
		public unsafe bool noGetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_noGetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_noGetPosition)) = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00086B08 File Offset: 0x00084D08
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00007C9C File Offset: 0x00005E9C
		public unsafe Hashtable keymap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keymap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keymap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00086B38 File Offset: 0x00084D38
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x00007CBB File Offset: 0x00005EBB
		public unsafe ByteMatcher rootmap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rootmap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ByteMatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rootmap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00086B68 File Offset: 0x00084D68
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x00007CDA File Offset: 0x00005EDA
		public unsafe int rl_startx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_startx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_startx)) = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00086B90 File Offset: 0x00084D90
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x00007CF5 File Offset: 0x00005EF5
		public unsafe int rl_starty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_starty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_starty)) = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00086BB8 File Offset: 0x00084DB8
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x00007D10 File Offset: 0x00005F10
		public unsafe Il2CppStructArray<byte> control_characters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_control_characters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_control_characters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x00086BE8 File Offset: 0x00084DE8
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x00007D2F File Offset: 0x00005F2F
		public unsafe static Il2CppStructArray<int> _consoleColorToAnsiCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr__consoleColorToAnsiCode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr__consoleColorToAnsiCode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x00086C10 File Offset: 0x00084E10
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x00007D41 File Offset: 0x00005F41
		public unsafe Il2CppStructArray<char> echobuf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echobuf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echobuf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x00086C40 File Offset: 0x00084E40
		// (set) Token: 0x06001657 RID: 5719 RVA: 0x00007D60 File Offset: 0x00005F60
		public unsafe int echon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echon)) = value;
			}
		}

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeFieldInfoPtr_native_terminal_size;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeFieldInfoPtr_terminal_size;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeFieldInfoPtr_locations;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeFieldInfoPtr_cursorLeft;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeFieldInfoPtr_cursorTop;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeFieldInfoPtr_titleFormat;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeFieldInfoPtr_cursorVisible;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeFieldInfoPtr_csrVisible;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeFieldInfoPtr_csrInvisible;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeFieldInfoPtr_clear;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeFieldInfoPtr_bell;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeFieldInfoPtr_term;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeFieldInfoPtr_stdin;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeFieldInfoPtr_stdout;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeFieldInfoPtr_windowWidth;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeFieldInfoPtr_windowHeight;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeFieldInfoPtr_bufferHeight;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeFieldInfoPtr_bufferWidth;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeFieldInfoPtr_readpos;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeFieldInfoPtr_writepos;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeFieldInfoPtr_keypadXmit;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeFieldInfoPtr_keypadLocal;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeFieldInfoPtr_initLock;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeFieldInfoPtr_initKeys;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeFieldInfoPtr_origPair;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeFieldInfoPtr_origColors;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeFieldInfoPtr_cursorAddress;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeFieldInfoPtr_fgcolor;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr_setfgcolor;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeFieldInfoPtr_setbgcolor;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeFieldInfoPtr_maxColors;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeFieldInfoPtr_noGetPosition;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr_keymap;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeFieldInfoPtr_rootmap;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeFieldInfoPtr_rl_startx;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeFieldInfoPtr_rl_starty;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeFieldInfoPtr_control_characters;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeFieldInfoPtr__consoleColorToAnsiCode;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeFieldInfoPtr_echobuf;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeFieldInfoPtr_echon;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeMethodInfoPtr_TryTermInfoDir_Private_Static_String_String_String_0;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeMethodInfoPtr_SearchTerminfo_Private_Static_String_String_0;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr_WriteConsole_Private_Void_String_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_IncrementX_Private_Void_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_WriteSpecialKey_Public_Void_ConsoleKeyInfo_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr_WriteSpecialKey_Public_Void_Char_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_ConsoleKeyInfo_0;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_Char_0;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorPosition_Private_Void_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_CheckWindowDimensions_Private_Void_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_get_WindowHeight_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_get_WindowWidth_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_AddToBuffer_Private_Void_Int32_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_AdjustBuffer_Private_Void_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_CreateKeyInfoFromInt_Private_ConsoleKeyInfo_Int32_Boolean_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyFromBuffer_Private_Object_Boolean_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr_ReadKeyInternal_Private_ConsoleKeyInfo_byref_Boolean_0;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeMethodInfoPtr_InputPending_Private_Boolean_0;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeMethodInfoPtr_QueueEcho_Private_Void_Char_0;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeMethodInfoPtr_Echo_Private_Void_ConsoleKeyInfo_0;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeMethodInfoPtr_EchoFlush_Private_Void_0;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_String_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_ReadUntilConditionInternal_Private_String_Boolean_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_SetCursorPosition_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_CreateKeyMap_Private_Void_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_InitKeys_Private_Void_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_AddStringMapping_Private_Void_TermInfoStrings_0;
	}
}
